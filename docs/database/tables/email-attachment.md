---
uid: table-email-attachment
title: email\_attachment table
description: Attachment info related to an email_item
so.generated: true
keywords:
  - "database"
  - "email_attachment"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# email\_attachment Table (478)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|email\_attachment\_id|Primary key|PK| |
|email\_item\_id|Id of the email_item|FK [email-item](email-item.md)|&#x25CF;|
|cid|The actual cid or the index of the mime part (an integer)|String(255)|&#x25CF;|
|description|Attachment description|String(255)|&#x25CF;|
|filename|Filename of attachment|String(255)|&#x25CF;|
|disposition|Attachment disposition|String(255)|&#x25CF;|
|type|Attachment type|String(255)|&#x25CF;|
|encoding|The attachment encoding|String(255)|&#x25CF;|
|size|Attachment file size|Int|&#x25CF;|


![email_attachment table relationship diagram](./media/email_attachment.png)

[!include[details](./includes/email-attachment.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|email\_attachment\_id |PK |Clustered, Unique |
|email\_item\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

