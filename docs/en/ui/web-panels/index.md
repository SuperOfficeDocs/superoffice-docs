---
title: Web panels
uid: web_panels
description: Web panels
author:
date:
keywords: ui
content_type: concept
---

# Web panels

A **web panel** is a webpage that is displayed inside SuperOffice CRM.

Where your web panel appears is determined by the display location.
The content of your web panel is determined by the URL.

The URL of the webpage can contain **template variables**, so that what the page displays depends on the client context. Whenever the URL of a webpage changes, the page will be reloaded (if it is visible).

## How web panels work

1. The user clicks a *company* in a search result.
2. The web panel computes the URL based on the selected company.
    * For example, `http://server/page.asp?id=<cuid>` becomes `http://server/page.asp?id=123`
3. If the new URL is different from the current, a request is sent to the webserver.
4. The webserver receives the URL.
5. The web server computes a new webpage using parameters in the URL.
6. The web server returns the webpage.
7. The web panel displays the page.

## Places you can add web panels

The **display location** of a web panel is selected as *Visible in* when you define the panel.

### In Sales

* Navigator button (main menu)
* Side panel
* Toolbar
* Toolbox menu, View menu
* Task button
  * Contact dialog
* Dialogs
  * Follow-ups dialog
  * Document dialog
  * Product dialog
  * Quote dialog
* Panel
  * Company card
  * Contact card
  * Project card
  * Sale card
  * Selection card
  * Web panel on SuperOffice button
  * Company screen selection tab
  * Contact screen selection tab
  * Project screen selection tab
  * Sale screen section tab

### In Service

* Main screen
* Company screen
* Contact screen
* Request screen
* Extra table entry screen
