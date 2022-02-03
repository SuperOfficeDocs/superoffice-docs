---
title: POST Presence/SaveAll
id: v1ChatPresence_SaveChatPresence
---

# POST Presence/SaveAll

```http
POST /api/v1/Presence/SaveAll
```

Save the chat presence for specified users








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: chatPresence  

An array with ChatPresence objects. Only the UserId and Present information is used while saving 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserId | int32 | The id for the chat user |
| DisplayName | string | The display name of the chat user |
| OngoingChats | int32 | The number of ongoing chats this users has now |
| Present | bool | Indicates if the user has the chat presence turned on or off |
| ChatTopics | array | An array of ids with chat topics that this user is a member of |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |