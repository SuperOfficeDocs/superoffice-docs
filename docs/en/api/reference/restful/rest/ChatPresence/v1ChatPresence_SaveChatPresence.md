---
title: POST Presence/SaveAll
uid: v1ChatPresence_SaveChatPresence
generated: true
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
| UserId | Integer | The id for the chat user |
| DisplayName | String | The display name of the chat user |
| OngoingChats | Integer | The number of ongoing chats this users has now |
| Present | Boolean | Indicates if the user has the chat presence turned on or off |
| ChatTopics | Array | An array of ids with chat topics that this user is a member of |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Presence/SaveAll
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "UserId": 814,
    "DisplayName": "Beatty, Gibson and McClure",
    "OngoingChats": 924,
    "Present": false,
    "ChatTopics": [
      763,
      81
    ]
  },
  {
    "UserId": 814,
    "DisplayName": "Beatty, Gibson and McClure",
    "OngoingChats": 924,
    "Present": false,
    "ChatTopics": [
      763,
      81
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