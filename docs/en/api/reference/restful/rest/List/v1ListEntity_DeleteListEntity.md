---
title: DEL List/{id}
uid: v1ListEntity_DeleteListEntity
generated: true
---

# DEL List/{id}

```http
DELETE /api/v1/List/{id}
```

Deletes the ListEntity


Calls the List agent service DeleteListEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ListEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

ListEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | ListEntity deleted. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/List/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 204 ListEntity deleted.
Content-Type: application/json; charset=utf-8

null
```