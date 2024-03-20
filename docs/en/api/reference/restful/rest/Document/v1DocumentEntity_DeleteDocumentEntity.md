---
title: DEL Document/{id}
uid: v1DocumentEntity_DeleteDocumentEntity
generated: true
---

# DEL Document/{id}

```http
DELETE /api/v1/Document/{id}
```

Deletes the DocumentEntity


Calls the Document agent service DeleteDocumentEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DocumentEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

DocumentEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | DocumentEntity deleted. |
| 412 | Delete aborted because DocumentEntity has changed since the requested If-Unmodified-Since timestamp. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/Document/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 204 DocumentEntity deleted.
Content-Type: application/json; charset=utf-8

null
```