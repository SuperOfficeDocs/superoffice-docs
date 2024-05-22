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
  "FileName": "Schumm LLC"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 896,
      "ContactName": "Veum-Kreiger",
      "PersonId": 615,
      "PersonName": "Cormier-Larkin",
      "AssociateId": 473,
      "Address": "aut",
      "EmailId": 195,
      "DuplicatePersonIds": [
        159,
        456
      ],
      "Name": "Walter Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 532
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 754,
      "ContactName": "Bergstrom, Spinka and Daugherty",
      "PersonId": 240,
      "PersonName": "Senger, Hoppe and Hessel",
      "AssociateId": 70,
      "Address": "eos",
      "EmailId": 866,
      "DuplicatePersonIds": [
        153,
        593
      ],
      "Name": "Fadel-Rosenbaum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 171
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 859,
      "ContactName": "Marvin-Yundt",
      "PersonId": 429,
      "PersonName": "Hickle-Durgan",
      "AssociateId": 168,
      "Address": "fugit",
      "EmailId": 956,
      "DuplicatePersonIds": [
        627,
        660
      ],
      "Name": "Ernser-Barrows",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 659
        }
      }
    }
  ],
  "Subject": "ad",
  "HTMLBody": "est",
  "From": null,
  "Sent": "1998-03-04T12:57:33.9773902+01:00",
  "Size": 70,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "et",
  "PlainBody": "beatae",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 479,
  "Attachments": [
    {
      "Description": "Innovative coherent architecture",
      "Filename": "dolor",
      "Size": 822,
      "Type": "labore",
      "Encoding": "nihil",
      "Id": "ut",
      "Disposition": "optio",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 207
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Batz-Turcotte",
      "Values": [
        "iste",
        "nisi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 980
        }
      }
    },
    {
      "Name": "Batz-Turcotte",
      "Values": [
        "iste",
        "nisi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 980
        }
      }
    }
  ],
  "FolderName": "Schmidt Inc and Sons",
  "EmailItemId": 444,
  "AccountId": 208,
  "ReceivedAt": "2022-10-05T12:57:33.9773902+02:00",
  "InReplyTo": null,
  "RepliedAt": "2000-05-17T12:57:33.9773902+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 17
    }
  }
}
```