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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 09 Apr 2007 15:05:41 G4T

{
  "Associate": {
    "AssociateId": 168,
    "Name": "Green Group",
    "PersonId": 812,
    "Rank": 582,
    "Tooltip": "doloribus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 823,
    "FullName": "Izaiah Sporer",
    "FormalName": "Gleichner Group",
    "Deleted": true,
    "EjUserId": 136,
    "UserName": "Yundt LLC",
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
    "ContactId": 986,
    "Name": "Friesen LLC",
    "OrgNr": "1558731",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "minus",
    "DirectPhone": "174-514-2645",
    "AssociateId": 491,
    "CountryId": 971,
    "EmailAddress": "brandyn.hegmann@runolfsdottirgrimes.biz",
    "Kananame": "et",
    "EmailAddressName": "chase_kautzer@hettinger.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Berta D'Amore",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "dolor",
    "FullName": "Kenton Borer",
    "IsOwnerContact": true,
    "ActiveErpLinks": 145,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 214
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 17,
    "Name": "Cartwright LLC",
    "PersonId": 373,
    "Rank": 297,
    "Tooltip": "nihil",
    "Type": "AnonymousAssociate",
    "GroupIdx": 154,
    "FullName": "Camren Hauck",
    "FormalName": "Rodriguez, Schuppe and Tremblay",
    "Deleted": true,
    "EjUserId": 550,
    "UserName": "Rosenbaum, Stiedemann and O'Reilly",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 979
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 677,
    "Name": "Littel, Harber and Witting",
    "PersonId": 611,
    "Rank": 967,
    "Tooltip": "fugit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 897,
    "FullName": "Marley Kunde",
    "FormalName": "Bernhard Inc and Sons",
    "Deleted": false,
    "EjUserId": 30,
    "UserName": "Shanahan-Heaney",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 281
      }
    }
  },
  "CreatedDate": "2016-10-05T15:05:41.4722633+02:00",
  "AppointmentId": 456,
  "Description": "Decentralized multimedia architecture",
  "StartDate": "2008-04-18T15:05:41.4722633+02:00",
  "EndDate": "1997-08-12T15:05:41.4722633+02:00",
  "InvitedPerson": {
    "Position": "id",
    "PersonId": 622,
    "Mrmrs": "qui",
    "Firstname": "Hardy",
    "Lastname": "Lind",
    "MiddleName": "Waters-Murphy",
    "Title": "repellat",
    "Description": "Monitored systemic forecast",
    "Email": "paris@hayeswiegand.name",
    "FullName": "Esteban Collins II",
    "DirectPhone": "634.544.3038",
    "FormalName": "Marquardt, Donnelly and Grant",
    "CountryId": 488,
    "ContactId": 145,
    "ContactName": "Rath, Jaskolski and Friesen",
    "Retired": 707,
    "Rank": 419,
    "ActiveInterests": 828,
    "ContactDepartment": "",
    "ContactCountryId": 372,
    "ContactOrgNr": "740809",
    "FaxPhone": "1-812-415-6172 x175",
    "MobilePhone": "446.140.4725",
    "ContactPhone": "1-042-542-4671 x1513",
    "AssociateName": "Mann-Hintz",
    "AssociateId": 283,
    "UsePersonAddress": false,
    "ContactFax": "fuga",
    "Kanafname": "sit",
    "Kanalname": "consequatur",
    "Post1": "sequi",
    "Post2": "nobis",
    "Post3": "quasi",
    "EmailName": "mable_corwin@kihn.us",
    "ContactFullName": "May Baumbach",
    "ActiveErpLinks": 723,
    "TicketPriorityId": 202,
    "SupportLanguageId": 296,
    "SupportAssociateId": 837,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 487
      }
    }
  },
  "Person": {
    "Position": "omnis",
    "PersonId": 642,
    "Mrmrs": "aut",
    "Firstname": "Gina",
    "Lastname": "Conn",
    "MiddleName": "Feest-Gleichner",
    "Title": "voluptates",
    "Description": "Balanced responsive artificial intelligence",
    "Email": "ward@ernserhodkiewicz.co.uk",
    "FullName": "Timmy Morissette",
    "DirectPhone": "581-546-2518 x42556",
    "FormalName": "Botsford Inc and Sons",
    "CountryId": 86,
    "ContactId": 875,
    "ContactName": "Yundt, Walker and Boyle",
    "Retired": 7,
    "Rank": 864,
    "ActiveInterests": 122,
    "ContactDepartment": "",
    "ContactCountryId": 518,
    "ContactOrgNr": "589120",
    "FaxPhone": "024-406-6572 x7750",
    "MobilePhone": "743.057.6050",
    "ContactPhone": "564-617-6823",
    "AssociateName": "Haag Inc and Sons",
    "AssociateId": 371,
    "UsePersonAddress": false,
    "ContactFax": "et",
    "Kanafname": "magni",
    "Kanalname": "excepturi",
    "Post1": "totam",
    "Post2": "sequi",
    "Post3": "laboriosam",
    "EmailName": "orrin.dach@kessler.co.uk",
    "ContactFullName": "Mr. Beaulah Bahringer",
    "ActiveErpLinks": 58,
    "TicketPriorityId": 690,
    "SupportLanguageId": 775,
    "SupportAssociateId": 39,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "envisioneer world-class synergies"
        },
        "FieldType": "System.Int32",
        "FieldLength": 680
      }
    }
  },
  "MotherId": 511,
  "Priority": {
    "Id": 465,
    "Value": "occaecati",
    "Tooltip": "velit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 498
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 118,
    "Name": "Denesik, Ebert and Streich",
    "Description": "Balanced didactic intranet",
    "URL": "http://www.example.com/",
    "Type": "a",
    "AssociateId": 443,
    "AssociateFullName": "Mr. Rex Effertz",
    "TypeId": 433,
    "Updated": "2002-12-26T15:05:41.4752978+01:00",
    "StatusId": 1000,
    "Status": "soluta",
    "TextId": 616,
    "PublishTo": "2010-01-22T15:05:41.4752978+01:00",
    "PublishFrom": "2005-03-17T15:05:41.4752978+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1001296",
    "ActiveErpLinks": 457,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 561
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2007-04-09T15:05:41.4752978+02:00",
  "Completed": "Completed",
  "ActiveLinks": 574,
  "Links": [
    {
      "EntityName": "Stehr, Kessler and Grant",
      "Id": 262,
      "Description": "Innovative homogeneous support",
      "ExtraInfo": "et",
      "LinkId": 355,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 770
        }
      }
    }
  ],
  "AlarmLeadTime": "unde",
  "HasAlarm": true,
  "ColorIndex": 816,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "cupiditate",
  "LeadTime": "voluptas",
  "Location": "et",
  "RejectCounter": 711,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 402,
    "StartDate": "2013-04-11T15:05:41.4752978+02:00",
    "EndDate": "2005-09-12T15:05:41.4752978+02:00",
    "RecurrenceCounter": 122,
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
      "AssociateId": 242,
      "PersonId": 712,
      "ContactId": 601,
      "EmailId": 294,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 242,
      "PersonId": 712,
      "ContactId": 601,
      "EmailId": 294,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2002-11-10T15:05:41.4762997+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 40,
    "Name": "Grady Inc and Sons",
    "PersonId": 27,
    "Rank": 713,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 329,
    "FullName": "Vicenta Olson",
    "FormalName": "Runolfsson-Graham",
    "Deleted": true,
    "EjUserId": 763,
    "UserName": "Renner, Kertzmann and Bahringer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 511
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 523,
    "Name": "Daugherty-Kshlerin",
    "PersonId": 933,
    "Rank": 638,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 649,
    "FullName": "Gillian Gottlieb",
    "FormalName": "Price, Hintz and Windler",
    "Deleted": true,
    "EjUserId": 546,
    "UserName": "Wehner, Purdy and Hilll",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 340
      }
    }
  },
  "Task": {
    "TaskListItemId": 958,
    "Value": "sit",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "sint",
    "Deleted": true,
    "IntentId": 48,
    "Rank": 704,
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
          "Reason": "matrix plug-and-play supply-chains"
        },
        "FieldType": "System.String",
        "FieldLength": 31
      }
    }
  },
  "PreferredTZLocation": 68,
  "Sale": {
    "ContactName": "Wehner Group",
    "SaleDate": "2019-04-16T15:05:41.4773025+02:00",
    "SaleId": 573,
    "Probability": 817,
    "Title": "hic",
    "Amount": 28823.397999999997,
    "Currency": "ullam",
    "ProjectName": "Langosh, Rogahn and Rutherford",
    "AssociateFullName": "Curt Ruecker",
    "Description": "Public-key multi-state moratorium",
    "Status": "Lost",
    "WeightedAmount": 26795.7,
    "ProjectId": 486,
    "EarningPercent": 13570.22,
    "Earning": 3478.74,
    "ContactId": 886,
    "AssociateId": 250,
    "PersonId": 283,
    "SaleTypeId": 636,
    "SaleTypeName": "Kertzmann-Walter",
    "PersonFullName": "Vernon Weber",
    "Completed": "Completed",
    "ActiveErpLinks": 87,
    "NextDueDate": "1995-10-15T15:05:41.4773025+02:00",
    "Number": "416178",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 763
      }
    }
  },
  "SuggestedAppointmentId": 635,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "mollitia",
  "UserDefinedFields": {
    "SuperOffice:1": "Garrison Huels Jr.",
    "SuperOffice:2": "Jaiden Waters"
  },
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "placeat"
  },
  "CustomFields": {
    "CustomFields1": "possimus",
    "CustomFields2": "temporibus"
  },
  "PublishEventDate": "1998-09-25T15:05:41.4782974+02:00",
  "PublishTo": "2018-06-09T15:05:41.4782974+02:00",
  "PublishFrom": "2018-02-01T15:05:41.4782974+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 309,
      "Visibility": "All",
      "DisplayValue": "ut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 800
        }
      }
    },
    {
      "VisibleId": 309,
      "Visibility": "All",
      "DisplayValue": "ut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 800
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
      "FieldLength": 225
    }
  }
}
```