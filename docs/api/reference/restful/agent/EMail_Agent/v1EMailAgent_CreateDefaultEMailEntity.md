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

Response body: 

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
      "ContactId": 487,
      "ContactName": "Wisozk, Luettgen and Lakin",
      "PersonId": 156,
      "PersonName": "Botsford, Macejkovic and Hickle",
      "AssociateId": 185,
      "Address": "voluptatibus",
      "EmailId": 465,
      "DuplicatePersonIds": [
        282,
        687
      ],
      "Name": "Ankunding Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 156
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 47,
      "ContactName": "Kovacek, Bartell and Lakin",
      "PersonId": 122,
      "PersonName": "Hoeger Group",
      "AssociateId": 673,
      "Address": "deserunt",
      "EmailId": 893,
      "DuplicatePersonIds": [
        772,
        670
      ],
      "Name": "Kautzer, Abernathy and Rice",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 660
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 520,
      "ContactName": "Stanton, Mohr and Lemke",
      "PersonId": 291,
      "PersonName": "Hammes Inc and Sons",
      "AssociateId": 873,
      "Address": "autem",
      "EmailId": 529,
      "DuplicatePersonIds": [
        734,
        759
      ],
      "Name": "Anderson, Auer and Hintz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 899
        }
      }
    }
  ],
  "Subject": "amet",
  "HTMLBody": "delectus",
  "From": null,
  "Sent": "2017-11-25T11:10:26.8964578+01:00",
  "Size": 906,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "aperiam",
  "PlainBody": "possimus",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 860,
  "Attachments": [
    {
      "Description": "Polarised fresh-thinking instruction set",
      "Filename": "nam",
      "Size": 123,
      "Type": "officiis",
      "Encoding": "commodi",
      "Id": "quia",
      "Disposition": "molestias",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 484
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Shields LLC",
      "Values": [
        "aspernatur",
        "dolorum"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 198
        }
      }
    },
    {
      "Name": "Shields LLC",
      "Values": [
        "aspernatur",
        "dolorum"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 198
        }
      }
    }
  ],
  "FolderName": "Durgan-Beahan",
  "EmailItemId": 244,
  "AccountId": 86,
  "ReceivedAt": "1999-12-29T11:10:26.8974525+01:00",
  "InReplyTo": null,
  "RepliedAt": "2011-11-23T11:10:26.8974525+01:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 564
    }
  }
}
```