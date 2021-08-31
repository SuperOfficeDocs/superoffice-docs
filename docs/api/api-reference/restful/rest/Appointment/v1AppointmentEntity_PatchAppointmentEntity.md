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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "omnis",
    "value": {
      "value1": {
        "PrimaryKey": 3652,
        "EntityName": "person",
        "personId": 3652,
        "fullName": "Carroll Mann"
      },
      "value2": {
        "PrimaryKey": 6675,
        "EntityName": "sale",
        "saleId": 6675,
        "contactId": 6945,
        "name": "Cummings LLC"
      }
    }
  },
  {
    "op": "add",
    "path": "omnis",
    "value": {
      "value1": {
        "PrimaryKey": 3652,
        "EntityName": "person",
        "personId": 3652,
        "fullName": "Carroll Mann"
      },
      "value2": {
        "PrimaryKey": 6675,
        "EntityName": "sale",
        "saleId": 6675,
        "contactId": 6945,
        "name": "Cummings LLC"
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
    "AssociateId": 811,
    "Name": "Mertz-Lesch",
    "PersonId": 899,
    "Rank": 473,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 544,
    "FullName": "Alden Pacocha",
    "FormalName": "Lowe, Cassin and Macejkovic",
    "Deleted": true,
    "EjUserId": 997,
    "UserName": "Hane LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 277
      }
    }
  },
  "Contact": {
    "ContactId": 832,
    "Name": "O'Conner, McLaughlin and Herzog",
    "OrgNr": "1374605",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "minus",
    "DirectPhone": "646.645.0622",
    "AssociateId": 282,
    "CountryId": 420,
    "EmailAddress": "althea@will.us",
    "Kananame": "sit",
    "EmailAddressName": "lilliana_roob@grady.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mr. Anastasia Schumm",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "officiis",
    "FullName": "Danyka Lueilwitz",
    "IsOwnerContact": false,
    "ActiveErpLinks": 858,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 952
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 552,
    "Name": "Crist-Little",
    "PersonId": 514,
    "Rank": 463,
    "Tooltip": "repellat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 186,
    "FullName": "Mr. Timmothy Cassin",
    "FormalName": "Kunze, Harber and Smitham",
    "Deleted": false,
    "EjUserId": 194,
    "UserName": "Ernser LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 729
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 231,
    "Name": "Kris, Lemke and Kris",
    "PersonId": 964,
    "Rank": 673,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 738,
    "FullName": "Isom Treutel",
    "FormalName": "Nader LLC",
    "Deleted": false,
    "EjUserId": 808,
    "UserName": "Brakus, Morar and Hamill",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 467
      }
    }
  },
  "CreatedDate": "2003-12-11T15:05:41.5690026+01:00",
  "AppointmentId": 329,
  "Description": "Team-oriented methodical function",
  "StartDate": "2008-01-14T15:05:41.5690026+01:00",
  "EndDate": "2001-08-03T15:05:41.5690026+02:00",
  "InvitedPerson": {
    "Position": "neque",
    "PersonId": 943,
    "Mrmrs": "cupiditate",
    "Firstname": "Benedict",
    "Lastname": "Gaylord",
    "MiddleName": "Osinski LLC",
    "Title": "ipsum",
    "Description": "Grass-roots discrete definition",
    "Email": "viviane_hettinger@muller.ca",
    "FullName": "Flo McKenzie",
    "DirectPhone": "(063)231-6876 x836",
    "FormalName": "Bergstrom-Weissnat",
    "CountryId": 677,
    "ContactId": 934,
    "ContactName": "Lesch Inc and Sons",
    "Retired": 371,
    "Rank": 741,
    "ActiveInterests": 919,
    "ContactDepartment": "",
    "ContactCountryId": 16,
    "ContactOrgNr": "498260",
    "FaxPhone": "1-582-852-2232",
    "MobilePhone": "533.882.5456 x70302",
    "ContactPhone": "(042)375-5166 x4037",
    "AssociateName": "Grant-Predovic",
    "AssociateId": 13,
    "UsePersonAddress": false,
    "ContactFax": "tenetur",
    "Kanafname": "non",
    "Kanalname": "aliquid",
    "Post1": "omnis",
    "Post2": "consequatur",
    "Post3": "rerum",
    "EmailName": "earline_franecki@boyer.co.uk",
    "ContactFullName": "Cody Dickens",
    "ActiveErpLinks": 298,
    "TicketPriorityId": 764,
    "SupportLanguageId": 571,
    "SupportAssociateId": 40,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 327
      }
    }
  },
  "Person": {
    "Position": "sequi",
    "PersonId": 498,
    "Mrmrs": "dolor",
    "Firstname": "Kaela",
    "Lastname": "Luettgen",
    "MiddleName": "Stanton, Beer and Wiza",
    "Title": "maxime",
    "Description": "Reduced maximized protocol",
    "Email": "kassandra_dicki@schinner.info",
    "FullName": "Lori Witting",
    "DirectPhone": "875.255.6770 x2483",
    "FormalName": "Rippin, Schiller and Kiehn",
    "CountryId": 554,
    "ContactId": 179,
    "ContactName": "Donnelly, Eichmann and Dibbert",
    "Retired": 361,
    "Rank": 518,
    "ActiveInterests": 543,
    "ContactDepartment": "",
    "ContactCountryId": 381,
    "ContactOrgNr": "1471983",
    "FaxPhone": "(518)231-0170 x84458",
    "MobilePhone": "838-107-0654 x810",
    "ContactPhone": "384-386-3635 x332",
    "AssociateName": "Feest, Rice and Nikolaus",
    "AssociateId": 706,
    "UsePersonAddress": false,
    "ContactFax": "iure",
    "Kanafname": "maiores",
    "Kanalname": "illum",
    "Post1": "amet",
    "Post2": "optio",
    "Post3": "aliquam",
    "EmailName": "antonetta.mraz@wehner.biz",
    "ContactFullName": "Aidan Dietrich DVM",
    "ActiveErpLinks": 322,
    "TicketPriorityId": 878,
    "SupportLanguageId": 669,
    "SupportAssociateId": 476,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 812
      }
    }
  },
  "MotherId": 193,
  "Priority": {
    "Id": 515,
    "Value": "illo",
    "Tooltip": "rerum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 503
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 7,
    "Name": "Howe-Hegmann",
    "Description": "Future-proofed transitional array",
    "URL": "http://www.example.com/",
    "Type": "quibusdam",
    "AssociateId": 481,
    "AssociateFullName": "Georgiana Botsford",
    "TypeId": 196,
    "Updated": "2021-02-09T15:05:41.5720022+01:00",
    "StatusId": 666,
    "Status": "voluptatem",
    "TextId": 320,
    "PublishTo": "1997-03-05T15:05:41.5720022+01:00",
    "PublishFrom": "1999-10-26T15:05:41.5720022+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "140055",
    "ActiveErpLinks": 477,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 89
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2005-07-01T15:05:41.5720022+02:00",
  "Completed": "Completed",
  "ActiveLinks": 724,
  "Links": [
    {
      "EntityName": "Dickens, Kohler and Watsica",
      "Id": 532,
      "Description": "Function-based local circuit",
      "ExtraInfo": "ipsa",
      "LinkId": 333,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "exploit cutting-edge portals"
          },
          "FieldType": "System.Int32",
          "FieldLength": 792
        }
      }
    }
  ],
  "AlarmLeadTime": "quo",
  "HasAlarm": false,
  "ColorIndex": 355,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "accusamus",
  "LeadTime": "unde",
  "Location": "fugit",
  "RejectCounter": 87,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 452,
    "StartDate": "2003-08-13T15:05:41.5730026+02:00",
    "EndDate": "2015-06-17T15:05:41.5730026+02:00",
    "RecurrenceCounter": 7,
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
      "AssociateId": 828,
      "PersonId": 753,
      "ContactId": 716,
      "EmailId": 539,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 828,
      "PersonId": 753,
      "ContactId": 716,
      "EmailId": 539,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2008-01-17T15:05:41.5730026+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 808,
    "Name": "Dach, Quitzon and Buckridge",
    "PersonId": 514,
    "Rank": 42,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 97,
    "FullName": "Mrs. Caitlyn Will",
    "FormalName": "Robel-Koss",
    "Deleted": false,
    "EjUserId": 857,
    "UserName": "Lockman, Tillman and Medhurst",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 334
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 691,
    "Name": "Leffler-Wiza",
    "PersonId": 53,
    "Rank": 68,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 741,
    "FullName": "Michael Wintheiser",
    "FormalName": "Cartwright-Franecki",
    "Deleted": false,
    "EjUserId": 734,
    "UserName": "Hudson-Stiedemann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "transition extensible systems"
        },
        "FieldType": "System.String",
        "FieldLength": 258
      }
    }
  },
  "Task": {
    "TaskListItemId": 39,
    "Value": "fuga",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "nisi",
    "Deleted": true,
    "IntentId": 133,
    "Rank": 123,
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
        "FieldType": "System.String",
        "FieldLength": 892
      }
    }
  },
  "PreferredTZLocation": 312,
  "Sale": {
    "ContactName": "Nicolas-Stracke",
    "SaleDate": "2011-12-20T15:05:41.5730026+01:00",
    "SaleId": 463,
    "Probability": 427,
    "Title": "iure",
    "Amount": 10188.634,
    "Currency": "ex",
    "ProjectName": "Bernhard-Beatty",
    "AssociateFullName": "Brooks Carroll II",
    "Description": "Advanced dedicated circuit",
    "Status": "Lost",
    "WeightedAmount": 3641.708,
    "ProjectId": 610,
    "EarningPercent": 23978.234,
    "Earning": 6703.626,
    "ContactId": 551,
    "AssociateId": 69,
    "PersonId": 580,
    "SaleTypeId": 128,
    "SaleTypeName": "Price, Rolfson and Pfannerstill",
    "PersonFullName": "Griffin Ratke",
    "Completed": "Completed",
    "ActiveErpLinks": 764,
    "NextDueDate": "2014-04-08T15:05:41.5740023+02:00",
    "Number": "1190464",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 560
      }
    }
  },
  "SuggestedAppointmentId": 149,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "rerum",
  "UserDefinedFields": {
    "SuperOffice:1": "1937625880",
    "SuperOffice:2": "284438669"
  },
  "ExtraFields": {
    "ExtraFields1": "occaecati",
    "ExtraFields2": "officia"
  },
  "CustomFields": {
    "CustomFields1": "debitis",
    "CustomFields2": "aut"
  },
  "PublishEventDate": "2016-03-24T15:05:41.5740023+01:00",
  "PublishTo": "2002-01-28T15:05:41.5740023+01:00",
  "PublishFrom": "2003-09-22T15:05:41.5740023+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 384,
      "Visibility": "All",
      "DisplayValue": "molestiae",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 24
        }
      }
    },
    {
      "VisibleId": 384,
      "Visibility": "All",
      "DisplayValue": "molestiae",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 24
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "expedite next-generation eyeballs"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 997
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```