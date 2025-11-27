# Create-Missing-Sample-Files.ps1
# This script finds missing sample request/response files referenced in API documentation
# and creates placeholder files with "No sample available" content.

# Usage: .\Create-Missing-Sample-Files.ps1 -RootPath "c:\path\to\docs\en\api\reference\restful" [-WhatIf]
# ------------------------------------------------------------------------------
# Preview what would be created (dry run)
# .\build\Create-Missing-Sample-Files.ps1 -WhatIf

# Actually create the missing files
# .\build\Create-Missing-Sample-Files.ps1

# Use a different root path
# .\build\Create-Missing-Sample-Files.ps1 -RootPath "C:\different\path\restful"

param(
    [string]$RootPath = (Join-Path $PSScriptRoot "..\docs\en\api\reference\restful"),
    [switch]$WhatIf
)

$ErrorActionPreference = "Stop"

# Statistics
$stats = @{
    FilesScanned = 0
    ReferencesFound = 0
    MissingFiles = 0
    FilesCreated = 0
    Errors = 0
}

Write-Host "Scanning for missing sample files..." -ForegroundColor Cyan
Write-Host "Root path: $RootPath" -ForegroundColor Gray
Write-Host ""

# Get all markdown files in agent and rest folders
$targetFolders = @(
    Join-Path $RootPath "agent"
    Join-Path $RootPath "rest"
)

foreach ($folder in $targetFolders) {
    if (-not (Test-Path $folder)) {
        Write-Warning "Folder not found: $folder"
        continue
    }

    Write-Host "Processing folder: $folder" -ForegroundColor Yellow
    
    # Get all .md files recursively
    $markdownFiles = Get-ChildItem -Path $folder -Filter "*.md" -Recurse -File
    
    foreach ($file in $markdownFiles) {
        $stats.FilesScanned++
        
        try {
            $content = Get-Content -Path $file.FullName -Raw
            
            # Regex pattern to find include references
            # Pattern: [!include[...](../../samples/.../.../.../filename.md)]
            $pattern = '\[!include\[.*?\]\((\.\.\/\.\.\/samples\/.*?\.md)\)\]'
            $matches = [regex]::Matches($content, $pattern)
            
            foreach ($match in $matches) {
                $stats.ReferencesFound++
                
                # Extract the relative path
                $relativePath = $match.Groups[1].Value
                
                # Resolve the full path from the current file's directory
                $fileDir = $file.Directory.FullName
                $sampleFilePath = Join-Path $fileDir $relativePath
                $sampleFilePath = [System.IO.Path]::GetFullPath($sampleFilePath)
                
                # Check if the sample file exists
                if (-not (Test-Path $sampleFilePath)) {
                    $stats.MissingFiles++
                    
                    # Display relative path for readability
                    $displayPath = $sampleFilePath.Replace($RootPath, "").TrimStart('\', '/')
                    Write-Host "  Missing: $displayPath" -ForegroundColor Red
                    
                    if ($WhatIf) {
                        Write-Host "    [WhatIf] Would create: $sampleFilePath" -ForegroundColor DarkGray
                    } else {
                        try {
                            # Create directory if it doesn't exist
                            $sampleDir = Split-Path $sampleFilePath -Parent
                            if (-not (Test-Path $sampleDir)) {
                                New-Item -Path $sampleDir -ItemType Directory -Force | Out-Null
                            }
                            
                            # Create the placeholder file
                            $placeholderContent = "No sample available"
                            Set-Content -Path $sampleFilePath -Value $placeholderContent -NoNewline
                            
                            $stats.FilesCreated++
                            Write-Host "    Created placeholder file" -ForegroundColor Green
                        } catch {
                            $stats.Errors++
                            Write-Host "    ERROR: $_" -ForegroundColor Red
                        }
                    }
                }
            }
        } catch {
            $stats.Errors++
            Write-Warning "Error processing file $($file.FullName): $_"
        }
    }
}

# Display summary
Write-Host ""
Write-Host ("=" * 60) -ForegroundColor Cyan
Write-Host "Summary" -ForegroundColor Cyan
Write-Host ("=" * 60) -ForegroundColor Cyan
Write-Host "Files scanned:        $($stats.FilesScanned)" -ForegroundColor White
Write-Host "References found:     $($stats.ReferencesFound)" -ForegroundColor White
Write-Host "Missing files:        $($stats.MissingFiles)" -ForegroundColor Yellow
if ($WhatIf) {
    Write-Host "Files to create:      $($stats.MissingFiles)" -ForegroundColor Magenta
} else {
    Write-Host "Files created:        $($stats.FilesCreated)" -ForegroundColor Green
}
if ($stats.Errors -gt 0) {
    Write-Host "Errors:               $($stats.Errors)" -ForegroundColor Red
}
Write-Host ("=" * 60) -ForegroundColor Cyan

if ($WhatIf) {
    Write-Host ""
    Write-Host "Run without -WhatIf to create the placeholder files." -ForegroundColor Yellow
}
