---
uid: table-doc-document
title: doc\_document table
description: This table contains documents.
so.generated: true
keywords:
  - "database"
  - "doc_document"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# doc\_document Table (280)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|folder\_id|The id of the document folder this entry is located in.|FK [doc-folder](doc-folder.md)| |
|attachment\_id|The attachment.id for the attachment associated with this document.|FK [attachment](attachment.md)| |
|title|The title for the document|String(255)| |
|created\_at|When the document was created|DateTime|&#x25CF;|
|created\_by|Who created the document|FK [ejuser](ejuser.md)| |
|last\_changed|When the document last was changed|DateTime|&#x25CF;|
|changed\_by|Who last changed the document|FK [ejuser](ejuser.md)|&#x25CF;|
|status|The status of the document|status|&#x25CF;|
|access\_level|The access level of the document|access-level|&#x25CF;|
|description|A descriptive text for the document|Clob|&#x25CF;|
|id\_string|A field for an id_string which may be used to access the document|String(255)| |


![doc_document table relationship diagram](./media/doc_document.png)

[!include[details](./includes/doc-document.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|folder\_id |FK |Index |
|attachment\_id |FK |Index |
|title |String(255) |Index |
|created\_by |FK |Index |
|changed\_by |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

