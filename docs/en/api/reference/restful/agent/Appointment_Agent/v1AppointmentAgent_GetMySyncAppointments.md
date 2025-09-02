---
title: POST Agents/Appointment/GetMySyncAppointments
uid: v1AppointmentAgent_GetMySyncAppointments
generated: true
content_type: reference
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
  "StartTime": "2008-05-31T03:46:54.0195335+02:00",
  "EndTime": "2022-11-06T03:46:54.0195335+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2025-02-15T03:46:54.0195335+01:00",
    "AppointmentId": 681,
    "AppointmentText": "ut",
    "ContactDepartment": "",
    "ContactFullName": "Miss Axel Baylee Botsford V",
    "ContactName": "Klocko LLC",
    "ContactId": 112,
    "EndDate": "2021-06-02T03:46:54.0195335+02:00",
    "HasAlarm": true,
    "IsAllDay": true,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": false,
    "IsTentative": true,
    "Location": "perferendis",
    "Participants": [
      {
        "PersonId": 623,
        "PersonFirstName": "Hansen, Ebert and Schoen",
        "PersonMiddleName": "Turner Inc and Sons",
        "PersonLastname": "Altenwerth",
        "PersonMrmrs": "autem",
        "PersonTitle": "molestiae",
        "PersonPosition": "laboriosam",
        "PersonAcademicTitle": "minima",
        "PersonFormalName": "Homenick Inc and Sons",
        "PersonFullName": "Eliane Abernathy",
        "ContactId": 413,
        "ContactName": "Fritsch, Casper and Konopelski",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Miss Tommie Glenna Koelpin",
        "EMail": [
          "consequatur",
          "est"
        ],
        "PhonePrivate": [
          "275.346.0500 x4952",
          "1-868-086-4834"
        ],
        "PhoneFax": [
          "459.095.1419 x2141",
          "(246)081-6033"
        ],
        "PhoneMobile": [
          "989.023.4219",
          "787-228-6026 x4972"
        ],
        "PhoneDirect": [
          "1-588-887-6182",
          "170-341-5124 x62221"
        ],
        "PhoneContact": [
          "790.105.9103",
          "925.336.6584"
        ],
        "Messenger": [
          "repellat",
          "perferendis"
        ],
        "Voip": [
          "non",
          "eos"
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
            "FieldLength": 757
          }
        }
      }
    ],
    "PersonFormalName": "Schumm Inc and Sons",
    "PersonFullName": "Axel Torrance Hessel DDS",
    "PersonId": 814,
    "ProjectId": 327,
    "ProjectName": "Denesik Inc and Sons",
    "SaleId": 142,
    "SaleName": "McKenzie-Hackett",
    "StartDate": "2005-11-23T03:46:54.0195335+01:00",
    "TaskName": "Jacobi Group",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 329
      }
    }
  }
]
```