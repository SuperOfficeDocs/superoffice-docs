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
  "DocumentId": 622
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 676,
      "ContactName": "Bernier, Jast and Ryan",
      "PersonId": 515,
      "PersonName": "Smith-Ziemann",
      "AssociateId": 29,
      "Address": "in",
      "EmailId": 974,
      "DuplicatePersonIds": [
        233,
        228
      ],
      "Name": "Maggio-Abshire",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 318
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 618,
      "ContactName": "Howe Group",
      "PersonId": 697,
      "PersonName": "Koepp, Schultz and Gorczany",
      "AssociateId": 571,
      "Address": "eveniet",
      "EmailId": 523,
      "DuplicatePersonIds": [
        140,
        377
      ],
      "Name": "Beer Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 143
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 292,
      "ContactName": "Collier-Wilkinson",
      "PersonId": 74,
      "PersonName": "Leffler, Crooks and Schneider",
      "AssociateId": 322,
      "Address": "aut",
      "EmailId": 893,
      "DuplicatePersonIds": [
        248,
        621
      ],
      "Name": "Berge-Heaney",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 531
        }
      }
    }
  ],
  "Subject": "dolorem",
  "HTMLBody": "ipsam",
  "From": null,
  "Sent": "2006-01-02T16:54:55.3174197+01:00",
  "Size": 547,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "ducimus",
  "PlainBody": "dignissimos",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 975,
  "Attachments": [
    {
      "Description": "Customer-focused systematic application",
      "Filename": "voluptatum",
      "Size": 733,
      "Type": "eos",
      "Encoding": "quis",
      "Id": "in",
      "Disposition": "quae",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 184
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Schulist Group",
      "Values": [
        "est",
        "quod"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 315
        }
      }
    },
    {
      "Name": "Schulist Group",
      "Values": [
        "est",
        "quod"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 315
        }
      }
    }
  ],
  "FolderName": "Schoen, Dickinson and Emard",
  "EmailItemId": 901,
  "AccountId": 217,
  "ReceivedAt": "2023-11-23T16:54:55.3174197+01:00",
  "InReplyTo": null,
  "RepliedAt": "2020-06-26T16:54:55.3184197+02:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 914
    }
  }
}
```