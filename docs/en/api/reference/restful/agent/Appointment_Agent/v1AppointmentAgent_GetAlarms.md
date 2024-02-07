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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "IncludeInvitations": true,
  "IncludeAllAppointments": false,
  "DefaultAlarmLeadTimeInMinutes": 357
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Alarms": [
    {
      "AppointmentId": 749,
      "StartTime": "2023-02-10T16:54:54.2741053+01:00",
      "EndDate": "2002-03-17T16:54:54.2741053+01:00",
      "AlarmTime": "2001-05-31T16:54:54.2741053+02:00",
      "PersonId": 53,
      "PersonFullName": "Miss Juwan Noelia Glover I",
      "ContactName": "Hahn, O'Keefe and Walter",
      "ProjectId": 531,
      "ProjectName": "Jacobi Inc and Sons",
      "AppointmentText": "quasi",
      "SaleId": 224,
      "SaleName": "Pollich, Veum and White",
      "Location": "alias",
      "AppointmentType": "BookingForChecklist",
      "ContactId": 648,
      "AssignmentStatus": "Assigning",
      "InvitationStatus": "Accepted",
      "BookingType": "None",
      "FormalName": "Osinski, Rolfson and Schultz",
      "TaskName": "Treutel-Wilkinson",
      "ContactDepartment": "",
      "ContactFullName": "Ms. Brandon Miller Sr.",
      "JoinVideomeetUrl": "http://www.example.com/",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 72
        }
      }
    }
  ],
  "PollingInterval": 658,
  "SilentAfter": 759,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 267
    }
  }
}
```