---
uid: help-en-project-create
title: Create a new project
description: How to create a project and be even more organized in your work.
keywords: create project, new project, add project, project
author: Bergfrid Dias
date: 01.03.2025
version: 10
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Create a new project

You can add a project in SuperOffice CRM using the **New** button on the top bar. Watch this video or follow the steps below to learn how to create a project:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/zLJwNll223w]

(video length - 2:49)

## Steps

1. Click **New** on the top bar and select **Project**.

1. Enter a **project name** (mandatory, marked in red).

    If the project name is a duplicate, the **Duplicates** dialog will appear, helping you avoid creating redundant records.

    ![The Project screen in edit mode, showing project details -screenshot][img1]

1. Use the large text box to provide a detailed overview or summary of the project. This is the Description field.

1. Choose the **Type** of the project (mandatory). Values are predefined and set up in **Settings and maintenance**.

1. **Optional: Provide additional information** in the **Project** tab:
    * Add a **Website** address and title.
    * Select a **Responsible** user for the project.
    * Choose the **Status** of the project. Values are predefined and set up in **Settings and maintenance**.
    * Set an **End date** using the calendar picker.

1. **Add more details:**
    * Go to the **More** tab to [enter custom fields][12].
    * Go to the **Image** tab to [upload and set a project image][2].
    * Go to the **Note** tab to [add notes][11].
    * Go to the **Links** tab to [connect activities, sales, documents, or websites][10] to the project.

1. Click **Save** to store the project details. You are now ready to [add project members][5].

## <a id="fields"></a>Key fields explained

The following fields are available in the Project card. Some fields are filled automatically, while others require input.

> [!NOTE]
> Fields and layout may vary based on [Screen designer][13] configurations and other UI customizations.

* **Project name:** The main identifier for the project. This is a mandatory field.
* **Number:** Auto-generated as the next available project number if configured in **Settings and maintenance**. You can edit this manually if required.
* **Website:** Add web addresses with brief descriptions. Click outside the table or press **TAB** to close the input table.
* **Description:** Summarize the project's goals, scope, or purpose. Optional but useful for tracking objectives.
* **Responsible:** Assign an associate responsible for the project.
* **Type:** Predefined project types. Some types may be linked to a [project guide][1].
* **Status:** Track the project's current stage (such as, Planned, In Progress, Completed). If the project guide is linked, statuses specific to the guide will appear in the list.
* **End date:** Specify when the project should end. Can be adjusted as needed.
* **Next milestone:** If the project is linked to a guide, this field shows the date of the next scheduled follow-up. The date is automatically calculated based on linked activities or the project guide. If no project guide is linked, the project end date is displayed. Dates prior to today are highlighted in red.

[!include[3 udef](../../learn/includes/more-udef.md)]

## Duplicate detection

If the project name matches or is similar to an existing record, the  **Duplicates** dialog helps you [avoid duplication][6]. Review the suggestions and proceed as needed.

## Related content

* [Add or change a project image][2]
* [Add project members][5]
* [Edit projects][7]
* [Merge projects][8]
* [Delete projects][9]
* [Project guides][1]
* [Activities][3]

<!-- Referenced links -->
[5]: project-members/add.md
[2]: add-image.md
[7]: edit.md
[8]: merge-projects.md
[9]: delete.md
[1]: project-guides.md
[3]: ../../learn/basics/activity.md
[6]: ../../learn/basics/duplicates.md
[10]: ../../learn/basics/links.md
[11]: ../../learn/basics/notes.md
[12]: ../../custom-objects/learn/more-tab.md
[13]: ../../ui/screen-designer/learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/create-project.png
