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
Accept-Language: en
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
      "Subject": "natus",
      "HTMLBody": "placeat",
      "From": null,
      "Sent": "2024-02-19T14:28:21.8991479+01:00",
      "Size": 210,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "deleniti",
      "PlainBody": "in",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 882,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Grimes-Bartell",
      "EmailItemId": 622,
      "AccountId": 32,
      "ReceivedAt": "1999-03-27T14:28:21.8991479+01:00",
      "InReplyTo": null,
      "RepliedAt": "2015-03-29T14:28:21.8991479+02:00",
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
        "ContactId": 852,
        "ContactName": "Swift, Rau and Cruickshank",
        "PersonId": 4,
        "PersonName": "Pacocha-Sipes",
        "AssociateId": 68,
        "Address": "consequatur",
        "EmailId": 113,
        "DuplicatePersonIds": [
          798,
          959
        ],
        "Name": "Hartmann-Conn",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 293
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 713,
        "ContactName": "Torphy, Berge and Heathcote",
        "PersonId": 284,
        "PersonName": "Sawayn Inc and Sons",
        "AssociateId": 888,
        "Address": "sequi",
        "EmailId": 548,
        "DuplicatePersonIds": [
          786,
          909
        ],
        "Name": "Mayert, Bins and D'Amore",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 603
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 848,
        "ContactName": "Wisoky LLC",
        "PersonId": 683,
        "PersonName": "Medhurst, Herzog and Thompson",
        "AssociateId": 576,
        "Address": "esse",
        "EmailId": 96,
        "DuplicatePersonIds": [
          797,
          557
        ],
        "Name": "Wilderman-Predovic",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 744
          }
        }
      }
    ],
    "Subject": "quis",
    "HTMLBody": "sunt",
    "From": null,
    "Sent": "2005-07-03T14:28:21.8991479+02:00",
    "Size": 894,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "et",
    "PlainBody": "expedita",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 290,
    "Attachments": [
      {
        "Description": "Public-key heuristic matrices",
        "Filename": "ea",
        "Size": 274,
        "Type": "autem",
        "Encoding": "et",
        "Id": "molestiae",
        "Disposition": "dolorem",
        "IsSafeFileExtension": true,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 679
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Mueller-Bogan",
        "Values": [
          "soluta",
          "veritatis"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 49
          }
        }
      },
      {
        "Name": "Mueller-Bogan",
        "Values": [
          "soluta",
          "veritatis"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 49
          }
        }
      }
    ],
    "FolderName": "Weimann-Kling",
    "EmailItemId": 184,
    "AccountId": 623,
    "ReceivedAt": "2024-02-24T14:28:21.8991479+01:00",
    "InReplyTo": null,
    "RepliedAt": "2024-06-22T14:28:21.8991479+02:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 30
      }
    }
  }
]
```