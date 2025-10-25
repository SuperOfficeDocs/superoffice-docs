---
uid: user-preferences
title: User preferences
description: Preference sections
keywords: user preference, setting
author: SuperOffice Product and Engineering
date: 10.14.2025
content_type: concept
audience: admin
audience_tooltip: Settings and maintenance
category: settings
topic: user preferences
index: true
language: en
redirect_from: /en/admin/user-preferences/howto/index
---

# User preferences

Preferences are used to personalize SuperOffice. The aim of this is to make the application more user-friendly. We store information on default values the user has set, different visual settings, and you may even store preferences for your own application.

For example:

* Whether the calendar starts on Sunday or Monday
* The size of the calendar
* The starting time of the calendar
* The end time of an all-day event

Preferences can also be used to add default values for a document or follow-up.

> [!NOTE]
> All preferences are stored in the [UserPreference table][6].

## Levels

Preferences can be defined at 6 different levels:

| Level | Description |
|---|---|
| 1 | global defaults |
| 2 | system-wide |
| 3 | database-wide (for example, specific to a satellite) |
| 4 | user-group-wide (all users in a particular group) |
| 5 | user-specific |
| 6 | machine-specific (stored in registry under HKLM) |

User preferences are stored at multiple levels.

We always use the most specific preference for the logged-in user.

## UserPreference sample table

| `id` | `deflevel` | `maxlevel` | `owner_id` | `prefsection` | `prefkey` | `prefvalue` |
|---|---|---|---|---|---|---|
| 1 | 2 | 5 | 0   | MyThing | Volume | quiet  |
| 2 | 4 | 5 | 123 | MyThing | Volume | off    |
| 3 | 5 | 5 | 456 | MyThing | Volume | loud   |
| 4 | 5 | 5 | 789 | MyThing | Volume | quiet  |
| 5 | 2 | 3 | 0   | MyThing | Color  | purple |
| 6 | 3 | 3 | 999 | MyThing | Color  | green  |

The `deflevel` value defines which level this preference value is defined at. The values here correspond to the list above.

The `maxLevel` value defines the maximum level at which a preference should be shown in the GUI. Some preferences are not controlled by the user, and can only be edited in the admin tool.

The meaning of the `owner_id` depends on the `deflevel` value.

| `deflevel` | `owner_id` |
|---|---|
| 1 | 0 |
| 2 | 0 |
| 3 | satellite ID (`travelcurrent_id`) |
| 4 | `usergroup_id` |
| 5 | `associate_id` |
| 6 | not stored in database; stored in registry |

Given the sample data above, a typical user would have the default value for the preference

\[MyThing\] Volume = "quiet"

since this is the system-wide default.

A user who is in primary user-group 123 would get the value "off" for the same preference since row ID 2 overrides the more general preference in row ID 1.

The user with `associate_id` 456 (even if he was in user-group 123) would get his user-specific preference, which is "loud".

The user with `assoicate_id` 789 would get the value "quiet" because of the preference with ID 4. The user-specific preference has a higher priority than any of the others, so it is the one that applies.

> [!NOTE]
> You can define whatever section and key names you want. You do not need to register your section with SuperOffice. Just start using the section and key names directly.
>
> If there is no value defined, you won't find a user-preference value in the table. Your code should take care to handle empty preferences sensibly.

With no default defined, we get the empty string back.

## How-to

In NetServer, we can either retrieve the current values of these preferences or set our own. Selected classes can be grouped as [preference caches][5].

> [!CAUTION]
> Many of these preferences control important system functions, and changing the values or adding a new preference value may cause the SuperOffice application or specific functionality (like Travel or Area management) to stop working. **Be very careful when changing these preferences.**

* [Get preferences - services][1]
* [Get preferences - data layer][3]
* [Set preferences - services][2]
* [Set preferences - data layer][4]

## Related content

* [Preference section reference][8]
* [UserPreference database table][6]
* [Changing personal settings][7] - in SuperOffice CRM
* [Global preferences][9] - in Settings and maintenance

<!-- Referenced links -->
[1]: ../../api/web-services/howto/user-preferences/get-preferences-preferenceagent.md
[2]: ../../api/web-services/howto/user-preferences/set-preferences-preferenceagent.md
[3]: ../../api/entities/howto/user-preferences/get-preferences-sopreference.md
[4]: ../../api/entities/howto/user-preferences/set-preferences-sopreference.md
[5]: ../../api/caching/superoffice-crm-security.md
[6]: ../../database/tables/userpreference.md
[7]: ../../learn/getting-started/preferences.md
[8]: reference/appointment-dialog.md
[9]: ../preferences/index.md
