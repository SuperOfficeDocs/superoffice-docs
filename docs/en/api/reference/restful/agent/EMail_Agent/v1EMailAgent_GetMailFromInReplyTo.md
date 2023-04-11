---
title: POST Agents/EMail/GetMailFromInReplyTo
uid: v1EMailAgent_GetMailFromInReplyTo
---

# POST Agents/EMail/GetMailFromInReplyTo

```http
POST /api/v1/Agents/EMail/GetMailFromInReplyTo
```

Get email from db based on In-Reply-To Message Id


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetMailFromInReplyTo?$select=name,department,category/id
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

MessageId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MessageId | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: EMailEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| To | array | To recipients of e-mail |
| Cc | array | Cc recipients of e-mail |
| Bcc | array | Bcc recipient of e-mail |
| Subject | string | Subject of the e-mail |
| HTMLBody | string | Body formatted in HTML |
| From | EMailAddress | Who did the e-mail originate from |
| Sent | date-time | When was the e-mail sent |
| Size | int32 | Total size of the e-mail |
| Priority | string | Importance of the e-mail |
| Flags | string | Flag status of this mail (unread, replied, deleted ) |
| MessageID | string | Unique id of e-mails |
| PlainBody | string | Body formatted in plain text |
| IsSent | bool | Is this a sent e-mail (not new) |
| EMailSOInfo | EMailSOInfo | Glue between SuperOffice data and an e-mail. |
| ServerId | int32 | Unique id for the e-mail on the server |
| Attachments | array |  |
| CustomHeaderList | array | Non standard e-mail headers |
| FolderName | string | Name of folder the e-mail belongs in |
| EmailItemId | int32 | Primary key |
| AccountId | int32 | Account Id |
| ReceivedAt | date-time | Received date time |
| InReplyTo | EMailEnvelope | The envelope of the email this email is a reply to, if it exists |
| RepliedAt | date-time | When this email was replied at |
| HasCalendarData | bool | If this email contains exactly one iCal appointment |
| CalMethod | string | Method stored in the associated iCal appointment. Indicates if the iCal data is a reply, counter proposal etc. |
| CalReplyStatus | string | Reply status stored in calendar data for the ical method is REPLY |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/EMail/GetMailFromInReplyTo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "MessageId": "voluptatem"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 373,
      "ContactName": "Deckow Inc and Sons",
      "PersonId": 382,
      "PersonName": "Lowe LLC",
      "AssociateId": 992,
      "Address": "aliquam",
      "EmailId": 294,
      "DuplicatePersonIds": [
        572,
        160
      ],
      "Name": "Daniel-Emmerich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 769
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 717,
      "ContactName": "Quigley-Franecki",
      "PersonId": 980,
      "PersonName": "Bosco-Gutmann",
      "AssociateId": 84,
      "Address": "quia",
      "EmailId": 451,
      "DuplicatePersonIds": [
        887,
        738
      ],
      "Name": "Gibson Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 235
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 342,
      "ContactName": "Abbott LLC",
      "PersonId": 739,
      "PersonName": "Shields Inc and Sons",
      "AssociateId": 490,
      "Address": "dolorum",
      "EmailId": 409,
      "DuplicatePersonIds": [
        556,
        405
      ],
      "Name": "Kirlin LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 569
        }
      }
    }
  ],
  "Subject": "ut",
  "HTMLBody": "et",
  "From": null,
  "Sent": "2005-12-30T15:29:21.6998152+01:00",
  "Size": 627,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "ratione",
  "PlainBody": "facilis",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 812,
  "Attachments": [
    {
      "Description": "Face to face client-driven database",
      "Filename": "tenetur",
      "Size": 695,
      "Type": "qui",
      "Encoding": "quo",
      "Id": "dolorem",
      "Disposition": "fuga",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Larkin-Wisozk",
      "Values": [
        "sint",
        "nisi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 320
        }
      }
    },
    {
      "Name": "Larkin-Wisozk",
      "Values": [
        "sint",
        "nisi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 320
        }
      }
    }
  ],
  "FolderName": "Rempel, Spinka and Hahn",
  "EmailItemId": 558,
  "AccountId": 6,
  "ReceivedAt": "2006-09-18T15:29:21.7008124+02:00",
  "InReplyTo": null,
  "RepliedAt": "2004-01-03T15:29:21.7013122+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 551
    }
  }
}
```