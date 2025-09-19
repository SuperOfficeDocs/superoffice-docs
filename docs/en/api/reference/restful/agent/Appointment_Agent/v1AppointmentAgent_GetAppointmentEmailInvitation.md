---
title: POST Agents/Appointment/GetAppointmentEmailInvitation
uid: v1AppointmentAgent_GetAppointmentEmailInvitation
generated: true
content_type: reference
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "TemplateName": "Dooley, Monahan and Schmitt",
  "Language": "beatae"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 856,
      "ContactName": "Halvorson Group",
      "PersonId": 481,
      "PersonName": "Mayert-Bayer",
      "AssociateId": 302,
      "Address": "et",
      "EmailId": 736,
      "DuplicatePersonIds": [
        972,
        175
      ],
      "Name": "Hermiston-Reynolds",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 703
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 425,
      "ContactName": "Schmidt, Turner and Cassin",
      "PersonId": 555,
      "PersonName": "Halvorson, Yundt and Koelpin",
      "AssociateId": 678,
      "Address": "et",
      "EmailId": 629,
      "DuplicatePersonIds": [
        632,
        485
      ],
      "Name": "Swift Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 205
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 858,
      "ContactName": "Heaney-Stamm",
      "PersonId": 194,
      "PersonName": "Koss LLC",
      "AssociateId": 916,
      "Address": "error",
      "EmailId": 628,
      "DuplicatePersonIds": [
        112,
        739
      ],
      "Name": "Gleason, Zemlak and Graham",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 72
        }
      }
    }
  ],
  "Subject": "est",
  "HTMLBody": "quo",
  "From": null,
  "Sent": "2017-09-24T03:41:53.0276297+02:00",
  "Size": 427,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "qui",
  "PlainBody": "consequatur",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 543,
  "Attachments": [
    {
      "Description": "Seamless uniform alliance",
      "Filename": "nemo",
      "Size": 110,
      "Type": "numquam",
      "Encoding": "dignissimos",
      "Id": "eius",
      "Disposition": "autem",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 121
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Kautzer, Miller and King",
      "Values": [
        "iste",
        "magnam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 442
        }
      }
    },
    {
      "Name": "Kautzer, Miller and King",
      "Values": [
        "iste",
        "magnam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 442
        }
      }
    }
  ],
  "FolderName": "Murray-Eichmann",
  "EmailItemId": 416,
  "AccountId": 6,
  "ReceivedAt": "2008-02-04T03:41:53.0276297+01:00",
  "InReplyTo": null,
  "RepliedAt": "2024-04-22T03:41:53.0276297+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 474
    }
  }
}
```