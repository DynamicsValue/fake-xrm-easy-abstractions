param (
    [string]$versionSuffix = "",
    [string]$targetFrameworks = "netcoreapp3.1",
    [string]$configuration = "FAKE_XRM_EASY_9",
    [string]$projectName = "FakeXrmEasy.Abstractions",
    [string]$projectPath = "src/FakeXrmEasy.Abstractions",
    [string]$packageIdPrefix = "FakeXrmEasy.Abstractions"
 )

Write-Host "Packing configuration '$($configuration)', for project '$($projectName)' at '$($projectPath)'..."

$packageId = $packageIdPrefix;

if($configuration -eq "FAKE_XRM_EASY_9")
{
  $packageId = $('"' + $packageIdPrefix + '.v9"')
}
elseif($configuration -eq "FAKE_XRM_EASY_365")
{
  $packageId = $('"' + $packageIdPrefix + '.v365"')
}
elseif($configuration -eq "FAKE_XRM_EASY_2016")
{
  $packageId = $('"' + $packageIdPrefix + '.v2016"')
}
elseif($configuration -eq "FAKE_XRM_EASY_2015")
{
  $packageId = $('"' + $packageIdPrefix + '.v2015"')
}
elseif($configuration -eq "FAKE_XRM_EASY_2013")
{
  $packageId = $('"' + $packageIdPrefix + '.v2013"')
}
else 
{
  $packageId = $('"' + $packageIdPrefix + '.v2011"')
  Write-Host $packageId
}
$tempNupkgFolder = './nupkgs'

Write-Host "Building..."

./build.ps1 -targetFramework $targetFrameworks -configuration $configuration

Write-Host "Packing assembly for targetFrameworks $($targetFrameworks)..."
if($targetFrameworks -eq "all")
{
    if($versionSuffix -eq "") 
    {
        dotnet pack --no-build --no-restore --configuration $configuration -p:PackageID=$packageId -o $tempNupkgFolder $projectPath/$projectName.csproj
    }
    else {
        dotnet pack --no-build --no-restore --configuration $configuration -p:PackageID=$packageId -o $tempNupkgFolder $projectPath/$projectName.csproj --version-suffix $versionSuffix
    }
}
else 
{
    if($versionSuffix -eq "") 
    {
        dotnet pack --no-build --no-restore --configuration $configuration -p:PackageID=$packageId -p:TargetFrameworks=$targetFrameworks -o $tempNupkgFolder $projectPath/$projectName.csproj
    }
    else {
        dotnet pack --no-build --no-restore --configuration $configuration -p:PackageID=$packageId -p:TargetFrameworks=$targetFrameworks -o $tempNupkgFolder $projectPath/$projectName.csproj --version-suffix $versionSuffix
    }
}


if(!($LASTEXITCODE -eq 0)) {
    throw "Error when packing the assembly"
}

Write-Host $("Pack $($packageId) Succeeded :)") -ForegroundColor Green