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
  "EmailId": 882,
  "AttachmentIds": [
    "at",
    "aut"
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
      "ContactId": 50,
      "ContactName": "Boyle, Gorczany and Schoen",
      "PersonId": 772,
      "PersonName": "Toy, Raynor and Paucek",
      "AssociateId": 95,
      "Address": "eum",
      "EmailId": 966,
      "DuplicatePersonIds": [
        38,
        577
      ],
      "Name": "Rodriguez LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 801
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 337,
      "ContactName": "Hansen Inc and Sons",
      "PersonId": 998,
      "PersonName": "Prosacco Inc and Sons",
      "AssociateId": 322,
      "Address": "velit",
      "EmailId": 302,
      "DuplicatePersonIds": [
        425,
        182
      ],
      "Name": "Beer LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 546
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 879,
      "ContactName": "Kovacek, Hessel and Emmerich",
      "PersonId": 616,
      "PersonName": "Bogan, Becker and Buckridge",
      "AssociateId": 780,
      "Address": "libero",
      "EmailId": 382,
      "DuplicatePersonIds": [
        741,
        197
      ],
      "Name": "Raynor Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 571
        }
      }
    }
  ],
  "Subject": "reiciendis",
  "HTMLBody": "excepturi",
  "From": null,
  "Sent": "2020-07-19T03:41:53.5276084+02:00",
  "Size": 792,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "quos",
  "PlainBody": "possimus",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 435,
  "Attachments": [
    {
      "Description": "Streamlined assymetric superstructure",
      "Filename": "dolor",
      "Size": 962,
      "Type": "est",
      "Encoding": "ipsa",
      "Id": "labore",
      "Disposition": "quisquam",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 501
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Rutherford, Crist and Harvey",
      "Values": [
        "veritatis",
        "quam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 606
        }
      }
    },
    {
      "Name": "Rutherford, Crist and Harvey",
      "Values": [
        "veritatis",
        "quam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 606
        }
      }
    }
  ],
  "FolderName": "Littel LLC",
  "EmailItemId": 227,
  "AccountId": 609,
  "ReceivedAt": "2011-08-04T03:41:53.5276084+02:00",
  "InReplyTo": null,
  "RepliedAt": "2012-02-18T03:41:53.5276084+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 241
    }
  }
}
```