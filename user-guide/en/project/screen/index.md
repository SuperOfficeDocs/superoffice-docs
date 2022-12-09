---
uid: help-en-project-screen
title: Project screen
description: The Project screen in SuperOffice
author: SuperOffice RnD
so.date: 07.04.2022
keywords: project
so.topic: reference
language: en
---

# Project screen

The **Project** screen contains information about the projects entered into SuperOffice CRM. Each project is displayed like an index card, showing all information about that project.

![Project screen -screenshot][img3]

To move backwards and forwards between projects, click the previous/next buttons ( ![icon][img2] ![icon][img1] ) at the bottom right of the cards

If you select a project type for which a [project guide][1] is defined, the **Project guide** tab is displayed on the section tab.

## <a id="event-tab" />The Event tab

This function requires a separate licence.

In the **Event** tab, you can specify settings for publishing events.

| Field | Description |
|---|---|
| Event | Here you check to indicate that the current project is an event. |
| Event date | This field shows the date of the event. Click the arrow to select a date for the event. |
| Published (From date and To date) | Here you can specify a precise time period the event ia visible to Audience users (requires a separate licence). Click the arrow next to each of the date fields to select a start and end date for publishing. If you do not enter dates in these fields, the project is published until is either unpublished or deleted from SuperOffice CRM (see [Create projects][2]). |
| Visible for category | Check here if you want the event to be visible only to specific categories. Click the button ( ![icon][img5] ) to the right of the field to select the categories that the event is visible for. |
| Visible for contact interest | Check here if you want the event to be visible only to contacts with specific interests. Click the button ( ![icon][img5] ) to the right of the field to select the interests that the event is visible for. |
| Visible for project members | If checked, the event is visible only in Audience for the [project members][3] specified on the **Project members** section tab. |
| Sign on | Check here if you want it to be possible to sign on to the event through Audience. |
| Sign off | Check here if you want it to be possible to sign off from the event through Audience. |
| Log as activity | If you also check **Log as activity** next to **Sign on** or **Sign off**, an activity is created for you when an Audience user signs on to or off from the event. |

> [!TIP]
> If you click the button ( ![icon][img5] ) to the right of **Confirmation**, you can enter a confirmation text to display in a dialog when an Audience user signs on or off the event. The user must click **Yes** or **No** in this dialog to continue.

## <a id="more" />The More tab

![The More tab (Project) -screenshot][img4]

The **More** tab displays user-defined fields for the project. If your organization needs more fields than the default fields in the **Project** tab, you can specify in SuperOffice Settings and maintenance that these fields will be inserted here.

Click **Edit** to edit the project information in the **More** tab.

Three of the user-defined fields from the **More** tab can also be displayed in the **Project** tab.

## The Note tab

[!include[About the Note tab](../../includes/about-note-tab.md)]

## Section tabs in the Project screen

The lower part of the **Project** screen consists of section tabs.

* [Project guide][4] (if one is defined for the current project type)
* [Project members][5]
* [Activities][6]
* [Sales][7]

[!include[Add more section tabs](../../includes/more-tab.md)]

## What would you like to do now?

* [Create a project][2]
* [Work with project guides][1]

<!-- Referenced links -->
[1]: ../project-guide/index.md
[2]: ../create.md
[3]: project-members-tab.md
[4]: project-guide-tab.md
[5]: project-members-tab.md
[6]: activities-project.md
[7]: sale.md

<!-- Referenced images -->
[img1]: ../../../media/icons/arrow-right.png
[img2]: ../../../media/icons/arrow-left.png
[img3]: ../media/project.bmp
[img4]: media/project-more.bmp
[img5]: ../../../media/icons/valgknapp.bmp
