---
title: POST Agents/Appointment/CreateDefaultAppointmentEntityByType
id: v1AppointmentAgent_CreateDefaultAppointmentEntityByType
---

# POST Agents/Appointment/CreateDefaultAppointmentEntityByType

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityByType
```

Creates a AppointmentEntity populated with the default values for the specific type.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityByType?$select=name,department,category/id
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

Type 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Type | string |  |


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
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityByType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Type": "Appointment"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 958,
    "Name": "Bashirian-VonRueden",
    "PersonId": 270,
    "Rank": 458,
    "Tooltip": "laudantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 892,
    "FullName": "Spencer Hirthe",
    "FormalName": "Mante, Fahey and Mann",
    "Deleted": false,
    "EjUserId": 689,
    "UserName": "Goodwin, Haley and Hettinger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 566
      }
    }
  },
  "Contact": {
    "ContactId": 422,
    "Name": "Turner Group",
    "OrgNr": "1140457",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "sed",
    "DirectPhone": "1-361-680-3644 x457",
    "AssociateId": 155,
    "CountryId": 459,
    "EmailAddress": "luella.nikolaus@schmidt.com",
    "Kananame": "suscipit",
    "EmailAddressName": "geovany@heller.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Freda Price",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "consequatur",
    "FullName": "Brenda Harris",
    "IsOwnerContact": true,
    "ActiveErpLinks": 932,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "synthesize vertical schemas"
        },
        "FieldType": "System.Int32",
        "FieldLength": 752
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 258,
    "Name": "Ziemann, Block and Maggio",
    "PersonId": 981,
    "Rank": 730,
    "Tooltip": "cupiditate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 350,
    "FullName": "Mariah Gaylord",
    "FormalName": "Ernser-Luettgen",
    "Deleted": false,
    "EjUserId": 260,
    "UserName": "Yundt LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 385
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 295,
    "Name": "Brown Group",
    "PersonId": 849,
    "Rank": 537,
    "Tooltip": "harum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 413,
    "FullName": "Sasha Block",
    "FormalName": "Wisozk-Batz",
    "Deleted": true,
    "EjUserId": 295,
    "UserName": "Ryan, McClure and Pacocha",
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
  "CreatedDate": "2007-02-15T18:28:47.9738451+01:00",
  "AppointmentId": 24,
  "Description": "Right-sized scalable synergy",
  "StartDate": "2008-09-12T18:28:47.9738451+02:00",
  "EndDate": "2020-03-15T18:28:47.9738451+01:00",
  "InvitedPerson": {
    "Position": "nobis",
    "PersonId": 417,
    "Mrmrs": "illum",
    "Firstname": "Grover",
    "Lastname": "Schulist",
    "MiddleName": "Baumbach-Harvey",
    "Title": "sapiente",
    "Description": "Public-key responsive strategy",
    "Email": "urban@reilly.info",
    "FullName": "Daniela Dach",
    "DirectPhone": "1-681-714-7786 x4058",
    "FormalName": "Jacobs, Leuschke and Hauck",
    "CountryId": 100,
    "ContactId": 981,
    "ContactName": "Hills Group",
    "Retired": 814,
    "Rank": 816,
    "ActiveInterests": 831,
    "ContactDepartment": "",
    "ContactCountryId": 753,
    "ContactOrgNr": "1201684",
    "FaxPhone": "(170)671-1141",
    "MobilePhone": "(815)827-6722 x11422",
    "ContactPhone": "1-022-084-5315",
    "AssociateName": "Cremin Inc and Sons",
    "AssociateId": 366,
    "UsePersonAddress": true,
    "ContactFax": "et",
    "Kanafname": "totam",
    "Kanalname": "sequi",
    "Post1": "sint",
    "Post2": "doloribus",
    "Post3": "sed",
    "EmailName": "angelita_mueller@kubstreich.co.uk",
    "ContactFullName": "Colleen Corwin",
    "ActiveErpLinks": 891,
    "TicketPriorityId": 385,
    "SupportLanguageId": 542,
    "SupportAssociateId": 294,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 609
      }
    }
  },
  "Person": {
    "Position": "eveniet",
    "PersonId": 165,
    "Mrmrs": "reprehenderit",
    "Firstname": "Amely",
    "Lastname": "Spinka",
    "MiddleName": "Dicki, Cummerata and Runte",
    "Title": "eaque",
    "Description": "Adaptive foreground solution",
    "Email": "josianne@roob.com",
    "FullName": "Gregoria O'Conner IV",
    "DirectPhone": "(871)763-3154",
    "FormalName": "Marks LLC",
    "CountryId": 652,
    "ContactId": 676,
    "ContactName": "Cruickshank, Gleason and Brown",
    "Retired": 888,
    "Rank": 985,
    "ActiveInterests": 693,
    "ContactDepartment": "",
    "ContactCountryId": 231,
    "ContactOrgNr": "1680647",
    "FaxPhone": "1-258-164-6720 x82561",
    "MobilePhone": "623-105-2014",
    "ContactPhone": "027-807-3055 x3407",
    "AssociateName": "Hegmann, Ward and Davis",
    "AssociateId": 32,
    "UsePersonAddress": true,
    "ContactFax": "et",
    "Kanafname": "modi",
    "Kanalname": "eum",
    "Post1": "molestiae",
    "Post2": "commodi",
    "Post3": "asperiores",
    "EmailName": "sylvan@mrazklein.co.uk",
    "ContactFullName": "Isom Effertz",
    "ActiveErpLinks": 663,
    "TicketPriorityId": 617,
    "SupportLanguageId": 587,
    "SupportAssociateId": 357,
    "CategoryName": "VIP Customer",
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
  "MotherId": 304,
  "Priority": {
    "Id": 360,
    "Value": "aut",
    "Tooltip": "velit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 936
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 67,
    "Name": "Harber-Douglas",
    "Description": "Quality-focused full-range firmware",
    "URL": "http://www.example.com/",
    "Type": "sequi",
    "AssociateId": 148,
    "AssociateFullName": "Raul Eichmann",
    "TypeId": 583,
    "Updated": "2015-03-01T18:28:47.975847+01:00",
    "StatusId": 558,
    "Status": "debitis",
    "TextId": 870,
    "PublishTo": "2015-02-13T18:28:47.975847+01:00",
    "PublishFrom": "2021-01-03T18:28:47.975847+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1053521",
    "ActiveErpLinks": 7,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 499
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "1999-05-26T18:28:47.975847+02:00",
  "Completed": "Completed",
  "ActiveLinks": 182,
  "Links": [
    {
      "EntityName": "Hoppe-Pouros",
      "Id": 333,
      "Description": "Inverse tertiary task-force",
      "ExtraInfo": "tempora",
      "LinkId": 224,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 630
        }
      }
    }
  ],
  "AlarmLeadTime": "fugiat",
  "HasAlarm": false,
  "ColorIndex": 112,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "animi",
  "LeadTime": "voluptas",
  "Location": "adipisci",
  "RejectCounter": 582,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 206,
    "StartDate": "2004-09-16T18:28:47.975847+02:00",
    "EndDate": "2000-02-29T18:28:47.975847+01:00",
    "RecurrenceCounter": 326,
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
      "AssociateId": 198,
      "PersonId": 555,
      "ContactId": 226,
      "EmailId": 773,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 198,
      "PersonId": 555,
      "ContactId": 226,
      "EmailId": 773,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2006-02-14T18:28:47.975847+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 463,
    "Name": "Hilll-Graham",
    "PersonId": 645,
    "Rank": 250,
    "Tooltip": "accusantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 738,
    "FullName": "Roxanne Hodkiewicz",
    "FormalName": "Haley LLC",
    "Deleted": true,
    "EjUserId": 600,
    "UserName": "Ryan-Hansen",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 283
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 632,
    "Name": "Weimann-Stanton",
    "PersonId": 844,
    "Rank": 794,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 735,
    "FullName": "Mr. Tevin Wyman",
    "FormalName": "Jones-Beer",
    "Deleted": true,
    "EjUserId": 145,
    "UserName": "Prohaska-Sporer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 648
      }
    }
  },
  "Task": {
    "TaskListItemId": 209,
    "Value": "et",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "quae",
    "Deleted": true,
    "IntentId": 14,
    "Rank": 911,
    "IsDefaultAlldayEvent": false,
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
        "FieldType": "System.Int32",
        "FieldLength": 218
      }
    }
  },
  "PreferredTZLocation": 253,
  "Sale": {
    "ContactName": "Moore Group",
    "SaleDate": "2012-04-14T18:28:47.9778442+02:00",
    "SaleId": 271,
    "Probability": 768,
    "Title": "autem",
    "Amount": 18192.87,
    "Currency": "repellendus",
    "ProjectName": "Hansen Inc and Sons",
    "AssociateFullName": "Stephan Koepp",
    "Description": "Grass-roots client-server framework",
    "Status": "Lost",
    "WeightedAmount": 28735.646,
    "ProjectId": 974,
    "EarningPercent": 19904.034,
    "Earning": 14585.636,
    "ContactId": 881,
    "AssociateId": 493,
    "PersonId": 201,
    "SaleTypeId": 465,
    "SaleTypeName": "Klein Inc and Sons",
    "PersonFullName": "Dominic Hilll",
    "Completed": "Completed",
    "ActiveErpLinks": 814,
    "NextDueDate": "2009-08-11T18:28:47.9778442+02:00",
    "Number": "1155140",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 229
      }
    }
  },
  "SuggestedAppointmentId": 125,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "ea",
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Rowena Conn",
    "SuperOffice:2": "1377989555"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "ad"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "sit"
  },
  "PublishEventDate": "2002-02-24T18:28:47.9778442+01:00",
  "PublishTo": "1999-05-26T18:28:47.9778442+02:00",
  "PublishFrom": "2020-04-26T18:28:47.9778442+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 992,
      "Visibility": "All",
      "DisplayValue": "voluptatibus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 496
        }
      }
    },
    {
      "VisibleId": 992,
      "Visibility": "All",
      "DisplayValue": "voluptatibus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 496
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
      "FieldLength": 842
    }
  }
}
```