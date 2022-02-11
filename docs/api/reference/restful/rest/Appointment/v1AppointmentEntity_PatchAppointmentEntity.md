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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "ab",
    "value": {
      "value1": {
        "PrimaryKey": 7655,
        "EntityName": "person",
        "personId": 7655,
        "fullName": "Annabel Crona PhD"
      },
      "value2": {
        "PrimaryKey": 4824,
        "EntityName": "person",
        "personId": 4824,
        "fullName": "Camryn Schulist"
      }
    }
  },
  {
    "op": "add",
    "path": "ab",
    "value": {
      "value1": {
        "PrimaryKey": 7655,
        "EntityName": "person",
        "personId": 7655,
        "fullName": "Annabel Crona PhD"
      },
      "value2": {
        "PrimaryKey": 4824,
        "EntityName": "person",
        "personId": 4824,
        "fullName": "Camryn Schulist"
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
    "AssociateId": 697,
    "Name": "Upton LLC",
    "PersonId": 583,
    "Rank": 769,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 358,
    "FullName": "Allene Feest",
    "FormalName": "Kuphal, Bernhard and Heller",
    "Deleted": false,
    "EjUserId": 316,
    "UserName": "Ratke-Glover",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 690
      }
    }
  },
  "Contact": {
    "ContactId": 78,
    "Name": "Hand Inc and Sons",
    "OrgNr": "1131375",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dignissimos",
    "DirectPhone": "1-553-170-7140",
    "AssociateId": 439,
    "CountryId": 851,
    "EmailAddress": "orlo@labadiemills.biz",
    "Kananame": "molestiae",
    "EmailAddressName": "vernie.trantow@pacocha.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Casimir Beier",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "commodi",
    "FullName": "Nora Dickens",
    "IsOwnerContact": true,
    "ActiveErpLinks": 742,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 444
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 33,
    "Name": "Fahey LLC",
    "PersonId": 546,
    "Rank": 554,
    "Tooltip": "quae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 777,
    "FullName": "Mr. Lue Hartmann",
    "FormalName": "Leffler-Daniel",
    "Deleted": true,
    "EjUserId": 969,
    "UserName": "Ebert-Veum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 313
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 696,
    "Name": "Labadie Group",
    "PersonId": 744,
    "Rank": 20,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 644,
    "FullName": "Alexie Erdman",
    "FormalName": "Treutel-Fritsch",
    "Deleted": false,
    "EjUserId": 285,
    "UserName": "Denesik-Senger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 567
      }
    }
  },
  "CreatedDate": "2011-10-16T18:25:49.9605614+02:00",
  "AppointmentId": 441,
  "Description": "Quality-focused contextually-based attitude",
  "StartDate": "1998-01-05T18:25:49.9605614+01:00",
  "EndDate": "2001-03-28T18:25:49.9605614+02:00",
  "InvitedPerson": {
    "Position": "incidunt",
    "PersonId": 860,
    "Mrmrs": "sed",
    "Firstname": "Estel",
    "Lastname": "Bartoletti",
    "MiddleName": "Friesen Inc and Sons",
    "Title": "eum",
    "Description": "Business-focused bifurcated approach",
    "Email": "icie_wyman@buckridge.uk",
    "FullName": "Leatha Weissnat",
    "DirectPhone": "1-352-206-6484",
    "FormalName": "Rau LLC",
    "CountryId": 252,
    "ContactId": 357,
    "ContactName": "Powlowski, Haley and Torp",
    "Retired": 503,
    "Rank": 426,
    "ActiveInterests": 303,
    "ContactDepartment": "",
    "ContactCountryId": 256,
    "ContactOrgNr": "408692",
    "FaxPhone": "556.505.8530 x7003",
    "MobilePhone": "(011)237-6878 x6380",
    "ContactPhone": "808.807.2811 x5588",
    "AssociateName": "Hagenes, Senger and Considine",
    "AssociateId": 768,
    "UsePersonAddress": true,
    "ContactFax": "inventore",
    "Kanafname": "placeat",
    "Kanalname": "debitis",
    "Post1": "hic",
    "Post2": "suscipit",
    "Post3": "dicta",
    "EmailName": "magdalen.smith@bernier.info",
    "ContactFullName": "Dejah Altenwerth",
    "ActiveErpLinks": 120,
    "TicketPriorityId": 788,
    "SupportLanguageId": 255,
    "SupportAssociateId": 828,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 897
      }
    }
  },
  "Person": {
    "Position": "ratione",
    "PersonId": 852,
    "Mrmrs": "et",
    "Firstname": "Wendell",
    "Lastname": "Ernser",
    "MiddleName": "Dicki Inc and Sons",
    "Title": "magnam",
    "Description": "Synchronised well-modulated instruction set",
    "Email": "dorothea@ankunding.info",
    "FullName": "Gerry Keeling",
    "DirectPhone": "886-050-0378",
    "FormalName": "Marvin, Bruen and Stoltenberg",
    "CountryId": 813,
    "ContactId": 14,
    "ContactName": "O'Conner LLC",
    "Retired": 994,
    "Rank": 160,
    "ActiveInterests": 152,
    "ContactDepartment": "",
    "ContactCountryId": 252,
    "ContactOrgNr": "719117",
    "FaxPhone": "1-313-145-7023 x14223",
    "MobilePhone": "1-526-614-6627",
    "ContactPhone": "766-344-0523 x628",
    "AssociateName": "Schmidt LLC",
    "AssociateId": 638,
    "UsePersonAddress": false,
    "ContactFax": "quaerat",
    "Kanafname": "maxime",
    "Kanalname": "optio",
    "Post1": "at",
    "Post2": "omnis",
    "Post3": "in",
    "EmailName": "stan_effertz@grimes.biz",
    "ContactFullName": "Mrs. Lesley Bruen",
    "ActiveErpLinks": 689,
    "TicketPriorityId": 832,
    "SupportLanguageId": 994,
    "SupportAssociateId": 780,
    "CategoryName": "VIP Customer",
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
  "MotherId": 809,
  "Priority": {
    "Id": 194,
    "Value": "optio",
    "Tooltip": "quisquam",
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
    "ProjectId": 740,
    "Name": "Rohan, Sporer and O'Conner",
    "Description": "Reactive content-based installation",
    "URL": "http://www.example.com/",
    "Type": "eligendi",
    "AssociateId": 320,
    "AssociateFullName": "Mr. Brant Murray",
    "TypeId": 354,
    "Updated": "1998-02-27T18:25:49.9635633+01:00",
    "StatusId": 993,
    "Status": "vero",
    "TextId": 426,
    "PublishTo": "1994-12-10T18:25:49.9635633+01:00",
    "PublishFrom": "2013-10-13T18:25:49.9635633+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "742738",
    "ActiveErpLinks": 515,
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
  "Type": "BookingForChecklist",
  "UpdatedDate": "2021-02-06T18:25:49.9635633+01:00",
  "Completed": "Completed",
  "ActiveLinks": 876,
  "Links": [
    {
      "EntityName": "Wehner Group",
      "Id": 343,
      "Description": "Business-focused discrete solution",
      "ExtraInfo": "velit",
      "LinkId": 491,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 511
        }
      }
    }
  ],
  "AlarmLeadTime": "quia",
  "HasAlarm": true,
  "ColorIndex": 576,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "animi",
  "LeadTime": "eos",
  "Location": "adipisci",
  "RejectCounter": 400,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 397,
    "StartDate": "2016-08-05T18:25:49.9635633+02:00",
    "EndDate": "2012-11-30T18:25:49.9635633+01:00",
    "RecurrenceCounter": 989,
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
      "AssociateId": 416,
      "PersonId": 883,
      "ContactId": 652,
      "EmailId": 6,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 416,
      "PersonId": 883,
      "ContactId": 652,
      "EmailId": 6,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2007-05-29T18:25:49.9635633+02:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 945,
    "Name": "Doyle-Kling",
    "PersonId": 45,
    "Rank": 417,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 616,
    "FullName": "Dr. Molly Swift",
    "FormalName": "Waelchi, Lindgren and Emmerich",
    "Deleted": true,
    "EjUserId": 191,
    "UserName": "Halvorson-Bosco",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 571
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 637,
    "Name": "Quigley Group",
    "PersonId": 513,
    "Rank": 612,
    "Tooltip": "magnam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 726,
    "FullName": "Camila Veum",
    "FormalName": "Collins Inc and Sons",
    "Deleted": false,
    "EjUserId": 364,
    "UserName": "Walker Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 667
      }
    }
  },
  "Task": {
    "TaskListItemId": 214,
    "Value": "eos",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "numquam",
    "Deleted": true,
    "IntentId": 847,
    "Rank": 192,
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
        "FieldLength": 197
      }
    }
  },
  "PreferredTZLocation": 607,
  "Sale": {
    "ContactName": "Friesen Inc and Sons",
    "SaleDate": "2015-07-08T18:25:49.9645673+02:00",
    "SaleId": 186,
    "Probability": 291,
    "Title": "quia",
    "Amount": 27582.334,
    "Currency": "sapiente",
    "ProjectName": "Doyle-Bechtelar",
    "AssociateFullName": "Don Wintheiser",
    "Description": "Pre-emptive secondary info-mediaries",
    "Status": "Lost",
    "WeightedAmount": 28528.802,
    "ProjectId": 68,
    "EarningPercent": 30387.264,
    "Earning": 13122.057999999999,
    "ContactId": 719,
    "AssociateId": 907,
    "PersonId": 824,
    "SaleTypeId": 803,
    "SaleTypeName": "Lakin Group",
    "PersonFullName": "Stacy Mertz",
    "Completed": "Completed",
    "ActiveErpLinks": 313,
    "NextDueDate": "1997-01-29T18:25:49.9645673+01:00",
    "Number": "1398899",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 408
      }
    }
  },
  "SuggestedAppointmentId": 230,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "et",
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Carmella Deckow"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "non"
  },
  "PublishEventDate": "2018-08-10T18:25:49.965563+02:00",
  "PublishTo": "2016-10-25T18:25:49.965563+02:00",
  "PublishFrom": "2013-07-06T18:25:49.965563+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 337,
      "Visibility": "All",
      "DisplayValue": "sit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 552
        }
      }
    },
    {
      "VisibleId": 337,
      "Visibility": "All",
      "DisplayValue": "sit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 552
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
      "FieldLength": 582
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```