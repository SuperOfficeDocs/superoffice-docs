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
  "StartTime": "2024-07-12T16:32:37.6646595+02:00",
  "EndTime": "2005-03-06T16:32:37.6646595+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2012-03-17T16:32:37.6646595+01:00",
    "AppointmentId": 285,
    "AppointmentText": "non",
    "ContactDepartment": "",
    "ContactFullName": "Barney Fay",
    "ContactName": "Grant Inc and Sons",
    "ContactId": 807,
    "EndDate": "2014-12-30T16:32:37.6646595+01:00",
    "HasAlarm": false,
    "IsAllDay": false,
    "IsAssignment": true,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": false,
    "IsTentative": true,
    "Location": "perferendis",
    "Participants": [
      {
        "PersonId": 997,
        "PersonFirstName": "Cassin, Kovacek and Kunde",
        "PersonMiddleName": "Tremblay LLC",
        "PersonLastname": "Zulauf",
        "PersonMrmrs": "quibusdam",
        "PersonTitle": "est",
        "PersonPosition": "et",
        "PersonAcademicTitle": "ut",
        "PersonFormalName": "Quigley, Ferry and D'Amore",
        "PersonFullName": "Maxwell Mosciski",
        "ContactId": 354,
        "ContactName": "Ernser Group",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Adelle Mayert",
        "EMail": [
          "iusto",
          "repellat"
        ],
        "PhonePrivate": [
          "1-001-564-9940",
          "1-959-210-6068"
        ],
        "PhoneFax": [
          "149-327-7705 x7772",
          "(629)315-8755"
        ],
        "PhoneMobile": [
          "1-373-733-3150 x147",
          "(615)816-1148"
        ],
        "PhoneDirect": [
          "024.153.0029 x3385",
          "(216)204-0952 x20006"
        ],
        "PhoneContact": [
          "701.739.1642",
          "366.406.9903 x041"
        ],
        "Messenger": [
          "dolorem",
          "rerum"
        ],
        "Voip": [
          "reprehenderit",
          "non"
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
            "FieldLength": 195
          }
        }
      }
    ],
    "PersonFormalName": "Shanahan Inc and Sons",
    "PersonFullName": "Abelardo Lang",
    "PersonId": 160,
    "ProjectId": 753,
    "ProjectName": "Kessler LLC",
    "SaleId": 616,
    "SaleName": "Collins-Keebler",
    "StartDate": "2002-09-30T16:32:37.7974094+02:00",
    "TaskName": "Beahan-Wisozk",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 690
      }
    }
  }
]
```