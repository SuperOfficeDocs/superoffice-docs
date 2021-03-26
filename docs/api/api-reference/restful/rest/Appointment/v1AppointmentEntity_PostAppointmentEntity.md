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
    "AssociateId": 3,
    "Name": "Crooks-Swaniawski",
    "PersonId": 241,
    "Rank": 402,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 107,
    "FullName": "Ophelia Blick",
    "FormalName": "Baumbach-Kshlerin",
    "Deleted": true,
    "EjUserId": 984,
    "UserName": "Marquardt LLC"
  },
  "Contact": {
    "ContactId": 578,
    "Name": "Rogahn Inc and Sons",
    "OrgNr": "982314",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "atque",
    "DirectPhone": "1-047-274-6310",
    "AssociateId": 850,
    "CountryId": 124,
    "EmailAddress": "jaqueline_larkin@terry.info",
    "Kananame": "autem",
    "EmailAddressName": "herminia@jenkinsrobel.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Kurt Ankunding",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "et",
    "FullName": "Era Fahey",
    "IsOwnerContact": true,
    "ActiveErpLinks": 246
  },
  "CreatedBy": {
    "AssociateId": 6,
    "Name": "Marvin-Cremin",
    "PersonId": 518,
    "Rank": 778,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 156,
    "FullName": "Lennie Klocko",
    "FormalName": "Beatty-Kub",
    "Deleted": true,
    "EjUserId": 660,
    "UserName": "Terry, Johnston and Bergstrom"
  },
  "UpdatedBy": {
    "AssociateId": 979,
    "Name": "Eichmann, Koss and Skiles",
    "PersonId": 422,
    "Rank": 71,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 804,
    "FullName": "Merle Altenwerth",
    "FormalName": "O'Kon Inc and Sons",
    "Deleted": true,
    "EjUserId": 974,
    "UserName": "Conn LLC"
  },
  "CreatedDate": "2001-04-10T09:40:58.5283408+02:00",
  "AppointmentId": 327,
  "Description": "Cross-platform impactful moderator",
  "StartDate": "2012-08-11T09:40:58.5283408+02:00",
  "EndDate": "2005-03-15T09:40:58.5283408+01:00",
  "InvitedPerson": {
    "Position": "iste",
    "PersonId": 184,
    "Mrmrs": "itaque",
    "Firstname": "Issac",
    "Lastname": "Trantow",
    "MiddleName": "Bayer, Weissnat and Bartoletti",
    "Title": "id",
    "Description": "Object-based next generation projection",
    "Email": "pearl.fisher@homenickgoldner.name",
    "FullName": "Titus Howell",
    "DirectPhone": "732.660.8657 x65362",
    "FormalName": "Weimann-Batz",
    "CountryId": 535,
    "ContactId": 86,
    "ContactName": "Larson Inc and Sons",
    "Retired": 718,
    "Rank": 614,
    "ActiveInterests": 75,
    "ContactDepartment": "",
    "ContactCountryId": 284,
    "ContactOrgNr": "561275",
    "FaxPhone": "008.065.2344 x810",
    "MobilePhone": "487-178-1328",
    "ContactPhone": "051.606.4326",
    "AssociateName": "Jenkins-Ondricka",
    "AssociateId": 531,
    "UsePersonAddress": false,
    "ContactFax": "distinctio",
    "Kanafname": "similique",
    "Kanalname": "suscipit",
    "Post1": "optio",
    "Post2": "sit",
    "Post3": "magni",
    "EmailName": "emery@mooreromaguera.co.uk",
    "ContactFullName": "Macie Altenwerth",
    "ActiveErpLinks": 112,
    "TicketPriorityId": 698,
    "SupportLanguageId": 460,
    "SupportAssociateId": 817,
    "CategoryName": "VIP Customer"
  },
  "Person": {
    "Position": "nulla",
    "PersonId": 777,
    "Mrmrs": "maiores",
    "Firstname": "Jasmin",
    "Lastname": "Davis",
    "MiddleName": "Wiza-Grant",
    "Title": "vel",
    "Description": "Re-engineered system-worthy algorithm",
    "Email": "tad.kunde@marquardt.name",
    "FullName": "Nash Jacobs DVM",
    "DirectPhone": "(758)464-4441 x68440",
    "FormalName": "Feeney, Armstrong and Collins",
    "CountryId": 654,
    "ContactId": 885,
    "ContactName": "Bogan Inc and Sons",
    "Retired": 579,
    "Rank": 243,
    "ActiveInterests": 528,
    "ContactDepartment": "",
    "ContactCountryId": 895,
    "ContactOrgNr": "344103",
    "FaxPhone": "(161)657-8242",
    "MobilePhone": "(777)048-0862 x286",
    "ContactPhone": "(684)065-3857 x632",
    "AssociateName": "Jakubowski Inc and Sons",
    "AssociateId": 807,
    "UsePersonAddress": true,
    "ContactFax": "harum",
    "Kanafname": "voluptate",
    "Kanalname": "quia",
    "Post1": "dolorem",
    "Post2": "sit",
    "Post3": "consequatur",
    "EmailName": "nicklaus.frami@stamm.name",
    "ContactFullName": "Boris Wolf",
    "ActiveErpLinks": 161,
    "TicketPriorityId": 89,
    "SupportLanguageId": 313,
    "SupportAssociateId": 146,
    "CategoryName": "VIP Customer"
  },
  "MotherId": 695,
  "Priority": {
    "Id": 846,
    "Value": "optio",
    "Tooltip": "numquam"
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 102,
    "Name": "Herzog Inc and Sons",
    "Description": "Fundamental zero defect software",
    "URL": "http://www.example.com/",
    "Type": "nesciunt",
    "AssociateId": 389,
    "AssociateFullName": "Tessie Abernathy",
    "TypeId": 944,
    "Updated": "2019-08-30T09:40:58.530343+02:00",
    "StatusId": 413,
    "Status": "omnis",
    "TextId": 490,
    "PublishTo": "2014-11-08T09:40:58.530343+01:00",
    "PublishFrom": "1994-09-16T09:40:58.530343+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "477603",
    "ActiveErpLinks": 608
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "1996-12-11T09:40:58.530343+01:00",
  "Completed": "Completed",
  "ActiveLinks": 979,
  "Links": [
    {
      "EntityName": "Schumm, Hegmann and Okuneva",
      "Id": 383,
      "Description": "Front-line zero administration hub",
      "ExtraInfo": "eos",
      "LinkId": 334
    },
    {
      "EntityName": "Schumm, Hegmann and Okuneva",
      "Id": 383,
      "Description": "Front-line zero administration hub",
      "ExtraInfo": "eos",
      "LinkId": 334
    }
  ],
  "AlarmLeadTime": "eos",
  "HasAlarm": false,
  "ColorIndex": 591,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "sed",
  "LeadTime": "et",
  "Location": "ratione",
  "RejectCounter": 974,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 405,
    "StartDate": "2005-02-01T09:40:58.5313723+01:00",
    "EndDate": "2020-01-24T09:40:58.5313723+01:00",
    "RecurrenceCounter": 113,
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
      "AssociateId": 713,
      "PersonId": 814,
      "ContactId": 492,
      "EmailId": 572,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 713,
      "PersonId": 814,
      "ContactId": 492,
      "EmailId": 572,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1995-01-18T09:40:58.5313723+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 412,
    "Name": "Dooley Inc and Sons",
    "PersonId": 550,
    "Rank": 642,
    "Tooltip": "odio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 686,
    "FullName": "Karli Rau",
    "FormalName": "Hintz, Padberg and Wolff",
    "Deleted": false,
    "EjUserId": 932,
    "UserName": "Torphy-Ondricka"
  },
  "MotherAssociate": {
    "AssociateId": 238,
    "Name": "Beatty LLC",
    "PersonId": 20,
    "Rank": 861,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 554,
    "FullName": "Vicenta Rippin",
    "FormalName": "Schaden, Grimes and Bauch",
    "Deleted": true,
    "EjUserId": 201,
    "UserName": "Walsh LLC"
  },
  "Task": {
    "TaskListItemId": 218,
    "Value": "omnis",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "facilis",
    "Deleted": false,
    "IntentId": 155,
    "Rank": 614,
    "IsDefaultAlldayEvent": true,
    "IsDefaultFree": false,
    "IsDefaultPublished": false,
    "ColorIndex": "BlueAlt1",
    "DefaultVideomeetingStatus": "NoChange"
  },
  "PreferredTZLocation": 79,
  "Sale": {
    "ContactName": "Bechtelar-Leffler",
    "SaleDate": "1997-07-19T09:40:58.5323729+02:00",
    "SaleId": 118,
    "Probability": 943,
    "Title": "possimus",
    "Amount": 29190.075999999997,
    "Currency": "necessitatibus",
    "ProjectName": "Pagac, Leffler and Considine",
    "AssociateFullName": "Myrtle Senger",
    "Description": "Configurable regional open system",
    "Status": "Lost",
    "WeightedAmount": 23793.327999999998,
    "ProjectId": 327,
    "EarningPercent": 1335.084,
    "Earning": 20430.546,
    "ContactId": 401,
    "AssociateId": 865,
    "PersonId": 853,
    "SaleTypeId": 992,
    "SaleTypeName": "Upton, Fisher and Windler",
    "PersonFullName": "Caleb Quitzon",
    "Completed": "Completed",
    "ActiveErpLinks": 296,
    "NextDueDate": "2013-09-17T09:40:58.5323729+02:00",
    "Number": "216652"
  },
  "SuggestedAppointmentId": 972,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "labore",
  "UserDefinedFields": {
    "SuperOffice:1": "1006951167",
    "SuperOffice:2": "15429593"
  },
  "ExtraFields": {
    "ExtraFields1": "assumenda",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "nostrum",
    "CustomFields2": "qui"
  },
  "PublishEventDate": "2008-07-03T09:40:58.5323729+02:00",
  "PublishTo": "2006-05-15T09:40:58.5323729+02:00",
  "PublishFrom": "2015-07-31T09:40:58.5323729+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 942,
      "Visibility": "All",
      "DisplayValue": "odio"
    },
    {
      "VisibleId": 942,
      "Visibility": "All",
      "DisplayValue": "odio"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 377,
    "Name": "Nikolaus, Parker and Carroll",
    "PersonId": 969,
    "Rank": 346,
    "Tooltip": "voluptates",
    "Type": "AnonymousAssociate",
    "GroupIdx": 161,
    "FullName": "Derick Gorczany",
    "FormalName": "Mills-Ebert",
    "Deleted": false,
    "EjUserId": 830,
    "UserName": "Walker Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 897
      }
    }
  },
  "Contact": {
    "ContactId": 359,
    "Name": "Murray-Johns",
    "OrgNr": "1151933",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ea",
    "DirectPhone": "468.360.3522 x3303",
    "AssociateId": 491,
    "CountryId": 227,
    "EmailAddress": "tony@hyatt.ca",
    "Kananame": "eius",
    "EmailAddressName": "morgan_kuhlman@rippin.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ayden Kunde",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quam",
    "FullName": "Rosanna Macejkovic",
    "IsOwnerContact": true,
    "ActiveErpLinks": 792,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 579
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 233,
    "Name": "Kuvalis, Cummings and Bruen",
    "PersonId": 185,
    "Rank": 962,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 766,
    "FullName": "Adah Gerlach",
    "FormalName": "Rohan, Langworth and Klocko",
    "Deleted": false,
    "EjUserId": 477,
    "UserName": "Gutkowski Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 393
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 838,
    "Name": "Schoen Group",
    "PersonId": 746,
    "Rank": 647,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 341,
    "FullName": "Nathan O'Conner",
    "FormalName": "Bechtelar, Dickinson and Schuppe",
    "Deleted": true,
    "EjUserId": 623,
    "UserName": "McDermott-Nikolaus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 894
      }
    }
  },
  "CreatedDate": "2007-11-02T09:40:58.5773703+01:00",
  "AppointmentId": 267,
  "Description": "Up-sized user-facing approach",
  "StartDate": "2012-01-22T09:40:58.5773703+01:00",
  "EndDate": "2006-08-26T09:40:58.5773703+02:00",
  "InvitedPerson": {
    "Position": "quia",
    "PersonId": 650,
    "Mrmrs": "delectus",
    "Firstname": "Aiyana",
    "Lastname": "Cremin",
    "MiddleName": "Pacocha, Herzog and Jaskolski",
    "Title": "quo",
    "Description": "Upgradable incremental data-warehouse",
    "Email": "cesar@effertzfeest.info",
    "FullName": "Mike Legros PhD",
    "DirectPhone": "(175)522-1773 x07044",
    "FormalName": "Gottlieb, Tromp and Harber",
    "CountryId": 156,
    "ContactId": 960,
    "ContactName": "Abshire, Schuppe and Ruecker",
    "Retired": 678,
    "Rank": 124,
    "ActiveInterests": 298,
    "ContactDepartment": "",
    "ContactCountryId": 929,
    "ContactOrgNr": "1498580",
    "FaxPhone": "1-188-061-6406",
    "MobilePhone": "(023)668-8716 x81777",
    "ContactPhone": "087.844.6744 x846",
    "AssociateName": "O'Hara-Tillman",
    "AssociateId": 289,
    "UsePersonAddress": true,
    "ContactFax": "ducimus",
    "Kanafname": "vel",
    "Kanalname": "explicabo",
    "Post1": "aut",
    "Post2": "et",
    "Post3": "vel",
    "EmailName": "chet@lueilwitz.com",
    "ContactFullName": "German Kuhic",
    "ActiveErpLinks": 581,
    "TicketPriorityId": 547,
    "SupportLanguageId": 275,
    "SupportAssociateId": 222,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 584
      }
    }
  },
  "Person": {
    "Position": "aut",
    "PersonId": 899,
    "Mrmrs": "doloremque",
    "Firstname": "Heath",
    "Lastname": "Gusikowski",
    "MiddleName": "Hettinger, Satterfield and Tremblay",
    "Title": "nesciunt",
    "Description": "Front-line local monitoring",
    "Email": "mertie@dooley.biz",
    "FullName": "Noelia Halvorson",
    "DirectPhone": "(602)050-7328 x31427",
    "FormalName": "Jones Group",
    "CountryId": 27,
    "ContactId": 331,
    "ContactName": "Wolff LLC",
    "Retired": 782,
    "Rank": 290,
    "ActiveInterests": 691,
    "ContactDepartment": "",
    "ContactCountryId": 568,
    "ContactOrgNr": "1302612",
    "FaxPhone": "864.550.6223",
    "MobilePhone": "1-260-528-1725 x68564",
    "ContactPhone": "781.138.4338 x621",
    "AssociateName": "Murazik, Ratke and Wilkinson",
    "AssociateId": 365,
    "UsePersonAddress": false,
    "ContactFax": "est",
    "Kanafname": "blanditiis",
    "Kanalname": "quam",
    "Post1": "beatae",
    "Post2": "et",
    "Post3": "sapiente",
    "EmailName": "bridget.torp@champlin.uk",
    "ContactFullName": "Crystal Reichert",
    "ActiveErpLinks": 131,
    "TicketPriorityId": 339,
    "SupportLanguageId": 250,
    "SupportAssociateId": 906,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 22
      }
    }
  },
  "MotherId": 35,
  "Priority": {
    "Id": 230,
    "Value": "et",
    "Tooltip": "beatae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 297
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 766,
    "Name": "Purdy Group",
    "Description": "Triple-buffered attitude-oriented orchestration",
    "URL": "http://www.example.com/",
    "Type": "quia",
    "AssociateId": 588,
    "AssociateFullName": "Sebastian Gulgowski",
    "TypeId": 658,
    "Updated": "1994-10-29T09:40:58.5803742+02:00",
    "StatusId": 598,
    "Status": "tempore",
    "TextId": 516,
    "PublishTo": "2008-03-25T09:40:58.5803742+01:00",
    "PublishFrom": "2005-11-23T09:40:58.5803742+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "915428",
    "ActiveErpLinks": 733,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 810
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "1997-08-06T09:40:58.5803742+02:00",
  "Completed": "Completed",
  "ActiveLinks": 195,
  "Links": [
    {
      "EntityName": "King-Medhurst",
      "Id": 424,
      "Description": "Intuitive encompassing project",
      "ExtraInfo": "nam",
      "LinkId": 676,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 795
        }
      }
    }
  ],
  "AlarmLeadTime": "ut",
  "HasAlarm": true,
  "ColorIndex": 378,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "exercitationem",
  "LeadTime": "voluptates",
  "Location": "sed",
  "RejectCounter": 204,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 94,
    "StartDate": "2020-01-15T09:40:58.5803742+01:00",
    "EndDate": "2007-02-17T09:40:58.5803742+01:00",
    "RecurrenceCounter": 725,
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
      "AssociateId": 207,
      "PersonId": 372,
      "ContactId": 175,
      "EmailId": 719,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 207,
      "PersonId": 372,
      "ContactId": 175,
      "EmailId": 719,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1999-09-01T09:40:58.5803742+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 380,
    "Name": "Lueilwitz, Rau and Hansen",
    "PersonId": 434,
    "Rank": 273,
    "Tooltip": "quis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 452,
    "FullName": "Halie Donnelly",
    "FormalName": "Durgan Group",
    "Deleted": false,
    "EjUserId": 161,
    "UserName": "Schimmel, Osinski and Anderson",
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
  "MotherAssociate": {
    "AssociateId": 267,
    "Name": "Grant-Jacobi",
    "PersonId": 913,
    "Rank": 122,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 36,
    "FullName": "Michel Boehm",
    "FormalName": "Hills-Hackett",
    "Deleted": false,
    "EjUserId": 757,
    "UserName": "Ruecker, Larson and Denesik",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 931
      }
    }
  },
  "Task": {
    "TaskListItemId": 79,
    "Value": "impedit",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "voluptatem",
    "Deleted": false,
    "IntentId": 7,
    "Rank": 504,
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
        "FieldLength": 477
      }
    }
  },
  "PreferredTZLocation": 907,
  "Sale": {
    "ContactName": "Gaylord LLC",
    "SaleDate": "2011-04-25T09:40:58.5813704+02:00",
    "SaleId": 455,
    "Probability": 2,
    "Title": "perspiciatis",
    "Amount": 4359.394,
    "Currency": "inventore",
    "ProjectName": "Cassin-Wunsch",
    "AssociateFullName": "Dr. Blair Jacobs",
    "Description": "Enterprise-wide client-server open system",
    "Status": "Lost",
    "WeightedAmount": 14005.846,
    "ProjectId": 869,
    "EarningPercent": 7038.964,
    "Earning": 23028.631999999998,
    "ContactId": 218,
    "AssociateId": 121,
    "PersonId": 908,
    "SaleTypeId": 151,
    "SaleTypeName": "Hartmann-DuBuque",
    "PersonFullName": "Rozella Schuppe",
    "Completed": "Completed",
    "ActiveErpLinks": 346,
    "NextDueDate": "2009-02-26T09:40:58.5813704+01:00",
    "Number": "1142716",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 444
      }
    }
  },
  "SuggestedAppointmentId": 477,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "ut",
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Ramiro Lueilwitz"
  },
  "ExtraFields": {
    "ExtraFields1": "porro",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "doloribus",
    "CustomFields2": "est"
  },
  "PublishEventDate": "2010-03-07T09:40:58.5823708+01:00",
  "PublishTo": "2000-06-19T09:40:58.5823708+02:00",
  "PublishFrom": "2017-09-15T09:40:58.5823708+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 647,
      "Visibility": "All",
      "DisplayValue": "iusto",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 524
        }
      }
    },
    {
      "VisibleId": 647,
      "Visibility": "All",
      "DisplayValue": "iusto",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 524
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
      "FieldLength": 939
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```