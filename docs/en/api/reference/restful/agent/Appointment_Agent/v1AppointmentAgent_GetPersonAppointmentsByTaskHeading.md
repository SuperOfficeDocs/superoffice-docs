---
title: POST Agents/Appointment/GetPersonAppointmentsByTaskHeading
uid: v1AppointmentAgent_GetPersonAppointmentsByTaskHeading
generated: true
---

# POST Agents/Appointment/GetPersonAppointmentsByTaskHeading

```http
POST /api/v1/Agents/Appointment/GetPersonAppointmentsByTaskHeading
```

Method that returns a specified number of appointments of a specific appointment task heading within a time range.


The appointments belong to the person specified.  Task represents the different types of activities, like “Phone call”, “Meeting” and so on. The heading represents a grouping or filtering of tasks.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetPersonAppointmentsByTaskHeading?$select=name,department,category/id
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

PersonId, IncludeProjectAppointments, StartTime, EndTime, Count, TaskHeadingId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer |  |
| IncludeProjectAppointments | Boolean |  |
| StartTime | String |  |
| EndTime | String |  |
| Count | Integer |  |
| TaskHeadingId | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
POST /api/v1/Agents/Appointment/GetPersonAppointmentsByTaskHeading
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 211,
  "IncludeProjectAppointments": true,
  "StartTime": "2005-02-24T10:17:54.8164912+01:00",
  "EndTime": "2002-10-10T10:17:54.8164912+02:00",
  "Count": 227,
  "TaskHeadingId": 869
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AppointmentId": 949,
    "StartDate": "2002-08-14T10:17:54.8164912+02:00",
    "EndDate": "2002-04-15T10:17:54.8164912+02:00",
    "Type": "BookingForChecklist",
    "Task": "recusandae",
    "AssociateFullName": "Hazel O'Kon",
    "ContactName": "Wilderman-Eichmann",
    "Description": "Universal 3rd generation monitoring",
    "PersonFullName": "Godfrey Frami",
    "PersonId": 660,
    "ContactId": 938,
    "ProjectId": 902,
    "ProjectName": "Herman-D'Amore",
    "IsPublished": true,
    "AssociateId": 423,
    "ColorIndex": 960,
    "IsFree": false,
    "HasAlarm": true,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 242,
    "PriorityName": "Armstrong, Boehm and Waelchi",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": true,
    "IsBooking": true,
    "ActiveDate": "2009-07-20T10:17:54.8164912+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2003-10-31T10:17:54.8164912+01:00",
    "RecurringEndDate": "2008-12-24T10:17:54.8164912+01:00",
    "MotherId": 495,
    "AssignedBy": 816,
    "AssignedByFullName": "Arlie Ernser",
    "RejectReason": "",
    "Location": "voluptatibus",
    "AlarmLeadTime": "beatae",
    "SaleId": 498,
    "SaleName": "Cummerata, Wyman and McDermott",
    "AssociateName": "Nikolaus LLC",
    "CreatedDate": "2000-07-25T10:17:54.8164912+02:00",
    "CreatedBy": "nostrum",
    "CreatedByFullName": "Jorge Spencer",
    "CreatedByAssociateId": 611,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "PreferredTZLocation": 31,
    "Title": "quos",
    "Agenda": "quaerat",
    "InternalNotes": "corporis",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 599
      }
    }
  }
]
```