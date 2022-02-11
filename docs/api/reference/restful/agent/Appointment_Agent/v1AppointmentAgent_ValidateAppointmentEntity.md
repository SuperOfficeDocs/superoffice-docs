---
title: POST Agents/Appointment/ValidateAppointmentEntity
id: v1AppointmentAgent_ValidateAppointmentEntity
---

# POST Agents/Appointment/ValidateAppointmentEntity

```http
POST /api/v1/Agents/Appointment/ValidateAppointmentEntity
```

Check that entity is ready for saving.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/ValidateAppointmentEntity?$select=name,department,category/id
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


## Sample Request

```http!
POST /api/v1/Agents/Appointment/ValidateAppointmentEntity
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
    "CreatedDate": "1996-04-15T18:28:47.8778476+02:00",
    "AppointmentId": 347,
    "Description": "Adaptive content-based hub",
    "StartDate": "2002-07-24T18:28:47.8778476+02:00",
    "EndDate": "1998-10-03T18:28:47.8778476+02:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 656,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "2014-02-20T18:28:47.8778476+01:00",
    "Completed": "Completed",
    "ActiveLinks": 359,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "reprehenderit",
    "HasAlarm": false,
    "ColorIndex": 97,
    "IsFree": false,
    "IsAlldayEvent": false,
    "LagTime": "voluptas",
    "LeadTime": "eveniet",
    "Location": "reprehenderit",
    "RejectCounter": 789,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "2016-03-16T18:28:47.8778476+01:00",
    "HasConflict": false,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 785,
    "Sale": {},
    "SuggestedAppointmentId": 310,
    "IsMileStone": true,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "aut",
    "UserDefinedFields": {
      "SuperOffice:1": "Loma Kub",
      "SuperOffice:2": "1899041809"
    },
    "ExtraFields": {
      "ExtraFields1": "quia",
      "ExtraFields2": "in"
    },
    "CustomFields": {
      "CustomFields1": "non",
      "CustomFields2": "rerum"
    },
    "PublishEventDate": "1997-02-21T18:28:47.8778476+01:00",
    "PublishTo": "2003-02-21T18:28:47.8778476+01:00",
    "PublishFrom": "2003-03-14T18:28:47.8778476+01:00",
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
  "1": "ea",
  "2": "adipisci"
}
```