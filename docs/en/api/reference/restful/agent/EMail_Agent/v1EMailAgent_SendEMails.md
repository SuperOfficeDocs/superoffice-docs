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
      "Subject": "voluptas",
      "HTMLBody": "neque",
      "From": null,
      "Sent": "2023-06-02T14:13:40.2660122+02:00",
      "Size": 934,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "est",
      "PlainBody": "ut",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 420,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Becker, McDermott and McKenzie",
      "EmailItemId": 453,
      "AccountId": 346,
      "ReceivedAt": "2008-07-21T14:13:40.2660122+02:00",
      "InReplyTo": null,
      "RepliedAt": "2001-10-06T14:13:40.2660122+02:00",
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
        "ContactId": 524,
        "ContactName": "Heathcote LLC",
        "PersonId": 780,
        "PersonName": "Smith Group",
        "AssociateId": 505,
        "Address": "porro",
        "EmailId": 393,
        "DuplicatePersonIds": [
          808,
          908
        ],
        "Name": "Pouros Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 593
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 670,
        "ContactName": "Fay-Haley",
        "PersonId": 787,
        "PersonName": "Bashirian, Metz and Dooley",
        "AssociateId": 915,
        "Address": "natus",
        "EmailId": 931,
        "DuplicatePersonIds": [
          468,
          939
        ],
        "Name": "Corkery-Kutch",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 148
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 31,
        "ContactName": "Baumbach Group",
        "PersonId": 495,
        "PersonName": "Marquardt, Renner and Romaguera",
        "AssociateId": 29,
        "Address": "qui",
        "EmailId": 418,
        "DuplicatePersonIds": [
          459,
          971
        ],
        "Name": "Berge Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 834
          }
        }
      }
    ],
    "Subject": "expedita",
    "HTMLBody": "nisi",
    "From": null,
    "Sent": "2016-04-03T14:13:40.2660122+02:00",
    "Size": 48,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "rem",
    "PlainBody": "aut",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 497,
    "Attachments": [
      {
        "Description": "Assimilated heuristic system engine",
        "Filename": "eius",
        "Size": 728,
        "Type": "quae",
        "Encoding": "eum",
        "Id": "sunt",
        "Disposition": "ut",
        "IsSafeFileExtension": true,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 23
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Koch-Ritchie",
        "Values": [
          "totam",
          "vel"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 586
          }
        }
      },
      {
        "Name": "Koch-Ritchie",
        "Values": [
          "totam",
          "vel"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 586
          }
        }
      }
    ],
    "FolderName": "Kautzer Group",
    "EmailItemId": 301,
    "AccountId": 360,
    "ReceivedAt": "1997-10-15T14:13:40.2660122+02:00",
    "InReplyTo": null,
    "RepliedAt": "2005-11-03T14:13:40.2660122+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 1002
      }
    }
  }
]
```