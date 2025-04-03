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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 147,
      "ContactName": "Herzog, Jacobs and Hackett",
      "PersonId": 355,
      "PersonName": "Lindgren-Heller",
      "AssociateId": 768,
      "Address": "adipisci",
      "EmailId": 889,
      "DuplicatePersonIds": [
        998,
        390
      ],
      "Name": "Kuhlman-Hoppe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 815,
      "ContactName": "Beahan, Streich and Jacobs",
      "PersonId": 749,
      "PersonName": "Kunze-Torphy",
      "AssociateId": 538,
      "Address": "sunt",
      "EmailId": 315,
      "DuplicatePersonIds": [
        900,
        3
      ],
      "Name": "Sauer Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 450
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 984,
      "ContactName": "Corkery Group",
      "PersonId": 764,
      "PersonName": "Ratke, Littel and Prosacco",
      "AssociateId": 717,
      "Address": "suscipit",
      "EmailId": 844,
      "DuplicatePersonIds": [
        371,
        356
      ],
      "Name": "Bins LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 856
        }
      }
    }
  ],
  "Subject": "sed",
  "HTMLBody": "ea",
  "From": null,
  "Sent": "2022-07-22T14:28:21.9303967+02:00",
  "Size": 182,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "pariatur",
  "PlainBody": "quod",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 885,
  "Attachments": [
    {
      "Description": "Re-contextualized 3rd generation time-frame",
      "Filename": "minima",
      "Size": 399,
      "Type": "nostrum",
      "Encoding": "impedit",
      "Id": "nisi",
      "Disposition": "earum",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 559
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Langosh-Ullrich",
      "Values": [
        "iure",
        "fugit"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 213
        }
      }
    },
    {
      "Name": "Langosh-Ullrich",
      "Values": [
        "iure",
        "fugit"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 213
        }
      }
    }
  ],
  "FolderName": "Beahan, Cartwright and McLaughlin",
  "EmailItemId": 673,
  "AccountId": 41,
  "ReceivedAt": "2010-10-01T14:28:21.9303967+02:00",
  "InReplyTo": null,
  "RepliedAt": "2014-02-21T14:28:21.9303967+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 174
    }
  }
}
```