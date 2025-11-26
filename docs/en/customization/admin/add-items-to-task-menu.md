---
uid: help-en-task-menu-add
title: Add items to the Task menu list
description: Add items to the Task menu list
keywords: Task menu
author: digitaldiina
date: 10.28.2025
version: 10.5
content_type: howto
category: customization
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /en/admin/lists/learn/add-items-to-task-menu
language: en
---

# Add items to the Task menu list

## Steps

1. Select <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lists** in the Navigator.

1. Select **Task menu** from the dropdown menu.

1. Click the **Add** button below the Items list.

1. Enter the name of the item in the **Name** field. *(Mandatory)*

1. Select the task menu you want to connect the item to.

1. Select the desired task menu type:

    * URL: Enter the **URL address** into the URL field and choose the type of [URL encoding][4] you want.
    * [CRMScript][5]: Select which **script** you want the task menu to run.
    * [SOProtocol][6]: Enter the **SOProtocol** URL you want the list item to navigate to.

1. Tick the boxes for where you want the Task menu item to show.

1. Optionally, type in a description of the item in the **Description** field. Read about [Translation][7].

1. Click **Save** to save the changes or **Cancel** to reject them.

## Using template variables

If you add a URL address, it may be useful to use template variables for the active company, for example, to retrieve information from other applications via an URL. The URL address must specify parameters, as in this fictitious example: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn here is the template variable for the organization number, but other variables like company name &lt;name&gt;, company phone number &lt;cpho&gt;, contact name &lt;attn&gt;, can also be used.

## Is SuperOffice CRM for Web installed on an https site? (Onsite)

[!include[HTTPS restriction](../includes/web-panels-and-https.md)]

## Related topics

* [Add a web panel item][1]
* [Add a translation][7]
* [Specialized lists][3]

<!-- Referenced links -->
[1]: ../web-panels/admin/add-web-panel.md
[3]: ../../admin/lists/specialized-lists.md
[4]: ../web-panels/admin/url-encoding.md
[5]: ../macros-and-scripts/admin/index.md
[6]: ../../../en/customization/soprotocol/index.md
[7]: ../../localization/learn/translate-fields.md

<!-- Referenced images -->
