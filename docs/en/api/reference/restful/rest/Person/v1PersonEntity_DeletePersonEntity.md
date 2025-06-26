---
title: DEL Person/{id}
uid: v1PersonEntity_DeletePersonEntity
generated: true
---

# DEL Person/{id}

```http
DELETE /api/v1/Person/{id}
```

Deletes the PersonEntity


Calls the Person agent service DeletePersonEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PersonEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

PersonEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | PersonEntity deleted. |
| 412 | Delete aborted because PersonEntity has changed since the requested If-Unmodified-Since timestamp. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 204 PersonEntity deleted.
Content-Type: application/json; charset=utf-8

null
```