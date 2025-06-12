---
title: POST Agents/EMail/GetUnsanitizedEMail
uid: v1EMailAgent_GetUnsanitizedEMail
generated: true
---

# POST Agents/EMail/GetUnsanitizedEMail

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMail
```

Get en e-mail based on its primary key in the DB.


The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMail?$select=name,department,category/id
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

Id, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | Integer |  |
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
POST /api/v1/Agents/EMail/GetUnsanitizedEMail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Id": 88,
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
      "ContactId": 423,
      "ContactName": "Klein, Waters and Cassin",
      "PersonId": 496,
      "PersonName": "Brakus-Mosciski",
      "AssociateId": 673,
      "Address": "quisquam",
      "EmailId": 120,
      "DuplicatePersonIds": [
        60,
        865
      ],
      "Name": "Dicki Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 776
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 509,
      "ContactName": "Upton, Abshire and Mayer",
      "PersonId": 697,
      "PersonName": "Smith Group",
      "AssociateId": 312,
      "Address": "accusantium",
      "EmailId": 506,
      "DuplicatePersonIds": [
        683,
        790
      ],
      "Name": "Waelchi Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 418
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 860,
      "ContactName": "Krajcik-Konopelski",
      "PersonId": 901,
      "PersonName": "Lebsack-Hagenes",
      "AssociateId": 669,
      "Address": "neque",
      "EmailId": 322,
      "DuplicatePersonIds": [
        249,
        514
      ],
      "Name": "Tromp-Schmidt",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 768
        }
      }
    }
  ],
  "Subject": "quasi",
  "HTMLBody": "officia",
  "From": null,
  "Sent": "2004-11-26T17:54:03.1170817+01:00",
  "Size": 993,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "qui",
  "PlainBody": "reprehenderit",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 58,
  "Attachments": [
    {
      "Description": "Cross-platform motivating policy",
      "Filename": "aut",
      "Size": 461,
      "Type": "asperiores",
      "Encoding": "possimus",
      "Id": "ex",
      "Disposition": "cumque",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 798
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Swaniawski Group",
      "Values": [
        "quia",
        "ducimus"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 350
        }
      }
    },
    {
      "Name": "Swaniawski Group",
      "Values": [
        "quia",
        "ducimus"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 350
        }
      }
    }
  ],
  "FolderName": "Ruecker-Watsica",
  "EmailItemId": 751,
  "AccountId": 188,
  "ReceivedAt": "2008-12-22T17:54:03.1170817+01:00",
  "InReplyTo": null,
  "RepliedAt": "2004-12-02T17:54:03.1170817+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 365
    }
  }
}
```