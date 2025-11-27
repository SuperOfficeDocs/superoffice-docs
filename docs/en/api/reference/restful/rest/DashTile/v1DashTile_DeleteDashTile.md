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
NsApiSlow threshold: 5000 ms.





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

[!include[sample request](../../samples/rest/request/v1DashTile_DeleteDashTile.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1DashTile_DeleteDashTile.md)]