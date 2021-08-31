---
title: Save
id: v1AppointmentAgent_Save
---

# Save

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AppointmentEntity": {
    "Associate": {},
    "Contact": {},
    "CreatedBy": {},
    "UpdatedBy": {},
    "CreatedDate": "2017-05-03T14:58:03.1845677+02:00",
    "AppointmentId": 983,
    "Description": "Centralized empowering leverage",
    "StartDate": "1999-03-21T14:58:03.1845677+01:00",
    "EndDate": "2021-03-09T14:58:03.1845677+01:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 322,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "1996-04-10T14:58:03.1845677+02:00",
    "Completed": "Completed",
    "ActiveLinks": 220,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "et",
    "HasAlarm": true,
    "ColorIndex": 344,
    "IsFree": true,
    "IsAlldayEvent": true,
    "LagTime": "itaque",
    "LeadTime": "quo",
    "Location": "aut",
    "RejectCounter": 130,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "1997-05-22T14:58:03.1855683+02:00",
    "HasConflict": true,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 225,
    "Sale": {},
    "SuggestedAppointmentId": 720,
    "IsMileStone": false,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "fuga",
    "UserDefinedFields": {
      "SuperOffice:1": "1725892170",
      "SuperOffice:2": "Domingo Hammes"
    },
    "ExtraFields": {
      "ExtraFields1": "quam",
      "ExtraFields2": "eaque"
    },
    "CustomFields": {
      "CustomFields1": "est",
      "CustomFields2": "dicta"
    },
    "PublishEventDate": "2021-01-30T14:58:03.1855683+01:00",
    "PublishTo": "2013-06-17T14:58:03.1855683+02:00",
    "PublishFrom": "2002-03-06T14:58:03.1855683+01:00",
    "IsPublished": true,
    "VisibleFor": [
      {},
      {}
    ]
  },
  "UpdateMode": "OnlyThis",
  "SendEmailToParticipants": true,
  "SmtpEMailConnectionInfo": {
    "ServerName": "Lockman-Jenkins",
    "UserName": "Reichert Inc and Sons",
    "Password": "iusto",
    "Folder": "deleniti",
    "UseSSL": true
  },
  "ImapEMailConnectionInfo": {
    "ServerName": "Reichel, Bartell and Gerlach",
    "UserName": "Raynor Inc and Sons",
    "Password": "iure",
    "Folder": "impedit",
    "UseSSL": true
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 743,
    "Name": "Schaefer, Christiansen and Erdman",
    "PersonId": 107,
    "Rank": 204,
    "Tooltip": "nisi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 435,
    "FullName": "Maynard Crist",
    "FormalName": "Sauer-Reynolds",
    "Deleted": true,
    "EjUserId": 463,
    "UserName": "Upton, Ledner and Windler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 635
      }
    }
  },
  "Contact": {
    "ContactId": 918,
    "Name": "Heller-Balistreri",
    "OrgNr": "726461",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ut",
    "DirectPhone": "(807)605-2027 x3806",
    "AssociateId": 555,
    "CountryId": 468,
    "EmailAddress": "kenna.rohan@padberglubowitz.uk",
    "Kananame": "officia",
    "EmailAddressName": "norberto.zboncak@predovic.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Amiya McClure",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "eveniet",
    "FullName": "Lyla Gleason",
    "IsOwnerContact": true,
    "ActiveErpLinks": 883,
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
  "CreatedBy": {
    "AssociateId": 473,
    "Name": "White-Bernhard",
    "PersonId": 244,
    "Rank": 598,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 410,
    "FullName": "Heloise Osinski",
    "FormalName": "Rohan-Gottlieb",
    "Deleted": false,
    "EjUserId": 723,
    "UserName": "Wolf-Ankunding",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 671
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 351,
    "Name": "Crist LLC",
    "PersonId": 673,
    "Rank": 261,
    "Tooltip": "repellat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 293,
    "FullName": "Allison Zulauf",
    "FormalName": "Quitzon-Schumm",
    "Deleted": true,
    "EjUserId": 531,
    "UserName": "Marquardt LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "synthesize customized initiatives"
        },
        "FieldType": "System.Int32",
        "FieldLength": 292
      }
    }
  },
  "CreatedDate": "2004-10-27T14:58:03.1945676+02:00",
  "AppointmentId": 586,
  "Description": "Virtual optimal encoding",
  "StartDate": "2010-09-18T14:58:03.1945676+02:00",
  "EndDate": "1997-03-28T14:58:03.1945676+01:00",
  "InvitedPerson": {
    "Position": "sed",
    "PersonId": 829,
    "Mrmrs": "voluptatem",
    "Firstname": "Brad",
    "Lastname": "Johnston",
    "MiddleName": "Gerlach Inc and Sons",
    "Title": "quisquam",
    "Description": "Expanded value-added capacity",
    "Email": "walker_bogan@crona.biz",
    "FullName": "Joey Runolfsson",
    "DirectPhone": "372-865-5165",
    "FormalName": "Bahringer, King and Beatty",
    "CountryId": 914,
    "ContactId": 839,
    "ContactName": "Orn-Kiehn",
    "Retired": 228,
    "Rank": 343,
    "ActiveInterests": 458,
    "ContactDepartment": "",
    "ContactCountryId": 3,
    "ContactOrgNr": "222773",
    "FaxPhone": "644-233-0048",
    "MobilePhone": "416-648-2651",
    "ContactPhone": "118-046-8728",
    "AssociateName": "Huels-Simonis",
    "AssociateId": 728,
    "UsePersonAddress": true,
    "ContactFax": "sit",
    "Kanafname": "autem",
    "Kanalname": "dignissimos",
    "Post1": "rem",
    "Post2": "quia",
    "Post3": "est",
    "EmailName": "zack_hansen@bednarkuhic.us",
    "ContactFullName": "Enoch Gottlieb",
    "ActiveErpLinks": 843,
    "TicketPriorityId": 372,
    "SupportLanguageId": 115,
    "SupportAssociateId": 655,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 728
      }
    }
  },
  "Person": {
    "Position": "consequatur",
    "PersonId": 238,
    "Mrmrs": "sapiente",
    "Firstname": "Amely",
    "Lastname": "Gerlach",
    "MiddleName": "Schmitt Inc and Sons",
    "Title": "id",
    "Description": "Reduced 24/7 artificial intelligence",
    "Email": "retha_oconnell@hauck.name",
    "FullName": "Mr. Pietro Abernathy",
    "DirectPhone": "(723)255-5636 x22860",
    "FormalName": "McGlynn, Lesch and Shanahan",
    "CountryId": 275,
    "ContactId": 187,
    "ContactName": "Ankunding, Jacobi and Wilderman",
    "Retired": 389,
    "Rank": 533,
    "ActiveInterests": 605,
    "ContactDepartment": "",
    "ContactCountryId": 619,
    "ContactOrgNr": "1166103",
    "FaxPhone": "(208)241-3414",
    "MobilePhone": "(363)531-3486 x68202",
    "ContactPhone": "183-670-0660",
    "AssociateName": "Bradtke-Howell",
    "AssociateId": 464,
    "UsePersonAddress": false,
    "ContactFax": "aliquid",
    "Kanafname": "accusantium",
    "Kanalname": "delectus",
    "Post1": "magnam",
    "Post2": "quia",
    "Post3": "minima",
    "EmailName": "kadin.rippin@dicki.com",
    "ContactFullName": "Nikko Rohan",
    "ActiveErpLinks": 37,
    "TicketPriorityId": 352,
    "SupportLanguageId": 625,
    "SupportAssociateId": 750,
    "CategoryName": "VIP Customer",
    "TableRight": {},
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
  },
  "MotherId": 127,
  "Priority": {
    "Id": 513,
    "Value": "est",
    "Tooltip": "fugit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 244
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 266,
    "Name": "Keebler-Robel",
    "Description": "Open-source bi-directional middleware",
    "URL": "http://www.example.com/",
    "Type": "velit",
    "AssociateId": 910,
    "AssociateFullName": "Daija Goyette",
    "TypeId": 265,
    "Updated": "2005-03-19T14:58:03.1975487+01:00",
    "StatusId": 113,
    "Status": "et",
    "TextId": 218,
    "PublishTo": "1997-01-25T14:58:03.1975487+01:00",
    "PublishFrom": "1995-08-03T14:58:03.1975487+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1105459",
    "ActiveErpLinks": 771,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 627
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2016-12-08T14:58:03.1975487+01:00",
  "Completed": "Completed",
  "ActiveLinks": 2,
  "Links": [
    {
      "EntityName": "Kuhn, Donnelly and Mills",
      "Id": 609,
      "Description": "Configurable mission-critical frame",
      "ExtraInfo": "officia",
      "LinkId": 436,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 427
        }
      }
    }
  ],
  "AlarmLeadTime": "alias",
  "HasAlarm": true,
  "ColorIndex": 366,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "voluptates",
  "LeadTime": "nesciunt",
  "Location": "hic",
  "RejectCounter": 294,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 692,
    "StartDate": "1995-02-07T14:58:03.1975487+01:00",
    "EndDate": "2001-07-11T14:58:03.1975487+02:00",
    "RecurrenceCounter": 749,
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
      "AssociateId": 406,
      "PersonId": 510,
      "ContactId": 72,
      "EmailId": 555,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 406,
      "PersonId": 510,
      "ContactId": 72,
      "EmailId": 555,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2005-05-23T14:58:03.198571+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 908,
    "Name": "Kemmer-Mueller",
    "PersonId": 915,
    "Rank": 810,
    "Tooltip": "expedita",
    "Type": "AnonymousAssociate",
    "GroupIdx": 586,
    "FullName": "Immanuel Nader",
    "FormalName": "Halvorson Inc and Sons",
    "Deleted": true,
    "EjUserId": 618,
    "UserName": "Waters, Bins and Collier",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 248
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 812,
    "Name": "Schneider-Shanahan",
    "PersonId": 140,
    "Rank": 324,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 873,
    "FullName": "Annabel Bednar",
    "FormalName": "Bins, Macejkovic and McClure",
    "Deleted": true,
    "EjUserId": 929,
    "UserName": "Kemmer LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 155
      }
    }
  },
  "Task": {
    "TaskListItemId": 701,
    "Value": "ea",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "magni",
    "Deleted": false,
    "IntentId": 1000,
    "Rank": 257,
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
          "Reason": "deploy magnetic eyeballs"
        },
        "FieldType": "System.String",
        "FieldLength": 773
      }
    }
  },
  "PreferredTZLocation": 858,
  "Sale": {
    "ContactName": "Lubowitz-Konopelski",
    "SaleDate": "2003-02-19T14:58:03.198571+01:00",
    "SaleId": 428,
    "Probability": 813,
    "Title": "magni",
    "Amount": 14168.814,
    "Currency": "maiores",
    "ProjectName": "Turcotte-Borer",
    "AssociateFullName": "Bennett Upton",
    "Description": "Upgradable fault-tolerant system engine",
    "Status": "Lost",
    "WeightedAmount": 22279.606,
    "ProjectId": 455,
    "EarningPercent": 23179.064,
    "Earning": 24228.953999999998,
    "ContactId": 188,
    "AssociateId": 298,
    "PersonId": 291,
    "SaleTypeId": 843,
    "SaleTypeName": "King, Medhurst and Walter",
    "PersonFullName": "Sofia Emmerich",
    "Completed": "Completed",
    "ActiveErpLinks": 156,
    "NextDueDate": "2002-05-07T14:58:03.1995676+02:00",
    "Number": "1445041",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 463
      }
    }
  },
  "SuggestedAppointmentId": 533,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "laboriosam",
  "UserDefinedFields": {
    "SuperOffice:1": "629731563",
    "SuperOffice:2": "Miss Bailey Rempel"
  },
  "ExtraFields": {
    "ExtraFields1": "labore",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "perspiciatis",
    "CustomFields2": "reprehenderit"
  },
  "PublishEventDate": "2002-08-17T14:58:03.1995676+02:00",
  "PublishTo": "2019-02-04T14:58:03.1995676+01:00",
  "PublishFrom": "2016-04-20T14:58:03.1995676+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 811,
      "Visibility": "All",
      "DisplayValue": "provident",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 476
        }
      }
    },
    {
      "VisibleId": 811,
      "Visibility": "All",
      "DisplayValue": "provident",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 476
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
      "FieldLength": 502
    }
  }
}
```