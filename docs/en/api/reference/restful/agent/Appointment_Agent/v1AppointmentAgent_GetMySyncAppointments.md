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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Appointment/GetMySyncAppointments
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "StartTime": "2004-10-21T11:22:36.9619023+02:00",
  "EndTime": "2021-05-01T11:22:36.9619023+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "1996-01-25T11:22:36.9619023+01:00",
    "AppointmentId": 859,
    "AppointmentText": "minima",
    "ContactDepartment": "",
    "ContactFullName": "Trevion Krajcik",
    "ContactName": "Cummerata, Glover and Greenholt",
    "ContactId": 392,
    "EndDate": "2016-07-19T11:22:36.9619023+02:00",
    "HasAlarm": false,
    "IsAllDay": true,
    "IsAssignment": true,
    "IsBusy": true,
    "IsCompleted": false,
    "IsInvitation": false,
    "IsTentative": false,
    "Location": "occaecati",
    "Participants": [
      {
        "PersonId": 648,
        "PersonFirstName": "Abshire, Predovic and Fritsch",
        "PersonMiddleName": "King, Beahan and Casper",
        "PersonLastname": "Larson",
        "PersonMrmrs": "sit",
        "PersonTitle": "iste",
        "PersonPosition": "et",
        "PersonAcademicTitle": "quo",
        "PersonFormalName": "Glover, Corwin and Stanton",
        "PersonFullName": "Mrs. Cecelia Dolores Hilll",
        "ContactId": 977,
        "ContactName": "Marvin LLC",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Alice Rath",
        "EMail": [
          "expedita",
          "hic"
        ],
        "PhonePrivate": [
          "347.253.3101 x131",
          "192-767-1598 x7687"
        ],
        "PhoneFax": [
          "892.303.2193",
          "288-023-9059"
        ],
        "PhoneMobile": [
          "(101)350-2115 x656",
          "101-337-2352 x43948"
        ],
        "PhoneDirect": [
          "(480)692-4816 x59716",
          "769-605-3125 x08672"
        ],
        "PhoneContact": [
          "1-661-359-6436 x25997",
          "(549)738-4220"
        ],
        "Messenger": [
          "nemo",
          "esse"
        ],
        "Voip": [
          "distinctio",
          "tempora"
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
            "FieldLength": 412
          }
        }
      }
    ],
    "PersonFormalName": "Jakubowski-Hayes",
    "PersonFullName": "Miss Lonie Stevie Steuber",
    "PersonId": 739,
    "ProjectId": 658,
    "ProjectName": "Bergstrom, Wunsch and Medhurst",
    "SaleId": 597,
    "SaleName": "Berge, Balistreri and Stokes",
    "StartDate": "2012-02-14T11:22:36.9619023+01:00",
    "TaskName": "Klocko, West and O'Hara",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 312
      }
    }
  }
]
```