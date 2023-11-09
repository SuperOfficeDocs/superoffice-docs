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
  "StartTime": "2005-10-26T11:06:33.4913656+02:00",
  "EndTime": "2008-03-07T11:06:33.4913656+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2016-01-23T11:06:33.4913656+01:00",
    "AppointmentId": 978,
    "AppointmentText": "aut",
    "ContactDepartment": "",
    "ContactFullName": "Makayla Torp",
    "ContactName": "Kuphal Inc and Sons",
    "ContactId": 501,
    "EndDate": "2000-03-10T11:06:33.4913656+01:00",
    "HasAlarm": true,
    "IsAllDay": true,
    "IsAssignment": true,
    "IsBusy": false,
    "IsCompleted": true,
    "IsInvitation": true,
    "IsTentative": false,
    "Location": "eos",
    "Participants": [
      {
        "PersonId": 335,
        "PersonFirstName": "Sauer, Haag and Williamson",
        "PersonMiddleName": "Lesch, Turcotte and Schmeler",
        "PersonLastname": "Hammes",
        "PersonMrmrs": "occaecati",
        "PersonTitle": "voluptatum",
        "PersonPosition": "possimus",
        "PersonAcademicTitle": "ab",
        "PersonFormalName": "Glover-Padberg",
        "PersonFullName": "Rebeka Veum",
        "ContactId": 571,
        "ContactName": "Wuckert LLC",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Miss Makenzie Ephraim Conroy DDS",
        "EMail": [
          "magni",
          "quas"
        ],
        "PhonePrivate": [
          "(721)754-6622",
          "(067)099-1583 x498"
        ],
        "PhoneFax": [
          "115-009-9237 x578",
          "(389)443-3831 x8747"
        ],
        "PhoneMobile": [
          "(768)003-4073 x6104",
          "1-868-348-6290 x08087"
        ],
        "PhoneDirect": [
          "(318)894-6072",
          "1-594-934-7154"
        ],
        "PhoneContact": [
          "(971)248-6268 x993",
          "(373)598-3008 x28506"
        ],
        "Messenger": [
          "maiores",
          "perferendis"
        ],
        "Voip": [
          "odio",
          "ipsum"
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
            "FieldLength": 425
          }
        }
      }
    ],
    "PersonFormalName": "Daugherty Group",
    "PersonFullName": "Irwin Bode",
    "PersonId": 708,
    "ProjectId": 389,
    "ProjectName": "O'Conner, Rempel and Hand",
    "SaleId": 716,
    "SaleName": "Armstrong, Zboncak and Dicki",
    "StartDate": "2019-12-02T11:06:33.4913656+01:00",
    "TaskName": "Bogisich Inc and Sons",
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