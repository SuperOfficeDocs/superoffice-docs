---
title: POST Agents/Appointment/CreateAppointmentForUID
id: v1AppointmentAgent_CreateAppointmentForUID
---

# POST Agents/Appointment/CreateAppointmentForUID

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AppointmentEntity": {
    "Associate": {},
    "Contact": {},
    "CreatedBy": {},
    "UpdatedBy": {},
    "CreatedDate": "2018-07-27T18:28:47.8478518+02:00",
    "AppointmentId": 797,
    "Description": "Polarised system-worthy secured line",
    "StartDate": "2007-11-28T18:28:47.8478518+01:00",
    "EndDate": "2016-01-01T18:28:47.8478518+01:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 24,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "2009-06-02T18:28:47.8478518+02:00",
    "Completed": "Completed",
    "ActiveLinks": 125,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "et",
    "HasAlarm": false,
    "ColorIndex": 387,
    "IsFree": true,
    "IsAlldayEvent": true,
    "LagTime": "aut",
    "LeadTime": "omnis",
    "Location": "voluptate",
    "RejectCounter": 241,
    "RejectReason": "",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "2006-06-07T18:28:47.8478518+02:00",
    "HasConflict": true,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 640,
    "Sale": {},
    "SuggestedAppointmentId": 9,
    "IsMileStone": true,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "in",
    "UserDefinedFields": {
      "SuperOffice:1": "1192673346",
      "SuperOffice:2": "1005601320"
    },
    "ExtraFields": {
      "ExtraFields1": "a",
      "ExtraFields2": "in"
    },
    "CustomFields": {
      "CustomFields1": "odio",
      "CustomFields2": "placeat"
    },
    "PublishEventDate": "2004-02-07T18:28:47.8478518+01:00",
    "PublishTo": "2015-05-16T18:28:47.8478518+02:00",
    "PublishFrom": "2001-05-16T18:28:47.8478518+02:00",
    "IsPublished": true,
    "VisibleFor": [
      {},
      {}
    ]
  },
  "UID": "architecto"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 156,
    "Name": "Bailey-Langosh",
    "PersonId": 595,
    "Rank": 55,
    "Tooltip": "alias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 720,
    "FullName": "Abbie Gorczany",
    "FormalName": "Thompson-Brakus",
    "Deleted": true,
    "EjUserId": 846,
    "UserName": "Waters, Gerlach and Williamson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 403
      }
    }
  },
  "Contact": {
    "ContactId": 554,
    "Name": "Kutch Group",
    "OrgNr": "1317807",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "unde",
    "DirectPhone": "(254)278-4587",
    "AssociateId": 52,
    "CountryId": 391,
    "EmailAddress": "telly.bahringer@framiharris.com",
    "Kananame": "quisquam",
    "EmailAddressName": "claudie@huelkuphal.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Hans Okuneva",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "repudiandae",
    "FullName": "Robbie Langosh",
    "IsOwnerContact": true,
    "ActiveErpLinks": 482,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 437
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 324,
    "Name": "Heller Inc and Sons",
    "PersonId": 376,
    "Rank": 588,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 98,
    "FullName": "Felicita Pfannerstill",
    "FormalName": "Connelly-Goodwin",
    "Deleted": false,
    "EjUserId": 455,
    "UserName": "Zemlak-Haag",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 477
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 215,
    "Name": "Tillman LLC",
    "PersonId": 159,
    "Rank": 164,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 400,
    "FullName": "Romaine Hauck",
    "FormalName": "Volkman Inc and Sons",
    "Deleted": false,
    "EjUserId": 160,
    "UserName": "Brekke-Maggio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 103
      }
    }
  },
  "CreatedDate": "2003-12-25T18:28:47.8578497+01:00",
  "AppointmentId": 632,
  "Description": "Stand-alone grid-enabled benchmark",
  "StartDate": "2001-03-29T18:28:47.8578497+02:00",
  "EndDate": "2020-10-20T18:28:47.8578497+02:00",
  "InvitedPerson": {
    "Position": "nobis",
    "PersonId": 163,
    "Mrmrs": "qui",
    "Firstname": "Nikolas",
    "Lastname": "Boyer",
    "MiddleName": "Hirthe, McDermott and Leannon",
    "Title": "et",
    "Description": "Mandatory human-resource help-desk",
    "Email": "therese.jast@jenkinsveum.us",
    "FullName": "Johan Lindgren",
    "DirectPhone": "1-412-052-0573 x410",
    "FormalName": "Reynolds-Wolff",
    "CountryId": 389,
    "ContactId": 141,
    "ContactName": "O'Reilly-Cummings",
    "Retired": 198,
    "Rank": 269,
    "ActiveInterests": 515,
    "ContactDepartment": "",
    "ContactCountryId": 346,
    "ContactOrgNr": "849556",
    "FaxPhone": "760.153.1244 x5375",
    "MobilePhone": "1-323-868-8507",
    "ContactPhone": "1-387-227-5706",
    "AssociateName": "Von-Konopelski",
    "AssociateId": 228,
    "UsePersonAddress": false,
    "ContactFax": "eveniet",
    "Kanafname": "accusamus",
    "Kanalname": "suscipit",
    "Post1": "consequuntur",
    "Post2": "nihil",
    "Post3": "blanditiis",
    "EmailName": "roger_bechtelar@harvey.co.uk",
    "ContactFullName": "Imani Cummerata I",
    "ActiveErpLinks": 839,
    "TicketPriorityId": 826,
    "SupportLanguageId": 957,
    "SupportAssociateId": 577,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 881
      }
    }
  },
  "Person": {
    "Position": "odit",
    "PersonId": 216,
    "Mrmrs": "voluptatem",
    "Firstname": "Breanne",
    "Lastname": "Nader",
    "MiddleName": "Ratke Group",
    "Title": "ut",
    "Description": "Front-line encompassing standardization",
    "Email": "andreane@heaneymcclure.com",
    "FullName": "Frida Gorczany DDS",
    "DirectPhone": "033-060-0165 x580",
    "FormalName": "Prosacco, Gaylord and Herman",
    "CountryId": 380,
    "ContactId": 709,
    "ContactName": "Turcotte LLC",
    "Retired": 962,
    "Rank": 918,
    "ActiveInterests": 518,
    "ContactDepartment": "",
    "ContactCountryId": 680,
    "ContactOrgNr": "1458830",
    "FaxPhone": "682.501.5616 x715",
    "MobilePhone": "315-378-7854",
    "ContactPhone": "1-444-483-2418 x653",
    "AssociateName": "Kuhlman, Nader and Pfannerstill",
    "AssociateId": 241,
    "UsePersonAddress": true,
    "ContactFax": "porro",
    "Kanafname": "est",
    "Kanalname": "eum",
    "Post1": "minima",
    "Post2": "porro",
    "Post3": "placeat",
    "EmailName": "reggie@lynch.com",
    "ContactFullName": "Dashawn Gulgowski V",
    "ActiveErpLinks": 737,
    "TicketPriorityId": 518,
    "SupportLanguageId": 348,
    "SupportAssociateId": 727,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 388
      }
    }
  },
  "MotherId": 320,
  "Priority": {
    "Id": 120,
    "Value": "ut",
    "Tooltip": "vel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 149
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 103,
    "Name": "Reynolds-Hansen",
    "Description": "Customizable eco-centric protocol",
    "URL": "http://www.example.com/",
    "Type": "veniam",
    "AssociateId": 740,
    "AssociateFullName": "Kassandra Abernathy",
    "TypeId": 734,
    "Updated": "1999-01-06T18:28:47.8608264+01:00",
    "StatusId": 982,
    "Status": "vel",
    "TextId": 778,
    "PublishTo": "1997-09-13T18:28:47.8608264+02:00",
    "PublishFrom": "1995-02-09T18:28:47.8608264+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "923225",
    "ActiveErpLinks": 670,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 246
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2021-06-21T18:28:47.8608264+02:00",
  "Completed": "Completed",
  "ActiveLinks": 993,
  "Links": [
    {
      "EntityName": "Donnelly-Feeney",
      "Id": 5,
      "Description": "Digitized cohesive Graphic Interface",
      "ExtraInfo": "et",
      "LinkId": 274,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 750
        }
      }
    }
  ],
  "AlarmLeadTime": "non",
  "HasAlarm": false,
  "ColorIndex": 324,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "voluptas",
  "LeadTime": "dolorem",
  "Location": "distinctio",
  "RejectCounter": 149,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 44,
    "StartDate": "2018-02-20T18:28:47.8608264+01:00",
    "EndDate": "2011-02-07T18:28:47.8608264+01:00",
    "RecurrenceCounter": 725,
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
      "AssociateId": 538,
      "PersonId": 605,
      "ContactId": 979,
      "EmailId": 162,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 538,
      "PersonId": 605,
      "ContactId": 979,
      "EmailId": 162,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1997-11-15T18:28:47.8608264+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 99,
    "Name": "Aufderhar LLC",
    "PersonId": 413,
    "Rank": 568,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 733,
    "FullName": "Gustave Ortiz",
    "FormalName": "Bednar-Upton",
    "Deleted": false,
    "EjUserId": 665,
    "UserName": "Walsh, Marquardt and Armstrong",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 857
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 164,
    "Name": "Schowalter Inc and Sons",
    "PersonId": 587,
    "Rank": 933,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 901,
    "FullName": "Jasper Reilly",
    "FormalName": "Bergstrom, Gaylord and Shields",
    "Deleted": false,
    "EjUserId": 722,
    "UserName": "Hackett LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 517
      }
    }
  },
  "Task": {
    "TaskListItemId": 572,
    "Value": "voluptatibus",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "a",
    "Deleted": false,
    "IntentId": 406,
    "Rank": 475,
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
        "FieldLength": 433
      }
    }
  },
  "PreferredTZLocation": 162,
  "Sale": {
    "ContactName": "Bechtelar, Stiedemann and Halvorson",
    "SaleDate": "2016-10-05T18:28:47.861817+02:00",
    "SaleId": 465,
    "Probability": 552,
    "Title": "unde",
    "Amount": 16622.736,
    "Currency": "nisi",
    "ProjectName": "Bernier-Hessel",
    "AssociateFullName": "Porter Kreiger",
    "Description": "Total object-oriented interface",
    "Status": "Lost",
    "WeightedAmount": 13263.088,
    "ProjectId": 594,
    "EarningPercent": 1485.5159999999999,
    "Earning": 5014.4,
    "ContactId": 632,
    "AssociateId": 838,
    "PersonId": 740,
    "SaleTypeId": 422,
    "SaleTypeName": "Willms, Barton and Jacobson",
    "PersonFullName": "Josiane Botsford",
    "Completed": "Completed",
    "ActiveErpLinks": 896,
    "NextDueDate": "2007-01-06T18:28:47.8628159+01:00",
    "Number": "744534",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 866
      }
    }
  },
  "SuggestedAppointmentId": 173,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "dicta",
  "UserDefinedFields": {
    "SuperOffice:1": "567109348",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "accusantium"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "consequuntur"
  },
  "PublishEventDate": "1998-04-09T18:28:47.8628159+02:00",
  "PublishTo": "2019-01-22T18:28:47.8628159+01:00",
  "PublishFrom": "2013-06-08T18:28:47.8628159+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 494,
      "Visibility": "All",
      "DisplayValue": "dolores",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 975
        }
      }
    },
    {
      "VisibleId": 494,
      "Visibility": "All",
      "DisplayValue": "dolores",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 975
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
      "FieldType": "System.String",
      "FieldLength": 557
    }
  }
}
```