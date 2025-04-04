---
title: POST Agents/EMail/GetEMailFromTemp
uid: v1EMailAgent_GetEMailFromTemp
generated: true
---

# POST Agents/EMail/GetEMailFromTemp

```http
POST /api/v1/Agents/EMail/GetEMailFromTemp
```

<para />


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromTemp?$select=name,department,category/id
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

FileName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| FileName | String |  |

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
POST /api/v1/Agents/EMail/GetEMailFromTemp
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "FileName": "Ortiz, Nikolaus and Lubowitz"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 474,
      "ContactName": "Herman, Johnston and Windler",
      "PersonId": 202,
      "PersonName": "Berge-Veum",
      "AssociateId": 966,
      "Address": "reiciendis",
      "EmailId": 561,
      "DuplicatePersonIds": [
        839,
        714
      ],
      "Name": "Nikolaus-Nicolas",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 138
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 289,
      "ContactName": "Jacobs, Frami and Gulgowski",
      "PersonId": 530,
      "PersonName": "Beier-Beatty",
      "AssociateId": 552,
      "Address": "distinctio",
      "EmailId": 945,
      "DuplicatePersonIds": [
        947,
        648
      ],
      "Name": "Bartell, Turner and Wiza",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 491,
      "ContactName": "Vandervort-Jenkins",
      "PersonId": 398,
      "PersonName": "Krajcik LLC",
      "AssociateId": 652,
      "Address": "voluptatem",
      "EmailId": 673,
      "DuplicatePersonIds": [
        829,
        463
      ],
      "Name": "Satterfield LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 186
        }
      }
    }
  ],
  "Subject": "et",
  "HTMLBody": "temporibus",
  "From": null,
  "Sent": "2014-08-24T13:14:00.4231039+02:00",
  "Size": 713,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "tempore",
  "PlainBody": "soluta",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 567,
  "Attachments": [
    {
      "Description": "Seamless bi-directional system engine",
      "Filename": "quod",
      "Size": 245,
      "Type": "aut",
      "Encoding": "fugiat",
      "Id": "iste",
      "Disposition": "autem",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 665
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Hauck-Dickens",
      "Values": [
        "aut",
        "numquam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    },
    {
      "Name": "Hauck-Dickens",
      "Values": [
        "aut",
        "numquam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    }
  ],
  "FolderName": "Schmeler-Kohler",
  "EmailItemId": 71,
  "AccountId": 676,
  "ReceivedAt": "2013-12-31T13:14:00.4231039+01:00",
  "InReplyTo": null,
  "RepliedAt": "2001-05-31T13:14:00.4231039+02:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 131
    }
  }
}
```