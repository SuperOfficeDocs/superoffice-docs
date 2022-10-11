param ($name, $sinceWhen, $basedir)

Write-Output "basedir=$basedir"
Set-Location $basedir

$log = &{ git log --since="$sinceWhen" --name-only }
$changes = @($log) -match "user-guide/en/a*" | Select-Object -unique | Where-Object { Test-Path $_ }
Write-Output "Changes"
Write-Output $changes
Compress-Archive -DestinationPath "translate-$name-en-changes.zip" -Path $changes
Get-ChildItem *.zip
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
