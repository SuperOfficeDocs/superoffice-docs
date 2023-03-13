---
title: POST Agents/EMail/CreateDefaultEMailEntity
uid: v1EMailAgent_CreateDefaultEMailEntity
---

# POST Agents/EMail/CreateDefaultEMailEntity

```http
POST /api/v1/Agents/EMail/CreateDefaultEMailEntity
```

Set default values into a new EMailEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: EMailEntity

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
POST /api/v1/Agents/EMail/CreateDefaultEMailEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 384,
      "ContactName": "Barton, Grimes and Bruen",
      "PersonId": 440,
      "PersonName": "Hirthe, McCullough and Williamson",
      "AssociateId": 643,
      "Address": "qui",
      "EmailId": 480,
      "DuplicatePersonIds": [
        133,
        638
      ],
      "Name": "Toy Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 41
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 53,
      "ContactName": "Dare Group",
      "PersonId": 699,
      "PersonName": "Goldner, Goyette and Batz",
      "AssociateId": 398,
      "Address": "mollitia",
      "EmailId": 449,
      "DuplicatePersonIds": [
        565,
        524
      ],
      "Name": "Kshlerin LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 683
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 843,
      "ContactName": "Rau Group",
      "PersonId": 851,
      "PersonName": "Quigley, Feil and Paucek",
      "AssociateId": 774,
      "Address": "eos",
      "EmailId": 98,
      "DuplicatePersonIds": [
        913,
        352
      ],
      "Name": "Keeling LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 909
        }
      }
    }
  ],
  "Subject": "maiores",
  "HTMLBody": "iusto",
  "From": null,
  "Sent": "2001-05-20T12:15:18.9727578+02:00",
  "Size": 224,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "in",
  "PlainBody": "blanditiis",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 547,
  "Attachments": [
    {
      "Description": "Progressive homogeneous customer loyalty",
      "Filename": "libero",
      "Size": 313,
      "Type": "et",
      "Encoding": "porro",
      "Id": "iure",
      "Disposition": "quis",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 334
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Wilkinson, Beatty and Senger",
      "Values": [
        "maiores",
        "nostrum"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 562
        }
      }
    },
    {
      "Name": "Wilkinson, Beatty and Senger",
      "Values": [
        "maiores",
        "nostrum"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 562
        }
      }
    }
  ],
  "FolderName": "Volkman-Upton",
  "EmailItemId": 713,
  "AccountId": 484,
  "ReceivedAt": "1995-12-13T12:15:18.9737517+01:00",
  "InReplyTo": null,
  "RepliedAt": "2014-07-07T12:15:18.9737517+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 849
    }
  }
}
```