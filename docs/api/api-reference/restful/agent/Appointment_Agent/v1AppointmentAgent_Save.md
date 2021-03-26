---
title: POST Agents/Appointment/Save
id: v1AppointmentAgent_Save
---

# POST Agents/Appointment/Save

```http
POST /api/v1/Agents/Appointment/Save
```

Saving a booking.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/Save?$select=name,department,category/id
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

AppointmentEntity, UpdateMode, SendEmailToParticipants, SmtpEMailConnectionInfo, ImapEMailConnectionInfo 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentEntity |  | Partial AppointmentEntity class associating the generated AppointmentEntity with an interface. |
| UpdateMode | string |  |
| SendEmailToParticipants | bool |  |
| SmtpEMailConnectionInfo |  | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
| ImapEMailConnectionInfo |  | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |


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
POST /api/v1/Agents/Appointment/Save
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AppointmentEntity": {
    "Associate": {},
    "Contact": {},
    "CreatedBy": {},
    "UpdatedBy": {},
    "CreatedDate": "2003-04-16T16:48:28.5664496+02:00",
    "AppointmentId": 493,
    "Description": "Stand-alone uniform artificial intelligence",
    "StartDate": "2003-12-02T16:48:28.5664496+01:00",
    "EndDate": "2015-01-30T16:48:28.5664496+01:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 231,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "2002-10-09T16:48:28.5664496+02:00",
    "Completed": "Completed",
    "ActiveLinks": 396,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "iste",
    "HasAlarm": false,
    "ColorIndex": 435,
    "IsFree": true,
    "IsAlldayEvent": true,
    "LagTime": "quia",
    "LeadTime": "fugit",
    "Location": "sed",
    "RejectCounter": 700,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "2001-10-01T16:48:28.567457+02:00",
    "HasConflict": false,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 942,
    "Sale": {},
    "SuggestedAppointmentId": 373,
    "IsMileStone": false,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "fugiat",
    "UserDefinedFields": {
      "SuperOffice:1": "Ms. Marlene Goodwin",
      "SuperOffice:2": "False"
    },
    "ExtraFields": {
      "ExtraFields1": "dolores",
      "ExtraFields2": "et"
    },
    "CustomFields": {
      "CustomFields1": "aperiam",
      "CustomFields2": "beatae"
    },
    "PublishEventDate": "2012-05-12T16:48:28.567457+02:00",
    "PublishTo": "2010-11-13T16:48:28.567457+01:00",
    "PublishFrom": "2002-11-03T16:48:28.567457+01:00",
    "IsPublished": false,
    "VisibleFor": [
      {},
      {}
    ]
  },
  "UpdateMode": "OnlyThis",
  "SendEmailToParticipants": true,
  "SmtpEMailConnectionInfo": {
    "ServerName": "Smith-Hilpert",
    "UserName": "Zulauf LLC",
    "Password": "sunt",
    "Folder": "sed",
    "UseSSL": false
  },
  "ImapEMailConnectionInfo": {
    "ServerName": "Klocko-O'Conner",
    "UserName": "Oberbrunner, Smith and Cummerata",
    "Password": "blanditiis",
    "Folder": "porro",
    "UseSSL": true
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 114,
    "Name": "Flatley, Haag and Abbott",
    "PersonId": 421,
    "Rank": 92,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 602,
    "FullName": "Danyka Hamill",
    "FormalName": "Kilback Inc and Sons",
    "Deleted": false,
    "EjUserId": 371,
    "UserName": "Goyette-Fay",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 897
      }
    }
  },
  "Contact": {
    "ContactId": 182,
    "Name": "Jacobi, Swaniawski and Bauch",
    "OrgNr": "242733",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "fugit",
    "DirectPhone": "867-571-1822",
    "AssociateId": 472,
    "CountryId": 389,
    "EmailAddress": "johnathan.kerluke@cruickshank.biz",
    "Kananame": "odit",
    "EmailAddressName": "brett@legros.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Aubree Williamson",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "consequuntur",
    "FullName": "Ms. Zora Kshlerin",
    "IsOwnerContact": true,
    "ActiveErpLinks": 785,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 712
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 571,
    "Name": "Hessel, Torp and Muller",
    "PersonId": 460,
    "Rank": 89,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 244,
    "FullName": "Kitty Kassulke",
    "FormalName": "McLaughlin Inc and Sons",
    "Deleted": true,
    "EjUserId": 977,
    "UserName": "Hodkiewicz-Kassulke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 887
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 723,
    "Name": "Rutherford, Bergstrom and Balistreri",
    "PersonId": 285,
    "Rank": 524,
    "Tooltip": "error",
    "Type": "AnonymousAssociate",
    "GroupIdx": 171,
    "FullName": "Dr. Rodger Towne",
    "FormalName": "Powlowski, Okuneva and Torp",
    "Deleted": true,
    "EjUserId": 977,
    "UserName": "Huels-Langworth",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 249
      }
    }
  },
  "CreatedDate": "2012-03-03T16:48:28.5764551+01:00",
  "AppointmentId": 144,
  "Description": "Devolved zero administration pricing structure",
  "StartDate": "2000-12-24T16:48:28.5764551+01:00",
  "EndDate": "2001-01-19T16:48:28.5764551+01:00",
  "InvitedPerson": {
    "Position": "in",
    "PersonId": 200,
    "Mrmrs": "a",
    "Firstname": "Ashlynn",
    "Lastname": "Beatty",
    "MiddleName": "Bechtelar, Johnston and Barton",
    "Title": "eos",
    "Description": "Monitored motivating policy",
    "Email": "jerrod_vandervort@grady.uk",
    "FullName": "Shaun Goodwin",
    "DirectPhone": "371.310.4141",
    "FormalName": "Hane, Walter and Quigley",
    "CountryId": 347,
    "ContactId": 94,
    "ContactName": "Paucek-Gibson",
    "Retired": 804,
    "Rank": 695,
    "ActiveInterests": 412,
    "ContactDepartment": "",
    "ContactCountryId": 484,
    "ContactOrgNr": "865126",
    "FaxPhone": "127.607.7312 x630",
    "MobilePhone": "426.538.3817 x15440",
    "ContactPhone": "1-623-437-6374 x021",
    "AssociateName": "Walker, Heaney and Ernser",
    "AssociateId": 841,
    "UsePersonAddress": true,
    "ContactFax": "est",
    "Kanafname": "facilis",
    "Kanalname": "ratione",
    "Post1": "voluptatem",
    "Post2": "in",
    "Post3": "laboriosam",
    "EmailName": "hilma@lednerhirthe.co.uk",
    "ContactFullName": "Lela Mosciski",
    "ActiveErpLinks": 519,
    "TicketPriorityId": 325,
    "SupportLanguageId": 719,
    "SupportAssociateId": 881,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 309
      }
    }
  },
  "Person": {
    "Position": "quibusdam",
    "PersonId": 400,
    "Mrmrs": "veniam",
    "Firstname": "Rocky",
    "Lastname": "VonRueden",
    "MiddleName": "Orn, Kunze and Hickle",
    "Title": "cumque",
    "Description": "Reduced solution-oriented Graphic Interface",
    "Email": "monserrat@kuhn.us",
    "FullName": "Darron Mills",
    "DirectPhone": "(216)883-7060 x6056",
    "FormalName": "Quitzon, Kutch and Cronin",
    "CountryId": 434,
    "ContactId": 921,
    "ContactName": "Kunze, Hamill and Purdy",
    "Retired": 182,
    "Rank": 342,
    "ActiveInterests": 291,
    "ContactDepartment": "",
    "ContactCountryId": 339,
    "ContactOrgNr": "1159228",
    "FaxPhone": "615.585.3675",
    "MobilePhone": "345-265-7747",
    "ContactPhone": "(777)065-1762 x3233",
    "AssociateName": "Collier Group",
    "AssociateId": 942,
    "UsePersonAddress": false,
    "ContactFax": "veritatis",
    "Kanafname": "qui",
    "Kanalname": "ut",
    "Post1": "aspernatur",
    "Post2": "autem",
    "Post3": "dolorum",
    "EmailName": "laurine@greenholt.info",
    "ContactFullName": "Nyah O'Keefe",
    "ActiveErpLinks": 990,
    "TicketPriorityId": 909,
    "SupportLanguageId": 728,
    "SupportAssociateId": 994,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 639
      }
    }
  },
  "MotherId": 465,
  "Priority": {
    "Id": 32,
    "Value": "est",
    "Tooltip": "dolorum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 824
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 533,
    "Name": "Kuhn-Friesen",
    "Description": "Reactive client-server orchestration",
    "URL": "http://www.example.com/",
    "Type": "quia",
    "AssociateId": 268,
    "AssociateFullName": "Vincenza Cole",
    "TypeId": 999,
    "Updated": "2021-01-03T16:48:28.5794491+01:00",
    "StatusId": 76,
    "Status": "est",
    "TextId": 983,
    "PublishTo": "2019-03-12T16:48:28.5794491+01:00",
    "PublishFrom": "2014-08-28T16:48:28.5794491+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1814198",
    "ActiveErpLinks": 472,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 377
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2007-04-13T16:48:28.5794491+02:00",
  "Completed": "Completed",
  "ActiveLinks": 22,
  "Links": [
    {
      "EntityName": "Feest-Boehm",
      "Id": 497,
      "Description": "Profound 3rd generation projection",
      "ExtraInfo": "rerum",
      "LinkId": 706,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 767
        }
      }
    }
  ],
  "AlarmLeadTime": "magni",
  "HasAlarm": false,
  "ColorIndex": 564,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "repellat",
  "LeadTime": "libero",
  "Location": "omnis",
  "RejectCounter": 981,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 255,
    "StartDate": "2020-10-26T16:48:28.5794491+01:00",
    "EndDate": "2004-11-03T16:48:28.5794491+01:00",
    "RecurrenceCounter": 758,
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
      "AssociateId": 764,
      "PersonId": 927,
      "ContactId": 580,
      "EmailId": 551,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 764,
      "PersonId": 927,
      "ContactId": 580,
      "EmailId": 551,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2006-09-15T16:48:28.5804513+02:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 405,
    "Name": "Morar, Hane and Shields",
    "PersonId": 962,
    "Rank": 900,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 975,
    "FullName": "Taylor Thiel",
    "FormalName": "Altenwerth Inc and Sons",
    "Deleted": false,
    "EjUserId": 108,
    "UserName": "Klocko-Cassin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 970
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 14,
    "Name": "Roberts, Cassin and Nolan",
    "PersonId": 695,
    "Rank": 142,
    "Tooltip": "autem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 182,
    "FullName": "Christy Nienow",
    "FormalName": "Pouros, Ortiz and Yundt",
    "Deleted": false,
    "EjUserId": 515,
    "UserName": "Ortiz-O'Hara",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 462
      }
    }
  },
  "Task": {
    "TaskListItemId": 917,
    "Value": "minima",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "eos",
    "Deleted": false,
    "IntentId": 987,
    "Rank": 156,
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
        "FieldLength": 273
      }
    }
  },
  "PreferredTZLocation": 687,
  "Sale": {
    "ContactName": "Roob-Runolfsdottir",
    "SaleDate": "2008-10-15T16:48:28.5804513+02:00",
    "SaleId": 216,
    "Probability": 226,
    "Title": "nemo",
    "Amount": 10708.877999999999,
    "Currency": "in",
    "ProjectName": "Crooks, Feeney and Fadel",
    "AssociateFullName": "Autumn Glover",
    "Description": "Organized scalable firmware",
    "Status": "Lost",
    "WeightedAmount": 27341.016,
    "ProjectId": 540,
    "EarningPercent": 16390.82,
    "Earning": 1861.596,
    "ContactId": 510,
    "AssociateId": 243,
    "PersonId": 469,
    "SaleTypeId": 169,
    "SaleTypeName": "Hauck-Cremin",
    "PersonFullName": "Zachery Cronin",
    "Completed": "Completed",
    "ActiveErpLinks": 826,
    "NextDueDate": "2006-07-06T16:48:28.5814529+02:00",
    "Number": "807061",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 578
      }
    }
  },
  "SuggestedAppointmentId": 448,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "debitis",
  "UserDefinedFields": {
    "SuperOffice:1": "1611183745",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "porro",
    "CustomFields2": "quo"
  },
  "PublishEventDate": "2016-06-14T16:48:28.5814529+02:00",
  "PublishTo": "2004-01-16T16:48:28.5814529+01:00",
  "PublishFrom": "2014-08-24T16:48:28.5814529+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 367,
      "Visibility": "All",
      "DisplayValue": "cum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 375
        }
      }
    },
    {
      "VisibleId": 367,
      "Visibility": "All",
      "DisplayValue": "cum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 375
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
      "FieldLength": 294
    }
  }
}
```