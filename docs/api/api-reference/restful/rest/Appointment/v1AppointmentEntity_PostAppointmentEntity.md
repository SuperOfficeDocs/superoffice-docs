---
title: POST Appointment
id: v1AppointmentEntity_PostAppointmentEntity
---

# POST Appointment

```http
POST /api/v1/Appointment
```

Creates a new AppointmentEntity

Calls the Appointment agent service SaveAppointmentEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Appointment?$select=name,department,category/id
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

## Request Body: newEntity  

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
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/Appointment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 344,
    "Name": "Collier-Schulist",
    "PersonId": 845,
    "Rank": 252,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 488,
    "FullName": "Chase Murphy",
    "FormalName": "Larson Inc and Sons",
    "Deleted": true,
    "EjUserId": 506,
    "UserName": "Price-Jast"
  },
  "Contact": {
    "ContactId": 459,
    "Name": "O'Reilly, Huel and Borer",
    "OrgNr": "999734",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "error",
    "DirectPhone": "1-221-261-7566",
    "AssociateId": 743,
    "CountryId": 647,
    "EmailAddress": "burdette_collier@keeblerstanton.co.uk",
    "Kananame": "quis",
    "EmailAddressName": "shayne_kohler@romagueraschuster.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Esteban Waelchi",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "repudiandae",
    "FullName": "Vinnie Ernser",
    "IsOwnerContact": true,
    "ActiveErpLinks": 77
  },
  "CreatedBy": {
    "AssociateId": 668,
    "Name": "Wolf, Pollich and Rau",
    "PersonId": 106,
    "Rank": 896,
    "Tooltip": "deleniti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 127,
    "FullName": "Miss Jena Jaskolski",
    "FormalName": "Koss, Graham and Jacobi",
    "Deleted": true,
    "EjUserId": 751,
    "UserName": "Satterfield Group"
  },
  "UpdatedBy": {
    "AssociateId": 884,
    "Name": "Reilly-McDermott",
    "PersonId": 234,
    "Rank": 300,
    "Tooltip": "modi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 775,
    "FullName": "Mikayla Huels",
    "FormalName": "Dach Group",
    "Deleted": false,
    "EjUserId": 172,
    "UserName": "Ledner Group"
  },
  "CreatedDate": "2000-06-29T18:25:49.8855339+02:00",
  "AppointmentId": 680,
  "Description": "Mandatory reciprocal adapter",
  "StartDate": "1998-11-30T18:25:49.8855339+01:00",
  "EndDate": "2003-05-13T18:25:49.8855339+02:00",
  "InvitedPerson": {
    "Position": "quis",
    "PersonId": 327,
    "Mrmrs": "velit",
    "Firstname": "Christophe",
    "Lastname": "Schoen",
    "MiddleName": "Hoeger Inc and Sons",
    "Title": "sit",
    "Description": "Cross-platform transitional attitude",
    "Email": "arlene_kunde@carroll.biz",
    "FullName": "Ramona Fritsch",
    "DirectPhone": "062.714.4354 x74137",
    "FormalName": "Gibson-Crist",
    "CountryId": 94,
    "ContactId": 403,
    "ContactName": "Olson, Schmeler and Heller",
    "Retired": 85,
    "Rank": 524,
    "ActiveInterests": 529,
    "ContactDepartment": "",
    "ContactCountryId": 219,
    "ContactOrgNr": "1401567",
    "FaxPhone": "816.504.7654 x4321",
    "MobilePhone": "(821)336-7038",
    "ContactPhone": "1-668-818-6050 x52263",
    "AssociateName": "Runte-Jakubowski",
    "AssociateId": 190,
    "UsePersonAddress": true,
    "ContactFax": "voluptates",
    "Kanafname": "error",
    "Kanalname": "accusantium",
    "Post1": "quia",
    "Post2": "explicabo",
    "Post3": "ut",
    "EmailName": "bulah_bruen@price.biz",
    "ContactFullName": "Lennie Gorczany II",
    "ActiveErpLinks": 969,
    "TicketPriorityId": 867,
    "SupportLanguageId": 608,
    "SupportAssociateId": 74,
    "CategoryName": "VIP Customer"
  },
  "Person": {
    "Position": "vitae",
    "PersonId": 672,
    "Mrmrs": "error",
    "Firstname": "Ron",
    "Lastname": "Schumm",
    "MiddleName": "Hickle-Murphy",
    "Title": "nihil",
    "Description": "Innovative 24 hour info-mediaries",
    "Email": "gaylord_deckow@ferry.co.uk",
    "FullName": "Lourdes Upton",
    "DirectPhone": "1-823-162-6040",
    "FormalName": "Gutkowski Group",
    "CountryId": 660,
    "ContactId": 426,
    "ContactName": "Crooks Group",
    "Retired": 351,
    "Rank": 188,
    "ActiveInterests": 136,
    "ContactDepartment": "",
    "ContactCountryId": 939,
    "ContactOrgNr": "1006575",
    "FaxPhone": "760-548-8441 x2801",
    "MobilePhone": "1-433-570-5188",
    "ContactPhone": "1-261-520-4038 x87413",
    "AssociateName": "Cruickshank-Hackett",
    "AssociateId": 779,
    "UsePersonAddress": true,
    "ContactFax": "eius",
    "Kanafname": "cum",
    "Kanalname": "in",
    "Post1": "aut",
    "Post2": "aliquam",
    "Post3": "perferendis",
    "EmailName": "lera_effertz@weberschmitt.us",
    "ContactFullName": "Virgil Rau",
    "ActiveErpLinks": 374,
    "TicketPriorityId": 461,
    "SupportLanguageId": 551,
    "SupportAssociateId": 893,
    "CategoryName": "VIP Customer"
  },
  "MotherId": 418,
  "Priority": {
    "Id": 511,
    "Value": "esse",
    "Tooltip": "modi"
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 185,
    "Name": "Spencer LLC",
    "Description": "Persevering optimal database",
    "URL": "http://www.example.com/",
    "Type": "voluptatum",
    "AssociateId": 163,
    "AssociateFullName": "Winnifred Emard",
    "TypeId": 860,
    "Updated": "2007-12-14T18:25:49.8885333+01:00",
    "StatusId": 158,
    "Status": "tempora",
    "TextId": 508,
    "PublishTo": "2008-04-15T18:25:49.8885333+02:00",
    "PublishFrom": "2004-04-18T18:25:49.8885333+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1011028",
    "ActiveErpLinks": 217
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2003-03-08T18:25:49.8885333+01:00",
  "Completed": "Completed",
  "ActiveLinks": 296,
  "Links": [
    {
      "EntityName": "Smith, Russel and Schiller",
      "Id": 894,
      "Description": "Managed local framework",
      "ExtraInfo": "aliquid",
      "LinkId": 67
    },
    {
      "EntityName": "Smith, Russel and Schiller",
      "Id": 894,
      "Description": "Managed local framework",
      "ExtraInfo": "aliquid",
      "LinkId": 67
    }
  ],
  "AlarmLeadTime": "nulla",
  "HasAlarm": true,
  "ColorIndex": 556,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "aperiam",
  "LeadTime": "aliquid",
  "Location": "consectetur",
  "RejectCounter": 340,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 122,
    "StartDate": "2010-12-08T18:25:49.8885333+01:00",
    "EndDate": "2006-05-13T18:25:49.8885333+02:00",
    "RecurrenceCounter": 332,
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
      "AssociateId": 916,
      "PersonId": 381,
      "ContactId": 481,
      "EmailId": 326,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 916,
      "PersonId": 381,
      "ContactId": 481,
      "EmailId": 326,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2000-06-05T18:25:49.8885333+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 879,
    "Name": "Koss-Schinner",
    "PersonId": 294,
    "Rank": 950,
    "Tooltip": "quod",
    "Type": "AnonymousAssociate",
    "GroupIdx": 652,
    "FullName": "Trudie Kunde",
    "FormalName": "Keeling-Bernhard",
    "Deleted": false,
    "EjUserId": 31,
    "UserName": "Bauch LLC"
  },
  "MotherAssociate": {
    "AssociateId": 191,
    "Name": "Brown LLC",
    "PersonId": 12,
    "Rank": 231,
    "Tooltip": "veniam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 606,
    "FullName": "Kenyon Gislason",
    "FormalName": "Treutel Inc and Sons",
    "Deleted": true,
    "EjUserId": 109,
    "UserName": "Thiel-Lehner"
  },
  "Task": {
    "TaskListItemId": 70,
    "Value": "deleniti",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "aut",
    "Deleted": true,
    "IntentId": 553,
    "Rank": 401,
    "IsDefaultAlldayEvent": false,
    "IsDefaultFree": false,
    "IsDefaultPublished": false,
    "ColorIndex": "BlueAlt1",
    "DefaultVideomeetingStatus": "NoChange"
  },
  "PreferredTZLocation": 364,
  "Sale": {
    "ContactName": "Grady Group",
    "SaleDate": "1996-03-13T18:25:49.8895336+01:00",
    "SaleId": 461,
    "Probability": 85,
    "Title": "laudantium",
    "Amount": 11702.356,
    "Currency": "suscipit",
    "ProjectName": "Schultz-Kilback",
    "AssociateFullName": "Gerald Cruickshank",
    "Description": "Automated bandwidth-monitored methodology",
    "Status": "Lost",
    "WeightedAmount": 955.87,
    "ProjectId": 28,
    "EarningPercent": 17293.412,
    "Earning": 12595.546,
    "ContactId": 159,
    "AssociateId": 458,
    "PersonId": 206,
    "SaleTypeId": 34,
    "SaleTypeName": "Moore, Mueller and Konopelski",
    "PersonFullName": "Zelma Senger",
    "Completed": "Completed",
    "ActiveErpLinks": 942,
    "NextDueDate": "2019-11-17T18:25:49.8895336+01:00",
    "Number": "1341167"
  },
  "SuggestedAppointmentId": 17,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "in",
  "UserDefinedFields": {
    "SuperOffice:1": "Katlynn Mayert",
    "SuperOffice:2": "1217502004"
  },
  "ExtraFields": {
    "ExtraFields1": "minus",
    "ExtraFields2": "aliquam"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "et"
  },
  "PublishEventDate": "1998-11-02T18:25:49.8905333+01:00",
  "PublishTo": "2010-01-20T18:25:49.8905333+01:00",
  "PublishFrom": "2006-11-27T18:25:49.8905333+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 714,
      "Visibility": "All",
      "DisplayValue": "qui"
    },
    {
      "VisibleId": 714,
      "Visibility": "All",
      "DisplayValue": "qui"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 234,
    "Name": "Upton-Koepp",
    "PersonId": 833,
    "Rank": 810,
    "Tooltip": "placeat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 583,
    "FullName": "Dr. Vicente Hauck",
    "FormalName": "Mohr, Konopelski and Wintheiser",
    "Deleted": true,
    "EjUserId": 566,
    "UserName": "Schamberger LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 798
      }
    }
  },
  "Contact": {
    "ContactId": 688,
    "Name": "Jacobs Inc and Sons",
    "OrgNr": "757617",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "repellat",
    "DirectPhone": "543.524.7144 x353",
    "AssociateId": 806,
    "CountryId": 238,
    "EmailAddress": "hollis_kessler@upton.name",
    "Kananame": "et",
    "EmailAddressName": "jamey.nader@parkerrenner.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Dr. Ismael O'Reilly",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "tenetur",
    "FullName": "Kelvin Stehr",
    "IsOwnerContact": true,
    "ActiveErpLinks": 365,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engineer distributed methodologies"
        },
        "FieldType": "System.String",
        "FieldLength": 864
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 697,
    "Name": "Wilkinson Group",
    "PersonId": 119,
    "Rank": 603,
    "Tooltip": "culpa",
    "Type": "AnonymousAssociate",
    "GroupIdx": 38,
    "FullName": "Jonatan Wisoky",
    "FormalName": "Moore, Schneider and Hermiston",
    "Deleted": false,
    "EjUserId": 789,
    "UserName": "Lang LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 950
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 551,
    "Name": "Wilderman-Robel",
    "PersonId": 870,
    "Rank": 362,
    "Tooltip": "eligendi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 567,
    "FullName": "Fiona Schaefer",
    "FormalName": "Hagenes, Heaney and Fisher",
    "Deleted": true,
    "EjUserId": 33,
    "UserName": "Legros-Kuhn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 700
      }
    }
  },
  "CreatedDate": "2016-04-11T18:25:49.9005336+02:00",
  "AppointmentId": 465,
  "Description": "Grass-roots actuating access",
  "StartDate": "2008-12-12T18:25:49.9015338+01:00",
  "EndDate": "2004-12-17T18:25:49.9015338+01:00",
  "InvitedPerson": {
    "Position": "ab",
    "PersonId": 797,
    "Mrmrs": "ut",
    "Firstname": "Caterina",
    "Lastname": "D'Amore",
    "MiddleName": "Goldner-Torp",
    "Title": "doloribus",
    "Description": "Adaptive background task-force",
    "Email": "cayla.turcotte@ratkejewess.co.uk",
    "FullName": "Luther Grant",
    "DirectPhone": "143.843.6574",
    "FormalName": "Goldner, Bogan and Stokes",
    "CountryId": 831,
    "ContactId": 260,
    "ContactName": "Schiller-Halvorson",
    "Retired": 451,
    "Rank": 589,
    "ActiveInterests": 267,
    "ContactDepartment": "",
    "ContactCountryId": 183,
    "ContactOrgNr": "787376",
    "FaxPhone": "868-086-8088",
    "MobilePhone": "452.413.4175 x71482",
    "ContactPhone": "588-124-2777 x36507",
    "AssociateName": "Hansen, Nitzsche and Gusikowski",
    "AssociateId": 674,
    "UsePersonAddress": true,
    "ContactFax": "quia",
    "Kanafname": "qui",
    "Kanalname": "nostrum",
    "Post1": "sit",
    "Post2": "perspiciatis",
    "Post3": "est",
    "EmailName": "harmon.batz@reichert.uk",
    "ContactFullName": "Eveline Turcotte",
    "ActiveErpLinks": 715,
    "TicketPriorityId": 525,
    "SupportLanguageId": 731,
    "SupportAssociateId": 750,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 627
      }
    }
  },
  "Person": {
    "Position": "expedita",
    "PersonId": 490,
    "Mrmrs": "nam",
    "Firstname": "Hobart",
    "Lastname": "Pagac",
    "MiddleName": "Towne Group",
    "Title": "quaerat",
    "Description": "Face to face asynchronous portal",
    "Email": "micah_luettgen@fritsch.uk",
    "FullName": "Fred Armstrong",
    "DirectPhone": "568-664-8183",
    "FormalName": "Hauck-Baumbach",
    "CountryId": 893,
    "ContactId": 437,
    "ContactName": "Hermann-Boehm",
    "Retired": 617,
    "Rank": 624,
    "ActiveInterests": 776,
    "ContactDepartment": "",
    "ContactCountryId": 36,
    "ContactOrgNr": "476494",
    "FaxPhone": "(328)082-3551 x74460",
    "MobilePhone": "634.173.8116 x632",
    "ContactPhone": "1-574-716-2830 x832",
    "AssociateName": "Schneider Group",
    "AssociateId": 562,
    "UsePersonAddress": false,
    "ContactFax": "numquam",
    "Kanafname": "soluta",
    "Kanalname": "ab",
    "Post1": "perferendis",
    "Post2": "omnis",
    "Post3": "exercitationem",
    "EmailName": "alanis.bogan@balistreriauer.biz",
    "ContactFullName": "Hassan Gottlieb",
    "ActiveErpLinks": 850,
    "TicketPriorityId": 984,
    "SupportLanguageId": 374,
    "SupportAssociateId": 300,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 325
      }
    }
  },
  "MotherId": 266,
  "Priority": {
    "Id": 136,
    "Value": "accusamus",
    "Tooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 840
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 291,
    "Name": "Zemlak-Block",
    "Description": "Open-source tertiary algorithm",
    "URL": "http://www.example.com/",
    "Type": "tempore",
    "AssociateId": 779,
    "AssociateFullName": "Shea Frami",
    "TypeId": 109,
    "Updated": "1996-05-02T18:25:49.9045351+02:00",
    "StatusId": 456,
    "Status": "eum",
    "TextId": 754,
    "PublishTo": "2007-02-20T18:25:49.9045351+01:00",
    "PublishFrom": "1995-11-15T18:25:49.9045351+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1099434",
    "ActiveErpLinks": 160,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "monetize visionary interfaces"
        },
        "FieldType": "System.String",
        "FieldLength": 579
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2009-01-17T18:25:49.9045351+01:00",
  "Completed": "Completed",
  "ActiveLinks": 777,
  "Links": [
    {
      "EntityName": "Turner, Stanton and Hyatt",
      "Id": 437,
      "Description": "Switchable 24/7 intranet",
      "ExtraInfo": "magnam",
      "LinkId": 651,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "unleash global systems"
          },
          "FieldType": "System.String",
          "FieldLength": 301
        }
      }
    }
  ],
  "AlarmLeadTime": "culpa",
  "HasAlarm": true,
  "ColorIndex": 350,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "quo",
  "LeadTime": "vitae",
  "Location": "magnam",
  "RejectCounter": 51,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 983,
    "StartDate": "2017-07-27T18:25:49.9055349+02:00",
    "EndDate": "2005-06-23T18:25:49.9055349+02:00",
    "RecurrenceCounter": 796,
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
      "AssociateId": 103,
      "PersonId": 699,
      "ContactId": 910,
      "EmailId": 212,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 103,
      "PersonId": 699,
      "ContactId": 910,
      "EmailId": 212,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2013-02-18T18:25:49.9055349+01:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 891,
    "Name": "Goyette-Little",
    "PersonId": 727,
    "Rank": 508,
    "Tooltip": "voluptatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 722,
    "FullName": "Tom Ruecker",
    "FormalName": "Dooley Group",
    "Deleted": false,
    "EjUserId": 962,
    "UserName": "Kozey Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 884
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 143,
    "Name": "Anderson Group",
    "PersonId": 361,
    "Rank": 515,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 364,
    "FullName": "Jerome Kemmer",
    "FormalName": "Botsford-Schroeder",
    "Deleted": false,
    "EjUserId": 705,
    "UserName": "McDermott-Runolfsson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 136
      }
    }
  },
  "Task": {
    "TaskListItemId": 610,
    "Value": "reiciendis",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "laboriosam",
    "Deleted": true,
    "IntentId": 666,
    "Rank": 586,
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
        "FieldLength": 823
      }
    }
  },
  "PreferredTZLocation": 688,
  "Sale": {
    "ContactName": "Heathcote-Leffler",
    "SaleDate": "2020-04-26T18:25:49.9055349+02:00",
    "SaleId": 665,
    "Probability": 560,
    "Title": "vel",
    "Amount": 15732.68,
    "Currency": "asperiores",
    "ProjectName": "Gusikowski Group",
    "AssociateFullName": "Donna Fahey",
    "Description": "Universal cohesive projection",
    "Status": "Lost",
    "WeightedAmount": 9464.68,
    "ProjectId": 772,
    "EarningPercent": 26588.856,
    "Earning": 22712.097999999998,
    "ContactId": 839,
    "AssociateId": 432,
    "PersonId": 414,
    "SaleTypeId": 176,
    "SaleTypeName": "Metz Group",
    "PersonFullName": "Alayna Roob I",
    "Completed": "Completed",
    "ActiveErpLinks": 922,
    "NextDueDate": "2016-12-04T18:25:49.9065352+01:00",
    "Number": "1600253",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 590
      }
    }
  },
  "SuggestedAppointmentId": 259,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "itaque",
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Jonatan Blanda",
    "SuperOffice:2": "1458625393"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "eius"
  },
  "CustomFields": {
    "CustomFields1": "incidunt",
    "CustomFields2": "quia"
  },
  "PublishEventDate": "1997-02-13T18:25:49.9065352+01:00",
  "PublishTo": "2014-04-09T18:25:49.9065352+02:00",
  "PublishFrom": "1995-05-16T18:25:49.9065352+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 559,
      "Visibility": "All",
      "DisplayValue": "cupiditate",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 223
        }
      }
    },
    {
      "VisibleId": 559,
      "Visibility": "All",
      "DisplayValue": "cupiditate",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 223
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
      "FieldLength": 240
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```