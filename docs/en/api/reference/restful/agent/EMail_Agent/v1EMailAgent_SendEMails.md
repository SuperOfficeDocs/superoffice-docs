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
      "Subject": "non",
      "HTMLBody": "aliquid",
      "From": null,
      "Sent": "2013-09-05T11:16:09.2097228+02:00",
      "Size": 543,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "molestias",
      "PlainBody": "ea",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 595,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Ortiz, Grant and Stokes",
      "EmailItemId": 900,
      "AccountId": 833,
      "ReceivedAt": "2020-04-06T11:16:09.2097228+02:00",
      "InReplyTo": null,
      "RepliedAt": "2009-12-19T11:16:09.2097228+01:00",
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
        "ContactId": 280,
        "ContactName": "Boyle Group",
        "PersonId": 689,
        "PersonName": "Gottlieb-Goodwin",
        "AssociateId": 310,
        "Address": "officia",
        "EmailId": 331,
        "DuplicatePersonIds": [
          994,
          132
        ],
        "Name": "Marks-Schroeder",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 385
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 634,
        "ContactName": "Larson, Vandervort and Wolf",
        "PersonId": 856,
        "PersonName": "Gulgowski-Breitenberg",
        "AssociateId": 937,
        "Address": "sunt",
        "EmailId": 999,
        "DuplicatePersonIds": [
          346,
          128
        ],
        "Name": "Borer-Anderson",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 161
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 618,
        "ContactName": "McLaughlin, White and Swaniawski",
        "PersonId": 370,
        "PersonName": "Hamill Group",
        "AssociateId": 92,
        "Address": "quas",
        "EmailId": 572,
        "DuplicatePersonIds": [
          599,
          876
        ],
        "Name": "Will LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 728
          }
        }
      }
    ],
    "Subject": "est",
    "HTMLBody": "delectus",
    "From": null,
    "Sent": "2024-03-26T11:16:09.2097228+01:00",
    "Size": 199,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "repellat",
    "PlainBody": "ex",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 405,
    "Attachments": [
      {
        "Description": "Sharable system-worthy frame",
        "Filename": "aspernatur",
        "Size": 966,
        "Type": "non",
        "Encoding": "dolor",
        "Id": "sed",
        "Disposition": "blanditiis",
        "IsSafeFileExtension": true,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 674
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Paucek Group",
        "Values": [
          "libero",
          "est"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 171
          }
        }
      },
      {
        "Name": "Paucek Group",
        "Values": [
          "libero",
          "est"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 171
          }
        }
      }
    ],
    "FolderName": "Jacobi Group",
    "EmailItemId": 141,
    "AccountId": 93,
    "ReceivedAt": "2022-10-06T11:16:09.2097228+02:00",
    "InReplyTo": null,
    "RepliedAt": "2006-01-06T11:16:09.2097228+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 257
      }
    }
  }
]
```