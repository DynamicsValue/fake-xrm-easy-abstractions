## [3.1.0]

### Added

Added Logger property to IXrmFakedPluginContextProperties - DynamicsValue/fake-xrm-easy#24

### Changed 

Upgraded Microsoft.CrmSdk.CoreAssemblies to 9.0.2.27 to support the new ILogger interface - DynamicsValue/fake-xrm-easy#24
Removed .netcoreapp3.1 as the target framework in v2.x. .netcore support is available in v3.x instead and update CI build accordingly - DynamicsValue/fake-xrm-easy#28

## [3.0.2]

Bump Dataverse dependency to 0.6.1 from 0.5.10 to solve DynamicsValue/fake-xrm-easy#20
Also replaced Microsoft.Dynamics.Sdk.Messages dependency, as it has also been deprecated by MSFT, to Microsoft.PowerPlatform.Dataverse.Client.Dynamics 0.6.1 DynamicsValue/fake-xrm-easy#20
## [3.0.1-rc1] - Initial release
