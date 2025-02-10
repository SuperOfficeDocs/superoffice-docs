---
title: POST Agents/Appointment/UpdateAppointmentWithMode
uid: v1AppointmentAgent_UpdateAppointmentWithMode
generated: true
---

# POST Agents/Appointment/UpdateAppointmentWithMode

```http
POST /api/v1/Agents/Appointment/UpdateAppointmentWithMode
```

Updates an appointment record, taking the given recurrence update mode into account.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/UpdateAppointmentWithMode?$select=name,department,category/id
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

Id, StartTime, EndTime, Status, Type, AssociateId, UpdateMode 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | Integer |  |
| StartTime | String |  |
| EndTime | String |  |
| Status | String |  |
| Type | String |  |
| AssociateId | Integer |  |
| UpdateMode | String |  |

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
POST /api/v1/Agents/Appointment/UpdateAppointmentWithMode
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Id": 573,
  "StartTime": "2013-10-13T12:01:27.0252114+02:00",
  "EndTime": "2008-06-03T12:01:27.0252114+02:00",
  "Status": "Assignment",
  "Type": "BookingForChecklist",
  "AssociateId": 124,
  "UpdateMode": "OnlyThis"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 973,
  "StartDate": "2012-08-07T12:01:27.0252114+02:00",
  "EndDate": "2018-02-26T12:01:27.0252114+01:00",
  "Type": "BookingForChecklist",
  "Task": "officiis",
  "AssociateFullName": "Quinn Kris",
  "ContactName": "Greenfelder Inc and Sons",
  "Description": "Realigned stable architecture",
  "PersonFullName": "Maximo Abshire II",
  "PersonId": 381,
  "ContactId": 597,
  "ProjectId": 543,
  "ProjectName": "Medhurst-Doyle",
  "IsPublished": true,
  "AssociateId": 768,
  "ColorIndex": 623,
  "IsFree": false,
  "HasAlarm": false,
  "IsAlldayEvent": false,
  "Private": "PrivateGroup",
  "PriorityId": 860,
  "PriorityName": "Schumm LLC",
  "TaskType": "Appointment",
  "IsBookingMain": true,
  "IsRecurrence": true,
  "IsBooking": false,
  "ActiveDate": "2021-07-18T12:01:27.0252114+02:00",
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "Completed": "Completed",
  "RecurringPattern": "Custom",
  "RecurringStartDate": "2006-09-13T12:01:27.0252114+02:00",
  "RecurringEndDate": "2001-10-15T12:01:27.0252114+02:00",
  "MotherId": 109,
  "AssignedBy": 524,
  "AssignedByFullName": "Adrien Tromp",
  "RejectReason": "",
  "Location": "facere",
  "AlarmLeadTime": "deleniti",
  "SaleId": 318,
  "SaleName": "Lemke Group",
  "AssociateName": "Keebler-Sauer",
  "CreatedDate": "2015-04-17T12:01:27.0252114+02:00",
  "CreatedBy": "voluptatem",
  "CreatedByFullName": "Prof. Nelle Kub",
  "CreatedByAssociateId": 619,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "PreferredTZLocation": 160,
  "Title": "qui",
  "Agenda": "voluptatem",
  "InternalNotes": "ullam",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 59
    }
  }
}
```