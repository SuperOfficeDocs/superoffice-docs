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
    "AssociateId": 760,
    "Name": "Pfannerstill-Sawayn",
    "PersonId": 898,
    "Rank": 891,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 160,
    "FullName": "Mr. Harrison Hettinger",
    "FormalName": "Dietrich, Gottlieb and Crooks",
    "Deleted": true,
    "EjUserId": 596,
    "UserName": "Renner, Gottlieb and Howell"
  },
  "Contact": {
    "ContactId": 572,
    "Name": "Kohler-Boyer",
    "OrgNr": "1284821",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "iste",
    "DirectPhone": "1-868-328-3454",
    "AssociateId": 328,
    "CountryId": 320,
    "EmailAddress": "thalia_bartell@greenfeldergrant.info",
    "Kananame": "accusantium",
    "EmailAddressName": "elian@leffler.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Dee Willms",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "provident",
    "FullName": "Ms. Augustine Gerlach",
    "IsOwnerContact": false,
    "ActiveErpLinks": 854
  },
  "CreatedBy": {
    "AssociateId": 113,
    "Name": "Ferry Inc and Sons",
    "PersonId": 811,
    "Rank": 63,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 407,
    "FullName": "Elta Ullrich",
    "FormalName": "Rice Group",
    "Deleted": false,
    "EjUserId": 508,
    "UserName": "Cummings-Satterfield"
  },
  "UpdatedBy": {
    "AssociateId": 578,
    "Name": "Moen, Harber and Lakin",
    "PersonId": 803,
    "Rank": 786,
    "Tooltip": "rem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 770,
    "FullName": "Ibrahim Dare",
    "FormalName": "Daugherty-Strosin",
    "Deleted": true,
    "EjUserId": 238,
    "UserName": "Barrows, Terry and Barrows"
  },
  "CreatedDate": "2012-11-29T18:28:47.9238444+01:00",
  "AppointmentId": 935,
  "Description": "Balanced dedicated projection",
  "StartDate": "2017-02-06T18:28:47.9238444+01:00",
  "EndDate": "2006-07-20T18:28:47.9238444+02:00",
  "InvitedPerson": {
    "Position": "fuga",
    "PersonId": 731,
    "Mrmrs": "sed",
    "Firstname": "Faye",
    "Lastname": "Nader",
    "MiddleName": "Gulgowski, Gerlach and Kohler",
    "Title": "architecto",
    "Description": "Self-enabling solution-oriented solution",
    "Email": "austin@reynolds.co.uk",
    "FullName": "Cordia Rolfson",
    "DirectPhone": "1-723-448-5801 x6351",
    "FormalName": "Baumbach-Braun",
    "CountryId": 978,
    "ContactId": 493,
    "ContactName": "Schmidt Inc and Sons",
    "Retired": 508,
    "Rank": 82,
    "ActiveInterests": 590,
    "ContactDepartment": "benchmark magnetic relationships",
    "ContactCountryId": 485,
    "ContactOrgNr": "748272",
    "FaxPhone": "1-743-376-4017",
    "MobilePhone": "(104)818-8363 x8562",
    "ContactPhone": "(331)348-1076 x15220",
    "AssociateName": "Nicolas LLC",
    "AssociateId": 828,
    "UsePersonAddress": false,
    "ContactFax": "nihil",
    "Kanafname": "aliquam",
    "Kanalname": "atque",
    "Post1": "aut",
    "Post2": "recusandae",
    "Post3": "qui",
    "EmailName": "wilford@cassin.info",
    "ContactFullName": "Norma Waelchi",
    "ActiveErpLinks": 55,
    "TicketPriorityId": 649,
    "SupportLanguageId": 211,
    "SupportAssociateId": 2,
    "CategoryName": "VIP Customer"
  },
  "Person": {
    "Position": "id",
    "PersonId": 158,
    "Mrmrs": "incidunt",
    "Firstname": "Dewitt",
    "Lastname": "Ferry",
    "MiddleName": "Hettinger, Hodkiewicz and Pfannerstill",
    "Title": "repudiandae",
    "Description": "Self-enabling 5th generation array",
    "Email": "cary@ward.us",
    "FullName": "Shanon Gleason",
    "DirectPhone": "100-304-2165 x05655",
    "FormalName": "Miller, Murray and Kihn",
    "CountryId": 30,
    "ContactId": 994,
    "ContactName": "O'Hara LLC",
    "Retired": 891,
    "Rank": 776,
    "ActiveInterests": 282,
    "ContactDepartment": "",
    "ContactCountryId": 856,
    "ContactOrgNr": "668258",
    "FaxPhone": "830-728-5155 x24241",
    "MobilePhone": "866.232.7834",
    "ContactPhone": "1-217-323-2624 x635",
    "AssociateName": "Fay LLC",
    "AssociateId": 399,
    "UsePersonAddress": false,
    "ContactFax": "numquam",
    "Kanafname": "sunt",
    "Kanalname": "et",
    "Post1": "omnis",
    "Post2": "iure",
    "Post3": "sunt",
    "EmailName": "jared@jacobi.info",
    "ContactFullName": "Abelardo Bailey Jr.",
    "ActiveErpLinks": 819,
    "TicketPriorityId": 952,
    "SupportLanguageId": 875,
    "SupportAssociateId": 211,
    "CategoryName": "VIP Customer"
  },
  "MotherId": 343,
  "Priority": {
    "Id": 26,
    "Value": "sed",
    "Tooltip": "qui"
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 219,
    "Name": "Cummerata Group",
    "Description": "Exclusive full-range database",
    "URL": "http://www.example.com/",
    "Type": "ut",
    "AssociateId": 886,
    "AssociateFullName": "Marie Gutkowski",
    "TypeId": 283,
    "Updated": "2005-07-19T18:28:47.9258417+02:00",
    "StatusId": 259,
    "Status": "sed",
    "TextId": 567,
    "PublishTo": "2017-08-21T18:28:47.9258417+02:00",
    "PublishFrom": "1996-04-30T18:28:47.9258417+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "747982",
    "ActiveErpLinks": 624
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2015-10-31T18:28:47.9258417+01:00",
  "Completed": "Completed",
  "ActiveLinks": 754,
  "Links": [
    {
      "EntityName": "Deckow-Stark",
      "Id": 122,
      "Description": "Diverse dedicated interface",
      "ExtraInfo": "facilis",
      "LinkId": 770
    },
    {
      "EntityName": "Deckow-Stark",
      "Id": 122,
      "Description": "Diverse dedicated interface",
      "ExtraInfo": "facilis",
      "LinkId": 770
    }
  ],
  "AlarmLeadTime": "maiores",
  "HasAlarm": true,
  "ColorIndex": 486,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "sunt",
  "LeadTime": "maxime",
  "Location": "distinctio",
  "RejectCounter": 3,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 297,
    "StartDate": "2020-10-02T18:28:47.9268448+02:00",
    "EndDate": "2020-07-09T18:28:47.9268448+02:00",
    "RecurrenceCounter": 112,
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
      "AssociateId": 204,
      "PersonId": 504,
      "ContactId": 762,
      "EmailId": 956,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 204,
      "PersonId": 504,
      "ContactId": 762,
      "EmailId": 956,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2019-11-07T18:28:47.9268448+01:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 9,
    "Name": "Dibbert-Dach",
    "PersonId": 444,
    "Rank": 684,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 482,
    "FullName": "Adelia Yost",
    "FormalName": "Deckow, Littel and Shanahan",
    "Deleted": true,
    "EjUserId": 207,
    "UserName": "Murray-Luettgen"
  },
  "MotherAssociate": {
    "AssociateId": 562,
    "Name": "Kris Group",
    "PersonId": 532,
    "Rank": 446,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 904,
    "FullName": "Natasha O'Keefe",
    "FormalName": "Carter-Cassin",
    "Deleted": false,
    "EjUserId": 369,
    "UserName": "Torphy Group"
  },
  "Task": {
    "TaskListItemId": 729,
    "Value": "quos",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "sunt",
    "Deleted": false,
    "IntentId": 938,
    "Rank": 821,
    "IsDefaultAlldayEvent": false,
    "IsDefaultFree": true,
    "IsDefaultPublished": true,
    "ColorIndex": "BlueAlt1",
    "DefaultVideomeetingStatus": "NoChange"
  },
  "PreferredTZLocation": 689,
  "Sale": {
    "ContactName": "Cremin, Medhurst and Yost",
    "SaleDate": "2004-06-27T18:28:47.9268448+02:00",
    "SaleId": 8,
    "Probability": 393,
    "Title": "et",
    "Amount": 8417.9239999999991,
    "Currency": "molestiae",
    "ProjectName": "Macejkovic, Smitham and Hayes",
    "AssociateFullName": "Reinhold Skiles",
    "Description": "Expanded zero tolerance time-frame",
    "Status": "Lost",
    "WeightedAmount": 29008.304,
    "ProjectId": 157,
    "EarningPercent": 30785.282,
    "Earning": 16826.446,
    "ContactId": 84,
    "AssociateId": 9,
    "PersonId": 356,
    "SaleTypeId": 206,
    "SaleTypeName": "Brekke, Kerluke and Torphy",
    "PersonFullName": "Jarret Turcotte Sr.",
    "Completed": "Completed",
    "ActiveErpLinks": 520,
    "NextDueDate": "2017-09-19T18:28:47.9278471+02:00",
    "Number": "1295689"
  },
  "SuggestedAppointmentId": 906,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "voluptatibus",
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Nicole O'Hara"
  },
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "rem"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "veritatis"
  },
  "PublishEventDate": "1996-09-13T18:28:47.9278471+02:00",
  "PublishTo": "2013-03-09T18:28:47.9278471+01:00",
  "PublishFrom": "2014-09-20T18:28:47.9278471+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 624,
      "Visibility": "All",
      "DisplayValue": "est"
    },
    {
      "VisibleId": 624,
      "Visibility": "All",
      "DisplayValue": "est"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 310,
    "Name": "Pfannerstill Inc and Sons",
    "PersonId": 241,
    "Rank": 935,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 654,
    "FullName": "Norberto Moen",
    "FormalName": "Parisian-Block",
    "Deleted": true,
    "EjUserId": 757,
    "UserName": "Borer-Wolff",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 319
      }
    }
  },
  "Contact": {
    "ContactId": 154,
    "Name": "Kihn LLC",
    "OrgNr": "1313818",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "natus",
    "DirectPhone": "1-035-134-3342",
    "AssociateId": 973,
    "CountryId": 298,
    "EmailAddress": "coleman@grahampaucek.us",
    "Kananame": "debitis",
    "EmailAddressName": "gregoria@schumm.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "John Considine",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ex",
    "FullName": "Mrs. Libbie Robel",
    "IsOwnerContact": false,
    "ActiveErpLinks": 604,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 961
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 395,
    "Name": "Heathcote-Steuber",
    "PersonId": 850,
    "Rank": 248,
    "Tooltip": "occaecati",
    "Type": "AnonymousAssociate",
    "GroupIdx": 997,
    "FullName": "Marina Cassin",
    "FormalName": "Jenkins-Russel",
    "Deleted": true,
    "EjUserId": 651,
    "UserName": "Sipes-Shanahan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 250
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 942,
    "Name": "Treutel-Reinger",
    "PersonId": 83,
    "Rank": 228,
    "Tooltip": "laboriosam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 9,
    "FullName": "Janis Feeney",
    "FormalName": "Smith, Volkman and Zboncak",
    "Deleted": true,
    "EjUserId": 489,
    "UserName": "Hickle-Feil",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 539
      }
    }
  },
  "CreatedDate": "2011-02-16T18:28:47.9368444+01:00",
  "AppointmentId": 91,
  "Description": "Reactive bi-directional access",
  "StartDate": "1999-12-16T18:28:47.9368444+01:00",
  "EndDate": "2001-12-15T18:28:47.9368444+01:00",
  "InvitedPerson": {
    "Position": "et",
    "PersonId": 666,
    "Mrmrs": "autem",
    "Firstname": "Narciso",
    "Lastname": "Runte",
    "MiddleName": "Hayes, Bins and O'Hara",
    "Title": "ullam",
    "Description": "Streamlined non-volatile middleware",
    "Email": "robin.fritsch@tillman.ca",
    "FullName": "Triston Littel",
    "DirectPhone": "758-856-5011 x15640",
    "FormalName": "Gutmann Inc and Sons",
    "CountryId": 488,
    "ContactId": 706,
    "ContactName": "Kohler, Sawayn and Gulgowski",
    "Retired": 950,
    "Rank": 551,
    "ActiveInterests": 562,
    "ContactDepartment": "",
    "ContactCountryId": 205,
    "ContactOrgNr": "267555",
    "FaxPhone": "(180)615-4516 x47544",
    "MobilePhone": "(742)247-1375 x0018",
    "ContactPhone": "183-373-2057 x84808",
    "AssociateName": "Koelpin-Auer",
    "AssociateId": 894,
    "UsePersonAddress": false,
    "ContactFax": "quisquam",
    "Kanafname": "qui",
    "Kanalname": "dolor",
    "Post1": "pariatur",
    "Post2": "est",
    "Post3": "autem",
    "EmailName": "samanta@veum.co.uk",
    "ContactFullName": "Deon Legros",
    "ActiveErpLinks": 530,
    "TicketPriorityId": 674,
    "SupportLanguageId": 420,
    "SupportAssociateId": 527,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "seize user-centric web services"
        },
        "FieldType": "System.String",
        "FieldLength": 16
      }
    }
  },
  "Person": {
    "Position": "doloremque",
    "PersonId": 162,
    "Mrmrs": "recusandae",
    "Firstname": "Van",
    "Lastname": "Bahringer",
    "MiddleName": "Rempel LLC",
    "Title": "eaque",
    "Description": "Mandatory intermediate collaboration",
    "Email": "maye@hilpert.us",
    "FullName": "Eva Collier",
    "DirectPhone": "470-528-5030",
    "FormalName": "Prosacco Group",
    "CountryId": 982,
    "ContactId": 339,
    "ContactName": "Rodriguez LLC",
    "Retired": 55,
    "Rank": 48,
    "ActiveInterests": 636,
    "ContactDepartment": "",
    "ContactCountryId": 973,
    "ContactOrgNr": "191562",
    "FaxPhone": "(752)656-0330 x0334",
    "MobilePhone": "1-004-837-0024 x12034",
    "ContactPhone": "(755)187-5356 x45203",
    "AssociateName": "Lubowitz Inc and Sons",
    "AssociateId": 622,
    "UsePersonAddress": false,
    "ContactFax": "ut",
    "Kanafname": "aut",
    "Kanalname": "omnis",
    "Post1": "tempora",
    "Post2": "ea",
    "Post3": "hic",
    "EmailName": "cheyanne.schulist@hand.uk",
    "ContactFullName": "Mrs. Nasir Gerhold",
    "ActiveErpLinks": 502,
    "TicketPriorityId": 781,
    "SupportLanguageId": 196,
    "SupportAssociateId": 164,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 794
      }
    }
  },
  "MotherId": 606,
  "Priority": {
    "Id": 396,
    "Value": "a",
    "Tooltip": "praesentium",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 902
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 742,
    "Name": "Rohan-Blanda",
    "Description": "Upgradable intermediate encryption",
    "URL": "http://www.example.com/",
    "Type": "sed",
    "AssociateId": 405,
    "AssociateFullName": "Janis Tromp",
    "TypeId": 878,
    "Updated": "2004-11-08T18:28:47.9388448+01:00",
    "StatusId": 215,
    "Status": "omnis",
    "TextId": 65,
    "PublishTo": "2007-09-27T18:28:47.9398474+02:00",
    "PublishFrom": "2003-07-12T18:28:47.9398474+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "392321",
    "ActiveErpLinks": 788,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 866
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2011-08-05T18:28:47.9398474+02:00",
  "Completed": "Completed",
  "ActiveLinks": 133,
  "Links": [
    {
      "EntityName": "Abernathy Group",
      "Id": 753,
      "Description": "Reactive demand-driven middleware",
      "ExtraInfo": "quas",
      "LinkId": 755,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 731
        }
      }
    }
  ],
  "AlarmLeadTime": "consequuntur",
  "HasAlarm": true,
  "ColorIndex": 660,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "molestias",
  "LeadTime": "et",
  "Location": "quis",
  "RejectCounter": 421,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 252,
    "StartDate": "2011-12-01T18:28:47.9398474+01:00",
    "EndDate": "2002-09-20T18:28:47.9398474+02:00",
    "RecurrenceCounter": 28,
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
      "AssociateId": 875,
      "PersonId": 956,
      "ContactId": 463,
      "EmailId": 69,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 875,
      "PersonId": 956,
      "ContactId": 463,
      "EmailId": 69,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2000-11-04T18:28:47.9398474+01:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 865,
    "Name": "Ryan, Walsh and Morissette",
    "PersonId": 845,
    "Rank": 297,
    "Tooltip": "placeat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 246,
    "FullName": "Dasia Jewess PhD",
    "FormalName": "Koepp, Conn and Becker",
    "Deleted": true,
    "EjUserId": 411,
    "UserName": "Wyman-Durgan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 583
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 918,
    "Name": "Hayes-Legros",
    "PersonId": 664,
    "Rank": 314,
    "Tooltip": "harum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 326,
    "FullName": "Ruthe Renner",
    "FormalName": "McLaughlin Inc and Sons",
    "Deleted": false,
    "EjUserId": 719,
    "UserName": "O'Conner LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 177
      }
    }
  },
  "Task": {
    "TaskListItemId": 408,
    "Value": "minima",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "fugiat",
    "Deleted": true,
    "IntentId": 716,
    "Rank": 671,
    "IsDefaultAlldayEvent": true,
    "IsDefaultFree": true,
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
        "FieldLength": 143
      }
    }
  },
  "PreferredTZLocation": 394,
  "Sale": {
    "ContactName": "Murray LLC",
    "SaleDate": "1994-09-15T18:28:47.9408443+02:00",
    "SaleId": 890,
    "Probability": 580,
    "Title": "natus",
    "Amount": 29418.858,
    "Currency": "qui",
    "ProjectName": "Hahn LLC",
    "AssociateFullName": "Josianne Corkery",
    "Description": "Streamlined encompassing local area network",
    "Status": "Lost",
    "WeightedAmount": 18957.566,
    "ProjectId": 18,
    "EarningPercent": 11498.645999999999,
    "Earning": 13310.098,
    "ContactId": 790,
    "AssociateId": 916,
    "PersonId": 145,
    "SaleTypeId": 302,
    "SaleTypeName": "King-Lakin",
    "PersonFullName": "Lorine Wuckert DDS",
    "Completed": "Completed",
    "ActiveErpLinks": 287,
    "NextDueDate": "1996-12-09T18:28:47.9408443+01:00",
    "Number": "1295212",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 276
      }
    }
  },
  "SuggestedAppointmentId": 921,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "ea",
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1028457592"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "similique"
  },
  "CustomFields": {
    "CustomFields1": "nam",
    "CustomFields2": "quaerat"
  },
  "PublishEventDate": "2014-04-17T18:28:47.9408443+02:00",
  "PublishTo": "2008-12-31T18:28:47.9408443+01:00",
  "PublishFrom": "1997-09-06T18:28:47.9408443+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 679,
      "Visibility": "All",
      "DisplayValue": "aspernatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 266
        }
      }
    },
    {
      "VisibleId": 679,
      "Visibility": "All",
      "DisplayValue": "aspernatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 266
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
        "Reason": "syndicate impactful architectures"
      },
      "FieldType": "System.String",
      "FieldLength": 897
    }
  }
}
```