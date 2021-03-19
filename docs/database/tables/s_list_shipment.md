---
uid: s_list_shipment
title: s_list_shipment table
description: A connector between shipment and list so that one shipment can have many lists, and one list can have many shipments
so.generated: true
keywords:
  - "database"
  - "s_list_shipment"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# SListShipment Table (348)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|list\_id|Reference to the list|FK [s_list](s_list.md)| |
|shipment\_id|Reference to the shipment|FK [s_shipment](s_shipment.md)| |
|type|Indicates if this is a static/dynamic spmlist or a selection|Int|&#x25CF;|
|status|Status of shipment list|Enum [ShipmentListStatus](enums\EnumShipmentListStatus.md)|&#x25CF;|


![s_list_shipment table relationship diagram](media\s_list_shipment.png)

[!include[details](./includes/s-list-shipment.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|list\_id |FK |Index |
|shipment\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

