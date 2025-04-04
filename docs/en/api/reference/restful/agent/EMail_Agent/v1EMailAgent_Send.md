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
Accept-Language: fr,de,ru,zh
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
      "Subject": "sapiente",
      "HTMLBody": "quis",
      "From": null,
      "Sent": "2015-10-01T13:14:00.2668463+02:00",
      "Size": 717,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "qui",
      "PlainBody": "unde",
      "IsSent": true,
      "EMailSOInfo": null,
      "ServerId": 171,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Powlowski LLC",
      "EmailItemId": 486,
      "AccountId": 404,
      "ReceivedAt": "2013-03-23T13:14:00.2668463+01:00",
      "InReplyTo": null,
      "RepliedAt": "2021-11-16T13:14:00.2668463+01:00",
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
        "ContactId": 668,
        "ContactName": "Glover-Beier",
        "PersonId": 114,
        "PersonName": "Luettgen, Koepp and Borer",
        "AssociateId": 880,
        "Address": "et",
        "EmailId": 749,
        "DuplicatePersonIds": [
          218,
          196
        ],
        "Name": "Lemke LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 139
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 967,
        "ContactName": "Towne-Muller",
        "PersonId": 854,
        "PersonName": "Kiehn, Abshire and Mills",
        "AssociateId": 907,
        "Address": "aut",
        "EmailId": 380,
        "DuplicatePersonIds": [
          406,
          287
        ],
        "Name": "Huel-Koch",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 785
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 65,
        "ContactName": "Koepp Group",
        "PersonId": 674,
        "PersonName": "Kuhn Inc and Sons",
        "AssociateId": 415,
        "Address": "cumque",
        "EmailId": 191,
        "DuplicatePersonIds": [
          711,
          965
        ],
        "Name": "Reynolds, Hoppe and Rowe",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 914
          }
        }
      }
    ],
    "Subject": "accusantium",
    "HTMLBody": "recusandae",
    "From": null,
    "Sent": "2024-07-17T13:14:00.2668463+02:00",
    "Size": 823,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "architecto",
    "PlainBody": "mollitia",
    "IsSent": true,
    "EMailSOInfo": null,
    "ServerId": 60,
    "Attachments": [
      {
        "Description": "Secured 3rd generation paradigm",
        "Filename": "beatae",
        "Size": 769,
        "Type": "ea",
        "Encoding": "beatae",
        "Id": "ea",
        "Disposition": "enim",
        "IsSafeFileExtension": false,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 654
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Sawayn-Witting",
        "Values": [
          "magnam",
          "sit"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 331
          }
        }
      },
      {
        "Name": "Sawayn-Witting",
        "Values": [
          "magnam",
          "sit"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 331
          }
        }
      }
    ],
    "FolderName": "Renner LLC",
    "EmailItemId": 393,
    "AccountId": 557,
    "ReceivedAt": "2011-10-19T13:14:00.2668463+02:00",
    "InReplyTo": null,
    "RepliedAt": "2014-02-17T13:14:00.2668463+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 694
      }
    }
  }
]
```