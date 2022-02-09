---
title: DEL ChatTopic/{id}/UserAgent/{username}
id: v1ChatTopicEntity_DeleteChatTopicUserAgent
---

# DEL ChatTopic/{id}/UserAgent/{username}

```http
DELETE /api/v1/ChatTopic/{chatTopicId}/UserAgent/{username}
```

Remove a user from a topic






| Path Part | Type | Description |
|-----------|------|-------------|
| chatTopicId | int32 | Id of the chat topic **Required** |
| username | string | Associate username or associate id to delete. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |