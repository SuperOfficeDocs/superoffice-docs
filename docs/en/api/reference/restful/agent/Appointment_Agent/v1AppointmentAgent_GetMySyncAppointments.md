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
  "StartTime": "2002-10-18T16:00:39.6488525+02:00",
  "EndTime": "2016-09-14T16:00:39.6488525+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2002-02-12T16:00:39.6644704+01:00",
    "AppointmentId": 998,
    "AppointmentText": "nemo",
    "ContactDepartment": "",
    "ContactFullName": "Dejah Beatty IV",
    "ContactName": "Bartoletti Inc and Sons",
    "ContactId": 295,
    "EndDate": "2019-07-20T16:00:39.6644704+02:00",
    "HasAlarm": false,
    "IsAllDay": true,
    "IsAssignment": false,
    "IsBusy": true,
    "IsCompleted": false,
    "IsInvitation": true,
    "IsTentative": false,
    "Location": "aut",
    "Participants": [
      {
        "PersonId": 472,
        "PersonFirstName": "Grant Group",
        "PersonMiddleName": "Casper, Haley and Reichert",
        "PersonLastname": "Pfeffer",
        "PersonMrmrs": "ab",
        "PersonTitle": "voluptatem",
        "PersonPosition": "nobis",
        "PersonAcademicTitle": "aut",
        "PersonFormalName": "Monahan LLC",
        "PersonFullName": "Katlynn Keebler",
        "ContactId": 16,
        "ContactName": "Luettgen LLC",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Dexter Cremin",
        "EMail": [
          "ab",
          "nostrum"
        ],
        "PhonePrivate": [
          "004.661.0941",
          "158-233-0876 x61123"
        ],
        "PhoneFax": [
          "823-673-1508 x917",
          "869.665.6513 x513"
        ],
        "PhoneMobile": [
          "(966)692-2143 x04863",
          "772.598.4429 x182"
        ],
        "PhoneDirect": [
          "833.850.5941 x235",
          "1-852-115-9098 x5978"
        ],
        "PhoneContact": [
          "(914)219-9736",
          "(705)039-5202 x1518"
        ],
        "Messenger": [
          "rerum",
          "nihil"
        ],
        "Voip": [
          "perspiciatis",
          "quidem"
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
            "FieldLength": 855
          }
        }
      }
    ],
    "PersonFormalName": "Harris-Rutherford",
    "PersonFullName": "Johnpaul Bertha Kunde DDS",
    "PersonId": 185,
    "ProjectId": 273,
    "ProjectName": "Shanahan, Ratke and Volkman",
    "SaleId": 960,
    "SaleName": "King, Prosacco and Leuschke",
    "StartDate": "2013-12-17T16:00:39.6644704+01:00",
    "TaskName": "Kuhn LLC",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 204
      }
    }
  }
]
```