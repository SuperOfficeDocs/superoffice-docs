---
title: PATCH Sale/{id}
id: v1SaleEntity_PatchSaleEntity
---

# PATCH Sale/{id}

```http
PATCH /api/v1/Sale/{id}
```

Update a SaleEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

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



Calls the {SuperOffice.CRM.Services.ISaleAgent} service SaveSaleEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SaleEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Sale/{id}?$select=name,department,category/id
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

The Sale Entity contains the sale amount, currency, and sale members. Sales are linked to contacts, persons, and/or projects.



SaleEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | SaleEntity  updated. |
| 404 | SaleEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because SaleEntity has changed since the requested If-Unmodified-Since timestamp. |

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
PATCH /api/v1/Sale/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "quia",
    "value": {
      "value1": {
        "PrimaryKey": 8317,
        "EntityName": "person",
        "personId": 8317,
        "fullName": "Gabe Lockman"
      },
      "value2": {
        "PrimaryKey": 8040,
        "EntityName": "person",
        "personId": 8040,
        "fullName": "Adriel Schneider"
      }
    }
  },
  {
    "op": "add",
    "path": "quia",
    "value": {
      "value1": {
        "PrimaryKey": 8317,
        "EntityName": "person",
        "personId": 8317,
        "fullName": "Gabe Lockman"
      },
      "value2": {
        "PrimaryKey": 8040,
        "EntityName": "person",
        "personId": 8040,
        "fullName": "Adriel Schneider"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 SaleEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 55,
    "StartDate": "2008-02-17T09:40:59.6406927+01:00",
    "EndDate": "2017-08-08T09:40:59.6406927+02:00",
    "Type": "BookingForChecklist",
    "Task": "cum",
    "AssociateFullName": "Miss Lucius Rohan",
    "ContactName": "Lowe Group",
    "Description": "Business-focused full-range capacity",
    "PersonFullName": "Diamond Parisian",
    "PersonId": 284,
    "ContactId": 59,
    "ProjectId": 114,
    "ProjectName": "Brown-Toy",
    "IsPublished": true,
    "AssociateId": 221,
    "ColorIndex": 44,
    "IsFree": true,
    "HasAlarm": true,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 1000,
    "PriorityName": "O'Reilly LLC",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": true,
    "IsBooking": false,
    "ActiveDate": "2009-06-21T09:40:59.6406927+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2018-12-05T09:40:59.6406927+01:00",
    "RecurringEndDate": "1999-10-23T09:40:59.6406927+02:00",
    "MotherId": 619,
    "AssignedBy": 813,
    "AssignedByFullName": "Rene Heller",
    "RejectReason": "",
    "Location": "earum",
    "AlarmLeadTime": "voluptatem",
    "SaleId": 928,
    "SaleName": "Kling, Wuckert and Koss",
    "AssociateName": "Roberts LLC",
    "CreatedDate": "2006-02-04T09:40:59.6406927+01:00",
    "CreatedBy": "in",
    "CreatedByFullName": "Marquis Rowe",
    "CreatedByAssociateId": 856,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 459
      }
    }
  },
  "Associate": {
    "AssociateId": 948,
    "Name": "Hayes, Kerluke and Jones",
    "PersonId": 493,
    "Rank": 23,
    "Tooltip": "fugit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 410,
    "FullName": "Martin Kirlin",
    "FormalName": "Parker-Farrell",
    "Deleted": true,
    "EjUserId": 824,
    "UserName": "Gutkowski LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 860
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 126,
    "Name": "Wisozk, Hermann and Romaguera",
    "PersonId": 133,
    "Rank": 254,
    "Tooltip": "architecto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 388,
    "FullName": "Ms. Wilhelm Cremin",
    "FormalName": "Kunde-Cruickshank",
    "Deleted": true,
    "EjUserId": 676,
    "UserName": "Feeney Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 942
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 439,
    "Name": "Hudson Inc and Sons",
    "PersonId": 942,
    "Rank": 55,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 217,
    "FullName": "Lorenza Gorczany",
    "FormalName": "D'Amore-Hodkiewicz",
    "Deleted": true,
    "EjUserId": 297,
    "UserName": "Tremblay Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 431
      }
    }
  },
  "Contact": {
    "ContactId": 126,
    "Name": "Schaefer, Toy and Lynch",
    "OrgNr": "1387259",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "illum",
    "DirectPhone": "604.885.7364",
    "AssociateId": 999,
    "CountryId": 205,
    "EmailAddress": "rupert_terry@labadieboyle.us",
    "Kananame": "sit",
    "EmailAddressName": "raymond.satterfield@ryanjohns.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ashley O'Keefe",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "eligendi",
    "FullName": "Roslyn Flatley",
    "IsOwnerContact": false,
    "ActiveErpLinks": 231,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 903
      }
    }
  },
  "Project": {
    "ProjectId": 129,
    "Name": "Towne-Barton",
    "Description": "Team-oriented uniform algorithm",
    "URL": "http://www.example.com/",
    "Type": "explicabo",
    "AssociateId": 479,
    "AssociateFullName": "Felton Haag",
    "TypeId": 631,
    "Updated": "2004-03-16T09:40:59.6436922+01:00",
    "StatusId": 211,
    "Status": "ipsa",
    "TextId": 926,
    "PublishTo": "2005-08-05T09:40:59.6436922+02:00",
    "PublishFrom": "2014-06-27T09:40:59.6436922+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "636522",
    "ActiveErpLinks": 163,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 602
      }
    }
  },
  "SaleText": "illo",
  "Person": {
    "Position": "aut",
    "PersonId": 823,
    "Mrmrs": "quo",
    "Firstname": "Sigmund",
    "Lastname": "Kessler",
    "MiddleName": "Kuphal, Christiansen and Kerluke",
    "Title": "dolor",
    "Description": "Synchronised encompassing attitude",
    "Email": "lilyan@botsford.biz",
    "FullName": "Cydney Williamson",
    "DirectPhone": "758.622.3834 x8726",
    "FormalName": "Johnston LLC",
    "CountryId": 809,
    "ContactId": 916,
    "ContactName": "Fay-Schuppe",
    "Retired": 138,
    "Rank": 809,
    "ActiveInterests": 689,
    "ContactDepartment": "",
    "ContactCountryId": 777,
    "ContactOrgNr": "1345770",
    "FaxPhone": "(147)052-5316",
    "MobilePhone": "885.273.3002 x7255",
    "ContactPhone": "(400)345-3024",
    "AssociateName": "Farrell, Champlin and Toy",
    "AssociateId": 817,
    "UsePersonAddress": true,
    "ContactFax": "qui",
    "Kanafname": "voluptatem",
    "Kanalname": "quas",
    "Post1": "pariatur",
    "Post2": "vel",
    "Post3": "deleniti",
    "EmailName": "emmanuelle.green@langoshrunolfsdottir.ca",
    "ContactFullName": "Rubie Hammes",
    "ActiveErpLinks": 149,
    "TicketPriorityId": 501,
    "SupportLanguageId": 920,
    "SupportAssociateId": 314,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 271
      }
    }
  },
  "Currency": {
    "Id": 203,
    "Value": "enim",
    "Tooltip": "nesciunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 991
      }
    }
  },
  "Competitor": {
    "Id": 558,
    "Value": "illum",
    "Tooltip": "rerum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "recontextualize B2C e-commerce"
        },
        "FieldType": "System.String",
        "FieldLength": 615
      }
    }
  },
  "Credited": {
    "Id": 128,
    "Value": "tempore",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 195
      }
    }
  },
  "Rating": {
    "Id": 719,
    "Value": "quis",
    "Tooltip": "occaecati",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 12
      }
    }
  },
  "Reason": {
    "Id": 318,
    "Value": "veniam",
    "Tooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 263
      }
    }
  },
  "Source": {
    "Id": 566,
    "Value": "enim",
    "Tooltip": "voluptatem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 948
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2008-04-01T09:40:59.6456926+02:00",
  "Amount": 10511.436,
  "SaleId": 509,
  "Earning": 13375.912,
  "EarningPercent": 10389.21,
  "Heading": "quo",
  "Number": "719753",
  "Probability": 965,
  "CreatedDate": "2011-04-04T09:40:59.6456926+02:00",
  "UpdatedDate": "2002-04-07T09:40:59.6456926+02:00",
  "Completed": "Completed",
  "ActiveLinks": 914,
  "Links": [
    {
      "EntityName": "Gulgowski LLC",
      "Id": 333,
      "Description": "Grass-roots eco-centric initiative",
      "ExtraInfo": "sunt",
      "LinkId": 207,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "transition sticky e-markets"
          },
          "FieldType": "System.String",
          "FieldLength": 453
        }
      }
    }
  ],
  "NextDueDate": "2008-12-30T09:40:59.6456926+01:00",
  "Postit": "beatae",
  "SaleType": {
    "Id": 613,
    "Value": "consequatur",
    "Tooltip": "hic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "e-enable distributed solutions"
        },
        "FieldType": "System.String",
        "FieldLength": 874
      }
    }
  },
  "ReasonSold": {
    "Id": 340,
    "Value": "modi",
    "Tooltip": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 104
      }
    }
  },
  "ReasonStalled": {
    "Id": 753,
    "Value": "corporis",
    "Tooltip": "eius",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 519
      }
    }
  },
  "ReopenDate": "2007-03-17T09:40:59.6456926+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Hyatt, Hilpert and Gusikowski",
      "Comment": "corrupti",
      "StakeholderRoleId": 583,
      "CountryId": 383,
      "PersonId": 376,
      "EmailDescription": "lavina@grant.uk",
      "EmailId": 775,
      "EmailAddress": "winfield@vandervortcassin.biz",
      "PhoneId": 673,
      "ContactName": "Stoltenberg, Veum and Labadie",
      "ContactId": 679,
      "SaleId": 732,
      "Mrmrs": "dolores",
      "Firstname": "Daisy",
      "MiddleName": "Rutherford Group",
      "Lastname": "Kovacek",
      "SaleStakeholderId": 968,
      "Rank": 101,
      "Phone": "438-334-5487 x4350",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 728
        }
      }
    }
  ],
  "ActiveErpLinks": 398,
  "UserDefinedFields": {
    "SuperOffice:1": "1503832956",
    "SuperOffice:2": "Elwyn Predovic"
  },
  "ExtraFields": {
    "ExtraFields1": "inventore",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "autem"
  },
  "PublishEventDate": "2020-01-20T09:40:59.646692+01:00",
  "PublishTo": "2008-03-13T09:40:59.646692+01:00",
  "PublishFrom": "2016-03-23T09:40:59.646692+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 243,
      "Visibility": "All",
      "DisplayValue": "odio",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 628
        }
      }
    },
    {
      "VisibleId": 243,
      "Visibility": "All",
      "DisplayValue": "odio",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 628
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "grow 24/365 users"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 909
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```