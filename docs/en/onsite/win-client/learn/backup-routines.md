---
uid: help-en-backup-routines
title: Backup routines
description: Backup routines
author: SuperOffice RnD
date: 06.29.2022
keywords: Windows Client settings
topic: help
language: en
client: win
envir: onsite
---

# Backup routines

If a database error occurs, it is extremely important that you have good backup routines. Backing up may seem a tedious chore when you have to spend time on it every day, but if something goes wrong, the error can be remedied quickly if you have a copy of the database from the previous day.

Imagine that you have built up a company database of 1,500 companies over a year. You have used SuperOffice CRM every day and created companies that you call and follow up every week. You have entered appointments well into the future and recorded all documents and follow-ups in SuperOffice CRM. But you have "forgotten" to take a backup for the last six months.

One day an error occurs on the hard disk which cannot be rectified immediately. You call SuperOffice and are asked if you backed up yesterday.

Imagine that you have to use a six-month old backup. How many important companies have you added after that? How many important telephone numbers were in the database? How many addresses?

> [!NOTE]
> Remember that databases and hard disks are not failsafe. Errors do occur and your most important remedial tool is a good backup routine. You should back up the database every day.

## To back up only the data file

* If you are using an SQL database, follow the instructions for backing up contained in the documentation of the SQL database concerned. This generates a database that can be used only in conjunction with the database it was generated from. This is the fastest means of making a backup.

* Open the **dbsetup.exe** file in the SuperOffice Server installation folder, and select the **Export a database to file** option. This generates a database that can be installed on all types of servers supported by SuperOffice CRM.

If, in addition, you want to back up all documents and templates, you must create a backup of the whole **SO_ARC** folder and associated sub-folders.

<!-- online --> Online customers must contact SuperOffice Support to create a backup.
