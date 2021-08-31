---
title: GetAppointmentFromUID
id: v1AppointmentAgent_GetAppointmentFromUID
---

# GetAppointmentFromUID

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "UID": "pariatur"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Associate": {
    "AssociateId": 285,
    "Name": "Homenick-Osinski",
    "PersonId": 274,
    "Rank": 874,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 55,
    "FullName": "Perry Deckow",
    "FormalName": "Mertz, Stark and Crona",
    "Deleted": false,
    "EjUserId": 502,
    "UserName": "Mante, Donnelly and Thiel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 732
      }
    }
  },
  "Contact": {
    "ContactId": 149,
    "Name": "Tromp, Ondricka and Ryan",
    "OrgNr": "1422749",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "amet",
    "DirectPhone": "(070)171-2624",
    "AssociateId": 719,
    "CountryId": 274,
    "EmailAddress": "minnie_haley@bogan.ca",
    "Kananame": "rem",
    "EmailAddressName": "elbert@denesik.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Lawrence Gislason",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nam",
    "FullName": "Lilliana O'Connell",
    "IsOwnerContact": false,
    "ActiveErpLinks": 370,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 824
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 573,
    "Name": "Kautzer LLC",
    "PersonId": 160,
    "Rank": 945,
    "Tooltip": "cupiditate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 402,
    "FullName": "Laila Dare",
    "FormalName": "Quitzon-Schmeler",
    "Deleted": false,
    "EjUserId": 682,
    "UserName": "Hagenes, Schroeder and Murazik",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 844
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 101,
    "Name": "Price, Smitham and Rolfson",
    "PersonId": 45,
    "Rank": 142,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 864,
    "FullName": "Albin Kihn",
    "FormalName": "Keebler, Ernser and Stracke",
    "Deleted": false,
    "EjUserId": 75,
    "UserName": "Auer, Wehner and Schumm",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 149
      }
    }
  },
  "CreatedDate": "2021-05-14T14:58:03.0295381+02:00",
  "AppointmentId": 944,
  "Description": "Advanced assymetric protocol",
  "StartDate": "2012-12-30T14:58:03.0295381+01:00",
  "EndDate": "1998-07-30T14:58:03.0295381+02:00",
  "InvitedPerson": {
    "Position": "dolorem",
    "PersonId": 539,
    "Mrmrs": "rem",
    "Firstname": "Isidro",
    "Lastname": "Von",
    "MiddleName": "Schoen, Weber and Dach",
    "Title": "vel",
    "Description": "Organic exuding groupware",
    "Email": "jaylen@cartwrightbode.name",
    "FullName": "Imani Bradtke",
    "DirectPhone": "828-868-6535",
    "FormalName": "Emard, Howell and Muller",
    "CountryId": 807,
    "ContactId": 317,
    "ContactName": "Thompson Inc and Sons",
    "Retired": 998,
    "Rank": 458,
    "ActiveInterests": 588,
    "ContactDepartment": "",
    "ContactCountryId": 540,
    "ContactOrgNr": "1251596",
    "FaxPhone": "(164)804-2466",
    "MobilePhone": "1-118-716-6108 x26701",
    "ContactPhone": "1-635-321-6477",
    "AssociateName": "McKenzie, Orn and Casper",
    "AssociateId": 170,
    "UsePersonAddress": true,
    "ContactFax": "numquam",
    "Kanafname": "ab",
    "Kanalname": "cum",
    "Post1": "eos",
    "Post2": "et",
    "Post3": "commodi",
    "EmailName": "zane_wehner@kiehn.co.uk",
    "ContactFullName": "Marcelino Zboncak",
    "ActiveErpLinks": 463,
    "TicketPriorityId": 437,
    "SupportLanguageId": 938,
    "SupportAssociateId": 367,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "grow holistic mindshare"
        },
        "FieldType": "System.Int32",
        "FieldLength": 197
      }
    }
  },
  "Person": {
    "Position": "veniam",
    "PersonId": 169,
    "Mrmrs": "quasi",
    "Firstname": "Alivia",
    "Lastname": "Romaguera",
    "MiddleName": "Rogahn-Okuneva",
    "Title": "harum",
    "Description": "Switchable clear-thinking parallelism",
    "Email": "damian_carter@franecki.biz",
    "FullName": "Leslie Robel",
    "DirectPhone": "660-456-7156",
    "FormalName": "Kessler-Altenwerth",
    "CountryId": 297,
    "ContactId": 723,
    "ContactName": "Harber, Brekke and Schmitt",
    "Retired": 92,
    "Rank": 206,
    "ActiveInterests": 374,
    "ContactDepartment": "",
    "ContactCountryId": 260,
    "ContactOrgNr": "986143",
    "FaxPhone": "(804)532-0886",
    "MobilePhone": "1-680-000-7107",
    "ContactPhone": "1-534-757-3261 x857",
    "AssociateName": "Brakus Inc and Sons",
    "AssociateId": 950,
    "UsePersonAddress": true,
    "ContactFax": "ullam",
    "Kanafname": "consectetur",
    "Kanalname": "vel",
    "Post1": "ipsa",
    "Post2": "ullam",
    "Post3": "molestiae",
    "EmailName": "jordi@johnson.com",
    "ContactFullName": "Miss Marie Fisher",
    "ActiveErpLinks": 611,
    "TicketPriorityId": 640,
    "SupportLanguageId": 974,
    "SupportAssociateId": 944,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 956
      }
    }
  },
  "MotherId": 973,
  "Priority": {
    "Id": 873,
    "Value": "illo",
    "Tooltip": "quos",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 100
      }
    }
  },
  "Private": "PrivateGroup",
  "Project": {
    "ProjectId": 610,
    "Name": "Bogisich-Stokes",
    "Description": "Fundamental zero defect infrastructure",
    "URL": "http://www.example.com/",
    "Type": "et",
    "AssociateId": 687,
    "AssociateFullName": "Aletha Halvorson",
    "TypeId": 436,
    "Updated": "2001-08-29T14:58:03.0325382+02:00",
    "StatusId": 691,
    "Status": "eius",
    "TextId": 270,
    "PublishTo": "2003-11-19T14:58:03.0325382+01:00",
    "PublishFrom": "2006-08-04T14:58:03.0325382+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "534088",
    "ActiveErpLinks": 545,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "seize wireless models"
        },
        "FieldType": "System.String",
        "FieldLength": 969
      }
    }
  },
  "Type": "BookingForChecklist",
  "UpdatedDate": "2002-09-30T14:58:03.0325382+02:00",
  "Completed": "Completed",
  "ActiveLinks": 608,
  "Links": [
    {
      "EntityName": "Satterfield-Nikolaus",
      "Id": 964,
      "Description": "Ergonomic 24 hour process improvement",
      "ExtraInfo": "accusantium",
      "LinkId": 843,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 804
        }
      }
    }
  ],
  "AlarmLeadTime": "eius",
  "HasAlarm": false,
  "ColorIndex": 450,
  "IsFree": true,
  "IsAlldayEvent": false,
  "LagTime": "omnis",
  "LeadTime": "temporibus",
  "Location": "odit",
  "RejectCounter": 506,
  "RejectReason": "",
  "Recurrence": {
    "RecurrenceId": 719,
    "StartDate": "1994-11-02T14:58:03.0325382+01:00",
    "EndDate": "2020-12-12T14:58:03.0325382+01:00",
    "RecurrenceCounter": 629,
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
      "AssociateId": 394,
      "PersonId": 579,
      "ContactId": 308,
      "EmailId": 404,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    },
    {
      "AssociateId": 394,
      "PersonId": 579,
      "ContactId": 308,
      "EmailId": 404,
      "SendEmail": false,
      "InvitationStatus": "Accepted"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "1994-12-02T14:58:03.0325382+01:00",
  "HasConflict": false,
  "AssignedBy": {
    "AssociateId": 974,
    "Name": "Crooks Group",
    "PersonId": 50,
    "Rank": 556,
    "Tooltip": "nemo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 762,
    "FullName": "Rowan Cassin",
    "FormalName": "Kuvalis Inc and Sons",
    "Deleted": false,
    "EjUserId": 46,
    "UserName": "Wehner, Funk and Goyette",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "expedite seamless paradigms"
        },
        "FieldType": "System.String",
        "FieldLength": 680
      }
    }
  },
  "MotherAssociate": {
    "AssociateId": 491,
    "Name": "Moore-Schulist",
    "PersonId": 312,
    "Rank": 134,
    "Tooltip": "error",
    "Type": "AnonymousAssociate",
    "GroupIdx": 933,
    "FullName": "Eriberto Bednar",
    "FormalName": "Jaskolski, Ward and Reinger",
    "Deleted": true,
    "EjUserId": 262,
    "UserName": "Baumbach LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 272
      }
    }
  },
  "Task": {
    "TaskListItemId": 693,
    "Value": "aut",
    "Direction": "Incoming",
    "Type": "Appointment",
    "Tooltip": "blanditiis",
    "Deleted": false,
    "IntentId": 691,
    "Rank": 303,
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
        "FieldLength": 346
      }
    }
  },
  "PreferredTZLocation": 615,
  "Sale": {
    "ContactName": "Harvey Inc and Sons",
    "SaleDate": "2015-07-25T14:58:03.0335382+02:00",
    "SaleId": 916,
    "Probability": 432,
    "Title": "vel",
    "Amount": 19925.971999999998,
    "Currency": "sed",
    "ProjectName": "Rutherford, Batz and Kessler",
    "AssociateFullName": "Kavon Stoltenberg IV",
    "Description": "Versatile systemic hardware",
    "Status": "Lost",
    "WeightedAmount": 3343.978,
    "ProjectId": 80,
    "EarningPercent": 21596.394,
    "Earning": 11476.707999999999,
    "ContactId": 252,
    "AssociateId": 33,
    "PersonId": 568,
    "SaleTypeId": 806,
    "SaleTypeName": "Lind LLC",
    "PersonFullName": "Mrs. Brycen Schaefer",
    "Completed": "Completed",
    "ActiveErpLinks": 8,
    "NextDueDate": "2001-11-22T14:58:03.0335382+01:00",
    "Number": "1636965",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "embrace global users"
        },
        "FieldType": "System.String",
        "FieldLength": 874
      }
    }
  },
  "SuggestedAppointmentId": 925,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "JoinVideomeetUrl": "http://www.example.com/",
  "CentralserviceVideomeetId": "maxime",
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. D'angelo Bergnaum",
    "SuperOffice:2": "1675263968"
  },
  "ExtraFields": {
    "ExtraFields1": "ullam",
    "ExtraFields2": "amet"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "doloribus"
  },
  "PublishEventDate": "2000-09-12T14:58:03.0335382+02:00",
  "PublishTo": "2003-05-12T14:58:03.0335382+02:00",
  "PublishFrom": "2008-04-26T14:58:03.0335382+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 229,
      "Visibility": "All",
      "DisplayValue": "consequatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 684
        }
      }
    },
    {
      "VisibleId": 229,
      "Visibility": "All",
      "DisplayValue": "consequatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 684
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
      "FieldLength": 684
    }
  }
}
```