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
  "FileName": "Lesch, Anderson and Crooks"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 564,
      "ContactName": "Von, King and Cruickshank",
      "PersonId": 53,
      "PersonName": "Tillman Inc and Sons",
      "AssociateId": 723,
      "Address": "ut",
      "EmailId": 752,
      "DuplicatePersonIds": [
        532,
        338
      ],
      "Name": "Tillman, Mills and Gleichner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 346
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 138,
      "ContactName": "Deckow, Powlowski and Nicolas",
      "PersonId": 394,
      "PersonName": "Beatty, Lehner and Denesik",
      "AssociateId": 720,
      "Address": "at",
      "EmailId": 179,
      "DuplicatePersonIds": [
        206,
        518
      ],
      "Name": "Yost, Gutmann and Labadie",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 156
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 605,
      "ContactName": "Nicolas-Gerlach",
      "PersonId": 429,
      "PersonName": "Heaney, Wyman and Rice",
      "AssociateId": 94,
      "Address": "accusantium",
      "EmailId": 815,
      "DuplicatePersonIds": [
        317,
        477
      ],
      "Name": "Smitham, Kemmer and Corkery",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 136
        }
      }
    }
  ],
  "Subject": "maxime",
  "HTMLBody": "velit",
  "From": null,
  "Sent": "2017-07-08T23:03:56.0101289+02:00",
  "Size": 771,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "dolorum",
  "PlainBody": "voluptates",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 680,
  "Attachments": [
    {
      "Description": "Multi-layered fresh-thinking focus group",
      "Filename": "odio",
      "Size": 818,
      "Type": "et",
      "Encoding": "occaecati",
      "Id": "maiores",
      "Disposition": "nesciunt",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 809
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Donnelly-Schultz",
      "Values": [
        "in",
        "quis"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 379
        }
      }
    },
    {
      "Name": "Donnelly-Schultz",
      "Values": [
        "in",
        "quis"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 379
        }
      }
    }
  ],
  "FolderName": "Mann, Huel and Stanton",
  "EmailItemId": 420,
  "AccountId": 115,
  "ReceivedAt": "2003-04-05T23:03:56.0106282+02:00",
  "InReplyTo": null,
  "RepliedAt": "2002-10-05T23:03:56.0106282+02:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 455
    }
  }
}
```