---
uid: help-en-create-new-status-web
title: Create new status web
description: Create new status web
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Create a new status

[!include[Requirement](../includes/note-saint-req.md)]

To add a new status:

1. Open the **SAINT** screen.

2. Select the **Company**, **Project** or **Contact** tab.

3. Click **Add** below the **Status monitors** list. The **Status monitor** dialog opens.

4. Complete these fields:
    * **Name**: Enter a descriptive name for the status you want to add.  
        Optional: Click ![icon][img1] to add translations of the status name. See [Translation](../../user/standardcrm/translate-fields.md).
    * **Description**: Enter an explanatory description of the status and what measures are required or recommended. In this field you can also use [template variables][1] to tailor the text to the relevant company, contact or project.<!-- Fix reuse ID=a11 -->

    The name and description are displayed in SuperOffice CRM when the user holds the mouse pointer over the status image or opens the status image for the company. You can subsequently edit the description by following the procedure under [Edit a status description](Edit-description-for-status.md).
5. Click **Save**. The status is displayed in the status list.  
    ![icon](../media/question.bmp) <!-- Fix reuse ID=a11 -->
    ![icon](../media/visualiser.bmp) – the **Visualise** icon indicates whether to display a status image for company, contact or project cards that fulfil the status criteria. The icon is only displayed if you have checked **Visualise** in the **Image** tab for the status in question (see [Select an image for a status](Select-image-for-status.md)).

    ![icon](../media/Roedt-kryss.bmp) – a red cross indicates that the status needs to be regenerated. The status must be regenerated (see [Manage status monitors](Manage-status-monitors.md)) each time you have added, edited or deleted a criterion or if, for example, you have changed an intention for a task. Statuses with red crosses are not updated and do not return current data when using SuperOffice CRM (see [Manage status monitors](Manage-status-monitors.md)).

    **Name** – the name of the statuses. Deleted statuses are displayed in red if you have checked **Show deleted**.

    **Priority** – the priority of the statuses. The priority determines which status will be displayed if a company, contact or project fulfils the criteria for several statuses.

6. If there are several statuses in the list, you need to specify the priority you want the status you have added to have. Click the status and use the arrow buttons to the right of the status list ( ![icon](../media/pil-flyttopp.bmp) / ![icon](../media/pil-flyttned.bmp) ) to move it up or down the list.  
    ![icon](../media/question.bmp) <!-- Fix reuse ID=a6 -->
    A company, contact or project can fulfil the criteria for several different statuses, but it is only possible to show one status image on the company card, contact card or project card in SuperOffice CRM. An order of priority therefore has to be specified for displaying statuses in SuperOffice CRM. If a company, contact or a project does not fulfil the criteria for the highest-priority status, then the status with the next highest priority is displayed. If the company, contact or project does not fulfil these criteria, then the next is displayed and so on.

    If a company, contact or project has several active statuses, the lower priority statuses are displayed as links in the status dialog. This dialog is displayed when the user clicks the status image in SuperOffice CRM or selects **Show status information** on the **Company**, **Contact** or **Project** menu for a company, contact or project with an active status.

## What would you like to do now?

[Select an image for a status](Select-image-for-status.md)

[Select a default follow-up type for a status](Select-default-follow-up-type-for-status.md)

[Specify status criteria](Select-status-criteria.md)

[Specify a period length](Select-period-length.md)

[Manage status monitors](Manage-status-monitors.md)

<!-- Referenced links -->
[1]: ../../user/standardcrm/diary/template-variables.md

<!-- Referenced images -->
[img1]: ../../../media/icons/translate.png
