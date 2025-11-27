---
title: DEL ShipmentMessageBlock/{id}
uid: v1ShipmentMessageBlockEntity_DeleteShipmentMessageBlockEntity
generated: true
content_type: reference
---

# DEL ShipmentMessageBlock/{id}

```http
DELETE /api/v1/ShipmentMessageBlock/{id}
```

Deletes the ShipmentMessageBlockEntity


Calls the Marketing agent service DeleteShipmentMessageBlockEntity.
NsApiSlow threshold: 5000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ShipmentMessageBlockEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

ShipmentMessageBlockEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | ShipmentMessageBlockEntity deleted. |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1ShipmentMessageBlockEntity_DeleteShipmentMessageBlockEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1ShipmentMessageBlockEntity_DeleteShipmentMessageBlockEntity.md)]