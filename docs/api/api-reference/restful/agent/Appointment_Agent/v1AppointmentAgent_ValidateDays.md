---
title: POST Agents/Appointment/ValidateDays
id: v1AppointmentAgent_ValidateDays
---

# POST Agents/Appointment/ValidateDays

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
    "CreatedDate": "2009-11-18T16:48:28.582449+01:00",
    "AppointmentId": 923,
    "Description": "Public-key local function",
    "StartDate": "1999-11-26T16:48:28.582449+01:00",
    "EndDate": "2020-04-09T16:48:28.582449+02:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 415,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "2013-05-29T16:48:28.582449+02:00",
    "Completed": "Completed",
    "ActiveLinks": 985,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "ea",
    "HasAlarm": true,
    "ColorIndex": 368,
    "IsFree": true,
    "IsAlldayEvent": true,
    "LagTime": "explicabo",
    "LeadTime": "qui",
    "Location": "dolor",
    "RejectCounter": 860,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "1998-11-14T16:48:28.5834487+01:00",
    "HasConflict": false,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 66,
    "Sale": {},
    "SuggestedAppointmentId": 671,
    "IsMileStone": true,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "molestias",
    "UserDefinedFields": {
      "SuperOffice:1": "1301945431",
      "SuperOffice:2": "False"
    },
    "ExtraFields": {
      "ExtraFields1": "unde",
      "ExtraFields2": "ab"
    },
    "CustomFields": {
      "CustomFields1": "consequatur",
      "CustomFields2": "eum"
    },
    "PublishEventDate": "2016-05-24T16:48:28.5834487+02:00",
    "PublishTo": "2007-01-24T16:48:28.5834487+01:00",
    "PublishFrom": "2017-05-29T16:48:28.5834487+02:00",
    "IsPublished": false,
    "VisibleFor": [
      {},
      {}
    ]
  },
  "Dates": [
    "totam",
    "reprehenderit"
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Date": "2018-07-02T16:48:28.5834487+02:00",
    "IsConflict": true,
    "Description": "Synergistic zero administration hardware",
    "DescriptionStyleHint": "Grass-roots logistical Graphic Interface",
    "Tooltip": "qui"
  },
  {
    "Date": "2018-07-02T16:48:28.5834487+02:00",
    "IsConflict": true,
    "Description": "Synergistic zero administration hardware",
    "DescriptionStyleHint": "Grass-roots logistical Graphic Interface",
    "Tooltip": "qui"
  }
]
```