param (
    [string]$packageSource = "local-packages"
 )

$project = "FakeXrmEasy.Abstractions"

Write-Host "Running with packageSource '$($packageSource)'..."

$tempNupkgFolder = './nupkgs'

if($packageSource -eq "local-packages") {
    $localPackagesFolder = '../local-packages'
    Write-Host "Deleting previous pushed version '$($localPackagesFolder)'..."
    $projectFilePattern = $project + ".*"
    Get-ChildItem -Path $localPackagesFolder -Include $projectFilePattern -File -Recurse | ForEach-Object { $_.Delete()}
}

Write-Host "Pushing '$($project)' to source '$($packageSource)'..."
dotnet nuget push $tempNupkgFolder/*.nupkg -s $packageSource
if(!($LASTEXITCODE -eq 0)) {
    throw "Error pushing NuGet package"
}

Write-Host "Push Succeeded :)" -ForegroundColor Green