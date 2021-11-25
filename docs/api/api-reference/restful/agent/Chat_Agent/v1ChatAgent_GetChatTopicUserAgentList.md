---
title: POST Agents/Chat/GetChatTopicUserAgentList
id: v1ChatAgent_GetChatTopicUserAgentList
---

# POST Agents/Chat/GetChatTopicUserAgentList

```http
POST /api/v1/Agents/Chat/GetChatTopicUserAgentList
```

Get list of users assigned to a chat topic







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/GetChatTopicUserAgentList?$select=name,department,category/id
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

ChatTopicId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatTopicId | int32 |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
POST /api/v1/Agents/Chat/GetChatTopicUserAgentList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 790
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "TopicId": 46,
    "User": {
      "AssociateId": 618,
      "Name": "McCullough, Gibson and Terry",
      "PersonId": 982,
      "Rank": 721,
      "Tooltip": "fugit",
      "Type": "AnonymousAssociate",
      "GroupIdx": 823,
      "FullName": "Noelia Moore",
      "FormalName": "Kreiger, Fahey and Rosenbaum",
      "Deleted": false,
      "EjUserId": 568,
      "UserName": "Jerde Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 95
        }
      }
    },
    "CanListen": true,
    "CanRespond": true,
    "CanManage": false,
    "CanNotify": false
  },
  {
    "TopicId": 46,
    "User": {
      "AssociateId": 618,
      "Name": "McCullough, Gibson and Terry",
      "PersonId": 982,
      "Rank": 721,
      "Tooltip": "fugit",
      "Type": "AnonymousAssociate",
      "GroupIdx": 823,
      "FullName": "Noelia Moore",
      "FormalName": "Kreiger, Fahey and Rosenbaum",
      "Deleted": false,
      "EjUserId": 568,
      "UserName": "Jerde Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 95
        }
      }
    },
    "CanListen": true,
    "CanRespond": true,
    "CanManage": false,
    "CanNotify": false
  }
]
```