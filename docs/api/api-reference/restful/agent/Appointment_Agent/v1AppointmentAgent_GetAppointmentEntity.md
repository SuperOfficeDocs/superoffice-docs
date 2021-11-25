---
title: POST Agents/Appointment/GetAppointmentEntity
id: v1AppointmentAgent_GetAppointmentEntity
---

# POST Agents/Appointment/GetAppointmentEntity

```http
POST /api/v1/Agents/Appointment/GetAppointmentEntity
```

Gets a AppointmentEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| appointmentEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetAppointmentEntity?appointmentEntityId=60
POST /api/v1/Agents/Appointment/GetAppointmentEntity?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Appointment/GetAppointmentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 575,
    "Name": "Miller, Dooley and Keebler",
    "PersonId": 152,
    "Rank": 109,
    "Tooltip": "magni",
    "Type": "AnonymousAssociate",
    "GroupIdx": 228,
    "FullName": "Abigayle Feest",
    "FormalName": "Upton, Abshire and Conn",
    "Deleted": false,
    "EjUserId": 137,
    "UserName": "Borer, Rodriguez and Parker",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 799
      }
    }
  },
  "Contact": {
    "ContactId": 819,
    "Name": "Weissnat LLC",
    "OrgNr": "803543",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "sed",
    "DirectPhone": "(358)541-8482",
    "AssociateId": 914,
    "CountryId": 64,
    "EmailAddress": "mckayla@legros.co.uk",
    "Kananame": "est",
    "EmailAddressName": "cicero@langworth.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Kelsi Tremblay",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "aliquid",
    "FullName": "Millie Reilly",
    "IsOwnerContact": true,
    "ActiveErpLinks": 229,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 769
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 948,
    "Name": "O'Kon-Torp",
    "PersonId": 756,
    "Rank": 59,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 587,
    "FullName": "Ford Douglas",
    "FormalName": "Graham-Keeling",
    "Deleted": false,
    "EjUserId": 131,
    "UserName": "Wehner-Durgan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 564
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 276,
    "Name": "Wuckert LLC",
    "PersonId": 304,
    "Rank": 183,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 780,
    "FullName": "Junius Jones",
    "FormalName": "Zboncak, Bartell and Welch",
    "Deleted": true,
    "EjUserId": 313,
    "UserName": "Zboncak, McGlynn and Cronin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 213
      }
    }
  },
  "CreatedDate": "2019-04-15T18:28:47.9588456+02:00",
  "AppointmentId": 602,
  "Description": "Organic zero defect forecast",
  "StartDate": "2018-01-20T18:28:47.9588456+01:00",
  "EndDate": "2013-01-30T18:28:47.9588456+01:00",
  "InvitedPerson": {
    "Position": "facere",
    "PersonId": 260,
    "Mrmrs": "eos",
    "Firstname": "Guadalupe",
    "Lastname": "Beahan",
    "MiddleName": "Bechtelar, Sauer and Leuschke",
    "Title": "ipsum",
    "Description": "Horizontal homogeneous support",
    "Email": "kenyatta@pouros.com",
    "FullName": "Jerad Osinski",
    "DirectPhone": "785.733.0226 x54861",
    "FormalName": "Hodkiewicz-Tromp",
    "CountryId": 9,
    "ContactId": 461,
    "ContactName": "Moore, Pollich and Grimes",
    "Retired": 414,
    "Rank": 643,
    "ActiveInterests": 450,
    "ContactDepartment": "",
    "ContactCountryId": 795,
    "ContactOrgNr": "1326939",
    "FaxPhone": "(132)848-1400 x21607",
    "MobilePhone": "1-316-541-1112 x36834",
    "ContactPhone": "063-441-0364 x3634",
    "AssociateName": "Hoeger-Skiles",
    "AssociateId": 535,
    "UsePersonAddress": true,
    "ContactFax": "voluptas",
    "Kanafname": "eum",
    "Kanalname": "nemo",
    "Post1": "quod",
    "Post2": "mollitia",
    "Post3": "in",
    "EmailName": "leif_bogisich@paucek.us",
    "ContactFullName": "Mrs. Sheila Zemlak",
    "ActiveErpLinks": 823,
    "TicketPriorityId": 376,
    "SupportLanguageId": 842,
    "SupportAssociateId": 660,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 409
      }
    }
  },
  "Person": {
    "Position": "voluptas",
    "PersonId": 789,
    "Mrmrs": "voluptas",
    "Firstname": "Frida",
    "Lastname": "Dach",
    "MiddleName": "Kerluke-Upton",
    "Title": "ex",
    "Description": "Universal national capability",
    "Email": "jamey_powlowski@cummingsbeahan.ca",
    "FullName": "Clemmie Huel",
    "DirectPhone": "810.454.1667",
    "FormalName": "Nienow Inc and Sons",
    "CountryId": 164,
    "ContactId": 834,
    "ContactName": "Cummerata, Marks and Legros",
    "Retired": 76,
    "Rank": 144,
    "ActiveInterests": 228,
    "ContactDepartment": "reinvent value-added e-tailers",
    "ContactCountryId": 413,
    "ContactOrgNr": "1236964",
    "FaxPhone": "(268)123-3317",
    "MobilePhone": "038.303.3323 x8520",
    "ContactPhone": "1-084-208-6443 x6084",
    "AssociateName": "Rogahn-Hessel",
    "AssociateId": 658,
    "UsePersonAddress": true,
    "ContactFax": "quo",
    "Kanafname": "voluptas",
    "Kanalname": "non",
    "Post1": "ut",
    "Post2": "officiis",
    "Post3": "fugit",
    "EmailName": "clyde_gislason@wilkinsonwalsh.info",
    "ContactFullName": "Everardo Tromp",
    "ActiveErpLinks": 413,
    "TicketPriorityId": 14,
    "SupportLanguageId": 313,
    "SupportAssociateId": 277,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 656
      }
    }
  },
  "MotherId": 541,
  "Priority": {
    "Id": 10,
    "Value": "aut",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 3
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 897,
    "Name": "Boyle-Fadel",
    "Description": "Cloned transitional functionalities",
    "URL": "http://www.example.com/",
    "Type": "consequatur",
    "AssociateId": 796,
    "AssociateFullName": "Ruby Kuphal",
    "TypeId": 789,
    "Updated": "1996-03-15T18:28:47.9618455+01:00",
    "StatusId": 757,
    "Status": "cumque",
    "TextId": 656,
    "PublishTo": "2004-01-12T18:28:47.9618455+01:00",
    "PublishFrom": "2020-08-10T18:28:47.9618455+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1091618",
    "ActiveErpLinks": 106,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 342
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2008-02-23T18:28:47.9618455+01:00",
  "Completed": "Completed",
  "ActiveLinks": 802,
  "Links": [
    {
      "EntityName": "Kilback, Grady and Hahn",
      "Id": 788,
      "Description": "Enhanced explicit adapter",
      "ExtraInfo": "placeat",
      "LinkId": 862,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "target scalable functionalities"
          },
          "FieldType": "System.Int32",
          "FieldLength": 221
        }
      }
    }
  ],
  "AlarmLeadTime": "optio",
  "HasAlarm": true,
  "ColorIndex": 979,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "quia",
  "LeadTime": "officia",
  "Location": "officiis",
  "RejectCounter": 594,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 863,
    "StartDate": "2020-06-12T18:28:47.9618455+02:00",
    "EndDate": "2002-08-11T18:28:47.9618455+02:00",
    "RecurrenceCounter": 342,
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
      "AssociateId": 476,
      "PersonId": 285,
      "ContactId": 627,
      "EmailId": 409,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 476,
      "PersonId": 285,
      "ContactId": 627,
      "EmailId": 409,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2015-11-14T18:28:47.9618455+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 175,
    "Name": "Rolfson Group",
    "PersonId": 454,
    "Rank": 821,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 667,
    "FullName": "Otha Gutmann",
    "FormalName": "Crist, Mante and Fisher",
    "Deleted": true,
    "EjUserId": 789,
    "UserName": "Goldner, Reinger and Daugherty",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 572
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 608,
    "Name": "Kirlin Inc and Sons",
    "PersonId": 333,
    "Rank": 370,
    "Tooltip": "cumque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 541,
    "FullName": "Layne Torp",
    "FormalName": "Runte, Heller and Hirthe",
    "Deleted": false,
    "EjUserId": 503,
    "UserName": "Nitzsche Inc and Sons",
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
  "Task": {
    "TaskListItemId": 466,
    "Value": "ducimus",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "qui",
    "Deleted": true,
    "IntentId": 966,
    "Rank": 845,
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
        "FieldLength": 259
      }
    }
  },
  "PreferredTZLocation": 502,
  "Sale": {
    "ContactName": "Yost, Kuvalis and Hintz",
    "SaleDate": "1999-12-29T18:28:47.9628451+01:00",
    "SaleId": 568,
    "Probability": 914,
    "Title": "molestiae",
    "Amount": 15391.073999999999,
    "Currency": "molestiae",
    "ProjectName": "Yundt Group",
    "AssociateFullName": "Dereck Hoeger",
    "Description": "Business-focused incremental strategy",
    "Status": "Lost",
    "WeightedAmount": 25231.834,
    "ProjectId": 926,
    "EarningPercent": 22326.615999999998,
    "Earning": 27685.755999999998,
    "ContactId": 276,
    "AssociateId": 89,
    "PersonId": 996,
    "SaleTypeId": 582,
    "SaleTypeName": "Rowe-Glover",
    "PersonFullName": "Ida Krajcik",
    "Completed": "Completed",
    "ActiveErpLinks": 74,
    "NextDueDate": "2015-12-19T18:28:47.9638448+01:00",
    "Number": "1461639",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 592
      }
    }
  },
  "SuggestedAppointmentId": 716,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "vel",
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "culpa",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "dolorem",
    "CustomFields2": "ut"
  },
  "PublishEventDate": "2018-04-07T18:28:47.9638448+02:00",
  "PublishTo": "2008-05-29T18:28:47.9638448+02:00",
  "PublishFrom": "2003-12-27T18:28:47.9638448+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 551,
      "Visibility": "All",
      "DisplayValue": "sit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "redefine real-time e-tailers"
          },
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    },
    {
      "VisibleId": 551,
      "Visibility": "All",
      "DisplayValue": "sit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "redefine real-time e-tailers"
          },
          "FieldType": "System.Int32",
          "FieldLength": 336
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
      "FieldLength": 774
    }
  }
}
```