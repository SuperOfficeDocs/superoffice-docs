---
uid: table-SubscriptionUnitHeadingLink
title: SubscriptionUnitHeadingLink table
description: Heading link table for SubscriptionUnit, for MDO item headings
so.generated: true
keywords:
  - "database"
  - "SubscriptionUnitHeadingLink"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# SubscriptionUnitHeadingLink Table (444)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|subscriptionunitheadinglink\_id|Primary key|PK| |
|subscriptionunit\_id|Link to SubscriptionUnit list table|FK [SubscriptionUnit](subscriptionunit.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SubscriptionUnitHeadingLink table relationship diagram](./media/SubscriptionUnitHeadingLink.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|subscriptionunitheadinglink\_id |PK |Clustered, Unique |
|subscriptionunit\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

