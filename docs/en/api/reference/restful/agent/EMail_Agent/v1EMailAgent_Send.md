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
      "Subject": "recusandae",
      "HTMLBody": "libero",
      "From": null,
      "Sent": "2019-02-19T17:54:03.0389604+01:00",
      "Size": 859,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "et",
      "PlainBody": "nobis",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 628,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Crona-Prosacco",
      "EmailItemId": 595,
      "AccountId": 459,
      "ReceivedAt": "2012-10-05T17:54:03.0389604+02:00",
      "InReplyTo": null,
      "RepliedAt": "2018-03-21T17:54:03.0389604+01:00",
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
        "ContactId": 771,
        "ContactName": "Tromp, Hessel and Nolan",
        "PersonId": 661,
        "PersonName": "Block-Littel",
        "AssociateId": 836,
        "Address": "maiores",
        "EmailId": 954,
        "DuplicatePersonIds": [
          628,
          141
        ],
        "Name": "White-Lockman",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 916
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 679,
        "ContactName": "Schultz Inc and Sons",
        "PersonId": 725,
        "PersonName": "Stamm, Yost and Watsica",
        "AssociateId": 472,
        "Address": "et",
        "EmailId": 585,
        "DuplicatePersonIds": [
          760,
          997
        ],
        "Name": "Schultz LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 666
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 519,
        "ContactName": "Pagac LLC",
        "PersonId": 42,
        "PersonName": "Luettgen Group",
        "AssociateId": 262,
        "Address": "minima",
        "EmailId": 631,
        "DuplicatePersonIds": [
          61,
          853
        ],
        "Name": "Vandervort Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 560
          }
        }
      }
    ],
    "Subject": "voluptates",
    "HTMLBody": "repudiandae",
    "From": null,
    "Sent": "2025-01-31T17:54:03.0389604+01:00",
    "Size": 635,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "et",
    "PlainBody": "fugiat",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 896,
    "Attachments": [
      {
        "Description": "Persistent local moratorium",
        "Filename": "quia",
        "Size": 767,
        "Type": "voluptas",
        "Encoding": "consequatur",
        "Id": "accusantium",
        "Disposition": "iusto",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 281
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Doyle-Lehner",
        "Values": [
          "officiis",
          "soluta"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 28
          }
        }
      },
      {
        "Name": "Doyle-Lehner",
        "Values": [
          "officiis",
          "soluta"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 28
          }
        }
      }
    ],
    "FolderName": "Haley LLC",
    "EmailItemId": 971,
    "AccountId": 71,
    "ReceivedAt": "2005-07-20T17:54:03.054585+02:00",
    "InReplyTo": null,
    "RepliedAt": "2023-11-15T17:54:03.054585+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 508
      }
    }
  }
]
```