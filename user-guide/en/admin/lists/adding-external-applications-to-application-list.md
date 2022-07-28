---
uid: help-en-adding-external-applications-to-application-list
title: Adding external applications to the Application list
description: Adding external applications to the Application list
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add items to the GUI - Application list

When you add an item to the **GUI - Application** list in Settings and maintenance, the **Edit list item** dialog is not the same as described under [Add items][1].

To complete the fields in the **Edit list item** dialog when the items are applications or similar:

> [!NOTE]
> Files or applications that have to be run locally (e.g. .exe files) are not accessible in SuperOffice CRM for Web.

1. Enter the required name of the item in the **Name** field. This name is displayed at the place where you add the application in SuperOffice CRM (see step 7 concerning the **Show** list box).

    > [!NOTE]
    > This is a mandatory field and must therefore be filled in.

2. Under **Add as**, select what the application will be added as:

<!-- -->

1. **Button**: the application icon is displayed in the Navigator in SuperOffice CRM. Users can then open the application directly by clicking the icon in the Navigator.
    * **Menu item**: the user can access the application by clicking the **Tools** button ( ![icon][img2] ) in the Navigator and/or by selecting **Other applications** on the main menu (![icon][img1]) in SuperOffice CRM.
    * **Event**: the application is run when SuperOffice CRM opens or closes or on a local update (Travel). See step 8. You could, for example, run a synchronisation program for a PDA when SuperOffice CRM closes.
    * **Task**: select an option in this list box to make the application accessible from the **Task** tab in the **Selection** screen or the **Task** buttons in various locations in SuperOffice CRM. <!-- Fix reuse ID=a2 -->
        The names in parenthesis indicate in which section tab the application is available.

        Examples:

        * **Sale selection (Sale)**: Once you have opened a sale selection in the **Selection** screen and the **Sales** section tab is enabled, the application is displayed as a task in the **Task** tab.
        * **Sale selection (Companies)**: Once you have opened a sale selection in the **Selection** screen and the **Companies** section tab is enabled, the application is displayed as a task in the **Task** tab.
        * **Sale selection (external)**: If your SuperOffice CRM installation is linked to a third-party application, other section tabs may be displayed for the different selections. You can then select, for example, **Sale selection (external)** to display the application as a task in the **Task** tab when you have opened a sale selection in the **Selection** screen and the third-party application section tab is active.

        Other options:

        * **Toolbar**: the application is displayed as an option on the toolbar. The users need to configure the toolbar in SuperOffice CRM and choose to display the application.

        * **Dialog for follow-ups**: the application is displayed as an option under the **Task** button in the dialog for follow-ups.

        * **Document dialog**: the application is displayed as an option under the **Task** button in the selected dialog. The same option is available for the **Contact**, **Quote** and **Product** dialogs.

> [!NOTE]
> Options you choose under **Add as** determine which options are available in the rest of the dialog.

1. Under **Available on**, choose where the application will be available. You can select several of these options simultaneously.

    * **Central database**: When you are working on the central database.
    * **Satellite**: When you are working on a satellite.
    * **Travel**: When you are using a local database using the Travel feature.

2. Specify the required application in the **File name** field.

3. In the **Parameters** field, specify any start-up parameters for the application.

4. In the **Work folder** field, you can specify which folder you want to be the current one when the program runs. Type in the path manually. You normally leave this field empty.

5. In the **Show** list box, select the required option. This list box only appears if you have selected **Menu item** under **Add as**.

<!-- -->

1. **Toolbox menu**: the user can access the application by clicking the **Tools** button (![icon][img2]) in the Navigator or by selecting **Other applications** on the main menu (![icon][img1]) in SuperOffice CRM.
    * **View menu**: the user can access the application using the **Other Applications** option on the **View** menu in SuperOffice CRM.

In the **Run when** list box, choose how the application will be run. This list box only appears if you have selected **Event** under **Add as**.

* **SuperOffice CRM starts**: the application runs when SuperOffice CRM starts.
* **SuperOffice CRM exits**: the application runs when SuperOffice CRM is closed down.
* **Local update**: the application runs when Travel is used.

Check **Wait for application to finish** if you want SuperOffice CRM to wait for the external application to quit before closing. If you do not check this box, you can close SuperOffice CRM without closing the external application. This list box only appears if you have selected **Event** under **Add as**.

Under **Start-up mode**, specify the type of window the application will start in – Maximised, Minimised or Restored.

In the **Icon** field, choose the icon to display for the application in the Navigator in SuperOffice CRM (see step 7 concerning the **Show** list box). This list box only appears if you have selected **Button** under **Add as**.

* **From library**: Select one of the available icons in the list.
* **Use program icon**: Use the default icon for the selected application.

Optionally, type in a description of the item in the **Description** field.

Click **Save**. The item is added to the **Items** list. Repeat this procedure to add more items.

> [!NOTE]
> Users must log in to SuperOffice CRM again to display the application.

<!-- Referenced links -->
[1]: adding-items.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-menu.png
[img2]: ../../../media/icons/admin/knapp-verktoey-liten.bmp
