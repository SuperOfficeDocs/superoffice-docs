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
      "Subject": "a",
      "HTMLBody": "minus",
      "From": null,
      "Sent": "2008-08-07T13:38:13.5146196+02:00",
      "Size": 950,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "modi",
      "PlainBody": "vero",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 151,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Stanton, Jones and Volkman",
      "EmailItemId": 690,
      "AccountId": 415,
      "ReceivedAt": "1999-07-03T13:38:13.5146196+02:00",
      "InReplyTo": null,
      "RepliedAt": "2009-09-23T13:38:13.5146196+02:00",
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
        "ContactId": 868,
        "ContactName": "Kuhic-Paucek",
        "PersonId": 859,
        "PersonName": "Abshire-Stanton",
        "AssociateId": 693,
        "Address": "labore",
        "EmailId": 633,
        "DuplicatePersonIds": [
          811,
          745
        ],
        "Name": "Parisian Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 219
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 830,
        "ContactName": "Turner-Rohan",
        "PersonId": 208,
        "PersonName": "Kub-Roob",
        "AssociateId": 567,
        "Address": "est",
        "EmailId": 182,
        "DuplicatePersonIds": [
          484,
          400
        ],
        "Name": "Wintheiser, Collins and Trantow",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 459
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 53,
        "ContactName": "DuBuque-Watsica",
        "PersonId": 533,
        "PersonName": "Yost LLC",
        "AssociateId": 236,
        "Address": "est",
        "EmailId": 587,
        "DuplicatePersonIds": [
          480,
          511
        ],
        "Name": "Batz, Treutel and Ledner",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 299
          }
        }
      }
    ],
    "Subject": "cupiditate",
    "HTMLBody": "id",
    "From": null,
    "Sent": "2023-07-21T13:38:13.5146196+02:00",
    "Size": 794,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "et",
    "PlainBody": "ducimus",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 508,
    "Attachments": [
      {
        "Description": "Universal cohesive artificial intelligence",
        "Filename": "ut",
        "Size": 977,
        "Type": "fugiat",
        "Encoding": "earum",
        "Id": "sed",
        "Disposition": "veniam",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 416
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Lueilwitz-Beatty",
        "Values": [
          "debitis",
          "molestiae"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 341
          }
        }
      },
      {
        "Name": "Lueilwitz-Beatty",
        "Values": [
          "debitis",
          "molestiae"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 341
          }
        }
      }
    ],
    "FolderName": "Cole, Dickinson and Hauck",
    "EmailItemId": 254,
    "AccountId": 718,
    "ReceivedAt": "2000-11-11T13:38:13.5146196+01:00",
    "InReplyTo": null,
    "RepliedAt": "2010-12-08T13:38:13.5146196+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 352
      }
    }
  }
]
```