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
      "Subject": "error",
      "HTMLBody": "enim",
      "From": null,
      "Sent": "2023-12-05T03:44:52.527125+01:00",
      "Size": 847,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "rem",
      "PlainBody": "rem",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 803,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Jewess Group",
      "EmailItemId": 152,
      "AccountId": 734,
      "ReceivedAt": "2004-12-12T03:44:52.527125+01:00",
      "InReplyTo": null,
      "RepliedAt": "2005-09-23T03:44:52.527125+02:00",
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
        "ContactId": 15,
        "ContactName": "Heller LLC",
        "PersonId": 665,
        "PersonName": "Satterfield-Cremin",
        "AssociateId": 318,
        "Address": "veritatis",
        "EmailId": 633,
        "DuplicatePersonIds": [
          309,
          923
        ],
        "Name": "Klein, Glover and Rath",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 35
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 383,
        "ContactName": "Kihn-Kihn",
        "PersonId": 112,
        "PersonName": "Satterfield Inc and Sons",
        "AssociateId": 388,
        "Address": "porro",
        "EmailId": 649,
        "DuplicatePersonIds": [
          249,
          508
        ],
        "Name": "Dickens LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 924
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 762,
        "ContactName": "Corkery LLC",
        "PersonId": 863,
        "PersonName": "Leannon, Gusikowski and Bergnaum",
        "AssociateId": 440,
        "Address": "rerum",
        "EmailId": 937,
        "DuplicatePersonIds": [
          201,
          217
        ],
        "Name": "Jacobson-Bogan",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 322
          }
        }
      }
    ],
    "Subject": "magni",
    "HTMLBody": "laboriosam",
    "From": null,
    "Sent": "2000-11-06T03:44:52.527125+01:00",
    "Size": 948,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "et",
    "PlainBody": "quo",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 591,
    "Attachments": [
      {
        "Description": "Vision-oriented methodical concept",
        "Filename": "quo",
        "Size": 315,
        "Type": "ea",
        "Encoding": "ea",
        "Id": "provident",
        "Disposition": "delectus",
        "IsSafeFileExtension": true,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 925
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Haag, Cummings and Harber",
        "Values": [
          "voluptatum",
          "ut"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 572
          }
        }
      },
      {
        "Name": "Haag, Cummings and Harber",
        "Values": [
          "voluptatum",
          "ut"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 572
          }
        }
      }
    ],
    "FolderName": "Durgan-Rosenbaum",
    "EmailItemId": 971,
    "AccountId": 410,
    "ReceivedAt": "2005-02-23T03:44:52.527125+01:00",
    "InReplyTo": null,
    "RepliedAt": "2019-05-30T03:44:52.527125+02:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 118
      }
    }
  }
]
```