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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Appointment/GetMySyncAppointments
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StartTime": "2001-08-29T17:37:16.2752421+02:00",
  "EndTime": "2004-08-03T17:37:16.2752421+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2010-05-13T17:37:16.2792417+02:00",
    "AppointmentId": 727,
    "AppointmentText": "at",
    "ContactDepartment": "",
    "ContactFullName": "Bryon Homenick",
    "ContactName": "Altenwerth, Collier and Lakin",
    "ContactId": 811,
    "EndDate": "2007-01-05T17:37:16.2792417+01:00",
    "HasAlarm": false,
    "IsAllDay": true,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": false,
    "IsTentative": true,
    "Location": "explicabo",
    "Participants": [
      {
        "PersonId": 769,
        "PersonFirstName": "Langosh, D'Amore and Stark",
        "PersonMiddleName": "Brekke-Howell",
        "PersonLastname": "Goodwin",
        "PersonMrmrs": "est",
        "PersonTitle": "corrupti",
        "PersonPosition": "vel",
        "PersonAcademicTitle": "error",
        "PersonFormalName": "Braun-Brakus",
        "PersonFullName": "Rosario Daugherty IV",
        "ContactId": 687,
        "ContactName": "Gaylord Inc and Sons",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Jailyn Satterfield",
        "EMail": [
          "illum",
          "veritatis"
        ],
        "PhonePrivate": [
          "1-911-577-7836",
          "1-563-952-4865 x244"
        ],
        "PhoneFax": [
          "1-095-159-0375 x895",
          "(612)999-6321 x3653"
        ],
        "PhoneMobile": [
          "560.260.5559 x19325",
          "(780)905-1801 x433"
        ],
        "PhoneDirect": [
          "1-906-496-4034 x593",
          "1-739-777-8424 x36538"
        ],
        "PhoneContact": [
          "(690)827-9651",
          "(870)212-1538 x52519"
        ],
        "Messenger": [
          "est",
          "commodi"
        ],
        "Voip": [
          "eaque",
          "fuga"
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
            "FieldLength": 435
          }
        }
      }
    ],
    "PersonFormalName": "Predovic, Kirlin and Spencer",
    "PersonFullName": "Miss Gina Brakus",
    "PersonId": 607,
    "ProjectId": 947,
    "ProjectName": "Hilll Inc and Sons",
    "SaleId": 932,
    "SaleName": "Stroman LLC",
    "StartDate": "2010-12-09T17:37:16.2802414+01:00",
    "TaskName": "Berge-Rolfson",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 266
      }
    }
  }
]
```