---
title: POST Agents/EMail/Send
uid: v1EMailAgent_Send
---

# POST Agents/EMail/Send

```http
POST /api/v1/Agents/EMail/Send
```

Send the provided e-mails

## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered

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
| Emails | array |  |

## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| To | array | To recipients of e-mail |
| Cc | array | Cc recipients of e-mail |
| Bcc | array | Bcc recipient of e-mail |
| Subject | string | Subject of the e-mail |
| HTMLBody | string | Body formatted in HTML |
| From |  | Who did the e-mail originate from |
| Sent | date-time | When was the e-mail sent |
| Size | int32 | Total size of the e-mail |
| Priority | string | Importance of the e-mail |
| Flags | string | Flag status of this mail (unread, replied, deleted ) |
| MessageID | string | Unique id of e-mails |
| PlainBody | string | Body formatted in plain text |
| IsSent | bool | Is this a sent e-mail (not new) |
| EMailSOInfo |  | Glue between SuperOffice data and an e-mail. |
| ServerId | int32 | Unique id for the e-mail on the server |
| Attachments | array |  |
| CustomHeaderList | array | Non standard e-mail headers |
| FolderName | string | Name of folder the e-mail belongs in |
| EmailItemId | int32 | Primary key |
| AccountId | int32 | Account Id |
| ReceivedAt | date-time | Received date time |
| InReplyTo |  | The envelope of the email this email is a reply to, if it exists |
| RepliedAt | date-time | When this email was replied at |
| HasCalendarData | bool | If this email contains exactly one iCal appointment |
| CalMethod | string | Method stored in the associated iCal appointment. Indicates if the iCal data is a reply, counter proposal etc. |
| CalReplyStatus | string | Reply status stored in calendar data for the ical method is REPLY |
| TableRight |  |  |
| FieldProperties | object |  |

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
      "Subject": "aut",
      "HTMLBody": "et",
      "From": null,
      "Sent": "2001-04-14T11:10:26.8414523+02:00",
      "Size": 902,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "ipsa",
      "PlainBody": "ipsum",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 306,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Kutch-Hickle",
      "EmailItemId": 118,
      "AccountId": 488,
      "ReceivedAt": "2004-12-26T11:10:26.8414523+01:00",
      "InReplyTo": null,
      "RepliedAt": "2009-08-19T11:10:26.8414523+02:00",
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
        "ContactId": 925,
        "ContactName": "Hirthe Inc and Sons",
        "PersonId": 881,
        "PersonName": "Purdy-O'Conner",
        "AssociateId": 728,
        "Address": "maiores",
        "EmailId": 307,
        "DuplicatePersonIds": [
          829,
          252
        ],
        "Name": "Wintheiser Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 456
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 357,
        "ContactName": "Nolan Inc and Sons",
        "PersonId": 530,
        "PersonName": "Hahn LLC",
        "AssociateId": 760,
        "Address": "deserunt",
        "EmailId": 851,
        "DuplicatePersonIds": [
          890,
          777
        ],
        "Name": "Reichert, Turcotte and Huels",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 151
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 256,
        "ContactName": "Walker Group",
        "PersonId": 756,
        "PersonName": "Nienow, Beier and Jones",
        "AssociateId": 759,
        "Address": "magni",
        "EmailId": 699,
        "DuplicatePersonIds": [
          362,
          654
        ],
        "Name": "Waters Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 684
          }
        }
      }
    ],
    "Subject": "cumque",
    "HTMLBody": "adipisci",
    "From": null,
    "Sent": "2019-02-05T11:10:26.8434537+01:00",
    "Size": 157,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "sit",
    "PlainBody": "excepturi",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 49,
    "Attachments": [
      {
        "Description": "Profound foreground interface",
        "Filename": "incidunt",
        "Size": 620,
        "Type": "sapiente",
        "Encoding": "quia",
        "Id": "adipisci",
        "Disposition": "a",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 998
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Fadel LLC",
        "Values": [
          "tenetur",
          "suscipit"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 703
          }
        }
      },
      {
        "Name": "Fadel LLC",
        "Values": [
          "tenetur",
          "suscipit"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 703
          }
        }
      }
    ],
    "FolderName": "Satterfield, Haley and Anderson",
    "EmailItemId": 365,
    "AccountId": 92,
    "ReceivedAt": "2013-09-30T11:10:26.8444526+02:00",
    "InReplyTo": null,
    "RepliedAt": "2005-03-04T11:10:26.8444526+01:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 876
      }
    }
  }
]
```
