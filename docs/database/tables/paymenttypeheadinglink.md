---
uid: table-PaymentTypeHeadingLink
title: PaymentTypeHeadingLink table
description: Heading link table for PaymentType, for MDO item headings
so.generated: true
keywords:
  - "database"
  - "PaymentTypeHeadingLink"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# PaymentTypeHeadingLink Table (432)

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

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

