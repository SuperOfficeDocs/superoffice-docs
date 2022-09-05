---
title: POST Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId
uid: v1EMailAgent_GetUnsanitizedEMailFromDocumentAttachmentId
---

# POST Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId
```

Get an e-mail based on an email in the archive system and attachment id.


The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId?$select=name,department,category/id
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
| DocId | int32 |  |
| AttachmentIds | array |  |
| IncludeAttachments | bool |  |


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
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocId": 449,
  "AttachmentIds": [
    "voluptatibus",
    "aperiam"
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
      "ContactId": 761,
      "ContactName": "Terry-Emard",
      "PersonId": 412,
      "PersonName": "Fay Group",
      "AssociateId": 968,
      "Address": "architecto",
      "EmailId": 114,
      "DuplicatePersonIds": [
        621,
        200
      ],
      "Name": "Halvorson, Ward and Sipes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 829
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 579,
      "ContactName": "Emmerich-Osinski",
      "PersonId": 597,
      "PersonName": "Gislason-Herzog",
      "AssociateId": 710,
      "Address": "similique",
      "EmailId": 580,
      "DuplicatePersonIds": [
        581,
        708
      ],
      "Name": "Wunsch, Brown and Rosenbaum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 389
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 342,
      "ContactName": "Hartmann LLC",
      "PersonId": 198,
      "PersonName": "Roob, Langosh and Pollich",
      "AssociateId": 897,
      "Address": "consequatur",
      "EmailId": 453,
      "DuplicatePersonIds": [
        611,
        883
      ],
      "Name": "Douglas LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 841
        }
      }
    }
  ],
  "Subject": "neque",
  "HTMLBody": "nemo",
  "From": null,
  "Sent": "2020-08-02T11:10:26.9594556+02:00",
  "Size": 14,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "occaecati",
  "PlainBody": "consequatur",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 478,
  "Attachments": [
    {
      "Description": "Balanced explicit paradigm",
      "Filename": "vero",
      "Size": 914,
      "Type": "quam",
      "Encoding": "molestiae",
      "Id": "voluptas",
      "Disposition": "non",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 410
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Daugherty, Harvey and Olson",
      "Values": [
        "sed",
        "voluptas"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 190
        }
      }
    },
    {
      "Name": "Daugherty, Harvey and Olson",
      "Values": [
        "sed",
        "voluptas"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 190
        }
      }
    }
  ],
  "FolderName": "Berge, Morar and Hodkiewicz",
  "EmailItemId": 987,
  "AccountId": 691,
  "ReceivedAt": "2008-10-12T11:10:26.9594556+02:00",
  "InReplyTo": null,
  "RepliedAt": "2016-11-04T11:10:26.9594556+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 852
    }
  }
}
```