---
title: DEL Dashboard/{id}
uid: v1Dashboard_DeleteDashboard
---

# DEL Dashboard/{id}

```http
DELETE /api/v1/Dashboard/{id}
```

Deletes the Dashboard


Calls the Dashboard agent service DeleteDashboard.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The Dashboard to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: 

Dashboard deleted.

| Response | Description |
|----------------|-------------|
| 204 | Dashboard deleted. |

Response body: 


## Sample request

```http!
DELETE /api/v1/Dashboard/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 204 Dashboard deleted.
Content-Type: application/json; charset=utf-8

null
```