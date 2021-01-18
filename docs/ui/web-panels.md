---
title: web_panels
description: Web panels
author:
so.date:
keywords:
so.topic:
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
5. The webserver computes a new webpage using parameters in the URL.
6. The webserver returns the webpage.
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

## Adding a web panel

### In Sales

1. Sign in to the SuperOffice CRM Admin client.
2. Select **Lists**.
3. Using the drop-down at the top, select **GUI - Web panel**. Then click **Add** (bottom left corner).
4. Enter name (UI label) and window name (ID).
5. Enter URL and select URL encoding.
6. Select display location and optionally set other settings.
7. Click **Save**.
8. Test the result.

### In Service

In Service, web panels are called **extra browser tabs**. You can add the same type of content as for [extra menus](./extra-menus.md).

1. Sign in to SuperOffice Service.
2. From the hamburger menu, select **System Design** and then select **Web panels**.
3. Point to the target display location and click **New web panel**.
4. Enter a UI label (the tab text)
5. Select either **Use URL** or **Use screen** and then select the corresponding details.
6. Select where to insert your new menu item from the **Position** list (0 = top).
7. Click **OK**.
8. Test the result.

> [!TIP]
> Read more about [base programs and URL parameters](./url-parameters.md).

## Url encoding

Browsers request pages from web servers by using a URL - the **address of a webpage**.
These URLs can only be sent over the Internet as ASCII characters. However, they will often contain non-ASCII characters, for example, *space*.

**URL encoding** converts the original URL to the correct format. When you add new web panels, you may choose URL encoding directly in a drop-down menu.

### ANSI

Conversion replaces unsafe characters with a percent (%) followed by 2 hexadecimal digits. For example, space becomes *%20*. Thus:

* Characters up to 0x7F (127) are passed along unmodified
* Characters from 0x7F to 0xFF are encoded

### Unicode

Conversion transforms all characters to UTF-8 and then prefixes each character's 1–3 byte hexadecimal value with % according to [RFC 2279](http://www.ietf.org/rfc/rfc2279.txt).

## Passing data with template variables

You can use template variables to pass data to the destination page to tailor it to the client context. This could be information about the current contact, person, or project.

For example, instead of `http://www.search.com/search?q=SuperOffice`, we can use the template variable for *company name* - which is \<name> - and type `http://www.search.com/search?q=<name>`

**Available variables:**

* [for CRM](https://community.superoffice.com/documentation/help/EN/CRM/8.5/UserHelp/index.htm#t=StandardCRM%2Fchap02%2FTemplate_variables.htm)
* [for Service](https://community.superoffice.com/documentation/help/EN/CRM/8.5/UserHelp/index.htm#t=Service%2Ftopics%2FTemplate_variables.html)

Here's how it works:

1. Append the template variables to the URL when editing the web panel properties.
    * Type the URL without padding (no extra spaces). SuperOffice handles the URL encoding.
    * Separate the parameters with an ampersand `&`.

2. Write the code of the target webpage so that it does something useful with the template variables.

> [!TIP]
> You can also pass template variables as **hidden variables** in your [custom screens](./custom-screens/custom-screens.md). And then do something like this in the suitable load or creation script:

```crmscript
User u;
u.load(getVariable("activeUser").toInteger());
```

## Link to a web panel

You can **add a link** in your web panel that will load another panel when pressed.

The HTML \<a> tag has multiple attributes. In addition to the **href** attribute, we can set the **target** attribute to specify *where* to open the link.

Syntax:

```html
<a target="_blank|_self|_parent|_top|framename">
```

* To open a link in a new browser window, set `target="_blank`
* To open a link **in your panel**, set `target=<window name>`

For example, `target="project.pdetails"` with link text *Show project info*.

## Reference

| Setting      | Description                                                           |
|:-------------|:----------------------------------------------------------------------|
| Name         | UI label                                                              |
| Window name  | ID of the panel, used in the HTML you load into the panels<br/>Must be unique, use prefixes |
| Description  | Tool-tip text                                                         |
| URL          | Location of web page                                                  |
| URL encoding | None, ANSI, or Unicode                                                |
| Visible in   | The display location                                                  |
| Available on | Device type (web, mobile)                                             |
| Show         | Whether to show the menu bar, toolbar, address bar, and/or status bar |
