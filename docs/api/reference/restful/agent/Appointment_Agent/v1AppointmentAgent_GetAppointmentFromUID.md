---
title: POST Agents/Appointment/GetAppointmentFromUID
id: v1AppointmentAgent_GetAppointmentFromUID
---

# POST Agents/Appointment/GetAppointmentFromUID

```http
POST /api/v1/Agents/Appointment/GetAppointmentFromUID
```

Get the appointment that corresponds to the given UID.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetAppointmentFromUID?$select=name,department,category/id
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

UID 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UID | string |  |


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
POST /api/v1/Agents/Appointment/GetAppointmentFromUID
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UID": "ad"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 161,
    "Name": "Borer Group",
    "PersonId": 441,
    "Rank": 126,
    "Tooltip": "laborum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 28,
    "FullName": "Flavie Padberg",
    "FormalName": "Green, Cremin and Green",
    "Deleted": true,
    "EjUserId": 173,
    "UserName": "Fritsch Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 849
      }
    }
  },
  "Contact": {
    "ContactId": 746,
    "Name": "Mills, Gerhold and Dickens",
    "OrgNr": "1955972",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "neque",
    "DirectPhone": "215-710-2472 x728",
    "AssociateId": 75,
    "CountryId": 828,
    "EmailAddress": "norberto@kreigergulgowski.name",
    "Kananame": "deserunt",
    "EmailAddressName": "aiyana@bahringer.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Garret Roberts",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nihil",
    "FullName": "Eudora Lynch",
    "IsOwnerContact": true,
    "ActiveErpLinks": 77,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 489
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 568,
    "Name": "Kovacek, Nader and Denesik",
    "PersonId": 365,
    "Rank": 667,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 865,
    "FullName": "Rodolfo Lindgren",
    "FormalName": "Stanton Inc and Sons",
    "Deleted": true,
    "EjUserId": 405,
    "UserName": "Labadie-Ullrich",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "incentivize revolutionary supply-chains"
        },
        "FieldType": "System.String",
        "FieldLength": 484
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 516,
    "Name": "Langworth, Ferry and Wunsch",
    "PersonId": 26,
    "Rank": 471,
    "Tooltip": "autem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 475,
    "FullName": "Bulah Olson",
    "FormalName": "Gislason Inc and Sons",
    "Deleted": true,
    "EjUserId": 795,
    "UserName": "Keebler Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 981
      }
    }
  },
  "CreatedDate": "2003-10-19T18:28:47.8718451+02:00",
  "AppointmentId": 821,
  "Description": "Grass-roots explicit archive",
  "StartDate": "1997-12-14T18:28:47.8718451+01:00",
  "EndDate": "1996-08-17T18:28:47.8718451+02:00",
  "InvitedPerson": {
    "Position": "velit",
    "PersonId": 833,
    "Mrmrs": "corporis",
    "Firstname": "Rudy",
    "Lastname": "Larson",
    "MiddleName": "Gutkowski, Schimmel and Eichmann",
    "Title": "nemo",
    "Description": "Horizontal content-based analyzer",
    "Email": "ayana_powlowski@bechtelarmoen.us",
    "FullName": "Camren Abernathy II",
    "DirectPhone": "106-533-4187 x2251",
    "FormalName": "Heathcote LLC",
    "CountryId": 783,
    "ContactId": 619,
    "ContactName": "Runte-Kutch",
    "Retired": 274,
    "Rank": 151,
    "ActiveInterests": 181,
    "ContactDepartment": "",
    "ContactCountryId": 691,
    "ContactOrgNr": "1108552",
    "FaxPhone": "171-117-4288",
    "MobilePhone": "782.537.8486 x3387",
    "ContactPhone": "(653)767-6663 x1402",
    "AssociateName": "Carter, Senger and O'Kon",
    "AssociateId": 639,
    "UsePersonAddress": false,
    "ContactFax": "eaque",
    "Kanafname": "possimus",
    "Kanalname": "voluptas",
    "Post1": "unde",
    "Post2": "dolor",
    "Post3": "non",
    "EmailName": "hershel@thompson.co.uk",
    "ContactFullName": "Sydnee Cremin I",
    "ActiveErpLinks": 525,
    "TicketPriorityId": 219,
    "SupportLanguageId": 304,
    "SupportAssociateId": 398,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 571
      }
    }
  },
  "Person": {
    "Position": "qui",
    "PersonId": 310,
    "Mrmrs": "sed",
    "Firstname": "Matteo",
    "Lastname": "Boyle",
    "MiddleName": "Deckow-West",
    "Title": "qui",
    "Description": "Digitized upward-trending toolset",
    "Email": "dallin_gislason@durgan.biz",
    "FullName": "Ethyl Langosh",
    "DirectPhone": "(427)848-2682",
    "FormalName": "Hettinger Group",
    "CountryId": 252,
    "ContactId": 936,
    "ContactName": "Cole Inc and Sons",
    "Retired": 48,
    "Rank": 595,
    "ActiveInterests": 248,
    "ContactDepartment": "",
    "ContactCountryId": 177,
    "ContactOrgNr": "1224981",
    "FaxPhone": "1-372-517-1718",
    "MobilePhone": "(762)620-8281",
    "ContactPhone": "615.628.0004 x03533",
    "AssociateName": "Botsford LLC",
    "AssociateId": 186,
    "UsePersonAddress": false,
    "ContactFax": "perferendis",
    "Kanafname": "minima",
    "Kanalname": "illum",
    "Post1": "perferendis",
    "Post2": "incidunt",
    "Post3": "consequatur",
    "EmailName": "gus.dubuque@johns.info",
    "ContactFullName": "Roberta Little PhD",
    "ActiveErpLinks": 351,
    "TicketPriorityId": 641,
    "SupportLanguageId": 302,
    "SupportAssociateId": 813,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 718
      }
    }
  },
  "MotherId": 247,
  "Priority": {
    "Id": 913,
    "Value": "ut",
    "Tooltip": "ducimus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 674
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 504,
    "Name": "Kihn Inc and Sons",
    "Description": "Function-based composite forecast",
    "URL": "http://www.example.com/",
    "Type": "doloremque",
    "AssociateId": 926,
    "AssociateFullName": "Stewart Daugherty MD",
    "TypeId": 448,
    "Updated": "1995-05-26T18:28:47.8748452+02:00",
    "StatusId": 178,
    "Status": "sed",
    "TextId": 710,
    "PublishTo": "2011-07-31T18:28:47.8748452+02:00",
    "PublishFrom": "2014-03-21T18:28:47.8748452+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1147552",
    "ActiveErpLinks": 310,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 21
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2000-10-10T18:28:47.8748452+02:00",
  "Completed": "Completed",
  "ActiveLinks": 980,
  "Links": [
    {
      "EntityName": "Schumm Group",
      "Id": 457,
      "Description": "Virtual methodical flexibility",
      "ExtraInfo": "est",
      "LinkId": 794,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 237
        }
      }
    }
  ],
  "AlarmLeadTime": "deleniti",
  "HasAlarm": true,
  "ColorIndex": 425,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "modi",
  "LeadTime": "autem",
  "Location": "sit",
  "RejectCounter": 911,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 701,
    "StartDate": "2021-07-17T18:28:47.8748452+02:00",
    "EndDate": "2003-02-08T18:28:47.8748452+01:00",
    "RecurrenceCounter": 404,
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
      "AssociateId": 630,
      "PersonId": 65,
      "ContactId": 723,
      "EmailId": 626,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 630,
      "PersonId": 65,
      "ContactId": 723,
      "EmailId": 626,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2005-12-17T18:28:47.8748452+01:00",
  "HasConflict": true,
  "AssignedBy": {
    "AssociateId": 730,
    "Name": "Sawayn LLC",
    "PersonId": 724,
    "Rank": 816,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 825,
    "FullName": "Mr. Norris Wilkinson",
    "FormalName": "Oberbrunner, Kreiger and Rath",
    "Deleted": true,
    "EjUserId": 670,
    "UserName": "Hodkiewicz-Morissette",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 801
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 210,
    "Name": "Goyette-O'Reilly",
    "PersonId": 231,
    "Rank": 211,
    "Tooltip": "nostrum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 905,
    "FullName": "Einar Swaniawski III",
    "FormalName": "Prohaska, Schimmel and Lemke",
    "Deleted": false,
    "EjUserId": 958,
    "UserName": "Waelchi, Reinger and Rau",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 914
      }
    }
  },
  "Task": {
    "TaskListItemId": 351,
    "Value": "ut",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "placeat",
    "Deleted": false,
    "IntentId": 218,
    "Rank": 159,
    "IsDefaultAlldayEvent": false,
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
        "FieldType": "System.Int32",
        "FieldLength": 235
      }
    }
  },
  "PreferredTZLocation": 224,
  "Sale": {
    "ContactName": "Padberg-Schuster",
    "SaleDate": "2002-06-20T18:28:47.8758165+02:00",
    "SaleId": 463,
    "Probability": 620,
    "Title": "quis",
    "Amount": 27027.615999999998,
    "Currency": "qui",
    "ProjectName": "Grimes, Greenfelder and Weimann",
    "AssociateFullName": "Frank Cartwright",
    "Description": "Customizable systematic open system",
    "Status": "Lost",
    "WeightedAmount": 15215.57,
    "ProjectId": 640,
    "EarningPercent": 21035.408,
    "Earning": 1570.134,
    "ContactId": 398,
    "AssociateId": 8,
    "PersonId": 74,
    "SaleTypeId": 986,
    "SaleTypeName": "Johnston-Crona",
    "PersonFullName": "Dion Osinski",
    "Completed": "Completed",
    "ActiveErpLinks": 832,
    "NextDueDate": "2004-12-03T18:28:47.8768165+01:00",
    "Number": "1414112",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 336
      }
    }
  },
  "SuggestedAppointmentId": 27,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "praesentium",
  "UserDefinedFields": {
    "SuperOffice:1": "333870856",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "consectetur",
    "ExtraFields2": "eaque"
  },
  "CustomFields": {
    "CustomFields1": "modi",
    "CustomFields2": "numquam"
  },
  "PublishEventDate": "1997-11-16T18:28:47.8768165+01:00",
  "PublishTo": "2018-06-20T18:28:47.8768165+02:00",
  "PublishFrom": "2010-12-20T18:28:47.8768165+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 607,
      "Visibility": "All",
      "DisplayValue": "facere",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 973
        }
      }
    },
    {
      "VisibleId": 607,
      "Visibility": "All",
      "DisplayValue": "facere",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 973
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
      "FieldLength": 446
    }
  }
}
```