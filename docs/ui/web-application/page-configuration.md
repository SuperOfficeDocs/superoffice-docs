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

## Configuration lifecycle

Callback requests made to the server are in the form of soprotocol.  The SoProtocolModule parses the soprotocol string and updates the SuperState and Current system, reflecting the changes made from the last request.  These changes are used by the ContextFilter to modify the configuration. Parts of the configuration that are not affected by the changes in SuperState/Current are removed.  When the PageBuilder receives the configuration it has no knowledge of what to render and what to not render. The PageBuilder only builds what the configuration tells it to build.

Before the unchanged parts of the page are stripped away, we need to build the entire page configuration, this has several step:

* The page configuration is parsed multiple times

  * Fragments are resolved and put together.
  * Data driven config for WWW panels and external applications are generated
  * The merge-filter does merges custom merge files with standard configuration files
  * Caching

* First cached in the database to reduce startup time after an application recycle
* Then cached in the application session for optimal access to the fully parsed configuration
* Use the magic Flush command to clear the cache both on client and server
  * Last but not least the context filter and many other filters
* Main purpose is to reduce client output, enforce rules(rights) based on client state/user

Below is an illustration of the growth and shrinking of a page configuration

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
