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
      "Subject": "praesentium",
      "HTMLBody": "qui",
      "From": null,
      "Sent": "2015-08-12T13:28:22.6323326+02:00",
      "Size": 201,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "animi",
      "PlainBody": "vel",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 898,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Barton-Kreiger",
      "EmailItemId": 5,
      "AccountId": 530,
      "ReceivedAt": "2007-05-15T13:28:22.6323326+02:00",
      "InReplyTo": null,
      "RepliedAt": "2002-02-08T13:28:22.6323326+01:00",
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
        "ContactId": 38,
        "ContactName": "Daniel LLC",
        "PersonId": 81,
        "PersonName": "Wunsch, Zboncak and Kiehn",
        "AssociateId": 190,
        "Address": "sunt",
        "EmailId": 131,
        "DuplicatePersonIds": [
          846,
          889
        ],
        "Name": "Friesen, Daniel and Rowe",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 760
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 784,
        "ContactName": "Wiegand-Gleason",
        "PersonId": 554,
        "PersonName": "Douglas Inc and Sons",
        "AssociateId": 576,
        "Address": "et",
        "EmailId": 858,
        "DuplicatePersonIds": [
          762,
          305
        ],
        "Name": "Schroeder, Smith and Cormier",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 778
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 669,
        "ContactName": "Jenkins, Cassin and Krajcik",
        "PersonId": 711,
        "PersonName": "Koelpin, Abbott and Yundt",
        "AssociateId": 415,
        "Address": "eaque",
        "EmailId": 593,
        "DuplicatePersonIds": [
          559,
          224
        ],
        "Name": "Russel LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 926
          }
        }
      }
    ],
    "Subject": "distinctio",
    "HTMLBody": "molestiae",
    "From": null,
    "Sent": "1999-05-13T13:28:22.6323326+02:00",
    "Size": 148,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "necessitatibus",
    "PlainBody": "est",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 887,
    "Attachments": [
      {
        "Description": "Object-based 3rd generation installation",
        "Filename": "mollitia",
        "Size": 828,
        "Type": "voluptatem",
        "Encoding": "voluptas",
        "Id": "quibusdam",
        "Disposition": "est",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 105
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Blick Inc and Sons",
        "Values": [
          "iusto",
          "numquam"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 111
          }
        }
      },
      {
        "Name": "Blick Inc and Sons",
        "Values": [
          "iusto",
          "numquam"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 111
          }
        }
      }
    ],
    "FolderName": "McDermott Group",
    "EmailItemId": 390,
    "AccountId": 273,
    "ReceivedAt": "2010-04-17T13:28:22.6323326+02:00",
    "InReplyTo": null,
    "RepliedAt": "2016-03-21T13:28:22.6323326+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 58
      }
    }
  }
]
```