---
title: The role of SoProtocol
uid: superstate_and_soprotocol
description: The role of SoProtocol in SuperState
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# The role of SoProtocol

The SuperState depends on the [SoProtocol][2], which allows you to control the user interface without using scripts. The protocol is defined by SuperOffice to interpret what should be shown on a page and gives you the possibility of sending a link to the user that will open another specific panel based on the information sent. If no SoProtocol is given, the last valid SuperState will be used.

Configuration files use a tag called `soprotocol` inside the panels and views. For example, the following code segments in SoContactPanel.config shows how we can set the values to soprotocol tag.

[!code-xml[XML](../includes/socontactpanel-config.xml?range=2)]

```XML
<view id="interests" type="SoView" soprotocol="interest" current="contact">
```

The URL `www.example.com/sixweb/default.aspx?contact.interest.personarchive` contains the SoProtocol name "interest", so this page will be shown on the webpage.

The link opens the contact page by activating the interest tab in the main card. Soprotocol value of the panel is *contact* and the soprotocol value set in the interest view in the main card is *interest*. These values are used to open the page which is requested by us. Panels and views are arranged on a page according to the information sent by the SoProtocol part of the URL.

It will look slightly different for a normal website and a website that is hosted as a virtual directory:

**Website:**

`http://www.webclient.example.com/default.aspx?contact.main.personarchive?contact_id=2&person_id=4445`

**Virtual directory:**

`http://www.example.com/webclient/default.aspx?contact.main.personarchive?contact_id=2&person_id=4445`

When the SoProtocol string changes, it tells the system that it needs to show something different on the page. So now the SuperState knows that the SoProtocol has changed and will get the new parts of the page and the data from the cache or the database.

For example, we change the above SoProtocol string to look like below:

`http://www.example.com/webclient/default.aspx?contact.main.personarchive?contact_id=3&person_id=105`

That `contact_id` and `person_id` have changed tells the SuperState to check for the availability of the data in the cache. If it is in the cache, it will be pulled from the cache. Otherwise, it will be pulled from the database.

The PageBuilder on the other hand works with SuperState to render a given page:

* When the SoProtocol says what it wants to show on a given page, the SuperState will gather necessary page config data and the data that needs to be shown on the page.
* PageBuilder will format the page according to the config data of the page and render the page along with its data.

> [!CAUTION]
> Use unique soprotocol values for each view within a config file. Otherwise, if we include the same soprotocol value for several views, once the page opens there will be a conflict on which tab to be activated.

## Reference

Many soprotocol tags are used in the *SoContactPanel.config* . Some of them are listed below.

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
[1]: ../../../soprotocol.md
