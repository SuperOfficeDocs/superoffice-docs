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
      "Subject": "est",
      "HTMLBody": "est",
      "From": null,
      "Sent": "2012-08-24T04:22:26.7491153+02:00",
      "Size": 965,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "minima",
      "PlainBody": "qui",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 506,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Marvin, Gislason and Quigley",
      "EmailItemId": 450,
      "AccountId": 710,
      "ReceivedAt": "2002-12-01T04:22:26.7491153+01:00",
      "InReplyTo": null,
      "RepliedAt": "2024-01-09T04:22:26.7491153+01:00",
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
        "ContactId": 253,
        "ContactName": "McCullough, Lesch and O'Connell",
        "PersonId": 853,
        "PersonName": "Ruecker Inc and Sons",
        "AssociateId": 549,
        "Address": "in",
        "EmailId": 604,
        "DuplicatePersonIds": [
          389,
          10
        ],
        "Name": "Witting Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 421
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 704,
        "ContactName": "Okuneva LLC",
        "PersonId": 92,
        "PersonName": "Schroeder Group",
        "AssociateId": 455,
        "Address": "maiores",
        "EmailId": 451,
        "DuplicatePersonIds": [
          248,
          731
        ],
        "Name": "Towne Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 137
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 518,
        "ContactName": "Hamill, Batz and McKenzie",
        "PersonId": 35,
        "PersonName": "Weimann, Howell and Bauch",
        "AssociateId": 32,
        "Address": "nesciunt",
        "EmailId": 301,
        "DuplicatePersonIds": [
          164,
          889
        ],
        "Name": "Murphy Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 900
          }
        }
      }
    ],
    "Subject": "veniam",
    "HTMLBody": "qui",
    "From": null,
    "Sent": "2001-04-04T04:22:26.7491153+02:00",
    "Size": 304,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "veritatis",
    "PlainBody": "quo",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 448,
    "Attachments": [
      {
        "Description": "Advanced incremental internet solution",
        "Filename": "enim",
        "Size": 375,
        "Type": "in",
        "Encoding": "aliquid",
        "Id": "repellat",
        "Disposition": "non",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 85
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Senger, Murray and Goldner",
        "Values": [
          "mollitia",
          "neque"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 415
          }
        }
      },
      {
        "Name": "Senger, Murray and Goldner",
        "Values": [
          "mollitia",
          "neque"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 415
          }
        }
      }
    ],
    "FolderName": "Padberg LLC",
    "EmailItemId": 899,
    "AccountId": 205,
    "ReceivedAt": "2011-10-01T04:22:26.7491153+02:00",
    "InReplyTo": null,
    "RepliedAt": "2016-01-18T04:22:26.7491153+01:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 598
      }
    }
  }
]
```