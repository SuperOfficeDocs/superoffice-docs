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
    "AssociateId": 93,
    "Name": "Kiehn-Gerlach",
    "PersonId": 733,
    "Rank": 710,
    "Tooltip": "impedit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 649,
    "FullName": "Elisabeth Rice",
    "FormalName": "Strosin, Dach and Considine",
    "Deleted": false,
    "EjUserId": 435,
    "UserName": "Greenholt Group"
  },
  "Contact": {
    "ContactId": 868,
    "Name": "Aufderhar LLC",
    "OrgNr": "1801116",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "alias",
    "DirectPhone": "(478)620-5282 x746",
    "AssociateId": 515,
    "CountryId": 34,
    "EmailAddress": "reba@mraz.co.uk",
    "Kananame": "est",
    "EmailAddressName": "joseph@ferryconnelly.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Sarai Greenfelder",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quibusdam",
    "FullName": "Sidney Walter",
    "IsOwnerContact": true,
    "ActiveErpLinks": 947
  },
  "CreatedBy": {
    "AssociateId": 62,
    "Name": "DuBuque Inc and Sons",
    "PersonId": 996,
    "Rank": 981,
    "Tooltip": "nemo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 560,
    "FullName": "Winifred Rohan",
    "FormalName": "Jaskolski-Johns",
    "Deleted": true,
    "EjUserId": 198,
    "UserName": "Franecki-Sipes"
  },
  "UpdatedBy": {
    "AssociateId": 846,
    "Name": "Larkin-Nolan",
    "PersonId": 430,
    "Rank": 527,
    "Tooltip": "hic",
    "Type": "AnonymousAssociate",
    "GroupIdx": 144,
    "FullName": "Merle Considine V",
    "FormalName": "Streich-Runolfsdottir",
    "Deleted": false,
    "EjUserId": 315,
    "UserName": "Bogan Group"
  },
  "CreatedDate": "2005-04-14T09:40:58.5993702+02:00",
  "AppointmentId": 884,
  "Description": "Horizontal bandwidth-monitored pricing structure",
  "StartDate": "2014-10-11T09:40:58.5993702+02:00",
  "EndDate": "2010-11-15T09:40:58.5993702+01:00",
  "InvitedPerson": {
    "Position": "eligendi",
    "PersonId": 266,
    "Mrmrs": "fugit",
    "Firstname": "Crystal",
    "Lastname": "Littel",
    "MiddleName": "Lynch, Mann and Klein",
    "Title": "ea",
    "Description": "Stand-alone full-range leverage",
    "Email": "lempi@steuber.ca",
    "FullName": "Ava Rogahn",
    "DirectPhone": "1-852-265-5348",
    "FormalName": "Bartell, Hegmann and Adams",
    "CountryId": 179,
    "ContactId": 206,
    "ContactName": "Stokes LLC",
    "Retired": 727,
    "Rank": 910,
    "ActiveInterests": 168,
    "ContactDepartment": "",
    "ContactCountryId": 91,
    "ContactOrgNr": "1302331",
    "FaxPhone": "751.863.0502",
    "MobilePhone": "(687)485-3557",
    "ContactPhone": "444.401.6317",
    "AssociateName": "Ferry, Roberts and Rogahn",
    "AssociateId": 301,
    "UsePersonAddress": true,
    "ContactFax": "nam",
    "Kanafname": "autem",
    "Kanalname": "molestiae",
    "Post1": "quia",
    "Post2": "recusandae",
    "Post3": "velit",
    "EmailName": "marcelino_cruickshank@kingbernhard.biz",
    "ContactFullName": "Ellis Heaney",
    "ActiveErpLinks": 905,
    "TicketPriorityId": 888,
    "SupportLanguageId": 720,
    "SupportAssociateId": 88,
    "CategoryName": "VIP Customer"
  },
  "Person": {
    "Position": "impedit",
    "PersonId": 655,
    "Mrmrs": "minus",
    "Firstname": "Manuel",
    "Lastname": "Leuschke",
    "MiddleName": "Vandervort LLC",
    "Title": "magnam",
    "Description": "Phased modular extranet",
    "Email": "ashlee_little@leannonstehr.info",
    "FullName": "Eldridge Parisian",
    "DirectPhone": "572-343-7340 x8641",
    "FormalName": "Barrows-Satterfield",
    "CountryId": 63,
    "ContactId": 199,
    "ContactName": "Bergstrom-Brown",
    "Retired": 595,
    "Rank": 257,
    "ActiveInterests": 133,
    "ContactDepartment": "",
    "ContactCountryId": 81,
    "ContactOrgNr": "1176670",
    "FaxPhone": "(860)084-5087 x62751",
    "MobilePhone": "(041)705-0144",
    "ContactPhone": "011.226.5115",
    "AssociateName": "Gerhold-Schimmel",
    "AssociateId": 441,
    "UsePersonAddress": false,
    "ContactFax": "ut",
    "Kanafname": "et",
    "Kanalname": "aut",
    "Post1": "inventore",
    "Post2": "animi",
    "Post3": "repellendus",
    "EmailName": "elmira_skiles@hilpertheller.ca",
    "ContactFullName": "Rodrigo Lebsack",
    "ActiveErpLinks": 494,
    "TicketPriorityId": 520,
    "SupportLanguageId": 278,
    "SupportAssociateId": 475,
    "CategoryName": "VIP Customer"
  },
  "MotherId": 60,
  "Priority": {
    "Id": 427,
    "Value": "modi",
    "Tooltip": "iure"
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 569,
    "Name": "Leannon, Ritchie and Gleason",
    "Description": "Down-sized 24 hour capability",
    "URL": "http://www.example.com/",
    "Type": "est",
    "AssociateId": 897,
    "AssociateFullName": "Minerva Smitham",
    "TypeId": 486,
    "Updated": "1998-12-28T09:40:58.6013679+01:00",
    "StatusId": 950,
    "Status": "odio",
    "TextId": 921,
    "PublishTo": "1996-10-29T09:40:58.6013679+01:00",
    "PublishFrom": "2014-09-24T09:40:58.6013679+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "483358",
    "ActiveErpLinks": 984
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2021-03-22T09:40:58.6013679+01:00",
  "Completed": "Completed",
  "ActiveLinks": 788,
  "Links": [
    {
      "EntityName": "Yost-Jacobs",
      "Id": 549,
      "Description": "Re-engineered transitional extranet",
      "ExtraInfo": "odit",
      "LinkId": 136
    },
    {
      "EntityName": "Yost-Jacobs",
      "Id": 549,
      "Description": "Re-engineered transitional extranet",
      "ExtraInfo": "odit",
      "LinkId": 136
    }
  ],
  "AlarmLeadTime": "eligendi",
  "HasAlarm": true,
  "ColorIndex": 801,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "quidem",
  "LeadTime": "laborum",
  "Location": "suscipit",
  "RejectCounter": 952,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 416,
    "StartDate": "2012-03-08T09:40:58.6013679+01:00",
    "EndDate": "1995-11-24T09:40:58.6013679+01:00",
    "RecurrenceCounter": 320,
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
      "AssociateId": 10,
      "PersonId": 516,
      "ContactId": 35,
      "EmailId": 350,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 10,
      "PersonId": 516,
      "ContactId": 35,
      "EmailId": 350,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2007-07-30T09:40:58.6013679+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 782,
    "Name": "Jaskolski Inc and Sons",
    "PersonId": 221,
    "Rank": 25,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 868,
    "FullName": "Aimee Dickinson",
    "FormalName": "Bashirian Group",
    "Deleted": true,
    "EjUserId": 408,
    "UserName": "Ziemann, Hane and Schuppe"
  },
  "MotherAssociate": {
    "AssociateId": 419,
    "Name": "Davis-Wyman",
    "PersonId": 452,
    "Rank": 690,
    "Tooltip": "eum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 997,
    "FullName": "Ms. Kayley Nitzsche",
    "FormalName": "Emard Inc and Sons",
    "Deleted": false,
    "EjUserId": 715,
    "UserName": "Stiedemann, Stanton and McCullough"
  },
  "Task": {
    "TaskListItemId": 496,
    "Value": "enim",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "optio",
    "Deleted": false,
    "IntentId": 505,
    "Rank": 839,
    "IsDefaultAlldayEvent": false,
    "IsDefaultFree": false,
    "IsDefaultPublished": false,
    "ColorIndex": "BlueAlt1",
    "DefaultVideomeetingStatus": "NoChange"
  },
  "PreferredTZLocation": 575,
  "Sale": {
    "ContactName": "Reilly, Baumbach and Hartmann",
    "SaleDate": "2009-06-08T09:40:58.6023773+02:00",
    "SaleId": 906,
    "Probability": 768,
    "Title": "qui",
    "Amount": 27466.376,
    "Currency": "exercitationem",
    "ProjectName": "Goyette LLC",
    "AssociateFullName": "Keshaun Waelchi",
    "Description": "Public-key bifurcated budgetary management",
    "Status": "Lost",
    "WeightedAmount": 11652.212,
    "ProjectId": 345,
    "EarningPercent": 26262.92,
    "Earning": 12476.454,
    "ContactId": 613,
    "AssociateId": 592,
    "PersonId": 597,
    "SaleTypeId": 755,
    "SaleTypeName": "Dooley Group",
    "PersonFullName": "Peyton Altenwerth",
    "Completed": "Completed",
    "ActiveErpLinks": 517,
    "NextDueDate": "2017-01-30T09:40:58.6033732+01:00",
    "Number": "663857"
  },
  "SuggestedAppointmentId": 827,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "in",
  "UserDefinedFields": {
    "SuperOffice:1": "476580805",
    "SuperOffice:2": "Winona Harris"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "ex"
  },
  "CustomFields": {
    "CustomFields1": "dolores",
    "CustomFields2": "exercitationem"
  },
  "PublishEventDate": "2016-06-01T09:40:58.6033732+02:00",
  "PublishTo": "1996-12-01T09:40:58.6033732+01:00",
  "PublishFrom": "2003-09-02T09:40:58.6033732+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 719,
      "Visibility": "All",
      "DisplayValue": "atque"
    },
    {
      "VisibleId": 719,
      "Visibility": "All",
      "DisplayValue": "atque"
    }
  ]
}
```

```http_
HTTP/1.1 200 AppointmentEntity updated.
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 59,
    "Name": "Gutkowski LLC",
    "PersonId": 226,
    "Rank": 88,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 740,
    "FullName": "Pearl Steuber",
    "FormalName": "Bahringer, Lockman and Terry",
    "Deleted": true,
    "EjUserId": 868,
    "UserName": "Abshire, Haag and Luettgen",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 596
      }
    }
  },
  "Contact": {
    "ContactId": 1001,
    "Name": "Hermann, Jacobs and Kuhlman",
    "OrgNr": "649387",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "explicabo",
    "DirectPhone": "1-233-235-2863 x5708",
    "AssociateId": 511,
    "CountryId": 976,
    "EmailAddress": "nestor_botsford@bayer.biz",
    "Kananame": "suscipit",
    "EmailAddressName": "lue@gleichnerhansen.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Armando Lehner II",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "sint",
    "FullName": "Ubaldo Pouros",
    "IsOwnerContact": true,
    "ActiveErpLinks": 229,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 480
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 983,
    "Name": "Stokes Group",
    "PersonId": 136,
    "Rank": 2,
    "Tooltip": "quaerat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 969,
    "FullName": "Dasia Fahey",
    "FormalName": "Grant LLC",
    "Deleted": true,
    "EjUserId": 321,
    "UserName": "Waelchi-Spinka",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 836
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 565,
    "Name": "Corkery LLC",
    "PersonId": 265,
    "Rank": 97,
    "Tooltip": "necessitatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 71,
    "FullName": "Jermain Hickle",
    "FormalName": "Klein Inc and Sons",
    "Deleted": false,
    "EjUserId": 693,
    "UserName": "Bogisich-Pagac",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 110
      }
    }
  },
  "CreatedDate": "2017-09-01T09:40:58.6123707+02:00",
  "AppointmentId": 32,
  "Description": "Programmable encompassing model",
  "StartDate": "2021-02-02T09:40:58.6123707+01:00",
  "EndDate": "2006-10-25T09:40:58.6123707+02:00",
  "InvitedPerson": {
    "Position": "quasi",
    "PersonId": 573,
    "Mrmrs": "porro",
    "Firstname": "Marianne",
    "Lastname": "Mayer",
    "MiddleName": "Zulauf, Hegmann and Hilll",
    "Title": "qui",
    "Description": "Synergistic object-oriented benchmark",
    "Email": "leopold.grady@smitham.info",
    "FullName": "Naomie Koss",
    "DirectPhone": "1-084-108-5255",
    "FormalName": "Considine-Bruen",
    "CountryId": 489,
    "ContactId": 89,
    "ContactName": "Jacobs LLC",
    "Retired": 586,
    "Rank": 247,
    "ActiveInterests": 399,
    "ContactDepartment": "",
    "ContactCountryId": 751,
    "ContactOrgNr": "1347240",
    "FaxPhone": "1-208-638-1370 x7107",
    "MobilePhone": "1-342-071-7673",
    "ContactPhone": "126-117-5364 x37158",
    "AssociateName": "Parisian, Beahan and Lehner",
    "AssociateId": 257,
    "UsePersonAddress": false,
    "ContactFax": "earum",
    "Kanafname": "ea",
    "Kanalname": "impedit",
    "Post1": "omnis",
    "Post2": "ut",
    "Post3": "eum",
    "EmailName": "reed_quigley@simoniswunsch.ca",
    "ContactFullName": "Chad Spinka",
    "ActiveErpLinks": 53,
    "TicketPriorityId": 657,
    "SupportLanguageId": 161,
    "SupportAssociateId": 410,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 704
      }
    }
  },
  "Person": {
    "Position": "eos",
    "PersonId": 311,
    "Mrmrs": "quis",
    "Firstname": "Oliver",
    "Lastname": "Roob",
    "MiddleName": "Brekke, Stracke and Schiller",
    "Title": "fugit",
    "Description": "Focused high-level internet solution",
    "Email": "vicente_barton@lowe.info",
    "FullName": "Avis Veum",
    "DirectPhone": "1-227-025-7223 x6880",
    "FormalName": "Padberg, Weissnat and Turner",
    "CountryId": 732,
    "ContactId": 759,
    "ContactName": "Mraz LLC",
    "Retired": 976,
    "Rank": 542,
    "ActiveInterests": 89,
    "ContactDepartment": "",
    "ContactCountryId": 741,
    "ContactOrgNr": "956216",
    "FaxPhone": "1-170-470-6844 x12320",
    "MobilePhone": "1-160-753-1556",
    "ContactPhone": "421-077-4407 x40518",
    "AssociateName": "Gibson Group",
    "AssociateId": 397,
    "UsePersonAddress": true,
    "ContactFax": "sint",
    "Kanafname": "voluptatem",
    "Kanalname": "eum",
    "Post1": "quis",
    "Post2": "nihil",
    "Post3": "at",
    "EmailName": "damaris@rempel.uk",
    "ContactFullName": "Isidro Wiza",
    "ActiveErpLinks": 761,
    "TicketPriorityId": 951,
    "SupportLanguageId": 265,
    "SupportAssociateId": 621,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 683
      }
    }
  },
  "MotherId": 106,
  "Priority": {
    "Id": 893,
    "Value": "aliquam",
    "Tooltip": "consequuntur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 999
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 81,
    "Name": "Paucek LLC",
    "Description": "Managed needs-based throughput",
    "URL": "http://www.example.com/",
    "Type": "sapiente",
    "AssociateId": 221,
    "AssociateFullName": "Richard Mayer",
    "TypeId": 948,
    "Updated": "2015-04-15T09:40:58.6153737+02:00",
    "StatusId": 951,
    "Status": "soluta",
    "TextId": 702,
    "PublishTo": "2008-10-22T09:40:58.6153737+02:00",
    "PublishFrom": "1994-09-18T09:40:58.6153737+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1322028",
    "ActiveErpLinks": 816,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 99
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2009-01-11T09:40:58.6153737+01:00",
  "Completed": "Completed",
  "ActiveLinks": 437,
  "Links": [
    {
      "EntityName": "Hills, Schowalter and Bins",
      "Id": 583,
      "Description": "Streamlined upward-trending moratorium",
      "ExtraInfo": "tempore",
      "LinkId": 463,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 311
        }
      }
    }
  ],
  "AlarmLeadTime": "quia",
  "HasAlarm": true,
  "ColorIndex": 605,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "perferendis",
  "LeadTime": "ut",
  "Location": "natus",
  "RejectCounter": 95,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 303,
    "StartDate": "2001-06-16T09:40:58.6153737+02:00",
    "EndDate": "2000-01-18T09:40:58.6153737+01:00",
    "RecurrenceCounter": 487,
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
      "AssociateId": 410,
      "PersonId": 878,
      "ContactId": 986,
      "EmailId": 847,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 410,
      "PersonId": 878,
      "ContactId": 986,
      "EmailId": 847,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2005-10-11T09:40:58.6163762+02:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 863,
    "Name": "Heidenreich Group",
    "PersonId": 815,
    "Rank": 844,
    "Tooltip": "saepe",
    "Type": "AnonymousAssociate",
    "GroupIdx": 355,
    "FullName": "Beau Balistreri",
    "FormalName": "Sipes LLC",
    "Deleted": false,
    "EjUserId": 951,
    "UserName": "O'Reilly, Ortiz and Huel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 445
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 759,
    "Name": "Romaguera-Langworth",
    "PersonId": 625,
    "Rank": 415,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 806,
    "FullName": "Genesis Upton",
    "FormalName": "Crona, Kuphal and Cartwright",
    "Deleted": true,
    "EjUserId": 159,
    "UserName": "Will, Marks and Weissnat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 457
      }
    }
  },
  "Task": {
    "TaskListItemId": 900,
    "Value": "totam",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "quis",
    "Deleted": true,
    "IntentId": 963,
    "Rank": 139,
    "IsDefaultAlldayEvent": false,
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
        "FieldLength": 338
      }
    }
  },
  "PreferredTZLocation": 42,
  "Sale": {
    "ContactName": "Labadie, Cummings and Glover",
    "SaleDate": "2007-04-13T09:40:58.6163762+02:00",
    "SaleId": 714,
    "Probability": 527,
    "Title": "amet",
    "Amount": 13328.902,
    "Currency": "minima",
    "ProjectName": "Williamson LLC",
    "AssociateFullName": "Daren Franecki",
    "Description": "Multi-tiered radical intranet",
    "Status": "Lost",
    "WeightedAmount": 6161.4439999999995,
    "ProjectId": 365,
    "EarningPercent": 4547.434,
    "Earning": 15431.815999999999,
    "ContactId": 322,
    "AssociateId": 76,
    "PersonId": 735,
    "SaleTypeId": 998,
    "SaleTypeName": "Berge, Tromp and Jacobs",
    "PersonFullName": "Gina Von",
    "Completed": "Completed",
    "ActiveErpLinks": 49,
    "NextDueDate": "2000-03-18T09:40:58.6173741+01:00",
    "Number": "982143",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 697
      }
    }
  },
  "SuggestedAppointmentId": 552,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "nisi",
  "UserDefinedFields": {
    "SuperOffice:1": "Jewel Vandervort",
    "SuperOffice:2": "Agustina Hudson III"
  },
  "ExtraFields": {
    "ExtraFields1": "consectetur",
    "ExtraFields2": "magnam"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "sed"
  },
  "PublishEventDate": "1999-03-22T09:40:58.6173741+01:00",
  "PublishTo": "2020-05-09T09:40:58.6173741+02:00",
  "PublishFrom": "2015-10-09T09:40:58.6173741+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 658,
      "Visibility": "All",
      "DisplayValue": "distinctio",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 443
        }
      }
    },
    {
      "VisibleId": 658,
      "Visibility": "All",
      "DisplayValue": "distinctio",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 443
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
        "Reason": "leverage granular e-business"
      },
      "FieldType": "System.String",
      "FieldLength": 80
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```