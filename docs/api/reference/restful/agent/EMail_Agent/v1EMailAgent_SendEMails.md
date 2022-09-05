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
| OutgoingConnectionInfo |  | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
| Emails | array |  |
| SentItemsConnectionInfo |  | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |


## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| To | array | To recipients of e-mail |
| Cc | array | Cc recipients of e-mail |
| Bcc | array | Bcc recipient of e-mail |
| Subject | string | Subject of the e-mail |
| HTMLBody | string | Body formatted in HTML |
| From |  | Who did the e-mail originate from |
| Sent | date-time | When was the e-mail sent |
| Size | int32 | Total size of the e-mail |
| Priority | string | Importance of the e-mail |
| Flags | string | Flag status of this mail (unread, replied, deleted ) |
| MessageID | string | Unique id of e-mails |
| PlainBody | string | Body formatted in plain text |
| IsSent | bool | Is this a sent e-mail (not new) |
| EMailSOInfo |  | Glue between SuperOffice data and an e-mail. |
| ServerId | int32 | Unique id for the e-mail on the server |
| Attachments | array |  |
| CustomHeaderList | array | Non standard e-mail headers |
| FolderName | string | Name of folder the e-mail belongs in |
| EmailItemId | int32 | Primary key |
| AccountId | int32 | Account Id |
| ReceivedAt | date-time | Received date time |
| InReplyTo |  | The envelope of the email this email is a reply to, if it exists |
| RepliedAt | date-time | When this email was replied at |
| HasCalendarData | bool | If this email contains exactly one iCal appointment |
| CalMethod | string | Method stored in the associated iCal appointment. Indicates if the iCal data is a reply, counter proposal etc. |
| CalReplyStatus | string | Reply status stored in calendar data for the ical method is REPLY |
| TableRight |  |  |
| FieldProperties | object |  |

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
      "Subject": "ratione",
      "HTMLBody": "sunt",
      "From": null,
      "Sent": "2010-09-10T11:10:26.9264254+02:00",
      "Size": 655,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "in",
      "PlainBody": "nulla",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 68,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Swift LLC",
      "EmailItemId": 567,
      "AccountId": 96,
      "ReceivedAt": "2007-12-11T11:10:26.9264254+01:00",
      "InReplyTo": null,
      "RepliedAt": "2020-07-24T11:10:26.9264254+02:00",
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
        "ContactId": 331,
        "ContactName": "Hegmann Inc and Sons",
        "PersonId": 240,
        "PersonName": "Jerde, Sauer and Koelpin",
        "AssociateId": 572,
        "Address": "iure",
        "EmailId": 813,
        "DuplicatePersonIds": [
          394,
          857
        ],
        "Name": "Hills, Okuneva and Miller",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 19
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 882,
        "ContactName": "Weimann-Rosenbaum",
        "PersonId": 507,
        "PersonName": "Mohr LLC",
        "AssociateId": 416,
        "Address": "nisi",
        "EmailId": 312,
        "DuplicatePersonIds": [
          504,
          337
        ],
        "Name": "Koelpin Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 292
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 365,
        "ContactName": "Marvin LLC",
        "PersonId": 634,
        "PersonName": "Jakubowski-Swift",
        "AssociateId": 142,
        "Address": "non",
        "EmailId": 820,
        "DuplicatePersonIds": [
          121,
          640
        ],
        "Name": "Baumbach, Dietrich and Kuphal",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 853
          }
        }
      }
    ],
    "Subject": "placeat",
    "HTMLBody": "voluptate",
    "From": null,
    "Sent": "2009-10-14T11:10:26.9284251+02:00",
    "Size": 261,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "dolorum",
    "PlainBody": "doloremque",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 176,
    "Attachments": [
      {
        "Description": "Enhanced intangible leverage",
        "Filename": "voluptatibus",
        "Size": 484,
        "Type": "esse",
        "Encoding": "quia",
        "Id": "quia",
        "Disposition": "non",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 125
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Medhurst-Williamson",
        "Values": [
          "incidunt",
          "vel"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 878
          }
        }
      },
      {
        "Name": "Medhurst-Williamson",
        "Values": [
          "incidunt",
          "vel"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 878
          }
        }
      }
    ],
    "FolderName": "Medhurst, Lesch and Kihn",
    "EmailItemId": 923,
    "AccountId": 736,
    "ReceivedAt": "1999-03-06T11:10:26.9294246+01:00",
    "InReplyTo": null,
    "RepliedAt": "2000-01-06T11:10:26.9294246+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 211
      }
    }
  }
]
```