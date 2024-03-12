---
uid: table-quick_reply
title: quick_reply table
description: Personal quick reply text fragments
so.generated: true
keywords: database table quick_reply
so.topic: reference
so.envir: onsite, online
---

# quick\_reply Table (463)

Personal quick reply text fragments

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|quick\_reply\_id|Primary key|PK| |
|associate\_id|Associate who owns this quick reply|FK [associate](associate.md)|&#x25CF;|
|name|The short name of the quick reply|String(255)|&#x25CF;|
|html\_body|The html body of the quick reply|Clob|&#x25CF;|
|rank|Rank order in lists|UShort| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![quick_reply table relationship diagram](./media/quick_reply.png)

[!include[details](./includes/quick-reply.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|quick\_reply\_id |PK |Clustered, Unique |
|rank |UShort |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

