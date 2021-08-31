---
title: CreateDefaultAppointmentEntityByType
id: v1AppointmentAgent_CreateDefaultAppointmentEntityByType
---

# CreateDefaultAppointmentEntityByType

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityByType
```

Creates a AppointmentEntity populated with the default values for the specific type.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityByType?$select=name,department,category/id
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

Type 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Type | string |  |


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
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityByType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Type": "Appointment"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 306,
    "Name": "Schmitt, Witting and D'Amore",
    "PersonId": 432,
    "Rank": 955,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 412,
    "FullName": "Ms. Jaren Adams",
    "FormalName": "Daniel Inc and Sons",
    "Deleted": true,
    "EjUserId": 549,
    "UserName": "DuBuque-Romaguera",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 905
      }
    }
  },
  "Contact": {
    "ContactId": 765,
    "Name": "Rau LLC",
    "OrgNr": "1513773",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "occaecati",
    "DirectPhone": "1-717-203-7618 x102",
    "AssociateId": 426,
    "CountryId": 102,
    "EmailAddress": "lorenzo_boyle@fay.info",
    "Kananame": "consectetur",
    "EmailAddressName": "garry@metz.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jefferey Lynch",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "sunt",
    "FullName": "Enrico Lehner",
    "IsOwnerContact": false,
    "ActiveErpLinks": 969,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 788
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 685,
    "Name": "Greenfelder LLC",
    "PersonId": 265,
    "Rank": 69,
    "Tooltip": "nobis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 314,
    "FullName": "Ernest Gaylord",
    "FormalName": "Pouros Inc and Sons",
    "Deleted": false,
    "EjUserId": 172,
    "UserName": "Oberbrunner, Jones and McLaughlin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 282
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 312,
    "Name": "Haag-Bashirian",
    "PersonId": 430,
    "Rank": 968,
    "Tooltip": "quod",
    "Type": "AnonymousAssociate",
    "GroupIdx": 277,
    "FullName": "Miss Esther Hauck",
    "FormalName": "Altenwerth, Wiza and Franecki",
    "Deleted": false,
    "EjUserId": 763,
    "UserName": "Green Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 668
      }
    }
  },
  "CreatedDate": "1999-04-10T14:58:03.1785707+02:00",
  "AppointmentId": 364,
  "Description": "Compatible foreground core",
  "StartDate": "2009-02-18T14:58:03.1785707+01:00",
  "EndDate": "1994-09-30T14:58:03.1785707+02:00",
  "InvitedPerson": {
    "Position": "quo",
    "PersonId": 378,
    "Mrmrs": "aut",
    "Firstname": "Itzel",
    "Lastname": "Yundt",
    "MiddleName": "Ledner-Johns",
    "Title": "est",
    "Description": "Streamlined full-range open architecture",
    "Email": "lia@breitenbergfranecki.us",
    "FullName": "Miss Kaycee McLaughlin",
    "DirectPhone": "243.377.3351 x5434",
    "FormalName": "Kulas, Ruecker and Johnson",
    "CountryId": 800,
    "ContactId": 720,
    "ContactName": "Friesen, Cole and White",
    "Retired": 476,
    "Rank": 985,
    "ActiveInterests": 130,
    "ContactDepartment": "",
    "ContactCountryId": 716,
    "ContactOrgNr": "950576",
    "FaxPhone": "701-411-4034 x75710",
    "MobilePhone": "462-167-0033 x8861",
    "ContactPhone": "787-523-2357 x6223",
    "AssociateName": "Cummerata-Heller",
    "AssociateId": 934,
    "UsePersonAddress": false,
    "ContactFax": "earum",
    "Kanafname": "perferendis",
    "Kanalname": "perferendis",
    "Post1": "aspernatur",
    "Post2": "impedit",
    "Post3": "est",
    "EmailName": "destinee@yost.ca",
    "ContactFullName": "Desmond Cruickshank",
    "ActiveErpLinks": 421,
    "TicketPriorityId": 607,
    "SupportLanguageId": 322,
    "SupportAssociateId": 62,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 822
      }
    }
  },
  "Person": {
    "Position": "officia",
    "PersonId": 961,
    "Mrmrs": "reprehenderit",
    "Firstname": "Maurine",
    "Lastname": "Hilll",
    "MiddleName": "Roberts, Mertz and Donnelly",
    "Title": "labore",
    "Description": "Profit-focused homogeneous contingency",
    "Email": "antwon@kautzervonrueden.com",
    "FullName": "Carmine Gislason",
    "DirectPhone": "476.043.4245 x617",
    "FormalName": "Morissette Group",
    "CountryId": 229,
    "ContactId": 919,
    "ContactName": "Adams-Walsh",
    "Retired": 776,
    "Rank": 128,
    "ActiveInterests": 94,
    "ContactDepartment": "",
    "ContactCountryId": 470,
    "ContactOrgNr": "435710",
    "FaxPhone": "1-067-871-4161 x77818",
    "MobilePhone": "1-112-718-8525 x665",
    "ContactPhone": "(012)337-8208",
    "AssociateName": "Luettgen LLC",
    "AssociateId": 795,
    "UsePersonAddress": false,
    "ContactFax": "itaque",
    "Kanafname": "incidunt",
    "Kanalname": "laborum",
    "Post1": "et",
    "Post2": "id",
    "Post3": "eum",
    "EmailName": "marilou@kautzer.ca",
    "ContactFullName": "Blaze O'Connell",
    "ActiveErpLinks": 525,
    "TicketPriorityId": 639,
    "SupportLanguageId": 819,
    "SupportAssociateId": 61,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 335
      }
    }
  },
  "MotherId": 692,
  "Priority": {
    "Id": 606,
    "Value": "consequuntur",
    "Tooltip": "doloremque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 50
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 744,
    "Name": "Stroman LLC",
    "Description": "Extended 24 hour neural-net",
    "URL": "http://www.example.com/",
    "Type": "debitis",
    "AssociateId": 549,
    "AssociateFullName": "Victoria Ankunding",
    "TypeId": 674,
    "Updated": "2018-05-10T14:58:03.1825678+02:00",
    "StatusId": 702,
    "Status": "omnis",
    "TextId": 174,
    "PublishTo": "1996-11-05T14:58:03.1825678+01:00",
    "PublishFrom": "2001-11-19T14:58:03.1825678+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1289364",
    "ActiveErpLinks": 136,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 650
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2014-07-22T14:58:03.1825678+02:00",
  "Completed": "Completed",
  "ActiveLinks": 550,
  "Links": [
    {
      "EntityName": "Hodkiewicz, Jast and O'Keefe",
      "Id": 28,
      "Description": "Operative 6th generation utilisation",
      "ExtraInfo": "veniam",
      "LinkId": 787,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 456
        }
      }
    }
  ],
  "AlarmLeadTime": "sit",
  "HasAlarm": true,
  "ColorIndex": 410,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "facilis",
  "LeadTime": "dolorem",
  "Location": "expedita",
  "RejectCounter": 306,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 917,
    "StartDate": "2010-03-28T14:58:03.1825678+02:00",
    "EndDate": "2013-10-12T14:58:03.1825678+02:00",
    "RecurrenceCounter": 141,
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
      "AssociateId": 712,
      "PersonId": 47,
      "ContactId": 276,
      "EmailId": 224,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 712,
      "PersonId": 47,
      "ContactId": 276,
      "EmailId": 224,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2011-02-19T14:58:03.1825678+01:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 157,
    "Name": "Quigley Inc and Sons",
    "PersonId": 49,
    "Rank": 852,
    "Tooltip": "voluptate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 736,
    "FullName": "Jefferey Lockman",
    "FormalName": "Rohan, Prosacco and Jast",
    "Deleted": false,
    "EjUserId": 499,
    "UserName": "Fay Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 138
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 188,
    "Name": "Ebert LLC",
    "PersonId": 829,
    "Rank": 850,
    "Tooltip": "maiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 59,
    "FullName": "Lavinia Hills",
    "FormalName": "Franecki-Adams",
    "Deleted": true,
    "EjUserId": 562,
    "UserName": "Luettgen, Reilly and Heaney",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 950
      }
    }
  },
  "Task": {
    "TaskListItemId": 306,
    "Value": "quaerat",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "doloremque",
    "Deleted": false,
    "IntentId": 665,
    "Rank": 669,
    "IsDefaultAlldayEvent": true,
    "IsDefaultFree": true,
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
        "FieldLength": 142
      }
    }
  },
  "PreferredTZLocation": 812,
  "Sale": {
    "ContactName": "Beier-Ward",
    "SaleDate": "2015-07-19T14:58:03.1835716+02:00",
    "SaleId": 1001,
    "Probability": 601,
    "Title": "qui",
    "Amount": 12899.544,
    "Currency": "at",
    "ProjectName": "Lind, Thiel and Lindgren",
    "AssociateFullName": "Modesto Murazik",
    "Description": "Virtual stable knowledge base",
    "Status": "Lost",
    "WeightedAmount": 24235.221999999998,
    "ProjectId": 581,
    "EarningPercent": 25379.131999999998,
    "Earning": 28444.183999999997,
    "ContactId": 655,
    "AssociateId": 40,
    "PersonId": 852,
    "SaleTypeId": 163,
    "SaleTypeName": "Pagac, Borer and Dare",
    "PersonFullName": "Dee Gorczany",
    "Completed": "Completed",
    "ActiveErpLinks": 876,
    "NextDueDate": "2008-04-17T14:58:03.1835716+02:00",
    "Number": "996847",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 218
      }
    }
  },
  "SuggestedAppointmentId": 834,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "quo",
  "UserDefinedFields": {
    "SuperOffice:1": "Dee Batz",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "debitis"
  },
  "CustomFields": {
    "CustomFields1": "debitis",
    "CustomFields2": "saepe"
  },
  "PublishEventDate": "2011-09-13T14:58:03.1835716+02:00",
  "PublishTo": "2009-12-04T14:58:03.1835716+01:00",
  "PublishFrom": "2013-06-15T14:58:03.1835716+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 689,
      "Visibility": "All",
      "DisplayValue": "ratione",
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
      "VisibleId": 689,
      "Visibility": "All",
      "DisplayValue": "ratione",
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
      "FieldType": "System.String",
      "FieldLength": 324
    }
  }
}
```