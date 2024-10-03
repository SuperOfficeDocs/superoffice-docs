---
uid: help-en-screen-designer-add-layout
title: Add layout
description: How to add a screen layout using the Screen Designer in Settings and maintenance.
keywords: Screen designer, layout, main card
author: Bergfrid Dias
date: 10.07.2024
version: 10.2.11
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Add layout

[!include[Requirement](../../../../../common/includes/req-dev-tools.md)]

Whether you add a personalized view for a selected user group or design a layout optimized for specific project, sales, and request, and follow-up types, start by adding a new layout for a screen in the Screen Designer.

With custom screen layouts for each of your teams, finding customer data will be easier than ever. The most relevant data will always be available and visible. Remove, move or hide irrelevant or less important data to unclutter the screens. Add customized archives with the most relevant data for your teams. The result will be a cleaner and more tidy screen for your teams to work in.

Watch this video and find out how add a new layout or follow the step-by-step guide below (the video will start at 5:37):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU?t=337]

## Create new layout

1. Open the Screen Designer (in **Settings and maintenance**).

1. At the top, select a screen or dialog to customize.

1. Select **Main cards**.

    To create a layout for an archive, see [Working with section tabs][2].

1. [Select assignment method][6] (if not set): click the text next to **Assign layouts to**, and choose group or type.

1. Under **Layouts**, click **Add**.

    ![Click Add to create a new layout -screenshot][img1]

1. In the **Add new layout** dialog, select a layout from the **Create new based on** list.

1. Enter a name and description for the new layout.

    ![Set correct name and the user groups to use this layout -screenshot][img2]

1. Click the **Assign to** field and assign the new layout to one or more user groups **or** sale/project/request/follow-up type.

    > [!NOTE]
    > Only groups/types currently using the default layout are shown.

1. Click **OK**.

    The new layout is added to the **Layouts** list with status Draft, meaning it is not yet visible to any users. The preview is displayed on the right side of the screen.

## Customize the new screen layout

1. With the new layout selected in the **Layouts** list, click the **Edit layout** button.

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
[15]: ../../../admin/user-management/learn/role/index.md
[16]: ../../../admin/user-management/learn/user-groups.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/ui/add-button-for-new-screen-layout.png
[img2]: ../../../../media/loc/en/ui/add-new-screen-layout.png
