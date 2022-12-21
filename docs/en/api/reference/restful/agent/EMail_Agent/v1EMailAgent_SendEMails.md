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
      "Subject": "dicta",
      "HTMLBody": "aut",
      "From": null,
      "Sent": "2017-11-29T02:49:44.4347885+01:00",
      "Size": 962,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "reprehenderit",
      "PlainBody": "consectetur",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 16,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Blanda LLC",
      "EmailItemId": 362,
      "AccountId": 717,
      "ReceivedAt": "2011-09-08T02:49:44.4347885+02:00",
      "InReplyTo": null,
      "RepliedAt": "2005-11-12T02:49:44.4347885+01:00",
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
        "ContactName": "Kris-Conn",
        "PersonId": 268,
        "PersonName": "Pfannerstill LLC",
        "AssociateId": 768,
        "Address": "eum",
        "EmailId": 123,
        "DuplicatePersonIds": [
          292,
          323
        ],
        "Name": "Little, Buckridge and Tillman",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 980
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 939,
        "ContactName": "Price-Wilderman",
        "PersonId": 993,
        "PersonName": "Vandervort Group",
        "AssociateId": 905,
        "Address": "rerum",
        "EmailId": 709,
        "DuplicatePersonIds": [
          738,
          190
        ],
        "Name": "Hansen-Murazik",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 122
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 670,
        "ContactName": "Osinski, Brown and Schmitt",
        "PersonId": 993,
        "PersonName": "Raynor Group",
        "AssociateId": 380,
        "Address": "et",
        "EmailId": 800,
        "DuplicatePersonIds": [
          82,
          424
        ],
        "Name": "Dickinson-Simonis",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 200
          }
        }
      }
    ],
    "Subject": "omnis",
    "HTMLBody": "officia",
    "From": null,
    "Sent": "2012-12-08T02:49:44.4347885+01:00",
    "Size": 47,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "ad",
    "PlainBody": "aut",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 249,
    "Attachments": [
      {
        "Description": "Multi-tiered cohesive parallelism",
        "Filename": "culpa",
        "Size": 267,
        "Type": "provident",
        "Encoding": "et",
        "Id": "aut",
        "Disposition": "voluptatum",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 964
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Smitham, Parker and Schmeler",
        "Values": [
          "dolorum",
          "libero"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 293
          }
        }
      },
      {
        "Name": "Smitham, Parker and Schmeler",
        "Values": [
          "dolorum",
          "libero"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 293
          }
        }
      }
    ],
    "FolderName": "Sporer-McKenzie",
    "EmailItemId": 133,
    "AccountId": 804,
    "ReceivedAt": "2004-12-01T02:49:44.4347885+01:00",
    "InReplyTo": null,
    "RepliedAt": "2014-06-03T02:49:44.4347885+02:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 599
      }
    }
  }
]
```