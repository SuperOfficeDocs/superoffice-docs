---
title: POST Agents/EMail/GetMailFromInReplyTo
uid: v1EMailAgent_GetMailFromInReplyTo
generated: true
---

# POST Agents/EMail/GetMailFromInReplyTo

```http
POST /api/v1/Agents/EMail/GetMailFromInReplyTo
```

Get email from db based on In-Reply-To Message Id


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetMailFromInReplyTo?$select=name,department,category/id
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

MessageId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MessageId | String |  |

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
POST /api/v1/Agents/EMail/GetMailFromInReplyTo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MessageId": "laboriosam"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 410,
      "ContactName": "Mayert Inc and Sons",
      "PersonId": 335,
      "PersonName": "Ebert Group",
      "AssociateId": 943,
      "Address": "sed",
      "EmailId": 153,
      "DuplicatePersonIds": [
        121,
        257
      ],
      "Name": "Kling LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 102
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 741,
      "ContactName": "Kautzer Group",
      "PersonId": 76,
      "PersonName": "Quitzon, Bashirian and Wiegand",
      "AssociateId": 427,
      "Address": "tempore",
      "EmailId": 243,
      "DuplicatePersonIds": [
        17,
        951
      ],
      "Name": "McKenzie Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 618
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 827,
      "ContactName": "Metz Group",
      "PersonId": 322,
      "PersonName": "Osinski-Kertzmann",
      "AssociateId": 675,
      "Address": "aut",
      "EmailId": 40,
      "DuplicatePersonIds": [
        85,
        502
      ],
      "Name": "Goldner, Corwin and Kunze",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 229
        }
      }
    }
  ],
  "Subject": "nam",
  "HTMLBody": "aspernatur",
  "From": null,
  "Sent": "1998-01-01T12:01:27.7909064+01:00",
  "Size": 538,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "cumque",
  "PlainBody": "iusto",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 918,
  "Attachments": [
    {
      "Description": "Mandatory systematic core",
      "Filename": "enim",
      "Size": 794,
      "Type": "qui",
      "Encoding": "dolorum",
      "Id": "eos",
      "Disposition": "omnis",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 270
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Zboncak LLC",
      "Values": [
        "temporibus",
        "ipsam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 689
        }
      }
    },
    {
      "Name": "Zboncak LLC",
      "Values": [
        "temporibus",
        "ipsam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 689
        }
      }
    }
  ],
  "FolderName": "Hayes, Mayert and Wolf",
  "EmailItemId": 637,
  "AccountId": 974,
  "ReceivedAt": "2016-05-17T12:01:27.7909064+02:00",
  "InReplyTo": null,
  "RepliedAt": "2005-10-11T12:01:27.7909064+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 18
    }
  }
}
```