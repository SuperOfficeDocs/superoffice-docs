---
title: POST Agents/Chat/UpdateChatTopicUserAgent
id: v1ChatAgent_UpdateChatTopicUserAgent
---

# POST Agents/Chat/UpdateChatTopicUserAgent

```http
POST /api/v1/Agents/Chat/UpdateChatTopicUserAgent
```

Update a user's role in a chat topic







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/UpdateChatTopicUserAgent?$select=name,department,category/id
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

ChatTopicId, Username, Useragent 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatTopicId | int32 |  |
| Username | string |  |
| Useragent |  | User agents within a chat topic. Which users are assigned and what roles they have within the chat topic. <para /> Carrier object for ChatTopicAgent. Services for the ChatTopicAgent Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IChatAgent">Chat Agent</see>. |


## Response: object

User agents within a chat topic. Which users are assigned and what roles they have within the chat topic.



Carrier object for ChatTopicAgent.
Services for the ChatTopicAgent Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IChatAgent">Chat Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| TopicId | int32 | The reference to the associated chat topic. |
| User |  | The associate that is the user agent. |
| CanListen | bool | True of a user can listen in on this topic |
| CanRespond | bool | True if the user can respond to chats in this topic |
| CanManage | bool | True if the user is a manager for this topic |
| CanNotify | bool | True if the user should receive notifications for this topic |

## Sample Request

```http!
POST /api/v1/Agents/Chat/UpdateChatTopicUserAgent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 569,
  "Username": "earum",
  "Useragent": {
    "TopicId": 487,
    "User": {},
    "CanListen": false,
    "CanRespond": true,
    "CanManage": true,
    "CanNotify": true
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TopicId": 139,
  "User": {
    "AssociateId": 270,
    "Name": "Lebsack-Lynch",
    "PersonId": 22,
    "Rank": 333,
    "Tooltip": "aliquid",
    "Type": "AnonymousAssociate",
    "GroupIdx": 837,
    "FullName": "Ms. Art Dach",
    "FormalName": "Olson-Pfannerstill",
    "Deleted": false,
    "EjUserId": 216,
    "UserName": "Smitham LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 390
      }
    }
  },
  "CanListen": false,
  "CanRespond": false,
  "CanManage": true,
  "CanNotify": true
}
```