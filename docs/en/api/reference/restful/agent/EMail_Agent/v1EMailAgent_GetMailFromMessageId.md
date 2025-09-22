---
title: POST Agents/EMail/GetMailFromMessageId
uid: v1EMailAgent_GetMailFromMessageId
generated: true
content_type: reference
---

# POST Agents/EMail/GetMailFromMessageId

```http
POST /api/v1/Agents/EMail/GetMailFromMessageId
```

Get email from db based on Message Id


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetMailFromMessageId?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetMailFromMessageId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "MessageId": "voluptates"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 619,
      "ContactName": "Schumm Inc and Sons",
      "PersonId": 960,
      "PersonName": "Torphy Group",
      "AssociateId": 362,
      "Address": "est",
      "EmailId": 684,
      "DuplicatePersonIds": [
        346,
        24
      ],
      "Name": "Schaefer-Farrell",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 457
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 226,
      "ContactName": "Wiegand Group",
      "PersonId": 404,
      "PersonName": "Hilpert, Dietrich and Koch",
      "AssociateId": 126,
      "Address": "porro",
      "EmailId": 769,
      "DuplicatePersonIds": [
        732,
        485
      ],
      "Name": "Graham, Schneider and Gorczany",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 22
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 969,
      "ContactName": "Upton-Morar",
      "PersonId": 99,
      "PersonName": "Kunze, Brown and Wilderman",
      "AssociateId": 101,
      "Address": "veniam",
      "EmailId": 375,
      "DuplicatePersonIds": [
        853,
        3
      ],
      "Name": "VonRueden, Emmerich and Stanton",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 90
        }
      }
    }
  ],
  "Subject": "officia",
  "HTMLBody": "explicabo",
  "From": null,
  "Sent": "2006-03-29T11:24:48.03141+02:00",
  "Size": 709,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "in",
  "PlainBody": "molestias",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 160,
  "Attachments": [
    {
      "Description": "Public-key bi-directional capacity",
      "Filename": "hic",
      "Size": 884,
      "Type": "maxime",
      "Encoding": "aperiam",
      "Id": "ipsam",
      "Disposition": "voluptatibus",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 486
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Bartoletti, D'Amore and Rau",
      "Values": [
        "reprehenderit",
        "ea"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 194
        }
      }
    },
    {
      "Name": "Bartoletti, D'Amore and Rau",
      "Values": [
        "reprehenderit",
        "ea"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 194
        }
      }
    }
  ],
  "FolderName": "Lindgren, Simonis and Thiel",
  "EmailItemId": 575,
  "AccountId": 822,
  "ReceivedAt": "2002-01-18T11:24:48.03141+01:00",
  "InReplyTo": null,
  "RepliedAt": "2022-02-15T11:24:48.03141+01:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 534
    }
  }
}
```