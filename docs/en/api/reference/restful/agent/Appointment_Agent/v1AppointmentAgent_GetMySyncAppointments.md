---
title: POST Agents/Appointment/GetMySyncAppointments
uid: v1AppointmentAgent_GetMySyncAppointments
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
| StartTime | date-time |  |
| EndTime | date-time |  |


## Response: array

OK

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

## Sample request

```http!
POST /api/v1/Agents/Appointment/GetMySyncAppointments
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StartTime": "2007-09-08T02:49:43.261747+02:00",
  "EndTime": "2011-12-13T02:49:43.261747+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "1996-09-28T02:49:43.261747+02:00",
    "AppointmentId": 175,
    "AppointmentText": "non",
    "ContactDepartment": "deliver mission-critical e-tailers",
    "ContactFullName": "Reinhold Rice",
    "ContactName": "Rowe Inc and Sons",
    "ContactId": 599,
    "EndDate": "2021-04-10T02:49:43.261747+02:00",
    "HasAlarm": false,
    "IsAllDay": false,
    "IsAssignment": true,
    "IsBusy": true,
    "IsCompleted": false,
    "IsInvitation": true,
    "IsTentative": false,
    "Location": "quo",
    "Participants": [
      {
        "PersonId": 42,
        "PersonFirstName": "Schoen Group",
        "PersonMiddleName": "Russel-Douglas",
        "PersonLastname": "Predovic",
        "PersonMrmrs": "nulla",
        "PersonTitle": "enim",
        "PersonPosition": "voluptatem",
        "PersonAcademicTitle": "hic",
        "PersonFormalName": "Volkman-Abshire",
        "PersonFullName": "Anika Orn",
        "ContactId": 694,
        "ContactName": "Mitchell, Hettinger and Toy",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Jake Crona",
        "EMail": [
          "et",
          "numquam"
        ],
        "PhonePrivate": [
          "085.145.6946 x239",
          "915.145.6838"
        ],
        "PhoneFax": [
          "1-977-712-0281 x768",
          "(902)166-4057 x482"
        ],
        "PhoneMobile": [
          "041.894.6843",
          "(791)900-9760"
        ],
        "PhoneDirect": [
          "966.983.1672 x1354",
          "128.339.8425 x09301"
        ],
        "PhoneContact": [
          "1-523-931-1225 x2840",
          "1-936-246-8920 x9589"
        ],
        "Messenger": [
          "mollitia",
          "velit"
        ],
        "Voip": [
          "atque",
          "maxime"
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
            "FieldType": "System.String",
            "FieldLength": 676
          }
        }
      }
    ],
    "PersonFormalName": "Heller Group",
    "PersonFullName": "Dr. Seth Taya King",
    "PersonId": 768,
    "ProjectId": 542,
    "ProjectName": "Connelly, Funk and Mraz",
    "SaleId": 34,
    "SaleName": "Hyatt, Leuschke and Macejkovic",
    "StartDate": "2008-12-29T02:49:43.261747+01:00",
    "TaskName": "Mayert, Goldner and Cartwright",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 461
      }
    }
  }
]
```