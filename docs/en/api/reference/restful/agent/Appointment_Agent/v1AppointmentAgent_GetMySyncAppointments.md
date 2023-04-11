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
  "StartTime": "2011-07-30T15:29:20.4293304+02:00",
  "EndTime": "2016-04-27T15:29:20.4293304+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2009-03-08T15:29:20.4328308+01:00",
    "AppointmentId": 565,
    "AppointmentText": "quis",
    "ContactDepartment": "",
    "ContactFullName": "Sydni Swaniawski",
    "ContactName": "Parisian Group",
    "ContactId": 362,
    "EndDate": "2022-09-02T15:29:20.4333321+02:00",
    "HasAlarm": false,
    "IsAllDay": false,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": false,
    "IsTentative": false,
    "Location": "minus",
    "Participants": [
      {
        "PersonId": 133,
        "PersonFirstName": "Greenfelder-Boyer",
        "PersonMiddleName": "Marquardt LLC",
        "PersonLastname": "Sanford",
        "PersonMrmrs": "quibusdam",
        "PersonTitle": "voluptatibus",
        "PersonPosition": "et",
        "PersonAcademicTitle": "est",
        "PersonFormalName": "Goodwin-Boyer",
        "PersonFullName": "Kasandra Powlowski Jr.",
        "ContactId": 302,
        "ContactName": "Bernier Group",
        "ContactDepartment": "target leading-edge technologies",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Mariam Windler",
        "EMail": [
          "qui",
          "ut"
        ],
        "PhonePrivate": [
          "1-317-532-3907",
          "136-457-0060 x58564"
        ],
        "PhoneFax": [
          "356.333.0107 x43199",
          "406.467.4009 x1515"
        ],
        "PhoneMobile": [
          "909-704-7843 x6386",
          "(917)947-9320"
        ],
        "PhoneDirect": [
          "157-510-0471",
          "(731)086-3352 x488"
        ],
        "PhoneContact": [
          "973-806-6621",
          "136-724-9565 x95370"
        ],
        "Messenger": [
          "quia",
          "consequuntur"
        ],
        "Voip": [
          "numquam",
          "rerum"
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
            "FieldLength": 737
          }
        }
      }
    ],
    "PersonFormalName": "Spencer-Sanford",
    "PersonFullName": "Miss Lily Zulauf I",
    "PersonId": 473,
    "ProjectId": 160,
    "ProjectName": "Satterfield-Nikolaus",
    "SaleId": 34,
    "SaleName": "D'Amore Inc and Sons",
    "StartDate": "2005-01-11T15:29:20.4343302+01:00",
    "TaskName": "Cruickshank, Schimmel and Torphy",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 440
      }
    }
  }
]
```