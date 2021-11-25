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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "IncludeInvitations": false,
  "IncludeAllAppointments": true,
  "DefaultAlarmLeadTimeInMinutes": 617
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Alarms": [
    {
      "AppointmentId": 328,
      "StartTime": "2004-10-27T18:28:47.7538442+02:00",
      "EndDate": "2010-11-20T18:28:47.7538442+01:00",
      "AlarmTime": "2001-07-11T18:28:47.7538442+02:00",
      "PersonId": 34,
      "PersonFullName": "Lori Funk PhD",
      "ContactName": "Howe Inc and Sons",
      "ProjectId": 291,
      "ProjectName": "Kuhn Group",
      "AppointmentText": "eum",
      "SaleId": 342,
      "SaleName": "Hills, Goldner and Kemmer",
      "Location": "voluptatibus",
      "AppointmentType": "BookingForChecklist",
      "ContactId": 128,
      "AssignmentStatus": "Assigning",
      "InvitationStatus": "Accepted",
      "BookingType": "None",
      "FormalName": "Christiansen Inc and Sons",
      "TaskName": "Kuphal, Emmerich and Lindgren",
      "ContactDepartment": "",
      "ContactFullName": "Joyce Toy",
      "JoinVideomeetUrl": "http://www.example.com/",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "deliver seamless deliverables"
          },
          "FieldType": "System.Int32",
          "FieldLength": 41
        }
      }
    }
  ],
  "PollingInterval": 19,
  "SilentAfter": 348,
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
      "FieldLength": 54
    }
  }
}
```