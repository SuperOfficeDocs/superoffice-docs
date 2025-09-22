---
title: POST Agents/EMail/Send
uid: v1EMailAgent_Send
generated: true
content_type: reference
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
      "Subject": "est",
      "HTMLBody": "soluta",
      "From": null,
      "Sent": "2005-12-09T11:24:48.03141+01:00",
      "Size": 41,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "omnis",
      "PlainBody": "iure",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 404,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Tromp, Gaylord and Marquardt",
      "EmailItemId": 76,
      "AccountId": 796,
      "ReceivedAt": "2010-01-09T11:24:48.03141+01:00",
      "InReplyTo": null,
      "RepliedAt": "2023-02-18T11:24:48.03141+01:00",
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
        "ContactId": 765,
        "ContactName": "Hodkiewicz, Hudson and Volkman",
        "PersonId": 460,
        "PersonName": "Murray LLC",
        "AssociateId": 538,
        "Address": "nostrum",
        "EmailId": 780,
        "DuplicatePersonIds": [
          967,
          654
        ],
        "Name": "Sauer, Abernathy and Corwin",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 421
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 240,
        "ContactName": "Stoltenberg-Roberts",
        "PersonId": 937,
        "PersonName": "Gibson, Reynolds and Frami",
        "AssociateId": 427,
        "Address": "ut",
        "EmailId": 351,
        "DuplicatePersonIds": [
          950,
          699
        ],
        "Name": "Macejkovic Group",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 679
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 485,
        "ContactName": "Dickens-Eichmann",
        "PersonId": 450,
        "PersonName": "Goyette LLC",
        "AssociateId": 687,
        "Address": "voluptatem",
        "EmailId": 2,
        "DuplicatePersonIds": [
          149,
          66
        ],
        "Name": "Yost, Gleichner and Feeney",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 922
          }
        }
      }
    ],
    "Subject": "laborum",
    "HTMLBody": "est",
    "From": null,
    "Sent": "2008-02-21T11:24:48.03141+01:00",
    "Size": 479,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "dolorem",
    "PlainBody": "mollitia",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 145,
    "Attachments": [
      {
        "Description": "Integrated composite circuit",
        "Filename": "laboriosam",
        "Size": 434,
        "Type": "accusamus",
        "Encoding": "veniam",
        "Id": "deleniti",
        "Disposition": "quis",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 703
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Little Inc and Sons",
        "Values": [
          "velit",
          "quis"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 381
          }
        }
      },
      {
        "Name": "Little Inc and Sons",
        "Values": [
          "velit",
          "quis"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 381
          }
        }
      }
    ],
    "FolderName": "Dicki Inc and Sons",
    "EmailItemId": 356,
    "AccountId": 699,
    "ReceivedAt": "2023-12-18T11:24:48.03141+01:00",
    "InReplyTo": null,
    "RepliedAt": "2016-08-20T11:24:48.03141+02:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 812
      }
    }
  }
]
```