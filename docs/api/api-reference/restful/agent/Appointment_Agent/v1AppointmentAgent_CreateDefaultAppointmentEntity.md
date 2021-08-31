---
title: CreateDefaultAppointmentEntity
id: v1AppointmentAgent_CreateDefaultAppointmentEntity
---

# CreateDefaultAppointmentEntity

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntity
```

Set default values into a new AppointmentEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 799,
    "Name": "Armstrong-Goyette",
    "PersonId": 697,
    "Rank": 299,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 898,
    "FullName": "Estefania Sawayn II",
    "FormalName": "Schowalter, Ledner and Ratke",
    "Deleted": true,
    "EjUserId": 878,
    "UserName": "Jaskolski Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 676
      }
    }
  },
  "Contact": {
    "ContactId": 210,
    "Name": "Bergstrom-Rodriguez",
    "OrgNr": "639964",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "delectus",
    "DirectPhone": "(361)661-3620",
    "AssociateId": 58,
    "CountryId": 660,
    "EmailAddress": "justyn@sanford.name",
    "Kananame": "autem",
    "EmailAddressName": "leann.mraz@lang.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mr. Aron Rowe",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "vitae",
    "FullName": "Mr. Cindy Kuhlman",
    "IsOwnerContact": true,
    "ActiveErpLinks": 423,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 619
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 551,
    "Name": "Lemke Group",
    "PersonId": 550,
    "Rank": 589,
    "Tooltip": "officiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 353,
    "FullName": "Jaren Langosh",
    "FormalName": "Feil, Tromp and Greenholt",
    "Deleted": false,
    "EjUserId": 241,
    "UserName": "Wiza, Tromp and Larkin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 540
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 456,
    "Name": "Hills Inc and Sons",
    "PersonId": 183,
    "Rank": 781,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 696,
    "FullName": "Emerson Keebler",
    "FormalName": "Effertz-McDermott",
    "Deleted": true,
    "EjUserId": 244,
    "UserName": "O'Kon-Fritsch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 735
      }
    }
  },
  "CreatedDate": "2016-09-16T14:58:03.0705381+02:00",
  "AppointmentId": 570,
  "Description": "Profit-focused multimedia open architecture",
  "StartDate": "2019-04-24T14:58:03.0705381+02:00",
  "EndDate": "2002-12-28T14:58:03.0705381+01:00",
  "InvitedPerson": {
    "Position": "ab",
    "PersonId": 253,
    "Mrmrs": "et",
    "Firstname": "Cyrus",
    "Lastname": "Okuneva",
    "MiddleName": "Labadie, Reynolds and Walsh",
    "Title": "at",
    "Description": "Operative scalable hub",
    "Email": "elyssa.durgan@wildermangraham.com",
    "FullName": "Deangelo Jacobi",
    "DirectPhone": "134-556-3314",
    "FormalName": "D'Amore, McCullough and Spencer",
    "CountryId": 149,
    "ContactId": 522,
    "ContactName": "D'Amore Inc and Sons",
    "Retired": 200,
    "Rank": 374,
    "ActiveInterests": 116,
    "ContactDepartment": "",
    "ContactCountryId": 339,
    "ContactOrgNr": "1433018",
    "FaxPhone": "860.057.5411",
    "MobilePhone": "(501)322-4855",
    "ContactPhone": "675-815-0410 x65351",
    "AssociateName": "Ernser-Heller",
    "AssociateId": 925,
    "UsePersonAddress": true,
    "ContactFax": "laboriosam",
    "Kanafname": "in",
    "Kanalname": "eaque",
    "Post1": "fugiat",
    "Post2": "consequatur",
    "Post3": "aliquam",
    "EmailName": "christiana_daugherty@mertzmorissette.co.uk",
    "ContactFullName": "Margarett Wintheiser",
    "ActiveErpLinks": 226,
    "TicketPriorityId": 869,
    "SupportLanguageId": 525,
    "SupportAssociateId": 775,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "transition B2C e-markets"
        },
        "FieldType": "System.String",
        "FieldLength": 298
      }
    }
  },
  "Person": {
    "Position": "nihil",
    "PersonId": 844,
    "Mrmrs": "dolor",
    "Firstname": "Cary",
    "Lastname": "Parisian",
    "MiddleName": "Turcotte LLC",
    "Title": "voluptatum",
    "Description": "Assimilated cohesive middleware",
    "Email": "vivienne_rice@wisoky.info",
    "FullName": "Magnolia Gislason",
    "DirectPhone": "1-664-842-3534",
    "FormalName": "Klein, Heller and Champlin",
    "CountryId": 772,
    "ContactId": 559,
    "ContactName": "Huel, Kuhn and Marks",
    "Retired": 192,
    "Rank": 208,
    "ActiveInterests": 913,
    "ContactDepartment": "",
    "ContactCountryId": 872,
    "ContactOrgNr": "1137374",
    "FaxPhone": "(002)184-5184 x877",
    "MobilePhone": "547-247-5702",
    "ContactPhone": "684.771.6884",
    "AssociateName": "Dicki Group",
    "AssociateId": 557,
    "UsePersonAddress": false,
    "ContactFax": "natus",
    "Kanafname": "quaerat",
    "Kanalname": "nihil",
    "Post1": "voluptatem",
    "Post2": "velit",
    "Post3": "officia",
    "EmailName": "jeffry@fahey.name",
    "ContactFullName": "Laury Braun III",
    "ActiveErpLinks": 88,
    "TicketPriorityId": 370,
    "SupportLanguageId": 174,
    "SupportAssociateId": 878,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 309
      }
    }
  },
  "MotherId": 123,
  "Priority": {
    "Id": 727,
    "Value": "nostrum",
    "Tooltip": "dolorem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 949
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 879,
    "Name": "Wilkinson-Leffler",
    "Description": "Multi-layered full-range utilisation",
    "URL": "http://www.example.com/",
    "Type": "quia",
    "AssociateId": 226,
    "AssociateFullName": "Felipa Effertz",
    "TypeId": 445,
    "Updated": "2017-12-03T14:58:03.0735383+01:00",
    "StatusId": 566,
    "Status": "ullam",
    "TextId": 828,
    "PublishTo": "1999-02-14T14:58:03.0735383+01:00",
    "PublishFrom": "2004-04-06T14:58:03.0735383+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "850487",
    "ActiveErpLinks": 866,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 61
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2018-04-09T14:58:03.0735383+02:00",
  "Completed": "Completed",
  "ActiveLinks": 258,
  "Links": [
    {
      "EntityName": "Fahey, Bednar and Cole",
      "Id": 841,
      "Description": "Quality-focused heuristic throughput",
      "ExtraInfo": "maiores",
      "LinkId": 85,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 850
        }
      }
    }
  ],
  "AlarmLeadTime": "id",
  "HasAlarm": false,
  "ColorIndex": 542,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "deserunt",
  "LeadTime": "quia",
  "Location": "rerum",
  "RejectCounter": 227,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 244,
    "StartDate": "2017-09-11T14:58:03.0745383+02:00",
    "EndDate": "2018-12-04T14:58:03.0745383+01:00",
    "RecurrenceCounter": 254,
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
      "AssociateId": 83,
      "PersonId": 434,
      "ContactId": 53,
      "EmailId": 610,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 83,
      "PersonId": 434,
      "ContactId": 53,
      "EmailId": 610,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2011-09-17T14:58:03.0745383+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 14,
    "Name": "Bernhard-Klein",
    "PersonId": 269,
    "Rank": 585,
    "Tooltip": "magni",
    "Type": "AnonymousAssociate",
    "GroupIdx": 637,
    "FullName": "Thomas Daniel",
    "FormalName": "Fahey, Trantow and Wisozk",
    "Deleted": false,
    "EjUserId": 985,
    "UserName": "Gottlieb Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 860
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 934,
    "Name": "Frami Group",
    "PersonId": 295,
    "Rank": 245,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 879,
    "FullName": "Paolo Terry",
    "FormalName": "Jacobson-Windler",
    "Deleted": false,
    "EjUserId": 583,
    "UserName": "Labadie Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "recontextualize bleeding-edge vortals"
        },
        "FieldType": "System.Int32",
        "FieldLength": 236
      }
    }
  },
  "Task": {
    "TaskListItemId": 213,
    "Value": "porro",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "est",
    "Deleted": false,
    "IntentId": 889,
    "Rank": 899,
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
        "FieldLength": 967
      }
    }
  },
  "PreferredTZLocation": 468,
  "Sale": {
    "ContactName": "Halvorson, Harber and Bechtelar",
    "SaleDate": "2008-05-07T14:58:03.0755596+02:00",
    "SaleId": 665,
    "Probability": 984,
    "Title": "sed",
    "Amount": 8107.6579999999994,
    "Currency": "quo",
    "ProjectName": "Monahan Group",
    "AssociateFullName": "Mr. Maryse Kutch",
    "Description": "Multi-lateral systemic secured line",
    "Status": "Lost",
    "WeightedAmount": 27576.066,
    "ProjectId": 241,
    "EarningPercent": 23263.682,
    "Earning": 13447.993999999999,
    "ContactId": 878,
    "AssociateId": 50,
    "PersonId": 797,
    "SaleTypeId": 78,
    "SaleTypeName": "Kuhlman LLC",
    "PersonFullName": "Solon Marquardt",
    "Completed": "Completed",
    "ActiveErpLinks": 807,
    "NextDueDate": "2004-09-10T14:58:03.0755596+02:00",
    "Number": "1004788",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 506
      }
    }
  },
  "SuggestedAppointmentId": 344,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "amet",
  "UserDefinedFields": {
    "SuperOffice:1": "Lawrence Turner",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "ut"
  },
  "PublishEventDate": "2004-04-21T14:58:03.0755596+02:00",
  "PublishTo": "2018-11-22T14:58:03.0755596+01:00",
  "PublishFrom": "2019-10-25T14:58:03.0755596+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 498,
      "Visibility": "All",
      "DisplayValue": "ipsa",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 267
        }
      }
    },
    {
      "VisibleId": 498,
      "Visibility": "All",
      "DisplayValue": "ipsa",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 267
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
      "FieldLength": 609
    }
  }
}
```