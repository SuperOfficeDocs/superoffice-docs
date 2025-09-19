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
      "ContactId": 710,
      "ContactName": "Bashirian Group",
      "PersonId": 745,
      "PersonName": "Schowalter-Schmitt",
      "AssociateId": 105,
      "Address": "illum",
      "EmailId": 656,
      "DuplicatePersonIds": [
        268,
        645
      ],
      "Name": "Blick LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 31
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 919,
      "ContactName": "Luettgen, Lindgren and Cummerata",
      "PersonId": 915,
      "PersonName": "Stiedemann Inc and Sons",
      "AssociateId": 220,
      "Address": "non",
      "EmailId": 593,
      "DuplicatePersonIds": [
        7,
        196
      ],
      "Name": "Bosco, Schaefer and Crooks",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 814
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 481,
      "ContactName": "Carter, Raynor and Rogahn",
      "PersonId": 516,
      "PersonName": "Pfannerstill, Stokes and Botsford",
      "AssociateId": 159,
      "Address": "impedit",
      "EmailId": 332,
      "DuplicatePersonIds": [
        991,
        214
      ],
      "Name": "Konopelski, Padberg and Roob",
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
  "Subject": "recusandae",
  "HTMLBody": "voluptatum",
  "From": null,
  "Sent": "1998-11-22T03:41:53.5119835+01:00",
  "Size": 589,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "aliquam",
  "PlainBody": "dolore",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 231,
  "Attachments": [
    {
      "Description": "Distributed explicit concept",
      "Filename": "autem",
      "Size": 722,
      "Type": "ut",
      "Encoding": "perferendis",
      "Id": "voluptas",
      "Disposition": "ea",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 809
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Hodkiewicz-Purdy",
      "Values": [
        "numquam",
        "suscipit"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 990
        }
      }
    },
    {
      "Name": "Hodkiewicz-Purdy",
      "Values": [
        "numquam",
        "suscipit"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 990
        }
      }
    }
  ],
  "FolderName": "VonRueden-Macejkovic",
  "EmailItemId": 834,
  "AccountId": 542,
  "ReceivedAt": "2014-03-04T03:41:53.5119835+01:00",
  "InReplyTo": null,
  "RepliedAt": "2011-01-24T03:41:53.5119835+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 803
    }
  }
}
```