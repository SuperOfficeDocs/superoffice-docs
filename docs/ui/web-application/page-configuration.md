---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: page_configuration       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Page configuration files

## Adding a new page

When making a new page you can split the configuration in several fragments for reuse and readability.

You can place the files in any folder as long as it is placed in the custom path folder. The only requirement is  to use the correct naming convention. This allows you to group your configuration fragments as you wish.

Example contact page:

Defined in ApplicationConfiguration:

```xml
<page id="contact" type="mainpage" function-right="hide-company" />
```

The file name must then be:  So**Contact**Page.config. The postfix ‘page’ must be the same as the root element name. The name  a fragment of a controlgroup would look like this SoMyCGFragControlGroup.config

### Fragments

Fragments can be reused in multiple pages, but when used in the same page you need to ensure unique ids. This can be done using referenceWithIdUpdate attribute.

Example of a fragment reference with id update:

```xml
<controlgroups>

  <controlgroup id="MoreMainHeaderGroup" referenceWithIdUpdate="MyCGFrag" />

...
```

All id attributes in the fragment are prefixed with ref. id

```xml
<controlgroups>

  <controlgroup id="MoreMainHeaderGroup_OrgId" type="ControlGroup" />

...
```

### Customize an existing page

When customizing an existing page you have to change or add sections of the configuration. It is important to ease the trouble of upgrading and other partners operating in the same pages. You can accomplish this by making use of merge files.

You can remove, replace and add sections of configuration xml with merge files. The merge is id-based making it durable between minor version upgrades and even major upgrades if the page only has small changes.

NB! Fragments and references cannot be used in the merge files since the merge filter is executed after the fragment resolving.

Page merge is id-based. It uses id attribute to pinpoint location of merge.

### Merge actions

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
