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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "FileName": "VonRueden-Kerluke"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 404,
      "ContactName": "Stehr, Gislason and VonRueden",
      "PersonId": 140,
      "PersonName": "Corkery-Bradtke",
      "AssociateId": 40,
      "Address": "veniam",
      "EmailId": 740,
      "DuplicatePersonIds": [
        722,
        361
      ],
      "Name": "Anderson, White and Nicolas",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 868
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 131,
      "ContactName": "Romaguera Group",
      "PersonId": 898,
      "PersonName": "Stoltenberg Inc and Sons",
      "AssociateId": 814,
      "Address": "saepe",
      "EmailId": 204,
      "DuplicatePersonIds": [
        951,
        851
      ],
      "Name": "Blick, Haley and Heller",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 918
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 220,
      "ContactName": "Beahan, Emmerich and Bailey",
      "PersonId": 673,
      "PersonName": "Heller-Block",
      "AssociateId": 820,
      "Address": "fugit",
      "EmailId": 139,
      "DuplicatePersonIds": [
        777,
        337
      ],
      "Name": "Leannon Group",
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
  "Subject": "quae",
  "HTMLBody": "quia",
  "From": null,
  "Sent": "2022-03-14T12:19:45.3359926+01:00",
  "Size": 467,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "velit",
  "PlainBody": "dolore",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 351,
  "Attachments": [
    {
      "Description": "Triple-buffered high-level utilisation",
      "Filename": "dolor",
      "Size": 970,
      "Type": "perferendis",
      "Encoding": "dicta",
      "Id": "et",
      "Disposition": "quae",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 361
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Mueller, Rogahn and Satterfield",
      "Values": [
        "neque",
        "est"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 788
        }
      }
    },
    {
      "Name": "Mueller, Rogahn and Satterfield",
      "Values": [
        "neque",
        "est"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 788
        }
      }
    }
  ],
  "FolderName": "Muller Group",
  "EmailItemId": 772,
  "AccountId": 776,
  "ReceivedAt": "2005-08-21T12:19:45.3359926+02:00",
  "InReplyTo": null,
  "RepliedAt": "2008-04-25T12:19:45.3359926+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 122
    }
  }
}
```