---
title: SoProtocol
uid: soprotocol
description: SoProtocol
author: Tony Yates
date: 09.24.2024
version: 10.3
keywords: soprotocol, deeplinking
topic: concept
---

# SoProtocol

**SOProtocol** is a standard for defining URL short-cuts to SuperOffice entities. It lets you control the user interface without scripting and send users directly to the desired screen.

## Why use SoProtocol

* No Scripting is needed, although scripts can [invoke an soprotocol URL][4].
* Works with the integrated web browser (webpages can control the CRM client user interface).
* Works with both web and Windows (legacy) clients.
* Security, it's primarily for navigation and cannot write data into the database.

## How is an SoProtocol URL defined

SOProtocol URLs have multiple parts, and can be either opened directly in the browser:
`https://{{environment}}.superoffice.com/{{tenant}}/default.aspx?{{WHERE}}?{{WHAT}}`

Or can be [invoker through a script][4]:
`soprotocol:{{WHERE}}?{{WHAT}}`

The {{WHERE}} tells SuperOffice which page to display, and what tabs to select.
The {{WHAT}} tells SuperOffice what data to display on the page, such as a specific contact or project by id.

Example:
`https://{{environment}}.superoffice.com/{{tenant}}/default.aspx?target-screen.upper-tab.lower-tab.mini-card?[entity]_id=id`

or

`soprotocol:target-screen.upper-tab.lower-tab.mini-card?[entity]_id=id`

## Practical examples

On the company page, showing the main tab above and the contacts grid below, with the company details on the right, where the contact_id equals 2, use the following SoProtocol URL:

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

## SoProtocol and SuperState

SoProtocol drives the [SuperState][1], meaning when you set an [entity]_id equal to a value, the current representation of that entity is set by the id. The SuperState is defined by the SoProtocol URL together with the values of SuperState history. If no SoProtocol is given, the last valid SuperState history will be used.

## Find current state

To get the SOProtocol link that reflects the current state of the application, use the browser address bar to view the current page information and copy the address.

> [!NOTE]
> Alternatively, use the **Copy Shortcut** option in the task button when available to get the current SoProtocol.

![03][img3]

> [!TIP]
> It is possible to test an SoProtocol by running PageUpdate in the console/browser's DevTools. For instance, opening a [CustomObject][3] can be achieved by running the command 'PageUpdate("soprotocol:customobject?customobject_name=y_car&customobject_id=1");'.

<!-- Referenced links -->
[1]: ../web-app/pagebuilder/superstate/index.md
[2]: navigation-points.md
[3]: custom-object.md
[4]: ./in-crmscript.md

<!-- Referenced images -->
[img1]: media/project-udef.png
[img2]: media/project-note-projectmembersarchive.png
[img3]: media/copy-shortcut.png
[img4]: media/contact-contact_id.png
