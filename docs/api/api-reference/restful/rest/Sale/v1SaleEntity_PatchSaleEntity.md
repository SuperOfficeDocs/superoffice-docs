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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "nihil",
    "value": {
      "value1": {
        "PrimaryKey": 142,
        "EntityName": "sale",
        "saleId": 142,
        "contactId": 6482,
        "name": "Gerhold Inc and Sons"
      },
      "value2": {
        "PrimaryKey": 7039,
        "EntityName": "sale",
        "saleId": 7039,
        "contactId": 2124,
        "name": "Kuvalis, Ankunding and Nikolaus"
      }
    }
  },
  {
    "op": "add",
    "path": "nihil",
    "value": {
      "value1": {
        "PrimaryKey": 142,
        "EntityName": "sale",
        "saleId": 142,
        "contactId": 6482,
        "name": "Gerhold Inc and Sons"
      },
      "value2": {
        "PrimaryKey": 7039,
        "EntityName": "sale",
        "saleId": 7039,
        "contactId": 2124,
        "name": "Kuvalis, Ankunding and Nikolaus"
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
    "AppointmentId": 442,
    "StartDate": "2012-11-06T18:25:51.0379455+01:00",
    "EndDate": "2012-04-08T18:25:51.0379455+02:00",
    "Type": "BookingForChecklist",
    "Task": "voluptas",
    "AssociateFullName": "Lenora Rice MD",
    "ContactName": "Hoeger, Padberg and Hilpert",
    "Description": "Exclusive human-resource middleware",
    "PersonFullName": "Jaylan Denesik Jr.",
    "PersonId": 975,
    "ContactId": 715,
    "ProjectId": 675,
    "ProjectName": "Lind-O'Conner",
    "IsPublished": true,
    "AssociateId": 79,
    "ColorIndex": 523,
    "IsFree": true,
    "HasAlarm": true,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 895,
    "PriorityName": "Jewess, Schulist and Nader",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": true,
    "IsBooking": true,
    "ActiveDate": "1996-07-20T18:25:51.0389456+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2019-05-03T18:25:51.0389456+02:00",
    "RecurringEndDate": "2000-10-27T18:25:51.0389456+02:00",
    "MotherId": 378,
    "AssignedBy": 727,
    "AssignedByFullName": "Vanessa Kohler",
    "RejectReason": "",
    "Location": "qui",
    "AlarmLeadTime": "consectetur",
    "SaleId": 775,
    "SaleName": "Eichmann-Hickle",
    "AssociateName": "Veum, Daniel and Kreiger",
    "CreatedDate": "2014-04-11T18:25:51.0389456+02:00",
    "CreatedBy": "aut",
    "CreatedByFullName": "Amos O'Reilly",
    "CreatedByAssociateId": 973,
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
        "FieldLength": 770
      }
    }
  },
  "Associate": {
    "AssociateId": 770,
    "Name": "Wyman Group",
    "PersonId": 914,
    "Rank": 300,
    "Tooltip": "unde",
    "Type": "AnonymousAssociate",
    "GroupIdx": 359,
    "FullName": "Foster Quitzon",
    "FormalName": "Roberts LLC",
    "Deleted": false,
    "EjUserId": 561,
    "UserName": "Bergnaum, Metz and Jacobson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 790
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 673,
    "Name": "Wuckert LLC",
    "PersonId": 830,
    "Rank": 625,
    "Tooltip": "sequi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 713,
    "FullName": "Jalen Kirlin",
    "FormalName": "Dickens-Mueller",
    "Deleted": true,
    "EjUserId": 922,
    "UserName": "Kiehn-Terry",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 967
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 230,
    "Name": "Leannon-Dach",
    "PersonId": 367,
    "Rank": 36,
    "Tooltip": "temporibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 629,
    "FullName": "Keshaun Schuster",
    "FormalName": "Buckridge-Kulas",
    "Deleted": false,
    "EjUserId": 816,
    "UserName": "Zieme LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 976
      }
    }
  },
  "Contact": {
    "ContactId": 352,
    "Name": "Pfannerstill LLC",
    "OrgNr": "1764566",
    "Department": "mesh turn-key e-markets",
    "URL": "http://www.example.com/",
    "City": "nisi",
    "DirectPhone": "065.620.4023 x18208",
    "AssociateId": 433,
    "CountryId": 534,
    "EmailAddress": "faustino@dietrichankunding.name",
    "Kananame": "ut",
    "EmailAddressName": "oma@armstrongdenesik.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Camryn Marquardt",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ex",
    "FullName": "Nikolas Sanford",
    "IsOwnerContact": true,
    "ActiveErpLinks": 335,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "repurpose web-enabled interfaces"
        },
        "FieldType": "System.String",
        "FieldLength": 853
      }
    }
  },
  "Project": {
    "ProjectId": 268,
    "Name": "Breitenberg LLC",
    "Description": "Total neutral productivity",
    "URL": "http://www.example.com/",
    "Type": "placeat",
    "AssociateId": 308,
    "AssociateFullName": "Betsy Flatley",
    "TypeId": 56,
    "Updated": "2020-10-28T18:25:51.0419463+01:00",
    "StatusId": 47,
    "Status": "aliquid",
    "TextId": 800,
    "PublishTo": "2001-05-26T18:25:51.0419463+02:00",
    "PublishFrom": "2015-03-14T18:25:51.0419463+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "791857",
    "ActiveErpLinks": 345,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 895
      }
    }
  },
  "SaleText": "vel",
  "Person": {
    "Position": "fuga",
    "PersonId": 924,
    "Mrmrs": "saepe",
    "Firstname": "Arianna",
    "Lastname": "Kilback",
    "MiddleName": "Klein, Sawayn and Rau",
    "Title": "odit",
    "Description": "Grass-roots multi-state process improvement",
    "Email": "shane@funk.info",
    "FullName": "Lemuel Renner",
    "DirectPhone": "1-215-341-4464",
    "FormalName": "Sipes Inc and Sons",
    "CountryId": 969,
    "ContactId": 15,
    "ContactName": "Heathcote-Wintheiser",
    "Retired": 531,
    "Rank": 932,
    "ActiveInterests": 911,
    "ContactDepartment": "",
    "ContactCountryId": 682,
    "ContactOrgNr": "599670",
    "FaxPhone": "786.872.4762",
    "MobilePhone": "025-055-1446 x026",
    "ContactPhone": "707-184-8312 x577",
    "AssociateName": "Adams, Heaney and Herman",
    "AssociateId": 222,
    "UsePersonAddress": false,
    "ContactFax": "ad",
    "Kanafname": "sapiente",
    "Kanalname": "exercitationem",
    "Post1": "molestias",
    "Post2": "officia",
    "Post3": "impedit",
    "EmailName": "vince_ullrich@pfeffer.info",
    "ContactFullName": "Hazle Rau",
    "ActiveErpLinks": 161,
    "TicketPriorityId": 238,
    "SupportLanguageId": 482,
    "SupportAssociateId": 821,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 104
      }
    }
  },
  "Currency": {
    "Id": 383,
    "Value": "ut",
    "Tooltip": "voluptatem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "matrix customized infrastructures"
        },
        "FieldType": "System.String",
        "FieldLength": 877
      }
    }
  },
  "Competitor": {
    "Id": 765,
    "Value": "dolorum",
    "Tooltip": "fugiat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 656
      }
    }
  },
  "Credited": {
    "Id": 758,
    "Value": "voluptas",
    "Tooltip": "natus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 478
      }
    }
  },
  "Rating": {
    "Id": 922,
    "Value": "soluta",
    "Tooltip": "minima",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 350
      }
    }
  },
  "Reason": {
    "Id": 724,
    "Value": "facere",
    "Tooltip": "quo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 711
      }
    }
  },
  "Source": {
    "Id": 618,
    "Value": "maiores",
    "Tooltip": "nam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 506
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2015-09-11T18:25:51.042946+02:00",
  "Amount": 18547.012,
  "SaleId": 654,
  "Earning": 12232.002,
  "EarningPercent": 17221.329999999998,
  "Heading": "quia",
  "Number": "1099475",
  "Probability": 280,
  "CreatedDate": "2017-04-04T18:25:51.0439481+02:00",
  "UpdatedDate": "2000-01-30T18:25:51.0439481+01:00",
  "Completed": "Completed",
  "ActiveLinks": 644,
  "Links": [
    {
      "EntityName": "Block, Nolan and Turcotte",
      "Id": 59,
      "Description": "Progressive user-facing ability",
      "ExtraInfo": "qui",
      "LinkId": 110,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 382
        }
      }
    }
  ],
  "NextDueDate": "2021-09-12T18:25:51.0439481+02:00",
  "Postit": "expedita",
  "SaleType": {
    "Id": 320,
    "Value": "sapiente",
    "Tooltip": "quasi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 507
      }
    }
  },
  "ReasonSold": {
    "Id": 9,
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
        "FieldLength": 586
      }
    }
  },
  "ReasonStalled": {
    "Id": 28,
    "Value": "similique",
    "Tooltip": "voluptas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 284
      }
    }
  },
  "ReopenDate": "2000-08-19T18:25:51.0439481+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Streich, Leannon and Dickens",
      "Comment": "excepturi",
      "StakeholderRoleId": 480,
      "CountryId": 215,
      "PersonId": 680,
      "EmailDescription": "adela@predovic.name",
      "EmailId": 657,
      "EmailAddress": "easter.stark@pouros.name",
      "PhoneId": 493,
      "ContactName": "Kshlerin Group",
      "ContactId": 741,
      "SaleId": 774,
      "Mrmrs": "qui",
      "Firstname": "Hertha",
      "MiddleName": "Nikolaus-Kshlerin",
      "Lastname": "Crona",
      "SaleStakeholderId": 435,
      "Rank": 28,
      "Phone": "1-654-517-7675",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 927
        }
      }
    }
  ],
  "ActiveErpLinks": 787,
  "UserDefinedFields": {
    "SuperOffice:1": "Nelle Jones DVM",
    "SuperOffice:2": "2017526537"
  },
  "ExtraFields": {
    "ExtraFields1": "assumenda",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "cupiditate",
    "CustomFields2": "dolores"
  },
  "PublishEventDate": "2008-03-22T18:25:51.0449469+01:00",
  "PublishTo": "2014-11-17T18:25:51.0449469+01:00",
  "PublishFrom": "1995-12-23T18:25:51.0449469+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 482,
      "Visibility": "All",
      "DisplayValue": "accusamus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 872
        }
      }
    },
    {
      "VisibleId": 482,
      "Visibility": "All",
      "DisplayValue": "accusamus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 872
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
      "FieldLength": 563
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```