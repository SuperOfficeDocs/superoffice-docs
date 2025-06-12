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
  "StartTime": "2022-12-01T17:54:02.3983677+01:00",
  "EndTime": "2007-09-22T17:54:02.3983677+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2001-09-23T17:54:02.3983677+02:00",
    "AppointmentId": 34,
    "AppointmentText": "dicta",
    "ContactDepartment": "",
    "ContactFullName": "Mr. Darren Gulgowski",
    "ContactName": "Nolan, Bashirian and Fadel",
    "ContactId": 976,
    "EndDate": "2003-06-04T17:54:02.3983677+02:00",
    "HasAlarm": false,
    "IsAllDay": true,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": true,
    "IsTentative": false,
    "Location": "modi",
    "Participants": [
      {
        "PersonId": 158,
        "PersonFirstName": "Ullrich-Little",
        "PersonMiddleName": "Breitenberg LLC",
        "PersonLastname": "Simonis",
        "PersonMrmrs": "et",
        "PersonTitle": "repellendus",
        "PersonPosition": "aut",
        "PersonAcademicTitle": "et",
        "PersonFormalName": "Grady Inc and Sons",
        "PersonFullName": "Ms. Henriette Elenora Cormier IV",
        "ContactId": 242,
        "ContactName": "McLaughlin-Halvorson",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Mr. Tressa Isac Gislason",
        "EMail": [
          "sunt",
          "ut"
        ],
        "PhonePrivate": [
          "212-427-2197 x6090",
          "(670)408-9251 x2211"
        ],
        "PhoneFax": [
          "(738)458-9787 x06370",
          "(086)638-5994 x156"
        ],
        "PhoneMobile": [
          "546.437.4413",
          "807-157-5314"
        ],
        "PhoneDirect": [
          "731-785-4728",
          "(295)313-3500 x687"
        ],
        "PhoneContact": [
          "490.560.9111 x898",
          "1-247-402-8594"
        ],
        "Messenger": [
          "ipsum",
          "et"
        ],
        "Voip": [
          "non",
          "tempora"
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
            "FieldLength": 610
          }
        }
      }
    ],
    "PersonFormalName": "Goldner-Koss",
    "PersonFullName": "Arnoldo Kuhn",
    "PersonId": 535,
    "ProjectId": 253,
    "ProjectName": "Osinski-Erdman",
    "SaleId": 928,
    "SaleName": "Hirthe Group",
    "StartDate": "1999-11-16T17:54:02.3983677+01:00",
    "TaskName": "Schamberger, Kerluke and Zboncak",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 684
      }
    }
  }
]
```