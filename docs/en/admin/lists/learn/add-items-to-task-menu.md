---
uid: help-en-task-menu-add
title: Add items to the Task menu list
description: Add items to the Task menu list
author: SuperOffice RnD
date: 01.11.2023
keywords: Settings and maintenance
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Add items to the Task menu list

When you add an item to the **Task menu** list in Settings and maintenance, the Edit list item dialog is not the same as described under [Add items][2].

This is how to fill out the fields in the Edit list items dialog for Task menu:

1. Click the Add button below the Items list.
    > Do you want to add an item to a specialised list?
    Some list types are more specialised than those referred to in this procedure. [Specialised lists][3]

1. Enter the name of the item in the **Name** field.

    > [!include[Mandatory](includes/note-mandatory-field.md)]

1. Select  the task menu you want to connect the item to.

1. Select the desired task menu type URL, CRMScript or SOProtocol.
    * URL
        * Enter the **URL address** into the URL field.
        * Choose the type of **encoding** you want.
        Want to know more about [URL encoding][4]?
    * CRMScript
        * Select which **script** you want the task menu to run.
        Want to know more about [CRMScript][5]?
    * SOProtocol
        * Enter the **SOProtocol** URL you want the list item to navigate to.
        Want to know more about [SOProtocol][6]?

1. Tick the boxes for where you want the Task menu item to show.

1. Optionally, type in a description of the item in the **Description** field. Read about [Translation][7].

1. [!include[Save or cancel](includes/save-or-cancel.md)]

> [!TIP]
> If you add a URL address, it may be useful to use template variables for the active company, for example, to retrieve information from other applications via an URL. The URL address must specify parameters, as in this fictitious example: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn here is the template variable for the organisation number, but other variables like company name &lt;name&gt;, company phone number &lt;cpho&gt;, contact name &lt;attn&gt;, can also be used.

## Is SuperOffice CRM for Web installed on an https site? (Onsite)

[!include[HTTPS restriction](includes/web-panels-and-https.md)]

## Related topics

* [Add a web panel item][1]
* [Add a translation][7]

<!-- Referenced links -->
[1]: web-panel-add-item.md
[2]: adding-items.md
[3]: specialized-lists.md
[4]: ../../../../en/ui/web-panels/url-encoding.md
[5]: ../../../automation/crmscript/learn/index.md
[6]: ../../../../en/ui/soprotocol/index.md
[7]: ../../../globalization-and-localization/learn/translate-fields.md

<!-- Referenced images -->
