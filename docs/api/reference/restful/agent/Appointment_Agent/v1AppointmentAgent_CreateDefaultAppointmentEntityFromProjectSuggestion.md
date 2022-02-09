---
title: POST Agents/Appointment/CreateDefaultAppointmentEntityFromProjectSuggestion
id: v1AppointmentAgent_CreateDefaultAppointmentEntityFromProjectSuggestion
---

# POST Agents/Appointment/CreateDefaultAppointmentEntityFromProjectSuggestion

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityFromProjectSuggestion
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityFromProjectSuggestion?$select=name,department,category/id
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

SuggestedAppointmentId, ProjectId, CreateNow, OwnerId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SuggestedAppointmentId | int32 |  |
| ProjectId | int32 |  |
| CreateNow | bool |  |
| OwnerId | int32 |  |


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
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityFromProjectSuggestion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 116,
  "ProjectId": 282,
  "CreateNow": true,
  "OwnerId": 20
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 550,
    "Name": "Rau-Reichel",
    "PersonId": 978,
    "Rank": 538,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 517,
    "FullName": "Ebba Becker",
    "FormalName": "Mosciski-Maggio",
    "Deleted": false,
    "EjUserId": 631,
    "UserName": "Baumbach Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 528
      }
    }
  },
  "Contact": {
    "ContactId": 315,
    "Name": "Dare, Osinski and Sawayn",
    "OrgNr": "1256514",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "voluptatem",
    "DirectPhone": "(524)053-3155 x6747",
    "AssociateId": 656,
    "CountryId": 200,
    "EmailAddress": "clint@runolfsdottir.com",
    "Kananame": "perspiciatis",
    "EmailAddressName": "tara@durganhansen.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Drake Willms DVM",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "beatae",
    "FullName": "Ms. Janelle Kassulke",
    "IsOwnerContact": true,
    "ActiveErpLinks": 328,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 639
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 879,
    "Name": "Brekke LLC",
    "PersonId": 41,
    "Rank": 47,
    "Tooltip": "natus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 52,
    "FullName": "Kailey Lubowitz",
    "FormalName": "Swift-Witting",
    "Deleted": true,
    "EjUserId": 606,
    "UserName": "Langworth-Mayer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 478
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 733,
    "Name": "Harvey Group",
    "PersonId": 418,
    "Rank": 319,
    "Tooltip": "nisi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 37,
    "FullName": "Baby Swaniawski",
    "FormalName": "Daugherty Group",
    "Deleted": true,
    "EjUserId": 102,
    "UserName": "Dickens-Kreiger",
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
  "CreatedDate": "2021-08-24T18:28:47.8428451+02:00",
  "AppointmentId": 272,
  "Description": "Distributed national application",
  "StartDate": "2020-09-11T18:28:47.8428451+02:00",
  "EndDate": "2017-12-25T18:28:47.8428451+01:00",
  "InvitedPerson": {
    "Position": "voluptatibus",
    "PersonId": 309,
    "Mrmrs": "neque",
    "Firstname": "Margarett",
    "Lastname": "Kiehn",
    "MiddleName": "Stroman, Dicki and Cummerata",
    "Title": "cupiditate",
    "Description": "Synergized grid-enabled matrix",
    "Email": "myrl@reynolds.name",
    "FullName": "Rebecca Hand",
    "DirectPhone": "530.752.8108 x6456",
    "FormalName": "Torp-Hammes",
    "CountryId": 290,
    "ContactId": 748,
    "ContactName": "Barrows-Hickle",
    "Retired": 565,
    "Rank": 675,
    "ActiveInterests": 922,
    "ContactDepartment": "",
    "ContactCountryId": 885,
    "ContactOrgNr": "1084307",
    "FaxPhone": "(843)300-6047",
    "MobilePhone": "(264)871-4045 x606",
    "ContactPhone": "273.863.6308 x1026",
    "AssociateName": "Dooley-Goyette",
    "AssociateId": 760,
    "UsePersonAddress": false,
    "ContactFax": "quo",
    "Kanafname": "aut",
    "Kanalname": "explicabo",
    "Post1": "iusto",
    "Post2": "nostrum",
    "Post3": "ad",
    "EmailName": "logan@ritchiedickinson.us",
    "ContactFullName": "Raoul Hyatt DDS",
    "ActiveErpLinks": 884,
    "TicketPriorityId": 712,
    "SupportLanguageId": 649,
    "SupportAssociateId": 689,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 458
      }
    }
  },
  "Person": {
    "Position": "voluptas",
    "PersonId": 952,
    "Mrmrs": "soluta",
    "Firstname": "Althea",
    "Lastname": "Parisian",
    "MiddleName": "Mertz, Schulist and Toy",
    "Title": "ducimus",
    "Description": "Customizable methodical migration",
    "Email": "harmony_wisoky@torpcorwin.name",
    "FullName": "Erica Shields",
    "DirectPhone": "(302)866-0122 x85036",
    "FormalName": "Waelchi LLC",
    "CountryId": 324,
    "ContactId": 740,
    "ContactName": "Auer Group",
    "Retired": 370,
    "Rank": 267,
    "ActiveInterests": 776,
    "ContactDepartment": "",
    "ContactCountryId": 402,
    "ContactOrgNr": "180921",
    "FaxPhone": "(317)444-8261 x4244",
    "MobilePhone": "801-701-0073",
    "ContactPhone": "868.658.2553",
    "AssociateName": "Tillman Inc and Sons",
    "AssociateId": 821,
    "UsePersonAddress": false,
    "ContactFax": "et",
    "Kanafname": "et",
    "Kanalname": "ea",
    "Post1": "tempora",
    "Post2": "a",
    "Post3": "nisi",
    "EmailName": "kaden.cassin@christiansen.ca",
    "ContactFullName": "Giovanna Walker",
    "ActiveErpLinks": 539,
    "TicketPriorityId": 537,
    "SupportLanguageId": 984,
    "SupportAssociateId": 940,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 188
      }
    }
  },
  "MotherId": 961,
  "Priority": {
    "Id": 14,
    "Value": "ipsa",
    "Tooltip": "quos",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 43
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 57,
    "Name": "Hills, Miller and Heaney",
    "Description": "Business-focused content-based core",
    "URL": "http://www.example.com/",
    "Type": "facere",
    "AssociateId": 896,
    "AssociateFullName": "Maximilian Pfannerstill",
    "TypeId": 730,
    "Updated": "2020-04-06T18:28:47.8458498+02:00",
    "StatusId": 93,
    "Status": "quam",
    "TextId": 36,
    "PublishTo": "2006-09-13T18:28:47.8458498+02:00",
    "PublishFrom": "2015-09-03T18:28:47.8458498+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "605058",
    "ActiveErpLinks": 926,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 849
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2008-10-10T18:28:47.8458498+02:00",
  "Completed": "Completed",
  "ActiveLinks": 825,
  "Links": [
    {
      "EntityName": "Collier-Cummings",
      "Id": 936,
      "Description": "Profit-focused system-worthy migration",
      "ExtraInfo": "quis",
      "LinkId": 434,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 356
        }
      }
    }
  ],
  "AlarmLeadTime": "et",
  "HasAlarm": true,
  "ColorIndex": 903,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "eum",
  "LeadTime": "aspernatur",
  "Location": "esse",
  "RejectCounter": 575,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 609,
    "StartDate": "2010-06-14T18:28:47.8458498+02:00",
    "EndDate": "2014-11-20T18:28:47.8458498+01:00",
    "RecurrenceCounter": 417,
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
      "AssociateId": 595,
      "PersonId": 894,
      "ContactId": 159,
      "EmailId": 91,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 595,
      "PersonId": 894,
      "ContactId": 159,
      "EmailId": 91,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2016-03-14T18:28:47.8458498+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 571,
    "Name": "Hirthe Inc and Sons",
    "PersonId": 784,
    "Rank": 598,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 510,
    "FullName": "Mr. Malvina Ernser",
    "FormalName": "Homenick Group",
    "Deleted": false,
    "EjUserId": 178,
    "UserName": "Zboncak-Kreiger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 909
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 814,
    "Name": "Miller, Rutherford and Wiza",
    "PersonId": 681,
    "Rank": 891,
    "Tooltip": "pariatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 868,
    "FullName": "Lorine Okuneva",
    "FormalName": "Friesen-West",
    "Deleted": false,
    "EjUserId": 479,
    "UserName": "Kuhlman, Streich and Franecki",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 164
      }
    }
  },
  "Task": {
    "TaskListItemId": 560,
    "Value": "sunt",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "officiis",
    "Deleted": false,
    "IntentId": 198,
    "Rank": 907,
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
        "FieldLength": 418
      }
    }
  },
  "PreferredTZLocation": 321,
  "Sale": {
    "ContactName": "Gulgowski-Robel",
    "SaleDate": "2007-04-03T18:28:47.8468505+02:00",
    "SaleId": 161,
    "Probability": 553,
    "Title": "esse",
    "Amount": 29635.104,
    "Currency": "in",
    "ProjectName": "Bins-Larkin",
    "AssociateFullName": "Ashley Rowe",
    "Description": "Front-line incremental pricing structure",
    "Status": "Lost",
    "WeightedAmount": 27409.964,
    "ProjectId": 157,
    "EarningPercent": 10790.362,
    "Earning": 24708.456,
    "ContactId": 309,
    "AssociateId": 43,
    "PersonId": 645,
    "SaleTypeId": 510,
    "SaleTypeName": "Hoppe-Labadie",
    "PersonFullName": "Kristian Nolan",
    "Completed": "Completed",
    "ActiveErpLinks": 855,
    "NextDueDate": "2006-09-29T18:28:47.8468505+02:00",
    "Number": "1771174",
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
  "SuggestedAppointmentId": 332,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "pariatur",
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "maxime"
  },
  "CustomFields": {
    "CustomFields1": "excepturi",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2009-06-25T18:28:47.8478518+02:00",
  "PublishTo": "2015-06-12T18:28:47.8478518+02:00",
  "PublishFrom": "2020-01-30T18:28:47.8478518+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 492,
      "Visibility": "All",
      "DisplayValue": "ut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 813
        }
      }
    },
    {
      "VisibleId": 492,
      "Visibility": "All",
      "DisplayValue": "ut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 813
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
      "FieldLength": 846
    }
  }
}
```