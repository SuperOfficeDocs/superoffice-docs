---
title: POST Agents/EMail/Send
uid: v1EMailAgent_Send
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/EMail/Send
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
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
      "Subject": "dolor",
      "HTMLBody": "unde",
      "From": null,
      "Sent": "1999-05-12T04:02:01.6748777+02:00",
      "Size": 52,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "amet",
      "PlainBody": "voluptas",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 727,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Bogan LLC",
      "EmailItemId": 856,
      "AccountId": 147,
      "ReceivedAt": "2002-01-11T04:02:01.6748777+01:00",
      "InReplyTo": null,
      "RepliedAt": "2011-05-02T04:02:01.6748777+02:00",
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
        "ContactId": 615,
        "ContactName": "Bahringer, Bartoletti and Boyle",
        "PersonId": 811,
        "PersonName": "Hartmann, Grant and Reichert",
        "AssociateId": 72,
        "Address": "facere",
        "EmailId": 702,
        "DuplicatePersonIds": [
          221,
          500
        ],
        "Name": "Prosacco LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 272
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 435,
        "ContactName": "Hayes LLC",
        "PersonId": 87,
        "PersonName": "Hermiston-Rau",
        "AssociateId": 401,
        "Address": "unde",
        "EmailId": 392,
        "DuplicatePersonIds": [
          277,
          414
        ],
        "Name": "Hand-Heidenreich",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 266
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 638,
        "ContactName": "Lebsack-Schinner",
        "PersonId": 660,
        "PersonName": "Hahn Group",
        "AssociateId": 214,
        "Address": "eum",
        "EmailId": 559,
        "DuplicatePersonIds": [
          184,
          752
        ],
        "Name": "Reilly LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 358
          }
        }
      }
    ],
    "Subject": "facere",
    "HTMLBody": "ea",
    "From": null,
    "Sent": "2003-07-04T04:02:01.6748777+02:00",
    "Size": 11,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "doloribus",
    "PlainBody": "aut",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 212,
    "Attachments": [
      {
        "Description": "Seamless eco-centric focus group",
        "Filename": "natus",
        "Size": 127,
        "Type": "ut",
        "Encoding": "alias",
        "Id": "occaecati",
        "Disposition": "nisi",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 969
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Wiza Inc and Sons",
        "Values": [
          "suscipit",
          "fugiat"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 950
          }
        }
      },
      {
        "Name": "Wiza Inc and Sons",
        "Values": [
          "suscipit",
          "fugiat"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 950
          }
        }
      }
    ],
    "FolderName": "Legros LLC",
    "EmailItemId": 40,
    "AccountId": 188,
    "ReceivedAt": "2018-12-11T04:02:01.6748777+01:00",
    "InReplyTo": null,
    "RepliedAt": "2010-07-14T04:02:01.6748777+02:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 974
      }
    }
  }
]
```