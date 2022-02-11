---
uid: table-reply_template_body
title: reply_template_body table
description: Contains the body of the reply templates in different languages
so.generated: true
keywords:
  - "database"
  - "reply_template_body"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# reply\_template\_body Table (279)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|reply\_template\_id|Links the body to a reply template|FK [reply_template](reply-template.md)| |
|language\_id|Links the body to a reply template|FK [cust_lang](cust-lang.md)| |
|flags|Identifies the status of the template body. Default, not default etc.|Int| |
|body\_plain|The plain text version of the body.|Clob|&#x25CF;|
|body\_html|The html version of the body.|Clob|&#x25CF;|
|subject|Subject of the outgoing message. Ignored if not needed|Clob|&#x25CF;|
|headers|Additional headers. Optional|Clob|&#x25CF;|
|body\_sms|The sms version of the body.|Clob|&#x25CF;|


![reply_template_body table relationship diagram](./media/reply_template_body.png)

[!include[details](./includes/reply-template-body.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|reply\_template\_id |FK |Index |
|language\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

