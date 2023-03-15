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
Accept-Language: *
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
      "Subject": "enim",
      "HTMLBody": "recusandae",
      "From": null,
      "Sent": "2011-09-16T12:15:18.9127528+02:00",
      "Size": 196,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "rerum",
      "PlainBody": "dolor",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 183,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Mraz LLC",
      "EmailItemId": 450,
      "AccountId": 425,
      "ReceivedAt": "1997-06-03T12:15:18.9127528+02:00",
      "InReplyTo": null,
      "RepliedAt": "2015-06-10T12:15:18.9127528+02:00",
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
        "ContactId": 304,
        "ContactName": "Torphy-Lehner",
        "PersonId": 27,
        "PersonName": "Wilkinson, Eichmann and Hessel",
        "AssociateId": 193,
        "Address": "saepe",
        "EmailId": 863,
        "DuplicatePersonIds": [
          591,
          215
        ],
        "Name": "Kunze-Thiel",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 417
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 388,
        "ContactName": "Weimann-Spinka",
        "PersonId": 40,
        "PersonName": "Robel LLC",
        "AssociateId": 191,
        "Address": "eligendi",
        "EmailId": 406,
        "DuplicatePersonIds": [
          711,
          98
        ],
        "Name": "Quitzon-Strosin",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 786
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 41,
        "ContactName": "Little, Erdman and Christiansen",
        "PersonId": 921,
        "PersonName": "Abshire Inc and Sons",
        "AssociateId": 417,
        "Address": "doloremque",
        "EmailId": 265,
        "DuplicatePersonIds": [
          692,
          248
        ],
        "Name": "Strosin-Barton",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 589
          }
        }
      }
    ],
    "Subject": "voluptatem",
    "HTMLBody": "quia",
    "From": null,
    "Sent": "1999-01-05T12:15:18.9157548+01:00",
    "Size": 699,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "voluptatum",
    "PlainBody": "blanditiis",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 982,
    "Attachments": [
      {
        "Description": "Operative stable model",
        "Filename": "tempora",
        "Size": 298,
        "Type": "accusantium",
        "Encoding": "quam",
        "Id": "exercitationem",
        "Disposition": "nam",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 845
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Bernier-Parker",
        "Values": [
          "deleniti",
          "quo"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 932
          }
        }
      },
      {
        "Name": "Bernier-Parker",
        "Values": [
          "deleniti",
          "quo"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 932
          }
        }
      }
    ],
    "FolderName": "Hamill, Hermann and Roberts",
    "EmailItemId": 490,
    "AccountId": 721,
    "ReceivedAt": "2017-10-26T12:15:18.9157548+02:00",
    "InReplyTo": null,
    "RepliedAt": "1999-03-13T12:15:18.9157548+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 129
      }
    }
  }
]
```