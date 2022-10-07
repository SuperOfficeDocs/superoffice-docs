param ($name, $sinceWhen)

Write-Output "Current loc"
Get-Location

$log = &{ git log --since="$sinceWhen" --name-only }
$changes = @($log) -match "user-guide/en/a*" | Select-Object -unique
Compress-Archive -DestinationPath "translate-$name-en-changes.zip" -Path $changes
Get-Location
Get-ChildItem *.zip
Write-Output "Changes"
Write-Output $changes
#
$langs = @( 'no', 'de', 'sv' )
$sourceFolderName = "user-guide/en/"
foreach ($lang in $langs)
{
  $targetFolderName = "user-guide/$lang/"
  $targetLanguage = "language: $lang"
  foreach ($itemToCopy in $changes)
  {
      $targetPathAndFile =  $itemToCopy.Replace( $sourceFolderName , $targetFolderName )
      $targetfolder = Split-Path $targetPathAndFile -Parent

      # If destination folder doesn't exist
      if (!(Test-Path $targetfolder -PathType Container)) {
          #Create destination folder
          New-Item -Path $targetfolder -ItemType Directory -Force | Out-Null
      }

      Copy-Item -Path $itemToCopy -Destination $targetPathAndFile 
      if( $itemToCopy -like "*.md")
      {
        echo "$itemToCopy --> $targetPathAndFile"
        # Update language code
        $content = Get-Content -path $targetPathAndFile -raw # get as single string
        # (?m) = regex mode select multiline line matching
        $newcontent = $content -replace "(?ms)^language: *en *", $targetLanguage
        Set-Content  -path $targetPathAndFile $newcontent
      }
  }
}
echo "Done"
