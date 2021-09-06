---
uid: table-paymenttermsheadinglink
title: paymenttermsheadinglink table
description: Heading link table for PaymentTerms, for MDO item headings
so.generated: true
keywords:
  - "database"
  - "PaymentTermsHeadingLink"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# paymenttermsheadinglink Table (429)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|paymenttermsheadinglink\_id|Primary key|PK| |
|paymentterms\_id|Link to PaymentTerms list table|FK [paymentterms](paymentterms.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PaymentTermsHeadingLink table relationship diagram](./media/PaymentTermsHeadingLink.png)

[!include[details](./includes/PaymentTermsHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|paymenttermsheadinglink\_id |PK |Clustered, Unique |
|paymentterms\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

