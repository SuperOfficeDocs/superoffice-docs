---
title: POST Agents/Chat/AddChatTopicUserAgent
uid: v1ChatAgent_AddChatTopicUserAgent
---

# POST Agents/Chat/AddChatTopicUserAgent

```http
POST /api/v1/Agents/Chat/AddChatTopicUserAgent
```

Add a user to a chat topic







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/AddChatTopicUserAgent?$select=name,department,category/id
```


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

## Request Body: request 

ChatTopicId, Useragent 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatTopicId | Integer |  |
| Useragent | ChatTopicAgent | User agents within a chat topic. Which users are assigned and what roles they have within the chat topic. <para /> Carrier object for ChatTopicAgent. Services for the ChatTopicAgent Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IChatAgent">Chat Agent</see>. |

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
POST /api/v1/Agents/Chat/AddChatTopicUserAgent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 731,
  "Useragent": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TopicId": 251,
  "User": null,
  "CanListen": false,
  "CanRespond": false,
  "CanManage": true,
  "CanNotify": true
}
```