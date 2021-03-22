---
uid: table-audienceconfig
title: audienceconfig table
description: Configuration data for Audience core and webparts
so.generated: true
keywords:
  - "database"
  - "AudienceConfig"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# audienceconfig Table (236)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|AudienceConfig\_id|Primary key|PK| |
|audienceLayoutId|The name of the installed instance of Audience - must match the web.config file|FK [audiencelayout](audiencelayout.md)| |
|configName|The name of the configuration parameter|String(239)| |
|configValue|The value of the configuration parameter|String(239)| |
|seqno|Sequence number, for chaining multiple records in case the value is too long|UShort| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![AudienceConfig table relationship diagram](./media/AudienceConfig.png)

[!include[details](./includes/AudienceConfig.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|AudienceConfig\_id |PK |Clustered, Unique |
|audienceLayoutId |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

