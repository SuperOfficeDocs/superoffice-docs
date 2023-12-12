---
title: Preferences
uid: preferences-howto
description: Caching preferences
author: Bergfrid Dias
so.date: 02.22.2022
keywords: user preferences
so.topic: concept
---

# Preferences

Preferences are used to personalize SuperOffice. The aim of this is to make the application more user-friendly. We store information on default values the user has set, different visual settings, and you may even store preferences for your own application.

For example:

* whether the calendar starts on Sunday or Monday
* the size of the calendar
* the starting time of the calendar
* the end time of an all-day event

Preferences can also be used to add default values for a document or follow-up.

> [!NOTE]
> All preferences are stored in the [UserPreference table][6].

Selected classes can be grouped as [preference caches][5].

## How-to

In NetServer, we can either retrieve the current values of these preferences or set our own.

* [Get preferences - services][1]
* [Get preferences - data layer][2]
* [Set preferences - services][3]
* [Set preferences - data layer][4]

<!-- Referenced links -->
[1]: get-preferences-preferenceagent.md
[2]: get-preferences-sopreference.md
[3]: set-preferences-preferenceagent.md
[4]: set-preferences-sopreference.md
[5]: ../../../api/caching/superoffice-crm-security.md
[6]: ../../../database/tables/userpreference.md

<!-- Referenced images -->
