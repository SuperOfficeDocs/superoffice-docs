---
title: GET ChatTopic/{id}/UserAgent
id: v1ChatTopicEntity_GetChatTopicUserAgentList
---

# GET ChatTopic/{id}/UserAgent

```http
GET /api/v1/ChatTopic/{chatTopicId}/UserAgent
```

Get list of users assigned to a chat topic






| Path Part | Type | Description |
|-----------|------|-------------|
| chatTopicId | int32 | Id of the chat topic **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/ChatTopic/{chatTopicId}/UserAgent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "TopicId": 208,
    "User": {
      "AssociateId": 339,
      "Name": "Marks LLC",
      "PersonId": 572,
      "Rank": 642,
      "Tooltip": "qui",
      "Type": "AnonymousAssociate",
      "GroupIdx": 385,
      "FullName": "Alycia Kulas",
      "FormalName": "Nienow LLC",
      "Deleted": false,
      "EjUserId": 994,
      "UserName": "Goodwin-Mann",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "whiteboard clicks-and-mortar solutions"
          },
          "FieldType": "System.String",
          "FieldLength": 585
        }
      }
    },
    "CanListen": true,
    "CanRespond": false,
    "CanManage": true,
    "CanNotify": true
  },
  {
    "TopicId": 208,
    "User": {
      "AssociateId": 339,
      "Name": "Marks LLC",
      "PersonId": 572,
      "Rank": 642,
      "Tooltip": "qui",
      "Type": "AnonymousAssociate",
      "GroupIdx": 385,
      "FullName": "Alycia Kulas",
      "FormalName": "Nienow LLC",
      "Deleted": false,
      "EjUserId": 994,
      "UserName": "Goodwin-Mann",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "whiteboard clicks-and-mortar solutions"
          },
          "FieldType": "System.String",
          "FieldLength": 585
        }
      }
    },
    "CanListen": true,
    "CanRespond": false,
    "CanManage": true,
    "CanNotify": true
  }
]
```