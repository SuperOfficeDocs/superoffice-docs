---
title: GET Sale/{id}
id: v1SaleEntity_GetSaleEntity
---

# GET Sale/{id}

```http
GET /api/v1/Sale/{id}
```

Gets a SaleEntity object.

Calls the Sale agent service GetSaleEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the SaleEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Sale/{id}?$select=name,department,category/id
GET /api/v1/Sale/{id}?fk=False
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

The Sale Entity contains the sale amount, currency, and sale members. Sales are linked to contacts, persons, and/or projects.



SaleEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | SaleEntity found. |
| 304 | SaleEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate |  | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy |  | Who updated the sale |
| CreatedBy |  | Who created to sale |
| Contact |  | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project |  | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | string | Text describing the sale |
| Person |  | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency |  | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor |  | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited |  | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating |  | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason |  | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source |  | The sale source  <para>Use MDO List name "source" to get list items.</para> |
| Status | string | The state of the Sale: Open / Sold / Lost / Stalled |
| Saledate | date-time | (expected / lost / won) sales date |
| Amount | double | Total sale amount |
| SaleId | int32 | Primary key |
| Earning | double | Earning on sale |
| EarningPercent | double | Earning as percent of total |
| Heading | string | Sale heading (short description?) |
| Number | string | Alphanumeric user field |
| Probability | int32 | Actual probability, may differ from the one in the list |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated  in UTC. |
| Completed | string | The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| ActiveLinks | int32 | Number of active links to sale, document, appointment. |
| Links | array | List of all elements linked to the sale. |
| NextDueDate | date-time | Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| SaleType |  | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold |  | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled |  | <para>Use MDO List name "reasonstalled" to get list items.</para> |
| ReopenDate | date-time | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | array |  |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.SaleEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
GET /api/v1/Sale/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 SaleEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 20 Nov 2011 18:25:50 G11T

{
  "Appointment": {
    "AppointmentId": 128,
    "StartDate": "2004-12-07T18:25:50.969258+01:00",
    "EndDate": "2011-08-04T18:25:50.969258+02:00",
    "Type": "BookingForChecklist",
    "Task": "qui",
    "AssociateFullName": "Glennie Hagenes",
    "ContactName": "Conroy, McClure and Stanton",
    "Description": "Enhanced disintermediate infrastructure",
    "PersonFullName": "Rhianna Rempel",
    "PersonId": 43,
    "ContactId": 818,
    "ProjectId": 565,
    "ProjectName": "Wiegand, White and Langosh",
    "IsPublished": true,
    "AssociateId": 430,
    "ColorIndex": 686,
    "IsFree": true,
    "HasAlarm": false,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 836,
    "PriorityName": "Monahan, Gleason and Raynor",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": true,
    "IsBooking": true,
    "ActiveDate": "2008-07-13T18:25:50.9702585+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "1997-04-30T18:25:50.9702585+02:00",
    "RecurringEndDate": "1998-12-05T18:25:50.9702585+01:00",
    "MotherId": 791,
    "AssignedBy": 344,
    "AssignedByFullName": "Rosanna Botsford",
    "RejectReason": "",
    "Location": "molestiae",
    "AlarmLeadTime": "harum",
    "SaleId": 619,
    "SaleName": "Quitzon Group",
    "AssociateName": "Jacobson Group",
    "CreatedDate": "2021-07-04T18:25:50.9702585+02:00",
    "CreatedBy": "est",
    "CreatedByFullName": "Margarete Mraz IV",
    "CreatedByAssociateId": 651,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 371
      }
    }
  },
  "Associate": {
    "AssociateId": 493,
    "Name": "Legros Group",
    "PersonId": 557,
    "Rank": 387,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 264,
    "FullName": "Rogelio Weissnat",
    "FormalName": "Mills-Donnelly",
    "Deleted": false,
    "EjUserId": 522,
    "UserName": "Gleichner-Morissette",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 626
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 119,
    "Name": "Cormier, Dietrich and McClure",
    "PersonId": 489,
    "Rank": 728,
    "Tooltip": "voluptate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 602,
    "FullName": "Salvador Jenkins",
    "FormalName": "Hand, Dibbert and Goldner",
    "Deleted": true,
    "EjUserId": 847,
    "UserName": "Renner-Beahan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 556
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 497,
    "Name": "Rolfson LLC",
    "PersonId": 226,
    "Rank": 325,
    "Tooltip": "odio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 933,
    "FullName": "Carol Ryan",
    "FormalName": "Pfeffer LLC",
    "Deleted": true,
    "EjUserId": 3,
    "UserName": "Rempel-Brekke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 736
      }
    }
  },
  "Contact": {
    "ContactId": 662,
    "Name": "Franecki-Howe",
    "OrgNr": "913397",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "recusandae",
    "DirectPhone": "155-335-8135",
    "AssociateId": 116,
    "CountryId": 359,
    "EmailAddress": "marquis.morar@waelchi.info",
    "Kananame": "voluptatem",
    "EmailAddressName": "ken_wiza@zemlak.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ronaldo Torphy",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "debitis",
    "FullName": "Lindsey Dicki",
    "IsOwnerContact": true,
    "ActiveErpLinks": 136,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 622
      }
    }
  },
  "Project": {
    "ProjectId": 305,
    "Name": "Macejkovic-Dicki",
    "Description": "Balanced empowering secured line",
    "URL": "http://www.example.com/",
    "Type": "corrupti",
    "AssociateId": 400,
    "AssociateFullName": "Mrs. Tamara Schulist",
    "TypeId": 380,
    "Updated": "2003-07-30T18:25:50.9722676+02:00",
    "StatusId": 925,
    "Status": "cumque",
    "TextId": 773,
    "PublishTo": "2005-02-07T18:25:50.9722676+01:00",
    "PublishFrom": "2007-10-18T18:25:50.9722676+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "456715",
    "ActiveErpLinks": 843,
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
  "SaleText": "excepturi",
  "Person": {
    "Position": "consequuntur",
    "PersonId": 262,
    "Mrmrs": "velit",
    "Firstname": "Rylee",
    "Lastname": "Watsica",
    "MiddleName": "Ankunding-Barton",
    "Title": "corrupti",
    "Description": "Multi-layered interactive standardization",
    "Email": "raoul.ebert@stanton.co.uk",
    "FullName": "Percival Johnston",
    "DirectPhone": "(100)310-5774 x02023",
    "FormalName": "Mayert, Cronin and Heller",
    "CountryId": 669,
    "ContactId": 775,
    "ContactName": "Koss, Von and Pfeffer",
    "Retired": 103,
    "Rank": 168,
    "ActiveInterests": 664,
    "ContactDepartment": "",
    "ContactCountryId": 122,
    "ContactOrgNr": "1005866",
    "FaxPhone": "862.861.4860 x26118",
    "MobilePhone": "1-235-360-2516 x078",
    "ContactPhone": "504.205.0788",
    "AssociateName": "Rowe, Bernhard and Tromp",
    "AssociateId": 214,
    "UsePersonAddress": true,
    "ContactFax": "tenetur",
    "Kanafname": "sequi",
    "Kanalname": "eligendi",
    "Post1": "sunt",
    "Post2": "rerum",
    "Post3": "qui",
    "EmailName": "abel.murray@hagenes.com",
    "ContactFullName": "Sigrid Bernhard II",
    "ActiveErpLinks": 472,
    "TicketPriorityId": 460,
    "SupportLanguageId": 526,
    "SupportAssociateId": 649,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 339
      }
    }
  },
  "Currency": {
    "Id": 367,
    "Value": "qui",
    "Tooltip": "est",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 236
      }
    }
  },
  "Competitor": {
    "Id": 430,
    "Value": "consectetur",
    "Tooltip": "nemo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 242
      }
    }
  },
  "Credited": {
    "Id": 758,
    "Value": "atque",
    "Tooltip": "voluptates",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 687
      }
    }
  },
  "Rating": {
    "Id": 691,
    "Value": "velit",
    "Tooltip": "labore",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "facilitate bricks-and-clicks applications"
        },
        "FieldType": "System.String",
        "FieldLength": 26
      }
    }
  },
  "Reason": {
    "Id": 261,
    "Value": "dignissimos",
    "Tooltip": "illum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 166
      }
    }
  },
  "Source": {
    "Id": 370,
    "Value": "est",
    "Tooltip": "labore",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 112
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2015-08-02T18:25:50.9742241+02:00",
  "Amount": 22665.088,
  "SaleId": 62,
  "Earning": 17472.05,
  "EarningPercent": 25153.484,
  "Heading": "voluptates",
  "Number": "1128666",
  "Probability": 954,
  "CreatedDate": "1996-02-03T18:25:50.9742241+01:00",
  "UpdatedDate": "2011-11-20T18:25:50.9742241+01:00",
  "Completed": "Completed",
  "ActiveLinks": 887,
  "Links": [
    {
      "EntityName": "Kunde Group",
      "Id": 40,
      "Description": "Cloned asynchronous productivity",
      "ExtraInfo": "fuga",
      "LinkId": 523,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 188
        }
      }
    }
  ],
  "NextDueDate": "2021-10-22T18:25:50.9742241+02:00",
  "Postit": "quis",
  "SaleType": {
    "Id": 32,
    "Value": "ea",
    "Tooltip": "ullam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 910
      }
    }
  },
  "ReasonSold": {
    "Id": 906,
    "Value": "perspiciatis",
    "Tooltip": "modi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 116
      }
    }
  },
  "ReasonStalled": {
    "Id": 742,
    "Value": "vel",
    "Tooltip": "perferendis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 541
      }
    }
  },
  "ReopenDate": "2015-06-03T18:25:50.9752227+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Moore Group",
      "Comment": "facere",
      "StakeholderRoleId": 666,
      "CountryId": 913,
      "PersonId": 752,
      "EmailDescription": "brannon_gulgowski@huels.com",
      "EmailId": 722,
      "EmailAddress": "emmanuel@hamill.ca",
      "PhoneId": 73,
      "ContactName": "Zulauf LLC",
      "ContactId": 788,
      "SaleId": 602,
      "Mrmrs": "sed",
      "Firstname": "Concepcion",
      "MiddleName": "Glover-Hoppe",
      "Lastname": "Grimes",
      "SaleStakeholderId": 181,
      "Rank": 273,
      "Phone": "522.861.3330 x7867",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 76
        }
      }
    }
  ],
  "ActiveErpLinks": 655,
  "UserDefinedFields": {
    "SuperOffice:1": "1620483497",
    "SuperOffice:2": "Alisha McLaughlin MD"
  },
  "ExtraFields": {
    "ExtraFields1": "repudiandae",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "ducimus",
    "CustomFields2": "cum"
  },
  "PublishEventDate": "1994-10-23T18:25:50.9752227+02:00",
  "PublishTo": "2020-01-23T18:25:50.9752227+01:00",
  "PublishFrom": "2020-06-29T18:25:50.9752227+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 874,
      "Visibility": "All",
      "DisplayValue": "illo",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 783
        }
      }
    },
    {
      "VisibleId": 874,
      "Visibility": "All",
      "DisplayValue": "illo",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 783
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
        "Reason": "architect back-end mindshare"
      },
      "FieldType": "System.Int32",
      "FieldLength": 452
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```