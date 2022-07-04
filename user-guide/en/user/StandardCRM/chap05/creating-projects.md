---
uid: help-en-creating-projects
title: Creating projects
description: Creating projects
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: help
language: en
---

# Create projects

To create projects:

1. Click **New** on the top bar and select **Project**.  
    An empty project card opens.
2. Fill in the required information in the fields in the **Project** tab.  
    <!-- Fix reuse ID=a6 -->
    **Project name**

    Type in the name of the project in the field at the top of the **Project** tab. ***Project Name*** is shown in red, indicating that this field is mandatory.

    If you try to create a project with the same, or similar, name as an existing project, the **Duplicates** dialog opens. This works in the same way as for companies. For more details, see [Duplicates](../chap01/Duplicates.md).

    Number

    In this field, SuperOffice CRM automatically enters the next available project number. The default setting is 10001 for the first project number and the value increases by 1 for each new project. These values can be changed in SuperOffice Settings and maintenance by administrators, so you do not have to worry about this.

    Web site

    This field contains a table with columns for **Web Address (URL)** and **Title**.

    Enter the address of a web page on the Internet and a brief description of the sort of page it is. You can enter several web addresses if required. Click outside the table when you have finished, or press **TAB** until the table closes.

    > [!TIP]
    > Clicking on a web address when you are in view mode will take you to the relevant web site. This will open in a separate browser in SuperOffice CRM. For more details, see [The Browser in SuperOffice CRM](../chap03/The-browser-in-SuperOffice-CRM.md).

    \[Description field\]

    Enter a more detailed description of the project in the large text box.

    Responsible

    Specify here the person who is responsible for the project. Click the arrow to display a list of users, user groups and resources in the database.

    Type

    Choose the type of project here. Click the arrow to display a list of predefined types. These are defined in SuperOffice Settings and maintenance. This is a mandatory field and **must** therefore be filled in.

    > [!NOTE]
    > Some project types are linked to a [project guide](Projectguide.md). If you switch project type, the associated project guide also disappears. Any activities and documents you have created in connection with the project guide will remain on the **Activities** section tab in the diary. If you later switch back to the original project type, the link between the follow-ups/documents and the project guide is restored.

    Status

    Specify the status of the project here. Click the arrow to display a list of predefined alternatives. These are defined in SuperOffice Settings and maintenance.

    > [!NOTE]
    > If the project is linked to a project guide, the statuses of the project guide are shown in this field. When you change a status, for example from **Planned** to **In progress**, the first status in the **Project guide** section tab is marked as completed, with a tick. See [Project guide](Projectguide.md).

    End date

    Enter the end date of the project in the **End date** field. If you want to change the proposed end date, click the arrow next to the date and select a new one in the calendar that appears.

    Next milestone

    If the project is linked to a project guide, the **Next milestone** field shows the date of the next milestone follow-up linked to the project. If this date is prior to today, it is shown in red. If the project is not linked to a project guide, the project end date is shown here. The **Next milestone** date calculates automatically based on activities linked to the project or entered via the project guide. Usually this is the date of the next open activity in the project's **Activities** section tab.

    \[User-defined fields\]

    Here, three of the fields from the **More** tab may be displayed (see [The More tab](More-tab-Project.md)), as defined in SuperOffice Settings and maintenance. The fields displayed can vary from user group to user group.

    **Completed**

    This box indicates whether the project is completed or not.

    Publish (requires separate licence)

    If you check this box, the project will be visible to external users through third-party applications. For more information about this, see the SuperOffice Audience help. You can choose to have the project published for a specified period of time only (see [The Event tab](Event-tab.md)).
3. Click **Save** to save the information entered, or click one of the tabs to enter further information.  
    You are now ready to [add project members](Creating-project-members.md), for example.

What would you like to do now?

[Add project members](Creating-project-members.md)

[Add project members from section tabs](Adding-project-members.md)

[Edit projects](Editing-projects.md)

[Merge projects](Merge-projects.md)

[Delete projects](Deleting-projects.md)

[Work with project guides](Work-with-projectguide.md)
