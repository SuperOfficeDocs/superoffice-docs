---
title: DEL Contact/{id}
uid: v1ContactEntity_DeleteContactEntity
generated: true
---

# DEL Contact/{id}

```http
DELETE /api/v1/Contact/{id}
```

Deletes the ContactEntity


Calls the Contact agent service DeleteContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

ContactEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | ContactEntity deleted. |
| 412 | Delete aborted because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 204 ContactEntity deleted.
Content-Type: application/json; charset=utf-8

null
```