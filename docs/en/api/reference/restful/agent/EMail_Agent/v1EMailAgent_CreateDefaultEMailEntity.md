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


NsApiSlow threshold: 5000 ms.


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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 483,
      "ContactName": "Cremin LLC",
      "PersonId": 364,
      "PersonName": "Kozey, Turner and McKenzie",
      "AssociateId": 452,
      "Address": "ea",
      "EmailId": 122,
      "DuplicatePersonIds": [
        772,
        52
      ],
      "Name": "Lowe-Lang",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 22
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 917,
      "ContactName": "Carroll Group",
      "PersonId": 146,
      "PersonName": "Grady LLC",
      "AssociateId": 310,
      "Address": "sed",
      "EmailId": 217,
      "DuplicatePersonIds": [
        161,
        805
      ],
      "Name": "Schneider-Koepp",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 165,
      "ContactName": "Harber Inc and Sons",
      "PersonId": 31,
      "PersonName": "Gulgowski-Thiel",
      "AssociateId": 593,
      "Address": "asperiores",
      "EmailId": 693,
      "DuplicatePersonIds": [
        174,
        986
      ],
      "Name": "Marvin Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 611
        }
      }
    }
  ],
  "Subject": "autem",
  "HTMLBody": "libero",
  "From": null,
  "Sent": "2012-07-23T02:30:47.2882099+02:00",
  "Size": 897,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "quidem",
  "PlainBody": "tenetur",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 89,
  "Attachments": [
    {
      "Description": "Sharable transitional policy",
      "Filename": "autem",
      "Size": 344,
      "Type": "odit",
      "Encoding": "voluptatem",
      "Id": "assumenda",
      "Disposition": "ratione",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 114
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Leffler-Goldner",
      "Values": [
        "voluptatem",
        "ut"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    },
    {
      "Name": "Leffler-Goldner",
      "Values": [
        "voluptatem",
        "ut"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    }
  ],
  "FolderName": "Williamson, Gutmann and McLaughlin",
  "EmailItemId": 962,
  "AccountId": 861,
  "ReceivedAt": "2008-08-15T02:30:47.2882099+02:00",
  "InReplyTo": null,
  "RepliedAt": "2002-02-11T02:30:47.2882099+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 303
    }
  }
}
```