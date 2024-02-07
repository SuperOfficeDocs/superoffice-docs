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
      "Subject": "ratione",
      "HTMLBody": "id",
      "From": null,
      "Sent": "2012-01-06T16:54:55.2964193+01:00",
      "Size": 66,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "maxime",
      "PlainBody": "provident",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 436,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Jaskolski, Ryan and Harber",
      "EmailItemId": 560,
      "AccountId": 64,
      "ReceivedAt": "2021-12-12T16:54:55.2964193+01:00",
      "InReplyTo": null,
      "RepliedAt": "2016-12-27T16:54:55.2964193+01:00",
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
        "ContactId": 1002,
        "ContactName": "Denesik Inc and Sons",
        "PersonId": 459,
        "PersonName": "Hickle Group",
        "AssociateId": 830,
        "Address": "incidunt",
        "EmailId": 346,
        "DuplicatePersonIds": [
          504,
          706
        ],
        "Name": "Carter Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 755
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 247,
        "ContactName": "Sporer, O'Reilly and Wyman",
        "PersonId": 660,
        "PersonName": "Stokes, Jacobs and Marks",
        "AssociateId": 880,
        "Address": "hic",
        "EmailId": 135,
        "DuplicatePersonIds": [
          699,
          761
        ],
        "Name": "Rutherford-Bergnaum",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 290
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 940,
        "ContactName": "Hane LLC",
        "PersonId": 137,
        "PersonName": "Bins, Schroeder and Franecki",
        "AssociateId": 434,
        "Address": "est",
        "EmailId": 209,
        "DuplicatePersonIds": [
          579,
          658
        ],
        "Name": "Mayer, Klein and Leuschke",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 498
          }
        }
      }
    ],
    "Subject": "aut",
    "HTMLBody": "labore",
    "From": null,
    "Sent": "2007-08-07T16:54:55.2984192+02:00",
    "Size": 880,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "pariatur",
    "PlainBody": "rerum",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 987,
    "Attachments": [
      {
        "Description": "Versatile client-server moderator",
        "Filename": "sint",
        "Size": 544,
        "Type": "laboriosam",
        "Encoding": "et",
        "Id": "velit",
        "Disposition": "quia",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 171
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Koss, Gerlach and Blick",
        "Values": [
          "culpa",
          "facere"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 217
          }
        }
      },
      {
        "Name": "Koss, Gerlach and Blick",
        "Values": [
          "culpa",
          "facere"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 217
          }
        }
      }
    ],
    "FolderName": "McKenzie-Kshlerin",
    "EmailItemId": 671,
    "AccountId": 55,
    "ReceivedAt": "2015-07-06T16:54:55.2994192+02:00",
    "InReplyTo": null,
    "RepliedAt": "2016-08-28T16:54:55.2994192+02:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 128
      }
    }
  }
]
```