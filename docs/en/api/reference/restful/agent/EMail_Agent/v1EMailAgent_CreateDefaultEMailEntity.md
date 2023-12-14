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
      "ContactId": 640,
      "ContactName": "Corkery, Haag and Watsica",
      "PersonId": 39,
      "PersonName": "Glover LLC",
      "AssociateId": 925,
      "Address": "molestiae",
      "EmailId": 592,
      "DuplicatePersonIds": [
        250,
        352
      ],
      "Name": "Legros LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 32
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 512,
      "ContactName": "Kessler, Feil and Cummerata",
      "PersonId": 354,
      "PersonName": "Lang, Hand and Ferry",
      "AssociateId": 878,
      "Address": "laudantium",
      "EmailId": 571,
      "DuplicatePersonIds": [
        159,
        741
      ],
      "Name": "Beatty, Reichel and Mertz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 669
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 215,
      "ContactName": "Langosh-Hagenes",
      "PersonId": 535,
      "PersonName": "Satterfield LLC",
      "AssociateId": 957,
      "Address": "quo",
      "EmailId": 540,
      "DuplicatePersonIds": [
        900,
        263
      ],
      "Name": "West Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 759
        }
      }
    }
  ],
  "Subject": "necessitatibus",
  "HTMLBody": "fugit",
  "From": null,
  "Sent": "2012-10-11T13:57:12.2779931+02:00",
  "Size": 725,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "est",
  "PlainBody": "quibusdam",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 916,
  "Attachments": [
    {
      "Description": "Up-sized methodical local area network",
      "Filename": "sit",
      "Size": 865,
      "Type": "qui",
      "Encoding": "quibusdam",
      "Id": "ipsam",
      "Disposition": "perspiciatis",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 169
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Christiansen Inc and Sons",
      "Values": [
        "eius",
        "commodi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 771
        }
      }
    },
    {
      "Name": "Christiansen Inc and Sons",
      "Values": [
        "eius",
        "commodi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 771
        }
      }
    }
  ],
  "FolderName": "Mohr Inc and Sons",
  "EmailItemId": 459,
  "AccountId": 158,
  "ReceivedAt": "2007-03-09T13:57:12.2779931+01:00",
  "InReplyTo": null,
  "RepliedAt": "2005-02-07T13:57:12.2779931+01:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 170
    }
  }
}
```