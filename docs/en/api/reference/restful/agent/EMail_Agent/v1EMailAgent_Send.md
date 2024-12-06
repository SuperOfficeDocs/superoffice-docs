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
      "Subject": "atque",
      "HTMLBody": "deleniti",
      "From": null,
      "Sent": "2014-09-15T10:17:55.5352844+02:00",
      "Size": 772,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "repellat",
      "PlainBody": "sit",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 428,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Nolan-Mills",
      "EmailItemId": 923,
      "AccountId": 207,
      "ReceivedAt": "2018-10-04T10:17:55.5352844+02:00",
      "InReplyTo": null,
      "RepliedAt": "2002-05-07T10:17:55.5352844+02:00",
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
        "ContactId": 892,
        "ContactName": "Hane, Torphy and O'Keefe",
        "PersonId": 311,
        "PersonName": "Kutch-Eichmann",
        "AssociateId": 391,
        "Address": "aut",
        "EmailId": 701,
        "DuplicatePersonIds": [
          123,
          483
        ],
        "Name": "Crona-Buckridge",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 723
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 11,
        "ContactName": "Gutkowski-Turcotte",
        "PersonId": 712,
        "PersonName": "Haag, Zemlak and Zboncak",
        "AssociateId": 725,
        "Address": "ut",
        "EmailId": 458,
        "DuplicatePersonIds": [
          145,
          575
        ],
        "Name": "Farrell LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 94
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 537,
        "ContactName": "Gorczany, Hodkiewicz and Gleichner",
        "PersonId": 606,
        "PersonName": "Jewess, Vandervort and Bergstrom",
        "AssociateId": 61,
        "Address": "eum",
        "EmailId": 264,
        "DuplicatePersonIds": [
          847,
          998
        ],
        "Name": "Effertz LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 868
          }
        }
      }
    ],
    "Subject": "sit",
    "HTMLBody": "nisi",
    "From": null,
    "Sent": "2017-03-22T10:17:55.5352844+01:00",
    "Size": 218,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "modi",
    "PlainBody": "beatae",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 531,
    "Attachments": [
      {
        "Description": "Public-key system-worthy installation",
        "Filename": "sunt",
        "Size": 507,
        "Type": "facere",
        "Encoding": "aut",
        "Id": "architecto",
        "Disposition": "ipsum",
        "IsSafeFileExtension": true,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 814
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Gislason-Heller",
        "Values": [
          "rerum",
          "fugiat"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 872
          }
        }
      },
      {
        "Name": "Gislason-Heller",
        "Values": [
          "rerum",
          "fugiat"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 872
          }
        }
      }
    ],
    "FolderName": "Jacobson, Rippin and Lemke",
    "EmailItemId": 93,
    "AccountId": 100,
    "ReceivedAt": "2001-04-12T10:17:55.5352844+02:00",
    "InReplyTo": null,
    "RepliedAt": "2002-06-06T10:17:55.5352844+02:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 173
      }
    }
  }
]
```