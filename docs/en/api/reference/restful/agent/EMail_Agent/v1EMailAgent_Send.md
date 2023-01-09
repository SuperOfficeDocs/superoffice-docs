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
| TableRight | TableRight |  |
| FieldProperties | object |  |

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
      "Subject": "placeat",
      "HTMLBody": "dolores",
      "From": null,
      "Sent": "2000-07-14T17:37:17.8562447+02:00",
      "Size": 591,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "tempore",
      "PlainBody": "ipsam",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 949,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Heaney Inc and Sons",
      "EmailItemId": 224,
      "AccountId": 588,
      "ReceivedAt": "2001-04-25T17:37:17.8562447+02:00",
      "InReplyTo": null,
      "RepliedAt": "2001-03-11T17:37:17.8562447+01:00",
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
        "ContactId": 626,
        "ContactName": "Gusikowski-Kulas",
        "PersonId": 593,
        "PersonName": "Heathcote-Hamill",
        "AssociateId": 934,
        "Address": "delectus",
        "EmailId": 814,
        "DuplicatePersonIds": [
          709,
          649
        ],
        "Name": "Walker, Lindgren and Towne",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 806
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 250,
        "ContactName": "Kunde, Kuphal and Hoppe",
        "PersonId": 13,
        "PersonName": "Legros LLC",
        "AssociateId": 306,
        "Address": "cumque",
        "EmailId": 195,
        "DuplicatePersonIds": [
          45,
          532
        ],
        "Name": "Johnston Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 500
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 273,
        "ContactName": "Hansen, Trantow and Hoeger",
        "PersonId": 752,
        "PersonName": "Bernier-Goodwin",
        "AssociateId": 320,
        "Address": "atque",
        "EmailId": 892,
        "DuplicatePersonIds": [
          378,
          955
        ],
        "Name": "Hegmann-Schmeler",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 902
          }
        }
      }
    ],
    "Subject": "alias",
    "HTMLBody": "earum",
    "From": null,
    "Sent": "1999-09-19T17:37:17.8582446+02:00",
    "Size": 429,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "unde",
    "PlainBody": "laudantium",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 609,
    "Attachments": [
      {
        "Description": "Decentralized interactive product",
        "Filename": "reprehenderit",
        "Size": 519,
        "Type": "dolor",
        "Encoding": "et",
        "Id": "vel",
        "Disposition": "excepturi",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 609
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Brekke LLC",
        "Values": [
          "ut",
          "aspernatur"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 537
          }
        }
      },
      {
        "Name": "Brekke LLC",
        "Values": [
          "ut",
          "aspernatur"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 537
          }
        }
      }
    ],
    "FolderName": "Vandervort LLC",
    "EmailItemId": 548,
    "AccountId": 168,
    "ReceivedAt": "2021-02-17T17:37:17.8592428+01:00",
    "InReplyTo": null,
    "RepliedAt": "2020-03-28T17:37:17.8592428+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 124
      }
    }
  }
]
```