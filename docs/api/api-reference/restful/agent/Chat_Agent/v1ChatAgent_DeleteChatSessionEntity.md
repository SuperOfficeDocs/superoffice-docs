---
title: DeleteChatSessionEntity
id: v1ChatAgent_DeleteChatSessionEntity
---

# DeleteChatSessionEntity

```http
POST /api/v1/Agents/Chat/DeleteChatSessionEntity
```

Deletes the ChatSessionEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ChatSessionEntityId | int32 | **Required** The id of the ChatSessionEntity to be deleted. |

```http
POST /api/v1/Agents/Chat/DeleteChatSessionEntity?ChatSessionEntityId=587
```


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