---
uid: caching-overview
title: caching
description: What is cached in SuperOffice and how to retrieve it.
author: Bergfrid Dias
date: 02.22.2022
keywords: cache, performance
content_type: concept
redirect_from: /en/api/netserver/caching/index
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
* [Get preferences - data layer][13]
* [Set preferences - services][12]
* [Set preferences - data layer][14]

<!-- Referenced links -->
[1]: cached-tables.md
[2]: superoffice-crm-security.md
[3]: superoffice-crm-cache.md
[4]: associate-cache.md
[5]: category-cache.md
[6]: ../../admin/user-preferences/index.md
[11]: ../web-services/howto/user-preferences/get-preferences-preferenceagent.md
[12]: ../web-services/howto/user-preferences/set-preferences-preferenceagent.md
[13]: ../entities/howto/user-preferences/get-preferences-sopreference.md
[14]: ../entities/howto/user-preferences/set-preferences-sopreference.md
