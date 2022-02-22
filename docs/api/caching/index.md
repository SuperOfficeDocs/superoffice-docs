---
uid: caching-overview
title: caching
description: What is cached in SuperOffice and how to retrieve it.
author: Bergfrid Dias
so.date: 02.22.2022
keywords: cache, performance
so.topic: concept
---

# Caching

A **cache** is a collection of data duplicating original values stored elsewhere or computed earlier where the original data is expensive in terms of access time to fetch or compute relatively to the cache.

Once the data is stored in the cache, future use can be made by accessing the cached copy rather than re-fetching or re-computing the original data, so that the average time is lower. Caches have proven extremely effective in many areas of computing because access patterns in typical computer applications have a locality of reference.

## What is cached?

* [NetServer data and security info][2]
  * DataRightsCache
  * FunctionRightsCache
  * OwnerContactCache
  * RefCountsPermissionCache
  * SentryPreferanceCache
  * UserGroupCache

* [Selected lists][3]
  * [AssociateCache][4]
  * [CategoryCache][5]
  * MDOListTableCache
  * PriorityCache
  * ProbCache
  * RedLetterDayCache

* [Certain tables][1] (Windows client)

## User preferences

The PreferenceCache stores information about [what the user prefers][6].

Here's how user preferences are handled *without* caching:

* [Get preferences - services][11]
* [Get preferences - data layer][12]
* [Set preferences - services][13]
* [Set preferences - data layer][14]

<!-- Referenced links -->
[1]: cached-tables.md
[2]: superoffice-crm-security.md
[3]: superoffice-crm-cache.md
[4]: associate-cache.md
[5]: category-cache.md
[6]: ../../admin/user-preferences/howto/index.md
[11]: ../../admin/user-preferences/howto/get-preferences-preferenceagent.md
[12]: ../../admin/user-preferences/howto/get-preferences-sopreference.md
[13]: ../../admin/user-preferences/howto/set-preferences-preferenceagent.md
[14]: ../../admin/user-preferences/howto/set-preferences-sopreference.md
