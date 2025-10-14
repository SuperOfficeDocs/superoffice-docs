---
title: Preferences
uid: preferences-howto
description: Caching preferences
author: Bergfrid Dias
date: 02.22.2022
keywords: user preferences
content_type: concept
index: true
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
* [Get preferences - data layer][3]
* [Set preferences - services][2]
* [Set preferences - data layer][4]

<!-- Referenced links -->
[1]: ../../../api/web-services/howto/user-preferences/get-preferences-preferenceagent.md
[2]: ../../../api/web-services/howto/user-preferences/set-preferences-preferenceagent.md
[3]: ../../../api/entities/howto/user-preferences/get-preferences-sopreference.md
[4]: ../../../api/entities/howto/user-preferences/set-preferences-sopreference.md
[5]: ../../../api/caching/superoffice-crm-security.md
[6]: ../../../database/tables/userpreference.md

<!-- Referenced images -->
