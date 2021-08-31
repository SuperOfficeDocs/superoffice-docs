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
GET /api/v1/Sale/{id}?fk=True
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
Accept-Language: *
```

```http_
HTTP/1.1 200 SaleEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 04 May 2013 15:05:42 G5T

{
  "Appointment": {
    "AppointmentId": 294,
    "StartDate": "2020-03-04T15:05:42.6186324+01:00",
    "EndDate": "2015-09-10T15:05:42.6186324+02:00",
    "Type": "BookingForChecklist",
    "Task": "dolores",
    "AssociateFullName": "Emelie Prosacco",
    "ContactName": "Casper, Lind and Stoltenberg",
    "Description": "User-friendly bandwidth-monitored product",
    "PersonFullName": "Chanel Frami",
    "PersonId": 643,
    "ContactId": 833,
    "ProjectId": 351,
    "ProjectName": "Marvin Group",
    "IsPublished": false,
    "AssociateId": 342,
    "ColorIndex": 197,
    "IsFree": true,
    "HasAlarm": true,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 877,
    "PriorityName": "Schamberger-Rodriguez",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": true,
    "IsBooking": false,
    "ActiveDate": "2021-08-21T15:05:42.6196329+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "1995-09-30T15:05:42.6196329+02:00",
    "RecurringEndDate": "2004-12-25T15:05:42.6196329+01:00",
    "MotherId": 959,
    "AssignedBy": 444,
    "AssignedByFullName": "Daphnee Barton",
    "RejectReason": "",
    "Location": "earum",
    "AlarmLeadTime": "facilis",
    "SaleId": 410,
    "SaleName": "Crist, Pfeffer and Ullrich",
    "AssociateName": "Franecki LLC",
    "CreatedDate": "2003-06-20T15:05:42.6196329+02:00",
    "CreatedBy": "ipsum",
    "CreatedByFullName": "Forest Halvorson",
    "CreatedByAssociateId": 22,
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
        "FieldLength": 105
      }
    }
  },
  "Associate": {
    "AssociateId": 746,
    "Name": "Treutel Group",
    "PersonId": 240,
    "Rank": 967,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 132,
    "FullName": "Rosella Rosenbaum",
    "FormalName": "Turner, Harber and Ryan",
    "Deleted": true,
    "EjUserId": 529,
    "UserName": "Raynor Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 585
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 84,
    "Name": "Ebert-Reichel",
    "PersonId": 106,
    "Rank": 111,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 157,
    "FullName": "Henriette Kirlin",
    "FormalName": "Russel, Wyman and Dicki",
    "Deleted": false,
    "EjUserId": 407,
    "UserName": "Morar LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 331
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 873,
    "Name": "Hoppe LLC",
    "PersonId": 401,
    "Rank": 332,
    "Tooltip": "expedita",
    "Type": "AnonymousAssociate",
    "GroupIdx": 856,
    "FullName": "Miss Alda Stracke",
    "FormalName": "Swift, Strosin and Rohan",
    "Deleted": true,
    "EjUserId": 352,
    "UserName": "McGlynn, Gaylord and Rice",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 120
      }
    }
  },
  "Contact": {
    "ContactId": 970,
    "Name": "Erdman-Larkin",
    "OrgNr": "955337",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dolores",
    "DirectPhone": "1-651-708-8444",
    "AssociateId": 356,
    "CountryId": 742,
    "EmailAddress": "mallie.dickens@gradysauer.biz",
    "Kananame": "vitae",
    "EmailAddressName": "cesar@hudson.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Linwood Cassin III",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "asperiores",
    "FullName": "Cyril Berge",
    "IsOwnerContact": false,
    "ActiveErpLinks": 342,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 621
      }
    }
  },
  "Project": {
    "ProjectId": 765,
    "Name": "Rutherford LLC",
    "Description": "Enterprise-wide zero defect encryption",
    "URL": "http://www.example.com/",
    "Type": "veritatis",
    "AssociateId": 848,
    "AssociateFullName": "Margret Kassulke",
    "TypeId": 962,
    "Updated": "2018-08-25T15:05:42.6216324+02:00",
    "StatusId": 667,
    "Status": "reprehenderit",
    "TextId": 915,
    "PublishTo": "2014-07-22T15:05:42.6216324+02:00",
    "PublishFrom": "1996-07-25T15:05:42.6216324+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "554499",
    "ActiveErpLinks": 673,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 756
      }
    }
  },
  "SaleText": "nulla",
  "Person": {
    "Position": "enim",
    "PersonId": 551,
    "Mrmrs": "praesentium",
    "Firstname": "Liam",
    "Lastname": "Blick",
    "MiddleName": "Lynch Group",
    "Title": "veritatis",
    "Description": "Operative optimizing firmware",
    "Email": "destany@stracke.ca",
    "FullName": "Maymie Lehner",
    "DirectPhone": "(576)081-5063 x74501",
    "FormalName": "Hermann Inc and Sons",
    "CountryId": 247,
    "ContactId": 167,
    "ContactName": "Kihn, Heller and Boyle",
    "Retired": 715,
    "Rank": 455,
    "ActiveInterests": 892,
    "ContactDepartment": "",
    "ContactCountryId": 434,
    "ContactOrgNr": "1125470",
    "FaxPhone": "750-144-0434 x88462",
    "MobilePhone": "722-243-0145 x24225",
    "ContactPhone": "606.000.4726",
    "AssociateName": "Gutmann, Koelpin and Kemmer",
    "AssociateId": 594,
    "UsePersonAddress": true,
    "ContactFax": "architecto",
    "Kanafname": "odit",
    "Kanalname": "corrupti",
    "Post1": "molestias",
    "Post2": "eveniet",
    "Post3": "eveniet",
    "EmailName": "lauryn@dubuque.biz",
    "ContactFullName": "Jaron Bartoletti I",
    "ActiveErpLinks": 806,
    "TicketPriorityId": 840,
    "SupportLanguageId": 790,
    "SupportAssociateId": 453,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 727
      }
    }
  },
  "Currency": {
    "Id": 674,
    "Value": "veritatis",
    "Tooltip": "exercitationem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 220
      }
    }
  },
  "Competitor": {
    "Id": 194,
    "Value": "dolorem",
    "Tooltip": "fugit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 678
      }
    }
  },
  "Credited": {
    "Id": 610,
    "Value": "nisi",
    "Tooltip": "sed",
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
  "Rating": {
    "Id": 692,
    "Value": "est",
    "Tooltip": "nihil",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 561
      }
    }
  },
  "Reason": {
    "Id": 835,
    "Value": "corporis",
    "Tooltip": "dolores",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 836
      }
    }
  },
  "Source": {
    "Id": 867,
    "Value": "eligendi",
    "Tooltip": "ratione",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 131
      }
    }
  },
  "Status": "Lost",
  "Saledate": "1998-10-16T15:05:42.6236324+02:00",
  "Amount": 28111.98,
  "SaleId": 946,
  "Earning": 10135.356,
  "EarningPercent": 12147.384,
  "Heading": "sit",
  "Number": "674245",
  "Probability": 665,
  "CreatedDate": "1996-01-29T15:05:42.6236324+01:00",
  "UpdatedDate": "2013-05-04T15:05:42.6236324+02:00",
  "Completed": "Completed",
  "ActiveLinks": 889,
  "Links": [
    {
      "EntityName": "Schowalter, Nienow and Hintz",
      "Id": 680,
      "Description": "Ameliorated static hardware",
      "ExtraInfo": "veniam",
      "LinkId": 110,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 174
        }
      }
    }
  ],
  "NextDueDate": "1999-05-28T15:05:42.6236324+02:00",
  "Postit": "et",
  "SaleType": {
    "Id": 735,
    "Value": "reprehenderit",
    "Tooltip": "necessitatibus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 479
      }
    }
  },
  "ReasonSold": {
    "Id": 357,
    "Value": "vel",
    "Tooltip": "natus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 340
      }
    }
  },
  "ReasonStalled": {
    "Id": 236,
    "Value": "in",
    "Tooltip": "sed",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 217
      }
    }
  },
  "ReopenDate": "2015-03-02T15:05:42.6246327+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Schowalter-Witting",
      "Comment": "esse",
      "StakeholderRoleId": 307,
      "CountryId": 573,
      "PersonId": 191,
      "EmailDescription": "bridget@bailey.ca",
      "EmailId": 491,
      "EmailAddress": "osvaldo.little@ryan.info",
      "PhoneId": 580,
      "ContactName": "Fay-Mueller",
      "ContactId": 924,
      "SaleId": 985,
      "Mrmrs": "tempora",
      "Firstname": "Gregg",
      "MiddleName": "Mayer, Orn and Hoppe",
      "Lastname": "Cronin",
      "SaleStakeholderId": 962,
      "Rank": 596,
      "Phone": "824.314.6507 x82615",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "enable revolutionary markets"
          },
          "FieldType": "System.String",
          "FieldLength": 269
        }
      }
    }
  ],
  "ActiveErpLinks": 514,
  "UserDefinedFields": {
    "SuperOffice:1": "Osvaldo Collins",
    "SuperOffice:2": "Reggie Schaefer"
  },
  "ExtraFields": {
    "ExtraFields1": "consequuntur",
    "ExtraFields2": "reiciendis"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "unde"
  },
  "PublishEventDate": "2020-02-10T15:05:42.6266627+01:00",
  "PublishTo": "1997-09-04T15:05:42.6266627+02:00",
  "PublishFrom": "2018-03-09T15:05:42.6266627+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 950,
      "Visibility": "All",
      "DisplayValue": "delectus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 884
        }
      }
    },
    {
      "VisibleId": 950,
      "Visibility": "All",
      "DisplayValue": "delectus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 884
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
      "FieldLength": 728
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```