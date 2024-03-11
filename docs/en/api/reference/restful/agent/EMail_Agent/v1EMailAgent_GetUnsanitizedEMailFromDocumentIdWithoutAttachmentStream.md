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
  "DocumentId": 393
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 492,
      "ContactName": "Rogahn Group",
      "PersonId": 729,
      "PersonName": "Kemmer-Rogahn",
      "AssociateId": 660,
      "Address": "maxime",
      "EmailId": 545,
      "DuplicatePersonIds": [
        24,
        2
      ],
      "Name": "Hilll Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 463
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 175,
      "ContactName": "Funk-Predovic",
      "PersonId": 125,
      "PersonName": "Kreiger-Satterfield",
      "AssociateId": 217,
      "Address": "dolor",
      "EmailId": 759,
      "DuplicatePersonIds": [
        736,
        279
      ],
      "Name": "Fisher-Kautzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 345
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 737,
      "ContactName": "Boyle, Dicki and Green",
      "PersonId": 652,
      "PersonName": "Nolan Inc and Sons",
      "AssociateId": 686,
      "Address": "quo",
      "EmailId": 175,
      "DuplicatePersonIds": [
        946,
        908
      ],
      "Name": "Jast-Mosciski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 837
        }
      }
    }
  ],
  "Subject": "perferendis",
  "HTMLBody": "aut",
  "From": null,
  "Sent": "2004-11-11T14:23:46.4543289+01:00",
  "Size": 558,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "excepturi",
  "PlainBody": "qui",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 195,
  "Attachments": [
    {
      "Description": "Polarised optimal challenge",
      "Filename": "nemo",
      "Size": 291,
      "Type": "et",
      "Encoding": "possimus",
      "Id": "rerum",
      "Disposition": "corporis",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 834
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Schinner, Kertzmann and Gottlieb",
      "Values": [
        "et",
        "aut"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 986
        }
      }
    },
    {
      "Name": "Schinner, Kertzmann and Gottlieb",
      "Values": [
        "et",
        "aut"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 986
        }
      }
    }
  ],
  "FolderName": "Tremblay Inc and Sons",
  "EmailItemId": 86,
  "AccountId": 760,
  "ReceivedAt": "2001-09-26T14:23:46.4543289+02:00",
  "InReplyTo": null,
  "RepliedAt": "2000-09-29T14:23:46.4543289+02:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 480
    }
  }
}
```