param ($version, $sourceDir)

Write-Host "Nuget version: $version"
Write-Host "Source folder: $sourceDir"

$template = Get-Content "$sourceDir\docfx-metatemplate.json"
Write-Host "Template: $template"

Write-Host "Replacing version info in template..."
$templateString = $template.Replace("#version#", $version)

#Write-Host "Fixing slashes in template..."
#$templateString = $templateString.Replace("\", "/")

Write-Host "Writing to disk..."
Set-Content -Path "$sourceDir\docfx-metadata.json" -Value $templateString

Write-Host "Template:\r\n $templateString"