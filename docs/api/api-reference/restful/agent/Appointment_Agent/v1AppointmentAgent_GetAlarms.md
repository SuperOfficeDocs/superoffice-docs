---
title: POST Agents/Appointment/GetAlarms
id: v1AppointmentAgent_GetAlarms
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "IncludeInvitations": true,
  "IncludeAllAppointments": true,
  "DefaultAlarmLeadTimeInMinutes": 43
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Alarms": [
    {
      "AppointmentId": 20,
      "StartTime": "2009-01-13T16:48:28.3464489+01:00",
      "EndDate": "2003-08-14T16:48:28.3464489+02:00",
      "AlarmTime": "2015-05-29T16:48:28.3464489+02:00",
      "PersonId": 143,
      "PersonFullName": "Ben Marks",
      "ContactName": "VonRueden, Rohan and Jacobson",
      "ProjectId": 279,
      "ProjectName": "Batz, Lowe and Mante",
      "AppointmentText": "in",
      "SaleId": 471,
      "SaleName": "Grimes Group",
      "Location": "ipsum",
      "AppointmentType": "BookingForChecklist",
      "ContactId": 615,
      "AssignmentStatus": "Assigning",
      "InvitationStatus": "Accepted",
      "BookingType": "None",
      "FormalName": "Tremblay, Rippin and Durgan",
      "TaskName": "Harber-Mayer",
      "ContactDepartment": "",
      "ContactFullName": "Royce Ritchie",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 867
        }
      }
    }
  ],
  "PollingInterval": 543,
  "SilentAfter": 285,
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
      "FieldLength": 321
    }
  }
}
```