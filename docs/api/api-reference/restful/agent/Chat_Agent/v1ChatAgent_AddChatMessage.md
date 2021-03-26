---
title: POST Agents/Chat/AddChatMessage
id: v1ChatAgent_AddChatMessage
---

# POST Agents/Chat/AddChatMessage

```http
POST /api/v1/Agents/Chat/AddChatMessage
```

Add a new message to a chat session







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Chat/AddChatMessage?$select=name,department,category/id
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

ChatSessionId, Message 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatSessionId | int32 |  |
| Message |  | A message in a chat session <para /> Carrier object for ChatMessage. Services for the ChatMessage Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IChatAgent">Chat Agent</see>. |


## Response: object

A message in a chat session



Carrier object for ChatMessage.
Services for the ChatMessage Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IChatAgent">Chat Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ChatMessageId | int32 | The primary key (auto-incremented) |
| ChatSessionId | int32 | The reference to the associated chat session. |
| Type | string | The type of the message. |
| Message | string | The message. |
| Author | string | The author of the message. |
| ReadByCustomer | int32 | Whether the message has been read by the customer or not. |
| SpecialType | string | Enum indicating if it is a special message, such as an URL redirection, etc. |
| SpecialParam | string | Special parameter for the special_type. |
| WhenPosted | date-time | When the message was posted (UTC timestamp). |

## Sample Request

```http!
POST /api/v1/Agents/Chat/AddChatMessage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ChatSessionId": 855,
  "Message": {
    "ChatMessageId": 882,
    "ChatSessionId": 728,
    "Type": "Invalid",
    "Message": "at",
    "Author": "veritatis",
    "ReadByCustomer": 852,
    "SpecialType": "Block",
    "SpecialParam": "inventore",
    "WhenPosted": "2001-12-21T16:48:29.0019242+01:00"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ChatMessageId": 880,
  "ChatSessionId": 183,
  "Type": "Invalid",
  "Message": "vel",
  "Author": "nesciunt",
  "ReadByCustomer": 126,
  "SpecialType": "Block",
  "SpecialParam": "architecto",
  "WhenPosted": "1999-09-12T16:48:29.0019242+02:00"
}
```