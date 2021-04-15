---
title: Clone
uid: clone_to_test_envir
description: Steps performed when we clone a source database to a test environment
author: {github-id}
keywords: tenant
so.topic: howto
so.envir: cloud
so.client: online
---

# Steps performed when we clone a source database to a test environment

> [!NOTE]
> **Depending on source database size steps 1,5,9, and 11 may take a long while!**

| Task number | Task | Description |
|:-:|---------|------|
| 1 | Wait for saga 'Backup Source Customer' to complete | Source database is backed up. |
| 2 | Wait for customer tasks to complete and enter offline maintenance mode | |
| 3 | Wait for customer task to complete | |
| 4 | Connecting customer to old clusters | |
| 5 | Restore customer backup from CustSOURCE | The database copy from source will now be restored as the target database. |
| 6 | Copy Customer Info | |
| 7 | Create SQL login | SQL Server logins must be created in target database after replace |
| 8 | Fix system users | System users must be created in the target database after replace |
| 9 | Replacing all personal email domains with `@mailinator.com` | All email addresses in the source database will be replaced in the test environment. Default `john.doe@company.com` will be changed to `john.doe_company.com@mailinator.com`, `mailinator.com` may be changed in the cloning wizard. |
| 10 | Register Customer In SuperId | |
| 11 | Clone Azure Templates from CustSOURCE on | Copy templates from source to target. |
| 12 | Provision Mail Service | All mailboxes used by Service are deleted and replaced with one single test email account for this domain. |
| 13 | Disable Scheduled Tasks | Any schedule tasks that have been active on the source will by default be set to disabled. Read more about scheduled tasks in the [admin help file][1] |
| 14 | Recycle customer | Recycle the target |
| 15 | Change the serial number to Test Env - COMPANYNAME/SERIALNUMBER | We need to change the serial number and owner company to match that of the test tenant. License information. |
| 16 | Set SuperId Tenant State to *In migration* | |
| 17 | Assign user plans | Assign user plans to the users that should be allowed to log in to the test environment.|
| 18 | Sync Customer SuperId Users | |
| 19 | Set SuperId Tenant State to *Normal* | |
| 20 | Create Partner System Users From App Authorizations in Customer Database | If this replaces an existing test environment with a new copy from source, then any apps authorized on the test environment that uses a system user must be re-created in the target database. |
| 21 | Update Company Info From Customer Database | |
| 22 | Clone SoArc system attachments from Source | New from September: only clone the attachments for Service chosen (new step) |
| 23 | Notify apps about Changing State with `BackupRestored` | Notify partner apps |
| 24 | Enter Running Mode | The test environment may now be logged in to! |

<!-- Referenced links -->
[1]: https://community.superoffice.com/documentation/help/en/crm/9.2/webhelpadmin/index.htm#t=topics_script%2Fblogic.listScheduledTasks.html
