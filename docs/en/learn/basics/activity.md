---
uid: help-en-activity
title: Activities
description: Activities in SuperOffice CRM
keywords: activity
author: SuperOffice RnD
date: 01.17.2025
version: 10.5
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Activities

![Activities in SuperOffice CRM -screenshot][img3]

## Types

There are two main types of activities – documents and follow-ups. In addition, mailings, form submissions, and chat records are displayed in the **Activities** section tab.

* [Follow-ups][1]
  * <i class="ph ph-calendar-blank" aria-hidden="true"></i> Meeting (appointment)
  * <i class="ph ph-calendar-blank" aria-hidden="true"></i> Follow-up (call)
  * <i class="ph ph-calendar-check" aria-hidden="true"></i> To-do (task)
* [Documents][4]
  * <i class="ph ph-files" aria-hidden="true"></i> Document (letters and other documents)
  * <i class="ph ph-at" aria-hidden="true"></i> Email
* <i class="ph ph-target" aria-hidden="true"></i> [Mailings][3] (bulk mailings by merged document, email or SMS)
* <i class="ph ph-chat-teardrop-text" aria-hidden="true"></i> [Chat sessions][12]
* <i class="ph ph-rows" aria-hidden="true"></i> Form submissions

## Where do I find activities?

The [Activities section tab][18] is available in the Company, Contact, Project, Sale, and Diary screens.

> [!NOTE]
> Activities are also displayed in the [different views][7] in the Diary screen.

## <a id="view"></a>View activities

The activities displayed depend on which filters you select at the bottom of the section tab. You can show all activities, or just one of the types. Click the **Filter** button (<i class="ph ph-funnel" aria-hidden="true"></i>) to [filter activities][17] by date and user.

![Activities section tabs shows filter options of different record types -screenshot][img4]

## Columns

The activities list columns contain the following information:

* The first column in the activities list specifies the **Completed** status of an activity. A tick (<i class="ph ph-check" aria-hidden="true"></i>) means that the activity is completed, while an empty box means that it is not completed.

* The **Category** column contains icons that indicate the type of activity, for example, a calendar for a meeting. These icons reflect the text in the **Type** column.

* The other columns in the activities list show various information about the activity. If not all the text in a field is visible, hold the mouse pointer over it to display it in a tooltip.

## Create activity

You create activities using the **New** menu in the top bar, or by clicking **Add** button in the section tab.

## <a id="delete"></a>Delete activity

You can delete activities from any screen where they are displayed:

1. Select one or more activities that you want to delete.

2. Right-click the selected activity or activities and select **Delete**.

3. When asked if you really want to delete the activity, click **Yes**.

[!include[Deleting items](../includes/tip-deletion.md)]

## Preferences <i class="ph ph-user-circle" aria-label="Contact icon"></i>

After an activity is completed, it is removed from the activities list by the next day. By default, the **Activities** section tab displays to-dos that you have not completed as of today's date.

### Display future to-dos

1. Go to **Personal settings** > **Preferences**.
2. Select **Functions** and find the **Show days ahead** option.
3. Define how many days ahead you want completed activities to be visible for. For example, entering 7 here would display to-dos for the next week.

### Remove activity from list when completed

1. Go to **Personal settings** > **Preferences**.
2. Select **Visual effects**.
3. Update the **Remove completed activities** [preference][2].

### Highlight overdue activities

If an activity is highlighted in red type, this means that its provisional date was passed. To change this setting:

1. Go to **Personal settings** > **Preferences**.
2. Select **Functions**.
3. Update the **Mark overdue activities** option.

## Related content

* [Filter activities][17]
* [Change Completed status of an activity][10]
* [Add follow-up (meeting, to-do, call)][8]
* [Dial contacts][11]
* [Work with documents][4]
* [Compose an email][5]
* [The Activities tab][18]

<!-- Referenced links -->
[1]: ../../diary/learn/follow-ups.md
[2]: ../getting-started/preferences.md
[3]: ../../marketing/mailing/learn/index.md
[4]: ../../document/learn/index.md
[5]: ../../email/learn/compose.md
[7]: ../../diary/learn/index.md
[8]: ../../diary/learn/create-follow-up.md
[10]: ../../diary/learn/change-completed-status.md
[11]: ../../contact/learn/dial.md
[12]: ../../chat/learn/index.md
[17]: ../section-tabs/filter.md
[18]: ../section-tabs/activities-tab.md

<!-- Referenced images -->
[img3]: ../../../media/loc/en/diary/activities-detail.png
[img4]: ../../../media/loc/en/learn/activities-filter.png
