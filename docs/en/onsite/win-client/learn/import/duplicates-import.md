---
uid: help-en-duplicates-import
title: Duplicates import
description: Duplicates import
author: SuperOffice RnD
date: 06.29.2022
keywords: Windows Client settings
topic: help
language: en
client: win
envir: onsite
---

# Duplicates

A duplicate occurs if you have the same record in the import file and in the database. You must always specify rules for managing duplicates during an import in an [import description][1]. These rules will then be included in the import description when you save it. This applies to all data types. The **Handling of duplicates** table has the following columns:

* **Table**: shows which data type this duplicate handling rule applies to. The contents of this column are based on what you specified in the **Field in SuperOffice CRM** column under **Field mapping**.
* **Key**: shows an import key, the criteria that must be satisfied for a record to be considered a duplicate.
* **Action**: shows what happens if a duplicate is encountered.

## What would you like to do now?

* [Update rules for duplicate handling][2]
* [Reset rules for duplicate handling][3]

<!-- Referenced links -->
[1]: import-descriptions.md
[2]: updating-rules-for-duplicate-handling.md
[3]: resetting-rules-for-duplicate-handling.md

<!-- Referenced images -->
