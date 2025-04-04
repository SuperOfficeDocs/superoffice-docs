---
title: POST Agents/EMail/GetEMail
uid: v1EMailAgent_GetEMail
generated: true
---

# POST Agents/EMail/GetEMail

```http
POST /api/v1/Agents/EMail/GetEMail
```

Get en e-mail based on its primary key in the DB


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMail?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetEMail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Id": 544,
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
      "ContactId": 343,
      "ContactName": "Goodwin-Bailey",
      "PersonId": 934,
      "PersonName": "Ebert, Murphy and Moen",
      "AssociateId": 884,
      "Address": "temporibus",
      "EmailId": 879,
      "DuplicatePersonIds": [
        324,
        165
      ],
      "Name": "Zboncak, Hayes and Walsh",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 53
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 491,
      "ContactName": "Connelly-Kunze",
      "PersonId": 408,
      "PersonName": "Muller LLC",
      "AssociateId": 74,
      "Address": "doloremque",
      "EmailId": 467,
      "DuplicatePersonIds": [
        225,
        885
      ],
      "Name": "Cruickshank, Wilkinson and Gutmann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 480,
      "ContactName": "Roob LLC",
      "PersonId": 230,
      "PersonName": "Eichmann-Lockman",
      "AssociateId": 768,
      "Address": "mollitia",
      "EmailId": 757,
      "DuplicatePersonIds": [
        552,
        21
      ],
      "Name": "Veum-Lesch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 719
        }
      }
    }
  ],
  "Subject": "possimus",
  "HTMLBody": "quasi",
  "From": null,
  "Sent": "2000-06-09T13:14:00.4231039+02:00",
  "Size": 658,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "fugiat",
  "PlainBody": "aliquam",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 908,
  "Attachments": [
    {
      "Description": "Organic 6th generation extranet",
      "Filename": "omnis",
      "Size": 515,
      "Type": "quas",
      "Encoding": "temporibus",
      "Id": "nostrum",
      "Disposition": "nihil",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 32
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "O'Kon, Gusikowski and Schultz",
      "Values": [
        "doloribus",
        "velit"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 296
        }
      }
    },
    {
      "Name": "O'Kon, Gusikowski and Schultz",
      "Values": [
        "doloribus",
        "velit"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 296
        }
      }
    }
  ],
  "FolderName": "Ondricka, Wisozk and Willms",
  "EmailItemId": 385,
  "AccountId": 451,
  "ReceivedAt": "2004-10-25T13:14:00.4231039+02:00",
  "InReplyTo": null,
  "RepliedAt": "2011-06-14T13:14:00.4231039+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 496
    }
  }
}
```