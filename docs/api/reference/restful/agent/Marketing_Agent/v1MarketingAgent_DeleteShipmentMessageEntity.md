---
title: POST Agents/Marketing/DeleteShipmentMessageEntity
id: v1MarketingAgent_DeleteShipmentMessageEntity
---

# POST Agents/Marketing/DeleteShipmentMessageEntity

```http
POST /api/v1/Agents/Marketing/DeleteShipmentMessageEntity
```

Deletes the ShipmentMessageEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ShipmentMessageEntityId | int32 | **Required** The id of the ShipmentMessageEntity to be deleted. |

```http
POST /api/v1/Agents/Marketing/DeleteShipmentMessageEntity?ShipmentMessageEntityId=15
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