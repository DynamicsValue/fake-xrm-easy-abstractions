param (
    [string]$folderPath = "./src/FakeXrmEasy.Abstractions/bin"
)

Get-ChildItem -Path $folderPath -Include * -File -Recurse | foreach { $_.Delete()}
