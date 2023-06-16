---
uid: table-SubscriptionUnitHeadingLink
title: SubscriptionUnitHeadingLink table
description: Heading link table for SubscriptionUnit, for MDO item headings
so.generated: true
keywords: database table SubscriptionUnitHeadingLink
so.topic: reference
so.envir: onsite, online
---

# SubscriptionUnitHeadingLink Table (444)

Heading link table for SubscriptionUnit, for MDO item headings

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

[!include[details](./includes/subscriptionunitheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|subscriptionunitheadinglink\_id |PK |Clustered, Unique |
|subscriptionunit\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[SubscriptionUnit](subscriptionunit.md)  |The list of Subscription units, in the internal product register (year/quarter/month etc., or perhaps amounts if volume-based subscription) |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

