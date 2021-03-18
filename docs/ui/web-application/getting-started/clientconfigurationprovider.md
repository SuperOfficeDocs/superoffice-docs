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

Configuration options in the *web.config* file are declared in the **ClientConfigurationProvider** element and tell the client where additional configuration files are located.

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

**Available options:**

| Options | Description |
|---|---|
| CustomPath | Defines a path that contains configuration and merge files |
| CacheConfigurations | Determines if the configuration is cached |
| ValidateConfigurations | Determines if GUI config data is validated at runtime |

## CustomPath

The custom-path key name must start with the text **CustomPath** and can be suffixed when necessary to support multiple custom paths. The only requirement is each key must start with "CustomPath_" and be unique.

Multiple custom paths are a means to organize and separate features and third-party integrations.

### Precedence

Files in a custom path folder take precedence and override standard web-client configuration files. This means that if a file called *SoApplicationConfiguration.config* exists in a custom path, it will take priority and be used instead of the default *SoApplicationConfiguration.config* in the web applications installation folder.

### Sub-folders

Inside the custom path directory, there must be a structured set of folders following the convention:

`<CustomPath>[applicationname][instancename]\`

Where **applicationname** and **instancename** defaults are WebClient and Web, which may or may not be explicitly defined in the `Client` element.

```xml
<SuperOffice>
  ...
  <Client applicationname="WebClient" instancename="Web">
  ...
  </Client>
  ...
</SuperOffice>
```

This default application configuration folder *App_Data* has the same structure and is where all standard configuration files are installed. The *.config files in these folders make up the entire structure of the web client.

![Web client configuration folder][img1]

Inside the *WebClient\Web* folders, the structure is not important. All sub-folders are searched for configuration files, so it's up to your personal preference. The following approaches demonstrate a few possibilities.

**Approach 1:**

```text
C:\WebClient\Common\WebClient\Web\SoApplicationConfiguration.config
C:\WebClient\Common\WebClient\Web\SoArchiveLists.merge
C:\WebClient\Common\WebClient\Web\SoMenuConfiguration.config
```

**Approach 2:**

```text
C:\WebFeature\MyFiles\WebClient\Web\Inventory\SoCustomInventoryPage.config
C:\WebFeature\MyFiles\WebClient\Web\Inventory\SoCustomInventoryDialog.config
C:\WebFeature\MyFiles\WebClient\Web\Inventory\SoCustomInventoryMenus.merge
```

**Approach 3:**

```text
C:\Thirdparty\MyFiles\WebClient\Web\Pages\SoThirdPartyPage.config
C:\Thirdparty\MyFiles\WebClient\Web\Pages\SoCustomContactPage.merge
C:\Thirdparty\MyFiles\WebClient\Web\Dialogs\SoThirdPartyDialogPage.config
C:\Thirdparty\MyFiles\WebClient\Web\Scripts\CustomScripts.js
```

### System files

If the decision is to use a copy of the original file in a custom path, try to use one common folder that is shared among third-parties to ensure you do not override each other's settings. That said, it's recommended to use a merge file instead.

[Merge files][1] are a means to apply customizations by, not overriding an entire file but, specifying where an existing file a merge action is applied at runtime.

## CacheConfigurations

There is a performance benefit to enabling `CacheConfigurations`, however, it makes more sense to turn this feature off during development. When set to false, configuration changes to UI elements are immediately applied and observed in the browser - there's no need to perform an IIS reset or issue a *flush* SoProtocol. There are however a few exceptions to this rule.

> [!NOTE]
> Caching works for all configuration files **except system files**.

System files are cached during application startup and held in memory. Any changes to the files below do require an IIS reset.

* SoApplicationConfiguration.config
* SoAdminApplicationConfiguration.config
* SoFilterList.config
* SoObjectMapping.config
* SoArchiveColumnList.config
* SoArchiveControlLinkInfoTypes.config
* SoArchiveCriteriaList.config

## Archive column lists

A quick note about **archive** elements. Once an archive provider is initialized with column definitions in an `archive` element, the column definitions are persisted like preferences in the `SUPERLISTCOLUMNSIZE` table of the database.

> [!NOTE]
> Any changes to the `archive` configuration will not be observed in the client until the corresponding records in the database are purged.

To delete rows from the `SUPERLISTCOLUMNSIZE` table, use the `archive` attribute guiname value as the key with the following delete query.

```SQL
-- replace [guiname] with the real archive guiname
DELETE * FROM [CRM7].[DATABASENAME].[SUPERLISTCOLUMNSIZE]
WHERE listOwner = '[guiname]'
```

## ValidateConfigurations

[SOML][2] is XML that must conform to a well-defined schema. When set to true, `ValidateConfirations` will validate all configurations based on respective schemas to ensure all markup is well-formed. Any errors found are shown in the browser.

<!-- Referenced links -->
[1]: ../pagebuilder/config/merge.md
[2]: ../pagebuilder/config/soml.md

<!-- Referenced images -->
[img1]: media/web-client-configuration-file-folders.png
