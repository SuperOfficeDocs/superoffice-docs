---
title: POST Agents/Appointment/GetAssociatesDiaryInfo
uid: v1AppointmentAgent_GetAssociatesDiaryInfo
generated: true
---

# POST Agents/Appointment/GetAssociatesDiaryInfo

```http
POST /api/v1/Agents/Appointment/GetAssociatesDiaryInfo
```

Fetch appointment info for given associates







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetAssociatesDiaryInfo?$select=name,department,category/id
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

AssociateIds, StartTime, EndTime 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateIds | Array |  |
| StartTime | String |  |
| EndTime | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentId | int32 | The id of the appointment |
| AssociateId | int32 | The id of the associate this appointment belongs to |
| MotherId | int32 | The id of the mother appointment (participants point to this one) |
| StartDate | date-time | The start of the appointment |
| EndDate | date-time | The end of the appointment |
| ColorIndex | string | The color index of the appointment (task) |
| TaskName | string | The name of the appointment task type |
| ContactName | string | The name of the appointment contact. |
| ProjectName | string | The name of the appointment project |
| Title | string | The appointment title (first line of appointment description) |
| Agenda | string | The appointment agenda (the rest of appointment description) |
| IsAllDay | bool | True if the appointment is an all day appointment |
| IsBusy | bool | True if the participant is marked as busy |
| IsRecurring | bool | True if the appointment is part of a recurring series |
| IsVideoMeeting | bool | True if the appointment has a video link |
| HasAlarm | bool | True if the appointment has alarm |
| IsCompleted | bool | True if the appointment is completed |
| IsTentative | bool | True if the appointment is tentative |
| IsBookingMain | bool | True if the appointment is a main booking |
| SendEmail | bool | True if the appointment record has the email flag set |
| AnySendEmail | bool | True if any of the appointment records has the email flag set |
| IsPrivate | bool | True if only visible for the owner |
| RecurrenceInfo | RecurrenceInfo | The recurrence info if the appointment is recurring |
| PersonName | string | The name of the appointment person. |
| IsBooking | bool | True if the appointment is part of a booking |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/GetAssociatesDiaryInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateIds": [
    292,
    161
  ],
  "StartTime": "2023-03-23T17:54:02.3983677+01:00",
  "EndTime": "1998-04-05T17:54:02.3983677+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AppointmentId": 895,
    "AssociateId": 137,
    "MotherId": 363,
    "StartDate": "2021-05-12T17:54:02.3983677+02:00",
    "EndDate": "2023-08-15T17:54:02.3983677+02:00",
    "ColorIndex": "BlueAlt1",
    "TaskName": "Windler-Barton",
    "ContactName": "Hodkiewicz-Marvin",
    "ProjectName": "Murphy LLC",
    "Title": "quia",
    "Agenda": "et",
    "IsAllDay": true,
    "IsBusy": false,
    "IsRecurring": false,
    "IsVideoMeeting": false,
    "HasAlarm": false,
    "IsCompleted": false,
    "IsTentative": false,
    "IsBookingMain": false,
    "SendEmail": false,
    "AnySendEmail": false,
    "IsPrivate": true,
    "RecurrenceInfo": null,
    "PersonName": "Bartoletti LLC",
    "IsBooking": false,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 360
      }
    }
  }
]
```