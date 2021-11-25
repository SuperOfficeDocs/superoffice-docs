---
title: POST Agents/EMail/CreateDefaultEMailAppointment
id: v1EMailAgent_CreateDefaultEMailAppointment
---

# POST Agents/EMail/CreateDefaultEMailAppointment

```http
POST /api/v1/Agents/EMail/CreateDefaultEMailAppointment
```

Set default values into a new EMailAppointment.

NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Information about an email appointment received as iCal data



Carrier object for EMailAppointment.
Services for the EMailAppointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Appointment information |
| CalMethod | string | Method field stored in ICS file. |
| Participants | array | List of participants in the iCal file - first one being the organizer |
| Comment | string | Comment attached to the calendar event (accept / reject reason etc.) |
| Sequence | int32 | Sequence number in ICS file. |
| DtStart | date-time | Start date/time in ICS file. |
| DtEnd | date-time | End date/time in ICS file. |
| Superseded | bool | A newer invitation exists |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/EMail/CreateDefaultEMailAppointment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 102,
    "StartDate": "1994-09-11T18:28:49.0799615+02:00",
    "EndDate": "2015-02-16T18:28:49.0799615+01:00",
    "Type": "BookingForChecklist",
    "Task": "doloribus",
    "AssociateFullName": "Erin McKenzie III",
    "ContactName": "Kshlerin-Green",
    "Description": "Reverse-engineered object-oriented website",
    "PersonFullName": "Amely Heathcote MD",
    "PersonId": 938,
    "ContactId": 270,
    "ProjectId": 837,
    "ProjectName": "Kuvalis, Thompson and Ziemann",
    "IsPublished": true,
    "AssociateId": 178,
    "ColorIndex": 310,
    "IsFree": false,
    "HasAlarm": true,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 149,
    "PriorityName": "Paucek Inc and Sons",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": false,
    "IsBooking": false,
    "ActiveDate": "2000-01-21T18:28:49.0799615+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "1996-12-05T18:28:49.0799615+01:00",
    "RecurringEndDate": "2008-12-15T18:28:49.0799615+01:00",
    "MotherId": 170,
    "AssignedBy": 854,
    "AssignedByFullName": "Miss Adrienne Sipes",
    "RejectReason": "incentivize leading-edge e-tailers",
    "Location": "molestiae",
    "AlarmLeadTime": "minima",
    "SaleId": 446,
    "SaleName": "Price LLC",
    "AssociateName": "Kunde-Gutkowski",
    "CreatedDate": "2019-04-10T18:28:49.0799615+02:00",
    "CreatedBy": "fugit",
    "CreatedByFullName": "Mr. Janie Walker",
    "CreatedByAssociateId": 894,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 705
      }
    }
  },
  "CalMethod": "Add",
  "Participants": [
    "sequi",
    "optio"
  ],
  "Comment": "quasi",
  "Sequence": 434,
  "DtStart": "2020-12-28T18:28:49.0809619+01:00",
  "DtEnd": "2000-08-01T18:28:49.0809619+02:00",
  "Superseded": true,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 113
    }
  }
}
```