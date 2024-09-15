---
uid: table-SubscriptionUnit
title: SubscriptionUnit table
description: The list of Subscription units, in the internal product register (year/quarter/month etc., or perhaps amounts if volume-based subscription)
so.generated: true
keywords: database table SubscriptionUnit
so.topic: reference
so.envir: onsite, online
---

# SubscriptionUnit Table (442)

SubscriptionUnit MDO list item table.
The list of Subscription units, in the internal product register (year/quarter/month etc., or perhaps amounts if volume-based subscription)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|subscriptionunit\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SubscriptionUnit table relationship diagram](./media/SubscriptionUnit.png)

[!include[details](./includes/subscriptionunit.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|subscriptionunit\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[SubscriptionUnitGroupLink](subscriptionunitgrouplink.md)  |User group link table for SubscriptionUnit, for MDO item hiding |
|[SubscriptionUnitHeadingLink](subscriptionunitheadinglink.md)  |Heading link table for SubscriptionUnit, for MDO item headings |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

