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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 842
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 555,
      "ContactName": "Greenfelder-Kautzer",
      "PersonId": 233,
      "PersonName": "Renner Inc and Sons",
      "AssociateId": 515,
      "Address": "quas",
      "EmailId": 921,
      "DuplicatePersonIds": [
        213,
        212
      ],
      "Name": "Will Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 474
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 705,
      "ContactName": "Sporer-Von",
      "PersonId": 175,
      "PersonName": "Greenfelder-Champlin",
      "AssociateId": 895,
      "Address": "autem",
      "EmailId": 508,
      "DuplicatePersonIds": [
        846,
        997
      ],
      "Name": "Kassulke Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 747
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 763,
      "ContactName": "Brekke-Willms",
      "PersonId": 930,
      "PersonName": "Schamberger, Schimmel and Kertzmann",
      "AssociateId": 249,
      "Address": "temporibus",
      "EmailId": 468,
      "DuplicatePersonIds": [
        677,
        80
      ],
      "Name": "Weimann, Lowe and Turner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 459
        }
      }
    }
  ],
  "Subject": "molestias",
  "HTMLBody": "animi",
  "From": null,
  "Sent": "2021-07-24T16:54:55.3769486+02:00",
  "Size": 1002,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "ea",
  "PlainBody": "placeat",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 333,
  "Attachments": [
    {
      "Description": "Integrated bifurcated moderator",
      "Filename": "amet",
      "Size": 238,
      "Type": "provident",
      "Encoding": "ut",
      "Id": "distinctio",
      "Disposition": "cumque",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 257
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Reichert, Jacobi and Goodwin",
      "Values": [
        "corrupti",
        "esse"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 828
        }
      }
    },
    {
      "Name": "Reichert, Jacobi and Goodwin",
      "Values": [
        "corrupti",
        "esse"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 828
        }
      }
    }
  ],
  "FolderName": "Dibbert, Gleason and Eichmann",
  "EmailItemId": 848,
  "AccountId": 341,
  "ReceivedAt": "2001-05-27T16:54:55.3769486+02:00",
  "InReplyTo": null,
  "RepliedAt": "2018-04-15T16:54:55.3779475+02:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 629
    }
  }
}
```