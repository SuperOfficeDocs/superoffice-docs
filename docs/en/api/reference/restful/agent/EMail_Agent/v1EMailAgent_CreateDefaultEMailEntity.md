---
title: POST Agents/EMail/CreateDefaultEMailEntity
uid: v1EMailAgent_CreateDefaultEMailEntity
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/EMail/CreateDefaultEMailEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 312,
      "ContactName": "Hoppe, Ziemann and Auer",
      "PersonId": 335,
      "PersonName": "Marquardt LLC",
      "AssociateId": 376,
      "Address": "laboriosam",
      "EmailId": 935,
      "DuplicatePersonIds": [
        456,
        758
      ],
      "Name": "Jakubowski, Botsford and Connelly",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 521
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 992,
      "ContactName": "Raynor LLC",
      "PersonId": 466,
      "PersonName": "Dietrich-Gleason",
      "AssociateId": 169,
      "Address": "dignissimos",
      "EmailId": 692,
      "DuplicatePersonIds": [
        31,
        568
      ],
      "Name": "Schamberger-Swaniawski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 600
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 498,
      "ContactName": "Crooks-Grimes",
      "PersonId": 137,
      "PersonName": "Beer, Olson and Huel",
      "AssociateId": 884,
      "Address": "corporis",
      "EmailId": 446,
      "DuplicatePersonIds": [
        178,
        70
      ],
      "Name": "Ledner Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 682
        }
      }
    }
  ],
  "Subject": "fugiat",
  "HTMLBody": "eligendi",
  "From": null,
  "Sent": "2010-06-16T14:19:03.4196462+02:00",
  "Size": 643,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "aperiam",
  "PlainBody": "omnis",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 855,
  "Attachments": [
    {
      "Description": "Down-sized web-enabled encryption",
      "Filename": "sed",
      "Size": 785,
      "Type": "et",
      "Encoding": "quo",
      "Id": "sed",
      "Disposition": "laboriosam",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "O'Hara-Lemke",
      "Values": [
        "dolorem",
        "aut"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    },
    {
      "Name": "O'Hara-Lemke",
      "Values": [
        "dolorem",
        "aut"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    }
  ],
  "FolderName": "McLaughlin, Schinner and Lakin",
  "EmailItemId": 503,
  "AccountId": 840,
  "ReceivedAt": "1997-01-26T14:19:03.4196462+01:00",
  "InReplyTo": null,
  "RepliedAt": "1999-10-14T14:19:03.4196462+02:00",
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