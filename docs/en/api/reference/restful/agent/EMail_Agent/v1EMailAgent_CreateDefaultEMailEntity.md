---
title: POST Agents/EMail/CreateDefaultEMailEntity
uid: v1EMailAgent_CreateDefaultEMailEntity
generated: true
content_type: reference
---

# POST Agents/EMail/CreateDefaultEMailEntity

```http
POST /api/v1/Agents/EMail/CreateDefaultEMailEntity
```

Loading default values into a new EMailEntity.


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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 331,
      "ContactName": "Sipes Inc and Sons",
      "PersonId": 60,
      "PersonName": "O'Reilly-Waters",
      "AssociateId": 200,
      "Address": "vel",
      "EmailId": 299,
      "DuplicatePersonIds": [
        882,
        877
      ],
      "Name": "Lind, Thompson and Haley",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 803
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 135,
      "ContactName": "Cronin LLC",
      "PersonId": 405,
      "PersonName": "Stamm-Franecki",
      "AssociateId": 473,
      "Address": "culpa",
      "EmailId": 975,
      "DuplicatePersonIds": [
        203,
        855
      ],
      "Name": "Wunsch-Walker",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 45
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 286,
      "ContactName": "Blanda-Robel",
      "PersonId": 183,
      "PersonName": "Schneider-Connelly",
      "AssociateId": 196,
      "Address": "animi",
      "EmailId": 816,
      "DuplicatePersonIds": [
        569,
        686
      ],
      "Name": "Bradtke-Rutherford",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 350
        }
      }
    }
  ],
  "Subject": "quibusdam",
  "HTMLBody": "recusandae",
  "From": null,
  "Sent": "2011-02-21T11:24:48.078283+01:00",
  "Size": 206,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "distinctio",
  "PlainBody": "consequatur",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 88,
  "Attachments": [
    {
      "Description": "Balanced homogeneous internet solution",
      "Filename": "nostrum",
      "Size": 312,
      "Type": "et",
      "Encoding": "delectus",
      "Id": "quam",
      "Disposition": "voluptatem",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 855
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Leffler Inc and Sons",
      "Values": [
        "ut",
        "optio"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 5
        }
      }
    },
    {
      "Name": "Leffler Inc and Sons",
      "Values": [
        "ut",
        "optio"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 5
        }
      }
    }
  ],
  "FolderName": "Harber-Von",
  "EmailItemId": 421,
  "AccountId": 305,
  "ReceivedAt": "2006-06-30T11:24:48.078283+02:00",
  "InReplyTo": null,
  "RepliedAt": "2007-03-19T11:24:48.078283+01:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 875
    }
  }
}
```