---
title: POST TicketMessage
uid: v1TicketMessageEntity_HttpPostSaveTicketMessageEntityWithNotify
generated: true
---

# POST TicketMessage

```http
POST /api/v1/TicketMessage
```

Saves a ticket message and performs any user notifications







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| notify | bool |  If true, then the notification will be sent along with the save |

```http
POST /api/v1/TicketMessage?notify=True
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

## Request Body: newEntity 

The ticket message to save 

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
| Person | Person | If this is an incoming message, this will contain the person  <para>Use MDO List name "person_new" to get list items.</para> |
| SearchTitle | string | A copy of the title of the ticket, for search optimisation and simpler reporting. |
| MessageHeaders | array | Contains the message headers, like To, Cc, Bcc information, or custom headers |
| Important | bool | If this message is important or not. |
| Language | string | The language this message is in, based on some kind of analysis |
| Sentiment | int32 | Sentiment index, 100 = completely happy; -100 = suicidally unhappy; 0 = no idea |
| SentimentConfidence | int32 | Confidence of sentiment index, 0 = no idea, 100 = completely sure |
| Badge | string | Badge to explicitly determine how a message was generated |
| AttachmentsInfo | array | Message attachments information |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.TicketMessageEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.TicketMessageEntity.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/TicketMessage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 236,
  "Ticket": null,
  "CreatedAt": "1996-01-29T16:00:48.5708887+01:00",
  "CreatedBy": null,
  "Author": "temporibus",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "beatae",
  "TimeSpent": 84,
  "Body": "est",
  "HtmlBody": "quia",
  "EmailHeader": "stephany@reynoldsjenkins.info",
  "DebugInfo": "itaque",
  "MailSorter": "qui",
  "MessageCategory": "Bounce",
  "Person": null,
  "SearchTitle": "accusantium",
  "MessageHeaders": [
    {
      "Id": 526,
      "Name": "Mitchell-Brakus",
      "Value": "molestiae",
      "StdItem": "CustomerReadFAQ",
      "StdItemCol": "Name"
    },
    {
      "Id": 526,
      "Name": "Mitchell-Brakus",
      "Value": "molestiae",
      "StdItem": "CustomerReadFAQ",
      "StdItemCol": "Name"
    }
  ],
  "Important": false,
  "Language": "ipsa",
  "Sentiment": 533,
  "SentimentConfidence": 373,
  "Badge": "Comment",
  "AttachmentsInfo": [
    {
      "AttachmentId": 91,
      "Name": "O'Hara, Johns and Deckow",
      "ContentType": "harum",
      "AttSize": 574,
      "InlineImage": true,
      "ContentId": "quisquam",
      "AuthKey": "dolores"
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "saepe",
    "ExtraFields2": "iste"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "quaerat"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjMessageId": 436,
  "Ticket": null,
  "CreatedAt": "1999-03-19T16:00:48.586505+01:00",
  "CreatedBy": null,
  "Author": "consectetur",
  "Slevel": "External",
  "Type": "Html",
  "MessageId": "impedit",
  "TimeSpent": 846,
  "Body": "consequatur",
  "HtmlBody": "veniam",
  "EmailHeader": "alysha.champlin@simonis.biz",
  "DebugInfo": "et",
  "MailSorter": "nemo",
  "MessageCategory": "Bounce",
  "Person": null,
  "SearchTitle": "eius",
  "MessageHeaders": [
    {
      "Id": 580,
      "Name": "Carroll, Schmitt and Bailey",
      "Value": "distinctio",
      "StdItem": "CustomerReadFAQ",
      "StdItemCol": "Name",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 814
        }
      }
    }
  ],
  "Important": false,
  "Language": "dolorum",
  "Sentiment": 743,
  "SentimentConfidence": 344,
  "Badge": "Comment",
  "AttachmentsInfo": [
    {
      "AttachmentId": 815,
      "Name": "Little Group",
      "ContentType": "qui",
      "AttSize": 453,
      "InlineImage": false,
      "ContentId": "rerum",
      "AuthKey": "animi",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 553
        }
      }
    }
  ],
  "ExtraFields": {
    "ExtraFields1": "hic",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "dolore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 861
    }
  }
}
```