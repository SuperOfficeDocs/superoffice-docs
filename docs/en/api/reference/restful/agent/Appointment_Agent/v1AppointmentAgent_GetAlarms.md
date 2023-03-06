---
title: POST Agents/Appointment/GetAlarms
uid: v1AppointmentAgent_GetAlarms
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Appointment/GetAlarms
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "IncludeInvitations": false,
  "IncludeAllAppointments": true,
  "DefaultAlarmLeadTimeInMinutes": 580
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Alarms": [
    {
      "AppointmentId": 185,
      "StartTime": "2010-10-18T14:19:02.4838092+02:00",
      "EndDate": "2016-01-24T14:19:02.4838092+01:00",
      "AlarmTime": "2003-04-18T14:19:02.4838092+02:00",
      "PersonId": 87,
      "PersonFullName": "Hilbert Russel",
      "ContactName": "Gleason-Torp",
      "ProjectId": 454,
      "ProjectName": "Smitham, Stracke and Pollich",
      "AppointmentText": "repudiandae",
      "SaleId": 587,
      "SaleName": "Zieme-Boyer",
      "Location": "et",
      "AppointmentType": "BookingForChecklist",
      "ContactId": 860,
      "AssignmentStatus": "Assigning",
      "InvitationStatus": "Accepted",
      "BookingType": "None",
      "FormalName": "Goyette, Hauck and Corwin",
      "TaskName": "Sawayn, Ernser and Sanford",
      "ContactDepartment": "",
      "ContactFullName": "Jonas McCullough",
      "JoinVideomeetUrl": "http://www.example.com/",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 149
        }
      }
    }
  ],
  "PollingInterval": 942,
  "SilentAfter": 193,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 564
    }
  }
}
```