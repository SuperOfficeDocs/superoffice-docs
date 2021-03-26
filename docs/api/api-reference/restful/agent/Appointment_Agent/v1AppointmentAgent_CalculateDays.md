---
title: POST Agents/Appointment/CalculateDays
id: v1AppointmentAgent_CalculateDays
---

# POST Agents/Appointment/CalculateDays

```http
POST /api/v1/Agents/Appointment/CalculateDays
```

Calculates the set of dates that represents a recurrence pattern.

Adds conflict information to each date.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CalculateDays?$select=name,department,category/id
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

AppointmentEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentEntity |  | Partial AppointmentEntity class associating the generated AppointmentEntity with an interface. |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| RecurrenceId | int32 |  |
| StartDate | date-time |  |
| EndDate | date-time |  |
| RecurrenceCounter | int32 |  |
| RecurrenceEndType | string |  |
| Pattern | string |  |
| DayPattern |  |  |
| WeekPattern |  |  |
| MonthPattern |  |  |
| YearPattern |  |  |
| Dates | array |  |
| IsRecurrence | bool |  |

## Sample Request

```http!
POST /api/v1/Agents/Appointment/CalculateDays
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AppointmentEntity": {
    "Associate": {},
    "Contact": {},
    "CreatedBy": {},
    "UpdatedBy": {},
    "CreatedDate": "2005-01-21T16:48:28.582449+01:00",
    "AppointmentId": 697,
    "Description": "Re-engineered demand-driven solution",
    "StartDate": "1997-08-06T16:48:28.582449+02:00",
    "EndDate": "2014-03-19T16:48:28.582449+01:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 257,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "2000-10-14T16:48:28.582449+02:00",
    "Completed": "Completed",
    "ActiveLinks": 862,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "accusantium",
    "HasAlarm": false,
    "ColorIndex": 265,
    "IsFree": true,
    "IsAlldayEvent": true,
    "LagTime": "reprehenderit",
    "LeadTime": "et",
    "Location": "fuga",
    "RejectCounter": 178,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "2004-02-17T16:48:28.582449+01:00",
    "HasConflict": false,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 44,
    "Sale": {},
    "SuggestedAppointmentId": 594,
    "IsMileStone": false,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "voluptatem",
    "UserDefinedFields": {
      "SuperOffice:1": "True",
      "SuperOffice:2": "False"
    },
    "ExtraFields": {
      "ExtraFields1": "sit",
      "ExtraFields2": "rem"
    },
    "CustomFields": {
      "CustomFields1": "amet",
      "CustomFields2": "possimus"
    },
    "PublishEventDate": "2003-01-11T16:48:28.582449+01:00",
    "PublishTo": "2007-06-21T16:48:28.582449+02:00",
    "PublishFrom": "2002-01-19T16:48:28.582449+01:00",
    "IsPublished": false,
    "VisibleFor": [
      {},
      {}
    ]
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RecurrenceId": 542,
  "StartDate": "1996-10-25T16:48:28.582449+02:00",
  "EndDate": "2012-11-02T16:48:28.582449+01:00",
  "RecurrenceCounter": 474,
  "RecurrenceEndType": "Counter",
  "Pattern": "Custom",
  "DayPattern": {
    "Pattern": "EveryCyclicDay",
    "Cycle": 548
  },
  "WeekPattern": {
    "Weekdays": "Friday",
    "Cycle": 686
  },
  "MonthPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 229,
    "Day": 471,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "YearPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 276,
    "Day": 933,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "Dates": [
    {
      "Date": "1998-06-11T16:48:28.582449+02:00",
      "IsConflict": true,
      "Description": "Assimilated web-enabled groupware",
      "DescriptionStyleHint": "Vision-oriented coherent intranet",
      "Tooltip": "id"
    },
    {
      "Date": "1998-06-11T16:48:28.582449+02:00",
      "IsConflict": true,
      "Description": "Assimilated web-enabled groupware",
      "DescriptionStyleHint": "Vision-oriented coherent intranet",
      "Tooltip": "id"
    }
  ],
  "IsRecurrence": true
}
```