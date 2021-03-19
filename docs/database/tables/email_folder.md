---
uid: email_folder
title: email_folder table
description: Corresponds to an email folder on a mail server
so.generated: true
keywords:
  - "database"
  - "email_folder"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# EmailFolder Table (475)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|email\_folder\_id|Primary key|PK| |
|account\_id|Account id|FK [email_account](email_account.md)|&#x25CF;|
|parent\_folder\_id|Parent folder|FK [email_folder](email_folder.md)|&#x25CF;|
|name|Folder name|String(255)|&#x25CF;|
|attributes|Folder attributes like Subscribed, HasChildren, Junk, Sent...|Int|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|folder\_separator|Character separating subfolders|String(255)|&#x25CF;|


![email_folder table relationship diagram](media\email_folder.png)

[!include[details](./includes/email-folder.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|email\_folder\_id |PK |Clustered, Unique |
|account\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

