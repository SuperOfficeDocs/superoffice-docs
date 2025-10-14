---
uid: help-en-add-web-panel
title: Add web panel
description: How to add items to the web panel list in Settings and maintenance.
keywords: web panel, GUI - Web panel list
author: digitaldiina
date: 10.13.2025
version: 11.5
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

Web panels are defined in the **GUI - Web panel** list, which you can manage in **Settings and maintenance** under **Lists**.

## Steps

1. Select <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lists** in the Navigator.

1. Select **GUI - Web panel** from the dropdown menu. The **Items** tab displays all existing web panels.

1. Click **Add** to open the **Edit list item** dialog.

1. Enter the required name of the item in the **Name** field. *(Mandatory)*

    * This name is displayed when you add the URL address in SuperOffice CRM.

1. In the **URL** field, specify the URL address such as a web page or a server-based HTML file. For details about supported URL types, see [Using HTTP vs HTTPS URLs](#https).

    * If you add a URL address, it may be useful to use template variables for the active company, for example, to retrieve information from other applications via an URL. The URL address must specify parameters, as in this fictitious example: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn here is the template variable for the organisation number, but other variables like company name &lt;name&gt;, company phone number &lt;cpho&gt;, contact name &lt;attn&gt;, can also be used.

1. In the **Window name** field, specify the required name of the browser window where the URL address should be opened. If you have previously added one or more window names and want to reuse them, you can click in the field and select a name from the list. You can also type a new name directly into the field. The window name as it will finally appear is displayed below, underlined.

1. In the **Visible in** list box, choose where the URL address will be accessible in SuperOffice CRM.
    * **Side panel**: select this option to make the URL address available on the side panels in the SuperOffice CRM.

    * **Toolbar**: select this option to make the URL accessible as a button on the toolbar.

    * **Navigator button**: select this option to make the URL accessible as a button in the navigator in SuperOffice CRM.

    * **Panel**: select [an option in this list](#options) to make the URL accessible as a panel/tab in SuperOffice CRM.

    * **Dialog**: select [option in this list](#options) to make the URL address accessible in a dialog.

    * **Menu**: select [option in this list](#options) to make the URL accessible on one of the menus in SuperOffice CRM.

1. In the **URL encoding** list box, you can select if the [URL][2] should be ANSI or Unicode (or no format).

1. Under **Show**, select which bars will be available in the browser that the URL is opened in: menu bar, toolbar, address bar or status bar.

1. Under **Available on** choose where you want the URL address to be available. You can select several of these options simultaneously.
    * **SuperOffice CRM for Web**: when you are using the Web version of SuperOffice CRM.
    * **Mobile CRM**: when you are using the mobile version of SuperOffice CRM.

    Extra settings:
    * **Always reload** content on tab navigation.
    * **Show link** for opening in separate window.

1. Click the **Icon** list to select an icon for the web panel.

1. Optionally, type in a description of the item in the **Description** field. Read about [Translation][3].

1. Click **Save** to save the changes or **Cancel** to reject them.

## After saving

Once the item is saved, you can:

* Change the order of items using the arrow buttons to the left of the list (<i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>).

* Specify additional settings for each item:
  * Which [user groups the item is visible for][7].
  * Which [heading][6] it will be displayed under.

## <a id="options"></a>Options

### Panel

* **Company card**, **Contact card**, **Project card**, **Selection card**, and **Sale card**: a shortcut to the URL address is added at the top of the **www** tab in the Company, Contact, Project, Selection, and Sale screens. When you click a shortcut in SuperOffice CRM, the web page in question is displayed in a small scrollable window in the tab. You can then also click **Open in separate window** to view the web page in a separate browser window.

* **Web panel on SuperOffice button**: the URL address is added in the web panel in SuperOffice CRM. The address can then be opened as an Internet page. If several URL addresses are defined for the web panel, they are shown as tabs on the right side of the web panel. The Web panel is opened by clicking the SuperOffice logo at the upper left in SuperOffice CRM.

* Section tabs in the Company, Contact, Project, and Sale screens: the URL address is added as an extra section tab in the Company/Contact/project/learn/Sale screen. When you select the section tab in SuperOffice CRM, the URL opens. You can then also click **Open in separate window** to view the web page in a separate browser window.

### Dialog

* **The Dialog for follow-ups**: a shortcut to the URL address is added at the top of the **www** tab in the **Follow-up** dialog. You can then also click **Open in separate window** to view the web page in a separate browser window.

* **The Document/Quote/Product dialog**: a shortcut to the URL address is added at the top of the **www** tab in these dialogs.

### Menu

* **Toolbox menu**: the URL address is displayed when the user clicks the **Tools** button (<i class="ph ph-wrench" aria-hidden="true"></i>) in the Navigator or selects **Other Applications** in SuperOffice CRM.

* **View menu**: the URL address is displayed when the user selects **Other Applications** in SuperOffice CRM.

## <a id="fields"></a>Field reference

| Setting | Description |
|---|---|
| Name | UI label |
| Window name | ID of the panel, used in the HTML you load into the panels. Must be unique, use prefixes |
| Description | Tool-tip text |
| URL | Location of web page |
| URL encoding | None, ANSI, or Unicode |
| Visible in | The display location |
| Available on | Device type (web, mobile) |
| Show | Whether to show the menu bar, toolbar, address bar, and/or status bar |

## <a id="https"></a>Using HTTP vs HTTPS URLs

[!include[HTTPS restriction](../../../admin/lists/learn/includes/web-panels-and-https.md)]

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
[1]: ../../../admin/lists/learn/add-items-to-task-menu.md
[2]: url-encoding.md
[3]: ../../../localization/learn/translate-fields.md
[4]: ../../../ui/blogic/learn/extra-menus/index.md
[5]: ../../../../en/ui/blogic/url-parameters.md
[6]: ../../../admin/lists/learn/organize/headings.md
[7]: ../../../admin/lists/learn/organize/user-group-filtering.md

<!-- Referenced images -->