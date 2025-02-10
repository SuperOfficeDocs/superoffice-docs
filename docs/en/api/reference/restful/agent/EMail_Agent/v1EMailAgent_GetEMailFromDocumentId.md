---
title: POST Agents/EMail/GetEMailFromDocumentId
uid: v1EMailAgent_GetEMailFromDocumentId
generated: true
---

# POST Agents/EMail/GetEMailFromDocumentId

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentId
```

Get an e-mail based on an archived document


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentId?$select=name,department,category/id
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

DocumentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | Integer |  |

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
POST /api/v1/Agents/EMail/GetEMailFromDocumentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 368
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 766,
      "ContactName": "Fisher Group",
      "PersonId": 684,
      "PersonName": "Barton-Fahey",
      "AssociateId": 544,
      "Address": "qui",
      "EmailId": 466,
      "DuplicatePersonIds": [
        859,
        11
      ],
      "Name": "Keebler, Reilly and Mosciski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 144
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 547,
      "ContactName": "Hoppe-Rempel",
      "PersonId": 5,
      "PersonName": "Gleason, Lockman and Hermann",
      "AssociateId": 597,
      "Address": "possimus",
      "EmailId": 157,
      "DuplicatePersonIds": [
        223,
        700
      ],
      "Name": "Emmerich, Strosin and Considine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 548,
      "ContactName": "Purdy, Ebert and Robel",
      "PersonId": 758,
      "PersonName": "Padberg Inc and Sons",
      "AssociateId": 6,
      "Address": "quaerat",
      "EmailId": 989,
      "DuplicatePersonIds": [
        244,
        621
      ],
      "Name": "Zboncak-Bashirian",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 723
        }
      }
    }
  ],
  "Subject": "pariatur",
  "HTMLBody": "ea",
  "From": null,
  "Sent": "2000-11-27T12:01:27.8377848+01:00",
  "Size": 35,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "aliquam",
  "PlainBody": "quibusdam",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 652,
  "Attachments": [
    {
      "Description": "Cloned mobile customer loyalty",
      "Filename": "debitis",
      "Size": 222,
      "Type": "quia",
      "Encoding": "numquam",
      "Id": "sint",
      "Disposition": "molestiae",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 4
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Torphy-Volkman",
      "Values": [
        "odit",
        "nihil"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 969
        }
      }
    },
    {
      "Name": "Torphy-Volkman",
      "Values": [
        "odit",
        "nihil"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 969
        }
      }
    }
  ],
  "FolderName": "Herman, Moore and Bruen",
  "EmailItemId": 532,
  "AccountId": 647,
  "ReceivedAt": "2006-03-06T12:01:27.8377848+01:00",
  "InReplyTo": null,
  "RepliedAt": "2001-06-11T12:01:27.8377848+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 682
    }
  }
}
```