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
      "Subject": "nobis",
      "HTMLBody": "omnis",
      "From": null,
      "Sent": "2006-08-23T03:46:54.707009+02:00",
      "Size": 759,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "temporibus",
      "PlainBody": "dolor",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 369,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Tromp, Douglas and Kessler",
      "EmailItemId": 89,
      "AccountId": 536,
      "ReceivedAt": "2002-06-12T03:46:54.707009+02:00",
      "InReplyTo": null,
      "RepliedAt": "2014-11-15T03:46:54.707009+01:00",
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
        "ContactId": 806,
        "ContactName": "Ernser-Leannon",
        "PersonId": 886,
        "PersonName": "Feest-Bogan",
        "AssociateId": 727,
        "Address": "non",
        "EmailId": 559,
        "DuplicatePersonIds": [
          630,
          955
        ],
        "Name": "Miller-Barton",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 67
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 634,
        "ContactName": "Boehm-Ortiz",
        "PersonId": 728,
        "PersonName": "Schulist-Kub",
        "AssociateId": 619,
        "Address": "natus",
        "EmailId": 424,
        "DuplicatePersonIds": [
          921,
          24
        ],
        "Name": "Cartwright-Klocko",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 836
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 149,
        "ContactName": "Swaniawski-Cummings",
        "PersonId": 597,
        "PersonName": "Grant, Boyle and Gottlieb",
        "AssociateId": 522,
        "Address": "suscipit",
        "EmailId": 473,
        "DuplicatePersonIds": [
          83,
          563
        ],
        "Name": "Nolan, Miller and White",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 784
          }
        }
      }
    ],
    "Subject": "expedita",
    "HTMLBody": "repellat",
    "From": null,
    "Sent": "2006-05-01T03:46:54.707009+02:00",
    "Size": 5,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "itaque",
    "PlainBody": "quia",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 289,
    "Attachments": [
      {
        "Description": "Intuitive stable capacity",
        "Filename": "atque",
        "Size": 164,
        "Type": "eaque",
        "Encoding": "sit",
        "Id": "esse",
        "Disposition": "perferendis",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 287
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Johnson Inc and Sons",
        "Values": [
          "maxime",
          "alias"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 848
          }
        }
      },
      {
        "Name": "Johnson Inc and Sons",
        "Values": [
          "maxime",
          "alias"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 848
          }
        }
      }
    ],
    "FolderName": "Parker Inc and Sons",
    "EmailItemId": 446,
    "AccountId": 134,
    "ReceivedAt": "2020-01-01T03:46:54.707009+01:00",
    "InReplyTo": null,
    "RepliedAt": "2025-05-30T03:46:54.707009+02:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 880
      }
    }
  }
]
```