---
title: POST Agents/EMail/CreateEMailFromDocumentEntity
uid: v1EMailAgent_CreateEMailFromDocumentEntity
---

# POST Agents/EMail/CreateEMailFromDocumentEntity

```http
POST /api/v1/Agents/EMail/CreateEMailFromDocumentEntity
```

Get an e-mail based on the provided DocumentEntity

## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered

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
| DocumentEntity |  | Partial DocumentEntity class associating the generated DocumentEntity with an interface. |

## Response

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
POST /api/v1/Agents/EMail/CreateEMailFromDocumentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
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
      "ContactId": 297,
      "ContactName": "Gottlieb-Luettgen",
      "PersonId": 392,
      "PersonName": "Weissnat, Jacobs and Hayes",
      "AssociateId": 669,
      "Address": "qui",
      "EmailId": 775,
      "DuplicatePersonIds": [
        328,
        811
      ],
      "Name": "Kling-Cummings",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 966
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 180,
      "ContactName": "Daugherty-Homenick",
      "PersonId": 380,
      "PersonName": "Satterfield, Kling and Prosacco",
      "AssociateId": 853,
      "Address": "et",
      "EmailId": 134,
      "DuplicatePersonIds": [
        468,
        135
      ],
      "Name": "Murray, Hilpert and Nolan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 907
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 635,
      "ContactName": "VonRueden, Nienow and Torp",
      "PersonId": 34,
      "PersonName": "Fay Group",
      "AssociateId": 684,
      "Address": "est",
      "EmailId": 996,
      "DuplicatePersonIds": [
        17,
        381
      ],
      "Name": "Carroll Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 394
        }
      }
    }
  ],
  "Subject": "ut",
  "HTMLBody": "necessitatibus",
  "From": null,
  "Sent": "2007-06-12T11:10:26.9654529+02:00",
  "Size": 17,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "tempora",
  "PlainBody": "est",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 162,
  "Attachments": [
    {
      "Description": "Exclusive empowering workforce",
      "Filename": "accusamus",
      "Size": 745,
      "Type": "cumque",
      "Encoding": "deleniti",
      "Id": "temporibus",
      "Disposition": "molestiae",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 549
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Hessel-Bartell",
      "Values": [
        "corporis",
        "tempora"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    },
    {
      "Name": "Hessel-Bartell",
      "Values": [
        "corporis",
        "tempora"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    }
  ],
  "FolderName": "Hane LLC",
  "EmailItemId": 172,
  "AccountId": 448,
  "ReceivedAt": "1999-08-25T11:10:26.9654529+02:00",
  "InReplyTo": null,
  "RepliedAt": "2016-05-18T11:10:26.9654529+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 697
    }
  }
}
```
