---
title: DEL ChatSession/{id}
uid: v1ChatSessionEntity_DeleteChatSessionEntity
---

# DEL ChatSession/{id}

```http
DELETE /api/v1/ChatSession/{id}
```

Deletes the ChatSessionEntity


Calls the Chat agent service DeleteChatSessionEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ChatSessionEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: 

ChatSessionEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | ChatSessionEntity deleted. |

Response body: 


## Sample request

```http!
DELETE /api/v1/ChatSession/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 204 ChatSessionEntity deleted.
Content-Type: application/json; charset=utf-8

null
```