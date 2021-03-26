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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AppointmentEntity": {
    "Associate": {},
    "Contact": {},
    "CreatedBy": {},
    "UpdatedBy": {},
    "CreatedDate": "2014-12-25T16:48:28.4164531+01:00",
    "AppointmentId": 678,
    "Description": "Re-engineered context-sensitive collaboration",
    "StartDate": "2008-10-04T16:48:28.4164531+02:00",
    "EndDate": "2015-05-27T16:48:28.4164531+02:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 877,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "2014-09-25T16:48:28.4164531+02:00",
    "Completed": "Completed",
    "ActiveLinks": 977,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "molestiae",
    "HasAlarm": true,
    "ColorIndex": 388,
    "IsFree": false,
    "IsAlldayEvent": false,
    "LagTime": "molestiae",
    "LeadTime": "suscipit",
    "Location": "velit",
    "RejectCounter": 59,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "2002-10-05T16:48:28.4164531+02:00",
    "HasConflict": true,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 454,
    "Sale": {},
    "SuggestedAppointmentId": 66,
    "IsMileStone": true,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "nobis",
    "UserDefinedFields": {
      "SuperOffice:1": "Abdul Schuppe",
      "SuperOffice:2": "Jaylon Buckridge"
    },
    "ExtraFields": {
      "ExtraFields1": "aut",
      "ExtraFields2": "eveniet"
    },
    "CustomFields": {
      "CustomFields1": "ullam",
      "CustomFields2": "reiciendis"
    },
    "PublishEventDate": "2011-11-30T16:48:28.4164531+01:00",
    "PublishTo": "1994-06-05T16:48:28.4164531+02:00",
    "PublishFrom": "1999-02-08T16:48:28.4164531+01:00",
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
  "1": "quibusdam",
  "2": "voluptates"
}
```