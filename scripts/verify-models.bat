@echo off
REM verify-models.bat
REM Script de vérification des modèles C# par rapport à db.sql (Windows)
REM 
REM Usage: scripts\verify-models.bat

echo ========================================
echo Vérification des Modèles avec db.sql
echo ========================================
echo.

REM Vérifier que db.sql existe
if not exist "db.sql" (
    echo ERREUR: db.sql introuvable à la racine du projet
    echo Assurez-vous d'exécuter ce script depuis la racine du projet.
    pause
    exit /b 1
)

echo db.sql trouvé
echo.

echo Ce script lance PowerShell pour effectuer la vérification.
echo Si vous préférez utiliser PowerShell directement:
echo   .\scripts\verify-models.ps1
echo.

REM Lancer le script PowerShell
powershell -ExecutionPolicy Bypass -File ".\scripts\verify-models.ps1"

if errorlevel 1 (
    echo.
    echo Une erreur s'est produite lors de la vérification.
    pause
    exit /b 1
)

pause
