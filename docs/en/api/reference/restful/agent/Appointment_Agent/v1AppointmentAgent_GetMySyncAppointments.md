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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "StartTime": "2004-12-03T10:17:54.9414989+01:00",
  "EndTime": "2007-05-31T10:17:54.9414989+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2013-03-13T10:17:54.9414989+01:00",
    "AppointmentId": 17,
    "AppointmentText": "soluta",
    "ContactDepartment": "",
    "ContactFullName": "Prof. Nya Schuppe",
    "ContactName": "Parker Inc and Sons",
    "ContactId": 78,
    "EndDate": "2000-05-30T10:17:54.9414989+02:00",
    "HasAlarm": false,
    "IsAllDay": false,
    "IsAssignment": true,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": true,
    "IsTentative": false,
    "Location": "qui",
    "Participants": [
      {
        "PersonId": 79,
        "PersonFirstName": "Crist-Prohaska",
        "PersonMiddleName": "Larkin LLC",
        "PersonLastname": "Moen",
        "PersonMrmrs": "consequuntur",
        "PersonTitle": "quibusdam",
        "PersonPosition": "aut",
        "PersonAcademicTitle": "quisquam",
        "PersonFormalName": "Gibson-Strosin",
        "PersonFullName": "Delmer Blick",
        "ContactId": 188,
        "ContactName": "Mitchell LLC",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Mr. Cleve Kiehn DDS",
        "EMail": [
          "rerum",
          "atque"
        ],
        "PhonePrivate": [
          "742-014-5353 x445",
          "1-079-885-0727 x837"
        ],
        "PhoneFax": [
          "(216)009-4332",
          "245.524.9368"
        ],
        "PhoneMobile": [
          "980-134-9088 x84737",
          "645-448-0391 x311"
        ],
        "PhoneDirect": [
          "(277)969-5081",
          "026.544.9165"
        ],
        "PhoneContact": [
          "527.278.9136",
          "(096)753-9790 x02239"
        ],
        "Messenger": [
          "eius",
          "mollitia"
        ],
        "Voip": [
          "dolorem",
          "id"
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
            "FieldLength": 692
          }
        }
      }
    ],
    "PersonFormalName": "Windler Group",
    "PersonFullName": "Bradford Heidenreich",
    "PersonId": 544,
    "ProjectId": 631,
    "ProjectName": "McCullough, Hartmann and Koelpin",
    "SaleId": 829,
    "SaleName": "Gorczany Inc and Sons",
    "StartDate": "2013-02-07T10:17:54.9414989+01:00",
    "TaskName": "Smith, Lesch and White",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 824
      }
    }
  }
]
```