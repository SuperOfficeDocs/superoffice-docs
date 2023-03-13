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
      "Subject": "voluptas",
      "HTMLBody": "incidunt",
      "From": null,
      "Sent": "2014-08-25T14:19:03.3883958+02:00",
      "Size": 228,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "eum",
      "PlainBody": "commodi",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 944,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Konopelski-Satterfield",
      "EmailItemId": 775,
      "AccountId": 99,
      "ReceivedAt": "2020-02-28T14:19:03.3883958+01:00",
      "InReplyTo": null,
      "RepliedAt": "2000-09-27T14:19:03.3883958+02:00",
      "HasCalendarData": false,
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
        "ContactId": 506,
        "ContactName": "Gleason-Senger",
        "PersonId": 124,
        "PersonName": "Reichert-Cronin",
        "AssociateId": 351,
        "Address": "amet",
        "EmailId": 54,
        "DuplicatePersonIds": [
          6,
          63
        ],
        "Name": "Kassulke Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 447
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 678,
        "ContactName": "Swift-Waters",
        "PersonId": 950,
        "PersonName": "Batz Inc and Sons",
        "AssociateId": 274,
        "Address": "blanditiis",
        "EmailId": 661,
        "DuplicatePersonIds": [
          12,
          311
        ],
        "Name": "Ziemann-Halvorson",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 31
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 63,
        "ContactName": "Schiller Inc and Sons",
        "PersonId": 804,
        "PersonName": "Reinger, Greenfelder and Schamberger",
        "AssociateId": 88,
        "Address": "rerum",
        "EmailId": 834,
        "DuplicatePersonIds": [
          826,
          248
        ],
        "Name": "Herman, Schuster and Klocko",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 374
          }
        }
      }
    ],
    "Subject": "rem",
    "HTMLBody": "et",
    "From": null,
    "Sent": "2018-02-28T14:19:03.3883958+01:00",
    "Size": 537,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "et",
    "PlainBody": "voluptatem",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 370,
    "Attachments": [
      {
        "Description": "Persevering 4th generation function",
        "Filename": "nobis",
        "Size": 168,
        "Type": "praesentium",
        "Encoding": "harum",
        "Id": "alias",
        "Disposition": "consequatur",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 593
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Murray-Breitenberg",
        "Values": [
          "cupiditate",
          "molestiae"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 780
          }
        }
      },
      {
        "Name": "Murray-Breitenberg",
        "Values": [
          "cupiditate",
          "molestiae"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 780
          }
        }
      }
    ],
    "FolderName": "Blanda-Lang",
    "EmailItemId": 556,
    "AccountId": 529,
    "ReceivedAt": "2014-08-24T14:19:03.3883958+02:00",
    "InReplyTo": null,
    "RepliedAt": "1995-11-25T14:19:03.3883958+01:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 916
      }
    }
  }
]
```