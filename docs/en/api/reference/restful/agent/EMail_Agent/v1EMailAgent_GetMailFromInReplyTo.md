---
title: POST Agents/EMail/GetMailFromInReplyTo
uid: v1EMailAgent_GetMailFromInReplyTo
generated: true
---

# POST Agents/EMail/GetMailFromInReplyTo

```http
POST /api/v1/Agents/EMail/GetMailFromInReplyTo
```

Get email from db based on In-Reply-To Message Id


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetMailFromInReplyTo?$select=name,department,category/id
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

MessageId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MessageId | String |  |

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
POST /api/v1/Agents/EMail/GetMailFromInReplyTo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MessageId": "consequatur"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 107,
      "ContactName": "Ferry Inc and Sons",
      "PersonId": 948,
      "PersonName": "Towne-Hamill",
      "AssociateId": 178,
      "Address": "eum",
      "EmailId": 966,
      "DuplicatePersonIds": [
        542,
        410
      ],
      "Name": "Barrows-Kuhn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 428
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 871,
      "ContactName": "Willms Inc and Sons",
      "PersonId": 129,
      "PersonName": "Nikolaus-Glover",
      "AssociateId": 542,
      "Address": "doloribus",
      "EmailId": 317,
      "DuplicatePersonIds": [
        691,
        277
      ],
      "Name": "Lueilwitz-Kessler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 77
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 637,
      "ContactName": "Schultz, Schuppe and Mohr",
      "PersonId": 129,
      "PersonName": "Bruen-Kautzer",
      "AssociateId": 622,
      "Address": "eveniet",
      "EmailId": 814,
      "DuplicatePersonIds": [
        868,
        968
      ],
      "Name": "McKenzie, Beatty and Senger",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 500
        }
      }
    }
  ],
  "Subject": "consequatur",
  "HTMLBody": "adipisci",
  "From": null,
  "Sent": "2017-06-04T16:54:55.3104198+02:00",
  "Size": 210,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "nam",
  "PlainBody": "totam",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 580,
  "Attachments": [
    {
      "Description": "Devolved cohesive application",
      "Filename": "praesentium",
      "Size": 911,
      "Type": "minus",
      "Encoding": "in",
      "Id": "quae",
      "Disposition": "itaque",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 352
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Steuber-Smitham",
      "Values": [
        "esse",
        "sunt"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 923
        }
      }
    },
    {
      "Name": "Steuber-Smitham",
      "Values": [
        "esse",
        "sunt"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 923
        }
      }
    }
  ],
  "FolderName": "Ryan-Feest",
  "EmailItemId": 361,
  "AccountId": 541,
  "ReceivedAt": "1999-04-17T16:54:55.3104198+02:00",
  "InReplyTo": null,
  "RepliedAt": "2020-06-08T16:54:55.3104198+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 41
    }
  }
}
```