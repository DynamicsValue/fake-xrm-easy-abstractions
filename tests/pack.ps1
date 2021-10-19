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

$packageIdPrefix = "FakeXrmEasy.Abstractions"
$projectName = "FakeXrmEasy.Abstractions"
$projectPath = "src/FakeXrmEasy.Abstractions"

Write-Host "Packing All Configurations for project $($projectName)" -ForegroundColor Green

 if($targetFrameworks -eq "netcoreapp3.1")
 {
    ./pack-configuration.ps1 -targetFramework $targetFrameworks -projectName $projectName -projectPath $projectPath -packageIdPrefix $packageIdPrefix -configuration "FAKE_XRM_EASY_365" 
    ./pack-configuration.ps1 -targetFramework $targetFrameworks -projectName $projectName -projectPath $projectPath -packageIdPrefix $packageIdPrefix -configuration "FAKE_XRM_EASY_9" 
 }
 else {
    ./pack-configuration.ps1 -targetFramework $targetFrameworks -projectName $projectName -projectPath $projectPath -packageIdPrefix $packageIdPrefix -configuration "FAKE_XRM_EASY" 
    ./pack-configuration.ps1 -targetFramework $targetFrameworks -projectName $projectName -projectPath $projectPath -packageIdPrefix $packageIdPrefix -configuration "FAKE_XRM_EASY_2013"
    ./pack-configuration.ps1 -targetFramework $targetFrameworks -projectName $projectName -projectPath $projectPath -packageIdPrefix $packageIdPrefix -configuration "FAKE_XRM_EASY_2015"
    ./pack-configuration.ps1 -targetFramework $targetFrameworks -projectName $projectName -projectPath $projectPath -packageIdPrefix $packageIdPrefix -configuration "FAKE_XRM_EASY_2016"
    ./pack-configuration.ps1 -targetFramework $targetFrameworks -projectName $projectName -projectPath $projectPath -packageIdPrefix $packageIdPrefix -configuration "FAKE_XRM_EASY_365"
    ./pack-configuration.ps1 -targetFramework $targetFrameworks -projectName $projectName -projectPath $projectPath -packageIdPrefix $packageIdPrefix -configuration "FAKE_XRM_EASY_9"
 }

Write-Host "Pack Succeeded  :)" -ForegroundColor Green