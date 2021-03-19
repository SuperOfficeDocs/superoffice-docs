---
uid: shipmenttype
title: shipmenttype table
description: Shipment type list table. Classification of a mailing, allowing recipients to subscribe to lists
so.generated: true
keywords:
  - "database"
  - "shipmenttype"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ShipmentType Table (484)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ShipmentType\_id|Primary key|PK| |
|name|The list item|String(4000)| |
|tooltip|The tooltip for the list item|String(4000)|&#x25CF;|
|rank|Rank order|UShort|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ShipmentType table relationship diagram](media\ShipmentType.png)

[!include[details](./includes/ShipmentType.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ShipmentType\_id |PK |Clustered, Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

