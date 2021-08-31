---
title: GetAppointmentEntity
id: v1AppointmentAgent_GetAppointmentEntity
---

# GetAppointmentEntity

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
POST /api/v1/Agents/Appointment/GetAppointmentEntity?appointmentEntityId=10
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
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 16,
    "Name": "Borer Inc and Sons",
    "PersonId": 88,
    "Rank": 793,
    "Tooltip": "dolore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 30,
    "FullName": "Fanny Kautzer",
    "FormalName": "Schoen, Lowe and Fay",
    "Deleted": true,
    "EjUserId": 678,
    "UserName": "Dietrich-Donnelly",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 450
      }
    }
  },
  "Contact": {
    "ContactId": 774,
    "Name": "Beahan, McGlynn and Schuppe",
    "OrgNr": "667538",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "unde",
    "DirectPhone": "657-345-3824 x367",
    "AssociateId": 724,
    "CountryId": 194,
    "EmailAddress": "chaz@schumm.com",
    "Kananame": "sit",
    "EmailAddressName": "cole.durgan@wuckert.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ms. Roscoe Spencer",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nam",
    "FullName": "Asa Lemke",
    "IsOwnerContact": false,
    "ActiveErpLinks": 997,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 866
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 628,
    "Name": "Dickens, Bergstrom and Pollich",
    "PersonId": 901,
    "Rank": 868,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 913,
    "FullName": "Bill DuBuque",
    "FormalName": "Goyette Group",
    "Deleted": true,
    "EjUserId": 425,
    "UserName": "Gerhold, Hegmann and Koss",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 565
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 32,
    "Name": "Nitzsche-McGlynn",
    "PersonId": 332,
    "Rank": 992,
    "Tooltip": "culpa",
    "Type": "AnonymousAssociate",
    "GroupIdx": 794,
    "FullName": "Jaycee Hermann",
    "FormalName": "Shields Group",
    "Deleted": true,
    "EjUserId": 256,
    "UserName": "Kuhlman Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 264
      }
    }
  },
  "CreatedDate": "2001-03-01T14:58:03.118561+01:00",
  "AppointmentId": 494,
  "Description": "Phased directional instruction set",
  "StartDate": "2016-11-09T14:58:03.118561+01:00",
  "EndDate": "1994-08-09T14:58:03.118561+02:00",
  "InvitedPerson": {
    "Position": "suscipit",
    "PersonId": 837,
    "Mrmrs": "corporis",
    "Firstname": "Dante",
    "Lastname": "McClure",
    "MiddleName": "Lang-Mueller",
    "Title": "corrupti",
    "Description": "Extended needs-based application",
    "Email": "hilma@kihnrosenbaum.biz",
    "FullName": "Marisol Schmeler",
    "DirectPhone": "1-425-482-1558 x03557",
    "FormalName": "Zemlak, Wuckert and Gerhold",
    "CountryId": 639,
    "ContactId": 974,
    "ContactName": "Marquardt, Parker and Bartell",
    "Retired": 178,
    "Rank": 838,
    "ActiveInterests": 69,
    "ContactDepartment": "",
    "ContactCountryId": 245,
    "ContactOrgNr": "1420590",
    "FaxPhone": "278-874-2376",
    "MobilePhone": "(007)750-6631 x8568",
    "ContactPhone": "(741)122-3327 x861",
    "AssociateName": "Wehner-Feeney",
    "AssociateId": 101,
    "UsePersonAddress": true,
    "ContactFax": "quidem",
    "Kanafname": "quia",
    "Kanalname": "esse",
    "Post1": "quos",
    "Post2": "incidunt",
    "Post3": "vel",
    "EmailName": "camilla@hirthe.info",
    "ContactFullName": "Margot Hudson",
    "ActiveErpLinks": 463,
    "TicketPriorityId": 683,
    "SupportLanguageId": 664,
    "SupportAssociateId": 612,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 604
      }
    }
  },
  "Person": {
    "Position": "corrupti",
    "PersonId": 930,
    "Mrmrs": "nihil",
    "Firstname": "Sarina",
    "Lastname": "Gislason",
    "MiddleName": "Kuphal-Kovacek",
    "Title": "et",
    "Description": "Streamlined cohesive budgetary management",
    "Email": "samanta_roberts@rutherfordsanford.co.uk",
    "FullName": "Hermann Sauer",
    "DirectPhone": "826-858-7668 x472",
    "FormalName": "Tremblay, Dickens and Homenick",
    "CountryId": 577,
    "ContactId": 811,
    "ContactName": "Gerlach-Littel",
    "Retired": 159,
    "Rank": 747,
    "ActiveInterests": 515,
    "ContactDepartment": "",
    "ContactCountryId": 835,
    "ContactOrgNr": "1321779",
    "FaxPhone": "835-421-7408 x833",
    "MobilePhone": "364.675.6351 x131",
    "ContactPhone": "350.023.8017 x46374",
    "AssociateName": "Morissette, Schumm and Crist",
    "AssociateId": 604,
    "UsePersonAddress": true,
    "ContactFax": "unde",
    "Kanafname": "hic",
    "Kanalname": "impedit",
    "Post1": "consequatur",
    "Post2": "nostrum",
    "Post3": "doloribus",
    "EmailName": "briana.stanton@dare.com",
    "ContactFullName": "Lorenz Erdman",
    "ActiveErpLinks": 141,
    "TicketPriorityId": 192,
    "SupportLanguageId": 863,
    "SupportAssociateId": 844,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 254
      }
    }
  },
  "MotherId": 566,
  "Priority": {
    "Id": 557,
    "Value": "aut",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 296
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 541,
    "Name": "Rohan-Marquardt",
    "Description": "Reactive bifurcated adapter",
    "URL": "http://www.example.com/",
    "Type": "rerum",
    "AssociateId": 102,
    "AssociateFullName": "Mr. Chaim Volkman",
    "TypeId": 871,
    "Updated": "1999-06-23T14:58:03.1215728+02:00",
    "StatusId": 715,
    "Status": "omnis",
    "TextId": 65,
    "PublishTo": "1999-04-19T14:58:03.1215728+02:00",
    "PublishFrom": "1995-09-24T14:58:03.1215728+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "694013",
    "ActiveErpLinks": 488,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 815
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2015-10-11T14:58:03.1215728+02:00",
  "Completed": "Completed",
  "ActiveLinks": 854,
  "Links": [
    {
      "EntityName": "Moen LLC",
      "Id": 618,
      "Description": "De-engineered next generation parallelism",
      "ExtraInfo": "cumque",
      "LinkId": 154,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    }
  ],
  "AlarmLeadTime": "ullam",
  "HasAlarm": false,
  "ColorIndex": 784,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "deserunt",
  "LeadTime": "voluptas",
  "Location": "numquam",
  "RejectCounter": 851,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 960,
    "StartDate": "1998-12-18T14:58:03.1225723+01:00",
    "EndDate": "2003-03-09T14:58:03.1225723+01:00",
    "RecurrenceCounter": 804,
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
      "AssociateId": 265,
      "PersonId": 422,
      "ContactId": 99,
      "EmailId": 687,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 265,
      "PersonId": 422,
      "ContactId": 99,
      "EmailId": 687,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1997-08-19T14:58:03.1225723+02:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 14,
    "Name": "Raynor LLC",
    "PersonId": 166,
    "Rank": 644,
    "Tooltip": "nihil",
    "Type": "AnonymousAssociate",
    "GroupIdx": 503,
    "FullName": "Aniya Hahn",
    "FormalName": "Stehr, Luettgen and Veum",
    "Deleted": false,
    "EjUserId": 479,
    "UserName": "Collier, Corwin and Hills",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 98
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 554,
    "Name": "Wolf, Heathcote and Koch",
    "PersonId": 449,
    "Rank": 412,
    "Tooltip": "placeat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 484,
    "FullName": "Alexandrine Donnelly",
    "FormalName": "Hudson-Halvorson",
    "Deleted": false,
    "EjUserId": 358,
    "UserName": "Ritchie, Douglas and Satterfield",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 136
      }
    }
  },
  "Task": {
    "TaskListItemId": 761,
    "Value": "minus",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "perspiciatis",
    "Deleted": true,
    "IntentId": 813,
    "Rank": 958,
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
          "Reason": "strategize sticky content"
        },
        "FieldType": "System.String",
        "FieldLength": 599
      }
    }
  },
  "PreferredTZLocation": 762,
  "Sale": {
    "ContactName": "Franecki LLC",
    "SaleDate": "2000-09-01T14:58:03.123538+02:00",
    "SaleId": 359,
    "Probability": 352,
    "Title": "earum",
    "Amount": 30349.656,
    "Currency": "ipsam",
    "ProjectName": "Hayes-Auer",
    "AssociateFullName": "Shaylee Bechtelar",
    "Description": "Multi-tiered bifurcated parallelism",
    "Status": "Lost",
    "WeightedAmount": 5048.874,
    "ProjectId": 440,
    "EarningPercent": 23160.26,
    "Earning": 27654.415999999997,
    "ContactId": 996,
    "AssociateId": 98,
    "PersonId": 675,
    "SaleTypeId": 604,
    "SaleTypeName": "Mayert LLC",
    "PersonFullName": "Bailee Parisian V",
    "Completed": "Completed",
    "ActiveErpLinks": 848,
    "NextDueDate": "2016-07-08T14:58:03.123538+02:00",
    "Number": "1397945",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 305
      }
    }
  },
  "SuggestedAppointmentId": 253,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "perspiciatis",
  "UserDefinedFields": {
    "SuperOffice:1": "Savion Hane",
    "SuperOffice:2": "Shaylee Hettinger"
  },
  "ExtraFields": {
    "ExtraFields1": "dignissimos",
    "ExtraFields2": "quibusdam"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2012-06-03T14:58:03.123538+02:00",
  "PublishTo": "1994-06-02T14:58:03.123538+02:00",
  "PublishFrom": "1999-07-17T14:58:03.123538+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 299,
      "Visibility": "All",
      "DisplayValue": "quam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 633
        }
      }
    },
    {
      "VisibleId": 299,
      "Visibility": "All",
      "DisplayValue": "quam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 633
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
      "FieldLength": 621
    }
  }
}
```