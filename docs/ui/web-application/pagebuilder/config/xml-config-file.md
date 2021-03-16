---
title: pagebuilder_config
description: PageBuilder XML config file
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# XML config file

The PageBuilder is the tool used by CRM.web to build a webpage. The PageBuilder uses the [pagename]Page.config file to build a specific web page. The config tells the PageBuilder about the contents of the page. Like the number of panels and DataHandlers used.

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

The code segment above describes the element structure of the page. It consists of main sections like data section and panels. The data tag tells the PageBuilder where to fetch the data to display on this page. Within the panels tag, all the panels are included in the config file by reference, which means that the definitions of the panels are in separate files. For example, The **Menu** panel is defined in the file *SoMenuPanel.config*.

## SoObjectMapping.config

The objects are identified by the relevant config file based on an *ObjectMapping* file. This file is called *SoObjectMapping.config* and it maps the objects of the webpages to the actual ASP.net objects.

The below code segment is mapped to the ContactEntityDataHandler object.

```XML
<object type="IDataHandler" mappingname="ContactEntityDataHandler" assemblyname="SuperOffice.CRMWeb" objectname="SuperOffice.CRM.Web.Data.ContactEntityDataHandler"></object>
```

## How to customize

The PageBuilder framework controls all these config files. Any third-party customizations can be plugged into the PageBuilder framework.

For example, if we were to build our own page using by using SO controls such as UI controls, SoProtocols, and DataHandlers the PageBuilder framework will be able to identify these controls and construct the webpage.
