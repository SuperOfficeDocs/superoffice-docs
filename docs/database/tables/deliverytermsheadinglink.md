---
uid: table-deliverytermsheadinglink
title: deliverytermsheadinglink table
description: Heading link table for DeliveryTerms, for MDO item headings
so.generated: true
keywords:
  - "database"
  - "DeliveryTermsHeadingLink"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# deliverytermsheadinglink Table (435)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|deliverytermsheadinglink\_id|Primary key|PK| |
|deliveryterms\_id|Link to DeliveryTerms list table|FK [deliveryterms](deliveryterms.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![DeliveryTermsHeadingLink table relationship diagram](./media/DeliveryTermsHeadingLink.png)

[!include[details](./includes/DeliveryTermsHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|deliverytermsheadinglink\_id |PK |Clustered, Unique |
|deliveryterms\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

