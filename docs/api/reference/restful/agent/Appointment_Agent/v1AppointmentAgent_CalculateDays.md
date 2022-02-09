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
    "CreatedDate": "2006-07-10T18:28:48.0558517+02:00",
    "AppointmentId": 640,
    "Description": "Inverse tangible instruction set",
    "StartDate": "2004-03-05T18:28:48.0558517+01:00",
    "EndDate": "1998-08-20T18:28:48.0558517+02:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 994,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "2012-05-24T18:28:48.0558517+02:00",
    "Completed": "Completed",
    "ActiveLinks": 919,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "reprehenderit",
    "HasAlarm": true,
    "ColorIndex": 133,
    "IsFree": false,
    "IsAlldayEvent": true,
    "LagTime": "id",
    "LeadTime": "vel",
    "Location": "est",
    "RejectCounter": 485,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "2001-06-19T18:28:48.0558517+02:00",
    "HasConflict": true,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 235,
    "Sale": {},
    "SuggestedAppointmentId": 744,
    "IsMileStone": true,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "omnis",
    "UserDefinedFields": {
      "SuperOffice:1": "1422881114",
      "SuperOffice:2": "1716013544"
    },
    "ExtraFields": {
      "ExtraFields1": "ut",
      "ExtraFields2": "ut"
    },
    "CustomFields": {
      "CustomFields1": "voluptatem",
      "CustomFields2": "enim"
    },
    "PublishEventDate": "2020-04-07T18:28:48.0568502+02:00",
    "PublishTo": "2010-03-04T18:28:48.0568502+01:00",
    "PublishFrom": "2006-03-22T18:28:48.0568502+01:00",
    "IsPublished": true,
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
  "RecurrenceId": 320,
  "StartDate": "1996-07-29T18:28:48.0568502+02:00",
  "EndDate": "2015-10-27T18:28:48.0568502+01:00",
  "RecurrenceCounter": 365,
  "RecurrenceEndType": "Counter",
  "Pattern": "Custom",
  "DayPattern": {
    "Pattern": "EveryCyclicDay",
    "Cycle": 504
  },
  "WeekPattern": {
    "Weekdays": "Friday",
    "Cycle": 630
  },
  "MonthPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 255,
    "Day": 207,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "YearPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 897,
    "Day": 36,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "Dates": [
    {
      "Date": "2002-07-11T18:28:48.0568502+02:00",
      "IsConflict": true,
      "Description": "Visionary multi-tasking local area network",
      "DescriptionStyleHint": "Quality-focused intermediate help-desk",
      "Tooltip": "dolorum"
    },
    {
      "Date": "2002-07-11T18:28:48.0568502+02:00",
      "IsConflict": true,
      "Description": "Visionary multi-tasking local area network",
      "DescriptionStyleHint": "Quality-focused intermediate help-desk",
      "Tooltip": "dolorum"
    }
  ],
  "IsRecurrence": false
}
```