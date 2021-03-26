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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "rerum",
    "value": {
      "value1": {
        "PrimaryKey": 3557,
        "EntityName": "person",
        "personId": 3557,
        "fullName": "Zachery Hamill"
      },
      "value2": {
        "PrimaryKey": 1758,
        "EntityName": "sale",
        "saleId": 1758,
        "contactId": 3831,
        "name": "Conroy Group"
      }
    }
  },
  {
    "op": "add",
    "path": "rerum",
    "value": {
      "value1": {
        "PrimaryKey": 3557,
        "EntityName": "person",
        "personId": 3557,
        "fullName": "Zachery Hamill"
      },
      "value2": {
        "PrimaryKey": 1758,
        "EntityName": "sale",
        "saleId": 1758,
        "contactId": 3831,
        "name": "Conroy Group"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 DocumentEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 528,
  "UpdatedBy": {
    "AssociateId": 838,
    "Name": "Hoeger, Windler and Terry",
    "PersonId": 636,
    "Rank": 559,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 356,
    "FullName": "Carey Windler",
    "FormalName": "Johns LLC",
    "Deleted": false,
    "EjUserId": 123,
    "UserName": "Lesch, McClure and Baumbach",
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
  "CreatedBy": {
    "AssociateId": 446,
    "Name": "Zboncak Group",
    "PersonId": 214,
    "Rank": 134,
    "Tooltip": "similique",
    "Type": "AnonymousAssociate",
    "GroupIdx": 212,
    "FullName": "Tina Schoen",
    "FormalName": "Hodkiewicz-Beahan",
    "Deleted": false,
    "EjUserId": 244,
    "UserName": "Murray-Sipes",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 507
      }
    }
  },
  "Attention": "consequatur",
  "Header": "aliquam",
  "Name": "Zboncak, Huel and Botsford",
  "OurRef": "fugit",
  "YourRef": "libero",
  "CreatedDate": "2019-01-05T09:40:59.1238547+01:00",
  "UpdatedDate": "2017-05-02T09:40:59.1238547+02:00",
  "Description": "Enterprise-wide bi-directional Graphic Interface",
  "DocumentTemplate": {
    "DocumentTemplateId": 652,
    "Name": "Bernier Group",
    "Tooltip": "qui",
    "SaveInDb": 158,
    "Filename": "quis",
    "DefaultOref": "maiores",
    "RecordType": "Appointment",
    "Deleted": 272,
    "Direction": "Incoming",
    "AutoeventId": 3,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 29
      }
    }
  },
  "Person": {
    "Position": "ea",
    "PersonId": 222,
    "Mrmrs": "fugiat",
    "Firstname": "Dorris",
    "Lastname": "Kuhlman",
    "MiddleName": "Hodkiewicz-McKenzie",
    "Title": "ut",
    "Description": "Networked grid-enabled installation",
    "Email": "kitty_gibson@skiles.ca",
    "FullName": "Gussie West",
    "DirectPhone": "(782)544-0028",
    "FormalName": "Brekke, Batz and O'Hara",
    "CountryId": 741,
    "ContactId": 158,
    "ContactName": "Beatty, Nienow and O'Hara",
    "Retired": 836,
    "Rank": 786,
    "ActiveInterests": 129,
    "ContactDepartment": "",
    "ContactCountryId": 911,
    "ContactOrgNr": "914575",
    "FaxPhone": "573.670.5408",
    "MobilePhone": "733.276.4250 x577",
    "ContactPhone": "230.756.1884 x3511",
    "AssociateName": "Yost Inc and Sons",
    "AssociateId": 106,
    "UsePersonAddress": false,
    "ContactFax": "possimus",
    "Kanafname": "atque",
    "Kanalname": "et",
    "Post1": "blanditiis",
    "Post2": "aut",
    "Post3": "accusantium",
    "EmailName": "lamar@mertz.ca",
    "ContactFullName": "Dylan Klein",
    "ActiveErpLinks": 960,
    "TicketPriorityId": 472,
    "SupportLanguageId": 859,
    "SupportAssociateId": 843,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 199
      }
    }
  },
  "Associate": {
    "AssociateId": 587,
    "Name": "Klocko, Wyman and Harris",
    "PersonId": 13,
    "Rank": 28,
    "Tooltip": "excepturi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 471,
    "FullName": "Yesenia Wiegand DDS",
    "FormalName": "Hirthe-Auer",
    "Deleted": true,
    "EjUserId": 628,
    "UserName": "Hermiston-O'Kon",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 800
      }
    }
  },
  "Contact": {
    "ContactId": 798,
    "Name": "Paucek-Wintheiser",
    "OrgNr": "786045",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quis",
    "DirectPhone": "028.551.0004 x053",
    "AssociateId": 466,
    "CountryId": 260,
    "EmailAddress": "leif@fahey.uk",
    "Kananame": "numquam",
    "EmailAddressName": "emmet@mueller.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Junius Tromp",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "omnis",
    "FullName": "Anderson Schmitt I",
    "IsOwnerContact": false,
    "ActiveErpLinks": 593,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 143
      }
    }
  },
  "Project": {
    "ProjectId": 236,
    "Name": "Purdy Inc and Sons",
    "Description": "Pre-emptive coherent capacity",
    "URL": "http://www.example.com/",
    "Type": "quisquam",
    "AssociateId": 596,
    "AssociateFullName": "Odie Hauck",
    "TypeId": 321,
    "Updated": "2013-05-05T09:40:59.1266563+02:00",
    "StatusId": 412,
    "Status": "voluptatem",
    "TextId": 426,
    "PublishTo": "2009-02-07T09:40:59.1266563+01:00",
    "PublishFrom": "2017-10-22T09:40:59.1266563+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "641315",
    "ActiveErpLinks": 220,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 535
      }
    }
  },
  "Date": "2014-04-05T09:40:59.1266563+02:00",
  "ExternalRef": "autem",
  "Completed": "Completed",
  "ActiveLinks": 90,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Von-Rice",
      "Id": 393,
      "Description": "Switchable foreground Graphic Interface",
      "ExtraInfo": "qui",
      "LinkId": 835,
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
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Koch-Bruen",
    "SaleDate": "2011-09-09T09:40:59.1266563+02:00",
    "SaleId": 18,
    "Probability": 744,
    "Title": "quia",
    "Amount": 29948.504,
    "Currency": "labore",
    "ProjectName": "Metz LLC",
    "AssociateFullName": "Bria Hegmann",
    "Description": "Exclusive contextually-based neural-net",
    "Status": "Lost",
    "WeightedAmount": 11739.964,
    "ProjectId": 634,
    "EarningPercent": 18076.912,
    "Earning": 1234.796,
    "ContactId": 728,
    "AssociateId": 313,
    "PersonId": 418,
    "SaleTypeId": 666,
    "SaleTypeName": "Shanahan, Konopelski and Bartell",
    "PersonFullName": "Oma Langosh",
    "Completed": "Completed",
    "ActiveErpLinks": 75,
    "NextDueDate": "2019-04-05T09:40:59.1266563+02:00",
    "Number": "873935",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 609
      }
    }
  },
  "SuggestedDocumentId": 230,
  "Snum": 802,
  "UserDefinedFields": {
    "SuperOffice:1": "Alysson Konopelski",
    "SuperOffice:2": "Bennie Simonis"
  },
  "ExtraFields": {
    "ExtraFields1": "nemo",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "perspiciatis",
    "CustomFields2": "magnam"
  },
  "PublishEventDate": "2000-02-04T09:40:59.1466858+01:00",
  "PublishTo": "2017-04-12T09:40:59.1466858+02:00",
  "PublishFrom": "2013-09-03T09:40:59.1466858+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 108,
      "Visibility": "All",
      "DisplayValue": "dolor",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "extend distributed e-services"
          },
          "FieldType": "System.String",
          "FieldLength": 813
        }
      }
    },
    {
      "VisibleId": 108,
      "Visibility": "All",
      "DisplayValue": "dolor",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "extend distributed e-services"
          },
          "FieldType": "System.String",
          "FieldLength": 813
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
      "FieldLength": 360
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```