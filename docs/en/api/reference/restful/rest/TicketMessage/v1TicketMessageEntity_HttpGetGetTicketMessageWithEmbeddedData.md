---
title: GET TicketMessage/{id}
uid: v1TicketMessageEntity_HttpGetGetTicketMessageWithEmbeddedData
---

# GET TicketMessage/{id}

```http
GET /api/v1/TicketMessage/{id}
```

Get a ticket message entity with posibillity to change embedded images to be represented with inline data within the HTML body.


If using inline data, be sure not to save this back to the database.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ticket message entity **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| embedImages | Enum: Link, Inline |  If set to Inline, then use inline base64 data to represent the images in the HTML body. Default: Link will use link to the image. |

```http
GET /api/v1/TicketMessage/{id}?embedImages=Inline
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
| 404 | Not Found. |

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/TicketMessage/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 811,
  "Ticket": null,
  "CreatedAt": "2005-07-05T12:15:27.5596276+02:00",
  "CreatedBy": null,
  "Author": "rerum",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "voluptatibus",
  "TimeSpent": 355,
  "Body": "vitae",
  "HtmlBody": "rerum",
  "EmailHeader": "linwood.toy@kemmer.ca",
  "DebugInfo": "eos",
  "MailSorter": "eos",
  "MessageCategory": "Bounce",
  "Person": null,
  "SearchTitle": "magnam",
  "MessageHeaders": [
    {
      "Id": 262,
      "Name": "Volkman, Brakus and Fisher",
      "Value": "autem",
      "StdItem": "CustomerReadFAQ",
      "StdItemCol": "Name",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 692
        }
      }
    }
  ],
  "Important": true,
  "Language": "ab",
  "Sentiment": 278,
  "SentimentConfidence": 899,
  "AttachmentsInfo": [
    {
      "AttachmentId": 398,
      "Name": "Stoltenberg, Stamm and Hudson",
      "ContentType": "aut",
      "AttSize": 5,
      "InlineImage": false,
      "ContentId": "laboriosam",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 110
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "nobis"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "sed"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 250
    }
  }
}
```