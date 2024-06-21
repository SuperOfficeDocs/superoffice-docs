---
title: ejTermSetup
uid: automated_task_ejtermsetup
description: Automated tasks in Service - ejTermSetup
author: {github-id}
keywords: service
topic: reference
envir: onsite
# client:
---

# ejTermSetup

Used for priming your SuperOffice database with Service data.

> [!NOTE]
> This executable should be completed **only once** for a healthy installation.

* --base-path: By setting this you can override the suggestion you get for basePath when running ejTermSetup.
* --unix-socket: Obsolete - no longer in use
* --config-file: Path to the config file that ejTermSetup can use for input values. Makes it possible to run ejtermsetup.exe without user input.
* --noconfirm: When this is set we will use the default values for questions asked, like use MSSQL database and so on.
* --delete-tables: Obsolete - no longer in use and will be removed
