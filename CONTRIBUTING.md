# Guide de Contribution

Merci de contribuer au projet SHINA Software !

## 🔄 Processus de Contribution

### 1. Créer une Branche

```bash
git checkout -b feature/ma-nouvelle-fonctionnalite
```

### 2. Faire vos Modifications

Assurez-vous de suivre les conventions de code du projet.

### 3. **IMPORTANT: Module Discipline**

⚠️ **Si vous modifiez le module Discipline**, vous **DEVEZ** vérifier vos changements contre `db.sql` :

```powershell
# Windows PowerShell
.\scripts\verify-models.ps1

# Ou Windows Command Line
.\scripts\verify-models.bat
```

**Ressources importantes :**
- 📖 [Guide de Vérification db.sql](.github/DB_VERIFICATION_GUIDE.md)
- 📋 [README Module Discipline](DISCIPLINE_MODULE_README.md)

**Tables concernées :**
- CouncilMeeting
- ConductScore
- AppliedSanction
- SanctionType
- Toutes les tables liées au module Discipline

### 4. Tester vos Modifications

Assurez-vous que :
- ✅ Le code compile sans erreurs
- ✅ Les fonctionnalités existantes ne sont pas cassées
- ✅ Vos nouvelles fonctionnalités fonctionnent correctement

### 5. Commit et Push

```bash
git add .
git commit -m "feat: description de la fonctionnalité"
git push origin feature/ma-nouvelle-fonctionnalite
```

**Format des messages de commit :**
- `feat:` nouvelle fonctionnalité
- `fix:` correction de bug
- `refactor:` refactorisation sans changement de fonctionnalité
- `docs:` mise à jour de documentation
- `style:` formatage, point-virgules manquants, etc.
- `test:` ajout de tests
- `chore:` maintenance

### 6. Créer une Pull Request

1. Allez sur GitHub et créez une Pull Request
2. **Remplissez le template de PR** (automatique)
3. ✅ **Cochez "Vérifié avec db.sql"** si vous avez modifié le module Discipline
4. Décrivez vos changements
5. Attendez la review

## 📋 Checklist Avant PR

- [ ] Le code compile sans erreurs
- [ ] Les fonctionnalités existantes fonctionnent toujours
- [ ] J'ai testé mes changements
- [ ] J'ai ajouté des commentaires si nécessaire
- [ ] **[Module Discipline uniquement]** J'ai vérifié avec db.sql
- [ ] **[Module Discipline uniquement]** J'ai exécuté `verify-models.ps1`
- [ ] Le message de commit suit le format demandé

## 🔍 Review Process

1. Un workflow automatique vérifie votre PR
2. Si vous modifiez le module Discipline, un rappel sera posté
3. Un reviewer vérifiera votre code
4. Des ajustements pourront être demandés
5. Une fois approuvé, votre PR sera mergée

## 🛠️ Environnement de Développement

- **Framework:** .NET Framework 4.7.2
- **IDE recommandé:** Visual Studio 2019 ou supérieur
- **Base de données:** MySQL/MariaDB
- **Structure de référence:** `db.sql` (pour le module Discipline)

## 📖 Documentation Importante

- [Guide de Vérification db.sql](.github/DB_VERIFICATION_GUIDE.md) - **À LIRE** pour le module Discipline
- [README Module Discipline](DISCIPLINE_MODULE_README.md) - Vue d'ensemble du module
- [Template de PR](.github/PULL_REQUEST_TEMPLATE.md) - Checklist automatique

## ❓ Questions ?

Si vous avez des questions :
1. Consultez la documentation ci-dessus
2. Regardez les PRs récentes pour des exemples
3. Contactez l'équipe de développement

## 🎯 Bonnes Pratiques

### Code C#

```csharp
// ✅ Bon
public class CouncilMeeting
{
    [Required]
    public int CouncilMeetingID { get; set; }
    
    [Required]
    [StringLength(200)]
    public string MeetingTitle { get; set; }
}

// ❌ Éviter
public class Meeting  // Nom pas clair
{
    public int id { get; set; }  // Pas le bon nom selon db.sql
    public string title { get; set; }  // Pas le bon nom
}
```

### Vérification db.sql

```csharp
// Toujours vérifier que vos propriétés correspondent EXACTEMENT à db.sql

// 1. Ouvrir db.sql
// 2. Chercher CREATE TABLE pour votre table
// 3. Vérifier chaque colonne :
//    - Nom exact
//    - Type compatible
//    - Contraintes (NOT NULL, etc.)
// 4. Ajouter les attributs C# appropriés ([Required], [StringLength], etc.)
```

## 🚫 Ce qu'il ne faut PAS faire

- ❌ Modifier des modèles du module Discipline sans consulter db.sql
- ❌ Ignorer les avertissements du workflow CI
- ❌ Ne pas cocher "Vérifié avec db.sql" dans le template de PR
- ❌ Créer des tables/colonnes qui ne sont pas dans db.sql
- ❌ Utiliser des noms de colonnes différents de db.sql

## 🎉 Merci !

Votre contribution est précieuse. En suivant ces guidelines, vous nous aidez à maintenir un code de qualité et cohérent.

---

**Dernière mise à jour:** Janvier 2026
