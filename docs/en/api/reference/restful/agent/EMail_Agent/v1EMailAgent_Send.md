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
Accept-Language: fr,de,ru,zh
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
      "Subject": "accusamus",
      "HTMLBody": "nesciunt",
      "From": null,
      "Sent": "2020-07-17T03:51:27.1623664+02:00",
      "Size": 78,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "alias",
      "PlainBody": "officiis",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 407,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Carter Inc and Sons",
      "EmailItemId": 547,
      "AccountId": 804,
      "ReceivedAt": "2012-10-15T03:51:27.1623664+02:00",
      "InReplyTo": null,
      "RepliedAt": "2020-10-08T03:51:27.1623664+02:00",
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
        "ContactId": 188,
        "ContactName": "Towne, Muller and Buckridge",
        "PersonId": 710,
        "PersonName": "Collins LLC",
        "AssociateId": 462,
        "Address": "commodi",
        "EmailId": 545,
        "DuplicatePersonIds": [
          888,
          829
        ],
        "Name": "Ebert Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 867
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 769,
        "ContactName": "Waelchi-Bins",
        "PersonId": 796,
        "PersonName": "Cronin LLC",
        "AssociateId": 487,
        "Address": "veritatis",
        "EmailId": 864,
        "DuplicatePersonIds": [
          480,
          990
        ],
        "Name": "Haley-Terry",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 128
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 632,
        "ContactName": "O'Conner LLC",
        "PersonId": 730,
        "PersonName": "Balistreri Inc and Sons",
        "AssociateId": 451,
        "Address": "optio",
        "EmailId": 72,
        "DuplicatePersonIds": [
          343,
          696
        ],
        "Name": "Tillman, O'Kon and Nitzsche",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 891
          }
        }
      }
    ],
    "Subject": "veniam",
    "HTMLBody": "sapiente",
    "From": null,
    "Sent": "2021-12-11T03:51:27.1623664+01:00",
    "Size": 950,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "aut",
    "PlainBody": "occaecati",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 589,
    "Attachments": [
      {
        "Description": "User-friendly coherent initiative",
        "Filename": "voluptatem",
        "Size": 500,
        "Type": "soluta",
        "Encoding": "iste",
        "Id": "quas",
        "Disposition": "voluptas",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 259
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Zemlak-Gottlieb",
        "Values": [
          "nemo",
          "reiciendis"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 92
          }
        }
      },
      {
        "Name": "Zemlak-Gottlieb",
        "Values": [
          "nemo",
          "reiciendis"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 92
          }
        }
      }
    ],
    "FolderName": "Oberbrunner, Koepp and Lang",
    "EmailItemId": 621,
    "AccountId": 495,
    "ReceivedAt": "2022-09-05T03:51:27.1623664+02:00",
    "InReplyTo": null,
    "RepliedAt": "2016-12-29T03:51:27.1623664+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 238
      }
    }
  }
]
```