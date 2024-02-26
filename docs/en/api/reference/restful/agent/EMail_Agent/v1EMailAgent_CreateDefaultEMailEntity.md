---
title: POST Agents/EMail/CreateDefaultEMailEntity
uid: v1EMailAgent_CreateDefaultEMailEntity
generated: true
---

# POST Agents/EMail/CreateDefaultEMailEntity

```http
POST /api/v1/Agents/EMail/CreateDefaultEMailEntity
```

Set default values into a new EMailEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/EMail/CreateDefaultEMailEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 603,
      "ContactName": "Bartoletti-Beahan",
      "PersonId": 924,
      "PersonName": "Turcotte-Bartoletti",
      "AssociateId": 400,
      "Address": "quod",
      "EmailId": 268,
      "DuplicatePersonIds": [
        661,
        742
      ],
      "Name": "Douglas-Harris",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 697
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 111,
      "ContactName": "Heaney-Wuckert",
      "PersonId": 888,
      "PersonName": "Goodwin-Thiel",
      "AssociateId": 569,
      "Address": "ad",
      "EmailId": 989,
      "DuplicatePersonIds": [
        587,
        651
      ],
      "Name": "Hermiston Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 428
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 245,
      "ContactName": "Borer-Fay",
      "PersonId": 501,
      "PersonName": "Mosciski-O'Conner",
      "AssociateId": 769,
      "Address": "temporibus",
      "EmailId": 115,
      "DuplicatePersonIds": [
        999,
        90
      ],
      "Name": "Feest Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 184
        }
      }
    }
  ],
  "Subject": "velit",
  "HTMLBody": "et",
  "From": null,
  "Sent": "2006-04-30T10:30:23.7668125+02:00",
  "Size": 221,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "voluptatem",
  "PlainBody": "praesentium",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 540,
  "Attachments": [
    {
      "Description": "Balanced zero tolerance help-desk",
      "Filename": "maiores",
      "Size": 280,
      "Type": "odio",
      "Encoding": "et",
      "Id": "illo",
      "Disposition": "voluptatem",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 628
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Dooley Group",
      "Values": [
        "praesentium",
        "laudantium"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 893
        }
      }
    },
    {
      "Name": "Dooley Group",
      "Values": [
        "praesentium",
        "laudantium"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 893
        }
      }
    }
  ],
  "FolderName": "Beahan Inc and Sons",
  "EmailItemId": 59,
  "AccountId": 854,
  "ReceivedAt": "2021-12-19T10:30:23.7668125+01:00",
  "InReplyTo": null,
  "RepliedAt": "2003-03-04T10:30:23.7668125+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 997
    }
  }
}
```