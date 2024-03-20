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
  "StartTime": "2020-11-24T12:19:44.1800107+01:00",
  "EndTime": "1997-09-22T12:19:44.1800107+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2014-07-22T12:19:44.1800107+02:00",
    "AppointmentId": 141,
    "AppointmentText": "rerum",
    "ContactDepartment": "",
    "ContactFullName": "Mrs. Jimmie Runolfsson",
    "ContactName": "Jerde, Abshire and Jaskolski",
    "ContactId": 992,
    "EndDate": "2019-05-01T12:19:44.1800107+02:00",
    "HasAlarm": false,
    "IsAllDay": true,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": false,
    "IsTentative": false,
    "Location": "aut",
    "Participants": [
      {
        "PersonId": 995,
        "PersonFirstName": "Kozey, Eichmann and Emmerich",
        "PersonMiddleName": "Volkman Group",
        "PersonLastname": "Botsford",
        "PersonMrmrs": "nihil",
        "PersonTitle": "mollitia",
        "PersonPosition": "aperiam",
        "PersonAcademicTitle": "et",
        "PersonFormalName": "Purdy, Haley and Bartoletti",
        "PersonFullName": "Heloise Grady",
        "ContactId": 296,
        "ContactName": "Thiel Group",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Emmitt Rutherford",
        "EMail": [
          "provident",
          "aperiam"
        ],
        "PhonePrivate": [
          "(238)908-5903 x8382",
          "1-976-507-2063"
        ],
        "PhoneFax": [
          "(620)251-2233 x56645",
          "332-389-1710"
        ],
        "PhoneMobile": [
          "1-679-184-4271 x614",
          "419-549-5555"
        ],
        "PhoneDirect": [
          "(550)619-5130 x69924",
          "118.148.7192"
        ],
        "PhoneContact": [
          "883-200-0592 x363",
          "(964)312-7138"
        ],
        "Messenger": [
          "quidem",
          "saepe"
        ],
        "Voip": [
          "et",
          "molestiae"
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
            "FieldLength": 115
          }
        }
      }
    ],
    "PersonFormalName": "Koch, Corwin and Steuber",
    "PersonFullName": "Raymond Effertz",
    "PersonId": 363,
    "ProjectId": 726,
    "ProjectName": "Kessler-Harvey",
    "SaleId": 521,
    "SaleName": "Hickle Inc and Sons",
    "StartDate": "2002-11-07T12:19:44.1956294+01:00",
    "TaskName": "McCullough Inc and Sons",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 676
      }
    }
  }
]
```