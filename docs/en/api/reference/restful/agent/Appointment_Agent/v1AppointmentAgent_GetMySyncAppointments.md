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
  "StartTime": "2001-04-03T23:03:54.5871475+02:00",
  "EndTime": "2007-06-19T23:03:54.5871475+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2003-10-02T23:03:54.5911478+02:00",
    "AppointmentId": 314,
    "AppointmentText": "voluptatem",
    "ContactDepartment": "",
    "ContactFullName": "Mr. Sandrine Dell Mills Jr.",
    "ContactName": "Kessler-Haag",
    "ContactId": 918,
    "EndDate": "2008-06-06T23:03:54.5911478+02:00",
    "HasAlarm": true,
    "IsAllDay": true,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": true,
    "IsInvitation": false,
    "IsTentative": true,
    "Location": "consectetur",
    "Participants": [
      {
        "PersonId": 827,
        "PersonFirstName": "Beer-Grimes",
        "PersonMiddleName": "Ferry-Kemmer",
        "PersonLastname": "Cartwright",
        "PersonMrmrs": "officiis",
        "PersonTitle": "aut",
        "PersonPosition": "voluptates",
        "PersonAcademicTitle": "reprehenderit",
        "PersonFormalName": "Howell LLC",
        "PersonFullName": "Mrs. Laverne Cordell Hilll",
        "ContactId": 969,
        "ContactName": "Grady Inc and Sons",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Ms. Christina Marge Cole DVM",
        "EMail": [
          "saepe",
          "ea"
        ],
        "PhonePrivate": [
          "(416)320-2644 x919",
          "(832)564-4951"
        ],
        "PhoneFax": [
          "1-851-443-3265 x8129",
          "1-509-468-3877"
        ],
        "PhoneMobile": [
          "1-210-873-3972",
          "644.482.1585 x125"
        ],
        "PhoneDirect": [
          "(700)405-9779 x36063",
          "(984)693-8515 x833"
        ],
        "PhoneContact": [
          "1-275-212-4225 x4893",
          "1-501-777-8137 x973"
        ],
        "Messenger": [
          "nihil",
          "deserunt"
        ],
        "Voip": [
          "est",
          "temporibus"
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
            "FieldLength": 371
          }
        }
      }
    ],
    "PersonFormalName": "Bailey, O'Connell and Bahringer",
    "PersonFullName": "Dr. Dante Goyette",
    "PersonId": 143,
    "ProjectId": 166,
    "ProjectName": "Kerluke Group",
    "SaleId": 565,
    "SaleName": "Schumm-Wehner",
    "StartDate": "2012-01-25T23:03:54.5931499+01:00",
    "TaskName": "Kunze LLC",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 461
      }
    }
  }
]
```