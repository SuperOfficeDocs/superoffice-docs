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
      "Subject": "fuga",
      "HTMLBody": "rerum",
      "From": null,
      "Sent": "2004-06-07T13:57:12.2311227+02:00",
      "Size": 1000,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "odit",
      "PlainBody": "repellendus",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 321,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Stark-Gislason",
      "EmailItemId": 919,
      "AccountId": 765,
      "ReceivedAt": "2016-02-05T13:57:12.2311227+01:00",
      "InReplyTo": null,
      "RepliedAt": "2008-07-24T13:57:12.2311227+02:00",
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
        "ContactId": 584,
        "ContactName": "Casper-Rippin",
        "PersonId": 259,
        "PersonName": "Monahan-Lakin",
        "AssociateId": 636,
        "Address": "at",
        "EmailId": 429,
        "DuplicatePersonIds": [
          334,
          482
        ],
        "Name": "Baumbach-Hansen",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 447
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 17,
        "ContactName": "Fadel Inc and Sons",
        "PersonId": 603,
        "PersonName": "Weissnat Group",
        "AssociateId": 244,
        "Address": "unde",
        "EmailId": 735,
        "DuplicatePersonIds": [
          802,
          476
        ],
        "Name": "Dibbert Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 118
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 523,
        "ContactName": "Mann Group",
        "PersonId": 110,
        "PersonName": "Cruickshank-Boyer",
        "AssociateId": 345,
        "Address": "eligendi",
        "EmailId": 576,
        "DuplicatePersonIds": [
          765,
          392
        ],
        "Name": "Kulas-Mayert",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 567
          }
        }
      }
    ],
    "Subject": "consectetur",
    "HTMLBody": "quis",
    "From": null,
    "Sent": "2014-08-14T13:57:12.2311227+02:00",
    "Size": 735,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "qui",
    "PlainBody": "in",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 302,
    "Attachments": [
      {
        "Description": "Diverse grid-enabled definition",
        "Filename": "et",
        "Size": 655,
        "Type": "et",
        "Encoding": "consequatur",
        "Id": "et",
        "Disposition": "numquam",
        "IsSafeFileExtension": true,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 628
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Harris, Shanahan and Runolfsdottir",
        "Values": [
          "explicabo",
          "optio"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 667
          }
        }
      },
      {
        "Name": "Harris, Shanahan and Runolfsdottir",
        "Values": [
          "explicabo",
          "optio"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 667
          }
        }
      }
    ],
    "FolderName": "Spencer, Wintheiser and Yundt",
    "EmailItemId": 417,
    "AccountId": 103,
    "ReceivedAt": "2006-02-23T13:57:12.2311227+01:00",
    "InReplyTo": null,
    "RepliedAt": "2023-02-09T13:57:12.2311227+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 606
      }
    }
  }
]
```