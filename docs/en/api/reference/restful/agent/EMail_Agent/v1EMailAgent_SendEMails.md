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
      "Subject": "repellendus",
      "HTMLBody": "perspiciatis",
      "From": null,
      "Sent": "2018-09-27T16:32:39.0239176+02:00",
      "Size": 685,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "nulla",
      "PlainBody": "voluptatibus",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 952,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Carter-Kovacek",
      "EmailItemId": 800,
      "AccountId": 201,
      "ReceivedAt": "2008-04-12T16:32:39.0239176+02:00",
      "InReplyTo": null,
      "RepliedAt": "2011-10-07T16:32:39.0239176+02:00",
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
        "ContactId": 853,
        "ContactName": "Howe-Wolff",
        "PersonId": 674,
        "PersonName": "Cremin, Wolf and Halvorson",
        "AssociateId": 899,
        "Address": "omnis",
        "EmailId": 362,
        "DuplicatePersonIds": [
          39,
          50
        ],
        "Name": "Waters LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 500
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 162,
        "ContactName": "Heidenreich-Mayert",
        "PersonId": 358,
        "PersonName": "Ratke LLC",
        "AssociateId": 498,
        "Address": "iste",
        "EmailId": 976,
        "DuplicatePersonIds": [
          149,
          557
        ],
        "Name": "Streich Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 408
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 800,
        "ContactName": "Johns Group",
        "PersonId": 525,
        "PersonName": "Kutch LLC",
        "AssociateId": 339,
        "Address": "repellendus",
        "EmailId": 6,
        "DuplicatePersonIds": [
          489,
          809
        ],
        "Name": "Fahey, Daugherty and Kiehn",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 810
          }
        }
      }
    ],
    "Subject": "quia",
    "HTMLBody": "odio",
    "From": null,
    "Sent": "2011-10-29T16:32:39.0239176+02:00",
    "Size": 17,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "veniam",
    "PlainBody": "id",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 596,
    "Attachments": [
      {
        "Description": "Triple-buffered clear-thinking adapter",
        "Filename": "totam",
        "Size": 147,
        "Type": "illum",
        "Encoding": "voluptatem",
        "Id": "et",
        "Disposition": "qui",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 979
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Aufderhar, Gorczany and Gibson",
        "Values": [
          "aliquam",
          "ad"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 147
          }
        }
      },
      {
        "Name": "Aufderhar, Gorczany and Gibson",
        "Values": [
          "aliquam",
          "ad"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 147
          }
        }
      }
    ],
    "FolderName": "Murazik Group",
    "EmailItemId": 207,
    "AccountId": 262,
    "ReceivedAt": "1999-11-22T16:32:39.0395385+01:00",
    "InReplyTo": null,
    "RepliedAt": "1999-07-05T16:32:39.0395385+02:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 753
      }
    }
  }
]
```