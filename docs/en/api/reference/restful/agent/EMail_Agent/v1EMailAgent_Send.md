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
      "Subject": "consectetur",
      "HTMLBody": "voluptas",
      "From": null,
      "Sent": "1996-10-07T03:31:26.401997+02:00",
      "Size": 425,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "alias",
      "PlainBody": "dolores",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 247,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Conn-Cummerata",
      "EmailItemId": 336,
      "AccountId": 89,
      "ReceivedAt": "2021-05-20T03:31:26.401997+02:00",
      "InReplyTo": null,
      "RepliedAt": "2004-06-05T03:31:26.401997+02:00",
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
        "ContactId": 146,
        "ContactName": "Quigley Group",
        "PersonId": 207,
        "PersonName": "Ankunding, Hettinger and VonRueden",
        "AssociateId": 902,
        "Address": "perferendis",
        "EmailId": 616,
        "DuplicatePersonIds": [
          995,
          445
        ],
        "Name": "Parisian LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 354
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 989,
        "ContactName": "Schowalter-Larkin",
        "PersonId": 416,
        "PersonName": "Effertz, Reichert and Schimmel",
        "AssociateId": 761,
        "Address": "perferendis",
        "EmailId": 453,
        "DuplicatePersonIds": [
          77,
          688
        ],
        "Name": "Jacobi-Nicolas",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 450
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 424,
        "ContactName": "Leuschke, Cremin and Gusikowski",
        "PersonId": 641,
        "PersonName": "Botsford-Cormier",
        "AssociateId": 448,
        "Address": "et",
        "EmailId": 232,
        "DuplicatePersonIds": [
          522,
          717
        ],
        "Name": "Bauch LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 313
          }
        }
      }
    ],
    "Subject": "totam",
    "HTMLBody": "libero",
    "From": null,
    "Sent": "2005-12-21T03:31:26.4176181+01:00",
    "Size": 545,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "ex",
    "PlainBody": "possimus",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 921,
    "Attachments": [
      {
        "Description": "Robust stable forecast",
        "Filename": "a",
        "Size": 681,
        "Type": "consequatur",
        "Encoding": "porro",
        "Id": "alias",
        "Disposition": "vel",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 629
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Kuhlman, Collier and Gibson",
        "Values": [
          "quam",
          "odit"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 644
          }
        }
      },
      {
        "Name": "Kuhlman, Collier and Gibson",
        "Values": [
          "quam",
          "odit"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 644
          }
        }
      }
    ],
    "FolderName": "Okuneva-Lockman",
    "EmailItemId": 992,
    "AccountId": 99,
    "ReceivedAt": "2017-01-03T03:31:26.4176181+01:00",
    "InReplyTo": null,
    "RepliedAt": "2013-05-24T03:31:26.4176181+02:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 42
      }
    }
  }
]
```