---
title: POST Agents/EMail/CreateEMailFromDocumentEntity
uid: v1EMailAgent_CreateEMailFromDocumentEntity
generated: true
---

# POST Agents/EMail/CreateEMailFromDocumentEntity

```http
POST /api/v1/Agents/EMail/CreateEMailFromDocumentEntity
```

Get an e-mail based on the provided DocumentEntity


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/CreateEMailFromDocumentEntity?$select=name,department,category/id
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

DocumentEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentEntity | DocumentEntity | Partial DocumentEntity class associating the generated DocumentEntity with an interface. |

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
POST /api/v1/Agents/EMail/CreateEMailFromDocumentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentEntity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 184,
      "ContactName": "Funk-O'Connell",
      "PersonId": 964,
      "PersonName": "Wuckert, Schmitt and Littel",
      "AssociateId": 388,
      "Address": "necessitatibus",
      "EmailId": 765,
      "DuplicatePersonIds": [
        714,
        956
      ],
      "Name": "Parker-Flatley",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 608
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 717,
      "ContactName": "Cormier, Collins and Pouros",
      "PersonId": 887,
      "PersonName": "Murray LLC",
      "AssociateId": 892,
      "Address": "et",
      "EmailId": 146,
      "DuplicatePersonIds": [
        267,
        286
      ],
      "Name": "Veum, Hartmann and McCullough",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 495
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 879,
      "ContactName": "Macejkovic-Jast",
      "PersonId": 277,
      "PersonName": "Goldner, Hagenes and Herzog",
      "AssociateId": 764,
      "Address": "ab",
      "EmailId": 932,
      "DuplicatePersonIds": [
        753,
        50
      ],
      "Name": "Ferry, Wuckert and Blanda",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 476
        }
      }
    }
  ],
  "Subject": "aut",
  "HTMLBody": "accusamus",
  "From": null,
  "Sent": "2013-06-10T23:03:56.0001309+02:00",
  "Size": 270,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "beatae",
  "PlainBody": "libero",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 376,
  "Attachments": [
    {
      "Description": "Intuitive needs-based standardization",
      "Filename": "aperiam",
      "Size": 106,
      "Type": "et",
      "Encoding": "in",
      "Id": "consequatur",
      "Disposition": "at",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 984
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Lubowitz Inc and Sons",
      "Values": [
        "velit",
        "omnis"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 811
        }
      }
    },
    {
      "Name": "Lubowitz Inc and Sons",
      "Values": [
        "velit",
        "omnis"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 811
        }
      }
    }
  ],
  "FolderName": "Feil, Buckridge and Roob",
  "EmailItemId": 997,
  "AccountId": 591,
  "ReceivedAt": "2012-09-30T23:03:56.0016284+02:00",
  "InReplyTo": null,
  "RepliedAt": "2022-04-01T23:03:56.0021291+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 893
    }
  }
}
```