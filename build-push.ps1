Write-Host "Building..."

./build.ps1

Write-Host "Packing assembly..."
dotnet pack src/FakeXrmEasy.Abstractions/FakeXrmEasy.Abstractions.csproj

Write-Host "Pushing FakeXrmEasy.Abstractions to local folder..."
dotnet nuget push ./src/FakeXrmEasy.Abstractions/bin/Debug/FakeXrmEasy.Abstractions.2.0.0.1-Alpha.nupkg -s local-packages

Write-Host "Succeeded :)"