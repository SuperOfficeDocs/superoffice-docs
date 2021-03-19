---
title: superstate_and_soprotocol
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

The *SoContactPanel.config* file includes a lot of views. For example, soprotocol="udef", soprotocol="interest", and soprotocol="personarchive"
In the view definition, it defines the type of the view and the soprotocol name for the view.

```XML
<view id="interests" type="SoView" soprotocol="interest" current="contact">
```

The URL `www.example.com/sixweb/default.aspx?contact.interest.personarchive` contains the SoProtocol name "interest", so this page will be shown on the webpage.

<!-- Referenced links -->
[1]: ../../../soprotocol.md
