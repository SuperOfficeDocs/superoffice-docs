---
title: POST Agents/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate
id: v1AppointmentAgent_CreateDefaultAppointmentEntityByTypeAndAssociate
---

# POST Agents/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate
```

Creates a AppointmentEntity populated with the default values for the specific type and owner.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate?$select=name,department,category/id
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

Type, AssociateId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Type | string |  |
| AssociateId | int32 |  |


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
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Type": "Appointment",
  "AssociateId": 902
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 605,
    "Name": "McKenzie Inc and Sons",
    "PersonId": 75,
    "Rank": 486,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 171,
    "FullName": "Dorthy Walker DVM",
    "FormalName": "Bednar Inc and Sons",
    "Deleted": false,
    "EjUserId": 108,
    "UserName": "Leffler, Rice and Schultz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 141
      }
    }
  },
  "Contact": {
    "ContactId": 738,
    "Name": "Gulgowski, Schinner and Lakin",
    "OrgNr": "1318192",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "cum",
    "DirectPhone": "1-038-747-0341 x523",
    "AssociateId": 402,
    "CountryId": 908,
    "EmailAddress": "rubie@kassulke.ca",
    "Kananame": "eaque",
    "EmailAddressName": "brando.murray@cole.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Santa Robel",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "facilis",
    "FullName": "Toni Morar PhD",
    "IsOwnerContact": true,
    "ActiveErpLinks": 977,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 399
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 605,
    "Name": "Wehner Inc and Sons",
    "PersonId": 408,
    "Rank": 759,
    "Tooltip": "molestias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 959,
    "FullName": "Georgette Lakin",
    "FormalName": "Morissette-Hintz",
    "Deleted": true,
    "EjUserId": 273,
    "UserName": "Schulist, Legros and Cruickshank",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 496
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 305,
    "Name": "Littel LLC",
    "PersonId": 912,
    "Rank": 1001,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 662,
    "FullName": "Aubrey Ward V",
    "FormalName": "Hessel Group",
    "Deleted": false,
    "EjUserId": 310,
    "UserName": "Johnson, Dickens and Fritsch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 709
      }
    }
  },
  "CreatedDate": "2019-07-15T16:48:28.6834543+02:00",
  "AppointmentId": 867,
  "Description": "Mandatory explicit parallelism",
  "StartDate": "2010-11-20T16:48:28.6834543+01:00",
  "EndDate": "1996-04-01T16:48:28.6834543+02:00",
  "InvitedPerson": {
    "Position": "commodi",
    "PersonId": 964,
    "Mrmrs": "quae",
    "Firstname": "Estrella",
    "Lastname": "Cole",
    "MiddleName": "Jacobi-Will",
    "Title": "delectus",
    "Description": "Future-proofed context-sensitive parallelism",
    "Email": "idell@turcotte.co.uk",
    "FullName": "Syble King",
    "DirectPhone": "(210)524-6016",
    "FormalName": "Blanda-Raynor",
    "CountryId": 975,
    "ContactId": 716,
    "ContactName": "Schamberger, Greenholt and Kling",
    "Retired": 957,
    "Rank": 515,
    "ActiveInterests": 486,
    "ContactDepartment": "",
    "ContactCountryId": 697,
    "ContactOrgNr": "423269",
    "FaxPhone": "573-401-8083 x76622",
    "MobilePhone": "(863)280-1254",
    "ContactPhone": "(477)357-5117 x237",
    "AssociateName": "Waters, Russel and Koch",
    "AssociateId": 979,
    "UsePersonAddress": false,
    "ContactFax": "nihil",
    "Kanafname": "et",
    "Kanalname": "et",
    "Post1": "consectetur",
    "Post2": "quas",
    "Post3": "aut",
    "EmailName": "lelah_kirlin@botsford.com",
    "ContactFullName": "April Casper",
    "ActiveErpLinks": 152,
    "TicketPriorityId": 222,
    "SupportLanguageId": 731,
    "SupportAssociateId": 430,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 311
      }
    }
  },
  "Person": {
    "Position": "ut",
    "PersonId": 985,
    "Mrmrs": "autem",
    "Firstname": "Fidel",
    "Lastname": "Hintz",
    "MiddleName": "Kuhlman-Wiegand",
    "Title": "maxime",
    "Description": "Pre-emptive incremental secured line",
    "Email": "myron@goodwin.biz",
    "FullName": "Nicklaus Schuster",
    "DirectPhone": "(501)541-6818 x5788",
    "FormalName": "Stokes LLC",
    "CountryId": 521,
    "ContactId": 274,
    "ContactName": "Hansen LLC",
    "Retired": 629,
    "Rank": 402,
    "ActiveInterests": 312,
    "ContactDepartment": "",
    "ContactCountryId": 311,
    "ContactOrgNr": "533691",
    "FaxPhone": "251-012-1887 x8735",
    "MobilePhone": "472.170.8463",
    "ContactPhone": "(372)774-5550",
    "AssociateName": "Steuber, Prohaska and Satterfield",
    "AssociateId": 697,
    "UsePersonAddress": false,
    "ContactFax": "rem",
    "Kanafname": "voluptatum",
    "Kanalname": "aperiam",
    "Post1": "possimus",
    "Post2": "ipsa",
    "Post3": "totam",
    "EmailName": "everette.kovacek@champlin.ca",
    "ContactFullName": "Victoria Legros I",
    "ActiveErpLinks": 866,
    "TicketPriorityId": 941,
    "SupportLanguageId": 90,
    "SupportAssociateId": 850,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 142
      }
    }
  },
  "MotherId": 412,
  "Priority": {
    "Id": 408,
    "Value": "perspiciatis",
    "Tooltip": "perferendis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 959
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 405,
    "Name": "Bailey Inc and Sons",
    "Description": "User-friendly contextually-based capacity",
    "URL": "http://www.example.com/",
    "Type": "officiis",
    "AssociateId": 343,
    "AssociateFullName": "Mrs. John Morissette",
    "TypeId": 219,
    "Updated": "2015-08-01T16:48:28.6864548+02:00",
    "StatusId": 94,
    "Status": "voluptates",
    "TextId": 864,
    "PublishTo": "2008-02-11T16:48:28.6864548+01:00",
    "PublishFrom": "2003-04-12T16:48:28.6864548+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1064978",
    "ActiveErpLinks": 104,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 533
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2019-08-27T16:48:28.6864548+02:00",
  "Completed": "Completed",
  "ActiveLinks": 166,
  "Links": [
    {
      "EntityName": "Collier Group",
      "Id": 630,
      "Description": "Customer-focused mobile service-desk",
      "ExtraInfo": "cupiditate",
      "LinkId": 800,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 928
        }
      }
    }
  ],
  "AlarmLeadTime": "aut",
  "HasAlarm": true,
  "ColorIndex": 412,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "placeat",
  "LeadTime": "eveniet",
  "Location": "at",
  "RejectCounter": 300,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 460,
    "StartDate": "2011-11-29T16:48:28.6864548+01:00",
    "EndDate": "2006-01-20T16:48:28.6864548+01:00",
    "RecurrenceCounter": 27,
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
      "AssociateId": 85,
      "PersonId": 368,
      "ContactId": 466,
      "EmailId": 25,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 85,
      "PersonId": 368,
      "ContactId": 466,
      "EmailId": 25,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1999-04-29T16:48:28.6864548+02:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 604,
    "Name": "Dicki Inc and Sons",
    "PersonId": 249,
    "Rank": 378,
    "Tooltip": "eos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 380,
    "FullName": "Twila Funk",
    "FormalName": "Hamill LLC",
    "Deleted": false,
    "EjUserId": 186,
    "UserName": "Gutkowski Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 440
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 821,
    "Name": "Hauck-Berge",
    "PersonId": 831,
    "Rank": 619,
    "Tooltip": "aspernatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 252,
    "FullName": "Breanna Cormier",
    "FormalName": "Daugherty LLC",
    "Deleted": false,
    "EjUserId": 499,
    "UserName": "Rogahn LLC",
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
  "Task": {
    "TaskListItemId": 957,
    "Value": "veniam",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "similique",
    "Deleted": false,
    "IntentId": 872,
    "Rank": 429,
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
        "FieldLength": 30
      }
    }
  },
  "PreferredTZLocation": 27,
  "Sale": {
    "ContactName": "Homenick-Bosco",
    "SaleDate": "2019-05-29T16:48:28.6874186+02:00",
    "SaleId": 704,
    "Probability": 8,
    "Title": "quia",
    "Amount": 25548.368,
    "Currency": "laborum",
    "ProjectName": "Hickle-Leuschke",
    "AssociateFullName": "Margaret Wyman",
    "Description": "Persistent mobile projection",
    "Status": "Lost",
    "WeightedAmount": 15751.484,
    "ProjectId": 280,
    "EarningPercent": 20841.1,
    "Earning": 5907.59,
    "ContactId": 515,
    "AssociateId": 892,
    "PersonId": 480,
    "SaleTypeId": 351,
    "SaleTypeName": "Mayer, Koelpin and Rau",
    "PersonFullName": "Buford Marks",
    "Completed": "Completed",
    "ActiveErpLinks": 219,
    "NextDueDate": "1999-06-20T16:48:28.6884581+02:00",
    "Number": "1675525",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 819
      }
    }
  },
  "SuggestedAppointmentId": 348,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "sunt",
  "UserDefinedFields": {
    "SuperOffice:1": "Dane Gusikowski PhD",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "fugit",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "iusto",
    "CustomFields2": "molestiae"
  },
  "PublishEventDate": "2009-10-21T16:48:28.6884581+02:00",
  "PublishTo": "2010-06-01T16:48:28.6884581+02:00",
  "PublishFrom": "2012-12-14T16:48:28.6884581+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 769,
      "Visibility": "All",
      "DisplayValue": "perferendis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 849
        }
      }
    },
    {
      "VisibleId": 769,
      "Visibility": "All",
      "DisplayValue": "perferendis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 849
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
      "FieldLength": 598
    }
  }
}
```