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

**SOProtocol** is a standard for defining URL short-cuts to SuperOffice entities. It lets you control the user interface without scripting and send users directly to the desired screen.

## Why use SoProtocol

* No Scripting is needed, although scripts can return to invoke an soprotocol URL.
* Works with the integrated web browser (webpages can control the CRM client user interface).
* Works with both web and Windows (legacy) clients.
* Security, it's primarily for navigation and cannot write data into the database.

SOProtocol URLs have two parts:

* [where targets][2] - which page to display and what tabs to select
* what targets - what data to display in the page, such as a specific contact or project by ID

`default.aspx?where.where...?what=id&what=id&...`

or

`soprotocol:where.where...?what=id&what=id&...`

This can also be represented as:

`default.aspx?target-screen.upper-tab.lower-tab.mini-card?[entity]_id=id&[entity]_id=id`

or

`soprotocol:target-screen.upper-tab.lower-tab.mini-card?[entity]_id=id&[entity]_id=id`

<!-- what here: is a History Item. -->

For example, on the company page, showing the main tab above and the contacts grid below, with the company details on the right, where the contact_id equals 2, use the following SoProtocol URL:

`soprotocol:contact.main.personarchive.minicontact?contact_id=2`

![08][img4]

> [!TIP]
> You can get a URL that reflects the current state of the application by selecting **Copy shortcut** either from the hamburger menu, the **Task** menu in dialogs for follow-ups and documents, or by right-clicking an item in a section tab, can get from address bar, and from developer tools: (SuperOffice.Environment.SoProtocol)

Changing the URL loads different pages, panels and cards in SuperOffice. Take the following URL for example.

`http://localhost/SuperOfficeWeb/default.aspx?project.udef`

This URL opens the project page displaying the **More** (udef) tab. Here, *project* is the target panel, and *udef* is the target upper tab view.

![01][img1]

`http://localhost/SuperOfficeWeb/default.aspx?project.links.projectmemberarchive`

This link opens the project page displaying the links tab above and the project members grid tab below:

![02][img2]

In the same config file, if we use duplicate soprotocol values for views, it will give us a conflict error message. We can create any number of views, but the soprotocol value of each view should be unique.

See the [SoProtocol targets reference][2] for a list of soprotocol targets.

## Query strings (what)

The **query string** is what comes behind the question mark (?) in the URL. Separate the whats with an ampersand `&`.

You can use the primary keys to specify what to open:

* contact_id
* person_id
* appointment_id
* sale_id
* project_id
* selection_id
* document_id

For example, to go to sale 42:

`soprotocol:sale?sale_id=42`

To go to a specific company card, set the active archive, and open an appointment:

`soprotocol:contact.main.activityarchive.appointment?contact_id=2&appointment_id=1`

## SoProtocol and SuperState

SoProtocol drives the [SuperState][1], meaning when you set an [entity]_id equal to a value, the current representation of that entity is set by the id. The SuperState is defined by the SoProtocol URL together with the values of SuperState history. If no SoProtocol is given, the last valid SuperState history will be used.

## Find current state

To get the SOProtocol link that reflects the current state of the application, use the browser address bar to view the current page information and copy the address.

> [!NOTE]
> Alternatively, use the **Copy Shortcut** option in the task button when available to get the current SoProtocol.

![03][img3]

<!-- Referenced links -->
[1]: ../web-app/pagebuilder/superstate/index.md
[2]: navigation-points.md
<!-- Referenced images -->
[img1]: media/project-udef.png
[img2]: media/project-note-projectmembersarchive.png
[img3]: media/copy-shortcut.png
[img4]: media/contact-contact_id.png
