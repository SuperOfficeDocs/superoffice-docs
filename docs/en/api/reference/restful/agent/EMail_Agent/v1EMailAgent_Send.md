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
      "Subject": "doloribus",
      "HTMLBody": "reprehenderit",
      "From": null,
      "Sent": "2019-12-27T11:16:09.1628538+01:00",
      "Size": 317,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "repellendus",
      "PlainBody": "molestias",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 214,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Koepp-Mueller",
      "EmailItemId": 776,
      "AccountId": 266,
      "ReceivedAt": "2010-11-23T11:16:09.1628538+01:00",
      "InReplyTo": null,
      "RepliedAt": "2011-07-20T11:16:09.1628538+02:00",
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
        "ContactId": 617,
        "ContactName": "Hirthe, Tromp and Schaefer",
        "PersonId": 404,
        "PersonName": "Farrell-O'Connell",
        "AssociateId": 74,
        "Address": "dolores",
        "EmailId": 336,
        "DuplicatePersonIds": [
          51,
          217
        ],
        "Name": "Mitchell-Paucek",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 379
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 86,
        "ContactName": "Larkin-Beahan",
        "PersonId": 801,
        "PersonName": "Corkery Inc and Sons",
        "AssociateId": 271,
        "Address": "pariatur",
        "EmailId": 832,
        "DuplicatePersonIds": [
          28,
          27
        ],
        "Name": "Harris-Botsford",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 692
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 985,
        "ContactName": "Hermann-Luettgen",
        "PersonId": 139,
        "PersonName": "Koelpin-Dickens",
        "AssociateId": 467,
        "Address": "harum",
        "EmailId": 35,
        "DuplicatePersonIds": [
          870,
          793
        ],
        "Name": "Rempel Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 788
          }
        }
      }
    ],
    "Subject": "doloribus",
    "HTMLBody": "voluptate",
    "From": null,
    "Sent": "2001-06-27T11:16:09.1628538+02:00",
    "Size": 625,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "ut",
    "PlainBody": "eveniet",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 830,
    "Attachments": [
      {
        "Description": "Quality-focused modular internet solution",
        "Filename": "libero",
        "Size": 109,
        "Type": "enim",
        "Encoding": "voluptate",
        "Id": "facilis",
        "Disposition": "illum",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 532
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Emmerich LLC",
        "Values": [
          "id",
          "voluptatem"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 808
          }
        }
      },
      {
        "Name": "Emmerich LLC",
        "Values": [
          "id",
          "voluptatem"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 808
          }
        }
      }
    ],
    "FolderName": "Gibson, Kreiger and Anderson",
    "EmailItemId": 204,
    "AccountId": 924,
    "ReceivedAt": "2020-08-24T11:16:09.1628538+02:00",
    "InReplyTo": null,
    "RepliedAt": "1997-07-20T11:16:09.1628538+02:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 283
      }
    }
  }
]
```