---
uid: table-s-picture-folder
title: s\_picture\_folder table
description: This table contains all picture folders
so.generated: true
keywords:
  - "database"
  - "s_picture_folder"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# s\_picture\_folder Table (339)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|name|Name of folder|String(255)| |
|parent\_id|The parent id for this folder. -1 for root folders|Int| |
|description|A description of the folder|String(255)|&#x25CF;|
|folder\_type|Indicates which type of folder this is|Short| |
|registered|Registered when|UtcDateTime|&#x25CF;|
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)|&#x25CF;|
|updated|Last updated when|UtcDateTime|&#x25CF;|
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)|&#x25CF;|
|updatedCount|Number of updates made to this record|UShort|&#x25CF;|


![s_picture_folder table relationship diagram](./media/s_picture_folder.png)

[!include[details](./includes/s-picture-folder.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|folder\_type |Short |Index |
|parent\_id, folder\_type |Int, Short |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

