---
title: AssignTo
id: v1AppointmentAgent_AssignTo
---

# AssignTo

```http
POST /api/v1/Agents/Appointment/AssignTo
```

Assigning an appointment to another person.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/AssignTo?$select=name,department,category/id
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

AppointmentId, Participant, UpdateMode 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentId | int32 |  |
| Participant |  |  |
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
POST /api/v1/Agents/Appointment/AssignTo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 415,
  "Participant": {
    "AssociateId": 860,
    "PersonId": 769,
    "ContactId": 674,
    "EmailId": 307,
    "SendEmail": false,
    "InvitationStatus": "Accepted"
  },
  "UpdateMode": "OnlyThis"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 902,
    "Name": "Abshire, Mills and Strosin",
    "PersonId": 952,
    "Rank": 636,
    "Tooltip": "reprehenderit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 211,
    "FullName": "Alaina Bayer",
    "FormalName": "Nolan-Becker",
    "Deleted": true,
    "EjUserId": 433,
    "UserName": "Schuster, Gleichner and Gerhold",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 881
      }
    }
  },
  "Contact": {
    "ContactId": 539,
    "Name": "Lockman-Kling",
    "OrgNr": "592084",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "aut",
    "DirectPhone": "(320)040-2831 x04638",
    "AssociateId": 588,
    "CountryId": 197,
    "EmailAddress": "london.boehm@feeney.co.uk",
    "Kananame": "nulla",
    "EmailAddressName": "baby@harrishaag.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Michael Vandervort",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quidem",
    "FullName": "Dawn Bailey",
    "IsOwnerContact": true,
    "ActiveErpLinks": 46,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 716
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 168,
    "Name": "Lebsack-Graham",
    "PersonId": 897,
    "Rank": 109,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 26,
    "FullName": "Yazmin Douglas",
    "FormalName": "Bauch Group",
    "Deleted": false,
    "EjUserId": 815,
    "UserName": "Ward, Von and Orn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 472
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 393,
    "Name": "Bode-D'Amore",
    "PersonId": 745,
    "Rank": 283,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 636,
    "FullName": "Audra Kerluke",
    "FormalName": "Davis Inc and Sons",
    "Deleted": false,
    "EjUserId": 888,
    "UserName": "Oberbrunner-Carter",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 80
      }
    }
  },
  "CreatedDate": "2003-03-03T14:58:03.2115681+01:00",
  "AppointmentId": 7,
  "Description": "Configurable responsive initiative",
  "StartDate": "2006-01-01T14:58:03.2115681+01:00",
  "EndDate": "2013-01-20T14:58:03.2115681+01:00",
  "InvitedPerson": {
    "Position": "nihil",
    "PersonId": 717,
    "Mrmrs": "eligendi",
    "Firstname": "Vella",
    "Lastname": "Gottlieb",
    "MiddleName": "Walker, Mosciski and Lakin",
    "Title": "dolore",
    "Description": "Synergized exuding leverage",
    "Email": "stephen.brakus@veum.uk",
    "FullName": "August Bernhard",
    "DirectPhone": "(871)023-0422",
    "FormalName": "Moen-Pouros",
    "CountryId": 724,
    "ContactId": 501,
    "ContactName": "Mayer-Waters",
    "Retired": 206,
    "Rank": 301,
    "ActiveInterests": 424,
    "ContactDepartment": "",
    "ContactCountryId": 897,
    "ContactOrgNr": "891383",
    "FaxPhone": "(703)477-1387 x238",
    "MobilePhone": "1-304-534-1177 x887",
    "ContactPhone": "758.656.4807 x4632",
    "AssociateName": "O'Reilly, Emard and Fay",
    "AssociateId": 946,
    "UsePersonAddress": false,
    "ContactFax": "quia",
    "Kanafname": "voluptatem",
    "Kanalname": "aut",
    "Post1": "fuga",
    "Post2": "qui",
    "Post3": "vel",
    "EmailName": "imelda_heaney@marks.name",
    "ContactFullName": "Zackary Purdy",
    "ActiveErpLinks": 43,
    "TicketPriorityId": 668,
    "SupportLanguageId": 103,
    "SupportAssociateId": 858,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 673
      }
    }
  },
  "Person": {
    "Position": "consectetur",
    "PersonId": 835,
    "Mrmrs": "voluptas",
    "Firstname": "Kianna",
    "Lastname": "Satterfield",
    "MiddleName": "Hoppe-Walter",
    "Title": "occaecati",
    "Description": "Ergonomic object-oriented projection",
    "Email": "maud.reichel@krajcikraynor.biz",
    "FullName": "Ernesto Considine",
    "DirectPhone": "(274)100-7775",
    "FormalName": "Mayert LLC",
    "CountryId": 793,
    "ContactId": 139,
    "ContactName": "Barrows, Quitzon and Koss",
    "Retired": 462,
    "Rank": 320,
    "ActiveInterests": 866,
    "ContactDepartment": "orchestrate clicks-and-mortar vortals",
    "ContactCountryId": 936,
    "ContactOrgNr": "503205",
    "FaxPhone": "(215)246-7664 x380",
    "MobilePhone": "1-573-737-6776",
    "ContactPhone": "463.150.6422 x78023",
    "AssociateName": "Gulgowski, Bartoletti and Will",
    "AssociateId": 96,
    "UsePersonAddress": true,
    "ContactFax": "consequatur",
    "Kanafname": "neque",
    "Kanalname": "vitae",
    "Post1": "et",
    "Post2": "cupiditate",
    "Post3": "recusandae",
    "EmailName": "aidan@kuvalis.co.uk",
    "ContactFullName": "Marilie Koepp",
    "ActiveErpLinks": 696,
    "TicketPriorityId": 57,
    "SupportLanguageId": 813,
    "SupportAssociateId": 883,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 906
      }
    }
  },
  "MotherId": 411,
  "Priority": {
    "Id": 767,
    "Value": "officia",
    "Tooltip": "id",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 461
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 836,
    "Name": "McClure Group",
    "Description": "Networked 3rd generation policy",
    "URL": "http://www.example.com/",
    "Type": "autem",
    "AssociateId": 470,
    "AssociateFullName": "Tomas Langosh",
    "TypeId": 416,
    "Updated": "1996-08-06T14:58:03.2135679+02:00",
    "StatusId": 150,
    "Status": "optio",
    "TextId": 281,
    "PublishTo": "1998-09-07T14:58:03.2135679+02:00",
    "PublishFrom": "2006-06-17T14:58:03.2135679+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "862621",
    "ActiveErpLinks": 761,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 414
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2003-09-15T14:58:03.2135679+02:00",
  "Completed": "Completed",
  "ActiveLinks": 644,
  "Links": [
    {
      "EntityName": "Sporer-Johnson",
      "Id": 114,
      "Description": "Focused dynamic solution",
      "ExtraInfo": "eius",
      "LinkId": 571,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 390
        }
      }
    }
  ],
  "AlarmLeadTime": "distinctio",
  "HasAlarm": true,
  "ColorIndex": 159,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "iusto",
  "LeadTime": "sint",
  "Location": "alias",
  "RejectCounter": 60,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 974,
    "StartDate": "1997-03-09T14:58:03.21457+01:00",
    "EndDate": "2014-05-09T14:58:03.21457+02:00",
    "RecurrenceCounter": 814,
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
      "AssociateId": 570,
      "PersonId": 495,
      "ContactId": 38,
      "EmailId": 461,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 570,
      "PersonId": 495,
      "ContactId": 38,
      "EmailId": 461,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2019-03-06T14:58:03.21457+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 926,
    "Name": "Cummings Inc and Sons",
    "PersonId": 957,
    "Rank": 952,
    "Tooltip": "maxime",
    "Type": "AnonymousAssociate",
    "GroupIdx": 19,
    "FullName": "Susie Streich",
    "FormalName": "Funk Inc and Sons",
    "Deleted": false,
    "EjUserId": 327,
    "UserName": "Mueller LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 169
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 422,
    "Name": "Runte, Harber and Hamill",
    "PersonId": 101,
    "Rank": 591,
    "Tooltip": "iste",
    "Type": "AnonymousAssociate",
    "GroupIdx": 9,
    "FullName": "Savanna Wehner",
    "FormalName": "Hackett LLC",
    "Deleted": true,
    "EjUserId": 45,
    "UserName": "McGlynn-Dach",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "incentivize bricks-and-clicks synergies"
        },
        "FieldType": "System.Int32",
        "FieldLength": 469
      }
    }
  },
  "Task": {
    "TaskListItemId": 310,
    "Value": "est",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "aliquam",
    "Deleted": false,
    "IntentId": 418,
    "Rank": 704,
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
        "FieldType": "System.String",
        "FieldLength": 389
      }
    }
  },
  "PreferredTZLocation": 988,
  "Sale": {
    "ContactName": "Stracke Inc and Sons",
    "SaleDate": "2013-11-18T14:58:03.21457+01:00",
    "SaleId": 959,
    "Probability": 581,
    "Title": "provident",
    "Amount": 20038.796,
    "Currency": "officia",
    "ProjectName": "Lueilwitz Group",
    "AssociateFullName": "Maximillia Grady DVM",
    "Description": "Upgradable foreground application",
    "Status": "Lost",
    "WeightedAmount": 3181.0099999999998,
    "ProjectId": 565,
    "EarningPercent": 3930.036,
    "Earning": 10053.872,
    "ContactId": 109,
    "AssociateId": 861,
    "PersonId": 950,
    "SaleTypeId": 884,
    "SaleTypeName": "Batz-Mraz",
    "PersonFullName": "Mr. Ines Boyer",
    "Completed": "Completed",
    "ActiveErpLinks": 604,
    "NextDueDate": "2011-12-28T14:58:03.2155679+01:00",
    "Number": "1008025",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 830
      }
    }
  },
  "SuggestedAppointmentId": 775,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "sapiente",
  "UserDefinedFields": {
    "SuperOffice:1": "Theron Rippin",
    "SuperOffice:2": "Louisa Kovacek III"
  },
  "ExtraFields": {
    "ExtraFields1": "possimus",
    "ExtraFields2": "unde"
  },
  "CustomFields": {
    "CustomFields1": "molestias",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2005-02-23T14:58:03.2155679+01:00",
  "PublishTo": "1998-07-09T14:58:03.2155679+02:00",
  "PublishFrom": "2012-01-12T14:58:03.2155679+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 118,
      "Visibility": "All",
      "DisplayValue": "omnis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 585
        }
      }
    },
    {
      "VisibleId": 118,
      "Visibility": "All",
      "DisplayValue": "omnis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 585
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
      "FieldLength": 638
    }
  }
}
```