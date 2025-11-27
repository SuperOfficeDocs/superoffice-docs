---
title: DEL ChatSession/{id}
uid: v1ChatSessionEntity_DeleteChatSessionEntity
generated: true
content_type: reference
---

# DEL ChatSession/{id}

```http
DELETE /api/v1/ChatSession/{id}
```

Deletes the ChatSessionEntity


Calls the Chat agent service DeleteChatSessionEntity.
NsApiSlow threshold: 5000 ms.





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

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1ChatSessionEntity_DeleteChatSessionEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1ChatSessionEntity_DeleteChatSessionEntity.md)]