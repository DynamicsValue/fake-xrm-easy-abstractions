param (
    [string]$packageSource = "local-packages"
 )

$project = "FakeXrmEasy.Abstractions"

Write-Host "Running with packageSource '$($packageSource)'..."

$dirSeparator = [IO.Path]::DirectorySeparatorChar

$tempNupkgFolder = ".$($dirSeparator)nupkgs$($dirSeparator)*.nupkg"

if($packageSource -eq "local-packages") {
    $localPackagesFolder = '../local-packages'
    Write-Host "Deleting previous pushed version '$($localPackagesFolder)'..."
    $projectFilePattern = $project + ".*"
    Get-ChildItem -Path $localPackagesFolder -Include $projectFilePattern -File -Recurse | ForEach-Object { $_.Delete()}
}

Write-Host "Pushing '$($project)' to source '$($packageSource)'..."


if($packageSource -eq "local-packages") {
    dotnet nuget push $tempNupkgFolder -s $packageSource
}
else 
{
    dotnet nuget push $tempNupkgFolder --skip-duplicate --api-key [System.Environment]::GetEnvironmentVariable('NUGET_TOKEN') -s $packageSource
}

if(!($LASTEXITCODE -eq 0)) {
    throw "Error pushing NuGet package"
}

Write-Host "Push Succeeded :)" -ForegroundColor Green