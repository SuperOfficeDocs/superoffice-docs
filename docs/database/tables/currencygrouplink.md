---
uid: table-currencygrouplink
title: currencygrouplink table
description: User group link table for Currency, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "CurrencyGroupLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# currencygrouplink Table (113)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|currencygrouplink\_id|Primary key|PK| |
|currency\_id|Link to Currency list table|FK [currency](currency.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![CurrencyGroupLink table relationship diagram](./media/CurrencyGroupLink.png)

[!include[details](./includes/CurrencyGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|currencygrouplink\_id |PK |Clustered, Unique |
|currency\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

