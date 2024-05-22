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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "StartTime": "1997-11-15T12:57:32.7584322+01:00",
  "EndTime": "2004-01-17T12:57:32.7584322+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "1999-05-01T12:57:32.7740533+02:00",
    "AppointmentId": 363,
    "AppointmentText": "et",
    "ContactDepartment": "",
    "ContactFullName": "Edgardo Sawayn",
    "ContactName": "Veum Inc and Sons",
    "ContactId": 777,
    "EndDate": "2007-02-27T12:57:32.7740533+01:00",
    "HasAlarm": false,
    "IsAllDay": false,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": true,
    "IsTentative": true,
    "Location": "ipsam",
    "Participants": [
      {
        "PersonId": 580,
        "PersonFirstName": "Mayer-Abernathy",
        "PersonMiddleName": "Schulist-Boyer",
        "PersonLastname": "Leffler",
        "PersonMrmrs": "alias",
        "PersonTitle": "eos",
        "PersonPosition": "unde",
        "PersonAcademicTitle": "dicta",
        "PersonFormalName": "Hills, Gusikowski and Gaylord",
        "PersonFullName": "Flossie Windler",
        "ContactId": 506,
        "ContactName": "Reichert Inc and Sons",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Carlos Jacobson",
        "EMail": [
          "magni",
          "similique"
        ],
        "PhonePrivate": [
          "537-064-8471 x02082",
          "1-072-890-2453 x141"
        ],
        "PhoneFax": [
          "420.712.6009 x286",
          "1-224-887-5282 x8773"
        ],
        "PhoneMobile": [
          "171-697-8974 x03532",
          "369-018-1449 x653"
        ],
        "PhoneDirect": [
          "113.879.8311 x16940",
          "216-891-6193"
        ],
        "PhoneContact": [
          "984.414.6217 x84493",
          "(021)062-4945"
        ],
        "Messenger": [
          "ipsam",
          "eum"
        ],
        "Voip": [
          "excepturi",
          "dolorem"
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
            "FieldLength": 614
          }
        }
      }
    ],
    "PersonFormalName": "Berge Group",
    "PersonFullName": "Hobart DuBuque",
    "PersonId": 691,
    "ProjectId": 292,
    "ProjectName": "Zemlak, Streich and Sauer",
    "SaleId": 320,
    "SaleName": "Bergstrom Group",
    "StartDate": "2004-05-12T12:57:32.7740533+02:00",
    "TaskName": "Zieme Group",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 738
      }
    }
  }
]
```