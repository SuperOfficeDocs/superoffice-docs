---
uid: help-en-project
title: Project
description: This how-to guide will show you how to create and use projects to stay on top of your work.
keywords: project
author: SuperOffice RnD
date: 11.29.2024
version: 10.3.11
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Project

You can link any activity to an external company and to a project. You can also work using a project guide that takes you through each step of the project, assuming that the project type you selected has a guide. A project can be targeted at many contacts, and a contact can participate in many projects.

![Project screen -screenshot][img1]

Projects help you keep your work organized and documented in one place, so that you and your team can enjoy better control and improve collaboration.

You can connect any contacts, companies, follow-ups, project members, and even sales opportunities into one project in SuperOffice CRM. You can also create or upload documents and files to the project.

All the information you save inside your project is tagged with a date and an owner, making it easier to sort and filter information when need.

The Project screen contains information about the projects entered into SuperOffice CRM. Each project is displayed like an index card, showing all information about that project.

To move backwards and forwards between projects, click the ![icon][img2] ![icon][img3] previous/next buttons at the lower right of the cards

If you select a project type for which a [project guide][1] is defined, the **Project guide** tab is displayed on the section tab.

## <a id="more-tab"></a>The More tab for projects

The [More tab][12] includes additional custom fields for the project. Up to three fields from the **More** tab can also be shown in the main **Project** tab for easier visibility.

## The Note tab

[!include[About the Note tab](../../learn/includes/about-note-tab.md)]

## <a id="event-tab"></a>The Event tab

This function requires a separate licence.

In the **Event** tab, you can specify settings for publishing events.

| Field | Description |
|---|---|
| Event | Here you check to indicate that the current project is an event. |
| Event date | This field shows the date of the event. Click the arrow to select a date for the event. |
| Published (From date and To date) | Here you can specify a precise time period the event ia visible to Audience users (requires a separate licence). Click the arrow next to each of the date fields to select a start and end date for publishing. If you do not enter dates in these fields, the [project is published][2] until is either unpublished or deleted from SuperOffice CRM. |
| Visible for category | Check here if you want the event to be visible only to specific categories. Click the button ( ![icon][img5] ) to the right of the field to select the categories that the event is visible for. |
| Visible for contact interest | Check here if you want the event to be visible only to contacts with specific interests. Click the button ( ![icon][img5] ) to the right of the field to select the interests that the event is visible for. |
| Visible for project members | If checked, the event is visible only in Audience for the [project members][8] specified on the **Project members** section tab. |
| Sign on | Check here if you want it to be possible to sign on to the event through Audience. |
| Sign off | Check here if you want it to be possible to sign off from the event through Audience. |
| Log as activity | If you also check **Log as activity** next to **Sign on** or **Sign off**, an activity is created for you when an Audience user signs on to or off from the event. |

> [!TIP]
> If you click the button ( ![icon][img5] ) to the right of **Confirmation**, you can enter a confirmation text to display in a dialog when an Audience user signs on or off the event. The user must click **Yes** or **No** in this dialog to continue.

## <a id="section-tabs"></a>Project screen section tabs

The lower part of the Project screen consists of section tabs.

* [Project guide][13] (if one is defined for the current project type)
* [Project members][6]
* [Activities][16]
* [Sales][17]
* [Requests][18]

[!include[Add more section tabs](../../learn/includes/more-tab.md)]

### Project guide

The project guide that can be customized to match your own unique project processes. You can map all the activities, documents and milestones of a project, which will make it easy for your whole team to track. The project guide will also help you monitor the current project status and prompt what needs to be done at all times.

![A project guide will help the team have a constant overview of the project status -screenshot][img4]

Your administrator can [add and customize project guides][8] for you.

## Related content

* [Add project as a favorite][9]
* [Create a project][2]
* [Edit a project][3]
* [Merge projects][4]
* [Delete a project][5]
* [Send a document to project members][7]
* [Project guide][1]
* [Print project info][11]
* [Links tab][10]

<!-- Referenced links -->
[1]: project-guide/index.md
[2]: create.md
[3]: edit.md
[4]: merge-projects.md
[5]: delete.md
[6]: project-members/index.md
[7]: project-members/create-mailing.md
[8]: project-guide/create.md
[9]: ../../learn/basics/fav.md
[10]: ../../learn/basics/links.md
[11]: ../../learn/basics/print.md
[12]: ../../custom-objects/learn/more-tab.md
[13]: project-guide/project-guide-tab.md
[16]: ../../learn/section-tabs/activities-tab.md
[17]: ../../learn/section-tabs/sales-tab.md
[18]: ../../learn/section-tabs/requests-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/project/projects.png
[img2]: ../../../media/icons/arrow-left.png
[img3]: ../../../media/icons/arrow-right.png
[img5]: ../../../media/icons/select.png
[img4]: ../../../media/loc/en/project/project-guide-create.png
