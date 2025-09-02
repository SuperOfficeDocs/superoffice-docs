---
title: DEL DashTile/{id}
uid: v1DashTile_DeleteDashTile
generated: true
content_type: reference
---

# DEL DashTile/{id}

```http
DELETE /api/v1/DashTile/{id}
```

Deletes the DashTile


Calls the Dash agent service DeleteDashTile.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DashTile to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

DashTile deleted.

| Response | Description |
|----------------|-------------|
| 204 | DashTile deleted. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/DashTile/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 DashTile deleted.
Content-Type: application/json; charset=utf-8

null
```