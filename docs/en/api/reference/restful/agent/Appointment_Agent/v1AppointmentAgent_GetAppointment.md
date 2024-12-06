---
title: POST Agents/Appointment/GetAppointment
uid: v1AppointmentAgent_GetAppointment
generated: true
---

# POST Agents/Appointment/GetAppointment

```http
POST /api/v1/Agents/Appointment/GetAppointment
```

Gets a Appointment object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| appointmentId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetAppointment?appointmentId=466
POST /api/v1/Agents/Appointment/GetAppointment?$select=name,department,category/id
```


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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
| JoinVideomeetUrl | string | Blank when not a video meeting. Filled with Join Meeting URL when created. |
| PreferredTZLocation | int32 | Preferred timezone location to use when displaying/editing this appointment |
| Title | string | The title of the appointment. |
| Agenda | string | The agenda of the appointment. |
| InternalNotes | string | Internal notes for the appointment. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/GetAppointment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 558,
  "StartDate": "2000-12-11T10:17:54.9727508+01:00",
  "EndDate": "2004-01-25T10:17:54.9727508+01:00",
  "Type": "BookingForChecklist",
  "Task": "quidem",
  "AssociateFullName": "Bartholome Koch",
  "ContactName": "Reinger Inc and Sons",
  "Description": "Cloned mobile circuit",
  "PersonFullName": "Harvey Bogan",
  "PersonId": 263,
  "ContactId": 1000,
  "ProjectId": 874,
  "ProjectName": "Conn-Torp",
  "IsPublished": true,
  "AssociateId": 65,
  "ColorIndex": 261,
  "IsFree": false,
  "HasAlarm": false,
  "IsAlldayEvent": true,
  "Private": "PrivateGroup",
  "PriorityId": 455,
  "PriorityName": "Schmitt Group",
  "TaskType": "Appointment",
  "IsBookingMain": true,
  "IsRecurrence": true,
  "IsBooking": false,
  "ActiveDate": "2022-03-10T10:17:54.9727508+01:00",
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "Completed": "Completed",
  "RecurringPattern": "Custom",
  "RecurringStartDate": "2006-01-16T10:17:54.9727508+01:00",
  "RecurringEndDate": "2012-12-12T10:17:54.9727508+01:00",
  "MotherId": 49,
  "AssignedBy": 603,
  "AssignedByFullName": "Antwan Bettye Kertzmann Sr.",
  "RejectReason": "",
  "Location": "voluptates",
  "AlarmLeadTime": "accusamus",
  "SaleId": 800,
  "SaleName": "Russel-Carroll",
  "AssociateName": "Labadie Group",
  "CreatedDate": "2017-12-29T10:17:54.9727508+01:00",
  "CreatedBy": "ipsam",
  "CreatedByFullName": "Prof. Brian Carlee Thompson",
  "CreatedByAssociateId": 823,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "PreferredTZLocation": 185,
  "Title": "ducimus",
  "Agenda": "ut",
  "InternalNotes": "et",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 115
    }
  }
}
```