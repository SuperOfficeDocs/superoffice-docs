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
  "IncludeInvitations": false,
  "IncludeAllAppointments": false,
  "DefaultAlarmLeadTimeInMinutes": 845
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Alarms": [
    {
      "AppointmentId": 729,
      "StartTime": "2002-12-28T13:57:11.2157245+01:00",
      "EndDate": "2019-04-05T13:57:11.2157245+02:00",
      "AlarmTime": "2001-09-16T13:57:11.2157245+02:00",
      "PersonId": 87,
      "PersonFullName": "Maye Jast",
      "ContactName": "Cummings-Feeney",
      "ProjectId": 659,
      "ProjectName": "Kassulke Inc and Sons",
      "AppointmentText": "laboriosam",
      "SaleId": 368,
      "SaleName": "Stroman Group",
      "Location": "asperiores",
      "AppointmentType": "BookingForChecklist",
      "ContactId": 783,
      "AssignmentStatus": "Assigning",
      "InvitationStatus": "Accepted",
      "BookingType": "None",
      "FormalName": "Green, Hamill and Lind",
      "TaskName": "O'Connell Group",
      "ContactDepartment": "",
      "ContactFullName": "Marge Flatley",
      "JoinVideomeetUrl": "http://www.example.com/",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 546
        }
      }
    }
  ],
  "PollingInterval": 229,
  "SilentAfter": 229,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 730
    }
  }
}
```