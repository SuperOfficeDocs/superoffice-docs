---
title: CreateDefaultAppointmentEntityFromProjectSuggestion
id: v1AppointmentAgent_CreateDefaultAppointmentEntityFromProjectSuggestion
---

# CreateDefaultAppointmentEntityFromProjectSuggestion

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityFromProjectSuggestion
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityFromProjectSuggestion?$select=name,department,category/id
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

SuggestedAppointmentId, ProjectId, CreateNow, OwnerId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SuggestedAppointmentId | int32 |  |
| ProjectId | int32 |  |
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
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityFromProjectSuggestion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 814,
  "ProjectId": 490,
  "CreateNow": false,
  "OwnerId": 194
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 906,
    "Name": "Rodriguez-Gaylord",
    "PersonId": 584,
    "Rank": 952,
    "Tooltip": "quam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 545,
    "FullName": "Hope Zemlak",
    "FormalName": "Rolfson, Kuvalis and Schoen",
    "Deleted": true,
    "EjUserId": 531,
    "UserName": "Waelchi-Fritsch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 834
      }
    }
  },
  "Contact": {
    "ContactId": 964,
    "Name": "Will, Spinka and Hand",
    "OrgNr": "921606",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "velit",
    "DirectPhone": "1-272-282-0804 x38217",
    "AssociateId": 234,
    "CountryId": 27,
    "EmailAddress": "maddison_durgan@rohan.uk",
    "Kananame": "eius",
    "EmailAddressName": "madalyn.labadie@marvinkunde.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Fritz Adams DVM",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "fuga",
    "FullName": "Emile Littel",
    "IsOwnerContact": false,
    "ActiveErpLinks": 629,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 756
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 764,
    "Name": "Murray, Reilly and Hand",
    "PersonId": 31,
    "Rank": 316,
    "Tooltip": "ducimus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 823,
    "FullName": "Mrs. Donavon Vandervort",
    "FormalName": "Romaguera-Prohaska",
    "Deleted": false,
    "EjUserId": 7,
    "UserName": "Wolf-O'Reilly",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 435
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 444,
    "Name": "Smith-Feeney",
    "PersonId": 705,
    "Rank": 927,
    "Tooltip": "atque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 708,
    "FullName": "Chad Emard",
    "FormalName": "Kirlin, Luettgen and Miller",
    "Deleted": false,
    "EjUserId": 550,
    "UserName": "Bayer, Nicolas and Gaylord",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 906
      }
    }
  },
  "CreatedDate": "2018-12-16T14:58:03.0005384+01:00",
  "AppointmentId": 787,
  "Description": "Cross-group homogeneous budgetary management",
  "StartDate": "2005-01-14T14:58:03.0005384+01:00",
  "EndDate": "2005-05-04T14:58:03.0005384+02:00",
  "InvitedPerson": {
    "Position": "velit",
    "PersonId": 615,
    "Mrmrs": "sed",
    "Firstname": "Candace",
    "Lastname": "King",
    "MiddleName": "Dickens, Thiel and Turner",
    "Title": "ut",
    "Description": "Compatible cohesive Graphical User Interface",
    "Email": "fernando@schinner.info",
    "FullName": "Vincenza Greenfelder",
    "DirectPhone": "076.526.5500 x8463",
    "FormalName": "Gaylord-Kihn",
    "CountryId": 379,
    "ContactId": 971,
    "ContactName": "Mitchell-Schroeder",
    "Retired": 898,
    "Rank": 369,
    "ActiveInterests": 55,
    "ContactDepartment": "transform wireless eyeballs",
    "ContactCountryId": 66,
    "ContactOrgNr": "810220",
    "FaxPhone": "(315)055-1860 x14565",
    "MobilePhone": "1-137-871-1824",
    "ContactPhone": "1-563-872-5227",
    "AssociateName": "Stiedemann Group",
    "AssociateId": 774,
    "UsePersonAddress": true,
    "ContactFax": "omnis",
    "Kanafname": "saepe",
    "Kanalname": "blanditiis",
    "Post1": "deleniti",
    "Post2": "cumque",
    "Post3": "expedita",
    "EmailName": "damaris_rodriguez@bauch.com",
    "ContactFullName": "Ardella Gorczany",
    "ActiveErpLinks": 178,
    "TicketPriorityId": 36,
    "SupportLanguageId": 354,
    "SupportAssociateId": 374,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 146
      }
    }
  },
  "Person": {
    "Position": "et",
    "PersonId": 272,
    "Mrmrs": "dolorem",
    "Firstname": "Holly",
    "Lastname": "Buckridge",
    "MiddleName": "Casper-Goodwin",
    "Title": "ad",
    "Description": "Persistent motivating matrix",
    "Email": "everardo@hyatt.com",
    "FullName": "Dayna Lueilwitz MD",
    "DirectPhone": "(630)080-1134 x845",
    "FormalName": "Walsh Group",
    "CountryId": 478,
    "ContactId": 935,
    "ContactName": "Schmitt, Parker and Lesch",
    "Retired": 430,
    "Rank": 259,
    "ActiveInterests": 31,
    "ContactDepartment": "",
    "ContactCountryId": 572,
    "ContactOrgNr": "1648371",
    "FaxPhone": "166-666-4022",
    "MobilePhone": "(410)174-0826",
    "ContactPhone": "1-576-187-0444",
    "AssociateName": "Howe LLC",
    "AssociateId": 238,
    "UsePersonAddress": false,
    "ContactFax": "et",
    "Kanafname": "laboriosam",
    "Kanalname": "et",
    "Post1": "est",
    "Post2": "sit",
    "Post3": "fugit",
    "EmailName": "tyra@schmelerondricka.us",
    "ContactFullName": "Buford Torphy",
    "ActiveErpLinks": 938,
    "TicketPriorityId": 535,
    "SupportLanguageId": 747,
    "SupportAssociateId": 707,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 571
      }
    }
  },
  "MotherId": 270,
  "Priority": {
    "Id": 819,
    "Value": "et",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 244
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 811,
    "Name": "Lindgren Group",
    "Description": "Phased object-oriented synergy",
    "URL": "http://www.example.com/",
    "Type": "aperiam",
    "AssociateId": 711,
    "AssociateFullName": "Alfredo Konopelski",
    "TypeId": 94,
    "Updated": "1999-04-28T14:58:03.0035381+02:00",
    "StatusId": 933,
    "Status": "laudantium",
    "TextId": 636,
    "PublishTo": "2007-11-07T14:58:03.0035381+01:00",
    "PublishFrom": "1998-02-05T14:58:03.0035381+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1117974",
    "ActiveErpLinks": 517,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 318
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2018-06-11T14:58:03.0035381+02:00",
  "Completed": "Completed",
  "ActiveLinks": 110,
  "Links": [
    {
      "EntityName": "Hartmann Group",
      "Id": 395,
      "Description": "Public-key bifurcated utilisation",
      "ExtraInfo": "dolor",
      "LinkId": 654,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 235
        }
      }
    }
  ],
  "AlarmLeadTime": "ex",
  "HasAlarm": false,
  "ColorIndex": 364,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "illum",
  "LeadTime": "alias",
  "Location": "sit",
  "RejectCounter": 935,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 930,
    "StartDate": "2014-03-10T14:58:03.0035381+01:00",
    "EndDate": "1994-12-05T14:58:03.0035381+01:00",
    "RecurrenceCounter": 593,
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
      "AssociateId": 759,
      "PersonId": 88,
      "ContactId": 540,
      "EmailId": 402,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 759,
      "PersonId": 88,
      "ContactId": 540,
      "EmailId": 402,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2013-08-07T14:58:03.0035381+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 737,
    "Name": "Hudson-Nader",
    "PersonId": 623,
    "Rank": 696,
    "Tooltip": "iure",
    "Type": "AnonymousAssociate",
    "GroupIdx": 395,
    "FullName": "Monserrat Schulist",
    "FormalName": "Effertz-Kilback",
    "Deleted": true,
    "EjUserId": 908,
    "UserName": "Gleichner, Wehner and Stark",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 158
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 964,
    "Name": "Olson, Gleichner and Collier",
    "PersonId": 313,
    "Rank": 709,
    "Tooltip": "mollitia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 136,
    "FullName": "Macey Goyette",
    "FormalName": "Jones, Luettgen and Stroman",
    "Deleted": true,
    "EjUserId": 359,
    "UserName": "Beahan, Brekke and Effertz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 27
      }
    }
  },
  "Task": {
    "TaskListItemId": 278,
    "Value": "praesentium",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "minus",
    "Deleted": true,
    "IntentId": 727,
    "Rank": 104,
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
        "FieldLength": 257
      }
    }
  },
  "PreferredTZLocation": 395,
  "Sale": {
    "ContactName": "Langosh-Greenholt",
    "SaleDate": "2018-10-24T14:58:03.0045382+02:00",
    "SaleId": 902,
    "Probability": 911,
    "Title": "repudiandae",
    "Amount": 24702.188,
    "Currency": "et",
    "ProjectName": "Maggio-Parisian",
    "AssociateFullName": "Miss Aliya Schmitt",
    "Description": "Up-sized client-server knowledge user",
    "Status": "Lost",
    "WeightedAmount": 21890.989999999998,
    "ProjectId": 457,
    "EarningPercent": 19092.327999999998,
    "Earning": 27246.996,
    "ContactId": 338,
    "AssociateId": 279,
    "PersonId": 292,
    "SaleTypeId": 400,
    "SaleTypeName": "Lowe, Larson and Herman",
    "PersonFullName": "Nolan McLaughlin",
    "Completed": "Completed",
    "ActiveErpLinks": 434,
    "NextDueDate": "2009-03-05T14:58:03.0055385+01:00",
    "Number": "850834",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 901
      }
    }
  },
  "SuggestedAppointmentId": 725,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "tempore",
  "UserDefinedFields": {
    "SuperOffice:1": "1897355553",
    "SuperOffice:2": "Raul Smith"
  },
  "ExtraFields": {
    "ExtraFields1": "doloremque",
    "ExtraFields2": "sequi"
  },
  "CustomFields": {
    "CustomFields1": "reprehenderit",
    "CustomFields2": "ex"
  },
  "PublishEventDate": "1998-09-10T14:58:03.0055385+02:00",
  "PublishTo": "2015-11-20T14:58:03.0055385+01:00",
  "PublishFrom": "2015-04-10T14:58:03.0055385+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 123,
      "Visibility": "All",
      "DisplayValue": "rem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 425
        }
      }
    },
    {
      "VisibleId": 123,
      "Visibility": "All",
      "DisplayValue": "rem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 425
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
      "FieldLength": 248
    }
  }
}
```