# Guide de Vérification avec db.sql

## Décision : db.sql comme Source de Vérité

**Date de décision:** Janvier 2026  
**Contexte:** .NET Framework 4.7.2, Module Discipline

### Principe Fondamental

Le fichier `db.sql` à la racine du projet est la **source de vérité unique** pour la structure des tables du module Discipline. Toute modification côté code doit être vérifiée et alignée avec ce fichier avant publication.

## Pourquoi cette Décision?

Le module Discipline présentait des écarts entre le code C# et la base de données :
- Modèles C# simplifiés ne reflétant pas toutes les colonnes de la base
- Enums dispersés dans différents fichiers
- Utilisation de stored procedures (ex: ConductScore) sans documentation cohérente
- Incohérences dans les noms de colonnes, types et contraintes

Cette décision vise à :
1. ✅ Éviter de nouveaux écarts entre code et base de données
2. ✅ Faciliter les corrections planifiées (SanctionTypeService, CouncilMeetingService, ConductScoreService)
3. ✅ Assurer la cohérence lors du développement futur
4. ✅ Simplifier la maintenance et le debugging

## Workflow de Vérification

### Avant Toute Modification de Model ou Table

1. **Consulter db.sql**
   ```bash
   # Ouvrir le fichier db.sql
   code db.sql
   # ou
   notepad db.sql
   ```

2. **Vérifier les Éléments Suivants:**
   - ✅ Noms de colonnes exacts
   - ✅ Types de données (INT, VARCHAR, DATE, etc.)
   - ✅ Contraintes (NOT NULL, UNIQUE, DEFAULT)
   - ✅ Clés primaires et étrangères
   - ✅ Index définis
   - ✅ Relations entre tables

3. **Aligner votre Code C#**
   ```csharp
   // ❌ INCORRECT - Ne correspond pas à db.sql
   public class CouncilMeeting
   {
       public int Id { get; set; }
       public string Name { get; set; }
   }

   // ✅ CORRECT - Correspond à db.sql
   public class CouncilMeeting
   {
       public int CouncilMeetingID { get; set; }  // Nom exact de db.sql
       public string MeetingTitle { get; set; }   // Nom exact de db.sql
       public DateTime MeetingDate { get; set; }  // Type exact de db.sql
       // ... autres champs selon db.sql
   }
   ```

### Tables Concernées du Module Discipline

Les tables suivantes doivent être particulièrement vérifiées :
- `CouncilMeeting` (Réunions du conseil de discipline)
- `ConductScore` (Notes de conduite)
- `AppliedSanction` (Sanctions appliquées)
- `SanctionType` (Types de sanctions)
- Autres tables liées au module Discipline

### Vérification des Triggers et Procédures Stockées

Si vous ajoutez ou modifiez des triggers ou stored procedures :

1. **Documenter dans db.sql**
   ```sql
   -- Ajoutez vos triggers/procédures dans db.sql
   DELIMITER $$
   CREATE TRIGGER after_sanction_insert
   AFTER INSERT ON AppliedSanction
   FOR EACH ROW
   BEGIN
       -- Logique du trigger
   END$$
   DELIMITER ;
   ```

2. **Documenter dans le Code**
   ```csharp
   // Service ou Repository
   // NOTE: Cette opération utilise le trigger 'after_sanction_insert'
   // défini dans db.sql (ligne XXX)
   public void ApplySanction(Sanction sanction)
   {
       // ...
   }
   ```

## Checklist Pull Request

Lors de la création d'une PR qui modifie le module Discipline, vous **DEVEZ** cocher :

- [ ] **Vérifié avec db.sql**

Cette vérification est **OBLIGATOIRE** pour :
- Création ou modification de Models
- Modifications de Services/Repositories accédant à la base
- Modifications de Controllers manipulant des données
- Ajout de DTOs représentant des données de la base
- Migrations de base de données
- Ajout/modification de triggers ou stored procedures

## Outils de Vérification

### Script de Vérification Manuel

Un script PowerShell `scripts/verify-models.ps1` est disponible pour vous aider à identifier les divergences courantes.

```powershell
# Exécuter depuis la racine du projet
.\scripts\verify-models.ps1
```

### Vérification Visuelle

Comparez manuellement :
1. Ouvrez `db.sql` et trouvez la table concernée
2. Ouvrez votre fichier Model C#
3. Vérifiez ligne par ligne que chaque propriété correspond

## Exemples Courants d'Erreurs

### ❌ Erreur 1: Nom de Colonne Différent
```csharp
// db.sql: CouncilMeetingID int(11)
public int Id { get; set; }  // ❌ Mauvais nom
```

### ❌ Erreur 2: Type de Données Incompatible
```csharp
// db.sql: MeetingDate DATE
public string MeetingDate { get; set; }  // ❌ Mauvais type
```

### ❌ Erreur 3: Propriété Manquante
```csharp
// db.sql a: CouncilMeetingID, MeetingTitle, MeetingDate, CreatedBy
public class CouncilMeeting
{
    public int CouncilMeetingID { get; set; }
    public string MeetingTitle { get; set; }
    // ❌ Manque MeetingDate et CreatedBy
}
```

### ❌ Erreur 4: Contrainte Ignorée
```csharp
// db.sql: MeetingTitle VARCHAR(200) NOT NULL
public string MeetingTitle { get; set; }  // ❌ Devrait être [Required]
```

## Corrections Planifiées

Les services suivants sont en cours de refactorisation pour conformité avec db.sql :
- [ ] SanctionTypeService
- [ ] CouncilMeetingService
- [ ] ConductScoreService (migration depuis stored procedures)

## Support

Si vous avez des questions sur la vérification avec db.sql :
1. Consultez ce guide
2. Vérifiez les PRs récentes pour des exemples
3. Contactez l'équipe de développement

---

**Dernière mise à jour:** Janvier 2026  
**Responsable:** Équipe Développement
