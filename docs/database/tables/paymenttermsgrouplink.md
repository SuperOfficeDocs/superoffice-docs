---
uid: table-paymenttermsgrouplink
title: paymenttermsgrouplink table
description: User group link table for PaymentTerms, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "PaymentTermsGroupLink"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# paymenttermsgrouplink Table (428)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|paymenttermsgrouplink\_id|Primary key|PK| |
|paymentterms\_id|Link to PaymentTerms list table|FK [paymentterms](paymentterms.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PaymentTermsGroupLink table relationship diagram](./media/PaymentTermsGroupLink.png)

[!include[details](./includes/PaymentTermsGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|paymenttermsgrouplink\_id |PK |Clustered, Unique |
|paymentterms\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

