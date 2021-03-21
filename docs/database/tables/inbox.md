---
uid: table-inbox
title: inbox table
description: Info and status for safe email import
so.generated: true
keywords:
  - "database"
  - "inbox"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# inbox Table (352)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|mail\_in\_filter|A reference to the id of the mail box|FK [mail-in-filter](mail-in-filter.md)| |
|locking\_id|A reference to the id of lock|FK [locking](locking.md)| |
|uidl|The uidl of the message. stored before the retrieval starts to prevent double import For locking purposes|String(255)|&#x25CF;|
|created|When the mail was created|DateTime|&#x25CF;|
|imported|When the mail was imported|DateTime| |
|status|Status enum|Int| |
|mail\_size|The size of the mail in bytes|Int| |
|next\_retry|When is the next time we should try again?|DateTime|&#x25CF;|
|plugin|Name of plugin that created this inbox entry|String(255)| |
|format|Format of the inbox entry|String(255)| |


![inbox table relationship diagram](./media/inbox.png)

[!include[details](./includes/inbox.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|mail\_in\_filter |FK |Index |
|locking\_id |FK |Index |
|imported |DateTime |Index |
|status |Int |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

