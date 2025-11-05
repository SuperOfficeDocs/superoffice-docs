---
title: POST Agents/EMail/GetMailFromMessageId
uid: v1EMailAgent_GetMailFromMessageId
generated: true
content_type: reference
---

# POST Agents/EMail/GetMailFromMessageId

```http
POST /api/v1/Agents/EMail/GetMailFromMessageId
```

Get email from db based on Message Id


NsApiSlow threshold: 5000 ms.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetMailFromMessageId?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetMailFromMessageId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MessageId": "et"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 990,
      "ContactName": "Ullrich, Spencer and Cummings",
      "PersonId": 508,
      "PersonName": "Lindgren-Schultz",
      "AssociateId": 91,
      "Address": "nobis",
      "EmailId": 663,
      "DuplicatePersonIds": [
        24,
        187
      ],
      "Name": "Goldner Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 676
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 275,
      "ContactName": "Kunde LLC",
      "PersonId": 773,
      "PersonName": "Gulgowski-Eichmann",
      "AssociateId": 41,
      "Address": "id",
      "EmailId": 953,
      "DuplicatePersonIds": [
        80,
        289
      ],
      "Name": "Ryan-Dietrich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 475
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 398,
      "ContactName": "Swaniawski LLC",
      "PersonId": 994,
      "PersonName": "Wolf-Casper",
      "AssociateId": 769,
      "Address": "sunt",
      "EmailId": 388,
      "DuplicatePersonIds": [
        595,
        805
      ],
      "Name": "Koelpin Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    }
  ],
  "Subject": "repellat",
  "HTMLBody": "nihil",
  "From": null,
  "Sent": "2019-02-06T02:30:47.2413353+01:00",
  "Size": 500,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "laudantium",
  "PlainBody": "quibusdam",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 634,
  "Attachments": [
    {
      "Description": "Re-contextualized web-enabled data-warehouse",
      "Filename": "et",
      "Size": 195,
      "Type": "eligendi",
      "Encoding": "et",
      "Id": "maiores",
      "Disposition": "ut",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 480
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Green LLC",
      "Values": [
        "libero",
        "excepturi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 105
        }
      }
    },
    {
      "Name": "Green LLC",
      "Values": [
        "libero",
        "excepturi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 105
        }
      }
    }
  ],
  "FolderName": "Stanton Inc and Sons",
  "EmailItemId": 708,
  "AccountId": 675,
  "ReceivedAt": "2007-05-25T02:30:47.2413353+02:00",
  "InReplyTo": null,
  "RepliedAt": "2014-11-27T02:30:47.2413353+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 471
    }
  }
}
```