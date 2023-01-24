---
title: POST Agents/EMail/Send
uid: v1EMailAgent_Send
---

# POST Agents/EMail/Send

```http
POST /api/v1/Agents/EMail/Send
```

Send the provided e-mails


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/Send?$select=name,department,category/id
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

Emails 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Emails | Array |  |

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/EMail/Send
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
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
      "Subject": "tempore",
      "HTMLBody": "natus",
      "From": null,
      "Sent": "2020-07-04T11:22:38.1803656+02:00",
      "Size": 874,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "esse",
      "PlainBody": "exercitationem",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 397,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Stamm Group",
      "EmailItemId": 44,
      "AccountId": 902,
      "ReceivedAt": "2020-10-14T11:22:38.1803656+02:00",
      "InReplyTo": null,
      "RepliedAt": "2008-02-01T11:22:38.1803656+01:00",
      "HasCalendarData": true,
      "CalMethod": "Add",
      "CalReplyStatus": "Accepted"
    }
  ]
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
        "ContactId": 580,
        "ContactName": "Kilback-Swift",
        "PersonId": 765,
        "PersonName": "Padberg Group",
        "AssociateId": 948,
        "Address": "officia",
        "EmailId": 468,
        "DuplicatePersonIds": [
          243,
          1002
        ],
        "Name": "Bergstrom Inc and Sons",
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
    "Cc": [
      {
        "ContactId": 314,
        "ContactName": "Bednar Group",
        "PersonId": 779,
        "PersonName": "Wilderman-Fahey",
        "AssociateId": 484,
        "Address": "qui",
        "EmailId": 163,
        "DuplicatePersonIds": [
          138,
          584
        ],
        "Name": "Daugherty, McClure and Moen",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 337
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 725,
        "ContactName": "Wolff Group",
        "PersonId": 994,
        "PersonName": "Lemke-Johns",
        "AssociateId": 476,
        "Address": "dolorem",
        "EmailId": 892,
        "DuplicatePersonIds": [
          952,
          552
        ],
        "Name": "Kuphal LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 560
          }
        }
      }
    ],
    "Subject": "numquam",
    "HTMLBody": "expedita",
    "From": null,
    "Sent": "2015-01-13T11:22:38.1803656+01:00",
    "Size": 985,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "possimus",
    "PlainBody": "a",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 766,
    "Attachments": [
      {
        "Description": "Proactive 5th generation contingency",
        "Filename": "distinctio",
        "Size": 942,
        "Type": "est",
        "Encoding": "neque",
        "Id": "voluptatem",
        "Disposition": "voluptatem",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 744
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "DuBuque, Shields and Tromp",
        "Values": [
          "porro",
          "repellendus"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 607
          }
        }
      },
      {
        "Name": "DuBuque, Shields and Tromp",
        "Values": [
          "porro",
          "repellendus"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 607
          }
        }
      }
    ],
    "FolderName": "Jewess Group",
    "EmailItemId": 606,
    "AccountId": 307,
    "ReceivedAt": "2014-06-13T11:22:38.1803656+02:00",
    "InReplyTo": null,
    "RepliedAt": "2012-07-27T11:22:38.1803656+02:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 732
      }
    }
  }
]
```