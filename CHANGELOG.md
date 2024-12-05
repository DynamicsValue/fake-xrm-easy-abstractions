## [2.6.1]

### Added

- Added the IsHierarchical property to XrmFakedRelationship in order to support AboveOrEqual condition expressions in FakeXrmEasy.Core

## [2.6.0]

### Added
- 
- Add new method to Initialize Files to support InMemory File Db - https://github.com/DynamicsValue/fake-xrm-easy/issues/157

## [2.5.0]

### Changed

- Upgraded CoreAssemblies package for v9 versions with latest version

## [2.4.0]

### Added

- **Alpha**: Introduced subscription usage monitoring based on customer feedback

### Changed

- Set default build configuration in solution file to FAKE_XRM_EASY_9
- build.ps1 improvements: do not build project twice (added --no-build) when running dotnet test, do not build again either when packing assemblies either: https://github.com/DynamicsValue/fake-xrm-easy/issues/119
- Remove release notes from package description: https://github.com/DynamicsValue/fake-xrm-easy/issues/115
- Update build scripts to use 'all' target frameworks by default - https://github.com/DynamicsValue/fake-xrm-easy/issues/126
- Update github actions to use new Sonar environment variables - https://github.com/DynamicsValue/fake-xrm-easy/issues/120

## [2.3.3]

### Added

- Added method to find early bound types by using their entityTypeCode

## [2.3.2]

### Changed 

- Upgraded GitHub Actions to update Java major version to run SonarCloud analysis - https://github.com/DynamicsValue/fake-xrm-easy/issues/110
- Update CLA bot version
- Update legacy CRM SDK 2011 dependency to use official MS package - https://github.com/DynamicsValue/fake-xrm-easy/issues/105

## [2.3.0]

### Added 

- Add new CustomApiFakeMessageExecutors property - https://github.com/DynamicsValue/fake-xrm-easy/issues/75
- Add enums needed for CustomProcessingStepType and BindingTypes of custom apis - https://github.com/DynamicsValue/fake-xrm-easy/issues/75
- Add IBaseCustomApiFakeMessageExecutor to better support both strongly-typed and late bound customa api when registering them in middleware - https://github.com/DynamicsValue/fake-xrm-easy/issues/50
- Add new ICustomApiFakeMessageExecutor and IGenericCustomApiFakeMessageExecutor interfaces to allow custom API execution with an optional plugin type as part of the Main Operation stage - https://github.com/DynamicsValue/fake-xrm-easy/issues/50
 
### Changed

- Move CallerProperties, GetTracingService and CallerProperties to IXrmBaseContext so the can be reused both in IXrmFakedContextand and IXrmRealContext interfaces - DynamicsValue/fake-xrm-easy#35
- Move XrmFakedPluginExecutionContext to the Plugins package, it'll be under FakeXrmEasy.Plugins as opposed to FakeXrmEasy.Abstractions.Plugins

## [2.2.0]

- Remove PullRequestException and added different types of exceptions depending on the license context

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