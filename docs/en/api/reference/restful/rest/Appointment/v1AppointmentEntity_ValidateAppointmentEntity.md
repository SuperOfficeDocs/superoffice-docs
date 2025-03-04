---
title: POST Appointment/Validate
uid: v1AppointmentEntity_ValidateAppointmentEntity
generated: true
---

# POST Appointment/Validate

```http
POST /api/v1/Appointment/Validate
```

Check that entity is ready for saving.








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

## Request Body: appointmentEntity 

Entity to be checked. 

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

## Response:object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: object


## Sample request

```http!
POST /api/v1/Appointment/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Associate": null,
  "Contact": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2009-05-14T14:13:48.2883428+02:00",
  "AppointmentId": 747,
  "Description": "Reactive intangible initiative",
  "Title": "et",
  "Agenda": "nobis",
  "InternalNotes": "sit",
  "StartDate": "1999-03-14T14:13:48.2883428+01:00",
  "EndDate": "2003-11-25T14:13:48.2883428+01:00",
  "InvitedPerson": null,
  "Person": null,
  "MotherId": 442,
  "Priority": null,
  "Private": "PrivateGroup",
  "Project": null,
  "Type": "BookingForChecklist",
  "UpdatedDate": "2001-05-31T14:13:48.2883428+02:00",
  "Completed": "Completed",
  "ActiveLinks": 526,
  "Links": [
    {
      "EntityName": "Boyer, Reinger and Prosacco",
      "Id": 717,
      "Description": "Expanded coherent framework",
      "ExtraInfo": "laudantium",
      "LinkId": 96
    },
    {
      "EntityName": "Boyer, Reinger and Prosacco",
      "Id": 717,
      "Description": "Expanded coherent framework",
      "ExtraInfo": "laudantium",
      "LinkId": 96
    }
  ],
  "AlarmLeadTime": "qui",
  "HasAlarm": true,
  "ColorIndex": 464,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "earum",
  "LeadTime": "quisquam",
  "Location": "beatae",
  "RejectCounter": 21,
  "RejectReason": "",
  "Recurrence": null,
  "Participants": [
    {
      "AssociateId": 821,
      "PersonId": 21,
      "ContactId": 589,
      "EmailId": 463,
      "SendEmail": false,
      "InvitationStatus": "Accepted",
      "EmailAddress": "roxanne@armstrongbode.co.uk",
      "Description": "Re-engineered grid-enabled firmware"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2008-04-15T14:13:48.2883428+02:00",
  "HasConflict": true,
  "AssignedBy": null,
  "MotherAssociate": null,
  "Task": null,
  "PreferredTZLocation": 971,
  "PreferredTZLocationData": null,
  "Sale": null,
  "SuggestedAppointmentId": 17,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "quasi",
  "UserDefinedFields": {
    "SuperOffice:1": "Delphia Pfannerstill",
    "SuperOffice:2": "Mr. Citlalli Myrtle Pollich DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "minus",
    "ExtraFields2": "optio"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "incidunt"
  },
  "PublishEventDate": "2004-09-25T14:13:48.2883428+02:00",
  "PublishTo": "2001-05-13T14:13:48.2883428+02:00",
  "PublishFrom": "2017-07-09T14:13:48.2883428+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 493,
      "Visibility": "All",
      "DisplayValue": "dolorem"
    },
    {
      "VisibleId": 493,
      "Visibility": "All",
      "DisplayValue": "dolorem"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "ut",
  "2": "aut"
}
```