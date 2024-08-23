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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 202,
      "ContactName": "Metz, Hayes and Green",
      "PersonId": 274,
      "PersonName": "Murazik, Greenfelder and Huel",
      "AssociateId": 294,
      "Address": "voluptatibus",
      "EmailId": 801,
      "DuplicatePersonIds": [
        213,
        852
      ],
      "Name": "Jakubowski-Wehner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 731
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 110,
      "ContactName": "McDermott-Luettgen",
      "PersonId": 866,
      "PersonName": "Hand-Davis",
      "AssociateId": 322,
      "Address": "molestiae",
      "EmailId": 188,
      "DuplicatePersonIds": [
        967,
        926
      ],
      "Name": "Bradtke, Ryan and Cassin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 139
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 54,
      "ContactName": "Miller, Metz and Grady",
      "PersonId": 509,
      "PersonName": "Marquardt, Gibson and Littel",
      "AssociateId": 471,
      "Address": "dolorum",
      "EmailId": 180,
      "DuplicatePersonIds": [
        322,
        890
      ],
      "Name": "Hagenes, Mann and Rau",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    }
  ],
  "Subject": "sed",
  "HTMLBody": "ullam",
  "From": null,
  "Sent": "2003-10-03T13:28:22.6791961+02:00",
  "Size": 44,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "quidem",
  "PlainBody": "pariatur",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 860,
  "Attachments": [
    {
      "Description": "Organic responsive benchmark",
      "Filename": "architecto",
      "Size": 509,
      "Type": "exercitationem",
      "Encoding": "voluptas",
      "Id": "sint",
      "Disposition": "veniam",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 183
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Friesen-Braun",
      "Values": [
        "aut",
        "non"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 779
        }
      }
    },
    {
      "Name": "Friesen-Braun",
      "Values": [
        "aut",
        "non"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 779
        }
      }
    }
  ],
  "FolderName": "Hayes, Waelchi and Erdman",
  "EmailItemId": 914,
  "AccountId": 801,
  "ReceivedAt": "2022-10-18T13:28:22.6791961+02:00",
  "InReplyTo": null,
  "RepliedAt": "2001-04-10T13:28:22.6791961+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 677
    }
  }
}
```