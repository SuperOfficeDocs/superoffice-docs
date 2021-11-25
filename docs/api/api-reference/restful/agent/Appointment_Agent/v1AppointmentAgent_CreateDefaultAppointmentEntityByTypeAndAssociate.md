---
title: POST Agents/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate
id: v1AppointmentAgent_CreateDefaultAppointmentEntityByTypeAndAssociate
---

# POST Agents/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate
```

Creates a AppointmentEntity populated with the default values for the specific type and owner.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate?$select=name,department,category/id
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

Type, AssociateId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Type | string |  |
| AssociateId | int32 |  |


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
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityByTypeAndAssociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Type": "Appointment",
  "AssociateId": 53
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 84,
    "Name": "Parker LLC",
    "PersonId": 516,
    "Rank": 370,
    "Tooltip": "nobis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 868,
    "FullName": "Daisy Lindgren",
    "FormalName": "Rice, Bins and Schiller",
    "Deleted": false,
    "EjUserId": 741,
    "UserName": "Krajcik, Robel and Bradtke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 473
      }
    }
  },
  "Contact": {
    "ContactId": 188,
    "Name": "Weimann, Grimes and Schoen",
    "OrgNr": "1442408",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "fugit",
    "DirectPhone": "412-345-6685 x4351",
    "AssociateId": 771,
    "CountryId": 359,
    "EmailAddress": "evalyn@beatty.name",
    "Kananame": "in",
    "EmailAddressName": "vicky_ankunding@anderson.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Clarissa Hackett",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ea",
    "FullName": "Mrs. Jakob Treutel",
    "IsOwnerContact": true,
    "ActiveErpLinks": 653,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 329
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 110,
    "Name": "Lubowitz LLC",
    "PersonId": 18,
    "Rank": 897,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 274,
    "FullName": "Lew Little",
    "FormalName": "Reichel LLC",
    "Deleted": false,
    "EjUserId": 83,
    "UserName": "Klocko, Johnson and Thompson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 107
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 606,
    "Name": "Schamberger Inc and Sons",
    "PersonId": 986,
    "Rank": 889,
    "Tooltip": "harum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 977,
    "FullName": "Karl Koch",
    "FormalName": "Trantow, Shields and Powlowski",
    "Deleted": true,
    "EjUserId": 653,
    "UserName": "Pfeffer-Huels",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 833
      }
    }
  },
  "CreatedDate": "1995-07-23T18:28:47.7978432+02:00",
  "AppointmentId": 31,
  "Description": "Triple-buffered contextually-based software",
  "StartDate": "2005-06-07T18:28:47.7978432+02:00",
  "EndDate": "2008-08-02T18:28:47.7978432+02:00",
  "InvitedPerson": {
    "Position": "nostrum",
    "PersonId": 916,
    "Mrmrs": "suscipit",
    "Firstname": "Eduardo",
    "Lastname": "Streich",
    "MiddleName": "Volkman LLC",
    "Title": "distinctio",
    "Description": "Implemented mobile solution",
    "Email": "larry.tromp@langworth.com",
    "FullName": "Niko Little",
    "DirectPhone": "826.211.0458",
    "FormalName": "Herzog Inc and Sons",
    "CountryId": 787,
    "ContactId": 143,
    "ContactName": "Schaefer, Keebler and Hilpert",
    "Retired": 353,
    "Rank": 213,
    "ActiveInterests": 116,
    "ContactDepartment": "",
    "ContactCountryId": 315,
    "ContactOrgNr": "983244",
    "FaxPhone": "1-840-877-1801",
    "MobilePhone": "542.025.3784",
    "ContactPhone": "534.318.7731",
    "AssociateName": "Stehr Inc and Sons",
    "AssociateId": 57,
    "UsePersonAddress": false,
    "ContactFax": "dignissimos",
    "Kanafname": "debitis",
    "Kanalname": "beatae",
    "Post1": "esse",
    "Post2": "eos",
    "Post3": "qui",
    "EmailName": "scotty_erdman@sawayn.info",
    "ContactFullName": "Gonzalo Kassulke",
    "ActiveErpLinks": 592,
    "TicketPriorityId": 194,
    "SupportLanguageId": 130,
    "SupportAssociateId": 266,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 658
      }
    }
  },
  "Person": {
    "Position": "perferendis",
    "PersonId": 756,
    "Mrmrs": "necessitatibus",
    "Firstname": "Demarcus",
    "Lastname": "Ankunding",
    "MiddleName": "Grimes, Becker and Abshire",
    "Title": "cupiditate",
    "Description": "De-engineered responsive time-frame",
    "Email": "horacio_cormier@kuhlman.info",
    "FullName": "Aidan Wunsch",
    "DirectPhone": "(677)231-7102 x0801",
    "FormalName": "Schinner LLC",
    "CountryId": 675,
    "ContactId": 905,
    "ContactName": "Hudson-Dach",
    "Retired": 342,
    "Rank": 342,
    "ActiveInterests": 219,
    "ContactDepartment": "",
    "ContactCountryId": 590,
    "ContactOrgNr": "1552234",
    "FaxPhone": "1-872-284-2622 x36753",
    "MobilePhone": "181.318.1524 x44015",
    "ContactPhone": "(213)166-1747",
    "AssociateName": "McDermott-Beier",
    "AssociateId": 719,
    "UsePersonAddress": true,
    "ContactFax": "repellat",
    "Kanafname": "voluptatem",
    "Kanalname": "omnis",
    "Post1": "porro",
    "Post2": "possimus",
    "Post3": "aperiam",
    "EmailName": "aditya@rowe.us",
    "ContactFullName": "Marcellus Denesik",
    "ActiveErpLinks": 127,
    "TicketPriorityId": 297,
    "SupportLanguageId": 407,
    "SupportAssociateId": 795,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 610
      }
    }
  },
  "MotherId": 532,
  "Priority": {
    "Id": 498,
    "Value": "ut",
    "Tooltip": "voluptatum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 507
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 475,
    "Name": "Koelpin-Yundt",
    "Description": "Progressive optimizing projection",
    "URL": "http://www.example.com/",
    "Type": "sed",
    "AssociateId": 197,
    "AssociateFullName": "Neva Herzog",
    "TypeId": 642,
    "Updated": "2006-09-05T18:28:47.7998495+02:00",
    "StatusId": 873,
    "Status": "maxime",
    "TextId": 843,
    "PublishTo": "2017-01-05T18:28:47.7998495+01:00",
    "PublishFrom": "2006-10-17T18:28:47.7998495+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "556553",
    "ActiveErpLinks": 218,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 294
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2017-04-26T18:28:47.7998495+02:00",
  "Completed": "Completed",
  "ActiveLinks": 805,
  "Links": [
    {
      "EntityName": "Dietrich-Quigley",
      "Id": 663,
      "Description": "Front-line optimal alliance",
      "ExtraInfo": "et",
      "LinkId": 193,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 218
        }
      }
    }
  ],
  "AlarmLeadTime": "quia",
  "HasAlarm": false,
  "ColorIndex": 870,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "commodi",
  "LeadTime": "ratione",
  "Location": "est",
  "RejectCounter": 215,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 527,
    "StartDate": "2008-05-12T18:28:47.8008408+02:00",
    "EndDate": "2017-09-13T18:28:47.8008408+02:00",
    "RecurrenceCounter": 30,
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
      "AssociateId": 446,
      "PersonId": 849,
      "ContactId": 211,
      "EmailId": 620,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 446,
      "PersonId": 849,
      "ContactId": 211,
      "EmailId": 620,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1996-09-27T18:28:47.8008408+02:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 473,
    "Name": "Mayer Inc and Sons",
    "PersonId": 689,
    "Rank": 99,
    "Tooltip": "in",
    "Type": "AnonymousAssociate",
    "GroupIdx": 83,
    "FullName": "Ken Johnston IV",
    "FormalName": "Koch-Baumbach",
    "Deleted": false,
    "EjUserId": 39,
    "UserName": "Krajcik-Schinner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "monetize 24/365 communities"
        },
        "FieldType": "System.Int32",
        "FieldLength": 341
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 718,
    "Name": "Steuber, Fahey and Okuneva",
    "PersonId": 303,
    "Rank": 972,
    "Tooltip": "quam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 57,
    "FullName": "Ms. Janis Skiles",
    "FormalName": "Grady Group",
    "Deleted": true,
    "EjUserId": 491,
    "UserName": "Mante-Von",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 677
      }
    }
  },
  "Task": {
    "TaskListItemId": 944,
    "Value": "omnis",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "labore",
    "Deleted": false,
    "IntentId": 208,
    "Rank": 275,
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
        "FieldType": "System.String",
        "FieldLength": 271
      }
    }
  },
  "PreferredTZLocation": 890,
  "Sale": {
    "ContactName": "Koepp Group",
    "SaleDate": "2020-09-07T18:28:47.8018399+02:00",
    "SaleId": 610,
    "Probability": 165,
    "Title": "alias",
    "Amount": 4657.124,
    "Currency": "cum",
    "ProjectName": "Lueilwitz, Muller and Barrows",
    "AssociateFullName": "Lukas Langworth",
    "Description": "Diverse grid-enabled forecast",
    "Status": "Lost",
    "WeightedAmount": 19668.984,
    "ProjectId": 46,
    "EarningPercent": 29641.372,
    "Earning": 702.016,
    "ContactId": 856,
    "AssociateId": 941,
    "PersonId": 882,
    "SaleTypeId": 948,
    "SaleTypeName": "Dickinson Inc and Sons",
    "PersonFullName": "Federico Krajcik V",
    "Completed": "Completed",
    "ActiveErpLinks": 685,
    "NextDueDate": "2003-03-03T18:28:47.8018399+01:00",
    "Number": "1153739",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 649
      }
    }
  },
  "SuggestedAppointmentId": 210,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "reiciendis",
  "UserDefinedFields": {
    "SuperOffice:1": "Kale Moore",
    "SuperOffice:2": "Ms. Elsa Schulist"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "atque"
  },
  "CustomFields": {
    "CustomFields1": "nisi",
    "CustomFields2": "omnis"
  },
  "PublishEventDate": "1995-01-20T18:28:47.8028156+01:00",
  "PublishTo": "1996-11-24T18:28:47.8028156+01:00",
  "PublishFrom": "1999-02-12T18:28:47.8028156+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 530,
      "Visibility": "All",
      "DisplayValue": "vel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 251
        }
      }
    },
    {
      "VisibleId": 530,
      "Visibility": "All",
      "DisplayValue": "vel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 251
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
      "FieldLength": 443
    }
  }
}
```