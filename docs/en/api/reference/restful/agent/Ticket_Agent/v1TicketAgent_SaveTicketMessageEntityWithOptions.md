---
title: POST Agents/Ticket/SaveTicketMessageEntityWithOptions
uid: v1TicketAgent_SaveTicketMessageEntityWithOptions
---

# POST Agents/Ticket/SaveTicketMessageEntityWithOptions

```http
POST /api/v1/Agents/Ticket/SaveTicketMessageEntityWithOptions
```

Saves a ticket message and performs additional actions







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SaveTicketMessageEntityWithOptions?$select=name,department,category/id
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

Entity, Notify, AttachmentIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Entity | TicketMessageEntity | The ticket messages are e-mails, SMS or other messages attached to a ticket (aka request). <para /> Carrier object for TicketMessageEntity. Services for the TicketMessageEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>. |
| Notify | Boolean |  |
| AttachmentIds | Array |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TicketMessageEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| EjMessageId | int32 | The primary key (auto-incremented) |
| Ticket | Ticket | The connected ticket |
| CreatedAt | date-time | When the message was posted. |
| CreatedBy | Associate | The associate who created this ticket message |
| Author | string | A string representing the author of the message. Could be a user&amp;apos;s name, or a persons email address. |
| Slevel | string | The securitylevel of the message. |
| Type | string | The type of the message (plaintext/html). |
| MessageId | string | The Message-Id header value from the email. Used for threading, i.e. connecting messages to existing tickets. |
| TimeSpent | int32 | The time spent (minutes) for this message. |
| Body | string | The textbody for the message. |
| HtmlBody | string | The html body for the message (if any). |
| EmailHeader | string | The email header is saved in this field as raw text |
| DebugInfo | string | The debug info for the message. |
| MailSorter | string | The name of the mail sorter used when the email was imported. Note: We must use name instead of id since the id&amp;apos;s change every time one changes the mail sorter. :-0 |
| MessageCategory | string | Defines what kind of message this is. |
| Person | Person | If this is an incoming message, this will contain the person  <para>Use MDO List name "person_new" to get list items.</para> |
| SearchTitle | string | A copy of the title of the ticket, for search optimisation and simpler reporting. |
| MessageHeaders | array | Contains the message headers, like To, Cc, Bcc information, or custom headers |
| Important | bool | If this message is important or not. |
| Language | string | The language this message is in, based on some kind of analysis |
| Sentiment | int32 | Sentiment index, 100 = completely happy; -100 = suicidally unhappy; 0 = no idea |
| SentimentConfidence | int32 | Confidence of sentiment index, 0 = no idea, 100 = completely sure |
| AttachmentsInfo | array | Message attachments information |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketMessageEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketMessageEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Ticket/SaveTicketMessageEntityWithOptions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Entity": null,
  "Notify": false,
  "AttachmentIds": [
    18,
    266
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 607,
  "Ticket": null,
  "CreatedAt": "2011-04-16T14:19:04.501577+02:00",
  "CreatedBy": null,
  "Author": "vitae",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "ut",
  "TimeSpent": 462,
  "Body": "voluptate",
  "HtmlBody": "et",
  "EmailHeader": "fabiola@hirthewalsh.com",
  "DebugInfo": "porro",
  "MailSorter": "et",
  "MessageCategory": "Bounce",
  "Person": null,
  "SearchTitle": "vel",
  "MessageHeaders": [
    {
      "Id": 94,
      "Name": "Friesen LLC",
      "Value": "vel",
      "StdItem": "CustomerReadFAQ",
      "StdItemCol": "Name",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 280
        }
      }
    }
  ],
  "Important": false,
  "Language": "repudiandae",
  "Sentiment": 260,
  "SentimentConfidence": 2,
  "AttachmentsInfo": [
    {
      "AttachmentId": 810,
      "Name": "Kunde-Abernathy",
      "ContentType": "aut",
      "AttSize": 549,
      "InlineImage": true,
      "ContentId": "fugiat",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 903
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "voluptatibus"
  },
  "CustomFields": {
    "CustomFields1": "libero",
    "CustomFields2": "modi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 373
    }
  }
}
```