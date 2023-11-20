---
title: POST Agents/Dashboard/DeleteDashboardTile
uid: v1DashboardAgent_DeleteDashboardTile
generated: true
---

# POST Agents/Dashboard/DeleteDashboardTile

```http
POST /api/v1/Agents/Dashboard/DeleteDashboardTile
```

Deletes the DashboardTile







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | int32 | **Required** The id of the DashboardTile to be deleted. |

```http
POST /api/v1/Agents/Dashboard/DeleteDashboardTile?DashboardTileId=13
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

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Dashboard/DeleteDashboardTile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```