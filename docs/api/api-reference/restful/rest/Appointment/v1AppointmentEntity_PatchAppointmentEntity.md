---
title: PATCH Appointment/{id}
id: v1AppointmentEntity_PatchAppointmentEntity
---

# PATCH Appointment/{id}

```http
PATCH /api/v1/Appointment/{id}
```

Update a AppointmentEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IAppointmentAgent} service SaveAppointmentEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The AppointmentEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Appointment/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: object

Appointments appear in the diary, and have links to a Contact/Person and possibly a Project or Sale. They have start and end time+date.



AppointmentEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | AppointmentEntity  updated. |
| 404 | AppointmentEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because AppointmentEntity has changed since the requested If-Unmodified-Since timestamp. |

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
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/Appointment/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "magni",
    "value": {
      "value1": {
        "PrimaryKey": 7101,
        "EntityName": "person",
        "personId": 7101,
        "fullName": "Ms. Emelie Rutherford"
      },
      "value2": {
        "PrimaryKey": 6200,
        "EntityName": "person",
        "personId": 6200,
        "fullName": "Miss Elyssa McClure"
      }
    }
  },
  {
    "op": "add",
    "path": "magni",
    "value": {
      "value1": {
        "PrimaryKey": 7101,
        "EntityName": "person",
        "personId": 7101,
        "fullName": "Ms. Emelie Rutherford"
      },
      "value2": {
        "PrimaryKey": 6200,
        "EntityName": "person",
        "personId": 6200,
        "fullName": "Miss Elyssa McClure"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 AppointmentEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 487,
    "Name": "Hansen LLC",
    "PersonId": 612,
    "Rank": 728,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 418,
    "FullName": "Cassie Conroy",
    "FormalName": "Shields, Weimann and Lebsack",
    "Deleted": true,
    "EjUserId": 81,
    "UserName": "Herman LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 118
      }
    }
  },
  "Contact": {
    "ContactId": 985,
    "Name": "Rippin-Labadie",
    "OrgNr": "1014958",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quaerat",
    "DirectPhone": "1-634-072-2118 x06461",
    "AssociateId": 930,
    "CountryId": 267,
    "EmailAddress": "princess.west@torp.ca",
    "Kananame": "dolor",
    "EmailAddressName": "madeline@eichmannpagac.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Carmelo Littel",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "aliquid",
    "FullName": "Mr. Vinnie Krajcik",
    "IsOwnerContact": false,
    "ActiveErpLinks": 87,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 308
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 409,
    "Name": "Stark-Cassin",
    "PersonId": 202,
    "Rank": 967,
    "Tooltip": "deleniti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 326,
    "FullName": "Hillard Christiansen",
    "FormalName": "Koch LLC",
    "Deleted": false,
    "EjUserId": 991,
    "UserName": "Kemmer-Baumbach",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 747
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 943,
    "Name": "Funk, Greenholt and Jaskolski",
    "PersonId": 429,
    "Rank": 610,
    "Tooltip": "officiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 243,
    "FullName": "Ashly Krajcik",
    "FormalName": "Hahn, Padberg and Lindgren",
    "Deleted": false,
    "EjUserId": 70,
    "UserName": "Yost-Tremblay",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "morph frictionless action-items"
        },
        "FieldType": "System.String",
        "FieldLength": 265
      }
    }
  },
  "CreatedDate": "2020-07-18T09:40:58.6303705+02:00",
  "AppointmentId": 161,
  "Description": "Innovative exuding database",
  "StartDate": "1994-04-26T09:40:58.6303705+02:00",
  "EndDate": "2002-04-12T09:40:58.6303705+02:00",
  "InvitedPerson": {
    "Position": "deserunt",
    "PersonId": 899,
    "Mrmrs": "animi",
    "Firstname": "Destinee",
    "Lastname": "Huels",
    "MiddleName": "Schuppe Group",
    "Title": "libero",
    "Description": "Cross-platform executive software",
    "Email": "golda.wilkinson@feil.com",
    "FullName": "Mrs. Damien Mohr",
    "DirectPhone": "026-185-4873 x0647",
    "FormalName": "Leuschke Group",
    "CountryId": 676,
    "ContactId": 483,
    "ContactName": "Denesik, Medhurst and Zemlak",
    "Retired": 263,
    "Rank": 306,
    "ActiveInterests": 897,
    "ContactDepartment": "",
    "ContactCountryId": 19,
    "ContactOrgNr": "1250563",
    "FaxPhone": "356-150-2647 x860",
    "MobilePhone": "(253)752-5664",
    "ContactPhone": "(248)014-4885 x065",
    "AssociateName": "Larkin, Lebsack and Witting",
    "AssociateId": 981,
    "UsePersonAddress": true,
    "ContactFax": "illum",
    "Kanafname": "dolorem",
    "Kanalname": "nemo",
    "Post1": "sequi",
    "Post2": "excepturi",
    "Post3": "quidem",
    "EmailName": "eduardo_greenholt@hirthemurray.us",
    "ContactFullName": "Gonzalo Sauer",
    "ActiveErpLinks": 19,
    "TicketPriorityId": 449,
    "SupportLanguageId": 150,
    "SupportAssociateId": 840,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "optimize enterprise e-commerce"
        },
        "FieldType": "System.String",
        "FieldLength": 692
      }
    }
  },
  "Person": {
    "Position": "tempore",
    "PersonId": 276,
    "Mrmrs": "quo",
    "Firstname": "Norberto",
    "Lastname": "Corwin",
    "MiddleName": "Nitzsche LLC",
    "Title": "aut",
    "Description": "Customer-focused high-level ability",
    "Email": "turner@hauck.ca",
    "FullName": "Alexys Wiza",
    "DirectPhone": "1-842-066-1721 x8024",
    "FormalName": "Denesik, Bogan and Romaguera",
    "CountryId": 302,
    "ContactId": 856,
    "ContactName": "Altenwerth-Hirthe",
    "Retired": 776,
    "Rank": 671,
    "ActiveInterests": 142,
    "ContactDepartment": "",
    "ContactCountryId": 282,
    "ContactOrgNr": "194271",
    "FaxPhone": "(525)828-2768",
    "MobilePhone": "1-830-355-4441",
    "ContactPhone": "1-128-043-5186 x1736",
    "AssociateName": "Murazik, Marvin and Gislason",
    "AssociateId": 802,
    "UsePersonAddress": false,
    "ContactFax": "saepe",
    "Kanafname": "quia",
    "Kanalname": "maxime",
    "Post1": "dolores",
    "Post2": "consequatur",
    "Post3": "perspiciatis",
    "EmailName": "summer@goodwin.com",
    "ContactFullName": "Theresia Fisher",
    "ActiveErpLinks": 588,
    "TicketPriorityId": 43,
    "SupportLanguageId": 381,
    "SupportAssociateId": 716,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 904
      }
    }
  },
  "MotherId": 985,
  "Priority": {
    "Id": 896,
    "Value": "qui",
    "Tooltip": "neque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 62
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 126,
    "Name": "Considine Inc and Sons",
    "Description": "Compatible modular parallelism",
    "URL": "http://www.example.com/",
    "Type": "sed",
    "AssociateId": 469,
    "AssociateFullName": "Garnett Schneider",
    "TypeId": 878,
    "Updated": "2003-09-04T09:40:58.6343703+02:00",
    "StatusId": 987,
    "Status": "molestiae",
    "TextId": 408,
    "PublishTo": "2006-05-10T09:40:58.6343703+02:00",
    "PublishFrom": "2019-10-23T09:40:58.6343703+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "607503",
    "ActiveErpLinks": 918,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 745
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2013-01-14T09:40:58.6343703+01:00",
  "Completed": "Completed",
  "ActiveLinks": 142,
  "Links": [
    {
      "EntityName": "Schmeler, Brekke and Kessler",
      "Id": 934,
      "Description": "Face to face assymetric process improvement",
      "ExtraInfo": "quia",
      "LinkId": 437,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 854
        }
      }
    }
  ],
  "AlarmLeadTime": "quia",
  "HasAlarm": true,
  "ColorIndex": 50,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "mollitia",
  "LeadTime": "magni",
  "Location": "fuga",
  "RejectCounter": 816,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 694,
    "StartDate": "2005-04-12T09:40:58.6343703+02:00",
    "EndDate": "2016-08-20T09:40:58.6343703+02:00",
    "RecurrenceCounter": 447,
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
      "AssociateId": 535,
      "PersonId": 546,
      "ContactId": 919,
      "EmailId": 642,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 535,
      "PersonId": 546,
      "ContactId": 919,
      "EmailId": 642,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2002-12-07T09:40:58.6343703+01:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 84,
    "Name": "Flatley, Mann and Mayer",
    "PersonId": 252,
    "Rank": 802,
    "Tooltip": "vitae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 568,
    "FullName": "Myrtie Ondricka",
    "FormalName": "Treutel LLC",
    "Deleted": false,
    "EjUserId": 269,
    "UserName": "Graham, Hansen and Ryan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 410
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 71,
    "Name": "Stroman, Flatley and Homenick",
    "PersonId": 464,
    "Rank": 798,
    "Tooltip": "at",
    "Type": "AnonymousAssociate",
    "GroupIdx": 126,
    "FullName": "Dr. Lukas Monahan",
    "FormalName": "Swift, Wisoky and Feeney",
    "Deleted": true,
    "EjUserId": 978,
    "UserName": "Tillman Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 113
      }
    }
  },
  "Task": {
    "TaskListItemId": 755,
    "Value": "sequi",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "minus",
    "Deleted": false,
    "IntentId": 217,
    "Rank": 960,
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
        "FieldLength": 352
      }
    }
  },
  "PreferredTZLocation": 257,
  "Sale": {
    "ContactName": "Herman, Tromp and Carter",
    "SaleDate": "2010-04-23T09:40:58.6353713+02:00",
    "SaleId": 282,
    "Probability": 434,
    "Title": "at",
    "Amount": 19919.703999999998,
    "Currency": "quos",
    "ProjectName": "Paucek, Schaefer and Ondricka",
    "AssociateFullName": "Clarabelle Torphy",
    "Description": "Centralized uniform parallelism",
    "Status": "Lost",
    "WeightedAmount": 28732.512,
    "ProjectId": 784,
    "EarningPercent": 12028.292,
    "Earning": 7408.776,
    "ContactId": 854,
    "AssociateId": 637,
    "PersonId": 610,
    "SaleTypeId": 794,
    "SaleTypeName": "Leuschke LLC",
    "PersonFullName": "Greg Grant",
    "Completed": "Completed",
    "ActiveErpLinks": 538,
    "NextDueDate": "1998-04-15T09:40:58.6353713+02:00",
    "Number": "1124975",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 692
      }
    }
  },
  "SuggestedAppointmentId": 156,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "consequatur",
  "UserDefinedFields": {
    "SuperOffice:1": "Evans Wiegand",
    "SuperOffice:2": "2111249747"
  },
  "ExtraFields": {
    "ExtraFields1": "perferendis",
    "ExtraFields2": "culpa"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "nemo"
  },
  "PublishEventDate": "1995-02-20T09:40:58.6363709+01:00",
  "PublishTo": "2016-04-06T09:40:58.6363709+02:00",
  "PublishFrom": "2014-06-13T09:40:58.6363709+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 377,
      "Visibility": "All",
      "DisplayValue": "ab",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 181
        }
      }
    },
    {
      "VisibleId": 377,
      "Visibility": "All",
      "DisplayValue": "ab",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 181
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "architect holistic convergence"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 476
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```