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
  "StartTime": "2007-07-25T14:32:01.6555155+02:00",
  "EndTime": "2001-01-12T14:32:01.6555155+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2003-03-29T14:32:01.6555155+01:00",
    "AppointmentId": 775,
    "AppointmentText": "fugit",
    "ContactDepartment": "",
    "ContactFullName": "Alvah Prudence Mante II",
    "ContactName": "Smitham, Doyle and Thiel",
    "ContactId": 700,
    "EndDate": "2014-03-23T14:32:01.6555155+01:00",
    "HasAlarm": true,
    "IsAllDay": false,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": false,
    "IsTentative": false,
    "Location": "at",
    "Participants": [
      {
        "PersonId": 376,
        "PersonFirstName": "Greenholt-Macejkovic",
        "PersonMiddleName": "Stokes LLC",
        "PersonLastname": "Torp",
        "PersonMrmrs": "exercitationem",
        "PersonTitle": "non",
        "PersonPosition": "sapiente",
        "PersonAcademicTitle": "culpa",
        "PersonFormalName": "Murphy, Blick and Schuster",
        "PersonFullName": "Prof. Cathy Aurore Bashirian",
        "ContactId": 973,
        "ContactName": "Herzog LLC",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Jackeline Braun",
        "EMail": [
          "deleniti",
          "et"
        ],
        "PhonePrivate": [
          "220.934.6185 x6861",
          "(914)472-7806 x07303"
        ],
        "PhoneFax": [
          "034-824-0189",
          "(965)553-6846 x06184"
        ],
        "PhoneMobile": [
          "674.614.8607 x2753",
          "948.975.2502"
        ],
        "PhoneDirect": [
          "1-823-461-7544 x74789",
          "(926)019-9460 x745"
        ],
        "PhoneContact": [
          "584-575-0666",
          "207.928.0513 x0982"
        ],
        "Messenger": [
          "et",
          "aliquam"
        ],
        "Voip": [
          "rerum",
          "ex"
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
            "FieldLength": 544
          }
        }
      }
    ],
    "PersonFormalName": "Ledner-Dach",
    "PersonFullName": "Jarret Lang",
    "PersonId": 563,
    "ProjectId": 214,
    "ProjectName": "Romaguera, Fahey and Keeling",
    "SaleId": 915,
    "SaleName": "Schmeler Group",
    "StartDate": "2000-12-27T14:32:01.6555155+01:00",
    "TaskName": "Zboncak-Vandervort",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 993
      }
    }
  }
]
```