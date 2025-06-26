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
      "Subject": "asperiores",
      "HTMLBody": "similique",
      "From": null,
      "Sent": "2016-10-14T03:45:23.373582+02:00",
      "Size": 440,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "quod",
      "PlainBody": "accusantium",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 912,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Cruickshank-Schmeler",
      "EmailItemId": 199,
      "AccountId": 164,
      "ReceivedAt": "2018-07-31T03:45:23.373582+02:00",
      "InReplyTo": null,
      "RepliedAt": "2013-06-20T03:45:23.373582+02:00",
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
        "ContactId": 315,
        "ContactName": "Turcotte, Aufderhar and Durgan",
        "PersonId": 842,
        "PersonName": "Russel-Towne",
        "AssociateId": 77,
        "Address": "quo",
        "EmailId": 958,
        "DuplicatePersonIds": [
          568,
          1000
        ],
        "Name": "Gibson, Larson and Dooley",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 753
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 207,
        "ContactName": "Ritchie, Zemlak and Runolfsson",
        "PersonId": 203,
        "PersonName": "Kreiger-Klocko",
        "AssociateId": 811,
        "Address": "quis",
        "EmailId": 427,
        "DuplicatePersonIds": [
          2,
          696
        ],
        "Name": "Runte-Zulauf",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 700
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 104,
        "ContactName": "Funk-Witting",
        "PersonId": 673,
        "PersonName": "Rice, Terry and Hettinger",
        "AssociateId": 616,
        "Address": "molestiae",
        "EmailId": 263,
        "DuplicatePersonIds": [
          762,
          944
        ],
        "Name": "Haley-Koelpin",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 801
          }
        }
      }
    ],
    "Subject": "assumenda",
    "HTMLBody": "reiciendis",
    "From": null,
    "Sent": "2012-11-01T03:45:23.373582+01:00",
    "Size": 132,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "minima",
    "PlainBody": "dolorem",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 761,
    "Attachments": [
      {
        "Description": "Innovative encompassing solution",
        "Filename": "qui",
        "Size": 398,
        "Type": "consequuntur",
        "Encoding": "minus",
        "Id": "veniam",
        "Disposition": "dolore",
        "IsSafeFileExtension": true,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 344
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Heller-Orn",
        "Values": [
          "est",
          "quas"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 272
          }
        }
      },
      {
        "Name": "Heller-Orn",
        "Values": [
          "est",
          "quas"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 272
          }
        }
      }
    ],
    "FolderName": "Rogahn-Ullrich",
    "EmailItemId": 156,
    "AccountId": 324,
    "ReceivedAt": "2001-04-10T03:45:23.373582+02:00",
    "InReplyTo": null,
    "RepliedAt": "2003-10-21T03:45:23.373582+02:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 270
      }
    }
  }
]
```