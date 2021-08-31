---
title: Move
id: v1AppointmentAgent_Move
---

# Move

```http
POST /api/v1/Agents/Appointment/Move
```

Moving a booking to another start time.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/Move?$select=name,department,category/id
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

AppointmentId, NewStartTime, UpdateMode 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentId | int32 |  |
| NewStartTime | date-time |  |
| UpdateMode | string |  |


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
POST /api/v1/Agents/Appointment/Move
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 32,
  "NewStartTime": "2014-01-31T14:58:02.9185754+01:00",
  "UpdateMode": "OnlyThis"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 569,
    "Name": "Deckow LLC",
    "PersonId": 639,
    "Rank": 657,
    "Tooltip": "quis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 769,
    "FullName": "Reece Hartmann",
    "FormalName": "Dickinson LLC",
    "Deleted": true,
    "EjUserId": 622,
    "UserName": "Bode-Upton",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 704
      }
    }
  },
  "Contact": {
    "ContactId": 618,
    "Name": "Kessler LLC",
    "OrgNr": "1594431",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "incidunt",
    "DirectPhone": "1-326-036-5174",
    "AssociateId": 899,
    "CountryId": 504,
    "EmailAddress": "dave@rippin.com",
    "Kananame": "explicabo",
    "EmailAddressName": "janie_aufderhar@andersonveum.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Keyshawn Cartwright",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "autem",
    "FullName": "Carolanne O'Connell",
    "IsOwnerContact": false,
    "ActiveErpLinks": 253,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 541
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 260,
    "Name": "Buckridge, Fay and DuBuque",
    "PersonId": 791,
    "Rank": 933,
    "Tooltip": "amet",
    "Type": "AnonymousAssociate",
    "GroupIdx": 237,
    "FullName": "Malika Sawayn Jr.",
    "FormalName": "Zboncak Group",
    "Deleted": false,
    "EjUserId": 837,
    "UserName": "Thompson Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 510
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 90,
    "Name": "Hessel-Steuber",
    "PersonId": 681,
    "Rank": 738,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 908,
    "FullName": "Rachel Cartwright II",
    "FormalName": "Homenick, Olson and Stroman",
    "Deleted": false,
    "EjUserId": 184,
    "UserName": "McClure-Keebler",
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
  "CreatedDate": "2007-08-30T14:58:02.9285678+02:00",
  "AppointmentId": 379,
  "Description": "Ameliorated non-volatile access",
  "StartDate": "1999-05-14T14:58:02.9285678+02:00",
  "EndDate": "2013-12-17T14:58:02.9285678+01:00",
  "InvitedPerson": {
    "Position": "cupiditate",
    "PersonId": 829,
    "Mrmrs": "iste",
    "Firstname": "Johnnie",
    "Lastname": "Leannon",
    "MiddleName": "Cruickshank-Daugherty",
    "Title": "aut",
    "Description": "Optional human-resource capacity",
    "Email": "bettie@pacochadurgan.com",
    "FullName": "Adelle Bradtke",
    "DirectPhone": "015.771.1874",
    "FormalName": "Lubowitz-Bednar",
    "CountryId": 313,
    "ContactId": 35,
    "ContactName": "Schneider-Johns",
    "Retired": 255,
    "Rank": 457,
    "ActiveInterests": 812,
    "ContactDepartment": "",
    "ContactCountryId": 38,
    "ContactOrgNr": "1236205",
    "FaxPhone": "1-135-134-6342 x86285",
    "MobilePhone": "(687)801-5420 x65381",
    "ContactPhone": "(880)736-1775",
    "AssociateName": "Rice, Runolfsson and Bernhard",
    "AssociateId": 133,
    "UsePersonAddress": true,
    "ContactFax": "et",
    "Kanafname": "inventore",
    "Kanalname": "recusandae",
    "Post1": "delectus",
    "Post2": "inventore",
    "Post3": "dolore",
    "EmailName": "aron.lind@mosciski.us",
    "ContactFullName": "Raegan Labadie",
    "ActiveErpLinks": 30,
    "TicketPriorityId": 812,
    "SupportLanguageId": 975,
    "SupportAssociateId": 119,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 781
      }
    }
  },
  "Person": {
    "Position": "a",
    "PersonId": 493,
    "Mrmrs": "et",
    "Firstname": "Lesly",
    "Lastname": "Cartwright",
    "MiddleName": "Aufderhar, Brown and Bauch",
    "Title": "quia",
    "Description": "Synergistic uniform approach",
    "Email": "josue.morar@grant.us",
    "FullName": "Ms. Erin Frami",
    "DirectPhone": "734.725.2225 x888",
    "FormalName": "Effertz, Weimann and Pagac",
    "CountryId": 183,
    "ContactId": 164,
    "ContactName": "Treutel, Hintz and Walsh",
    "Retired": 159,
    "Rank": 289,
    "ActiveInterests": 633,
    "ContactDepartment": "",
    "ContactCountryId": 151,
    "ContactOrgNr": "1021194",
    "FaxPhone": "271-164-2025",
    "MobilePhone": "473-524-5322 x13634",
    "ContactPhone": "455.103.5516",
    "AssociateName": "Lakin-Kiehn",
    "AssociateId": 350,
    "UsePersonAddress": true,
    "ContactFax": "quaerat",
    "Kanafname": "necessitatibus",
    "Kanalname": "dolorem",
    "Post1": "eum",
    "Post2": "iste",
    "Post3": "atque",
    "EmailName": "blanche_koch@ernser.uk",
    "ContactFullName": "Jed Rolfson",
    "ActiveErpLinks": 44,
    "TicketPriorityId": 217,
    "SupportLanguageId": 694,
    "SupportAssociateId": 493,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 903
      }
    }
  },
  "MotherId": 985,
  "Priority": {
    "Id": 96,
    "Value": "explicabo",
    "Tooltip": "omnis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 267
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 589,
    "Name": "Willms Group",
    "Description": "Open-source mission-critical encoding",
    "URL": "http://www.example.com/",
    "Type": "quis",
    "AssociateId": 341,
    "AssociateFullName": "Myrtie Cummings",
    "TypeId": 775,
    "Updated": "2012-07-07T14:58:02.9315399+02:00",
    "StatusId": 848,
    "Status": "magni",
    "TextId": 181,
    "PublishTo": "1997-05-17T14:58:02.9315399+02:00",
    "PublishFrom": "2008-12-03T14:58:02.9315399+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1458230",
    "ActiveErpLinks": 693,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 208
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2006-11-21T14:58:02.9315399+01:00",
  "Completed": "Completed",
  "ActiveLinks": 133,
  "Links": [
    {
      "EntityName": "Tromp-Lubowitz",
      "Id": 83,
      "Description": "Grass-roots client-driven success",
      "ExtraInfo": "dolor",
      "LinkId": 800,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 135
        }
      }
    }
  ],
  "AlarmLeadTime": "quaerat",
  "HasAlarm": false,
  "ColorIndex": 566,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "optio",
  "LeadTime": "labore",
  "Location": "dolorem",
  "RejectCounter": 703,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 428,
    "StartDate": "2005-07-17T14:58:02.9315399+02:00",
    "EndDate": "2008-07-21T14:58:02.9315399+02:00",
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
    "IsRecurrence": false
  },
  "Participants": [
    {
      "AssociateId": 875,
      "PersonId": 782,
      "ContactId": 767,
      "EmailId": 494,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 875,
      "PersonId": 782,
      "ContactId": 767,
      "EmailId": 494,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2010-10-11T14:58:02.9315399+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 337,
    "Name": "Bradtke, Moen and Kunze",
    "PersonId": 245,
    "Rank": 106,
    "Tooltip": "facere",
    "Type": "AnonymousAssociate",
    "GroupIdx": 782,
    "FullName": "Libby Dickinson",
    "FormalName": "Prosacco-Ryan",
    "Deleted": false,
    "EjUserId": 321,
    "UserName": "Volkman, Rogahn and Kutch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 73
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 478,
    "Name": "Pouros-Jaskolski",
    "PersonId": 450,
    "Rank": 842,
    "Tooltip": "eum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 83,
    "FullName": "Assunta Feest",
    "FormalName": "Emmerich, Steuber and Schiller",
    "Deleted": true,
    "EjUserId": 465,
    "UserName": "Gusikowski LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 352
      }
    }
  },
  "Task": {
    "TaskListItemId": 637,
    "Value": "officia",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "iste",
    "Deleted": true,
    "IntentId": 630,
    "Rank": 960,
    "IsDefaultAlldayEvent": true,
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
        "FieldLength": 957
      }
    }
  },
  "PreferredTZLocation": 501,
  "Sale": {
    "ContactName": "Bernhard Group",
    "SaleDate": "1997-03-14T14:58:02.9325677+01:00",
    "SaleId": 712,
    "Probability": 356,
    "Title": "autem",
    "Amount": 24169.408,
    "Currency": "est",
    "ProjectName": "Quitzon, Boyle and DuBuque",
    "AssociateFullName": "Dedric Sipes",
    "Description": "Managed neutral internet solution",
    "Status": "Lost",
    "WeightedAmount": 2071.574,
    "ProjectId": 262,
    "EarningPercent": 24909.032,
    "Earning": 11345.08,
    "ContactId": 762,
    "AssociateId": 990,
    "PersonId": 950,
    "SaleTypeId": 940,
    "SaleTypeName": "Wisozk Group",
    "PersonFullName": "Dina Mann III",
    "Completed": "Completed",
    "ActiveErpLinks": 475,
    "NextDueDate": "2013-07-04T14:58:02.9335681+02:00",
    "Number": "871766",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 278
      }
    }
  },
  "SuggestedAppointmentId": 722,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "sed",
  "UserDefinedFields": {
    "SuperOffice:1": "412758685",
    "SuperOffice:2": "Mr. Hortense Boyle"
  },
  "ExtraFields": {
    "ExtraFields1": "deserunt",
    "ExtraFields2": "nulla"
  },
  "CustomFields": {
    "CustomFields1": "tenetur",
    "CustomFields2": "eum"
  },
  "PublishEventDate": "2007-09-16T14:58:02.9335681+02:00",
  "PublishTo": "1998-11-14T14:58:02.9335681+01:00",
  "PublishFrom": "2004-03-15T14:58:02.9335681+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 551,
      "Visibility": "All",
      "DisplayValue": "qui",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    },
    {
      "VisibleId": 551,
      "Visibility": "All",
      "DisplayValue": "qui",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 78
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
      "FieldLength": 821
    }
  }
}
```