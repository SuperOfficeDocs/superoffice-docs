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
      "Subject": "non",
      "HTMLBody": "ipsum",
      "From": null,
      "Sent": "1996-10-23T23:03:55.9626373+02:00",
      "Size": 588,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "similique",
      "PlainBody": "tempora",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 168,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Hodkiewicz Group",
      "EmailItemId": 745,
      "AccountId": 642,
      "ReceivedAt": "2019-04-18T23:03:55.9626373+02:00",
      "InReplyTo": null,
      "RepliedAt": "2006-01-01T23:03:55.9626373+01:00",
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
        "ContactId": 548,
        "ContactName": "McClure-McKenzie",
        "PersonId": 380,
        "PersonName": "Dooley LLC",
        "AssociateId": 441,
        "Address": "aliquam",
        "EmailId": 595,
        "DuplicatePersonIds": [
          549,
          25
        ],
        "Name": "Koelpin-Batz",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 618
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 822,
        "ContactName": "Terry-Lebsack",
        "PersonId": 542,
        "PersonName": "Mertz-Bode",
        "AssociateId": 561,
        "Address": "natus",
        "EmailId": 939,
        "DuplicatePersonIds": [
          104,
          203
        ],
        "Name": "Runolfsson, Bogisich and Stokes",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 924
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 617,
        "ContactName": "Leffler LLC",
        "PersonId": 84,
        "PersonName": "Christiansen Group",
        "AssociateId": 438,
        "Address": "quisquam",
        "EmailId": 121,
        "DuplicatePersonIds": [
          934,
          138
        ],
        "Name": "Treutel-Zieme",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 531
          }
        }
      }
    ],
    "Subject": "neque",
    "HTMLBody": "mollitia",
    "From": null,
    "Sent": "2022-09-08T23:03:55.9651292+02:00",
    "Size": 90,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "maiores",
    "PlainBody": "nulla",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 36,
    "Attachments": [
      {
        "Description": "Total object-oriented synergy",
        "Filename": "id",
        "Size": 411,
        "Type": "fuga",
        "Encoding": "vel",
        "Id": "fugiat",
        "Disposition": "voluptatum",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 322
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Hirthe, Kshlerin and Quigley",
        "Values": [
          "molestiae",
          "consequatur"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 592
          }
        }
      },
      {
        "Name": "Hirthe, Kshlerin and Quigley",
        "Values": [
          "molestiae",
          "consequatur"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 592
          }
        }
      }
    ],
    "FolderName": "Borer, Stiedemann and Hamill",
    "EmailItemId": 900,
    "AccountId": 19,
    "ReceivedAt": "2005-07-07T23:03:55.9666296+02:00",
    "InReplyTo": null,
    "RepliedAt": "2008-11-20T23:03:55.9666296+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 462
      }
    }
  }
]
```