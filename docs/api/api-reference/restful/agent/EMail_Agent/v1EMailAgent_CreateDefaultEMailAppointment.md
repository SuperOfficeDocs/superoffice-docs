---
title: CreateDefaultEMailAppointment
id: v1EMailAgent_CreateDefaultEMailAppointment
---

# CreateDefaultEMailAppointment

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
    "AppointmentId": 503,
    "StartDate": "2003-12-30T14:58:04.1714606+01:00",
    "EndDate": "2007-05-13T14:58:04.1714606+02:00",
    "Type": "BookingForChecklist",
    "Task": "aut",
    "AssociateFullName": "Rogelio Pfeffer",
    "ContactName": "Zieme, Bashirian and Hegmann",
    "Description": "Reactive needs-based solution",
    "PersonFullName": "Luigi Ratke",
    "PersonId": 704,
    "ContactId": 765,
    "ProjectId": 793,
    "ProjectName": "Nitzsche Group",
    "IsPublished": false,
    "AssociateId": 408,
    "ColorIndex": 354,
    "IsFree": false,
    "HasAlarm": true,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 94,
    "PriorityName": "Jast Group",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": true,
    "IsBooking": false,
    "ActiveDate": "1999-09-15T14:58:04.1714606+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2005-09-11T14:58:04.1714606+02:00",
    "RecurringEndDate": "2010-12-20T14:58:04.1714606+01:00",
    "MotherId": 45,
    "AssignedBy": 962,
    "AssignedByFullName": "Ms. Vada Bruen",
    "RejectReason": "",
    "Location": "nisi",
    "AlarmLeadTime": "officia",
    "SaleId": 920,
    "SaleName": "Langosh-Thiel",
    "AssociateName": "Purdy-Jacobi",
    "CreatedDate": "1995-10-23T14:58:04.1714606+02:00",
    "CreatedBy": "exercitationem",
    "CreatedByFullName": "Everette Miller",
    "CreatedByAssociateId": 469,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 353
      }
    }
  },
  "CalMethod": "Add",
  "Participants": [
    "sint",
    "nemo"
  ],
  "Comment": "dolorem",
  "Sequence": 554,
  "DtStart": "2003-11-30T14:58:04.1724703+01:00",
  "DtEnd": "1994-11-05T14:58:04.1724703+01:00",
  "Superseded": false,
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
      "FieldType": "System.Int32",
      "FieldLength": 326
    }
  }
}
```