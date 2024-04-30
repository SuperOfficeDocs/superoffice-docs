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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "StartTime": "2010-09-18T11:16:08.5220136+02:00",
  "EndTime": "2007-11-27T11:16:08.5220136+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2006-07-19T11:16:08.5220136+02:00",
    "AppointmentId": 99,
    "AppointmentText": "dolor",
    "ContactDepartment": "",
    "ContactFullName": "Zora Klein",
    "ContactName": "Maggio, Herzog and Reilly",
    "ContactId": 53,
    "EndDate": "2012-05-02T11:16:08.5220136+02:00",
    "HasAlarm": false,
    "IsAllDay": true,
    "IsAssignment": true,
    "IsBusy": true,
    "IsCompleted": false,
    "IsInvitation": true,
    "IsTentative": true,
    "Location": "consequatur",
    "Participants": [
      {
        "PersonId": 462,
        "PersonFirstName": "McKenzie LLC",
        "PersonMiddleName": "McGlynn, Brakus and Bernier",
        "PersonLastname": "Rippin",
        "PersonMrmrs": "ut",
        "PersonTitle": "consectetur",
        "PersonPosition": "quas",
        "PersonAcademicTitle": "voluptas",
        "PersonFormalName": "DuBuque Inc and Sons",
        "PersonFullName": "Earlene Kuvalis",
        "ContactId": 663,
        "ContactName": "Heaney, Marks and Ondricka",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Elmo Gerlach",
        "EMail": [
          "vel",
          "sed"
        ],
        "PhonePrivate": [
          "1-983-738-3827 x476",
          "(619)713-7327 x38840"
        ],
        "PhoneFax": [
          "457-928-6194 x48366",
          "026-512-3210 x98440"
        ],
        "PhoneMobile": [
          "(628)498-9400 x041",
          "223-869-7464 x21886"
        ],
        "PhoneDirect": [
          "(963)425-0760 x1470",
          "327-130-3037"
        ],
        "PhoneContact": [
          "562.265.3512",
          "(649)789-5878 x557"
        ],
        "Messenger": [
          "hic",
          "inventore"
        ],
        "Voip": [
          "dolorem",
          "sed"
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
            "FieldLength": 469
          }
        }
      }
    ],
    "PersonFormalName": "Renner, Kohler and Hand",
    "PersonFullName": "Dane Runolfsdottir",
    "PersonId": 736,
    "ProjectId": 414,
    "ProjectName": "Adams, Hills and Douglas",
    "SaleId": 45,
    "SaleName": "Robel, Rogahn and Runolfsson",
    "StartDate": "2015-12-14T11:16:08.5220136+01:00",
    "TaskName": "Daugherty-Halvorson",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 724
      }
    }
  }
]
```