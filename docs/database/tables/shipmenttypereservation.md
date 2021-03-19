---
uid: shipmenttypereservation
title: shipmenttypereservation table
description: ShipmentTypes a person has reserved against. Note that the absense of a record here implies acceptance of a mailings of this type
so.generated: true
keywords:
  - "database"
  - "shipmenttypereservation"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ShipmentTypeReservation Table (485)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ShipmentTypeReservation\_id|Primary key|PK| |
|person\_id|Owning person|FK [person](person.md)| |
|ShipmentType\_id|Shipment type to reserve against|FK [ShipmentType](ShipmentType.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ShipmentTypeReservation table relationship diagram](media\ShipmentTypeReservation.png)

[!include[details](./includes/ShipmentTypeReservation.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ShipmentTypeReservation\_id |PK |Clustered, Unique |
|person\_id |FK |Index |
|ShipmentType\_id, person\_id |FK, FK |Index |

## Replication Flags

* Area Management controlled table. Contents replicated to satellites and traveller databases.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

