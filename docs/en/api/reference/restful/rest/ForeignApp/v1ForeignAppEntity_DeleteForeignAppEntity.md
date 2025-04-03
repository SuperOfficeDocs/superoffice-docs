---
title: DEL ForeignApp/{id}
uid: v1ForeignAppEntity_DeleteForeignAppEntity
generated: true
---

# DEL ForeignApp/{id}

```http
DELETE /api/v1/ForeignApp/{id}
```

Deletes the ForeignAppEntity


Calls the ForeignSystem agent service DeleteForeignAppEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ForeignAppEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

ForeignAppEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | ForeignAppEntity deleted. |
| 412 | Delete aborted because ForeignAppEntity has changed since the requested If-Unmodified-Since timestamp. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/ForeignApp/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 204 ForeignAppEntity deleted.
Content-Type: application/json; charset=utf-8

null
```