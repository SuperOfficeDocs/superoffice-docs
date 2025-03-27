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
  "StartTime": "2014-04-02T02:38:20.6514919+02:00",
  "EndTime": "1999-01-25T02:38:20.6514919+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "1999-02-24T02:38:20.6514919+01:00",
    "AppointmentId": 820,
    "AppointmentText": "quia",
    "ContactDepartment": "",
    "ContactFullName": "Miss Elsie Pete Treutel III",
    "ContactName": "Hegmann, Kemmer and Hintz",
    "ContactId": 189,
    "EndDate": "2018-06-02T02:38:20.6514919+02:00",
    "HasAlarm": false,
    "IsAllDay": false,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": false,
    "IsTentative": true,
    "Location": "iure",
    "Participants": [
      {
        "PersonId": 100,
        "PersonFirstName": "Bartell Inc and Sons",
        "PersonMiddleName": "Bradtke, Dickinson and Parker",
        "PersonLastname": "Hane",
        "PersonMrmrs": "in",
        "PersonTitle": "voluptatem",
        "PersonPosition": "ipsam",
        "PersonAcademicTitle": "labore",
        "PersonFormalName": "Beahan, Johns and Ledner",
        "PersonFullName": "Miss Noah Van Becker",
        "ContactId": 721,
        "ContactName": "Raynor-Beatty",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Prof. Kyler Garrick Block DVM",
        "EMail": [
          "et",
          "ab"
        ],
        "PhonePrivate": [
          "(977)252-2816 x64182",
          "687.282.1522 x150"
        ],
        "PhoneFax": [
          "1-237-415-6632",
          "869-021-4103"
        ],
        "PhoneMobile": [
          "314-586-8495 x579",
          "(498)395-1734 x105"
        ],
        "PhoneDirect": [
          "958.550.6168 x02445",
          "294-575-6347"
        ],
        "PhoneContact": [
          "1-221-199-9586",
          "(849)766-6752"
        ],
        "Messenger": [
          "omnis",
          "omnis"
        ],
        "Voip": [
          "voluptas",
          "dignissimos"
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
            "FieldLength": 833
          }
        }
      }
    ],
    "PersonFormalName": "Doyle, Cummings and Toy",
    "PersonFullName": "Hortense Rempel",
    "PersonId": 715,
    "ProjectId": 966,
    "ProjectName": "Bogan Inc and Sons",
    "SaleId": 60,
    "SaleName": "Nienow, Sawayn and Pfannerstill",
    "StartDate": "2023-07-10T02:38:20.6514919+02:00",
    "TaskName": "Cummings Group",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 310
      }
    }
  }
]
```