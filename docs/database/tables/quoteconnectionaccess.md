---
uid: quoteconnectionaccess
title: quoteconnectionaccess table
description: Access control for Quote Connections
so.generated: true
keywords:
  - "database"
  - "quoteconnectionaccess"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# QuoteConnectionAccess Table (27)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|quoteconnectionaccess\_id|Primary key|PK| |
|QuoteConnectionId|Link to quote connection we&apos;re granting access for|FK [QuoteConnection](QuoteConnection.md)| |
|AssociateId|If set, then this row grants access for a particular associate|FK [associate](associate.md)|&#x25CF;|
|UserGroupId|If set, then this row grants access for a particular group of users|FK [UserGroup](UserGroup.md)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![QuoteConnectionAccess table relationship diagram](media\QuoteConnectionAccess.png)

[!include[details](./includes/QuoteConnectionAccess.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|quoteconnectionaccess\_id |PK |Clustered, Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

