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
      "HTMLBody": "quam",
      "From": null,
      "Sent": "2014-05-15T03:44:52.5896202+02:00",
      "Size": 941,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "laudantium",
      "PlainBody": "doloribus",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 649,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Braun, Hudson and Smitham",
      "EmailItemId": 796,
      "AccountId": 200,
      "ReceivedAt": "2000-07-18T03:44:52.5896202+02:00",
      "InReplyTo": null,
      "RepliedAt": "2021-08-11T03:44:52.5896202+02:00",
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
        "ContactId": 496,
        "ContactName": "Koelpin, Lakin and West",
        "PersonId": 55,
        "PersonName": "Batz LLC",
        "AssociateId": 158,
        "Address": "et",
        "EmailId": 201,
        "DuplicatePersonIds": [
          840,
          692
        ],
        "Name": "Jacobs Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 314
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 374,
        "ContactName": "Stiedemann LLC",
        "PersonId": 270,
        "PersonName": "Howe Inc and Sons",
        "AssociateId": 545,
        "Address": "est",
        "EmailId": 705,
        "DuplicatePersonIds": [
          380,
          796
        ],
        "Name": "Reilly Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 980
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 420,
        "ContactName": "Bogisich Inc and Sons",
        "PersonId": 448,
        "PersonName": "Rutherford-Monahan",
        "AssociateId": 232,
        "Address": "ullam",
        "EmailId": 619,
        "DuplicatePersonIds": [
          158,
          967
        ],
        "Name": "Olson-Mueller",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 466
          }
        }
      }
    ],
    "Subject": "corporis",
    "HTMLBody": "soluta",
    "From": null,
    "Sent": "2000-07-28T03:44:52.5896202+02:00",
    "Size": 974,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "rem",
    "PlainBody": "eius",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 400,
    "Attachments": [
      {
        "Description": "Polarised user-facing data-warehouse",
        "Filename": "qui",
        "Size": 413,
        "Type": "dolor",
        "Encoding": "magnam",
        "Id": "aut",
        "Disposition": "sed",
        "IsSafeFileExtension": true,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 306
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Hegmann, Cummings and Beer",
        "Values": [
          "qui",
          "expedita"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 90
          }
        }
      },
      {
        "Name": "Hegmann, Cummings and Beer",
        "Values": [
          "qui",
          "expedita"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 90
          }
        }
      }
    ],
    "FolderName": "Wilderman, Ankunding and Hayes",
    "EmailItemId": 835,
    "AccountId": 445,
    "ReceivedAt": "2004-05-25T03:44:52.5896202+02:00",
    "InReplyTo": null,
    "RepliedAt": "2011-03-30T03:44:52.5896202+02:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 8
      }
    }
  }
]
```