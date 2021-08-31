---
title: AcceptRejected
id: v1AppointmentAgent_AcceptRejected
---

# AcceptRejected

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
  "AppointmentId": 412,
  "UpdateMode": "OnlyThis"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 815,
    "Name": "Beier-Christiansen",
    "PersonId": 105,
    "Rank": 180,
    "Tooltip": "quisquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 295,
    "FullName": "Burley Schinner",
    "FormalName": "Hane-Welch",
    "Deleted": false,
    "EjUserId": 45,
    "UserName": "Braun LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 106
      }
    }
  },
  "Contact": {
    "ContactId": 169,
    "Name": "Swift-Douglas",
    "OrgNr": "1359323",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ut",
    "DirectPhone": "1-465-048-0623",
    "AssociateId": 392,
    "CountryId": 530,
    "EmailAddress": "cassidy.bahringer@wintheiser.name",
    "Kananame": "corrupti",
    "EmailAddressName": "travon@treutellarson.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Amira Huels",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "accusantium",
    "FullName": "Dejon Jewess",
    "IsOwnerContact": false,
    "ActiveErpLinks": 764,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 897
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 203,
    "Name": "Nienow, Shields and Quigley",
    "PersonId": 4,
    "Rank": 891,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 838,
    "FullName": "Frederique Effertz",
    "FormalName": "Conroy-Steuber",
    "Deleted": true,
    "EjUserId": 566,
    "UserName": "Kling Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 359
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 956,
    "Name": "Smitham-Doyle",
    "PersonId": 277,
    "Rank": 741,
    "Tooltip": "aliquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 312,
    "FullName": "Norwood Dicki",
    "FormalName": "Kulas-Doyle",
    "Deleted": false,
    "EjUserId": 69,
    "UserName": "O'Hara LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 908
      }
    }
  },
  "CreatedDate": "2019-04-08T14:58:02.9425716+02:00",
  "AppointmentId": 762,
  "Description": "Stand-alone grid-enabled structure",
  "StartDate": "2001-12-29T14:58:02.9425716+01:00",
  "EndDate": "2021-06-16T14:58:02.9425716+02:00",
  "InvitedPerson": {
    "Position": "aliquid",
    "PersonId": 49,
    "Mrmrs": "aut",
    "Firstname": "Eldridge",
    "Lastname": "Becker",
    "MiddleName": "Maggio Inc and Sons",
    "Title": "ut",
    "Description": "Switchable asynchronous strategy",
    "Email": "rhianna@rowe.ca",
    "FullName": "Dr. Thelma Rice",
    "DirectPhone": "218-873-5267",
    "FormalName": "Effertz-Hyatt",
    "CountryId": 264,
    "ContactId": 16,
    "ContactName": "Bogisich, Hansen and Braun",
    "Retired": 640,
    "Rank": 980,
    "ActiveInterests": 818,
    "ContactDepartment": "",
    "ContactCountryId": 716,
    "ContactOrgNr": "1180673",
    "FaxPhone": "1-730-314-7871",
    "MobilePhone": "245.530.5574 x858",
    "ContactPhone": "700.482.8527 x753",
    "AssociateName": "O'Reilly-Moen",
    "AssociateId": 266,
    "UsePersonAddress": true,
    "ContactFax": "quas",
    "Kanafname": "culpa",
    "Kanalname": "quam",
    "Post1": "consectetur",
    "Post2": "vel",
    "Post3": "fuga",
    "EmailName": "rickie.stamm@kirlin.ca",
    "ContactFullName": "Ruben Mertz",
    "ActiveErpLinks": 666,
    "TicketPriorityId": 251,
    "SupportLanguageId": 843,
    "SupportAssociateId": 707,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 952
      }
    }
  },
  "Person": {
    "Position": "ut",
    "PersonId": 765,
    "Mrmrs": "corrupti",
    "Firstname": "Kayden",
    "Lastname": "Feil",
    "MiddleName": "Moore Inc and Sons",
    "Title": "quia",
    "Description": "Phased disintermediate moderator",
    "Email": "akeem_lynch@effertz.biz",
    "FullName": "Zack Vandervort",
    "DirectPhone": "216.558.3031",
    "FormalName": "Leuschke Inc and Sons",
    "CountryId": 74,
    "ContactId": 353,
    "ContactName": "Keeling Inc and Sons",
    "Retired": 731,
    "Rank": 991,
    "ActiveInterests": 361,
    "ContactDepartment": "",
    "ContactCountryId": 920,
    "ContactOrgNr": "833199",
    "FaxPhone": "(163)446-5188",
    "MobilePhone": "(411)122-7802 x87621",
    "ContactPhone": "(806)204-4666",
    "AssociateName": "Mills, Gutmann and Willms",
    "AssociateId": 107,
    "UsePersonAddress": true,
    "ContactFax": "et",
    "Kanafname": "sint",
    "Kanalname": "vel",
    "Post1": "suscipit",
    "Post2": "id",
    "Post3": "autem",
    "EmailName": "selmer@dare.biz",
    "ContactFullName": "Chanel Quitzon PhD",
    "ActiveErpLinks": 994,
    "TicketPriorityId": 697,
    "SupportLanguageId": 504,
    "SupportAssociateId": 484,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 645
      }
    }
  },
  "MotherId": 126,
  "Priority": {
    "Id": 163,
    "Value": "blanditiis",
    "Tooltip": "nisi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 881
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 127,
    "Name": "Jenkins Group",
    "Description": "Multi-layered secondary utilisation",
    "URL": "http://www.example.com/",
    "Type": "modi",
    "AssociateId": 803,
    "AssociateFullName": "Timmy Zboncak",
    "TypeId": 697,
    "Updated": "2011-05-06T14:58:02.9455679+02:00",
    "StatusId": 977,
    "Status": "aut",
    "TextId": 333,
    "PublishTo": "2005-12-31T14:58:02.9456667+01:00",
    "PublishFrom": "1994-12-02T14:58:02.9456667+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1029349",
    "ActiveErpLinks": 635,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 834
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2001-01-09T14:58:02.9456667+01:00",
  "Completed": "Completed",
  "ActiveLinks": 301,
  "Links": [
    {
      "EntityName": "McDermott, Marquardt and McClure",
      "Id": 983,
      "Description": "Ameliorated multi-tasking leverage",
      "ExtraInfo": "maiores",
      "LinkId": 844,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 762
        }
      }
    }
  ],
  "AlarmLeadTime": "consequatur",
  "HasAlarm": false,
  "ColorIndex": 739,
  "IsFree": false,
  "IsAlldayEvent": true,
  "LagTime": "modi",
  "LeadTime": "voluptatum",
  "Location": "eaque",
  "RejectCounter": 396,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 895,
    "StartDate": "2020-02-25T14:58:02.9456667+01:00",
    "EndDate": "2020-05-11T14:58:02.9456667+02:00",
    "RecurrenceCounter": 757,
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
      "AssociateId": 805,
      "PersonId": 396,
      "ContactId": 241,
      "EmailId": 987,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 805,
      "PersonId": 396,
      "ContactId": 241,
      "EmailId": 987,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2018-06-18T14:58:02.9456667+02:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 634,
    "Name": "Cormier-Koelpin",
    "PersonId": 175,
    "Rank": 18,
    "Tooltip": "asperiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 364,
    "FullName": "Benjamin Tromp",
    "FormalName": "Goldner, Smith and Ritchie",
    "Deleted": false,
    "EjUserId": 796,
    "UserName": "Mitchell LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 755
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 753,
    "Name": "Haley Inc and Sons",
    "PersonId": 303,
    "Rank": 952,
    "Tooltip": "soluta",
    "Type": "AnonymousAssociate",
    "GroupIdx": 734,
    "FullName": "Hillary Tillman",
    "FormalName": "Wuckert LLC",
    "Deleted": false,
    "EjUserId": 749,
    "UserName": "Green-Hayes",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 607
      }
    }
  },
  "Task": {
    "TaskListItemId": 993,
    "Value": "illo",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "et",
    "Deleted": true,
    "IntentId": 421,
    "Rank": 266,
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
        "FieldLength": 541
      }
    }
  },
  "PreferredTZLocation": 242,
  "Sale": {
    "ContactName": "Beahan Group",
    "SaleDate": "2019-05-18T14:58:02.9465412+02:00",
    "SaleId": 970,
    "Probability": 741,
    "Title": "pariatur",
    "Amount": 21449.095999999998,
    "Currency": "facere",
    "ProjectName": "Crona, Koss and Hagenes",
    "AssociateFullName": "Ellsworth Torphy",
    "Description": "Horizontal non-volatile parallelism",
    "Status": "Lost",
    "WeightedAmount": 14513.554,
    "ProjectId": 768,
    "EarningPercent": 9865.832,
    "Earning": 30045.658,
    "ContactId": 576,
    "AssociateId": 688,
    "PersonId": 10,
    "SaleTypeId": 542,
    "SaleTypeName": "Jerde Group",
    "PersonFullName": "Elenora Welch",
    "Completed": "Completed",
    "ActiveErpLinks": 971,
    "NextDueDate": "1999-01-21T14:58:02.9465412+01:00",
    "Number": "408815",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 511
      }
    }
  },
  "SuggestedAppointmentId": 950,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "molestiae",
  "UserDefinedFields": {
    "SuperOffice:1": "706954289",
    "SuperOffice:2": "Friedrich McCullough"
  },
  "ExtraFields": {
    "ExtraFields1": "assumenda",
    "ExtraFields2": "neque"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "nostrum"
  },
  "PublishEventDate": "2012-05-03T14:58:02.9475409+02:00",
  "PublishTo": "1998-01-01T14:58:02.9475409+01:00",
  "PublishFrom": "2015-01-21T14:58:02.9475409+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 368,
      "Visibility": "All",
      "DisplayValue": "veritatis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 135
        }
      }
    },
    {
      "VisibleId": 368,
      "Visibility": "All",
      "DisplayValue": "veritatis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 135
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
      "FieldLength": 938
    }
  }
}
```