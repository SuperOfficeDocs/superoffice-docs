---
uid: table-attachment_location
title: attachment_location table
description: A location for storing attachments
so.generated: true
keywords:
  - "database"
  - "attachment_location"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# attachment\_location Table (471)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|attachment\_location\_id|Primary key|PK| |
|path|The path for this location|String(4000)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![attachment_location table relationship diagram](./media/attachment_location.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|attachment\_location\_id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

