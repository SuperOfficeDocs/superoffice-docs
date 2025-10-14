---
uid: help-en-ui-web-panels
title: Web panels
description: Web panels
keywords: web panel, www tab
author: digitaldiina
date: 10.13.2025
version: 11.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
language: en
index: true
redirect_from: 
  - /en/ui/web-panels/learn/index
  - /en/ui/web-panels/index
  - /en/admin/lists/learn/web-panel
---

# Web panels

A **web panel** is a configurable area inside SuperOffice CRM that displays content from a web page or internal resource, based on a URL. This lets you integrate external data sources or internal tools directly into the CRM interface.

Web panels can appear in various locations and are tailored to the context the user is working in, such as a company card, request, or follow-up.

## Content types supported by web panels

Web panels support a range of content types:

* **URLs:** external web pages or internal systems
* **Screens:** SuperOffice CRM screen shortcuts
* **Selections:** shortcuts to selections
* **Scripts/macros:** actions triggered via a button or menu

## Display locations for web panels

The **display location** is defined when you configure the panel. This controls where in SuperOffice the panel appears.

* **Side panel** – Appears in the collapsible panel on the side of many CRM screens.
* **Toolbar** – Adds a button to the toolbar.
* **Navigator button** – Adds a button to the main menu.
* **Panels:**
  * **Company, Contact, Project, Sale, and Selection cards** – Adds a shortcut in the **www** tab for each screen.
  * **Web panel on SuperOffice button** – Opens from the SuperOffice logo (upper left corner). Multiple URLs appear as tabs on the right.
  * **Section tabs (in Company, Contact, Project, Sale screens)** – Adds a separate tab that opens the panel content.
* **Dialogs:**
  * **Follow-up dialog** – Adds a shortcut in the **www** tab of the follow-up dialog.
  * **Document, Product, and Quote dialogs** – Adds a shortcut in the **www** tab of each dialog.
* **Menus:**
  * **Toolbox menu** – Appears under **Other Applications** when clicking the **Tools** button in the Navigator.
  * **View menu** – Appears in the **Other Applications** menu option.
* **Dashboard tiles** – Available in the tile content selector for dashboard widgets.

### In Service (legacy)

* Main screen
* Request screen
* Company screen
* Contact screen
* Extra table entry screen

## <a id="www"></a>The www tab

In places like Company, Contact, Project, and Sale, web panels are often displayed under the **www** tab.

You can rename the tab in **Settings and maintenance** > **Options** > **Labels**. To reposition the tab within the CRM interface, use the **GUI – Web panel** list.

### Open in separate window

All embedded URLs can be opened in a separate browser window using **Open in separate window**.

## How web panels work

Web panels dynamically load content based on CRM context and the URL defined for the panel:

1. A user opens a record (for example, a company).
1. The system computes the URL using available template variables.
    * For example, `http://server/page.asp?id=<cuid>` becomes `http://server/page.asp?id=123`
1. If the new URL is different from the previous one, the system sends a new request.
1. The server responds with the appropriate web page: it receives the URL, computes the page using URL parameters, and returns the result.
1. The panel renders the web page inside SuperOffice CRM.

## Related content

* [Add web panel][1]
* [Building web panels][2]

<!-- Referenced links -->
[1]: add-web-panel.md
[2]: ../../../../en/customization/web-panels/dev/index.md

<!-- Referenced images -->
