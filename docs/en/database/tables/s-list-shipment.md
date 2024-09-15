---
uid: table-s_list_shipment
title: s_list_shipment table
description: A connector between shipment and list so that one shipment can have many lists, and one list can have many shipments
so.generated: true
keywords: database table s_list_shipment
so.topic: reference
so.envir: onsite, online
---

# s\_list\_shipment Table (348)

A connector between shipment and list so that one shipment can have many lists, and one list can have many shipments

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|list\_id|Reference to the list|FK [s_list](s-list.md)| |
|shipment\_id|Reference to the shipment|FK [s_shipment](s-shipment.md)| |
|type|Indicates if this is a static/dynamic spmlist or a selection|Int|&#x25CF;|
|status|Status of shipment list|Enum [ShipmentListStatus](enums/shipmentliststatus.md)|&#x25CF;|


![s_list_shipment table relationship diagram](./media/s_list_shipment.png)

[!include[details](./includes/s-list-shipment.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|list\_id |FK |Index |
|shipment\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[s\_list](s-list.md)  |A list, dynamic or static |
|[s\_shipment](s-shipment.md)  |Contains info about one shipment. The addresses are stored in s_shipment_addr |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

