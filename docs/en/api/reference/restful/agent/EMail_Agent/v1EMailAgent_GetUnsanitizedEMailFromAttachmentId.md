---
title: POST Agents/EMail/GetUnsanitizedEMailFromAttachmentId
uid: v1EMailAgent_GetUnsanitizedEMailFromAttachmentId
generated: true
content_type: reference
---

# POST Agents/EMail/GetUnsanitizedEMailFromAttachmentId

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromAttachmentId
```

Get an e-mail based on an email and attachment id.


The returned value is not sanitized.
NsApiSlow threshold: 5000 ms.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromAttachmentId?$select=name,department,category/id
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

EmailId, AttachmentIds, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailId | Integer |  |
| AttachmentIds | Array |  |
| IncludeAttachments | Boolean |  |

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
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EmailId": 557,
  "AttachmentIds": [
    "dolor",
    "nesciunt"
  ],
  "IncludeAttachments": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 75,
      "ContactName": "Dickinson LLC",
      "PersonId": 881,
      "PersonName": "Cormier-Fritsch",
      "AssociateId": 33,
      "Address": "repudiandae",
      "EmailId": 271,
      "DuplicatePersonIds": [
        836,
        109
      ],
      "Name": "Kihn-Mayer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 168
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 350,
      "ContactName": "Hermann-Hudson",
      "PersonId": 273,
      "PersonName": "Kassulke Group",
      "AssociateId": 26,
      "Address": "repudiandae",
      "EmailId": 270,
      "DuplicatePersonIds": [
        760,
        686
      ],
      "Name": "Sawayn-Okuneva",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 182
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 82,
      "ContactName": "Flatley-Koelpin",
      "PersonId": 747,
      "PersonName": "Pacocha, Bartoletti and Douglas",
      "AssociateId": 48,
      "Address": "et",
      "EmailId": 103,
      "DuplicatePersonIds": [
        775,
        361
      ],
      "Name": "Reinger Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 75
        }
      }
    }
  ],
  "Subject": "molestias",
  "HTMLBody": "vero",
  "From": null,
  "Sent": "2013-02-07T02:30:47.3038336+01:00",
  "Size": 327,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "officiis",
  "PlainBody": "recusandae",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 630,
  "Attachments": [
    {
      "Description": "Expanded 6th generation productivity",
      "Filename": "illo",
      "Size": 254,
      "Type": "magnam",
      "Encoding": "quidem",
      "Id": "delectus",
      "Disposition": "soluta",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 778
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Haag-Klocko",
      "Values": [
        "omnis",
        "velit"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 375
        }
      }
    },
    {
      "Name": "Haag-Klocko",
      "Values": [
        "omnis",
        "velit"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 375
        }
      }
    }
  ],
  "FolderName": "Franecki LLC",
  "EmailItemId": 851,
  "AccountId": 300,
  "ReceivedAt": "2004-02-01T02:30:47.3038336+01:00",
  "InReplyTo": null,
  "RepliedAt": "2014-08-25T02:30:47.3038336+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 957
    }
  }
}
```