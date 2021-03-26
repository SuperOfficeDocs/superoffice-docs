---
title: POST Agents/Appointment/SaveAppointmentEntity
id: v1AppointmentAgent_SaveAppointmentEntity
---

# POST Agents/Appointment/SaveAppointmentEntity

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 800,
    "Name": "Collins, Ernser and Sporer",
    "PersonId": 921,
    "Rank": 73,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 101,
    "FullName": "Niko Swift",
    "FormalName": "Bosco Inc and Sons",
    "Deleted": false,
    "EjUserId": 953,
    "UserName": "Marks LLC"
  },
  "Contact": {
    "ContactId": 636,
    "Name": "Jacobson, Dicki and Murazik",
    "OrgNr": "1095849",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "fugiat",
    "DirectPhone": "1-320-216-1204 x80243",
    "AssociateId": 853,
    "CountryId": 542,
    "EmailAddress": "nathan.swift@kassulkehartmann.uk",
    "Kananame": "et",
    "EmailAddressName": "leta@macejkovicmante.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Halie Mosciski",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nulla",
    "FullName": "Addison Rodriguez",
    "IsOwnerContact": true,
    "ActiveErpLinks": 571
  },
  "CreatedBy": {
    "AssociateId": 927,
    "Name": "Muller-Brown",
    "PersonId": 745,
    "Rank": 260,
    "Tooltip": "aspernatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 451,
    "FullName": "Alysson Robel",
    "FormalName": "Reilly, Schumm and Hand",
    "Deleted": true,
    "EjUserId": 914,
    "UserName": "Murphy, Tillman and Jones"
  },
  "UpdatedBy": {
    "AssociateId": 820,
    "Name": "Bashirian, Rohan and Nolan",
    "PersonId": 695,
    "Rank": 831,
    "Tooltip": "deserunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 38,
    "FullName": "Mathilde Schmitt",
    "FormalName": "Vandervort, Bartoletti and Altenwerth",
    "Deleted": true,
    "EjUserId": 721,
    "UserName": "Russel LLC"
  },
  "CreatedDate": "2002-11-30T16:48:28.508449+01:00",
  "AppointmentId": 791,
  "Description": "Multi-tiered 4th generation knowledge base",
  "StartDate": "1995-12-18T16:48:28.508449+01:00",
  "EndDate": "1998-05-27T16:48:28.508449+02:00",
  "InvitedPerson": {
    "Position": "itaque",
    "PersonId": 43,
    "Mrmrs": "aut",
    "Firstname": "Evie",
    "Lastname": "Quigley",
    "MiddleName": "Willms-Jakubowski",
    "Title": "quo",
    "Description": "Triple-buffered client-driven orchestration",
    "Email": "alexandrea@morar.name",
    "FullName": "Fletcher Cruickshank",
    "DirectPhone": "1-023-815-2765",
    "FormalName": "Klocko LLC",
    "CountryId": 998,
    "ContactId": 365,
    "ContactName": "Lebsack Inc and Sons",
    "Retired": 869,
    "Rank": 709,
    "ActiveInterests": 406,
    "ContactDepartment": "",
    "ContactCountryId": 306,
    "ContactOrgNr": "1425307",
    "FaxPhone": "(086)855-7860 x347",
    "MobilePhone": "1-681-557-4028 x3544",
    "ContactPhone": "1-183-465-2078 x45522",
    "AssociateName": "Wolf, Fritsch and Cassin",
    "AssociateId": 965,
    "UsePersonAddress": false,
    "ContactFax": "est",
    "Kanafname": "deserunt",
    "Kanalname": "repellat",
    "Post1": "est",
    "Post2": "asperiores",
    "Post3": "nihil",
    "EmailName": "korey@weber.co.uk",
    "ContactFullName": "Ms. Robb Heaney",
    "ActiveErpLinks": 687,
    "TicketPriorityId": 94,
    "SupportLanguageId": 290,
    "SupportAssociateId": 987,
    "CategoryName": "VIP Customer"
  },
  "Person": {
    "Position": "rerum",
    "PersonId": 110,
    "Mrmrs": "eum",
    "Firstname": "Franz",
    "Lastname": "Kuhn",
    "MiddleName": "Kling-Greenholt",
    "Title": "voluptates",
    "Description": "Sharable multimedia migration",
    "Email": "connie@johnson.biz",
    "FullName": "Timothy Walter Sr.",
    "DirectPhone": "463-022-8165",
    "FormalName": "Moore Group",
    "CountryId": 931,
    "ContactId": 609,
    "ContactName": "Sawayn Group",
    "Retired": 142,
    "Rank": 271,
    "ActiveInterests": 448,
    "ContactDepartment": "",
    "ContactCountryId": 543,
    "ContactOrgNr": "887984",
    "FaxPhone": "(131)614-1386 x0275",
    "MobilePhone": "1-375-826-2843 x07856",
    "ContactPhone": "1-225-140-0463",
    "AssociateName": "Wolff-Thompson",
    "AssociateId": 46,
    "UsePersonAddress": true,
    "ContactFax": "sed",
    "Kanafname": "sit",
    "Kanalname": "sint",
    "Post1": "nihil",
    "Post2": "ut",
    "Post3": "qui",
    "EmailName": "bryon@halvorson.ca",
    "ContactFullName": "Aliya Dickens",
    "ActiveErpLinks": 431,
    "TicketPriorityId": 416,
    "SupportLanguageId": 332,
    "SupportAssociateId": 852,
    "CategoryName": "VIP Customer"
  },
  "MotherId": 143,
  "Priority": {
    "Id": 221,
    "Value": "exercitationem",
    "Tooltip": "architecto"
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 951,
    "Name": "Friesen, Lehner and Mann",
    "Description": "Streamlined composite archive",
    "URL": "http://www.example.com/",
    "Type": "laborum",
    "AssociateId": 277,
    "AssociateFullName": "Ms. Nelson Heaney",
    "TypeId": 100,
    "Updated": "2019-01-24T16:48:28.5104496+01:00",
    "StatusId": 647,
    "Status": "quis",
    "TextId": 208,
    "PublishTo": "2008-11-02T16:48:28.5104496+01:00",
    "PublishFrom": "1996-01-15T16:48:28.5104496+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1637501",
    "ActiveErpLinks": 67
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "1995-08-28T16:48:28.5104496+02:00",
  "Completed": "Completed",
  "ActiveLinks": 684,
  "Links": [
    {
      "EntityName": "Howell-Botsford",
      "Id": 330,
      "Description": "Down-sized full-range productivity",
      "ExtraInfo": "autem",
      "LinkId": 384
    },
    {
      "EntityName": "Howell-Botsford",
      "Id": 330,
      "Description": "Down-sized full-range productivity",
      "ExtraInfo": "autem",
      "LinkId": 384
    }
  ],
  "AlarmLeadTime": "numquam",
  "HasAlarm": false,
  "ColorIndex": 156,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "et",
  "LeadTime": "pariatur",
  "Location": "voluptatum",
  "RejectCounter": 791,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 499,
    "StartDate": "2020-12-17T16:48:28.5104496+01:00",
    "EndDate": "2017-05-08T16:48:28.5104496+02:00",
    "RecurrenceCounter": 584,
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
    "IsRecurrence": true
  },
  "Participants": [
    {
      "AssociateId": 154,
      "PersonId": 329,
      "ContactId": 933,
      "EmailId": 628,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 154,
      "PersonId": 329,
      "ContactId": 933,
      "EmailId": 628,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2013-03-08T16:48:28.5104496+01:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 402,
    "Name": "Kling, Ferry and Hegmann",
    "PersonId": 955,
    "Rank": 564,
    "Tooltip": "delectus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 815,
    "FullName": "Alexandra D'Amore",
    "FormalName": "Schowalter-Sipes",
    "Deleted": true,
    "EjUserId": 278,
    "UserName": "Gutmann LLC"
  },
  "MotherAssociate": {
    "AssociateId": 944,
    "Name": "Torp-Nitzsche",
    "PersonId": 529,
    "Rank": 754,
    "Tooltip": "cum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 442,
    "FullName": "Clare Blick",
    "FormalName": "Shields, Gerhold and Ondricka",
    "Deleted": true,
    "EjUserId": 21,
    "UserName": "Schmeler LLC"
  },
  "Task": {
    "TaskListItemId": 341,
    "Value": "ut",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "officia",
    "Deleted": false,
    "IntentId": 406,
    "Rank": 92,
    "IsDefaultAlldayEvent": true,
    "IsDefaultFree": false,
    "IsDefaultPublished": false,
    "ColorIndex": "BlueAlt1",
    "DefaultVideomeetingStatus": "NoChange"
  },
  "PreferredTZLocation": 706,
  "Sale": {
    "ContactName": "Schroeder-Koss",
    "SaleDate": "2013-05-18T16:48:28.5114502+02:00",
    "SaleId": 305,
    "Probability": 375,
    "Title": "voluptas",
    "Amount": 2952.228,
    "Currency": "voluptatibus",
    "ProjectName": "Leuschke-Bogisich",
    "AssociateFullName": "Eldora Schowalter IV",
    "Description": "Exclusive composite portal",
    "Status": "Lost",
    "WeightedAmount": 22436.306,
    "ProjectId": 790,
    "EarningPercent": 2764.188,
    "Earning": 23329.496,
    "ContactId": 37,
    "AssociateId": 464,
    "PersonId": 34,
    "SaleTypeId": 288,
    "SaleTypeName": "Wisozk, Turner and Williamson",
    "PersonFullName": "Corine Leuschke",
    "Completed": "Completed",
    "ActiveErpLinks": 163,
    "NextDueDate": "1994-10-11T16:48:28.5124502+02:00",
    "Number": "637507"
  },
  "SuggestedAppointmentId": 362,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "iure",
  "UserDefinedFields": {
    "SuperOffice:1": "William Kshlerin",
    "SuperOffice:2": "309201711"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquid",
    "ExtraFields2": "nobis"
  },
  "CustomFields": {
    "CustomFields1": "natus",
    "CustomFields2": "quidem"
  },
  "PublishEventDate": "1999-02-02T16:48:28.5124502+01:00",
  "PublishTo": "1999-02-08T16:48:28.5124502+01:00",
  "PublishFrom": "1999-09-02T16:48:28.5124502+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 672,
      "Visibility": "All",
      "DisplayValue": "aut"
    },
    {
      "VisibleId": 672,
      "Visibility": "All",
      "DisplayValue": "aut"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 122,
    "Name": "Yundt-Marvin",
    "PersonId": 736,
    "Rank": 361,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 544,
    "FullName": "Angelina Reichert",
    "FormalName": "Hamill-Schaefer",
    "Deleted": true,
    "EjUserId": 791,
    "UserName": "Shields, Turner and Hammes",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 937
      }
    }
  },
  "Contact": {
    "ContactId": 399,
    "Name": "Keebler-Osinski",
    "OrgNr": "777209",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "cum",
    "DirectPhone": "(314)540-0228 x577",
    "AssociateId": 645,
    "CountryId": 732,
    "EmailAddress": "layla.kunde@kozey.info",
    "Kananame": "et",
    "EmailAddressName": "kyla@strosin.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Rodger Kirlin",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "et",
    "FullName": "Edythe Stokes I",
    "IsOwnerContact": false,
    "ActiveErpLinks": 200,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 525
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 790,
    "Name": "Leannon, Will and Kris",
    "PersonId": 916,
    "Rank": 881,
    "Tooltip": "accusamus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 751,
    "FullName": "Loren O'Kon",
    "FormalName": "Walker-Kirlin",
    "Deleted": false,
    "EjUserId": 348,
    "UserName": "Armstrong, Dicki and Rolfson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 640
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 570,
    "Name": "Gleason-Mayert",
    "PersonId": 523,
    "Rank": 366,
    "Tooltip": "animi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 803,
    "FullName": "Mervin Hyatt",
    "FormalName": "Simonis LLC",
    "Deleted": false,
    "EjUserId": 493,
    "UserName": "O'Kon-Doyle",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 771
      }
    }
  },
  "CreatedDate": "1995-09-18T16:48:28.5214488+02:00",
  "AppointmentId": 748,
  "Description": "Object-based methodical collaboration",
  "StartDate": "2019-06-04T16:48:28.5214488+02:00",
  "EndDate": "2004-09-25T16:48:28.5214488+02:00",
  "InvitedPerson": {
    "Position": "ad",
    "PersonId": 313,
    "Mrmrs": "id",
    "Firstname": "Jerome",
    "Lastname": "Fahey",
    "MiddleName": "Fritsch Inc and Sons",
    "Title": "quia",
    "Description": "Operative 5th generation throughput",
    "Email": "cielo_stark@ratke.info",
    "FullName": "Jovani Schowalter",
    "DirectPhone": "570.462.2163 x832",
    "FormalName": "Jacobson-Corkery",
    "CountryId": 868,
    "ContactId": 852,
    "ContactName": "Rempel Group",
    "Retired": 968,
    "Rank": 321,
    "ActiveInterests": 989,
    "ContactDepartment": "",
    "ContactCountryId": 103,
    "ContactOrgNr": "1837770",
    "FaxPhone": "470-655-3033 x26707",
    "MobilePhone": "362-028-6205 x5401",
    "ContactPhone": "332-258-6560 x0448",
    "AssociateName": "Crist Group",
    "AssociateId": 535,
    "UsePersonAddress": true,
    "ContactFax": "in",
    "Kanafname": "sint",
    "Kanalname": "dolores",
    "Post1": "voluptas",
    "Post2": "doloremque",
    "Post3": "qui",
    "EmailName": "efrain@schoen.biz",
    "ContactFullName": "Mose Reichert Jr.",
    "ActiveErpLinks": 540,
    "TicketPriorityId": 7,
    "SupportLanguageId": 197,
    "SupportAssociateId": 515,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 452
      }
    }
  },
  "Person": {
    "Position": "voluptatem",
    "PersonId": 660,
    "Mrmrs": "incidunt",
    "Firstname": "Rowland",
    "Lastname": "Kling",
    "MiddleName": "Schiller, Langosh and Cole",
    "Title": "deserunt",
    "Description": "Self-enabling cohesive analyzer",
    "Email": "merle@osinski.com",
    "FullName": "Lisa D'Amore",
    "DirectPhone": "1-083-863-4527",
    "FormalName": "Bernhard-Larson",
    "CountryId": 956,
    "ContactId": 886,
    "ContactName": "Weissnat, Pouros and Miller",
    "Retired": 609,
    "Rank": 482,
    "ActiveInterests": 734,
    "ContactDepartment": "",
    "ContactCountryId": 141,
    "ContactOrgNr": "924320",
    "FaxPhone": "374.600.8743",
    "MobilePhone": "665-043-6011 x77250",
    "ContactPhone": "720.151.2166 x030",
    "AssociateName": "Collins-Hauck",
    "AssociateId": 440,
    "UsePersonAddress": true,
    "ContactFax": "eveniet",
    "Kanafname": "totam",
    "Kanalname": "qui",
    "Post1": "et",
    "Post2": "hic",
    "Post3": "quae",
    "EmailName": "angus@kshlerin.ca",
    "ContactFullName": "Caroline D'Amore",
    "ActiveErpLinks": 554,
    "TicketPriorityId": 444,
    "SupportLanguageId": 438,
    "SupportAssociateId": 274,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 84
      }
    }
  },
  "MotherId": 577,
  "Priority": {
    "Id": 81,
    "Value": "ex",
    "Tooltip": "nobis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 113
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 754,
    "Name": "Schmidt-Hackett",
    "Description": "Operative needs-based internet solution",
    "URL": "http://www.example.com/",
    "Type": "nisi",
    "AssociateId": 536,
    "AssociateFullName": "Liam Turner",
    "TypeId": 279,
    "Updated": "1995-01-02T16:48:28.5234561+01:00",
    "StatusId": 399,
    "Status": "deserunt",
    "TextId": 197,
    "PublishTo": "2010-01-24T16:48:28.5234561+01:00",
    "PublishFrom": "2018-08-20T16:48:28.5234561+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "972719",
    "ActiveErpLinks": 874,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 381
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "1995-03-26T16:48:28.5234561+02:00",
  "Completed": "Completed",
  "ActiveLinks": 408,
  "Links": [
    {
      "EntityName": "Jaskolski, Ryan and Rolfson",
      "Id": 136,
      "Description": "Triple-buffered logistical customer loyalty",
      "ExtraInfo": "doloribus",
      "LinkId": 550,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 79
        }
      }
    }
  ],
  "AlarmLeadTime": "quis",
  "HasAlarm": false,
  "ColorIndex": 945,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "dolorum",
  "LeadTime": "maiores",
  "Location": "quis",
  "RejectCounter": 2,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 663,
    "StartDate": "2008-06-29T16:48:28.5234561+02:00",
    "EndDate": "2005-03-26T16:48:28.5234561+01:00",
    "RecurrenceCounter": 877,
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
      "AssociateId": 184,
      "PersonId": 648,
      "ContactId": 321,
      "EmailId": 689,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 184,
      "PersonId": 648,
      "ContactId": 321,
      "EmailId": 689,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1999-06-24T16:48:28.5234561+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 618,
    "Name": "Veum-Botsford",
    "PersonId": 202,
    "Rank": 8,
    "Tooltip": "cumque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 789,
    "FullName": "Norval Predovic",
    "FormalName": "McClure-Schoen",
    "Deleted": false,
    "EjUserId": 525,
    "UserName": "Considine, Friesen and Herzog",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 357
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 257,
    "Name": "Lindgren-Schaden",
    "PersonId": 480,
    "Rank": 630,
    "Tooltip": "accusantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 387,
    "FullName": "Kenton Gislason",
    "FormalName": "Hodkiewicz-Lakin",
    "Deleted": true,
    "EjUserId": 84,
    "UserName": "Thompson-Mraz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 239
      }
    }
  },
  "Task": {
    "TaskListItemId": 621,
    "Value": "et",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "repudiandae",
    "Deleted": true,
    "IntentId": 846,
    "Rank": 752,
    "IsDefaultAlldayEvent": false,
    "IsDefaultFree": true,
    "IsDefaultPublished": true,
    "ColorIndex": "BlueAlt1",
    "DefaultVideomeetingStatus": "NoChange",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 196
      }
    }
  },
  "PreferredTZLocation": 282,
  "Sale": {
    "ContactName": "Gerhold LLC",
    "SaleDate": "2000-04-09T16:48:28.5244512+02:00",
    "SaleId": 742,
    "Probability": 277,
    "Title": "aliquid",
    "Amount": 23755.719999999998,
    "Currency": "aut",
    "ProjectName": "Dicki-Little",
    "AssociateFullName": "Willy Lind",
    "Description": "Synergistic hybrid utilisation",
    "Status": "Lost",
    "WeightedAmount": 3519.482,
    "ProjectId": 421,
    "EarningPercent": 25924.448,
    "Earning": 14065.392,
    "ContactId": 351,
    "AssociateId": 773,
    "PersonId": 775,
    "SaleTypeId": 740,
    "SaleTypeName": "Wiegand LLC",
    "PersonFullName": "Antonio DuBuque",
    "Completed": "Completed",
    "ActiveErpLinks": 261,
    "NextDueDate": "1996-12-28T16:48:28.5244512+01:00",
    "Number": "1400917",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 113
      }
    }
  },
  "SuggestedAppointmentId": 652,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "qui",
  "UserDefinedFields": {
    "SuperOffice:1": "Dulce Emard",
    "SuperOffice:2": "Keegan Halvorson"
  },
  "ExtraFields": {
    "ExtraFields1": "quas",
    "ExtraFields2": "laborum"
  },
  "CustomFields": {
    "CustomFields1": "repellendus",
    "CustomFields2": "eligendi"
  },
  "PublishEventDate": "2017-12-27T16:48:28.5254493+01:00",
  "PublishTo": "2011-11-23T16:48:28.5254493+01:00",
  "PublishFrom": "2007-08-09T16:48:28.5254493+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 657,
      "Visibility": "All",
      "DisplayValue": "optio",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 179
        }
      }
    },
    {
      "VisibleId": 657,
      "Visibility": "All",
      "DisplayValue": "optio",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 179
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
      "FieldLength": 279
    }
  }
}
```