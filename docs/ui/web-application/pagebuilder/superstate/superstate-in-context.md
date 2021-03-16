---
title: superstate_in_context
description: How does Super State work with SOProtocol and Pagebuilder
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# How does SuperState work with SoProtocol and Pagebuilder

Let’s look at how SuperState works with the other important components of SuperOffice.

The main components that work with the SuperState are the SoProtocol module and the PageBuilder module.

* [SoProtocol][1] interprets what is to be shown on a given page
* [PageBuilder][2] builds and renders the page

The SoProtocol is a protocol that is defined by SuperOffice to define what should be shown on a page. Given below is how the SoProtocol will look like for a normal website and a website that is hosted as a virtual directory.

Website

`http://www.webclient.example.com/default.aspx?contact.main.personarchive?contact_id=2&person_id=4445`

Virtual directory

`http://www.example.com/webclient/default.aspx?contact.main.personarchive?contact_id=2&person_id=4445`

When the SoProtocol changes, it tells the system that it needs to show something different on the page. So now the SuperState knows that the SoProtocol has changed and will get the new parts of the page and the data from the cache or the database.

For example, we change the above SoProtocol string to look like below:

`http://www.example.com/webclient/default.aspx?contact.main.personarchive?contact_id=3&person_id=105`

That `contact_id` and `person_id` have changed tells the SuperState to check for the availability of the data in the cache. If it is in the cache, it will be pulled from the cache. Otherwise, it will be pulled from the database.

The PageBuilder on the other hand works with SuperState to render a given page. When the SoProtocol says what it wants to show on a given page, the SuperState will gather necessary page config data and the data that needs to be shown on the page. PageBuilder will format the page according to the config data of the page and render the page along with its data.

<!-- Referenced links -->
[1]: ../framework/soprotocol.md
[1]: ../framework/index.md

<!-- Referenced images -->
