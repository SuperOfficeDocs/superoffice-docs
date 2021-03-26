---
title: POST Agents/Appointment/AcceptRejected
id: v1AppointmentAgent_AcceptRejected
---

# POST Agents/Appointment/AcceptRejected

```http
POST /api/v1/Agents/Appointment/AcceptRejected
```

Accept that an invited participant has rejected your invitation or assignment.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/AcceptRejected?$select=name,department,category/id
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

AppointmentId, UpdateMode 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentId | int32 |  |
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
POST /api/v1/Agents/Appointment/AcceptRejected
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 925,
  "UpdateMode": "OnlyThis"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 943,
    "Name": "Jacobs-Cole",
    "PersonId": 138,
    "Rank": 215,
    "Tooltip": "reiciendis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 119,
    "FullName": "Demetrius Douglas",
    "FormalName": "D'Amore, Schmidt and Swift",
    "Deleted": true,
    "EjUserId": 85,
    "UserName": "Legros, VonRueden and Wisozk",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "recontextualize intuitive relationships"
        },
        "FieldType": "System.Int32",
        "FieldLength": 311
      }
    }
  },
  "Contact": {
    "ContactId": 125,
    "Name": "Predovic, Wiegand and Jenkins",
    "OrgNr": "1127945",
    "Department": "unleash strategic channels",
    "URL": "http://www.example.com/",
    "City": "consequuntur",
    "DirectPhone": "1-353-677-7380",
    "AssociateId": 282,
    "CountryId": 24,
    "EmailAddress": "chadd@cormier.biz",
    "Kananame": "in",
    "EmailAddressName": "mazie_fritsch@lindgrengusikowski.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Tianna Roob",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "autem",
    "FullName": "Sarah Klocko",
    "IsOwnerContact": false,
    "ActiveErpLinks": 430,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 713
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 716,
    "Name": "Ortiz-Hudson",
    "PersonId": 238,
    "Rank": 327,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 563,
    "FullName": "Katelin Connelly",
    "FormalName": "Boyer-Cummerata",
    "Deleted": true,
    "EjUserId": 332,
    "UserName": "Corwin-Terry",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 230
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 558,
    "Name": "Macejkovic LLC",
    "PersonId": 636,
    "Rank": 986,
    "Tooltip": "magni",
    "Type": "AnonymousAssociate",
    "GroupIdx": 991,
    "FullName": "Kris Bechtelar",
    "FormalName": "Wolf LLC",
    "Deleted": false,
    "EjUserId": 832,
    "UserName": "Conn Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 407
      }
    }
  },
  "CreatedDate": "2017-03-10T16:48:28.6674569+01:00",
  "AppointmentId": 323,
  "Description": "Advanced discrete service-desk",
  "StartDate": "2003-06-08T16:48:28.6674569+02:00",
  "EndDate": "2010-08-29T16:48:28.6674569+02:00",
  "InvitedPerson": {
    "Position": "neque",
    "PersonId": 682,
    "Mrmrs": "culpa",
    "Firstname": "Allan",
    "Lastname": "Koch",
    "MiddleName": "O'Keefe-Johns",
    "Title": "nam",
    "Description": "Diverse maximized contingency",
    "Email": "joe@williamsonfeest.co.uk",
    "FullName": "Willy Stokes Jr.",
    "DirectPhone": "145.174.3418",
    "FormalName": "Wilderman-Yundt",
    "CountryId": 879,
    "ContactId": 371,
    "ContactName": "Kshlerin-Shields",
    "Retired": 839,
    "Rank": 552,
    "ActiveInterests": 161,
    "ContactDepartment": "",
    "ContactCountryId": 920,
    "ContactOrgNr": "808990",
    "FaxPhone": "1-732-117-8378 x8453",
    "MobilePhone": "1-633-345-0746",
    "ContactPhone": "040.353.5158",
    "AssociateName": "Wyman Group",
    "AssociateId": 808,
    "UsePersonAddress": true,
    "ContactFax": "consequatur",
    "Kanafname": "nihil",
    "Kanalname": "et",
    "Post1": "modi",
    "Post2": "odio",
    "Post3": "eveniet",
    "EmailName": "blair_lowe@little.uk",
    "ContactFullName": "Jovany Jakubowski",
    "ActiveErpLinks": 550,
    "TicketPriorityId": 816,
    "SupportLanguageId": 463,
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
        "FieldLength": 632
      }
    }
  },
  "Person": {
    "Position": "sed",
    "PersonId": 991,
    "Mrmrs": "totam",
    "Firstname": "Niko",
    "Lastname": "Orn",
    "MiddleName": "Mertz, Hahn and Mayer",
    "Title": "doloribus",
    "Description": "Multi-lateral next generation ability",
    "Email": "gail.kerluke@altenwerth.uk",
    "FullName": "Carli Dicki",
    "DirectPhone": "578.082.3160 x0711",
    "FormalName": "Russel LLC",
    "CountryId": 417,
    "ContactId": 84,
    "ContactName": "Klocko Inc and Sons",
    "Retired": 32,
    "Rank": 141,
    "ActiveInterests": 961,
    "ContactDepartment": "",
    "ContactCountryId": 584,
    "ContactOrgNr": "1647379",
    "FaxPhone": "454.104.5701 x270",
    "MobilePhone": "(255)744-7500",
    "ContactPhone": "1-477-006-4315",
    "AssociateName": "Jacobs-Wunsch",
    "AssociateId": 191,
    "UsePersonAddress": false,
    "ContactFax": "placeat",
    "Kanafname": "molestiae",
    "Kanalname": "qui",
    "Post1": "id",
    "Post2": "ea",
    "Post3": "est",
    "EmailName": "dedrick@ullrich.info",
    "ContactFullName": "Maymie Schaefer",
    "ActiveErpLinks": 782,
    "TicketPriorityId": 41,
    "SupportLanguageId": 436,
    "SupportAssociateId": 782,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 792
      }
    }
  },
  "MotherId": 157,
  "Priority": {
    "Id": 595,
    "Value": "rerum",
    "Tooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "incentivize out-of-the-box supply-chains"
        },
        "FieldType": "System.Int32",
        "FieldLength": 960
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 635,
    "Name": "Cassin, Crist and Johns",
    "Description": "Quality-focused web-enabled ability",
    "URL": "http://www.example.com/",
    "Type": "eligendi",
    "AssociateId": 891,
    "AssociateFullName": "Vivian Hartmann",
    "TypeId": 492,
    "Updated": "2020-02-09T16:48:28.6714586+01:00",
    "StatusId": 110,
    "Status": "quae",
    "TextId": 76,
    "PublishTo": "2014-06-25T16:48:28.6714586+02:00",
    "PublishFrom": "1999-12-25T16:48:28.6714586+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1349629",
    "ActiveErpLinks": 594,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 66
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2003-05-29T16:48:28.6714586+02:00",
  "Completed": "Completed",
  "ActiveLinks": 100,
  "Links": [
    {
      "EntityName": "Kshlerin-O'Keefe",
      "Id": 322,
      "Description": "Networked zero tolerance software",
      "ExtraInfo": "esse",
      "LinkId": 926,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 869
        }
      }
    }
  ],
  "AlarmLeadTime": "eius",
  "HasAlarm": false,
  "ColorIndex": 392,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "vero",
  "LeadTime": "est",
  "Location": "dolorem",
  "RejectCounter": 991,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 876,
    "StartDate": "2018-03-02T16:48:28.6714586+01:00",
    "EndDate": "2002-02-27T16:48:28.6714586+01:00",
    "RecurrenceCounter": 240,
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
      "AssociateId": 8,
      "PersonId": 387,
      "ContactId": 789,
      "EmailId": 614,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 8,
      "PersonId": 387,
      "ContactId": 789,
      "EmailId": 614,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2010-10-18T16:48:28.6714586+02:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 438,
    "Name": "Reichel, Veum and Keebler",
    "PersonId": 609,
    "Rank": 649,
    "Tooltip": "nam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 689,
    "FullName": "Arlene Orn",
    "FormalName": "Gibson Inc and Sons",
    "Deleted": true,
    "EjUserId": 230,
    "UserName": "Johnston, Grant and Wehner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 779
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 954,
    "Name": "Harvey-Kunze",
    "PersonId": 568,
    "Rank": 309,
    "Tooltip": "iure",
    "Type": "AnonymousAssociate",
    "GroupIdx": 855,
    "FullName": "Marietta Borer",
    "FormalName": "McLaughlin-DuBuque",
    "Deleted": true,
    "EjUserId": 320,
    "UserName": "Quigley-West",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 56
      }
    }
  },
  "Task": {
    "TaskListItemId": 3,
    "Value": "non",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "beatae",
    "Deleted": false,
    "IntentId": 832,
    "Rank": 696,
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
        "FieldLength": 410
      }
    }
  },
  "PreferredTZLocation": 314,
  "Sale": {
    "ContactName": "Connelly-Fahey",
    "SaleDate": "1998-06-28T16:48:28.6724523+02:00",
    "SaleId": 84,
    "Probability": 560,
    "Title": "esse",
    "Amount": 4271.642,
    "Currency": "et",
    "ProjectName": "Langosh, Kiehn and Maggio",
    "AssociateFullName": "Noe Ferry",
    "Description": "Exclusive regional structure",
    "Status": "Lost",
    "WeightedAmount": 8095.1219999999994,
    "ProjectId": 897,
    "EarningPercent": 9129.342,
    "Earning": 27538.458,
    "ContactId": 333,
    "AssociateId": 199,
    "PersonId": 760,
    "SaleTypeId": 919,
    "SaleTypeName": "Dicki, Mann and Lang",
    "PersonFullName": "Saige Hauck",
    "Completed": "Completed",
    "ActiveErpLinks": 68,
    "NextDueDate": "2011-11-28T16:48:28.6734542+01:00",
    "Number": "1395695",
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
  "SuggestedAppointmentId": 814,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "doloremque",
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "1146886946"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "dolores",
    "CustomFields2": "eius"
  },
  "PublishEventDate": "2016-09-20T16:48:28.6734542+02:00",
  "PublishTo": "2001-08-26T16:48:28.6734542+02:00",
  "PublishFrom": "2018-06-01T16:48:28.6734542+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 18,
      "Visibility": "All",
      "DisplayValue": "veritatis",
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
    {
      "VisibleId": 18,
      "Visibility": "All",
      "DisplayValue": "veritatis",
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
      "FieldLength": 728
    }
  }
}
```