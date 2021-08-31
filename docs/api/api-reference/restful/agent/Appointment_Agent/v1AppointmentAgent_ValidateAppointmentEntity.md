---
title: ValidateAppointmentEntity
id: v1AppointmentAgent_ValidateAppointmentEntity
---

# ValidateAppointmentEntity

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
    "CreatedDate": "2017-10-31T14:58:03.0345382+01:00",
    "AppointmentId": 517,
    "Description": "Future-proofed fresh-thinking array",
    "StartDate": "2016-06-28T14:58:03.0345382+02:00",
    "EndDate": "1999-10-11T14:58:03.0345382+02:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 475,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "2009-12-27T14:58:03.0345382+01:00",
    "Completed": "Completed",
    "ActiveLinks": 535,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "libero",
    "HasAlarm": false,
    "ColorIndex": 814,
    "IsFree": false,
    "IsAlldayEvent": true,
    "LagTime": "perspiciatis",
    "LeadTime": "commodi",
    "Location": "vel",
    "RejectCounter": 966,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "2014-02-22T14:58:03.0345382+01:00",
    "HasConflict": true,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 32,
    "Sale": {},
    "SuggestedAppointmentId": 394,
    "IsMileStone": true,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "eos",
    "UserDefinedFields": {
      "SuperOffice:1": "False",
      "SuperOffice:2": "714711524"
    },
    "ExtraFields": {
      "ExtraFields1": "et",
      "ExtraFields2": "molestias"
    },
    "CustomFields": {
      "CustomFields1": "dolore",
      "CustomFields2": "libero"
    },
    "PublishEventDate": "1996-07-19T14:58:03.0345382+02:00",
    "PublishTo": "2020-09-23T14:58:03.0345382+02:00",
    "PublishFrom": "2012-01-18T14:58:03.0345382+01:00",
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
  "1": "ipsum",
  "2": "est"
}
```