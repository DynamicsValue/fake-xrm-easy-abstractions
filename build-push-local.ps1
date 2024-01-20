param (
    [string]$targetFrameworks = "netcoreapp3.1"
 )

Write-Host " -> Checking local packages..." -ForegroundColor Yellow
$localPackagesFolder = "../local-packages";
$packagesFolderExists = Test-Path $localPackagesFolder -PathType Container

if($packagesFolderExists) 
{
    Write-Host " -> Deleting previous packages in local packages..." -ForegroundColor Yellow
    Get-ChildItem -Path $localPackagesFolder -Include fakexrmeasy.abstractions* -Directory -Recurse -Force | Remove-Item -Recurse -Force
}
./pack-push.ps1 -targetFrameworks $targetFrameworks -versionSuffix "zlocal"


