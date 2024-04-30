---
title: POST Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream
uid: v1EMailAgent_GetEMailFromDocumentIdWithoutAttachmentStream
generated: true
---

# POST Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream
```

Get an e-mail based on an archived document


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream?$select=name,department,category/id
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

DocumentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | Integer |  |

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
POST /api/v1/Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 378
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 989,
      "ContactName": "Fay Inc and Sons",
      "PersonId": 19,
      "PersonName": "Macejkovic-Upton",
      "AssociateId": 37,
      "Address": "consectetur",
      "EmailId": 923,
      "DuplicatePersonIds": [
        880,
        347
      ],
      "Name": "Watsica-Murphy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 103
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 524,
      "ContactName": "Roob LLC",
      "PersonId": 52,
      "PersonName": "Zemlak Group",
      "AssociateId": 542,
      "Address": "voluptatum",
      "EmailId": 487,
      "DuplicatePersonIds": [
        774,
        428
      ],
      "Name": "Homenick Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 309
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 501,
      "ContactName": "Hoeger-Littel",
      "PersonId": 111,
      "PersonName": "Runolfsson Inc and Sons",
      "AssociateId": 654,
      "Address": "dolores",
      "EmailId": 205,
      "DuplicatePersonIds": [
        768,
        435
      ],
      "Name": "Watsica LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 992
        }
      }
    }
  ],
  "Subject": "sed",
  "HTMLBody": "sapiente",
  "From": null,
  "Sent": "2012-09-12T11:44:33.5878385+02:00",
  "Size": 835,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "excepturi",
  "PlainBody": "et",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 538,
  "Attachments": [
    {
      "Description": "Reactive transitional circuit",
      "Filename": "quae",
      "Size": 773,
      "Type": "est",
      "Encoding": "dolores",
      "Id": "impedit",
      "Disposition": "est",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 144
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Williamson, Friesen and Collins",
      "Values": [
        "voluptas",
        "iusto"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 718
        }
      }
    },
    {
      "Name": "Williamson, Friesen and Collins",
      "Values": [
        "voluptas",
        "iusto"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 718
        }
      }
    }
  ],
  "FolderName": "Rau, Kiehn and Casper",
  "EmailItemId": 732,
  "AccountId": 24,
  "ReceivedAt": "2006-06-03T11:44:33.6034713+02:00",
  "InReplyTo": null,
  "RepliedAt": "2008-07-02T11:44:33.6034713+02:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 66
    }
  }
}
```