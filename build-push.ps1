Write-Host "Building..."

./build.ps1

$tempNupkgFolder = './nupkgs'
Write-Host "Checking if temp nupkgs folder '$($localPackagesFolder)' exists..."

$tempNupkgFolderExists = Test-Path $tempNupkgFolder -PathType Container

if(!($tempNupkgFolderExists)) 
{
    New-Item $tempNupkgFolder -ItemType Directory
}

Write-Host "Deleting temporary nupkgs..."
Get-ChildItem -Path $tempNupkgFolder -Include *.* -File -Recurse | ForEach-Object { $_.Delete()}

Write-Host "Packing assembly..."
dotnet pack -o $tempNupkgFolder src/FakeXrmEasy.Abstractions/FakeXrmEasy.Abstractions.csproj

Write-Host "Pushing FakeXrmEasy.Abstractions to local folder..."
dotnet nuget push $tempNupkgFolder/*.nupkg -s local-packages

Write-Host "Succeeded :)"