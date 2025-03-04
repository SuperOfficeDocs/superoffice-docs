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
      "Subject": "assumenda",
      "HTMLBody": "earum",
      "From": null,
      "Sent": "2011-06-19T14:13:40.1566615+02:00",
      "Size": 563,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "ipsam",
      "PlainBody": "ad",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 923,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "O'Reilly-Terry",
      "EmailItemId": 306,
      "AccountId": 790,
      "ReceivedAt": "2001-02-22T14:13:40.1566615+01:00",
      "InReplyTo": null,
      "RepliedAt": "2016-04-29T14:13:40.1566615+02:00",
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
        "ContactId": 352,
        "ContactName": "Waters, Lubowitz and Weimann",
        "PersonId": 650,
        "PersonName": "O'Keefe-Zulauf",
        "AssociateId": 635,
        "Address": "quos",
        "EmailId": 103,
        "DuplicatePersonIds": [
          314,
          431
        ],
        "Name": "Erdman, Schoen and McLaughlin",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 733
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 379,
        "ContactName": "Kovacek-Kohler",
        "PersonId": 118,
        "PersonName": "Crist-Glover",
        "AssociateId": 49,
        "Address": "officia",
        "EmailId": 290,
        "DuplicatePersonIds": [
          253,
          554
        ],
        "Name": "Nicolas, Weimann and Hilpert",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 536
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 390,
        "ContactName": "Kertzmann, Marks and Dietrich",
        "PersonId": 470,
        "PersonName": "Emmerich-Corwin",
        "AssociateId": 781,
        "Address": "harum",
        "EmailId": 340,
        "DuplicatePersonIds": [
          81,
          514
        ],
        "Name": "Halvorson-Vandervort",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 316
          }
        }
      }
    ],
    "Subject": "voluptatem",
    "HTMLBody": "omnis",
    "From": null,
    "Sent": "2016-01-12T14:13:40.1722829+01:00",
    "Size": 219,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "temporibus",
    "PlainBody": "et",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 655,
    "Attachments": [
      {
        "Description": "Object-based upward-trending structure",
        "Filename": "omnis",
        "Size": 738,
        "Type": "et",
        "Encoding": "nihil",
        "Id": "nemo",
        "Disposition": "a",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 445
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Kozey-Adams",
        "Values": [
          "qui",
          "ut"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 233
          }
        }
      },
      {
        "Name": "Kozey-Adams",
        "Values": [
          "qui",
          "ut"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 233
          }
        }
      }
    ],
    "FolderName": "Crona Inc and Sons",
    "EmailItemId": 234,
    "AccountId": 574,
    "ReceivedAt": "2024-10-18T14:13:40.1722829+02:00",
    "InReplyTo": null,
    "RepliedAt": "1999-06-30T14:13:40.1722829+02:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 365
      }
    }
  }
]
```