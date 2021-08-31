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
    "path": "nam",
    "value": {
      "value1": {
        "PrimaryKey": 7045,
        "EntityName": "sale",
        "saleId": 7045,
        "contactId": 80,
        "name": "Treutel, Roberts and Daniel"
      },
      "value2": {
        "PrimaryKey": 4684,
        "EntityName": "person",
        "personId": 4684,
        "fullName": "Mrs. Rodrigo Fritsch"
      }
    }
  },
  {
    "op": "add",
    "path": "nam",
    "value": {
      "value1": {
        "PrimaryKey": 7045,
        "EntityName": "sale",
        "saleId": 7045,
        "contactId": 80,
        "name": "Treutel, Roberts and Daniel"
      },
      "value2": {
        "PrimaryKey": 4684,
        "EntityName": "person",
        "personId": 4684,
        "fullName": "Mrs. Rodrigo Fritsch"
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
    "AppointmentId": 536,
    "StartDate": "2020-07-01T15:05:42.6866349+02:00",
    "EndDate": "2018-11-29T15:05:42.6866349+01:00",
    "Type": "BookingForChecklist",
    "Task": "voluptatum",
    "AssociateFullName": "Kelley Keeling",
    "ContactName": "Mohr-Ryan",
    "Description": "Universal impactful core",
    "PersonFullName": "Mrs. Sabryna Kunde",
    "PersonId": 627,
    "ContactId": 277,
    "ProjectId": 519,
    "ProjectName": "DuBuque, Powlowski and Weimann",
    "IsPublished": true,
    "AssociateId": 125,
    "ColorIndex": 957,
    "IsFree": false,
    "HasAlarm": true,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 867,
    "PriorityName": "Cole LLC",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": false,
    "IsBooking": true,
    "ActiveDate": "2009-11-25T15:05:42.6866349+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2004-11-07T15:05:42.6866349+01:00",
    "RecurringEndDate": "2005-04-30T15:05:42.6866349+02:00",
    "MotherId": 716,
    "AssignedBy": 404,
    "AssignedByFullName": "Malinda Zieme",
    "RejectReason": "",
    "Location": "architecto",
    "AlarmLeadTime": "voluptatem",
    "SaleId": 707,
    "SaleName": "Dare LLC",
    "AssociateName": "Herman-Fadel",
    "CreatedDate": "2006-06-02T15:05:42.6866349+02:00",
    "CreatedBy": "voluptatem",
    "CreatedByFullName": "Mrs. Luigi Bode",
    "CreatedByAssociateId": 534,
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
        "FieldLength": 459
      }
    }
  },
  "Associate": {
    "AssociateId": 884,
    "Name": "Mohr-Ledner",
    "PersonId": 243,
    "Rank": 482,
    "Tooltip": "quisquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 473,
    "FullName": "Anderson Ratke II",
    "FormalName": "Quitzon Inc and Sons",
    "Deleted": false,
    "EjUserId": 281,
    "UserName": "Lebsack-Gaylord",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 324
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 760,
    "Name": "Cole-Murphy",
    "PersonId": 549,
    "Rank": 331,
    "Tooltip": "iusto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 300,
    "FullName": "Mabelle Hettinger",
    "FormalName": "Muller LLC",
    "Deleted": true,
    "EjUserId": 581,
    "UserName": "Beahan Group",
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
  "CreatedBy": {
    "AssociateId": 23,
    "Name": "Keeling-Watsica",
    "PersonId": 628,
    "Rank": 927,
    "Tooltip": "aperiam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 724,
    "FullName": "Lacey McLaughlin",
    "FormalName": "Tromp, Altenwerth and Gorczany",
    "Deleted": false,
    "EjUserId": 777,
    "UserName": "Keeling LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 922
      }
    }
  },
  "Contact": {
    "ContactId": 904,
    "Name": "Kiehn LLC",
    "OrgNr": "824399",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "cupiditate",
    "DirectPhone": "1-547-335-4328 x65103",
    "AssociateId": 398,
    "CountryId": 234,
    "EmailAddress": "ross_dooley@veumpurdy.co.uk",
    "Kananame": "deserunt",
    "EmailAddressName": "dion@gorczany.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Oliver Boyer",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "tempore",
    "FullName": "Adolph Stoltenberg",
    "IsOwnerContact": false,
    "ActiveErpLinks": 104,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 409
      }
    }
  },
  "Project": {
    "ProjectId": 247,
    "Name": "Collins LLC",
    "Description": "Networked well-modulated paradigm",
    "URL": "http://www.example.com/",
    "Type": "deserunt",
    "AssociateId": 104,
    "AssociateFullName": "Jack Bailey",
    "TypeId": 175,
    "Updated": "2019-06-15T15:05:42.6886348+02:00",
    "StatusId": 292,
    "Status": "et",
    "TextId": 258,
    "PublishTo": "2017-06-20T15:05:42.6886348+02:00",
    "PublishFrom": "2004-02-17T15:05:42.6886348+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1128929",
    "ActiveErpLinks": 86,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 780
      }
    }
  },
  "SaleText": "non",
  "Person": {
    "Position": "placeat",
    "PersonId": 185,
    "Mrmrs": "quia",
    "Firstname": "Rosendo",
    "Lastname": "Reilly",
    "MiddleName": "Kemmer, Gerhold and Fritsch",
    "Title": "asperiores",
    "Description": "Balanced context-sensitive project",
    "Email": "oswald.koelpin@zboncak.ca",
    "FullName": "Elmo Kohler",
    "DirectPhone": "(333)755-6717 x386",
    "FormalName": "Tremblay, Howell and Kihn",
    "CountryId": 307,
    "ContactId": 778,
    "ContactName": "Feil, Rath and Lueilwitz",
    "Retired": 379,
    "Rank": 350,
    "ActiveInterests": 856,
    "ContactDepartment": "",
    "ContactCountryId": 718,
    "ContactOrgNr": "825900",
    "FaxPhone": "422-077-3344 x868",
    "MobilePhone": "481.131.4452 x67836",
    "ContactPhone": "836.385.4704 x0723",
    "AssociateName": "Aufderhar LLC",
    "AssociateId": 420,
    "UsePersonAddress": false,
    "ContactFax": "et",
    "Kanafname": "eaque",
    "Kanalname": "doloribus",
    "Post1": "expedita",
    "Post2": "quia",
    "Post3": "eveniet",
    "EmailName": "maynard_lebsack@wilkinsonkrajcik.co.uk",
    "ContactFullName": "Ismael Hills",
    "ActiveErpLinks": 120,
    "TicketPriorityId": 876,
    "SupportLanguageId": 127,
    "SupportAssociateId": 573,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 683
      }
    }
  },
  "Currency": {
    "Id": 182,
    "Value": "harum",
    "Tooltip": "ipsum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 441
      }
    }
  },
  "Competitor": {
    "Id": 889,
    "Value": "quam",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 604
      }
    }
  },
  "Credited": {
    "Id": 828,
    "Value": "veritatis",
    "Tooltip": "ea",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 462
      }
    }
  },
  "Rating": {
    "Id": 166,
    "Value": "quam",
    "Tooltip": "ea",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 327
      }
    }
  },
  "Reason": {
    "Id": 336,
    "Value": "cupiditate",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 891
      }
    }
  },
  "Source": {
    "Id": 31,
    "Value": "qui",
    "Tooltip": "quae",
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
  "Status": "Lost",
  "Saledate": "2021-05-28T15:05:42.6926595+02:00",
  "Amount": 6593.936,
  "SaleId": 727,
  "Earning": 9514.824,
  "EarningPercent": 28917.417999999998,
  "Heading": "modi",
  "Number": "410454",
  "Probability": 110,
  "CreatedDate": "2005-04-13T15:05:42.6926595+02:00",
  "UpdatedDate": "2013-03-20T15:05:42.6926595+01:00",
  "Completed": "Completed",
  "ActiveLinks": 111,
  "Links": [
    {
      "EntityName": "Rodriguez Inc and Sons",
      "Id": 80,
      "Description": "Realigned mission-critical methodology",
      "ExtraInfo": "amet",
      "LinkId": 20,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 899
        }
      }
    }
  ],
  "NextDueDate": "2019-11-19T15:05:42.6926595+01:00",
  "Postit": "ratione",
  "SaleType": {
    "Id": 981,
    "Value": "voluptatem",
    "Tooltip": "fugit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 167
      }
    }
  },
  "ReasonSold": {
    "Id": 925,
    "Value": "perferendis",
    "Tooltip": "nostrum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 987
      }
    }
  },
  "ReasonStalled": {
    "Id": 303,
    "Value": "omnis",
    "Tooltip": "sunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 708
      }
    }
  },
  "ReopenDate": "1998-05-26T15:05:42.6926595+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Nader-Hand",
      "Comment": "asperiores",
      "StakeholderRoleId": 964,
      "CountryId": 621,
      "PersonId": 385,
      "EmailDescription": "deon.collins@krajciklittel.biz",
      "EmailId": 544,
      "EmailAddress": "braeden@reynolds.name",
      "PhoneId": 765,
      "ContactName": "Medhurst, Gleason and Heller",
      "ContactId": 15,
      "SaleId": 981,
      "Mrmrs": "ut",
      "Firstname": "Nora",
      "MiddleName": "Legros LLC",
      "Lastname": "Roberts",
      "SaleStakeholderId": 22,
      "Rank": 102,
      "Phone": "(327)714-0174 x6881",
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
    }
  ],
  "ActiveErpLinks": 97,
  "UserDefinedFields": {
    "SuperOffice:1": "757238964",
    "SuperOffice:2": "April Feeney"
  },
  "ExtraFields": {
    "ExtraFields1": "ducimus",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "aspernatur",
    "CustomFields2": "inventore"
  },
  "PublishEventDate": "2010-10-28T15:05:42.6936649+02:00",
  "PublishTo": "2020-04-19T15:05:42.6936649+02:00",
  "PublishFrom": "2007-12-31T15:05:42.6936649+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 600,
      "Visibility": "All",
      "DisplayValue": "aspernatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 197
        }
      }
    },
    {
      "VisibleId": 600,
      "Visibility": "All",
      "DisplayValue": "aspernatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 197
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
      "FieldLength": 185
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```