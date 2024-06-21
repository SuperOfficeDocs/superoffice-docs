---
uid: help-en-import-routines
title: Import routines
description: Import routines
author: SuperOffice RnD
date: 06.29.2022
keywords: Windows Client settings
topic: help
language: en
client: win
envir: onsite
---

# Import routines

There are two important things to remember before you import data:

* If you have an existing SuperOffice database that you want to import data into, you must perform a backup before you start. If anything goes wrong during the import, it is best to start again with the original database file. (See [Backup routines][8].)

* The data file you import from must be a text file, and specifically a Windows-based [ANSI file][1]. This means that if your customer index is saved in Excel, for example, you must save the Excel file as a text file before you can import the data from it into the SuperOffice database. You can check the file format by opening it in Excel. The file should have the file type **TXT** (for example **IMPORT.TXT**), and you must know which folder the file is in.

> [!NOTE]
> You cannot import files with fixed-length fields into the SuperOffice database unless the fields are delimited.

## Related topics

* [ANSI files][1]
* [Import files][2]
* [Field mapping][3]
* [Specify advanced import settings][4]
* [Duplicates][5]
* [Import descriptions][6]
* [Update information in the database][7]

<!-- Referenced links -->
[1]: ansi-files.md
[2]: importing-files.md
[3]: field-mapping.md
[4]: specifying-advanced-import-settings.md
[5]: duplicates-import.md
[6]: import-descriptions.md
[7]: ../update-database.md
[8]: ../backup-routines.md

<!-- Referenced images -->
