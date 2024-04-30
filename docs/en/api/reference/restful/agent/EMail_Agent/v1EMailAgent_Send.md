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
      "Subject": "quia",
      "HTMLBody": "eos",
      "From": null,
      "Sent": "2004-07-25T11:44:33.5722192+02:00",
      "Size": 644,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "voluptatibus",
      "PlainBody": "ex",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 313,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Champlin-Botsford",
      "EmailItemId": 235,
      "AccountId": 303,
      "ReceivedAt": "2000-08-16T11:44:33.5722192+02:00",
      "InReplyTo": null,
      "RepliedAt": "2006-08-11T11:44:33.5722192+02:00",
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
        "ContactId": 614,
        "ContactName": "Gutmann Group",
        "PersonId": 641,
        "PersonName": "Barton-Conn",
        "AssociateId": 153,
        "Address": "sequi",
        "EmailId": 81,
        "DuplicatePersonIds": [
          358,
          495
        ],
        "Name": "DuBuque Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 161
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 183,
        "ContactName": "Schuster Inc and Sons",
        "PersonId": 30,
        "PersonName": "Kulas Inc and Sons",
        "AssociateId": 774,
        "Address": "rerum",
        "EmailId": 959,
        "DuplicatePersonIds": [
          802,
          306
        ],
        "Name": "Rau Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 853
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 531,
        "ContactName": "Kilback, D'Amore and Sawayn",
        "PersonId": 105,
        "PersonName": "Rutherford Inc and Sons",
        "AssociateId": 34,
        "Address": "animi",
        "EmailId": 963,
        "DuplicatePersonIds": [
          331,
          836
        ],
        "Name": "O'Keefe-Stroman",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 472
          }
        }
      }
    ],
    "Subject": "aperiam",
    "HTMLBody": "est",
    "From": null,
    "Sent": "2015-02-28T11:44:33.5722192+01:00",
    "Size": 492,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "rerum",
    "PlainBody": "dolores",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 980,
    "Attachments": [
      {
        "Description": "Multi-tiered exuding paradigm",
        "Filename": "non",
        "Size": 959,
        "Type": "et",
        "Encoding": "incidunt",
        "Id": "ut",
        "Disposition": "rerum",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 784
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Boyer, Wiegand and Doyle",
        "Values": [
          "omnis",
          "eum"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 240
          }
        }
      },
      {
        "Name": "Boyer, Wiegand and Doyle",
        "Values": [
          "omnis",
          "eum"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 240
          }
        }
      }
    ],
    "FolderName": "Pacocha-Rippin",
    "EmailItemId": 637,
    "AccountId": 622,
    "ReceivedAt": "2016-08-20T11:44:33.5722192+02:00",
    "InReplyTo": null,
    "RepliedAt": "2003-08-24T11:44:33.5722192+02:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 691
      }
    }
  }
]
```