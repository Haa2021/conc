# SHINA Software - Système de Gestion Scolaire

Application de gestion scolaire développée avec .NET Framework 4.7.2 pour Windows.

## 🎯 À Propos

SHINA Software est une solution complète de gestion pour établissements scolaires, incluant :
- 📚 Gestion académique (élèves, classes, inscriptions)
- 👨‍🏫 Gestion du personnel (employés, salaires, présences)
- 💰 Gestion financière (paiements, dépenses, revenus)
- 📊 Rapports et statistiques

## ⚙️ Technologie

- **Framework:** .NET Framework 4.7.2
- **Interface:** Windows Forms
- **Base de données:** MySQL/MariaDB
- **Rapports:** Crystal Reports
- **IDE:** Visual Studio 2019+

## 🚀 Démarrage Rapide

### Prérequis

- Visual Studio 2019 ou supérieur
- .NET Framework 4.7.2
- MySQL/MariaDB Server
- Crystal Reports Runtime

### Installation

1. Cloner le repository
```bash
git clone https://github.com/Haa2021/conc.git
cd conc
```

2. Ouvrir la solution
```bash
SHINASoftware.sln
```

3. Restaurer les packages NuGet
4. Configurer la connexion à la base de données dans `App.config`
5. Importer le schéma de base de données depuis `db.sql`
6. Compiler et exécuter

## 📋 Module Discipline - Important !

### ⚠️ Décision Importante

**db.sql est la source de vérité** pour le module Discipline (gestion de la conduite et des sanctions).

Toute modification de modèles, services ou contrôleurs liés au module Discipline **DOIT** être vérifiée contre `db.sql`.

### Documentation Module Discipline

| Document | Description |
|----------|-------------|
| [📖 Guide de Vérification](.github/DB_VERIFICATION_GUIDE.md) | Guide complet de vérification |
| [📘 README Module](DISCIPLINE_MODULE_README.md) | Vue d'ensemble du module |
| [📄 État Technique](DISCIPLINE_MODULE_STATUS.md) | État actuel et détails techniques |
| [⚡ Quick Reference](QUICK_REFERENCE.md) | Référence rapide |

### Vérification Avant PR

```powershell
# Exécuter le script de vérification
.\scripts\verify-models.ps1

# Ou version batch
.\scripts\verify-models.bat
```

**N'oubliez pas** de cocher "Vérifié avec db.sql" dans le template de PR !

## 🤝 Contribution

Consultez [CONTRIBUTING.md](CONTRIBUTING.md) pour les guidelines de contribution.

### Workflow de Contribution

1. Créer une branche feature
2. **[Module Discipline]** Vérifier avec db.sql
3. Faire vos modifications
4. Tester localement
5. Créer une Pull Request
6. **Cocher la checklist** dans le template de PR

### Checklist PR Module Discipline

- [ ] Consulté db.sql
- [ ] Vérifié noms de colonnes
- [ ] Vérifié types de données
- [ ] Exécuté verify-models.ps1
- [ ] ✅ **Coché "Vérifié avec db.sql"**

## 📁 Structure du Projet

```
conc/
├── .github/
│   ├── workflows/
│   │   └── db-verification-reminder.yml    # CI workflow
│   ├── DB_VERIFICATION_GUIDE.md            # Guide de vérification
│   └── PULL_REQUEST_TEMPLATE.md            # Template de PR
├── SHINASoftware/
│   ├── Forms/                              # Formulaires Windows
│   ├── CR/                                 # Crystal Reports
│   ├── DS/                                 # DataSets
│   └── ...
├── scripts/
│   ├── verify-models.ps1                   # Script PowerShell
│   └── verify-models.bat                   # Script Batch
├── db.sql                                  # ⭐ Source de vérité DB
├── CONTRIBUTING.md                         # Guide de contribution
├── DISCIPLINE_MODULE_README.md             # Doc module Discipline
├── DISCIPLINE_MODULE_STATUS.md             # État technique
├── QUICK_REFERENCE.md                      # Référence rapide
└── SHINASoftware.sln                       # Solution Visual Studio
```

## 🔧 Configuration

### Base de Données

Le fichier `db.sql` contient le schéma complet de la base de données.

**Important:** Pour le module Discipline, `db.sql` est la référence absolue.

### Connection String

Modifier dans `App.config` :

```xml
<connectionStrings>
  <add name="MySQLConnection" 
       connectionString="Server=localhost;Database=sigepecdb;Uid=root;Pwd=yourpassword;" 
       providerName="MySql.Data.MySqlClient" />
</connectionStrings>
```

## 🧪 Tests

Les tests doivent couvrir :
- Fonctionnalités métier
- Accès aux données
- Validation des modèles
- **Cohérence avec db.sql** (module Discipline)

## 📊 Rapports

L'application utilise Crystal Reports pour :
- Listes d'élèves
- Bulletins de notes
- Reçus de paiement
- Listes de présence
- Fiches de paie

## 🔒 Sécurité

- Authentification utilisateur
- Gestion des rôles et permissions
- Audit des actions critiques

## 📝 Licence

[À définir]

## 👥 Équipe

[À compléter]

## 📞 Support

Pour questions ou problèmes :
1. Consultez la documentation
2. Vérifiez les issues existantes
3. Créez une nouvelle issue si nécessaire

## 🎓 Ressources Supplémentaires

### Pour Développeurs

- [Guide de Contribution](CONTRIBUTING.md)
- [Guide Vérification db.sql](.github/DB_VERIFICATION_GUIDE.md)
- [État Module Discipline](DISCIPLINE_MODULE_STATUS.md)
- [Référence Rapide](QUICK_REFERENCE.md)

### Pour le Module Discipline

- **Documentation:** [DISCIPLINE_MODULE_README.md](DISCIPLINE_MODULE_README.md)
- **Script de Vérification:** `scripts/verify-models.ps1`
- **Workflow CI:** `.github/workflows/db-verification-reminder.yml`
- **Template PR:** `.github/PULL_REQUEST_TEMPLATE.md`

## 🔄 Changelog

### Janvier 2026
- ✅ Établissement de db.sql comme source de vérité pour module Discipline
- ✅ Ajout du workflow de vérification automatique
- ✅ Documentation complète du processus
- ✅ Scripts de vérification PowerShell et Batch

---

**Version:** 1.0  
**Framework:** .NET Framework 4.7.2  
**Dernière mise à jour:** Janvier 2026
