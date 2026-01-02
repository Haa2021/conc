# État Actuel du Module Discipline - Documentation Technique

## ⚠️ Note Importante : Deux Contextes "Discipline"

Le projet utilise le terme "Discipline" dans deux contextes différents :

### 1. **Discipline Académique** (Matières/Sujets) - ✅ EXISTE
Tables actuelles dans db.sql :
- `discipline` - Matières académiques (ex: Math, Français)
- `subdiscipline` - Sous-matières

### 2. **Module Discipline** (Conduite/Sanctions) - 🔄 EN DÉVELOPPEMENT
Tables planifiées pour la gestion de la conduite des élèves :
- `CouncilMeeting` - Réunions du conseil de discipline
- `ConductScore` - Notes de conduite
- `AppliedSanction` - Sanctions appliquées aux élèves
- `SanctionType` - Types de sanctions disponibles

**Ce guide et ces outils concernent le Module Discipline (Conduite/Sanctions).**

## 📊 État des Lieux

### Tables Existantes dans db.sql

Actuellement, db.sql contient la structure complète de l'application SHINA Software, incluant :
- Gestion académique (students, enrollment, classes, etc.)
- Gestion du personnel (employees, payroll, etc.)
- Gestion financière (payments, expenses, income, etc.)
- **Disciplines académiques** (discipline, subdiscipline)

### Tables du Module Discipline (Conduite) - À Créer

Les tables suivantes sont mentionnées dans le problème mais **n'existent pas encore** dans db.sql :
- `CouncilMeeting`
- `ConductScore`
- `AppliedSanction`
- `SanctionType`

## 🎯 Objectif de Cette Infrastructure

Cette infrastructure (documentation, scripts, workflows) a été mise en place pour :

1. **Établir le Processus** : Quand les tables du module Discipline seront créées, le processus de vérification sera déjà en place
2. **Prévenir les Écarts** : Éviter les incohérences entre code et base de données dès le départ
3. **Faciliter le Développement** : Fournir les outils et la documentation nécessaires

## 📋 Workflow pour Créer le Module Discipline

### Étape 1 : Définir la Structure dans db.sql

Avant de créer les modèles C#, **définir d'abord** les tables dans db.sql :

```sql
-- Exemple : Table SanctionType
CREATE TABLE `sanctiontype` (
  `SanctionTypeID` int(11) UNSIGNED NOT NULL AUTO_INCREMENT,
  `SanctionName` varchar(150) NOT NULL,
  `SanctionDescription` text,
  `SeverityLevel` tinyint(2) UNSIGNED NOT NULL,
  `CreatedDate` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`SanctionTypeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

### Étape 2 : Créer les Modèles C# Correspondants

```csharp
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("sanctiontype")]
public class SanctionType
{
    [Key]
    [Column("SanctionTypeID")]
    public int SanctionTypeID { get; set; }
    
    [Required]
    [StringLength(150)]
    [Column("SanctionName")]
    public string SanctionName { get; set; }
    
    [Column("SanctionDescription")]
    public string SanctionDescription { get; set; }
    
    [Required]
    [Column("SeverityLevel")]
    public byte SeverityLevel { get; set; }
    
    [Column("CreatedDate")]
    public DateTime CreatedDate { get; set; }
}
```

### Étape 3 : Vérifier avec le Script

```powershell
.\scripts\verify-models.ps1
```

### Étape 4 : Créer la PR avec la Checklist

✅ Cocher "Vérifié avec db.sql" dans le template de PR

## 🔧 Adaptation du Script de Vérification

Le script `verify-models.ps1` est préconfiguré pour rechercher ces tables :
- CouncilMeeting
- ConductScore
- AppliedSanction
- SanctionType

**Quand vous créez une nouvelle table du module Discipline** :

1. Ajoutez-la d'abord à db.sql
2. Modifiez le script pour inclure la nouvelle table :

```powershell
# Dans verify-models.ps1, ligne ~20
$disciplineTables = @(
    "CouncilMeeting",
    "ConductScore", 
    "AppliedSanction",
    "SanctionType",
    "VotreNouvelleTable"  # <-- Ajouter ici
)
```

## 📚 Correspondance Types SQL → C#

| Type SQL | Type C# | Attribut C# |
|----------|---------|-------------|
| `INT(11) NOT NULL` | `int` | `[Required]` |
| `INT(11) UNSIGNED NOT NULL AUTO_INCREMENT` | `int` | `[Key]` |
| `VARCHAR(150) NOT NULL` | `string` | `[Required][StringLength(150)]` |
| `VARCHAR(150)` | `string` | `[StringLength(150)]` |
| `TEXT` | `string` | - |
| `DATE` | `DateTime` | - |
| `DATETIME` | `DateTime` | - |
| `DECIMAL(10,2)` | `decimal` | - |
| `DOUBLE` | `double` | - |
| `TINYINT(2) UNSIGNED` | `byte` | - |
| `CHAR(1)` | `string` ou `char` | `[StringLength(1)]` |

## 🔍 Vérification Manuelle

### Checklist de Vérification Modèle ↔ db.sql

Pour chaque modèle C# :

- [ ] Le nom de la table correspond (attribut `[Table("nom")]`)
- [ ] Chaque propriété a l'attribut `[Column("nom")]` exact
- [ ] Les types C# sont compatibles avec les types SQL
- [ ] Les contraintes NOT NULL ont l'attribut `[Required]`
- [ ] Les VARCHAR ont `[StringLength(longueur)]`
- [ ] Les clés primaires ont `[Key]`
- [ ] Les foreign keys sont définies correctement
- [ ] Les relations (1-N, N-N) correspondent

## 🚀 Services Planifiés pour Refactorisation

D'après le problème, ces services sont à créer/refactoriser :

### SanctionTypeService
```csharp
// À créer pour gérer les types de sanctions
// IMPORTANT : Vérifier avec la table sanctiontype dans db.sql
```

### CouncilMeetingService
```csharp
// À créer pour gérer les réunions du conseil de discipline
// IMPORTANT : Vérifier avec la table councilmeeting dans db.sql
```

### ConductScoreService
```csharp
// À refactoriser : actuellement utilise des stored procedures
// IMPORTANT : Migrer vers des modèles alignés avec db.sql
```

## 📝 Exemples de Scénarios

### Scénario 1 : Créer une Nouvelle Table

1. ✅ Définir CREATE TABLE dans db.sql
2. ✅ Créer le modèle C# correspondant
3. ✅ Exécuter verify-models.ps1
4. ✅ Créer le service/repository
5. ✅ Créer la PR avec "Vérifié avec db.sql" coché

### Scénario 2 : Modifier une Table Existante

1. ✅ Modifier CREATE TABLE dans db.sql
2. ✅ Mettre à jour le modèle C# correspondant
3. ✅ Exécuter verify-models.ps1
4. ✅ Mettre à jour le service/repository si nécessaire
5. ✅ Créer la PR avec "Vérifié avec db.sql" coché

### Scénario 3 : Ajouter une Stored Procedure

1. ✅ Ajouter la procédure dans db.sql
2. ✅ Documenter son utilisation dans le code C#
3. ✅ Commenter dans le service qui l'utilise
4. ✅ Créer la PR avec "Vérifié avec db.sql" coché

## 🎓 Ressources

- [Guide Complet de Vérification](.github/DB_VERIFICATION_GUIDE.md)
- [Template de PR](.github/PULL_REQUEST_TEMPLATE.md)
- [Guide de Contribution](CONTRIBUTING.md)
- [README Module Discipline](DISCIPLINE_MODULE_README.md)

## ⚡ Quick Reference

```bash
# Vérifier les modèles
.\scripts\verify-models.ps1

# Ou avec batch
.\scripts\verify-models.bat

# Consulter db.sql
code db.sql    # VS Code
notepad db.sql # Notepad
```

---

**Statut:** Infrastructure en place, tables du module à créer  
**Framework:** .NET Framework 4.7.2  
**Base de données:** MySQL/MariaDB  
**Dernière mise à jour:** Janvier 2026
