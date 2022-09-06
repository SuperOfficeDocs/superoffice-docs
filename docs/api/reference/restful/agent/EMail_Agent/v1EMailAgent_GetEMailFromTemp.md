---
title: POST Agents/EMail/GetEMailFromTemp
uid: v1EMailAgent_GetEMailFromTemp
---

# POST Agents/EMail/GetEMailFromTemp

```http
POST /api/v1/Agents/EMail/GetEMailFromTemp
```

<para />

## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered

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
| FileName | string |  |

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
POST /api/v1/Agents/EMail/GetEMailFromTemp
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "FileName": "Torphy Inc and Sons"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 942,
      "ContactName": "Torp LLC",
      "PersonId": 594,
      "PersonName": "Lynch, Upton and Dicki",
      "AssociateId": 281,
      "Address": "quasi",
      "EmailId": 166,
      "DuplicatePersonIds": [
        232,
        756
      ],
      "Name": "Moore-Fahey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 66
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 641,
      "ContactName": "Larkin Inc and Sons",
      "PersonId": 435,
      "PersonName": "Wiegand, Orn and Walker",
      "AssociateId": 163,
      "Address": "voluptatem",
      "EmailId": 332,
      "DuplicatePersonIds": [
        842,
        392
      ],
      "Name": "Cronin LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 573
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 59,
      "ContactName": "Maggio-Hackett",
      "PersonId": 783,
      "PersonName": "Rosenbaum-Cummerata",
      "AssociateId": 174,
      "Address": "veniam",
      "EmailId": 945,
      "DuplicatePersonIds": [
        71,
        108
      ],
      "Name": "Haley, Veum and Greenholt",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 701
        }
      }
    }
  ],
  "Subject": "omnis",
  "HTMLBody": "voluptatibus",
  "From": null,
  "Sent": "2001-06-29T11:10:26.9734598+02:00",
  "Size": 538,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "facilis",
  "PlainBody": "doloribus",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 493,
  "Attachments": [
    {
      "Description": "De-engineered attitude-oriented pricing structure",
      "Filename": "odio",
      "Size": 247,
      "Type": "dolorum",
      "Encoding": "quo",
      "Id": "officia",
      "Disposition": "aut",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Jaskolski, Ebert and Rogahn",
      "Values": [
        "voluptatem",
        "veniam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 787
        }
      }
    },
    {
      "Name": "Jaskolski, Ebert and Rogahn",
      "Values": [
        "voluptatem",
        "veniam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 787
        }
      }
    }
  ],
  "FolderName": "Zboncak Group",
  "EmailItemId": 599,
  "AccountId": 316,
  "ReceivedAt": "2019-08-10T11:10:26.9734598+02:00",
  "InReplyTo": null,
  "RepliedAt": "2000-05-28T11:10:26.9734598+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 445
    }
  }
}
```
