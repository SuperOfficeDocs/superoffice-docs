---
title: client_config_provider
description: Client configuration provider
author: Tony Yates
so.date: 04.17.2018
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# Client configuration provider

Configuration options, located in the *web.config* file, are declared in the **ClientConfigurationProvider** element and tell the client where additional configuration files are located.

**Available options:**

| Options | Description |
|---|---|
| CustomPath | Defines a path that contains configuration and merge files |
| CacheConfigurations | Determines if the configuration is cached |
| ValidateConfigurations | Determines if GUI config data is validated at runtime |

```xml
<SuperOffice>
  ...
  <ClientConfigurationProvider>
    <add key="CustomPath_Common"      value ="C:\WebClient\Common" />
    <add key="CustomPath_Feature"     value ="C:\WebFeature\MyFiles" />
    <add key="CustomPath_ThirdParty"  value ="C:\Thirdparty\MyFiles" />
    <add key="CacheConfigurations"    value="false" />
    <add key="ValidateConfigurations" value="true" />
  </ClientConfigurationProvider>
  ...
<SuperOffice>
```

## CustomPath

The custom path key name must start with the text **CustomPath** and can be suffixed when necessary to support multiple custom paths. The only requirement is each key must start with "CustomPath_" and be unique.

Multiple custom paths are a means to organize and separate features and third-party integrations.

Files in a custom path folder take precedence and override standard web-client configuration files. This means that if a file called **SoApplicationConfiguration.config** exists in a CustomPath, it will take priority and be used instead of the default **SoApplicationConfiguration.config** in the web applications installation folder.

Inside the custom path directory, there must be a structured set of folders following the convention:

`<CustomPath>[applicationname][instancename]\`

Where *applicationname* and *instancename* defaults are WebClient and Web, which may or may not be explicitly defined in the **Client** element.

```xml
<SuperOffice>
  ...
  <Client applicationname="WebClient" instancename="Web">
  ...
  </Client>
  ...
</SuperOffice>
```

This default application configuration folder _App_Data_ has the same structure and is where all standard configuration files are installed. The *.config files in these folders make up the entire structure of the web client.

![Web Client Configuration Folder][img1]

With regards to **CustomPath** sub-folders, inside the WebClient\Web folders, the structure is not important. Because all subfolders are searched for configuration files, it's really personal-preference.

The following approaches demonstrate a few possibilities.

Approach #1:

```text
C:\WebClient\Common\WebClient\Web\SoApplicationConfiguration.config
C:\WebClient\Common\WebClient\Web\SoArchiveLists.merge
C:\WebClient\Common\WebClient\Web\SoMenuConfiguration.config
```

Approach #2:

```text
C:\WebFeature\MyFiles\WebClient\Web\Inventory\SoCustomInventoryPage.config
C:\WebFeature\MyFiles\WebClient\Web\Inventory\SoCustomInventoryDialog.config
C:\WebFeature\MyFiles\WebClient\Web\Inventory\SoCustomInventoryMenus.merge
```

Approach #3:

```text
C:\Thirdparty\MyFiles\WebClient\Web\Pages\SoThirdPartyPage.config
C:\Thirdparty\MyFiles\WebClient\Web\Pages\SoCustomContactPage.merge
C:\Thirdparty\MyFiles\WebClient\Web\Dialogs\SoThirdPartyDialogPage.config
C:\Thirdparty\MyFiles\WebClient\Web\Scripts\CustomScripts.js
```

With regards to system files, if the decision is to use a copy of the original file in a custom path, try to use one common folder that is shared among third-parties to ensure one does not override the settings of another. That said, it's recommended to use a merge file instead.

Merge files are a means to apply customizations by, not overriding an entire file but, specifying where in an existing file a merge action is applied at runtime. There is more information about merge actions in the merge section below.

## CacheConfigurations

There is a performance benefit to enabling CacheConfigurations, however, it makes more sense to turn this feature off during development. When set to false, configuration changes to UI elements are immediately applied and observed in the browser - there's no need to perform an IIS reset or issue a _flush_ SoProtocol. There are however a few exceptions to this rule.

Caching works for all configuration files except system files. System files are cached during application startup and held in memory. Any changes to the files below do require an IIS reset.

* SoApplicationConfiguration.config
* SoAdminApplicationConfiguration.config
* SoFilterList.config
* SoObjectMapping.config
* SoArchiveColumnList.config
* SoArchiveControlLinkInfoTypes.config
* SoArchiveCriteriaList.config

## Archive Column Lists

A quick note about **archive** elements. Once an archive provider is initialized with column definitions in an _archive_ element, the column definitions are persisted like preferences in the _SUPERLISTCOLUMNSIZE_ table of the database. Any changes to the _archive_ configuration will not be observed in the client until the corresponding records in the database are purged. To delete rows from the _SUPERLISTCOLUMNSIZE_ table, use the _Archive_ attribute guiname value as the key with the following delete query.

```sql
-- replace [guiname] with the real archive guiname
DELETE * FROM [CRM7].[DATABASENAME].[SUPERLISTCOLUMNSIZE]
WHERE listOwner = '[guiname]'
```

## ValidateConfigurations

SOML is XML that must conform to a well-defined schema. When set to true, **ValidateConfirations** will validate all configurations based on respective schemas to ensure all markup is well-formed. Any errors found are shown in the browser.
