---
title: POST Agents/Appointment/GetAppointmentFromUID
id: v1AppointmentAgent_GetAppointmentFromUID
---

# POST Agents/Appointment/GetAppointmentFromUID

```http
POST /api/v1/Agents/Appointment/GetAppointmentFromUID
```

Get the appointment that corresponds to the given UID.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetAppointmentFromUID?$select=name,department,category/id
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

UID 

| Property Name | Type |  Description |
|----------------|------|--------------|
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
POST /api/v1/Agents/Appointment/GetAppointmentFromUID
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "UID": "illo"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 569,
    "Name": "Dietrich-Ernser",
    "PersonId": 550,
    "Rank": 441,
    "Tooltip": "autem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 485,
    "FullName": "Kailyn Gerlach",
    "FormalName": "Miller-Strosin",
    "Deleted": false,
    "EjUserId": 225,
    "UserName": "Waters, Willms and Hand",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 472
      }
    }
  },
  "Contact": {
    "ContactId": 665,
    "Name": "McGlynn-Bosco",
    "OrgNr": "742623",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "sapiente",
    "DirectPhone": "(824)006-3355",
    "AssociateId": 525,
    "CountryId": 598,
    "EmailAddress": "florida@becker.co.uk",
    "Kananame": "odio",
    "EmailAddressName": "sylvia.ryan@dubuque.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Darlene Jones",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "officiis",
    "FullName": "Nigel Orn",
    "IsOwnerContact": false,
    "ActiveErpLinks": 194,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 707
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 948,
    "Name": "Donnelly Inc and Sons",
    "PersonId": 219,
    "Rank": 618,
    "Tooltip": "maxime",
    "Type": "AnonymousAssociate",
    "GroupIdx": 722,
    "FullName": "Diamond Harber",
    "FormalName": "Gulgowski-Gibson",
    "Deleted": false,
    "EjUserId": 346,
    "UserName": "Wilderman-Gerlach",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 486
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 239,
    "Name": "Bernhard LLC",
    "PersonId": 908,
    "Rank": 360,
    "Tooltip": "eveniet",
    "Type": "AnonymousAssociate",
    "GroupIdx": 133,
    "FullName": "Kolby Wolf",
    "FormalName": "Donnelly, Hayes and Mitchell",
    "Deleted": true,
    "EjUserId": 707,
    "UserName": "Monahan-Haag",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 629
      }
    }
  },
  "CreatedDate": "2006-06-16T16:48:28.4084537+02:00",
  "AppointmentId": 857,
  "Description": "Team-oriented grid-enabled monitoring",
  "StartDate": "1996-09-18T16:48:28.4084537+02:00",
  "EndDate": "2014-05-01T16:48:28.4084537+02:00",
  "InvitedPerson": {
    "Position": "voluptatibus",
    "PersonId": 320,
    "Mrmrs": "consectetur",
    "Firstname": "Albert",
    "Lastname": "Hessel",
    "MiddleName": "Hettinger, Cassin and Gerhold",
    "Title": "nobis",
    "Description": "Persevering holistic Graphical User Interface",
    "Email": "madisyn_koepp@swiftward.name",
    "FullName": "Theodore Gottlieb",
    "DirectPhone": "106-472-2870 x32352",
    "FormalName": "Brekke Group",
    "CountryId": 948,
    "ContactId": 41,
    "ContactName": "Kerluke Inc and Sons",
    "Retired": 789,
    "Rank": 668,
    "ActiveInterests": 431,
    "ContactDepartment": "",
    "ContactCountryId": 872,
    "ContactOrgNr": "436991",
    "FaxPhone": "264.633.7633 x544",
    "MobilePhone": "617-567-8826",
    "ContactPhone": "(687)343-7441 x4788",
    "AssociateName": "Hand, Abernathy and McKenzie",
    "AssociateId": 685,
    "UsePersonAddress": false,
    "ContactFax": "qui",
    "Kanafname": "a",
    "Kanalname": "accusantium",
    "Post1": "corporis",
    "Post2": "facilis",
    "Post3": "quas",
    "EmailName": "anjali_huels@hudson.biz",
    "ContactFullName": "Mr. Ayana Daniel",
    "ActiveErpLinks": 325,
    "TicketPriorityId": 881,
    "SupportLanguageId": 728,
    "SupportAssociateId": 935,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 557
      }
    }
  },
  "Person": {
    "Position": "dolor",
    "PersonId": 25,
    "Mrmrs": "at",
    "Firstname": "Ariel",
    "Lastname": "Kub",
    "MiddleName": "Littel Group",
    "Title": "at",
    "Description": "Ameliorated 24 hour software",
    "Email": "hector@monahanroberts.biz",
    "FullName": "Rosemarie Predovic",
    "DirectPhone": "781-430-6884 x258",
    "FormalName": "Hahn LLC",
    "CountryId": 877,
    "ContactId": 180,
    "ContactName": "Cummerata Inc and Sons",
    "Retired": 148,
    "Rank": 322,
    "ActiveInterests": 39,
    "ContactDepartment": "",
    "ContactCountryId": 515,
    "ContactOrgNr": "454611",
    "FaxPhone": "748-280-0351 x7180",
    "MobilePhone": "(564)223-7564 x155",
    "ContactPhone": "1-078-320-0328",
    "AssociateName": "Emard Inc and Sons",
    "AssociateId": 274,
    "UsePersonAddress": true,
    "ContactFax": "doloremque",
    "Kanafname": "et",
    "Kanalname": "deleniti",
    "Post1": "veritatis",
    "Post2": "consequatur",
    "Post3": "illo",
    "EmailName": "consuelo_satterfield@kemmerfarrell.ca",
    "ContactFullName": "Valentina Rau",
    "ActiveErpLinks": 689,
    "TicketPriorityId": 998,
    "SupportLanguageId": 369,
    "SupportAssociateId": 208,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 84
      }
    }
  },
  "MotherId": 364,
  "Priority": {
    "Id": 542,
    "Value": "rem",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 416
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 998,
    "Name": "Abbott-Barrows",
    "Description": "Down-sized bifurcated hierarchy",
    "URL": "http://www.example.com/",
    "Type": "et",
    "AssociateId": 783,
    "AssociateFullName": "Norris Pagac",
    "TypeId": 306,
    "Updated": "2012-09-08T16:48:28.4114517+02:00",
    "StatusId": 610,
    "Status": "quas",
    "TextId": 274,
    "PublishTo": "2016-01-27T16:48:28.4114517+01:00",
    "PublishFrom": "2004-11-27T16:48:28.4114517+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1822238",
    "ActiveErpLinks": 516,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 875
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2003-08-10T16:48:28.4114517+02:00",
  "Completed": "Completed",
  "ActiveLinks": 94,
  "Links": [
    {
      "EntityName": "Wilkinson-Gutmann",
      "Id": 687,
      "Description": "Versatile bottom-line application",
      "ExtraInfo": "quaerat",
      "LinkId": 566,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 921
        }
      }
    }
  ],
  "AlarmLeadTime": "consectetur",
  "HasAlarm": true,
  "ColorIndex": 498,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "adipisci",
  "LeadTime": "corrupti",
  "Location": "excepturi",
  "RejectCounter": 943,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 162,
    "StartDate": "2012-01-28T16:48:28.4124562+01:00",
    "EndDate": "2000-10-04T16:48:28.4124562+02:00",
    "RecurrenceCounter": 139,
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
      "AssociateId": 352,
      "PersonId": 10,
      "ContactId": 925,
      "EmailId": 105,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 352,
      "PersonId": 10,
      "ContactId": 925,
      "EmailId": 105,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2004-02-21T16:48:28.4124562+01:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 740,
    "Name": "Maggio-Bradtke",
    "PersonId": 576,
    "Rank": 372,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 337,
    "FullName": "Ray Mayert",
    "FormalName": "Effertz-O'Conner",
    "Deleted": false,
    "EjUserId": 925,
    "UserName": "Cruickshank, Hirthe and Braun",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 376
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 395,
    "Name": "Corkery, Block and Stiedemann",
    "PersonId": 84,
    "Rank": 865,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 848,
    "FullName": "Miss Gaston Sawayn",
    "FormalName": "Schneider, Schroeder and O'Hara",
    "Deleted": true,
    "EjUserId": 344,
    "UserName": "Conn-Lynch",
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
    "TaskListItemId": 953,
    "Value": "culpa",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "reiciendis",
    "Deleted": true,
    "IntentId": 96,
    "Rank": 789,
    "IsDefaultAlldayEvent": true,
    "IsDefaultFree": false,
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
        "FieldLength": 165
      }
    }
  },
  "PreferredTZLocation": 441,
  "Sale": {
    "ContactName": "Johnston-Gusikowski",
    "SaleDate": "1994-11-09T16:48:28.4124562+01:00",
    "SaleId": 166,
    "Probability": 992,
    "Title": "maxime",
    "Amount": 25184.824,
    "Currency": "vel",
    "ProjectName": "Reilly-Jacobs",
    "AssociateFullName": "Brooks Altenwerth",
    "Description": "Compatible bifurcated knowledge base",
    "Status": "Lost",
    "WeightedAmount": 11586.398,
    "ProjectId": 860,
    "EarningPercent": 551.584,
    "Earning": 10411.148,
    "ContactId": 41,
    "AssociateId": 241,
    "PersonId": 542,
    "SaleTypeId": 970,
    "SaleTypeName": "Roob-Kihn",
    "PersonFullName": "Terry Bode",
    "Completed": "Completed",
    "ActiveErpLinks": 336,
    "NextDueDate": "2004-05-16T16:48:28.4134497+02:00",
    "Number": "1509271",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 509
      }
    }
  },
  "SuggestedAppointmentId": 974,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "aut",
  "UserDefinedFields": {
    "SuperOffice:1": "1314866439",
    "SuperOffice:2": "Alize Altenwerth"
  },
  "ExtraFields": {
    "ExtraFields1": "veniam",
    "ExtraFields2": "consequuntur"
  },
  "CustomFields": {
    "CustomFields1": "quos",
    "CustomFields2": "quis"
  },
  "PublishEventDate": "1998-06-24T16:48:28.4134497+02:00",
  "PublishTo": "2011-02-27T16:48:28.4134497+01:00",
  "PublishFrom": "2015-12-29T16:48:28.4134497+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 323,
      "Visibility": "All",
      "DisplayValue": "qui",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 167
        }
      }
    },
    {
      "VisibleId": 323,
      "Visibility": "All",
      "DisplayValue": "qui",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 167
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
      "FieldLength": 691
    }
  }
}
```