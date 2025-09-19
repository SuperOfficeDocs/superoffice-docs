---
title: POST Agents/Appointment/GetMySyncAppointments
uid: v1AppointmentAgent_GetMySyncAppointments
generated: true
content_type: reference
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StartTime": "2000-04-20T03:41:52.8088865+02:00",
  "EndTime": "2003-06-21T03:41:52.8088865+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2022-07-23T03:41:52.8088865+02:00",
    "AppointmentId": 850,
    "AppointmentText": "ut",
    "ContactDepartment": "",
    "ContactFullName": "Ms. Kristina Heller Sr.",
    "ContactName": "Stanton-Frami",
    "ContactId": 482,
    "EndDate": "2019-04-08T03:41:52.8088865+02:00",
    "HasAlarm": false,
    "IsAllDay": false,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": true,
    "IsTentative": false,
    "Location": "aut",
    "Participants": [
      {
        "PersonId": 266,
        "PersonFirstName": "Simonis Group",
        "PersonMiddleName": "Senger, White and O'Keefe",
        "PersonLastname": "Krajcik",
        "PersonMrmrs": "aut",
        "PersonTitle": "unde",
        "PersonPosition": "doloribus",
        "PersonAcademicTitle": "doloremque",
        "PersonFormalName": "Funk Inc and Sons",
        "PersonFullName": "Reese Wilderman",
        "ContactId": 777,
        "ContactName": "Pfeffer-Casper",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Rodrick Bergnaum Sr.",
        "EMail": [
          "voluptatem",
          "amet"
        ],
        "PhonePrivate": [
          "870.378.9778 x5083",
          "1-023-733-8911"
        ],
        "PhoneFax": [
          "768-756-5338 x3101",
          "298-135-2358"
        ],
        "PhoneMobile": [
          "1-704-560-4668",
          "(493)162-6597 x1303"
        ],
        "PhoneDirect": [
          "021.124.5590 x331",
          "(355)469-4211 x284"
        ],
        "PhoneContact": [
          "(138)246-8979",
          "425.195.6715 x74612"
        ],
        "Messenger": [
          "quaerat",
          "dolores"
        ],
        "Voip": [
          "quia",
          "officia"
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
            "FieldLength": 158
          }
        }
      }
    ],
    "PersonFormalName": "Haag Inc and Sons",
    "PersonFullName": "Idell D'Amore",
    "PersonId": 573,
    "ProjectId": 447,
    "ProjectName": "Kerluke, Stoltenberg and O'Kon",
    "SaleId": 624,
    "SaleName": "Monahan Group",
    "StartDate": "2019-04-09T03:41:52.8088865+02:00",
    "TaskName": "Buckridge, Hermiston and Parisian",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 454
      }
    }
  }
]
```