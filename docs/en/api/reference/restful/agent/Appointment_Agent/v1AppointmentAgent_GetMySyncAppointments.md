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
  "StartTime": "2012-03-17T03:51:26.1469713+01:00",
  "EndTime": "1998-06-24T03:51:26.1469713+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2008-09-09T03:51:26.1469713+02:00",
    "AppointmentId": 871,
    "AppointmentText": "qui",
    "ContactDepartment": "",
    "ContactFullName": "Yessenia George Brakus DVM",
    "ContactName": "Jacobson, Berge and Cruickshank",
    "ContactId": 800,
    "EndDate": "2007-11-17T03:51:26.1469713+01:00",
    "HasAlarm": false,
    "IsAllDay": true,
    "IsAssignment": false,
    "IsBusy": true,
    "IsCompleted": true,
    "IsInvitation": true,
    "IsTentative": false,
    "Location": "tempora",
    "Participants": [
      {
        "PersonId": 388,
        "PersonFirstName": "Torphy, Hagenes and Toy",
        "PersonMiddleName": "Champlin Inc and Sons",
        "PersonLastname": "Weimann",
        "PersonMrmrs": "in",
        "PersonTitle": "accusantium",
        "PersonPosition": "eligendi",
        "PersonAcademicTitle": "itaque",
        "PersonFormalName": "Gorczany-Green",
        "PersonFullName": "Annabell Bashirian",
        "ContactId": 853,
        "ContactName": "Turcotte Group",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Stephanie Schuppe",
        "EMail": [
          "cupiditate",
          "omnis"
        ],
        "PhonePrivate": [
          "583-420-1559",
          "1-655-259-2800 x450"
        ],
        "PhoneFax": [
          "1-610-945-4484 x06891",
          "1-186-382-3833 x320"
        ],
        "PhoneMobile": [
          "1-662-921-2881 x65505",
          "1-850-655-9876 x8860"
        ],
        "PhoneDirect": [
          "728.485.8088 x6405",
          "(462)887-5795"
        ],
        "PhoneContact": [
          "1-599-704-4618",
          "556-454-3212 x1225"
        ],
        "Messenger": [
          "eaque",
          "nesciunt"
        ],
        "Voip": [
          "laboriosam",
          "ullam"
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
            "FieldLength": 639
          }
        }
      }
    ],
    "PersonFormalName": "Beer, Sanford and Turner",
    "PersonFullName": "Miss Berenice Marlin Moore",
    "PersonId": 971,
    "ProjectId": 481,
    "ProjectName": "Smitham, Gutmann and Quigley",
    "SaleId": 291,
    "SaleName": "Kuvalis-Nitzsche",
    "StartDate": "1999-01-27T03:51:26.1469713+01:00",
    "TaskName": "Fahey-Auer",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 375
      }
    }
  }
]
```