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
      "Subject": "ut",
      "HTMLBody": "qui",
      "From": null,
      "Sent": "2017-10-27T14:23:46.4230787+02:00",
      "Size": 698,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "excepturi",
      "PlainBody": "quasi",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 966,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Muller LLC",
      "EmailItemId": 292,
      "AccountId": 29,
      "ReceivedAt": "2019-08-09T14:23:46.4230787+02:00",
      "InReplyTo": null,
      "RepliedAt": "2001-05-03T14:23:46.4230787+02:00",
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
        "ContactId": 793,
        "ContactName": "Larkin-McLaughlin",
        "PersonId": 482,
        "PersonName": "Dicki-Kling",
        "AssociateId": 523,
        "Address": "exercitationem",
        "EmailId": 442,
        "DuplicatePersonIds": [
          519,
          680
        ],
        "Name": "Cummerata Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 174
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 181,
        "ContactName": "Nolan, Schuppe and West",
        "PersonId": 406,
        "PersonName": "Lebsack-Grimes",
        "AssociateId": 60,
        "Address": "ab",
        "EmailId": 230,
        "DuplicatePersonIds": [
          564,
          484
        ],
        "Name": "Kozey-Gutkowski",
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
        "ContactId": 63,
        "ContactName": "Prohaska, Okuneva and D'Amore",
        "PersonId": 409,
        "PersonName": "Mueller-Cummings",
        "AssociateId": 195,
        "Address": "iste",
        "EmailId": 668,
        "DuplicatePersonIds": [
          518,
          101
        ],
        "Name": "Quitzon LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 268
          }
        }
      }
    ],
    "Subject": "et",
    "HTMLBody": "at",
    "From": null,
    "Sent": "2005-06-22T14:23:46.4230787+02:00",
    "Size": 403,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "eos",
    "PlainBody": "alias",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 82,
    "Attachments": [
      {
        "Description": "Realigned well-modulated groupware",
        "Filename": "consequatur",
        "Size": 756,
        "Type": "praesentium",
        "Encoding": "architecto",
        "Id": "est",
        "Disposition": "explicabo",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 681
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Dach Group",
        "Values": [
          "aut",
          "facere"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 628
          }
        }
      },
      {
        "Name": "Dach Group",
        "Values": [
          "aut",
          "facere"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 628
          }
        }
      }
    ],
    "FolderName": "Marks Inc and Sons",
    "EmailItemId": 629,
    "AccountId": 163,
    "ReceivedAt": "1996-11-02T14:23:46.4230787+01:00",
    "InReplyTo": null,
    "RepliedAt": "1998-03-08T14:23:46.4230787+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 817
      }
    }
  }
]
```