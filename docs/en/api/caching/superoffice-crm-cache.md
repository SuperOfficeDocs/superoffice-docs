---
title: SuperOffice.CRM.Cache
uid: superoffice_crm_cache
description: SuperOffice.CRM.Cache
author: SuperOffice Product and Engineering
date: 02.22.2022
keywords: cache
content_type: reference
redirect_from: /en/api/netserver/caching/superoffice-crm-cache
---

# SuperOffice.CRM.Cache

This is one of the namespaces related to the caching provided by the NetServer.

The namespace exposes the following classes to the user:

* **AssociateCache** holds information about the users (the people who log in to the application). These users can be either [associates][1] with login rights, Windows or web client users, or even external system and anonymous users. The cache is a window, which shows data stored in the `Associate` table. [How to use the AssociateCache][3]

* **CategoryCache** holds information about the [category][2] (mandatory on a Company). The cache is a window, which shows data stored in the `Category` table.

* **MDOListTableCache** holds the items that are in the MDO tables. These tables can be identified as containers for cached results that represent a Row in an MDO table.

* **PriorityCache** holds information about the activities' priority. The cache is a window, which shows data stored in the `Priority` table.

* **ProbCache** holds information about the sale probability. The cache is a window, which shows data stored in the `Prob` table.

* **RedLetterDayCache** holds information about red-letters days (national holidays and other important days) of the calendar. It is possible to store red-letter days for more than one country in the database and these may or may not be colored in red in the diary.

* **RowCacheBase** is the base class for all caches. It is built over the HDB rows.

<!-- Referenced links -->
[1]: ../../contact/dev/index.md#associate
[2]: ../../company/category-list.md
[3]: associate-cache.md
