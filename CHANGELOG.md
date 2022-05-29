## [2.1.1]

### Changed

- Updated build script to also include the major version in the Title property of the generated .nuspec file - DynamicsValue/fake-xrm-easy#41
- Made CRM SDK v8.2 dependencies less specific - DynamicsValue/fake-xrm-easy#21

## [2.1.0]

### Added

- Added Logger property to IXrmFakedPluginContextProperties - DynamicsValue/fake-xrm-easy#24

### Changed 

- Upgraded Microsoft.CrmSdk.CoreAssemblies to 9.0.2.27 to support the new ILogger interface - DynamicsValue/fake-xrm-easy#24
- Removed .netcoreapp3.1 as the target framework in v2.x. .netcore support is available in v3.x instead and update CI build accordingly - DynamicsValue/fake-xrm-easy#28

## [2.0.1-rc1] - Initial release