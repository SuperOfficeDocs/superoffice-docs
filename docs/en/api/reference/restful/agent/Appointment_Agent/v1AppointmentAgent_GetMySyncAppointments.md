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
  "StartTime": "2016-11-04T04:02:01.0181873+01:00",
  "EndTime": "2019-12-14T04:02:01.0181873+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2005-10-07T04:02:01.0181873+02:00",
    "AppointmentId": 606,
    "AppointmentText": "laborum",
    "ContactDepartment": "",
    "ContactFullName": "Orlando Pfannerstill",
    "ContactName": "Legros-Leffler",
    "ContactId": 952,
    "EndDate": "2019-06-08T04:02:01.0181873+02:00",
    "HasAlarm": false,
    "IsAllDay": false,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": true,
    "IsInvitation": true,
    "IsTentative": false,
    "Location": "quisquam",
    "Participants": [
      {
        "PersonId": 354,
        "PersonFirstName": "McGlynn LLC",
        "PersonMiddleName": "Simonis-Tillman",
        "PersonLastname": "Skiles",
        "PersonMrmrs": "voluptate",
        "PersonTitle": "aut",
        "PersonPosition": "dicta",
        "PersonAcademicTitle": "incidunt",
        "PersonFormalName": "Windler Group",
        "PersonFullName": "Muhammad Hackett IV",
        "ContactId": 107,
        "ContactName": "Rutherford-Jenkins",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Prof. Claude Pagac",
        "EMail": [
          "rem",
          "ipsa"
        ],
        "PhonePrivate": [
          "(167)822-7751 x35218",
          "(938)526-6149 x683"
        ],
        "PhoneFax": [
          "004.335.8630",
          "1-826-024-6193"
        ],
        "PhoneMobile": [
          "1-355-218-4206 x51350",
          "309-520-5036 x09496"
        ],
        "PhoneDirect": [
          "1-494-617-2045",
          "1-309-674-1671 x193"
        ],
        "PhoneContact": [
          "(927)311-4406 x383",
          "(301)123-3938"
        ],
        "Messenger": [
          "qui",
          "sit"
        ],
        "Voip": [
          "aut",
          "consequatur"
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
            "FieldLength": 81
          }
        }
      }
    ],
    "PersonFormalName": "Weimann, Price and Rau",
    "PersonFullName": "Amely Catharine Vandervort II",
    "PersonId": 403,
    "ProjectId": 665,
    "ProjectName": "Grady LLC",
    "SaleId": 343,
    "SaleName": "Satterfield Inc and Sons",
    "StartDate": "2024-08-10T04:02:01.0181873+02:00",
    "TaskName": "Kling-Miller",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 101
      }
    }
  }
]
```