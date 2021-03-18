---
title: pagebuilder_config
description: PageBuilder config files
author: Tony Yates
so.date: 06.24.2016
keywords: config
so.topic: concept
so.client: web
so.envir: onsite
---

# PageBuilder config files

The PageBuilder is the mechanism that is defined by SuperOffice to build the pages of the CRM.web application. This section will focus on the many different config files that PageBuilder uses.

## Intro

The PageBuilder uses the [pagename]Page.config file to build a specific webpage. The config tells the PageBuilder about the contents of the page. Like the number of panels and DataHandlers used.

The following is an example of the *SoConactPage.config* file.

```XML
<page id="ContactPage">
  <data>
    <datahandlers>
      <!-- Some other code-->
      <datahandler id="ContactEntityDataHandler" type="ContactEntityDataHandler"></datahandler>
      <!-- Some other code-->
    </datahandlers>
  </data>
  <panels>
    <panel reference="Menu" />
    <panel reference="ButtonBar" />
    <panel reference="Navigator" />
    <panel reference="Contact" />
  </panels>
</page>
```

The code segment above describes the element structure of the page. It consists of main sections like data section and panels. The `data` element tells the PageBuilder where to fetch the data to display on this page. Within the `panels` element, all the panels are included in the config file by reference, which means that the definitions of the panels are in separate files. For example, The **Menu** panel is defined in the file *SoMenuPanel.config*.

The objects are identified by the relevant config file based on an [object-mapping][1] file. This file is called *SoObjectMapping.config* and it maps the objects of the webpages to the actual ASP.net objects.

The below code segment is mapped to the ContactEntityDataHandler object.

```XML
<object type="IDataHandler" mappingname="ContactEntityDataHandler" assemblyname="SuperOffice.CRMWeb" objectname="SuperOffice.CRM.Web.Data.ContactEntityDataHandler"></object>
```

## Why create all pages through CONFIG files?

* The ability to customize the application by only editing few XML files. Since all these config files are controlled and managed by the PageBuilder, any third-party customizations can be added in a way the framework will understand.

* It allows customizations to be done without altering the HTML files directly. This makes keeping track of customizations easier when upgrading to a new version of CRM.web.

* It is easy to validate properly structured XML files. If the system is going to depend on the config files, validation is very important since you can catch most of the issues at compile time rather than when executing the code.

> [!TIP]
> Familiarize yourself with PageBuilder before going into more detail on the config files.

## System configuration files

Configuration files make up both the infrastructure components and user-interface (UI) components of the application.

Infrastructure components are a collection of files that represent the system itself and are referred to as system files. They declare every application dependency, including web controls, currents, menu items, and pages. These files essentially describe the skeleton of the entire web application.

* [SoApplicationConfiguration.config][2]: contains all of the page and dialog declarations, essentially cataloging all of the files that represent UI components.

* [SoObjectMapping.config][3] maps all element types used in page configurations to user controls and web controls defined in assemblies.

Both of these system files contain more than what's described here, but this explanation is useful in that it describes how the contents of system files are different than dedicated page configuration files.

**Other files considered to be system files include:**

* SoAdminApplicationConfiguration.config
* SoFilterList.config
* SoArchiveColumnList.config
* [SoArchiveControlLinkInfoTypes.config][4]
* SoArchiveCriteriaList.config
* SoMenuConfiguration.config

## Page configuration files

What's shown in a browser window is generally associated with being a UI configuration component.

![PageFramework][img1]

The following SOML represents a dialog page called *SoPlainCardDialog.config*. It contains a root element [page][5] and contains 2 child elements, `title` and `panels`. The **panels** element is a container for one or more [panel][6] elements. In this case it only contains one panel of type `SoDialogPanel`.

The panel element contains a **cards** child element and this represents a contains for one or more [card][7] elements. In this case, only one card of type `SoDialogSimpleCard` is declared.

The `card` element contains a **views** element, which is a container for one or more [view][8] elements. In this case, only one view of type `SoDialogSimpleView` is declared.

The `view` element contains a **controlgroups** element, which is a container for one or more `controlgroup` element. In this case, only one group of type `SoControlGroup` is declared.

The `controlgroup` element contains a **controls** element, which is a container for one or more `control` elements. In this case, only one control of type `SoLabel` is declared.

Beginning to see a pattern yet?

[!code-xml[XML](includes/soplaincarddialog.xml)]

### Config element

All elements have child **config** elements for additional functionality, but only certain controls use them. Here the card uses a `config` element to define a CSS style that should override the default. It's up to the control implementation to define what child elements are available in the config element and then process each accordingly.

## How to customize

The PageBuilder framework controls all these config files. Any third-party customizations can be plugged into the framework.

For example, if we were to build our own page using by using SO controls such as UI controls, SoProtocols, and DataHandlers the PageBuilder framework will be able to identify these controls and construct the webpage.

There are 2 approaches to apply a configuration change: complete structure or using an XPath element. System files must use the complete structure approach, whole UI pages can use either one or both.

### Complete structure approach

Using the complete structure approach means creating a merge file with the complete page structure up to the element with a `mergeaction` attribute. Using this approach, the merge filter can accurately determine which element to process.

The following example demonstrates how to replace a control group in the SoContactPage configuration. Take notice of how each ID along the path is defined for the page, panel, card, view, and finally the control group. Make sure to also include the **< pages >** root element.

[!code-xml[XML](includes/socontactpage.merge.xml)]

Without stating id values at each stage of the structure, the filter would not be unable to determine which page>panel>card>view>controlgroup path to replace and the merge would be ignored.

## XPath element approach

XPath is a new approach to add page elements that even supports adding elements across fragments!

> [!NOTE]
> This capability applies only to the contents of UI pages and dialogs and **is not applicable to system files**. XPath also requires SuperOffice 8.1 or newer.

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

> [!CAUTION]
> Because pages can contain duplicate element IDs at various nested levels, care must be taken when using this approach to ensure no unusual side effects occur. The potential for XPath side effects was enough to deem this capability too powerful for replace and remove actions.

## Data-driven

Config for web panels and external applications are generated using templates. These reside in the Service layer.

Some parts of the configuration file are filled in according to data in the database. The PageBuilder framework replaces part of the config file with new data generated from information in the database.

For example, the layout of the user-defined fields on the **More** tab is stored in the database in the `UDefField` table. The actual values in the user-defined fields are stored in a different table.

The config for the **More** tab on the company card looks like this:

```XML
<view id="more" type="SoView" soprotocol="udef" current="contact">
  <caption>[SR_MORE_CONTACT]</caption>
  <controlgroups>
    <controlgroup id="contactmainmoreudefgroup" type="SoControlGroup" left="16px" right="20px" top="85px" bottom="54px" overflow="auto" position="absolute">
      <controls>
      </controls>
      <config>
        <grouptype>absolute</grouptype>
      </config>
    </controlgroup>
  </controlgroups>
</view>
```

The control group is empty, but the framework knows that it needs to place the controls defined in the `UdefField` table in the database inside this element because of the *SoUdefConfiguration.config* file defines the ID of the control group.

The PageBuilder generates the controls needed to show the user-defined fields using the data in the `UdefField` table in the database.

## Configuration cache

Caches exist in the database and the application. Fragments and data-driven config are cached in the database. The post MergeFilter is run on the client. Use the magic `?Flush` command to clear the cache both on the client and server.

You should turn off the cache during development - or you won't see changes to the config file appear in the GUI.

<!-- Referenced links -->
[1]: object-mapping.md
[2]: soapplicationconfiguration.md
[3]: object-mapping.md
[4]: soarchivecontrollinkinfotypes.md
[5]: page.md
[6]: panel.md
[7]: card.md
[8]: view.md

<!-- Referenced images -->
[img1]: media/web-client-pagebuilder-framework2.png