---
title: Merge process
uid: merge_files_and_actions
description: Merge process
author: Tony Yates
so.date: 04.17.2018
keywords:
so.topic: generic
so.client: web
so.envir: onsite
---

# Merge process

While the system supports modifying configuration files copied directly from the application into a [custom path folder][1], it's generally cleaner to instead use merge files.

**Merge files** have a *.merge* file extension and make it easy to add, remove or replace configuration elements without touching the original application files.

Regardless of approach, it's important to know how to target a specific location in a configuration file so that the customization appears in the application where it is expected.

Elements use one or more attributes to ensure that elements with identical tags have a unique identity, which is important to resolve which element is affected.

The following table maps which element relies on which identifiers to ensure uniqueness.

| Parent | Element | Identifier | File(s) |
|---|---|---|---|
| pages** | page | id | SoApplicationConfiguration |
| currents | current | id | SoApplicationConfiguration |
| jsincludes | jsinclude | path | SoApplicationConfiguration |
| cssincludes | cssinclude | path | SoApplicationConfiguration |
| consts | const | id | SoApplicationConfiguration |
| pages | page | id | So[_abc_]Page |
| archives | archive | providername, guiname | SoArchiveColumnList |
| linkinfos | linkinfo | type, subtype | SoArchiveControlLinkInfoTypes |
| filters** | filter | name | SoFilterList |
| menus** | menu | context, subcontext | SoMenuConfiguration |
| objects | object | mappingname | SoObjectMapping |

** Elements type appear in more than one configuration file.

## Merge actions

A **mergeaction** attribute is used to determine which element to process. The following table lists what actions are available.

> [!NOTE]
> Insert is the **default behavior** when no `mergeaction` attribute is specified.

| Command | Description |
|---|---|
| insert  | inserts the section (default) |
| replace | replaces the section with the same ID value |
| remove  | removes the section. |

### Example 1

The following snippet demonstrates how to add a new page to the application configuration pages collection using an *SoApplicationConfiguration.merge* file.

```xml
<applicationsettings>
  <pages>
    <page id="CustomPage" type="mainpage" mergeaction="insert"/>
  </pages>
</applicationsettings>
```

### Example 2

This example will replace the controlgroup `maingroup_2` in the page named Contact.

```xml
<pages>
  <page id="ContactPage">
    <panels>
      <panel id="Contact">
        <cards>
          <card id="ContactMainCard">
            <views>
              <view id="MainView">
                <controlgroups>
                  <controlgroup id="maingroup_2" mergeaction="replace"
                                type="SoControlGroup" position="absolute" 
                                top="58px" width="42%" right="20px" 
                                overflow="hidden">
                    <controls>
                      <control id="miniImage" type="SoImage">
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

> [!TIP]
> Not all elements are based on ID alone, so remember to use the correct element/identifier when applying changes.

<!-- Referenced links -->
[1]:../../getting-started/set-up-custom-folder.md

<!-- Referenced images -->
