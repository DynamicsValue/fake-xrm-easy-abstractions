param (
    [string]$packageSource = "local-packages",
    [string]$versionSuffix = ""
 )

$project = "FakeXrmEasy.Abstractions"

Write-Host "Running with packageSource '$($packageSource)' and versionSuffix '$($versionSuffix)'..."

$tempNupkgFolder = './nupkgs'
$localPackagesFolder = '../' + $packageSource

Write-Host "Checking if temp nupkgs folder '$($tempNupkgFolder)' exists..."

$tempNupkgFolderExists = Test-Path $tempNupkgFolder -PathType Container

if(!($tempNupkgFolderExists)) 
{
    New-Item $tempNupkgFolder -ItemType Directory
}

Write-Host "Deleting temporary nupkgs..."
Get-ChildItem -Path $tempNupkgFolder -Include *.* -File -Recurse | ForEach-Object { $_.Delete()}

Write-Host "Deleting previous pushed version '$($localPackagesFolder)'..."
Get-ChildItem -Path $localPackagesFolder -Include FakeXrmEasy.Abstractions.* -File -Recurse | ForEach-Object { $_.Delete()}

Write-Host "Packing assembly..."
if($versionSuffix -eq "") 
{
    dotnet pack -o $tempNupkgFolder src/$project/$project.csproj
}
else {
    dotnet pack -o $tempNupkgFolder src/$project/$project.csproj /p:VersionSuffix=$versionSuffix
}
if(!($LASTEXITCODE -eq 0)) {
    throw "Error when packing the assembly"
}

Write-Host "Pushing '$($project)' to source '$($packageSource)'..."
dotnet nuget push $tempNupkgFolder/*.nupkg -s $packageSource
if(!($LASTEXITCODE -eq 0)) {
    throw "Error pushing NuGet package"
}

Write-Host "Succeeded :)" -ForegroundColor Green