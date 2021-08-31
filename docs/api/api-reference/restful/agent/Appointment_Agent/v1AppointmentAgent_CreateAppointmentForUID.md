---
title: CreateAppointmentForUID
id: v1AppointmentAgent_CreateAppointmentForUID
---

# CreateAppointmentForUID

```http
POST /api/v1/Agents/Appointment/CreateAppointmentForUID
```

Create an invitation record and an appointment with a given UID to reserve it if the UID is unused, otherwise null.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateAppointmentForUID?$select=name,department,category/id
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

AppointmentEntity, UID 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentEntity |  | Partial AppointmentEntity class associating the generated AppointmentEntity with an interface. |
| UID | string |  |


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
POST /api/v1/Agents/Appointment/CreateAppointmentForUID
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AppointmentEntity": {
    "Associate": {},
    "Contact": {},
    "CreatedBy": {},
    "UpdatedBy": {},
    "CreatedDate": "2001-10-02T14:58:03.0055385+02:00",
    "AppointmentId": 387,
    "Description": "Programmable heuristic instruction set",
    "StartDate": "2006-06-25T14:58:03.0055385+02:00",
    "EndDate": "1995-09-29T14:58:03.0055385+02:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 755,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "1997-06-28T14:58:03.0055385+02:00",
    "Completed": "Completed",
    "ActiveLinks": 194,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "quisquam",
    "HasAlarm": false,
    "ColorIndex": 62,
    "IsFree": false,
    "IsAlldayEvent": true,
    "LagTime": "et",
    "LeadTime": "qui",
    "Location": "sint",
    "RejectCounter": 112,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "1997-06-10T14:58:03.0065388+02:00",
    "HasConflict": false,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 236,
    "Sale": {},
    "SuggestedAppointmentId": 380,
    "IsMileStone": false,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "iure",
    "UserDefinedFields": {
      "SuperOffice:1": "Fredy Schuster",
      "SuperOffice:2": "False"
    },
    "ExtraFields": {
      "ExtraFields1": "facilis",
      "ExtraFields2": "esse"
    },
    "CustomFields": {
      "CustomFields1": "harum",
      "CustomFields2": "necessitatibus"
    },
    "PublishEventDate": "2012-10-27T14:58:03.0065388+02:00",
    "PublishTo": "2001-06-03T14:58:03.0065388+02:00",
    "PublishFrom": "2014-12-25T14:58:03.0065388+01:00",
    "IsPublished": true,
    "VisibleFor": [
      {},
      {}
    ]
  },
  "UID": "in"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 455,
    "Name": "Okuneva, Schneider and Kihn",
    "PersonId": 969,
    "Rank": 713,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 550,
    "FullName": "Kenya Reynolds",
    "FormalName": "Schuster-Pacocha",
    "Deleted": false,
    "EjUserId": 907,
    "UserName": "Harber, Senger and VonRueden",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 699
      }
    }
  },
  "Contact": {
    "ContactId": 41,
    "Name": "Fisher, Wilkinson and McLaughlin",
    "OrgNr": "471000",
    "Department": "morph 24/7 interfaces",
    "URL": "http://www.example.com/",
    "City": "modi",
    "DirectPhone": "1-333-646-7861 x16565",
    "AssociateId": 897,
    "CountryId": 784,
    "EmailAddress": "royal.osinski@satterfield.uk",
    "Kananame": "est",
    "EmailAddressName": "kristian@shields.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Heather Lynch",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nisi",
    "FullName": "Ricky Cassin",
    "IsOwnerContact": true,
    "ActiveErpLinks": 31,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 449
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 498,
    "Name": "Kling-Mohr",
    "PersonId": 55,
    "Rank": 956,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 998,
    "FullName": "Andre Goyette",
    "FormalName": "Rosenbaum Inc and Sons",
    "Deleted": true,
    "EjUserId": 363,
    "UserName": "Roberts Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 632
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 945,
    "Name": "Little-Miller",
    "PersonId": 752,
    "Rank": 600,
    "Tooltip": "maxime",
    "Type": "AnonymousAssociate",
    "GroupIdx": 112,
    "FullName": "Bradford Kshlerin",
    "FormalName": "Reinger, Monahan and Goodwin",
    "Deleted": false,
    "EjUserId": 565,
    "UserName": "Grady-Murazik",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 913
      }
    }
  },
  "CreatedDate": "2010-08-18T14:58:03.0155382+02:00",
  "AppointmentId": 801,
  "Description": "User-centric multi-state emulation",
  "StartDate": "2020-04-12T14:58:03.0155382+02:00",
  "EndDate": "1998-08-14T14:58:03.0155382+02:00",
  "InvitedPerson": {
    "Position": "aut",
    "PersonId": 518,
    "Mrmrs": "illo",
    "Firstname": "Sean",
    "Lastname": "Hyatt",
    "MiddleName": "Hahn-Hane",
    "Title": "doloribus",
    "Description": "Vision-oriented modular matrices",
    "Email": "brent@jewessrussel.com",
    "FullName": "Emerson Streich",
    "DirectPhone": "571.272.7624",
    "FormalName": "Ebert-Tremblay",
    "CountryId": 224,
    "ContactId": 920,
    "ContactName": "Rosenbaum Group",
    "Retired": 305,
    "Rank": 426,
    "ActiveInterests": 378,
    "ContactDepartment": "",
    "ContactCountryId": 280,
    "ContactOrgNr": "1285966",
    "FaxPhone": "172-557-5440 x13402",
    "MobilePhone": "(618)122-4543",
    "ContactPhone": "374-537-8183",
    "AssociateName": "Terry-Strosin",
    "AssociateId": 561,
    "UsePersonAddress": true,
    "ContactFax": "aut",
    "Kanafname": "ea",
    "Kanalname": "ad",
    "Post1": "odit",
    "Post2": "voluptatem",
    "Post3": "aliquid",
    "EmailName": "rusty.osinski@fritsch.com",
    "ContactFullName": "Vicky Kozey",
    "ActiveErpLinks": 826,
    "TicketPriorityId": 523,
    "SupportLanguageId": 522,
    "SupportAssociateId": 880,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 252
      }
    }
  },
  "Person": {
    "Position": "natus",
    "PersonId": 879,
    "Mrmrs": "et",
    "Firstname": "Luisa",
    "Lastname": "Batz",
    "MiddleName": "Rippin, Hayes and Predovic",
    "Title": "voluptate",
    "Description": "Multi-tiered homogeneous Graphical User Interface",
    "Email": "kristina@king.us",
    "FullName": "Oran Jakubowski",
    "DirectPhone": "1-783-622-8776",
    "FormalName": "Roob Inc and Sons",
    "CountryId": 155,
    "ContactId": 333,
    "ContactName": "Stroman Inc and Sons",
    "Retired": 770,
    "Rank": 70,
    "ActiveInterests": 340,
    "ContactDepartment": "",
    "ContactCountryId": 102,
    "ContactOrgNr": "1373535",
    "FaxPhone": "(558)126-1418",
    "MobilePhone": "1-538-456-6876",
    "ContactPhone": "(204)503-7777",
    "AssociateName": "Eichmann, O'Conner and Goodwin",
    "AssociateId": 879,
    "UsePersonAddress": false,
    "ContactFax": "non",
    "Kanafname": "occaecati",
    "Kanalname": "ut",
    "Post1": "quaerat",
    "Post2": "voluptas",
    "Post3": "eligendi",
    "EmailName": "garnet@windlerhammes.us",
    "ContactFullName": "Thalia Rempel",
    "ActiveErpLinks": 652,
    "TicketPriorityId": 770,
    "SupportLanguageId": 873,
    "SupportAssociateId": 709,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "synthesize open-source eyeballs"
        },
        "FieldType": "System.Int32",
        "FieldLength": 231
      }
    }
  },
  "MotherId": 769,
  "Priority": {
    "Id": 109,
    "Value": "praesentium",
    "Tooltip": "eius",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 225
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 168,
    "Name": "Breitenberg, Kuhlman and Koch",
    "Description": "Down-sized zero defect success",
    "URL": "http://www.example.com/",
    "Type": "earum",
    "AssociateId": 958,
    "AssociateFullName": "Perry Rosenbaum",
    "TypeId": 678,
    "Updated": "1999-05-25T14:58:03.0175382+02:00",
    "StatusId": 686,
    "Status": "ipsum",
    "TextId": 593,
    "PublishTo": "2010-08-07T14:58:03.0175382+02:00",
    "PublishFrom": "2006-02-15T14:58:03.0175382+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1170803",
    "ActiveErpLinks": 95,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 19
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2005-10-13T14:58:03.0175382+02:00",
  "Completed": "Completed",
  "ActiveLinks": 665,
  "Links": [
    {
      "EntityName": "Boyle-Mills",
      "Id": 824,
      "Description": "Public-key eco-centric open architecture",
      "ExtraInfo": "earum",
      "LinkId": 292,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 705
        }
      }
    }
  ],
  "AlarmLeadTime": "voluptate",
  "HasAlarm": false,
  "ColorIndex": 751,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "mollitia",
  "LeadTime": "dolor",
  "Location": "consequatur",
  "RejectCounter": 78,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 795,
    "StartDate": "2013-01-04T14:58:03.0185383+01:00",
    "EndDate": "2006-08-08T14:58:03.0185383+02:00",
    "RecurrenceCounter": 378,
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
      "AssociateId": 580,
      "PersonId": 214,
      "ContactId": 864,
      "EmailId": 510,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 580,
      "PersonId": 214,
      "ContactId": 864,
      "EmailId": 510,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2018-07-05T14:58:03.0185383+02:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 610,
    "Name": "Bogan-Pouros",
    "PersonId": 403,
    "Rank": 642,
    "Tooltip": "officiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 6,
    "FullName": "Helga Marvin",
    "FormalName": "Flatley LLC",
    "Deleted": false,
    "EjUserId": 626,
    "UserName": "Kemmer, Ullrich and Herman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 755
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 242,
    "Name": "Reilly LLC",
    "PersonId": 973,
    "Rank": 398,
    "Tooltip": "aliquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 645,
    "FullName": "Bailey Volkman DVM",
    "FormalName": "Kozey, Bechtelar and Cremin",
    "Deleted": false,
    "EjUserId": 792,
    "UserName": "Dickens LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 305
      }
    }
  },
  "Task": {
    "TaskListItemId": 682,
    "Value": "aliquam",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "est",
    "Deleted": true,
    "IntentId": 91,
    "Rank": 150,
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
        "FieldType": "System.Int32",
        "FieldLength": 420
      }
    }
  },
  "PreferredTZLocation": 712,
  "Sale": {
    "ContactName": "Konopelski, Kautzer and Gutkowski",
    "SaleDate": "2010-11-10T14:58:03.0185383+01:00",
    "SaleId": 103,
    "Probability": 406,
    "Title": "ab",
    "Amount": 22423.77,
    "Currency": "sint",
    "ProjectName": "Bosco, Homenick and D'Amore",
    "AssociateFullName": "Nikolas Considine",
    "Description": "Phased demand-driven instruction set",
    "Status": "Lost",
    "WeightedAmount": 10276.386,
    "ProjectId": 463,
    "EarningPercent": 3757.6659999999997,
    "Earning": 20606.05,
    "ContactId": 434,
    "AssociateId": 969,
    "PersonId": 630,
    "SaleTypeId": 5,
    "SaleTypeName": "Crist-Greenfelder",
    "PersonFullName": "Coty O'Keefe",
    "Completed": "Completed",
    "ActiveErpLinks": 492,
    "NextDueDate": "1995-04-21T14:58:03.0195383+02:00",
    "Number": "275127",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 673
      }
    }
  },
  "SuggestedAppointmentId": 64,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "illo",
  "UserDefinedFields": {
    "SuperOffice:1": "Imani Hamill",
    "SuperOffice:2": "217700234"
  },
  "ExtraFields": {
    "ExtraFields1": "ad",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "accusamus"
  },
  "PublishEventDate": "2000-10-06T14:58:03.0195383+02:00",
  "PublishTo": "2003-02-06T14:58:03.0195383+01:00",
  "PublishFrom": "2004-09-26T14:58:03.0195383+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 518,
      "Visibility": "All",
      "DisplayValue": "sit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "orchestrate dot-com niches"
          },
          "FieldType": "System.String",
          "FieldLength": 59
        }
      }
    },
    {
      "VisibleId": 518,
      "Visibility": "All",
      "DisplayValue": "sit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "orchestrate dot-com niches"
          },
          "FieldType": "System.String",
          "FieldLength": 59
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
      "FieldLength": 307
    }
  }
}
```