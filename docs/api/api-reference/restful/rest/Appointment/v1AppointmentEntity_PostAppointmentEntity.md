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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 857,
    "Name": "Hessel, Carroll and Nader",
    "PersonId": 209,
    "Rank": 398,
    "Tooltip": "maiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 700,
    "FullName": "Sally Hansen",
    "FormalName": "Emard, Ankunding and Schuppe",
    "Deleted": false,
    "EjUserId": 745,
    "UserName": "Hudson-Ebert"
  },
  "Contact": {
    "ContactId": 342,
    "Name": "Hahn, Schaefer and Hoppe",
    "OrgNr": "1153389",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "qui",
    "DirectPhone": "1-303-326-5342",
    "AssociateId": 885,
    "CountryId": 567,
    "EmailAddress": "hudson@streichlakin.biz",
    "Kananame": "sint",
    "EmailAddressName": "jalon_bahringer@hammesjohnson.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Miss Morgan Carter",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ut",
    "FullName": "Morgan Shields",
    "IsOwnerContact": false,
    "ActiveErpLinks": 552
  },
  "CreatedBy": {
    "AssociateId": 258,
    "Name": "Cassin Group",
    "PersonId": 887,
    "Rank": 459,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 745,
    "FullName": "Rebeka Powlowski",
    "FormalName": "Turner-Renner",
    "Deleted": false,
    "EjUserId": 335,
    "UserName": "Beahan-White"
  },
  "UpdatedBy": {
    "AssociateId": 250,
    "Name": "Heaney-Stroman",
    "PersonId": 596,
    "Rank": 765,
    "Tooltip": "molestias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 913,
    "FullName": "Dr. Chanelle Osinski",
    "FormalName": "Konopelski, Mertz and Torp",
    "Deleted": false,
    "EjUserId": 215,
    "UserName": "Bernhard Inc and Sons"
  },
  "CreatedDate": "2018-12-10T15:05:41.4980027+01:00",
  "AppointmentId": 839,
  "Description": "Assimilated holistic methodology",
  "StartDate": "1999-07-15T15:05:41.4980027+02:00",
  "EndDate": "1996-03-09T15:05:41.4980027+01:00",
  "InvitedPerson": {
    "Position": "praesentium",
    "PersonId": 538,
    "Mrmrs": "aut",
    "Firstname": "Hyman",
    "Lastname": "Sauer",
    "MiddleName": "Green, Powlowski and Buckridge",
    "Title": "vel",
    "Description": "Streamlined upward-trending success",
    "Email": "wilber.gerlach@kilbackschmitt.info",
    "FullName": "Chaya Hodkiewicz",
    "DirectPhone": "052-465-4535",
    "FormalName": "Huels-Pfannerstill",
    "CountryId": 600,
    "ContactId": 597,
    "ContactName": "Boyle, Greenholt and Gerhold",
    "Retired": 437,
    "Rank": 179,
    "ActiveInterests": 946,
    "ContactDepartment": "",
    "ContactCountryId": 495,
    "ContactOrgNr": "1083857",
    "FaxPhone": "856.670.4863 x601",
    "MobilePhone": "1-348-265-6786",
    "ContactPhone": "880-007-8105 x8677",
    "AssociateName": "Cormier-Murray",
    "AssociateId": 867,
    "UsePersonAddress": true,
    "ContactFax": "incidunt",
    "Kanafname": "sed",
    "Kanalname": "dignissimos",
    "Post1": "dolor",
    "Post2": "aut",
    "Post3": "explicabo",
    "EmailName": "vivienne.upton@kovacek.biz",
    "ContactFullName": "Nikolas Upton",
    "ActiveErpLinks": 156,
    "TicketPriorityId": 752,
    "SupportLanguageId": 424,
    "SupportAssociateId": 818,
    "CategoryName": "VIP Customer"
  },
  "Person": {
    "Position": "deleniti",
    "PersonId": 340,
    "Mrmrs": "eos",
    "Firstname": "Xavier",
    "Lastname": "Kohler",
    "MiddleName": "Hilll Group",
    "Title": "incidunt",
    "Description": "Profit-focused homogeneous middleware",
    "Email": "chelsey@koss.biz",
    "FullName": "Tia Erdman",
    "DirectPhone": "(617)628-3354 x6445",
    "FormalName": "Funk LLC",
    "CountryId": 739,
    "ContactId": 44,
    "ContactName": "Fisher Inc and Sons",
    "Retired": 202,
    "Rank": 985,
    "ActiveInterests": 711,
    "ContactDepartment": "",
    "ContactCountryId": 896,
    "ContactOrgNr": "502868",
    "FaxPhone": "(241)637-5508",
    "MobilePhone": "(708)845-5380 x078",
    "ContactPhone": "487-850-0141 x137",
    "AssociateName": "Gutmann LLC",
    "AssociateId": 36,
    "UsePersonAddress": false,
    "ContactFax": "fugiat",
    "Kanafname": "numquam",
    "Kanalname": "veritatis",
    "Post1": "explicabo",
    "Post2": "sint",
    "Post3": "quae",
    "EmailName": "margarett@hamill.info",
    "ContactFullName": "Mara King",
    "ActiveErpLinks": 961,
    "TicketPriorityId": 372,
    "SupportLanguageId": 634,
    "SupportAssociateId": 495,
    "CategoryName": "VIP Customer"
  },
  "MotherId": 837,
  "Priority": {
    "Id": 776,
    "Value": "voluptas",
    "Tooltip": "inventore"
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 19,
    "Name": "Schneider Inc and Sons",
    "Description": "Advanced disintermediate productivity",
    "URL": "http://www.example.com/",
    "Type": "dolor",
    "AssociateId": 500,
    "AssociateFullName": "Cecelia Vandervort",
    "TypeId": 480,
    "Updated": "1998-02-02T15:05:41.5010025+01:00",
    "StatusId": 474,
    "Status": "rem",
    "TextId": 390,
    "PublishTo": "2008-06-18T15:05:41.5010025+02:00",
    "PublishFrom": "1996-03-30T15:05:41.5010025+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "358644",
    "ActiveErpLinks": 464
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2001-11-15T15:05:41.5010025+01:00",
  "Completed": "Completed",
  "ActiveLinks": 291,
  "Links": [
    {
      "EntityName": "Gaylord Group",
      "Id": 861,
      "Description": "Visionary 4th generation utilisation",
      "ExtraInfo": "dicta",
      "LinkId": 310
    },
    {
      "EntityName": "Gaylord Group",
      "Id": 861,
      "Description": "Visionary 4th generation utilisation",
      "ExtraInfo": "dicta",
      "LinkId": 310
    }
  ],
  "AlarmLeadTime": "ipsa",
  "HasAlarm": false,
  "ColorIndex": 889,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "quisquam",
  "LeadTime": "aut",
  "Location": "ut",
  "RejectCounter": 368,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 578,
    "StartDate": "2011-09-07T15:05:41.5010025+02:00",
    "EndDate": "2003-11-18T15:05:41.5010025+01:00",
    "RecurrenceCounter": 89,
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
      "AssociateId": 579,
      "PersonId": 412,
      "ContactId": 528,
      "EmailId": 717,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 579,
      "PersonId": 412,
      "ContactId": 528,
      "EmailId": 717,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1997-04-20T15:05:41.5010025+02:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 133,
    "Name": "Schumm LLC",
    "PersonId": 23,
    "Rank": 481,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 68,
    "FullName": "Glenna Yost",
    "FormalName": "Towne Group",
    "Deleted": true,
    "EjUserId": 621,
    "UserName": "Tillman-Daugherty"
  },
  "MotherAssociate": {
    "AssociateId": 452,
    "Name": "Zemlak LLC",
    "PersonId": 383,
    "Rank": 174,
    "Tooltip": "ducimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 797,
    "FullName": "Arthur Predovic",
    "FormalName": "Douglas, Corkery and Collins",
    "Deleted": true,
    "EjUserId": 172,
    "UserName": "Schowalter, Hintz and Crona"
  },
  "Task": {
    "TaskListItemId": 871,
    "Value": "ut",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "accusantium",
    "Deleted": true,
    "IntentId": 68,
    "Rank": 8,
    "IsDefaultAlldayEvent": true,
    "IsDefaultFree": false,
    "IsDefaultPublished": true,
    "ColorIndex": "BlueAlt1",
    "DefaultVideomeetingStatus": "NoChange"
  },
  "PreferredTZLocation": 642,
  "Sale": {
    "ContactName": "Mayert LLC",
    "SaleDate": "2011-07-01T15:05:41.5020028+02:00",
    "SaleId": 272,
    "Probability": 142,
    "Title": "nostrum",
    "Amount": 12257.073999999999,
    "Currency": "qui",
    "ProjectName": "Goodwin Inc and Sons",
    "AssociateFullName": "Mrs. Aracely Ward",
    "Description": "Cross-platform mobile software",
    "Status": "Lost",
    "WeightedAmount": 11135.101999999999,
    "ProjectId": 625,
    "EarningPercent": 27033.884,
    "Earning": 15309.59,
    "ContactId": 503,
    "AssociateId": 79,
    "PersonId": 272,
    "SaleTypeId": 91,
    "SaleTypeName": "Hamill Inc and Sons",
    "PersonFullName": "Sally Emmerich",
    "Completed": "Completed",
    "ActiveErpLinks": 5,
    "NextDueDate": "1997-05-31T15:05:41.5020028+02:00",
    "Number": "1437065"
  },
  "SuggestedAppointmentId": 251,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "aut",
  "UserDefinedFields": {
    "SuperOffice:1": "Anabel Moen",
    "SuperOffice:2": "Pierre Pfeffer I"
  },
  "ExtraFields": {
    "ExtraFields1": "molestias",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "error"
  },
  "PublishEventDate": "2007-12-07T15:05:41.5020028+01:00",
  "PublishTo": "1999-04-20T15:05:41.5020028+02:00",
  "PublishFrom": "2005-12-28T15:05:41.5020028+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 867,
      "Visibility": "All",
      "DisplayValue": "ipsa"
    },
    {
      "VisibleId": 867,
      "Visibility": "All",
      "DisplayValue": "ipsa"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 428,
    "Name": "Boyle Group",
    "PersonId": 475,
    "Rank": 591,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 941,
    "FullName": "Amie Champlin",
    "FormalName": "Lesch Inc and Sons",
    "Deleted": true,
    "EjUserId": 580,
    "UserName": "McClure Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 617
      }
    }
  },
  "Contact": {
    "ContactId": 165,
    "Name": "Fahey Inc and Sons",
    "OrgNr": "1700359",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "fugiat",
    "DirectPhone": "(502)336-3808",
    "AssociateId": 939,
    "CountryId": 92,
    "EmailAddress": "raoul.crona@wymanpaucek.co.uk",
    "Kananame": "quam",
    "EmailAddressName": "destiney@huels.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Cary Schroeder",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nostrum",
    "FullName": "Tyshawn Crooks",
    "IsOwnerContact": false,
    "ActiveErpLinks": 192,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 419
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 486,
    "Name": "Pagac, Bins and Macejkovic",
    "PersonId": 415,
    "Rank": 521,
    "Tooltip": "reprehenderit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 349,
    "FullName": "Coy Daniel",
    "FormalName": "Becker, Blick and Wuckert",
    "Deleted": false,
    "EjUserId": 913,
    "UserName": "Wehner-Collins",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 868
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 332,
    "Name": "Dietrich Inc and Sons",
    "PersonId": 877,
    "Rank": 352,
    "Tooltip": "recusandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 583,
    "FullName": "Robbie Rolfson DVM",
    "FormalName": "Rutherford-Swaniawski",
    "Deleted": false,
    "EjUserId": 559,
    "UserName": "Rutherford-Greenfelder",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "whiteboard sticky networks"
        },
        "FieldType": "System.String",
        "FieldLength": 549
      }
    }
  },
  "CreatedDate": "1998-10-19T15:05:41.5130027+02:00",
  "AppointmentId": 761,
  "Description": "Extended scalable intranet",
  "StartDate": "2016-06-23T15:05:41.5130027+02:00",
  "EndDate": "2008-08-05T15:05:41.5130027+02:00",
  "InvitedPerson": {
    "Position": "est",
    "PersonId": 473,
    "Mrmrs": "iste",
    "Firstname": "Davon",
    "Lastname": "Okuneva",
    "MiddleName": "Spencer-Corkery",
    "Title": "rerum",
    "Description": "Visionary clear-thinking data-warehouse",
    "Email": "dayana@botsford.uk",
    "FullName": "Miss Margaret Langosh",
    "DirectPhone": "337-801-6152 x11045",
    "FormalName": "Goldner-Lebsack",
    "CountryId": 353,
    "ContactId": 893,
    "ContactName": "Hoppe, Marquardt and Langosh",
    "Retired": 37,
    "Rank": 721,
    "ActiveInterests": 454,
    "ContactDepartment": "recontextualize leading-edge experiences",
    "ContactCountryId": 802,
    "ContactOrgNr": "1614166",
    "FaxPhone": "(257)151-7580 x08531",
    "MobilePhone": "125-807-2826 x51423",
    "ContactPhone": "1-363-633-6687",
    "AssociateName": "Konopelski-Wisoky",
    "AssociateId": 738,
    "UsePersonAddress": false,
    "ContactFax": "eos",
    "Kanafname": "consequatur",
    "Kanalname": "magnam",
    "Post1": "pariatur",
    "Post2": "laboriosam",
    "Post3": "illum",
    "EmailName": "karli_carroll@nolan.name",
    "ContactFullName": "Ms. Haylie Reynolds",
    "ActiveErpLinks": 615,
    "TicketPriorityId": 901,
    "SupportLanguageId": 972,
    "SupportAssociateId": 204,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 570
      }
    }
  },
  "Person": {
    "Position": "officiis",
    "PersonId": 255,
    "Mrmrs": "excepturi",
    "Firstname": "Thad",
    "Lastname": "Bechtelar",
    "MiddleName": "Skiles-Streich",
    "Title": "iusto",
    "Description": "Persevering secondary circuit",
    "Email": "mark@shanahan.co.uk",
    "FullName": "Harvey Torp",
    "DirectPhone": "(737)524-8206",
    "FormalName": "Wilderman-Cruickshank",
    "CountryId": 726,
    "ContactId": 716,
    "ContactName": "Baumbach Inc and Sons",
    "Retired": 98,
    "Rank": 983,
    "ActiveInterests": 146,
    "ContactDepartment": "",
    "ContactCountryId": 724,
    "ContactOrgNr": "1258662",
    "FaxPhone": "1-064-717-2306",
    "MobilePhone": "157.337.4666 x0408",
    "ContactPhone": "1-288-050-1842 x714",
    "AssociateName": "Osinski-Rempel",
    "AssociateId": 673,
    "UsePersonAddress": true,
    "ContactFax": "vero",
    "Kanafname": "magnam",
    "Kanalname": "aut",
    "Post1": "eius",
    "Post2": "repellendus",
    "Post3": "repudiandae",
    "EmailName": "gabe@oreilly.ca",
    "ContactFullName": "Antwon Pfannerstill",
    "ActiveErpLinks": 60,
    "TicketPriorityId": 667,
    "SupportLanguageId": 360,
    "SupportAssociateId": 195,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 65
      }
    }
  },
  "MotherId": 61,
  "Priority": {
    "Id": 12,
    "Value": "voluptatum",
    "Tooltip": "fugit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 131
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 412,
    "Name": "Hayes LLC",
    "Description": "Organized zero administration hardware",
    "URL": "http://www.example.com/",
    "Type": "eum",
    "AssociateId": 145,
    "AssociateFullName": "Dannie Pfannerstill",
    "TypeId": 941,
    "Updated": "2005-07-10T15:05:41.5160026+02:00",
    "StatusId": 799,
    "Status": "necessitatibus",
    "TextId": 352,
    "PublishTo": "2014-07-26T15:05:41.5160026+02:00",
    "PublishFrom": "2010-03-06T15:05:41.5160026+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1677315",
    "ActiveErpLinks": 572,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 757
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2009-04-16T15:05:41.5160026+02:00",
  "Completed": "Completed",
  "ActiveLinks": 374,
  "Links": [
    {
      "EntityName": "Ondricka, Mueller and Raynor",
      "Id": 307,
      "Description": "Seamless composite attitude",
      "ExtraInfo": "sit",
      "LinkId": 921,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 536
        }
      }
    }
  ],
  "AlarmLeadTime": "voluptatem",
  "HasAlarm": true,
  "ColorIndex": 179,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "sed",
  "LeadTime": "laborum",
  "Location": "explicabo",
  "RejectCounter": 185,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 560,
    "StartDate": "2019-01-07T15:05:41.5160026+01:00",
    "EndDate": "2002-09-25T15:05:41.5160026+02:00",
    "RecurrenceCounter": 280,
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
      "AssociateId": 967,
      "PersonId": 82,
      "ContactId": 610,
      "EmailId": 110,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 967,
      "PersonId": 82,
      "ContactId": 610,
      "EmailId": 110,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1995-04-01T15:05:41.5160026+02:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 741,
    "Name": "Hermann LLC",
    "PersonId": 716,
    "Rank": 276,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 460,
    "FullName": "Beaulah Langworth",
    "FormalName": "Barton, Gerlach and Reichert",
    "Deleted": true,
    "EjUserId": 230,
    "UserName": "Walter-Yundt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 411
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 71,
    "Name": "Rempel, Kulas and Davis",
    "PersonId": 85,
    "Rank": 650,
    "Tooltip": "ex",
    "Type": "AnonymousAssociate",
    "GroupIdx": 505,
    "FullName": "Mrs. Hayley Gleichner",
    "FormalName": "Kirlin-Schuppe",
    "Deleted": true,
    "EjUserId": 978,
    "UserName": "Johnson Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 803
      }
    }
  },
  "Task": {
    "TaskListItemId": 482,
    "Value": "placeat",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "nemo",
    "Deleted": true,
    "IntentId": 136,
    "Rank": 776,
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
          "Reason": "unleash seamless infomediaries"
        },
        "FieldType": "System.String",
        "FieldLength": 218
      }
    }
  },
  "PreferredTZLocation": 576,
  "Sale": {
    "ContactName": "Kertzmann-Schimmel",
    "SaleDate": "2014-07-13T15:05:41.5170025+02:00",
    "SaleId": 317,
    "Probability": 651,
    "Title": "nulla",
    "Amount": 2497.798,
    "Currency": "veniam",
    "ProjectName": "Conroy LLC",
    "AssociateFullName": "Golden Waelchi",
    "Description": "Centralized composite benchmark",
    "Status": "Lost",
    "WeightedAmount": 20248.773999999998,
    "ProjectId": 542,
    "EarningPercent": 836.778,
    "Earning": 16343.81,
    "ContactId": 582,
    "AssociateId": 88,
    "PersonId": 990,
    "SaleTypeId": 127,
    "SaleTypeName": "Feest, Zboncak and Gislason",
    "PersonFullName": "Cristina Macejkovic",
    "Completed": "Completed",
    "ActiveErpLinks": 941,
    "NextDueDate": "1994-07-21T15:05:41.5170025+02:00",
    "Number": "913754",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 147
      }
    }
  },
  "SuggestedAppointmentId": 289,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "ea",
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Stan Runolfsson"
  },
  "ExtraFields": {
    "ExtraFields1": "minus",
    "ExtraFields2": "temporibus"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "nostrum"
  },
  "PublishEventDate": "1996-11-29T15:05:41.5170025+01:00",
  "PublishTo": "1998-03-22T15:05:41.5170025+01:00",
  "PublishFrom": "2011-01-03T15:05:41.5170025+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 83,
      "Visibility": "All",
      "DisplayValue": "expedita",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 506
        }
      }
    },
    {
      "VisibleId": 83,
      "Visibility": "All",
      "DisplayValue": "expedita",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 506
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
      "FieldLength": 766
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```