---
title: GET Appointment/default
id: v1AppointmentEntity_DefaultAppointmentEntity
---

# GET Appointment/default

```http
GET /api/v1/Appointment/default
```

Set default values into a new AppointmentEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Appointment agent service CreateDefaultAppointmentEntity.






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
GET /api/v1/Appointment/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 30 May 1998 09:40:58 G5T

{
  "Associate": {
    "AssociateId": 782,
    "Name": "Mraz-Wisoky",
    "PersonId": 730,
    "Rank": 404,
    "Tooltip": "vel",
    "Type": "AnonymousAssociate",
    "GroupIdx": 912,
    "FullName": "Dr. Aryanna Ratke",
    "FormalName": "Jast, O'Kon and Baumbach",
    "Deleted": true,
    "EjUserId": 499,
    "UserName": "Luettgen, Rippin and Lehner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 237
      }
    }
  },
  "Contact": {
    "ContactId": 900,
    "Name": "Wuckert-Bayer",
    "OrgNr": "884489",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "numquam",
    "DirectPhone": "1-470-271-6476",
    "AssociateId": 408,
    "CountryId": 261,
    "EmailAddress": "jimmy.ohara@ernser.com",
    "Kananame": "omnis",
    "EmailAddressName": "tavares_waters@glover.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Cleo Lesch",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "rerum",
    "FullName": "Jaiden Rohan",
    "IsOwnerContact": false,
    "ActiveErpLinks": 834,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "enable transparent systems"
        },
        "FieldType": "System.String",
        "FieldLength": 479
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 861,
    "Name": "Kling, Yost and Schinner",
    "PersonId": 131,
    "Rank": 874,
    "Tooltip": "corporis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 326,
    "FullName": "Mrs. Madison Denesik",
    "FormalName": "Ebert Inc and Sons",
    "Deleted": true,
    "EjUserId": 418,
    "UserName": "Littel, Franecki and Jerde",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 985
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 695,
    "Name": "Bruen-Goodwin",
    "PersonId": 157,
    "Rank": 454,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 522,
    "FullName": "Anjali Ondricka",
    "FormalName": "Harvey, Fritsch and Collins",
    "Deleted": false,
    "EjUserId": 350,
    "UserName": "Block Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 214
      }
    }
  },
  "CreatedDate": "2007-03-27T09:40:58.4983475+02:00",
  "AppointmentId": 315,
  "Description": "Profound 5th generation instruction set",
  "StartDate": "2005-08-20T09:40:58.4983475+02:00",
  "EndDate": "1997-04-09T09:40:58.4983475+02:00",
  "InvitedPerson": {
    "Position": "aperiam",
    "PersonId": 886,
    "Mrmrs": "ab",
    "Firstname": "Santino",
    "Lastname": "Ryan",
    "MiddleName": "Schultz-Schulist",
    "Title": "non",
    "Description": "Vision-oriented optimizing capacity",
    "Email": "zita@rodriguez.co.uk",
    "FullName": "Miracle Kulas",
    "DirectPhone": "688.762.0816",
    "FormalName": "Kirlin, Effertz and Bogisich",
    "CountryId": 858,
    "ContactId": 574,
    "ContactName": "Gibson, Cronin and Feil",
    "Retired": 231,
    "Rank": 577,
    "ActiveInterests": 462,
    "ContactDepartment": "",
    "ContactCountryId": 107,
    "ContactOrgNr": "1420496",
    "FaxPhone": "678.236.3875 x0565",
    "MobilePhone": "836-718-2355 x21145",
    "ContactPhone": "042.237.4046 x8601",
    "AssociateName": "Lubowitz-Ortiz",
    "AssociateId": 768,
    "UsePersonAddress": true,
    "ContactFax": "aliquid",
    "Kanafname": "in",
    "Kanalname": "iure",
    "Post1": "nisi",
    "Post2": "magni",
    "Post3": "modi",
    "EmailName": "deja@batz.us",
    "ContactFullName": "Christina Waters",
    "ActiveErpLinks": 694,
    "TicketPriorityId": 263,
    "SupportLanguageId": 453,
    "SupportAssociateId": 962,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 962
      }
    }
  },
  "Person": {
    "Position": "qui",
    "PersonId": 360,
    "Mrmrs": "fuga",
    "Firstname": "Harvey",
    "Lastname": "Dicki",
    "MiddleName": "Herzog, Trantow and Wisozk",
    "Title": "nihil",
    "Description": "Upgradable well-modulated instruction set",
    "Email": "jeramy@casper.co.uk",
    "FullName": "Felicia Gusikowski",
    "DirectPhone": "551-871-7730",
    "FormalName": "Kilback, Mosciski and Johnson",
    "CountryId": 849,
    "ContactId": 152,
    "ContactName": "Hoppe LLC",
    "Retired": 737,
    "Rank": 228,
    "ActiveInterests": 763,
    "ContactDepartment": "",
    "ContactCountryId": 936,
    "ContactOrgNr": "551622",
    "FaxPhone": "335-006-5657",
    "MobilePhone": "075-847-5077 x230",
    "ContactPhone": "857-821-3614",
    "AssociateName": "Skiles-Beahan",
    "AssociateId": 858,
    "UsePersonAddress": false,
    "ContactFax": "nam",
    "Kanafname": "ea",
    "Kanalname": "enim",
    "Post1": "voluptatem",
    "Post2": "quaerat",
    "Post3": "veniam",
    "EmailName": "cole@blick.ca",
    "ContactFullName": "Mr. Brennon Schaefer",
    "ActiveErpLinks": 863,
    "TicketPriorityId": 277,
    "SupportLanguageId": 605,
    "SupportAssociateId": 2,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 548
      }
    }
  },
  "MotherId": 670,
  "Priority": {
    "Id": 809,
    "Value": "quis",
    "Tooltip": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 697
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 416,
    "Name": "Nienow-Stracke",
    "Description": "Triple-buffered 24 hour intranet",
    "URL": "http://www.example.com/",
    "Type": "iusto",
    "AssociateId": 330,
    "AssociateFullName": "Yessenia Rolfson",
    "TypeId": 619,
    "Updated": "2014-10-21T09:40:58.5033556+02:00",
    "StatusId": 804,
    "Status": "facere",
    "TextId": 643,
    "PublishTo": "1994-07-04T09:40:58.5033556+02:00",
    "PublishFrom": "1994-09-15T09:40:58.5033556+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1355804",
    "ActiveErpLinks": 638,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "harness holistic paradigms"
        },
        "FieldType": "System.Int32",
        "FieldLength": 182
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "1998-05-30T09:40:58.5033556+02:00",
  "Completed": "Completed",
  "ActiveLinks": 297,
  "Links": [
    {
      "EntityName": "Jast Group",
      "Id": 1000,
      "Description": "Secured multi-tasking model",
      "ExtraInfo": "in",
      "LinkId": 819,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 382
        }
      }
    }
  ],
  "AlarmLeadTime": "enim",
  "HasAlarm": false,
  "ColorIndex": 721,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "quae",
  "LeadTime": "quam",
  "Location": "consectetur",
  "RejectCounter": 26,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 318,
    "StartDate": "2018-10-16T09:40:58.5043436+02:00",
    "EndDate": "2004-01-04T09:40:58.5043436+01:00",
    "RecurrenceCounter": 919,
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
      "AssociateId": 579,
      "PersonId": 59,
      "ContactId": 645,
      "EmailId": 186,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 579,
      "PersonId": 59,
      "ContactId": 645,
      "EmailId": 186,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2009-02-19T09:40:58.5043436+01:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 735,
    "Name": "Bashirian-Ritchie",
    "PersonId": 438,
    "Rank": 643,
    "Tooltip": "vel",
    "Type": "AnonymousAssociate",
    "GroupIdx": 178,
    "FullName": "Drake Cremin V",
    "FormalName": "Gleichner-Turcotte",
    "Deleted": true,
    "EjUserId": 190,
    "UserName": "Runte Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 102
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 537,
    "Name": "Turcotte Inc and Sons",
    "PersonId": 858,
    "Rank": 411,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 434,
    "FullName": "Koby O'Hara",
    "FormalName": "Howe, Larkin and Hills",
    "Deleted": true,
    "EjUserId": 397,
    "UserName": "Kuhlman, McDermott and Olson",
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
  "Task": {
    "TaskListItemId": 316,
    "Value": "illo",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "suscipit",
    "Deleted": true,
    "IntentId": 533,
    "Rank": 481,
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
        "FieldLength": 325
      }
    }
  },
  "PreferredTZLocation": 659,
  "Sale": {
    "ContactName": "Robel Inc and Sons",
    "SaleDate": "2012-10-22T09:40:58.5053663+02:00",
    "SaleId": 403,
    "Probability": 54,
    "Title": "est",
    "Amount": 29794.938,
    "Currency": "minus",
    "ProjectName": "Wolf-Sanford",
    "AssociateFullName": "Lucius Jacobson",
    "Description": "Profit-focused optimizing analyzer",
    "Status": "Lost",
    "WeightedAmount": 27604.272,
    "ProjectId": 857,
    "EarningPercent": 1215.992,
    "Earning": 30732.003999999997,
    "ContactId": 83,
    "AssociateId": 624,
    "PersonId": 483,
    "SaleTypeId": 700,
    "SaleTypeName": "Kirlin-Feest",
    "PersonFullName": "Damien Kautzer",
    "Completed": "Completed",
    "ActiveErpLinks": 468,
    "NextDueDate": "2000-09-30T09:40:58.5053663+02:00",
    "Number": "923854",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 193
      }
    }
  },
  "SuggestedAppointmentId": 748,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "quidem",
  "UserDefinedFields": {
    "SuperOffice:1": "Chyna Gleichner",
    "SuperOffice:2": "687653818"
  },
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "tenetur",
    "CustomFields2": "molestias"
  },
  "PublishEventDate": "1996-12-02T09:40:58.5063424+01:00",
  "PublishTo": "2007-08-08T09:40:58.5063424+02:00",
  "PublishFrom": "2015-05-24T09:40:58.5063424+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 350,
      "Visibility": "All",
      "DisplayValue": "expedita",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 591
        }
      }
    },
    {
      "VisibleId": 350,
      "Visibility": "All",
      "DisplayValue": "expedita",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 591
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
        "Reason": "scale extensible applications"
      },
      "FieldType": "System.String",
      "FieldLength": 708
    }
  }
}
```