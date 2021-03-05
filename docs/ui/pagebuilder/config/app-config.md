---
title: pagebuilder_config_app
description: Application config files
author: Tony Yates
so.date: 06.24.2016
keywords: config
so.topic: concept
so.client: web
so.envir: onsite
---

# Application config file

The application configuration file lists all the pages used in the system. It stores data like the preference section for a given page in the `UserPreference` table and what the key of the preference is. It holds the current information of a given page in the current section of the file.

## SoApplicationConfiguration

The *SoApplicationConfiguration.config* file can contain declarations for:

* pages
* dialogs
* currents
* consts
* jsincludes
* cssincludes

[!code-xml[xml](includes/soapplicationconfiguration.xml)]

In the above file, we can see that the pages are listed inside the `pages` element. The user preference data for all the pages will be stored under the *SuperMode* section and the key will be *MainPanel*.

When we go into the individual pages, it gives the page ID, the type of the page, and if it is a main page, the functional rights it has. If the page is not a main page, we can see that the size information of the page has been detailed out since it is not appearing as a page but as a dialog.

In the `currents` section, it gives details about where the application has stored the current data for a given page. For example, the below line says that the current appointment is stored in the `history` table and the provider that will retrieve the data for us is the *SoProtocolProvider*. Likewise, it will list all the current values of the application.

[!code-xml[xml](includes/soapplicationconfiguration.xml?range=14)]

## Example

The following example demonstrates how to add a page, current, Javascript, and CSS file.

```xml
<applicationsettings>
  <pages>
    <!-- new feature !!! -->
    <page id="customfeature" type="mainpage" />
  </pages>
  <currents>
    <!-- new current !!! -->
    <current id="customfeature" type="none" providername="SoProtocolProvider" />
  </currents>
  <jsincludes>
    <!-- new feature script dependency !!! -->
    <jsinclude path="~/scripts/customfeature.js" />
  </jsincludes>
  <cssincludes>
    <!-- new feature styles dependency !!! -->
    <cssinclude path="~/styles/customfeature.css" />
  </cssincludes>
</applicationsettings>
```

When the application starts, these elements are read into the memory representation of **ApplicationConfiguration.config** and ready to be used by the application when called upon.

Assuming a file called SoCustomFeature.config exists that contains the page definition for *customfeature*, it can be called and shown using SoProtocol:

```javascript
PageUpdate('soprotocol:CustomFeature','');
```

A global SuperOffice method PageUpdate issues an SoProtocol string to the server. In addition to navigation and changing the viewed configuration, SoProtocol can also update currents.

```javascript
// JavaScript.
var id = 10;
PageUpdate('soprotocol:?customfeature_id=' + id,'');
//or use SuperOffice.PageBuilder
SuperOffice.PageBuilder.setCurrent("customfeature", id);
```

To get a current value, use the *SuperOffice.Util.getCurrentId* Javascript method.

``` javascript
// get current id value
id = SuperOffice.Util.getCurrentId("customfeature");
```
