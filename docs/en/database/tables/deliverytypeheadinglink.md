---
uid: table-DeliveryTypeHeadingLink
title: DeliveryTypeHeadingLink table
description: Heading link table for DeliveryType, for MDO item headings
so.generated: true
keywords: database table DeliveryTypeHeadingLink
so.topic: reference
so.envir: onsite, online
---

# DeliveryTypeHeadingLink Table (438)

Heading link table for DeliveryType, for MDO item headings

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|deliverytypeheadinglink\_id|Primary key|PK| |
|deliverytype\_id|Link to DeliveryType list table|FK [DeliveryType](deliverytype.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![DeliveryTypeHeadingLink table relationship diagram](./media/DeliveryTypeHeadingLink.png)

[!include[details](./includes/deliverytypeheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|deliverytypeheadinglink\_id |PK |Clustered, Unique |
|deliverytype\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[DeliveryType](deliverytype.md)  |The list of Delivery types, in the internal product register |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

