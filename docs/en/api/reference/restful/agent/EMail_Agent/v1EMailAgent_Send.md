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
Accept-Language: fr,de,ru,zh
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
      "Subject": "ea",
      "HTMLBody": "molestias",
      "From": null,
      "Sent": "2013-11-12T02:38:21.3232921+01:00",
      "Size": 717,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "ullam",
      "PlainBody": "dolor",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 582,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Murazik LLC",
      "EmailItemId": 326,
      "AccountId": 806,
      "ReceivedAt": "2003-04-20T02:38:21.3232921+02:00",
      "InReplyTo": null,
      "RepliedAt": "2003-08-08T02:38:21.3232921+02:00",
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
        "ContactId": 403,
        "ContactName": "Reichel Group",
        "PersonId": 2,
        "PersonName": "Rolfson-Jakubowski",
        "AssociateId": 381,
        "Address": "est",
        "EmailId": 311,
        "DuplicatePersonIds": [
          879,
          613
        ],
        "Name": "Heathcote-Gottlieb",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 805
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 840,
        "ContactName": "Wisoky-Schaefer",
        "PersonId": 562,
        "PersonName": "Ankunding, Dickens and Gutkowski",
        "AssociateId": 589,
        "Address": "veritatis",
        "EmailId": 933,
        "DuplicatePersonIds": [
          20,
          66
        ],
        "Name": "Durgan LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 46
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 733,
        "ContactName": "Thompson-Adams",
        "PersonId": 562,
        "PersonName": "Gleichner Group",
        "AssociateId": 406,
        "Address": "vero",
        "EmailId": 737,
        "DuplicatePersonIds": [
          292,
          254
        ],
        "Name": "Bernhard-Haag",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 204
          }
        }
      }
    ],
    "Subject": "nobis",
    "HTMLBody": "aliquam",
    "From": null,
    "Sent": "2020-01-04T02:38:21.3232921+01:00",
    "Size": 154,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "nam",
    "PlainBody": "inventore",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 876,
    "Attachments": [
      {
        "Description": "Down-sized object-oriented structure",
        "Filename": "facilis",
        "Size": 296,
        "Type": "cupiditate",
        "Encoding": "non",
        "Id": "et",
        "Disposition": "aut",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 669
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Vandervort-Labadie",
        "Values": [
          "nostrum",
          "veritatis"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 416
          }
        }
      },
      {
        "Name": "Vandervort-Labadie",
        "Values": [
          "nostrum",
          "veritatis"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 416
          }
        }
      }
    ],
    "FolderName": "McDermott Group",
    "EmailItemId": 59,
    "AccountId": 893,
    "ReceivedAt": "2011-09-19T02:38:21.3232921+02:00",
    "InReplyTo": null,
    "RepliedAt": "2022-05-27T02:38:21.3232921+02:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 222
      }
    }
  }
]
```