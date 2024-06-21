---
title: SoTables.ini
uid: sotables_ini
description: SoTables.ini
author: Bergfrid Dias
date: 12.10.2021
keywords: database, DBSetup, SoTables.ini
topic: reference
# envir:
# client:
---

# SoTables.ini

Used by [DBSetup.exe][1]

* This file is up until 8.1 used during the setup phase - it describes which prime data files are to be loaded into the newly created or upgraded database.

* Before 8.1 the file is created automatically during the setup process with links to our priming data. From 8.1 the priming data is part of our dictionary steps and the files are no longer used.

* You may manually edit this file to import additional data.

Before SuperOffice 8.1 and the [continuous database][2], this file would also have some sections that were always loaded after a fresh install, when creating a new database. These are not available from the dropdown menu inside DBSetup.exe to avoid running them unintentionally.

Some sections may be re-run to update or add additional data, and you may also create your own section to add your own import files.

## Sections in this file

Sections Init, Register, and Upgrade are hidden from the Load or re-load initial data into an 8.1+ database dropdown in SuperOffice CRM Database Maintenance (DBsetup.exe) menu.

You may add your own import files and add a section inside brackets, like: `[MyImportSection]`

The prefix before =path.and.filename just needs to be unique.

```text
UNIQEPREFIX_A=c:\program files (x86)\SuperOffice\SuperOffice Server\Init\MyImportFile.imp
```

## Creating your own imp file

The imp file must match the table you want to import, starting with the table name inside brackets. On the line below you may specify what you want to do with the current data in this table.

### Truncate_table

This will delete all data in the table before it imports what is found in the imp file.

### Truncate_BuiltIn and Set_BuiltIn

Special data marked as belonging to SuperOffice may be updated in later releases, this is done by us flagging our data with 1 inside the IsBuildIn field of the database table. Then we can later tell DBSetup that we only want to delete our data, but leave customer and partner rows behind in the database.

> [!NOTE]
> If you set the primary key of a table to 0 then DBSetup, which automatically sets the primary key to the next available value. If you want to set it hard to a specific ID as we do in the `SORPublish` table in the *I_STDReportsNew.imp* file.
If you need to reuse a privacy key later, in another table you may use variables like `#MyTableEntry_id1`, `#MyTableEntry_id2`, and so on. Then in a later table in the same imp file, you may pick up the value and assign it as a foreignKey.

![x -screenshot][img1]

<!-- Referenced links -->
[1]: dbsetup-exe.md
[2]: ../../../database/dictionary/howto-make-db-changes.md

<!-- Referenced links -->
[img1]:media/primaryforeignkey.png
