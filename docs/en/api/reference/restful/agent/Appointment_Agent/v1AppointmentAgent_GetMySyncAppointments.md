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
  "StartTime": "2012-12-03T14:13:39.0005676+01:00",
  "EndTime": "1999-08-07T14:13:39.0005676+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "1998-12-23T14:13:39.0005676+01:00",
    "AppointmentId": 510,
    "AppointmentText": "necessitatibus",
    "ContactDepartment": "",
    "ContactFullName": "Cheyanne Rutherford",
    "ContactName": "Purdy-Grimes",
    "ContactId": 22,
    "EndDate": "2024-07-09T14:13:39.0005676+02:00",
    "HasAlarm": false,
    "IsAllDay": false,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": true,
    "IsInvitation": false,
    "IsTentative": false,
    "Location": "repellendus",
    "Participants": [
      {
        "PersonId": 422,
        "PersonFirstName": "Volkman Group",
        "PersonMiddleName": "VonRueden-Reichert",
        "PersonLastname": "Collins",
        "PersonMrmrs": "minima",
        "PersonTitle": "velit",
        "PersonPosition": "voluptate",
        "PersonAcademicTitle": "saepe",
        "PersonFormalName": "Dickens, Larkin and Cassin",
        "PersonFullName": "Neil Cremin",
        "ContactId": 992,
        "ContactName": "Reinger Group",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Landen Bernhard",
        "EMail": [
          "enim",
          "porro"
        ],
        "PhonePrivate": [
          "1-511-973-8231 x72894",
          "729.615.6822 x439"
        ],
        "PhoneFax": [
          "234-899-2669 x9245",
          "1-187-997-9696 x786"
        ],
        "PhoneMobile": [
          "1-685-134-4903",
          "(860)847-3589 x57372"
        ],
        "PhoneDirect": [
          "1-429-073-0878 x5351",
          "242-056-6131"
        ],
        "PhoneContact": [
          "504.301.5535 x0735",
          "722.191.6590 x093"
        ],
        "Messenger": [
          "provident",
          "accusantium"
        ],
        "Voip": [
          "iste",
          "ad"
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
            "FieldLength": 188
          }
        }
      }
    ],
    "PersonFormalName": "Murazik-Kohler",
    "PersonFullName": "Creola Botsford",
    "PersonId": 335,
    "ProjectId": 392,
    "ProjectName": "Friesen-Stanton",
    "SaleId": 700,
    "SaleName": "Crona LLC",
    "StartDate": "2010-11-15T14:13:39.0005676+01:00",
    "TaskName": "Upton Group",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 387
      }
    }
  }
]
```