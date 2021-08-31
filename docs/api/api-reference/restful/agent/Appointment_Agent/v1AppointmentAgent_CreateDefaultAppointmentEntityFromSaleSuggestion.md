---
title: CreateDefaultAppointmentEntityFromSaleSuggestion
id: v1AppointmentAgent_CreateDefaultAppointmentEntityFromSaleSuggestion
---

# CreateDefaultAppointmentEntityFromSaleSuggestion

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 291,
  "SaleId": 282,
  "CreateNow": false,
  "OwnerId": 814
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 202,
    "Name": "Bayer Group",
    "PersonId": 238,
    "Rank": 305,
    "Tooltip": "recusandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 797,
    "FullName": "Ollie Renner",
    "FormalName": "Nitzsche Inc and Sons",
    "Deleted": false,
    "EjUserId": 211,
    "UserName": "Schneider Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 847
      }
    }
  },
  "Contact": {
    "ContactId": 520,
    "Name": "Turner-Kling",
    "OrgNr": "1080925",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "laborum",
    "DirectPhone": "024.358.8168 x84668",
    "AssociateId": 838,
    "CountryId": 251,
    "EmailAddress": "triston_will@wilkinson.name",
    "Kananame": "deleniti",
    "EmailAddressName": "dortha@lemkecarroll.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ryley Kirlin",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "laborum",
    "FullName": "Selina Bayer",
    "IsOwnerContact": false,
    "ActiveErpLinks": 137,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 207
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 483,
    "Name": "Glover, Borer and Gulgowski",
    "PersonId": 661,
    "Rank": 40,
    "Tooltip": "aliquid",
    "Type": "AnonymousAssociate",
    "GroupIdx": 691,
    "FullName": "Maudie Kris",
    "FormalName": "Koelpin, Hartmann and Hickle",
    "Deleted": true,
    "EjUserId": 352,
    "UserName": "Buckridge LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 80
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 912,
    "Name": "Schuppe Inc and Sons",
    "PersonId": 654,
    "Rank": 192,
    "Tooltip": "repellat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 5,
    "FullName": "Daryl Klocko",
    "FormalName": "Huel LLC",
    "Deleted": true,
    "EjUserId": 114,
    "UserName": "Doyle, Huels and Emard",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 732
      }
    }
  },
  "CreatedDate": "2011-08-30T14:58:02.9715409+02:00",
  "AppointmentId": 114,
  "Description": "Horizontal encompassing secured line",
  "StartDate": "2017-12-19T14:58:02.9715409+01:00",
  "EndDate": "2014-08-26T14:58:02.9715409+02:00",
  "InvitedPerson": {
    "Position": "consequuntur",
    "PersonId": 128,
    "Mrmrs": "aspernatur",
    "Firstname": "Alice",
    "Lastname": "Kub",
    "MiddleName": "Kris, Denesik and Klocko",
    "Title": "magni",
    "Description": "Synergized 6th generation open system",
    "Email": "daryl.auer@parker.co.uk",
    "FullName": "Thea Senger",
    "DirectPhone": "(521)387-1280 x04480",
    "FormalName": "Zulauf, Kilback and Stehr",
    "CountryId": 309,
    "ContactId": 415,
    "ContactName": "Brakus, Kuhic and Carroll",
    "Retired": 420,
    "Rank": 899,
    "ActiveInterests": 435,
    "ContactDepartment": "",
    "ContactCountryId": 516,
    "ContactOrgNr": "586705",
    "FaxPhone": "(777)231-8835 x1252",
    "MobilePhone": "580.104.4716 x2586",
    "ContactPhone": "458.760.1452 x73818",
    "AssociateName": "Little Inc and Sons",
    "AssociateId": 129,
    "UsePersonAddress": false,
    "ContactFax": "dolores",
    "Kanafname": "ab",
    "Kanalname": "voluptatem",
    "Post1": "cum",
    "Post2": "quia",
    "Post3": "voluptatem",
    "EmailName": "jayde@moen.info",
    "ContactFullName": "Melvin Langosh",
    "ActiveErpLinks": 465,
    "TicketPriorityId": 427,
    "SupportLanguageId": 885,
    "SupportAssociateId": 215,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 288
      }
    }
  },
  "Person": {
    "Position": "minus",
    "PersonId": 468,
    "Mrmrs": "sapiente",
    "Firstname": "Louvenia",
    "Lastname": "Wintheiser",
    "MiddleName": "Upton LLC",
    "Title": "vitae",
    "Description": "Multi-layered value-added implementation",
    "Email": "robb.kunze@hackett.uk",
    "FullName": "Deshaun Stark",
    "DirectPhone": "(370)723-1311",
    "FormalName": "Spinka Inc and Sons",
    "CountryId": 319,
    "ContactId": 396,
    "ContactName": "Emard LLC",
    "Retired": 43,
    "Rank": 517,
    "ActiveInterests": 956,
    "ContactDepartment": "",
    "ContactCountryId": 382,
    "ContactOrgNr": "853146",
    "FaxPhone": "848.836.7870 x5570",
    "MobilePhone": "055-056-8452 x71312",
    "ContactPhone": "(174)353-1640 x232",
    "AssociateName": "Nolan-Sawayn",
    "AssociateId": 963,
    "UsePersonAddress": false,
    "ContactFax": "officia",
    "Kanafname": "aut",
    "Kanalname": "ipsa",
    "Post1": "aut",
    "Post2": "impedit",
    "Post3": "quos",
    "EmailName": "osvaldo@morissettejenkins.biz",
    "ContactFullName": "Mallory Ferry",
    "ActiveErpLinks": 665,
    "TicketPriorityId": 445,
    "SupportLanguageId": 931,
    "SupportAssociateId": 553,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 209
      }
    }
  },
  "MotherId": 78,
  "Priority": {
    "Id": 627,
    "Value": "magnam",
    "Tooltip": "labore",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 479
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 430,
    "Name": "Bergnaum-Keebler",
    "Description": "Compatible 24 hour methodology",
    "URL": "http://www.example.com/",
    "Type": "dolor",
    "AssociateId": 706,
    "AssociateFullName": "Sonia Howe II",
    "TypeId": 453,
    "Updated": "2015-12-02T14:58:02.9745411+01:00",
    "StatusId": 147,
    "Status": "aliquam",
    "TextId": 748,
    "PublishTo": "2005-02-03T14:58:02.9745411+01:00",
    "PublishFrom": "2009-12-15T14:58:02.9745411+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "361309",
    "ActiveErpLinks": 637,
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
  "Type": "BookingForChecklist",
  "UpdatedDate": "2020-11-11T14:58:02.9745411+01:00",
  "Completed": "Completed",
  "ActiveLinks": 990,
  "Links": [
    {
      "EntityName": "Orn LLC",
      "Id": 13,
      "Description": "Streamlined interactive workforce",
      "ExtraInfo": "omnis",
      "LinkId": 504,
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
    }
  ],
  "AlarmLeadTime": "doloremque",
  "HasAlarm": true,
  "ColorIndex": 956,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "alias",
  "LeadTime": "temporibus",
  "Location": "blanditiis",
  "RejectCounter": 771,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 991,
    "StartDate": "2000-07-16T14:58:02.9745411+02:00",
    "EndDate": "1999-01-08T14:58:02.9745411+01:00",
    "RecurrenceCounter": 102,
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
      "AssociateId": 785,
      "PersonId": 613,
      "ContactId": 136,
      "EmailId": 949,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 785,
      "PersonId": 613,
      "ContactId": 136,
      "EmailId": 949,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2012-08-17T14:58:02.9745411+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 16,
    "Name": "Moore LLC",
    "PersonId": 515,
    "Rank": 924,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 237,
    "FullName": "Ramiro O'Reilly",
    "FormalName": "Ryan-Dickens",
    "Deleted": false,
    "EjUserId": 7,
    "UserName": "Sporer, Breitenberg and Ernser",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 364
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 8,
    "Name": "Wolf-Brakus",
    "PersonId": 351,
    "Rank": 469,
    "Tooltip": "doloribus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 489,
    "FullName": "Jay Gerhold PhD",
    "FormalName": "Boehm Inc and Sons",
    "Deleted": false,
    "EjUserId": 886,
    "UserName": "Konopelski, Mante and Weber",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 627
      }
    }
  },
  "Task": {
    "TaskListItemId": 486,
    "Value": "autem",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "voluptatem",
    "Deleted": false,
    "IntentId": 480,
    "Rank": 565,
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
        "FieldLength": 436
      }
    }
  },
  "PreferredTZLocation": 748,
  "Sale": {
    "ContactName": "Nolan, Bahringer and Altenwerth",
    "SaleDate": "2019-09-28T14:58:02.9755411+02:00",
    "SaleId": 526,
    "Probability": 620,
    "Title": "odio",
    "Amount": 15231.24,
    "Currency": "ipsam",
    "ProjectName": "Spencer, Wiza and Roberts",
    "AssociateFullName": "Barrett Yost",
    "Description": "Innovative attitude-oriented website",
    "Status": "Lost",
    "WeightedAmount": 16306.202,
    "ProjectId": 130,
    "EarningPercent": 29437.662,
    "Earning": 14165.68,
    "ContactId": 451,
    "AssociateId": 798,
    "PersonId": 632,
    "SaleTypeId": 650,
    "SaleTypeName": "Heller-Tromp",
    "PersonFullName": "Roman Fahey",
    "Completed": "Completed",
    "ActiveErpLinks": 318,
    "NextDueDate": "2003-02-02T14:58:02.9765412+01:00",
    "Number": "730513",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 771
      }
    }
  },
  "SuggestedAppointmentId": 183,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "quis",
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Osvaldo Waelchi",
    "SuperOffice:2": "1889241117"
  },
  "ExtraFields": {
    "ExtraFields1": "architecto",
    "ExtraFields2": "explicabo"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "sapiente"
  },
  "PublishEventDate": "1999-08-23T14:58:02.9765412+02:00",
  "PublishTo": "1994-08-29T14:58:02.9765412+02:00",
  "PublishFrom": "2018-01-14T14:58:02.9765412+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 867,
      "Visibility": "All",
      "DisplayValue": "sint",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 367
        }
      }
    },
    {
      "VisibleId": 867,
      "Visibility": "All",
      "DisplayValue": "sint",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 367
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
      "FieldLength": 344
    }
  }
}
```