---
title: POST Agents/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate
uid: v1AppointmentAgent_CreateDefaultAppointmentEntityByTypeAndAssociate
generated: true
---

# POST Agents/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate
```

Creates a AppointmentEntity populated with the default values for the specific type and owner.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate?$select=name,department,category/id
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

Type, AssociateId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Type | String |  |
| AssociateId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: AppointmentEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| Associate | Associate | The owner of the appointment - the associate whose diary/checklist the appointment is in.  Use MDO List name "associate" to get list items. |
| Contact | Contact | The contact associated with the appointment. It may also be null if no contact is associated with the appointment.  Use MDO List name "contact_new" to get list items. |
| CreatedBy | Associate | The associate that first created the appointment. The property is read-only. |
| UpdatedBy | Associate | The person that last updated the appointment. |
| CreatedDate | date-time | Registered date  in UTC. |
| AppointmentId | int32 | Primary key |
| Description | string | Description of the appointment. |
| Title | string | The title of the appointment. |
| Agenda | string | The agenda of the appointment. |
| InternalNotes | string | Internal notes for the appointment. |
| StartDate | date-time | date + start time planned |
| EndDate | date-time | Date + end time planned |
| InvitedPerson | Person | If the appointment is a booking, the invited persons may be your associates, but you are also able to invite contact persons from other companies to join your meeting. They do not receive an invitation, unless you send them one by email, but you can see in the appointment that persons other than your associates have been invited to a meeting. Each invited person will have an appointment slave record. |
| Person | Person | An appointment may also be connected to a person; this must be a contact person registered on the current company. This does not mean however that a person is required.  Use MDO List name "person" to get list items. |
| MotherId | int32 | ID of mother appointment; self if booking master, master ID if booking slave, 0 if normal appointment. However, if 0 and assoc_id != reg_id then this is an assigned appointment, indicated vt type = kBooking |
| Priority | Priority | It's possible to give appointments different priorities. All the different priority types are saved in the priority table, and edited from the Admin. Client. An appointment does not require a priority.  Use MDO List name "priority" to get list items. |
| Private | string | The confidentiality of appointments is shown as different types of “private” on the appointment. For an updated list of “private” types, see the database manual. |
| Project | Project | An appointment may also be connected to a project, so you see the appointment both on the company card, and on the project card. This does not mean however that a project is required.  Use MDO List name "project" to get list items. |
| Type | string | The different types of appointment, if the appointment is supposed to be shown in the diary or checklist, or if it's a document. See the different types of appointments in the database manual. |
| UpdatedDate | date-time | Updated date  in UTC. |
| Completed | string | Appointment Completed state. This property is the part of the Status property that is the completed state. Could be three state if the three state user preference is set. |
| ActiveLinks | int32 | Number of active links to sale, document, appointment. |
| Links | array | List of all elements linked to the appointment. |
| AlarmLeadTime | string | Alarm lead time. |
| HasAlarm | bool | Does this appointment have an alarm |
| ColorIndex | int32 | Appointment colour, used only in Japanese versions. Western versions take colour from Task |
| IsFree | bool | True if free, false if busy |
| IsAlldayEvent | bool | True if all day event |
| LagTime | string | as leadtime, but after the end - time blocked for travel etc. |
| LeadTime | string | Time blocked (minutes) BEFORE starttime |
| Location | string | Location for appointment, defaulted from invited resource of type place and other rules, but you can write anything you want here |
| RejectCounter | int32 | How many invitees have rejected this appointment |
| RejectReason | string | Why was this booking or assignment rejected, the RejectReason list is a source of suggestions but you can write anything here  Use MDO List name "rejectReason" to get list items. |
| Recurrence | RecurrenceInfo | The appointment recurrence. |
| Participants | array | List of id's of the participants to this appointment. |
| AssignmentStatus | string | Status if this appointment is in the process of being assigned to someone else |
| InvitationStatus | string | Status if this appointment represents an invitation |
| BookingType | string | The type of booking the appointment represents |
| ActiveDate | date-time | The date to be used for searching &amp; showing |
| HasConflict | bool | Does the appointment overlap with another appointment in the user's diary? |
| AssignedBy | Associate | Who assigned this appointment to this user? Whose diary did the appointment come from? |
| MotherAssociate | Associate | The owner of the mother appointment - the associate whose diary/checklist the mother appointment is in.  The mother appointment is the one identified by the mother_id. If the mother_id is 0 or the same as this appointment_id, then the master associate will be the same as the 'ordinary' associate. |
| Task | TaskListItem | Task comprises the different types of activities, like “Phone call”, “Meeting” and so on.  Use MDO List name "task" to get list items. |
| PreferredTZLocation | int32 | Appointments preferred timezone location. |
| PreferredTZLocationData | TimeZoneData | Read-only timezone data for PreferredTZLocation. |
| Sale | Sale | An appointment may also be connected to a sale, so you see the appointment on the company card, on the project card and on the sale card. This does not mean however that a sale is required.  Use MDO List name "sale" to get list items. |
| SuggestedAppointmentId | int32 | Suggested guide item that this appointment is an instance of (Note: NOT VALID for document-type appointments, they have their own link) |
| IsMileStone | bool | Is this appointment a milestone? |
| CautionWarning | string | Status field to indicate appointments that have some sort of problem |
| JoinVideomeetUrl | string | Blank when not a video meeting. Filled with Join Meeting URL when created. |
| CentralserviceVideomeetId | string | GUID for video meeting in central services – this is set when we create meetings from SuperOffice. It is blank for incoming meetings created from inbox. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.AppointmentEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.AppointmentEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.AppointmentEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Type": "Appointment",
  "AssociateId": 633
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": null,
  "Contact": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2018-09-23T14:13:39.2036462+02:00",
  "AppointmentId": 30,
  "Description": "Devolved motivating complexity",
  "Title": "rerum",
  "Agenda": "delectus",
  "InternalNotes": "ab",
  "StartDate": "1998-03-08T14:13:39.2192678+01:00",
  "EndDate": "2020-02-18T14:13:39.2192678+01:00",
  "InvitedPerson": null,
  "Person": null,
  "MotherId": 469,
  "Priority": null,
  "Private": "PrivateGroup",
  "Project": null,
  "Type": "BookingForChecklist",
  "UpdatedDate": "2011-05-28T14:13:39.2192678+02:00",
  "Completed": "Completed",
  "ActiveLinks": 747,
  "Links": [
    {
      "EntityName": "Lockman Inc and Sons",
      "Id": 152,
      "Description": "Quality-focused value-added customer loyalty",
      "ExtraInfo": "aspernatur",
      "LinkId": 607,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 226
        }
      }
    }
  ],
  "AlarmLeadTime": "vel",
  "HasAlarm": true,
  "ColorIndex": 696,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "et",
  "LeadTime": "eveniet",
  "Location": "reiciendis",
  "RejectCounter": 708,
  "RejectReason": "",
  "Recurrence": null,
  "Participants": [
    {
      "AssociateId": 813,
      "PersonId": 495,
      "ContactId": 581,
      "EmailId": 11,
      "SendEmail": true,
      "InvitationStatus": "Accepted",
      "EmailAddress": "mac_jast@hauckharris.info",
      "Description": "Self-enabling contextually-based migration"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2024-04-24T14:13:39.2192678+02:00",
  "HasConflict": true,
  "AssignedBy": null,
  "MotherAssociate": null,
  "Task": null,
  "PreferredTZLocation": 554,
  "PreferredTZLocationData": null,
  "Sale": null,
  "SuggestedAppointmentId": 369,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "rerum",
  "UserDefinedFields": {
    "SuperOffice:1": "Laurine Ansel Konopelski V",
    "SuperOffice:2": "Wellington Bartell"
  },
  "ExtraFields": {
    "ExtraFields1": "impedit",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "atque",
    "CustomFields2": "dolorem"
  },
  "PublishEventDate": "2012-02-06T14:13:39.2192678+01:00",
  "PublishTo": "2003-04-25T14:13:39.2192678+02:00",
  "PublishFrom": "2001-04-09T14:13:39.2192678+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 461,
      "Visibility": "All",
      "DisplayValue": "officia",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 160
        }
      }
    },
    {
      "VisibleId": 461,
      "Visibility": "All",
      "DisplayValue": "officia",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 160
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 304
    }
  }
}
```