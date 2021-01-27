---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: user_preferences       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference sections  # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# User preferences

These pages describe the user-preferences used in SuperOffice.

> [!NOTE]
> Many of these preferences control important system functions, and changing the values or adding a new preference value may cause the SuperOffice application or specific functionality (like travel or area management) to stop working. **Be very careful when changing these preferences.**

Preferences are stored in the `UserPreference` table in the database.

Preferences can be defined at 6 different levels:

| Level | Description |
|---|---|
| 1 | global defaults |
| 2 | system wide |
| 3 | database wide (e.g. specific to a satellite) |
| 4 | user-group wide (all users in a particular group) |
| 5 | user specific |
| 6 | machine specific (stored in registry under HKLM) |

User preferences are stored at multiple levels.

We always use the most specific preference for the logged in user.

## UserPreference sample table

| id | deflevel | maxlevel | owner\_id | prefsection | prefkey | prefvalue |
|---|---|---|---|---|---|---|
| 1 | 2 | 5 | 0   | MyThing | Volume | quiet  |
| 2 | 4 | 5 | 123 | MyThing | Volume | off    |
| 3 | 5 | 5 | 456 | MyThing | Volume | loud   |
| 4 | 5 | 5 | 789 | MyThing | Volume | quiet  |
| 5 | 2 | 3 | 0   | MyThing | Color  | purple |
| 6 | 3 | 3 | 999 | MyThing | Color  | green  |

The `deflevel` value defines which level this preference value is defined at. The values here correspond to the list above.

The `maxLevel` value defines the max level at which a preference should be shown in the GUI. Some preferences are not controlled by the user, and can only be edited in the admin tool.

The meaning of the `owner_id` depends on the deflevel value.

| deflevel | owner\_id |
|---|---|
| 1 | 0 |
| 2 | 0 |
| 3 | satellite ID (travelcurrent\_id) |
| 4 | usergroup\_id |
| 5 | associate\_id |
| 6 | not stored in database; stored in registry |

Given the sample data above, a typical user would have the default value for the preference

\[MyThing\] Volume = "quiet"

since this is the system-wide default.

A user who is in primary usergroup 123 would get the value "off" for the same preference, since row ID 2 overrides the more general preference in row ID 1.

The user with associate\_id 456 (even if he was in usergroup 123) would get his user-specific preference, which is "loud".

The user with assoicate\_id 789 would get the value "quiet" because of the preference with ID 4. The user-specific preference has a higher priority than any of the others, so it is the one which applies.

> [!NOTE]
> You can define whatever section and keynames you want. You do not need to register your section with SuperOffice. Just start using the section and key names directly.<br>If there is no value defined, you won't find a userpreference value in the table. Your code should take care to handle empty preferences in a sensible way.

With no default defined, we get the empty string back.
