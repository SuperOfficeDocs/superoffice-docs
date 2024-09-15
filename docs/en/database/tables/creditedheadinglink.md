---
uid: table-CreditedHeadingLink
title: CreditedHeadingLink table
description: Heading link table for Credited, for MDO headers
so.generated: true
keywords: database table CreditedHeadingLink
so.topic: reference
so.envir: onsite, online
---

# CreditedHeadingLink Table (99)

Heading link table for Credited, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|creditedheadinglink\_id|Primary key|PK| |
|credited\_id|Link to Credited list table|FK [Credited](credited.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![CreditedHeadingLink table relationship diagram](./media/CreditedHeadingLink.png)

[!include[details](./includes/creditedheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|creditedheadinglink\_id |PK |Clustered, Unique |
|credited\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Credited](credited.md)  |Credited list table. List of who is to be credited for the sale. |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

