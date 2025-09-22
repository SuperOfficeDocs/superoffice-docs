---
title: POST Agents/EMail/GetEMailFromDocumentAttachmentId
uid: v1EMailAgent_GetEMailFromDocumentAttachmentId
generated: true
content_type: reference
---

# POST Agents/EMail/GetEMailFromDocumentAttachmentId

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentAttachmentId
```

Get an e-mail based on an email in the archive system and attachment id


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentAttachmentId?$select=name,department,category/id
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

DocId, AttachmentIds, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocId | Integer |  |
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
POST /api/v1/Agents/EMail/GetEMailFromDocumentAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocId": 653,
  "AttachmentIds": [
    "neque",
    "ipsum"
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
      "ContactId": 998,
      "ContactName": "Ferry Inc and Sons",
      "PersonId": 65,
      "PersonName": "Kassulke Group",
      "AssociateId": 656,
      "Address": "perferendis",
      "EmailId": 639,
      "DuplicatePersonIds": [
        612,
        149
      ],
      "Name": "Boyer Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 481
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 856,
      "ContactName": "Kilback Group",
      "PersonId": 455,
      "PersonName": "Green, Kunze and Sawayn",
      "AssociateId": 622,
      "Address": "quibusdam",
      "EmailId": 530,
      "DuplicatePersonIds": [
        216,
        774
      ],
      "Name": "Strosin, Schaden and Kiehn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 280
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 724,
      "ContactName": "Murphy, Johnson and Ernser",
      "PersonId": 800,
      "PersonName": "Reinger-Schmitt",
      "AssociateId": 267,
      "Address": "neque",
      "EmailId": 417,
      "DuplicatePersonIds": [
        298,
        197
      ],
      "Name": "Braun-Quitzon",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 709
        }
      }
    }
  ],
  "Subject": "recusandae",
  "HTMLBody": "veritatis",
  "From": null,
  "Sent": "2016-03-14T11:24:48.0939075+01:00",
  "Size": 270,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "aliquam",
  "PlainBody": "dolorum",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 283,
  "Attachments": [
    {
      "Description": "Optimized multi-tasking solution",
      "Filename": "rem",
      "Size": 76,
      "Type": "voluptatem",
      "Encoding": "minima",
      "Id": "omnis",
      "Disposition": "voluptates",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 716
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "O'Hara-Walter",
      "Values": [
        "dolorem",
        "consequatur"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 195
        }
      }
    },
    {
      "Name": "O'Hara-Walter",
      "Values": [
        "dolorem",
        "consequatur"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 195
        }
      }
    }
  ],
  "FolderName": "Sauer Inc and Sons",
  "EmailItemId": 89,
  "AccountId": 356,
  "ReceivedAt": "2013-05-18T11:24:48.0939075+02:00",
  "InReplyTo": null,
  "RepliedAt": "1999-04-06T11:24:48.0939075+02:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 263
    }
  }
}
```