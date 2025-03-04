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
  "TemplateName": "O'Keefe, Schamberger and Spencer",
  "Language": "id"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 356,
      "ContactName": "Stehr, Rolfson and Wyman",
      "PersonId": 904,
      "PersonName": "Armstrong LLC",
      "AssociateId": 755,
      "Address": "qui",
      "EmailId": 366,
      "DuplicatePersonIds": [
        854,
        238
      ],
      "Name": "Waelchi Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 501
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 455,
      "ContactName": "Huels Inc and Sons",
      "PersonId": 177,
      "PersonName": "Marvin, Funk and Gusikowski",
      "AssociateId": 155,
      "Address": "aut",
      "EmailId": 820,
      "DuplicatePersonIds": [
        70,
        509
      ],
      "Name": "Homenick, Bogan and Medhurst",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 541
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 412,
      "ContactName": "Williamson Group",
      "PersonId": 949,
      "PersonName": "Ratke-Heidenreich",
      "AssociateId": 701,
      "Address": "error",
      "EmailId": 666,
      "DuplicatePersonIds": [
        292,
        530
      ],
      "Name": "Cartwright-Murazik",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 391
        }
      }
    }
  ],
  "Subject": "ipsam",
  "HTMLBody": "at",
  "From": null,
  "Sent": "2005-02-20T14:13:39.2973748+01:00",
  "Size": 242,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "culpa",
  "PlainBody": "aperiam",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 193,
  "Attachments": [
    {
      "Description": "Operative full-range groupware",
      "Filename": "voluptates",
      "Size": 267,
      "Type": "aut",
      "Encoding": "autem",
      "Id": "harum",
      "Disposition": "quisquam",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 291
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Volkman, Kshlerin and Schaden",
      "Values": [
        "vel",
        "optio"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 434
        }
      }
    },
    {
      "Name": "Volkman, Kshlerin and Schaden",
      "Values": [
        "vel",
        "optio"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 434
        }
      }
    }
  ],
  "FolderName": "Conn-Hammes",
  "EmailItemId": 133,
  "AccountId": 893,
  "ReceivedAt": "2012-03-30T14:13:39.2973748+02:00",
  "InReplyTo": null,
  "RepliedAt": "2003-12-13T14:13:39.2973748+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 206
    }
  }
}
```