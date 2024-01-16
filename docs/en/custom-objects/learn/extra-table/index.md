---
uid: help-en-extra-table
title:  Extra tables
description:  Extra tables
author: SuperOffice RnD
so.date: 06.29.2022
keywords: extra table
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Extra tables and fields

[!include[Requirement](../../../learn/includes/req-expander-services.md)]

The **Tables** screen displays the tables that are configured in the system. Using these tables, you can store data in the system exactly as you wish. You can create new tables and fields for different cards and dialogs. Only administrators have access to this functionality.

## Tables screen

In the **Tables** screen, there is a list of the database tables in SuperOffice. The data structures are configured in ![icon][img1] **System design** > **Tables**, where you can display and edit data content in the [tables][1].

This screen displays both standard tables (predefined in the system and form the basis of different screens) and extra tables (tables you create yourself with optional content).

> [!NOTE]
> You will see a message that NetServer must be restarted every time you add new fields or tables. If Travel is activated, you will also see a message that a new Travel database must be generated.

### Where to find the screen

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Click ![icon][img1] **System design** in the navigator and select the **Tables** tab.

### Table folder properties

This screen is used to edit the properties of a new or existing table folder. Table folders are used to organise your custom tables.

## Related topics

* [Add extra tables][2]
* [Add extra fields][3]
* [User-defined fields][4]

<!-- Referenced links -->
[1]: ../../../ui/blogic/learn/index.md
[2]: create.md
[3]: ../extra-field/create.md
[4]: ../../udef/index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-systemdesign-active.png
