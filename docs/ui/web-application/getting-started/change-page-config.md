---
title: change_page_config
description: How to alter page configuration files
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: howto
so.envir: onsite
so.client: web
---

# How to alter page configuration files

While element placement might not be important for system configuration files, modifying elements in a page or dialog must be structured accordingly. A page contains cards, and cards contain views, and views contain controlgroups and so on, and knowing how to structure a merge definition is critical to successfully deploying a change.

There are 2 approaches to apply a configuration change: complete structure or using an xpath element. System files must use the complete structure approach, whole UI pages can use either one or both.

## Complete structure approach

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

## XPath Element Approach

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

## Adding a new page

When making a new page you can split the configuration in several fragments for reuse and readability.

You can place the files in any folder as long as it is placed in the custom path folder. The only requirement is to use the correct naming convention. This allows you to group your configuration fragments as you wish.

Example contact page:

Defined in ApplicationConfiguration:

```xml
<page id="contact" type="mainpage" function-right="hide-company" />
```

The file name must then be:  So**Contact**Page.config. The postfix ‘page’ must be the same as the root element name. The name  a fragment of a controlgroup would look like this SoMyCGFragControlGroup.config

## Customize an existing page

When customizing an existing page you have to change or add sections of the configuration. It is important to ease the trouble of upgrading and other partners operating in the same pages. You can accomplish this by making use of merge files.

You can remove, replace and add sections of configuration xml with merge files. The merge is id-based making it durable between minor version upgrades and even major upgrades if the page only has small changes.

NB! Fragments and references cannot be used in the merge files since the merge filter is executed after the fragment resolving.

Page merge is id-based. It uses id attribute to pinpoint location of merge.
