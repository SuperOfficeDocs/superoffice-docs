---
title: POST Agents/EMail/SendEMails
uid: v1EMailAgent_SendEMails
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/EMail/SendEMails
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
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
      "Subject": "facilis",
      "HTMLBody": "commodi",
      "From": null,
      "Sent": "2021-09-07T14:19:03.4508967+02:00",
      "Size": 388,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "sunt",
      "PlainBody": "quia",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 132,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Williamson Group",
      "EmailItemId": 301,
      "AccountId": 90,
      "ReceivedAt": "2016-08-03T14:19:03.4508967+02:00",
      "InReplyTo": null,
      "RepliedAt": "2003-12-11T14:19:03.4508967+01:00",
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
        "ContactId": 298,
        "ContactName": "Wolf-Von",
        "PersonId": 965,
        "PersonName": "Mraz-Armstrong",
        "AssociateId": 977,
        "Address": "repellendus",
        "EmailId": 52,
        "DuplicatePersonIds": [
          588,
          232
        ],
        "Name": "Jacobson-Murphy",
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
    "Cc": [
      {
        "ContactId": 976,
        "ContactName": "Runte Group",
        "PersonId": 64,
        "PersonName": "Funk LLC",
        "AssociateId": 485,
        "Address": "pariatur",
        "EmailId": 344,
        "DuplicatePersonIds": [
          101,
          767
        ],
        "Name": "Goyette, Kulas and Cormier",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 382
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 904,
        "ContactName": "Gleichner Group",
        "PersonId": 525,
        "PersonName": "Mann-Hartmann",
        "AssociateId": 481,
        "Address": "sunt",
        "EmailId": 394,
        "DuplicatePersonIds": [
          256,
          157
        ],
        "Name": "DuBuque LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 563
          }
        }
      }
    ],
    "Subject": "ut",
    "HTMLBody": "omnis",
    "From": null,
    "Sent": "2006-08-31T14:19:03.4508967+02:00",
    "Size": 253,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "vel",
    "PlainBody": "amet",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 381,
    "Attachments": [
      {
        "Description": "Secured radical service-desk",
        "Filename": "est",
        "Size": 683,
        "Type": "quia",
        "Encoding": "numquam",
        "Id": "quia",
        "Disposition": "rerum",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 165
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Emard, Bogan and Gerhold",
        "Values": [
          "quia",
          "vel"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 533
          }
        }
      },
      {
        "Name": "Emard, Bogan and Gerhold",
        "Values": [
          "quia",
          "vel"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 533
          }
        }
      }
    ],
    "FolderName": "Farrell-Wolff",
    "EmailItemId": 360,
    "AccountId": 384,
    "ReceivedAt": "2002-07-28T14:19:03.4508967+02:00",
    "InReplyTo": null,
    "RepliedAt": "2015-11-11T14:19:03.4508967+01:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 479
      }
    }
  }
]
```