---
title: POST Agents/Appointment/AssignTo
id: v1AppointmentAgent_AssignTo
---

# POST Agents/Appointment/AssignTo

```http
POST /api/v1/Agents/Appointment/AssignTo
```

Assigning an appointment to another person.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/AssignTo?$select=name,department,category/id
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

AppointmentId, Participant, UpdateMode 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentId | int32 |  |
| Participant |  |  |
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
POST /api/v1/Agents/Appointment/AssignTo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 390,
  "Participant": {
    "AssociateId": 143,
    "PersonId": 407,
    "ContactId": 4,
    "EmailId": 385,
    "SendEmail": false,
    "InvitationStatus": "Accepted"
  },
  "UpdateMode": "OnlyThis"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 856,
    "Name": "Nikolaus-Beahan",
    "PersonId": 884,
    "Rank": 391,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 150,
    "FullName": "Malvina Grady",
    "FormalName": "Huel, White and Anderson",
    "Deleted": true,
    "EjUserId": 91,
    "UserName": "Stoltenberg, Cruickshank and Wilderman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 166
      }
    }
  },
  "Contact": {
    "ContactId": 227,
    "Name": "Olson Group",
    "OrgNr": "535502",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ad",
    "DirectPhone": "(835)333-4716",
    "AssociateId": 340,
    "CountryId": 706,
    "EmailAddress": "eloy@stehrbuckridge.biz",
    "Kananame": "iste",
    "EmailAddressName": "alexys@fadelkohler.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Favian Lind I",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quo",
    "FullName": "Miss Asia Wisozk",
    "IsOwnerContact": true,
    "ActiveErpLinks": 412,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 446
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 824,
    "Name": "Shanahan-Leannon",
    "PersonId": 885,
    "Rank": 353,
    "Tooltip": "numquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 771,
    "FullName": "Minnie Stroman",
    "FormalName": "Stokes, Jenkins and Tromp",
    "Deleted": false,
    "EjUserId": 131,
    "UserName": "Fritsch Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 532
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 221,
    "Name": "Jacobi-Prosacco",
    "PersonId": 164,
    "Rank": 874,
    "Tooltip": "a",
    "Type": "AnonymousAssociate",
    "GroupIdx": 956,
    "FullName": "Tyrique Marvin",
    "FormalName": "Trantow, Hansen and Spinka",
    "Deleted": true,
    "EjUserId": 183,
    "UserName": "Schroeder-Douglas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 553
      }
    }
  },
  "CreatedDate": "2002-05-27T16:48:28.5934489+02:00",
  "AppointmentId": 273,
  "Description": "Distributed solution-oriented secured line",
  "StartDate": "2015-09-14T16:48:28.5934489+02:00",
  "EndDate": "1995-08-14T16:48:28.5934489+02:00",
  "InvitedPerson": {
    "Position": "dolores",
    "PersonId": 84,
    "Mrmrs": "est",
    "Firstname": "Lenora",
    "Lastname": "Okuneva",
    "MiddleName": "Upton-Padberg",
    "Title": "perferendis",
    "Description": "User-friendly even-keeled data-warehouse",
    "Email": "tiana@predovic.com",
    "FullName": "Ahmad Gibson",
    "DirectPhone": "151.763.1102",
    "FormalName": "Schroeder, Langworth and Dietrich",
    "CountryId": 500,
    "ContactId": 523,
    "ContactName": "Turcotte, Ledner and Durgan",
    "Retired": 28,
    "Rank": 558,
    "ActiveInterests": 203,
    "ContactDepartment": "",
    "ContactCountryId": 1001,
    "ContactOrgNr": "945355",
    "FaxPhone": "1-665-174-4846",
    "MobilePhone": "1-267-814-4381",
    "ContactPhone": "1-374-025-3674 x60325",
    "AssociateName": "Zboncak-Berge",
    "AssociateId": 740,
    "UsePersonAddress": false,
    "ContactFax": "aperiam",
    "Kanafname": "incidunt",
    "Kanalname": "non",
    "Post1": "architecto",
    "Post2": "ut",
    "Post3": "quisquam",
    "EmailName": "rodrick.schulist@runolfsdottircarter.info",
    "ContactFullName": "Merritt Veum",
    "ActiveErpLinks": 646,
    "TicketPriorityId": 590,
    "SupportLanguageId": 763,
    "SupportAssociateId": 381,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 471
      }
    }
  },
  "Person": {
    "Position": "eius",
    "PersonId": 700,
    "Mrmrs": "ea",
    "Firstname": "Angela",
    "Lastname": "Gerlach",
    "MiddleName": "Casper-Balistreri",
    "Title": "officiis",
    "Description": "Front-line motivating website",
    "Email": "lavonne@sanford.name",
    "FullName": "Tavares Hartmann",
    "DirectPhone": "1-156-784-8044",
    "FormalName": "Windler Group",
    "CountryId": 755,
    "ContactId": 365,
    "ContactName": "Ziemann Group",
    "Retired": 253,
    "Rank": 839,
    "ActiveInterests": 607,
    "ContactDepartment": "",
    "ContactCountryId": 607,
    "ContactOrgNr": "1455454",
    "FaxPhone": "682.327.4285 x8207",
    "MobilePhone": "1-214-758-0508 x15440",
    "ContactPhone": "801-707-0133",
    "AssociateName": "Schneider, Rogahn and Dooley",
    "AssociateId": 704,
    "UsePersonAddress": false,
    "ContactFax": "recusandae",
    "Kanafname": "accusamus",
    "Kanalname": "vel",
    "Post1": "vero",
    "Post2": "exercitationem",
    "Post3": "blanditiis",
    "EmailName": "bo@reichert.ca",
    "ContactFullName": "Dedrick Wehner",
    "ActiveErpLinks": 19,
    "TicketPriorityId": 861,
    "SupportLanguageId": 413,
    "SupportAssociateId": 28,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 159
      }
    }
  },
  "MotherId": 220,
  "Priority": {
    "Id": 884,
    "Value": "dolore",
    "Tooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "enhance ubiquitous channels"
        },
        "FieldType": "System.String",
        "FieldLength": 301
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 752,
    "Name": "O'Conner-Bauch",
    "Description": "Function-based explicit algorithm",
    "URL": "http://www.example.com/",
    "Type": "ipsum",
    "AssociateId": 255,
    "AssociateFullName": "Noble Kerluke",
    "TypeId": 75,
    "Updated": "1995-01-13T16:48:28.5954486+01:00",
    "StatusId": 845,
    "Status": "reprehenderit",
    "TextId": 928,
    "PublishTo": "2002-01-23T16:48:28.5954486+01:00",
    "PublishFrom": "2007-01-29T16:48:28.5954486+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "489252",
    "ActiveErpLinks": 737,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 599
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2000-05-24T16:48:28.5964512+02:00",
  "Completed": "Completed",
  "ActiveLinks": 640,
  "Links": [
    {
      "EntityName": "Brekke, Rodriguez and Hirthe",
      "Id": 229,
      "Description": "Configurable stable attitude",
      "ExtraInfo": "quo",
      "LinkId": 629,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 492
        }
      }
    }
  ],
  "AlarmLeadTime": "qui",
  "HasAlarm": true,
  "ColorIndex": 793,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "laboriosam",
  "LeadTime": "odio",
  "Location": "voluptate",
  "RejectCounter": 896,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 373,
    "StartDate": "2007-07-15T16:48:28.5964512+02:00",
    "EndDate": "2007-09-30T16:48:28.5964512+02:00",
    "RecurrenceCounter": 123,
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
      "AssociateId": 212,
      "PersonId": 469,
      "ContactId": 633,
      "EmailId": 295,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 212,
      "PersonId": 469,
      "ContactId": 633,
      "EmailId": 295,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2009-09-08T16:48:28.5964512+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 143,
    "Name": "Homenick, Douglas and Morissette",
    "PersonId": 971,
    "Rank": 359,
    "Tooltip": "dignissimos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 362,
    "FullName": "Theo Pouros",
    "FormalName": "Olson, Terry and Eichmann",
    "Deleted": true,
    "EjUserId": 667,
    "UserName": "Haag-Ledner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 500
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 895,
    "Name": "Gerlach LLC",
    "PersonId": 734,
    "Rank": 21,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 80,
    "FullName": "Shanon Lebsack DDS",
    "FormalName": "Aufderhar Inc and Sons",
    "Deleted": false,
    "EjUserId": 534,
    "UserName": "Mills, Conn and Von",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 757
      }
    }
  },
  "Task": {
    "TaskListItemId": 513,
    "Value": "laudantium",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "rem",
    "Deleted": true,
    "IntentId": 18,
    "Rank": 187,
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
        "FieldType": "System.String",
        "FieldLength": 332
      }
    }
  },
  "PreferredTZLocation": 613,
  "Sale": {
    "ContactName": "Konopelski, Graham and Harris",
    "SaleDate": "2017-08-31T16:48:28.5974486+02:00",
    "SaleId": 398,
    "Probability": 712,
    "Title": "facere",
    "Amount": 3331.442,
    "Currency": "sequi",
    "ProjectName": "Gislason Group",
    "AssociateFullName": "Humberto Padberg",
    "Description": "Total needs-based analyzer",
    "Status": "Lost",
    "WeightedAmount": 2046.502,
    "ProjectId": 836,
    "EarningPercent": 1971.2859999999998,
    "Earning": 6938.6759999999995,
    "ContactId": 619,
    "AssociateId": 32,
    "PersonId": 178,
    "SaleTypeId": 97,
    "SaleTypeName": "Parker Inc and Sons",
    "PersonFullName": "Ruby Bauch",
    "Completed": "Completed",
    "ActiveErpLinks": 136,
    "NextDueDate": "2013-10-08T16:48:28.5974486+02:00",
    "Number": "1364091",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 317
      }
    }
  },
  "SuggestedAppointmentId": 979,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "asperiores",
  "UserDefinedFields": {
    "SuperOffice:1": "1950380890",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "quisquam"
  },
  "PublishEventDate": "2003-03-02T16:48:28.5974486+01:00",
  "PublishTo": "2000-01-14T16:48:28.5974486+01:00",
  "PublishFrom": "2016-02-18T16:48:28.5974486+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 311,
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
          "FieldLength": 198
        }
      }
    },
    {
      "VisibleId": 311,
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
          "FieldLength": 198
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
      "FieldLength": 810
    }
  }
}
```