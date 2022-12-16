---
title: Clone
uid: clone_to_sandbox_steps
description: Steps performed when we clone a source database to a production sandbox
author: Bergfrid Dias
so.date: 12.06.2021
keywords: tenant, sandbox, test environment, clone
so.topic: reference
so.envir: cloud
so.client: online
---

# Steps performed when we clone a source database to a production sandbox

> [!NOTE]
> **Depending on source database size, steps 1, 5, 9, and 11 might take long!**

| Task number | Task | Description |
|:-:|---|---|
| 1 | Wait for saga 'Backup Source Customer' to complete | Source database is backed up. |
| 2 | Wait for customer tasks to complete and enter offline maintenance mode | |
| 3 | Wait for customer task to complete | |
| 4 | Connecting customer to old clusters | |
| 5 | Restore customer backup from CustSOURCE | The database copy from source will now be restored as the target database. |
| 6 | Copy Customer Info | |
| 7 | Create SQL login | SQL Server logins must be created in target database after replace |
| 8 | Fix system users | System users must be created in the target database after replace |
| 9 | Replacing all personal email domains with `@mailinator.com` | All email addresses in the source database will be replaced in the production sandbox. Default `john.doe@company.com` will be changed to `john.doe_company.com@mailinator.com`, `mailinator.com` may be changed in the cloning wizard. |
| 10 | Register customer in SuperID | |
| 11 | Clone Azure templates from CustSOURCE on | Copy templates from source to target. |
| 12 | Provision Mail Service | All mailboxes used by Service are deleted and replaced with one single test email account for this domain. |
| 13 | Disable Scheduled Tasks | Any scheduled tasks that have been active on the source will by default be set to disabled. [Read more][1] |
| 14 | Recycle customer | Recycle the target |
| 15 | Change the serial number to Test Env - COMPANYNAME/SERIALNUMBER | We need to change the serial number and owner company to match that of the test tenant. License information. |
| 16 | Set SuperID Tenant State to *In migration* | |
| 17 | Assign user plans | Assign user plans to the users that should be allowed to log in to the production sandbox.|
| 18 | Sync Customer SuperID Users | |
| 19 | Set SuperID Tenant State to *Normal* | |
| 20 | Create Partner System Users From App Authorizations in Customer Database | If this replaces an existing sandbox with a new copy from source, any apps authorized on the sandbox that uses a system user must be re-created in the target database. |
| 21 | Update Company Info From Customer Database | |
| 22 | Clone SoArc system attachments from Source | New from September: only clone the attachments for Service chosen (new step) |
| 23 | Notify apps about Changing State with `BackupRestored` | Notify partner apps |
| 24 | Enter Running Mode | The production sandbox may now be logged in to! |

<!-- Referenced links -->
[1]: ../../automation/learn/schedule-task.md
