# 📋 Quick Reference - Vérification db.sql

## 🚀 TL;DR

**db.sql = Source de Vérité pour le Module Discipline**

Avant chaque PR touchant au module Discipline :
```powershell
.\scripts\verify-models.ps1
```
✅ Cocher "Vérifié avec db.sql" dans la PR

---

## 📖 Documentation

| Document | Contenu |
|----------|---------|
| [DB_VERIFICATION_GUIDE.md](.github/DB_VERIFICATION_GUIDE.md) | Guide complet de vérification |
| [DISCIPLINE_MODULE_README.md](DISCIPLINE_MODULE_README.md) | Vue d'ensemble du module |
| [DISCIPLINE_MODULE_STATUS.md](DISCIPLINE_MODULE_STATUS.md) | État actuel et technique |
| [CONTRIBUTING.md](CONTRIBUTING.md) | Guide de contribution |

---

## 🔧 Outils

| Outil | Commande | Usage |
|-------|----------|-------|
| Script PowerShell | `.\scripts\verify-models.ps1` | Vérification automatique |
| Script Batch | `.\scripts\verify-models.bat` | Alternative Windows |
| Workflow CI | Automatique sur PR | Rappel automatique |

---

## ✅ Checklist PR Module Discipline

Avant de créer votre PR :

- [ ] Consulté db.sql
- [ ] Vérifié noms de colonnes exacts
- [ ] Vérifié types de données
- [ ] Vérifié contraintes (NOT NULL, etc.)
- [ ] Exécuté verify-models.ps1
- [ ] **Coché "Vérifié avec db.sql" dans le template**

---

## 📊 Tables Concernées

Tables du module Discipline (Conduite/Sanctions) :
- `CouncilMeeting` - Réunions du conseil
- `ConductScore` - Notes de conduite
- `AppliedSanction` - Sanctions appliquées
- `SanctionType` - Types de sanctions

⚠️ Ne pas confondre avec `discipline` et `subdiscipline` (matières académiques)

---

## 🎯 Correspondance Types

| SQL | C# | Attribut |
|-----|-----|----------|
| `INT NOT NULL` | `int` | `[Required]` |
| `VARCHAR(150)` | `string` | `[StringLength(150)]` |
| `DATE` | `DateTime` | - |
| `DECIMAL(10,2)` | `decimal` | - |

---

## ❌ Erreurs Courantes

1. ❌ Nom de propriété ≠ nom de colonne
2. ❌ Type C# incompatible avec type SQL
3. ❌ Propriété manquante
4. ❌ Contrainte NOT NULL sans [Required]
5. ❌ Table créée sans être dans db.sql

---

## ✅ Workflow Simplifié

```
1. Modifier/Créer table dans db.sql
     ↓
2. Créer/Modifier modèle C#
     ↓
3. Exécuter verify-models.ps1
     ↓
4. Créer PR + cocher checklist
     ↓
5. CI vérifie automatiquement
     ↓
6. Review & Merge
```

---

## 📞 Support

1. Consultez la documentation
2. Vérifiez les PRs récentes
3. Contactez l'équipe dev

---

**Version:** 1.0  
**Date:** Janvier 2026
