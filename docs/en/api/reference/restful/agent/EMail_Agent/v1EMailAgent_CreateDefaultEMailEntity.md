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
      "ContactId": 539,
      "ContactName": "Bogisich LLC",
      "PersonId": 477,
      "PersonName": "Rodriguez, Connelly and Morissette",
      "AssociateId": 420,
      "Address": "qui",
      "EmailId": 169,
      "DuplicatePersonIds": [
        75,
        312
      ],
      "Name": "McDermott, Bode and Swift",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 591
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 727,
      "ContactName": "DuBuque LLC",
      "PersonId": 493,
      "PersonName": "Reynolds Group",
      "AssociateId": 66,
      "Address": "voluptatum",
      "EmailId": 2,
      "DuplicatePersonIds": [
        20,
        981
      ],
      "Name": "Lesch, Heidenreich and Prohaska",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 222
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 409,
      "ContactName": "Crist LLC",
      "PersonId": 779,
      "PersonName": "Runte-Runolfsson",
      "AssociateId": 906,
      "Address": "qui",
      "EmailId": 561,
      "DuplicatePersonIds": [
        162,
        638
      ],
      "Name": "Auer-Koch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 88
        }
      }
    }
  ],
  "Subject": "eligendi",
  "HTMLBody": "quisquam",
  "From": null,
  "Sent": "2010-12-02T03:46:54.7695066+01:00",
  "Size": 201,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "quis",
  "PlainBody": "aspernatur",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 483,
  "Attachments": [
    {
      "Description": "Visionary bandwidth-monitored leverage",
      "Filename": "ut",
      "Size": 646,
      "Type": "est",
      "Encoding": "eveniet",
      "Id": "laboriosam",
      "Disposition": "rem",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 502
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Stracke Group",
      "Values": [
        "quia",
        "ea"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 368
        }
      }
    },
    {
      "Name": "Stracke Group",
      "Values": [
        "quia",
        "ea"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 368
        }
      }
    }
  ],
  "FolderName": "Kutch-Lowe",
  "EmailItemId": 509,
  "AccountId": 660,
  "ReceivedAt": "2023-08-27T03:46:54.7695066+02:00",
  "InReplyTo": null,
  "RepliedAt": "2005-04-19T03:46:54.7695066+02:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 990
    }
  }
}
```