---
title: CalculateDays
id: v1AppointmentAgent_CalculateDays
---

# CalculateDays

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
    "CreatedDate": "2008-04-24T14:58:03.2005678+02:00",
    "AppointmentId": 627,
    "Description": "Multi-channelled multi-state algorithm",
    "StartDate": "2014-05-08T14:58:03.2005678+02:00",
    "EndDate": "2003-04-01T14:58:03.2005678+02:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 790,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "1995-02-28T14:58:03.2005678+01:00",
    "Completed": "Completed",
    "ActiveLinks": 328,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "non",
    "HasAlarm": true,
    "ColorIndex": 504,
    "IsFree": false,
    "IsAlldayEvent": true,
    "LagTime": "vero",
    "LeadTime": "adipisci",
    "Location": "voluptate",
    "RejectCounter": 327,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "2019-02-28T14:58:03.2005678+01:00",
    "HasConflict": false,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 583,
    "Sale": {},
    "SuggestedAppointmentId": 423,
    "IsMileStone": false,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "officia",
    "UserDefinedFields": {
      "SuperOffice:1": "158870759",
      "SuperOffice:2": "Myrna Brakus"
    },
    "ExtraFields": {
      "ExtraFields1": "iste",
      "ExtraFields2": "eos"
    },
    "CustomFields": {
      "CustomFields1": "minima",
      "CustomFields2": "dignissimos"
    },
    "PublishEventDate": "2004-05-03T14:58:03.2005678+02:00",
    "PublishTo": "2008-04-17T14:58:03.2005678+02:00",
    "PublishFrom": "2020-10-21T14:58:03.2005678+02:00",
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
  "RecurrenceId": 935,
  "StartDate": "2005-11-26T14:58:03.2005678+01:00",
  "EndDate": "2019-12-05T14:58:03.2005678+01:00",
  "RecurrenceCounter": 876,
  "RecurrenceEndType": "Counter",
  "Pattern": "Custom",
  "DayPattern": {
    "Pattern": "EveryCyclicDay",
    "Cycle": 779
  },
  "WeekPattern": {
    "Weekdays": "Friday",
    "Cycle": 105
  },
  "MonthPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 922,
    "Day": 197,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "YearPattern": {
    "Pattern": "DayOfMonth",
    "Cycle": 162,
    "Day": 367,
    "Weekday": "Friday",
    "WeekOfMonth": "First"
  },
  "Dates": [
    {
      "Date": "2006-05-10T14:58:03.2005678+02:00",
      "IsConflict": false,
      "Description": "Exclusive zero administration budgetary management",
      "DescriptionStyleHint": "Centralized user-facing contingency",
      "Tooltip": "dolores"
    },
    {
      "Date": "2006-05-10T14:58:03.2005678+02:00",
      "IsConflict": false,
      "Description": "Exclusive zero administration budgetary management",
      "DescriptionStyleHint": "Centralized user-facing contingency",
      "Tooltip": "dolores"
    }
  ],
  "IsRecurrence": true
}
```