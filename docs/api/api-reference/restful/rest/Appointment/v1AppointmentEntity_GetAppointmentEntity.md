---
title: GET Appointment/{id}
id: v1AppointmentEntity_GetAppointmentEntity
---

# GET Appointment/{id}

```http
GET /api/v1/Appointment/{id}
```

Gets a AppointmentEntity object.

Calls the Appointment agent service GetAppointmentEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the AppointmentEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Appointment/{id}?$select=name,department,category/id
GET /api/v1/Appointment/{id}?fk=True
```


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

Appointments appear in the diary, and have links to a Contact/Person and possibly a Project or Sale. They have start and end time+date.



AppointmentEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | AppointmentEntity found. |
| 304 | AppointmentEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

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
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/Appointment/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 AppointmentEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 27 Nov 2004 15:05:41 G11T

{
  "Associate": {
    "AssociateId": 692,
    "Name": "Nicolas, Larson and Gutmann",
    "PersonId": 982,
    "Rank": 40,
    "Tooltip": "recusandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 604,
    "FullName": "Tara Jacobi",
    "FormalName": "Nienow-Romaguera",
    "Deleted": true,
    "EjUserId": 5,
    "UserName": "Glover LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 113
      }
    }
  },
  "Contact": {
    "ContactId": 676,
    "Name": "Tremblay Inc and Sons",
    "OrgNr": "1803477",
    "Department": "deploy impactful e-tailers",
    "URL": "http://www.example.com/",
    "City": "aut",
    "DirectPhone": "018-555-3661 x00602",
    "AssociateId": 382,
    "CountryId": 238,
    "EmailAddress": "blake@dickinsongutmann.name",
    "Kananame": "non",
    "EmailAddressName": "nathanael.kovacek@hartmanncrona.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Aaliyah Wuckert",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "officiis",
    "FullName": "Tod Paucek",
    "IsOwnerContact": true,
    "ActiveErpLinks": 904,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 171
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 830,
    "Name": "Beier, Luettgen and Braun",
    "PersonId": 363,
    "Rank": 308,
    "Tooltip": "optio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 484,
    "FullName": "Kellie Spencer",
    "FormalName": "Fahey Inc and Sons",
    "Deleted": false,
    "EjUserId": 922,
    "UserName": "Doyle Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 293
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 191,
    "Name": "Sauer, Jacobson and Abshire",
    "PersonId": 600,
    "Rank": 35,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 414,
    "FullName": "Mrs. Pete Nitzsche",
    "FormalName": "Gutkowski, Sauer and Toy",
    "Deleted": true,
    "EjUserId": 362,
    "UserName": "Larson Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "e-enable bricks-and-clicks web services"
        },
        "FieldType": "System.String",
        "FieldLength": 458
      }
    }
  },
  "CreatedDate": "2020-03-21T15:05:41.5280024+01:00",
  "AppointmentId": 199,
  "Description": "Sharable client-driven initiative",
  "StartDate": "1997-09-24T15:05:41.5280024+02:00",
  "EndDate": "2013-08-12T15:05:41.5280024+02:00",
  "InvitedPerson": {
    "Position": "rerum",
    "PersonId": 619,
    "Mrmrs": "molestiae",
    "Firstname": "Phoebe",
    "Lastname": "Schultz",
    "MiddleName": "McKenzie Inc and Sons",
    "Title": "quis",
    "Description": "Re-contextualized local attitude",
    "Email": "tomas@greenholt.biz",
    "FullName": "Maya Gusikowski",
    "DirectPhone": "(183)735-1005 x05516",
    "FormalName": "Monahan-Leffler",
    "CountryId": 773,
    "ContactId": 218,
    "ContactName": "Blanda, Towne and Wehner",
    "Retired": 61,
    "Rank": 883,
    "ActiveInterests": 72,
    "ContactDepartment": "",
    "ContactCountryId": 278,
    "ContactOrgNr": "932342",
    "FaxPhone": "277.742.1432",
    "MobilePhone": "1-804-285-2038 x0100",
    "ContactPhone": "744-863-2726 x378",
    "AssociateName": "Hermann-Glover",
    "AssociateId": 851,
    "UsePersonAddress": true,
    "ContactFax": "et",
    "Kanafname": "non",
    "Kanalname": "dolores",
    "Post1": "ab",
    "Post2": "hic",
    "Post3": "ut",
    "EmailName": "nyasia_bartell@nicolaswhite.uk",
    "ContactFullName": "Estell Prohaska",
    "ActiveErpLinks": 286,
    "TicketPriorityId": 247,
    "SupportLanguageId": 565,
    "SupportAssociateId": 585,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 2
      }
    }
  },
  "Person": {
    "Position": "ut",
    "PersonId": 740,
    "Mrmrs": "fugit",
    "Firstname": "Lauretta",
    "Lastname": "Gibson",
    "MiddleName": "Johnson, Hane and Rau",
    "Title": "voluptas",
    "Description": "Organized 6th generation alliance",
    "Email": "walter_stamm@hammes.co.uk",
    "FullName": "Karianne Goyette Jr.",
    "DirectPhone": "1-867-850-8063 x264",
    "FormalName": "Rosenbaum LLC",
    "CountryId": 374,
    "ContactId": 716,
    "ContactName": "Lebsack Group",
    "Retired": 767,
    "Rank": 429,
    "ActiveInterests": 878,
    "ContactDepartment": "",
    "ContactCountryId": 338,
    "ContactOrgNr": "1575508",
    "FaxPhone": "(808)873-8838 x0041",
    "MobilePhone": "507-314-7704 x412",
    "ContactPhone": "621.137.3265 x57486",
    "AssociateName": "Kilback LLC",
    "AssociateId": 545,
    "UsePersonAddress": false,
    "ContactFax": "labore",
    "Kanafname": "blanditiis",
    "Kanalname": "voluptatem",
    "Post1": "modi",
    "Post2": "laudantium",
    "Post3": "enim",
    "EmailName": "adelia_rau@torp.co.uk",
    "ContactFullName": "Emmanuelle Conn",
    "ActiveErpLinks": 690,
    "TicketPriorityId": 424,
    "SupportLanguageId": 971,
    "SupportAssociateId": 843,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 65
      }
    }
  },
  "MotherId": 583,
  "Priority": {
    "Id": 331,
    "Value": "molestiae",
    "Tooltip": "maxime",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 166
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 261,
    "Name": "Heathcote-Brown",
    "Description": "Operative directional adapter",
    "URL": "http://www.example.com/",
    "Type": "error",
    "AssociateId": 410,
    "AssociateFullName": "Tessie Terry DVM",
    "TypeId": 407,
    "Updated": "2000-08-27T15:05:41.5300025+02:00",
    "StatusId": 151,
    "Status": "incidunt",
    "TextId": 132,
    "PublishTo": "1995-10-20T15:05:41.5300025+02:00",
    "PublishFrom": "2010-01-08T15:05:41.5300025+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1067427",
    "ActiveErpLinks": 299,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 270
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2004-11-27T15:05:41.5300025+01:00",
  "Completed": "Completed",
  "ActiveLinks": 25,
  "Links": [
    {
      "EntityName": "Schmeler LLC",
      "Id": 313,
      "Description": "Mandatory leading edge approach",
      "ExtraInfo": "voluptatum",
      "LinkId": 656,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 512
        }
      }
    }
  ],
  "AlarmLeadTime": "reiciendis",
  "HasAlarm": true,
  "ColorIndex": 92,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "fugiat",
  "LeadTime": "et",
  "Location": "incidunt",
  "RejectCounter": 1000,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 187,
    "StartDate": "2013-08-15T15:05:41.5300025+02:00",
    "EndDate": "2005-04-16T15:05:41.5300025+02:00",
    "RecurrenceCounter": 553,
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
      "AssociateId": 609,
      "PersonId": 425,
      "ContactId": 839,
      "EmailId": 744,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 609,
      "PersonId": 425,
      "ContactId": 839,
      "EmailId": 744,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2013-02-24T15:05:41.5310025+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 464,
    "Name": "Pollich, Champlin and Schmidt",
    "PersonId": 722,
    "Rank": 78,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 714,
    "FullName": "Kaley DuBuque",
    "FormalName": "Beatty-Koss",
    "Deleted": true,
    "EjUserId": 58,
    "UserName": "Howe, Wunsch and O'Hara",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 349
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 865,
    "Name": "Carter, Torp and Kub",
    "PersonId": 307,
    "Rank": 846,
    "Tooltip": "tempora",
    "Type": "AnonymousAssociate",
    "GroupIdx": 58,
    "FullName": "Seth Kozey",
    "FormalName": "Feil LLC",
    "Deleted": false,
    "EjUserId": 698,
    "UserName": "Lesch Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 544
      }
    }
  },
  "Task": {
    "TaskListItemId": 447,
    "Value": "deleniti",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "ipsum",
    "Deleted": true,
    "IntentId": 215,
    "Rank": 892,
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
        "FieldLength": 416
      }
    }
  },
  "PreferredTZLocation": 691,
  "Sale": {
    "ContactName": "Hudson Inc and Sons",
    "SaleDate": "2001-04-17T15:05:41.5320029+02:00",
    "SaleId": 22,
    "Probability": 810,
    "Title": "sit",
    "Amount": 25426.142,
    "Currency": "sapiente",
    "ProjectName": "Carter Group",
    "AssociateFullName": "Ellis Green",
    "Description": "Configurable encompassing infrastructure",
    "Status": "Lost",
    "WeightedAmount": 15829.833999999999,
    "ProjectId": 263,
    "EarningPercent": 8436.728,
    "Earning": 23273.084,
    "ContactId": 293,
    "AssociateId": 668,
    "PersonId": 277,
    "SaleTypeId": 607,
    "SaleTypeName": "Ryan Inc and Sons",
    "PersonFullName": "Ardella Hettinger",
    "Completed": "Completed",
    "ActiveErpLinks": 313,
    "NextDueDate": "2001-07-04T15:05:41.5330022+02:00",
    "Number": "280280",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 462
      }
    }
  },
  "SuggestedAppointmentId": 932,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "natus",
  "UserDefinedFields": {
    "SuperOffice:1": "317048788",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "tempore",
    "ExtraFields2": "a"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "culpa"
  },
  "PublishEventDate": "2001-10-25T15:05:41.5330022+02:00",
  "PublishTo": "2002-03-02T15:05:41.5330022+01:00",
  "PublishFrom": "1994-11-27T15:05:41.5330022+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 902,
      "Visibility": "All",
      "DisplayValue": "aut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 160
        }
      }
    },
    {
      "VisibleId": 902,
      "Visibility": "All",
      "DisplayValue": "aut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 160
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
      "FieldLength": 552
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```