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
      "Subject": "iusto",
      "HTMLBody": "voluptas",
      "From": null,
      "Sent": "2008-12-31T03:45:23.4204561+01:00",
      "Size": 280,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "quo",
      "PlainBody": "eveniet",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 692,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Schuppe, Lueilwitz and Hamill",
      "EmailItemId": 17,
      "AccountId": 947,
      "ReceivedAt": "2002-03-07T03:45:23.4204561+01:00",
      "InReplyTo": null,
      "RepliedAt": "2002-10-21T03:45:23.4204561+02:00",
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
        "ContactId": 589,
        "ContactName": "Mertz, Friesen and Smith",
        "PersonId": 637,
        "PersonName": "Hintz-Kessler",
        "AssociateId": 619,
        "Address": "id",
        "EmailId": 646,
        "DuplicatePersonIds": [
          836,
          276
        ],
        "Name": "Metz Inc and Sons",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 64
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 294,
        "ContactName": "Terry LLC",
        "PersonId": 506,
        "PersonName": "Krajcik-Schaefer",
        "AssociateId": 273,
        "Address": "quos",
        "EmailId": 96,
        "DuplicatePersonIds": [
          461,
          867
        ],
        "Name": "Wolff-O'Kon",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 633
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 454,
        "ContactName": "Lakin, Harris and Kihn",
        "PersonId": 474,
        "PersonName": "Konopelski-DuBuque",
        "AssociateId": 39,
        "Address": "minus",
        "EmailId": 926,
        "DuplicatePersonIds": [
          395,
          679
        ],
        "Name": "Ryan-Armstrong",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 547
          }
        }
      }
    ],
    "Subject": "quo",
    "HTMLBody": "suscipit",
    "From": null,
    "Sent": "2021-05-21T03:45:23.4204561+02:00",
    "Size": 295,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "sit",
    "PlainBody": "molestiae",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 573,
    "Attachments": [
      {
        "Description": "Right-sized multimedia neural-net",
        "Filename": "molestiae",
        "Size": 402,
        "Type": "eveniet",
        "Encoding": "harum",
        "Id": "iusto",
        "Disposition": "facilis",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
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
    "CustomHeaderList": [
      {
        "Name": "Pollich Group",
        "Values": [
          "quisquam",
          "fuga"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 641
          }
        }
      },
      {
        "Name": "Pollich Group",
        "Values": [
          "quisquam",
          "fuga"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 641
          }
        }
      }
    ],
    "FolderName": "Ullrich, Hintz and Grant",
    "EmailItemId": 791,
    "AccountId": 119,
    "ReceivedAt": "2003-08-02T03:45:23.4204561+02:00",
    "InReplyTo": null,
    "RepliedAt": "2009-12-14T03:45:23.4204561+01:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 342
      }
    }
  }
]
```