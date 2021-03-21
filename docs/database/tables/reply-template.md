---
uid: table-reply-template
title: reply\_template table
description: Templates for automatic and manual replies to emails/sms organized hierachically
so.generated: true
keywords:
  - "database"
  - "reply_template"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# reply\_template Table (277)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|name|The name for this reply template.|String(255)| |
|description|The description for this reply template.|String(255)|&#x25CF;|
|folder\_id|The id of the folder in which this reply template is located. NULL or -1 if this is a toplevel reply template.|FK [reply-template-folder](reply-template-folder.md)| |
|owned\_by|The id of the user who owns this reply template.|FK [ejuser](ejuser.md)|&#x25CF;|
|last\_changed|When the reply template was last changed.|DateTime|&#x25CF;|
|access\_level|The access level (enum) for this reply template.|access-level|&#x25CF;|
|flags|A bitmap for flags.not used for anything [snarum 29 aug 2001]|Int|&#x25CF;|


![reply_template table relationship diagram](./media/reply_template.png)

[!include[details](./includes/reply-template.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|name |String(255) |Index |
|folder\_id |FK |Index |
|owned\_by |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

