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
| StartTime | date-time |  |
| EndTime | date-time |  |


## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Appointment/GetMySyncAppointments
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StartTime": "2010-02-13T11:10:25.4725221+01:00",
  "EndTime": "2002-04-23T11:10:25.4725221+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2010-10-14T11:10:25.475523+02:00",
    "AppointmentId": 696,
    "AppointmentText": "autem",
    "ContactDepartment": "",
    "ContactFullName": "Miss Mabel Wisoky",
    "ContactName": "Wyman Inc and Sons",
    "ContactId": 544,
    "EndDate": "2020-11-10T11:10:25.475523+01:00",
    "HasAlarm": false,
    "IsAllDay": false,
    "IsAssignment": false,
    "IsBusy": true,
    "IsCompleted": false,
    "IsInvitation": false,
    "IsTentative": false,
    "Location": "dolore",
    "Participants": [
      {
        "PersonId": 987,
        "PersonFirstName": "Sauer, Friesen and Kihn",
        "PersonMiddleName": "Friesen-Effertz",
        "PersonLastname": "Hahn",
        "PersonMrmrs": "dignissimos",
        "PersonTitle": "enim",
        "PersonPosition": "nihil",
        "PersonAcademicTitle": "nesciunt",
        "PersonFormalName": "Bauch-Stiedemann",
        "PersonFullName": "Mr. Itzel Asa Schmidt III",
        "ContactId": 134,
        "ContactName": "Beer, Yundt and Nitzsche",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Duncan Streich",
        "EMail": [
          "cumque",
          "molestias"
        ],
        "PhonePrivate": [
          "1-318-244-4415 x110",
          "1-859-754-0646"
        ],
        "PhoneFax": [
          "(733)486-4775 x598",
          "(710)352-2748"
        ],
        "PhoneMobile": [
          "863.940.6426 x2655",
          "368.981.7182 x08553"
        ],
        "PhoneDirect": [
          "1-537-926-7180 x732",
          "532.118.4898 x663"
        ],
        "PhoneContact": [
          "1-416-885-5385 x7391",
          "1-617-856-6695"
        ],
        "Messenger": [
          "iste",
          "ut"
        ],
        "Voip": [
          "quia",
          "numquam"
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
            "FieldLength": 541
          }
        }
      }
    ],
    "PersonFormalName": "McClure Inc and Sons",
    "PersonFullName": "Rodger Schultz",
    "PersonId": 643,
    "ProjectId": 275,
    "ProjectName": "O'Kon, Cremin and Sawayn",
    "SaleId": 325,
    "SaleName": "Von Group",
    "StartDate": "2006-06-06T11:10:25.4775225+02:00",
    "TaskName": "Roob LLC",
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