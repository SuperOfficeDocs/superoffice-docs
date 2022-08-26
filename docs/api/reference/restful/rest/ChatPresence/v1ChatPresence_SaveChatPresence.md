---
title: POST Presence/SaveAll
uid: v1ChatPresence_SaveChatPresence
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
| Accept         | Content-type(s) you would like the response in:  |
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


## Response: 

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

Response body: 


## Sample request

```http!
POST /api/v1/Presence/SaveAll
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "UserId": 640,
    "DisplayName": "Schulist-Wilkinson",
    "OngoingChats": 970,
    "Present": false,
    "ChatTopics": [
      605,
      418
    ]
  },
  {
    "UserId": 640,
    "DisplayName": "Schulist-Wilkinson",
    "OngoingChats": 970,
    "Present": false,
    "ChatTopics": [
      605,
      418
    ]
  }
]
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```