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
      "Subject": "officiis",
      "HTMLBody": "tempore",
      "From": null,
      "Sent": "2009-01-27T11:06:34.458307+01:00",
      "Size": 85,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "aperiam",
      "PlainBody": "dolores",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 614,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Stark, Jerde and Batz",
      "EmailItemId": 691,
      "AccountId": 637,
      "ReceivedAt": "2004-07-24T11:06:34.458307+02:00",
      "InReplyTo": null,
      "RepliedAt": "2005-05-28T11:06:34.458307+02:00",
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
        "ContactId": 677,
        "ContactName": "Klein-DuBuque",
        "PersonId": 473,
        "PersonName": "Turcotte LLC",
        "AssociateId": 452,
        "Address": "et",
        "EmailId": 517,
        "DuplicatePersonIds": [
          633,
          960
        ],
        "Name": "O'Conner-Murazik",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 471
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 332,
        "ContactName": "Kohler-Ruecker",
        "PersonId": 567,
        "PersonName": "Dietrich LLC",
        "AssociateId": 847,
        "Address": "consectetur",
        "EmailId": 995,
        "DuplicatePersonIds": [
          920,
          793
        ],
        "Name": "Hirthe-Wiegand",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 595
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 432,
        "ContactName": "Mayert, Kris and Leuschke",
        "PersonId": 715,
        "PersonName": "Schroeder, Parisian and Beahan",
        "AssociateId": 229,
        "Address": "molestias",
        "EmailId": 991,
        "DuplicatePersonIds": [
          994,
          826
        ],
        "Name": "Bayer, Swaniawski and Schultz",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 387
          }
        }
      }
    ],
    "Subject": "qui",
    "HTMLBody": "dolores",
    "From": null,
    "Sent": "2014-02-04T11:06:34.458307+01:00",
    "Size": 38,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "ratione",
    "PlainBody": "voluptatem",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 417,
    "Attachments": [
      {
        "Description": "Re-contextualized grid-enabled focus group",
        "Filename": "temporibus",
        "Size": 290,
        "Type": "deleniti",
        "Encoding": "quia",
        "Id": "commodi",
        "Disposition": "harum",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 697
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Farrell-Gottlieb",
        "Values": [
          "est",
          "veniam"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 809
          }
        }
      },
      {
        "Name": "Farrell-Gottlieb",
        "Values": [
          "est",
          "veniam"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 809
          }
        }
      }
    ],
    "FolderName": "Schuster-Cormier",
    "EmailItemId": 848,
    "AccountId": 643,
    "ReceivedAt": "1999-04-06T11:06:34.458307+02:00",
    "InReplyTo": null,
    "RepliedAt": "2006-02-08T11:06:34.458307+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 732
      }
    }
  }
]
```