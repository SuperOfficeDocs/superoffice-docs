---
uid: help-en-preferences
title: Preferences
description: Administrators can set preferences for various functions in the system for specific users, user groups, or for the entire SuperOffice CRM (global preferences).
author: Bergfrid Dias
so.date: 03.21.2023
keywords: settings, preferences
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Preferences

In the Preferences screen you can set preferences for the whole system (globally), one database, one user group or an individual user. Preferences that can be set only on a global (system) level, are located in the **[Global preferences][1]** tab.

Users can edit the settings of [individual preferences][4] to customize them for their own use by going to **Personal settings** > **Preferences** in the Top bar. The preferences available to the user depend on what is specified in Settings and maintenance.

In addition, you can configure video meetings in the [Video meetings][8] tab and document library in the [Document library][9] tab.

## <a id="levels" />Levels for preference settings

You can specify preference settings for four different levels:

| Level | Description |
|---|---|
| System | Global preferences that apply to all users in the system, including all satellites, groups and individual users. |
| Database | Preferences that apply to one specific database and all groups and users connected to this database. |
| Group | Preferences that apply to all users in a specific group. |
| User | Preferences that are linked to each individual user. |

You can specify different values for different levels so that, for example, you can have one setting for a user and a different setting for the user group that the contact belongs to. The lowest level always applies.

> [!NOTE]
> Not all levels are available for all preferences. If any of the options are disabled, you cannot choose them for the selected preference.

You can choose which settings to display in the list based on the level they are specified for, in the **Active settings** field. The levels displayed depend on which levels you check at the bottom of the field. You can use these checkboxes to show one, two or all levels.

> [!NOTE]
> Settings for the system level are always displayed.

## <a id="global" />Global preferences (for the whole system)

Some [preferences][1] can be set only on a global level:

* Statistics
* Functions
* Email
* Grouped lists
* Marketing
* Mobile CRM
* Sale
* SuperOffice Service system settings
* System
* SMS configuration
* Customer Centre password policy

### Change global preferences

To edit these preferences, go to the ![icon][img1] **Preferences** screen and select the **Global preferences** tab.

* The various preferences are divided into sections.
* Hold the mouse-pointer over a preference to display additional info.
* Click **Save** to implement your changes.

## <a id="preferences-tab" />Preferences tab

In the **Preferences** tab you can specify settings for different parts of SuperOffice CRM, such as the number of items to display in the history list, the default type for new meetings, and the default currency in the Sale screen.

At the top of the **Preferences** tab, you can choose the required preference group. The rest of the **Preferences** tab is divided into three main sections: a list of all preferences, a description field explaining description the preference currently selected, and a field showing the settings specified for that preference.

### Preferences list

On the left is the **Preferences** list containing all the preferences defined for the active preference group.

**Groups of preferences:**

* Contact
* Default values
* Diary
* Email
* Filter Dialog
* Free-text search
* Functions
* Grouped lists
* In-app communication
* Marketing
* Notifications via email + popup + SMS
* Request
* Sale
* Sorting
* System
* Tooltip
* Visual effects
* Web server
* Web Services

> [!NOTE]
> Preferences with active individual settings are shown in bold text.

### Active settings

The **Active settings** field shows the settings specified for the preference currently selected in the **Preferences** list, and the levels and the values for each. You can edit and delete existing settings and add new ones in this field.

The field consists of three columns:

| Column | Description |
|---|---|
| Who | Shows who the setting applies to (the name of the system, database, group or user). If this is an individual user, a tooltip about this user will pop up when you hold the mouse pointer over the user's initials in this column. |
| Level | Shows which [level the setting applies to](#levels) (system, database, group or user). |
| Value | Shows the value specified for the setting. |

The contents of these columns are defined in the **Setting** dialog. [How to add preference settings][3].

You can sort the rows in the columns by clicking on the required column heading. Click the column heading onc to sort in reverse order.

<!-- Referenced links -->
[1]: global-preferences/system.md
[3]: update-preferences.md
[4]: update-preferences.md#personal
[8]: video-meetings/index.md
[9]: document-library/index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-preferences-active.png
