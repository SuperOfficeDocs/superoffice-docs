param ($version, $source, $pkgDest)

Write-Host "Nuget version: $version"
Write-Host "Package source folder: $source"
Write-Host "Package destination folder: $pkgDest"

cmd /c dir $source

$packages = @(
    "SuperOffice.ContinuousDatabase",
    "SuperOffice.NetServer.Core",
    "SuperOffice.NetServer.Services",
    "SuperOffice.Crm.Web",
    "SuperOffice.Crm.Online.IntegrationServices",
    "SuperOffice.WebApi")

# loop over all packages and unpack them

For ($i=0; $i -lt $packages.Length; $i++) {

    $packageName = $packages[$i]
    $webApiPackageDir = Get-ChildItem -Path $source -Recurse -Include "$packageName.$version*" | Select-Object -First 1 -ExpandProperty DirectoryName
    Write-Host Attempting to install $packageName from $webApiPackageDir
    nuget.exe install $packageName -Version $version -Source $webApiPackageDir -OutputDirectory $pkgDest -DependencyVersion Ignore -NoCache -NonInteractive -Verbosity detailed  
}

#Write-Host "Executing: nuget.exe install $packageName -Version $version -Source $source -OutputDirectory $source -DependencyVersion Ignore"
#nuget.exe install $packageName -Version $version -Source $source -OutputDirectory $source -DependencyVersion Ignore

cmd /c dir $source