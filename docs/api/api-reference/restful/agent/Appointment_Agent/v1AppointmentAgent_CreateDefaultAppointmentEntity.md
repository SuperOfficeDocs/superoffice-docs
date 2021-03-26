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
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 924,
    "Name": "Hartmann Group",
    "PersonId": 554,
    "Rank": 306,
    "Tooltip": "incidunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 312,
    "FullName": "Louvenia Emard",
    "FormalName": "Buckridge, Sawayn and Glover",
    "Deleted": true,
    "EjUserId": 379,
    "UserName": "Kautzer Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 434
      }
    }
  },
  "Contact": {
    "ContactId": 85,
    "Name": "Schroeder Group",
    "OrgNr": "955313",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "nostrum",
    "DirectPhone": "127-752-8075",
    "AssociateId": 417,
    "CountryId": 720,
    "EmailAddress": "ruben@green.biz",
    "Kananame": "rerum",
    "EmailAddressName": "blaise.cartwright@upton.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Riley Lynch",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "sunt",
    "FullName": "Ms. Aileen Hodkiewicz",
    "IsOwnerContact": false,
    "ActiveErpLinks": 454,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "morph dynamic systems"
        },
        "FieldType": "System.Int32",
        "FieldLength": 366
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 987,
    "Name": "Rosenbaum, Lakin and Bergstrom",
    "PersonId": 440,
    "Rank": 443,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 774,
    "FullName": "Lois Rice",
    "FormalName": "Lubowitz, McKenzie and Zulauf",
    "Deleted": true,
    "EjUserId": 215,
    "UserName": "Borer Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 189
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 473,
    "Name": "Murphy, Rice and Senger",
    "PersonId": 105,
    "Rank": 857,
    "Tooltip": "laudantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 1000,
    "FullName": "Bo Rowe",
    "FormalName": "Wolff LLC",
    "Deleted": true,
    "EjUserId": 631,
    "UserName": "Rau, Dicki and Lehner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 805
      }
    }
  },
  "CreatedDate": "2015-03-17T16:48:28.5004541+01:00",
  "AppointmentId": 897,
  "Description": "Reactive logistical matrix",
  "StartDate": "2007-05-29T16:48:28.5004541+02:00",
  "EndDate": "2014-05-04T16:48:28.5004541+02:00",
  "InvitedPerson": {
    "Position": "quos",
    "PersonId": 492,
    "Mrmrs": "hic",
    "Firstname": "Lula",
    "Lastname": "Rutherford",
    "MiddleName": "Kihn, Witting and McLaughlin",
    "Title": "aut",
    "Description": "Multi-channelled uniform array",
    "Email": "tina.ondricka@gottliebhane.name",
    "FullName": "Devyn Gusikowski",
    "DirectPhone": "068-327-7641 x2818",
    "FormalName": "Lynch, Bogan and Corwin",
    "CountryId": 590,
    "ContactId": 353,
    "ContactName": "Sawayn Group",
    "Retired": 656,
    "Rank": 317,
    "ActiveInterests": 843,
    "ContactDepartment": "",
    "ContactCountryId": 691,
    "ContactOrgNr": "702412",
    "FaxPhone": "631.768.1805 x15452",
    "MobilePhone": "1-546-716-8327 x303",
    "ContactPhone": "(058)255-8105",
    "AssociateName": "Davis, Kshlerin and Pollich",
    "AssociateId": 115,
    "UsePersonAddress": true,
    "ContactFax": "accusantium",
    "Kanafname": "corporis",
    "Kanalname": "sequi",
    "Post1": "tempore",
    "Post2": "perferendis",
    "Post3": "et",
    "EmailName": "suzanne_breitenberg@armstronglynch.ca",
    "ContactFullName": "Eleanore Auer",
    "ActiveErpLinks": 661,
    "TicketPriorityId": 554,
    "SupportLanguageId": 451,
    "SupportAssociateId": 475,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 191
      }
    }
  },
  "Person": {
    "Position": "modi",
    "PersonId": 87,
    "Mrmrs": "voluptatem",
    "Firstname": "Annamae",
    "Lastname": "Carroll",
    "MiddleName": "West, D'Amore and Gorczany",
    "Title": "mollitia",
    "Description": "Ergonomic client-server leverage",
    "Email": "vidal@murazik.uk",
    "FullName": "Catherine Abshire",
    "DirectPhone": "666.266.7154",
    "FormalName": "Haag-Batz",
    "CountryId": 435,
    "ContactId": 143,
    "ContactName": "Kiehn-Hyatt",
    "Retired": 851,
    "Rank": 422,
    "ActiveInterests": 420,
    "ContactDepartment": "",
    "ContactCountryId": 873,
    "ContactOrgNr": "532922",
    "FaxPhone": "361.651.2630",
    "MobilePhone": "(856)605-1556",
    "ContactPhone": "240.025.8383",
    "AssociateName": "Langosh LLC",
    "AssociateId": 104,
    "UsePersonAddress": true,
    "ContactFax": "at",
    "Kanafname": "asperiores",
    "Kanalname": "et",
    "Post1": "ut",
    "Post2": "qui",
    "Post3": "est",
    "EmailName": "nola@romaguera.com",
    "ContactFullName": "Lelia Ortiz",
    "ActiveErpLinks": 517,
    "TicketPriorityId": 832,
    "SupportLanguageId": 731,
    "SupportAssociateId": 772,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 942
      }
    }
  },
  "MotherId": 66,
  "Priority": {
    "Id": 326,
    "Value": "dicta",
    "Tooltip": "enim",
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
    "ProjectId": 173,
    "Name": "Gleason-Crona",
    "Description": "Upgradable mobile middleware",
    "URL": "http://www.example.com/",
    "Type": "est",
    "AssociateId": 451,
    "AssociateFullName": "Mr. Melany Jaskolski",
    "TypeId": 187,
    "Updated": "2011-12-24T16:48:28.5034503+01:00",
    "StatusId": 613,
    "Status": "natus",
    "TextId": 80,
    "PublishTo": "1998-12-05T16:48:28.5034503+01:00",
    "PublishFrom": "2009-01-14T16:48:28.5034503+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1591743",
    "ActiveErpLinks": 977,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 633
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2020-08-30T16:48:28.5034503+02:00",
  "Completed": "Completed",
  "ActiveLinks": 103,
  "Links": [
    {
      "EntityName": "Brekke-Franecki",
      "Id": 674,
      "Description": "Secured bifurcated framework",
      "ExtraInfo": "exercitationem",
      "LinkId": 493,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "productize open-source architectures"
          },
          "FieldType": "System.String",
          "FieldLength": 513
        }
      }
    }
  ],
  "AlarmLeadTime": "vero",
  "HasAlarm": true,
  "ColorIndex": 481,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "voluptatem",
  "LeadTime": "reprehenderit",
  "Location": "distinctio",
  "RejectCounter": 978,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 56,
    "StartDate": "2018-07-15T16:48:28.5034503+02:00",
    "EndDate": "2004-08-19T16:48:28.5034503+02:00",
    "RecurrenceCounter": 977,
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
      "AssociateId": 473,
      "PersonId": 414,
      "ContactId": 713,
      "EmailId": 742,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 473,
      "PersonId": 414,
      "ContactId": 713,
      "EmailId": 742,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2006-01-20T16:48:28.5044487+01:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 551,
    "Name": "Kunde Inc and Sons",
    "PersonId": 18,
    "Rank": 623,
    "Tooltip": "aspernatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 354,
    "FullName": "Nikki Rosenbaum",
    "FormalName": "Halvorson-Wehner",
    "Deleted": false,
    "EjUserId": 61,
    "UserName": "Prohaska-Kub",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 446
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 341,
    "Name": "Marvin, West and Rodriguez",
    "PersonId": 643,
    "Rank": 951,
    "Tooltip": "neque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 858,
    "FullName": "Dr. Arne Wyman",
    "FormalName": "Wolff LLC",
    "Deleted": false,
    "EjUserId": 643,
    "UserName": "Wilkinson-Hansen",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "revolutionize extensible systems"
        },
        "FieldType": "System.String",
        "FieldLength": 960
      }
    }
  },
  "Task": {
    "TaskListItemId": 710,
    "Value": "similique",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "dolores",
    "Deleted": true,
    "IntentId": 991,
    "Rank": 712,
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
        "FieldType": "System.String",
        "FieldLength": 374
      }
    }
  },
  "PreferredTZLocation": 436,
  "Sale": {
    "ContactName": "Kub-Yost",
    "SaleDate": "2013-05-22T16:48:28.5044487+02:00",
    "SaleId": 791,
    "Probability": 387,
    "Title": "quod",
    "Amount": 25802.221999999998,
    "Currency": "voluptatem",
    "ProjectName": "Wyman Inc and Sons",
    "AssociateFullName": "Elroy Kub",
    "Description": "Devolved foreground artificial intelligence",
    "Status": "Lost",
    "WeightedAmount": 25795.953999999998,
    "ProjectId": 366,
    "EarningPercent": 27447.572,
    "Earning": 23874.811999999998,
    "ContactId": 736,
    "AssociateId": 361,
    "PersonId": 32,
    "SaleTypeId": 376,
    "SaleTypeName": "Schamberger LLC",
    "PersonFullName": "Hazle Kilback",
    "Completed": "Completed",
    "ActiveErpLinks": 564,
    "NextDueDate": "2013-07-03T16:48:28.5054488+02:00",
    "Number": "1219939",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 77
      }
    }
  },
  "SuggestedAppointmentId": 691,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "saepe",
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "580473495"
  },
  "ExtraFields": {
    "ExtraFields1": "nobis",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "vel"
  },
  "PublishEventDate": "2011-03-24T16:48:28.5054488+01:00",
  "PublishTo": "2005-04-05T16:48:28.5054488+02:00",
  "PublishFrom": "2017-10-30T16:48:28.5054488+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 15,
      "Visibility": "All",
      "DisplayValue": "sit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    },
    {
      "VisibleId": 15,
      "Visibility": "All",
      "DisplayValue": "sit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 116
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
      "FieldLength": 179
    }
  }
}
```