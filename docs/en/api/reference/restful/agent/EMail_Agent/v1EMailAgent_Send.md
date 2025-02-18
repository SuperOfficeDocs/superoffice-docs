---
title: POST Agents/EMail/Send
uid: v1EMailAgent_Send
generated: true
---

# POST Agents/EMail/Send

```http
POST /api/v1/Agents/EMail/Send
```

Send the provided e-mails


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/Send?$select=name,department,category/id
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

Emails 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Emails | Array |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
POST /api/v1/Agents/EMail/Send
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Emails": [
    {
      "To": [
        {},
        {}
      ],
      "Cc": [
        {},
        {}
      ],
      "Bcc": [
        {},
        {}
      ],
      "Subject": "sequi",
      "HTMLBody": "est",
      "From": null,
      "Sent": "2021-02-03T14:32:02.7960532+01:00",
      "Size": 247,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "illum",
      "PlainBody": "rerum",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 353,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Oberbrunner, O'Kon and Kerluke",
      "EmailItemId": 752,
      "AccountId": 492,
      "ReceivedAt": "2005-06-20T14:32:02.7960532+02:00",
      "InReplyTo": null,
      "RepliedAt": "2024-01-02T14:32:02.7960532+01:00",
      "HasCalendarData": true,
      "CalMethod": "Add",
      "CalReplyStatus": "Accepted"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "To": [
      {
        "ContactId": 892,
        "ContactName": "Roberts-Beahan",
        "PersonId": 60,
        "PersonName": "Auer-Schmeler",
        "AssociateId": 467,
        "Address": "assumenda",
        "EmailId": 343,
        "DuplicatePersonIds": [
          780,
          82
        ],
        "Name": "Kling Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 969
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 343,
        "ContactName": "Champlin LLC",
        "PersonId": 828,
        "PersonName": "Deckow Inc and Sons",
        "AssociateId": 672,
        "Address": "sit",
        "EmailId": 270,
        "DuplicatePersonIds": [
          883,
          124
        ],
        "Name": "Metz Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 654
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 536,
        "ContactName": "Kutch, Beier and O'Keefe",
        "PersonId": 745,
        "PersonName": "Doyle-McDermott",
        "AssociateId": 612,
        "Address": "quibusdam",
        "EmailId": 509,
        "DuplicatePersonIds": [
          778,
          659
        ],
        "Name": "Sporer-Anderson",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 447
          }
        }
      }
    ],
    "Subject": "harum",
    "HTMLBody": "consequatur",
    "From": null,
    "Sent": "2016-05-06T14:32:02.7960532+02:00",
    "Size": 559,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "voluptatem",
    "PlainBody": "dolores",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 633,
    "Attachments": [
      {
        "Description": "Upgradable zero tolerance circuit",
        "Filename": "quidem",
        "Size": 655,
        "Type": "repellat",
        "Encoding": "dolor",
        "Id": "qui",
        "Disposition": "assumenda",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 978
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Stehr Inc and Sons",
        "Values": [
          "deserunt",
          "et"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 918
          }
        }
      },
      {
        "Name": "Stehr Inc and Sons",
        "Values": [
          "deserunt",
          "et"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 918
          }
        }
      }
    ],
    "FolderName": "Quigley LLC",
    "EmailItemId": 268,
    "AccountId": 48,
    "ReceivedAt": "2002-11-05T14:32:02.7960532+01:00",
    "InReplyTo": null,
    "RepliedAt": "2014-11-03T14:32:02.7960532+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 188
      }
    }
  }
]
```