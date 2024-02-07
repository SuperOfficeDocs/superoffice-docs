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
  "StartTime": "2007-05-30T16:54:54.2680905+02:00",
  "EndTime": "1997-09-22T16:54:54.2680905+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2014-07-21T16:54:54.2711148+02:00",
    "AppointmentId": 437,
    "AppointmentText": "aut",
    "ContactDepartment": "",
    "ContactFullName": "Ambrose Wyman DVM",
    "ContactName": "Armstrong-Harber",
    "ContactId": 640,
    "EndDate": "2005-07-19T16:54:54.2711148+02:00",
    "HasAlarm": false,
    "IsAllDay": false,
    "IsAssignment": true,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": false,
    "IsTentative": true,
    "Location": "in",
    "Participants": [
      {
        "PersonId": 983,
        "PersonFirstName": "Gorczany Inc and Sons",
        "PersonMiddleName": "Bauch LLC",
        "PersonLastname": "Senger",
        "PersonMrmrs": "et",
        "PersonTitle": "ipsa",
        "PersonPosition": "quia",
        "PersonAcademicTitle": "consectetur",
        "PersonFormalName": "Hegmann-Zieme",
        "PersonFullName": "Tyreek Nitzsche",
        "ContactId": 991,
        "ContactName": "Macejkovic-Moore",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Fletcher Volkman PhD",
        "EMail": [
          "consequatur",
          "praesentium"
        ],
        "PhonePrivate": [
          "1-731-737-9480",
          "679.252.1683"
        ],
        "PhoneFax": [
          "231-625-4220 x375",
          "(424)028-3789 x799"
        ],
        "PhoneMobile": [
          "1-449-935-5355 x4136",
          "282.463.8276"
        ],
        "PhoneDirect": [
          "791.629.5418 x80810",
          "1-251-365-3245 x82111"
        ],
        "PhoneContact": [
          "1-563-863-2590",
          "195-359-0756 x75645"
        ],
        "Messenger": [
          "repudiandae",
          "sunt"
        ],
        "Voip": [
          "quam",
          "delectus"
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
            "FieldLength": 85
          }
        }
      }
    ],
    "PersonFormalName": "Goodwin-Parisian",
    "PersonFullName": "Mr. Valentin Nova Murazik",
    "PersonId": 981,
    "ProjectId": 532,
    "ProjectName": "Wiegand Inc and Sons",
    "SaleId": 383,
    "SaleName": "Hills LLC",
    "StartDate": "1998-09-02T16:54:54.272093+02:00",
    "TaskName": "Pfannerstill, Schmeler and Nolan",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 855
      }
    }
  }
]
```