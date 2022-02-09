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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 614,
    "Name": "Herman-Gusikowski",
    "PersonId": 634,
    "Rank": 607,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 839,
    "FullName": "Marley Adams",
    "FormalName": "O'Conner-Langworth",
    "Deleted": false,
    "EjUserId": 891,
    "UserName": "Murazik, Moore and Kilback"
  },
  "Contact": {
    "ContactId": 187,
    "Name": "Russel LLC",
    "OrgNr": "224586",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "et",
    "DirectPhone": "1-708-224-3077",
    "AssociateId": 785,
    "CountryId": 995,
    "EmailAddress": "delphia_olson@davisgulgowski.name",
    "Kananame": "sit",
    "EmailAddressName": "casimir.beer@greenjerde.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Yasmeen Volkman",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "et",
    "FullName": "Franz Herman",
    "IsOwnerContact": true,
    "ActiveErpLinks": 210
  },
  "CreatedBy": {
    "AssociateId": 478,
    "Name": "Skiles-Romaguera",
    "PersonId": 665,
    "Rank": 194,
    "Tooltip": "occaecati",
    "Type": "AnonymousAssociate",
    "GroupIdx": 532,
    "FullName": "Amelia Ryan",
    "FormalName": "Schaden, Nader and Dickinson",
    "Deleted": false,
    "EjUserId": 112,
    "UserName": "Abbott Inc and Sons"
  },
  "UpdatedBy": {
    "AssociateId": 680,
    "Name": "Carroll, Schimmel and Block",
    "PersonId": 712,
    "Rank": 385,
    "Tooltip": "exercitationem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 987,
    "FullName": "Ms. Mia Heidenreich",
    "FormalName": "Kuphal Group",
    "Deleted": false,
    "EjUserId": 9,
    "UserName": "Torp-Jakubowski"
  },
  "CreatedDate": "2002-12-18T18:25:49.9685333+01:00",
  "AppointmentId": 216,
  "Description": "User-centric full-range core",
  "StartDate": "2000-03-13T18:25:49.9685333+01:00",
  "EndDate": "2007-03-06T18:25:49.9685333+01:00",
  "InvitedPerson": {
    "Position": "recusandae",
    "PersonId": 209,
    "Mrmrs": "rerum",
    "Firstname": "Shannon",
    "Lastname": "Nicolas",
    "MiddleName": "Bruen, Olson and Conn",
    "Title": "ut",
    "Description": "Digitized actuating open architecture",
    "Email": "antwon@cartwright.co.uk",
    "FullName": "Zakary Lueilwitz",
    "DirectPhone": "435.121.7600 x7164",
    "FormalName": "Murray-Thompson",
    "CountryId": 25,
    "ContactId": 870,
    "ContactName": "O'Conner-Erdman",
    "Retired": 627,
    "Rank": 531,
    "ActiveInterests": 463,
    "ContactDepartment": "",
    "ContactCountryId": 948,
    "ContactOrgNr": "884468",
    "FaxPhone": "1-317-131-2838",
    "MobilePhone": "(410)732-7662",
    "ContactPhone": "101.270.6811 x476",
    "AssociateName": "Hane, Moore and Collier",
    "AssociateId": 226,
    "UsePersonAddress": true,
    "ContactFax": "est",
    "Kanafname": "numquam",
    "Kanalname": "eaque",
    "Post1": "qui",
    "Post2": "quae",
    "Post3": "doloribus",
    "EmailName": "sienna_bogisich@anderson.com",
    "ContactFullName": "Ila Sauer",
    "ActiveErpLinks": 92,
    "TicketPriorityId": 929,
    "SupportLanguageId": 303,
    "SupportAssociateId": 320,
    "CategoryName": "VIP Customer"
  },
  "Person": {
    "Position": "aperiam",
    "PersonId": 696,
    "Mrmrs": "praesentium",
    "Firstname": "Felipa",
    "Lastname": "Harvey",
    "MiddleName": "Frami, Stroman and Wintheiser",
    "Title": "amet",
    "Description": "Function-based local success",
    "Email": "charley@zboncak.ca",
    "FullName": "Lawson Cassin",
    "DirectPhone": "051-012-6250 x33414",
    "FormalName": "Spinka, Stanton and Beahan",
    "CountryId": 721,
    "ContactId": 227,
    "ContactName": "Roberts, Lowe and Purdy",
    "Retired": 915,
    "Rank": 900,
    "ActiveInterests": 313,
    "ContactDepartment": "",
    "ContactCountryId": 551,
    "ContactOrgNr": "518743",
    "FaxPhone": "526.616.6486 x445",
    "MobilePhone": "738-664-3517 x5313",
    "ContactPhone": "705-277-8716 x021",
    "AssociateName": "Dicki Inc and Sons",
    "AssociateId": 12,
    "UsePersonAddress": true,
    "ContactFax": "eaque",
    "Kanafname": "et",
    "Kanalname": "distinctio",
    "Post1": "sequi",
    "Post2": "inventore",
    "Post3": "quae",
    "EmailName": "justice.casper@padberg.us",
    "ContactFullName": "Norberto Weissnat",
    "ActiveErpLinks": 636,
    "TicketPriorityId": 796,
    "SupportLanguageId": 45,
    "SupportAssociateId": 657,
    "CategoryName": "VIP Customer"
  },
  "MotherId": 222,
  "Priority": {
    "Id": 238,
    "Value": "repellat",
    "Tooltip": "facilis"
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 946,
    "Name": "Lowe LLC",
    "Description": "Enterprise-wide zero administration paradigm",
    "URL": "http://www.example.com/",
    "Type": "qui",
    "AssociateId": 864,
    "AssociateFullName": "Candido Weissnat",
    "TypeId": 578,
    "Updated": "1995-06-06T18:25:49.9715629+02:00",
    "StatusId": 47,
    "Status": "sint",
    "TextId": 383,
    "PublishTo": "2002-01-16T18:25:49.9715629+01:00",
    "PublishFrom": "2012-12-02T18:25:49.9715629+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "335200",
    "ActiveErpLinks": 640
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2021-09-13T18:25:49.9715629+02:00",
  "Completed": "Completed",
  "ActiveLinks": 918,
  "Links": [
    {
      "EntityName": "Berge, Haag and Jacobi",
      "Id": 439,
      "Description": "Persevering 6th generation local area network",
      "ExtraInfo": "odio",
      "LinkId": 882
    },
    {
      "EntityName": "Berge, Haag and Jacobi",
      "Id": 439,
      "Description": "Persevering 6th generation local area network",
      "ExtraInfo": "odio",
      "LinkId": 882
    }
  ],
  "AlarmLeadTime": "perferendis",
  "HasAlarm": false,
  "ColorIndex": 81,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "beatae",
  "LeadTime": "consectetur",
  "Location": "deleniti",
  "RejectCounter": 222,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 991,
    "StartDate": "2009-11-05T18:25:49.9715629+01:00",
    "EndDate": "2015-12-05T18:25:49.9715629+01:00",
    "RecurrenceCounter": 313,
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
      "AssociateId": 394,
      "PersonId": 817,
      "ContactId": 16,
      "EmailId": 802,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 394,
      "PersonId": 817,
      "ContactId": 16,
      "EmailId": 802,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2008-12-19T18:25:49.9715629+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 77,
    "Name": "Cremin-Hahn",
    "PersonId": 565,
    "Rank": 17,
    "Tooltip": "repellat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 930,
    "FullName": "Miss Rylan Mayert",
    "FormalName": "Kris LLC",
    "Deleted": true,
    "EjUserId": 835,
    "UserName": "Schmidt Group"
  },
  "MotherAssociate": {
    "AssociateId": 909,
    "Name": "Dooley Group",
    "PersonId": 280,
    "Rank": 154,
    "Tooltip": "mollitia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 340,
    "FullName": "David Jakubowski",
    "FormalName": "Runolfsdottir, Padberg and Terry",
    "Deleted": true,
    "EjUserId": 813,
    "UserName": "Schneider, Baumbach and Hane"
  },
  "Task": {
    "TaskListItemId": 93,
    "Value": "eius",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "nulla",
    "Deleted": true,
    "IntentId": 213,
    "Rank": 912,
    "IsDefaultAlldayEvent": true,
    "IsDefaultFree": false,
    "IsDefaultPublished": false,
    "ColorIndex": "BlueAlt1",
    "DefaultVideomeetingStatus": "NoChange"
  },
  "PreferredTZLocation": 738,
  "Sale": {
    "ContactName": "Brown-Bergstrom",
    "SaleDate": "1998-11-29T18:25:49.9725632+01:00",
    "SaleId": 730,
    "Probability": 7,
    "Title": "quia",
    "Amount": 11445.368,
    "Currency": "est",
    "ProjectName": "Murray LLC",
    "AssociateFullName": "Mr. Salvador Stehr",
    "Description": "Configurable real-time application",
    "Status": "Lost",
    "WeightedAmount": 19292.904,
    "ProjectId": 544,
    "EarningPercent": 7637.558,
    "Earning": 8051.246,
    "ContactId": 510,
    "AssociateId": 329,
    "PersonId": 301,
    "SaleTypeId": 129,
    "SaleTypeName": "Lynch, Ferry and Koepp",
    "PersonFullName": "Marlin Rippin",
    "Completed": "Completed",
    "ActiveErpLinks": 598,
    "NextDueDate": "2019-07-21T18:25:49.9725632+02:00",
    "Number": "580314"
  },
  "SuggestedAppointmentId": 139,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "qui",
  "UserDefinedFields": {
    "SuperOffice:1": "Monserrate Cartwright",
    "SuperOffice:2": "Maxime Kulas"
  },
  "ExtraFields": {
    "ExtraFields1": "mollitia",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "officiis",
    "CustomFields2": "molestiae"
  },
  "PublishEventDate": "2016-02-08T18:25:49.9735634+01:00",
  "PublishTo": "2021-02-16T18:25:49.9735634+01:00",
  "PublishFrom": "2017-05-12T18:25:49.9735634+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 320,
      "Visibility": "All",
      "DisplayValue": "quaerat"
    },
    {
      "VisibleId": 320,
      "Visibility": "All",
      "DisplayValue": "quaerat"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "quaerat",
  "2": "aut"
}
```