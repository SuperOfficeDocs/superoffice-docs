---
title: cust_and_deploy
description: customization and deployment
author: Tony Yates
so.date: 04.17.2018
keywords:
so.topic: generic
so.client: web
so.envir: onsite
---

# Customization and deployment

Customizing the web client is all made possible by modifying application XML SuperOffice Markup Language (SOML) files. To begin, it's as easy as navigating to the applications App_Data folder and opening one of the .config files that requires customizing. From click-actions to UI windows there are virtually limitless client customization capabilities.

With regards to modifying existing application files, there are downsides to this approach. Product upgrades, for example, replace all existing files and thereby wipe away all direct customizations.

Client configuration options provide a better approach, with an ability to define a directory outside the installation directory where configuration overrides are placed. These override files are then discovered and incorporated at runtime. The *client configuration provider* solves this problem.

## Client configuration provider

Configuration options, located in the web.config file, are declared in the **ClientConfigurationProvider** element and tell the client where additional configuration files are located. This table lists all ClientConfigurationProvider options.

|Options                | Description                                                 |
|-----------------------|-------------------------------------------------------------|
|CustomPath             | Defines a path that contains configuration and merge files. |
|CacheConfigurations    | Determines if the configuration is cached.                       |
|ValidateConfigurations | Determines of GUI config data is validated at runtime.      |

### Custom Path

To begin, add a **CustomPath** directive in the ClientConfigurationProvider element. The custom path key name must start with the text **CustomPath** and can be suffixed when necessary to support multiple custom paths. The only requirement is each key must start with _CustomPath_ and be unique.

```xml
<SuperOffice>
  ...
  <ClientConfigurationProvider>

   <!-- add path to customization files -->
    <add key="CustomPath_Common"      value ="C:\WebClient\Common" />
    <add key="CustomPath_Feature"     value ="C:\WebFeature\MyFiles" />
    <add key="CustomPath_ThirdParty"  value ="C:\Thirdparty\MyFiles" />
    <add key="CacheConfigurations"    value="false" />
    <add key="ValidateConfigurations" value="true" />
  </ClientConfigurationProvider>
  ...
<SuperOffice>
```

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

### CacheConfigurations

There is a performance benefit to enabling CacheConfigurations, however, it makes more sense to turn this feature off during development. When set to false, configuration changes to UI elements are immediately applied and observed in the browser - there's no need to perform an IIS reset or issue a _flush_ SoProtocol. There are however a few exceptions to this rule.

Caching works for all configuration files except system files. System files are cached during application startup and held in memory. Any changes to the files below do require an IIS reset.

* SoApplicationConfiguration.config
* SoAdminApplicationConfiguration.config
* SoFilterList.config
* SoObjectMapping.config
* SoArchiveColumnList.config
* SoArchiveControlLinkInfoTypes.config
* SoArchiveCriteriaList.config

#### Archive Column Lists

A quick note about **archive** elements. Once an archive provider is initialized with column definitions in an _archive_ element, the column definitions are persisted like preferences in the _SUPERLISTCOLUMNSIZE_ table of the database. Any changes to the _archive_ configuration will not be observed in the client until the corresponding records in the database are purged. To delete rows from the _SUPERLISTCOLUMNSIZE_ table, use the _Archive_ attribute guiname value as the key with the following delete query.

```sql
-- replace [guiname] with the real archive guiname
DELETE * FROM [CRM7].[DATABASENAME].[SUPERLISTCOLUMNSIZE]
WHERE listOwner = '[guiname]'
```

### ValidateConfigurations

SOML is XML that must conform to a well-defined schema. When set to true, **ValidateConfirations** will validate all configurations based on respective schemas to ensure all markup is well-formed. Any errors found are shown in the browser.

## Merge Process

While the system supports modifying configuration files copied directly from the application into a custom path folder, it's generally cleaner to instead use merge files instead.

Merge files have a .merge file extension and make it easy to add, remove or replace configuration elements without touching the original application files.

Regardless of approach, it's important to know how to target a specific location in a configuration file so that the customization appears in the application where it is expected.

Different elements tags use one or more attributes to ensure each element with the same tag has a unique identity. Having a unique element identity is important to resolve which element is affected. The following table maps which element relies on which identifier(s) to ensure uniqueness.

| Parent | Element | Identifier | File(s)
|------|------------|------|----|
|pages**|page|id|SoApplicationConfiguration|
|currents|current|id|SoApplicationConfiguration|
|jsincludes|jsinclude|path|SoApplicationConfiguration|
|cssincludes|cssinclude|path|SoApplicationConfiguration|
|consts|const|id|SoApplicationConfiguration|
|pages|page|id|So[_abc_]Page|
|archives|archive|providername, guiname|SoArchiveColumnList|
|linkinfos|linkinfo|type, subtype|SoArchiveControlLinkInfoTypes|
|filters**|filter|name|SoFilterList|
|menus**|menu|context, subcontext|SoMenuConfiguration|
|objects|object|mappingname|SoObjectMapping|

** Elements type appear in more than one configuration files.

### Merge Actions

A **mergeaction** attribute is used to determine which element to process. The following table lists what actions are available. *Insert is the default behavior* when no **mergeaction** attribute is specified.

|command|description |
|-------|------------|
|insert | inserts the section (default) |
|replace| replaces the section with same id-value|
|remove | removes the section.|

The following snippet demonstrates how to add a new page to the application configuration pages collection using an _SoApplicationConfiguration.merge_ file.

```xml
<applicationsettings>
  <pages>
    <page id="CustomPage" type="mainpage" mergeaction="insert"/>
  </pages>
</applicationsettings>
```

Not all elements are based on id alone, so remember to use the correct element/identifier when applying changes.

## Page Configuration Files

While element placement might not be important for system configuration files, modifying elements in a page or dialog must be structured accordingly. A page contains cards, and cards contain views, and views contain controlgroups and so on, and knowing how to structure a merge definition is critical to successfully deploying a change.

There are two approaches to apply a configuration change: complete structure or using an xpath element. System files must use the complete structure approach, whole UI pages can use either one or both.

### Complete Structure Approach

Using the complete structure approach means creating a merge file with the complete page structure up to the element with a mergeaction attribute. Using this approach, the merge filter can accurately determine which element to process.

The following example demonstrates how to replace a controlgroup in the SoContactPage configuration. Take notice how each id along the path is defined for the page, panel, card, view, and finally the controlgroup. Make sure to also include the **< pages >** root element.

```xml
<!-- SoContactPage.merge -->
<pages>
  <page id ="ContactPage">
    <panels>
      <panel id="Contact">
        <cards>
          <card id="ContactMainCard">
            <views>
              <view id="MainView">
                <controlgroups>
                  <controlgroup id="maingroup_2" mergeaction="replace"
                                type="SoControlGroup" position="absolute"
                                top="58px" width="42%" right="20px"
                                overflow="hidden">
                    <controls>
                      <control id="miniImage" type="SoImage">
                        <config>
                          <imagetype>url<imagetype>
                          <src>MyImages/WebClient/Web/image/owl.jpg<src>
                        <config>
                      <control>
                    <controls>
                  <controlgroup>
                <controlgroups>
              <view>
            <views>
          <card>
        <cards>
      <panel>
    <panels>
  <page>
<pages>
```

Without stating id values at each stage of the structure, the filter would not be unable to determine which page>panel>card>view>controlgroup path to replace and the merge would be ignored.

### XPath Element Approach

Added in SuperOffice 8.1, xpath is a new approach to add page elements. This approach even supports adding elements across fragments!

_This capability only applies to the contents of UI pages and dialogs and **is not applicable to system files**._

```xml
<!-- Example: <filename>.merge
  Add a button to all pages that uses the navigationpanel fragment
 -->
<pages>
  <xpath xpath="/page/panels/panel/cards/card/views/view[@id='NavigatorView']/controlgroups/controlgroup[@id='ButtonGroup']/controls">
    <control  id="testButton" type="SoNavigatorButton">
     ...
    </control>
  </xpath>
</pages>
```

Because pages can contain duplicate element ids at various nested levels, care must be taken when using this approach to ensure no unusual side effects occur.

_The potential for xpath side effects was enough to deem this capability too powerful for replace and remove actions._

## System Configuration Files

* SoApplicationConfiguration
* SoObjectMapping
* SoArchiveControlLinkInfoTypes

<!-- Referenced images -->
[img1]: media/web-client-configuration-file-folders.png
