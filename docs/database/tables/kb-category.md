---
uid: table-kb-category
title: kb\_category table
description: Knowledge base folder hierarchy
so.generated: true
keywords:
  - "database"
  - "kb_category"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# kb\_category Table (283)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|parent\_id|This entry contains a reference to the parent category. NULL or -1 if this is a toplevel category.|FK [kb-category](kb-category.md)| |
|name|The name of this category.|String(64)|&#x25CF;|
|fullname|The full name of this category, i.e. Foo/bar/test.|Clob|&#x25CF;|
|description|The description of this category.|Clob|&#x25CF;|
|sort\_order|A strictly ascending number used for sorting categories when they are listed.|Int| |
|access\_level|The access level for this category (enum).|access-level|&#x25CF;|
|inherited\_access\_level|The lowest access level for this category or any parent|inherited-access-level|&#x25CF;|
|created\_by|The id of the user who created this category.|FK [ejuser](ejuser.md)|&#x25CF;|
|access\_check|Contains a Parser-script used for evaluating customer access to this category.|Clob|&#x25CF;|
|dbi\_agent\_id|Integration agent (eJournal)|FK [dbi-agent](dbi-agent.md)| |
|dbi\_key|The primary key for the integrated entry in the external datasource.|String(255)| |
|dbi\_last\_syncronized|Last external syncronization.|DateTime| |
|dbi\_last\_modified|When the entry was last modified.|DateTime| |


![kb_category table relationship diagram](./media/kb_category.png)

[!include[details](./includes/kb-category.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|parent\_id |FK |Index |
|sort\_order |Int |Index |
|created\_by |FK |Index |
|dbi\_agent\_id |FK |Index |
|dbi\_key |String(255) |Index |
|dbi\_last\_syncronized |DateTime |Index |
|dbi\_last\_modified |DateTime |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

