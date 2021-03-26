---
title: POST Agents/Appointment/CreateDefaultReOpenAppointment
id: v1AppointmentAgent_CreateDefaultReOpenAppointment
---

# POST Agents/Appointment/CreateDefaultReOpenAppointment

```http
POST /api/v1/Agents/Appointment/CreateDefaultReOpenAppointment
```

A re-open appointment should be created as a reminder to re-open the sale at a certain date with information regarding the stalled sale.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/CreateDefaultReOpenAppointment?$select=name,department,category/id
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

SaleId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleId | int32 |  |


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
POST /api/v1/Agents/Appointment/CreateDefaultReOpenAppointment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SaleId": 703
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 313,
    "Name": "Kreiger Group",
    "PersonId": 815,
    "Rank": 231,
    "Tooltip": "nostrum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 282,
    "FullName": "Kaci Schuster I",
    "FormalName": "Deckow, Pfeffer and Baumbach",
    "Deleted": false,
    "EjUserId": 60,
    "UserName": "Jerde Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "matrix synergistic e-markets"
        },
        "FieldType": "System.Int32",
        "FieldLength": 267
      }
    }
  },
  "Contact": {
    "ContactId": 12,
    "Name": "Harris, Klein and Huels",
    "OrgNr": "1404208",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ex",
    "DirectPhone": "(783)643-4185",
    "AssociateId": 692,
    "CountryId": 790,
    "EmailAddress": "jason@kilback.info",
    "Kananame": "sequi",
    "EmailAddressName": "ottilie.gusikowski@hickle.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Bethel Price",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "consequatur",
    "FullName": "Hiram Kreiger",
    "IsOwnerContact": false,
    "ActiveErpLinks": 648,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 592
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 640,
    "Name": "Conroy Inc and Sons",
    "PersonId": 978,
    "Rank": 499,
    "Tooltip": "cum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 481,
    "FullName": "Austin Bailey",
    "FormalName": "Bins LLC",
    "Deleted": true,
    "EjUserId": 65,
    "UserName": "Wintheiser-Hilpert",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 298
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 195,
    "Name": "Wisozk-Effertz",
    "PersonId": 976,
    "Rank": 348,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 147,
    "FullName": "Carmela Witting",
    "FormalName": "Herman-Waelchi",
    "Deleted": false,
    "EjUserId": 163,
    "UserName": "Schoen Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 365
      }
    }
  },
  "CreatedDate": "2011-04-03T16:48:28.7124541+02:00",
  "AppointmentId": 456,
  "Description": "Pre-emptive heuristic conglomeration",
  "StartDate": "2017-10-24T16:48:28.7124541+02:00",
  "EndDate": "2012-03-27T16:48:28.7124541+02:00",
  "InvitedPerson": {
    "Position": "recusandae",
    "PersonId": 785,
    "Mrmrs": "quia",
    "Firstname": "Jamel",
    "Lastname": "Wolff",
    "MiddleName": "Maggio LLC",
    "Title": "illo",
    "Description": "Cross-platform dedicated extranet",
    "Email": "dino.lehner@russelhauck.ca",
    "FullName": "Darrell Macejkovic",
    "DirectPhone": "585-200-5105 x25310",
    "FormalName": "Herman LLC",
    "CountryId": 180,
    "ContactId": 284,
    "ContactName": "Becker Group",
    "Retired": 360,
    "Rank": 410,
    "ActiveInterests": 688,
    "ContactDepartment": "",
    "ContactCountryId": 558,
    "ContactOrgNr": "1008047",
    "FaxPhone": "(765)328-0704 x02084",
    "MobilePhone": "160.240.2651",
    "ContactPhone": "(722)046-6476",
    "AssociateName": "Sporer, Hansen and Goodwin",
    "AssociateId": 657,
    "UsePersonAddress": true,
    "ContactFax": "perferendis",
    "Kanafname": "quo",
    "Kanalname": "sapiente",
    "Post1": "id",
    "Post2": "error",
    "Post3": "autem",
    "EmailName": "jayce_schroeder@mueller.uk",
    "ContactFullName": "Ida Mertz",
    "ActiveErpLinks": 579,
    "TicketPriorityId": 313,
    "SupportLanguageId": 424,
    "SupportAssociateId": 611,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 768
      }
    }
  },
  "Person": {
    "Position": "qui",
    "PersonId": 910,
    "Mrmrs": "qui",
    "Firstname": "Olen",
    "Lastname": "Jacobi",
    "MiddleName": "Veum, Sawayn and Nolan",
    "Title": "recusandae",
    "Description": "Organized exuding product",
    "Email": "shanie@ratke.co.uk",
    "FullName": "Frances Hauck III",
    "DirectPhone": "383-120-7147",
    "FormalName": "Cormier, Bauch and Renner",
    "CountryId": 749,
    "ContactId": 293,
    "ContactName": "Connelly, Franecki and Ondricka",
    "Retired": 2,
    "Rank": 932,
    "ActiveInterests": 646,
    "ContactDepartment": "",
    "ContactCountryId": 520,
    "ContactOrgNr": "479392",
    "FaxPhone": "(754)125-8755",
    "MobilePhone": "113.783.6888",
    "ContactPhone": "410.614.3058 x8628",
    "AssociateName": "Schumm Group",
    "AssociateId": 478,
    "UsePersonAddress": false,
    "ContactFax": "minus",
    "Kanafname": "maxime",
    "Kanalname": "non",
    "Post1": "aut",
    "Post2": "officiis",
    "Post3": "iure",
    "EmailName": "benedict@dicki.co.uk",
    "ContactFullName": "Florence Leffler",
    "ActiveErpLinks": 540,
    "TicketPriorityId": 460,
    "SupportLanguageId": 44,
    "SupportAssociateId": 498,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 927
      }
    }
  },
  "MotherId": 658,
  "Priority": {
    "Id": 562,
    "Value": "corrupti",
    "Tooltip": "explicabo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 10
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 626,
    "Name": "Oberbrunner-Farrell",
    "Description": "Stand-alone impactful pricing structure",
    "URL": "http://www.example.com/",
    "Type": "ipsum",
    "AssociateId": 712,
    "AssociateFullName": "Nellie Goyette",
    "TypeId": 120,
    "Updated": "2015-09-03T16:48:28.7154561+02:00",
    "StatusId": 326,
    "Status": "consequatur",
    "TextId": 251,
    "PublishTo": "1998-09-23T16:48:28.7154561+02:00",
    "PublishFrom": "2017-07-19T16:48:28.7154561+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "221448",
    "ActiveErpLinks": 314,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 13
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "1999-12-17T16:48:28.7154561+01:00",
  "Completed": "Completed",
  "ActiveLinks": 61,
  "Links": [
    {
      "EntityName": "Reynolds-Cruickshank",
      "Id": 892,
      "Description": "Enterprise-wide context-sensitive website",
      "ExtraInfo": "omnis",
      "LinkId": 972,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 614
        }
      }
    }
  ],
  "AlarmLeadTime": "quae",
  "HasAlarm": false,
  "ColorIndex": 776,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "sunt",
  "LeadTime": "amet",
  "Location": "repudiandae",
  "RejectCounter": 931,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 861,
    "StartDate": "2004-03-29T16:48:28.7154561+02:00",
    "EndDate": "2018-01-07T16:48:28.7154561+01:00",
    "RecurrenceCounter": 935,
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
      "AssociateId": 387,
      "PersonId": 41,
      "ContactId": 435,
      "EmailId": 45,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 387,
      "PersonId": 41,
      "ContactId": 435,
      "EmailId": 45,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1994-11-12T16:48:28.7154561+01:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 503,
    "Name": "Lemke Group",
    "PersonId": 245,
    "Rank": 281,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 246,
    "FullName": "Westley Grant",
    "FormalName": "Green LLC",
    "Deleted": false,
    "EjUserId": 144,
    "UserName": "Goyette, McGlynn and Cartwright",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 337
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 733,
    "Name": "Willms-Strosin",
    "PersonId": 719,
    "Rank": 718,
    "Tooltip": "quaerat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 649,
    "FullName": "Mr. Gavin Smitham",
    "FormalName": "Kreiger-Schultz",
    "Deleted": false,
    "EjUserId": 839,
    "UserName": "Corkery Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 231
      }
    }
  },
  "Task": {
    "TaskListItemId": 617,
    "Value": "possimus",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "voluptas",
    "Deleted": false,
    "IntentId": 550,
    "Rank": 753,
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
        "FieldLength": 311
      }
    }
  },
  "PreferredTZLocation": 638,
  "Sale": {
    "ContactName": "Armstrong, Raynor and Brekke",
    "SaleDate": "2012-11-12T16:48:28.7164534+01:00",
    "SaleId": 964,
    "Probability": 145,
    "Title": "amet",
    "Amount": 84.618,
    "Currency": "beatae",
    "ProjectName": "Kuhic Inc and Sons",
    "AssociateFullName": "Jessika Barton",
    "Description": "Assimilated incremental challenge",
    "Status": "Lost",
    "WeightedAmount": 9076.064,
    "ProjectId": 813,
    "EarningPercent": 25535.832,
    "Earning": 25520.162,
    "ContactId": 178,
    "AssociateId": 8,
    "PersonId": 313,
    "SaleTypeId": 118,
    "SaleTypeName": "Steuber, Marquardt and Bartoletti",
    "PersonFullName": "Lawrence Windler",
    "Completed": "Completed",
    "ActiveErpLinks": 76,
    "NextDueDate": "2003-04-27T16:48:28.7164534+02:00",
    "Number": "1307928",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 588
      }
    }
  },
  "SuggestedAppointmentId": 801,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "provident",
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "634086519"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "quos"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "quasi"
  },
  "PublishEventDate": "2016-06-09T16:48:28.7164534+02:00",
  "PublishTo": "2013-12-07T16:48:28.7164534+01:00",
  "PublishFrom": "2007-05-17T16:48:28.7164534+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 24,
      "Visibility": "All",
      "DisplayValue": "pariatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 273
        }
      }
    },
    {
      "VisibleId": 24,
      "Visibility": "All",
      "DisplayValue": "pariatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 273
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
      "FieldLength": 140
    }
  }
}
```