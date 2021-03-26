---
title: DEL ChatTopic/{id}
id: v1ChatTopicEntity_DeleteChatTopicEntity
---

# DEL ChatTopic/{id}

```http
DELETE /api/v1/ChatTopic/{id}
```

Deletes the ChatTopicEntity

Calls the Chat agent service DeleteChatTopicEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ChatTopicEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | ChatTopicEntity deleted. |