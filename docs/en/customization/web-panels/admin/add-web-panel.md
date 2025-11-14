---
uid: help-en-add-web-panel
title: Add web panel
description: How to add items to the web panel list in Settings and maintenance.
keywords: web panel, GUI - Web panel list
author: digitaldiina
date: 11.04.2025
version: 11.6
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
content_type: howto
language: en
index: true
redirect_from: 
  - /en/admin/lists/learn/web-panel-add-item
  - /en/ui/web-panels/add-web-panel
---

# Add web panel

[!include[Must be admin](../../../learn/includes/req-admin.md)]

Web panels are defined in the **GUI - Web panel** list, which you can manage in **Settings and maintenance** under **Lists**. Where your web panel appears is determined by the display location. The content of your web panel is determined by the URL.

## Steps

1. Select <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lists** in the Navigator.

1. Select **GUI - Web panel** from the dropdown menu. The **Items** tab displays all existing web panels.

1. Click **Add** to open the **Edit list item** dialog.

1. In the **Name** field, enter the label that will be shown in SuperOffice CRM. *(Mandatory)*

    * Optionally, type in a description of the item in the **Description** field. Read about [Translation][3].

1. In the **URL** field, specify the URL address such as a web page or a server-based HTML file. For details about supported URL types, see [Using HTTP vs HTTPS URLs](#https).

    * In the **URL encoding** field, select *None*, *ANSI*, or *Unicode*.

1. In the **Window name** field, specify the required name of the browser window where the URL address should be opened. If you have previously added one or more window names and want to reuse them, you can click in the field and select a name from the list. You can also type a new name directly into the field. The window name as it will finally appear is displayed below, underlined.

1. In the **Visible in** list, choose where the web panel should appear in SuperOffice CRM.

1. Under **Available on**, select one or both options:
    * **SuperOffice CRM for Web**
    * **Mobile CRM**

1. (Optional) To control how the panel behaves:

    * Select **Always reload content on tab navigation** if the content should refresh every time users switch tabs.
    * Select **Do not reload content when navigating to the main card** to cache the content during card navigation.
    * Select **Show link for opening in separate window** if the panel should also open in a new browser window.

1. (Optional) Click the **Icon** list to select an icon for the web panel.

1. Click **Save** to save the changes or **Cancel** to reject them.

## After saving

Once the item is saved, you can:

* Change the order of items using the arrow buttons to the left of the list (<i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>).

* Specify additional settings for each item:
  * Which [user groups the item is visible for][7].
  * Which [heading][6] it will be displayed under.

## <a id="fields"></a>Field reference

| Setting | Description |
|---|---|
| Name | UI label |
| Window name | ID of the panel, used in the HTML you load into the panels. Must be unique, use prefixes |
| Description | Tool-tip text |
| URL | Location of web page |
| [URL encoding][2] | None, ANSI, or Unicode |
| Visible in | The display location. You can select from panels, dialogs, menus, toolbar, or side panel locations. For a full list of display options, see [Display locations for web panels][8]. |
| Available on | Device type (web, mobile) - where you want the URL address to be available |

### <a id="https"></a>Using HTTP vs HTTPS URLs

[!include[HTTPS restriction](../../includes/web-panels-and-https.md)]

### Using template variables

If you add a URL address, it may be useful to use template variables for the active company, for example, to retrieve information from other applications via an URL. The URL address must specify parameters, as in this fictitious example: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn here is the template variable for the organisation number, but other variables like company name &lt;name&gt;, company phone number &lt;cpho&gt;, contact name &lt;attn&gt;, can also be used.

## Add web panel in Service (legacy)

In Service, web panels are called **extra browser tabs**. You can add the same type of content as for [extra menus][4].

1. Sign in to SuperOffice Service.
1. From the hamburger menu, select **System Design** and then select **Web panels**.
1. Point to the target display location and click **New web panel**.
1. Enter a UI label (the tab text).
1. Select either **Use URL** or **Use screen** and then select the corresponding details.
1. Select where to insert your new menu item from the **Position** list (0 = top).
1. Click **OK**.
1. Test the result.

## Related content

* [Add a task menu item][1]
* [Base programs and URL parameters][5]

<!-- Referenced links -->
[1]: ../../admin/add-items-to-task-menu.md
[2]: url-encoding.md
[3]: ../../../localization/learn/translate-fields.md
[4]: ../../../ui/blogic/learn/extra-menus/index.md
[5]: ../../../../en/ui/blogic/url-parameters.md
[6]: ../../../admin/lists/headings.md
[7]: ../../../admin/lists/user-group-filtering.md
[8]: index.md

<!-- Referenced images -->