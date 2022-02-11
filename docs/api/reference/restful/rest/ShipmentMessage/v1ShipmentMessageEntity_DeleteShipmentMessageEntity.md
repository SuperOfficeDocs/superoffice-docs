---
title: DEL ShipmentMessage/{id}
id: v1ShipmentMessageEntity_DeleteShipmentMessageEntity
---

# DEL ShipmentMessage/{id}

```http
DELETE /api/v1/ShipmentMessage/{id}
```

Deletes the ShipmentMessageEntity

Calls the Marketing agent service DeleteShipmentMessageEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ShipmentMessageEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | ShipmentMessageEntity deleted. |