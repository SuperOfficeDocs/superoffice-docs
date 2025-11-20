---
uid: help-en-screen-designer-archive
title: Working with section tabs/archives
description: ScreenDesigner Edit layout - Archives (section tabs)
keywords: add section tab, new section tab, add archive tab, customize section tab, section tab layout
author: digitaldiina
date: 11.20.2025
version: 11.6
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: en
index: true
redirect_from:
  - /en/ui/screen-designer/learn/edit-layout-archives
  - /en/customization/screen-designer/working-with-archives
---

# Working with section tabs (archives)

You can customize the layout by adding or removing section tabs (also called archives) on the main cards for Company, Contact, Sale, Project, and Request screens.

Customizing section tabs is typically done to meet the specific needs of different user groups. You can create a layout tailored for a particular user group, ensuring the section tabs display relevant content for that group.

![Add the name to the new section tab/archive layout and select the user group(s) it should show for -screenshot][img6]

## Understanding section tabs

Section tabs, located at the bottom of most SuperOffice CRM screens, display related data such as contacts, activities, projects, and sales. While some section tabs, like Sales Guides and Quotes, are not archives, for simplicity, we will refer to all as archives or archive tabs.

When creating a new layout for a user group, consider what data they need most. Customizing archives allows you to filter and prioritize information, making it easier for users to find what they need.

## Add archive tab

You can add a new section tab on any screen with a section tab area. Depending on the chosen screen, you can add a new tab with contents of: document, follow-up, product, project, project member, sale, sale stakeholder, request, contact, and relation.

![Select the type of content you want to show in the section tab -screenshot][img5]

**Steps:**

1. Open the Screen Designer.

1. At the top, select a screen to customize and click **Archives**.

1. Select a layout from the list and click <i class="ph ph-pencil-simple" aria-label="Edit layout"></i> below the preview.

1. Click **Add** to open the **Tab** section.

1. Replace "New tab" with the archive name and enter a description for the new layout. Optionally, click <i class="ph ph-translate" aria-label="Translate"></i> to [add the texts in other languages][1].

1. Adjust the **Unique name for tab** (soprotocol) as needed.

1. In the **Settings** section, select the data type (content) to display in the archive.

    Data is limited the current screen. For example, if you add an archive to the Company screen, only data linked to the **current** company will be displayed.

1. Add or edit criteria under **Filter** to refine the displayed data. These criteria function similarly to the [search filters in the **Find** screen][2] and in selections.

    Click **Update preview** to see the filtered data.

1. (Optional) Use **Advanced options** to customize single-click and double-click actions. By default a single-click will select a row, and a double-click will open a record/entity in SuperOffice.

    > [!TIP]
    > Hold the mouse-pointer over <i class="ph ph-info" aria-label="Info"></i> for examples.

1. Drag the archive to the desired position in the preview.

1. Select **Save draft** or **Save + Publish** to save your changes. Click **Cancel** to discard your changes.

## Edit existing section tab

To modify an existing archive tab, select it and update the fields and settings in the **Tab** and **Settings** sections. You can also reposition the tab by dragging it.

### Limitations

* Default tabs cannot be edited.

* Some tabs, such as **Quote**, **Sales guide** and **Project guide**, cannot be edited, because they have specific functions.

## Remove section tab

1. Select the archive or section tab.

1. Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> and select **Remove tab**.

1. Confirm by clicking **OK**. The tab will be hidden but not deleted.

![Click on Task and then Remove tab to remove any unwanted tabs in the section tab (archive) -screenshot][img1]

To undo these changes, click **Restore tabs**.

## Related content

* [Create new layout][4]

<!-- Referenced links -->
[1]: ../../../localization/learn/translate-fields.md
[2]: ../../../search-options/learn/search-criteria.md
[4]: add-layout.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/admin-screendesigner-edit-archive.png
[img5]: ../../../../media/loc/en/customization/admin-screendesigner-edit-archive-add-tab.png
[img6]: ../../../../media/loc/en/customization/admin-screendesigner-add-archive-layout.png
