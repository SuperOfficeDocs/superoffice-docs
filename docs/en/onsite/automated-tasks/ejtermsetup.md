---
uid: automated_task_ejtermsetup
title: ejTermSetup
description: Automated tasks in Service - ejTermSetup
author: SuperOffice Product and Engineering
date: 11.21.2025
category: Service
content_type: reference
deployment: onsite
redirect_from: /en/service/automated-tasks/ejtermsetup
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
