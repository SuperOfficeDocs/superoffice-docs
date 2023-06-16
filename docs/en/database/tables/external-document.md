---
uid: table-external_document
title: external_document table
description: This table stores documents which can be viewed externaly, through the customer module
so.generated: true
keywords: database table external_document
so.topic: reference
so.envir: onsite, online
---

# external\_document Table (401)

This table stores documents which can be viewed externaly, through the customer module

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|hierarchy\_id|This document belongs to the following folder|FK [hierarchy](hierarchy.md)| |
|attachment\_id|The attachment.id for the attachment associated with this external document.|FK [attachment](attachment.md)| |
|title|The title for the document|String(255)| |
|description|The description of the external document|Clob|&#x25CF;|
|created\_at|When the document was created|DateTime|&#x25CF;|
|created\_by|Who created the document|FK [ejuser](ejuser.md)| |
|last\_changed|When the document last was changed|DateTime|&#x25CF;|
|changed\_by|Who last changed the document|FK [ejuser](ejuser.md)|&#x25CF;|
|deleted|A boolean telling if the external document is to be treated as deleted|Bool| |
|s\_message|Relation to s_message if this document is an image in a newsletter|FK [s_message](s-message.md)|&#x25CF;|


![external_document table relationship diagram](./media/external_document.png)

[!include[details](./includes/external-document.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|hierarchy\_id |FK |Index |
|attachment\_id |FK |Index |
|title |String(255) |Index |
|created\_by |FK |Index |
|changed\_by |FK |Index |
|s\_message |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[attachment](attachment.md)  |This table contains metadata for attachments. The actual attachments are stored directly on disk, with filenames based on the the primary key for this table. |
|[ejuser](ejuser.md)  |This table contains entries for the users of the system. |
|[hierarchy](hierarchy.md)  |This table contains folders used to group the extra tables in the system. |
|[s\_message](s-message.md)  |A message used in a shipment. Can be html and/or plain text |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

