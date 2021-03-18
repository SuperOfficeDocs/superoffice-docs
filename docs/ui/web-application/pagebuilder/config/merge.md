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

# Merge process

While the system supports modifying configuration files copied directly from the application into a custom path folder, it's generally cleaner to instead use merge files.

Merge files have a .merge file extension and make it easy to add, remove or replace configuration elements without touching the original application files.

Regardless of approach, it's important to know how to target a specific location in a configuration file so that the customization appears in the application where it is expected.

Different element tags use one or more attributes to ensure each element with the same tag has a unique identity. Having a unique element identity is important to resolve which element is affected. The following table maps which element relies on which identifier(s) to ensure uniqueness.

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

## Merge Actions

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

---

You can specify the merge action by adding an attribute called mergeaction. There are three actions available:

* Insert (default), inserts the section
* Replace, replaces the section with same id-value
* Remove, removes the section.

The example below will replace the controlgroup ‘maingroup\_2’ in the page named Contact

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
