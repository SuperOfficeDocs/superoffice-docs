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
  "StartTime": "2006-12-21T13:13:21.5709641+01:00",
  "EndTime": "2011-05-28T13:13:21.5709641+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2013-10-12T13:13:21.5709641+02:00",
    "AppointmentId": 281,
    "AppointmentText": "quasi",
    "ContactDepartment": "",
    "ContactFullName": "Leland Schmitt",
    "ContactName": "Balistreri, Dickinson and Terry",
    "ContactId": 568,
    "EndDate": "2005-08-21T13:13:21.5865858+02:00",
    "HasAlarm": true,
    "IsAllDay": true,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": false,
    "IsTentative": false,
    "Location": "ut",
    "Participants": [
      {
        "PersonId": 450,
        "PersonFirstName": "Schimmel LLC",
        "PersonMiddleName": "Larson, Lakin and Mitchell",
        "PersonLastname": "Kling",
        "PersonMrmrs": "beatae",
        "PersonTitle": "in",
        "PersonPosition": "numquam",
        "PersonAcademicTitle": "et",
        "PersonFormalName": "Cassin Inc and Sons",
        "PersonFullName": "Miss Kiarra Nikki Mante IV",
        "ContactId": 242,
        "ContactName": "Bergnaum, Carroll and Macejkovic",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Dr. Cleta Schoen DVM",
        "EMail": [
          "atque",
          "quis"
        ],
        "PhonePrivate": [
          "(991)208-8182",
          "(907)084-6283 x492"
        ],
        "PhoneFax": [
          "690-588-7512 x508",
          "029.447.0028"
        ],
        "PhoneMobile": [
          "(244)911-1417",
          "923.469.4929 x93956"
        ],
        "PhoneDirect": [
          "(778)468-0866 x687",
          "1-664-341-1976 x81691"
        ],
        "PhoneContact": [
          "768.711.0283",
          "319-982-4818 x904"
        ],
        "Messenger": [
          "exercitationem",
          "neque"
        ],
        "Voip": [
          "velit",
          "veritatis"
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
            "FieldLength": 216
          }
        }
      }
    ],
    "PersonFormalName": "Murphy, Jewess and Corkery",
    "PersonFullName": "Alena Herzog",
    "PersonId": 297,
    "ProjectId": 843,
    "ProjectName": "Maggio LLC",
    "SaleId": 159,
    "SaleName": "Johnston, Block and Jacobs",
    "StartDate": "2024-10-21T13:13:21.5865858+02:00",
    "TaskName": "Heidenreich-Rath",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 644
      }
    }
  }
]
```