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
  "DocumentId": 490
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 209,
      "ContactName": "Bosco Inc and Sons",
      "PersonId": 146,
      "PersonName": "Berge-Berge",
      "AssociateId": 719,
      "Address": "laborum",
      "EmailId": 838,
      "DuplicatePersonIds": [
        130,
        398
      ],
      "Name": "Altenwerth Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 487
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 743,
      "ContactName": "Glover-Dicki",
      "PersonId": 997,
      "PersonName": "Hartmann, Auer and Brakus",
      "AssociateId": 516,
      "Address": "sed",
      "EmailId": 139,
      "DuplicatePersonIds": [
        389,
        433
      ],
      "Name": "Swaniawski-Murray",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 875
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 397,
      "ContactName": "Lakin, Collins and Rohan",
      "PersonId": 41,
      "PersonName": "Muller, Goodwin and Halvorson",
      "AssociateId": 160,
      "Address": "optio",
      "EmailId": 502,
      "DuplicatePersonIds": [
        257,
        883
      ],
      "Name": "Predovic Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 534
        }
      }
    }
  ],
  "Subject": "adipisci",
  "HTMLBody": "reiciendis",
  "From": null,
  "Sent": "2021-02-04T12:57:33.8836618+01:00",
  "Size": 255,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "temporibus",
  "PlainBody": "totam",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 814,
  "Attachments": [
    {
      "Description": "Pre-emptive maximized encryption",
      "Filename": "amet",
      "Size": 947,
      "Type": "deleniti",
      "Encoding": "ipsam",
      "Id": "illo",
      "Disposition": "libero",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Daniel Inc and Sons",
      "Values": [
        "cumque",
        "totam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 763
        }
      }
    },
    {
      "Name": "Daniel Inc and Sons",
      "Values": [
        "cumque",
        "totam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 763
        }
      }
    }
  ],
  "FolderName": "Prohaska-Erdman",
  "EmailItemId": 615,
  "AccountId": 351,
  "ReceivedAt": "2015-12-03T12:57:33.8836618+01:00",
  "InReplyTo": null,
  "RepliedAt": "2012-08-20T12:57:33.8836618+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 972
    }
  }
}
```