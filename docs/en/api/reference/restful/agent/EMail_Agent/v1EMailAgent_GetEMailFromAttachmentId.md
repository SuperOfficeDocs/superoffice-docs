---
title: POST Agents/EMail/GetEMailFromAttachmentId
uid: v1EMailAgent_GetEMailFromAttachmentId
generated: true
content_type: reference
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EmailId": 520,
  "AttachmentIds": [
    "voluptatem",
    "temporibus"
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
      "ContactId": 447,
      "ContactName": "Monahan-Casper",
      "PersonId": 599,
      "PersonName": "Buckridge-Hahn",
      "AssociateId": 339,
      "Address": "dolores",
      "EmailId": 848,
      "DuplicatePersonIds": [
        200,
        225
      ],
      "Name": "Kertzmann LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 703
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 593,
      "ContactName": "Little Group",
      "PersonId": 870,
      "PersonName": "Dickens, Reinger and Murazik",
      "AssociateId": 558,
      "Address": "enim",
      "EmailId": 434,
      "DuplicatePersonIds": [
        909,
        188
      ],
      "Name": "Robel, Mraz and Deckow",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 707
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 398,
      "ContactName": "Lehner Inc and Sons",
      "PersonId": 223,
      "PersonName": "Nolan LLC",
      "AssociateId": 778,
      "Address": "voluptatibus",
      "EmailId": 665,
      "DuplicatePersonIds": [
        272,
        720
      ],
      "Name": "Hermann-Hand",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 447
        }
      }
    }
  ],
  "Subject": "qui",
  "HTMLBody": "recusandae",
  "From": null,
  "Sent": "1998-05-21T03:46:54.785131+02:00",
  "Size": 606,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "dignissimos",
  "PlainBody": "commodi",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 973,
  "Attachments": [
    {
      "Description": "Face to face global knowledge base",
      "Filename": "eaque",
      "Size": 617,
      "Type": "vel",
      "Encoding": "reiciendis",
      "Id": "et",
      "Disposition": "tempora",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
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
  "CustomHeaderList": [
    {
      "Name": "Braun, Hyatt and Rau",
      "Values": [
        "vitae",
        "quaerat"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    },
    {
      "Name": "Braun, Hyatt and Rau",
      "Values": [
        "vitae",
        "quaerat"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    }
  ],
  "FolderName": "Douglas LLC",
  "EmailItemId": 948,
  "AccountId": 735,
  "ReceivedAt": "2010-06-09T03:46:54.785131+02:00",
  "InReplyTo": null,
  "RepliedAt": "2021-07-21T03:46:54.785131+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 209
    }
  }
}
```