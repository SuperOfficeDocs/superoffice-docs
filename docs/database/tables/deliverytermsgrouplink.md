---
uid: table-DeliveryTermsGroupLink
title: DeliveryTermsGroupLink table
description: User group link table for DeliveryTerms, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "DeliveryTermsGroupLink"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# DeliveryTermsGroupLink Table (434)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|deliverytermsgrouplink\_id|Primary key|PK| |
|deliveryterms\_id|Link to DeliveryTerms list table|FK [DeliveryTerms](deliveryterms.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![DeliveryTermsGroupLink table relationship diagram](./media/DeliveryTermsGroupLink.png)

[!include[details](./includes/deliverytermsgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|deliverytermsgrouplink\_id |PK |Clustered, Unique |
|deliveryterms\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

