---
title: usercontrols_soprotocol
description: SoProtocol names
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concepts
so.client: web
so.envir: onsite
---

# SoProtocol names

The [SoProtocol][1] allows you to control the user interface without using scripts. This protocol gives you the possibility of sending a link to a user that opens another specific panel based on the information sent.

Configuration files use a tag called `soprotocol` inside the panels and views. For example, the following code segments in SoContactPanel.config shows how we can set the values to soprotocol tag.

[!code-xml[XML](../includes/socontactpanel-config.xml?range=2)]

```XML
<view id="interests" type="SoView" soprotocol="interest" current="contact">
```

`http://localhost/SuperOfficeWeb/default.aspx?contact.interest`

The above link opens the contact page by activating the interest tab in the main card. Soprotocol value of the panel is *contact* and the soprotocol value set in the interest view in the main card is *interest*. These values are used to open the page which is requested by us. Panels and views are arranged on a page according to the information sent by the SoProtocol part of the URL.

> [!CAUTION]
> Use unique soprotocol values for each view within a config file. Otherwise, if we include the same soprotocol value for several views, once the page opens there will be a conflict on which tab to be activated.

## Reference

Many soprotocol tags are used in the SoContactPanel.config . Some of them are listed below.

```XML
<view id="interests" type="SoView" soprotocol="interest" current="contact">

<panel id="Contact" type="SplitterPanel" soprotocol="Contact" paneltype="Main" placeholderid="MainPlaceHolder">

<view id="more" type="SoView" soprotocol="udef" current="contact">

<view id="ContactPersonArchiveView" type="SoView" soprotocol="personarchive">

<view id="ContactRelationArchiveView" type="SoView" soprotocol="relationarchive">

<view id="ContactProjectArchiveView" type="SoView" soprotocol="projectarchive" >

<view id="ContactActivityArchiveView" type="SoView" soprotocol="activityarchive" >
```

The soprotocol names defined in the view and panel tag are not listed anywhere else. You can define your own soprotocol names by changing the value in the soprotocol attribute.

SuperOffice uses the *SoUdefConfiuration.config* file to determine which set of user-defined fields to load into the udef controls used in the various views.

[!code-xml[xml](includes/soudefconfiuration.xml)]

<!-- Referenced links -->
[1]: ../../../soprotocol/index.md

<!-- Referenced images -->