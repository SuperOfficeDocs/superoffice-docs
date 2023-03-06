---
title: POST Agents/EMail/GetEMailFromAttachmentId
uid: v1EMailAgent_GetEMailFromAttachmentId
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EmailId": 365,
  "AttachmentIds": [
    "incidunt",
    "magni"
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
      "ContactId": 298,
      "ContactName": "Prohaska-Maggio",
      "PersonId": 408,
      "PersonName": "Breitenberg-Jacobson",
      "AssociateId": 487,
      "Address": "et",
      "EmailId": 572,
      "DuplicatePersonIds": [
        984,
        421
      ],
      "Name": "Jaskolski-Hauck",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 740
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 564,
      "ContactName": "Leuschke Group",
      "PersonId": 392,
      "PersonName": "Reynolds Group",
      "AssociateId": 599,
      "Address": "enim",
      "EmailId": 285,
      "DuplicatePersonIds": [
        492,
        118
      ],
      "Name": "Harvey Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 730
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 747,
      "ContactName": "Bosco-Maggio",
      "PersonId": 52,
      "PersonName": "Lakin Inc and Sons",
      "AssociateId": 490,
      "Address": "ut",
      "EmailId": 583,
      "DuplicatePersonIds": [
        461,
        549
      ],
      "Name": "Gusikowski, Kirlin and Keeling",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 756
        }
      }
    }
  ],
  "Subject": "quibusdam",
  "HTMLBody": "et",
  "From": null,
  "Sent": "2003-02-13T14:19:03.466522+01:00",
  "Size": 993,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "delectus",
  "PlainBody": "architecto",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 485,
  "Attachments": [
    {
      "Description": "Robust coherent application",
      "Filename": "velit",
      "Size": 611,
      "Type": "cupiditate",
      "Encoding": "facere",
      "Id": "sit",
      "Disposition": "hic",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 64
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Moen Group",
      "Values": [
        "asperiores",
        "voluptate"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 223
        }
      }
    },
    {
      "Name": "Moen Group",
      "Values": [
        "asperiores",
        "voluptate"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 223
        }
      }
    }
  ],
  "FolderName": "Schimmel Inc and Sons",
  "EmailItemId": 411,
  "AccountId": 190,
  "ReceivedAt": "1998-12-15T14:19:03.466522+01:00",
  "InReplyTo": null,
  "RepliedAt": "2022-09-30T14:19:03.466522+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 293
    }
  }
}
```