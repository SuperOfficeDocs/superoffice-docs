---
title: POST Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId
uid: v1EMailAgent_GetUnsanitizedEMailFromDocumentAttachmentId
generated: true
content_type: reference
---

# POST Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId
```

Get an e-mail based on an email in the archive system and attachment id.


The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId?$select=name,department,category/id
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

DocId, AttachmentIds, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocId | Integer |  |
| AttachmentIds | Array |  |
| IncludeAttachments | Boolean |  |

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
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocId": 914,
  "AttachmentIds": [
    "eum",
    "sint"
  ],
  "IncludeAttachments": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 6,
      "ContactName": "Wolff-Cummings",
      "PersonId": 950,
      "PersonName": "Wyman, White and Bergstrom",
      "AssociateId": 743,
      "Address": "quaerat",
      "EmailId": 527,
      "DuplicatePersonIds": [
        914,
        66
      ],
      "Name": "Frami-Rogahn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 950
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 524,
      "ContactName": "Collins, Leannon and Wehner",
      "PersonId": 466,
      "PersonName": "Miller-VonRueden",
      "AssociateId": 261,
      "Address": "expedita",
      "EmailId": 900,
      "DuplicatePersonIds": [
        861,
        866
      ],
      "Name": "Fay, Kunde and Bechtelar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 469
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 875,
      "ContactName": "Schultz-Davis",
      "PersonId": 468,
      "PersonName": "Orn, Ledner and Watsica",
      "AssociateId": 436,
      "Address": "ipsam",
      "EmailId": 972,
      "DuplicatePersonIds": [
        498,
        208
      ],
      "Name": "Parker, Watsica and Rosenbaum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 925
        }
      }
    }
  ],
  "Subject": "sint",
  "HTMLBody": "consectetur",
  "From": null,
  "Sent": "2004-09-15T03:41:53.5276084+02:00",
  "Size": 63,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "voluptas",
  "PlainBody": "esse",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 643,
  "Attachments": [
    {
      "Description": "Centralized object-oriented parallelism",
      "Filename": "aut",
      "Size": 745,
      "Type": "nulla",
      "Encoding": "magnam",
      "Id": "eos",
      "Disposition": "enim",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 968
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Ward-Runolfsdottir",
      "Values": [
        "perferendis",
        "distinctio"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    },
    {
      "Name": "Ward-Runolfsdottir",
      "Values": [
        "perferendis",
        "distinctio"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 436
        }
      }
    }
  ],
  "FolderName": "Rutherford, Stamm and Luettgen",
  "EmailItemId": 85,
  "AccountId": 242,
  "ReceivedAt": "2019-01-06T03:41:53.5276084+01:00",
  "InReplyTo": null,
  "RepliedAt": "2023-10-14T03:41:53.5276084+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 274
    }
  }
}
```