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
      "Subject": "laboriosam",
      "HTMLBody": "dolorem",
      "From": null,
      "Sent": "2002-01-15T13:13:22.9302583+01:00",
      "Size": 223,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "minima",
      "PlainBody": "molestiae",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 258,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Dibbert-Lemke",
      "EmailItemId": 490,
      "AccountId": 718,
      "ReceivedAt": "2008-08-11T13:13:22.9302583+02:00",
      "InReplyTo": null,
      "RepliedAt": "2017-03-07T13:13:22.9302583+01:00",
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
        "ContactId": 568,
        "ContactName": "Turcotte Inc and Sons",
        "PersonId": 257,
        "PersonName": "Huels Group",
        "AssociateId": 891,
        "Address": "autem",
        "EmailId": 571,
        "DuplicatePersonIds": [
          958,
          131
        ],
        "Name": "Leuschke Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 668
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 571,
        "ContactName": "Powlowski, Dare and Mertz",
        "PersonId": 40,
        "PersonName": "Trantow Inc and Sons",
        "AssociateId": 4,
        "Address": "voluptas",
        "EmailId": 439,
        "DuplicatePersonIds": [
          393,
          916
        ],
        "Name": "Reichel Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 631
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 408,
        "ContactName": "Willms-Franecki",
        "PersonId": 402,
        "PersonName": "Rohan, Lakin and Anderson",
        "AssociateId": 624,
        "Address": "ipsa",
        "EmailId": 183,
        "DuplicatePersonIds": [
          950,
          751
        ],
        "Name": "O'Reilly-Mosciski",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 328
          }
        }
      }
    ],
    "Subject": "iure",
    "HTMLBody": "officiis",
    "From": null,
    "Sent": "2009-10-06T13:13:22.9302583+02:00",
    "Size": 854,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "rerum",
    "PlainBody": "quia",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 612,
    "Attachments": [
      {
        "Description": "Phased real-time parallelism",
        "Filename": "a",
        "Size": 19,
        "Type": "optio",
        "Encoding": "fugit",
        "Id": "quia",
        "Disposition": "pariatur",
        "IsSafeFileExtension": true,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 276
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Trantow-Breitenberg",
        "Values": [
          "debitis",
          "qui"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 851
          }
        }
      },
      {
        "Name": "Trantow-Breitenberg",
        "Values": [
          "debitis",
          "qui"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 851
          }
        }
      }
    ],
    "FolderName": "Champlin Inc and Sons",
    "EmailItemId": 972,
    "AccountId": 871,
    "ReceivedAt": "2006-05-18T13:13:22.9302583+02:00",
    "InReplyTo": null,
    "RepliedAt": "2004-08-17T13:13:22.9302583+02:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 346
      }
    }
  }
]
```