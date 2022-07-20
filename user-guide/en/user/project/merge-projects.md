---
uid: help-en-merge-projects
title: Merge projects
description: Merge projects
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: help
language: en
---

# Merge projects

If you have two nearly identical projects, it is possible to merge them, including the project members and activities. The source project will then be deleted.

To do this:

1. Go to the project you want merge into another project. (See [Use the Find screen][1].)

2. Click ![icon][img1] **Task** on the **Project** card and select **Merge projects**. The **Merge projects** dialog opens.

    ![Merge projects dialog -screenshot][img2]

3. Under **To**, select the project you want to merge the existing project into. Start typing in the field to search for a project.

    > [!TIP]
    > If you want to switch the **From** and **To** projects, click the ![icon][img3] button.

4. Select the **Replace empty fields in \[target project\] with data from \[source project\]** if you want to update empty fields in the target project with details from the source one.

    > [!NOTE]
    > If you want to see the results before you merge the projects, click **Show results:**![icon][img4]

5. Click **Merge**. The following then happens:
    * The projects are merged.
    * Details are merged if you have specified this.
    * Project members are moved or merged.
    * Any associated sales are moved.
    * All activities are moved.  
        If you merge a project that is linked to a project guide with a project that has a different or no project guide, the project guide is removed from the source project. However, all follow-ups and documents are moved over to the new project and shown on the **Activities** section tab.
    * Any previous publishing of the source and target projects is disabled.
    * The source project is deleted.

## Related topics

* [Edit projects][3]
* [Merge companies][2]

<!-- Referenced links -->
[1]: ../standardcrm/key-functions/find-dialog.md
[2]: ../standardcrm/company/merge-companies.md
[3]: editing-projects.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-menu.png
[img2]: media/merge-project.bmp
[img3]: ../../../media/icons/slå-sammen-bytte.bmp
[img4]: ../../../media/icons/vis-resultat.bmp
