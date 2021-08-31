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
    "AssociateId": 715,
    "Name": "Wilderman LLC",
    "PersonId": 911,
    "Rank": 472,
    "Tooltip": "eligendi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 354,
    "FullName": "Gabe Batz",
    "FormalName": "Buckridge Group",
    "Deleted": true,
    "EjUserId": 262,
    "UserName": "Daugherty Group"
  },
  "Contact": {
    "ContactId": 756,
    "Name": "Medhurst-Erdman",
    "OrgNr": "391476",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "voluptas",
    "DirectPhone": "456-746-3633 x7757",
    "AssociateId": 639,
    "CountryId": 121,
    "EmailAddress": "freeda.hamill@gerhold.biz",
    "Kananame": "qui",
    "EmailAddressName": "erna@gusikowski.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ed Rath",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ut",
    "FullName": "Ashlynn Becker",
    "IsOwnerContact": false,
    "ActiveErpLinks": 863
  },
  "CreatedBy": {
    "AssociateId": 845,
    "Name": "Swaniawski, Roob and Sanford",
    "PersonId": 584,
    "Rank": 105,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 11,
    "FullName": "Claudine Runolfsson",
    "FormalName": "Upton Group",
    "Deleted": true,
    "EjUserId": 102,
    "UserName": "Champlin LLC"
  },
  "UpdatedBy": {
    "AssociateId": 928,
    "Name": "Upton LLC",
    "PersonId": 927,
    "Rank": 840,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 267,
    "FullName": "Gracie Beatty",
    "FormalName": "Bogisich, Berge and Mayert",
    "Deleted": false,
    "EjUserId": 584,
    "UserName": "Hackett, Hane and McDermott"
  },
  "CreatedDate": "2016-06-09T15:05:41.535003+02:00",
  "AppointmentId": 93,
  "Description": "User-centric coherent frame",
  "StartDate": "1996-07-30T15:05:41.535003+02:00",
  "EndDate": "2002-12-05T15:05:41.535003+01:00",
  "InvitedPerson": {
    "Position": "molestiae",
    "PersonId": 734,
    "Mrmrs": "saepe",
    "Firstname": "Kyleigh",
    "Lastname": "Stanton",
    "MiddleName": "O'Kon Inc and Sons",
    "Title": "facere",
    "Description": "Pre-emptive optimizing toolset",
    "Email": "michele.schuster@sengerhermann.uk",
    "FullName": "Cody Miller",
    "DirectPhone": "(638)507-2215 x6841",
    "FormalName": "Borer-Halvorson",
    "CountryId": 581,
    "ContactId": 557,
    "ContactName": "Spinka, Fahey and Grimes",
    "Retired": 231,
    "Rank": 968,
    "ActiveInterests": 539,
    "ContactDepartment": "",
    "ContactCountryId": 862,
    "ContactOrgNr": "1533910",
    "FaxPhone": "127.176.5182",
    "MobilePhone": "710-223-4217 x587",
    "ContactPhone": "(166)454-6125 x650",
    "AssociateName": "Jast-Powlowski",
    "AssociateId": 400,
    "UsePersonAddress": false,
    "ContactFax": "voluptate",
    "Kanafname": "dolorem",
    "Kanalname": "optio",
    "Post1": "debitis",
    "Post2": "sit",
    "Post3": "in",
    "EmailName": "gilda@nitzsche.name",
    "ContactFullName": "Mikel Herman",
    "ActiveErpLinks": 848,
    "TicketPriorityId": 720,
    "SupportLanguageId": 600,
    "SupportAssociateId": 834,
    "CategoryName": "VIP Customer"
  },
  "Person": {
    "Position": "animi",
    "PersonId": 711,
    "Mrmrs": "hic",
    "Firstname": "Rupert",
    "Lastname": "Krajcik",
    "MiddleName": "Zieme-Langworth",
    "Title": "architecto",
    "Description": "Visionary incremental utilisation",
    "Email": "maribel@hoeger.biz",
    "FullName": "Mrs. Krystel Kertzmann",
    "DirectPhone": "(466)246-7270 x44342",
    "FormalName": "Kuhn Group",
    "CountryId": 582,
    "ContactId": 568,
    "ContactName": "Jaskolski, Wisoky and Konopelski",
    "Retired": 676,
    "Rank": 761,
    "ActiveInterests": 338,
    "ContactDepartment": "transform frictionless e-services",
    "ContactCountryId": 126,
    "ContactOrgNr": "954290",
    "FaxPhone": "666.862.5676",
    "MobilePhone": "1-581-453-0710",
    "ContactPhone": "157.361.4735 x3044",
    "AssociateName": "Turcotte, Senger and Gutmann",
    "AssociateId": 25,
    "UsePersonAddress": false,
    "ContactFax": "qui",
    "Kanafname": "aspernatur",
    "Kanalname": "aut",
    "Post1": "minus",
    "Post2": "quia",
    "Post3": "at",
    "EmailName": "tyrell@boehmdickens.uk",
    "ContactFullName": "Hertha Fay",
    "ActiveErpLinks": 102,
    "TicketPriorityId": 363,
    "SupportLanguageId": 473,
    "SupportAssociateId": 303,
    "CategoryName": "VIP Customer"
  },
  "MotherId": 803,
  "Priority": {
    "Id": 617,
    "Value": "consequatur",
    "Tooltip": "dolor"
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 190,
    "Name": "Predovic-Kshlerin",
    "Description": "Centralized needs-based synergy",
    "URL": "http://www.example.com/",
    "Type": "facilis",
    "AssociateId": 751,
    "AssociateFullName": "Destiny Nitzsche",
    "TypeId": 509,
    "Updated": "1999-08-14T15:05:41.5390028+02:00",
    "StatusId": 611,
    "Status": "nihil",
    "TextId": 715,
    "PublishTo": "2010-02-26T15:05:41.5390028+01:00",
    "PublishFrom": "2002-01-20T15:05:41.5390028+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1450870",
    "ActiveErpLinks": 367
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "1999-11-23T15:05:41.5390028+01:00",
  "Completed": "Completed",
  "ActiveLinks": 360,
  "Links": [
    {
      "EntityName": "Waelchi-Jaskolski",
      "Id": 943,
      "Description": "Monitored multi-tasking synergy",
      "ExtraInfo": "perferendis",
      "LinkId": 10
    },
    {
      "EntityName": "Waelchi-Jaskolski",
      "Id": 943,
      "Description": "Monitored multi-tasking synergy",
      "ExtraInfo": "perferendis",
      "LinkId": 10
    }
  ],
  "AlarmLeadTime": "deleniti",
  "HasAlarm": false,
  "ColorIndex": 784,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "eum",
  "LeadTime": "repellat",
  "Location": "quasi",
  "RejectCounter": 107,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 761,
    "StartDate": "1998-05-05T15:05:41.5390028+02:00",
    "EndDate": "2005-06-11T15:05:41.5390028+02:00",
    "RecurrenceCounter": 914,
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
      "AssociateId": 893,
      "PersonId": 295,
      "ContactId": 339,
      "EmailId": 122,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 893,
      "PersonId": 295,
      "ContactId": 339,
      "EmailId": 122,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1997-06-07T15:05:41.5390028+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 973,
    "Name": "Ebert, Weimann and Senger",
    "PersonId": 815,
    "Rank": 985,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 2,
    "FullName": "Felix Klein",
    "FormalName": "Morissette, Deckow and Mertz",
    "Deleted": true,
    "EjUserId": 9,
    "UserName": "Trantow-Abshire"
  },
  "MotherAssociate": {
    "AssociateId": 613,
    "Name": "Lueilwitz LLC",
    "PersonId": 656,
    "Rank": 779,
    "Tooltip": "harum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 113,
    "FullName": "Ayla Jast",
    "FormalName": "Schuppe-Barrows",
    "Deleted": false,
    "EjUserId": 931,
    "UserName": "Steuber, Rosenbaum and Toy"
  },
  "Task": {
    "TaskListItemId": 661,
    "Value": "nam",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "animi",
    "Deleted": false,
    "IntentId": 879,
    "Rank": 828,
    "IsDefaultAlldayEvent": true,
    "IsDefaultFree": false,
    "IsDefaultPublished": false,
    "ColorIndex": "BlueAlt1",
    "DefaultVideomeetingStatus": "NoChange"
  },
  "PreferredTZLocation": 152,
  "Sale": {
    "ContactName": "Wiza LLC",
    "SaleDate": "2004-12-03T15:05:41.5400025+01:00",
    "SaleId": 50,
    "Probability": 524,
    "Title": "ex",
    "Amount": 12742.844,
    "Currency": "commodi",
    "ProjectName": "Greenfelder-Block",
    "AssociateFullName": "Alisha Frami",
    "Description": "Re-contextualized intangible local area network",
    "Status": "Lost",
    "WeightedAmount": 20161.022,
    "ProjectId": 940,
    "EarningPercent": 20267.577999999998,
    "Earning": 965.27199999999993,
    "ContactId": 182,
    "AssociateId": 235,
    "PersonId": 820,
    "SaleTypeId": 22,
    "SaleTypeName": "Wuckert, Bergstrom and Ruecker",
    "PersonFullName": "Lawson Yundt",
    "Completed": "Completed",
    "ActiveErpLinks": 149,
    "NextDueDate": "1998-08-15T15:05:41.5400025+02:00",
    "Number": "415405"
  },
  "SuggestedAppointmentId": 311,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "aperiam",
  "UserDefinedFields": {
    "SuperOffice:1": "1716314678",
    "SuperOffice:2": "Shakira Fahey"
  },
  "ExtraFields": {
    "ExtraFields1": "sequi",
    "ExtraFields2": "aperiam"
  },
  "CustomFields": {
    "CustomFields1": "culpa",
    "CustomFields2": "nostrum"
  },
  "PublishEventDate": "1997-05-11T15:05:41.5400025+02:00",
  "PublishTo": "2012-06-28T15:05:41.5400025+02:00",
  "PublishFrom": "2002-11-13T15:05:41.5400025+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 298,
      "Visibility": "All",
      "DisplayValue": "deleniti"
    },
    {
      "VisibleId": 298,
      "Visibility": "All",
      "DisplayValue": "deleniti"
    }
  ]
}
```

```http_
HTTP/1.1 200 AppointmentEntity updated.
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 613,
    "Name": "Bailey Inc and Sons",
    "PersonId": 665,
    "Rank": 355,
    "Tooltip": "ipsam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 28,
    "FullName": "Brenna Moen",
    "FormalName": "Boyle Group",
    "Deleted": true,
    "EjUserId": 971,
    "UserName": "Beier Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "orchestrate sexy paradigms"
        },
        "FieldType": "System.Int32",
        "FieldLength": 505
      }
    }
  },
  "Contact": {
    "ContactId": 814,
    "Name": "Hilpert LLC",
    "OrgNr": "1205125",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "exercitationem",
    "DirectPhone": "706.533.2781",
    "AssociateId": 122,
    "CountryId": 83,
    "EmailAddress": "mason@schroeder.com",
    "Kananame": "deleniti",
    "EmailAddressName": "ephraim_kuphal@okeefe.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mervin Prohaska",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "voluptatem",
    "FullName": "Mrs. Jennifer Huel",
    "IsOwnerContact": false,
    "ActiveErpLinks": 882,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "transition dynamic mindshare"
        },
        "FieldType": "System.Int32",
        "FieldLength": 682
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 651,
    "Name": "Fisher Group",
    "PersonId": 180,
    "Rank": 425,
    "Tooltip": "numquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 124,
    "FullName": "Ms. Mauricio Schoen",
    "FormalName": "Powlowski-Stokes",
    "Deleted": true,
    "EjUserId": 382,
    "UserName": "Leuschke LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 438
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 995,
    "Name": "Kulas, Kilback and Durgan",
    "PersonId": 772,
    "Rank": 871,
    "Tooltip": "vel",
    "Type": "AnonymousAssociate",
    "GroupIdx": 15,
    "FullName": "Kadin Gorczany",
    "FormalName": "Weber LLC",
    "Deleted": true,
    "EjUserId": 378,
    "UserName": "Bins, Bins and Bartell",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 351
      }
    }
  },
  "CreatedDate": "2001-01-25T15:05:41.5510025+01:00",
  "AppointmentId": 142,
  "Description": "Centralized logistical middleware",
  "StartDate": "2008-06-03T15:05:41.5510025+02:00",
  "EndDate": "2001-05-08T15:05:41.5510025+02:00",
  "InvitedPerson": {
    "Position": "eos",
    "PersonId": 721,
    "Mrmrs": "repudiandae",
    "Firstname": "Evert",
    "Lastname": "Mills",
    "MiddleName": "Ziemann, Hilpert and Parker",
    "Title": "officiis",
    "Description": "Configurable client-driven matrix",
    "Email": "davonte@kulas.name",
    "FullName": "Arno Keeling",
    "DirectPhone": "317-653-8772",
    "FormalName": "Cummings Inc and Sons",
    "CountryId": 34,
    "ContactId": 319,
    "ContactName": "Block-Okuneva",
    "Retired": 733,
    "Rank": 551,
    "ActiveInterests": 104,
    "ContactDepartment": "",
    "ContactCountryId": 578,
    "ContactOrgNr": "1441889",
    "FaxPhone": "1-383-405-7684",
    "MobilePhone": "(262)502-8388 x11071",
    "ContactPhone": "711.427.2083",
    "AssociateName": "Fay-McClure",
    "AssociateId": 357,
    "UsePersonAddress": false,
    "ContactFax": "eum",
    "Kanafname": "eum",
    "Kanalname": "odio",
    "Post1": "voluptatem",
    "Post2": "cum",
    "Post3": "et",
    "EmailName": "cecile@hilll.us",
    "ContactFullName": "Kay Rogahn",
    "ActiveErpLinks": 947,
    "TicketPriorityId": 590,
    "SupportLanguageId": 416,
    "SupportAssociateId": 406,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 925
      }
    }
  },
  "Person": {
    "Position": "aut",
    "PersonId": 644,
    "Mrmrs": "aut",
    "Firstname": "Fannie",
    "Lastname": "Littel",
    "MiddleName": "Emard Group",
    "Title": "aut",
    "Description": "Digitized systemic capability",
    "Email": "stephania_bruen@oreilly.us",
    "FullName": "Antonina Herzog",
    "DirectPhone": "(734)133-0032 x00475",
    "FormalName": "Hirthe, Batz and Kiehn",
    "CountryId": 563,
    "ContactId": 84,
    "ContactName": "Kshlerin-Kutch",
    "Retired": 444,
    "Rank": 524,
    "ActiveInterests": 624,
    "ContactDepartment": "",
    "ContactCountryId": 329,
    "ContactOrgNr": "727080",
    "FaxPhone": "646-566-4617",
    "MobilePhone": "676-520-5835 x77380",
    "ContactPhone": "1-767-670-7201 x0854",
    "AssociateName": "Kerluke, Fay and Nikolaus",
    "AssociateId": 818,
    "UsePersonAddress": false,
    "ContactFax": "officiis",
    "Kanafname": "magnam",
    "Kanalname": "deserunt",
    "Post1": "id",
    "Post2": "expedita",
    "Post3": "libero",
    "EmailName": "alf_bailey@cummings.ca",
    "ContactFullName": "Immanuel O'Connell",
    "ActiveErpLinks": 69,
    "TicketPriorityId": 952,
    "SupportLanguageId": 668,
    "SupportAssociateId": 295,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 573
      }
    }
  },
  "MotherId": 798,
  "Priority": {
    "Id": 115,
    "Value": "quae",
    "Tooltip": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 223
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 385,
    "Name": "Walker-Howe",
    "Description": "Future-proofed maximized protocol",
    "URL": "http://www.example.com/",
    "Type": "quia",
    "AssociateId": 66,
    "AssociateFullName": "Clint Schimmel",
    "TypeId": 230,
    "Updated": "2015-07-10T15:05:41.5530024+02:00",
    "StatusId": 334,
    "Status": "repellat",
    "TextId": 302,
    "PublishTo": "1995-10-27T15:05:41.5530024+02:00",
    "PublishFrom": "2003-06-02T15:05:41.5530024+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "522147",
    "ActiveErpLinks": 558,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 694
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2017-08-10T15:05:41.5530024+02:00",
  "Completed": "Completed",
  "ActiveLinks": 399,
  "Links": [
    {
      "EntityName": "Beier-Gutmann",
      "Id": 146,
      "Description": "Organic eco-centric orchestration",
      "ExtraInfo": "enim",
      "LinkId": 241,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "iterate back-end schemas"
          },
          "FieldType": "System.String",
          "FieldLength": 1000
        }
      }
    }
  ],
  "AlarmLeadTime": "voluptatem",
  "HasAlarm": false,
  "ColorIndex": 279,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "corrupti",
  "LeadTime": "voluptatem",
  "Location": "vitae",
  "RejectCounter": 976,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 917,
    "StartDate": "1995-11-03T15:05:41.5530024+01:00",
    "EndDate": "1999-10-08T15:05:41.5530024+02:00",
    "RecurrenceCounter": 153,
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
      "AssociateId": 737,
      "PersonId": 681,
      "ContactId": 599,
      "EmailId": 875,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 737,
      "PersonId": 681,
      "ContactId": 599,
      "EmailId": 875,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1999-09-09T15:05:41.5530024+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 992,
    "Name": "Kutch, Champlin and Schaefer",
    "PersonId": 122,
    "Rank": 39,
    "Tooltip": "quae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 733,
    "FullName": "Baylee Yundt",
    "FormalName": "Thiel LLC",
    "Deleted": true,
    "EjUserId": 117,
    "UserName": "O'Connell-Schuppe",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 344
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 405,
    "Name": "Kling Group",
    "PersonId": 177,
    "Rank": 192,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 283,
    "FullName": "Patience Crist",
    "FormalName": "Buckridge, Upton and Swaniawski",
    "Deleted": false,
    "EjUserId": 5,
    "UserName": "Kulas-Torp",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 131
      }
    }
  },
  "Task": {
    "TaskListItemId": 527,
    "Value": "cupiditate",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "repellendus",
    "Deleted": true,
    "IntentId": 718,
    "Rank": 829,
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
        "FieldType": "System.Int32",
        "FieldLength": 24
      }
    }
  },
  "PreferredTZLocation": 804,
  "Sale": {
    "ContactName": "Kemmer Inc and Sons",
    "SaleDate": "2001-05-30T15:05:41.5540024+02:00",
    "SaleId": 950,
    "Probability": 283,
    "Title": "sapiente",
    "Amount": 26595.124,
    "Currency": "aut",
    "ProjectName": "Pouros, Bayer and O'Reilly",
    "AssociateFullName": "Stephen VonRueden",
    "Description": "Integrated system-worthy ability",
    "Status": "Lost",
    "WeightedAmount": 30177.286,
    "ProjectId": 288,
    "EarningPercent": 3331.442,
    "Earning": 15767.153999999999,
    "ContactId": 47,
    "AssociateId": 464,
    "PersonId": 302,
    "SaleTypeId": 819,
    "SaleTypeName": "Bogan, Kessler and Denesik",
    "PersonFullName": "Mr. Cayla Schaden",
    "Completed": "Completed",
    "ActiveErpLinks": 602,
    "NextDueDate": "2008-12-23T15:05:41.5570024+01:00",
    "Number": "1419770",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 678
      }
    }
  },
  "SuggestedAppointmentId": 439,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "reiciendis",
  "UserDefinedFields": {
    "SuperOffice:1": "314968145",
    "SuperOffice:2": "Wava Nader"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "distinctio"
  },
  "CustomFields": {
    "CustomFields1": "provident",
    "CustomFields2": "omnis"
  },
  "PublishEventDate": "2007-10-04T15:05:41.5570024+02:00",
  "PublishTo": "1995-11-10T15:05:41.5570024+01:00",
  "PublishFrom": "2005-11-21T15:05:41.5570024+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 118,
      "Visibility": "All",
      "DisplayValue": "velit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "unleash efficient e-tailers"
          },
          "FieldType": "System.String",
          "FieldLength": 610
        }
      }
    },
    {
      "VisibleId": 118,
      "Visibility": "All",
      "DisplayValue": "velit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "unleash efficient e-tailers"
          },
          "FieldType": "System.String",
          "FieldLength": 610
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
      "FieldType": "System.Int32",
      "FieldLength": 296
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```