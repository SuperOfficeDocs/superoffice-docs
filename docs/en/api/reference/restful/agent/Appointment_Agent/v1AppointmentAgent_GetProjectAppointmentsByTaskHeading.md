---
title: POST Agents/Appointment/GetProjectAppointmentsByTaskHeading
uid: v1AppointmentAgent_GetProjectAppointmentsByTaskHeading
generated: true
---

# POST Agents/Appointment/GetProjectAppointmentsByTaskHeading

```http
POST /api/v1/Agents/Appointment/GetProjectAppointmentsByTaskHeading
```

Method that returns a specified number of appointments of a specific appointment task heading within a time range.


The appointments belong to the project specified.  Task represents the different types of activities, like “Phone call”, “Meeting” and so on. The heading represents a grouping or filtering of tasks.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetProjectAppointmentsByTaskHeading?$select=name,department,category/id
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

ProjectId, StartTime, EndTime, Count, TaskHeadingId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | Integer |  |
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
POST /api/v1/Agents/Appointment/GetProjectAppointmentsByTaskHeading
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 957,
  "StartTime": "2001-06-28T12:57:32.7271897+02:00",
  "EndTime": "2019-07-21T12:57:32.7271897+02:00",
  "Count": 225,
  "TaskHeadingId": 109
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AppointmentId": 420,
    "StartDate": "1997-12-12T12:57:32.7271897+01:00",
    "EndDate": "2005-02-06T12:57:32.7271897+01:00",
    "Type": "BookingForChecklist",
    "Task": "rerum",
    "AssociateFullName": "Dr. Catherine Carlotta Hahn Sr.",
    "ContactName": "Schimmel, Koch and Wilkinson",
    "Description": "Optional zero defect access",
    "PersonFullName": "Cheyenne Gutkowski",
    "PersonId": 891,
    "ContactId": 155,
    "ProjectId": 117,
    "ProjectName": "Crona-Veum",
    "IsPublished": true,
    "AssociateId": 838,
    "ColorIndex": 583,
    "IsFree": true,
    "HasAlarm": false,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 851,
    "PriorityName": "Veum Group",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": false,
    "IsBooking": false,
    "ActiveDate": "2013-01-13T12:57:32.7271897+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2009-07-02T12:57:32.7271897+02:00",
    "RecurringEndDate": "2015-08-03T12:57:32.7271897+02:00",
    "MotherId": 381,
    "AssignedBy": 670,
    "AssignedByFullName": "Mrs. Zakary Immanuel Swift",
    "RejectReason": "",
    "Location": "quo",
    "AlarmLeadTime": "error",
    "SaleId": 237,
    "SaleName": "Russel Inc and Sons",
    "AssociateName": "Roberts, Spinka and Nader",
    "CreatedDate": "2007-02-18T12:57:32.7271897+01:00",
    "CreatedBy": "magni",
    "CreatedByFullName": "Nils Ebert",
    "CreatedByAssociateId": 333,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "PreferredTZLocation": 275,
    "Title": "harum",
    "Agenda": "voluptatem",
    "InternalNotes": "nulla",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 722
      }
    }
  }
]
```