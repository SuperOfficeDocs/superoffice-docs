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
  "StartTime": "2002-10-13T03:31:25.1313731+02:00",
  "EndTime": "2003-02-26T03:31:25.1313731+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2009-11-12T03:31:25.1469933+01:00",
    "AppointmentId": 19,
    "AppointmentText": "assumenda",
    "ContactDepartment": "",
    "ContactFullName": "Rachael Zachariah Davis DDS",
    "ContactName": "Mann LLC",
    "ContactId": 72,
    "EndDate": "2020-10-22T03:31:25.1469933+02:00",
    "HasAlarm": false,
    "IsAllDay": true,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": false,
    "IsTentative": false,
    "Location": "voluptas",
    "Participants": [
      {
        "PersonId": 213,
        "PersonFirstName": "Jones, Kemmer and Sauer",
        "PersonMiddleName": "White, Casper and Considine",
        "PersonLastname": "Oberbrunner",
        "PersonMrmrs": "deserunt",
        "PersonTitle": "labore",
        "PersonPosition": "iusto",
        "PersonAcademicTitle": "tempora",
        "PersonFormalName": "Kuphal, Schmidt and Cremin",
        "PersonFullName": "Shayna Glover",
        "ContactId": 662,
        "ContactName": "Emard, Heaney and Bahringer",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Miss Genesis Kuvalis",
        "EMail": [
          "qui",
          "nostrum"
        ],
        "PhonePrivate": [
          "308.277.5223",
          "(353)245-6328"
        ],
        "PhoneFax": [
          "456-712-6769 x32020",
          "(175)841-6314"
        ],
        "PhoneMobile": [
          "(263)690-8724 x9536",
          "887.460.1828 x663"
        ],
        "PhoneDirect": [
          "(964)508-7863",
          "1-869-418-2567"
        ],
        "PhoneContact": [
          "140-214-2114",
          "(281)163-1847 x9878"
        ],
        "Messenger": [
          "dolore",
          "fugit"
        ],
        "Voip": [
          "maxime",
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
            "FieldType": "System.Int32",
            "FieldLength": 419
          }
        }
      }
    ],
    "PersonFormalName": "Klocko, Koss and Schroeder",
    "PersonFullName": "Woodrow Douglas",
    "PersonId": 589,
    "ProjectId": 419,
    "ProjectName": "Bernhard-McClure",
    "SaleId": 459,
    "SaleName": "Howell, Ernser and Purdy",
    "StartDate": "2001-05-03T03:31:25.1469933+02:00",
    "TaskName": "Price, Nicolas and Crona",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 905
      }
    }
  }
]
```