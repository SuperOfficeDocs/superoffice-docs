---
title: GET Appointment/default
id: v1AppointmentEntity_DefaultAppointmentEntity
---

# GET Appointment/default

```http
GET /api/v1/Appointment/default
```

Set default values into a new AppointmentEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Appointment agent service CreateDefaultAppointmentEntity.






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
GET /api/v1/Appointment/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 28 Jul 2009 18:25:49 G7T

{
  "Associate": {
    "AssociateId": 276,
    "Name": "Mayer-Pacocha",
    "PersonId": 627,
    "Rank": 743,
    "Tooltip": "praesentium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 996,
    "FullName": "Lamar Cremin",
    "FormalName": "Howell LLC",
    "Deleted": false,
    "EjUserId": 262,
    "UserName": "Greenfelder, Schulist and Leuschke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 238
      }
    }
  },
  "Contact": {
    "ContactId": 699,
    "Name": "Olson, Rolfson and Bartell",
    "OrgNr": "686529",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "temporibus",
    "DirectPhone": "755-043-5575",
    "AssociateId": 734,
    "CountryId": 177,
    "EmailAddress": "lexus@hammeserdman.uk",
    "Kananame": "et",
    "EmailAddressName": "clemens.baumbach@schinnerboyle.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Emily Towne",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "animi",
    "FullName": "Otilia Nicolas",
    "IsOwnerContact": true,
    "ActiveErpLinks": 233,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "facilitate 24/7 e-markets"
        },
        "FieldType": "System.String",
        "FieldLength": 966
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 688,
    "Name": "Collier-McCullough",
    "PersonId": 95,
    "Rank": 52,
    "Tooltip": "veniam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 526,
    "FullName": "Darron Mills",
    "FormalName": "Rippin-Graham",
    "Deleted": false,
    "EjUserId": 308,
    "UserName": "Romaguera-Marvin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 811
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 122,
    "Name": "Doyle, Mayert and Gutkowski",
    "PersonId": 484,
    "Rank": 582,
    "Tooltip": "beatae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 444,
    "FullName": "Georgette Durgan",
    "FormalName": "Brekke Group",
    "Deleted": true,
    "EjUserId": 853,
    "UserName": "Jacobs LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 666
      }
    }
  },
  "CreatedDate": "1996-04-09T18:25:49.8385335+02:00",
  "AppointmentId": 64,
  "Description": "Streamlined fault-tolerant array",
  "StartDate": "2010-04-30T18:25:49.8385335+02:00",
  "EndDate": "2013-09-05T18:25:49.8385335+02:00",
  "InvitedPerson": {
    "Position": "aut",
    "PersonId": 63,
    "Mrmrs": "cumque",
    "Firstname": "Ricky",
    "Lastname": "Bauch",
    "MiddleName": "Kerluke LLC",
    "Title": "exercitationem",
    "Description": "Function-based disintermediate artificial intelligence",
    "Email": "lulu@bruen.uk",
    "FullName": "Candice Ondricka",
    "DirectPhone": "1-544-867-0552 x1415",
    "FormalName": "Balistreri, Windler and Blick",
    "CountryId": 423,
    "ContactId": 246,
    "ContactName": "Herzog-Smitham",
    "Retired": 780,
    "Rank": 194,
    "ActiveInterests": 692,
    "ContactDepartment": "",
    "ContactCountryId": 343,
    "ContactOrgNr": "947841",
    "FaxPhone": "(888)145-4742 x567",
    "MobilePhone": "(144)263-3631",
    "ContactPhone": "(666)876-0272",
    "AssociateName": "Davis-Kertzmann",
    "AssociateId": 316,
    "UsePersonAddress": true,
    "ContactFax": "et",
    "Kanafname": "ut",
    "Kanalname": "distinctio",
    "Post1": "cumque",
    "Post2": "dolorem",
    "Post3": "quasi",
    "EmailName": "theron.dare@simonisveum.info",
    "ContactFullName": "Mervin Skiles",
    "ActiveErpLinks": 672,
    "TicketPriorityId": 599,
    "SupportLanguageId": 580,
    "SupportAssociateId": 459,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 347
      }
    }
  },
  "Person": {
    "Position": "a",
    "PersonId": 238,
    "Mrmrs": "sed",
    "Firstname": "Ruby",
    "Lastname": "King",
    "MiddleName": "Morissette Group",
    "Title": "est",
    "Description": "Streamlined executive methodology",
    "Email": "emie@cartwright.ca",
    "FullName": "Linnie Russel",
    "DirectPhone": "132-188-5741 x587",
    "FormalName": "Bayer LLC",
    "CountryId": 296,
    "ContactId": 54,
    "ContactName": "Bahringer, Abbott and Hahn",
    "Retired": 992,
    "Rank": 385,
    "ActiveInterests": 143,
    "ContactDepartment": "",
    "ContactCountryId": 660,
    "ContactOrgNr": "1373204",
    "FaxPhone": "1-351-750-8371 x107",
    "MobilePhone": "(438)707-2476 x383",
    "ContactPhone": "1-052-178-6060 x68571",
    "AssociateName": "Vandervort, Yundt and Kemmer",
    "AssociateId": 500,
    "UsePersonAddress": false,
    "ContactFax": "suscipit",
    "Kanafname": "corporis",
    "Kanalname": "minima",
    "Post1": "dolor",
    "Post2": "iure",
    "Post3": "optio",
    "EmailName": "felix@stehr.com",
    "ContactFullName": "Queenie Kuvalis",
    "ActiveErpLinks": 579,
    "TicketPriorityId": 955,
    "SupportLanguageId": 125,
    "SupportAssociateId": 108,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 157
      }
    }
  },
  "MotherId": 839,
  "Priority": {
    "Id": 421,
    "Value": "rerum",
    "Tooltip": "enim",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 631
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 739,
    "Name": "Hartmann LLC",
    "Description": "Up-sized didactic intranet",
    "URL": "http://www.example.com/",
    "Type": "ut",
    "AssociateId": 825,
    "AssociateFullName": "Pinkie Leannon",
    "TypeId": 696,
    "Updated": "2012-10-13T18:25:49.8415331+02:00",
    "StatusId": 214,
    "Status": "id",
    "TextId": 200,
    "PublishTo": "1994-12-01T18:25:49.8415331+01:00",
    "PublishFrom": "1996-08-05T18:25:49.8415331+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1227957",
    "ActiveErpLinks": 969,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 81
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2009-07-28T18:25:49.8415331+02:00",
  "Completed": "Completed",
  "ActiveLinks": 560,
  "Links": [
    {
      "EntityName": "Bergstrom Inc and Sons",
      "Id": 244,
      "Description": "Function-based cohesive service-desk",
      "ExtraInfo": "dolorem",
      "LinkId": 294,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 938
        }
      }
    }
  ],
  "AlarmLeadTime": "facere",
  "HasAlarm": true,
  "ColorIndex": 872,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "voluptas",
  "LeadTime": "harum",
  "Location": "distinctio",
  "RejectCounter": 627,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 591,
    "StartDate": "2009-08-15T18:25:49.8425335+02:00",
    "EndDate": "1995-03-07T18:25:49.8425335+01:00",
    "RecurrenceCounter": 375,
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
      "AssociateId": 629,
      "PersonId": 87,
      "ContactId": 971,
      "EmailId": 60,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 629,
      "PersonId": 87,
      "ContactId": 971,
      "EmailId": 60,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2013-11-15T18:25:49.8425335+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 349,
    "Name": "Mraz-Douglas",
    "PersonId": 20,
    "Rank": 124,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 463,
    "FullName": "Miss Johnpaul O'Reilly",
    "FormalName": "Hills-Blick",
    "Deleted": true,
    "EjUserId": 318,
    "UserName": "Strosin, Hodkiewicz and Nikolaus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 813
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 134,
    "Name": "Hand LLC",
    "PersonId": 651,
    "Rank": 342,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 844,
    "FullName": "Hillard Stehr",
    "FormalName": "Nolan-Hane",
    "Deleted": false,
    "EjUserId": 610,
    "UserName": "Kling-Huel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 723
      }
    }
  },
  "Task": {
    "TaskListItemId": 83,
    "Value": "necessitatibus",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "sed",
    "Deleted": false,
    "IntentId": 312,
    "Rank": 652,
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
        "FieldLength": 528
      }
    }
  },
  "PreferredTZLocation": 691,
  "Sale": {
    "ContactName": "Koelpin, Hilll and Fadel",
    "SaleDate": "2020-06-05T18:25:49.8435326+02:00",
    "SaleId": 807,
    "Probability": 956,
    "Title": "harum",
    "Amount": 13118.923999999999,
    "Currency": "sit",
    "ProjectName": "Welch LLC",
    "AssociateFullName": "Mr. Ewell Little",
    "Description": "Seamless systematic installation",
    "Status": "Lost",
    "WeightedAmount": 29437.662,
    "ProjectId": 647,
    "EarningPercent": 23031.766,
    "Earning": 1203.456,
    "ContactId": 239,
    "AssociateId": 198,
    "PersonId": 919,
    "SaleTypeId": 43,
    "SaleTypeName": "Konopelski-Lubowitz",
    "PersonFullName": "Libbie Wintheiser",
    "Completed": "Completed",
    "ActiveErpLinks": 916,
    "NextDueDate": "1996-11-19T18:25:49.8435326+01:00",
    "Number": "441596",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 670
      }
    }
  },
  "SuggestedAppointmentId": 511,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "praesentium",
  "UserDefinedFields": {
    "SuperOffice:1": "Rodolfo Kihn",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "assumenda",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "eos"
  },
  "PublishEventDate": "2007-06-11T18:25:49.8435326+02:00",
  "PublishTo": "2017-03-24T18:25:49.8435326+01:00",
  "PublishFrom": "1995-11-28T18:25:49.8435326+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 415,
      "Visibility": "All",
      "DisplayValue": "soluta",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 466
        }
      }
    },
    {
      "VisibleId": 415,
      "Visibility": "All",
      "DisplayValue": "soluta",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 466
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
      "FieldLength": 459
    }
  }
}
```