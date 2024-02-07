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
      "ContactId": 786,
      "ContactName": "Hyatt Group",
      "PersonId": 24,
      "PersonName": "Langosh-Gutmann",
      "AssociateId": 837,
      "Address": "corrupti",
      "EmailId": 935,
      "DuplicatePersonIds": [
        520,
        299
      ],
      "Name": "Douglas, Stroman and Beatty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 16,
      "ContactName": "Hermiston, Wintheiser and Mante",
      "PersonId": 162,
      "PersonName": "Green-Lesch",
      "AssociateId": 206,
      "Address": "facere",
      "EmailId": 484,
      "DuplicatePersonIds": [
        10,
        227
      ],
      "Name": "Tremblay-Anderson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 348
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 223,
      "ContactName": "Hirthe, Tremblay and Satterfield",
      "PersonId": 732,
      "PersonName": "Dickinson LLC",
      "AssociateId": 710,
      "Address": "voluptas",
      "EmailId": 781,
      "DuplicatePersonIds": [
        405,
        344
      ],
      "Name": "Cummerata-VonRueden",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 77
        }
      }
    }
  ],
  "Subject": "officiis",
  "HTMLBody": "voluptatum",
  "From": null,
  "Sent": "2016-10-29T16:54:55.3394198+02:00",
  "Size": 532,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "dolore",
  "PlainBody": "in",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 133,
  "Attachments": [
    {
      "Description": "Vision-oriented grid-enabled project",
      "Filename": "cupiditate",
      "Size": 95,
      "Type": "ea",
      "Encoding": "non",
      "Id": "molestiae",
      "Disposition": "omnis",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 981
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "McKenzie, Von and Watsica",
      "Values": [
        "sunt",
        "reiciendis"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 96
        }
      }
    },
    {
      "Name": "McKenzie, Von and Watsica",
      "Values": [
        "sunt",
        "reiciendis"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 96
        }
      }
    }
  ],
  "FolderName": "Stoltenberg Inc and Sons",
  "EmailItemId": 848,
  "AccountId": 761,
  "ReceivedAt": "2016-05-15T16:54:55.3404203+02:00",
  "InReplyTo": null,
  "RepliedAt": "2009-03-20T16:54:55.3404203+01:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 549
    }
  }
}
```