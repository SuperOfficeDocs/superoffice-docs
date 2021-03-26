---
title: POST Agents/Appointment/WillSendEmail
id: v1AppointmentAgent_WillSendEmail
---

# POST Agents/Appointment/WillSendEmail

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "Associate": {},
    "Contact": {},
    "CreatedBy": {},
    "UpdatedBy": {},
    "CreatedDate": "2004-10-23T16:48:28.4164531+02:00",
    "AppointmentId": 39,
    "Description": "Profit-focused neutral synergy",
    "StartDate": "2013-07-28T16:48:28.4164531+02:00",
    "EndDate": "2018-03-10T16:48:28.4164531+01:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 926,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "1995-07-17T16:48:28.4164531+02:00",
    "Completed": "Completed",
    "ActiveLinks": 576,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "delectus",
    "HasAlarm": false,
    "ColorIndex": 506,
    "IsFree": false,
    "IsAlldayEvent": true,
    "LagTime": "et",
    "LeadTime": "unde",
    "Location": "debitis",
    "RejectCounter": 733,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "2015-06-29T16:48:28.4174495+02:00",
    "HasConflict": true,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 770,
    "Sale": {},
    "SuggestedAppointmentId": 573,
    "IsMileStone": false,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "incidunt",
    "UserDefinedFields": {
      "SuperOffice:1": "Darrell Littel DDS",
      "SuperOffice:2": "Jaylin Lehner"
    },
    "ExtraFields": {
      "ExtraFields1": "nemo",
      "ExtraFields2": "consequatur"
    },
    "CustomFields": {
      "CustomFields1": "consequatur",
      "CustomFields2": "corrupti"
    },
    "PublishEventDate": "1995-09-19T16:48:28.4174495+02:00",
    "PublishTo": "1998-08-19T16:48:28.4174495+02:00",
    "PublishFrom": "2016-02-22T16:48:28.4174495+01:00",
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

true
```