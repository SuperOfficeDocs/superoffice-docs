---
uid: help-en-adding-items-to-webpanel-list
title: Adding items to the Webpanel list
description: Adding items to the Webpanel list
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add items to the GUI - Web panel list

<details><summary>Is SuperOffice CRM for Web installed on an https site?</summary>

If SuperOffice CRM for Web is installed on an HTTPS site, web panels using HTTP URLs will not work. You must use HTTPS URLs.

You can open the URL in safe mode in your browser, but the site will then no longer be safe.

If SuperOffice CRM for Web is installed on an HTTP site, use "normal" HTTP URLs.

</details>

When you add an item to the **GUI - Web panel** list in Settings and maintenance, the **Edit list item** dialog is not the same as described under [Add items][1].

This is how to fill out the fields in the **Edit list items** dialog when the items are URL addresses, i.e. pages on the Internet or saved HTML files:

1. Enter the required name of the item in the **Name** field. This name is displayed when you add the URL address in SuperOffice CRM.

    > [!NOTE]
    > [!include[Mandatory](../../includes/note-mandatory-field.md)]

1. In the **URL** field, specify the URL address. This might be an Internet page or a server-based HTML file. Please see the information at the top concerning the use of HTTP/HTTPS URLs.

1. In the **Window name** field, specify the required name of the browser window in which the URL address is to be opened. If you have previously added one or more window names and want to reuse them, you can click in the field and select a name from the list. You can also type a new name directly into the field. The window name as it will finally appear is displayed below, underlined.

1. In the **Visible in** list box, choose where the URL address will be accessible in SuperOffice CRM.
    * **Side panel**: select this option to make the URL address available on the side panels in the SuperOffice CRM.

    * **Toolbar**: select this option to make the URL accessible as a button on the toolbar.

    * **Navigator button**: select this option to make the URL accessible as a button in the navigator in SuperOffice CRM.

    * **Panel**: select an option in this list box to make the URL accessible as a panel/tab in SuperOffice CRM. <details><summary> Click here to find out more about the different options.</summary>

      * **Company card**, **Contact card**, **Project card**, **Selection card** and **Sale card**: a shortcut to the URL address is added at the top of the **www** tab in the **Company**, **Contact**, **Project**, **Selection** and **Sale** screens. When you click a shortcut in SuperOffice CRM, the web page in question is displayed in a small scrollable window in the tab. You can then also click **Open in separate window** to view the web page in a separate browser window.
      * **Web panel on SuperOffice button**: the URL address is added in the web panel in SuperOffice CRM. The address can then be opened as an Internet page. If several URL addresses are defined for the web panel, they are shown as tabs on the right-hand side of the web panel. The Web panel is opened by clicking the SuperOffice logo at the top left in SuperOffice CRM.
      * Section tabs in the **Company**, **Contact**, **Project** and **Sale** screens: the URL address is added as an extra section tab in the **Company/Contact/Project/Sale** screen. When you select the section tab in SuperOffice CRM, the URL opens. You can then also click **Open in separate window** to view the web page in a separate browser window.

      </details>

    * **Dialog**: select an option in this list box to make the URL address accessible in a dialog. <details><summary> Click here to find out more about the different options.</summary>

      * **The Dialog for follow-ups**: a shortcut to the URL address is added at the top of the **www** tab in the **Appointment**, **Task** and **Phone Call** dialogs. You can then also click **Open in separate window** to view the web page in a separate browser window.

      * **The Document/Quote/Product dialog**: a shortcut to the URL address is added at the top of the **www** tab in these dialogs.

      </details>

    * **Task**: select this option to make the URL address accessible from the **Task** button in the **Contact** screen.

    * **Menu**: select an option in this list box to make the URL accessible on one of the menus in SuperOffice CRM. <details><summary> Click here to find out more about the different options.</summary>

      * **Toolbox menu**: the URL address is displayed when the user clicks the **Tools** button ( ![icon][img1] ) in the Navigator or selects **Other Applications** in SuperOffice CRM.
      * **View menu**: the URL address is displayed when the user selects **Other Applications** in SuperOffice CRM.

      </details

1. In the **URL encoding** list box, you can select whether the URL should be ANSI or Unicode (or no format).
1. Under **Show**, select which bars will be available in the browser that the URL is opened in: menu bar, toolbar, address bar or status bar.
1. Under **Available on** choose where you want the URL address to be available. You can select several of these options simultaneously.
    * **Central database**: when you are working on the central database.
    * **Satellite**: when you are working on a satellite.
    * **Travel**: when you are using a local database using the Travel feature.
    * **SuperOffice CRM for Web**: when you are using the Web version of SuperOffice CRM.
    * **Pocket CRM**: when you are using the mobile version of SuperOffice CRM.
1. Click the **Icon** list to select an icon for the web panel.
1. Optionally, type in a description of the item in the **Description** field.
1. [!include[Save or cancel](../../includes/save-or-cancel.md)]

> [!TIP]
> If you add a URL address, it may be useful to use template variables for the active company, for example, to retrieve information from other applications via a URL. The URL address must specify parameters, as in this fictitious example: `http://www.comlist.com/data/indiv/detail.jsp?orgno=<orgn>`. orgn here is the template variable for the organisation number, but other variables like company name &lt;name&gt;, company phone number &lt;cpho&gt;, contact name &lt;attn&gt;, can also be used.

<!-- Referenced links -->
[1]: adding-items.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/nav-tools.png
