---
uid: table-s_picture_entry
title: s_picture_entry table
description: This table describes each picture in the database
so.generated: true
keywords: database table s_picture_entry
so.topic: reference
so.envir: onsite, online
---

# s\_picture\_entry Table (340)

This table describes each picture in the database

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|attachment\_id|The id of the attachment in the attachment table|FK [attachment](attachment.md)|&#x25CF;|
|description|A description of the picture|String(255)|&#x25CF;|
|folder\_id|The folder which this picture belongs to. -1 indicates that the picture is on the root|Int| |
|flags|Various flags for this picture|UInt|&#x25CF;|
|status|Indicates the status of the picture. 0 = ok, 1 = deleted|Short| |
|hits|Number of hits on this image|Int|&#x25CF;|
|registered|Registered when|UtcDateTime|&#x25CF;|
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)|&#x25CF;|
|updated|Last updated when|UtcDateTime|&#x25CF;|
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)|&#x25CF;|
|updatedCount|Number of updates made to this record|UShort|&#x25CF;|


![s_picture_entry table relationship diagram](./media/s_picture_entry.png)

[!include[details](./includes/s-picture-entry.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|attachment\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[attachment](attachment.md)  |This table contains metadata for attachments. The actual attachments are stored directly on disk, with filenames based on the the primary key for this table. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

