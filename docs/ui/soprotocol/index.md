---
title: soprotocol       
description: SoProtocol
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
---

# SoProtocol

By changing the URL we can load different panels and cards into SuperOffice.

For one page there can be a lot of views, but the `soprotocol` tag of each view should be unique within a page. By calling the soprotocol, which is in a particular view, we can directly open the page by activating the tab(view) which we need to be activated.

`<http://localhost/SuperOfficeWeb/default.aspx?project.udef>`

The above link opens the project page displaying the **More** (udef) tab. Here, *project* is the soprotocol value set in the panel and *udef* is the soprotocol value set in the view. It generates the following output:

![01][img1]

`<http://localhost/SuperOfficeWeb/default.aspx?project.event.projectmemberarchive>`

This link opens the project page displaying the event tab and Project Member tab:

![02][img2]

In the same config file, if we use duplicate soprotocol values for views, it will give us a conflict error message. We can create any number of views, but the soprotocol value of each view should be unique.

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/image002.jpg
