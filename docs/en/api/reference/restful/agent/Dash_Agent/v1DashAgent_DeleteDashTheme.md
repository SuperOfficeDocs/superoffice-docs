---
title: POST Agents/Dash/DeleteDashTheme
uid: v1DashAgent_DeleteDashTheme
generated: true
---

# POST Agents/Dash/DeleteDashTheme

```http
POST /api/v1/Agents/Dash/DeleteDashTheme
```

Deletes the DashTheme







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| DashThemeId | int32 | **Required** The id of the DashTheme to be deleted. |

```http
POST /api/v1/Agents/Dash/DeleteDashTheme?DashThemeId=449
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
POST /api/v1/Agents/Dash/DeleteDashTheme
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