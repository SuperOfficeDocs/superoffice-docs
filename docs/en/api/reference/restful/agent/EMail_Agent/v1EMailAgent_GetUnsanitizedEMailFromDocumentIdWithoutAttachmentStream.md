---
title: POST Agents/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
uid: v1EMailAgent_GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
generated: true
---

# POST Agents/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
```

Get an e-mail based on an archived document.


The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 811
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 866,
      "ContactName": "Cremin, Parisian and Donnelly",
      "PersonId": 573,
      "PersonName": "Kunde-Jaskolski",
      "AssociateId": 147,
      "Address": "et",
      "EmailId": 731,
      "DuplicatePersonIds": [
        728,
        505
      ],
      "Name": "Zieme LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 301,
      "ContactName": "Lubowitz-Mante",
      "PersonId": 8,
      "PersonName": "Okuneva, Cole and Krajcik",
      "AssociateId": 165,
      "Address": "excepturi",
      "EmailId": 30,
      "DuplicatePersonIds": [
        217,
        249
      ],
      "Name": "Morar Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 52
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 395,
      "ContactName": "Auer LLC",
      "PersonId": 899,
      "PersonName": "Hyatt LLC",
      "AssociateId": 495,
      "Address": "dolorem",
      "EmailId": 742,
      "DuplicatePersonIds": [
        67,
        447
      ],
      "Name": "Steuber Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 88
        }
      }
    }
  ],
  "Subject": "et",
  "HTMLBody": "hic",
  "From": null,
  "Sent": "2020-11-28T17:54:03.0702097+01:00",
  "Size": 500,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "sunt",
  "PlainBody": "aut",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 464,
  "Attachments": [
    {
      "Description": "Visionary optimizing project",
      "Filename": "quo",
      "Size": 704,
      "Type": "explicabo",
      "Encoding": "consectetur",
      "Id": "modi",
      "Disposition": "rerum",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 4
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Purdy LLC",
      "Values": [
        "omnis",
        "ipsa"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 794
        }
      }
    },
    {
      "Name": "Purdy LLC",
      "Values": [
        "omnis",
        "ipsa"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 794
        }
      }
    }
  ],
  "FolderName": "Nicolas Group",
  "EmailItemId": 739,
  "AccountId": 440,
  "ReceivedAt": "2004-08-31T17:54:03.0702097+02:00",
  "InReplyTo": null,
  "RepliedAt": "2007-07-20T17:54:03.0702097+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 172
    }
  }
}
```