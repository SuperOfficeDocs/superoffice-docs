---
title: POST Agents/Appointment/GetAppointmentEntity
id: v1AppointmentAgent_GetAppointmentEntity
---

# POST Agents/Appointment/GetAppointmentEntity

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
POST /api/v1/Agents/Appointment/GetAppointmentEntity?appointmentEntityId=863
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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 946,
    "Name": "Durgan, Altenwerth and Romaguera",
    "PersonId": 976,
    "Rank": 185,
    "Tooltip": "magni",
    "Type": "AnonymousAssociate",
    "GroupIdx": 563,
    "FullName": "Casandra Konopelski IV",
    "FormalName": "Marks, Runolfsson and Boyer",
    "Deleted": false,
    "EjUserId": 796,
    "UserName": "Stracke Group",
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
  "Contact": {
    "ContactId": 519,
    "Name": "Conn LLC",
    "OrgNr": "1292749",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "fugiat",
    "DirectPhone": "677.841.5406",
    "AssociateId": 755,
    "CountryId": 166,
    "EmailAddress": "lorenzo@vonrueden.name",
    "Kananame": "labore",
    "EmailAddressName": "nolan@hills.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Tiara Farrell",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ab",
    "FullName": "Alfredo Dicki",
    "IsOwnerContact": true,
    "ActiveErpLinks": 271,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 675
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 337,
    "Name": "Wolff Inc and Sons",
    "PersonId": 61,
    "Rank": 354,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 26,
    "FullName": "Jessyca O'Conner",
    "FormalName": "Weissnat-Vandervort",
    "Deleted": false,
    "EjUserId": 429,
    "UserName": "O'Connell Group",
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
  "UpdatedBy": {
    "AssociateId": 825,
    "Name": "Upton LLC",
    "PersonId": 945,
    "Rank": 5,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 905,
    "FullName": "Ottilie Buckridge",
    "FormalName": "Keebler LLC",
    "Deleted": false,
    "EjUserId": 505,
    "UserName": "Batz LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 187
      }
    }
  },
  "CreatedDate": "2003-11-20T16:48:28.5464517+01:00",
  "AppointmentId": 489,
  "Description": "Profit-focused transitional system engine",
  "StartDate": "2004-01-22T16:48:28.5464517+01:00",
  "EndDate": "2001-01-14T16:48:28.5464517+01:00",
  "InvitedPerson": {
    "Position": "quam",
    "PersonId": 238,
    "Mrmrs": "corporis",
    "Firstname": "Vinnie",
    "Lastname": "Kreiger",
    "MiddleName": "Bailey Inc and Sons",
    "Title": "eligendi",
    "Description": "Optimized bandwidth-monitored interface",
    "Email": "nettie@schulist.co.uk",
    "FullName": "Belle Lindgren MD",
    "DirectPhone": "(324)043-2506 x0128",
    "FormalName": "Deckow Inc and Sons",
    "CountryId": 414,
    "ContactId": 902,
    "ContactName": "Prohaska, Beer and Brown",
    "Retired": 372,
    "Rank": 893,
    "ActiveInterests": 872,
    "ContactDepartment": "strategize turn-key e-commerce",
    "ContactCountryId": 317,
    "ContactOrgNr": "1230131",
    "FaxPhone": "514-860-3817 x0467",
    "MobilePhone": "816.588.2111",
    "ContactPhone": "270.333.6537 x606",
    "AssociateName": "Harris, Schulist and Weimann",
    "AssociateId": 285,
    "UsePersonAddress": true,
    "ContactFax": "eos",
    "Kanafname": "et",
    "Kanalname": "totam",
    "Post1": "ab",
    "Post2": "est",
    "Post3": "ut",
    "EmailName": "maximillian@schimmel.info",
    "ContactFullName": "Ismael Ondricka",
    "ActiveErpLinks": 873,
    "TicketPriorityId": 75,
    "SupportLanguageId": 479,
    "SupportAssociateId": 327,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 774
      }
    }
  },
  "Person": {
    "Position": "qui",
    "PersonId": 358,
    "Mrmrs": "illum",
    "Firstname": "Santa",
    "Lastname": "Kiehn",
    "MiddleName": "Monahan, Gusikowski and Waelchi",
    "Title": "sit",
    "Description": "Centralized zero administration analyzer",
    "Email": "emie.mosciski@runte.com",
    "FullName": "Makenzie Kozey",
    "DirectPhone": "(784)352-8480",
    "FormalName": "Simonis-Olson",
    "CountryId": 831,
    "ContactId": 953,
    "ContactName": "Schowalter-Pouros",
    "Retired": 335,
    "Rank": 801,
    "ActiveInterests": 104,
    "ContactDepartment": "",
    "ContactCountryId": 443,
    "ContactOrgNr": "1571659",
    "FaxPhone": "1-671-101-3316",
    "MobilePhone": "400-030-7658 x27331",
    "ContactPhone": "1-683-446-2513",
    "AssociateName": "Wolff, Howe and Kerluke",
    "AssociateId": 282,
    "UsePersonAddress": false,
    "ContactFax": "maxime",
    "Kanafname": "deserunt",
    "Kanalname": "quisquam",
    "Post1": "suscipit",
    "Post2": "voluptatem",
    "Post3": "reprehenderit",
    "EmailName": "aidan@rogahn.biz",
    "ContactFullName": "Rachelle Erdman",
    "ActiveErpLinks": 272,
    "TicketPriorityId": 723,
    "SupportLanguageId": 796,
    "SupportAssociateId": 471,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 851
      }
    }
  },
  "MotherId": 389,
  "Priority": {
    "Id": 132,
    "Value": "officia",
    "Tooltip": "harum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 960
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 30,
    "Name": "Jacobs, Price and Von",
    "Description": "Customer-focused bi-directional interface",
    "URL": "http://www.example.com/",
    "Type": "ipsa",
    "AssociateId": 563,
    "AssociateFullName": "Sadie Stark",
    "TypeId": 38,
    "Updated": "2008-04-07T16:48:28.5494494+02:00",
    "StatusId": 592,
    "Status": "vel",
    "TextId": 797,
    "PublishTo": "2004-10-22T16:48:28.5494494+02:00",
    "PublishFrom": "2019-10-06T16:48:28.5494494+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1709284",
    "ActiveErpLinks": 715,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 661
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "1999-12-12T16:48:28.5494494+01:00",
  "Completed": "Completed",
  "ActiveLinks": 137,
  "Links": [
    {
      "EntityName": "Herzog, Stroman and Bahringer",
      "Id": 880,
      "Description": "Fundamental regional knowledge user",
      "ExtraInfo": "consequatur",
      "LinkId": 827,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 526
        }
      }
    }
  ],
  "AlarmLeadTime": "dolores",
  "HasAlarm": false,
  "ColorIndex": 237,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "explicabo",
  "LeadTime": "facere",
  "Location": "ut",
  "RejectCounter": 682,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 404,
    "StartDate": "2003-05-09T16:48:28.5504496+02:00",
    "EndDate": "1999-10-05T16:48:28.5504496+02:00",
    "RecurrenceCounter": 969,
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
      "AssociateId": 606,
      "PersonId": 570,
      "ContactId": 922,
      "EmailId": 475,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 606,
      "PersonId": 570,
      "ContactId": 922,
      "EmailId": 475,
      "SendEmail": true,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2006-06-23T16:48:28.5504496+02:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 126,
    "Name": "Balistreri, Crooks and Nicolas",
    "PersonId": 543,
    "Rank": 595,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 232,
    "FullName": "Mariah Bernier",
    "FormalName": "Effertz Group",
    "Deleted": true,
    "EjUserId": 43,
    "UserName": "Borer-Ondricka",
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
  "MotherAssociate": {
    "AssociateId": 764,
    "Name": "Nicolas Inc and Sons",
    "PersonId": 140,
    "Rank": 702,
    "Tooltip": "corporis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 750,
    "FullName": "Dayana Auer",
    "FormalName": "Hintz Inc and Sons",
    "Deleted": true,
    "EjUserId": 415,
    "UserName": "Gusikowski-Flatley",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 15
      }
    }
  },
  "Task": {
    "TaskListItemId": 802,
    "Value": "aspernatur",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "rem",
    "Deleted": true,
    "IntentId": 805,
    "Rank": 781,
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
        "FieldLength": 358
      }
    }
  },
  "PreferredTZLocation": 901,
  "Sale": {
    "ContactName": "Conn-Schmeler",
    "SaleDate": "2019-06-23T16:48:28.5504496+02:00",
    "SaleId": 815,
    "Probability": 395,
    "Title": "sit",
    "Amount": 19653.314,
    "Currency": "ea",
    "ProjectName": "Schmeler Inc and Sons",
    "AssociateFullName": "Queenie Buckridge",
    "Description": "Networked needs-based moratorium",
    "Status": "Lost",
    "WeightedAmount": 219.38,
    "ProjectId": 215,
    "EarningPercent": 14526.09,
    "Earning": 29309.167999999998,
    "ContactId": 462,
    "AssociateId": 611,
    "PersonId": 289,
    "SaleTypeId": 846,
    "SaleTypeName": "Swaniawski LLC",
    "PersonFullName": "Trenton Kemmer",
    "Completed": "Completed",
    "ActiveErpLinks": 99,
    "NextDueDate": "2020-03-31T16:48:28.5514501+02:00",
    "Number": "1061659",
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
  },
  "SuggestedAppointmentId": 421,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "temporibus",
  "UserDefinedFields": {
    "SuperOffice:1": "Deborah Pouros",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "magni",
    "ExtraFields2": "repellendus"
  },
  "CustomFields": {
    "CustomFields1": "suscipit",
    "CustomFields2": "quo"
  },
  "PublishEventDate": "1997-02-02T16:48:28.5514501+01:00",
  "PublishTo": "2001-12-19T16:48:28.5514501+01:00",
  "PublishFrom": "1997-08-18T16:48:28.5514501+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 678,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 403
        }
      }
    },
    {
      "VisibleId": 678,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 403
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
      "FieldLength": 502
    }
  }
}
```