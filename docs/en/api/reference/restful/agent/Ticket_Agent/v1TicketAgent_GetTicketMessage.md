---
title: POST Agents/Ticket/GetTicketMessage
uid: v1TicketAgent_GetTicketMessage
generated: true
content_type: reference
---

# POST Agents/Ticket/GetTicketMessage

```http
POST /api/v1/Agents/Ticket/GetTicketMessage
```

Gets a TicketMessage object.


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ticketMessageId | int32 | **Required** The identifier of the TicketMessage object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetTicketMessage?ticketMessageId=194
POST /api/v1/Agents/Ticket/GetTicketMessage?$select=name,department,category/id
```


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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TicketMessage

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketMessageId | int32 | The primary key (auto-incremented) |
| CreatedAt | date-time | When the message was posted. |
| Slevel | string | The securitylevel of the message. |
| Important | bool | If this message is important or not. |
| Author | string | A string representing the author of the message. Could be a user&amp;apos;s name, or a persons email address. |
| PersonId | int32 | Primary key |
| PersonFullName | string | Get the persons full name (internal name used in clients for employees). |
| ContactId | int32 | Primary key |
| ContactName | string | Contact name |
| ContactDepartment | string | Department |
| NumAttachments | int32 | Number of attachments in the message |
| EmailHeader | string | The email header is saved in this field as raw text |
| MessageHeaders | array | Contains the message headers, like To, Cc, Bcc information, or custom headers |
| Language | string | The language this message is in, based on some kind of analysis |
| Sentiment | int32 | Sentiment index, 100 = completely happy; -100 = suicidally unhappy; 0 = no idea |
| SentimentConfidence | int32 | Confidence of sentiment index, 0 = no idea, 100 = completely sure |
| CreatedBy | int32 | The id of the user who posted the message. The value 1 (system user) for externally posted messages. |
| ChangedAt | date-time | When the message was changed. |
| Badge | string | Badge to explicitly determine how a message was generated |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/agent/request/v1TicketAgent_GetTicketMessage.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1TicketAgent_GetTicketMessage.md)]