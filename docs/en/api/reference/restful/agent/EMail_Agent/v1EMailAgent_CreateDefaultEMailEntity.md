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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 243,
      "ContactName": "Hackett-Ernser",
      "PersonId": 890,
      "PersonName": "Hammes, Brakus and Bernhard",
      "AssociateId": 149,
      "Address": "nulla",
      "EmailId": 761,
      "DuplicatePersonIds": [
        452,
        644
      ],
      "Name": "Mohr LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 247
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 806,
      "ContactName": "Lockman-Wunsch",
      "PersonId": 594,
      "PersonName": "Ledner Inc and Sons",
      "AssociateId": 689,
      "Address": "sequi",
      "EmailId": 546,
      "DuplicatePersonIds": [
        597,
        319
      ],
      "Name": "Robel-Becker",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 564
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 526,
      "ContactName": "Hayes, McClure and Leuschke",
      "PersonId": 979,
      "PersonName": "Kiehn-Koss",
      "AssociateId": 773,
      "Address": "excepturi",
      "EmailId": 807,
      "DuplicatePersonIds": [
        960,
        264
      ],
      "Name": "Spinka, Baumbach and Haag",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 548
        }
      }
    }
  ],
  "Subject": "officia",
  "HTMLBody": "est",
  "From": null,
  "Sent": "2019-10-05T03:40:46.8592703+02:00",
  "Size": 695,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "alias",
  "PlainBody": "eos",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 441,
  "Attachments": [
    {
      "Description": "Implemented optimal artificial intelligence",
      "Filename": "in",
      "Size": 463,
      "Type": "eveniet",
      "Encoding": "harum",
      "Id": "quod",
      "Disposition": "officiis",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 338
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Batz, Nader and Beier",
      "Values": [
        "iusto",
        "necessitatibus"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    },
    {
      "Name": "Batz, Nader and Beier",
      "Values": [
        "iusto",
        "necessitatibus"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    }
  ],
  "FolderName": "Cronin-Toy",
  "EmailItemId": 950,
  "AccountId": 312,
  "ReceivedAt": "2001-02-19T03:40:46.8592703+01:00",
  "InReplyTo": null,
  "RepliedAt": "2007-04-12T03:40:46.8592703+02:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 66
    }
  }
}
```