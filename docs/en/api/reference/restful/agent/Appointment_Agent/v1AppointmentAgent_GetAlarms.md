---
title: POST Agents/Appointment/GetAlarms
uid: v1AppointmentAgent_GetAlarms
generated: true
content_type: reference
---

# POST Agents/Appointment/GetAlarms

```http
POST /api/v1/Agents/Appointment/GetAlarms
```

NsApiSlow threshold: 2000 ms.







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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "IncludeInvitations": false,
  "IncludeAllAppointments": false,
  "DefaultAlarmLeadTimeInMinutes": 19
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Alarms": [
    {
      "AppointmentId": 742,
      "StartTime": "2007-09-27T03:40:45.654368+02:00",
      "EndDate": "2009-07-05T03:40:45.654368+02:00",
      "AlarmTime": "2025-10-03T03:40:45.654368+02:00",
      "PersonId": 842,
      "PersonFullName": "Miss Sheila Brook Brakus MD",
      "ContactName": "Schuster Group",
      "ProjectId": 816,
      "ProjectName": "Little-Feeney",
      "AppointmentText": "nihil",
      "SaleId": 400,
      "SaleName": "Lubowitz, Jewess and Stark",
      "Location": "ipsa",
      "AppointmentType": "BookingForChecklist",
      "ContactId": 944,
      "AssignmentStatus": "Assigning",
      "InvitationStatus": "Accepted",
      "BookingType": "None",
      "FormalName": "Hayes Inc and Sons",
      "TaskName": "Hane-Balistreri",
      "ContactDepartment": "",
      "ContactFullName": "Ike Alex Langosh II",
      "JoinVideomeetUrl": "http://www.example.com/",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 553
        }
      }
    }
  ],
  "PollingInterval": 939,
  "SilentAfter": 237,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 161
    }
  }
}
```