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
Accept-Language: en
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
      "Subject": "earum",
      "HTMLBody": "quaerat",
      "From": null,
      "Sent": "2005-03-06T13:38:13.5614895+01:00",
      "Size": 751,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "temporibus",
      "PlainBody": "nam",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 3,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Reilly Inc and Sons",
      "EmailItemId": 766,
      "AccountId": 79,
      "ReceivedAt": "2008-02-21T13:38:13.5614895+01:00",
      "InReplyTo": null,
      "RepliedAt": "1999-08-02T13:38:13.5614895+02:00",
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
        "ContactId": 282,
        "ContactName": "Wisozk, Wisoky and Turner",
        "PersonId": 35,
        "PersonName": "O'Conner Group",
        "AssociateId": 432,
        "Address": "odio",
        "EmailId": 474,
        "DuplicatePersonIds": [
          152,
          721
        ],
        "Name": "Kling Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 291
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 248,
        "ContactName": "Zulauf-Fahey",
        "PersonId": 648,
        "PersonName": "Marquardt Inc and Sons",
        "AssociateId": 325,
        "Address": "aliquid",
        "EmailId": 778,
        "DuplicatePersonIds": [
          109,
          914
        ],
        "Name": "Upton-Purdy",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 806
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 710,
        "ContactName": "VonRueden, Pouros and Ward",
        "PersonId": 392,
        "PersonName": "Hickle Group",
        "AssociateId": 171,
        "Address": "eum",
        "EmailId": 579,
        "DuplicatePersonIds": [
          686,
          410
        ],
        "Name": "Okuneva, Lang and Towne",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 915
          }
        }
      }
    ],
    "Subject": "reprehenderit",
    "HTMLBody": "culpa",
    "From": null,
    "Sent": "2022-10-09T13:38:13.5614895+02:00",
    "Size": 523,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "doloremque",
    "PlainBody": "dolore",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 682,
    "Attachments": [
      {
        "Description": "Adaptive multi-tasking alliance",
        "Filename": "beatae",
        "Size": 624,
        "Type": "enim",
        "Encoding": "praesentium",
        "Id": "sit",
        "Disposition": "aspernatur",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 249
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Hilll, Tillman and Satterfield",
        "Values": [
          "laudantium",
          "sunt"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 993
          }
        }
      },
      {
        "Name": "Hilll, Tillman and Satterfield",
        "Values": [
          "laudantium",
          "sunt"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 993
          }
        }
      }
    ],
    "FolderName": "Fisher, Collier and Harvey",
    "EmailItemId": 413,
    "AccountId": 578,
    "ReceivedAt": "2017-11-23T13:38:13.5614895+01:00",
    "InReplyTo": null,
    "RepliedAt": "2002-05-22T13:38:13.5614895+02:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 422
      }
    }
  }
]
```