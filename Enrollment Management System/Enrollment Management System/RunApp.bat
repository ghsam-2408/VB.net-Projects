@echo off
REM Quick Run Script for Enrollment Management System
echo Starting Enrollment Management System...

REM Kill any existing instances first
call KillApp.bat

REM Wait a moment
timeout /t 1 /nobreak > nul

REM Start the application
if exist "bin\Debug\net8.0-windows\Enrollment Management System.exe" (
    start "" "bin\Debug\net8.0-windows\Enrollment Management System.exe"
    echo ? Application started
) else (
    echo ? Application not found. Please build first.
    echo Run BuildHelper.bat to build the application.
    pause
)