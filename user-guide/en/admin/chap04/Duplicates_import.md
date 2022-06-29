---
uid: help-en-duplicates-import
title: Duplicates import
description: Duplicates import
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Windows Client settings
so.topic: help
language: en
---

# Duplicates

A duplicate occurs if you have the same record in the import file and in the database. You always need to specify rules for managing duplicates during an import in an import description (see [Import descriptions](Import_descriptions.md)). These rules will then be included in the import description when you save it. This applies to all data types. The **Handling of duplicates** table has the following columns:

* **Table**: shows which data type this duplicate handling rule applies to. The contents of this column are based on what you specified in the **Field in SuperOffice CRM** column under **Field mapping**.
* **Key**: shows an import key, i.e. which criteria must be satisfied for a record to be considered a duplicate.
* **Action**: shows what happens if a duplicate is encountered.

## What would you like to do now?

[Update rules for duplicate handling](Updating_rules_for_duplicate_handling.md)

[Reset rules for duplicate handling](Resetting_rules_for_duplicate_handling.md)
