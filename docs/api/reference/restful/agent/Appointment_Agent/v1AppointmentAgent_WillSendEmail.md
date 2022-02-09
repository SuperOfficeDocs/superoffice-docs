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
    "CreatedDate": "2014-01-22T18:28:47.8788444+01:00",
    "AppointmentId": 893,
    "Description": "Automated impactful archive",
    "StartDate": "2007-07-31T18:28:47.8788444+02:00",
    "EndDate": "2016-01-29T18:28:47.8788444+01:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 15,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "2016-02-20T18:28:47.8788444+01:00",
    "Completed": "Completed",
    "ActiveLinks": 521,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "iusto",
    "HasAlarm": false,
    "ColorIndex": 742,
    "IsFree": true,
    "IsAlldayEvent": true,
    "LagTime": "veniam",
    "LeadTime": "debitis",
    "Location": "nobis",
    "RejectCounter": 854,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "2003-11-25T18:28:47.8788444+01:00",
    "HasConflict": true,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 140,
    "Sale": {},
    "SuggestedAppointmentId": 184,
    "IsMileStone": false,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "illo",
    "UserDefinedFields": {
      "SuperOffice:1": "Sylvester Weimann",
      "SuperOffice:2": "1019523333"
    },
    "ExtraFields": {
      "ExtraFields1": "non",
      "ExtraFields2": "esse"
    },
    "CustomFields": {
      "CustomFields1": "expedita",
      "CustomFields2": "nemo"
    },
    "PublishEventDate": "2015-02-04T18:28:47.8788444+01:00",
    "PublishTo": "1996-12-13T18:28:47.8788444+01:00",
    "PublishFrom": "1996-06-30T18:28:47.8788444+02:00",
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