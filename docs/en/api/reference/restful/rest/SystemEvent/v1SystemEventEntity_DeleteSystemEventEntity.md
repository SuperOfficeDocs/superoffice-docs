---
title: DEL SystemEvent/{id}
uid: v1SystemEventEntity_DeleteSystemEventEntity
generated: true
content_type: reference
---

# DEL SystemEvent/{id}

```http
DELETE /api/v1/SystemEvent/{id}
```

Deletes the SystemEventEntity


Calls the Configuration agent service DeleteSystemEventEntity.
NsApiSlow threshold: 5000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SystemEventEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

SystemEventEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | SystemEventEntity deleted. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/SystemEvent/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 204 SystemEventEntity deleted.
Content-Type: application/json; charset=utf-8

null
```