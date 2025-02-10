---
title: DEL DashboardTile/{id}
uid: v1DashboardTile_DeleteDashboardTile
generated: true
---

# DEL DashboardTile/{id}

```http
DELETE /api/v1/DashboardTile/{id}
```

Deletes the DashboardTile


Calls the Dashboard agent service DeleteDashboardTile.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DashboardTile to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

DashboardTile deleted.

| Response | Description |
|----------------|-------------|
| 204 | DashboardTile deleted. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/DashboardTile/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 204 DashboardTile deleted.
Content-Type: application/json; charset=utf-8

null
```