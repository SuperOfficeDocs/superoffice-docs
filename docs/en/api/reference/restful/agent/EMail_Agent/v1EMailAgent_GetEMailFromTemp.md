---
title: POST Agents/EMail/GetEMailFromTemp
uid: v1EMailAgent_GetEMailFromTemp
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/EMail/GetEMailFromTemp
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "FileName": "Hartmann, Block and Farrell"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 341,
      "ContactName": "Turner LLC",
      "PersonId": 238,
      "PersonName": "McCullough Inc and Sons",
      "AssociateId": 773,
      "Address": "aliquid",
      "EmailId": 324,
      "DuplicatePersonIds": [
        234,
        737
      ],
      "Name": "Frami Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 612
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 118,
      "ContactName": "Halvorson LLC",
      "PersonId": 378,
      "PersonName": "Gottlieb, Waelchi and Kilback",
      "AssociateId": 796,
      "Address": "similique",
      "EmailId": 361,
      "DuplicatePersonIds": [
        549,
        87
      ],
      "Name": "Hamill LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 949
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 831,
      "ContactName": "Corkery-Mitchell",
      "PersonId": 189,
      "PersonName": "Boyer, Volkman and Rowe",
      "AssociateId": 949,
      "Address": "consequatur",
      "EmailId": 63,
      "DuplicatePersonIds": [
        706,
        361
      ],
      "Name": "Bogan Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 26
        }
      }
    }
  ],
  "Subject": "vel",
  "HTMLBody": "vel",
  "From": null,
  "Sent": "2001-03-29T14:19:03.4821464+02:00",
  "Size": 365,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "est",
  "PlainBody": "quae",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 120,
  "Attachments": [
    {
      "Description": "User-centric intermediate algorithm",
      "Filename": "soluta",
      "Size": 918,
      "Type": "est",
      "Encoding": "eum",
      "Id": "est",
      "Disposition": "ipsa",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 473
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Willms Group",
      "Values": [
        "esse",
        "et"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 150
        }
      }
    },
    {
      "Name": "Willms Group",
      "Values": [
        "esse",
        "et"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 150
        }
      }
    }
  ],
  "FolderName": "Cassin, Reichel and Kuhn",
  "EmailItemId": 530,
  "AccountId": 469,
  "ReceivedAt": "2017-02-21T14:19:03.4821464+01:00",
  "InReplyTo": null,
  "RepliedAt": "2020-02-10T14:19:03.4821464+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 135
    }
  }
}
```