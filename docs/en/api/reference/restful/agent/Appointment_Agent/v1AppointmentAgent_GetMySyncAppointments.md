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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "StartTime": "2017-02-24T12:15:17.6827699+01:00",
  "EndTime": "1996-07-14T12:15:17.6827699+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2011-01-06T12:15:17.6867735+01:00",
    "AppointmentId": 542,
    "AppointmentText": "corrupti",
    "ContactDepartment": "",
    "ContactFullName": "Solon Hoeger",
    "ContactName": "Ritchie-Cronin",
    "ContactId": 63,
    "EndDate": "2016-09-23T12:15:17.6867735+02:00",
    "HasAlarm": false,
    "IsAllDay": false,
    "IsAssignment": true,
    "IsBusy": false,
    "IsCompleted": true,
    "IsInvitation": true,
    "IsTentative": true,
    "Location": "molestiae",
    "Participants": [
      {
        "PersonId": 154,
        "PersonFirstName": "Ankunding LLC",
        "PersonMiddleName": "Bahringer-Nader",
        "PersonLastname": "Hermann",
        "PersonMrmrs": "neque",
        "PersonTitle": "explicabo",
        "PersonPosition": "maxime",
        "PersonAcademicTitle": "autem",
        "PersonFormalName": "Lakin, Halvorson and Mraz",
        "PersonFullName": "Mrs. Zachery Marquardt",
        "ContactId": 689,
        "ContactName": "Ritchie Group",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Rosie Thaddeus Kunze Sr.",
        "EMail": [
          "tempora",
          "iure"
        ],
        "PhonePrivate": [
          "205-205-8279",
          "1-012-386-5234 x011"
        ],
        "PhoneFax": [
          "167.616.6437 x45389",
          "(829)623-7400 x2495"
        ],
        "PhoneMobile": [
          "210-678-8704 x720",
          "658.044.7204"
        ],
        "PhoneDirect": [
          "1-957-825-7213",
          "(533)691-4912 x677"
        ],
        "PhoneContact": [
          "138-945-7799 x24585",
          "161.620.0425 x14054"
        ],
        "Messenger": [
          "voluptatibus",
          "voluptatibus"
        ],
        "Voip": [
          "quis",
          "assumenda"
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
            "FieldLength": 688
          }
        }
      }
    ],
    "PersonFormalName": "Berge, Dach and Ratke",
    "PersonFullName": "Lexi Hamill",
    "PersonId": 886,
    "ProjectId": 583,
    "ProjectName": "Morar-Nikolaus",
    "SaleId": 327,
    "SaleName": "Crist, Goodwin and Stanton",
    "StartDate": "1998-06-19T12:15:17.6877704+02:00",
    "TaskName": "Conn, Gleason and Krajcik",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 111
      }
    }
  }
]
```