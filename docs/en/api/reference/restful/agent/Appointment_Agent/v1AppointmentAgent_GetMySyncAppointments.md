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
  "StartTime": "2021-02-08T12:01:27.0252114+01:00",
  "EndTime": "2000-10-13T12:01:27.0252114+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2013-08-21T12:01:27.0408377+02:00",
    "AppointmentId": 693,
    "AppointmentText": "velit",
    "ContactDepartment": "",
    "ContactFullName": "Jana Torphy",
    "ContactName": "Medhurst LLC",
    "ContactId": 289,
    "EndDate": "1998-05-26T12:01:27.0408377+02:00",
    "HasAlarm": true,
    "IsAllDay": false,
    "IsAssignment": false,
    "IsBusy": true,
    "IsCompleted": true,
    "IsInvitation": false,
    "IsTentative": true,
    "Location": "et",
    "Participants": [
      {
        "PersonId": 211,
        "PersonFirstName": "Bechtelar Inc and Sons",
        "PersonMiddleName": "Fisher LLC",
        "PersonLastname": "Mayer",
        "PersonMrmrs": "reprehenderit",
        "PersonTitle": "aut",
        "PersonPosition": "iste",
        "PersonAcademicTitle": "qui",
        "PersonFormalName": "Leffler Inc and Sons",
        "PersonFullName": "Ms. Marcel Mills",
        "ContactId": 32,
        "ContactName": "Denesik-Dach",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Bart DuBuque",
        "EMail": [
          "tempora",
          "aut"
        ],
        "PhonePrivate": [
          "608.146.6583 x71574",
          "819.082.5083 x9536"
        ],
        "PhoneFax": [
          "1-370-010-5136 x5320",
          "1-455-068-9621"
        ],
        "PhoneMobile": [
          "1-299-685-3007",
          "806-825-5367 x3265"
        ],
        "PhoneDirect": [
          "397.269.4931 x1538",
          "961.615.3736 x479"
        ],
        "PhoneContact": [
          "504-222-1218",
          "1-457-432-2246"
        ],
        "Messenger": [
          "corporis",
          "quia"
        ],
        "Voip": [
          "vitae",
          "quibusdam"
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
            "FieldLength": 91
          }
        }
      }
    ],
    "PersonFormalName": "Watsica Inc and Sons",
    "PersonFullName": "Dr. Effie Schaden MD",
    "PersonId": 492,
    "ProjectId": 747,
    "ProjectName": "D'Amore Group",
    "SaleId": 542,
    "SaleName": "O'Hara, Bogan and Kessler",
    "StartDate": "2017-10-21T12:01:27.0408377+02:00",
    "TaskName": "Thompson, Muller and Gulgowski",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 822
      }
    }
  }
]
```