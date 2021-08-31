---
title: GetMySyncAppointments
id: v1AppointmentAgent_GetMySyncAppointments
---

# GetMySyncAppointments

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
| StartTime | date-time |  |
| EndTime | date-time |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Appointment/GetMySyncAppointments
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StartTime": "2014-11-28T14:58:03.1055728+01:00",
  "EndTime": "2021-01-20T14:58:03.1055728+01:00"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2008-11-04T14:58:03.1075676+01:00",
    "AppointmentId": 963,
    "AppointmentText": "veritatis",
    "ContactDepartment": "",
    "ContactFullName": "Richie Fisher PhD",
    "ContactName": "Shanahan, Reichert and Moen",
    "ContactId": 2,
    "EndDate": "2004-09-01T14:58:03.1075676+02:00",
    "HasAlarm": true,
    "IsAllDay": false,
    "IsAssignment": true,
    "IsBusy": true,
    "IsCompleted": false,
    "IsInvitation": false,
    "IsTentative": true,
    "Location": "assumenda",
    "Participants": [
      {
        "PersonId": 416,
        "PersonFirstName": "Osinski, Vandervort and Hickle",
        "PersonMiddleName": "Beier Group",
        "PersonLastname": "Morar",
        "PersonMrmrs": "accusamus",
        "PersonTitle": "autem",
        "PersonPosition": "officiis",
        "PersonAcademicTitle": "consequuntur",
        "PersonFormalName": "Greenfelder-Kuhn",
        "PersonFullName": "Jack Abbott",
        "ContactId": 149,
        "ContactName": "Adams Inc and Sons",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Dr. Mayra Boehm",
        "EMail": [
          "eligendi",
          "ex"
        ],
        "PhonePrivate": [
          "(876)680-8150 x627",
          "806-387-4537 x4760"
        ],
        "PhoneFax": [
          "265.401.5473 x3006",
          "1-521-268-0264 x82481"
        ],
        "PhoneMobile": [
          "(373)230-7732",
          "805.647.3126 x427"
        ],
        "PhoneDirect": [
          "380-171-5528",
          "644-533-7331"
        ],
        "PhoneContact": [
          "(064)407-8385",
          "080.764.1826 x547"
        ],
        "Messenger": [
          "eveniet",
          "nulla"
        ],
        "Voip": [
          "culpa",
          "commodi"
        ],
        "ContactUrl": [
          "http://www.example.com/",
          "http://www.example.com/"
        ],
        "Url": [
          "http://www.example.com/",
          "http://www.example.com/"
        ],
        "StreetAddress": {},
        "PostalAddress": {},
        "Country": "Sokovia",
        "PersonAddress": {},
        "PersonCountry": "Sokovia",
        "ParticipantStatus": "Assignment",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 672
          }
        }
      }
    ],
    "PersonFormalName": "Beatty-Rolfson",
    "PersonFullName": "Thad Bayer",
    "PersonId": 644,
    "ProjectId": 117,
    "ProjectName": "Lemke-King",
    "SaleId": 620,
    "SaleName": "Hermiston, Dibbert and Keebler",
    "StartDate": "1998-11-03T14:58:03.1085663+01:00",
    "TaskName": "Kautzer-Gerlach",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "reinvent mission-critical markets"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 192
      }
    }
  }
]
```