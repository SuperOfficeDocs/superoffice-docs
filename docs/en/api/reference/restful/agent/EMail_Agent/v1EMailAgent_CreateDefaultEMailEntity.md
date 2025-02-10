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
      "ContactId": 687,
      "ContactName": "Haag Group",
      "PersonId": 943,
      "PersonName": "Beier LLC",
      "AssociateId": 719,
      "Address": "labore",
      "EmailId": 957,
      "DuplicatePersonIds": [
        706,
        471
      ],
      "Name": "Murray-Greenfelder",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 801
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 939,
      "ContactName": "Considine-Upton",
      "PersonId": 580,
      "PersonName": "Vandervort-Reinger",
      "AssociateId": 210,
      "Address": "omnis",
      "EmailId": 334,
      "DuplicatePersonIds": [
        33,
        884
      ],
      "Name": "Terry, Stark and Abshire",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 619
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 841,
      "ContactName": "Rau-Schroeder",
      "PersonId": 862,
      "PersonName": "Franecki, Kreiger and Bednar",
      "AssociateId": 711,
      "Address": "sunt",
      "EmailId": 878,
      "DuplicatePersonIds": [
        633,
        976
      ],
      "Name": "Lang LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 607
        }
      }
    }
  ],
  "Subject": "sapiente",
  "HTMLBody": "in",
  "From": null,
  "Sent": "2010-04-02T12:01:27.8221586+02:00",
  "Size": 47,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "incidunt",
  "PlainBody": "neque",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 230,
  "Attachments": [
    {
      "Description": "Profit-focused national moderator",
      "Filename": "beatae",
      "Size": 100,
      "Type": "aut",
      "Encoding": "quia",
      "Id": "cupiditate",
      "Disposition": "voluptas",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 457
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Corwin, Botsford and Haag",
      "Values": [
        "neque",
        "unde"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 737
        }
      }
    },
    {
      "Name": "Corwin, Botsford and Haag",
      "Values": [
        "neque",
        "unde"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 737
        }
      }
    }
  ],
  "FolderName": "Jewess-Conn",
  "EmailItemId": 437,
  "AccountId": 770,
  "ReceivedAt": "2003-10-11T12:01:27.8221586+02:00",
  "InReplyTo": null,
  "RepliedAt": "2020-03-30T12:01:27.8221586+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 851
    }
  }
}
```