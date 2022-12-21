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
      "Subject": "magnam",
      "HTMLBody": "autem",
      "From": null,
      "Sent": "2018-06-01T02:49:44.3566372+02:00",
      "Size": 459,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "dolores",
      "PlainBody": "ipsum",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 764,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Erdman, McDermott and Walter",
      "EmailItemId": 405,
      "AccountId": 228,
      "ReceivedAt": "2001-09-26T02:49:44.3566372+02:00",
      "InReplyTo": null,
      "RepliedAt": "2009-11-20T02:49:44.3566372+01:00",
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
        "ContactId": 586,
        "ContactName": "Robel-Bayer",
        "PersonId": 941,
        "PersonName": "Abshire Inc and Sons",
        "AssociateId": 897,
        "Address": "ut",
        "EmailId": 203,
        "DuplicatePersonIds": [
          346,
          704
        ],
        "Name": "Purdy-Schaden",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 337
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 155,
        "ContactName": "Larkin-Kertzmann",
        "PersonId": 385,
        "PersonName": "Thompson-Mann",
        "AssociateId": 555,
        "Address": "aut",
        "EmailId": 798,
        "DuplicatePersonIds": [
          244,
          721
        ],
        "Name": "Murphy, Kiehn and Corkery",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 675
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 847,
        "ContactName": "Jones-Cronin",
        "PersonId": 511,
        "PersonName": "Terry-Cartwright",
        "AssociateId": 239,
        "Address": "exercitationem",
        "EmailId": 658,
        "DuplicatePersonIds": [
          397,
          529
        ],
        "Name": "Haag, Murazik and Osinski",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 914
          }
        }
      }
    ],
    "Subject": "a",
    "HTMLBody": "eos",
    "From": null,
    "Sent": "2000-06-15T02:49:44.3722628+02:00",
    "Size": 682,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "eligendi",
    "PlainBody": "neque",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 825,
    "Attachments": [
      {
        "Description": "Secured fault-tolerant array",
        "Filename": "ut",
        "Size": 326,
        "Type": "labore",
        "Encoding": "et",
        "Id": "nulla",
        "Disposition": "voluptate",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 666
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Bins-Adams",
        "Values": [
          "dolorem",
          "sint"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 720
          }
        }
      },
      {
        "Name": "Bins-Adams",
        "Values": [
          "dolorem",
          "sint"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 720
          }
        }
      }
    ],
    "FolderName": "Turcotte, Konopelski and Gulgowski",
    "EmailItemId": 84,
    "AccountId": 178,
    "ReceivedAt": "2004-12-17T02:49:44.3722628+01:00",
    "InReplyTo": null,
    "RepliedAt": "2022-01-28T02:49:44.3722628+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 927
      }
    }
  }
]
```