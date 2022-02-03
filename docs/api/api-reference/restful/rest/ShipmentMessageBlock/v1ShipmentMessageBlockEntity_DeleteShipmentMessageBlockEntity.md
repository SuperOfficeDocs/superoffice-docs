---
title: DEL ShipmentMessageBlock/{id}
id: v1ShipmentMessageBlockEntity_DeleteShipmentMessageBlockEntity
---

# DEL ShipmentMessageBlock/{id}

```http
DELETE /api/v1/ShipmentMessageBlock/{id}
```

Deletes the ShipmentMessageBlockEntity

Calls the Marketing agent service DeleteShipmentMessageBlockEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ShipmentMessageBlockEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | ShipmentMessageBlockEntity deleted. |