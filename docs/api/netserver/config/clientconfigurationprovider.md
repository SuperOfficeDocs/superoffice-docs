---
title: ClientConfigurationProvider
uid: ns_config_client_configuration
description: NetServer configuration for the Web client configuration data provider.
so.date: 12.17.2021
author: Bergfrid Dias
keywords: web.config, ClientConfigurationProvider, FilePath, cache, CustomPath
so.topic: reference
so.envir: onsite
so.client: web
---

# NetServer ClientConfigurationProvider element (SuperOffice only)

Configuration for the Web client configuration data provider. The paths tell the client where additional configuration files are located.

```XML
<ClientConfigurationProvider>
  <add key="CacheConfigurations" value="false" />
  <add key="ValidateConfigurations" value="true" />
</ClientConfigurationProvider>
```

| Name | Description | Default |
|---|---|---|
| CacheConfigurations | Should GUI config data be cached? | |
| CacheUserPreferences | Should user preferences be cached? | true |
| CustomPath | List of alternate paths for GUI .config files. When more than one, each additional path must have a numbered suffix (CustomPath1, CustomPath2, ...) | |
| FilePath | File path for standard .config files. | |
| ValidateConfigurations | Should GUI config data be validated runtime? | |

## CacheConfigurations

Caching configuration benefits performance. However, it makes more sense to turn caching off during development.

When set to false, configuration changes to UI elements are immediately applied and observed in the browser. There's no need to reset IIS or issue a *flush* SoProtocol.

## CustomPath

The custom-path key name must start with the text **CustomPath** and can be suffixed when necessary to support multiple custom paths. The only requirement is each key must start with "CustomPath_" and be unique.

Multiple custom paths are a means to organize and separate features and third-party integrations.

```xml
<ClientConfigurationProvider>
  <add key="CustomPath_Common"     value ="C:\WebClient\Common" />
  <add key="CustomPath_Feature"    value ="C:\WebFeature\MyFiles" />
  <add key="CustomPath_ThirdParty" value ="C:\Thirdparty\MyFiles" />
</ClientConfigurationProvider>
```

Files in a custom path folder take **precedence** and override standard web-client configuration files. This means that if a file called *SoApplicationConfiguration.config* exists in a custom path, it will take priority and be used instead of the default *SoApplicationConfiguration.config* in the web applications installation folder.

If the decision is to use a copy of the original file in a custom path, try to use one common folder that is shared among third-parties to ensure you do not override each other's settings. That said, it's recommended to use a [merge file][3] instead.

## ValidateConfigurations

[SOML][2] is PageBuilder XML that must conform to a well-defined schema. When set to true, `ValidateConfigurations` will validate all configurations based on respective schemas to ensure all markup is well-formed. Any errors found are shown in the browser.

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.ClientConfigurationProvider>
[2]: ../../../../user-interface/docs/web-application/pagebuilder/config/soml.md
[3]: ../../../../user-interface/docs/web-application/pagebuilder/config/merge-files-and-actions.md
