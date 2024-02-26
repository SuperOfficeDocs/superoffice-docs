---
title: POST Agents/EMail/GetUnsanitizedEMailFromDocumentId
uid: v1EMailAgent_GetUnsanitizedEMailFromDocumentId
generated: true
---

# POST Agents/EMail/GetUnsanitizedEMailFromDocumentId

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentId
```

Get an e-mail based on an archived document.


The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentId?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 90
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 327,
      "ContactName": "Lebsack-McClure",
      "PersonId": 940,
      "PersonName": "Adams, Von and Lubowitz",
      "AssociateId": 201,
      "Address": "fugit",
      "EmailId": 268,
      "DuplicatePersonIds": [
        918,
        400
      ],
      "Name": "Leannon, Jacobson and Lang",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 956
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 641,
      "ContactName": "Schamberger-Keeling",
      "PersonId": 988,
      "PersonName": "Crona Group",
      "AssociateId": 149,
      "Address": "dolor",
      "EmailId": 400,
      "DuplicatePersonIds": [
        793,
        376
      ],
      "Name": "Bode-Cremin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 585
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 84,
      "ContactName": "Lebsack, Klein and Durgan",
      "PersonId": 243,
      "PersonName": "Bergnaum LLC",
      "AssociateId": 295,
      "Address": "enim",
      "EmailId": 797,
      "DuplicatePersonIds": [
        351,
        252
      ],
      "Name": "Greenfelder Group",
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
  "Subject": "accusantium",
  "HTMLBody": "voluptatibus",
  "From": null,
  "Sent": "2019-06-28T10:30:23.8136779+02:00",
  "Size": 690,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "molestiae",
  "PlainBody": "et",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 872,
  "Attachments": [
    {
      "Description": "Adaptive zero administration productivity",
      "Filename": "doloribus",
      "Size": 896,
      "Type": "voluptas",
      "Encoding": "delectus",
      "Id": "ducimus",
      "Disposition": "cumque",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 41
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Mann, Stracke and Ryan",
      "Values": [
        "eum",
        "repudiandae"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 114
        }
      }
    },
    {
      "Name": "Mann, Stracke and Ryan",
      "Values": [
        "eum",
        "repudiandae"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 114
        }
      }
    }
  ],
  "FolderName": "Carter, Kuphal and Hegmann",
  "EmailItemId": 268,
  "AccountId": 607,
  "ReceivedAt": "2004-05-25T10:30:23.8136779+02:00",
  "InReplyTo": null,
  "RepliedAt": "2003-08-20T10:30:23.8136779+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 920
    }
  }
}
```