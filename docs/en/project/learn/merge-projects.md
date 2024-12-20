---
uid: help-en-project-merge
title: Merge projects
description: How to merge project in SuperOffice
keywords: merge projects, project management, project
author: Bergfrid Dias
date: 10.29.2024
version: 10.3.11
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Merge projects

If you have two nearly identical projects, you can merge them, including project members and activities. The source project will then be deleted.

## Steps

1. Go to the project you want to merge into another project. See [Use the Find screen][1].

1. Click the **Task** button (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) in the upper-right corner of the Project card and select **Merge projects**.

    > [!NOTE]
    > If the **Merge** option is dimmed, it means you do not have sufficient user rights to merge projects.

1. In the **Merge projects** dialog:

    * Under **To**, select the project you want to merge the current project into. Start typing to search for a project.
    * To swap the **From** and **To** projects, click the arrow button (<i class="ph ph-arrows-left-right" aria-hidden="true"></i>).

    > [!CAUTION]
    > Make sure you select the correct projects in the **From** and **To** fields before proceeding. **Merging cannot be undone**.

1. (Optional) Select **Replace empty fields with data from [source project]** to update empty fields in the target project with data from the source project.

1. Click **Merge**. The following will happen:
    * Project members are moved or merged.
    * All activities are moved.
    * Any associated sales are moved.
    * Details are merged (if specified).
    * If you merge a project that is linked to a project guide with a project that has a different or no project guide, the project guide is removed from the source project.
    * The source project is deleted.

![Merge projects dialog showing fields for selecting source and target projects, options to replace empty fields, and a summary of the merge actions. - screenshot][img2]

## Related topics

* [Edit projects][3]
* [Merge companies][2]

<!-- Referenced links -->
[1]: ../../search-options/learn/find-screen.md
[2]: ../../company/learn/merge-companies.md
[3]: edit.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/project/merge-projects.png
