---
title: POST Agents/EMail/Send
uid: v1EMailAgent_Send
generated: true
content_type: reference
---

# POST Agents/EMail/Send

```http
POST /api/v1/Agents/EMail/Send
```

Send the provided e-mails


NsApiSlow threshold: 5000 ms.


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
      "Subject": "fuga",
      "HTMLBody": "voluptatibus",
      "From": null,
      "Sent": "2009-12-11T03:40:46.7498885+01:00",
      "Size": 287,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "quia",
      "PlainBody": "dolore",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 456,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Moen Group",
      "EmailItemId": 371,
      "AccountId": 167,
      "ReceivedAt": "2015-03-11T03:40:46.7498885+01:00",
      "InReplyTo": null,
      "RepliedAt": "2017-06-29T03:40:46.7498885+02:00",
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
        "ContactId": 164,
        "ContactName": "Yundt, Steuber and Schmidt",
        "PersonId": 790,
        "PersonName": "Gutmann, Moen and Reinger",
        "AssociateId": 870,
        "Address": "corrupti",
        "EmailId": 692,
        "DuplicatePersonIds": [
          268,
          472
        ],
        "Name": "Blanda, Feil and Hessel",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 311
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 428,
        "ContactName": "Osinski, Davis and Johnson",
        "PersonId": 408,
        "PersonName": "Ruecker Group",
        "AssociateId": 869,
        "Address": "qui",
        "EmailId": 65,
        "DuplicatePersonIds": [
          54,
          182
        ],
        "Name": "Friesen Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 782
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 854,
        "ContactName": "Kuphal Group",
        "PersonId": 535,
        "PersonName": "Skiles, Romaguera and Orn",
        "AssociateId": 547,
        "Address": "sit",
        "EmailId": 989,
        "DuplicatePersonIds": [
          33,
          377
        ],
        "Name": "Schultz Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 907
          }
        }
      }
    ],
    "Subject": "vel",
    "HTMLBody": "perferendis",
    "From": null,
    "Sent": "2010-12-16T03:40:46.7655146+01:00",
    "Size": 24,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "incidunt",
    "PlainBody": "voluptatem",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 89,
    "Attachments": [
      {
        "Description": "Optional mission-critical Graphic Interface",
        "Filename": "perspiciatis",
        "Size": 737,
        "Type": "aperiam",
        "Encoding": "perspiciatis",
        "Id": "explicabo",
        "Disposition": "eveniet",
        "IsSafeFileExtension": true,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 372
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Ebert-Boyle",
        "Values": [
          "cumque",
          "voluptate"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 607
          }
        }
      },
      {
        "Name": "Ebert-Boyle",
        "Values": [
          "cumque",
          "voluptate"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 607
          }
        }
      }
    ],
    "FolderName": "Prohaska, Gusikowski and Ullrich",
    "EmailItemId": 395,
    "AccountId": 56,
    "ReceivedAt": "2000-07-03T03:40:46.7655146+02:00",
    "InReplyTo": null,
    "RepliedAt": "2008-10-11T03:40:46.7655146+02:00",
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