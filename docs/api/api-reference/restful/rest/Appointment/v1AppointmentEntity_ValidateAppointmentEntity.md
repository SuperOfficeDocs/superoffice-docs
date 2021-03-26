---
title: POST Appointment/Validate
id: v1AppointmentEntity_ValidateAppointmentEntity
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



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
POST /api/v1/Appointment/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 652,
    "Name": "Hyatt-Rutherford",
    "PersonId": 282,
    "Rank": 366,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 532,
    "FullName": "Ms. Zane Balistreri",
    "FormalName": "Anderson-Bartoletti",
    "Deleted": false,
    "EjUserId": 537,
    "UserName": "Haag Inc and Sons"
  },
  "Contact": {
    "ContactId": 399,
    "Name": "Bernier-Bailey",
    "OrgNr": "558141",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "nostrum",
    "DirectPhone": "1-116-437-6734 x5152",
    "AssociateId": 844,
    "CountryId": 321,
    "EmailAddress": "emmanuel@wuckert.com",
    "Kananame": "autem",
    "EmailAddressName": "savion@gaylord.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Davon Hintz",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quibusdam",
    "FullName": "Savion McGlynn",
    "IsOwnerContact": true,
    "ActiveErpLinks": 237
  },
  "CreatedBy": {
    "AssociateId": 678,
    "Name": "Schowalter, Rath and Dickinson",
    "PersonId": 892,
    "Rank": 807,
    "Tooltip": "incidunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 626,
    "FullName": "Elvie Altenwerth",
    "FormalName": "Dietrich LLC",
    "Deleted": true,
    "EjUserId": 553,
    "UserName": "Kuhn Inc and Sons"
  },
  "UpdatedBy": {
    "AssociateId": 457,
    "Name": "Wolf Group",
    "PersonId": 262,
    "Rank": 966,
    "Tooltip": "veritatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 733,
    "FullName": "Nathaniel Bashirian",
    "FormalName": "Dicki-Ondricka",
    "Deleted": false,
    "EjUserId": 984,
    "UserName": "Bins, McClure and Batz"
  },
  "CreatedDate": "2002-02-10T09:40:58.6403706+01:00",
  "AppointmentId": 302,
  "Description": "Up-sized executive emulation",
  "StartDate": "2004-09-10T09:40:58.6403706+02:00",
  "EndDate": "1997-07-20T09:40:58.6403706+02:00",
  "InvitedPerson": {
    "Position": "eaque",
    "PersonId": 967,
    "Mrmrs": "et",
    "Firstname": "Emelia",
    "Lastname": "Nader",
    "MiddleName": "Farrell, Murphy and Spencer",
    "Title": "ipsum",
    "Description": "Realigned tertiary Graphical User Interface",
    "Email": "wanda_abernathy@lind.uk",
    "FullName": "Hassan Kozey",
    "DirectPhone": "(086)316-6803 x0585",
    "FormalName": "Becker-Watsica",
    "CountryId": 411,
    "ContactId": 324,
    "ContactName": "Tillman, Hessel and Huel",
    "Retired": 680,
    "Rank": 602,
    "ActiveInterests": 136,
    "ContactDepartment": "",
    "ContactCountryId": 468,
    "ContactOrgNr": "1001729",
    "FaxPhone": "810.161.6881",
    "MobilePhone": "1-554-478-1240 x067",
    "ContactPhone": "(407)072-2621 x3745",
    "AssociateName": "Feest, Keeling and Hermann",
    "AssociateId": 610,
    "UsePersonAddress": true,
    "ContactFax": "eum",
    "Kanafname": "sequi",
    "Kanalname": "voluptatem",
    "Post1": "dignissimos",
    "Post2": "aut",
    "Post3": "corrupti",
    "EmailName": "jon@crooks.name",
    "ContactFullName": "Vivienne Grant PhD",
    "ActiveErpLinks": 324,
    "TicketPriorityId": 314,
    "SupportLanguageId": 50,
    "SupportAssociateId": 935,
    "CategoryName": "VIP Customer"
  },
  "Person": {
    "Position": "mollitia",
    "PersonId": 345,
    "Mrmrs": "dolorum",
    "Firstname": "Myles",
    "Lastname": "Berge",
    "MiddleName": "Thiel-Pacocha",
    "Title": "nobis",
    "Description": "Re-contextualized secondary utilisation",
    "Email": "rogelio.huel@miller.biz",
    "FullName": "Joshuah Fadel",
    "DirectPhone": "084-703-5505 x4037",
    "FormalName": "Lueilwitz-Harber",
    "CountryId": 175,
    "ContactId": 188,
    "ContactName": "Zboncak LLC",
    "Retired": 48,
    "Rank": 192,
    "ActiveInterests": 921,
    "ContactDepartment": "monetize dot-com eyeballs",
    "ContactCountryId": 616,
    "ContactOrgNr": "973831",
    "FaxPhone": "1-338-185-2226 x252",
    "MobilePhone": "(627)312-8557 x288",
    "ContactPhone": "(034)635-0463",
    "AssociateName": "Medhurst-Stiedemann",
    "AssociateId": 85,
    "UsePersonAddress": false,
    "ContactFax": "quibusdam",
    "Kanafname": "mollitia",
    "Kanalname": "in",
    "Post1": "autem",
    "Post2": "libero",
    "Post3": "id",
    "EmailName": "niko.steuber@monahan.com",
    "ContactFullName": "Clinton Leffler",
    "ActiveErpLinks": 261,
    "TicketPriorityId": 769,
    "SupportLanguageId": 487,
    "SupportAssociateId": 248,
    "CategoryName": "VIP Customer"
  },
  "MotherId": 643,
  "Priority": {
    "Id": 448,
    "Value": "laborum",
    "Tooltip": "dolorem"
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 760,
    "Name": "Runte LLC",
    "Description": "Fully-configurable human-resource superstructure",
    "URL": "http://www.example.com/",
    "Type": "enim",
    "AssociateId": 54,
    "AssociateFullName": "Veda Farrell",
    "TypeId": 752,
    "Updated": "2005-08-30T09:40:58.6443443+02:00",
    "StatusId": 533,
    "Status": "voluptatibus",
    "TextId": 595,
    "PublishTo": "1995-09-04T09:40:58.6443443+02:00",
    "PublishFrom": "1999-11-24T09:40:58.6443443+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "555998",
    "ActiveErpLinks": 829
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2012-03-02T09:40:58.6443443+01:00",
  "Completed": "Completed",
  "ActiveLinks": 932,
  "Links": [
    {
      "EntityName": "Bednar Inc and Sons",
      "Id": 780,
      "Description": "Seamless zero tolerance algorithm",
      "ExtraInfo": "optio",
      "LinkId": 295
    },
    {
      "EntityName": "Bednar Inc and Sons",
      "Id": 780,
      "Description": "Seamless zero tolerance algorithm",
      "ExtraInfo": "optio",
      "LinkId": 295
    }
  ],
  "AlarmLeadTime": "magnam",
  "HasAlarm": false,
  "ColorIndex": 929,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "quaerat",
  "LeadTime": "architecto",
  "Location": "qui",
  "RejectCounter": 631,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 893,
    "StartDate": "2015-07-25T09:40:58.6443443+02:00",
    "EndDate": "2017-07-06T09:40:58.6443443+02:00",
    "RecurrenceCounter": 801,
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
      "AssociateId": 159,
      "PersonId": 353,
      "ContactId": 136,
      "EmailId": 102,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 159,
      "PersonId": 353,
      "ContactId": 136,
      "EmailId": 102,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2006-06-30T09:40:58.6443443+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 621,
    "Name": "Schumm, Parisian and Willms",
    "PersonId": 697,
    "Rank": 795,
    "Tooltip": "perferendis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 837,
    "FullName": "Afton Kertzmann",
    "FormalName": "Jast-Torphy",
    "Deleted": false,
    "EjUserId": 865,
    "UserName": "Mills Inc and Sons"
  },
  "MotherAssociate": {
    "AssociateId": 141,
    "Name": "Turcotte-Paucek",
    "PersonId": 829,
    "Rank": 482,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 745,
    "FullName": "Janelle Brown",
    "FormalName": "Bergnaum, Ebert and Frami",
    "Deleted": true,
    "EjUserId": 8,
    "UserName": "Kutch, Frami and Hammes"
  },
  "Task": {
    "TaskListItemId": 880,
    "Value": "distinctio",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "eos",
    "Deleted": false,
    "IntentId": 309,
    "Rank": 845,
    "IsDefaultAlldayEvent": true,
    "IsDefaultFree": false,
    "IsDefaultPublished": true,
    "ColorIndex": "BlueAlt1",
    "DefaultVideomeetingStatus": "NoChange"
  },
  "PreferredTZLocation": 869,
  "Sale": {
    "ContactName": "Hammes LLC",
    "SaleDate": "2018-09-22T09:40:58.6453712+02:00",
    "SaleId": 93,
    "Probability": 939,
    "Title": "sit",
    "Amount": 15196.766,
    "Currency": "cum",
    "ProjectName": "Johnston-Fadel",
    "AssociateFullName": "Marietta Trantow",
    "Description": "Focused 3rd generation knowledge base",
    "Status": "Lost",
    "WeightedAmount": 28585.214,
    "ProjectId": 410,
    "EarningPercent": 11106.895999999999,
    "Earning": 29951.638,
    "ContactId": 857,
    "AssociateId": 229,
    "PersonId": 627,
    "SaleTypeId": 675,
    "SaleTypeName": "Stracke-Keebler",
    "PersonFullName": "Kianna Pouros",
    "Completed": "Completed",
    "ActiveErpLinks": 132,
    "NextDueDate": "2017-01-02T09:40:58.6453712+01:00",
    "Number": "1172080"
  },
  "SuggestedAppointmentId": 574,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "est",
  "UserDefinedFields": {
    "SuperOffice:1": "1000853417",
    "SuperOffice:2": "Madge Ullrich"
  },
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "ut"
  },
  "PublishEventDate": "2001-10-15T09:40:58.6453712+02:00",
  "PublishTo": "1996-01-12T09:40:58.6453712+01:00",
  "PublishFrom": "2003-03-31T09:40:58.6453712+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 483,
      "Visibility": "All",
      "DisplayValue": "pariatur"
    },
    {
      "VisibleId": 483,
      "Visibility": "All",
      "DisplayValue": "pariatur"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "vitae",
  "2": "quo"
}
```