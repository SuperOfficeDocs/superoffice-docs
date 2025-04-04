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
  "StartTime": "2001-04-03T13:13:59.156344+02:00",
  "EndTime": "2020-02-15T13:13:59.156344+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2015-04-11T13:13:59.1719704+02:00",
    "AppointmentId": 294,
    "AppointmentText": "voluptatem",
    "ContactDepartment": "",
    "ContactFullName": "Eli Feil III",
    "ContactName": "Dach Inc and Sons",
    "ContactId": 289,
    "EndDate": "2006-01-19T13:13:59.1719704+01:00",
    "HasAlarm": false,
    "IsAllDay": false,
    "IsAssignment": true,
    "IsBusy": true,
    "IsCompleted": true,
    "IsInvitation": true,
    "IsTentative": false,
    "Location": "recusandae",
    "Participants": [
      {
        "PersonId": 997,
        "PersonFirstName": "Rippin Inc and Sons",
        "PersonMiddleName": "Weissnat LLC",
        "PersonLastname": "Casper",
        "PersonMrmrs": "est",
        "PersonTitle": "sed",
        "PersonPosition": "qui",
        "PersonAcademicTitle": "et",
        "PersonFormalName": "Hane, Hirthe and Wuckert",
        "PersonFullName": "Chadd Conn",
        "ContactId": 136,
        "ContactName": "Bernhard Group",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Jessy Pacocha",
        "EMail": [
          "dolor",
          "necessitatibus"
        ],
        "PhonePrivate": [
          "586.493.0686",
          "1-478-060-0788 x618"
        ],
        "PhoneFax": [
          "1-332-379-9320 x4707",
          "359.267.0776 x6895"
        ],
        "PhoneMobile": [
          "497-938-6320 x406",
          "(069)818-7704 x0422"
        ],
        "PhoneDirect": [
          "217-608-8369 x82664",
          "(198)031-3092 x89855"
        ],
        "PhoneContact": [
          "1-020-226-4057 x4906",
          "984-358-2587 x47837"
        ],
        "Messenger": [
          "optio",
          "in"
        ],
        "Voip": [
          "ea",
          "soluta"
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
            "FieldLength": 43
          }
        }
      }
    ],
    "PersonFormalName": "Farrell, Ward and Erdman",
    "PersonFullName": "Tom Crooks",
    "PersonId": 391,
    "ProjectId": 957,
    "ProjectName": "Bahringer Inc and Sons",
    "SaleId": 459,
    "SaleName": "Lehner-Denesik",
    "StartDate": "2008-09-04T13:13:59.1719704+02:00",
    "TaskName": "Langosh-Mante",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 538
      }
    }
  }
]
```