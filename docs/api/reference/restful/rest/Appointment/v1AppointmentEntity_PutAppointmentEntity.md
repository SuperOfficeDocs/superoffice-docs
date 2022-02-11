---
title: PUT Appointment/{id}
id: v1AppointmentEntity_PutAppointmentEntity
---

# PUT Appointment/{id}

```http
PUT /api/v1/Appointment/{id}
```

Updates the existing AppointmentEntity






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

Appointments appear in the diary, and have links to a Contact/Person and possibly a Project or Sale. They have start and end time+date.



AppointmentEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | AppointmentEntity updated. |
| 412 | Update stopped because AppointmentEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/Appointment/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 641,
    "Name": "Conn Inc and Sons",
    "PersonId": 172,
    "Rank": 753,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 928,
    "FullName": "Pat McLaughlin",
    "FormalName": "Johnston-Mayert",
    "Deleted": false,
    "EjUserId": 705,
    "UserName": "Bartell-Quitzon"
  },
  "Contact": {
    "ContactId": 684,
    "Name": "Luettgen Inc and Sons",
    "OrgNr": "799577",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "labore",
    "DirectPhone": "(838)307-2273",
    "AssociateId": 382,
    "CountryId": 471,
    "EmailAddress": "orland_schaefer@kleinlockman.com",
    "Kananame": "dolorem",
    "EmailAddressName": "bridgette_wilkinson@weberkerluke.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Lera Koepp PhD",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "iusto",
    "FullName": "Bell Hodkiewicz",
    "IsOwnerContact": false,
    "ActiveErpLinks": 370
  },
  "CreatedBy": {
    "AssociateId": 428,
    "Name": "Pfeffer-Harber",
    "PersonId": 214,
    "Rank": 638,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 497,
    "FullName": "Myrtie Bogisich",
    "FormalName": "Ruecker, Reinger and Schroeder",
    "Deleted": true,
    "EjUserId": 90,
    "UserName": "Howe Group"
  },
  "UpdatedBy": {
    "AssociateId": 152,
    "Name": "Runolfsson Inc and Sons",
    "PersonId": 813,
    "Rank": 838,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 78,
    "FullName": "Ottis Purdy",
    "FormalName": "Weber-Schoen",
    "Deleted": false,
    "EjUserId": 319,
    "UserName": "Ondricka, Kulas and Dibbert"
  },
  "CreatedDate": "1999-06-06T18:25:49.9265339+02:00",
  "AppointmentId": 875,
  "Description": "Implemented uniform circuit",
  "StartDate": "2002-06-10T18:25:49.9265339+02:00",
  "EndDate": "1999-01-27T18:25:49.9265339+01:00",
  "InvitedPerson": {
    "Position": "nostrum",
    "PersonId": 510,
    "Mrmrs": "officia",
    "Firstname": "Imelda",
    "Lastname": "Larkin",
    "MiddleName": "Durgan-Shanahan",
    "Title": "pariatur",
    "Description": "Self-enabling 3rd generation definition",
    "Email": "elliott.dickens@abshire.uk",
    "FullName": "Everette Windler",
    "DirectPhone": "858.562.6727",
    "FormalName": "Christiansen LLC",
    "CountryId": 245,
    "ContactId": 538,
    "ContactName": "Stiedemann-Schulist",
    "Retired": 694,
    "Rank": 162,
    "ActiveInterests": 550,
    "ContactDepartment": "",
    "ContactCountryId": 75,
    "ContactOrgNr": "1667977",
    "FaxPhone": "1-704-022-4165 x82142",
    "MobilePhone": "(541)036-0258 x577",
    "ContactPhone": "416.746.2247 x52585",
    "AssociateName": "Pacocha-Dooley",
    "AssociateId": 887,
    "UsePersonAddress": true,
    "ContactFax": "sunt",
    "Kanafname": "non",
    "Kanalname": "et",
    "Post1": "labore",
    "Post2": "ut",
    "Post3": "cum",
    "EmailName": "meda@quigley.us",
    "ContactFullName": "Ms. Dallas Kautzer",
    "ActiveErpLinks": 956,
    "TicketPriorityId": 250,
    "SupportLanguageId": 412,
    "SupportAssociateId": 121,
    "CategoryName": "VIP Customer"
  },
  "Person": {
    "Position": "sequi",
    "PersonId": 717,
    "Mrmrs": "ut",
    "Firstname": "Ivah",
    "Lastname": "VonRueden",
    "MiddleName": "Paucek, Wuckert and Olson",
    "Title": "et",
    "Description": "Inverse non-volatile adapter",
    "Email": "cloyd.wiza@strosin.name",
    "FullName": "Christy Greenfelder",
    "DirectPhone": "752-437-7441 x16500",
    "FormalName": "Thompson Inc and Sons",
    "CountryId": 602,
    "ContactId": 877,
    "ContactName": "Pfannerstill Group",
    "Retired": 972,
    "Rank": 440,
    "ActiveInterests": 231,
    "ContactDepartment": "",
    "ContactCountryId": 231,
    "ContactOrgNr": "917990",
    "FaxPhone": "1-258-733-1748 x42011",
    "MobilePhone": "(777)025-3517",
    "ContactPhone": "1-015-553-1716",
    "AssociateName": "Pfeffer Group",
    "AssociateId": 663,
    "UsePersonAddress": true,
    "ContactFax": "delectus",
    "Kanafname": "velit",
    "Kanalname": "fugiat",
    "Post1": "a",
    "Post2": "ex",
    "Post3": "maiores",
    "EmailName": "marilie.gerhold@kunze.ca",
    "ContactFullName": "Ernie Skiles",
    "ActiveErpLinks": 868,
    "TicketPriorityId": 885,
    "SupportLanguageId": 260,
    "SupportAssociateId": 84,
    "CategoryName": "VIP Customer"
  },
  "MotherId": 555,
  "Priority": {
    "Id": 666,
    "Value": "aut",
    "Tooltip": "itaque"
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 451,
    "Name": "Rohan, Dickinson and Kuvalis",
    "Description": "Synchronised content-based artificial intelligence",
    "URL": "http://www.example.com/",
    "Type": "laborum",
    "AssociateId": 426,
    "AssociateFullName": "Clint Waelchi",
    "TypeId": 461,
    "Updated": "2007-12-16T18:25:49.9305683+01:00",
    "StatusId": 190,
    "Status": "cupiditate",
    "TextId": 666,
    "PublishTo": "2019-01-04T18:25:49.9305683+01:00",
    "PublishFrom": "2004-06-24T18:25:49.9305683+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1329702",
    "ActiveErpLinks": 578
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2010-10-22T18:25:49.9305683+02:00",
  "Completed": "Completed",
  "ActiveLinks": 170,
  "Links": [
    {
      "EntityName": "Marquardt, Rogahn and Cruickshank",
      "Id": 762,
      "Description": "Front-line upward-trending encryption",
      "ExtraInfo": "veniam",
      "LinkId": 383
    },
    {
      "EntityName": "Marquardt, Rogahn and Cruickshank",
      "Id": 762,
      "Description": "Front-line upward-trending encryption",
      "ExtraInfo": "veniam",
      "LinkId": 383
    }
  ],
  "AlarmLeadTime": "odit",
  "HasAlarm": true,
  "ColorIndex": 444,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "explicabo",
  "LeadTime": "repellat",
  "Location": "necessitatibus",
  "RejectCounter": 275,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 815,
    "StartDate": "2019-06-23T18:25:49.9305683+02:00",
    "EndDate": "2016-04-01T18:25:49.9305683+02:00",
    "RecurrenceCounter": 408,
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
      "AssociateId": 300,
      "PersonId": 57,
      "ContactId": 676,
      "EmailId": 853,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 300,
      "PersonId": 57,
      "ContactId": 676,
      "EmailId": 853,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1997-10-09T18:25:49.9305683+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 244,
    "Name": "Fisher LLC",
    "PersonId": 641,
    "Rank": 103,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 313,
    "FullName": "Cecelia Lang",
    "FormalName": "Kovacek, Romaguera and West",
    "Deleted": true,
    "EjUserId": 720,
    "UserName": "Mayert, Mann and Little"
  },
  "MotherAssociate": {
    "AssociateId": 567,
    "Name": "Littel LLC",
    "PersonId": 597,
    "Rank": 30,
    "Tooltip": "earum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 119,
    "FullName": "Lulu Zboncak Sr.",
    "FormalName": "Kilback Inc and Sons",
    "Deleted": false,
    "EjUserId": 414,
    "UserName": "Leannon, O'Hara and Torphy"
  },
  "Task": {
    "TaskListItemId": 163,
    "Value": "exercitationem",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "et",
    "Deleted": false,
    "IntentId": 600,
    "Rank": 677,
    "IsDefaultAlldayEvent": false,
    "IsDefaultFree": false,
    "IsDefaultPublished": true,
    "ColorIndex": "BlueAlt1",
    "DefaultVideomeetingStatus": "NoChange"
  },
  "PreferredTZLocation": 826,
  "Sale": {
    "ContactName": "Wuckert-Hilll",
    "SaleDate": "2019-11-01T18:25:49.9315678+01:00",
    "SaleId": 54,
    "Probability": 264,
    "Title": "atque",
    "Amount": 18362.106,
    "Currency": "est",
    "ProjectName": "Veum-Cummerata",
    "AssociateFullName": "Albin Volkman",
    "Description": "De-engineered exuding hardware",
    "Status": "Lost",
    "WeightedAmount": 23492.464,
    "ProjectId": 788,
    "EarningPercent": 407.41999999999996,
    "Earning": 22104.102,
    "ContactId": 138,
    "AssociateId": 653,
    "PersonId": 972,
    "SaleTypeId": 256,
    "SaleTypeName": "Schmitt-Hermann",
    "PersonFullName": "Carroll Walsh",
    "Completed": "Completed",
    "ActiveErpLinks": 156,
    "NextDueDate": "2006-02-11T18:25:49.9315678+01:00",
    "Number": "1733272"
  },
  "SuggestedAppointmentId": 130,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "nesciunt",
  "UserDefinedFields": {
    "SuperOffice:1": "Ronny Quitzon",
    "SuperOffice:2": "Ashley Lebsack"
  },
  "ExtraFields": {
    "ExtraFields1": "adipisci",
    "ExtraFields2": "quis"
  },
  "CustomFields": {
    "CustomFields1": "laborum",
    "CustomFields2": "incidunt"
  },
  "PublishEventDate": "2019-05-09T18:25:49.9315678+02:00",
  "PublishTo": "1998-04-28T18:25:49.9315678+02:00",
  "PublishFrom": "2010-07-04T18:25:49.9315678+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 752,
      "Visibility": "All",
      "DisplayValue": "accusamus"
    },
    {
      "VisibleId": 752,
      "Visibility": "All",
      "DisplayValue": "accusamus"
    }
  ]
}
```

```http_
HTTP/1.1 200 AppointmentEntity updated.
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 158,
    "Name": "Kunze-Monahan",
    "PersonId": 11,
    "Rank": 678,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 770,
    "FullName": "Lydia Feil",
    "FormalName": "Swaniawski-Hyatt",
    "Deleted": true,
    "EjUserId": 559,
    "UserName": "Hayes, Williamson and Reinger",
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
  "Contact": {
    "ContactId": 601,
    "Name": "VonRueden, Johnston and Bashirian",
    "OrgNr": "796589",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quis",
    "DirectPhone": "371-048-4316 x11317",
    "AssociateId": 771,
    "CountryId": 199,
    "EmailAddress": "hilma@williamson.uk",
    "Kananame": "magni",
    "EmailAddressName": "adele@becker.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "King Ruecker",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "similique",
    "FullName": "Jettie Schmitt",
    "IsOwnerContact": false,
    "ActiveErpLinks": 136,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 689
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 543,
    "Name": "Farrell Group",
    "PersonId": 29,
    "Rank": 801,
    "Tooltip": "quaerat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 743,
    "FullName": "Althea Ward",
    "FormalName": "Veum-Schultz",
    "Deleted": true,
    "EjUserId": 783,
    "UserName": "Pfannerstill-O'Hara",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 201
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 918,
    "Name": "Murazik, Hintz and Senger",
    "PersonId": 933,
    "Rank": 707,
    "Tooltip": "dignissimos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 809,
    "FullName": "Demetris Huels",
    "FormalName": "Waters-Flatley",
    "Deleted": false,
    "EjUserId": 23,
    "UserName": "Ledner LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 784
      }
    }
  },
  "CreatedDate": "1995-09-19T18:25:49.9415619+02:00",
  "AppointmentId": 230,
  "Description": "Reduced 4th generation policy",
  "StartDate": "2001-07-12T18:25:49.9415619+02:00",
  "EndDate": "2018-12-29T18:25:49.9415619+01:00",
  "InvitedPerson": {
    "Position": "aut",
    "PersonId": 55,
    "Mrmrs": "rerum",
    "Firstname": "Allan",
    "Lastname": "Schroeder",
    "MiddleName": "Jacobs, Kub and Towne",
    "Title": "ipsam",
    "Description": "Configurable exuding capacity",
    "Email": "hal.kemmer@osinski.biz",
    "FullName": "Allan Wolf",
    "DirectPhone": "(836)035-2303 x615",
    "FormalName": "Streich Inc and Sons",
    "CountryId": 787,
    "ContactId": 612,
    "ContactName": "Marks, Bernhard and Zboncak",
    "Retired": 627,
    "Rank": 649,
    "ActiveInterests": 310,
    "ContactDepartment": "",
    "ContactCountryId": 932,
    "ContactOrgNr": "951367",
    "FaxPhone": "307.140.1084",
    "MobilePhone": "(760)321-4638",
    "ContactPhone": "333-871-6166 x87863",
    "AssociateName": "Morissette-Schaefer",
    "AssociateId": 98,
    "UsePersonAddress": false,
    "ContactFax": "tempora",
    "Kanafname": "dolore",
    "Kanalname": "in",
    "Post1": "vitae",
    "Post2": "eum",
    "Post3": "delectus",
    "EmailName": "laura@keeblerschinner.ca",
    "ContactFullName": "Winnifred Graham",
    "ActiveErpLinks": 802,
    "TicketPriorityId": 738,
    "SupportLanguageId": 360,
    "SupportAssociateId": 893,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "unleash cutting-edge schemas"
        },
        "FieldType": "System.String",
        "FieldLength": 911
      }
    }
  },
  "Person": {
    "Position": "quia",
    "PersonId": 148,
    "Mrmrs": "non",
    "Firstname": "Carson",
    "Lastname": "Okuneva",
    "MiddleName": "Turcotte Group",
    "Title": "suscipit",
    "Description": "Total well-modulated matrix",
    "Email": "alex@monahan.co.uk",
    "FullName": "Sincere Kuhlman",
    "DirectPhone": "1-324-422-4850",
    "FormalName": "Labadie-Kuphal",
    "CountryId": 636,
    "ContactId": 945,
    "ContactName": "Boehm LLC",
    "Retired": 748,
    "Rank": 404,
    "ActiveInterests": 468,
    "ContactDepartment": "",
    "ContactCountryId": 321,
    "ContactOrgNr": "1511842",
    "FaxPhone": "1-183-262-5772 x63377",
    "MobilePhone": "357.438.0307 x10530",
    "ContactPhone": "(620)443-2176 x7535",
    "AssociateName": "Wilderman LLC",
    "AssociateId": 514,
    "UsePersonAddress": false,
    "ContactFax": "ut",
    "Kanafname": "praesentium",
    "Kanalname": "nulla",
    "Post1": "sed",
    "Post2": "aut",
    "Post3": "ipsum",
    "EmailName": "enrico@padberg.biz",
    "ContactFullName": "Hipolito Welch",
    "ActiveErpLinks": 298,
    "TicketPriorityId": 696,
    "SupportLanguageId": 661,
    "SupportAssociateId": 761,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 373
      }
    }
  },
  "MotherId": 674,
  "Priority": {
    "Id": 195,
    "Value": "dolores",
    "Tooltip": "voluptatem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 848
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 516,
    "Name": "Hintz Inc and Sons",
    "Description": "Front-line impactful hierarchy",
    "URL": "http://www.example.com/",
    "Type": "dolore",
    "AssociateId": 981,
    "AssociateFullName": "Mrs. Chadd Bode",
    "TypeId": 644,
    "Updated": "2009-08-02T18:25:49.945562+02:00",
    "StatusId": 210,
    "Status": "cumque",
    "TextId": 68,
    "PublishTo": "2011-04-10T18:25:49.9465646+02:00",
    "PublishFrom": "1996-03-10T18:25:49.9465646+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1144290",
    "ActiveErpLinks": 990,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 327
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2015-04-13T18:25:49.9465646+02:00",
  "Completed": "Completed",
  "ActiveLinks": 660,
  "Links": [
    {
      "EntityName": "Rohan, Walker and Monahan",
      "Id": 353,
      "Description": "Ergonomic next generation challenge",
      "ExtraInfo": "reprehenderit",
      "LinkId": 610,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 200
        }
      }
    }
  ],
  "AlarmLeadTime": "omnis",
  "HasAlarm": true,
  "ColorIndex": 167,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "commodi",
  "LeadTime": "dolorem",
  "Location": "deleniti",
  "RejectCounter": 907,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 924,
    "StartDate": "1998-06-24T18:25:49.9465646+02:00",
    "EndDate": "1999-05-22T18:25:49.9465646+02:00",
    "RecurrenceCounter": 340,
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
      "AssociateId": 529,
      "PersonId": 599,
      "ContactId": 191,
      "EmailId": 458,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 529,
      "PersonId": 599,
      "ContactId": 191,
      "EmailId": 458,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1996-01-13T18:25:49.9465646+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 982,
    "Name": "Friesen-Rutherford",
    "PersonId": 114,
    "Rank": 77,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 387,
    "FullName": "Imani Bartell",
    "FormalName": "Schmidt, Welch and Tromp",
    "Deleted": false,
    "EjUserId": 788,
    "UserName": "Thiel-Towne",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 824
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 711,
    "Name": "Boehm-Klocko",
    "PersonId": 928,
    "Rank": 528,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 567,
    "FullName": "Cameron Robel",
    "FormalName": "Feest, Crona and Senger",
    "Deleted": false,
    "EjUserId": 753,
    "UserName": "Crona Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 903
      }
    }
  },
  "Task": {
    "TaskListItemId": 835,
    "Value": "porro",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "illum",
    "Deleted": true,
    "IntentId": 368,
    "Rank": 686,
    "IsDefaultAlldayEvent": true,
    "IsDefaultFree": false,
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
        "FieldType": "System.Int32",
        "FieldLength": 971
      }
    }
  },
  "PreferredTZLocation": 751,
  "Sale": {
    "ContactName": "Batz, Hyatt and Reichel",
    "SaleDate": "2020-02-02T18:25:49.9475617+01:00",
    "SaleId": 801,
    "Probability": 534,
    "Title": "nam",
    "Amount": 535.914,
    "Currency": "consequatur",
    "ProjectName": "Bailey Group",
    "AssociateFullName": "Addison Jaskolski",
    "Description": "Operative 24 hour flexibility",
    "Status": "Lost",
    "WeightedAmount": 11906.065999999999,
    "ProjectId": 551,
    "EarningPercent": 27663.818,
    "Earning": 29425.126,
    "ContactId": 49,
    "AssociateId": 503,
    "PersonId": 937,
    "SaleTypeId": 853,
    "SaleTypeName": "Hane-Gutmann",
    "PersonFullName": "Benton Schimmel",
    "Completed": "Completed",
    "ActiveErpLinks": 997,
    "NextDueDate": "2021-03-15T18:25:49.9475617+01:00",
    "Number": "669240",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 828
      }
    }
  },
  "SuggestedAppointmentId": 468,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "nemo",
  "UserDefinedFields": {
    "SuperOffice:1": "Victoria Jewess",
    "SuperOffice:2": "1417558862"
  },
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "facere"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "officia"
  },
  "PublishEventDate": "2007-04-23T18:25:49.9475617+02:00",
  "PublishTo": "2008-02-06T18:25:49.9475617+01:00",
  "PublishFrom": "2000-10-05T18:25:49.9475617+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 901,
      "Visibility": "All",
      "DisplayValue": "eum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 828
        }
      }
    },
    {
      "VisibleId": 901,
      "Visibility": "All",
      "DisplayValue": "eum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 828
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
      "FieldLength": 946
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```