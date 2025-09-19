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
  "DocId": 856,
  "AttachmentIds": [
    "sed",
    "nobis"
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
      "ContactId": 583,
      "ContactName": "King, Hegmann and Littel",
      "PersonId": 39,
      "PersonName": "Oberbrunner-Quitzon",
      "AssociateId": 640,
      "Address": "omnis",
      "EmailId": 952,
      "DuplicatePersonIds": [
        829,
        30
      ],
      "Name": "Wolff LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 896
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 220,
      "ContactName": "Ratke, Stiedemann and Emmerich",
      "PersonId": 772,
      "PersonName": "Mertz, Nikolaus and Balistreri",
      "AssociateId": 823,
      "Address": "sed",
      "EmailId": 891,
      "DuplicatePersonIds": [
        331,
        355
      ],
      "Name": "Cassin, Gerlach and Stroman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 391
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 138,
      "ContactName": "Nader Inc and Sons",
      "PersonId": 870,
      "PersonName": "Hayes-Blick",
      "AssociateId": 736,
      "Address": "impedit",
      "EmailId": 80,
      "DuplicatePersonIds": [
        127,
        399
      ],
      "Name": "Boyer-Rath",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 422
        }
      }
    }
  ],
  "Subject": "debitis",
  "HTMLBody": "dolores",
  "From": null,
  "Sent": "2016-01-23T03:41:53.5276084+01:00",
  "Size": 797,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "molestias",
  "PlainBody": "ea",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 249,
  "Attachments": [
    {
      "Description": "Compatible scalable hub",
      "Filename": "aperiam",
      "Size": 804,
      "Type": "et",
      "Encoding": "et",
      "Id": "accusamus",
      "Disposition": "temporibus",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 847
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Swaniawski Inc and Sons",
      "Values": [
        "atque",
        "quia"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    },
    {
      "Name": "Swaniawski Inc and Sons",
      "Values": [
        "atque",
        "quia"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    }
  ],
  "FolderName": "Larson LLC",
  "EmailItemId": 521,
  "AccountId": 722,
  "ReceivedAt": "2004-06-27T03:41:53.5276084+02:00",
  "InReplyTo": null,
  "RepliedAt": "2023-01-25T03:41:53.5276084+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 319
    }
  }
}
```