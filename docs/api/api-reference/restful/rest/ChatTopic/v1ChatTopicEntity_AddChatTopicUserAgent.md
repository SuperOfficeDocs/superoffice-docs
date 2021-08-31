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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TopicId": 371,
  "User": {
    "AssociateId": 574,
    "Name": "Renner Group",
    "PersonId": 32,
    "Rank": 253,
    "Tooltip": "ducimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 690,
    "FullName": "Palma Veum",
    "FormalName": "Rodriguez, Konopelski and Ratke",
    "Deleted": true,
    "EjUserId": 761,
    "UserName": "Bayer-Schumm"
  },
  "CanListen": true,
  "CanRespond": false,
  "CanManage": false,
  "CanNotify": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TopicId": 45,
  "User": {
    "AssociateId": 981,
    "Name": "Lang-Veum",
    "PersonId": 448,
    "Rank": 985,
    "Tooltip": "facere",
    "Type": "AnonymousAssociate",
    "GroupIdx": 978,
    "FullName": "Justina Emmerich",
    "FormalName": "Feeney Inc and Sons",
    "Deleted": false,
    "EjUserId": 407,
    "UserName": "Nader, McKenzie and Carter",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 77
      }
    }
  },
  "CanListen": true,
  "CanRespond": true,
  "CanManage": true,
  "CanNotify": true
}
```