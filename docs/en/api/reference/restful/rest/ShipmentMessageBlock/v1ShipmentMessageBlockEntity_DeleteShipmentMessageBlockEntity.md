---
title: DEL ShipmentMessageBlock/{id}
uid: v1ShipmentMessageBlockEntity_DeleteShipmentMessageBlockEntity
generated: true
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
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

ShipmentMessageBlockEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | ShipmentMessageBlockEntity deleted. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/ShipmentMessageBlock/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 204 ShipmentMessageBlockEntity deleted.
Content-Type: application/json; charset=utf-8

null
```