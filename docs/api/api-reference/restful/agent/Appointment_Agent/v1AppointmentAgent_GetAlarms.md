---
title: GetAlarms
id: v1AppointmentAgent_GetAlarms
---

# GetAlarms

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
| IncludeInvitations | bool |  |
| IncludeAllAppointments | bool |  |
| DefaultAlarmLeadTimeInMinutes | int32 |  |


## Response: object

Carrier object for MultiAlarmData.
Services for the MultiAlarmData Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Alarms | array |  |
| PollingInterval | int32 |  |
| SilentAfter | int32 |  |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Appointment/GetAlarms
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "IncludeInvitations": true,
  "IncludeAllAppointments": true,
  "DefaultAlarmLeadTimeInMinutes": 811
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Alarms": [
    {
      "AppointmentId": 540,
      "StartTime": "2009-04-04T14:58:02.8995578+02:00",
      "EndDate": "2002-05-12T14:58:02.8995578+02:00",
      "AlarmTime": "2014-05-24T14:58:02.8995578+02:00",
      "PersonId": 171,
      "PersonFullName": "Kellen Botsford",
      "ContactName": "Stiedemann-Grimes",
      "ProjectId": 155,
      "ProjectName": "Hilpert, Ferry and O'Keefe",
      "AppointmentText": "ea",
      "SaleId": 955,
      "SaleName": "Schuster-Morar",
      "Location": "sequi",
      "AppointmentType": "BookingForChecklist",
      "ContactId": 201,
      "AssignmentStatus": "Assigning",
      "InvitationStatus": "Accepted",
      "BookingType": "None",
      "FormalName": "Wisozk-Johnston",
      "TaskName": "Hirthe-Reichel",
      "ContactDepartment": "",
      "ContactFullName": "Tabitha Halvorson",
      "JoinVideomeetUrl": "http://www.example.com/",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 821
        }
      }
    }
  ],
  "PollingInterval": 45,
  "SilentAfter": 654,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 274
    }
  }
}
```