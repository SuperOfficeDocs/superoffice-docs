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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "TemplateName": "Pacocha, Runte and Wuckert",
  "Language": "magni"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 164,
      "ContactName": "McKenzie Group",
      "PersonId": 221,
      "PersonName": "White, Will and Abernathy",
      "AssociateId": 908,
      "Address": "cupiditate",
      "EmailId": 181,
      "DuplicatePersonIds": [
        146,
        86
      ],
      "Name": "Ebert Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 950,
      "ContactName": "Kling, Rutherford and Marks",
      "PersonId": 489,
      "PersonName": "Will-Howell",
      "AssociateId": 602,
      "Address": "eligendi",
      "EmailId": 774,
      "DuplicatePersonIds": [
        175,
        705
      ],
      "Name": "Grimes Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 960
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 993,
      "ContactName": "Walsh LLC",
      "PersonId": 869,
      "PersonName": "Mohr, Berge and Braun",
      "AssociateId": 782,
      "Address": "quam",
      "EmailId": 201,
      "DuplicatePersonIds": [
        241,
        733
      ],
      "Name": "Hettinger-Conroy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 821
        }
      }
    }
  ],
  "Subject": "sed",
  "HTMLBody": "fugiat",
  "From": null,
  "Sent": "2009-04-21T10:30:23.0201695+02:00",
  "Size": 519,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "delectus",
  "PlainBody": "nobis",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 371,
  "Attachments": [
    {
      "Description": "Team-oriented composite moratorium",
      "Filename": "aut",
      "Size": 891,
      "Type": "qui",
      "Encoding": "voluptate",
      "Id": "recusandae",
      "Disposition": "beatae",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 961
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Wunsch, Fadel and Pfeffer",
      "Values": [
        "qui",
        "iusto"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 278
        }
      }
    },
    {
      "Name": "Wunsch, Fadel and Pfeffer",
      "Values": [
        "qui",
        "iusto"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 278
        }
      }
    }
  ],
  "FolderName": "Schmidt, Steuber and Nienow",
  "EmailItemId": 12,
  "AccountId": 593,
  "ReceivedAt": "2017-10-12T10:30:23.0201695+02:00",
  "InReplyTo": null,
  "RepliedAt": "2013-05-20T10:30:23.0201695+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 39
    }
  }
}
```