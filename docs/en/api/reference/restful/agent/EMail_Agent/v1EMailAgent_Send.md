---
title: POST Agents/EMail/Send
uid: v1EMailAgent_Send
generated: true
content_type: reference
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
Accept-Language: sv
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
      "Subject": "aut",
      "HTMLBody": "eius",
      "From": null,
      "Sent": "2019-04-18T03:41:53.4651107+02:00",
      "Size": 100,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "modi",
      "PlainBody": "occaecati",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 670,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Murphy, Kautzer and Hand",
      "EmailItemId": 396,
      "AccountId": 588,
      "ReceivedAt": "2015-05-10T03:41:53.4651107+02:00",
      "InReplyTo": null,
      "RepliedAt": "2011-01-24T03:41:53.4651107+01:00",
      "HasCalendarData": false,
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
        "ContactId": 77,
        "ContactName": "Gottlieb, Lubowitz and Kilback",
        "PersonId": 262,
        "PersonName": "Fahey, Predovic and Schaden",
        "AssociateId": 451,
        "Address": "quas",
        "EmailId": 355,
        "DuplicatePersonIds": [
          962,
          936
        ],
        "Name": "Hauck, Rogahn and Labadie",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 593
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 953,
        "ContactName": "Kautzer, Daugherty and Kuhic",
        "PersonId": 537,
        "PersonName": "Flatley, Pacocha and Schmidt",
        "AssociateId": 622,
        "Address": "quibusdam",
        "EmailId": 660,
        "DuplicatePersonIds": [
          955,
          191
        ],
        "Name": "Zieme-Bergstrom",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 52
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 880,
        "ContactName": "Dare LLC",
        "PersonId": 469,
        "PersonName": "Carter-Beer",
        "AssociateId": 598,
        "Address": "pariatur",
        "EmailId": 728,
        "DuplicatePersonIds": [
          918,
          700
        ],
        "Name": "Pouros-Rau",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 61
          }
        }
      }
    ],
    "Subject": "sequi",
    "HTMLBody": "quas",
    "From": null,
    "Sent": "2024-02-22T03:41:53.4651107+01:00",
    "Size": 36,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "similique",
    "PlainBody": "et",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 706,
    "Attachments": [
      {
        "Description": "Right-sized radical software",
        "Filename": "sed",
        "Size": 667,
        "Type": "quidem",
        "Encoding": "voluptate",
        "Id": "est",
        "Disposition": "amet",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 678
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Ryan, Streich and Cremin",
        "Values": [
          "quas",
          "dicta"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 56
          }
        }
      },
      {
        "Name": "Ryan, Streich and Cremin",
        "Values": [
          "quas",
          "dicta"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 56
          }
        }
      }
    ],
    "FolderName": "Bechtelar-Mueller",
    "EmailItemId": 622,
    "AccountId": 115,
    "ReceivedAt": "2018-06-14T03:41:53.4651107+02:00",
    "InReplyTo": null,
    "RepliedAt": "2022-03-20T03:41:53.4651107+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 939
      }
    }
  }
]
```