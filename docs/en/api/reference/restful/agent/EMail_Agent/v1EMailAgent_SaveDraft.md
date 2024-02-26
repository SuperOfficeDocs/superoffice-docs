---
title: POST Agents/EMail/SaveDraft
uid: v1EMailAgent_SaveDraft
generated: true
---

# POST Agents/EMail/SaveDraft

```http
POST /api/v1/Agents/EMail/SaveDraft
```

Save the Email entity to the drafts folder


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/SaveDraft?$select=name,department,category/id
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

Entity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Entity | EMailEntity | All information about an e-mail <para /> Carrier object for EMailEntity. Services for the EMailEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |

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
POST /api/v1/Agents/EMail/SaveDraft
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Entity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 402,
      "ContactName": "Gibson LLC",
      "PersonId": 769,
      "PersonName": "Okuneva-Sawayn",
      "AssociateId": 26,
      "Address": "est",
      "EmailId": 623,
      "DuplicatePersonIds": [
        631,
        775
      ],
      "Name": "Mohr Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 43
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 457,
      "ContactName": "Daniel LLC",
      "PersonId": 164,
      "PersonName": "Bailey, Huel and Ziemann",
      "AssociateId": 983,
      "Address": "laboriosam",
      "EmailId": 52,
      "DuplicatePersonIds": [
        710,
        643
      ],
      "Name": "Skiles Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 744
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 696,
      "ContactName": "Gusikowski-Quitzon",
      "PersonId": 764,
      "PersonName": "Stamm, McDermott and White",
      "AssociateId": 871,
      "Address": "repellendus",
      "EmailId": 301,
      "DuplicatePersonIds": [
        917,
        371
      ],
      "Name": "Corwin, Kuhn and Tremblay",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 439
        }
      }
    }
  ],
  "Subject": "eius",
  "HTMLBody": "velit",
  "From": null,
  "Sent": "2018-06-26T10:30:23.7511796+02:00",
  "Size": 933,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "est",
  "PlainBody": "quidem",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 445,
  "Attachments": [
    {
      "Description": "Innovative responsive leverage",
      "Filename": "illo",
      "Size": 955,
      "Type": "aperiam",
      "Encoding": "dolore",
      "Id": "illo",
      "Disposition": "non",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 122
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Hintz-Bergstrom",
      "Values": [
        "velit",
        "qui"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 91
        }
      }
    },
    {
      "Name": "Hintz-Bergstrom",
      "Values": [
        "velit",
        "qui"
      ],
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
  "FolderName": "Konopelski-Mueller",
  "EmailItemId": 290,
  "AccountId": 983,
  "ReceivedAt": "2018-05-23T10:30:23.7511796+02:00",
  "InReplyTo": null,
  "RepliedAt": "2015-10-19T10:30:23.7511796+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 451
    }
  }
}
```