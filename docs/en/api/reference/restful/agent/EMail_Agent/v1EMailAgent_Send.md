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
      "Subject": "tenetur",
      "HTMLBody": "corporis",
      "From": null,
      "Sent": "2007-11-08T04:22:26.6709828+01:00",
      "Size": 322,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "cupiditate",
      "PlainBody": "excepturi",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 749,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Marvin, Stamm and Walker",
      "EmailItemId": 145,
      "AccountId": 344,
      "ReceivedAt": "2002-06-18T04:22:26.6709828+02:00",
      "InReplyTo": null,
      "RepliedAt": "2020-12-14T04:22:26.6709828+01:00",
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
        "ContactId": 916,
        "ContactName": "Gulgowski, Heidenreich and Ritchie",
        "PersonId": 227,
        "PersonName": "Funk-Wintheiser",
        "AssociateId": 516,
        "Address": "quia",
        "EmailId": 29,
        "DuplicatePersonIds": [
          766,
          736
        ],
        "Name": "D'Amore-Hegmann",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 422
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 208,
        "ContactName": "Hand LLC",
        "PersonId": 805,
        "PersonName": "Koss Inc and Sons",
        "AssociateId": 864,
        "Address": "rerum",
        "EmailId": 128,
        "DuplicatePersonIds": [
          899,
          610
        ],
        "Name": "Watsica LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 35
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 770,
        "ContactName": "Wiza, Kerluke and Crona",
        "PersonId": 416,
        "PersonName": "Lindgren, Mosciski and Reichel",
        "AssociateId": 194,
        "Address": "voluptatem",
        "EmailId": 152,
        "DuplicatePersonIds": [
          390,
          53
        ],
        "Name": "Swift, Quigley and Lesch",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 786
          }
        }
      }
    ],
    "Subject": "nobis",
    "HTMLBody": "incidunt",
    "From": null,
    "Sent": "2018-08-28T04:22:26.6709828+02:00",
    "Size": 309,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "doloremque",
    "PlainBody": "necessitatibus",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 788,
    "Attachments": [
      {
        "Description": "Assimilated full-range collaboration",
        "Filename": "sit",
        "Size": 939,
        "Type": "commodi",
        "Encoding": "quae",
        "Id": "dolores",
        "Disposition": "assumenda",
        "IsSafeFileExtension": true,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 364
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Wiza Group",
        "Values": [
          "ut",
          "libero"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 525
          }
        }
      },
      {
        "Name": "Wiza Group",
        "Values": [
          "ut",
          "libero"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 525
          }
        }
      }
    ],
    "FolderName": "Flatley-Kshlerin",
    "EmailItemId": 852,
    "AccountId": 406,
    "ReceivedAt": "1997-08-06T04:22:26.686607+02:00",
    "InReplyTo": null,
    "RepliedAt": "2016-02-25T04:22:26.686607+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 362
      }
    }
  }
]
```