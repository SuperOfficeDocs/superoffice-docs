---
title: POST ChatTopic/{id}/UserAgent
id: v1ChatTopicEntity_AddChatTopicUserAgent
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
| TopicId | int32 | The reference to the associated chat topic. |
| User |  | The associate that is the user agent. |
| CanListen | bool | True of a user can listen in on this topic |
| CanRespond | bool | True if the user can respond to chats in this topic |
| CanManage | bool | True if the user is a manager for this topic |
| CanNotify | bool | True if the user should receive notifications for this topic |


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
POST /api/v1/ChatTopic/{chatTopicId}/UserAgent
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TopicId": 446,
  "User": {
    "AssociateId": 24,
    "Name": "Cronin, Reinger and Wiegand",
    "PersonId": 60,
    "Rank": 993,
    "Tooltip": "beatae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 890,
    "FullName": "Garth Dibbert",
    "FormalName": "Larson, Homenick and Hartmann",
    "Deleted": true,
    "EjUserId": 521,
    "UserName": "Ebert-Davis"
  },
  "CanListen": true,
  "CanRespond": true,
  "CanManage": false,
  "CanNotify": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TopicId": 997,
  "User": {
    "AssociateId": 948,
    "Name": "Simonis-Nicolas",
    "PersonId": 550,
    "Rank": 939,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 654,
    "FullName": "Jocelyn Brekke",
    "FormalName": "Vandervort-Konopelski",
    "Deleted": true,
    "EjUserId": 615,
    "UserName": "Marvin LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 576
      }
    }
  },
  "CanListen": true,
  "CanRespond": true,
  "CanManage": true,
  "CanNotify": true
}
```