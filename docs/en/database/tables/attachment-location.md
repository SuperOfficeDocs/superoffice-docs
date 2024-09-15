---
uid: table-attachment_location
title: attachment_location table
description: A location for storing attachments
so.generated: true
keywords: database table attachment_location
so.topic: reference
so.envir: onsite, online
---

# attachment\_location Table (476)

A location for storing attachments

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

[!include[details](./includes/attachment-location.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|attachment\_location\_id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[attachment](attachment.md)  |This table contains metadata for attachments. The actual attachments are stored directly on disk, with filenames based on the the primary key for this table. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

