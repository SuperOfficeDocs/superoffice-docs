---
title: POST Agents/Appointment/CreateDefaultReOpenAppointment
id: v1AppointmentAgent_CreateDefaultReOpenAppointment
---

# POST Agents/Appointment/CreateDefaultReOpenAppointment

```http
POST /api/v1/Agents/Appointment/CreateDefaultReOpenAppointment
```

A re-open appointment should be created as a reminder to re-open the sale at a certain date with information regarding the stalled sale.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateDefaultReOpenAppointment?$select=name,department,category/id
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

SaleId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleId | int32 |  |


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
POST /api/v1/Agents/Appointment/CreateDefaultReOpenAppointment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SaleId": 516
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 43,
    "Name": "Gaylord, Heidenreich and Graham",
    "PersonId": 864,
    "Rank": 329,
    "Tooltip": "laboriosam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 304,
    "FullName": "Elliot Champlin",
    "FormalName": "Bayer, Carroll and Keebler",
    "Deleted": false,
    "EjUserId": 422,
    "UserName": "Tromp Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 599
      }
    }
  },
  "Contact": {
    "ContactId": 107,
    "Name": "Ryan, Kerluke and O'Kon",
    "OrgNr": "1217743",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "odit",
    "DirectPhone": "677-775-3660 x474",
    "AssociateId": 275,
    "CountryId": 752,
    "EmailAddress": "norma@torphy.uk",
    "Kananame": "ut",
    "EmailAddressName": "antonetta@coleoberbrunner.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Laron Hane",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "soluta",
    "FullName": "Vladimir Mayert",
    "IsOwnerContact": true,
    "ActiveErpLinks": 52,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 662
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 536,
    "Name": "Wisozk-Gusikowski",
    "PersonId": 166,
    "Rank": 907,
    "Tooltip": "porro",
    "Type": "AnonymousAssociate",
    "GroupIdx": 517,
    "FullName": "Adah Simonis",
    "FormalName": "Mosciski-Satterfield",
    "Deleted": true,
    "EjUserId": 444,
    "UserName": "West, Weimann and Koss",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 537
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 783,
    "Name": "Kertzmann-Borer",
    "PersonId": 593,
    "Rank": 781,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 633,
    "FullName": "Mrs. Vito Robel",
    "FormalName": "Brakus Inc and Sons",
    "Deleted": false,
    "EjUserId": 648,
    "UserName": "Upton, Hirthe and Williamson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 276
      }
    }
  },
  "CreatedDate": "2014-07-20T18:28:47.8288507+02:00",
  "AppointmentId": 722,
  "Description": "Business-focused foreground application",
  "StartDate": "2008-01-20T18:28:47.8288507+01:00",
  "EndDate": "2004-09-03T18:28:47.8288507+02:00",
  "InvitedPerson": {
    "Position": "ad",
    "PersonId": 279,
    "Mrmrs": "molestiae",
    "Firstname": "Jonas",
    "Lastname": "Schamberger",
    "MiddleName": "Stokes-Yundt",
    "Title": "voluptatem",
    "Description": "Multi-layered 24/7 support",
    "Email": "donavon.gerhold@murazik.uk",
    "FullName": "Enrico Rippin",
    "DirectPhone": "1-846-206-3567 x871",
    "FormalName": "Gottlieb, Larkin and Witting",
    "CountryId": 869,
    "ContactId": 748,
    "ContactName": "Funk-Hessel",
    "Retired": 885,
    "Rank": 794,
    "ActiveInterests": 21,
    "ContactDepartment": "",
    "ContactCountryId": 384,
    "ContactOrgNr": "721035",
    "FaxPhone": "381.071.1652 x1310",
    "MobilePhone": "412.374.0532",
    "ContactPhone": "571.233.8838 x610",
    "AssociateName": "Hand Inc and Sons",
    "AssociateId": 231,
    "UsePersonAddress": true,
    "ContactFax": "at",
    "Kanafname": "officiis",
    "Kanalname": "cupiditate",
    "Post1": "qui",
    "Post2": "fugiat",
    "Post3": "aliquid",
    "EmailName": "reva@funk.ca",
    "ContactFullName": "Sherman Schmidt",
    "ActiveErpLinks": 508,
    "TicketPriorityId": 171,
    "SupportLanguageId": 569,
    "SupportAssociateId": 457,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 219
      }
    }
  },
  "Person": {
    "Position": "nostrum",
    "PersonId": 801,
    "Mrmrs": "quia",
    "Firstname": "Grayce",
    "Lastname": "Hilll",
    "MiddleName": "Kling, Pfeffer and Lueilwitz",
    "Title": "nobis",
    "Description": "Business-focused needs-based archive",
    "Email": "schuyler.schaden@adamsosinski.info",
    "FullName": "Ida Heathcote",
    "DirectPhone": "286-683-2842",
    "FormalName": "Hermiston, Torphy and Schuster",
    "CountryId": 860,
    "ContactId": 858,
    "ContactName": "O'Hara, Buckridge and Kessler",
    "Retired": 483,
    "Rank": 478,
    "ActiveInterests": 940,
    "ContactDepartment": "",
    "ContactCountryId": 632,
    "ContactOrgNr": "1048775",
    "FaxPhone": "584.602.3487 x227",
    "MobilePhone": "(411)086-1788 x2857",
    "ContactPhone": "704-763-5702",
    "AssociateName": "Jacobs-Hettinger",
    "AssociateId": 897,
    "UsePersonAddress": false,
    "ContactFax": "eos",
    "Kanafname": "repellendus",
    "Kanalname": "qui",
    "Post1": "dolorum",
    "Post2": "officiis",
    "Post3": "aut",
    "EmailName": "kaycee.corwin@mclaughlin.info",
    "ContactFullName": "Ivory Blick",
    "ActiveErpLinks": 327,
    "TicketPriorityId": 957,
    "SupportLanguageId": 402,
    "SupportAssociateId": 147,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 787
      }
    }
  },
  "MotherId": 922,
  "Priority": {
    "Id": 7,
    "Value": "laudantium",
    "Tooltip": "dolor",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 430
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 930,
    "Name": "Mann LLC",
    "Description": "Exclusive multi-tasking capacity",
    "URL": "http://www.example.com/",
    "Type": "consequatur",
    "AssociateId": 895,
    "AssociateFullName": "Burley Mertz",
    "TypeId": 413,
    "Updated": "2006-04-02T18:28:47.8318501+02:00",
    "StatusId": 461,
    "Status": "voluptas",
    "TextId": 611,
    "PublishTo": "1996-11-07T18:28:47.8318501+01:00",
    "PublishFrom": "2016-11-07T18:28:47.8318501+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1505420",
    "ActiveErpLinks": 991,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 970
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2017-02-22T18:28:47.8318501+01:00",
  "Completed": "Completed",
  "ActiveLinks": 401,
  "Links": [
    {
      "EntityName": "Lebsack, Runte and Rosenbaum",
      "Id": 371,
      "Description": "Customizable homogeneous knowledge user",
      "ExtraInfo": "omnis",
      "LinkId": 893,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 53
        }
      }
    }
  ],
  "AlarmLeadTime": "quia",
  "HasAlarm": false,
  "ColorIndex": 971,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "esse",
  "LeadTime": "soluta",
  "Location": "veniam",
  "RejectCounter": 773,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 848,
    "StartDate": "2019-01-18T18:28:47.8318501+01:00",
    "EndDate": "2002-03-13T18:28:47.8318501+01:00",
    "RecurrenceCounter": 630,
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
      "AssociateId": 804,
      "PersonId": 702,
      "ContactId": 617,
      "EmailId": 183,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 804,
      "PersonId": 702,
      "ContactId": 617,
      "EmailId": 183,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2002-09-09T18:28:47.8318501+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 987,
    "Name": "Eichmann, Nolan and Schmidt",
    "PersonId": 205,
    "Rank": 671,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 82,
    "FullName": "Miss Saige Quigley",
    "FormalName": "Ortiz LLC",
    "Deleted": true,
    "EjUserId": 556,
    "UserName": "Cormier Inc and Sons",
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
  "MotherAssociate": {
    "AssociateId": 311,
    "Name": "Crona LLC",
    "PersonId": 961,
    "Rank": 982,
    "Tooltip": "ullam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 45,
    "FullName": "Ellis Langworth DVM",
    "FormalName": "Upton, Sauer and Reichert",
    "Deleted": false,
    "EjUserId": 844,
    "UserName": "Johnston Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 148
      }
    }
  },
  "Task": {
    "TaskListItemId": 15,
    "Value": "soluta",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "esse",
    "Deleted": true,
    "IntentId": 738,
    "Rank": 774,
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
        "FieldLength": 145
      }
    }
  },
  "PreferredTZLocation": 658,
  "Sale": {
    "ContactName": "Funk-Ferry",
    "SaleDate": "2011-06-02T18:28:47.8328504+02:00",
    "SaleId": 158,
    "Probability": 1000,
    "Title": "totam",
    "Amount": 27795.446,
    "Currency": "neque",
    "ProjectName": "Jacobs, Skiles and Klein",
    "AssociateFullName": "Delores Quigley",
    "Description": "Devolved responsive artificial intelligence",
    "Status": "Lost",
    "WeightedAmount": 3867.3559999999998,
    "ProjectId": 137,
    "EarningPercent": 4105.54,
    "Earning": 18835.34,
    "ContactId": 530,
    "AssociateId": 541,
    "PersonId": 756,
    "SaleTypeId": 646,
    "SaleTypeName": "Leffler, Hilll and Tromp",
    "PersonFullName": "Nils Metz",
    "Completed": "Completed",
    "ActiveErpLinks": 180,
    "NextDueDate": "2021-04-10T18:28:47.8338516+02:00",
    "Number": "1010269",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 705
      }
    }
  },
  "SuggestedAppointmentId": 721,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "non",
  "UserDefinedFields": {
    "SuperOffice:1": "621152589",
    "SuperOffice:2": "1194252458"
  },
  "ExtraFields": {
    "ExtraFields1": "magni",
    "ExtraFields2": "magnam"
  },
  "CustomFields": {
    "CustomFields1": "rem",
    "CustomFields2": "quo"
  },
  "PublishEventDate": "2015-04-02T18:28:47.8338516+02:00",
  "PublishTo": "2014-11-05T18:28:47.8338516+01:00",
  "PublishFrom": "2004-07-25T18:28:47.8338516+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 503,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 731
        }
      }
    },
    {
      "VisibleId": 503,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 731
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "brand back-end technologies"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 652
    }
  }
}
```