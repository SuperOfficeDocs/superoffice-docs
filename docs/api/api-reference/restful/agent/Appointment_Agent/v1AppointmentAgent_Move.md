---
title: POST Agents/Appointment/Move
id: v1AppointmentAgent_Move
---

# POST Agents/Appointment/Move

```http
POST /api/v1/Agents/Appointment/Move
```

Moving a booking to another start time.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/Move?$select=name,department,category/id
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

AppointmentId, NewStartTime, UpdateMode 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentId | int32 |  |
| NewStartTime | date-time |  |
| UpdateMode | string |  |


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
POST /api/v1/Agents/Appointment/Move
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 348,
  "NewStartTime": "2007-03-31T18:28:48.0728565+02:00",
  "UpdateMode": "OnlyThis"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 13,
    "Name": "Bogan Group",
    "PersonId": 162,
    "Rank": 932,
    "Tooltip": "maiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 369,
    "FullName": "Cayla Welch DDS",
    "FormalName": "Sanford, Barrows and Borer",
    "Deleted": true,
    "EjUserId": 193,
    "UserName": "Bednar, Wyman and Howe",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 486
      }
    }
  },
  "Contact": {
    "ContactId": 283,
    "Name": "Kling, Medhurst and Schuster",
    "OrgNr": "1156651",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "pariatur",
    "DirectPhone": "(463)764-4182 x042",
    "AssociateId": 778,
    "CountryId": 106,
    "EmailAddress": "velva@price.us",
    "Kananame": "asperiores",
    "EmailAddressName": "evans_murphy@oharawaelchi.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Chasity Muller",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "excepturi",
    "FullName": "Christiana Effertz DVM",
    "IsOwnerContact": true,
    "ActiveErpLinks": 649,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 267
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 214,
    "Name": "Raynor, Conroy and Veum",
    "PersonId": 558,
    "Rank": 725,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 688,
    "FullName": "Juston Stoltenberg",
    "FormalName": "Dare, Lehner and Bechtelar",
    "Deleted": true,
    "EjUserId": 739,
    "UserName": "Mosciski Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 84
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 783,
    "Name": "Parisian-Pfeffer",
    "PersonId": 776,
    "Rank": 517,
    "Tooltip": "optio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 631,
    "FullName": "Adelia Greenholt",
    "FormalName": "Harvey-Kuhlman",
    "Deleted": false,
    "EjUserId": 826,
    "UserName": "O'Hara-Heidenreich",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 83
      }
    }
  },
  "CreatedDate": "1999-11-10T18:28:48.0828527+01:00",
  "AppointmentId": 453,
  "Description": "Upgradable maximized initiative",
  "StartDate": "2018-07-04T18:28:48.0828527+02:00",
  "EndDate": "2015-11-28T18:28:48.0828527+01:00",
  "InvitedPerson": {
    "Position": "rem",
    "PersonId": 944,
    "Mrmrs": "blanditiis",
    "Firstname": "Alvena",
    "Lastname": "Veum",
    "MiddleName": "Klein Inc and Sons",
    "Title": "unde",
    "Description": "Ameliorated 5th generation attitude",
    "Email": "zaria@mills.uk",
    "FullName": "Miss Mckenzie Klein",
    "DirectPhone": "580.102.4277 x610",
    "FormalName": "Veum, Gerlach and Donnelly",
    "CountryId": 186,
    "ContactId": 51,
    "ContactName": "Botsford-Batz",
    "Retired": 687,
    "Rank": 346,
    "ActiveInterests": 940,
    "ContactDepartment": "",
    "ContactCountryId": 893,
    "ContactOrgNr": "1135032",
    "FaxPhone": "626-738-1206",
    "MobilePhone": "612-370-8718",
    "ContactPhone": "1-574-526-1531 x470",
    "AssociateName": "Jacobi-Cormier",
    "AssociateId": 239,
    "UsePersonAddress": false,
    "ContactFax": "rerum",
    "Kanafname": "laboriosam",
    "Kanalname": "consequatur",
    "Post1": "iure",
    "Post2": "dicta",
    "Post3": "delectus",
    "EmailName": "leann@dickinson.name",
    "ContactFullName": "Sarina Okuneva",
    "ActiveErpLinks": 441,
    "TicketPriorityId": 110,
    "SupportLanguageId": 422,
    "SupportAssociateId": 283,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 218
      }
    }
  },
  "Person": {
    "Position": "blanditiis",
    "PersonId": 945,
    "Mrmrs": "rerum",
    "Firstname": "Arden",
    "Lastname": "Barton",
    "MiddleName": "Hahn-Ebert",
    "Title": "nihil",
    "Description": "Total responsive attitude",
    "Email": "jakob@vandervortritchie.name",
    "FullName": "Janessa Renner",
    "DirectPhone": "256.606.1418",
    "FormalName": "Kautzer-Goodwin",
    "CountryId": 616,
    "ContactId": 527,
    "ContactName": "Runte Inc and Sons",
    "Retired": 721,
    "Rank": 314,
    "ActiveInterests": 169,
    "ContactDepartment": "",
    "ContactCountryId": 648,
    "ContactOrgNr": "1142548",
    "FaxPhone": "225-208-1253 x26248",
    "MobilePhone": "674.710.3615",
    "ContactPhone": "1-314-074-2478 x7751",
    "AssociateName": "Bauch, Brown and Schroeder",
    "AssociateId": 52,
    "UsePersonAddress": true,
    "ContactFax": "ex",
    "Kanafname": "eaque",
    "Kanalname": "et",
    "Post1": "harum",
    "Post2": "et",
    "Post3": "quia",
    "EmailName": "darrin@casper.uk",
    "ContactFullName": "Adrain Barrows Sr.",
    "ActiveErpLinks": 229,
    "TicketPriorityId": 880,
    "SupportLanguageId": 971,
    "SupportAssociateId": 845,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 275
      }
    }
  },
  "MotherId": 861,
  "Priority": {
    "Id": 72,
    "Value": "non",
    "Tooltip": "sed",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 237
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 269,
    "Name": "Bahringer, Nienow and Hettinger",
    "Description": "Inverse full-range service-desk",
    "URL": "http://www.example.com/",
    "Type": "quo",
    "AssociateId": 339,
    "AssociateFullName": "Abbey Dicki",
    "TypeId": 242,
    "Updated": "2000-10-27T18:28:48.0858509+02:00",
    "StatusId": 163,
    "Status": "expedita",
    "TextId": 697,
    "PublishTo": "2011-01-05T18:28:48.0858509+01:00",
    "PublishFrom": "2016-03-11T18:28:48.0858509+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "197766",
    "ActiveErpLinks": 915,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 515
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2016-10-29T18:28:48.0858509+02:00",
  "Completed": "Completed",
  "ActiveLinks": 406,
  "Links": [
    {
      "EntityName": "Dietrich, DuBuque and Ferry",
      "Id": 606,
      "Description": "Mandatory coherent groupware",
      "ExtraInfo": "natus",
      "LinkId": 524,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 824
        }
      }
    }
  ],
  "AlarmLeadTime": "ut",
  "HasAlarm": true,
  "ColorIndex": 632,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "enim",
  "LeadTime": "et",
  "Location": "nihil",
  "RejectCounter": 694,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 506,
    "StartDate": "2007-10-09T18:28:48.0858509+02:00",
    "EndDate": "2017-09-21T18:28:48.0858509+02:00",
    "RecurrenceCounter": 952,
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
      "AssociateId": 565,
      "PersonId": 922,
      "ContactId": 242,
      "EmailId": 225,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 565,
      "PersonId": 922,
      "ContactId": 242,
      "EmailId": 225,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1995-12-02T18:28:48.0858509+01:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 370,
    "Name": "Kuhlman, Cummerata and Spencer",
    "PersonId": 556,
    "Rank": 394,
    "Tooltip": "nihil",
    "Type": "AnonymousAssociate",
    "GroupIdx": 247,
    "FullName": "Carey Reinger",
    "FormalName": "Kunze-Koss",
    "Deleted": true,
    "EjUserId": 371,
    "UserName": "Yost Group",
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
  "MotherAssociate": {
    "AssociateId": 409,
    "Name": "Erdman Group",
    "PersonId": 183,
    "Rank": 423,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 787,
    "FullName": "Euna Pacocha",
    "FormalName": "Luettgen-Jacobson",
    "Deleted": false,
    "EjUserId": 121,
    "UserName": "Deckow Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 761
      }
    }
  },
  "Task": {
    "TaskListItemId": 47,
    "Value": "quo",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "dolorum",
    "Deleted": false,
    "IntentId": 728,
    "Rank": 148,
    "IsDefaultAlldayEvent": true,
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
        "FieldLength": 721
      }
    }
  },
  "PreferredTZLocation": 84,
  "Sale": {
    "ContactName": "Hills Group",
    "SaleDate": "2003-04-13T18:28:48.08685+02:00",
    "SaleId": 585,
    "Probability": 182,
    "Title": "unde",
    "Amount": 7722.1759999999995,
    "Currency": "voluptates",
    "ProjectName": "Reinger Inc and Sons",
    "AssociateFullName": "Demond Spencer DDS",
    "Description": "Synergized multi-state project",
    "Status": "Lost",
    "WeightedAmount": 29704.052,
    "ProjectId": 453,
    "EarningPercent": 6493.648,
    "Earning": 13463.663999999999,
    "ContactId": 852,
    "AssociateId": 377,
    "PersonId": 496,
    "SaleTypeId": 996,
    "SaleTypeName": "Breitenberg Inc and Sons",
    "PersonFullName": "Litzy Padberg",
    "Completed": "Completed",
    "ActiveErpLinks": 33,
    "NextDueDate": "2001-02-10T18:28:48.08685+01:00",
    "Number": "752150",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 237
      }
    }
  },
  "SuggestedAppointmentId": 302,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "sunt",
  "UserDefinedFields": {
    "SuperOffice:1": "550979807",
    "SuperOffice:2": "138574496"
  },
  "ExtraFields": {
    "ExtraFields1": "provident",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "sequi",
    "CustomFields2": "veniam"
  },
  "PublishEventDate": "2020-05-16T18:28:48.0878496+02:00",
  "PublishTo": "2015-01-04T18:28:48.0878496+01:00",
  "PublishFrom": "1995-02-27T18:28:48.0878496+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 778,
      "Visibility": "All",
      "DisplayValue": "praesentium",
      "TableRight": {},
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
    },
    {
      "VisibleId": 778,
      "Visibility": "All",
      "DisplayValue": "praesentium",
      "TableRight": {},
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
      "FieldLength": 908
    }
  }
}
```