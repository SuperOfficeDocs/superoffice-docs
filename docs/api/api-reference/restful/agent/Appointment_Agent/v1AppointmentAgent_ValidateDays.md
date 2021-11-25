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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AppointmentEntity": {
    "Associate": {},
    "Contact": {},
    "CreatedBy": {},
    "UpdatedBy": {},
    "CreatedDate": "1996-08-10T18:28:48.0568502+02:00",
    "AppointmentId": 371,
    "Description": "De-engineered bi-directional system engine",
    "StartDate": "2021-05-24T18:28:48.0568502+02:00",
    "EndDate": "1999-09-07T18:28:48.0568502+02:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 431,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "1998-08-18T18:28:48.0568502+02:00",
    "Completed": "Completed",
    "ActiveLinks": 956,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "omnis",
    "HasAlarm": false,
    "ColorIndex": 184,
    "IsFree": false,
    "IsAlldayEvent": false,
    "LagTime": "molestiae",
    "LeadTime": "hic",
    "Location": "ipsam",
    "RejectCounter": 937,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "2002-06-03T18:28:48.0568502+02:00",
    "HasConflict": true,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 704,
    "Sale": {},
    "SuggestedAppointmentId": 58,
    "IsMileStone": false,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "sapiente",
    "UserDefinedFields": {
      "SuperOffice:1": "Miss Hudson Harris",
      "SuperOffice:2": "Mr. Alana Bergnaum"
    },
    "ExtraFields": {
      "ExtraFields1": "illum",
      "ExtraFields2": "aut"
    },
    "CustomFields": {
      "CustomFields1": "fuga",
      "CustomFields2": "quae"
    },
    "PublishEventDate": "1999-08-12T18:28:48.0568502+02:00",
    "PublishTo": "1994-10-23T18:28:48.0568502+02:00",
    "PublishFrom": "2009-03-30T18:28:48.0568502+02:00",
    "IsPublished": true,
    "VisibleFor": [
      {},
      {}
    ]
  },
  "Dates": [
    "et",
    "iste"
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Date": "1998-04-14T18:28:48.0578499+02:00",
    "IsConflict": false,
    "Description": "Expanded full-range superstructure",
    "DescriptionStyleHint": "Mandatory real-time system engine",
    "Tooltip": "eveniet"
  },
  {
    "Date": "1998-04-14T18:28:48.0578499+02:00",
    "IsConflict": false,
    "Description": "Expanded full-range superstructure",
    "DescriptionStyleHint": "Mandatory real-time system engine",
    "Tooltip": "eveniet"
  }
]
```