---
uid: clone-to-sandbox-steps
title: Clone
description: Steps performed when we clone a source database to a production sandbox
author: Bergfrid Dias, Margrethe Halvorsen
date: 12.11.2024
version: 10
keywords: tenant, sandbox, test environment, clone
topic: reference
envir: cloud
client: online
---

# Steps performed when we clone a source database to a production sandbox

> [!NOTE]
> **Depending on source database size, step 8 might take long!**

| Task number | Task | Description |
|:-:|---|---|
| 01 | Wait for customer tasks to complete and enter offline maintenance mode | |
| 02 | Wait for customer task to complete | |
| 03 | Connecting customer to old clusters | |
| 04 | Remove mail routes | |
| 05 | Drop database | |
| 06 | Create customer database | |
| 07 | Create SQL login | SQL Server logins must be created in target database after replace |
| 08 | Copy customer database from XXX to ZZZ | |
| 09 | Prepare cloned database for target customer | |
| 10 | Create SQL login | |
| 11 | Disable scheduled tasks | Any scheduled tasks that have been active on the source will by default be set to disabled. [Read more][1] |
| 12 | Fix system users | System users must be created in the target database after replace |
| 13 | Replacing all personal email domains with '@mailinator.com' | All email addresses in the source database will be replaced in the production sandbox. Default `john.doe@company.com` will be changed to `john.doe_company.com@mailinator.com`, `mailinator.com` may be changed in the cloning wizard. |
| 14 | Register customer in SuperID | |
| 15 | Replace test environment in SuperID | |
| 16 | Clone Azure templates from CUST on ARCHIVEServer | Copy templates from source to target. |
| 17 | Verify or provision mail service | All mailboxes used by Service are deleted and replaced with one single test email account for this domain. |
| 18 | Set database permissions for customer query | |
| 19 | Recycle customer | Recycle the target |
| 20 | Change serial number to TEST NAME/ SERIALNUMBER | We need to change the serial number and owner company to match that of the test tenant. License information. |
| 21 | Set SuperId Tenant State to: *In migration* | |
| 22 | Assign user plans | Assign user plans to the users that should be allowed to log in to the production sandbox.|
| 23 | Sync customer SuperID users | |
| 24 | Set SuperID tenant state to: *Normal* | |
| 25 | Create partner system users from app authorizations in customer database | If this replaces an existing sandbox with a new copy from source, any apps authorized on the sandbox that uses a system user must be re-created in the target database. |
| 26 | Update company info and license | |
| 27 | Clone EjPackages in Azure from CustID | |
| 28 | Clone EjPackages in SoArc from CustID | |
| 29 | Notify apps about Changing State with BackupRestored | Notify partner apps |
| 30 | Enter running mode | The production sandbox may now be logged in to! |
| 31 | Wait for customers IIS ApplicationHost.config operations to complete | |

<!-- Referenced links -->
[1]: ../../automation/crmscript/learn/schedule-task.md
