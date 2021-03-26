---
title: POST Agents/Appointment/Move
id: v1AppointmentAgent_Move
---

# POST Agents/Appointment/Move

```http
POST /api/v1/Agents/Appointment/Move
```

Moving a booking to another start time.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/Move?$select=name,department,category/id
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

AppointmentId, NewStartTime, UpdateMode 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentId | int32 |  |
| NewStartTime | date-time |  |
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
POST /api/v1/Agents/Appointment/Move
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 184,
  "NewStartTime": "2007-11-07T16:48:28.5984492+01:00",
  "UpdateMode": "OnlyThis"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 211,
    "Name": "Hills Group",
    "PersonId": 188,
    "Rank": 375,
    "Tooltip": "odit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 322,
    "FullName": "Lewis Cole",
    "FormalName": "Kiehn, Raynor and Leannon",
    "Deleted": false,
    "EjUserId": 795,
    "UserName": "Botsford-Feil",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 128
      }
    }
  },
  "Contact": {
    "ContactId": 644,
    "Name": "Robel, Balistreri and Harber",
    "OrgNr": "809222",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "sequi",
    "DirectPhone": "017.405.5477 x523",
    "AssociateId": 780,
    "CountryId": 241,
    "EmailAddress": "aurelio_witting@gutmann.biz",
    "Kananame": "commodi",
    "EmailAddressName": "yessenia_koelpin@waters.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Yoshiko West",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "qui",
    "FullName": "Kurt Dach",
    "IsOwnerContact": true,
    "ActiveErpLinks": 60,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 92
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 122,
    "Name": "Tremblay Group",
    "PersonId": 246,
    "Rank": 264,
    "Tooltip": "illo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 181,
    "FullName": "Avis McLaughlin",
    "FormalName": "Huels, Cruickshank and O'Hara",
    "Deleted": false,
    "EjUserId": 282,
    "UserName": "Lowe LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 347
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 722,
    "Name": "Schmitt, Osinski and Schultz",
    "PersonId": 57,
    "Rank": 312,
    "Tooltip": "voluptatum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 812,
    "FullName": "Alvera Towne",
    "FormalName": "Nader-VonRueden",
    "Deleted": false,
    "EjUserId": 316,
    "UserName": "Witting-Price",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "synergize real-time web-readiness"
        },
        "FieldType": "System.String",
        "FieldLength": 541
      }
    }
  },
  "CreatedDate": "2005-06-11T16:48:28.6074187+02:00",
  "AppointmentId": 911,
  "Description": "Innovative maximized superstructure",
  "StartDate": "2006-05-26T16:48:28.6074187+02:00",
  "EndDate": "2013-06-30T16:48:28.6074187+02:00",
  "InvitedPerson": {
    "Position": "in",
    "PersonId": 365,
    "Mrmrs": "repellendus",
    "Firstname": "Matilda",
    "Lastname": "Jast",
    "MiddleName": "Herman, Prosacco and Turner",
    "Title": "eos",
    "Description": "Universal modular function",
    "Email": "stevie@aufderharankunding.biz",
    "FullName": "Dillan Balistreri",
    "DirectPhone": "1-384-331-3134",
    "FormalName": "Olson-Price",
    "CountryId": 281,
    "ContactId": 292,
    "ContactName": "Robel, Prohaska and Oberbrunner",
    "Retired": 638,
    "Rank": 101,
    "ActiveInterests": 623,
    "ContactDepartment": "",
    "ContactCountryId": 528,
    "ContactOrgNr": "875755",
    "FaxPhone": "1-424-105-3244 x836",
    "MobilePhone": "640-841-0628",
    "ContactPhone": "532.688.2657 x773",
    "AssociateName": "Bashirian Inc and Sons",
    "AssociateId": 948,
    "UsePersonAddress": false,
    "ContactFax": "vel",
    "Kanafname": "necessitatibus",
    "Kanalname": "autem",
    "Post1": "nulla",
    "Post2": "et",
    "Post3": "et",
    "EmailName": "alia_mante@feildickens.ca",
    "ContactFullName": "Justina Pfannerstill",
    "ActiveErpLinks": 682,
    "TicketPriorityId": 139,
    "SupportLanguageId": 223,
    "SupportAssociateId": 852,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 500
      }
    }
  },
  "Person": {
    "Position": "ratione",
    "PersonId": 953,
    "Mrmrs": "sequi",
    "Firstname": "Cortez",
    "Lastname": "Reinger",
    "MiddleName": "Swaniawski, O'Hara and Bradtke",
    "Title": "officia",
    "Description": "Digitized coherent algorithm",
    "Email": "destiny_senger@bernier.info",
    "FullName": "Marge Rolfson III",
    "DirectPhone": "1-317-142-7033 x632",
    "FormalName": "Kohler, Brekke and Boyle",
    "CountryId": 500,
    "ContactId": 949,
    "ContactName": "Armstrong LLC",
    "Retired": 901,
    "Rank": 855,
    "ActiveInterests": 701,
    "ContactDepartment": "",
    "ContactCountryId": 797,
    "ContactOrgNr": "933182",
    "FaxPhone": "483-328-4358",
    "MobilePhone": "674.036.3650",
    "ContactPhone": "714.820.4640",
    "AssociateName": "Jacobi, Schuppe and Sanford",
    "AssociateId": 10,
    "UsePersonAddress": false,
    "ContactFax": "dolores",
    "Kanafname": "distinctio",
    "Kanalname": "ipsa",
    "Post1": "enim",
    "Post2": "odio",
    "Post3": "laboriosam",
    "EmailName": "geovany@lockman.com",
    "ContactFullName": "Rocky Hane DDS",
    "ActiveErpLinks": 539,
    "TicketPriorityId": 985,
    "SupportLanguageId": 974,
    "SupportAssociateId": 419,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 643
      }
    }
  },
  "MotherId": 293,
  "Priority": {
    "Id": 355,
    "Value": "quod",
    "Tooltip": "sunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 190
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 339,
    "Name": "Fay, Buckridge and Little",
    "Description": "Configurable attitude-oriented forecast",
    "URL": "http://www.example.com/",
    "Type": "praesentium",
    "AssociateId": 609,
    "AssociateFullName": "Bridget Heathcote",
    "TypeId": 757,
    "Updated": "2020-10-01T16:48:28.6104477+02:00",
    "StatusId": 679,
    "Status": "fuga",
    "TextId": 902,
    "PublishTo": "2009-08-17T16:48:28.6104477+02:00",
    "PublishFrom": "2016-07-22T16:48:28.6104477+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1478323",
    "ActiveErpLinks": 341,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 624
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2010-01-16T16:48:28.6104477+01:00",
  "Completed": "Completed",
  "ActiveLinks": 601,
  "Links": [
    {
      "EntityName": "White, Haag and Stroman",
      "Id": 427,
      "Description": "Fully-configurable zero defect installation",
      "ExtraInfo": "sit",
      "LinkId": 686,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 495
        }
      }
    }
  ],
  "AlarmLeadTime": "eligendi",
  "HasAlarm": true,
  "ColorIndex": 139,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "asperiores",
  "LeadTime": "magni",
  "Location": "laudantium",
  "RejectCounter": 366,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 785,
    "StartDate": "2009-11-19T16:48:28.6104477+01:00",
    "EndDate": "2015-10-19T16:48:28.6104477+02:00",
    "RecurrenceCounter": 704,
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
      "AssociateId": 712,
      "PersonId": 811,
      "ContactId": 461,
      "EmailId": 315,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 712,
      "PersonId": 811,
      "ContactId": 461,
      "EmailId": 315,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2010-06-20T16:48:28.6104477+02:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 246,
    "Name": "Howell Group",
    "PersonId": 612,
    "Rank": 273,
    "Tooltip": "repellendus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 954,
    "FullName": "Myrtice Emmerich",
    "FormalName": "Mraz, Morissette and Flatley",
    "Deleted": false,
    "EjUserId": 487,
    "UserName": "Brekke, Bauch and Pfannerstill",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 825
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 375,
    "Name": "Bailey, Hoeger and Ward",
    "PersonId": 738,
    "Rank": 515,
    "Tooltip": "fugit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 855,
    "FullName": "Tillman Waters",
    "FormalName": "Lemke, Stehr and Connelly",
    "Deleted": true,
    "EjUserId": 243,
    "UserName": "Greenholt-Gutmann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 505
      }
    }
  },
  "Task": {
    "TaskListItemId": 588,
    "Value": "error",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "ducimus",
    "Deleted": true,
    "IntentId": 896,
    "Rank": 799,
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
          "Reason": "disintermediate compelling architectures"
        },
        "FieldType": "System.String",
        "FieldLength": 359
      }
    }
  },
  "PreferredTZLocation": 509,
  "Sale": {
    "ContactName": "Erdman, Schulist and Renner",
    "SaleDate": "2011-05-28T16:48:28.6114448+02:00",
    "SaleId": 81,
    "Probability": 588,
    "Title": "sed",
    "Amount": 18976.37,
    "Currency": "molestiae",
    "ProjectName": "Lowe LLC",
    "AssociateFullName": "Catalina Kreiger",
    "Description": "Operative systematic policy",
    "Status": "Lost",
    "WeightedAmount": 15682.536,
    "ProjectId": 69,
    "EarningPercent": 16848.384,
    "Earning": 26178.302,
    "ContactId": 790,
    "AssociateId": 189,
    "PersonId": 509,
    "SaleTypeId": 882,
    "SaleTypeName": "Littel, Farrell and Powlowski",
    "PersonFullName": "Rae Feeney",
    "Completed": "Completed",
    "ActiveErpLinks": 90,
    "NextDueDate": "2012-07-19T16:48:28.6124451+02:00",
    "Number": "979120",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 779
      }
    }
  },
  "SuggestedAppointmentId": 616,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "quibusdam",
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "adipisci",
    "ExtraFields2": "nostrum"
  },
  "CustomFields": {
    "CustomFields1": "dolorum",
    "CustomFields2": "voluptas"
  },
  "PublishEventDate": "2002-06-06T16:48:28.6124451+02:00",
  "PublishTo": "2002-02-23T16:48:28.6124451+01:00",
  "PublishFrom": "2012-06-24T16:48:28.6124451+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 665,
      "Visibility": "All",
      "DisplayValue": "reprehenderit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 249
        }
      }
    },
    {
      "VisibleId": 665,
      "Visibility": "All",
      "DisplayValue": "reprehenderit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 249
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
      "FieldLength": 542
    }
  }
}
```