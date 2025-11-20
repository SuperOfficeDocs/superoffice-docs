---
uid: help-en-screen-designer-add-layout
title: Add layout
description: How to add a screen layout using the Screen Designer in Settings and maintenance.
keywords: add layout, new layout, screen layout, Assign layouts to
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
  - /en/customization/screen-designer/add-layout
  - /en/ui/screen-designer/configurable-screens/add-layout
  - /en/ui/screen-designer/learn/add-new-layout
---

# Add layout

[!include[Requirement](../../../includes/req-dev-tools.md)]

Whether you add a personalized view for a selected user group or design a layout optimized for specific project, sales, and request, and follow-up types or document templates, start by adding a new layout for a screen in the Screen Designer.

With custom screen layouts for each of your teams, finding customer data will be easier than ever. The most relevant data will always be available and visible. Remove, move or hide irrelevant or less important data to unclutter the screens. Add customized archives with the most relevant data for your teams. The result will be a cleaner and more tidy screen for your teams to work in.

## Create new layout

1. Open the Screen Designer (in **Settings and maintenance**).

1. At the top, select a screen or dialog to customize.

1. Select **Main cards**.

    To create a layout for an archive, see [Working with section tabs][2].

1. [Select assignment method][6] (if not set): click the text next to **Assign layouts to**, and choose group, type, or template.

1. Under **Layouts**, click **Add**.

    ![Click Add to create a new layout -screenshot][img1]

1. In the **Add new layout** dialog, select a layout from the **Create new based on** list.

1. Enter a name and description for the new layout.

    ![Set correct name and the user groups to use this layout -screenshot][img2]

1. Click the **Assign to** field and assign the new layout to one or more user groups **or** sale/project/request/follow-up type **or** document template.

    > [!NOTE]
    > Only groups/types/templates currently using the default layout are shown.

1. Click **OK**.

    The new layout is added to the **Layouts** list with status Draft, meaning it is not yet visible to any users. The preview is displayed on the right side of the screen.

## Customize the new screen layout

1. With the new layout selected in the **Layouts** list, click <i class="ph ph-pencil-simple" aria-label="Edit layout"></i>.

2. Work your way through the tabs in the layout.

    * [Add, edit, move, or remove a field][1]
    * [Add link or button][5]
    * [Add, remove, restore a tab][3]
    * [Add or remove a section tab (archive)][2]

3. When you are done, save or publish the layout.

## Related content

* [How do I configure what information the users of our company can access in SuperOffice CRM?][15]
* [How do I create a new User Group in SuperOffice CRM?][16]
* [Delete layout][4]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: working-with-archives.md
[3]: working-with-tabs.md
[4]: edit-layout.md#delete
[5]: add-button.md
[6]: assign-layout.md
[15]: ../../../admin/user-management/role/index.md
[16]: ../../../admin/user-management/user-groups.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/add-button-for-new-screen-layout.png
[img2]: ../../../../media/loc/en/customization/add-new-screen-layout.png
