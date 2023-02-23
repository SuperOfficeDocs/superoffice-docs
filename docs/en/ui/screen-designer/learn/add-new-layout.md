---
uid: help-en-screen-designer-add-layout
title: Add new screen layout
description: How to add a new layout for a user group.
author: SuperOffice RnD
so.date: 02.20.2023
keywords: screen designer, layout, main card, archive
so.topic: howto
so.user: admin
language: en
---

# Add new screen layout

If the default layout doesn’t reflect the needs of a user group, you can create a new layout to match the user group’s unique information needs. A customized layout for the contact and company cards and the different archive/section tabs lets your teams and organization work more efficient.

With custom screen layouts for each of your teams, finding customer data will be easier than ever. The most relevant data will always be available and visible. Remove, move or hide irrelevant or less important data to unclutter the company, contact, sale and project screens. Add customized archives with the most relevant data for your teams. The result will be a cleaner and more tidy screen for your teams to work in.

## Main card layout

A customized layout for the Contact and Company cards/screens lets your teams and organization work more efficiently, as it eliminates the distracting “information noise”.

For example, if your Support team rarely uses the company address when they communicate with companies and contacts, you will want to make space for other fields that are more important on the first page (the Company tab). As we don’t want the address field on the first page, move it by clicking on the bars on the left side of the field and drag it over to the “More” tab.

Watch this video and find out how add a new layout or follow the step-by-step guide below (the video will start at 5:37):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://youtu.be/EcL4TEXXvmU?t=337]

### Steps

[!include[Go to screen designer](includes/goto-screen-designer.md)]

1. Select **Main cards** or **Archives** (also known as section tabs).

1. If relevant, click the text next to **Assign layouts to**.

    By default, the layouts can be assigned to user groups.
    If, however, you are adding main card layouts for the **Sale** or **Project** screens, you can assign the layouts to sale types or project types.

1. Click **Add** under **Layouts**.

    ![Click Add to create a new layout -screenshot][img1]

1. In the the **Add new layout** dialog, select a layout in the **Create new based on** list.

    The new layout will be based on the selected layout.

1. Enter a name for the new layout in the **Name** field.

    ![Set correct name and the user groups to use this layout -screenshot][img2]

1. Click the **Assign to** field and select the user group(s) that will use this new layout.

    The list will display only user groups that are using the default layout. A user group can only be assigned to one layout. Sale types or project types will be available here, if you selected these options in step 3.

1. Enter a description of the layout in the **Description** field.

1. Click **OK** when you are done. The new layout is added to the **Layouts** list. It has the status **Draft**, meaning it is not yet visible to any users. The preview is displayed on the right side of the screen.

    > [!TIP]
    > If you later want to edit the layout settings, double-click the layout in the list to open the **Edit layout settings** dialog. You cannot edit the settings for the default layout.

1. With the new layout selected in the **Layouts** list, click the **Edit layout** button to customize the screen layout. See [Edit layout - Main cards][1] or [Edit layout - Archives (section tabs)][2].

> [!NOTE]
> To delete a layout, select the layout in the **Layouts** list and click **Delete**. User groups that were assigned to the deleted layout, will go back to the default layout.

## Section tab/archive layout

Customizing the layout of the different section tabs/archives for a main card is normally done when there are different needs for the different user groups.

You can create a new layout for the specific user group(s) and set up the different section tabs to show with different content.

Create a new layout for a specific user group by setting up section tabs with content relevant to that user group. By adding and removing the different tabs, you can create the wanted setup on a main card for your user group.

![Add the name to the new section tab/archive layout and select the user group(s) it should show for -screenshot][img3]

## Related content

* [How do I configure what information the users of our company can access in SuperOffice CRM?][3] - FAQ
* [How do I create a new User Group in SuperOffice CRM?][4] - FAQ
* [User administration][5]

<!-- Referenced links -->
[1]: edit-layout.md
[2]: edit-layout-archives.md
[3]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-configure-what-information-the-users-of-our-company-can-access-in-superoffice-crm/
[4]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-create-a-new-user-group-in-superoffice-crm/
[5]: ../../../admin/user-management/learn/index.md

<!-- Referenced images -->
[img1]: media/add-button-for-new-screen-layout.png
[img2]: media/add-new-screen-layout.png
[img3]: media/admin-screendesigner-add-archive-layout.png
