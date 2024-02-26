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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StartTime": "2022-02-23T10:30:22.7220872+01:00",
  "EndTime": "2019-02-06T10:30:22.7220872+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "1998-10-30T10:30:22.7220872+01:00",
    "AppointmentId": 663,
    "AppointmentText": "consectetur",
    "ContactDepartment": "",
    "ContactFullName": "Shea Erdman",
    "ContactName": "Murphy-Schultz",
    "ContactId": 524,
    "EndDate": "2015-05-12T10:30:22.7220872+02:00",
    "HasAlarm": true,
    "IsAllDay": true,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": true,
    "IsTentative": false,
    "Location": "quo",
    "Participants": [
      {
        "PersonId": 48,
        "PersonFirstName": "Purdy Group",
        "PersonMiddleName": "Spencer Inc and Sons",
        "PersonLastname": "McGlynn",
        "PersonMrmrs": "exercitationem",
        "PersonTitle": "ex",
        "PersonPosition": "pariatur",
        "PersonAcademicTitle": "qui",
        "PersonFormalName": "Nienow-Hyatt",
        "PersonFullName": "Glen Oberbrunner",
        "ContactId": 750,
        "ContactName": "Baumbach, Ortiz and Spinka",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Liam Raina Watsica Sr.",
        "EMail": [
          "culpa",
          "perspiciatis"
        ],
        "PhonePrivate": [
          "1-606-792-2751 x65541",
          "545.283.3808"
        ],
        "PhoneFax": [
          "875-029-3053",
          "063.544.2347 x3733"
        ],
        "PhoneMobile": [
          "1-946-915-2409",
          "376.438.8288"
        ],
        "PhoneDirect": [
          "1-942-075-6915 x797",
          "1-929-106-3279 x5385"
        ],
        "PhoneContact": [
          "1-747-345-2745 x9721",
          "082-397-5656 x7852"
        ],
        "Messenger": [
          "ipsa",
          "ratione"
        ],
        "Voip": [
          "possimus",
          "culpa"
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
            "FieldLength": 464
          }
        }
      }
    ],
    "PersonFormalName": "West, Bartoletti and Weimann",
    "PersonFullName": "Ms. Seamus Oscar Hand IV",
    "PersonId": 377,
    "ProjectId": 185,
    "ProjectName": "Bartoletti-Zieme",
    "SaleId": 590,
    "SaleName": "Schowalter, Schneider and Koch",
    "StartDate": "2001-09-10T10:30:22.7220872+02:00",
    "TaskName": "Jones-Schroeder",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 756
      }
    }
  }
]
```