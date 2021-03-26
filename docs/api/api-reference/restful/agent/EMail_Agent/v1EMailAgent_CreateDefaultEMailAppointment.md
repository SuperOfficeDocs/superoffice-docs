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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 121,
    "StartDate": "2000-10-20T16:48:29.5519243+02:00",
    "EndDate": "2002-07-05T16:48:29.5519243+02:00",
    "Type": "BookingForChecklist",
    "Task": "hic",
    "AssociateFullName": "Jackson Wilkinson",
    "ContactName": "Bartoletti Inc and Sons",
    "Description": "De-engineered system-worthy service-desk",
    "PersonFullName": "Alena Kris",
    "PersonId": 170,
    "ContactId": 687,
    "ProjectId": 330,
    "ProjectName": "Durgan, Streich and Sporer",
    "IsPublished": true,
    "AssociateId": 723,
    "ColorIndex": 144,
    "IsFree": false,
    "HasAlarm": true,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 655,
    "PriorityName": "Mann, Schuster and Ruecker",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": true,
    "IsBooking": true,
    "ActiveDate": "2012-04-20T16:48:29.5519243+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2007-10-13T16:48:29.5519243+02:00",
    "RecurringEndDate": "2008-02-24T16:48:29.5519243+01:00",
    "MotherId": 194,
    "AssignedBy": 774,
    "AssignedByFullName": "Dr. Brandy Schimmel",
    "RejectReason": "",
    "Location": "illum",
    "AlarmLeadTime": "ut",
    "SaleId": 232,
    "SaleName": "Koepp-Torp",
    "AssociateName": "Stracke LLC",
    "CreatedDate": "2012-08-31T16:48:29.5529306+02:00",
    "CreatedBy": "consequatur",
    "CreatedByFullName": "Wilton Herzog DDS",
    "CreatedByAssociateId": 368,
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
        "FieldLength": 184
      }
    }
  },
  "CalMethod": "Add",
  "Participants": [
    "nam",
    "ullam"
  ],
  "Comment": "quis",
  "Sequence": 528,
  "DtStart": "2019-09-27T16:48:29.5529306+02:00",
  "DtEnd": "2013-06-29T16:48:29.5529306+02:00",
  "Superseded": true,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "productize user-centric applications"
      },
      "FieldType": "System.Int32",
      "FieldLength": 622
    }
  }
}
```