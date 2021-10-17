param (
    [string]$versionSuffix = "",
    [string]$targetFrameworks = "netcoreapp3.1"
 )

Write-Host "Running with versionSuffix '$($versionSuffix)'..."

$tempNupkgFolder = './nupkgs'

Write-Host "Checking if temp nupkgs folder '$($tempNupkgFolder)' exists..."

$tempNupkgFolderExists = Test-Path $tempNupkgFolder -PathType Container

if(!($tempNupkgFolderExists)) 
{
    New-Item $tempNupkgFolder -ItemType Directory
}

Write-Host "Deleting temporary nupkgs..."
Get-ChildItem -Path $tempNupkgFolder -Include *.nupkg -File -Recurse | ForEach-Object { $_.Delete()}

./pack-all-configurations.ps1 -targetFrameworks $targetFrameworks -versionSuffix $versionSuffix

Write-Host "Pack Succeeded  :)" -ForegroundColor Green