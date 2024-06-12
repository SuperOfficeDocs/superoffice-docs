---
title: POST Agents/Appointment/GetMySyncAppointments
uid: v1AppointmentAgent_GetMySyncAppointments
generated: true
---

# POST Agents/Appointment/GetMySyncAppointments

```http
POST /api/v1/Agents/Appointment/GetMySyncAppointments
```

Method that returns a specified number of appointments within a time range.


The appointments belong to the currently logged on user.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetMySyncAppointments?$select=name,department,category/id
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

StartTime, EndTime 

| Property Name | Type |  Description |
|----------------|------|--------------|
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
| AlarmTime | date-time | Date and time at which to show alarm |
| AppointmentId | int32 | Primary key |
| AppointmentText | string | The appointment's textbox; holds a descriptive text about the appointment. Filled out by the user. |
| ContactDepartment | string | The department of the contact connected to the appointment |
| ContactFullName | string | The entire name of the contact, including department name |
| ContactName | string | The contact associated with the appointment. |
| ContactId | int32 | The contacts identifier |
| EndDate | date-time | Date + end time planned |
| HasAlarm | bool | Does this appointment have an alarm |
| IsAllDay | bool |  |
| IsAssignment | bool |  |
| IsBusy | bool |  |
| IsCompleted | bool |  |
| IsInvitation | bool |  |
| IsTentative | bool |  |
| Location | string | Location for appointment, defaulted from invited resource of type place and other rules, but you can write anything you want here |
| Participants | array |  |
| PersonFormalName | string |  |
| PersonFullName | string | The full name of the person this appointment belongs to. |
| PersonId | int32 | Person ID of person the appointment is with, may be 0 |
| ProjectId | int32 | ID of project referred to, may be 0 |
| ProjectName | string | Project name |
| SaleId | int32 | Owning sale, if any (may be 0) |
| SaleName | string | Sale heading (short description?) |
| StartDate | date-time | date + start time planned |
| TaskName | string |  |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/GetMySyncAppointments
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StartTime": "2009-02-15T04:22:25.6990591+01:00",
  "EndTime": "2013-08-20T04:22:25.6990591+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2013-08-25T04:22:25.6990591+02:00",
    "AppointmentId": 463,
    "AppointmentText": "qui",
    "ContactDepartment": "",
    "ContactFullName": "Giovanny Hickle",
    "ContactName": "Hand-Morar",
    "ContactId": 487,
    "EndDate": "2020-11-03T04:22:25.6990591+01:00",
    "HasAlarm": true,
    "IsAllDay": false,
    "IsAssignment": false,
    "IsBusy": true,
    "IsCompleted": false,
    "IsInvitation": true,
    "IsTentative": false,
    "Location": "beatae",
    "Participants": [
      {
        "PersonId": 552,
        "PersonFirstName": "Lubowitz Inc and Sons",
        "PersonMiddleName": "Bergnaum, Weissnat and Durgan",
        "PersonLastname": "Bode",
        "PersonMrmrs": "aut",
        "PersonTitle": "ut",
        "PersonPosition": "optio",
        "PersonAcademicTitle": "illum",
        "PersonFormalName": "Klocko-Wolff",
        "PersonFullName": "Tressa Wiegand PhD",
        "ContactId": 893,
        "ContactName": "Cronin-Keeling",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Prof. Shanelle Quitzon",
        "EMail": [
          "molestias",
          "facilis"
        ],
        "PhonePrivate": [
          "889.700.2127 x577",
          "120.919.5433"
        ],
        "PhoneFax": [
          "1-721-935-5648",
          "(888)382-9919"
        ],
        "PhoneMobile": [
          "(192)763-8401",
          "998-729-5297"
        ],
        "PhoneDirect": [
          "1-995-096-9687",
          "676.420.3196 x927"
        ],
        "PhoneContact": [
          "1-086-907-5170",
          "085-149-1252"
        ],
        "Messenger": [
          "dolore",
          "itaque"
        ],
        "Voip": [
          "voluptatibus",
          "libero"
        ],
        "ContactUrl": [
          "http://www.example.com/",
          "http://www.example.com/"
        ],
        "Url": [
          "http://www.example.com/",
          "http://www.example.com/"
        ],
        "StreetAddress": null,
        "PostalAddress": null,
        "Country": "Sokovia",
        "PersonAddress": null,
        "PersonCountry": "Sokovia",
        "ParticipantStatus": "Assignment",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 757
          }
        }
      }
    ],
    "PersonFormalName": "Pfeffer-Windler",
    "PersonFullName": "Darian Strosin",
    "PersonId": 97,
    "ProjectId": 841,
    "ProjectName": "Labadie Inc and Sons",
    "SaleId": 987,
    "SaleName": "King Inc and Sons",
    "StartDate": "2017-12-09T04:22:25.6990591+01:00",
    "TaskName": "Auer Group",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 788
      }
    }
  }
]
```