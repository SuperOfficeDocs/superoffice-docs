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
      "Subject": "nihil",
      "HTMLBody": "exercitationem",
      "From": null,
      "Sent": "2014-03-17T12:19:45.2266504+01:00",
      "Size": 759,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "dolorem",
      "PlainBody": "suscipit",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 682,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Rowe-Kub",
      "EmailItemId": 737,
      "AccountId": 959,
      "ReceivedAt": "2009-09-24T12:19:45.2266504+02:00",
      "InReplyTo": null,
      "RepliedAt": "1996-11-16T12:19:45.2266504+01:00",
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
        "ContactId": 252,
        "ContactName": "Stokes, Treutel and Breitenberg",
        "PersonId": 664,
        "PersonName": "Krajcik-Schaden",
        "AssociateId": 259,
        "Address": "magni",
        "EmailId": 906,
        "DuplicatePersonIds": [
          158,
          492
        ],
        "Name": "Gottlieb-Conroy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 80
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 275,
        "ContactName": "Nitzsche-Shanahan",
        "PersonId": 546,
        "PersonName": "Kuhic, Kuhic and Bruen",
        "AssociateId": 936,
        "Address": "sunt",
        "EmailId": 702,
        "DuplicatePersonIds": [
          360,
          490
        ],
        "Name": "Kovacek Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 496
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 375,
        "ContactName": "Jacobson-Hauck",
        "PersonId": 467,
        "PersonName": "Breitenberg LLC",
        "AssociateId": 169,
        "Address": "quo",
        "EmailId": 937,
        "DuplicatePersonIds": [
          636,
          781
        ],
        "Name": "Gerhold, Nicolas and Buckridge",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 251
          }
        }
      }
    ],
    "Subject": "alias",
    "HTMLBody": "voluptas",
    "From": null,
    "Sent": "2001-09-30T12:19:45.2266504+02:00",
    "Size": 422,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "veritatis",
    "PlainBody": "voluptatum",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 589,
    "Attachments": [
      {
        "Description": "Customer-focused assymetric functionalities",
        "Filename": "ipsum",
        "Size": 714,
        "Type": "excepturi",
        "Encoding": "voluptate",
        "Id": "ab",
        "Disposition": "et",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 692
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Wiza LLC",
        "Values": [
          "sit",
          "dolor"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 322
          }
        }
      },
      {
        "Name": "Wiza LLC",
        "Values": [
          "sit",
          "dolor"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 322
          }
        }
      }
    ],
    "FolderName": "Rippin, Schowalter and Wolf",
    "EmailItemId": 829,
    "AccountId": 954,
    "ReceivedAt": "2007-11-22T12:19:45.2266504+01:00",
    "InReplyTo": null,
    "RepliedAt": "2013-11-21T12:19:45.2266504+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 488
      }
    }
  }
]
```