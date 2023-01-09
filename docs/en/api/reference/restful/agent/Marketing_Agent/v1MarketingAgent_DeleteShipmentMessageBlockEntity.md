---
title: POST Agents/Marketing/DeleteShipmentMessageBlockEntity
uid: v1MarketingAgent_DeleteShipmentMessageBlockEntity
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
POST /api/v1/Agents/Marketing/DeleteShipmentMessageBlockEntity?ShipmentMessageBlockEntityId=1000
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TableRight


## Sample request

```http!
POST /api/v1/Agents/Marketing/DeleteShipmentMessageBlockEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```