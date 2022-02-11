---
title: DEL ChatSession/{id}
id: v1ChatSessionEntity_DeleteChatSessionEntity
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
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | ChatSessionEntity deleted. |