---
title: POST Agents/EMail/GetEMailFromAttachmentId
uid: v1EMailAgent_GetEMailFromAttachmentId
generated: true
---

# POST Agents/EMail/GetEMailFromAttachmentId

```http
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId
```

Get an e-mail based on an email and attachment id


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId?$select=name,department,category/id
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

EmailId, AttachmentIds, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailId | Integer |  |
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
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "EmailId": 127,
  "AttachmentIds": [
    "in",
    "cupiditate"
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
      "ContactId": 446,
      "ContactName": "Jacobson Inc and Sons",
      "PersonId": 86,
      "PersonName": "Daugherty, Nader and Stiedemann",
      "AssociateId": 732,
      "Address": "voluptas",
      "EmailId": 937,
      "DuplicatePersonIds": [
        681,
        445
      ],
      "Name": "Ankunding, Kling and Kautzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 386
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 456,
      "ContactName": "McClure Inc and Sons",
      "PersonId": 457,
      "PersonName": "Gleason-Eichmann",
      "AssociateId": 375,
      "Address": "nemo",
      "EmailId": 289,
      "DuplicatePersonIds": [
        516,
        13
      ],
      "Name": "Schneider, Aufderhar and Bruen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 261
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 993,
      "ContactName": "Friesen, Emard and Pouros",
      "PersonId": 930,
      "PersonName": "Lebsack-Grant",
      "AssociateId": 432,
      "Address": "debitis",
      "EmailId": 514,
      "DuplicatePersonIds": [
        598,
        196
      ],
      "Name": "Haag-Smith",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 326
        }
      }
    }
  ],
  "Subject": "labore",
  "HTMLBody": "omnis",
  "From": null,
  "Sent": "2001-12-28T23:03:55.9841317+01:00",
  "Size": 81,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "possimus",
  "PlainBody": "autem",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 744,
  "Attachments": [
    {
      "Description": "Self-enabling demand-driven infrastructure",
      "Filename": "sit",
      "Size": 652,
      "Type": "perspiciatis",
      "Encoding": "repudiandae",
      "Id": "qui",
      "Disposition": "blanditiis",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 714
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Rosenbaum LLC",
      "Values": [
        "earum",
        "rerum"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 544
        }
      }
    },
    {
      "Name": "Rosenbaum LLC",
      "Values": [
        "earum",
        "rerum"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 544
        }
      }
    }
  ],
  "FolderName": "Langworth LLC",
  "EmailItemId": 66,
  "AccountId": 809,
  "ReceivedAt": "2012-07-21T23:03:55.9846293+02:00",
  "InReplyTo": null,
  "RepliedAt": "2021-12-25T23:03:55.9846293+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 366
    }
  }
}
```