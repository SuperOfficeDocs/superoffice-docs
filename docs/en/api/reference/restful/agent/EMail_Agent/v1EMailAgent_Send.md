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
      "Subject": "enim",
      "HTMLBody": "minus",
      "From": null,
      "Sent": "2011-12-20T23:03:55.8701376+01:00",
      "Size": 756,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "voluptas",
      "PlainBody": "repellat",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 30,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Torp Inc and Sons",
      "EmailItemId": 193,
      "AccountId": 934,
      "ReceivedAt": "1999-01-02T23:03:55.8701376+01:00",
      "InReplyTo": null,
      "RepliedAt": "2021-06-07T23:03:55.8701376+02:00",
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
        "ContactId": 420,
        "ContactName": "Daugherty-Sipes",
        "PersonId": 965,
        "PersonName": "Kuphal-Hauck",
        "AssociateId": 810,
        "Address": "maxime",
        "EmailId": 228,
        "DuplicatePersonIds": [
          606,
          523
        ],
        "Name": "Beahan-Pollich",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 296
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 984,
        "ContactName": "Crist, Mayert and Heaney",
        "PersonId": 439,
        "PersonName": "Glover-Howe",
        "AssociateId": 135,
        "Address": "minus",
        "EmailId": 545,
        "DuplicatePersonIds": [
          553,
          836
        ],
        "Name": "Gutkowski, Lang and Price",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 561
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 761,
        "ContactName": "Emard-Funk",
        "PersonId": 262,
        "PersonName": "Terry, Abshire and Osinski",
        "AssociateId": 98,
        "Address": "ut",
        "EmailId": 855,
        "DuplicatePersonIds": [
          628,
          46
        ],
        "Name": "Lindgren Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 879
          }
        }
      }
    ],
    "Subject": "quo",
    "HTMLBody": "et",
    "From": null,
    "Sent": "2012-11-10T23:03:55.8721428+01:00",
    "Size": 953,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "aliquid",
    "PlainBody": "vero",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 599,
    "Attachments": [
      {
        "Description": "Distributed radical Graphical User Interface",
        "Filename": "ab",
        "Size": 792,
        "Type": "deserunt",
        "Encoding": "nam",
        "Id": "repellat",
        "Disposition": "recusandae",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 492
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Ernser, Leuschke and Glover",
        "Values": [
          "voluptatum",
          "unde"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 794
          }
        }
      },
      {
        "Name": "Ernser, Leuschke and Glover",
        "Values": [
          "voluptatum",
          "unde"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 794
          }
        }
      }
    ],
    "FolderName": "Hahn, Beier and Yost",
    "EmailItemId": 878,
    "AccountId": 689,
    "ReceivedAt": "2020-08-30T23:03:55.8726304+02:00",
    "InReplyTo": null,
    "RepliedAt": "2017-09-30T23:03:55.8726304+02:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 903
      }
    }
  }
]
```