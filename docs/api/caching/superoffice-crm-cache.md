---
title: superoffice_crm_cache
description: SuperOffice.CRM.Cache 
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: cache
so.topic: reference
---

# SuperOffice.CRM.Cache

This is one of the namespaces related to the caching provided by the NetServer.

The namespace exposes the following classes to the user:

* **AssociateCache** holds information about the users (the people who log in to the application). These users can be either associates with login rights, windows or web client users, or even external system and anonymous users. The cache is a window, which shows data stored in the `Associate` table.

* **CategoryCache** holds information about the category (mandatory on a Company). The cache is a window, which shows data stored in the `Category` table.

* **MDOListTableCache** holds the items that are in the MDO tables. These tables can be identified as containers for cached results that represent a Row in an MDO table.

* **PriorityCache** holds information about the activities' priority. The cache is a window, which shows data stored in the `Priority` table.

* **ProbCache** holds information about the sale probability. The cache is a window, which shows data stored in the `Prob` table.

* **RedLetterDayCache** holds information about red-letters days (national holidays and other important days) of the calendar. It is possible to store red-letter days for more than one country in the database and these may or may not be colored in red in the diary.

* **RowCacheBase** is the base class for all caches. It is built over the HDB rows.
