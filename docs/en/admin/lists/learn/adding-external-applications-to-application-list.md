---
uid: help-en-adding-external-applications-to-application-list
title: Adding external applications to the Application list
description: Adding external applications to the Application list
author: SuperOffice RnD
date: 06.29.2022
keywords: list
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Add items to the GUI - Application list

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

[!include[Edit list item](includes/edit-list-item.md)] when the items are applications or similar:

> [!NOTE]
> Files or applications that must be run locally (for example, *.exe* files) are not accessible in SuperOffice CRM for Web.

1. Enter the required name of the item in the **Name** field. This name is displayed at the place where you add the application in SuperOffice CRM (see step 7 concerning the **Show** list box).

    > [!NOTE]
    > [!include[Mandatory](includes/note-mandatory-field.md)]

1. Under **Add as**, select what the application will be added as:

    * **Button**: the application icon is displayed in the Navigator. Users can then open the application directly by clicking the icon in the Navigator.
    * **Menu item**: the user can access the application by clicking the **Tools** button ( <i class="ph ph-wrench" aria-hidden="true"></i> ) in the Navigator and/or by selecting **Other applications** on the main menu (<i class="ph ph-list" aria-hidden="true"></i>).
    * **Event**: the application is run when SuperOffice CRM opens or closes or on a local update (Travel). See step 8. You could, for example, run a synchronization program for a PDA when SuperOffice CRM closes.
    * **Task**: select an option in this list box to make the application accessible from the **Task** tab in the Selection screen or the **Task** buttons.

        <details><summary>Find out more about the different options.</summary>

        The names in parenthesis indicate the section tab where the application is available.

        Examples:

        * **Sale selection (Sale)**: After you open a sale selection in the Selection screen and the **Sales** section tab is enabled, the application is displayed as a task in the **Task** tab.
        * **Sale selection (Companies)**: After you open a sale selection in the Selection screen and the **Companies** section tab is enabled, the application is displayed as a task in the **Task** tab.
        * **Sale selection (external)**: If your SuperOffice CRM installation is linked to a third-party application, other section tabs may be displayed for the different selections. You can then select, for example, **Sale selection (external)** to display the application as a task in the **Task** tab when you open a sale selection in the Selection screen and the third-party application section tab is active.

        Other options:

        * **Toolbar**: the application is displayed as an option on the toolbar. The users must configure the toolbar in SuperOffice CRM and choose to display the application.

        * **Follow-up dialog**: the application is displayed as an option under the **Task** button in the dialog for follow-ups.

        * **Document dialog**: the application is displayed as an option under the **Task** button in the selected dialog. The same option is available for the Contact, Quote, and Product screens.

        </details>

    > [!NOTE]
    > Options you choose under **Add as** determine which options are available in the rest of the dialog.

1. Under **Available on**, choose where the application is available. You can select several of these options simultaneously.

    * **Central database**: When you are working on the central database.
    * **Satellite**: When you are working on a satellite.
    * **Travel**: When you are using a local database using the Travel feature.

1. Specify the required application in the **File name** field.

1. In the **Parameters** field, specify any start-up parameters for the application.

1. In the **Work folder** field, you can specify which folder you want to be the current one when the program runs. Type in the path manually. You normally leave this field empty.

1. In the **Show** list box, select the required option. This list box appears only if you selected **Menu item** under **Add as**.

    * **Toolbox menu**: the user can access the application by clicking the **Tools** button in the Navigator or by selecting **Other applications** on the main menu in SuperOffice CRM.
    * **View menu**: the user can access the application using the **Other Applications** option on the **View** menu in SuperOffice CRM.

1. In the **Run when** list box, choose when to run the application. This list box appears only if you selected **Event** under **Add as**.

    * **SuperOffice CRM starts**: the application runs when SuperOffice CRM starts.
    * **SuperOffice CRM exits**: the application runs when SuperOffice CRM is closed down.
    * **Local update**: the application runs when Travel is used.

1. Check **Wait for application to finish** if you want SuperOffice CRM to wait for the external application to quit before closing. If you do not check this box, you can close SuperOffice CRM without closing the external application. This list box appears only if you selected **Event** under **Add as**.

1. Under **Start-up mode**, specify the type of window the application will start in – Maximized, Minimized or Restored.

1. In the **Icon** field, choose the icon to display for the application in the Navigator in SuperOffice CRM (see step 7 concerning the **Show** list box). This list box appears only if you selected **Button** under **Add as**.

    * **From library**: Select one of the available icons in the list.
    * **Use program icon**: Use the default icon for the selected application.

1. Optionally, type in a description of the item in the **Description** field.

1. Click **Save**. The item is added to the **Items** list. Repeat this procedure to add more items.

> [!NOTE]
> Users must log in to SuperOffice CRM again to display the application.
