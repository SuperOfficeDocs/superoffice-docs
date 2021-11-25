---
title: PUT ChatTopic/{id}/UserAgent/{username}
id: v1ChatTopicEntity_UpdateChatTopicUserAgent
---

# PUT ChatTopic/{id}/UserAgent/{username}

```http
PUT /api/v1/ChatTopic/{chatTopicId}/UserAgent/{username}
```

Update a user's role in a chat topic






| Path Part | Type | Description |
|-----------|------|-------------|
| chatTopicId | int32 | Id of the chat topic **Required** |
| username | string | Associate username or associate id to get. **Required** |



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

User's updated role within the chat topic. 

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
PUT /api/v1/ChatTopic/{chatTopicId}/UserAgent/{username}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TopicId": 942,
  "User": {
    "AssociateId": 492,
    "Name": "Mitchell, Toy and Monahan",
    "PersonId": 771,
    "Rank": 425,
    "Tooltip": "tenetur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 306,
    "FullName": "Zoila Hodkiewicz",
    "FormalName": "Lebsack, Lemke and Hyatt",
    "Deleted": true,
    "EjUserId": 603,
    "UserName": "Littel Inc and Sons"
  },
  "CanListen": true,
  "CanRespond": false,
  "CanManage": true,
  "CanNotify": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TopicId": 30,
  "User": {
    "AssociateId": 824,
    "Name": "Fahey Inc and Sons",
    "PersonId": 413,
    "Rank": 752,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 558,
    "FullName": "Tracy Bayer",
    "FormalName": "Heaney Group",
    "Deleted": false,
    "EjUserId": 589,
    "UserName": "Boyle Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 27
      }
    }
  },
  "CanListen": true,
  "CanRespond": false,
  "CanManage": true,
  "CanNotify": false
}
```