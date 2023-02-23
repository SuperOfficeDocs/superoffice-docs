---
uid: help-en-archive-edit-layout
title: Edit layout on section tabs/archives
description: ScreenDesigner Edit layout - Archives (section tabs)
author: SuperOffice RnD
so.date: 02.23.2023
keywords: screen designer, section tab, archive
so.topic: howto
language: en
---

# Edit layout on section tabs/archives

You can edit the layout by adding or removing section tabs/archives on the different main cards for Company, Contact, Sale and Project.

## Disambiguation

Section tabs are the tabs located at the bottom of most SuperOffice CRM screens. Example: The **Company** screen has section tabs containing contacts, activities, projects, and sales. These are also referred to as archives. There are also section tabs that are not considered as archives, such as section tabs containing sales guides, project guides, and quotes. For the purpose of this topic, we will refer to them as archives or archive tabs (when referring to the actual tab containing the archive).

When you have created a new layout for archives (section tabs) as described in Add new layout, it is time to customize it according to the needs of the assigned user group(s). If you are customizing a layout for the sales team, you should have a clear plan of what their needs are with regards to the layout, formatting and contents of the archives. Do they need customized archives with filtered data? Which information should be first and easiest to find? Do they need all the archives?

## Steps

You can add a new section tab on any main cards you like. Depending on the main card chosen, you can add a new tab with contents of: Document, Appointment, Product, Project, Project member, Sale, Sale stakeholder, Request, Contact and Relation.

![Select the type of content you want to show in the section tab -screenshot][img5]

[!include[Go to screen designer](includes/goto-screen-designer.md)]

1. Click **Archives**.

1. Select a layout in the list on the left side.

1. Click **Edit layout** below the preview. A new window opens.

1. See the sections below for more information on how to edit the layout.

1. When you have finished editing the layout, click one of the following buttons:

      * **Save draft**: Click this button if the layout is not finished yet.
      * **Save + Publish**: Click this button to publish the layout to the selected user groups.
      * **Cancel**: Click this button to discard all changes. See also [Undo changes](#undo-changes).

## Add archive tab

1. Click ![icon][img2] **Add**. The **Tab** section opens to the left.

2. Under **Name**, replace the text **New tab** with the name of the archive. You can also add the name in [other languages][1] by clicking ![icon][img3].

3. If relevant, edit **Unique name for tab (soprotocol)**. This name cannot be changed later.

4. Enter a description of the archive in the **Description** field. You can also add the description in [other languages][1] by clicking ![icon][img3].

5. Select the **Settings** section.

6. In the **Content** list, select the type of data you want to display in the archive. The data in the archive will be limited to data for the current screen.

    Example: If you are adding an archive for the Company screen, only data linked to the current company will be displayed.

7. Under **Filter**, add/edit the relevant criteria as follows:

    * [Edit a criterion][2].

        Example: Select **Appointment** in the **Content** list and add criteria to display only internal and external meetings for this week and next week.

    * Click **Add** to specify more criteria. A new line is added to the criteria list.

    * To move criteria, click and drag .

    * Click **Or** to add a another set of criteria.

8. Click **Update preview** to display data for the current criteria, in the preview on the right side. Use the **Preview of company** list to select which company to preview.

9. Click **Advanced options** to change the default actions for single-clicks and double-clicks in the archive. You can see examples on how to set this up under **Example of syntax**, and by holding the mouse-pointer over the icon ( ![icon][img4] ).

    > [!NOTE]
    > By default a single-click will select a row, and a double-click will open a record/entity in SuperOffice. If, however, your company uses custom archives to display data from other systems, you can change these settings to open a record in an external system.

10. Click and drag the newly created archive in the preview, and move it to the desired position.

11. Save the changes as described above.

## Edit existing section tabs

To edit an existing archive, select it and edit the available fields and settings in the **Tab** and **Settings** sections. You can also click and drag it to a new position.

## Limitations

* Default tabs cannot be edited.

* Some tabs, such as **Quote**, **Sales guide** and **Project guide**, cannot be edited, since they have specific functions.

## Remove an archive

1. Select the archive (or other section tab) and click **Task** > **Remove tab**.

1. Click **OK** in the dialog that displays. The tab is removed (hidden, but not deleted).

![Click on Task and then Remove tab to remove any unwanted tabs in the section tab (archive) -screenshot][img1]

You can always click **Restore tabs** to undo these changes.

## Undo changes

If you need to revert to an earlier version of the screen, you can access the following options from the **Task** button:

* **Reset to factory settings**: This option discards all changes and resets the layout to the standard layout delivered by SuperOffice.

* **Restore tabs**: This option restores all tabs that have been removed.

* **Discard draft**: Discards all changes and resets to the published version of the layout.

## Related

* [How do I reorganize the fields in the More tab in Company and Contact screens/cards, after the upgrade to SuperOffice version 10?][3] - FAQ
* [Create new layout][4]

<!-- Referenced links -->
[1]: ../../../globalization-and-localization/learn/translate-fields.md
[2]: ../../../search-options/learn/using-search-criteria.md
[3]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-reorganize-the-fields-in-the-more-tab-in-company-and-contact-screenscards-after-the-upgrade-to-superoffice-version-10/
[4]: add-new-layout.md

<!-- Referenced images -->
[img2]: ../../../../../common/icons/add-icon.png
[img3]: ../../../../../common/icons/az.png
[img4]: ../../../../../common/icons/info-ball.png
[img1]: media/admin-screendesigner-edit-archive.png
[img5]: media/admin-screendesigner-edit-archive-add-tab.png
