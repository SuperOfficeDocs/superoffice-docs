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
  "StartTime": "2014-12-30T13:57:11.2157245+01:00",
  "EndTime": "2013-09-17T13:57:11.2157245+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2023-12-04T13:57:11.2157245+01:00",
    "AppointmentId": 426,
    "AppointmentText": "nostrum",
    "ContactDepartment": "",
    "ContactFullName": "Mary Dach",
    "ContactName": "Raynor, Upton and Walker",
    "ContactId": 274,
    "EndDate": "2005-10-20T13:57:11.2157245+02:00",
    "HasAlarm": true,
    "IsAllDay": false,
    "IsAssignment": true,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": true,
    "IsTentative": false,
    "Location": "exercitationem",
    "Participants": [
      {
        "PersonId": 289,
        "PersonFirstName": "Effertz Group",
        "PersonMiddleName": "Leffler, D'Amore and Kovacek",
        "PersonLastname": "Hamill",
        "PersonMrmrs": "maiores",
        "PersonTitle": "quod",
        "PersonPosition": "fugit",
        "PersonAcademicTitle": "illum",
        "PersonFormalName": "Schimmel LLC",
        "PersonFullName": "Barrett Zieme",
        "ContactId": 95,
        "ContactName": "Robel-Lockman",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Miss Erica Kuhic PhD",
        "EMail": [
          "quos",
          "eum"
        ],
        "PhonePrivate": [
          "(404)393-3574 x006",
          "1-336-597-5165"
        ],
        "PhoneFax": [
          "761.551.5995 x01004",
          "1-029-762-1934 x85563"
        ],
        "PhoneMobile": [
          "1-019-545-5976",
          "351-558-3984"
        ],
        "PhoneDirect": [
          "(779)215-6090 x182",
          "(353)922-2484 x18512"
        ],
        "PhoneContact": [
          "899-952-9132 x460",
          "906.504.5701 x965"
        ],
        "Messenger": [
          "minima",
          "tenetur"
        ],
        "Voip": [
          "quasi",
          "qui"
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
            "FieldLength": 920
          }
        }
      }
    ],
    "PersonFormalName": "Zemlak-Hayes",
    "PersonFullName": "Judah Alivia O'Conner I",
    "PersonId": 166,
    "ProjectId": 177,
    "ProjectName": "Wiegand Inc and Sons",
    "SaleId": 588,
    "SaleName": "Wolf Inc and Sons",
    "StartDate": "2013-09-04T13:57:11.2157245+02:00",
    "TaskName": "Sipes, Hettinger and Stokes",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 433
      }
    }
  }
]
```