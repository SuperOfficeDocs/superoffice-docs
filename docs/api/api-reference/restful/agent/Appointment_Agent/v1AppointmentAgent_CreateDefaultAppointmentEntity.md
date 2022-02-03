---
title: POST Agents/Appointment/CreateDefaultAppointmentEntity
id: v1AppointmentAgent_CreateDefaultAppointmentEntity
---

# POST Agents/Appointment/CreateDefaultAppointmentEntity

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntity
```

Set default values into a new AppointmentEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 452,
    "Name": "Jewess-Predovic",
    "PersonId": 923,
    "Rank": 33,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 182,
    "FullName": "Nick Effertz",
    "FormalName": "Stracke, Dicki and Stanton",
    "Deleted": false,
    "EjUserId": 764,
    "UserName": "Hodkiewicz, Schamberger and Mante",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 650
      }
    }
  },
  "Contact": {
    "ContactId": 787,
    "Name": "Kessler, Heaney and Conroy",
    "OrgNr": "1804205",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "officia",
    "DirectPhone": "744.012.1363 x734",
    "AssociateId": 277,
    "CountryId": 784,
    "EmailAddress": "vesta@schadenthompson.co.uk",
    "Kananame": "eum",
    "EmailAddressName": "amelia_smith@schaeferhilpert.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Lea Gibson",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ut",
    "FullName": "Frederique Okuneva",
    "IsOwnerContact": true,
    "ActiveErpLinks": 380,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 954
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 538,
    "Name": "Bernhard, Herzog and Schmeler",
    "PersonId": 881,
    "Rank": 872,
    "Tooltip": "impedit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 364,
    "FullName": "Ryleigh Willms III",
    "FormalName": "Quigley-Murray",
    "Deleted": true,
    "EjUserId": 179,
    "UserName": "Rice Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 594
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 3,
    "Name": "Kuphal-Russel",
    "PersonId": 715,
    "Rank": 103,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 770,
    "FullName": "Dr. Jeramy Hamill",
    "FormalName": "Toy-Price",
    "Deleted": true,
    "EjUserId": 91,
    "UserName": "Jakubowski-Greenfelder",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 476
      }
    }
  },
  "CreatedDate": "2019-01-16T18:28:47.9168441+01:00",
  "AppointmentId": 833,
  "Description": "Self-enabling next generation interface",
  "StartDate": "1999-08-25T18:28:47.9168441+02:00",
  "EndDate": "1994-12-08T18:28:47.9168441+01:00",
  "InvitedPerson": {
    "Position": "accusamus",
    "PersonId": 843,
    "Mrmrs": "autem",
    "Firstname": "Lysanne",
    "Lastname": "Baumbach",
    "MiddleName": "Kihn LLC",
    "Title": "et",
    "Description": "Profit-focused scalable standardization",
    "Email": "ronny_daugherty@hammesdibbert.biz",
    "FullName": "Richmond Corwin",
    "DirectPhone": "876-022-0144",
    "FormalName": "Upton, Raynor and Bayer",
    "CountryId": 336,
    "ContactId": 960,
    "ContactName": "Borer, Becker and Wuckert",
    "Retired": 673,
    "Rank": 248,
    "ActiveInterests": 58,
    "ContactDepartment": "",
    "ContactCountryId": 175,
    "ContactOrgNr": "699632",
    "FaxPhone": "(010)353-0263 x4355",
    "MobilePhone": "215-438-2856 x156",
    "ContactPhone": "688-830-2322 x28022",
    "AssociateName": "Ratke-Heaney",
    "AssociateId": 75,
    "UsePersonAddress": false,
    "ContactFax": "et",
    "Kanafname": "aut",
    "Kanalname": "cum",
    "Post1": "velit",
    "Post2": "animi",
    "Post3": "voluptas",
    "EmailName": "jarred@kuvalis.us",
    "ContactFullName": "Blaze Swift",
    "ActiveErpLinks": 851,
    "TicketPriorityId": 364,
    "SupportLanguageId": 156,
    "SupportAssociateId": 413,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 11
      }
    }
  },
  "Person": {
    "Position": "eum",
    "PersonId": 496,
    "Mrmrs": "accusantium",
    "Firstname": "Valentin",
    "Lastname": "Hudson",
    "MiddleName": "Wolff LLC",
    "Title": "sunt",
    "Description": "Upgradable next generation project",
    "Email": "mayra@flatleyschmeler.co.uk",
    "FullName": "Alvis McClure",
    "DirectPhone": "1-881-646-7444 x5334",
    "FormalName": "Buckridge LLC",
    "CountryId": 442,
    "ContactId": 634,
    "ContactName": "Barrows Group",
    "Retired": 145,
    "Rank": 566,
    "ActiveInterests": 691,
    "ContactDepartment": "",
    "ContactCountryId": 370,
    "ContactOrgNr": "1621872",
    "FaxPhone": "1-678-118-1248 x34411",
    "MobilePhone": "1-211-647-3268",
    "ContactPhone": "507-306-4673 x12082",
    "AssociateName": "Quigley, Tromp and Kozey",
    "AssociateId": 470,
    "UsePersonAddress": false,
    "ContactFax": "sunt",
    "Kanafname": "et",
    "Kanalname": "dolor",
    "Post1": "voluptates",
    "Post2": "deserunt",
    "Post3": "voluptatem",
    "EmailName": "lamont@mraz.us",
    "ContactFullName": "Vance Huel",
    "ActiveErpLinks": 304,
    "TicketPriorityId": 683,
    "SupportLanguageId": 132,
    "SupportAssociateId": 796,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 863
      }
    }
  },
  "MotherId": 708,
  "Priority": {
    "Id": 422,
    "Value": "dolores",
    "Tooltip": "non",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 561
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 137,
    "Name": "Kub, Spencer and Parker",
    "Description": "Devolved static extranet",
    "URL": "http://www.example.com/",
    "Type": "quis",
    "AssociateId": 151,
    "AssociateFullName": "Laurine Langworth",
    "TypeId": 586,
    "Updated": "2019-01-18T18:28:47.9188467+01:00",
    "StatusId": 893,
    "Status": "qui",
    "TextId": 376,
    "PublishTo": "2010-12-24T18:28:47.9188467+01:00",
    "PublishFrom": "2019-05-05T18:28:47.9188467+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "836446",
    "ActiveErpLinks": 295,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 785
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2010-01-15T18:28:47.9188467+01:00",
  "Completed": "Completed",
  "ActiveLinks": 382,
  "Links": [
    {
      "EntityName": "Leffler, Schumm and Spencer",
      "Id": 450,
      "Description": "Polarised empowering implementation",
      "ExtraInfo": "corrupti",
      "LinkId": 558,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 249
        }
      }
    }
  ],
  "AlarmLeadTime": "in",
  "HasAlarm": true,
  "ColorIndex": 675,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "vel",
  "LeadTime": "libero",
  "Location": "occaecati",
  "RejectCounter": 494,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 217,
    "StartDate": "2016-10-30T18:28:47.9198447+01:00",
    "EndDate": "2002-04-11T18:28:47.9198447+02:00",
    "RecurrenceCounter": 955,
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
      "AssociateId": 289,
      "PersonId": 52,
      "ContactId": 811,
      "EmailId": 834,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 289,
      "PersonId": 52,
      "ContactId": 811,
      "EmailId": 834,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2010-12-19T18:28:47.9198447+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 677,
    "Name": "Goldner Inc and Sons",
    "PersonId": 12,
    "Rank": 761,
    "Tooltip": "minima",
    "Type": "AnonymousAssociate",
    "GroupIdx": 716,
    "FullName": "Cesar Beier",
    "FormalName": "Skiles LLC",
    "Deleted": true,
    "EjUserId": 305,
    "UserName": "Schuppe, Jacobs and Gottlieb",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 368
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 842,
    "Name": "Cruickshank Inc and Sons",
    "PersonId": 255,
    "Rank": 717,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 387,
    "FullName": "Adalberto Daniel",
    "FormalName": "Kihn, Weber and Walsh",
    "Deleted": true,
    "EjUserId": 294,
    "UserName": "Rohan, Rice and Effertz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 268
      }
    }
  },
  "Task": {
    "TaskListItemId": 581,
    "Value": "qui",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "facilis",
    "Deleted": false,
    "IntentId": 371,
    "Rank": 119,
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
        "FieldLength": 76
      }
    }
  },
  "PreferredTZLocation": 131,
  "Sale": {
    "ContactName": "Hintz, Kohler and Herman",
    "SaleDate": "1998-07-28T18:28:47.9208447+02:00",
    "SaleId": 528,
    "Probability": 648,
    "Title": "odit",
    "Amount": 29033.376,
    "Currency": "non",
    "ProjectName": "Kilback, Pfeffer and Kerluke",
    "AssociateFullName": "Janick Ebert",
    "Description": "Function-based intangible algorithm",
    "Status": "Lost",
    "WeightedAmount": 25607.914,
    "ProjectId": 399,
    "EarningPercent": 27569.798,
    "Earning": 438.76,
    "ContactId": 975,
    "AssociateId": 404,
    "PersonId": 487,
    "SaleTypeId": 764,
    "SaleTypeName": "Nikolaus-Champlin",
    "PersonFullName": "Constantin Schowalter",
    "Completed": "Completed",
    "ActiveErpLinks": 64,
    "NextDueDate": "1996-07-12T18:28:47.9208447+02:00",
    "Number": "64918",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 1001
      }
    }
  },
  "SuggestedAppointmentId": 465,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "quibusdam",
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1814002027"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "tempore",
    "CustomFields2": "dolorum"
  },
  "PublishEventDate": "2017-05-26T18:28:47.9208447+02:00",
  "PublishTo": "2016-04-21T18:28:47.9208447+02:00",
  "PublishFrom": "1997-07-29T18:28:47.9208447+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 66,
      "Visibility": "All",
      "DisplayValue": "velit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 505
        }
      }
    },
    {
      "VisibleId": 66,
      "Visibility": "All",
      "DisplayValue": "velit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 505
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
      "FieldLength": 185
    }
  }
}
```