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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 744,
  "UpdateMode": "OnlyThis"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 824,
    "Name": "Kemmer Group",
    "PersonId": 488,
    "Rank": 591,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 692,
    "FullName": "Kraig O'Keefe",
    "FormalName": "Zulauf LLC",
    "Deleted": false,
    "EjUserId": 711,
    "UserName": "Pacocha-Crooks",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 45
      }
    }
  },
  "Contact": {
    "ContactId": 191,
    "Name": "O'Conner, Windler and Gibson",
    "OrgNr": "1200858",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ut",
    "DirectPhone": "676-453-0773 x637",
    "AssociateId": 629,
    "CountryId": 33,
    "EmailAddress": "leonie@brakus.name",
    "Kananame": "exercitationem",
    "EmailAddressName": "cassandra.lemke@yost.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Laron Schultz",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "perferendis",
    "FullName": "Adrain Schneider",
    "IsOwnerContact": true,
    "ActiveErpLinks": 377,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 498
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 819,
    "Name": "Fay-Crona",
    "PersonId": 941,
    "Rank": 567,
    "Tooltip": "odio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 784,
    "FullName": "Mrs. Rhianna Kulas",
    "FormalName": "Kohler Group",
    "Deleted": false,
    "EjUserId": 89,
    "UserName": "Bode-Fisher",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 656
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 718,
    "Name": "Feil LLC",
    "PersonId": 358,
    "Rank": 32,
    "Tooltip": "sequi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 898,
    "FullName": "Shanon Bayer",
    "FormalName": "Batz, Waelchi and Witting",
    "Deleted": true,
    "EjUserId": 63,
    "UserName": "Champlin-Larkin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 786
      }
    }
  },
  "CreatedDate": "2005-12-09T18:28:47.7818442+01:00",
  "AppointmentId": 69,
  "Description": "Inverse logistical interface",
  "StartDate": "2012-08-26T18:28:47.7818442+02:00",
  "EndDate": "2003-04-26T18:28:47.7818442+02:00",
  "InvitedPerson": {
    "Position": "pariatur",
    "PersonId": 962,
    "Mrmrs": "non",
    "Firstname": "Herminia",
    "Lastname": "Beahan",
    "MiddleName": "Pacocha-Corkery",
    "Title": "neque",
    "Description": "Versatile responsive framework",
    "Email": "carolina@satterfield.info",
    "FullName": "Clinton Morar",
    "DirectPhone": "754-666-3816 x706",
    "FormalName": "Moen, Ankunding and Barton",
    "CountryId": 456,
    "ContactId": 373,
    "ContactName": "Olson-Mann",
    "Retired": 990,
    "Rank": 216,
    "ActiveInterests": 695,
    "ContactDepartment": "",
    "ContactCountryId": 306,
    "ContactOrgNr": "1251805",
    "FaxPhone": "653-727-5783 x71604",
    "MobilePhone": "(341)770-7162",
    "ContactPhone": "204.454.3016 x836",
    "AssociateName": "Douglas-Larkin",
    "AssociateId": 1000,
    "UsePersonAddress": false,
    "ContactFax": "aut",
    "Kanafname": "porro",
    "Kanalname": "consequatur",
    "Post1": "in",
    "Post2": "maiores",
    "Post3": "dolorem",
    "EmailName": "allan@gleichner.info",
    "ContactFullName": "Summer Farrell",
    "ActiveErpLinks": 738,
    "TicketPriorityId": 373,
    "SupportLanguageId": 34,
    "SupportAssociateId": 283,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 419
      }
    }
  },
  "Person": {
    "Position": "et",
    "PersonId": 555,
    "Mrmrs": "natus",
    "Firstname": "Edd",
    "Lastname": "Labadie",
    "MiddleName": "Larkin-O'Kon",
    "Title": "tempore",
    "Description": "Balanced reciprocal Graphic Interface",
    "Email": "giovanny@torpjerde.uk",
    "FullName": "Ms. Annabell Botsford",
    "DirectPhone": "638.372.6123",
    "FormalName": "Zulauf LLC",
    "CountryId": 758,
    "ContactId": 510,
    "ContactName": "Stanton-Carter",
    "Retired": 782,
    "Rank": 233,
    "ActiveInterests": 180,
    "ContactDepartment": "",
    "ContactCountryId": 972,
    "ContactOrgNr": "1607015",
    "FaxPhone": "558-314-6150",
    "MobilePhone": "1-073-884-0138 x1871",
    "ContactPhone": "1-271-641-4750",
    "AssociateName": "Walter Inc and Sons",
    "AssociateId": 648,
    "UsePersonAddress": true,
    "ContactFax": "velit",
    "Kanafname": "recusandae",
    "Kanalname": "ullam",
    "Post1": "ad",
    "Post2": "voluptatum",
    "Post3": "sed",
    "EmailName": "ashley@roobborer.com",
    "ContactFullName": "Coleman Strosin",
    "ActiveErpLinks": 2,
    "TicketPriorityId": 793,
    "SupportLanguageId": 609,
    "SupportAssociateId": 504,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 901
      }
    }
  },
  "MotherId": 671,
  "Priority": {
    "Id": 564,
    "Value": "sed",
    "Tooltip": "quos",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 436
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 886,
    "Name": "Ullrich-Green",
    "Description": "Operative multi-tasking alliance",
    "URL": "http://www.example.com/",
    "Type": "sequi",
    "AssociateId": 301,
    "AssociateFullName": "Octavia Gibson III",
    "TypeId": 397,
    "Updated": "2010-02-01T18:28:47.7848445+01:00",
    "StatusId": 411,
    "Status": "et",
    "TextId": 223,
    "PublishTo": "2013-08-23T18:28:47.7848445+02:00",
    "PublishFrom": "2003-04-03T18:28:47.7848445+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1529406",
    "ActiveErpLinks": 46,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 580
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2016-12-28T18:28:47.7848445+01:00",
  "Completed": "Completed",
  "ActiveLinks": 888,
  "Links": [
    {
      "EntityName": "Grady Inc and Sons",
      "Id": 504,
      "Description": "Centralized solution-oriented initiative",
      "ExtraInfo": "similique",
      "LinkId": 601,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 91
        }
      }
    }
  ],
  "AlarmLeadTime": "veritatis",
  "HasAlarm": false,
  "ColorIndex": 642,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "sed",
  "LeadTime": "nostrum",
  "Location": "quos",
  "RejectCounter": 674,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 143,
    "StartDate": "2006-03-09T18:28:47.7848445+01:00",
    "EndDate": "2021-07-12T18:28:47.7848445+02:00",
    "RecurrenceCounter": 957,
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
      "AssociateId": 112,
      "PersonId": 338,
      "ContactId": 908,
      "EmailId": 759,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 112,
      "PersonId": 338,
      "ContactId": 908,
      "EmailId": 759,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2019-09-05T18:28:47.7848445+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 424,
    "Name": "Nikolaus, Lehner and Beier",
    "PersonId": 647,
    "Rank": 701,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 77,
    "FullName": "Brandon Mayert",
    "FormalName": "Senger Inc and Sons",
    "Deleted": false,
    "EjUserId": 587,
    "UserName": "Rohan-Frami",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 613
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 885,
    "Name": "Kuhic, O'Reilly and Borer",
    "PersonId": 432,
    "Rank": 210,
    "Tooltip": "quasi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 36,
    "FullName": "Jonas Hilll",
    "FormalName": "Legros Inc and Sons",
    "Deleted": true,
    "EjUserId": 37,
    "UserName": "Satterfield-Daugherty",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 122
      }
    }
  },
  "Task": {
    "TaskListItemId": 194,
    "Value": "consequatur",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "consequatur",
    "Deleted": true,
    "IntentId": 764,
    "Rank": 821,
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
        "FieldLength": 790
      }
    }
  },
  "PreferredTZLocation": 511,
  "Sale": {
    "ContactName": "Emmerich-Hand",
    "SaleDate": "2015-11-14T18:28:47.7858444+01:00",
    "SaleId": 50,
    "Probability": 944,
    "Title": "adipisci",
    "Amount": 26040.406,
    "Currency": "odio",
    "ProjectName": "Roberts-Wisozk",
    "AssociateFullName": "Mekhi Towne PhD",
    "Description": "Sharable 24/7 projection",
    "Status": "Lost",
    "WeightedAmount": 18979.504,
    "ProjectId": 437,
    "EarningPercent": 15858.039999999999,
    "Earning": 21411.487999999998,
    "ContactId": 996,
    "AssociateId": 392,
    "PersonId": 935,
    "SaleTypeId": 912,
    "SaleTypeName": "Baumbach-Bruen",
    "PersonFullName": "Lucas Wiza",
    "Completed": "Completed",
    "ActiveErpLinks": 149,
    "NextDueDate": "2018-05-12T18:28:47.7868444+02:00",
    "Number": "439916",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 382
      }
    }
  },
  "SuggestedAppointmentId": 439,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "necessitatibus",
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Leopoldo Towne"
  },
  "ExtraFields": {
    "ExtraFields1": "commodi",
    "ExtraFields2": "adipisci"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "qui"
  },
  "PublishEventDate": "2008-12-01T18:28:47.7868444+01:00",
  "PublishTo": "2012-11-19T18:28:47.7868444+01:00",
  "PublishFrom": "2012-11-06T18:28:47.7868444+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 531,
      "Visibility": "All",
      "DisplayValue": "consequatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 551
        }
      }
    },
    {
      "VisibleId": 531,
      "Visibility": "All",
      "DisplayValue": "consequatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 551
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
      "FieldLength": 45
    }
  }
}
```