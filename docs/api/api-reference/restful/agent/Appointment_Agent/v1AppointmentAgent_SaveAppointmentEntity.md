---
title: SaveAppointmentEntity
id: v1AppointmentAgent_SaveAppointmentEntity
---

# SaveAppointmentEntity

```http
POST /api/v1/Agents/Appointment/SaveAppointmentEntity
```

Updates the existing AppointmentEntity or creates a new AppointmentEntity if the id parameter is empty








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
| Associate |  | The owner of the appointment - the associate whose diary/checklist the appointment is in.  <para>Use MDO List name "associate" to get list items.</para> |
| Contact |  | The contact associated with the appointment. It may also be null if no contact is associated with the appointment.  <para>Use MDO List name "contact_new" to get list items.</para> |
| CreatedBy |  | The associate that first created the appointment. The property is read-only. |
| UpdatedBy |  | The person that last updated the appointment. |
| CreatedDate | date-time | Registered date  in UTC. |
| AppointmentId | int32 | Primary key |
| Description | string | Description of the appointment. |
| StartDate | date-time | date + start time planned |
| EndDate | date-time | Date + end time planned |
| InvitedPerson |  | If the appointment is a booking, the invited persons may be your associates, but you are also able to invite contact persons from other companies to join your meeting. They do not receive an invitation, unless you send them one by email, but you can see in the appointment that persons other than your associates have been invited to a meeting. Each invited person will have an appointment slave record. |
| Person |  | An appointment may also be connected to a person; this must be a contact person registered on the current company. This does not mean however that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| MotherId | int32 | ID of mother appointment; self if booking master, master ID if booking slave, 0 if normal appointment. However, if 0 and assoc_id != reg_id then this is an assigned appointment, indicated vt type = kBooking |
| Priority |  | It's possible to give appointments different priorities. All the different priority types are saved in the priority table, and edited from the Admin. Client. An appointment does not require a priority.  <para>Use MDO List name "priority" to get list items.</para> |
| Private | string | The confidentiality of appointments is shown as different types of “private” on the appointment. For an updated list of “private” types, see the database manual. |
| Project |  | An appointment may also be connected to a project, so you see the appointment both on the company card, and on the project card. This does not mean however that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
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
| RejectReason | string | Why was this booking or assignment rejected, the RejectReason list is a source of suggestions but you can write anything here  <para>Use MDO List name "rejectReason" to get list items.</para> |
| Recurrence |  | The appointment recurrence. |
| Participants | array | List of id's of the participants to this appointment. |
| AssignmentStatus | string | Status if this appointment is in the process of being assigned to someone else |
| InvitationStatus | string | Status if this appointment represents an invitation |
| BookingType | string | The type of booking the appointment represents |
| ActiveDate | date-time | The date to be used for searching &amp; showing |
| HasConflict | bool | Does the appointment overlap with another appointment in the user's diary? |
| AssignedBy |  | Who assigned this appointment to this user? Whose diary did the appointment come from? |
| MotherAssociate |  | The owner of the mother appointment - the associate whose diary/checklist the mother appointment is in.  The mother appointment is the one identified by the mother_id. If the mother_id is 0 or the same as this appointment_id, then the master associate will be the same as the 'ordinary' associate. |
| Task |  | Task comprises the different types of activities, like “Phone call”, “Meeting” and so on.  <para>Use MDO List name "task" to get list items.</para> |
| PreferredTZLocation | int32 | Appoinmtments preferred timezone location. |
| Sale |  | An appointment may also be connected to a sale, so you see the appointment on the company card, on the project card and on the sale card. This does not mean however that a sale is required.  <para>Use MDO List name "sale" to get list items.</para> |
| SuggestedAppointmentId | int32 | Suggested guide item that this appointment is an instance of (Note: NOT VALID for document-type appointments, they have their own link) |
| IsMileStone | bool | Is this appointment a milestone? |
| CautionWarning | string | Status field to indicate appointments that have some sort of problem |
| JoinVideomeetUrl | string | Blank when not a video meeting. Filled with Join Meeting URL when created. |
| CentralserviceVideomeetId | string | GUID for video meeting in central services – this is set when we create meetings from SuperOffice. It is blank for incoming meetings created from inbox. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.AppointmentEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.AppointmentEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.AppointmentEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.AppointmentEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| VisibleFor | array | The set of users or groups the record is visible for |


## Response: object

Partial AppointmentEntity class associating the generated AppointmentEntity with an interface.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Associate |  | The owner of the appointment - the associate whose diary/checklist the appointment is in.  <para>Use MDO List name "associate" to get list items.</para> |
| Contact |  | The contact associated with the appointment. It may also be null if no contact is associated with the appointment.  <para>Use MDO List name "contact_new" to get list items.</para> |
| CreatedBy |  | The associate that first created the appointment. The property is read-only. |
| UpdatedBy |  | The person that last updated the appointment. |
| CreatedDate | date-time | Registered date  in UTC. |
| AppointmentId | int32 | Primary key |
| Description | string | Description of the appointment. |
| StartDate | date-time | date + start time planned |
| EndDate | date-time | Date + end time planned |
| InvitedPerson |  | If the appointment is a booking, the invited persons may be your associates, but you are also able to invite contact persons from other companies to join your meeting. They do not receive an invitation, unless you send them one by email, but you can see in the appointment that persons other than your associates have been invited to a meeting. Each invited person will have an appointment slave record. |
| Person |  | An appointment may also be connected to a person; this must be a contact person registered on the current company. This does not mean however that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| MotherId | int32 | ID of mother appointment; self if booking master, master ID if booking slave, 0 if normal appointment. However, if 0 and assoc_id != reg_id then this is an assigned appointment, indicated vt type = kBooking |
| Priority |  | It's possible to give appointments different priorities. All the different priority types are saved in the priority table, and edited from the Admin. Client. An appointment does not require a priority.  <para>Use MDO List name "priority" to get list items.</para> |
| Private | string | The confidentiality of appointments is shown as different types of “private” on the appointment. For an updated list of “private” types, see the database manual. |
| Project |  | An appointment may also be connected to a project, so you see the appointment both on the company card, and on the project card. This does not mean however that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
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
| RejectReason | string | Why was this booking or assignment rejected, the RejectReason list is a source of suggestions but you can write anything here  <para>Use MDO List name "rejectReason" to get list items.</para> |
| Recurrence |  | The appointment recurrence. |
| Participants | array | List of id's of the participants to this appointment. |
| AssignmentStatus | string | Status if this appointment is in the process of being assigned to someone else |
| InvitationStatus | string | Status if this appointment represents an invitation |
| BookingType | string | The type of booking the appointment represents |
| ActiveDate | date-time | The date to be used for searching &amp; showing |
| HasConflict | bool | Does the appointment overlap with another appointment in the user's diary? |
| AssignedBy |  | Who assigned this appointment to this user? Whose diary did the appointment come from? |
| MotherAssociate |  | The owner of the mother appointment - the associate whose diary/checklist the mother appointment is in.  The mother appointment is the one identified by the mother_id. If the mother_id is 0 or the same as this appointment_id, then the master associate will be the same as the 'ordinary' associate. |
| Task |  | Task comprises the different types of activities, like “Phone call”, “Meeting” and so on.  <para>Use MDO List name "task" to get list items.</para> |
| PreferredTZLocation | int32 | Appoinmtments preferred timezone location. |
| Sale |  | An appointment may also be connected to a sale, so you see the appointment on the company card, on the project card and on the sale card. This does not mean however that a sale is required.  <para>Use MDO List name "sale" to get list items.</para> |
| SuggestedAppointmentId | int32 | Suggested guide item that this appointment is an instance of (Note: NOT VALID for document-type appointments, they have their own link) |
| IsMileStone | bool | Is this appointment a milestone? |
| CautionWarning | string | Status field to indicate appointments that have some sort of problem |
| JoinVideomeetUrl | string | Blank when not a video meeting. Filled with Join Meeting URL when created. |
| CentralserviceVideomeetId | string | GUID for video meeting in central services – this is set when we create meetings from SuperOffice. It is blank for incoming meetings created from inbox. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.AppointmentEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.AppointmentEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.AppointmentEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.AppointmentEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Appointment/SaveAppointmentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 860,
    "Name": "Ziemann-Witting",
    "PersonId": 607,
    "Rank": 655,
    "Tooltip": "at",
    "Type": "AnonymousAssociate",
    "GroupIdx": 387,
    "FullName": "Kayla Connelly",
    "FormalName": "Mitchell-Crona",
    "Deleted": false,
    "EjUserId": 369,
    "UserName": "Hane, Pouros and Harris"
  },
  "Contact": {
    "ContactId": 795,
    "Name": "Hagenes-Littel",
    "OrgNr": "980788",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ad",
    "DirectPhone": "(662)335-4335",
    "AssociateId": 825,
    "CountryId": 500,
    "EmailAddress": "mozelle.zulauf@mayerpollich.ca",
    "Kananame": "earum",
    "EmailAddressName": "judy_lind@beerstiedemann.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mike Brown",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quibusdam",
    "FullName": "Braden Dicki",
    "IsOwnerContact": false,
    "ActiveErpLinks": 47
  },
  "CreatedBy": {
    "AssociateId": 872,
    "Name": "Yundt-Beahan",
    "PersonId": 511,
    "Rank": 296,
    "Tooltip": "in",
    "Type": "AnonymousAssociate",
    "GroupIdx": 797,
    "FullName": "Jewell O'Hara",
    "FormalName": "Hyatt, Schumm and Schmitt",
    "Deleted": false,
    "EjUserId": 612,
    "UserName": "Abernathy, Kerluke and Lueilwitz"
  },
  "UpdatedBy": {
    "AssociateId": 402,
    "Name": "Breitenberg, Howe and Ortiz",
    "PersonId": 938,
    "Rank": 797,
    "Tooltip": "totam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 647,
    "FullName": "Elyssa Wilderman",
    "FormalName": "Armstrong, Labadie and Schowalter",
    "Deleted": true,
    "EjUserId": 732,
    "UserName": "Jast Inc and Sons"
  },
  "CreatedDate": "2019-11-28T14:58:03.0785386+01:00",
  "AppointmentId": 433,
  "Description": "Profound zero administration middleware",
  "StartDate": "2012-10-03T14:58:03.0785386+02:00",
  "EndDate": "2005-10-10T14:58:03.0785386+02:00",
  "InvitedPerson": {
    "Position": "ipsa",
    "PersonId": 435,
    "Mrmrs": "officia",
    "Firstname": "Chaya",
    "Lastname": "Jacobson",
    "MiddleName": "Berge, Nitzsche and Lehner",
    "Title": "illo",
    "Description": "Re-engineered 24 hour time-frame",
    "Email": "sammy@sauer.name",
    "FullName": "Jeremy Zboncak",
    "DirectPhone": "080.814.8752 x236",
    "FormalName": "Miller-Rogahn",
    "CountryId": 442,
    "ContactId": 199,
    "ContactName": "Hermiston LLC",
    "Retired": 58,
    "Rank": 474,
    "ActiveInterests": 571,
    "ContactDepartment": "visualize real-time supply-chains",
    "ContactCountryId": 991,
    "ContactOrgNr": "847579",
    "FaxPhone": "1-553-806-3318 x366",
    "MobilePhone": "1-214-244-3508 x437",
    "ContactPhone": "(037)457-6025 x667",
    "AssociateName": "Dicki, McKenzie and O'Hara",
    "AssociateId": 805,
    "UsePersonAddress": false,
    "ContactFax": "odio",
    "Kanafname": "aut",
    "Kanalname": "rerum",
    "Post1": "sequi",
    "Post2": "non",
    "Post3": "totam",
    "EmailName": "roel_hessel@cruickshank.name",
    "ContactFullName": "Bryana VonRueden",
    "ActiveErpLinks": 858,
    "TicketPriorityId": 559,
    "SupportLanguageId": 726,
    "SupportAssociateId": 671,
    "CategoryName": "VIP Customer"
  },
  "Person": {
    "Position": "odio",
    "PersonId": 466,
    "Mrmrs": "soluta",
    "Firstname": "Luna",
    "Lastname": "Feest",
    "MiddleName": "Nader LLC",
    "Title": "voluptas",
    "Description": "Future-proofed multi-state projection",
    "Email": "sean.botsford@wisoky.uk",
    "FullName": "Max Skiles",
    "DirectPhone": "(241)184-5400 x78576",
    "FormalName": "Breitenberg Inc and Sons",
    "CountryId": 762,
    "ContactId": 310,
    "ContactName": "Maggio, Baumbach and Pagac",
    "Retired": 464,
    "Rank": 809,
    "ActiveInterests": 703,
    "ContactDepartment": "",
    "ContactCountryId": 5,
    "ContactOrgNr": "640623",
    "FaxPhone": "736.127.8702 x47312",
    "MobilePhone": "1-612-584-8633",
    "ContactPhone": "1-073-403-7120 x4821",
    "AssociateName": "Fahey, O'Kon and Beatty",
    "AssociateId": 213,
    "UsePersonAddress": true,
    "ContactFax": "quos",
    "Kanafname": "corrupti",
    "Kanalname": "quo",
    "Post1": "quae",
    "Post2": "quam",
    "Post3": "assumenda",
    "EmailName": "cathrine_wilderman@rosenbaum.ca",
    "ContactFullName": "Antonette Blick",
    "ActiveErpLinks": 135,
    "TicketPriorityId": 130,
    "SupportLanguageId": 98,
    "SupportAssociateId": 494,
    "CategoryName": "VIP Customer"
  },
  "MotherId": 976,
  "Priority": {
    "Id": 301,
    "Value": "nobis",
    "Tooltip": "voluptatem"
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 617,
    "Name": "VonRueden LLC",
    "Description": "Fully-configurable homogeneous process improvement",
    "URL": "http://www.example.com/",
    "Type": "dolorem",
    "AssociateId": 52,
    "AssociateFullName": "Beth Beer",
    "TypeId": 338,
    "Updated": "2021-05-25T14:58:03.0815381+02:00",
    "StatusId": 553,
    "Status": "natus",
    "TextId": 819,
    "PublishTo": "2002-03-27T14:58:03.0815381+01:00",
    "PublishFrom": "2012-06-20T14:58:03.0815381+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "831890",
    "ActiveErpLinks": 753
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2008-12-16T14:58:03.0815381+01:00",
  "Completed": "Completed",
  "ActiveLinks": 986,
  "Links": [
    {
      "EntityName": "Hartmann LLC",
      "Id": 733,
      "Description": "Seamless cohesive monitoring",
      "ExtraInfo": "sed",
      "LinkId": 178
    },
    {
      "EntityName": "Hartmann LLC",
      "Id": 733,
      "Description": "Seamless cohesive monitoring",
      "ExtraInfo": "sed",
      "LinkId": 178
    }
  ],
  "AlarmLeadTime": "illum",
  "HasAlarm": true,
  "ColorIndex": 249,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "eaque",
  "LeadTime": "delectus",
  "Location": "eum",
  "RejectCounter": 126,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 441,
    "StartDate": "2020-04-08T14:58:03.0815381+02:00",
    "EndDate": "2016-05-11T14:58:03.0815381+02:00",
    "RecurrenceCounter": 814,
    "RecurrenceEndType": "Counter",
    "Pattern": "Custom",
    "DayPattern": {},
    "WeekPattern": {},
    "MonthPattern": {},
    "YearPattern": {},
    "Dates": [
      {},
      {}
    ],
    "IsRecurrence": false
  },
  "Participants": [
    {
      "AssociateId": 19,
      "PersonId": 694,
      "ContactId": 880,
      "EmailId": 689,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 19,
      "PersonId": 694,
      "ContactId": 880,
      "EmailId": 689,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2012-02-22T14:58:03.0815381+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 783,
    "Name": "Ullrich-Trantow",
    "PersonId": 210,
    "Rank": 175,
    "Tooltip": "alias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 581,
    "FullName": "Benjamin Feest",
    "FormalName": "Ebert, Denesik and Greenfelder",
    "Deleted": false,
    "EjUserId": 11,
    "UserName": "Dickinson, Farrell and Kris"
  },
  "MotherAssociate": {
    "AssociateId": 896,
    "Name": "Franecki LLC",
    "PersonId": 311,
    "Rank": 140,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 618,
    "FullName": "Leif Robel",
    "FormalName": "Little-Spinka",
    "Deleted": true,
    "EjUserId": 362,
    "UserName": "Corwin-Bruen"
  },
  "Task": {
    "TaskListItemId": 711,
    "Value": "facilis",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "sunt",
    "Deleted": false,
    "IntentId": 125,
    "Rank": 500,
    "IsDefaultAlldayEvent": false,
    "IsDefaultFree": false,
    "IsDefaultPublished": false,
    "ColorIndex": "BlueAlt1",
    "DefaultVideomeetingStatus": "NoChange"
  },
  "PreferredTZLocation": 962,
  "Sale": {
    "ContactName": "Conroy-Stoltenberg",
    "SaleDate": "2018-10-13T14:58:03.0825385+02:00",
    "SaleId": 819,
    "Probability": 287,
    "Title": "veniam",
    "Amount": 4581.9079999999994,
    "Currency": "impedit",
    "ProjectName": "Torphy, Yundt and Kuhic",
    "AssociateFullName": "Ardith Hills",
    "Description": "Digitized interactive matrix",
    "Status": "Lost",
    "WeightedAmount": 25131.546,
    "ProjectId": 112,
    "EarningPercent": 16933.002,
    "Earning": 6775.708,
    "ContactId": 900,
    "AssociateId": 120,
    "PersonId": 355,
    "SaleTypeId": 52,
    "SaleTypeName": "Koepp, Satterfield and Thompson",
    "PersonFullName": "Cynthia Price",
    "Completed": "Completed",
    "ActiveErpLinks": 298,
    "NextDueDate": "2010-01-23T14:58:03.0825385+01:00",
    "Number": "458794"
  },
  "SuggestedAppointmentId": 793,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "expedita",
  "UserDefinedFields": {
    "SuperOffice:1": "Jarvis Legros",
    "SuperOffice:2": "Yoshiko Hayes"
  },
  "ExtraFields": {
    "ExtraFields1": "error",
    "ExtraFields2": "iure"
  },
  "CustomFields": {
    "CustomFields1": "molestiae",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2015-01-17T14:58:03.0835384+01:00",
  "PublishTo": "1995-04-02T14:58:03.0835384+02:00",
  "PublishFrom": "2021-06-24T14:58:03.0835384+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 273,
      "Visibility": "All",
      "DisplayValue": "architecto"
    },
    {
      "VisibleId": 273,
      "Visibility": "All",
      "DisplayValue": "architecto"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 932,
    "Name": "Sanford-Schuppe",
    "PersonId": 476,
    "Rank": 968,
    "Tooltip": "consectetur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 575,
    "FullName": "Gussie Ondricka",
    "FormalName": "Buckridge-Herzog",
    "Deleted": false,
    "EjUserId": 194,
    "UserName": "Kassulke LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 986
      }
    }
  },
  "Contact": {
    "ContactId": 11,
    "Name": "Herman, Buckridge and Harvey",
    "OrgNr": "1363044",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "et",
    "DirectPhone": "1-736-057-1538 x8800",
    "AssociateId": 907,
    "CountryId": 175,
    "EmailAddress": "lucienne_kunde@wiegand.com",
    "Kananame": "beatae",
    "EmailAddressName": "brittany_swaniawski@johns.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Dana Stehr",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "et",
    "FullName": "Ms. Alysha Brown",
    "IsOwnerContact": false,
    "ActiveErpLinks": 310,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 213
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 896,
    "Name": "Kassulke Group",
    "PersonId": 937,
    "Rank": 584,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 807,
    "FullName": "Iva Schmeler",
    "FormalName": "Bogan LLC",
    "Deleted": false,
    "EjUserId": 530,
    "UserName": "Price-Kuhlman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 871
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 502,
    "Name": "Herman, Ebert and Erdman",
    "PersonId": 969,
    "Rank": 451,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 547,
    "FullName": "Laura Leuschke",
    "FormalName": "Ernser, Herzog and Schoen",
    "Deleted": false,
    "EjUserId": 937,
    "UserName": "O'Connell-Wunsch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 584
      }
    }
  },
  "CreatedDate": "2021-08-09T14:58:03.092572+02:00",
  "AppointmentId": 564,
  "Description": "Re-contextualized attitude-oriented extranet",
  "StartDate": "2016-12-01T14:58:03.092572+01:00",
  "EndDate": "1996-10-19T14:58:03.092572+02:00",
  "InvitedPerson": {
    "Position": "quibusdam",
    "PersonId": 900,
    "Mrmrs": "dolorem",
    "Firstname": "Rodrick",
    "Lastname": "Stokes",
    "MiddleName": "Keebler-Bogisich",
    "Title": "atque",
    "Description": "Centralized zero defect internet solution",
    "Email": "brenda@conn.info",
    "FullName": "Erin Rosenbaum",
    "DirectPhone": "342.572.7600 x268",
    "FormalName": "Blanda, Bernier and Emmerich",
    "CountryId": 895,
    "ContactId": 488,
    "ContactName": "Lubowitz, Medhurst and Koepp",
    "Retired": 89,
    "Rank": 591,
    "ActiveInterests": 127,
    "ContactDepartment": "",
    "ContactCountryId": 858,
    "ContactOrgNr": "1266166",
    "FaxPhone": "582.432.7125 x37313",
    "MobilePhone": "121.587.7078 x20608",
    "ContactPhone": "406-764-5736",
    "AssociateName": "Gutmann Inc and Sons",
    "AssociateId": 713,
    "UsePersonAddress": true,
    "ContactFax": "dolorem",
    "Kanafname": "perferendis",
    "Kanalname": "non",
    "Post1": "beatae",
    "Post2": "odit",
    "Post3": "nam",
    "EmailName": "alexie@koss.uk",
    "ContactFullName": "Ervin Hyatt",
    "ActiveErpLinks": 613,
    "TicketPriorityId": 257,
    "SupportLanguageId": 633,
    "SupportAssociateId": 580,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 661
      }
    }
  },
  "Person": {
    "Position": "accusamus",
    "PersonId": 80,
    "Mrmrs": "nostrum",
    "Firstname": "Simeon",
    "Lastname": "Mosciski",
    "MiddleName": "Heidenreich LLC",
    "Title": "doloremque",
    "Description": "Ameliorated next generation internet solution",
    "Email": "darien_purdy@welch.info",
    "FullName": "Max Leuschke",
    "DirectPhone": "730.167.0535 x467",
    "FormalName": "Dibbert, Heller and VonRueden",
    "CountryId": 789,
    "ContactId": 302,
    "ContactName": "Turner-Raynor",
    "Retired": 770,
    "Rank": 348,
    "ActiveInterests": 569,
    "ContactDepartment": "",
    "ContactCountryId": 32,
    "ContactOrgNr": "1597625",
    "FaxPhone": "1-626-366-2271",
    "MobilePhone": "012.607.3627 x53151",
    "ContactPhone": "652-736-2728 x4040",
    "AssociateName": "Wintheiser-Buckridge",
    "AssociateId": 420,
    "UsePersonAddress": false,
    "ContactFax": "quos",
    "Kanafname": "sed",
    "Kanalname": "cum",
    "Post1": "et",
    "Post2": "neque",
    "Post3": "qui",
    "EmailName": "laurine.mraz@mann.us",
    "ContactFullName": "Hayley Leffler",
    "ActiveErpLinks": 42,
    "TicketPriorityId": 376,
    "SupportLanguageId": 250,
    "SupportAssociateId": 240,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 284
      }
    }
  },
  "MotherId": 749,
  "Priority": {
    "Id": 837,
    "Value": "quia",
    "Tooltip": "vitae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "disintermediate leading-edge web services"
        },
        "FieldType": "System.String",
        "FieldLength": 366
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 810,
    "Name": "Klocko-Johns",
    "Description": "User-friendly foreground policy",
    "URL": "http://www.example.com/",
    "Type": "laudantium",
    "AssociateId": 551,
    "AssociateFullName": "Mr. Jeremy Franecki",
    "TypeId": 431,
    "Updated": "2001-11-28T14:58:03.0955666+01:00",
    "StatusId": 417,
    "Status": "error",
    "TextId": 577,
    "PublishTo": "1998-10-13T14:58:03.0955666+02:00",
    "PublishFrom": "1998-04-28T14:58:03.0955666+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1461862",
    "ActiveErpLinks": 594,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 245
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2001-11-24T14:58:03.0955666+01:00",
  "Completed": "Completed",
  "ActiveLinks": 632,
  "Links": [
    {
      "EntityName": "Ritchie-Satterfield",
      "Id": 797,
      "Description": "Expanded cohesive intranet",
      "ExtraInfo": "quis",
      "LinkId": 85,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 387
        }
      }
    }
  ],
  "AlarmLeadTime": "tempore",
  "HasAlarm": false,
  "ColorIndex": 945,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "tenetur",
  "LeadTime": "cupiditate",
  "Location": "ea",
  "RejectCounter": 466,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 615,
    "StartDate": "2015-09-11T14:58:03.0955666+02:00",
    "EndDate": "2006-05-26T14:58:03.0955666+02:00",
    "RecurrenceCounter": 354,
    "RecurrenceEndType": "Counter",
    "Pattern": "Custom",
    "DayPattern": {},
    "WeekPattern": {},
    "MonthPattern": {},
    "YearPattern": {},
    "Dates": [
      {},
      {}
    ],
    "IsRecurrence": false
  },
  "Participants": [
    {
      "AssociateId": 690,
      "PersonId": 944,
      "ContactId": 622,
      "EmailId": 768,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 690,
      "PersonId": 944,
      "ContactId": 622,
      "EmailId": 768,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1997-04-28T14:58:03.0955666+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 7,
    "Name": "Lehner-Lehner",
    "PersonId": 552,
    "Rank": 50,
    "Tooltip": "autem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 612,
    "FullName": "Derrick Turcotte PhD",
    "FormalName": "Baumbach, Haley and Crist",
    "Deleted": false,
    "EjUserId": 696,
    "UserName": "Reilly Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 178
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 766,
    "Name": "O'Reilly, Kozey and O'Reilly",
    "PersonId": 636,
    "Rank": 398,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 81,
    "FullName": "Johann Rowe",
    "FormalName": "Schneider-Bernier",
    "Deleted": true,
    "EjUserId": 688,
    "UserName": "Stokes, Murphy and Zboncak",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 196
      }
    }
  },
  "Task": {
    "TaskListItemId": 370,
    "Value": "nulla",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "officiis",
    "Deleted": false,
    "IntentId": 620,
    "Rank": 392,
    "IsDefaultAlldayEvent": true,
    "IsDefaultFree": false,
    "IsDefaultPublished": false,
    "ColorIndex": "BlueAlt1",
    "DefaultVideomeetingStatus": "NoChange",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 489
      }
    }
  },
  "PreferredTZLocation": 19,
  "Sale": {
    "ContactName": "Miller, VonRueden and Nader",
    "SaleDate": "2007-04-30T14:58:03.0965667+02:00",
    "SaleId": 44,
    "Probability": 357,
    "Title": "dolores",
    "Amount": 24012.708,
    "Currency": "voluptatem",
    "ProjectName": "Kertzmann Inc and Sons",
    "AssociateFullName": "Mr. Israel Goodwin",
    "Description": "Digitized motivating system engine",
    "Status": "Lost",
    "WeightedAmount": 12996.698,
    "ProjectId": 938,
    "EarningPercent": 30218.028,
    "Earning": 2043.368,
    "ContactId": 214,
    "AssociateId": 312,
    "PersonId": 814,
    "SaleTypeId": 915,
    "SaleTypeName": "Smith-Harvey",
    "PersonFullName": "Ocie Hessel",
    "Completed": "Completed",
    "ActiveErpLinks": 994,
    "NextDueDate": "2000-10-27T14:58:03.0965667+02:00",
    "Number": "678802",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 983
      }
    }
  },
  "SuggestedAppointmentId": 218,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "maxime",
  "UserDefinedFields": {
    "SuperOffice:1": "2062887161",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quas",
    "ExtraFields2": "natus"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "voluptatem"
  },
  "PublishEventDate": "1998-04-27T14:58:03.0975665+02:00",
  "PublishTo": "2001-12-22T14:58:03.0975665+01:00",
  "PublishFrom": "2013-01-04T14:58:03.0975665+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 182,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 83
        }
      }
    },
    {
      "VisibleId": 182,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 83
        }
      }
    }
  ],
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
      "FieldType": "System.String",
      "FieldLength": 885
    }
  }
}
```