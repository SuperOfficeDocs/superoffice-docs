---
title: POST Agents/Appointment/GetAppointmentEmailInvitation
uid: v1AppointmentAgent_GetAppointmentEmailInvitation
generated: true
---

# POST Agents/Appointment/GetAppointmentEmailInvitation

```http
POST /api/v1/Agents/Appointment/GetAppointmentEmailInvitation
```

Create an EMailEntity (without an ical attachment) with the email sent to participants when the appointment is saved







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetAppointmentEmailInvitation?$select=name,department,category/id
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

Appointment, TemplateName, Language 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment | AppointmentEntity | Partial AppointmentEntity class associating the generated AppointmentEntity with an interface. |
| TemplateName | String |  |
| Language | String |  |

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
POST /api/v1/Agents/Appointment/GetAppointmentEmailInvitation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "TemplateName": "Brekke LLC",
  "Language": "repudiandae"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 722,
      "ContactName": "Waelchi-Shields",
      "PersonId": 520,
      "PersonName": "Walker-Ernser",
      "AssociateId": 325,
      "Address": "perspiciatis",
      "EmailId": 708,
      "DuplicatePersonIds": [
        937,
        923
      ],
      "Name": "Shields-Heathcote",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 14
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 320,
      "ContactName": "McDermott LLC",
      "PersonId": 192,
      "PersonName": "Schmeler, Stanton and Hansen",
      "AssociateId": 682,
      "Address": "laudantium",
      "EmailId": 284,
      "DuplicatePersonIds": [
        813,
        793
      ],
      "Name": "Sporer-Bogan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 89
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 852,
      "ContactName": "Weimann Inc and Sons",
      "PersonId": 379,
      "PersonName": "Howe-Auer",
      "AssociateId": 369,
      "Address": "qui",
      "EmailId": 233,
      "DuplicatePersonIds": [
        246,
        752
      ],
      "Name": "Smitham-Barrows",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 135
        }
      }
    }
  ],
  "Subject": "sed",
  "HTMLBody": "adipisci",
  "From": null,
  "Sent": "2020-07-01T10:17:55.0821324+02:00",
  "Size": 79,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "recusandae",
  "PlainBody": "quos",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 456,
  "Attachments": [
    {
      "Description": "Re-contextualized reciprocal intranet",
      "Filename": "nulla",
      "Size": 108,
      "Type": "minus",
      "Encoding": "accusantium",
      "Id": "iusto",
      "Disposition": "iure",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 832
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Huels Group",
      "Values": [
        "dolorum",
        "dolore"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 202
        }
      }
    },
    {
      "Name": "Huels Group",
      "Values": [
        "dolorum",
        "dolore"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 202
        }
      }
    }
  ],
  "FolderName": "Prohaska, Shanahan and Paucek",
  "EmailItemId": 748,
  "AccountId": 301,
  "ReceivedAt": "2006-02-25T10:17:55.0821324+01:00",
  "InReplyTo": null,
  "RepliedAt": "2015-10-22T10:17:55.0821324+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 413
    }
  }
}
```