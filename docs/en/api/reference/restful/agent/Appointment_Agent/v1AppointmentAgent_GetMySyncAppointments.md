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
  "StartTime": "2019-01-28T03:24:46.9713962+01:00",
  "EndTime": "2003-04-12T03:24:46.9713962+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2000-08-29T03:24:46.9713962+02:00",
    "AppointmentId": 643,
    "AppointmentText": "ut",
    "ContactDepartment": "",
    "ContactFullName": "Holly Larkin",
    "ContactName": "Gleason Inc and Sons",
    "ContactId": 136,
    "EndDate": "2011-03-26T03:24:46.9713962+01:00",
    "HasAlarm": false,
    "IsAllDay": true,
    "IsAssignment": true,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": true,
    "IsTentative": false,
    "Location": "quos",
    "Participants": [
      {
        "PersonId": 344,
        "PersonFirstName": "Ryan, Schroeder and Torp",
        "PersonMiddleName": "Schmitt LLC",
        "PersonLastname": "Schaden",
        "PersonMrmrs": "vel",
        "PersonTitle": "sint",
        "PersonPosition": "eum",
        "PersonAcademicTitle": "earum",
        "PersonFormalName": "Pacocha, Shields and Hackett",
        "PersonFullName": "Mrs. Jaclyn Bailey MD",
        "ContactId": 343,
        "ContactName": "Berge-Thompson",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Cortney Streich",
        "EMail": [
          "voluptatem",
          "molestiae"
        ],
        "PhonePrivate": [
          "916.815.4482",
          "662-256-0104"
        ],
        "PhoneFax": [
          "379.718.9616 x8252",
          "1-690-505-4133 x474"
        ],
        "PhoneMobile": [
          "1-115-973-5272",
          "(567)223-2864"
        ],
        "PhoneDirect": [
          "220-066-6399 x649",
          "(331)235-2648"
        ],
        "PhoneContact": [
          "1-676-624-7772 x586",
          "729.325.8415"
        ],
        "Messenger": [
          "nisi",
          "incidunt"
        ],
        "Voip": [
          "dolorum",
          "voluptas"
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
            "FieldLength": 28
          }
        }
      }
    ],
    "PersonFormalName": "Wiza, Mosciski and Kilback",
    "PersonFullName": "Marianne Brown",
    "PersonId": 88,
    "ProjectId": 761,
    "ProjectName": "Koss-Torp",
    "SaleId": 449,
    "SaleName": "Medhurst, Franecki and Leannon",
    "StartDate": "2009-02-07T03:24:46.9713962+01:00",
    "TaskName": "Bergstrom Group",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 542
      }
    }
  }
]
```