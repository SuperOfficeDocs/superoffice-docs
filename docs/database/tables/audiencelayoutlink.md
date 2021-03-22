---
uid: table-audiencelayoutlink
title: audiencelayoutlink table
description: Link between an audience layout and some target grouping table - might be Role or Category
so.generated: true
keywords:
  - "database"
  - "AudienceLayoutLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# audiencelayoutlink Table (235)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|AudienceLayoutLink\_id|Primary key|PK| |
|audienceLayoutId|The name of the installed instance of Audience - must match the web.config file|FK [audiencelayout](audiencelayout.md)| |
|targetTable|Table number of target table - entity that the layout is valid for|TableNumber| |
|targetRecord|ID of record in target table that this layout is valid for|RecordId| |
|comment|A possible user comment when making this link|String(254)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![AudienceLayoutLink table relationship diagram](./media/AudienceLayoutLink.png)

[!include[details](./includes/AudienceLayoutLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|AudienceLayoutLink\_id |PK |Clustered, Unique |
|audienceLayoutId |FK |Index |
|targetTable, targetRecord |TableNumber, RecordId |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

