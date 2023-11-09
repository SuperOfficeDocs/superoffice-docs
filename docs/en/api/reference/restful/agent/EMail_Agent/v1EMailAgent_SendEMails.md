---
title: POST Agents/EMail/SendEMails
uid: v1EMailAgent_SendEMails
generated: true
---

# POST Agents/EMail/SendEMails

```http
POST /api/v1/Agents/EMail/SendEMails
```

Send the provided e-mails


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/SendEMails?$select=name,department,category/id
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

OutgoingConnectionInfo, Emails, SentItemsConnectionInfo 

| Property Name | Type |  Description |
|----------------|------|--------------|
| OutgoingConnectionInfo | EMailConnectionInfo | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
| Emails | Array |  |
| SentItemsConnectionInfo | EMailConnectionInfo | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |

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
POST /api/v1/Agents/EMail/SendEMails
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "OutgoingConnectionInfo": null,
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
      "Subject": "eos",
      "HTMLBody": "delectus",
      "From": null,
      "Sent": "2014-05-05T11:06:34.5208161+02:00",
      "Size": 628,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "vel",
      "PlainBody": "est",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 858,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Schuster-Moore",
      "EmailItemId": 443,
      "AccountId": 569,
      "ReceivedAt": "2004-10-15T11:06:34.5208161+02:00",
      "InReplyTo": null,
      "RepliedAt": "2013-08-29T11:06:34.5208161+02:00",
      "HasCalendarData": false,
      "CalMethod": "Add",
      "CalReplyStatus": "Accepted"
    }
  ],
  "SentItemsConnectionInfo": null
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
        "ContactId": 566,
        "ContactName": "Gleason-Hills",
        "PersonId": 360,
        "PersonName": "Koch LLC",
        "AssociateId": 630,
        "Address": "in",
        "EmailId": 742,
        "DuplicatePersonIds": [
          346,
          784
        ],
        "Name": "Braun-Hudson",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 201
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 849,
        "ContactName": "Wehner Group",
        "PersonId": 794,
        "PersonName": "Bauch Inc and Sons",
        "AssociateId": 405,
        "Address": "est",
        "EmailId": 659,
        "DuplicatePersonIds": [
          787,
          607
        ],
        "Name": "Pfannerstill-Kling",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 155
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 917,
        "ContactName": "Gutkowski-Hintz",
        "PersonId": 305,
        "PersonName": "Sawayn, Von and Hand",
        "AssociateId": 724,
        "Address": "atque",
        "EmailId": 303,
        "DuplicatePersonIds": [
          617,
          492
        ],
        "Name": "Jones-Durgan",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 886
          }
        }
      }
    ],
    "Subject": "delectus",
    "HTMLBody": "dolore",
    "From": null,
    "Sent": "2009-11-03T11:06:34.5208161+01:00",
    "Size": 578,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "amet",
    "PlainBody": "sed",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 41,
    "Attachments": [
      {
        "Description": "Up-sized bottom-line monitoring",
        "Filename": "iste",
        "Size": 268,
        "Type": "culpa",
        "Encoding": "blanditiis",
        "Id": "fugit",
        "Disposition": "dolorem",
        "IsSafeFileExtension": true,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 376
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Feeney-Halvorson",
        "Values": [
          "ut",
          "est"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 175
          }
        }
      },
      {
        "Name": "Feeney-Halvorson",
        "Values": [
          "ut",
          "est"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 175
          }
        }
      }
    ],
    "FolderName": "Conn Inc and Sons",
    "EmailItemId": 1000,
    "AccountId": 544,
    "ReceivedAt": "2002-07-16T11:06:34.5208161+02:00",
    "InReplyTo": null,
    "RepliedAt": "2021-03-22T11:06:34.5208161+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 391
      }
    }
  }
]
```