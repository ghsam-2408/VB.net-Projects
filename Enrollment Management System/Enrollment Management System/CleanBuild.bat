@echo off
echo ================================
echo  CLEAN BUILD FOR ENROLLMENT SYSTEM
echo ================================

echo.
echo Step 1: Killing any running instances...
taskkill /F /IM "Enrollment Management System.exe" 2>nul
taskkill /F /IM "dotnet.exe" 2>nul
taskkill /F /IM "MSBuild.exe" 2>nul
echo ? All processes terminated

echo.
echo Step 2: Cleaning solution...
dotnet clean --configuration Debug
dotnet clean --configuration Release

echo.
echo Step 3: Removing bin and obj folders...
if exist "bin" rmdir /s /q "bin"
if exist "obj" rmdir /s /q "obj"
echo ? Build folders removed

echo.
echo Step 4: Restoring packages...
dotnet restore

echo.
echo Step 5: Building solution...
dotnet build --configuration Debug --no-restore

if %errorlevel% equ 0 (
    echo.
    echo ================================
    echo ? CLEAN BUILD COMPLETED SUCCESSFULLY!
    echo ================================
) else (
    echo.
    echo ================================
    echo ? CLEAN BUILD FAILED!
    echo ================================
)

echo.
pause