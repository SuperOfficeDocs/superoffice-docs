---
title: DEL DashTileDefinition/{id}
uid: v1DashTileDefinition_DeleteDashTileDefinition
generated: true
---

# DEL DashTileDefinition/{id}

```http
DELETE /api/v1/DashTileDefinition/{id}
```

Deletes the DashTileDefinition


Calls the Dash agent service DeleteDashTileDefinition.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DashTileDefinition to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

DashTileDefinition deleted.

| Response | Description |
|----------------|-------------|
| 204 | DashTileDefinition deleted. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/DashTileDefinition/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 204 DashTileDefinition deleted.
Content-Type: application/json; charset=utf-8

null
```