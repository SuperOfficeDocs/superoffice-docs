---
title: POST Agents/Marketing/DeleteShipmentMessageBlockEntity
id: v1MarketingAgent_DeleteShipmentMessageBlockEntity
---

# POST Agents/Marketing/DeleteShipmentMessageBlockEntity

```http
POST /api/v1/Agents/Marketing/DeleteShipmentMessageBlockEntity
```

Deletes the ShipmentMessageBlockEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ShipmentMessageBlockEntityId | int32 | **Required** The id of the ShipmentMessageBlockEntity to be deleted. |

```http
POST /api/v1/Agents/Marketing/DeleteShipmentMessageBlockEntity?ShipmentMessageBlockEntityId=893
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |