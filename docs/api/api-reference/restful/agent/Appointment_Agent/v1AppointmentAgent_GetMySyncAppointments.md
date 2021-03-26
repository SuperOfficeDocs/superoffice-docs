---
title: POST Agents/Appointment/GetMySyncAppointments
id: v1AppointmentAgent_GetMySyncAppointments
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

## Sample Request

```http!
POST /api/v1/Agents/Appointment/GetMySyncAppointments
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "StartTime": "2019-08-07T16:48:28.5344543+02:00",
  "EndTime": "2015-02-20T16:48:28.5344543+01:00"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2019-04-16T16:48:28.536456+02:00",
    "AppointmentId": 761,
    "AppointmentText": "assumenda",
    "ContactDepartment": "",
    "ContactFullName": "Garret Batz",
    "ContactName": "Ryan, Leuschke and Beer",
    "ContactId": 897,
    "EndDate": "1999-10-12T16:48:28.536456+02:00",
    "HasAlarm": false,
    "IsAllDay": true,
    "IsAssignment": true,
    "IsBusy": true,
    "IsCompleted": false,
    "IsInvitation": true,
    "IsTentative": true,
    "Location": "repellendus",
    "Participants": [
      {
        "PersonId": 940,
        "PersonFirstName": "Wiegand-Bode",
        "PersonMiddleName": "Schaefer, Wisoky and Gaylord",
        "PersonLastname": "McGlynn",
        "PersonMrmrs": "et",
        "PersonTitle": "natus",
        "PersonPosition": "dolorem",
        "PersonAcademicTitle": "quis",
        "PersonFormalName": "Heidenreich Group",
        "PersonFullName": "Olga Senger",
        "ContactId": 328,
        "ContactName": "Rolfson, Welch and Rowe",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Sophia Hane",
        "EMail": [
          "aut",
          "nisi"
        ],
        "PhonePrivate": [
          "(532)648-1338 x024",
          "281-215-5117"
        ],
        "PhoneFax": [
          "650-145-6446",
          "(018)768-4673 x0653"
        ],
        "PhoneMobile": [
          "626-732-3473 x11732",
          "845-702-3866 x38657"
        ],
        "PhoneDirect": [
          "757-366-2365 x144",
          "1-535-511-8473 x8716"
        ],
        "PhoneContact": [
          "461-463-2480 x21113",
          "1-738-003-1463"
        ],
        "Messenger": [
          "quo",
          "quam"
        ],
        "Voip": [
          "similique",
          "mollitia"
        ],
        "ContactUrl": [
          "http://www.example.com/",
          "http://www.example.com/"
        ],
        "Url": [
          "http://www.example.com/",
          "http://www.example.com/"
        ],
        "StreetAddress": {},
        "PostalAddress": {},
        "Country": "Sokovia",
        "PersonAddress": {},
        "PersonCountry": "Sokovia",
        "ParticipantStatus": "Assignment",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 798
          }
        }
      }
    ],
    "PersonFormalName": "Hyatt Group",
    "PersonFullName": "Jazmyne Upton",
    "PersonId": 991,
    "ProjectId": 816,
    "ProjectName": "Kiehn LLC",
    "SaleId": 117,
    "SaleName": "Cronin-Powlowski",
    "StartDate": "1998-11-24T16:48:28.5384488+01:00",
    "TaskName": "Lindgren Group",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 515
      }
    }
  }
]
```