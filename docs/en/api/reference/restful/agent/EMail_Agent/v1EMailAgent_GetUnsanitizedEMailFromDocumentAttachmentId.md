---
title: POST Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId
uid: v1EMailAgent_GetUnsanitizedEMailFromDocumentAttachmentId
generated: true
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocId": 153,
  "AttachmentIds": [
    "laudantium",
    "porro"
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
      "ContactName": "Casper LLC",
      "PersonId": 164,
      "PersonName": "Williamson Group",
      "AssociateId": 308,
      "Address": "doloribus",
      "EmailId": 776,
      "DuplicatePersonIds": [
        242,
        496
      ],
      "Name": "Lubowitz-Hessel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 26
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 268,
      "ContactName": "Fritsch LLC",
      "PersonId": 979,
      "PersonName": "Stokes LLC",
      "AssociateId": 104,
      "Address": "numquam",
      "EmailId": 273,
      "DuplicatePersonIds": [
        321,
        281
      ],
      "Name": "Bogan-Quitzon",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 172
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 384,
      "ContactName": "Kunde, Luettgen and Shanahan",
      "PersonId": 625,
      "PersonName": "Hilll, Lynch and McKenzie",
      "AssociateId": 325,
      "Address": "aut",
      "EmailId": 959,
      "DuplicatePersonIds": [
        665,
        964
      ],
      "Name": "Kihn Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 17
        }
      }
    }
  ],
  "Subject": "nobis",
  "HTMLBody": "libero",
  "From": null,
  "Sent": "2004-01-06T11:06:34.5520595+01:00",
  "Size": 342,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "suscipit",
  "PlainBody": "vel",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 322,
  "Attachments": [
    {
      "Description": "Assimilated tertiary projection",
      "Filename": "repellat",
      "Size": 384,
      "Type": "nemo",
      "Encoding": "ipsum",
      "Id": "hic",
      "Disposition": "dolores",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 764
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Blick Inc and Sons",
      "Values": [
        "veniam",
        "nihil"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    },
    {
      "Name": "Blick Inc and Sons",
      "Values": [
        "veniam",
        "nihil"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    }
  ],
  "FolderName": "Hane, Rodriguez and Morar",
  "EmailItemId": 474,
  "AccountId": 545,
  "ReceivedAt": "2001-12-25T11:06:34.5520595+01:00",
  "InReplyTo": null,
  "RepliedAt": "2001-06-10T11:06:34.5520595+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 933
    }
  }
}
```