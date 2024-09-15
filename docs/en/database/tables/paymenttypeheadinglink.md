---
uid: table-PaymentTypeHeadingLink
title: PaymentTypeHeadingLink table
description: Heading link table for PaymentType, for MDO item headings
so.generated: true
keywords: database table PaymentTypeHeadingLink
so.topic: reference
so.envir: onsite, online
---

# PaymentTypeHeadingLink Table (432)

Heading link table for PaymentType, for MDO item headings

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|paymenttypeheadinglink\_id|Primary key|PK| |
|paymenttype\_id|Link to PaymentType list table|FK [PaymentType](paymenttype.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PaymentTypeHeadingLink table relationship diagram](./media/PaymentTypeHeadingLink.png)

[!include[details](./includes/paymenttypeheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|paymenttypeheadinglink\_id |PK |Clustered, Unique |
|paymenttype\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[PaymentType](paymenttype.md)  |The list of payment types, in the internal product register |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

