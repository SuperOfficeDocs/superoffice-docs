---
title: PUT Appointment/{id}
uid: v1AppointmentEntity_PutAppointmentEntity
generated: true
---

# PUT Appointment/{id}

```http
PUT /api/v1/Appointment/{id}
```

Updates the existing AppointmentEntity Save the appointment entity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The AppointmentEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Appointment/{id}?$select=name,department,category/id
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

## Request Body: entity 

The AppointmentEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Associate | Associate | The owner of the appointment - the associate whose diary/checklist the appointment is in.  <para>Use MDO List name "associate" to get list items.</para> |
| Contact | Contact | The contact associated with the appointment. It may also be null if no contact is associated with the appointment.  <para>Use MDO List name "contact_new" to get list items.</para> |
| CreatedBy | Associate | The associate that first created the appointment. The property is read-only. |
| UpdatedBy | Associate | The person that last updated the appointment. |
| CreatedDate | String | Registered date  in UTC. |
| AppointmentId | Integer | Primary key |
| Description | String | Description of the appointment. |
| Title | String | The title of the appointment. |
| Agenda | String | The agenda of the appointment. |
| InternalNotes | String | Internal notes for the appointment. |
| StartDate | String | date + start time planned |
| EndDate | String | Date + end time planned |
| InvitedPerson | Person | If the appointment is a booking, the invited persons may be your associates, but you are also able to invite contact persons from other companies to join your meeting. They do not receive an invitation, unless you send them one by email, but you can see in the appointment that persons other than your associates have been invited to a meeting. Each invited person will have an appointment slave record. |
| Person | Person | An appointment may also be connected to a person; this must be a contact person registered on the current company. This does not mean however that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| MotherId | Integer | ID of mother appointment; self if booking master, master ID if booking slave, 0 if normal appointment. However, if 0 and assoc_id != reg_id then this is an assigned appointment, indicated vt type = kBooking |
| Priority | Priority | It's possible to give appointments different priorities. All the different priority types are saved in the priority table, and edited from the Admin. Client. An appointment does not require a priority.  <para>Use MDO List name "priority" to get list items.</para> |
| Private | String | The confidentiality of appointments is shown as different types of “private” on the appointment. For an updated list of “private” types, see the database manual. |
| Project | Project | An appointment may also be connected to a project, so you see the appointment both on the company card, and on the project card. This does not mean however that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| Type | String | The different types of appointment, if the appointment is supposed to be shown in the diary or checklist, or if it's a document. See the different types of appointments in the database manual. |
| UpdatedDate | String | Updated date  in UTC. |
| Completed | String | Appointment Completed state. This property is the part of the Status property that is the completed state. Could be three state if the three state user preference is set. |
| ActiveLinks | Integer | Number of active links to sale, document, appointment. |
| Links | Array | List of all elements linked to the appointment. |
| AlarmLeadTime | String | Alarm lead time. |
| HasAlarm | Boolean | Does this appointment have an alarm |
| ColorIndex | Integer | Appointment colour, used only in Japanese versions. Western versions take colour from Task |
| IsFree | Boolean | True if free, false if busy |
| IsAlldayEvent | Boolean | True if all day event |
| LagTime | String | as leadtime, but after the end - time blocked for travel etc. |
| LeadTime | String | Time blocked (minutes) BEFORE starttime |
| Location | String | Location for appointment, defaulted from invited resource of type place and other rules, but you can write anything you want here |
| RejectCounter | Integer | How many invitees have rejected this appointment |
| RejectReason | String | Why was this booking or assignment rejected, the RejectReason list is a source of suggestions but you can write anything here  <para>Use MDO List name "rejectReason" to get list items.</para> |
| Recurrence | RecurrenceInfo | The appointment recurrence. |
| Participants | Array | List of id's of the participants to this appointment. |
| AssignmentStatus | String | Status if this appointment is in the process of being assigned to someone else |
| InvitationStatus | String | Status if this appointment represents an invitation |
| BookingType | String | The type of booking the appointment represents |
| ActiveDate | String | The date to be used for searching &amp; showing |
| HasConflict | Boolean | Does the appointment overlap with another appointment in the user's diary? |
| AssignedBy | Associate | Who assigned this appointment to this user? Whose diary did the appointment come from? |
| MotherAssociate | Associate | The owner of the mother appointment - the associate whose diary/checklist the mother appointment is in.  The mother appointment is the one identified by the mother_id. If the mother_id is 0 or the same as this appointment_id, then the master associate will be the same as the 'ordinary' associate. |
| Task | TaskListItem | Task comprises the different types of activities, like “Phone call”, “Meeting” and so on.  <para>Use MDO List name "task" to get list items.</para> |
| PreferredTZLocation | Integer | Appointments preferred timezone location. |
| PreferredTZLocationData | TimeZoneData | Read-only timezone data for PreferredTZLocation. |
| Sale | Sale | An appointment may also be connected to a sale, so you see the appointment on the company card, on the project card and on the sale card. This does not mean however that a sale is required.  <para>Use MDO List name "sale" to get list items.</para> |
| SuggestedAppointmentId | Integer | Suggested guide item that this appointment is an instance of (Note: NOT VALID for document-type appointments, they have their own link) |
| IsMileStone | Boolean | Is this appointment a milestone? |
| CautionWarning | String | Status field to indicate appointments that have some sort of problem |
| JoinVideomeetUrl | String | Blank when not a video meeting. Filled with Join Meeting URL when created. |
| CentralserviceVideomeetId | String | GUID for video meeting in central services – this is set when we create meetings from SuperOffice. It is blank for incoming meetings created from inbox. |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.AppointmentEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.AppointmentEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.AppointmentEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.AppointmentEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |
| VisibleFor | Array | The set of users or groups the record is visible for |

## Response:

AppointmentEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | AppointmentEntity updated. |
| 412 | Update stopped because AppointmentEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: AppointmentEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Appointment/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Associate": null,
  "Contact": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2019-03-09T12:19:52.9775027+01:00",
  "AppointmentId": 575,
  "Description": "Fundamental disintermediate circuit",
  "Title": "sapiente",
  "Agenda": "adipisci",
  "InternalNotes": "a",
  "StartDate": "2007-10-03T12:19:52.9775027+02:00",
  "EndDate": "2019-10-26T12:19:52.9775027+02:00",
  "InvitedPerson": null,
  "Person": null,
  "MotherId": 238,
  "Priority": null,
  "Private": "PrivateGroup",
  "Project": null,
  "Type": "BookingForChecklist",
  "UpdatedDate": "2019-09-02T12:19:52.9775027+02:00",
  "Completed": "Completed",
  "ActiveLinks": 884,
  "Links": [
    {
      "EntityName": "Shanahan, Hessel and Erdman",
      "Id": 569,
      "Description": "Decentralized disintermediate framework",
      "ExtraInfo": "consequatur",
      "LinkId": 435
    },
    {
      "EntityName": "Shanahan, Hessel and Erdman",
      "Id": 569,
      "Description": "Decentralized disintermediate framework",
      "ExtraInfo": "consequatur",
      "LinkId": 435
    }
  ],
  "AlarmLeadTime": "atque",
  "HasAlarm": false,
  "ColorIndex": 373,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "ipsa",
  "LeadTime": "nemo",
  "Location": "nesciunt",
  "RejectCounter": 784,
  "RejectReason": "",
  "Recurrence": null,
  "Participants": [
    {
      "AssociateId": 263,
      "PersonId": 720,
      "ContactId": 263,
      "EmailId": 296,
      "SendEmail": true,
      "InvitationStatus": "Accepted",
      "EmailAddress": "hillary.botsford@bartoletti.ca",
      "Description": "Phased user-facing toolset"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2020-11-20T12:19:52.9775027+01:00",
  "HasConflict": false,
  "AssignedBy": null,
  "MotherAssociate": null,
  "Task": null,
  "PreferredTZLocation": 664,
  "PreferredTZLocationData": null,
  "Sale": null,
  "SuggestedAppointmentId": 24,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "at",
  "UserDefinedFields": {
    "SuperOffice:1": "Jaime Kunze",
    "SuperOffice:2": "669843181"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptates",
    "ExtraFields2": "soluta"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "ratione"
  },
  "PublishEventDate": "2012-12-25T12:19:52.9775027+01:00",
  "PublishTo": "2015-09-12T12:19:52.9775027+02:00",
  "PublishFrom": "2005-06-03T12:19:52.9775027+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 790,
      "Visibility": "All",
      "DisplayValue": "quis"
    },
    {
      "VisibleId": 790,
      "Visibility": "All",
      "DisplayValue": "quis"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 AppointmentEntity updated.
Content-Type: application/json; charset=utf-8

{
  "Associate": null,
  "Contact": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2004-04-05T12:19:52.9775027+02:00",
  "AppointmentId": 289,
  "Description": "Object-based human-resource local area network",
  "Title": "consequuntur",
  "Agenda": "tenetur",
  "InternalNotes": "laudantium",
  "StartDate": "2005-05-01T12:19:52.9775027+02:00",
  "EndDate": "2000-10-08T12:19:52.9775027+02:00",
  "InvitedPerson": null,
  "Person": null,
  "MotherId": 438,
  "Priority": null,
  "Private": "PrivateGroup",
  "Project": null,
  "Type": "BookingForChecklist",
  "UpdatedDate": "2005-10-02T12:19:52.9775027+02:00",
  "Completed": "Completed",
  "ActiveLinks": 584,
  "Links": [
    {
      "EntityName": "Bailey Inc and Sons",
      "Id": 332,
      "Description": "Diverse human-resource forecast",
      "ExtraInfo": "aut",
      "LinkId": 735,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 215
        }
      }
    }
  ],
  "AlarmLeadTime": "minus",
  "HasAlarm": false,
  "ColorIndex": 864,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "vel",
  "LeadTime": "et",
  "Location": "accusamus",
  "RejectCounter": 176,
  "RejectReason": "",
  "Recurrence": null,
  "Participants": [
    {
      "AssociateId": 644,
      "PersonId": 331,
      "ContactId": 131,
      "EmailId": 462,
      "SendEmail": false,
      "InvitationStatus": "Accepted",
      "EmailAddress": "hoyt_schinner@daugherty.uk",
      "Description": "Right-sized didactic hardware"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2000-10-26T12:19:52.9931271+02:00",
  "HasConflict": false,
  "AssignedBy": null,
  "MotherAssociate": null,
  "Task": null,
  "PreferredTZLocation": 72,
  "PreferredTZLocationData": null,
  "Sale": null,
  "SuggestedAppointmentId": 560,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "asperiores",
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Tess Shields",
    "SuperOffice:2": "459657880"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "tenetur"
  },
  "CustomFields": {
    "CustomFields1": "unde",
    "CustomFields2": "facere"
  },
  "PublishEventDate": "2017-02-23T12:19:52.9931271+01:00",
  "PublishTo": "1998-12-17T12:19:52.9931271+01:00",
  "PublishFrom": "2024-03-07T12:19:52.9931271+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 193,
      "Visibility": "All",
      "DisplayValue": "animi",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 331
        }
      }
    },
    {
      "VisibleId": 193,
      "Visibility": "All",
      "DisplayValue": "animi",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 331
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 15
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```