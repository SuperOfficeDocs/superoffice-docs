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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StartTime": "2020-05-27T14:19:02.4838092+02:00",
  "EndTime": "2014-08-17T14:19:02.4838092+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2021-10-18T14:19:02.4838092+02:00",
    "AppointmentId": 756,
    "AppointmentText": "non",
    "ContactDepartment": "",
    "ContactFullName": "Clement Monahan MD",
    "ContactName": "Rohan, Strosin and McLaughlin",
    "ContactId": 496,
    "EndDate": "2008-07-30T14:19:02.4838092+02:00",
    "HasAlarm": true,
    "IsAllDay": true,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": true,
    "IsInvitation": false,
    "IsTentative": true,
    "Location": "ea",
    "Participants": [
      {
        "PersonId": 924,
        "PersonFirstName": "Green-Raynor",
        "PersonMiddleName": "Schaden, White and Nicolas",
        "PersonLastname": "Carroll",
        "PersonMrmrs": "in",
        "PersonTitle": "reprehenderit",
        "PersonPosition": "quia",
        "PersonAcademicTitle": "mollitia",
        "PersonFormalName": "Dibbert, Mayer and Considine",
        "PersonFullName": "Letitia Parisian",
        "ContactId": 122,
        "ContactName": "Lockman LLC",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Roselyn Price",
        "EMail": [
          "optio",
          "accusantium"
        ],
        "PhonePrivate": [
          "1-673-116-7231",
          "345-462-1981 x4197"
        ],
        "PhoneFax": [
          "1-397-740-0426",
          "311.476.3177 x141"
        ],
        "PhoneMobile": [
          "756.775.2033 x6948",
          "1-998-936-8215 x993"
        ],
        "PhoneDirect": [
          "330.568.1710",
          "747-890-4557"
        ],
        "PhoneContact": [
          "(354)762-1735",
          "(534)411-6657 x15825"
        ],
        "Messenger": [
          "quis",
          "ipsum"
        ],
        "Voip": [
          "omnis",
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
            "FieldType": "System.Int32",
            "FieldLength": 165
          }
        }
      }
    ],
    "PersonFormalName": "Heidenreich Group",
    "PersonFullName": "Amos Stiedemann III",
    "PersonId": 190,
    "ProjectId": 26,
    "ProjectName": "Luettgen Group",
    "SaleId": 22,
    "SaleName": "Waelchi Group",
    "StartDate": "2022-04-23T14:19:02.4838092+02:00",
    "TaskName": "Johns LLC",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 27
      }
    }
  }
]
```