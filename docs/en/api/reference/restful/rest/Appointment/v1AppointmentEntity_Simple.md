---
title: GET Appointment/{id}/Simple
uid: v1AppointmentEntity_Simple
generated: true
content_type: reference
---

# GET Appointment/{id}/Simple

```http
GET /api/v1/Appointment/{id}/Simple
```

A simple Appointment object.


This is a simpler, smaller variation of the full AppointmentEntity. Calls the Appointment agent service GetAppointment.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the Appointment to return. **Required** |



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


## Response:

AppointmentEntity found.

| Response | Description |
|----------------|-------------|
| 200 | AppointmentEntity found. |
| 404 | Not Found. |

### Response body: Appointment

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentId | int32 | Primary key |
| StartDate | date-time | date + start time planned |
| EndDate | date-time | Date + end time planned |
| Type | string | The different types of appointment, if the appointment is supposed to be shown in the diary or checklist, or if it's a document. See the different types of appointments in the database manual. |
| Task | string | Task comprises the different types of activities, like “Phone call”, “Meeting” and so on. |
| AssociateFullName | string | The owner of the appointment - the associate whose diary/checklist the appointment is in. |
| ContactName | string | The contact associated with the appointment. |
| Description | string | The appointment's textbox; holds a descriptive text about the appointment. Filled out by the user. |
| PersonFullName | string | The full name of the person this appointment belongs to. |
| PersonId | int32 | Person ID of person the appointment is with, may be 0 |
| ContactId | int32 | Contact ID of owning contact, may be 0 |
| ProjectId | int32 | ID of project referred to, may be 0 |
| ProjectName | string | The name of the project this appointment belong to. Blank if no project is connected. |
| IsPublished | bool | True if appointment have an entry in published table |
| AssociateId | int32 | ID of associate whose diary the appointment is in, REQUIRED |
| ColorIndex | int32 | Appointment colour, used only in Japanese versions. Western versions take colour from Task |
| IsFree | bool | True if free, false if busy |
| HasAlarm | bool | Does this appointment have an alarm |
| IsAlldayEvent | bool | True if all day event |
| Private | string | Obsolete, but still maintained field for appointment privacy; denormalization of visiblefor status |
| PriorityId | int32 | Link to priority list |
| PriorityName | string | Name of the appointments priority |
| TaskType | string | The different task types of the appointment, if the activity is an appointment, task, phone. See the different types of appointments in the database manual. |
| IsBookingMain | bool | True if this appointment is a booking and current associate is the owner. False if it is a booking and current associate is a participant. |
| IsRecurrence | bool | True if the appointment is part of a recurring pattern. |
| IsBooking | bool | True if this appointment is a booking. |
| ActiveDate | date-time | The date to be used for searching &amp; showing |
| AssignmentStatus | string | Status if this appointment is in the process of being assigned to someone else |
| InvitationStatus | string | Status if this appointment represents an invitation |
| BookingType | string | The type of booking the appointment represents |
| Completed | string | The Completed state. |
| RecurringPattern | string |  |
| RecurringStartDate | date-time |  |
| RecurringEndDate | date-time |  |
| MotherId | int32 | ID of mother appointment; self if booking master, master ID if booking slave, 0 if normal appointment. However, if 0 and assoc_id != reg_id then this is an assigned appointment, indicated vt type = kBooking |
| AssignedBy | int32 | Who (last) assigned this appointment to associate_id? |
| AssignedByFullName | string | The associate's culture formatted fullname (firstname, middleName and lastname) |
| RejectReason | string | Why was this booking or assignment rejected, the RejectReason list is a source of suggestions but you can write anything here |
| Location | string | Location for appointment, defaulted from invited resource of type place and other rules, but you can write anything you want here |
| AlarmLeadTime | string | Alarm lead time. |
| SaleId | int32 | Owning sale, if any (may be 0) |
| SaleName | string | Heading of Owning sale, if any. (may be blank) |
| AssociateName | string | The associate's name |
| CreatedDate | date-time | Appointment creation date |
| CreatedBy | string | Who created the appointment. Associate name. |
| CreatedByFullName | string | Who created the appointment. Full name. |
| CreatedByAssociateId | int32 | Id of the associate that created the appointment |
| CautionWarning | string | Status field to indicate appointments that have some sort of problem |
| OwnedExternally | string | Set if an external system owns this appointment. |
| MotherAssociateId | int32 | Associate/owner of the mother appointment |
| JoinVideomeetUrl | string | Blank when not a video meeting. Filled with Join Meeting URL when created. |
| PreferredTZLocation | int32 | Preferred timezone location to use when displaying/editing this appointment |
| Title | string | The title of the appointment. |
| Agenda | string | The agenda of the appointment. |
| InternalNotes | string | Internal notes for the appointment. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Appointment/{id}/Simple
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 AppointmentEntity found.
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 156,
  "StartDate": "2011-12-28T03:41:58.3555323+01:00",
  "EndDate": "2025-08-28T03:41:58.3555323+02:00",
  "Type": "BookingForChecklist",
  "Task": "quibusdam",
  "AssociateFullName": "Jaycee Blick",
  "ContactName": "Schuster-Kling",
  "Description": "Multi-channelled next generation data-warehouse",
  "PersonFullName": "Dr. Cortney Immanuel Gerhold",
  "PersonId": 2,
  "ContactId": 376,
  "ProjectId": 580,
  "ProjectName": "Reichert, Gorczany and Conroy",
  "IsPublished": false,
  "AssociateId": 763,
  "ColorIndex": 545,
  "IsFree": true,
  "HasAlarm": false,
  "IsAlldayEvent": false,
  "Private": "PrivateGroup",
  "PriorityId": 559,
  "PriorityName": "Feil, Becker and Ferry",
  "TaskType": "Appointment",
  "IsBookingMain": false,
  "IsRecurrence": true,
  "IsBooking": true,
  "ActiveDate": "2023-07-13T03:41:58.3555323+02:00",
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "Completed": "Completed",
  "RecurringPattern": "Custom",
  "RecurringStartDate": "2000-04-11T03:41:58.3555323+02:00",
  "RecurringEndDate": "2000-05-05T03:41:58.3555323+02:00",
  "MotherId": 157,
  "AssignedBy": 939,
  "AssignedByFullName": "Alexane Dach",
  "RejectReason": "",
  "Location": "tempora",
  "AlarmLeadTime": "amet",
  "SaleId": 384,
  "SaleName": "Schneider, Cassin and Nitzsche",
  "AssociateName": "Lehner Group",
  "CreatedDate": "2013-10-20T03:41:58.3555323+02:00",
  "CreatedBy": "cupiditate",
  "CreatedByFullName": "Mina Hammes DDS",
  "CreatedByAssociateId": 1002,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "OwnedExternally": "Google",
  "MotherAssociateId": 667,
  "JoinVideomeetUrl": "http://www.example.com/",
  "PreferredTZLocation": 384,
  "Title": "tenetur",
  "Agenda": "est",
  "InternalNotes": "sed",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 805
    }
  }
}
```