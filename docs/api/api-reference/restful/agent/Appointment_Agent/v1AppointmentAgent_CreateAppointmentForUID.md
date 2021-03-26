---
title: POST Agents/Appointment/CreateAppointmentForUID
id: v1AppointmentAgent_CreateAppointmentForUID
---

# POST Agents/Appointment/CreateAppointmentForUID

```http
POST /api/v1/Agents/Appointment/CreateAppointmentForUID
```

Create an invitation record and an appointment with a given UID to reserve it if the UID is unused, otherwise null.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateAppointmentForUID?$select=name,department,category/id
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

## Request Body: request  

AppointmentEntity, UID 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentEntity |  | Partial AppointmentEntity class associating the generated AppointmentEntity with an interface. |
| UID | string |  |


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
POST /api/v1/Agents/Appointment/CreateAppointmentForUID
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AppointmentEntity": {
    "Associate": {},
    "Contact": {},
    "CreatedBy": {},
    "UpdatedBy": {},
    "CreatedDate": "2003-06-28T16:48:28.384445+02:00",
    "AppointmentId": 480,
    "Description": "Multi-channelled background structure",
    "StartDate": "2006-11-17T16:48:28.384445+01:00",
    "EndDate": "1996-09-18T16:48:28.384445+02:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 244,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "2011-04-03T16:48:28.384445+02:00",
    "Completed": "Completed",
    "ActiveLinks": 223,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "fuga",
    "HasAlarm": true,
    "ColorIndex": 404,
    "IsFree": true,
    "IsAlldayEvent": true,
    "LagTime": "porro",
    "LeadTime": "accusamus",
    "Location": "cum",
    "RejectCounter": 839,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "1995-11-29T16:48:28.384445+01:00",
    "HasConflict": true,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 659,
    "Sale": {},
    "SuggestedAppointmentId": 46,
    "IsMileStone": false,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "soluta",
    "UserDefinedFields": {
      "SuperOffice:1": "Ashley D'Amore",
      "SuperOffice:2": "True"
    },
    "ExtraFields": {
      "ExtraFields1": "facilis",
      "ExtraFields2": "beatae"
    },
    "CustomFields": {
      "CustomFields1": "aliquam",
      "CustomFields2": "numquam"
    },
    "PublishEventDate": "2010-06-17T16:48:28.3854492+02:00",
    "PublishTo": "1999-07-06T16:48:28.3854492+02:00",
    "PublishFrom": "2004-07-19T16:48:28.3854492+02:00",
    "IsPublished": true,
    "VisibleFor": [
      {},
      {}
    ]
  },
  "UID": "ipsa"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 938,
    "Name": "Schroeder-Hettinger",
    "PersonId": 199,
    "Rank": 168,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 790,
    "FullName": "Rosalia Langworth",
    "FormalName": "Haag, Mills and Wisoky",
    "Deleted": true,
    "EjUserId": 105,
    "UserName": "Lakin Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 914
      }
    }
  },
  "Contact": {
    "ContactId": 710,
    "Name": "Strosin-Smitham",
    "OrgNr": "729130",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "est",
    "DirectPhone": "1-736-660-8224 x413",
    "AssociateId": 114,
    "CountryId": 418,
    "EmailAddress": "ian@kiehnsporer.uk",
    "Kananame": "eum",
    "EmailAddressName": "jade@nicolas.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jovan Collier",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "voluptas",
    "FullName": "Kasandra Macejkovic",
    "IsOwnerContact": true,
    "ActiveErpLinks": 575,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 576
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 442,
    "Name": "Littel-Wilderman",
    "PersonId": 759,
    "Rank": 424,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 939,
    "FullName": "Audie Terry",
    "FormalName": "Kris Inc and Sons",
    "Deleted": false,
    "EjUserId": 383,
    "UserName": "Wyman-Wisozk",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 654
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 321,
    "Name": "Reilly, Becker and Bayer",
    "PersonId": 953,
    "Rank": 652,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 906,
    "FullName": "Archibald Thiel",
    "FormalName": "Barrows LLC",
    "Deleted": false,
    "EjUserId": 198,
    "UserName": "Padberg Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 913
      }
    }
  },
  "CreatedDate": "2018-03-13T16:48:28.3944491+01:00",
  "AppointmentId": 778,
  "Description": "Streamlined mission-critical Graphical User Interface",
  "StartDate": "1994-05-01T16:48:28.3944491+02:00",
  "EndDate": "2005-12-10T16:48:28.3944491+01:00",
  "InvitedPerson": {
    "Position": "odio",
    "PersonId": 554,
    "Mrmrs": "quo",
    "Firstname": "Mae",
    "Lastname": "Yost",
    "MiddleName": "Koch LLC",
    "Title": "in",
    "Description": "Future-proofed maximized installation",
    "Email": "verlie@douglasdouglas.biz",
    "FullName": "Grover Herzog",
    "DirectPhone": "817-776-4836 x3447",
    "FormalName": "Ebert Group",
    "CountryId": 216,
    "ContactId": 401,
    "ContactName": "Kutch-Satterfield",
    "Retired": 327,
    "Rank": 609,
    "ActiveInterests": 415,
    "ContactDepartment": "",
    "ContactCountryId": 202,
    "ContactOrgNr": "1000996",
    "FaxPhone": "201-774-1356 x55870",
    "MobilePhone": "(340)866-0811 x72484",
    "ContactPhone": "1-144-325-0505",
    "AssociateName": "Nienow-Spencer",
    "AssociateId": 848,
    "UsePersonAddress": false,
    "ContactFax": "perspiciatis",
    "Kanafname": "odio",
    "Kanalname": "dolor",
    "Post1": "illo",
    "Post2": "doloremque",
    "Post3": "est",
    "EmailName": "michel_welch@durgan.uk",
    "ContactFullName": "Maegan Lockman",
    "ActiveErpLinks": 790,
    "TicketPriorityId": 485,
    "SupportLanguageId": 409,
    "SupportAssociateId": 929,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 104
      }
    }
  },
  "Person": {
    "Position": "ea",
    "PersonId": 295,
    "Mrmrs": "et",
    "Firstname": "Jaycee",
    "Lastname": "Turner",
    "MiddleName": "Heller LLC",
    "Title": "autem",
    "Description": "Business-focused upward-trending hardware",
    "Email": "camron_schneider@manteharber.us",
    "FullName": "Shayne Abernathy MD",
    "DirectPhone": "677.351.3232",
    "FormalName": "Gislason Inc and Sons",
    "CountryId": 152,
    "ContactId": 167,
    "ContactName": "Koelpin, Grady and Kuhic",
    "Retired": 863,
    "Rank": 57,
    "ActiveInterests": 489,
    "ContactDepartment": "",
    "ContactCountryId": 581,
    "ContactOrgNr": "1340708",
    "FaxPhone": "1-801-787-6345 x468",
    "MobilePhone": "(148)541-3136 x547",
    "ContactPhone": "1-202-865-4223",
    "AssociateName": "Keeling LLC",
    "AssociateId": 799,
    "UsePersonAddress": false,
    "ContactFax": "sint",
    "Kanafname": "in",
    "Kanalname": "et",
    "Post1": "pariatur",
    "Post2": "et",
    "Post3": "fugit",
    "EmailName": "margarete.doyle@bauchmuller.co.uk",
    "ContactFullName": "Felicity Miller",
    "ActiveErpLinks": 979,
    "TicketPriorityId": 303,
    "SupportLanguageId": 39,
    "SupportAssociateId": 896,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 109
      }
    }
  },
  "MotherId": 563,
  "Priority": {
    "Id": 622,
    "Value": "alias",
    "Tooltip": "accusantium",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 294
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 279,
    "Name": "Walker LLC",
    "Description": "Profound logistical software",
    "URL": "http://www.example.com/",
    "Type": "placeat",
    "AssociateId": 394,
    "AssociateFullName": "Monserrat Goodwin",
    "TypeId": 2,
    "Updated": "2012-07-10T16:48:28.3964499+02:00",
    "StatusId": 601,
    "Status": "quia",
    "TextId": 14,
    "PublishTo": "1999-12-03T16:48:28.3964499+01:00",
    "PublishFrom": "2012-01-09T16:48:28.3964499+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1002588",
    "ActiveErpLinks": 497,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 181
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2004-05-19T16:48:28.3964499+02:00",
  "Completed": "Completed",
  "ActiveLinks": 778,
  "Links": [
    {
      "EntityName": "Bins LLC",
      "Id": 55,
      "Description": "Self-enabling exuding extranet",
      "ExtraInfo": "ullam",
      "LinkId": 697,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 215
        }
      }
    }
  ],
  "AlarmLeadTime": "blanditiis",
  "HasAlarm": true,
  "ColorIndex": 667,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "ut",
  "LeadTime": "quia",
  "Location": "alias",
  "RejectCounter": 347,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 177,
    "StartDate": "2020-04-24T16:48:28.3974491+02:00",
    "EndDate": "2012-12-29T16:48:28.3974491+01:00",
    "RecurrenceCounter": 778,
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
      "AssociateId": 928,
      "PersonId": 797,
      "ContactId": 547,
      "EmailId": 471,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 928,
      "PersonId": 797,
      "ContactId": 547,
      "EmailId": 471,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2020-02-10T16:48:28.3974491+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 605,
    "Name": "O'Reilly Inc and Sons",
    "PersonId": 757,
    "Rank": 784,
    "Tooltip": "tempora",
    "Type": "AnonymousAssociate",
    "GroupIdx": 263,
    "FullName": "Cody Hirthe",
    "FormalName": "Bartoletti, Jacobi and Dickinson",
    "Deleted": true,
    "EjUserId": 396,
    "UserName": "Brakus, Weimann and Brakus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 197
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 156,
    "Name": "Braun-Stracke",
    "PersonId": 870,
    "Rank": 283,
    "Tooltip": "in",
    "Type": "AnonymousAssociate",
    "GroupIdx": 248,
    "FullName": "Dulce Larkin",
    "FormalName": "Green Group",
    "Deleted": false,
    "EjUserId": 579,
    "UserName": "Cummings-Orn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 776
      }
    }
  },
  "Task": {
    "TaskListItemId": 463,
    "Value": "occaecati",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "unde",
    "Deleted": false,
    "IntentId": 588,
    "Rank": 361,
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
        "FieldType": "System.String",
        "FieldLength": 155
      }
    }
  },
  "PreferredTZLocation": 229,
  "Sale": {
    "ContactName": "Terry, Padberg and Schulist",
    "SaleDate": "2014-05-10T16:48:28.3984489+02:00",
    "SaleId": 255,
    "Probability": 500,
    "Title": "impedit",
    "Amount": 16553.788,
    "Currency": "adipisci",
    "ProjectName": "Borer, Jakubowski and Davis",
    "AssociateFullName": "Murray Frami",
    "Description": "Profound fresh-thinking Graphic Interface",
    "Status": "Lost",
    "WeightedAmount": 28321.958,
    "ProjectId": 555,
    "EarningPercent": 16641.54,
    "Earning": 14131.206,
    "ContactId": 98,
    "AssociateId": 679,
    "PersonId": 846,
    "SaleTypeId": 266,
    "SaleTypeName": "Considine Group",
    "PersonFullName": "Kurtis Jones",
    "Completed": "Completed",
    "ActiveErpLinks": 414,
    "NextDueDate": "2000-11-04T16:48:28.3984489+01:00",
    "Number": "575961",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 543
      }
    }
  },
  "SuggestedAppointmentId": 272,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "autem",
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quaerat",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "iure",
    "CustomFields2": "voluptatem"
  },
  "PublishEventDate": "2018-02-28T16:48:28.3984489+01:00",
  "PublishTo": "2019-11-22T16:48:28.3984489+01:00",
  "PublishFrom": "1996-08-25T16:48:28.3984489+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 822,
      "Visibility": "All",
      "DisplayValue": "quia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 238
        }
      }
    },
    {
      "VisibleId": 822,
      "Visibility": "All",
      "DisplayValue": "quia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 238
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
      "FieldLength": 23
    }
  }
}
```