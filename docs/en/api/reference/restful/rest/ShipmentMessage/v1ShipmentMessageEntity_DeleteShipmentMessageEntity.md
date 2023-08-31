---
title: DEL ShipmentMessage/{id}
uid: v1ShipmentMessageEntity_DeleteShipmentMessageEntity
generated: true
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
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

ShipmentMessageEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | ShipmentMessageEntity deleted. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/ShipmentMessage/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 ShipmentMessageEntity deleted.
Content-Type: application/json; charset=utf-8

null
```