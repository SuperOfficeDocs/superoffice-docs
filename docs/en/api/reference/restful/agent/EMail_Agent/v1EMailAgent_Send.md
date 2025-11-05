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


NsApiSlow threshold: 5000 ms.


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
      "Subject": "et",
      "HTMLBody": "excepturi",
      "From": null,
      "Sent": "2005-05-03T02:30:47.2257111+02:00",
      "Size": 929,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "nihil",
      "PlainBody": "dolorem",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 49,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Brakus LLC",
      "EmailItemId": 119,
      "AccountId": 212,
      "ReceivedAt": "2024-08-27T02:30:47.2257111+02:00",
      "InReplyTo": null,
      "RepliedAt": "2010-06-04T02:30:47.2257111+02:00",
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
        "ContactId": 160,
        "ContactName": "Rutherford-Kub",
        "PersonId": 210,
        "PersonName": "Howe-Pouros",
        "AssociateId": 874,
        "Address": "sint",
        "EmailId": 848,
        "DuplicatePersonIds": [
          838,
          814
        ],
        "Name": "Stiedemann, Willms and Connelly",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 815
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 991,
        "ContactName": "Schmidt-Fritsch",
        "PersonId": 915,
        "PersonName": "Hyatt LLC",
        "AssociateId": 330,
        "Address": "magni",
        "EmailId": 307,
        "DuplicatePersonIds": [
          874,
          565
        ],
        "Name": "Kautzer-Kautzer",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 321
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 54,
        "ContactName": "Yundt-Grimes",
        "PersonId": 440,
        "PersonName": "Eichmann Group",
        "AssociateId": 70,
        "Address": "adipisci",
        "EmailId": 194,
        "DuplicatePersonIds": [
          63,
          903
        ],
        "Name": "Stark-Hyatt",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 632
          }
        }
      }
    ],
    "Subject": "suscipit",
    "HTMLBody": "aliquam",
    "From": null,
    "Sent": "2004-10-08T02:30:47.2257111+02:00",
    "Size": 216,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "reiciendis",
    "PlainBody": "eveniet",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 624,
    "Attachments": [
      {
        "Description": "Ameliorated zero tolerance focus group",
        "Filename": "impedit",
        "Size": 45,
        "Type": "consequatur",
        "Encoding": "dolorem",
        "Id": "consequatur",
        "Disposition": "assumenda",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 368
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Torp, Fahey and Thompson",
        "Values": [
          "sunt",
          "est"
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
        "Name": "Torp, Fahey and Thompson",
        "Values": [
          "sunt",
          "est"
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
    "FolderName": "Jenkins Inc and Sons",
    "EmailItemId": 339,
    "AccountId": 737,
    "ReceivedAt": "2003-08-09T02:30:47.2257111+02:00",
    "InReplyTo": null,
    "RepliedAt": "2000-12-14T02:30:47.2257111+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 901
      }
    }
  }
]
```