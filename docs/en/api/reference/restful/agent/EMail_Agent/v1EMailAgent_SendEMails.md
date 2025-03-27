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
Accept-Language: fr,de,ru,zh
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
      "Subject": "voluptatibus",
      "HTMLBody": "porro",
      "From": null,
      "Sent": "2009-01-12T02:38:21.3857927+01:00",
      "Size": 590,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "magni",
      "PlainBody": "dicta",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 223,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Erdman-Medhurst",
      "EmailItemId": 777,
      "AccountId": 573,
      "ReceivedAt": "2009-09-08T02:38:21.3857927+02:00",
      "InReplyTo": null,
      "RepliedAt": "2016-09-02T02:38:21.3857927+02:00",
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
        "ContactId": 241,
        "ContactName": "Ratke, Hayes and Mertz",
        "PersonId": 694,
        "PersonName": "Jacobi Inc and Sons",
        "AssociateId": 818,
        "Address": "repellat",
        "EmailId": 218,
        "DuplicatePersonIds": [
          521,
          478
        ],
        "Name": "Hoppe, Lynch and McClure",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 504
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 230,
        "ContactName": "Ritchie-Hodkiewicz",
        "PersonId": 446,
        "PersonName": "Leuschke, Thiel and Keebler",
        "AssociateId": 575,
        "Address": "magnam",
        "EmailId": 22,
        "DuplicatePersonIds": [
          900,
          808
        ],
        "Name": "Heathcote, Rowe and Kohler",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 431
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 706,
        "ContactName": "Torphy-Aufderhar",
        "PersonId": 257,
        "PersonName": "Witting Group",
        "AssociateId": 801,
        "Address": "repellat",
        "EmailId": 149,
        "DuplicatePersonIds": [
          975,
          815
        ],
        "Name": "Tillman LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 529
          }
        }
      }
    ],
    "Subject": "voluptatem",
    "HTMLBody": "in",
    "From": null,
    "Sent": "2005-11-25T02:38:21.3857927+01:00",
    "Size": 137,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "porro",
    "PlainBody": "esse",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 674,
    "Attachments": [
      {
        "Description": "Digitized multimedia initiative",
        "Filename": "mollitia",
        "Size": 326,
        "Type": "atque",
        "Encoding": "ea",
        "Id": "numquam",
        "Disposition": "quo",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 648
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "O'Connell Inc and Sons",
        "Values": [
          "est",
          "laudantium"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 574
          }
        }
      },
      {
        "Name": "O'Connell Inc and Sons",
        "Values": [
          "est",
          "laudantium"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 574
          }
        }
      }
    ],
    "FolderName": "Koss Group",
    "EmailItemId": 626,
    "AccountId": 767,
    "ReceivedAt": "2004-09-18T02:38:21.3857927+02:00",
    "InReplyTo": null,
    "RepliedAt": "2017-08-17T02:38:21.3857927+02:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 680
      }
    }
  }
]
```