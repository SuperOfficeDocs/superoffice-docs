---
title: GET Appointment/{id}
id: v1AppointmentEntity_GetAppointmentEntity
---

# GET Appointment/{id}

```http
GET /api/v1/Appointment/{id}
```

Gets a AppointmentEntity object.

Calls the Appointment agent service GetAppointmentEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the AppointmentEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Appointment/{id}?$select=name,department,category/id
GET /api/v1/Appointment/{id}?fk=False
```


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

Appointments appear in the diary, and have links to a Contact/Person and possibly a Project or Sale. They have start and end time+date.



AppointmentEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | AppointmentEntity found. |
| 304 | AppointmentEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

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
GET /api/v1/Appointment/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 AppointmentEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 25 Jul 2016 18:25:49 G7T

{
  "Associate": {
    "AssociateId": 821,
    "Name": "Connelly-Feil",
    "PersonId": 454,
    "Rank": 421,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 281,
    "FullName": "Jovanny Rodriguez",
    "FormalName": "Hodkiewicz, Smith and Carroll",
    "Deleted": true,
    "EjUserId": 403,
    "UserName": "Carroll-Murazik",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 728
      }
    }
  },
  "Contact": {
    "ContactId": 495,
    "Name": "McClure-Gorczany",
    "OrgNr": "579685",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "necessitatibus",
    "DirectPhone": "1-280-141-4044 x8124",
    "AssociateId": 464,
    "CountryId": 447,
    "EmailAddress": "mitchel@dickinsonharber.biz",
    "Kananame": "est",
    "EmailAddressName": "arnulfo.weissnat@dubuque.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Laila Davis",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "dolore",
    "FullName": "Zander Cummerata",
    "IsOwnerContact": true,
    "ActiveErpLinks": 15,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 202
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 66,
    "Name": "Berge, Stracke and Toy",
    "PersonId": 406,
    "Rank": 701,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 336,
    "FullName": "Jacinto Tillman IV",
    "FormalName": "Flatley LLC",
    "Deleted": false,
    "EjUserId": 266,
    "UserName": "Ward, Goyette and Kuhn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 29
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 190,
    "Name": "Bartoletti-Turcotte",
    "PersonId": 547,
    "Rank": 884,
    "Tooltip": "consequuntur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 343,
    "FullName": "Ms. Calista Fadel",
    "FormalName": "Nader LLC",
    "Deleted": true,
    "EjUserId": 516,
    "UserName": "Nolan Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 117
      }
    }
  },
  "CreatedDate": "2007-09-10T18:25:49.9175349+02:00",
  "AppointmentId": 137,
  "Description": "Operative local support",
  "StartDate": "2018-03-01T18:25:49.9175349+01:00",
  "EndDate": "1995-04-26T18:25:49.9175349+02:00",
  "InvitedPerson": {
    "Position": "modi",
    "PersonId": 910,
    "Mrmrs": "et",
    "Firstname": "Marjolaine",
    "Lastname": "Marquardt",
    "MiddleName": "Huel, Mitchell and Tromp",
    "Title": "deleniti",
    "Description": "Cross-group high-level support",
    "Email": "scot_fisher@homenick.name",
    "FullName": "Annabell Kautzer",
    "DirectPhone": "051.374.4001",
    "FormalName": "Hartmann Group",
    "CountryId": 403,
    "ContactId": 254,
    "ContactName": "Strosin Inc and Sons",
    "Retired": 357,
    "Rank": 2,
    "ActiveInterests": 63,
    "ContactDepartment": "",
    "ContactCountryId": 886,
    "ContactOrgNr": "1659030",
    "FaxPhone": "(527)023-2167 x44685",
    "MobilePhone": "(746)528-1100 x632",
    "ContactPhone": "634-881-1077 x06646",
    "AssociateName": "Leannon-Jenkins",
    "AssociateId": 363,
    "UsePersonAddress": false,
    "ContactFax": "ex",
    "Kanafname": "ex",
    "Kanalname": "est",
    "Post1": "est",
    "Post2": "non",
    "Post3": "qui",
    "EmailName": "rubye.balistreri@prosacco.us",
    "ContactFullName": "Mandy Stroman",
    "ActiveErpLinks": 528,
    "TicketPriorityId": 566,
    "SupportLanguageId": 192,
    "SupportAssociateId": 677,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 299
      }
    }
  },
  "Person": {
    "Position": "optio",
    "PersonId": 395,
    "Mrmrs": "et",
    "Firstname": "Blaze",
    "Lastname": "Hoppe",
    "MiddleName": "Barrows LLC",
    "Title": "est",
    "Description": "De-engineered demand-driven service-desk",
    "Email": "fredrick_johns@hessel.biz",
    "FullName": "Brooke Shields",
    "DirectPhone": "443-363-6146",
    "FormalName": "Stroman-Halvorson",
    "CountryId": 890,
    "ContactId": 423,
    "ContactName": "Monahan, Armstrong and Purdy",
    "Retired": 269,
    "Rank": 739,
    "ActiveInterests": 315,
    "ContactDepartment": "",
    "ContactCountryId": 652,
    "ContactOrgNr": "901403",
    "FaxPhone": "1-136-522-3540 x68745",
    "MobilePhone": "514-444-3063 x522",
    "ContactPhone": "618.357.7025",
    "AssociateName": "Gerlach, Terry and Smith",
    "AssociateId": 897,
    "UsePersonAddress": true,
    "ContactFax": "voluptas",
    "Kanafname": "eveniet",
    "Kanalname": "sint",
    "Post1": "sed",
    "Post2": "libero",
    "Post3": "culpa",
    "EmailName": "rusty_beer@hillshilpert.ca",
    "ContactFullName": "Georgianna Ullrich",
    "ActiveErpLinks": 818,
    "TicketPriorityId": 636,
    "SupportLanguageId": 564,
    "SupportAssociateId": 830,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 615
      }
    }
  },
  "MotherId": 547,
  "Priority": {
    "Id": 207,
    "Value": "provident",
    "Tooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 540
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 959,
    "Name": "Ryan, Douglas and Bode",
    "Description": "Monitored static support",
    "URL": "http://www.example.com/",
    "Type": "quas",
    "AssociateId": 467,
    "AssociateFullName": "Ardith Larkin",
    "TypeId": 859,
    "Updated": "2013-07-25T18:25:49.9215336+02:00",
    "StatusId": 265,
    "Status": "est",
    "TextId": 674,
    "PublishTo": "2003-08-01T18:25:49.9215336+02:00",
    "PublishFrom": "2014-12-11T18:25:49.9215336+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "853146",
    "ActiveErpLinks": 370,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 82
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2016-07-25T18:25:49.9215336+02:00",
  "Completed": "Completed",
  "ActiveLinks": 201,
  "Links": [
    {
      "EntityName": "Wolff-Bauch",
      "Id": 434,
      "Description": "Multi-tiered exuding benchmark",
      "ExtraInfo": "ex",
      "LinkId": 109,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 16
        }
      }
    }
  ],
  "AlarmLeadTime": "accusamus",
  "HasAlarm": true,
  "ColorIndex": 390,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "nihil",
  "LeadTime": "exercitationem",
  "Location": "quo",
  "RejectCounter": 126,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 25,
    "StartDate": "2000-09-01T18:25:49.922535+02:00",
    "EndDate": "2004-07-11T18:25:49.922535+02:00",
    "RecurrenceCounter": 272,
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
      "AssociateId": 881,
      "PersonId": 265,
      "ContactId": 833,
      "EmailId": 633,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 881,
      "PersonId": 265,
      "ContactId": 833,
      "EmailId": 633,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2010-12-20T18:25:49.922535+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 827,
    "Name": "Zieme Inc and Sons",
    "PersonId": 22,
    "Rank": 484,
    "Tooltip": "consequuntur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 722,
    "FullName": "Miss Leif Runolfsson",
    "FormalName": "Fadel LLC",
    "Deleted": false,
    "EjUserId": 475,
    "UserName": "Kohler, O'Reilly and Waelchi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 758
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 183,
    "Name": "Bernhard Group",
    "PersonId": 929,
    "Rank": 898,
    "Tooltip": "necessitatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 910,
    "FullName": "Miss Camryn Maggio",
    "FormalName": "Schaefer LLC",
    "Deleted": false,
    "EjUserId": 520,
    "UserName": "Stracke Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 476
      }
    }
  },
  "Task": {
    "TaskListItemId": 591,
    "Value": "nesciunt",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "temporibus",
    "Deleted": false,
    "IntentId": 526,
    "Rank": 804,
    "IsDefaultAlldayEvent": true,
    "IsDefaultFree": false,
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
        "FieldLength": 597
      }
    }
  },
  "PreferredTZLocation": 825,
  "Sale": {
    "ContactName": "Frami Inc and Sons",
    "SaleDate": "1997-11-08T18:25:49.9235476+01:00",
    "SaleId": 548,
    "Probability": 284,
    "Title": "alias",
    "Amount": 27967.816,
    "Currency": "consequatur",
    "ProjectName": "Kris-Kirlin",
    "AssociateFullName": "Darian Rempel",
    "Description": "Managed zero administration matrix",
    "Status": "Lost",
    "WeightedAmount": 13347.706,
    "ProjectId": 42,
    "EarningPercent": 13896.155999999999,
    "Earning": 24028.378,
    "ContactId": 458,
    "AssociateId": 602,
    "PersonId": 671,
    "SaleTypeId": 921,
    "SaleTypeName": "Mohr, Abbott and Spencer",
    "PersonFullName": "Candelario Heaney",
    "Completed": "Completed",
    "ActiveErpLinks": 283,
    "NextDueDate": "1998-11-09T18:25:49.9235476+01:00",
    "Number": "975300",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 797
      }
    }
  },
  "SuggestedAppointmentId": 388,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "beatae",
  "UserDefinedFields": {
    "SuperOffice:1": "Zackary Stiedemann",
    "SuperOffice:2": "Bert Borer"
  },
  "ExtraFields": {
    "ExtraFields1": "quam",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "maiores"
  },
  "PublishEventDate": "2013-09-03T18:25:49.9235476+02:00",
  "PublishTo": "1995-07-10T18:25:49.9235476+02:00",
  "PublishFrom": "2011-04-19T18:25:49.9235476+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 587,
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
          "FieldLength": 382
        }
      }
    },
    {
      "VisibleId": 587,
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
          "FieldLength": 382
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
      "FieldLength": 596
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```