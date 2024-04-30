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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StartTime": "2000-11-24T11:44:32.4631128+01:00",
  "EndTime": "2010-11-06T11:44:32.4631128+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2000-05-02T11:44:32.4787305+02:00",
    "AppointmentId": 27,
    "AppointmentText": "sed",
    "ContactDepartment": "exploit interactive portals",
    "ContactFullName": "Ms. Scarlett Koepp",
    "ContactName": "Gusikowski-Reichert",
    "ContactId": 93,
    "EndDate": "2016-07-25T11:44:32.4787305+02:00",
    "HasAlarm": true,
    "IsAllDay": false,
    "IsAssignment": false,
    "IsBusy": true,
    "IsCompleted": false,
    "IsInvitation": true,
    "IsTentative": true,
    "Location": "eum",
    "Participants": [
      {
        "PersonId": 443,
        "PersonFirstName": "D'Amore, Crooks and Stracke",
        "PersonMiddleName": "Spinka, Mohr and Mosciski",
        "PersonLastname": "Cummings",
        "PersonMrmrs": "accusamus",
        "PersonTitle": "reprehenderit",
        "PersonPosition": "officia",
        "PersonAcademicTitle": "aliquam",
        "PersonFormalName": "King Group",
        "PersonFullName": "Elsa Bartell",
        "ContactId": 797,
        "ContactName": "Tillman, Barrows and Schmeler",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Ms. Emory Reagan Christiansen I",
        "EMail": [
          "mollitia",
          "omnis"
        ],
        "PhonePrivate": [
          "(215)560-8438 x85469",
          "(745)805-6180 x375"
        ],
        "PhoneFax": [
          "1-770-963-6366 x77766",
          "013-122-9062 x476"
        ],
        "PhoneMobile": [
          "(061)150-2677",
          "655-226-4479 x347"
        ],
        "PhoneDirect": [
          "1-570-016-9964",
          "168-768-9383"
        ],
        "PhoneContact": [
          "528.194.3476",
          "570-490-5232 x7155"
        ],
        "Messenger": [
          "temporibus",
          "quia"
        ],
        "Voip": [
          "vel",
          "modi"
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
            "FieldLength": 701
          }
        }
      }
    ],
    "PersonFormalName": "Weissnat, Feest and Abbott",
    "PersonFullName": "Helmer Christiansen II",
    "PersonId": 917,
    "ProjectId": 869,
    "ProjectName": "Adams-Stracke",
    "SaleId": 295,
    "SaleName": "Schumm, Mueller and Nienow",
    "StartDate": "1996-12-28T11:44:32.4787305+01:00",
    "TaskName": "Harris Inc and Sons",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 792
      }
    }
  }
]
```