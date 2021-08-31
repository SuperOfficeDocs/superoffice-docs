---
title: CreateDefaultAppointmentEntityByTypeAndAssociate
id: v1AppointmentAgent_CreateDefaultAppointmentEntityByTypeAndAssociate
---

# CreateDefaultAppointmentEntityByTypeAndAssociate

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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Type": "Appointment",
  "AssociateId": 220
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 496,
    "Name": "Purdy-Prosacco",
    "PersonId": 408,
    "Rank": 53,
    "Tooltip": "nesciunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 208,
    "FullName": "Mrs. Bethel Quigley",
    "FormalName": "Zemlak-Larkin",
    "Deleted": true,
    "EjUserId": 912,
    "UserName": "Thompson, Emmerich and Hilpert",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 23
      }
    }
  },
  "Contact": {
    "ContactId": 159,
    "Name": "Leuschke Group",
    "OrgNr": "401726",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "asperiores",
    "DirectPhone": "831.034.8854 x170",
    "AssociateId": 725,
    "CountryId": 484,
    "EmailAddress": "candace.gorczany@flatley.info",
    "Kananame": "vitae",
    "EmailAddressName": "ebba.predovic@turcotte.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ken Rau",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "fugiat",
    "FullName": "Nyah Koelpin",
    "IsOwnerContact": true,
    "ActiveErpLinks": 8,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 298
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 818,
    "Name": "Thompson-Stoltenberg",
    "PersonId": 72,
    "Rank": 593,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 520,
    "FullName": "Wilma Lind Sr.",
    "FormalName": "Gleichner-Hickle",
    "Deleted": false,
    "EjUserId": 276,
    "UserName": "Mann Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 661
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 512,
    "Name": "Rogahn-Becker",
    "PersonId": 729,
    "Rank": 124,
    "Tooltip": "natus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 789,
    "FullName": "Halle Sipes",
    "FormalName": "Pfeffer Inc and Sons",
    "Deleted": false,
    "EjUserId": 198,
    "UserName": "Stark-Weimann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 641
      }
    }
  },
  "CreatedDate": "2008-01-09T14:58:02.9575406+01:00",
  "AppointmentId": 634,
  "Description": "Extended object-oriented monitoring",
  "StartDate": "2002-06-24T14:58:02.9575406+02:00",
  "EndDate": "2019-07-20T14:58:02.9575406+02:00",
  "InvitedPerson": {
    "Position": "velit",
    "PersonId": 83,
    "Mrmrs": "error",
    "Firstname": "Romaine",
    "Lastname": "Schamberger",
    "MiddleName": "Gottlieb Group",
    "Title": "et",
    "Description": "Multi-channelled web-enabled process improvement",
    "Email": "hattie@kuhlmanmarks.us",
    "FullName": "Millie Veum",
    "DirectPhone": "1-432-437-7067 x3125",
    "FormalName": "Jakubowski, Koss and Marks",
    "CountryId": 960,
    "ContactId": 898,
    "ContactName": "Russel, Parker and Rippin",
    "Retired": 608,
    "Rank": 857,
    "ActiveInterests": 294,
    "ContactDepartment": "",
    "ContactCountryId": 132,
    "ContactOrgNr": "878363",
    "FaxPhone": "(160)355-7187 x6037",
    "MobilePhone": "751.786.0766",
    "ContactPhone": "(754)588-7684 x437",
    "AssociateName": "Reichert, Schneider and Abshire",
    "AssociateId": 168,
    "UsePersonAddress": true,
    "ContactFax": "qui",
    "Kanafname": "est",
    "Kanalname": "quas",
    "Post1": "asperiores",
    "Post2": "non",
    "Post3": "sint",
    "EmailName": "maudie@parisian.ca",
    "ContactFullName": "Reinhold Sanford II",
    "ActiveErpLinks": 613,
    "TicketPriorityId": 864,
    "SupportLanguageId": 622,
    "SupportAssociateId": 350,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 172
      }
    }
  },
  "Person": {
    "Position": "aut",
    "PersonId": 623,
    "Mrmrs": "eos",
    "Firstname": "Avery",
    "Lastname": "Collins",
    "MiddleName": "Carroll, Conn and Zboncak",
    "Title": "id",
    "Description": "Secured static migration",
    "Email": "meghan@fahey.info",
    "FullName": "Dusty Greenfelder",
    "DirectPhone": "700.250.0812 x5584",
    "FormalName": "Kunze-Brown",
    "CountryId": 832,
    "ContactId": 834,
    "ContactName": "Schulist, Auer and Zemlak",
    "Retired": 116,
    "Rank": 555,
    "ActiveInterests": 547,
    "ContactDepartment": "",
    "ContactCountryId": 722,
    "ContactOrgNr": "1022777",
    "FaxPhone": "(372)270-8375",
    "MobilePhone": "625-176-0654 x45870",
    "ContactPhone": "603.217.0165 x25414",
    "AssociateName": "Brown, Zboncak and Haley",
    "AssociateId": 661,
    "UsePersonAddress": true,
    "ContactFax": "quod",
    "Kanafname": "expedita",
    "Kanalname": "laborum",
    "Post1": "delectus",
    "Post2": "laboriosam",
    "Post3": "quod",
    "EmailName": "colleen@jones.ca",
    "ContactFullName": "Emelia Kirlin",
    "ActiveErpLinks": 440,
    "TicketPriorityId": 146,
    "SupportLanguageId": 386,
    "SupportAssociateId": 497,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 466
      }
    }
  },
  "MotherId": 484,
  "Priority": {
    "Id": 983,
    "Value": "quam",
    "Tooltip": "quis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 134
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 258,
    "Name": "Kling Inc and Sons",
    "Description": "Universal solution-oriented framework",
    "URL": "http://www.example.com/",
    "Type": "ut",
    "AssociateId": 560,
    "AssociateFullName": "Garrick Kunze",
    "TypeId": 347,
    "Updated": "2021-01-05T14:58:02.9595412+01:00",
    "StatusId": 967,
    "Status": "est",
    "TextId": 163,
    "PublishTo": "1998-08-09T14:58:02.9595412+02:00",
    "PublishFrom": "2016-07-28T14:58:02.9595412+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1272630",
    "ActiveErpLinks": 361,
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
  "Type": "BookingForChecklist",
  "UpdatedDate": "1994-06-28T14:58:02.9605408+02:00",
  "Completed": "Completed",
  "ActiveLinks": 483,
  "Links": [
    {
      "EntityName": "Beer-Feest",
      "Id": 983,
      "Description": "Stand-alone holistic moratorium",
      "ExtraInfo": "voluptate",
      "LinkId": 796,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 55
        }
      }
    }
  ],
  "AlarmLeadTime": "blanditiis",
  "HasAlarm": true,
  "ColorIndex": 760,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "dicta",
  "LeadTime": "porro",
  "Location": "a",
  "RejectCounter": 84,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 759,
    "StartDate": "2018-11-06T14:58:02.9605408+01:00",
    "EndDate": "2012-04-04T14:58:02.9605408+02:00",
    "RecurrenceCounter": 567,
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
      "AssociateId": 289,
      "PersonId": 789,
      "ContactId": 986,
      "EmailId": 774,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 289,
      "PersonId": 789,
      "ContactId": 986,
      "EmailId": 774,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2005-05-13T14:58:02.9605408+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 755,
    "Name": "Friesen, Cremin and McLaughlin",
    "PersonId": 135,
    "Rank": 169,
    "Tooltip": "consectetur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 535,
    "FullName": "Elena Streich",
    "FormalName": "Cruickshank-Brown",
    "Deleted": true,
    "EjUserId": 452,
    "UserName": "Langosh-Rath",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 339
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 988,
    "Name": "Wunsch, Haley and Hagenes",
    "PersonId": 587,
    "Rank": 122,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 256,
    "FullName": "Johnnie Ebert",
    "FormalName": "Witting-Prohaska",
    "Deleted": true,
    "EjUserId": 755,
    "UserName": "Pfeffer Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 472
      }
    }
  },
  "Task": {
    "TaskListItemId": 489,
    "Value": "officia",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "atque",
    "Deleted": true,
    "IntentId": 148,
    "Rank": 480,
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
        "FieldLength": 910
      }
    }
  },
  "PreferredTZLocation": 508,
  "Sale": {
    "ContactName": "Ferry, Weissnat and Lind",
    "SaleDate": "2021-05-21T14:58:02.9615408+02:00",
    "SaleId": 607,
    "Probability": 33,
    "Title": "est",
    "Amount": 2547.942,
    "Currency": "et",
    "ProjectName": "Spencer-Boyle",
    "AssociateFullName": "Zackary Cruickshank",
    "Description": "Pre-emptive regional attitude",
    "Status": "Lost",
    "WeightedAmount": 1986.956,
    "ProjectId": 921,
    "EarningPercent": 24175.676,
    "Earning": 25880.572,
    "ContactId": 349,
    "AssociateId": 806,
    "PersonId": 870,
    "SaleTypeId": 977,
    "SaleTypeName": "Ondricka LLC",
    "PersonFullName": "Margret Franecki",
    "Completed": "Completed",
    "ActiveErpLinks": 51,
    "NextDueDate": "2020-10-24T14:58:02.9615408+02:00",
    "Number": "504043",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 538
      }
    }
  },
  "SuggestedAppointmentId": 550,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "provident",
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "tempora",
    "CustomFields2": "tempore"
  },
  "PublishEventDate": "1998-09-26T14:58:02.9615408+02:00",
  "PublishTo": "2014-01-21T14:58:02.9615408+01:00",
  "PublishFrom": "2015-05-05T14:58:02.9615408+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 167,
      "Visibility": "All",
      "DisplayValue": "rerum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 37
        }
      }
    },
    {
      "VisibleId": 167,
      "Visibility": "All",
      "DisplayValue": "rerum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 37
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
      "FieldLength": 41
    }
  }
}
```