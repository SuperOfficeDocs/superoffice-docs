---
title: POST Agents/EMail/GetEMailFromAttachmentId
uid: v1EMailAgent_GetEMailFromAttachmentId
generated: true
---

# POST Agents/EMail/GetEMailFromAttachmentId

```http
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId
```

Get an e-mail based on an email and attachment id


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EmailId": 890,
  "AttachmentIds": [
    "maiores",
    "odio"
  ],
  "IncludeAttachments": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 528,
      "ContactName": "Baumbach, Franecki and Graham",
      "PersonId": 823,
      "PersonName": "Heller Inc and Sons",
      "AssociateId": 702,
      "Address": "tenetur",
      "EmailId": 125,
      "DuplicatePersonIds": [
        259,
        680
      ],
      "Name": "Hegmann-Yundt",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 901
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 846,
      "ContactName": "Schamberger-Marvin",
      "PersonId": 675,
      "PersonName": "Schmitt LLC",
      "AssociateId": 449,
      "Address": "qui",
      "EmailId": 843,
      "DuplicatePersonIds": [
        560,
        211
      ],
      "Name": "Brown Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 529
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 661,
      "ContactName": "Weber, Senger and Walsh",
      "PersonId": 678,
      "PersonName": "Graham, Lindgren and Eichmann",
      "AssociateId": 758,
      "Address": "vero",
      "EmailId": 399,
      "DuplicatePersonIds": [
        517,
        427
      ],
      "Name": "Torp-Schneider",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 613
        }
      }
    }
  ],
  "Subject": "dolores",
  "HTMLBody": "maxime",
  "From": null,
  "Sent": "2004-10-09T13:28:22.7416819+02:00",
  "Size": 230,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "quasi",
  "PlainBody": "distinctio",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 208,
  "Attachments": [
    {
      "Description": "Team-oriented 24 hour pricing structure",
      "Filename": "veritatis",
      "Size": 534,
      "Type": "nisi",
      "Encoding": "delectus",
      "Id": "dolor",
      "Disposition": "praesentium",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 238
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Crona LLC",
      "Values": [
        "rem",
        "quasi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 347
        }
      }
    },
    {
      "Name": "Crona LLC",
      "Values": [
        "rem",
        "quasi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 347
        }
      }
    }
  ],
  "FolderName": "Deckow Group",
  "EmailItemId": 654,
  "AccountId": 551,
  "ReceivedAt": "2001-09-07T13:28:22.7416819+02:00",
  "InReplyTo": null,
  "RepliedAt": "2015-12-03T13:28:22.7416819+01:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 178
    }
  }
}
```