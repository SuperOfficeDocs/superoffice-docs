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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AppointmentEntity": {
    "Associate": {},
    "Contact": {},
    "CreatedBy": {},
    "UpdatedBy": {},
    "CreatedDate": "1996-11-12T18:28:47.9788445+01:00",
    "AppointmentId": 614,
    "Description": "Extended systemic superstructure",
    "StartDate": "2001-10-02T18:28:47.9788445+02:00",
    "EndDate": "2018-12-18T18:28:47.9788445+01:00",
    "InvitedPerson": {},
    "Person": {},
    "MotherId": 363,
    "Priority": {},
    "Private": "PrivateGroup",
    "Project": {},
    "Type": "BookingForChecklist",
    "UpdatedDate": "2020-12-21T18:28:47.9788445+01:00",
    "Completed": "Completed",
    "ActiveLinks": 916,
    "Links": [
      {},
      {}
    ],
    "AlarmLeadTime": "modi",
    "HasAlarm": false,
    "ColorIndex": 824,
    "IsFree": true,
    "IsAlldayEvent": false,
    "LagTime": "consequatur",
    "LeadTime": "sint",
    "Location": "ut",
    "RejectCounter": 848,
    "RejectReason": "iterate 24/7 technologies",
    "Recurrence": {},
    "Participants": [
      {},
      {}
    ],
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "ActiveDate": "2012-02-03T18:28:47.9798526+01:00",
    "HasConflict": false,
    "AssignedBy": {},
    "MotherAssociate": {},
    "Task": {},
    "PreferredTZLocation": 989,
    "Sale": {},
    "SuggestedAppointmentId": 857,
    "IsMileStone": true,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "CentralserviceVideomeetId": "blanditiis",
    "UserDefinedFields": {
      "SuperOffice:1": "586654860",
      "SuperOffice:2": "Wilmer Kertzmann"
    },
    "ExtraFields": {
      "ExtraFields1": "et",
      "ExtraFields2": "sit"
    },
    "CustomFields": {
      "CustomFields1": "et",
      "CustomFields2": "aperiam"
    },
    "PublishEventDate": "2019-03-30T18:28:47.9798526+01:00",
    "PublishTo": "2012-08-14T18:28:47.9798526+02:00",
    "PublishFrom": "2012-11-22T18:28:47.9798526+01:00",
    "IsPublished": true,
    "VisibleFor": [
      {},
      {}
    ]
  },
  "UpdateMode": "OnlyThis",
  "SendEmailToParticipants": true,
  "SmtpEMailConnectionInfo": {
    "ServerName": "Shields Inc and Sons",
    "UserName": "McGlynn, Lueilwitz and Carter",
    "Password": "quasi",
    "Folder": "voluptatibus",
    "UseSSL": false
  },
  "ImapEMailConnectionInfo": {
    "ServerName": "Howell, Mohr and Hermiston",
    "UserName": "Bednar Group",
    "Password": "enim",
    "Folder": "est",
    "UseSSL": true
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 326,
    "Name": "Dietrich-Pollich",
    "PersonId": 836,
    "Rank": 658,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 319,
    "FullName": "Citlalli Mosciski",
    "FormalName": "Stamm, Thompson and Schimmel",
    "Deleted": false,
    "EjUserId": 302,
    "UserName": "Satterfield, Casper and Larson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 224
      }
    }
  },
  "Contact": {
    "ContactId": 972,
    "Name": "Streich Inc and Sons",
    "OrgNr": "1403917",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "accusamus",
    "DirectPhone": "1-630-658-6037 x071",
    "AssociateId": 704,
    "CountryId": 308,
    "EmailAddress": "judah@douglas.com",
    "Kananame": "numquam",
    "EmailAddressName": "rickie@pollichgerhold.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Finn Champlin",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "vel",
    "FullName": "Berenice Grant Sr.",
    "IsOwnerContact": true,
    "ActiveErpLinks": 191,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 772
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 204,
    "Name": "Sporer Inc and Sons",
    "PersonId": 753,
    "Rank": 778,
    "Tooltip": "magni",
    "Type": "AnonymousAssociate",
    "GroupIdx": 746,
    "FullName": "Tamara Fahey",
    "FormalName": "Vandervort-Zboncak",
    "Deleted": true,
    "EjUserId": 513,
    "UserName": "Sawayn LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 576
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 200,
    "Name": "Hirthe, VonRueden and Anderson",
    "PersonId": 377,
    "Rank": 83,
    "Tooltip": "dignissimos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 649,
    "FullName": "Jules Labadie",
    "FormalName": "Legros, Fadel and Reynolds",
    "Deleted": true,
    "EjUserId": 8,
    "UserName": "Thompson Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 240
      }
    }
  },
  "CreatedDate": "1999-12-07T18:28:48.0508164+01:00",
  "AppointmentId": 771,
  "Description": "Extended dynamic function",
  "StartDate": "2021-06-11T18:28:48.0508164+02:00",
  "EndDate": "2005-10-03T18:28:48.0508164+02:00",
  "InvitedPerson": {
    "Position": "accusantium",
    "PersonId": 692,
    "Mrmrs": "eum",
    "Firstname": "Freeda",
    "Lastname": "Greenfelder",
    "MiddleName": "Sawayn, Heidenreich and Gibson",
    "Title": "porro",
    "Description": "Adaptive content-based database",
    "Email": "carmen@schusterhermiston.us",
    "FullName": "Mr. Maud Bergnaum",
    "DirectPhone": "1-231-826-8887",
    "FormalName": "Heidenreich Group",
    "CountryId": 717,
    "ContactId": 510,
    "ContactName": "Herzog Group",
    "Retired": 967,
    "Rank": 232,
    "ActiveInterests": 236,
    "ContactDepartment": "",
    "ContactCountryId": 517,
    "ContactOrgNr": "160011",
    "FaxPhone": "122-844-2202 x53847",
    "MobilePhone": "(232)760-7161",
    "ContactPhone": "1-786-816-4466 x8240",
    "AssociateName": "Prosacco-Feeney",
    "AssociateId": 484,
    "UsePersonAddress": false,
    "ContactFax": "quam",
    "Kanafname": "sit",
    "Kanalname": "aut",
    "Post1": "nisi",
    "Post2": "sunt",
    "Post3": "perferendis",
    "EmailName": "gerard@kub.us",
    "ContactFullName": "Mafalda Larson",
    "ActiveErpLinks": 27,
    "TicketPriorityId": 77,
    "SupportLanguageId": 333,
    "SupportAssociateId": 289,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 73
      }
    }
  },
  "Person": {
    "Position": "et",
    "PersonId": 741,
    "Mrmrs": "sit",
    "Firstname": "Eloy",
    "Lastname": "Homenick",
    "MiddleName": "Kemmer, Schultz and Jakubowski",
    "Title": "autem",
    "Description": "Mandatory eco-centric orchestration",
    "Email": "summer_lindgren@jenkins.co.uk",
    "FullName": "Jalen Huels",
    "DirectPhone": "788.850.6625",
    "FormalName": "Kreiger Inc and Sons",
    "CountryId": 609,
    "ContactId": 856,
    "ContactName": "Beatty-Fay",
    "Retired": 147,
    "Rank": 596,
    "ActiveInterests": 754,
    "ContactDepartment": "",
    "ContactCountryId": 612,
    "ContactOrgNr": "270261",
    "FaxPhone": "686-646-8073",
    "MobilePhone": "373-653-1623 x65380",
    "ContactPhone": "1-752-368-2260",
    "AssociateName": "Bogan-Kris",
    "AssociateId": 568,
    "UsePersonAddress": true,
    "ContactFax": "esse",
    "Kanafname": "quidem",
    "Kanalname": "autem",
    "Post1": "adipisci",
    "Post2": "quos",
    "Post3": "illum",
    "EmailName": "angelita.jaskolski@keeling.uk",
    "ContactFullName": "Amelie Borer",
    "ActiveErpLinks": 465,
    "TicketPriorityId": 542,
    "SupportLanguageId": 94,
    "SupportAssociateId": 53,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 222
      }
    }
  },
  "MotherId": 666,
  "Priority": {
    "Id": 349,
    "Value": "qui",
    "Tooltip": "laboriosam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 428
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 895,
    "Name": "Christiansen LLC",
    "Description": "Distributed demand-driven middleware",
    "URL": "http://www.example.com/",
    "Type": "et",
    "AssociateId": 82,
    "AssociateFullName": "Megane Brakus",
    "TypeId": 367,
    "Updated": "2005-02-28T18:28:48.0528505+01:00",
    "StatusId": 176,
    "Status": "cumque",
    "TextId": 798,
    "PublishTo": "2003-10-22T18:28:48.0528505+02:00",
    "PublishFrom": "2013-04-17T18:28:48.0528505+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "452310",
    "ActiveErpLinks": 450,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 396
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "1997-11-28T18:28:48.0528505+01:00",
  "Completed": "Completed",
  "ActiveLinks": 963,
  "Links": [
    {
      "EntityName": "Crona-Steuber",
      "Id": 336,
      "Description": "Advanced tertiary project",
      "ExtraInfo": "ab",
      "LinkId": 380,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 859
        }
      }
    }
  ],
  "AlarmLeadTime": "voluptatem",
  "HasAlarm": true,
  "ColorIndex": 851,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "est",
  "LeadTime": "recusandae",
  "Location": "vitae",
  "RejectCounter": 98,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 845,
    "StartDate": "2010-02-08T18:28:48.0538503+01:00",
    "EndDate": "1997-05-17T18:28:48.0538503+02:00",
    "RecurrenceCounter": 206,
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
      "AssociateId": 208,
      "PersonId": 757,
      "ContactId": 842,
      "EmailId": 815,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 208,
      "PersonId": 757,
      "ContactId": 842,
      "EmailId": 815,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2017-07-18T18:28:48.0538503+02:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 808,
    "Name": "Langworth Group",
    "PersonId": 230,
    "Rank": 909,
    "Tooltip": "alias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 875,
    "FullName": "Thea Hermiston",
    "FormalName": "Schmeler, Schuster and Bins",
    "Deleted": false,
    "EjUserId": 484,
    "UserName": "Von, Treutel and Herman",
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
  "MotherAssociate": {
    "AssociateId": 21,
    "Name": "Bahringer LLC",
    "PersonId": 350,
    "Rank": 777,
    "Tooltip": "ad",
    "Type": "AnonymousAssociate",
    "GroupIdx": 455,
    "FullName": "Mrs. Xzavier Cremin",
    "FormalName": "Lockman LLC",
    "Deleted": true,
    "EjUserId": 836,
    "UserName": "Tillman-Adams",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 602
      }
    }
  },
  "Task": {
    "TaskListItemId": 225,
    "Value": "voluptates",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "ut",
    "Deleted": false,
    "IntentId": 34,
    "Rank": 855,
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
        "FieldType": "System.Int32",
        "FieldLength": 983
      }
    }
  },
  "PreferredTZLocation": 418,
  "Sale": {
    "ContactName": "Sauer-Muller",
    "SaleDate": "2012-05-15T18:28:48.0548501+02:00",
    "SaleId": 724,
    "Probability": 91,
    "Title": "nulla",
    "Amount": 4798.1539999999995,
    "Currency": "delectus",
    "ProjectName": "Schultz-Rogahn",
    "AssociateFullName": "Ada Hickle",
    "Description": "Versatile impactful methodology",
    "Status": "Lost",
    "WeightedAmount": 3616.636,
    "ProjectId": 122,
    "EarningPercent": 13698.714,
    "Earning": 11780.706,
    "ContactId": 220,
    "AssociateId": 103,
    "PersonId": 691,
    "SaleTypeId": 158,
    "SaleTypeName": "Beier Group",
    "PersonFullName": "Daphnee Braun",
    "Completed": "Completed",
    "ActiveErpLinks": 403,
    "NextDueDate": "2006-07-16T18:28:48.0548501+02:00",
    "Number": "1024488",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 22
      }
    }
  },
  "SuggestedAppointmentId": 888,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "deserunt",
  "UserDefinedFields": {
    "SuperOffice:1": "Ryley Hilpert",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "maiores"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "hic"
  },
  "PublishEventDate": "2017-10-07T18:28:48.0558517+02:00",
  "PublishTo": "2003-10-02T18:28:48.0558517+02:00",
  "PublishFrom": "2005-11-18T18:28:48.0558517+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 113,
      "Visibility": "All",
      "DisplayValue": "autem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 398
        }
      }
    },
    {
      "VisibleId": 113,
      "Visibility": "All",
      "DisplayValue": "autem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 398
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
      "FieldLength": 97
    }
  }
}
```