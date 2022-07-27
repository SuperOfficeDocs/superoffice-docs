---
uid: help-en-import-routines
title: Import routines
description: Import routines
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Windows Client settings
so.topic: help
language: en
---

# Import routines

There are two important things to remember before you import data:

* If you have an existing SuperOffice database that you want to import data into, you must perform a backup before you start. If anything goes wrong during the import, it is best to start again with the original database file. (See the [Backup routines](../getting-started/Backup-routines.md) topic.)
* The data file you import from must be a text file, and specifically a Windows-based ANSI file (see [ANSI files](ANSI-files.md)). This means that if your customer index is saved in Excel, for example, you must save the Excel file as a text file before you can import the data from it into the SuperOffice database. You can check the file format by opening it in Excel. The file should have the file type **TXT** (for example **IMPORT.TXT**), and you must know which folder the file is in.

> [!NOTE]
> You cannot import files with fixed-length fields into the SuperOffice database unless the fields are delimited.

## Related topics

[ANSI files](ANSI-files.md)

[Import files](Importing-files.md)

[Field mapping](Field-mapping.md)

[Specify advanced import settings](Specifying-advanced-import-settings.md)

[Duplicates](Duplicates-import.md)

[Import descriptions](Import-descriptions.md)

[Update information in the database](Updating-database.md)
