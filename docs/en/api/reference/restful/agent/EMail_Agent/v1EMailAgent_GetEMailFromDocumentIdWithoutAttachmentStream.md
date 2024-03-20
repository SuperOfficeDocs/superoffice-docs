---
title: POST Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream
uid: v1EMailAgent_GetEMailFromDocumentIdWithoutAttachmentStream
generated: true
---

# POST Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream
```

Get an e-mail based on an archived document


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream?$select=name,department,category/id
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

DocumentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | Integer |  |

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
POST /api/v1/Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 568
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 314,
      "ContactName": "VonRueden LLC",
      "PersonId": 618,
      "PersonName": "Purdy, Goyette and Fahey",
      "AssociateId": 642,
      "Address": "porro",
      "EmailId": 307,
      "DuplicatePersonIds": [
        575,
        783
      ],
      "Name": "Jast-Kuhlman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 493
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 489,
      "ContactName": "Rowe LLC",
      "PersonId": 1002,
      "PersonName": "Larson, Bauch and Ondricka",
      "AssociateId": 925,
      "Address": "sapiente",
      "EmailId": 947,
      "DuplicatePersonIds": [
        168,
        21
      ],
      "Name": "Murphy, Hamill and Corwin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 569
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 677,
      "ContactName": "Dibbert, Blanda and Macejkovic",
      "PersonId": 115,
      "PersonName": "Schultz-Bahringer",
      "AssociateId": 149,
      "Address": "tempore",
      "EmailId": 316,
      "DuplicatePersonIds": [
        693,
        476
      ],
      "Name": "Mueller-Hodkiewicz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 253
        }
      }
    }
  ],
  "Subject": "quas",
  "HTMLBody": "natus",
  "From": null,
  "Sent": "2003-08-10T12:19:45.2422708+02:00",
  "Size": 892,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "alias",
  "PlainBody": "odit",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 247,
  "Attachments": [
    {
      "Description": "Function-based optimal concept",
      "Filename": "corporis",
      "Size": 390,
      "Type": "rem",
      "Encoding": "quaerat",
      "Id": "quasi",
      "Disposition": "est",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 937
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Gutmann LLC",
      "Values": [
        "voluptatem",
        "quos"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    },
    {
      "Name": "Gutmann LLC",
      "Values": [
        "voluptatem",
        "quos"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    }
  ],
  "FolderName": "Bahringer Group",
  "EmailItemId": 637,
  "AccountId": 268,
  "ReceivedAt": "2024-03-17T12:19:45.2422708+01:00",
  "InReplyTo": null,
  "RepliedAt": "2017-07-02T12:19:45.2422708+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 78
    }
  }
}
```