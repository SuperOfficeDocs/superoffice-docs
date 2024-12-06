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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Id": 401,
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
      "ContactId": 593,
      "ContactName": "Brekke-Schiller",
      "PersonId": 490,
      "PersonName": "Daugherty Inc and Sons",
      "AssociateId": 471,
      "Address": "neque",
      "EmailId": 616,
      "DuplicatePersonIds": [
        81,
        347
      ],
      "Name": "Armstrong Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 705
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 180,
      "ContactName": "Hane Group",
      "PersonId": 347,
      "PersonName": "Ward-Stiedemann",
      "AssociateId": 142,
      "Address": "ipsa",
      "EmailId": 175,
      "DuplicatePersonIds": [
        15,
        756
      ],
      "Name": "Lindgren Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 104
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 55,
      "ContactName": "Ebert, Littel and Mitchell",
      "PersonId": 244,
      "PersonName": "Fadel-Goyette",
      "AssociateId": 467,
      "Address": "et",
      "EmailId": 732,
      "DuplicatePersonIds": [
        938,
        52
      ],
      "Name": "Stokes, Frami and Labadie",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 529
        }
      }
    }
  ],
  "Subject": "laudantium",
  "HTMLBody": "non",
  "From": null,
  "Sent": "2005-08-24T10:17:55.6134076+02:00",
  "Size": 239,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "et",
  "PlainBody": "vero",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 977,
  "Attachments": [
    {
      "Description": "Switchable modular projection",
      "Filename": "enim",
      "Size": 583,
      "Type": "saepe",
      "Encoding": "quia",
      "Id": "veniam",
      "Disposition": "molestiae",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 792
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Shanahan, Hand and Schmidt",
      "Values": [
        "quia",
        "maxime"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 959
        }
      }
    },
    {
      "Name": "Shanahan, Hand and Schmidt",
      "Values": [
        "quia",
        "maxime"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 959
        }
      }
    }
  ],
  "FolderName": "Heller, Shanahan and Kautzer",
  "EmailItemId": 920,
  "AccountId": 557,
  "ReceivedAt": "2023-08-21T10:17:55.6134076+02:00",
  "InReplyTo": null,
  "RepliedAt": "2015-01-05T10:17:55.6134076+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 97
    }
  }
}
```