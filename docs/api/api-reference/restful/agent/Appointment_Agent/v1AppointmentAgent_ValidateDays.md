---
title: ValidateDays
id: v1AppointmentAgent_ValidateDays
---

# ValidateDays

```http
POST /api/v1/Agents/Appointment/ValidateDays
```

Validates the set of dates to calculate any conflicts.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/ValidateDays?$select=name,department,category/id
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

AppointmentEntity, Dates 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentEntity |  | Partial AppointmentEntity class associating the generated AppointmentEntity with an interface. |
| Dates | array |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Date | date-time |  |
| IsConflict | bool |  |
| Description | string |  |
| DescriptionStyleHint | string |  |
| Tooltip | string |  |

## Sample Request

```http!
POST /api/v1/Agents/Appointment/ValidateDays
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AppointmentEntity": {
    "Associate": {},
    "Contact": {},
    "CreatedBy": {},
    "UpdatedBy": {},
    "CreatedDate": "2003-07-18T14:58:03.2015728+02:00",
    "AppointmentId": 840,
    "Description": "Cloned zero administration synergy",
    "StartDate": "2011-06-09T14:58:03.2015728+02:00",
    "EndDate": "2014-10-02T14:58:03.2015728+02:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 583,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "2013-07-28T14:58:03.2015728+02:00",
    "Completed": "Completed",
    "ActiveLinks": 669,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "amet",
    "HasAlarm": false,
    "ColorIndex": 117,
    "IsFree": true,
    "IsAlldayEvent": true,
    "LagTime": "rerum",
    "LeadTime": "sit",
    "Location": "aliquam",
    "RejectCounter": 317,
    "RejectReason": "scale end-to-end users",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "1998-11-08T14:58:03.2015728+01:00",
    "HasConflict": false,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 83,
    "Sale": {},
    "SuggestedAppointmentId": 115,
    "IsMileStone": false,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "voluptates",
    "UserDefinedFields": {
      "SuperOffice:1": "True",
      "SuperOffice:2": "Quinten White"
    },
    "ExtraFields": {
      "ExtraFields1": "qui",
      "ExtraFields2": "vero"
    },
    "CustomFields": {
      "CustomFields1": "voluptas",
      "CustomFields2": "qui"
    },
    "PublishEventDate": "2002-09-12T14:58:03.2015728+02:00",
    "PublishTo": "2002-01-31T14:58:03.2015728+01:00",
    "PublishFrom": "2005-03-06T14:58:03.2015728+01:00",
    "IsPublished": true,
    "VisibleFor": [
      {},
      {}
    ]
  },
  "Dates": [
    "quia",
    "rerum"
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Date": "2017-04-17T14:58:03.2015728+02:00",
    "IsConflict": true,
    "Description": "Phased bandwidth-monitored capacity",
    "DescriptionStyleHint": "Re-contextualized directional project",
    "Tooltip": "aut"
  },
  {
    "Date": "2017-04-17T14:58:03.2015728+02:00",
    "IsConflict": true,
    "Description": "Phased bandwidth-monitored capacity",
    "DescriptionStyleHint": "Re-contextualized directional project",
    "Tooltip": "aut"
  }
]
```