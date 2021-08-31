---
title: CreateDefaultReOpenAppointment
id: v1AppointmentAgent_CreateDefaultReOpenAppointment
---

# CreateDefaultReOpenAppointment

```http
POST /api/v1/Agents/Appointment/CreateDefaultReOpenAppointment
```

A re-open appointment should be created as a reminder to re-open the sale at a certain date with information regarding the stalled sale.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateDefaultReOpenAppointment?$select=name,department,category/id
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

SaleId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleId | int32 |  |


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
POST /api/v1/Agents/Appointment/CreateDefaultReOpenAppointment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SaleId": 549
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 409,
    "Name": "Barton, Schoen and Price",
    "PersonId": 144,
    "Rank": 405,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 496,
    "FullName": "Wilhelm Wilderman",
    "FormalName": "Daniel-Kirlin",
    "Deleted": false,
    "EjUserId": 904,
    "UserName": "Schowalter-O'Hara",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 240
      }
    }
  },
  "Contact": {
    "ContactId": 818,
    "Name": "Balistreri-Huels",
    "OrgNr": "1190362",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dolores",
    "DirectPhone": "664-282-8436 x6548",
    "AssociateId": 67,
    "CountryId": 386,
    "EmailAddress": "lela_romaguera@kunze.uk",
    "Kananame": "alias",
    "EmailAddressName": "brendon.goyette@aufderhar.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Megane Johnson",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "voluptatum",
    "FullName": "Mollie Walter",
    "IsOwnerContact": true,
    "ActiveErpLinks": 981,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 133
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 333,
    "Name": "O'Connell-Monahan",
    "PersonId": 223,
    "Rank": 382,
    "Tooltip": "magnam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 1001,
    "FullName": "Torrey Klocko",
    "FormalName": "Cole, Berge and Hermiston",
    "Deleted": false,
    "EjUserId": 755,
    "UserName": "Konopelski-Herzog",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 227
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 28,
    "Name": "Haag-Cummings",
    "PersonId": 971,
    "Rank": 84,
    "Tooltip": "nihil",
    "Type": "AnonymousAssociate",
    "GroupIdx": 826,
    "FullName": "Merlin Schmeler",
    "FormalName": "Labadie-Dare",
    "Deleted": true,
    "EjUserId": 422,
    "UserName": "Lind-Becker",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 624
      }
    }
  },
  "CreatedDate": "2000-09-19T14:58:02.987538+02:00",
  "AppointmentId": 492,
  "Description": "Face to face multi-state utilisation",
  "StartDate": "2004-06-19T14:58:02.987538+02:00",
  "EndDate": "2002-06-15T14:58:02.987538+02:00",
  "InvitedPerson": {
    "Position": "asperiores",
    "PersonId": 355,
    "Mrmrs": "earum",
    "Firstname": "Hilton",
    "Lastname": "Bartell",
    "MiddleName": "Stanton, Rolfson and Ziemann",
    "Title": "et",
    "Description": "Profit-focused upward-trending extranet",
    "Email": "eino@lindgren.ca",
    "FullName": "Austen Mayert Sr.",
    "DirectPhone": "1-157-071-8270 x426",
    "FormalName": "Satterfield-Pouros",
    "CountryId": 303,
    "ContactId": 939,
    "ContactName": "Price-Wolff",
    "Retired": 839,
    "Rank": 177,
    "ActiveInterests": 170,
    "ContactDepartment": "",
    "ContactCountryId": 720,
    "ContactOrgNr": "496435",
    "FaxPhone": "(723)677-2061 x14312",
    "MobilePhone": "051.487.1045 x335",
    "ContactPhone": "(004)387-1475 x4556",
    "AssociateName": "Donnelly-Macejkovic",
    "AssociateId": 716,
    "UsePersonAddress": false,
    "ContactFax": "ipsam",
    "Kanafname": "recusandae",
    "Kanalname": "alias",
    "Post1": "aspernatur",
    "Post2": "veniam",
    "Post3": "praesentium",
    "EmailName": "hermina.becker@wunsch.com",
    "ContactFullName": "Imogene McDermott",
    "ActiveErpLinks": 786,
    "TicketPriorityId": 590,
    "SupportLanguageId": 18,
    "SupportAssociateId": 254,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 283
      }
    }
  },
  "Person": {
    "Position": "et",
    "PersonId": 471,
    "Mrmrs": "ex",
    "Firstname": "Vivien",
    "Lastname": "Daugherty",
    "MiddleName": "Harris-Barrows",
    "Title": "quo",
    "Description": "Digitized homogeneous artificial intelligence",
    "Email": "cristopher_raynor@emardkreiger.ca",
    "FullName": "Broderick Rempel",
    "DirectPhone": "376.665.0273",
    "FormalName": "Parisian-Bogan",
    "CountryId": 823,
    "ContactId": 366,
    "ContactName": "Buckridge, Osinski and Moen",
    "Retired": 401,
    "Rank": 309,
    "ActiveInterests": 485,
    "ContactDepartment": "",
    "ContactCountryId": 39,
    "ContactOrgNr": "1393202",
    "FaxPhone": "1-040-885-5765",
    "MobilePhone": "021.122.7755",
    "ContactPhone": "(647)420-7468 x02876",
    "AssociateName": "Kozey-Becker",
    "AssociateId": 477,
    "UsePersonAddress": false,
    "ContactFax": "neque",
    "Kanafname": "expedita",
    "Kanalname": "eius",
    "Post1": "amet",
    "Post2": "sed",
    "Post3": "eaque",
    "EmailName": "craig_mraz@hilpert.ca",
    "ContactFullName": "Davon Swaniawski",
    "ActiveErpLinks": 404,
    "TicketPriorityId": 973,
    "SupportLanguageId": 992,
    "SupportAssociateId": 245,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 358
      }
    }
  },
  "MotherId": 822,
  "Priority": {
    "Id": 158,
    "Value": "eius",
    "Tooltip": "optio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 911
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 326,
    "Name": "Bradtke-Adams",
    "Description": "Multi-layered object-oriented website",
    "URL": "http://www.example.com/",
    "Type": "nihil",
    "AssociateId": 106,
    "AssociateFullName": "Taurean Altenwerth",
    "TypeId": 396,
    "Updated": "2013-09-12T14:58:02.9895382+02:00",
    "StatusId": 361,
    "Status": "consequatur",
    "TextId": 975,
    "PublishTo": "2000-12-23T14:58:02.9895382+01:00",
    "PublishFrom": "2004-10-07T14:58:02.9895382+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "877766",
    "ActiveErpLinks": 883,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 929
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2016-04-02T14:58:02.9895382+02:00",
  "Completed": "Completed",
  "ActiveLinks": 653,
  "Links": [
    {
      "EntityName": "Volkman LLC",
      "Id": 304,
      "Description": "Versatile impactful instruction set",
      "ExtraInfo": "laudantium",
      "LinkId": 323,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 562
        }
      }
    }
  ],
  "AlarmLeadTime": "minima",
  "HasAlarm": true,
  "ColorIndex": 532,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "inventore",
  "LeadTime": "distinctio",
  "Location": "consequuntur",
  "RejectCounter": 271,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 768,
    "StartDate": "2016-10-08T14:58:02.9905382+02:00",
    "EndDate": "2005-07-22T14:58:02.9905382+02:00",
    "RecurrenceCounter": 909,
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
      "AssociateId": 482,
      "PersonId": 927,
      "ContactId": 58,
      "EmailId": 721,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 482,
      "PersonId": 927,
      "ContactId": 58,
      "EmailId": 721,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2005-05-15T14:58:02.9905382+02:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 641,
    "Name": "Cummings-West",
    "PersonId": 593,
    "Rank": 307,
    "Tooltip": "quae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 246,
    "FullName": "Miss Darrell Spencer",
    "FormalName": "Sawayn LLC",
    "Deleted": true,
    "EjUserId": 735,
    "UserName": "Kuhn-Wuckert",
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
  "MotherAssociate": {
    "AssociateId": 812,
    "Name": "Parker, Schiller and Turcotte",
    "PersonId": 804,
    "Rank": 66,
    "Tooltip": "atque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 566,
    "FullName": "Kyra Goyette",
    "FormalName": "Ledner-Runolfsdottir",
    "Deleted": true,
    "EjUserId": 471,
    "UserName": "Senger Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 872
      }
    }
  },
  "Task": {
    "TaskListItemId": 368,
    "Value": "rem",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "deserunt",
    "Deleted": true,
    "IntentId": 497,
    "Rank": 442,
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
        "FieldType": "System.String",
        "FieldLength": 221
      }
    }
  },
  "PreferredTZLocation": 809,
  "Sale": {
    "ContactName": "King, Simonis and Wintheiser",
    "SaleDate": "2015-10-23T14:58:02.9905382+02:00",
    "SaleId": 389,
    "Probability": 877,
    "Title": "blanditiis",
    "Amount": 29196.343999999997,
    "Currency": "aut",
    "ProjectName": "Bartoletti LLC",
    "AssociateFullName": "Loma Shanahan",
    "Description": "Stand-alone optimal contingency",
    "Status": "Lost",
    "WeightedAmount": 24670.847999999998,
    "ProjectId": 76,
    "EarningPercent": 5174.2339999999995,
    "Earning": 1886.668,
    "ContactId": 123,
    "AssociateId": 263,
    "PersonId": 579,
    "SaleTypeId": 694,
    "SaleTypeName": "Yost-Klein",
    "PersonFullName": "Chadd Von",
    "Completed": "Completed",
    "ActiveErpLinks": 509,
    "NextDueDate": "2009-06-12T14:58:02.9915381+02:00",
    "Number": "1357689",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 100
      }
    }
  },
  "SuggestedAppointmentId": 354,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "eum",
  "UserDefinedFields": {
    "SuperOffice:1": "1136225966",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "nam",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "iste"
  },
  "PublishEventDate": "2000-10-06T14:58:02.9915381+02:00",
  "PublishTo": "2010-07-10T14:58:02.9915381+02:00",
  "PublishFrom": "2011-12-18T14:58:02.9915381+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 138,
      "Visibility": "All",
      "DisplayValue": "reprehenderit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    },
    {
      "VisibleId": 138,
      "Visibility": "All",
      "DisplayValue": "reprehenderit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 793
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
      "FieldLength": 417
    }
  }
}
```