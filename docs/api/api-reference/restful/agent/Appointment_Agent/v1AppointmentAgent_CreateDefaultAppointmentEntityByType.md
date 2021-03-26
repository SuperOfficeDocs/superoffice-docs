---
title: POST Agents/Appointment/CreateDefaultAppointmentEntityByType
id: v1AppointmentAgent_CreateDefaultAppointmentEntityByType
---

# POST Agents/Appointment/CreateDefaultAppointmentEntityByType

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
Accept-Language: sv
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
    "AssociateId": 245,
    "Name": "Hammes-Treutel",
    "PersonId": 348,
    "Rank": 515,
    "Tooltip": "deserunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 500,
    "FullName": "Elwin Harvey MD",
    "FormalName": "Lubowitz Inc and Sons",
    "Deleted": false,
    "EjUserId": 50,
    "UserName": "Torphy-Sawayn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 455
      }
    }
  },
  "Contact": {
    "ContactId": 470,
    "Name": "Haley, Hand and Blick",
    "OrgNr": "886726",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "recusandae",
    "DirectPhone": "113-422-5645 x13764",
    "AssociateId": 858,
    "CountryId": 645,
    "EmailAddress": "jadon_corkery@trantowbayer.com",
    "Kananame": "praesentium",
    "EmailAddressName": "camron@kozeyrosenbaum.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Althea Macejkovic",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "dicta",
    "FullName": "Izabella Huel",
    "IsOwnerContact": true,
    "ActiveErpLinks": 931,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 440
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 583,
    "Name": "Dooley-Dibbert",
    "PersonId": 309,
    "Rank": 422,
    "Tooltip": "nam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 329,
    "FullName": "Esmeralda Beahan",
    "FormalName": "Douglas, Lockman and Barton",
    "Deleted": true,
    "EjUserId": 402,
    "UserName": "Collier Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "mesh rich synergies"
        },
        "FieldType": "System.Int32",
        "FieldLength": 673
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 523,
    "Name": "Rice Group",
    "PersonId": 839,
    "Rank": 879,
    "Tooltip": "tenetur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 170,
    "FullName": "Steve Blanda",
    "FormalName": "Feest LLC",
    "Deleted": false,
    "EjUserId": 517,
    "UserName": "Dickinson-Walsh",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 194
      }
    }
  },
  "CreatedDate": "2012-11-27T16:48:28.5614485+01:00",
  "AppointmentId": 885,
  "Description": "Quality-focused 5th generation migration",
  "StartDate": "2012-07-21T16:48:28.5614485+02:00",
  "EndDate": "2009-11-23T16:48:28.5614485+01:00",
  "InvitedPerson": {
    "Position": "asperiores",
    "PersonId": 206,
    "Mrmrs": "natus",
    "Firstname": "Kailee",
    "Lastname": "Ebert",
    "MiddleName": "Hoppe, Metz and Ritchie",
    "Title": "veritatis",
    "Description": "Fully-configurable 6th generation function",
    "Email": "nannie_kozey@beckerrodriguez.biz",
    "FullName": "Reyna Mills",
    "DirectPhone": "1-818-678-7018 x712",
    "FormalName": "Schoen-Hane",
    "CountryId": 156,
    "ContactId": 667,
    "ContactName": "Thiel, Frami and Kutch",
    "Retired": 18,
    "Rank": 309,
    "ActiveInterests": 823,
    "ContactDepartment": "",
    "ContactCountryId": 988,
    "ContactOrgNr": "1240455",
    "FaxPhone": "768.602.6011 x482",
    "MobilePhone": "(851)723-4686 x2405",
    "ContactPhone": "087-741-1255 x45046",
    "AssociateName": "Gleason-Feest",
    "AssociateId": 324,
    "UsePersonAddress": true,
    "ContactFax": "tempore",
    "Kanafname": "maxime",
    "Kanalname": "odit",
    "Post1": "facere",
    "Post2": "iure",
    "Post3": "sequi",
    "EmailName": "dannie@doyle.com",
    "ContactFullName": "Karina Ryan",
    "ActiveErpLinks": 306,
    "TicketPriorityId": 543,
    "SupportLanguageId": 262,
    "SupportAssociateId": 703,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 278
      }
    }
  },
  "Person": {
    "Position": "voluptatem",
    "PersonId": 258,
    "Mrmrs": "sit",
    "Firstname": "Leslie",
    "Lastname": "Hauck",
    "MiddleName": "Cartwright, Abbott and Kautzer",
    "Title": "commodi",
    "Description": "Centralized content-based approach",
    "Email": "kaia@huels.co.uk",
    "FullName": "Orlo Nienow",
    "DirectPhone": "1-170-067-4832 x38573",
    "FormalName": "Corkery-Gutmann",
    "CountryId": 476,
    "ContactId": 414,
    "ContactName": "Gusikowski Inc and Sons",
    "Retired": 313,
    "Rank": 252,
    "ActiveInterests": 539,
    "ContactDepartment": "",
    "ContactCountryId": 777,
    "ContactOrgNr": "1383112",
    "FaxPhone": "046.180.8617 x1770",
    "MobilePhone": "250-381-2267 x6671",
    "ContactPhone": "634-433-8543",
    "AssociateName": "McLaughlin Inc and Sons",
    "AssociateId": 526,
    "UsePersonAddress": true,
    "ContactFax": "consequatur",
    "Kanafname": "harum",
    "Kanalname": "incidunt",
    "Post1": "quia",
    "Post2": "natus",
    "Post3": "ipsam",
    "EmailName": "genevieve.heidenreich@lesch.com",
    "ContactFullName": "Hassie Hamill",
    "ActiveErpLinks": 653,
    "TicketPriorityId": 246,
    "SupportLanguageId": 312,
    "SupportAssociateId": 20,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 606
      }
    }
  },
  "MotherId": 46,
  "Priority": {
    "Id": 704,
    "Value": "ea",
    "Tooltip": "iusto",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 17
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 527,
    "Name": "O'Reilly, Beier and Weimann",
    "Description": "Diverse discrete alliance",
    "URL": "http://www.example.com/",
    "Type": "illo",
    "AssociateId": 68,
    "AssociateFullName": "Elody Altenwerth",
    "TypeId": 48,
    "Updated": "2003-08-24T16:48:28.5634487+02:00",
    "StatusId": 389,
    "Status": "non",
    "TextId": 98,
    "PublishTo": "2016-12-04T16:48:28.5644492+01:00",
    "PublishFrom": "2017-01-02T16:48:28.5644492+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1269886",
    "ActiveErpLinks": 345,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 5
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2010-04-09T16:48:28.5644492+02:00",
  "Completed": "Completed",
  "ActiveLinks": 447,
  "Links": [
    {
      "EntityName": "Hoeger, Yost and Denesik",
      "Id": 371,
      "Description": "Sharable disintermediate synergy",
      "ExtraInfo": "omnis",
      "LinkId": 979,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 284
        }
      }
    }
  ],
  "AlarmLeadTime": "est",
  "HasAlarm": false,
  "ColorIndex": 584,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "maiores",
  "LeadTime": "ducimus",
  "Location": "tempora",
  "RejectCounter": 408,
  "RejectReason": "utilize 24/365 bandwidth",
  "Recurrence": {
    "RecurrenceId": 166,
    "StartDate": "1997-08-20T16:48:28.5644492+02:00",
    "EndDate": "2017-12-28T16:48:28.5644492+01:00",
    "RecurrenceCounter": 667,
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
      "AssociateId": 398,
      "PersonId": 800,
      "ContactId": 238,
      "EmailId": 401,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 398,
      "PersonId": 800,
      "ContactId": 238,
      "EmailId": 401,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2004-10-09T16:48:28.5644492+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 232,
    "Name": "Schumm, Funk and Gulgowski",
    "PersonId": 522,
    "Rank": 398,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 587,
    "FullName": "Patricia Reynolds",
    "FormalName": "Hagenes Inc and Sons",
    "Deleted": true,
    "EjUserId": 278,
    "UserName": "Conn-Marks",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 911
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 973,
    "Name": "Hansen-Douglas",
    "PersonId": 591,
    "Rank": 649,
    "Tooltip": "perferendis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 625,
    "FullName": "Tamara Macejkovic",
    "FormalName": "Gleichner-Pagac",
    "Deleted": true,
    "EjUserId": 847,
    "UserName": "Ullrich, Kihn and O'Reilly",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 534
      }
    }
  },
  "Task": {
    "TaskListItemId": 307,
    "Value": "reiciendis",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "dolores",
    "Deleted": true,
    "IntentId": 550,
    "Rank": 816,
    "IsDefaultAlldayEvent": false,
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
        "FieldLength": 465
      }
    }
  },
  "PreferredTZLocation": 292,
  "Sale": {
    "ContactName": "Pagac, Hegmann and Koch",
    "SaleDate": "2018-04-30T16:48:28.5654496+02:00",
    "SaleId": 427,
    "Probability": 377,
    "Title": "laudantium",
    "Amount": 9593.1739999999991,
    "Currency": "a",
    "ProjectName": "Beer LLC",
    "AssociateFullName": "Alfred Cole",
    "Description": "Cross-platform composite product",
    "Status": "Lost",
    "WeightedAmount": 1557.598,
    "ProjectId": 457,
    "EarningPercent": 861.85,
    "Earning": 29070.984,
    "ContactId": 664,
    "AssociateId": 873,
    "PersonId": 821,
    "SaleTypeId": 673,
    "SaleTypeName": "Rath, Ullrich and Romaguera",
    "PersonFullName": "Liza Nienow",
    "Completed": "Completed",
    "ActiveErpLinks": 555,
    "NextDueDate": "2019-03-13T16:48:28.5654496+01:00",
    "Number": "1176430",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 693
      }
    }
  },
  "SuggestedAppointmentId": 383,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "id",
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1586515777"
  },
  "ExtraFields": {
    "ExtraFields1": "necessitatibus",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "quas",
    "CustomFields2": "autem"
  },
  "PublishEventDate": "2005-03-29T16:48:28.5654496+02:00",
  "PublishTo": "2004-03-04T16:48:28.5654496+01:00",
  "PublishFrom": "2019-10-08T16:48:28.5654496+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 439,
      "Visibility": "All",
      "DisplayValue": "sint",
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
    },
    {
      "VisibleId": 439,
      "Visibility": "All",
      "DisplayValue": "sint",
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
      "FieldLength": 539
    }
  }
}
```