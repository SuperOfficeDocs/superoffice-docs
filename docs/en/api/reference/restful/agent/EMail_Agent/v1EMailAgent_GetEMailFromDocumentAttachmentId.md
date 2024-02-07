---
title: POST Agents/EMail/GetEMailFromDocumentAttachmentId
uid: v1EMailAgent_GetEMailFromDocumentAttachmentId
generated: true
---

# POST Agents/EMail/GetEMailFromDocumentAttachmentId

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentAttachmentId
```

Get an e-mail based on an email in the archive system and attachment id


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentAttachmentId?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetEMailFromDocumentAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocId": 265,
  "AttachmentIds": [
    "officiis",
    "et"
  ],
  "IncludeAttachments": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 687,
      "ContactName": "Schaefer Inc and Sons",
      "PersonId": 761,
      "PersonName": "Bosco, Walter and Renner",
      "AssociateId": 114,
      "Address": "quae",
      "EmailId": 439,
      "DuplicatePersonIds": [
        221,
        713
      ],
      "Name": "Miller, Hermiston and Erdman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 786
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 232,
      "ContactName": "Gulgowski, Marvin and Hessel",
      "PersonId": 418,
      "PersonName": "Gutmann, Wilkinson and Towne",
      "AssociateId": 834,
      "Address": "dolorum",
      "EmailId": 649,
      "DuplicatePersonIds": [
        797,
        8
      ],
      "Name": "Paucek Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 738
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 14,
      "ContactName": "Herman Inc and Sons",
      "PersonId": 129,
      "PersonName": "Mraz-Heaney",
      "AssociateId": 909,
      "Address": "aut",
      "EmailId": 239,
      "DuplicatePersonIds": [
        418,
        367
      ],
      "Name": "Zulauf Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 320
        }
      }
    }
  ],
  "Subject": "reiciendis",
  "HTMLBody": "velit",
  "From": null,
  "Sent": "1997-07-19T16:54:55.3869485+02:00",
  "Size": 535,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "sit",
  "PlainBody": "reprehenderit",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 596,
  "Attachments": [
    {
      "Description": "Horizontal object-oriented process improvement",
      "Filename": "ad",
      "Size": 429,
      "Type": "iure",
      "Encoding": "distinctio",
      "Id": "vero",
      "Disposition": "ducimus",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 338
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Abbott, Christiansen and Kiehn",
      "Values": [
        "quia",
        "et"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 439
        }
      }
    },
    {
      "Name": "Abbott, Christiansen and Kiehn",
      "Values": [
        "quia",
        "et"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 439
        }
      }
    }
  ],
  "FolderName": "Kuhn, Tremblay and Tillman",
  "EmailItemId": 409,
  "AccountId": 112,
  "ReceivedAt": "2015-03-16T16:54:55.3869485+01:00",
  "InReplyTo": null,
  "RepliedAt": "2022-07-13T16:54:55.3869485+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 612
    }
  }
}
```