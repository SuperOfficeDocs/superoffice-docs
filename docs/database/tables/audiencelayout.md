---
uid: table-audiencelayout
title: audiencelayout table
description: One layout (of webparts and other stuff) for an audience instance
so.generated: true
keywords:
  - "database"
  - "AudienceLayout"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# audiencelayout Table (234)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|AudienceLayout\_id|Primary key|PK| |
|instanceName|The name of the installed instance of Audience - must match the web.config file|String(239)| |
|instanceLayout|The layout, as a serialized string via the Provider architecture|String(2047)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![AudienceLayout table relationship diagram](./media/AudienceLayout.png)

[!include[details](./includes/AudienceLayout.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|AudienceLayout\_id |PK |Clustered, Unique |
|instanceName |String(239) |Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

