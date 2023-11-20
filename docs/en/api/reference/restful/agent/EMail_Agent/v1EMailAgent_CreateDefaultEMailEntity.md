---
title: POST Agents/EMail/CreateDefaultEMailEntity
uid: v1EMailAgent_CreateDefaultEMailEntity
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

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
      "ContactId": 216,
      "ContactName": "Langosh, Anderson and Koepp",
      "PersonId": 651,
      "PersonName": "Bartoletti-Wiza",
      "AssociateId": 800,
      "Address": "quas",
      "EmailId": 765,
      "DuplicatePersonIds": [
        441,
        158
      ],
      "Name": "Klocko, Mante and McLaughlin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 948
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 858,
      "ContactName": "Kulas Inc and Sons",
      "PersonId": 408,
      "PersonName": "Yost, McLaughlin and Schneider",
      "AssociateId": 972,
      "Address": "nisi",
      "EmailId": 337,
      "DuplicatePersonIds": [
        211,
        879
      ],
      "Name": "Hessel-Block",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 856
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 747,
      "ContactName": "Hegmann-Johns",
      "PersonId": 503,
      "PersonName": "Hermann, Parisian and Fahey",
      "AssociateId": 95,
      "Address": "accusamus",
      "EmailId": 126,
      "DuplicatePersonIds": [
        939,
        875
      ],
      "Name": "Bradtke-Frami",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 425
        }
      }
    }
  ],
  "Subject": "sed",
  "HTMLBody": "fugiat",
  "From": null,
  "Sent": "2007-10-25T13:38:13.5458695+02:00",
  "Size": 468,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "sapiente",
  "PlainBody": "corporis",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 323,
  "Attachments": [
    {
      "Description": "Synchronised cohesive challenge",
      "Filename": "temporibus",
      "Size": 70,
      "Type": "voluptatem",
      "Encoding": "sed",
      "Id": "est",
      "Disposition": "eligendi",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 52
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Nicolas-Fadel",
      "Values": [
        "nemo",
        "ipsam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 275
        }
      }
    },
    {
      "Name": "Nicolas-Fadel",
      "Values": [
        "nemo",
        "ipsam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 275
        }
      }
    }
  ],
  "FolderName": "Cassin Inc and Sons",
  "EmailItemId": 996,
  "AccountId": 436,
  "ReceivedAt": "2007-10-09T13:38:13.5458695+02:00",
  "InReplyTo": null,
  "RepliedAt": "2020-06-29T13:38:13.5458695+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 966
    }
  }
}
```