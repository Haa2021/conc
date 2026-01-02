# verify-models.ps1
# Script de vérification des modèles C# par rapport à db.sql
# 
# Usage: .\scripts\verify-models.ps1

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Vérification des Modèles avec db.sql" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# Vérifier que db.sql existe
$dbSqlPath = Join-Path $PSScriptRoot "..\db.sql"
if (-not (Test-Path $dbSqlPath)) {
    Write-Host "❌ ERREUR: db.sql introuvable à la racine du projet" -ForegroundColor Red
    exit 1
}

Write-Host "✅ db.sql trouvé: $dbSqlPath" -ForegroundColor Green
Write-Host ""

# Tables du module Discipline à vérifier
$disciplineTables = @(
    "CouncilMeeting",
    "ConductScore", 
    "AppliedSanction",
    "SanctionType"
)

Write-Host "📋 Tables du module Discipline à vérifier:" -ForegroundColor Yellow
foreach ($table in $disciplineTables) {
    Write-Host "   - $table" -ForegroundColor White
}
Write-Host ""

# Lire le contenu de db.sql
$dbSqlContent = Get-Content $dbSqlPath -Raw

# Vérifier chaque table
$issuesFound = $false
foreach ($table in $disciplineTables) {
    Write-Host "🔍 Vérification de $table..." -ForegroundColor Cyan
    
    # Rechercher la définition de la table dans db.sql
    # Support MySQL backtick quoting and case-insensitive matching
    $pattern = "CREATE TABLE\s+\`?$table\`?\s*\("
    if ($dbSqlContent -match $pattern) {
        Write-Host "   ✅ Définition trouvée dans db.sql" -ForegroundColor Green
        
        # Extraire la section de création de table
        $startIndex = $dbSqlContent.IndexOf($matches[0])
        $endIndex = $dbSqlContent.IndexOf(";", $startIndex)
        if ($endIndex -gt $startIndex) {
            $tableDefinition = $dbSqlContent.Substring($startIndex, $endIndex - $startIndex)
            
            # Extraire les colonnes
            $lines = $tableDefinition -split "`n"
            $columns = @()
            foreach ($line in $lines) {
                # Match columns with backticks, optional length/precision, and modifiers
                if ($line -match "^\s*\`?(\w+)\`?\s+(INT|VARCHAR|DATE|DATETIME|DECIMAL|DOUBLE|TEXT|CHAR|TINYINT|SMALLINT|BIGINT|FLOAT)(\([^\)]+\))?\s*(UNSIGNED)?") {
                    $columnName = $matches[1]
                    $columnType = $matches[2]
                    $columnLength = $matches[3]
                    $columnModifier = $matches[4]
                    $fullType = "$columnType$columnLength $columnModifier".Trim()
                    $columns += @{Name=$columnName; Type=$fullType}
                }
            }
            
            if ($columns.Count -gt 0) {
                Write-Host "   📊 Colonnes définies ($($columns.Count)):" -ForegroundColor White
                foreach ($col in $columns) {
                    Write-Host "      - $($col.Name): $($col.Type)" -ForegroundColor Gray
                }
            }
        }
        
        # Chercher le modèle C# correspondant avec plusieurs stratégies
        $searchPath = Join-Path $PSScriptRoot "..\SHINASoftware"
        $modelFiles = @()
        
        # Stratégie 1: Nom exact
        $modelFiles += Get-ChildItem -Path $searchPath -Filter "$table.cs" -Recurse -ErrorAction SilentlyContinue
        
        # Stratégie 2: Avec "Model" suffix
        $modelFiles += Get-ChildItem -Path $searchPath -Filter "$($table)Model.cs" -Recurse -ErrorAction SilentlyContinue
        
        # Stratégie 3: Wildcard (peut avoir faux positifs, mais utile)
        $wildcardFiles = Get-ChildItem -Path $searchPath -Filter "*$table*.cs" -Recurse -ErrorAction SilentlyContinue
        foreach ($file in $wildcardFiles) {
            if ($modelFiles -notcontains $file) {
                $modelFiles += $file
            }
        }
        
        if ($modelFiles.Count -eq 0) {
            Write-Host "   ⚠️  ATTENTION: Aucun fichier modèle C# trouvé pour $table" -ForegroundColor Yellow
            Write-Host "      Vérifiez que le modèle existe et correspond à la table db.sql" -ForegroundColor Yellow
            $issuesFound = $true
        } else {
            Write-Host "   ℹ️  Fichier(s) modèle trouvé(s):" -ForegroundColor White
            foreach ($file in $modelFiles) {
                Write-Host "      - $($file.FullName)" -ForegroundColor Gray
            }
            Write-Host "   ⚠️  Vérifiez manuellement que les propriétés correspondent aux colonnes ci-dessus" -ForegroundColor Yellow
        }
    } else {
        Write-Host "   ⚠️  ATTENTION: Table '$table' non trouvée dans db.sql" -ForegroundColor Yellow
        Write-Host "      Cette table existe-t-elle dans la base ou est-elle nommée différemment?" -ForegroundColor Yellow
        $issuesFound = $true
    }
    Write-Host ""
}

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Résumé de la Vérification" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan

if ($issuesFound) {
    Write-Host ""
    Write-Host "⚠️  Des problèmes potentiels ont été détectés" -ForegroundColor Yellow
    Write-Host ""
    Write-Host "Actions recommandées:" -ForegroundColor White
    Write-Host "1. Vérifiez manuellement chaque table dans db.sql" -ForegroundColor White
    Write-Host "2. Comparez avec les modèles C# correspondants" -ForegroundColor White
    Write-Host "3. Assurez-vous que les noms de colonnes, types et contraintes correspondent" -ForegroundColor White
    Write-Host "4. Consultez .github/DB_VERIFICATION_GUIDE.md pour plus de détails" -ForegroundColor White
} else {
    Write-Host ""
    Write-Host "✅ Vérification de base terminée" -ForegroundColor Green
    Write-Host "ℹ️  N'oubliez pas de vérifier manuellement:" -ForegroundColor White
    Write-Host "   - Les types de données C# correspondent aux types SQL" -ForegroundColor White
    Write-Host "   - Les contraintes (NOT NULL, etc.) sont respectées" -ForegroundColor White
    Write-Host "   - Les relations et foreign keys sont correctes" -ForegroundColor White
}

Write-Host ""
Write-Host "📖 Documentation complète: .github/DB_VERIFICATION_GUIDE.md" -ForegroundColor Cyan
Write-Host ""
