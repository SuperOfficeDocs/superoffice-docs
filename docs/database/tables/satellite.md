---
uid: table-satellite
title: satellite table
description: Definition of Satellites
so.generated: true
keywords:
  - "database"
  - "satellite"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# satellite Table (42)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|satellite\_id|Primary key|PK| |
|area\_id|Area this satellite is based on (mandatory != 0)|FK [area](area.md)| |
|contact\_id|Contact card that owns this satellite|FK [contact](contact.md)| |
|encryptedComm|Use encryption for this Satellite?|UShort|&#x25CF;|
|DSN|Data source name last used for this satellite|String(254)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![satellite table relationship diagram](./media/satellite.png)

[!include[details](./includes/satellite.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|satellite\_id |PK |Clustered, Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Copy to satellite and travel prototypes.

## Security Flags

* Sentry controls access to items in this table using user's Role and data rights matrix.

