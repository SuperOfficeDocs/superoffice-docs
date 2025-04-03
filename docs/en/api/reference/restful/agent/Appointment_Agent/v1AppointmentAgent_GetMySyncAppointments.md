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
  "StartTime": "2017-10-18T14:28:21.2744024+02:00",
  "EndTime": "2019-01-02T14:28:21.2744024+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AlarmTime": "2003-06-18T14:28:21.2744024+02:00",
    "AppointmentId": 506,
    "AppointmentText": "nobis",
    "ContactDepartment": "",
    "ContactFullName": "Mrs. Destiney Emard",
    "ContactName": "Hudson Group",
    "ContactId": 300,
    "EndDate": "2017-01-05T14:28:21.2744024+01:00",
    "HasAlarm": false,
    "IsAllDay": false,
    "IsAssignment": false,
    "IsBusy": false,
    "IsCompleted": false,
    "IsInvitation": false,
    "IsTentative": false,
    "Location": "et",
    "Participants": [
      {
        "PersonId": 668,
        "PersonFirstName": "Wintheiser, Huel and Lehner",
        "PersonMiddleName": "Schaefer, Sawayn and Cremin",
        "PersonLastname": "Durgan",
        "PersonMrmrs": "quod",
        "PersonTitle": "facilis",
        "PersonPosition": "omnis",
        "PersonAcademicTitle": "aut",
        "PersonFormalName": "Keeling, Nienow and Lindgren",
        "PersonFullName": "Kitty Deckow PhD",
        "ContactId": 790,
        "ContactName": "Jacobi, Kulas and Kling",
        "ContactDepartment": "",
        "ContactBusiness": "Information Technology",
        "ContactCountry": "Sokovia",
        "ContactCategory": "VIP Customer",
        "ContactFullName": "Cielo Weimann",
        "EMail": [
          "ut",
          "quos"
        ],
        "PhonePrivate": [
          "(146)835-8767 x4144",
          "480-914-5225 x9383"
        ],
        "PhoneFax": [
          "(465)545-1691",
          "218-575-3308"
        ],
        "PhoneMobile": [
          "(375)455-2498 x7006",
          "(367)908-3180"
        ],
        "PhoneDirect": [
          "(817)167-9348 x88946",
          "1-083-643-5278 x21448"
        ],
        "PhoneContact": [
          "(161)262-5073 x3669",
          "409-513-4256 x51120"
        ],
        "Messenger": [
          "porro",
          "qui"
        ],
        "Voip": [
          "officia",
          "alias"
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
            "FieldLength": 785
          }
        }
      }
    ],
    "PersonFormalName": "Langosh, Robel and Bogan",
    "PersonFullName": "Mrs. Juanita Kihn",
    "PersonId": 672,
    "ProjectId": 601,
    "ProjectName": "Braun, Ortiz and Dickinson",
    "SaleId": 742,
    "SaleName": "Stehr, Glover and Watsica",
    "StartDate": "2000-09-13T14:28:21.2744024+02:00",
    "TaskName": "Lang-Baumbach",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 489
      }
    }
  }
]
```