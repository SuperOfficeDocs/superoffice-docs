---
title: POST Agents/EMail/Send
uid: v1EMailAgent_Send
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
      "Subject": "ea",
      "HTMLBody": "sit",
      "From": null,
      "Sent": "2010-06-02T15:29:21.6823128+02:00",
      "Size": 928,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "aut",
      "PlainBody": "tempora",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 96,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Bayer Inc and Sons",
      "EmailItemId": 149,
      "AccountId": 565,
      "ReceivedAt": "2020-01-31T15:29:21.6823128+01:00",
      "InReplyTo": null,
      "RepliedAt": "2011-12-21T15:29:21.6823128+01:00",
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
        "ContactId": 620,
        "ContactName": "Hansen, Stokes and Erdman",
        "PersonId": 262,
        "PersonName": "Fisher-Turner",
        "AssociateId": 784,
        "Address": "cum",
        "EmailId": 28,
        "DuplicatePersonIds": [
          529,
          708
        ],
        "Name": "Yundt-Macejkovic",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 135
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 104,
        "ContactName": "Schamberger, Franecki and Flatley",
        "PersonId": 449,
        "PersonName": "Purdy-Klocko",
        "AssociateId": 58,
        "Address": "minus",
        "EmailId": 799,
        "DuplicatePersonIds": [
          780,
          40
        ],
        "Name": "Corkery-Mante",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 688
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 179,
        "ContactName": "Osinski LLC",
        "PersonId": 889,
        "PersonName": "Considine-Brekke",
        "AssociateId": 351,
        "Address": "quis",
        "EmailId": 989,
        "DuplicatePersonIds": [
          16,
          821
        ],
        "Name": "Grady-Runolfsson",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 468
          }
        }
      }
    ],
    "Subject": "aut",
    "HTMLBody": "sunt",
    "From": null,
    "Sent": "2002-10-27T15:29:21.6843128+01:00",
    "Size": 593,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "voluptatem",
    "PlainBody": "incidunt",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 667,
    "Attachments": [
      {
        "Description": "Optional radical matrices",
        "Filename": "pariatur",
        "Size": 355,
        "Type": "optio",
        "Encoding": "esse",
        "Id": "consequatur",
        "Disposition": "corporis",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 862
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Crooks LLC",
        "Values": [
          "eos",
          "laborum"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 525
          }
        }
      },
      {
        "Name": "Crooks LLC",
        "Values": [
          "eos",
          "laborum"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 525
          }
        }
      }
    ],
    "FolderName": "Nitzsche Inc and Sons",
    "EmailItemId": 82,
    "AccountId": 277,
    "ReceivedAt": "2019-01-11T15:29:21.6853147+01:00",
    "InReplyTo": null,
    "RepliedAt": "2015-01-24T15:29:21.6853147+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 468
      }
    }
  }
]
```