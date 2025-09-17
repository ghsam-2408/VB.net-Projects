@echo off
echo ================================
echo  BUILD HELPER FOR ENROLLMENT SYSTEM
echo ================================

echo.
echo Step 1: Killing any running instances...
taskkill /F /IM "Enrollment Management System.exe" 2>nul
if %errorlevel% equ 0 (
    echo ? Running instances terminated successfully
    timeout /t 2 /nobreak > nul
) else (
    echo ? No running instances found
)

echo.
echo Step 2: Cleaning previous build...
if exist "bin\Debug\net8.0-windows\Enrollment Management System.exe" (
    del /F /Q "bin\Debug\net8.0-windows\Enrollment Management System.exe" 2>nul
    echo ? Previous executable deleted
)

if exist "obj\Debug\net8.0-windows\apphost.exe" (
    del /F /Q "obj\Debug\net8.0-windows\apphost.exe" 2>nul
    echo ? Previous apphost deleted
)

echo.
echo Step 3: Building project...
dotnet build --configuration Debug --verbosity minimal

if %errorlevel% equ 0 (
    echo.
    echo ================================
    echo ? BUILD COMPLETED SUCCESSFULLY!
    echo ================================
) else (
    echo.
    echo ================================
    echo ? BUILD FAILED!
    echo ================================
    pause
    exit /b 1
)

echo.
echo Press any key to continue...
pause >nul