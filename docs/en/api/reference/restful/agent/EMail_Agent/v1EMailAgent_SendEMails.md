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
Accept-Language: sv
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
      "Subject": "qui",
      "HTMLBody": "quas",
      "From": null,
      "Sent": "2023-04-17T12:19:45.3047627+02:00",
      "Size": 216,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "odio",
      "PlainBody": "eius",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 478,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Anderson Group",
      "EmailItemId": 441,
      "AccountId": 445,
      "ReceivedAt": "2020-08-22T12:19:45.3047627+02:00",
      "InReplyTo": null,
      "RepliedAt": "2001-01-20T12:19:45.3047627+01:00",
      "HasCalendarData": true,
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
        "ContactId": 44,
        "ContactName": "Rutherford LLC",
        "PersonId": 230,
        "PersonName": "Hintz-Hilpert",
        "AssociateId": 572,
        "Address": "dignissimos",
        "EmailId": 642,
        "DuplicatePersonIds": [
          735,
          138
        ],
        "Name": "Lakin-Schimmel",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 893
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 517,
        "ContactName": "Howell-Lang",
        "PersonId": 847,
        "PersonName": "Prosacco Inc and Sons",
        "AssociateId": 833,
        "Address": "quia",
        "EmailId": 226,
        "DuplicatePersonIds": [
          295,
          952
        ],
        "Name": "Veum LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 496
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 4,
        "ContactName": "Langosh, Gislason and Lang",
        "PersonId": 39,
        "PersonName": "Bradtke LLC",
        "AssociateId": 635,
        "Address": "ut",
        "EmailId": 828,
        "DuplicatePersonIds": [
          79,
          444
        ],
        "Name": "Prohaska LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 413
          }
        }
      }
    ],
    "Subject": "aliquam",
    "HTMLBody": "perferendis",
    "From": null,
    "Sent": "2015-06-23T12:19:45.3047627+02:00",
    "Size": 390,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "minus",
    "PlainBody": "voluptas",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 802,
    "Attachments": [
      {
        "Description": "Innovative high-level leverage",
        "Filename": "eaque",
        "Size": 313,
        "Type": "inventore",
        "Encoding": "praesentium",
        "Id": "et",
        "Disposition": "qui",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 117
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Renner, Kessler and Champlin",
        "Values": [
          "labore",
          "itaque"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 787
          }
        }
      },
      {
        "Name": "Renner, Kessler and Champlin",
        "Values": [
          "labore",
          "itaque"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 787
          }
        }
      }
    ],
    "FolderName": "Reichert, Pacocha and Veum",
    "EmailItemId": 21,
    "AccountId": 318,
    "ReceivedAt": "2008-12-14T12:19:45.3047627+01:00",
    "InReplyTo": null,
    "RepliedAt": "2020-10-24T12:19:45.3047627+02:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 274
      }
    }
  }
]
```