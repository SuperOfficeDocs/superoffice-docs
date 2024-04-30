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
Accept-Language: fr,de,ru,zh
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
      "ContactId": 511,
      "ContactName": "Huels, Hackett and Larson",
      "PersonId": 948,
      "PersonName": "Swaniawski Group",
      "AssociateId": 17,
      "Address": "ut",
      "EmailId": 973,
      "DuplicatePersonIds": [
        21,
        716
      ],
      "Name": "Davis Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 752
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 714,
      "ContactName": "Kuhlman, Robel and Larkin",
      "PersonId": 11,
      "PersonName": "Corkery-Batz",
      "AssociateId": 91,
      "Address": "aliquam",
      "EmailId": 305,
      "DuplicatePersonIds": [
        277,
        618
      ],
      "Name": "Becker-Runolfsson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 91
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 350,
      "ContactName": "Kub, Barrows and Wiza",
      "PersonId": 207,
      "PersonName": "Jerde, Torphy and Kautzer",
      "AssociateId": 97,
      "Address": "nam",
      "EmailId": 555,
      "DuplicatePersonIds": [
        889,
        494
      ],
      "Name": "Bins-Buckridge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 472
        }
      }
    }
  ],
  "Subject": "eos",
  "HTMLBody": "asperiores",
  "From": null,
  "Sent": "2018-01-03T11:16:09.1784746+01:00",
  "Size": 94,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "deleniti",
  "PlainBody": "corrupti",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 798,
  "Attachments": [
    {
      "Description": "Networked optimal concept",
      "Filename": "quasi",
      "Size": 428,
      "Type": "qui",
      "Encoding": "consequatur",
      "Id": "nesciunt",
      "Disposition": "corporis",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 215
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Lind, Cormier and Hamill",
      "Values": [
        "et",
        "nisi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 599
        }
      }
    },
    {
      "Name": "Lind, Cormier and Hamill",
      "Values": [
        "et",
        "nisi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 599
        }
      }
    }
  ],
  "FolderName": "Reynolds, Bruen and Orn",
  "EmailItemId": 555,
  "AccountId": 334,
  "ReceivedAt": "2019-11-28T11:16:09.1784746+01:00",
  "InReplyTo": null,
  "RepliedAt": "2002-02-14T11:16:09.1784746+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 991
    }
  }
}
```