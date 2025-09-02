---
title: POST Agents/EMail/CreateEMailFromDocumentEntity
uid: v1EMailAgent_CreateEMailFromDocumentEntity
generated: true
content_type: reference
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
Accept-Language: *
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
      "ContactId": 180,
      "ContactName": "Prohaska Group",
      "PersonId": 135,
      "PersonName": "Torphy-Bogan",
      "AssociateId": 475,
      "Address": "et",
      "EmailId": 398,
      "DuplicatePersonIds": [
        147,
        759
      ],
      "Name": "Schulist-Stehr",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 694
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 947,
      "ContactName": "Strosin, Metz and Morar",
      "PersonId": 84,
      "PersonName": "Marvin Inc and Sons",
      "AssociateId": 169,
      "Address": "quia",
      "EmailId": 197,
      "DuplicatePersonIds": [
        539,
        983
      ],
      "Name": "Robel, Turner and Osinski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 177
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 253,
      "ContactName": "Mosciski LLC",
      "PersonId": 240,
      "PersonName": "Boehm, Kunde and Schmitt",
      "AssociateId": 252,
      "Address": "vero",
      "EmailId": 451,
      "DuplicatePersonIds": [
        544,
        554
      ],
      "Name": "Kilback-Collins",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 752
        }
      }
    }
  ],
  "Subject": "enim",
  "HTMLBody": "nesciunt",
  "From": null,
  "Sent": "2004-07-01T03:46:54.785131+02:00",
  "Size": 770,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "aut",
  "PlainBody": "hic",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 693,
  "Attachments": [
    {
      "Description": "Multi-channelled analyzing alliance",
      "Filename": "magnam",
      "Size": 84,
      "Type": "aliquam",
      "Encoding": "placeat",
      "Id": "voluptate",
      "Disposition": "voluptatem",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 848
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Kling, Pouros and O'Keefe",
      "Values": [
        "aut",
        "dicta"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 512
        }
      }
    },
    {
      "Name": "Kling, Pouros and O'Keefe",
      "Values": [
        "aut",
        "dicta"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 512
        }
      }
    }
  ],
  "FolderName": "Cruickshank Inc and Sons",
  "EmailItemId": 466,
  "AccountId": 204,
  "ReceivedAt": "2004-11-04T03:46:54.785131+01:00",
  "InReplyTo": null,
  "RepliedAt": "2024-03-31T03:46:54.785131+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 313
    }
  }
}
```