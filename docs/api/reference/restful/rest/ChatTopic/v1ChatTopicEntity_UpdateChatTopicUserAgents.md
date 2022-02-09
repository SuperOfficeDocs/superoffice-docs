---
title: PUT ChatTopic/{id}/UserAgent
id: v1ChatTopicEntity_UpdateChatTopicUserAgents
---

# PUT ChatTopic/{id}/UserAgent

```http
PUT /api/v1/ChatTopic/{chatTopicId}/UserAgent
```

Update users roles in a chat topic






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

## Request Body: useragents  

Users new/updated roles within the chat topic. Replaces existing roles 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TopicId | int32 | The reference to the associated chat topic. |
| User |  | The associate that is the user agent. |
| CanListen | bool | True of a user can listen in on this topic |
| CanRespond | bool | True if the user can respond to chats in this topic |
| CanManage | bool | True if the user is a manager for this topic |
| CanNotify | bool | True if the user should receive notifications for this topic |


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
PUT /api/v1/ChatTopic/{chatTopicId}/UserAgent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "TopicId": 151,
    "User": {
      "AssociateId": 629,
      "Name": "Witting, Klocko and Larkin",
      "PersonId": 580,
      "Rank": 951,
      "Tooltip": "molestiae",
      "Type": "AnonymousAssociate",
      "GroupIdx": 271,
      "FullName": "Domingo Kerluke",
      "FormalName": "Collins, Nicolas and Parker",
      "Deleted": false,
      "EjUserId": 500,
      "UserName": "Lowe LLC"
    },
    "CanListen": true,
    "CanRespond": false,
    "CanManage": false,
    "CanNotify": false
  },
  {
    "TopicId": 151,
    "User": {
      "AssociateId": 629,
      "Name": "Witting, Klocko and Larkin",
      "PersonId": 580,
      "Rank": 951,
      "Tooltip": "molestiae",
      "Type": "AnonymousAssociate",
      "GroupIdx": 271,
      "FullName": "Domingo Kerluke",
      "FormalName": "Collins, Nicolas and Parker",
      "Deleted": false,
      "EjUserId": 500,
      "UserName": "Lowe LLC"
    },
    "CanListen": true,
    "CanRespond": false,
    "CanManage": false,
    "CanNotify": false
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "TopicId": 969,
    "User": {
      "AssociateId": 869,
      "Name": "Rolfson, Gerhold and Fadel",
      "PersonId": 211,
      "Rank": 198,
      "Tooltip": "ab",
      "Type": "AnonymousAssociate",
      "GroupIdx": 710,
      "FullName": "Dr. Vickie Torp",
      "FormalName": "Swaniawski, Schmeler and Lindgren",
      "Deleted": false,
      "EjUserId": 808,
      "UserName": "Ward-Zulauf",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 683
        }
      }
    },
    "CanListen": true,
    "CanRespond": true,
    "CanManage": true,
    "CanNotify": true
  },
  {
    "TopicId": 969,
    "User": {
      "AssociateId": 869,
      "Name": "Rolfson, Gerhold and Fadel",
      "PersonId": 211,
      "Rank": 198,
      "Tooltip": "ab",
      "Type": "AnonymousAssociate",
      "GroupIdx": 710,
      "FullName": "Dr. Vickie Torp",
      "FormalName": "Swaniawski, Schmeler and Lindgren",
      "Deleted": false,
      "EjUserId": 808,
      "UserName": "Ward-Zulauf",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 683
        }
      }
    },
    "CanListen": true,
    "CanRespond": true,
    "CanManage": true,
    "CanNotify": true
  }
]
```