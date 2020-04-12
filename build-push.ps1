Write-Host "Building..."

./build.ps1

Write-Host "Packing assembly..."
dotnet pack src/FakeXrmEasy.Abstractions/FakeXrmEasy.Abstractions.csproj

Write-Host "Pushing FakeXrmEasy.Abstractions to local folder..."
dotnet nuget push /home/jordi/code/DynamicsValue/fake-xrm-easy-abstractions/src/FakeXrmEasy.Abstractions/bin/Debug/FakeXrmEasy.Abstractions.1.0.0.nupkg -s local-packages

Write-Host "Succeeded :)"