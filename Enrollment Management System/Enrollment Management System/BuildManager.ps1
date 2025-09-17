# Advanced Build Manager for Enrollment Management System
param(
    [switch]$Clean,
    [switch]$Force,
    [switch]$Verbose
)

function Write-ColorText($Text, $Color = "White") {
    Write-Host $Text -ForegroundColor $Color
}

function Kill-AppProcesses {
    Write-ColorText "?? Checking for running instances..." "Yellow"
    
    $processes = Get-Process -Name "*Enrollment Management*" -ErrorAction SilentlyContinue
    if ($processes) {
        Write-ColorText "??  Found $($processes.Count) running instance(s). Terminating..." "Red"
        $processes | ForEach-Object {
            Write-ColorText "   Killing PID: $($_.Id)" "Gray"
            Stop-Process -Id $_.Id -Force -ErrorAction SilentlyContinue
        }
        Start-Sleep -Seconds 2
        Write-ColorText "? All instances terminated" "Green"
    } else {
        Write-ColorText "? No running instances found" "Green"
    }
}

function Remove-LockedFiles {
    Write-ColorText "?? Removing potentially locked files..." "Yellow"
    
    $filesToRemove = @(
        "bin\Debug\net8.0-windows\Enrollment Management System.exe",
        "bin\Debug\net8.0-windows\Enrollment Management System.dll",
        "bin\Debug\net8.0-windows\Enrollment Management System.pdb",
        "obj\Debug\net8.0-windows\apphost.exe",
        "obj\Debug\net8.0-windows\Enrollment Management System.exe",
        "obj\Debug\net8.0-windows\Enrollment Management System.dll"
    )
    
    foreach ($file in $filesToRemove) {
        if (Test-Path $file) {
            try {
                Remove-Item $file -Force -ErrorAction Stop
                Write-ColorText "   ? Removed: $file" "Gray"
            } catch {
                Write-ColorText "   ??  Could not remove: $file" "Yellow"
            }
        }
    }
}

function Clean-Solution {
    Write-ColorText "?? Cleaning solution..." "Yellow"
    
    # Clean with dotnet
    & dotnet clean --configuration Debug --verbosity quiet
    & dotnet clean --configuration Release --verbosity quiet
    
    # Remove directories
    $dirsToRemove = @("bin", "obj")
    foreach ($dir in $dirsToRemove) {
        if (Test-Path $dir) {
            Remove-Item $dir -Recurse -Force -ErrorAction SilentlyContinue
            Write-ColorText "   ? Removed: $dir" "Gray"
        }
    }
}

function Build-Solution {
    Write-ColorText "?? Building solution..." "Yellow"
    
    # Restore packages first
    Write-ColorText "   ?? Restoring packages..." "Gray"
    & dotnet restore --verbosity quiet
    
    # Build
    Write-ColorText "   ?? Compiling..." "Gray"
    $verbosityLevel = if ($Verbose) { "normal" } else { "minimal" }
    & dotnet build --configuration Debug --no-restore --verbosity $verbosityLevel
    
    if ($LASTEXITCODE -eq 0) {
        Write-ColorText "? BUILD SUCCESSFUL!" "Green"
        return $true
    } else {
        Write-ColorText "? BUILD FAILED!" "Red"
        return $false
    }
}

# Main execution
Write-ColorText "========================================" "Cyan"
Write-ColorText " ENROLLMENT MANAGEMENT SYSTEM BUILDER  " "Cyan"
Write-ColorText "========================================" "Cyan"
Write-Host ""

try {
    # Always kill processes first
    Kill-AppProcesses
    
    # Remove locked files
    Remove-LockedFiles
    
    # Clean if requested
    if ($Clean -or $Force) {
        Clean-Solution
    }
    
    # Build
    $buildSuccess = Build-Solution
    
    if ($buildSuccess) {
        Write-Host ""
        Write-ColorText "?? All operations completed successfully!" "Green"
        Write-ColorText "   Ready to run: bin\Debug\net8.0-windows\Enrollment Management System.exe" "Gray"
    } else {
        Write-Host ""
        Write-ColorText "? Build failed. Check the output above for errors." "Red"
        exit 1
    }
    
} catch {
    Write-ColorText "? Unexpected error: $($_.Exception.Message)" "Red"
    exit 1
}

Write-Host ""
Write-ColorText "Press any key to continue..." "Gray"
$null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")