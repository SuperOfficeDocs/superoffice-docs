---
title: WillSendEmail
id: v1AppointmentAgent_WillSendEmail
---

# WillSendEmail

```http
POST /api/v1/Agents/Appointment/WillSendEmail
```

Returns true if the changes will trigger email sending on Save, so you can inform the user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/WillSendEmail?$select=name,department,category/id
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

Appointment 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Partial AppointmentEntity class associating the generated AppointmentEntity with an interface. |


## Response: bool



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: bool


## Sample Request

```http!
POST /api/v1/Agents/Appointment/WillSendEmail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "Associate": {},
    "Contact": {},
    "CreatedBy": {},
    "UpdatedBy": {},
    "CreatedDate": "2003-10-14T14:58:03.0355383+02:00",
    "AppointmentId": 348,
    "Description": "User-centric client-server budgetary management",
    "StartDate": "2021-07-28T14:58:03.0355383+02:00",
    "EndDate": "2007-12-22T14:58:03.0355383+01:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 714,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "2003-04-30T14:58:03.0355383+02:00",
    "Completed": "Completed",
    "ActiveLinks": 78,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "quia",
    "HasAlarm": true,
    "ColorIndex": 311,
    "IsFree": true,
    "IsAlldayEvent": true,
    "LagTime": "est",
    "LeadTime": "ex",
    "Location": "soluta",
    "RejectCounter": 807,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "2000-10-23T14:58:03.0355383+02:00",
    "HasConflict": true,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 882,
    "Sale": {},
    "SuggestedAppointmentId": 782,
    "IsMileStone": false,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "rerum",
    "UserDefinedFields": {
      "SuperOffice:1": "1952022012",
      "SuperOffice:2": "False"
    },
    "ExtraFields": {
      "ExtraFields1": "commodi",
      "ExtraFields2": "molestias"
    },
    "CustomFields": {
      "CustomFields1": "accusantium",
      "CustomFields2": "quisquam"
    },
    "PublishEventDate": "2002-09-20T14:58:03.0355383+02:00",
    "PublishTo": "2019-11-30T14:58:03.0355383+01:00",
    "PublishFrom": "2021-01-01T14:58:03.0355383+01:00",
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

false
```