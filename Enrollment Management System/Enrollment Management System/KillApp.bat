@echo off
REM Quick Kill Script for Enrollment Management System
echo Terminating Enrollment Management System processes...
taskkill /F /IM "Enrollment Management System.exe" 2>nul
if %errorlevel% equ 0 (
    echo ? Process terminated successfully
) else (
    echo ? No process found to terminate
)
timeout /t 2 /nobreak > nul