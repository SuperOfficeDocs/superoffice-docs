---
title: DEL Selection/{id}
uid: v1SelectionEntity_DeleteSelectionEntity
generated: true
---

# DEL Selection/{id}

```http
DELETE /api/v1/Selection/{id}
```

Deletes the SelectionEntity


Calls the Selection agent service DeleteSelectionEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SelectionEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

SelectionEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | SelectionEntity deleted. |
| 412 | Delete aborted because SelectionEntity has changed since the requested If-Unmodified-Since timestamp. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/Selection/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 204 SelectionEntity deleted.
Content-Type: application/json; charset=utf-8

null
```