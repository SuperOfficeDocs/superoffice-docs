---
title: POST Agents/Ticket/SaveTicketMessageEntity
uid: v1TicketAgent_SaveTicketMessageEntity
generated: true
---

# POST Agents/Ticket/SaveTicketMessageEntity

```http
POST /api/v1/Agents/Ticket/SaveTicketMessageEntity
```

Updates the existing TicketMessageEntity or creates a new TicketMessageEntity if the id parameter is empty








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

## Request Body: entity 

The TicketMessageEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EjMessageId | Integer | The primary key (auto-incremented) |
| Ticket | Ticket | The connected ticket |
| CreatedAt | String | When the message was posted. |
| CreatedBy | Associate | The associate who created this ticket message |
| Author | String | A string representing the author of the message. Could be a user&amp;apos;s name, or a persons email address. |
| Slevel | String | The securitylevel of the message. |
| Type | String | The type of the message (plaintext/html). |
| MessageId | String | The Message-Id header value from the email. Used for threading, i.e. connecting messages to existing tickets. |
| TimeSpent | Integer | The time spent (minutes) for this message. |
| Body | String | The textbody for the message. |
| HtmlBody | String | The html body for the message (if any). |
| EmailHeader | String | The email header is saved in this field as raw text |
| DebugInfo | String | The debug info for the message. |
| MailSorter | String | The name of the mail sorter used when the email was imported. Note: We must use name instead of id since the id&amp;apos;s change every time one changes the mail sorter. :-0 |
| MessageCategory | String | Defines what kind of message this is. |
| Person | Person | If this is an incoming message, this will contain the person  <para>Use MDO List name "person_new" to get list items.</para> |
| SearchTitle | String | A copy of the title of the ticket, for search optimisation and simpler reporting. |
| MessageHeaders | Array | Contains the message headers, like To, Cc, Bcc information, or custom headers |
| Important | Boolean | If this message is important or not. |
| Language | String | The language this message is in, based on some kind of analysis |
| Sentiment | Integer | Sentiment index, 100 = completely happy; -100 = suicidally unhappy; 0 = no idea |
| SentimentConfidence | Integer | Confidence of sentiment index, 0 = no idea, 100 = completely sure |
| Badge | String | Badge to explicitly determine how a message was generated |
| AttachmentsInfo | Array | Message attachments information |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.TicketMessageEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketMessageEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

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
| Person | Person | If this is an incoming message, this will contain the person  Use MDO List name "person_new" to get list items. |
| SearchTitle | string | A copy of the title of the ticket, for search optimisation and simpler reporting. |
| MessageHeaders | array | Contains the message headers, like To, Cc, Bcc information, or custom headers |
| Important | bool | If this message is important or not. |
| Language | string | The language this message is in, based on some kind of analysis |
| Sentiment | int32 | Sentiment index, 100 = completely happy; -100 = suicidally unhappy; 0 = no idea |
| SentimentConfidence | int32 | Confidence of sentiment index, 0 = no idea, 100 = completely sure |
| Badge | string | Badge to explicitly determine how a message was generated |
| AttachmentsInfo | array | Message attachments information |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketMessageEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketMessageEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Ticket/SaveTicketMessageEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 916,
  "Ticket": null,
  "CreatedAt": "2004-01-05T12:57:35.0551794+01:00",
  "CreatedBy": null,
  "Author": "dolores",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "iusto",
  "TimeSpent": 949,
  "Body": "culpa",
  "HtmlBody": "expedita",
  "EmailHeader": "orlo@nitzsche.biz",
  "DebugInfo": "sapiente",
  "MailSorter": "enim",
  "MessageCategory": "Bounce",
  "Person": null,
  "SearchTitle": "et",
  "MessageHeaders": [
    {
      "Id": 755,
      "Name": "Renner Inc and Sons",
      "Value": "aut",
      "StdItem": "CustomerReadFAQ",
      "StdItemCol": "Name"
    },
    {
      "Id": 755,
      "Name": "Renner Inc and Sons",
      "Value": "aut",
      "StdItem": "CustomerReadFAQ",
      "StdItemCol": "Name"
    }
  ],
  "Important": true,
  "Language": "deserunt",
  "Sentiment": 17,
  "SentimentConfidence": 423,
  "Badge": "Comment",
  "AttachmentsInfo": [
    {
      "AttachmentId": 156,
      "Name": "Schneider LLC",
      "ContentType": "nihil",
      "AttSize": 454,
      "InlineImage": true,
      "ContentId": "rerum",
      "AuthKey": "itaque",
      "IsSafeFileExtension": false
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "voluptatum",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "error",
    "CustomFields2": "suscipit"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 842,
  "Ticket": null,
  "CreatedAt": "2013-10-07T12:57:35.0708009+02:00",
  "CreatedBy": null,
  "Author": "unde",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "rerum",
  "TimeSpent": 154,
  "Body": "et",
  "HtmlBody": "quibusdam",
  "EmailHeader": "jessica_schuster@rau.com",
  "DebugInfo": "ut",
  "MailSorter": "maxime",
  "MessageCategory": "Bounce",
  "Person": null,
  "SearchTitle": "tempore",
  "MessageHeaders": [
    {
      "Id": 468,
      "Name": "Brakus, Yundt and Corkery",
      "Value": "optio",
      "StdItem": "CustomerReadFAQ",
      "StdItemCol": "Name",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 211
        }
      }
    }
  ],
  "Important": false,
  "Language": "et",
  "Sentiment": 21,
  "SentimentConfidence": 194,
  "Badge": "Comment",
  "AttachmentsInfo": [
    {
      "AttachmentId": 520,
      "Name": "Kreiger-Fahey",
      "ContentType": "quis",
      "AttSize": 333,
      "InlineImage": true,
      "ContentId": "culpa",
      "AuthKey": "provident",
      "IsSafeFileExtension": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 28
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "vero",
    "ExtraFields2": "saepe"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "suscipit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 80
    }
  }
}
```