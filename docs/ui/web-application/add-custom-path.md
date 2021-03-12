---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: add_custom_path       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# CustomPath

The first step when customizing the web client is to add your own custom path to the web applications configuration file. The custom path is added to the `ClientConfigurationProvider` section of the *web.config* and must start with the text "CustomPath".  Multiple entries are allowed but the key must be unique.

You should never add your own config files to the standard configuration path. Always use your own custom path. You should also separate your own custom paths from other modifications as well.

Add the custom path and turn off caching. While developing you should always turn off caching.

```xml
<ClientConfigurationProvider>
  <add key="CustomPath_1" value="C:\MyPath\MyFiles1" />
  <add key="CustomPath_2" value="C:\MyPath\MyFiles2" />
  <add key="CacheConfigurations" value="false" />
</ClientConfigurationProvider>
```

The files placed in the custom folder will automatically be preferred by the web-client over the standard configuration files. All ".config" files will override existing files in the client. All ".merge" files will be merged into the standard configuration files specified within the merge file.

Be aware that when defining a custompath, you need to create a structured set of folders following the following convention - using the application name and instance name:

`c:\MyPath\MyFiles\[applicationname]\[instancename]\[mynamedfolder]\Myconfig.config`

The following example is based on a standard installation of the web client:

`C:\MyPath\MyFiles1\WebClient\Web\CustomSeven\SoCustomSevenPage.config`
`C:\MyPath\MyFiles2\WebClient\Web\CustomSeven\SoCustomSevenPage.config`

Alter System configuration files

Next, I'll present how to alter the system configuration files. The configuration files considered "system files" are:

* SoApplicationConfiguration
* SoObjectMapping
* SoArchiveControlLinkInfoTypes

## ApplicationConfiguration

*ApplicationConfiguration.config* contains those definitions for all pages, dialogs, and application currents.

Adding a new page to the web application requires a new entry in the `ApplicationConfiguration` as shown below.

```xml
<applicationsettings defaultprefsection="SuperMode">
  <pages prefsection="SuperMode" prefkey="MainPanel">
    <page id="contact" type="mainpage" function-right="hide-company" />
    <page id="project" type="mainpage" function-right="hide-project" />
    <page id="sale" type="mainpage" function-right="hide-sale" />
    <page id="selection" type="mainpage" function-right="hide-selection" />
    <page id="report" type="mainpage" function-right="hide-reporter" />
    <page id="diary" type="mainpage" />
    <page id="emarketing" type="mainpage" />
    <page id="CustomSeven" type="mainpage" />
...
```

We recommend you make this change only by creating and including a merge file.  There is no need to copy and override the default configuration file.

Do this by creating a new file names MyApplicationConfiguration.merge and place it in your custom path, for example *C:\\MyPath\\MyFiles1\\WebClient\\Web\\**CustomSeven**\\*. The content should look like this:

```xml
<applicationsettings defaultprefsection="SuperMode">
  <pages prefsection="SuperMode" prefkey="MainPanel">
    <page id="CustomSeven" type="mainpage" />
  </pages>
</applicationsettings>
```

When the application starts your page node will now be merged into the standard ApplicationConfiguration.config and you are good to go.

The page can be called by using a SoProtocol:

`PageUpdate('soprotocol:CustomSeven','');`

## Current

ApplicationConfiguration is also the place to define your own currents. The current system helps you maintain state between requests and even between sessions if needed.

Extend your merge file with a current definition:

```xml
<applicationsettings defaultprefsection="SuperMode">
  <pages prefsection="SuperMode"  prefkey="MainPanel">
    ...
  </pages>
  <currents>
    <current id="customsevencurrent" type="history" providername="SoProtocolProvider" />
  <currents>
</applicationsettings>
```

Currents are set using a SoProtocol:

`PageUpdate('soprotocol:CustomSeven?customsevencurrent_id=100','');`

## ObjectMapping

The ObjectMapping file maps the type used in page configuration files to actual object types defined in assemblies.  It is also possible to use merge files to extend or replace object definitions in the ObjectMapping configuration.

Here is a typical entry in *SoObjectMapping.config*:

```xml
<object type="IPanel" mappingname="SoPanel" assemblyname="SuperOffice.CRMWeb" objectname="SuperOffice.CRM.Web.UI.Controls.Panel">
</object>
```

This is an example of adding a new textbox control using an ObjectMapping merge file:

```xml
<objects>
  <object type="Control" mappingname="SoTextBox" assemblyname="CustomSeven" objectname="CustomSeven.MySoTextBox" />
</objects>
```

This is an example of how to override the standard textbox control in the web client:

```xml
<objects>
  <object type="Control" mappingname="SoTextBox" assemblyname="CustomSeven" objectname="CustomSeven.MySoTextBox" />
</objects>
```

## ArchiveControlLinkInfoTypes

ArchiveProviders provides LinkHints rather than actual links. The SoArchiveLinkInfoTypes.config contains the definition to resolves the linkhint to actual actions. This is mainly used by the ArchiveControl. You can change existing or add your own linkhint def. to support your own archive providers.

Linkhint merge is type/subtype-based. The linkhint merge uses the combination of the type and subtype attributes to the find location.

This is an example of how to override an existing linkhint using a merge file (ArchiveLinkInfoTypes.merge):

```xml
<linkinfos>
  <linkinfo type="personarchive:person" subtype="click">
    <baseurl>javascript:PageUpdate('soprotocol:?person_id={person_id}','');</baseurl>
    <target></target>
  </linkinfo>
</linkinfos>
```

## MenuConfiguration

SoMenuConfiguration.config holds the definition of all menus in the web-client.

Menu merge is context/subcontext-based. The menu merge uses the combination of the context and subcontext attributes to the find location.

```xml
<menus>
  <menu context="mainmenu" subcontext="file">
    <menuitems>
      <menuitem id="menufileexit" type="normal">
        <caption>[SR_MENU_FILE_EXIT]</caption>
        <url>javascript:if(confirm('Are you sure?')) {ApplicationExit();}</url>
      </menuitem>

      <menuitem id="" type="divider" />
      <menuitem id="menufiletest" type="normal">
        <caption>Open debugwindow</caption>
        <url>Debug.openWindow();</url>
      </menuitem>
    <menuitems>
  <menu>
</menus>
```
