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
    "AssociateId": 824,
    "Name": "Pacocha-Hirthe",
    "PersonId": 255,
    "Rank": 362,
    "Tooltip": "porro",
    "Type": "AnonymousAssociate",
    "GroupIdx": 191,
    "FullName": "Adela Schmidt",
    "FormalName": "Smitham-Schuppe",
    "Deleted": false,
    "EjUserId": 686,
    "UserName": "Thompson Group"
  },
  "Contact": {
    "ContactId": 540,
    "Name": "Roob, Brakus and Emard",
    "OrgNr": "219444",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "et",
    "DirectPhone": "(603)674-4834 x35227",
    "AssociateId": 92,
    "CountryId": 807,
    "EmailAddress": "adolphus@erdmankirlin.us",
    "Kananame": "commodi",
    "EmailAddressName": "dorothy.hane@ullrich.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mittie Bauch",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "doloribus",
    "FullName": "Corine Cole",
    "IsOwnerContact": false,
    "ActiveErpLinks": 453
  },
  "CreatedBy": {
    "AssociateId": 171,
    "Name": "Jones Group",
    "PersonId": 376,
    "Rank": 945,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 560,
    "FullName": "Deron Reilly",
    "FormalName": "Hills Group",
    "Deleted": true,
    "EjUserId": 439,
    "UserName": "Moore-Mante"
  },
  "UpdatedBy": {
    "AssociateId": 109,
    "Name": "Hane-Witting",
    "PersonId": 119,
    "Rank": 51,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 154,
    "FullName": "Dr. Stella Buckridge",
    "FormalName": "Kuhn LLC",
    "Deleted": false,
    "EjUserId": 384,
    "UserName": "Hamill-Kertzmann"
  },
  "CreatedDate": "2002-03-12T15:05:41.578003+01:00",
  "AppointmentId": 356,
  "Description": "Automated zero tolerance time-frame",
  "StartDate": "2001-08-12T15:05:41.578003+02:00",
  "EndDate": "2019-08-03T15:05:41.578003+02:00",
  "InvitedPerson": {
    "Position": "est",
    "PersonId": 516,
    "Mrmrs": "aut",
    "Firstname": "Angelina",
    "Lastname": "Welch",
    "MiddleName": "Stiedemann Inc and Sons",
    "Title": "cum",
    "Description": "Grass-roots discrete groupware",
    "Email": "emmalee_wiza@johnson.info",
    "FullName": "Dax Friesen MD",
    "DirectPhone": "(881)081-2350 x0003",
    "FormalName": "Jakubowski-Kuhic",
    "CountryId": 696,
    "ContactId": 970,
    "ContactName": "Haag Group",
    "Retired": 727,
    "Rank": 176,
    "ActiveInterests": 980,
    "ContactDepartment": "",
    "ContactCountryId": 657,
    "ContactOrgNr": "1463414",
    "FaxPhone": "(553)218-1761",
    "MobilePhone": "082-782-0136",
    "ContactPhone": "1-243-118-1547 x323",
    "AssociateName": "Olson-Schumm",
    "AssociateId": 267,
    "UsePersonAddress": false,
    "ContactFax": "est",
    "Kanafname": "omnis",
    "Kanalname": "veniam",
    "Post1": "odio",
    "Post2": "inventore",
    "Post3": "et",
    "EmailName": "lizeth@carterherman.info",
    "ContactFullName": "Valentina Reinger",
    "ActiveErpLinks": 196,
    "TicketPriorityId": 681,
    "SupportLanguageId": 141,
    "SupportAssociateId": 690,
    "CategoryName": "VIP Customer"
  },
  "Person": {
    "Position": "quidem",
    "PersonId": 693,
    "Mrmrs": "nihil",
    "Firstname": "Devan",
    "Lastname": "Johns",
    "MiddleName": "Leuschke, Bradtke and Beer",
    "Title": "quas",
    "Description": "Intuitive assymetric framework",
    "Email": "kip.jacobson@lesch.com",
    "FullName": "Miss Stuart Haley",
    "DirectPhone": "1-007-085-1487 x67644",
    "FormalName": "Stanton-Koch",
    "CountryId": 836,
    "ContactId": 583,
    "ContactName": "Mosciski, Mosciski and Rippin",
    "Retired": 814,
    "Rank": 685,
    "ActiveInterests": 882,
    "ContactDepartment": "",
    "ContactCountryId": 673,
    "ContactOrgNr": "857254",
    "FaxPhone": "1-450-063-4322 x525",
    "MobilePhone": "722-613-0684",
    "ContactPhone": "021.617.4223",
    "AssociateName": "Kuphal LLC",
    "AssociateId": 851,
    "UsePersonAddress": true,
    "ContactFax": "in",
    "Kanafname": "porro",
    "Kanalname": "ex",
    "Post1": "et",
    "Post2": "est",
    "Post3": "voluptatibus",
    "EmailName": "brenna@ratkenicolas.ca",
    "ContactFullName": "Layne Connelly",
    "ActiveErpLinks": 293,
    "TicketPriorityId": 672,
    "SupportLanguageId": 63,
    "SupportAssociateId": 399,
    "CategoryName": "VIP Customer"
  },
  "MotherId": 79,
  "Priority": {
    "Id": 933,
    "Value": "deserunt",
    "Tooltip": "qui"
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 840,
    "Name": "Hoeger, Ortiz and Jacobson",
    "Description": "Exclusive holistic algorithm",
    "URL": "http://www.example.com/",
    "Type": "rem",
    "AssociateId": 340,
    "AssociateFullName": "Ms. Salvador Heathcote",
    "TypeId": 201,
    "Updated": "2000-01-23T15:05:41.5810026+01:00",
    "StatusId": 707,
    "Status": "recusandae",
    "TextId": 768,
    "PublishTo": "2014-11-13T15:05:41.5810026+01:00",
    "PublishFrom": "2013-08-19T15:05:41.5810026+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "997251",
    "ActiveErpLinks": 321
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2010-01-08T15:05:41.5810026+01:00",
  "Completed": "Completed",
  "ActiveLinks": 214,
  "Links": [
    {
      "EntityName": "Walker Group",
      "Id": 146,
      "Description": "Multi-channelled optimizing product",
      "ExtraInfo": "eum",
      "LinkId": 102
    },
    {
      "EntityName": "Walker Group",
      "Id": 146,
      "Description": "Multi-channelled optimizing product",
      "ExtraInfo": "eum",
      "LinkId": 102
    }
  ],
  "AlarmLeadTime": "sunt",
  "HasAlarm": false,
  "ColorIndex": 954,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "minus",
  "LeadTime": "harum",
  "Location": "adipisci",
  "RejectCounter": 797,
  "RejectReason": "engage bleeding-edge models",
  "Recurrence": {
    "RecurrenceId": 941,
    "StartDate": "2017-12-06T15:05:41.5810026+01:00",
    "EndDate": "1996-02-17T15:05:41.5810026+01:00",
    "RecurrenceCounter": 561,
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
      "AssociateId": 146,
      "PersonId": 193,
      "ContactId": 789,
      "EmailId": 721,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 146,
      "PersonId": 193,
      "ContactId": 789,
      "EmailId": 721,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1998-11-23T15:05:41.5810026+01:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 679,
    "Name": "Quigley-Daniel",
    "PersonId": 762,
    "Rank": 787,
    "Tooltip": "eligendi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 329,
    "FullName": "Brandt O'Reilly",
    "FormalName": "Abbott-Bartoletti",
    "Deleted": false,
    "EjUserId": 174,
    "UserName": "Lind-Armstrong"
  },
  "MotherAssociate": {
    "AssociateId": 202,
    "Name": "Schowalter-Hettinger",
    "PersonId": 721,
    "Rank": 816,
    "Tooltip": "veniam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 490,
    "FullName": "Dr. Vernon Veum",
    "FormalName": "Anderson, Runolfsson and Hirthe",
    "Deleted": true,
    "EjUserId": 383,
    "UserName": "Heaney, Watsica and Considine"
  },
  "Task": {
    "TaskListItemId": 66,
    "Value": "dolorem",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "modi",
    "Deleted": false,
    "IntentId": 292,
    "Rank": 130,
    "IsDefaultAlldayEvent": true,
    "IsDefaultFree": true,
    "IsDefaultPublished": false,
    "ColorIndex": "BlueAlt1",
    "DefaultVideomeetingStatus": "NoChange"
  },
  "PreferredTZLocation": 972,
  "Sale": {
    "ContactName": "Jast LLC",
    "SaleDate": "1998-09-05T15:05:41.5820025+02:00",
    "SaleId": 910,
    "Probability": 165,
    "Title": "rerum",
    "Amount": 5393.614,
    "Currency": "quasi",
    "ProjectName": "Gutmann, Cronin and Bradtke",
    "AssociateFullName": "Jaqueline Ondricka",
    "Description": "Focused methodical moderator",
    "Status": "Lost",
    "WeightedAmount": 27187.45,
    "ProjectId": 444,
    "EarningPercent": 8286.296,
    "Earning": 13723.786,
    "ContactId": 675,
    "AssociateId": 832,
    "PersonId": 438,
    "SaleTypeId": 611,
    "SaleTypeName": "Will LLC",
    "PersonFullName": "Amari Kuvalis DVM",
    "Completed": "Completed",
    "ActiveErpLinks": 237,
    "NextDueDate": "1996-12-21T15:05:41.5820025+01:00",
    "Number": "936610"
  },
  "SuggestedAppointmentId": 714,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "ut",
  "UserDefinedFields": {
    "SuperOffice:1": "Neal Feest",
    "SuperOffice:2": "951795181"
  },
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "delectus"
  },
  "CustomFields": {
    "CustomFields1": "rem",
    "CustomFields2": "debitis"
  },
  "PublishEventDate": "2016-01-20T15:05:41.5830022+01:00",
  "PublishTo": "2006-04-07T15:05:41.5830022+02:00",
  "PublishFrom": "1996-09-24T15:05:41.5830022+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 464,
      "Visibility": "All",
      "DisplayValue": "mollitia"
    },
    {
      "VisibleId": 464,
      "Visibility": "All",
      "DisplayValue": "mollitia"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "consequuntur",
  "2": "rem"
}
```