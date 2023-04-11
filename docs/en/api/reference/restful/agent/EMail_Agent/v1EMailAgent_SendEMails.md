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
      "Subject": "quasi",
      "HTMLBody": "id",
      "From": null,
      "Sent": "2018-08-06T15:29:21.7697754+02:00",
      "Size": 101,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "ipsum",
      "PlainBody": "voluptates",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 936,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Abshire, Frami and Feil",
      "EmailItemId": 121,
      "AccountId": 339,
      "ReceivedAt": "1998-05-16T15:29:21.7697754+02:00",
      "InReplyTo": null,
      "RepliedAt": "1999-10-17T15:29:21.7697754+02:00",
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
        "ContactId": 287,
        "ContactName": "Rosenbaum Group",
        "PersonId": 550,
        "PersonName": "McGlynn Group",
        "AssociateId": 263,
        "Address": "id",
        "EmailId": 562,
        "DuplicatePersonIds": [
          962,
          445
        ],
        "Name": "Mraz LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 960
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 802,
        "ContactName": "Durgan-Hand",
        "PersonId": 245,
        "PersonName": "Gaylord LLC",
        "AssociateId": 119,
        "Address": "quis",
        "EmailId": 610,
        "DuplicatePersonIds": [
          891,
          228
        ],
        "Name": "Walsh Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 442
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 874,
        "ContactName": "Johnston Inc and Sons",
        "PersonId": 546,
        "PersonName": "Wyman, Spencer and Schaefer",
        "AssociateId": 589,
        "Address": "asperiores",
        "EmailId": 618,
        "DuplicatePersonIds": [
          321,
          13
        ],
        "Name": "Hyatt-Monahan",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 960
          }
        }
      }
    ],
    "Subject": "labore",
    "HTMLBody": "quia",
    "From": null,
    "Sent": "2009-08-20T15:29:21.7727752+02:00",
    "Size": 408,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "facilis",
    "PlainBody": "cupiditate",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 371,
    "Attachments": [
      {
        "Description": "Compatible neutral structure",
        "Filename": "praesentium",
        "Size": 881,
        "Type": "quasi",
        "Encoding": "ullam",
        "Id": "est",
        "Disposition": "tempore",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 611
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Funk LLC",
        "Values": [
          "in",
          "maiores"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 437
          }
        }
      },
      {
        "Name": "Funk LLC",
        "Values": [
          "in",
          "maiores"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 437
          }
        }
      }
    ],
    "FolderName": "Buckridge Group",
    "EmailItemId": 201,
    "AccountId": 312,
    "ReceivedAt": "2012-01-20T15:29:21.7732762+01:00",
    "InReplyTo": null,
    "RepliedAt": "2010-04-17T15:29:21.7732762+02:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 329
      }
    }
  }
]
```