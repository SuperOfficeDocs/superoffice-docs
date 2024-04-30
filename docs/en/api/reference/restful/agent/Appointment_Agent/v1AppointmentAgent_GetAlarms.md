---
title: POST Agents/Appointment/GetAlarms
uid: v1AppointmentAgent_GetAlarms
generated: true
---

# POST Agents/Appointment/GetAlarms

```http
POST /api/v1/Agents/Appointment/GetAlarms
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetAlarms?$select=name,department,category/id
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

IncludeInvitations, IncludeAllAppointments, DefaultAlarmLeadTimeInMinutes 

| Property Name | Type |  Description |
|----------------|------|--------------|
| IncludeInvitations | Boolean |  |
| IncludeAllAppointments | Boolean |  |
| DefaultAlarmLeadTimeInMinutes | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: MultiAlarmData

| Property Name | Type |  Description |
|----------------|------|--------------|
| Alarms | array |  |
| PollingInterval | int32 |  |
| SilentAfter | int32 |  |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/GetAlarms
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "IncludeInvitations": false,
  "IncludeAllAppointments": false,
  "DefaultAlarmLeadTimeInMinutes": 649
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Alarms": [
    {
      "AppointmentId": 491,
      "StartTime": "2020-10-06T11:16:08.5220136+02:00",
      "EndDate": "2005-09-14T11:16:08.5220136+02:00",
      "AlarmTime": "1998-11-24T11:16:08.5220136+01:00",
      "PersonId": 673,
      "PersonFullName": "Colleen Deondre Harber III",
      "ContactName": "Quigley, Franecki and Bosco",
      "ProjectId": 613,
      "ProjectName": "Durgan-Wisozk",
      "AppointmentText": "non",
      "SaleId": 606,
      "SaleName": "Haley, McGlynn and Witting",
      "Location": "doloremque",
      "AppointmentType": "BookingForChecklist",
      "ContactId": 923,
      "AssignmentStatus": "Assigning",
      "InvitationStatus": "Accepted",
      "BookingType": "None",
      "FormalName": "Kessler, Schinner and McLaughlin",
      "TaskName": "Buckridge-Klein",
      "ContactDepartment": "",
      "ContactFullName": "Edwina Mertz",
      "JoinVideomeetUrl": "http://www.example.com/",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 598
        }
      }
    }
  ],
  "PollingInterval": 804,
  "SilentAfter": 79,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 202
    }
  }
}
```