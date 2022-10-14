param ($name, $sinceWhen, $basedir)

$sourceFolderName = "user-guide/en/"

Write-Output "basedir=$basedir"
Set-Location $basedir

$log = &{ git log --since="$sinceWhen" --name-only }
$changes = @($log) -like "user-guide/en/a*" | Select-Object -unique | Where-Object { Test-Path -Path $_ -PathType Leaf}
Write-Output "Changes"
mkdir en -Force
foreach ($itemToCopy in $changes)
{
  if( Test-Path -Path $itemToCopy )
  {
    $targetPathAndFile =  $itemToCopy.Replace( $sourceFolderName , $targetFolderName )
    $targetfolder = Split-Path $targetPathAndFile -Parent

    if( Test-Path $itemToCopy )
    {
      # If destination folder doesn't exist
      if (!(Test-Path $targetfolder -PathType Container)) {
          # Create destination folder
          New-Item -Path $targetfolder -ItemType Directory -Force | Out-Null
      }

      Copy-Item -Path $itemToCopy -Destination $targetPathAndFile 
      Write-Output $itemToCopy
    }
  }
}
Write-Output "-----"

Write-Output "Creating archive '$name'"
Compress-Archive -DestinationPath "translate-$name-en-changes.zip" -Path "en"
Get-ChildItem *.zip
Remove-Item en -Recurse -Force 
#
Write-Output "Copying EN to languages folders"
$langs = @( 'no', 'de', 'sv' )
foreach ($lang in $langs)
{
  Write-Output "Copying en to $lang"
  $targetFolderName = "user-guide/$lang/"
  $targetLanguage = "language: $lang"
  foreach ($itemToCopy in $changes)
  {
    $targetPathAndFile =  $itemToCopy.Replace( $sourceFolderName , $targetFolderName )
    $targetfolder = Split-Path $targetPathAndFile -Parent

    if( Test-Path $itemToCopy )
    {
      # If destination folder doesn't exist
      if (!(Test-Path $targetfolder -PathType Container)) {
          #Create destination folder
          New-Item -Path $targetfolder -ItemType Directory -Force | Out-Null
      }

      Copy-Item -Path $itemToCopy -Destination $targetPathAndFile 
      if( $itemToCopy -like "*.md")
      {
        Write-Output "$itemToCopy --> $targetPathAndFile"
        # Update language code
        $content = Get-Content -path $targetPathAndFile -raw # get as single string
        # (?m) = regex mode select multiline line matching
        $newcontent = $content -replace "(?ms)^language: *en *", $targetLanguage
        Set-Content  -path $targetPathAndFile $newcontent
      }
    }
  }
}
Write-Output "Done copying files"
