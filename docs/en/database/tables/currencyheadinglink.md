---
uid: table-CurrencyHeadingLink
title: CurrencyHeadingLink table
description: Heading link table for Currency, for MDO headers
so.generated: true
keywords: database table CurrencyHeadingLink
so.topic: reference
so.envir: onsite, online
---

# CurrencyHeadingLink Table (114)

Heading link table for Currency, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|currencyheadinglink\_id|Primary key|PK| |
|currency\_id|Link to Currency list table|FK [Currency](currency.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![CurrencyHeadingLink table relationship diagram](./media/CurrencyHeadingLink.png)

[!include[details](./includes/currencyheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|currencyheadinglink\_id |PK |Clustered, Unique |
|currency\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Currency](currency.md)  |Currency list table |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

