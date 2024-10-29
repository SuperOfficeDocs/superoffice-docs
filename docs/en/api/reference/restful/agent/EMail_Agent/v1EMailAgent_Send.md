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
      "Subject": "sint",
      "HTMLBody": "deserunt",
      "From": null,
      "Sent": "2003-04-17T13:14:05.9289081+02:00",
      "Size": 324,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "eos",
      "PlainBody": "culpa",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 310,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Lynch, Hane and Johnson",
      "EmailItemId": 434,
      "AccountId": 910,
      "ReceivedAt": "2005-12-02T13:14:05.9289081+01:00",
      "InReplyTo": null,
      "RepliedAt": "1997-11-20T13:14:05.9289081+01:00",
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
        "ContactId": 1002,
        "ContactName": "Kertzmann Group",
        "PersonId": 829,
        "PersonName": "Bogan-Boehm",
        "AssociateId": 625,
        "Address": "in",
        "EmailId": 28,
        "DuplicatePersonIds": [
          226,
          976
        ],
        "Name": "Walker-Gottlieb",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 720
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 112,
        "ContactName": "Schimmel-Aufderhar",
        "PersonId": 899,
        "PersonName": "Champlin, Wilkinson and VonRueden",
        "AssociateId": 330,
        "Address": "dicta",
        "EmailId": 66,
        "DuplicatePersonIds": [
          695,
          981
        ],
        "Name": "Lueilwitz-Harber",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 282
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 821,
        "ContactName": "Schoen-McClure",
        "PersonId": 421,
        "PersonName": "Von LLC",
        "AssociateId": 86,
        "Address": "quia",
        "EmailId": 291,
        "DuplicatePersonIds": [
          267,
          217
        ],
        "Name": "Gusikowski, Lemke and Bednar",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 934
          }
        }
      }
    ],
    "Subject": "rerum",
    "HTMLBody": "voluptates",
    "From": null,
    "Sent": "2015-12-02T13:14:05.9445336+01:00",
    "Size": 440,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "optio",
    "PlainBody": "doloribus",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 753,
    "Attachments": [
      {
        "Description": "Monitored holistic initiative",
        "Filename": "itaque",
        "Size": 253,
        "Type": "voluptatem",
        "Encoding": "voluptatem",
        "Id": "eos",
        "Disposition": "rem",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 972
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "DuBuque, Jenkins and McDermott",
        "Values": [
          "similique",
          "quisquam"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 846
          }
        }
      },
      {
        "Name": "DuBuque, Jenkins and McDermott",
        "Values": [
          "similique",
          "quisquam"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 846
          }
        }
      }
    ],
    "FolderName": "Dicki, Jerde and Ferry",
    "EmailItemId": 91,
    "AccountId": 948,
    "ReceivedAt": "2007-06-04T13:14:05.9445336+02:00",
    "InReplyTo": null,
    "RepliedAt": "2002-01-20T13:14:05.9445336+01:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 621
      }
    }
  }
]
```