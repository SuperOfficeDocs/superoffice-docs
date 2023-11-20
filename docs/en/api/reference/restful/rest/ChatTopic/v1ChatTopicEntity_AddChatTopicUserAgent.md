---
title: POST ChatTopic/{id}/UserAgent
uid: v1ChatTopicEntity_AddChatTopicUserAgent
generated: true
---

# POST ChatTopic/{id}/UserAgent

```http
POST /api/v1/ChatTopic/{chatTopicId}/UserAgent
```

Add a user to a chat topic






| Path Part | Type | Description |
|-----------|------|-------------|
| chatTopicId | int32 | Id of the chat topic **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: useragent 

User's role within the chat topic to add to topic. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TopicId | Integer | The reference to the associated chat topic. |
| User | Associate | The associate that is the user agent. |
| CanListen | Boolean | True of a user can listen in on this topic |
| CanRespond | Boolean | True if the user can respond to chats in this topic |
| CanManage | Boolean | True if the user is a manager for this topic |
| CanNotify | Boolean | True if the user should receive notifications for this topic |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ChatTopicAgent

| Property Name | Type |  Description |
|----------------|------|--------------|
| TopicId | int32 | The reference to the associated chat topic. |
| User | Associate | The associate that is the user agent. |
| CanListen | bool | True of a user can listen in on this topic |
| CanRespond | bool | True if the user can respond to chats in this topic |
| CanManage | bool | True if the user is a manager for this topic |
| CanNotify | bool | True if the user should receive notifications for this topic |

## Sample request

```http!
POST /api/v1/ChatTopic/{chatTopicId}/UserAgent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TopicId": 574,
  "User": null,
  "CanListen": false,
  "CanRespond": false,
  "CanManage": false,
  "CanNotify": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TopicId": 847,
  "User": null,
  "CanListen": false,
  "CanRespond": true,
  "CanManage": false,
  "CanNotify": true
}
```