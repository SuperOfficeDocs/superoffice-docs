---
title: POST Agents/Appointment/CreateDefaultAppointmentEntityFromSaleSuggestion
id: v1AppointmentAgent_CreateDefaultAppointmentEntityFromSaleSuggestion
---

# POST Agents/Appointment/CreateDefaultAppointmentEntityFromSaleSuggestion

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityFromSaleSuggestion
```

Creates an appointment based on a suggested appointment.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityFromSaleSuggestion?$select=name,department,category/id
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

SuggestedAppointmentId, SaleId, CreateNow, OwnerId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SuggestedAppointmentId | int32 |  |
| SaleId | int32 |  |
| CreateNow | bool |  |
| OwnerId | int32 |  |


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
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityFromSaleSuggestion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 411,
  "SaleId": 446,
  "CreateNow": true,
  "OwnerId": 224
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 227,
    "Name": "Lueilwitz Inc and Sons",
    "PersonId": 941,
    "Rank": 766,
    "Tooltip": "veritatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 163,
    "FullName": "Nicholaus Crist",
    "FormalName": "VonRueden, Fadel and Jerde",
    "Deleted": true,
    "EjUserId": 804,
    "UserName": "Zboncak Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 525
      }
    }
  },
  "Contact": {
    "ContactId": 574,
    "Name": "Steuber Group",
    "OrgNr": "695166",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ab",
    "DirectPhone": "(833)074-1407 x1358",
    "AssociateId": 783,
    "CountryId": 414,
    "EmailAddress": "corbin_klein@cremin.uk",
    "Kananame": "nesciunt",
    "EmailAddressName": "clementina@lueilwitz.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Elvis Blanda",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "facere",
    "FullName": "Jaydon Mayer III",
    "IsOwnerContact": true,
    "ActiveErpLinks": 791,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "brand plug-and-play channels"
        },
        "FieldType": "System.String",
        "FieldLength": 832
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 749,
    "Name": "Mertz-Huel",
    "PersonId": 761,
    "Rank": 985,
    "Tooltip": "vero",
    "Type": "AnonymousAssociate",
    "GroupIdx": 303,
    "FullName": "Lilyan Kutch",
    "FormalName": "Konopelski Group",
    "Deleted": true,
    "EjUserId": 609,
    "UserName": "Kerluke, Spencer and Armstrong",
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
    "AssociateId": 567,
    "Name": "Beahan Group",
    "PersonId": 272,
    "Rank": 992,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 995,
    "FullName": "Dr. Katrine Bosco",
    "FormalName": "Trantow LLC",
    "Deleted": true,
    "EjUserId": 581,
    "UserName": "Spencer, Prosacco and Weber",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "monetize dot-com technologies"
        },
        "FieldType": "System.String",
        "FieldLength": 732
      }
    }
  },
  "CreatedDate": "2014-02-15T18:28:47.8128268+01:00",
  "AppointmentId": 720,
  "Description": "Optimized value-added Graphical User Interface",
  "StartDate": "1996-05-16T18:28:47.8128268+02:00",
  "EndDate": "1999-09-14T18:28:47.8128268+02:00",
  "InvitedPerson": {
    "Position": "doloremque",
    "PersonId": 10,
    "Mrmrs": "omnis",
    "Firstname": "Alexzander",
    "Lastname": "Kozey",
    "MiddleName": "Kunze-Bednar",
    "Title": "ea",
    "Description": "User-centric human-resource collaboration",
    "Email": "amalia@stoltenberg.ca",
    "FullName": "Jeramie Moore",
    "DirectPhone": "1-263-256-0041 x5106",
    "FormalName": "Romaguera-McLaughlin",
    "CountryId": 275,
    "ContactId": 885,
    "ContactName": "Baumbach Inc and Sons",
    "Retired": 96,
    "Rank": 422,
    "ActiveInterests": 503,
    "ContactDepartment": "",
    "ContactCountryId": 558,
    "ContactOrgNr": "1025521",
    "FaxPhone": "048.066.2148",
    "MobilePhone": "1-780-678-1580",
    "ContactPhone": "(556)058-7512 x8100",
    "AssociateName": "Bahringer Group",
    "AssociateId": 694,
    "UsePersonAddress": true,
    "ContactFax": "qui",
    "Kanafname": "impedit",
    "Kanalname": "nostrum",
    "Post1": "eligendi",
    "Post2": "architecto",
    "Post3": "et",
    "EmailName": "flavio@ullrichhodkiewicz.us",
    "ContactFullName": "Camren Hane",
    "ActiveErpLinks": 357,
    "TicketPriorityId": 831,
    "SupportLanguageId": 827,
    "SupportAssociateId": 63,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 672
      }
    }
  },
  "Person": {
    "Position": "rerum",
    "PersonId": 239,
    "Mrmrs": "velit",
    "Firstname": "Laury",
    "Lastname": "Stamm",
    "MiddleName": "Torphy, Lang and Schiller",
    "Title": "quaerat",
    "Description": "De-engineered intermediate pricing structure",
    "Email": "louvenia_nitzsche@stanton.us",
    "FullName": "Camila Beier",
    "DirectPhone": "152.400.0112 x76524",
    "FormalName": "Smith, McKenzie and Bernhard",
    "CountryId": 194,
    "ContactId": 285,
    "ContactName": "Berge Inc and Sons",
    "Retired": 936,
    "Rank": 338,
    "ActiveInterests": 521,
    "ContactDepartment": "",
    "ContactCountryId": 215,
    "ContactOrgNr": "1290634",
    "FaxPhone": "(474)222-4213",
    "MobilePhone": "660-083-7480 x7605",
    "ContactPhone": "1-564-281-8526 x62550",
    "AssociateName": "Bins, Ward and Kihn",
    "AssociateId": 385,
    "UsePersonAddress": false,
    "ContactFax": "ut",
    "Kanafname": "voluptate",
    "Kanalname": "quam",
    "Post1": "dolor",
    "Post2": "ratione",
    "Post3": "et",
    "EmailName": "maia@rempel.uk",
    "ContactFullName": "Cecelia Spinka",
    "ActiveErpLinks": 354,
    "TicketPriorityId": 230,
    "SupportLanguageId": 105,
    "SupportAssociateId": 270,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 795
      }
    }
  },
  "MotherId": 781,
  "Priority": {
    "Id": 599,
    "Value": "iure",
    "Tooltip": "voluptatum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 797
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 424,
    "Name": "Marks-Dare",
    "Description": "Phased composite synergy",
    "URL": "http://www.example.com/",
    "Type": "aut",
    "AssociateId": 234,
    "AssociateFullName": "Alexandro Nolan",
    "TypeId": 369,
    "Updated": "2021-04-06T18:28:47.8158159+02:00",
    "StatusId": 916,
    "Status": "corporis",
    "TextId": 115,
    "PublishTo": "2008-02-05T18:28:47.8158159+01:00",
    "PublishFrom": "2005-12-15T18:28:47.8158159+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1243129",
    "ActiveErpLinks": 913,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 272
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "1995-05-08T18:28:47.816836+02:00",
  "Completed": "Completed",
  "ActiveLinks": 618,
  "Links": [
    {
      "EntityName": "Rogahn Inc and Sons",
      "Id": 783,
      "Description": "Balanced hybrid application",
      "ExtraInfo": "atque",
      "LinkId": 146,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 560
        }
      }
    }
  ],
  "AlarmLeadTime": "impedit",
  "HasAlarm": false,
  "ColorIndex": 521,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "non",
  "LeadTime": "cum",
  "Location": "voluptatem",
  "RejectCounter": 156,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 986,
    "StartDate": "2019-05-27T18:28:47.816836+02:00",
    "EndDate": "2014-06-18T18:28:47.816836+02:00",
    "RecurrenceCounter": 264,
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
      "AssociateId": 621,
      "PersonId": 734,
      "ContactId": 134,
      "EmailId": 326,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 621,
      "PersonId": 734,
      "ContactId": 134,
      "EmailId": 326,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2013-04-22T18:28:47.816836+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 348,
    "Name": "Welch, Ernser and Quitzon",
    "PersonId": 314,
    "Rank": 404,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 259,
    "FullName": "Kole Schamberger",
    "FormalName": "Schulist-Armstrong",
    "Deleted": true,
    "EjUserId": 875,
    "UserName": "King Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 429
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 197,
    "Name": "Kautzer, Schaefer and Sipes",
    "PersonId": 705,
    "Rank": 366,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 304,
    "FullName": "Geoffrey Williamson",
    "FormalName": "Kris, Borer and Casper",
    "Deleted": true,
    "EjUserId": 122,
    "UserName": "Lemke-Klein",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 915
      }
    }
  },
  "Task": {
    "TaskListItemId": 16,
    "Value": "velit",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "veniam",
    "Deleted": true,
    "IntentId": 638,
    "Rank": 867,
    "IsDefaultAlldayEvent": false,
    "IsDefaultFree": true,
    "IsDefaultPublished": false,
    "ColorIndex": "BlueAlt1",
    "DefaultVideomeetingStatus": "NoChange",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "syndicate end-to-end synergies"
        },
        "FieldType": "System.String",
        "FieldLength": 441
      }
    }
  },
  "PreferredTZLocation": 970,
  "Sale": {
    "ContactName": "Armstrong Inc and Sons",
    "SaleDate": "1998-07-03T18:28:47.8178419+02:00",
    "SaleId": 876,
    "Probability": 662,
    "Title": "amet",
    "Amount": 9339.32,
    "Currency": "temporibus",
    "ProjectName": "Hilll-Reichel",
    "AssociateFullName": "Noel Langworth",
    "Description": "Compatible static contingency",
    "Status": "Lost",
    "WeightedAmount": 17305.948,
    "ProjectId": 661,
    "EarningPercent": 25335.255999999998,
    "Earning": 27325.345999999998,
    "ContactId": 36,
    "AssociateId": 663,
    "PersonId": 372,
    "SaleTypeId": 731,
    "SaleTypeName": "Pollich Group",
    "PersonFullName": "Modesta Conn",
    "Completed": "Completed",
    "ActiveErpLinks": 505,
    "NextDueDate": "2011-02-24T18:28:47.8178419+01:00",
    "Number": "864889",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 338
      }
    }
  },
  "SuggestedAppointmentId": 766,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "sunt",
  "UserDefinedFields": {
    "SuperOffice:1": "Antonietta Emard",
    "SuperOffice:2": "1089633830"
  },
  "ExtraFields": {
    "ExtraFields1": "incidunt",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "veritatis"
  },
  "PublishEventDate": "2009-12-15T18:28:47.8188163+01:00",
  "PublishTo": "2000-04-10T18:28:47.8188163+02:00",
  "PublishFrom": "2000-09-15T18:28:47.8188163+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 584,
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
          "FieldLength": 939
        }
      }
    },
    {
      "VisibleId": 584,
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
          "FieldLength": 939
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
      "FieldLength": 509
    }
  }
}
```