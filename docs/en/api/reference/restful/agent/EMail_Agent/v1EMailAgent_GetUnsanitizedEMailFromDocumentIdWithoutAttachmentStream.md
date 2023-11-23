---
title: POST Agents/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
uid: v1EMailAgent_GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
generated: true
---

# POST Agents/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
```

Get an e-mail based on an archived document.


The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 397
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 77,
      "ContactName": "Aufderhar-Bailey",
      "PersonId": 939,
      "PersonName": "Cormier Inc and Sons",
      "AssociateId": 605,
      "Address": "sit",
      "EmailId": 338,
      "DuplicatePersonIds": [
        319,
        623
      ],
      "Name": "Streich-Heathcote",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 453
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 884,
      "ContactName": "Jakubowski Group",
      "PersonId": 533,
      "PersonName": "Schneider-Mayert",
      "AssociateId": 524,
      "Address": "tempore",
      "EmailId": 629,
      "DuplicatePersonIds": [
        147,
        21
      ],
      "Name": "Fahey, Thompson and Schultz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 793
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 663,
      "ContactName": "Rippin Group",
      "PersonId": 615,
      "PersonName": "Erdman-Wiza",
      "AssociateId": 734,
      "Address": "culpa",
      "EmailId": 637,
      "DuplicatePersonIds": [
        108,
        333
      ],
      "Name": "Tromp Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 873
        }
      }
    }
  ],
  "Subject": "a",
  "HTMLBody": "magnam",
  "From": null,
  "Sent": "2012-01-26T13:38:13.5302438+01:00",
  "Size": 895,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "in",
  "PlainBody": "voluptatem",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 977,
  "Attachments": [
    {
      "Description": "Multi-lateral national hardware",
      "Filename": "voluptatem",
      "Size": 385,
      "Type": "et",
      "Encoding": "molestiae",
      "Id": "necessitatibus",
      "Disposition": "aut",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 214
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Weber Inc and Sons",
      "Values": [
        "omnis",
        "sequi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 634
        }
      }
    },
    {
      "Name": "Weber Inc and Sons",
      "Values": [
        "omnis",
        "sequi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 634
        }
      }
    }
  ],
  "FolderName": "Veum-Morar",
  "EmailItemId": 835,
  "AccountId": 808,
  "ReceivedAt": "2018-01-07T13:38:13.5302438+01:00",
  "InReplyTo": null,
  "RepliedAt": "2009-01-15T13:38:13.5302438+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 776
    }
  }
}
```