# Generate HTML sitemaps from sitemap.xml

# print working directory
Get-Location

Get-ChildItem -Path "." -Name

Set-Location -Path .\_site

Get-Location

Get-ChildItem -Path "." -Name

# Create the HTML files with the given titles
@('en', 'no', 'sv', 'da', 'nl', 'de') | ForEach-Object {
    $languageCode = $_
    $fileName = "learn-$languageCode.html"
    "<title>Learn $languageCode</title>" | Set-Content -Path $fileName
}

# Read the XML file, select lines with 'loc' and '/learn/', filter by language and modify the content, then append it to the corresponding HTML files
$regex = '<loc>([^<]*)</loc>'
$sitemapContent = Get-Content -Path .\sitemap.xml -Raw

@('no', 'en') | ForEach-Object {
    $languageCode = $_
    $fileName = "learn-$languageCode.html"

    $replacedContent = ([regex]::Matches($sitemapContent, $regex) | Where-Object {$_.Value -like "*/learn/*/$languageCode/*"}).Value -replace $regex, '<a href="$1">$1</a><br>'
    Add-Content -Path $fileName -Value $replacedContent
}

Get-Location

#Get-ChildItem -Path .\learn*.html -Name

Set-Location -Path ..
