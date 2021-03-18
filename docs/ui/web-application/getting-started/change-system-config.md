---
title: change_system_config
description: How to alter system configuration files
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: howto
so.envir: win
so.client: web
---

# How to alter system configuration files

The configuration files considered system files are:

* SoApplicationConfiguration
* SoObjectMapping
* SoArchiveControlLinkInfoTypes

## ApplicationConfiguration

*ApplicationConfiguration.config* contains those definitions for all pages, dialogs, and application currents.

Adding a new page to the web application requires a new entry in the `ApplicationConfiguration`:

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

We recommend you make this change only by creating and including a merge file. There is no need to copy and override the default configuration file.

Do this by creating a new file names *MyApplicationConfiguration.merge* and place it in your custom path, for example `C:\MyPath\MyFiles1\WebClient\Web\CustomSeven\`. The content should look like this:

```xml
<applicationsettings defaultprefsection="SuperMode">
  <pages prefsection="SuperMode" prefkey="MainPanel">
    <page id="CustomSeven" type="mainpage" />
  </pages>
</applicationsettings>
```

When the application starts, your page node will now be merged into the standard *ApplicationConfiguration.config* and you are good to go.

The page can be called by using a SoProtocol:

`PageUpdate('soprotocol:CustomSeven','');`

## Current

*ApplicationConfiguration* is also the place to define your own currents. The current system helps you maintain the state between requests and even between sessions if needed.

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

The *ObjectMapping.config* file maps the type used in page configuration files to actual object types defined in assemblies. It is also possible to use merge files to extend or replace object definitions in the ObjectMapping configuration.

**A typical entry:**

```xml
<object type="IPanel" mappingname="SoPanel" assemblyname="SuperOffice.CRMWeb" objectname="SuperOffice.CRM.Web.UI.Controls.Panel">
</object>
```

### Adding a new textbox control using an ObjectMapping merge file

This example demonstrates how to add a new textbox control using an *SoObjectMapping.merge* file.

```xml
<objects>
  <object
    type="Control"
    mappingname="MySoTextBox"
    assemblyname="CustomFeatures"
    objectname ="CustomFeatures.MySoTextBox" />
</objects >
```

### How to override the standard textbox control in the web client

This example demonstrates how to override the standard web client textbox control.

```xml
<objects>
  <object
    mergeaction="replace"
    type="Control"
    mappingname="SoTextBox"
    assemblyname="CustomFeatures"
    objectname ="CustomFeatures.MySoTextBox"/>
</objects>
```

## ArchiveControlLinkInfoTypes

Archive providers provides **LinkHints** rather than actual links. The *SoArchiveLinkInfoTypes.config* file contains the definition to resolve the hint to actual actions. This is mainly used by the archive control. You can change existing or add your own definition to support your archive providers.

`LinkHints` merge is type/subtype-based and uses the combination of the type and subtype attributes to the find location.

### How to override an existing linkhint using a merge file (ArchiveLinkInfoTypes.merge)

```xml
<linkinfos>
  <linkinfo type="personarchive:person" subtype="click">
    <baseurl>javascript:PageUpdate('soprotocol:?person_id={person_id}','');</baseurl>
    <target></target>
  </linkinfo>
</linkinfos>
```

## MenuConfiguration

*SoMenuConfiguration.config* holds the definition of all menus in the web client.

Menu merge is context/sub-context-based and uses the combination of the `context` and `subcontext` attributes to the find location.

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
