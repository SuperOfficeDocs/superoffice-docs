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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Id": 702,
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
      "ContactId": 651,
      "ContactName": "Simonis, Kshlerin and Nikolaus",
      "PersonId": 254,
      "PersonName": "Lueilwitz-McGlynn",
      "AssociateId": 665,
      "Address": "eum",
      "EmailId": 764,
      "DuplicatePersonIds": [
        74,
        847
      ],
      "Name": "Becker Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 444
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 837,
      "ContactName": "Koch Inc and Sons",
      "PersonId": 980,
      "PersonName": "Ruecker-Runolfsdottir",
      "AssociateId": 20,
      "Address": "non",
      "EmailId": 207,
      "DuplicatePersonIds": [
        543,
        880
      ],
      "Name": "Konopelski Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 618
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 179,
      "ContactName": "Larkin, Casper and Walker",
      "PersonId": 169,
      "PersonName": "Hayes-Kozey",
      "AssociateId": 705,
      "Address": "quaerat",
      "EmailId": 775,
      "DuplicatePersonIds": [
        49,
        589
      ],
      "Name": "Armstrong, Schultz and Wilkinson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 22
        }
      }
    }
  ],
  "Subject": "reprehenderit",
  "HTMLBody": "quis",
  "From": null,
  "Sent": "2021-12-19T16:00:40.9768577+01:00",
  "Size": 378,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "et",
  "PlainBody": "itaque",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 525,
  "Attachments": [
    {
      "Description": "Persistent multi-state attitude",
      "Filename": "eum",
      "Size": 12,
      "Type": "et",
      "Encoding": "quibusdam",
      "Id": "dolores",
      "Disposition": "quibusdam",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 900
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Bartoletti-Lynch",
      "Values": [
        "qui",
        "ea"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 297
        }
      }
    },
    {
      "Name": "Bartoletti-Lynch",
      "Values": [
        "qui",
        "ea"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 297
        }
      }
    }
  ],
  "FolderName": "Larkin-Franecki",
  "EmailItemId": 627,
  "AccountId": 51,
  "ReceivedAt": "2021-01-06T16:00:40.9768577+01:00",
  "InReplyTo": null,
  "RepliedAt": "2004-01-01T16:00:40.9768577+01:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 199
    }
  }
}
```