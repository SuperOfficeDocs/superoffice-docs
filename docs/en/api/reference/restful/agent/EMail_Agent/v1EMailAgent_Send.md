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
      "Subject": "vitae",
      "HTMLBody": "quidem",
      "From": null,
      "Sent": "2018-06-13T16:00:40.8518697+02:00",
      "Size": 174,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "ut",
      "PlainBody": "beatae",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 432,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Keebler-Streich",
      "EmailItemId": 804,
      "AccountId": 490,
      "ReceivedAt": "2009-02-19T16:00:40.8518697+01:00",
      "InReplyTo": null,
      "RepliedAt": "2014-07-15T16:00:40.8518697+02:00",
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
        "ContactId": 895,
        "ContactName": "Bogisich LLC",
        "PersonId": 229,
        "PersonName": "Bergstrom Group",
        "AssociateId": 762,
        "Address": "eius",
        "EmailId": 366,
        "DuplicatePersonIds": [
          764,
          621
        ],
        "Name": "Gaylord-Kuvalis",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 351
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 396,
        "ContactName": "Reinger Inc and Sons",
        "PersonId": 1001,
        "PersonName": "Bogan, Watsica and Schaefer",
        "AssociateId": 577,
        "Address": "in",
        "EmailId": 899,
        "DuplicatePersonIds": [
          469,
          834
        ],
        "Name": "Bode-Champlin",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 838
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 658,
        "ContactName": "Price-Bode",
        "PersonId": 46,
        "PersonName": "Mertz-Wilderman",
        "AssociateId": 339,
        "Address": "qui",
        "EmailId": 575,
        "DuplicatePersonIds": [
          318,
          693
        ],
        "Name": "Ritchie, Haley and Schneider",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 437
          }
        }
      }
    ],
    "Subject": "qui",
    "HTMLBody": "velit",
    "From": null,
    "Sent": "1998-07-12T16:00:40.8518697+02:00",
    "Size": 320,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "harum",
    "PlainBody": "adipisci",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 745,
    "Attachments": [
      {
        "Description": "Function-based multi-tasking groupware",
        "Filename": "sapiente",
        "Size": 459,
        "Type": "ut",
        "Encoding": "sit",
        "Id": "non",
        "Disposition": "et",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 316
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Parisian, Johnston and Rath",
        "Values": [
          "iure",
          "odit"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 935
          }
        }
      },
      {
        "Name": "Parisian, Johnston and Rath",
        "Values": [
          "iure",
          "odit"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 935
          }
        }
      }
    ],
    "FolderName": "Effertz-Douglas",
    "EmailItemId": 988,
    "AccountId": 194,
    "ReceivedAt": "2006-11-04T16:00:40.8518697+01:00",
    "InReplyTo": null,
    "RepliedAt": "2005-03-01T16:00:40.8518697+01:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 985
      }
    }
  }
]
```