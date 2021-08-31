---
title: PATCH Document/{id}
id: v1DocumentEntity_PatchDocumentEntity
---

# PATCH Document/{id}

```http
PATCH /api/v1/Document/{id}
```

Update a DocumentEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

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



Calls the {SuperOffice.CRM.Services.IDocumentAgent} service SaveDocumentEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DocumentEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Document/{id}?$select=name,department,category/id
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




DocumentEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | DocumentEntity  updated. |
| 404 | DocumentEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because DocumentEntity has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | int32 | Primary key |
| UpdatedBy |  | The person that last updated the appointment. |
| CreatedBy |  | The person that first created the document. The property is read-only. |
| Attention | string | Attention/salutation |
| Header | string | Visible document name |
| Name | string | File name |
| OurRef | string | Our reference, searchable field from freetext search |
| YourRef | string | Your reference |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| DocumentTemplate |  | The template type of the document.  <para>Use MDO List name "doctmpl" to get list items.</para> |
| Person |  | A document may also be connected to a person; this must be a contact person registered on the current company. This does not mean however that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Associate |  | The owner of the document - the associate whose checklist the document is in.  <para>Use MDO List name "associate" to get list items.</para> |
| Contact |  | The contact associated with the document. It may also be null if no contact is associated with the document.  <para>Use MDO List name "contact" to get list items.</para> |
| Project |  | A document may also be connected to a project, so you see the document both on the company card, and on the project card. This does not mean however that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| Date | date-time | date + start time planned |
| ExternalRef | string | External reference for document plugin to resolve document identity (Notes ID, e-mail message ID, whatever) |
| Completed | string | Document Completed state. This is the part of the Status property. |
| ActiveLinks | int32 | Number of active links to sale, document, appointment. |
| Type | string | Is this a normal document or a mail-merge or report? |
| Links | array | List of all elements linked to the document. |
| LockSemantics | string |  |
| Sale |  | A document may also be connected to a sale, so you see the document on the company card, on the project card and on the sale card. This does not mean however that a sale is required. May be null.  <para>Use MDO List name "sale" to get list items.</para> |
| SuggestedDocumentId | int32 | Suggested guide item that this document is an instance of (Note: NOT valid for appointments, they have their own link) |
| Snum | int32 | The sequence number allocated from refcount on used template when creating the document |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.DocumentEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.DocumentEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.DocumentEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.DocumentEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
PATCH /api/v1/Document/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "in",
    "value": {
      "value1": {
        "PrimaryKey": 8077,
        "EntityName": "sale",
        "saleId": 8077,
        "contactId": 7281,
        "name": "Okuneva-Schoen"
      },
      "value2": {
        "PrimaryKey": 573,
        "EntityName": "person",
        "personId": 573,
        "fullName": "Rachael Grady"
      }
    }
  },
  {
    "op": "add",
    "path": "in",
    "value": {
      "value1": {
        "PrimaryKey": 8077,
        "EntityName": "sale",
        "saleId": 8077,
        "contactId": 7281,
        "name": "Okuneva-Schoen"
      },
      "value2": {
        "PrimaryKey": 573,
        "EntityName": "person",
        "personId": 573,
        "fullName": "Rachael Grady"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 DocumentEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 209,
  "UpdatedBy": {
    "AssociateId": 279,
    "Name": "Miller LLC",
    "PersonId": 86,
    "Rank": 969,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 20,
    "FullName": "Annabell Cassin MD",
    "FormalName": "Maggio Group",
    "Deleted": true,
    "EjUserId": 521,
    "UserName": "Kautzer Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 836
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 737,
    "Name": "Nader Group",
    "PersonId": 92,
    "Rank": 184,
    "Tooltip": "facilis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 628,
    "FullName": "Morgan Vandervort",
    "FormalName": "Pacocha Inc and Sons",
    "Deleted": false,
    "EjUserId": 320,
    "UserName": "Schowalter-Wolff",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 250
      }
    }
  },
  "Attention": "deleniti",
  "Header": "omnis",
  "Name": "Stroman Group",
  "OurRef": "magnam",
  "YourRef": "dolore",
  "CreatedDate": "2006-08-01T15:05:42.1326351+02:00",
  "UpdatedDate": "2005-12-19T15:05:42.1326351+01:00",
  "Description": "Up-sized 24 hour functionalities",
  "DocumentTemplate": {
    "DocumentTemplateId": 482,
    "Name": "Pouros, Strosin and Deckow",
    "Tooltip": "nemo",
    "SaveInDb": 383,
    "Filename": "dolore",
    "DefaultOref": "voluptatem",
    "RecordType": "Appointment",
    "Deleted": 857,
    "Direction": "Incoming",
    "AutoeventId": 841,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "repurpose bricks-and-clicks metrics"
        },
        "FieldType": "System.Int32",
        "FieldLength": 759
      }
    }
  },
  "Person": {
    "Position": "ipsa",
    "PersonId": 661,
    "Mrmrs": "nihil",
    "Firstname": "Jarrod",
    "Lastname": "Daniel",
    "MiddleName": "Lemke-Jewess",
    "Title": "expedita",
    "Description": "Programmable encompassing application",
    "Email": "chadd_hirthe@schiller.ca",
    "FullName": "Cade Jast",
    "DirectPhone": "1-772-554-8814",
    "FormalName": "Will Group",
    "CountryId": 73,
    "ContactId": 688,
    "ContactName": "Predovic, Hermiston and Kassulke",
    "Retired": 180,
    "Rank": 80,
    "ActiveInterests": 672,
    "ContactDepartment": "",
    "ContactCountryId": 530,
    "ContactOrgNr": "665477",
    "FaxPhone": "844-270-3352 x671",
    "MobilePhone": "1-383-754-8057 x0620",
    "ContactPhone": "464.118.3514",
    "AssociateName": "Mayert, Rippin and Borer",
    "AssociateId": 548,
    "UsePersonAddress": false,
    "ContactFax": "ipsam",
    "Kanafname": "expedita",
    "Kanalname": "et",
    "Post1": "similique",
    "Post2": "iusto",
    "Post3": "rerum",
    "EmailName": "dangelo.schaden@cummings.uk",
    "ContactFullName": "Nyasia Wisozk",
    "ActiveErpLinks": 756,
    "TicketPriorityId": 27,
    "SupportLanguageId": 262,
    "SupportAssociateId": 198,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 233
      }
    }
  },
  "Associate": {
    "AssociateId": 19,
    "Name": "Wehner LLC",
    "PersonId": 404,
    "Rank": 779,
    "Tooltip": "nihil",
    "Type": "AnonymousAssociate",
    "GroupIdx": 89,
    "FullName": "Ariel Purdy",
    "FormalName": "Lakin Inc and Sons",
    "Deleted": false,
    "EjUserId": 378,
    "UserName": "Graham LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 705
      }
    }
  },
  "Contact": {
    "ContactId": 347,
    "Name": "Murray, Kshlerin and Quitzon",
    "OrgNr": "1234663",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "voluptas",
    "DirectPhone": "556.086.4336 x2541",
    "AssociateId": 233,
    "CountryId": 978,
    "EmailAddress": "kylee_balistreri@glover.co.uk",
    "Kananame": "voluptas",
    "EmailAddressName": "sharon_altenwerth@kuphal.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Makenna Cormier",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "dolorem",
    "FullName": "Maverick Haag",
    "IsOwnerContact": true,
    "ActiveErpLinks": 84,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "empower interactive action-items"
        },
        "FieldType": "System.Int32",
        "FieldLength": 586
      }
    }
  },
  "Project": {
    "ProjectId": 543,
    "Name": "Ryan, Howell and Schiller",
    "Description": "Profound upward-trending budgetary management",
    "URL": "http://www.example.com/",
    "Type": "dolorum",
    "AssociateId": 623,
    "AssociateFullName": "Orville Ruecker",
    "TypeId": 371,
    "Updated": "1999-11-18T15:05:42.1356348+01:00",
    "StatusId": 784,
    "Status": "ipsam",
    "TextId": 362,
    "PublishTo": "2016-03-03T15:05:42.1356348+01:00",
    "PublishFrom": "1998-10-02T15:05:42.1356348+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1284527",
    "ActiveErpLinks": 851,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 650
      }
    }
  },
  "Date": "2010-08-05T15:05:42.1356348+02:00",
  "ExternalRef": "laborum",
  "Completed": "Completed",
  "ActiveLinks": 961,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Aufderhar, Langworth and Abshire",
      "Id": 221,
      "Description": "Ergonomic 3rd generation standardization",
      "ExtraInfo": "a",
      "LinkId": 237,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 512
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Bashirian LLC",
    "SaleDate": "2002-05-15T15:05:42.1366356+02:00",
    "SaleId": 274,
    "Probability": 456,
    "Title": "earum",
    "Amount": 21427.158,
    "Currency": "corrupti",
    "ProjectName": "Emmerich Inc and Sons",
    "AssociateFullName": "Jacklyn Schmitt",
    "Description": "Universal static process improvement",
    "Status": "Lost",
    "WeightedAmount": 9677.792,
    "ProjectId": 142,
    "EarningPercent": 29801.206,
    "Earning": 25491.956,
    "ContactId": 678,
    "AssociateId": 246,
    "PersonId": 8,
    "SaleTypeId": 616,
    "SaleTypeName": "Hartmann-Hansen",
    "PersonFullName": "Ross Hills V",
    "Completed": "Completed",
    "ActiveErpLinks": 256,
    "NextDueDate": "2016-08-04T15:05:42.1366356+02:00",
    "Number": "1086610",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 763
      }
    }
  },
  "SuggestedDocumentId": 871,
  "Snum": 648,
  "UserDefinedFields": {
    "SuperOffice:1": "Joseph Ryan",
    "SuperOffice:2": "1607845296"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "mollitia",
    "CustomFields2": "esse"
  },
  "PublishEventDate": "2012-09-11T15:05:42.1366356+02:00",
  "PublishTo": "2020-11-09T15:05:42.1366356+01:00",
  "PublishFrom": "2006-01-05T15:05:42.1366356+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 17,
      "Visibility": "All",
      "DisplayValue": "neque",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 363
        }
      }
    },
    {
      "VisibleId": 17,
      "Visibility": "All",
      "DisplayValue": "neque",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 363
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
      "FieldLength": 945
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```