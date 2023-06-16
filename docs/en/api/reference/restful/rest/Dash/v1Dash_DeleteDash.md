---
title: DEL Dash/{id}
uid: v1Dash_DeleteDash
generated: true
---

# DEL Dash/{id}

```http
DELETE /api/v1/Dash/{id}
```

Deletes the Dash


Calls the Dash agent service DeleteDash.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The Dash to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

Dash deleted.

| Response | Description |
|----------------|-------------|
| 204 | Dash deleted. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/Dash/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 Dash deleted.
Content-Type: application/json; charset=utf-8

null
```