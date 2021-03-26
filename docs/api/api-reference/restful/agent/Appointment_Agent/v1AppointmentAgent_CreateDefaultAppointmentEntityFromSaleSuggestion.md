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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 772,
  "SaleId": 611,
  "CreateNow": true,
  "OwnerId": 678
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 336,
    "Name": "Harber Group",
    "PersonId": 137,
    "Rank": 109,
    "Tooltip": "mollitia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 783,
    "FullName": "Jules Lehner",
    "FormalName": "Lakin Inc and Sons",
    "Deleted": false,
    "EjUserId": 878,
    "UserName": "Dach, Hudson and Gutmann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 810
      }
    }
  },
  "Contact": {
    "ContactId": 631,
    "Name": "Gibson, King and Hintz",
    "OrgNr": "464372",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "accusamus",
    "DirectPhone": "1-068-835-5382 x01224",
    "AssociateId": 965,
    "CountryId": 396,
    "EmailAddress": "alexa@keeling.us",
    "Kananame": "vitae",
    "EmailAddressName": "daphney@gaylordkovacek.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Luciano Dietrich",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "magni",
    "FullName": "Deonte Wiza",
    "IsOwnerContact": false,
    "ActiveErpLinks": 483,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 554
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 615,
    "Name": "Considine Group",
    "PersonId": 450,
    "Rank": 659,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 508,
    "FullName": "Haylee Kilback PhD",
    "FormalName": "Hettinger Inc and Sons",
    "Deleted": true,
    "EjUserId": 523,
    "UserName": "Pouros-Kuphal",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 170
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 142,
    "Name": "Hamill Group",
    "PersonId": 882,
    "Rank": 858,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 306,
    "FullName": "Ms. Rafael Schultz",
    "FormalName": "Kuphal-Wilkinson",
    "Deleted": false,
    "EjUserId": 658,
    "UserName": "Hegmann, Johnson and Towne",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 451
      }
    }
  },
  "CreatedDate": "2020-09-28T16:48:28.6974586+02:00",
  "AppointmentId": 861,
  "Description": "Cross-group zero tolerance orchestration",
  "StartDate": "2007-09-22T16:48:28.6974586+02:00",
  "EndDate": "2013-07-30T16:48:28.6974586+02:00",
  "InvitedPerson": {
    "Position": "quasi",
    "PersonId": 564,
    "Mrmrs": "fuga",
    "Firstname": "Fermin",
    "Lastname": "Marquardt",
    "MiddleName": "Hickle-Satterfield",
    "Title": "rerum",
    "Description": "Extended next generation website",
    "Email": "karlie@sawaynokuneva.info",
    "FullName": "Herminia Witting",
    "DirectPhone": "337-032-3042 x388",
    "FormalName": "Gutmann Inc and Sons",
    "CountryId": 827,
    "ContactId": 56,
    "ContactName": "Bernhard LLC",
    "Retired": 187,
    "Rank": 744,
    "ActiveInterests": 30,
    "ContactDepartment": "",
    "ContactCountryId": 568,
    "ContactOrgNr": "1562046",
    "FaxPhone": "475-551-8640 x48563",
    "MobilePhone": "252.448.5286 x257",
    "ContactPhone": "764-104-6337 x333",
    "AssociateName": "Nikolaus Inc and Sons",
    "AssociateId": 71,
    "UsePersonAddress": true,
    "ContactFax": "dignissimos",
    "Kanafname": "asperiores",
    "Kanalname": "dignissimos",
    "Post1": "laudantium",
    "Post2": "voluptas",
    "Post3": "voluptas",
    "EmailName": "dwight_bednar@schimmel.uk",
    "ContactFullName": "Sylvia Shanahan",
    "ActiveErpLinks": 908,
    "TicketPriorityId": 177,
    "SupportLanguageId": 440,
    "SupportAssociateId": 121,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 678
      }
    }
  },
  "Person": {
    "Position": "libero",
    "PersonId": 796,
    "Mrmrs": "ex",
    "Firstname": "Xzavier",
    "Lastname": "Schiller",
    "MiddleName": "Armstrong Group",
    "Title": "consequatur",
    "Description": "Mandatory multi-state knowledge user",
    "Email": "ariel.haley@stamm.info",
    "FullName": "Liana Kuvalis",
    "DirectPhone": "821-745-8118 x50343",
    "FormalName": "Blanda-Lind",
    "CountryId": 393,
    "ContactId": 246,
    "ContactName": "Marks-Bauch",
    "Retired": 671,
    "Rank": 312,
    "ActiveInterests": 802,
    "ContactDepartment": "",
    "ContactCountryId": 3,
    "ContactOrgNr": "1022069",
    "FaxPhone": "1-648-366-6776 x36172",
    "MobilePhone": "321.672.2132",
    "ContactPhone": "1-467-811-0754 x067",
    "AssociateName": "Parisian LLC",
    "AssociateId": 536,
    "UsePersonAddress": true,
    "ContactFax": "voluptates",
    "Kanafname": "veritatis",
    "Kanalname": "blanditiis",
    "Post1": "omnis",
    "Post2": "accusantium",
    "Post3": "eius",
    "EmailName": "anissa.daniel@corwin.info",
    "ContactFullName": "Kaelyn Bosco Jr.",
    "ActiveErpLinks": 663,
    "TicketPriorityId": 938,
    "SupportLanguageId": 310,
    "SupportAssociateId": 585,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 620
      }
    }
  },
  "MotherId": 729,
  "Priority": {
    "Id": 956,
    "Value": "quis",
    "Tooltip": "laudantium",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 420
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 14,
    "Name": "Hickle-Parisian",
    "Description": "Adaptive dynamic methodology",
    "URL": "http://www.example.com/",
    "Type": "non",
    "AssociateId": 647,
    "AssociateFullName": "Anastasia Hermann",
    "TypeId": 819,
    "Updated": "1999-02-27T16:48:28.7004545+01:00",
    "StatusId": 403,
    "Status": "ratione",
    "TextId": 109,
    "PublishTo": "2011-07-01T16:48:28.7004545+02:00",
    "PublishFrom": "1994-01-06T16:48:28.7004545+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1382980",
    "ActiveErpLinks": 823,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 781
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2004-11-04T16:48:28.7004545+01:00",
  "Completed": "Completed",
  "ActiveLinks": 768,
  "Links": [
    {
      "EntityName": "Block, Okuneva and Greenholt",
      "Id": 257,
      "Description": "Front-line didactic protocol",
      "ExtraInfo": "tempore",
      "LinkId": 974,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 556
        }
      }
    }
  ],
  "AlarmLeadTime": "veritatis",
  "HasAlarm": false,
  "ColorIndex": 219,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "amet",
  "LeadTime": "officiis",
  "Location": "reprehenderit",
  "RejectCounter": 277,
  "RejectReason": "empower cross-platform paradigms",
  "Recurrence": {
    "RecurrenceId": 276,
    "StartDate": "2013-04-10T16:48:28.7004545+02:00",
    "EndDate": "2004-11-01T16:48:28.7004545+01:00",
    "RecurrenceCounter": 739,
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
      "AssociateId": 842,
      "PersonId": 842,
      "ContactId": 546,
      "EmailId": 687,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 842,
      "PersonId": 842,
      "ContactId": 546,
      "EmailId": 687,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2007-12-06T16:48:28.7004545+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 719,
    "Name": "Hoeger LLC",
    "PersonId": 705,
    "Rank": 972,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 397,
    "FullName": "Zachery Olson",
    "FormalName": "Zboncak Group",
    "Deleted": false,
    "EjUserId": 608,
    "UserName": "Schultz-Ruecker",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 313
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 520,
    "Name": "Barton LLC",
    "PersonId": 338,
    "Rank": 937,
    "Tooltip": "temporibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 568,
    "FullName": "Malvina Walsh",
    "FormalName": "Murazik-Sporer",
    "Deleted": false,
    "EjUserId": 688,
    "UserName": "Walsh, Stamm and Tillman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "recontextualize cutting-edge e-services"
        },
        "FieldType": "System.Int32",
        "FieldLength": 671
      }
    }
  },
  "Task": {
    "TaskListItemId": 791,
    "Value": "ea",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "accusamus",
    "Deleted": false,
    "IntentId": 674,
    "Rank": 84,
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
        "FieldLength": 21
      }
    }
  },
  "PreferredTZLocation": 873,
  "Sale": {
    "ContactName": "Senger, Gleichner and Schinner",
    "SaleDate": "2008-11-08T16:48:28.7014534+01:00",
    "SaleId": 465,
    "Probability": 636,
    "Title": "officiis",
    "Amount": 16980.012,
    "Currency": "et",
    "ProjectName": "Carter, Schowalter and Schneider",
    "AssociateFullName": "Maida Towne",
    "Description": "Intuitive radical website",
    "Status": "Lost",
    "WeightedAmount": 18932.494,
    "ProjectId": 361,
    "EarningPercent": 27833.054,
    "Earning": 20214.3,
    "ContactId": 821,
    "AssociateId": 203,
    "PersonId": 833,
    "SaleTypeId": 734,
    "SaleTypeName": "Gulgowski Inc and Sons",
    "PersonFullName": "Virginia Kuhn",
    "Completed": "Completed",
    "ActiveErpLinks": 554,
    "NextDueDate": "2005-07-02T16:48:28.7014534+02:00",
    "Number": "981749",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "maximize next-generation initiatives"
        },
        "FieldType": "System.Int32",
        "FieldLength": 256
      }
    }
  },
  "SuggestedAppointmentId": 655,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "et",
  "UserDefinedFields": {
    "SuperOffice:1": "Malika Kerluke",
    "SuperOffice:2": "1757039058"
  },
  "ExtraFields": {
    "ExtraFields1": "labore",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "nihil"
  },
  "PublishEventDate": "1998-02-27T16:48:28.7014534+01:00",
  "PublishTo": "2012-09-15T16:48:28.7014534+02:00",
  "PublishFrom": "2003-05-01T16:48:28.7014534+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 315,
      "Visibility": "All",
      "DisplayValue": "alias",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 719
        }
      }
    },
    {
      "VisibleId": 315,
      "Visibility": "All",
      "DisplayValue": "alias",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 719
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
      "FieldLength": 246
    }
  }
}
```