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
GET /api/v1/Appointment/{id}?fk=False
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
Accept-Language: *
```

```http_
HTTP/1.1 200 AppointmentEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 23 May 2013 09:40:58 G5T

{
  "Associate": {
    "AssociateId": 86,
    "Name": "Murazik, Murray and Waters",
    "PersonId": 762,
    "Rank": 914,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 558,
    "FullName": "Hulda Strosin",
    "FormalName": "Hegmann-Harris",
    "Deleted": false,
    "EjUserId": 804,
    "UserName": "Von, Deckow and Herzog",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 613
      }
    }
  },
  "Contact": {
    "ContactId": 516,
    "Name": "Emard, Nader and Lebsack",
    "OrgNr": "915200",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "esse",
    "DirectPhone": "(620)418-5751 x514",
    "AssociateId": 785,
    "CountryId": 350,
    "EmailAddress": "amos@leuschke.ca",
    "Kananame": "in",
    "EmailAddressName": "crystel.bartoletti@lowemarquardt.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Rocio Bogisich",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "qui",
    "FullName": "Zachary Kirlin",
    "IsOwnerContact": false,
    "ActiveErpLinks": 549,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 682
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 675,
    "Name": "Dare, Weissnat and Simonis",
    "PersonId": 398,
    "Rank": 141,
    "Tooltip": "minima",
    "Type": "AnonymousAssociate",
    "GroupIdx": 111,
    "FullName": "Katharina Wiza",
    "FormalName": "Mohr-Labadie",
    "Deleted": true,
    "EjUserId": 608,
    "UserName": "Gibson, Quigley and Powlowski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 911
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 88,
    "Name": "Orn, Towne and Raynor",
    "PersonId": 466,
    "Rank": 251,
    "Tooltip": "error",
    "Type": "AnonymousAssociate",
    "GroupIdx": 420,
    "FullName": "Charley Monahan",
    "FormalName": "Lueilwitz, Zulauf and Kemmer",
    "Deleted": true,
    "EjUserId": 890,
    "UserName": "Williamson Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 106
      }
    }
  },
  "CreatedDate": "2009-10-27T09:40:58.5913703+01:00",
  "AppointmentId": 967,
  "Description": "Decentralized explicit neural-net",
  "StartDate": "2015-05-15T09:40:58.5913703+02:00",
  "EndDate": "2007-12-03T09:40:58.5913703+01:00",
  "InvitedPerson": {
    "Position": "a",
    "PersonId": 613,
    "Mrmrs": "reprehenderit",
    "Firstname": "Charlene",
    "Lastname": "Gusikowski",
    "MiddleName": "Waters-Rolfson",
    "Title": "suscipit",
    "Description": "Managed composite data-warehouse",
    "Email": "maverick@bodereinger.name",
    "FullName": "Ardith Murazik I",
    "DirectPhone": "(375)346-4650 x87005",
    "FormalName": "Balistreri-Corkery",
    "CountryId": 954,
    "ContactId": 323,
    "ContactName": "Torphy-Corwin",
    "Retired": 815,
    "Rank": 458,
    "ActiveInterests": 3,
    "ContactDepartment": "",
    "ContactCountryId": 488,
    "ContactOrgNr": "1518621",
    "FaxPhone": "(884)747-4237 x65218",
    "MobilePhone": "1-012-086-8446",
    "ContactPhone": "841.005.1874 x1164",
    "AssociateName": "Mitchell, Kuhn and O'Keefe",
    "AssociateId": 230,
    "UsePersonAddress": false,
    "ContactFax": "natus",
    "Kanafname": "cupiditate",
    "Kanalname": "nostrum",
    "Post1": "tenetur",
    "Post2": "inventore",
    "Post3": "nisi",
    "EmailName": "ashtyn_sauer@schowalter.co.uk",
    "ContactFullName": "Mrs. Anita Sawayn",
    "ActiveErpLinks": 886,
    "TicketPriorityId": 18,
    "SupportLanguageId": 571,
    "SupportAssociateId": 601,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 843
      }
    }
  },
  "Person": {
    "Position": "omnis",
    "PersonId": 162,
    "Mrmrs": "consequatur",
    "Firstname": "Lilian",
    "Lastname": "Osinski",
    "MiddleName": "Schulist, Doyle and O'Conner",
    "Title": "perspiciatis",
    "Description": "Switchable empowering moderator",
    "Email": "ayana.parker@doyle.us",
    "FullName": "Sigurd Nienow",
    "DirectPhone": "1-618-251-0081",
    "FormalName": "McDermott, Collins and Smitham",
    "CountryId": 212,
    "ContactId": 871,
    "ContactName": "Green-Fisher",
    "Retired": 40,
    "Rank": 682,
    "ActiveInterests": 926,
    "ContactDepartment": "",
    "ContactCountryId": 953,
    "ContactOrgNr": "1405679",
    "FaxPhone": "087-888-3052 x31362",
    "MobilePhone": "1-617-418-8615 x5575",
    "ContactPhone": "582.011.2057 x65511",
    "AssociateName": "Greenholt, Hills and Durgan",
    "AssociateId": 909,
    "UsePersonAddress": false,
    "ContactFax": "amet",
    "Kanafname": "quae",
    "Kanalname": "quae",
    "Post1": "ut",
    "Post2": "est",
    "Post3": "aperiam",
    "EmailName": "rosie@bechtelar.com",
    "ContactFullName": "Jasper Bernier",
    "ActiveErpLinks": 212,
    "TicketPriorityId": 752,
    "SupportLanguageId": 419,
    "SupportAssociateId": 378,
    "CategoryName": "VIP Customer",
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
  "MotherId": 307,
  "Priority": {
    "Id": 282,
    "Value": "est",
    "Tooltip": "impedit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 187
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 590,
    "Name": "Ernser, Breitenberg and Konopelski",
    "Description": "Persevering context-sensitive flexibility",
    "URL": "http://www.example.com/",
    "Type": "consequatur",
    "AssociateId": 612,
    "AssociateFullName": "Letha Kautzer DDS",
    "TypeId": 648,
    "Updated": "2009-04-11T09:40:58.5943726+02:00",
    "StatusId": 240,
    "Status": "occaecati",
    "TextId": 475,
    "PublishTo": "2003-08-20T09:40:58.5943726+02:00",
    "PublishFrom": "2008-02-29T09:40:58.5943726+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1106494",
    "ActiveErpLinks": 387,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "syndicate dynamic bandwidth"
        },
        "FieldType": "System.Int32",
        "FieldLength": 519
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2013-05-23T09:40:58.5943726+02:00",
  "Completed": "Completed",
  "ActiveLinks": 647,
  "Links": [
    {
      "EntityName": "Schimmel, Dickens and Ferry",
      "Id": 121,
      "Description": "Visionary neutral array",
      "ExtraInfo": "eius",
      "LinkId": 373,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 350
        }
      }
    }
  ],
  "AlarmLeadTime": "animi",
  "HasAlarm": false,
  "ColorIndex": 309,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "adipisci",
  "LeadTime": "adipisci",
  "Location": "et",
  "RejectCounter": 946,
  "RejectReason": "evolve real-time vortals",
  "Recurrence": {
    "RecurrenceId": 661,
    "StartDate": "1999-07-23T09:40:58.5943726+02:00",
    "EndDate": "2013-04-21T09:40:58.5943726+02:00",
    "RecurrenceCounter": 875,
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
      "AssociateId": 495,
      "PersonId": 382,
      "ContactId": 304,
      "EmailId": 725,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 495,
      "PersonId": 382,
      "ContactId": 304,
      "EmailId": 725,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2012-07-15T09:40:58.5943726+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 918,
    "Name": "Wolff, Smitham and White",
    "PersonId": 179,
    "Rank": 599,
    "Tooltip": "quae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 555,
    "FullName": "Tristin Terry",
    "FormalName": "Turner, Jacobs and Kuhlman",
    "Deleted": true,
    "EjUserId": 477,
    "UserName": "Hilll-Johnston",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 49
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 33,
    "Name": "Buckridge Inc and Sons",
    "PersonId": 491,
    "Rank": 628,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 491,
    "FullName": "Rosalee Bruen",
    "FormalName": "Connelly Inc and Sons",
    "Deleted": false,
    "EjUserId": 941,
    "UserName": "Hessel-Stamm",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 738
      }
    }
  },
  "Task": {
    "TaskListItemId": 796,
    "Value": "consequatur",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "quasi",
    "Deleted": false,
    "IntentId": 131,
    "Rank": 568,
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
        "FieldLength": 415
      }
    }
  },
  "PreferredTZLocation": 583,
  "Sale": {
    "ContactName": "Barton-Dooley",
    "SaleDate": "2015-10-29T09:40:58.5953706+01:00",
    "SaleId": 181,
    "Probability": 599,
    "Title": "eos",
    "Amount": 990.34399999999994,
    "Currency": "unde",
    "ProjectName": "Kertzmann LLC",
    "AssociateFullName": "Ova Schumm",
    "Description": "Proactive analyzing firmware",
    "Status": "Lost",
    "WeightedAmount": 9066.662,
    "ProjectId": 984,
    "EarningPercent": 22207.523999999998,
    "Earning": 3090.124,
    "ContactId": 259,
    "AssociateId": 322,
    "PersonId": 877,
    "SaleTypeId": 506,
    "SaleTypeName": "Cremin LLC",
    "PersonFullName": "Aurelie Borer",
    "Completed": "Completed",
    "ActiveErpLinks": 643,
    "NextDueDate": "1999-02-06T09:40:58.5953706+01:00",
    "Number": "1293771",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 931
      }
    }
  },
  "SuggestedAppointmentId": 21,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "consequatur",
  "UserDefinedFields": {
    "SuperOffice:1": "647860322",
    "SuperOffice:2": "Dr. Florencio Bechtelar"
  },
  "ExtraFields": {
    "ExtraFields1": "aspernatur",
    "ExtraFields2": "minima"
  },
  "CustomFields": {
    "CustomFields1": "harum",
    "CustomFields2": "quae"
  },
  "PublishEventDate": "2017-02-25T09:40:58.5963705+01:00",
  "PublishTo": "2002-12-03T09:40:58.5963705+01:00",
  "PublishFrom": "2011-10-11T09:40:58.5963705+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 937,
      "Visibility": "All",
      "DisplayValue": "voluptatem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 768
        }
      }
    },
    {
      "VisibleId": 937,
      "Visibility": "All",
      "DisplayValue": "voluptatem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 768
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
      "FieldLength": 508
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```