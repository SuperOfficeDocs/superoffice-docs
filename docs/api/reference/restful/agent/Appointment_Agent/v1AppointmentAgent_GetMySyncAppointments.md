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
  "StartTime": "2010-08-01T18:28:47.746844+02:00",
  "EndTime": "2015-03-21T18:28:47.746844+01:00"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2015-03-02T18:28:47.7498176+01:00",
    "AppointmentId": 968,
    "AppointmentText": "aut",
    "ContactDepartment": "",
    "ContactFullName": "Anya Lebsack",
    "ContactName": "Friesen-Olson",
    "ContactId": 786,
    "EndDate": "2014-10-10T18:28:47.7498176+02:00",
    "HasAlarm": false,
    "IsAllDay": true,
    "IsAssignment": false,
    "IsBusy": true,
    "IsCompleted": false,
    "IsInvitation": false,
    "IsTentative": false,
    "Location": "nihil",
    "Participants": [
      {
        "PersonId": 338,
        "PersonFirstName": "Becker-Turner",
        "PersonMiddleName": "Robel-Wyman",
        "PersonLastname": "Zemlak",
        "PersonMrmrs": "explicabo",
        "PersonTitle": "sapiente",
        "PersonPosition": "facere",
        "PersonAcademicTitle": "maiores",
        "PersonFormalName": "Beahan-Rogahn",
        "PersonFullName": "Gillian Von",
        "ContactId": 38,
        "ContactName": "Hand, Green and Hagenes",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Tobin Breitenberg",
        "EMail": [
          "neque",
          "et"
        ],
        "PhonePrivate": [
          "072.244.7542",
          "1-324-240-6234"
        ],
        "PhoneFax": [
          "(523)863-8570",
          "1-385-732-8044"
        ],
        "PhoneMobile": [
          "886-755-5321",
          "1-820-856-4584 x2284"
        ],
        "PhoneDirect": [
          "(654)330-5424 x1773",
          "378.583.7451 x58445"
        ],
        "PhoneContact": [
          "728-788-7762 x6634",
          "1-518-143-2438 x18271"
        ],
        "Messenger": [
          "doloremque",
          "saepe"
        ],
        "Voip": [
          "occaecati",
          "qui"
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
            "FieldLength": 982
          }
        }
      }
    ],
    "PersonFormalName": "Mohr-Beier",
    "PersonFullName": "Berenice Fisher DVM",
    "PersonId": 741,
    "ProjectId": 582,
    "ProjectName": "Breitenberg-Gerlach",
    "SaleId": 589,
    "SaleName": "Lindgren, Turcotte and Streich",
    "StartDate": "1995-02-15T18:28:47.7508443+01:00",
    "TaskName": "Abernathy-Lynch",
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
        "FieldLength": 401
      }
    }
  }
]
```