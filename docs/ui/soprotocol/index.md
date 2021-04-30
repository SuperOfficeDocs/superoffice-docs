---
title: SoProtocol
uid: soprotocol
description: SoProtocol
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
---

# SoProtocol

**SOProtocol** is a standard for defining URL short-cuts to SuperOffice entities. It lets you control the user interface without scripting and send users directly to the entry in question.

SOProtocol URLs have a navigation part and a content part.

`superoffice:where.where...?what=id&what=id&...`

<!-- what here: is a History Item. -->

For example, to go to the contact with contact_id=2:

`superoffice:contact.main?contact_id=2`

![08][img4]

> [!TIP]
> You can get a URL that reflects the current state of the application by selecting **Copy shortcut** either from the hamburger menu, the **Task** menu in dialogs for follow-ups and documents, or by right-clicking an item in a section tab,

> [!TIP]
> Can get from address bar, and from Developer Tools: (SuperOffice.Environment.SoProtocol)

For example:

`person.main.activityarchive?diaryowner_id=5&person_id=1&contact_id=1&appointment_id=90&sale_id=1&document_id=2`

By changing the URL we can load different panels and cards into SuperOffice.

For one page there can be a lot of views, but the `soprotocol` tag of each view should be unique within a page. By calling the soprotocol, which is in a particular view, we can directly open the page by activating the tab(view) which we need to be activated.

`<http://localhost/SuperOfficeWeb/default.aspx?project.udef>`

The above link opens the project page displaying the **More** (udef) tab. Here, *project* is the soprotocol value set in the panel, and *udef* is the soprotocol value set in the view. It generates the following output:

![01][img1]

`<http://localhost/SuperOfficeWeb/default.aspx?project.event.projectmemberarchive>`

This link opens the project page displaying the event tab and Project Member tab:

![02][img2]

In the same config file, if we use duplicate soprotocol values for views, it will give us a conflict error message. We can create any number of views, but the soprotocol value of each view should be unique.

## Why use SoProtocol

* No Scripting is needed.
* Works with the integrated web browser (webpages can control the CRM client user interface).
* Works with normal internet explorer.
* Works with both Windows and web clients.
* The web page cannot write data into the database, it can only show the data.

## Find current state

To get the SOProtocol link that reflects the current state of the application, use the view page info option available and copy the address.

> [!NOTE]
> When running SuperOffice in a Firefox browser, we can use the **Copy Shortcut** option on the task button to get the address.

![03][img3]

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/image002.jpg
[img3]: media/image003.jpg
[img4]: media/image008.jpg
