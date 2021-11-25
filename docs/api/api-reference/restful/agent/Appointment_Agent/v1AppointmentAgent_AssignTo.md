---
title: POST Agents/Appointment/AssignTo
id: v1AppointmentAgent_AssignTo
---

# POST Agents/Appointment/AssignTo

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 960,
  "Participant": {
    "AssociateId": 797,
    "PersonId": 811,
    "ContactId": 654,
    "EmailId": 547,
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
    "AssociateId": 112,
    "Name": "Turcotte LLC",
    "PersonId": 695,
    "Rank": 669,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 252,
    "FullName": "Alexa Carter",
    "FormalName": "Rippin, Ondricka and Gleichner",
    "Deleted": false,
    "EjUserId": 964,
    "UserName": "Koelpin Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 33
      }
    }
  },
  "Contact": {
    "ContactId": 690,
    "Name": "Koelpin, Schuster and Kuhic",
    "OrgNr": "866761",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "vitae",
    "DirectPhone": "(466)531-1442 x233",
    "AssociateId": 574,
    "CountryId": 440,
    "EmailAddress": "beverly.wintheiser@hageneshudson.biz",
    "Kananame": "at",
    "EmailAddressName": "leo@johns.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Cristal Rosenbaum",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quia",
    "FullName": "Alejandra Armstrong",
    "IsOwnerContact": true,
    "ActiveErpLinks": 144,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 531
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 43,
    "Name": "Beatty LLC",
    "PersonId": 385,
    "Rank": 88,
    "Tooltip": "provident",
    "Type": "AnonymousAssociate",
    "GroupIdx": 121,
    "FullName": "Miss Myriam Dickens",
    "FormalName": "Kautzer-Bartell",
    "Deleted": false,
    "EjUserId": 562,
    "UserName": "Schaefer-Durgan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 551
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 240,
    "Name": "Blanda, Cummings and Waelchi",
    "PersonId": 958,
    "Rank": 610,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 714,
    "FullName": "Caden Parisian",
    "FormalName": "Carter-Bins",
    "Deleted": false,
    "EjUserId": 161,
    "UserName": "Simonis-Smitham",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 487
      }
    }
  },
  "CreatedDate": "2017-12-17T18:28:48.0678554+01:00",
  "AppointmentId": 735,
  "Description": "Reduced stable help-desk",
  "StartDate": "2000-06-07T18:28:48.0678554+02:00",
  "EndDate": "2002-02-19T18:28:48.0678554+01:00",
  "InvitedPerson": {
    "Position": "pariatur",
    "PersonId": 79,
    "Mrmrs": "aut",
    "Firstname": "Clovis",
    "Lastname": "Bednar",
    "MiddleName": "Jenkins Group",
    "Title": "porro",
    "Description": "Balanced stable structure",
    "Email": "marcel.dare@green.uk",
    "FullName": "Alessandra Bednar",
    "DirectPhone": "775-388-2275 x503",
    "FormalName": "Gerlach LLC",
    "CountryId": 858,
    "ContactId": 334,
    "ContactName": "Beier LLC",
    "Retired": 265,
    "Rank": 752,
    "ActiveInterests": 76,
    "ContactDepartment": "",
    "ContactCountryId": 260,
    "ContactOrgNr": "1109504",
    "FaxPhone": "1-453-862-2752",
    "MobilePhone": "740.300.6002 x4168",
    "ContactPhone": "414.652.7138 x2167",
    "AssociateName": "McGlynn, Franecki and Botsford",
    "AssociateId": 539,
    "UsePersonAddress": true,
    "ContactFax": "numquam",
    "Kanafname": "et",
    "Kanalname": "cupiditate",
    "Post1": "ea",
    "Post2": "et",
    "Post3": "qui",
    "EmailName": "ward_cummings@watsica.ca",
    "ContactFullName": "Erika O'Reilly",
    "ActiveErpLinks": 454,
    "TicketPriorityId": 778,
    "SupportLanguageId": 854,
    "SupportAssociateId": 59,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 296
      }
    }
  },
  "Person": {
    "Position": "neque",
    "PersonId": 731,
    "Mrmrs": "suscipit",
    "Firstname": "Osbaldo",
    "Lastname": "Kertzmann",
    "MiddleName": "Conroy LLC",
    "Title": "reprehenderit",
    "Description": "Multi-layered heuristic installation",
    "Email": "meaghan@schmidt.us",
    "FullName": "Zoe Greenholt",
    "DirectPhone": "482.744.3054 x5123",
    "FormalName": "Thompson-VonRueden",
    "CountryId": 431,
    "ContactId": 966,
    "ContactName": "Wehner-Dickens",
    "Retired": 4,
    "Rank": 277,
    "ActiveInterests": 593,
    "ContactDepartment": "",
    "ContactCountryId": 977,
    "ContactOrgNr": "712611",
    "FaxPhone": "413.777.1160 x02788",
    "MobilePhone": "(373)330-0673",
    "ContactPhone": "(011)505-5836 x35466",
    "AssociateName": "Walker, Konopelski and Nitzsche",
    "AssociateId": 324,
    "UsePersonAddress": true,
    "ContactFax": "cupiditate",
    "Kanafname": "dolorem",
    "Kanalname": "quasi",
    "Post1": "velit",
    "Post2": "eligendi",
    "Post3": "molestiae",
    "EmailName": "brianne_macejkovic@abbottokeefe.com",
    "ContactFullName": "Juvenal Hagenes",
    "ActiveErpLinks": 989,
    "TicketPriorityId": 240,
    "SupportLanguageId": 916,
    "SupportAssociateId": 652,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 277
      }
    }
  },
  "MotherId": 213,
  "Priority": {
    "Id": 39,
    "Value": "tempore",
    "Tooltip": "dolorem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 51
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 272,
    "Name": "Howell Inc and Sons",
    "Description": "Object-based methodical policy",
    "URL": "http://www.example.com/",
    "Type": "odio",
    "AssociateId": 470,
    "AssociateFullName": "Asia Barrows",
    "TypeId": 811,
    "Updated": "2016-02-04T18:28:48.0698505+01:00",
    "StatusId": 960,
    "Status": "recusandae",
    "TextId": 420,
    "PublishTo": "1997-02-25T18:28:48.0698505+01:00",
    "PublishFrom": "2019-12-22T18:28:48.0698505+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1233630",
    "ActiveErpLinks": 391,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 397
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2000-12-03T18:28:48.0698505+01:00",
  "Completed": "Completed",
  "ActiveLinks": 185,
  "Links": [
    {
      "EntityName": "Gibson-Franecki",
      "Id": 600,
      "Description": "Compatible fresh-thinking analyzer",
      "ExtraInfo": "ratione",
      "LinkId": 673,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 834
        }
      }
    }
  ],
  "AlarmLeadTime": "atque",
  "HasAlarm": true,
  "ColorIndex": 467,
  "IsFree": true,
  "IsAlldayEvent": true,
  "LagTime": "quos",
  "LeadTime": "est",
  "Location": "facere",
  "RejectCounter": 364,
  "RejectReason": "deploy impactful action-items",
  "Recurrence": {
    "RecurrenceId": 704,
    "StartDate": "1997-02-26T18:28:48.0708497+01:00",
    "EndDate": "1997-02-04T18:28:48.0708497+01:00",
    "RecurrenceCounter": 594,
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
      "AssociateId": 833,
      "PersonId": 519,
      "ContactId": 366,
      "EmailId": 958,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 833,
      "PersonId": 519,
      "ContactId": 366,
      "EmailId": 958,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2013-07-17T18:28:48.0708497+02:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 809,
    "Name": "Murazik LLC",
    "PersonId": 932,
    "Rank": 39,
    "Tooltip": "perferendis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 28,
    "FullName": "America VonRueden",
    "FormalName": "Herman-Hane",
    "Deleted": true,
    "EjUserId": 323,
    "UserName": "Ferry Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 786
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 789,
    "Name": "Marks Group",
    "PersonId": 40,
    "Rank": 981,
    "Tooltip": "inventore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 636,
    "FullName": "Milford Feil",
    "FormalName": "Stroman, O'Conner and Lemke",
    "Deleted": true,
    "EjUserId": 335,
    "UserName": "Koepp-Kihn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 506
      }
    }
  },
  "Task": {
    "TaskListItemId": 272,
    "Value": "et",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "asperiores",
    "Deleted": false,
    "IntentId": 144,
    "Rank": 849,
    "IsDefaultAlldayEvent": true,
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
        "FieldLength": 747
      }
    }
  },
  "PreferredTZLocation": 609,
  "Sale": {
    "ContactName": "Hegmann, Daniel and McKenzie",
    "SaleDate": "2000-06-24T18:28:48.0708497+02:00",
    "SaleId": 156,
    "Probability": 516,
    "Title": "voluptatem",
    "Amount": 10715.145999999999,
    "Currency": "alias",
    "ProjectName": "Lemke, Quigley and Volkman",
    "AssociateFullName": "Derick Heathcote",
    "Description": "Expanded object-oriented knowledge base",
    "Status": "Lost",
    "WeightedAmount": 655.006,
    "ProjectId": 280,
    "EarningPercent": 13175.336,
    "Earning": 25119.01,
    "ContactId": 288,
    "AssociateId": 462,
    "PersonId": 472,
    "SaleTypeId": 65,
    "SaleTypeName": "Senger-Jewess",
    "PersonFullName": "Theresia Fadel",
    "Completed": "Completed",
    "ActiveErpLinks": 501,
    "NextDueDate": "2018-03-21T18:28:48.07185+01:00",
    "Number": "1673105",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 370
      }
    }
  },
  "SuggestedAppointmentId": 239,
  "IsMileStone": true,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "alias",
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Candace Hagenes"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquid",
    "ExtraFields2": "nobis"
  },
  "CustomFields": {
    "CustomFields1": "minima",
    "CustomFields2": "dolor"
  },
  "PublishEventDate": "2009-04-22T18:28:48.07185+02:00",
  "PublishTo": "1997-05-07T18:28:48.07185+02:00",
  "PublishFrom": "2000-05-25T18:28:48.07185+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 517,
      "Visibility": "All",
      "DisplayValue": "dignissimos",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 912
        }
      }
    },
    {
      "VisibleId": 517,
      "Visibility": "All",
      "DisplayValue": "dignissimos",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 912
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
      "FieldLength": 469
    }
  }
}
```