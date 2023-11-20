---
title: POST Agents/EMail/GetUnsanitizedEMail
uid: v1EMailAgent_GetUnsanitizedEMail
generated: true
---

# POST Agents/EMail/GetUnsanitizedEMail

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMail
```

Get en e-mail based on its primary key in the DB.


The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMail?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

Id, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | Integer |  |
| IncludeAttachments | Boolean |  |

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
POST /api/v1/Agents/EMail/GetUnsanitizedEMail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Id": 45,
  "IncludeAttachments": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 826,
      "ContactName": "Roob Group",
      "PersonId": 442,
      "PersonName": "Kassulke-Tillman",
      "AssociateId": 331,
      "Address": "illo",
      "EmailId": 559,
      "DuplicatePersonIds": [
        166,
        220
      ],
      "Name": "Streich-Romaguera",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 197
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 8,
      "ContactName": "Waters Inc and Sons",
      "PersonId": 113,
      "PersonName": "Ortiz-Schmeler",
      "AssociateId": 1002,
      "Address": "adipisci",
      "EmailId": 848,
      "DuplicatePersonIds": [
        689,
        653
      ],
      "Name": "Zulauf-Shanahan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 821
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 314,
      "ContactName": "Beer, Will and Kuhn",
      "PersonId": 395,
      "PersonName": "Reichel Inc and Sons",
      "AssociateId": 501,
      "Address": "provident",
      "EmailId": 570,
      "DuplicatePersonIds": [
        336,
        179
      ],
      "Name": "Hand, Upton and D'Amore",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 695
        }
      }
    }
  ],
  "Subject": "quidem",
  "HTMLBody": "sed",
  "From": null,
  "Sent": "2013-01-26T13:38:13.592742+01:00",
  "Size": 171,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "deleniti",
  "PlainBody": "quia",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 796,
  "Attachments": [
    {
      "Description": "Ergonomic content-based task-force",
      "Filename": "esse",
      "Size": 761,
      "Type": "nihil",
      "Encoding": "labore",
      "Id": "voluptatem",
      "Disposition": "unde",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 66
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Rau-Williamson",
      "Values": [
        "ut",
        "nihil"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 243
        }
      }
    },
    {
      "Name": "Rau-Williamson",
      "Values": [
        "ut",
        "nihil"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 243
        }
      }
    }
  ],
  "FolderName": "Herzog Inc and Sons",
  "EmailItemId": 547,
  "AccountId": 543,
  "ReceivedAt": "2006-12-07T13:38:13.592742+01:00",
  "InReplyTo": null,
  "RepliedAt": "2010-06-29T13:38:13.592742+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 457
    }
  }
}
```