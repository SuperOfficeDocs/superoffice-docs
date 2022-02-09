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
    "path": "occaecati",
    "value": {
      "value1": {
        "PrimaryKey": 2974,
        "EntityName": "sale",
        "saleId": 2974,
        "contactId": 1736,
        "name": "Blanda Inc and Sons"
      },
      "value2": {
        "PrimaryKey": 5392,
        "EntityName": "sale",
        "saleId": 5392,
        "contactId": 5454,
        "name": "Hills-Greenholt"
      }
    }
  },
  {
    "op": "add",
    "path": "occaecati",
    "value": {
      "value1": {
        "PrimaryKey": 2974,
        "EntityName": "sale",
        "saleId": 2974,
        "contactId": 1736,
        "name": "Blanda Inc and Sons"
      },
      "value2": {
        "PrimaryKey": 5392,
        "EntityName": "sale",
        "saleId": 5392,
        "contactId": 5454,
        "name": "Hills-Greenholt"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 DocumentEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 634,
  "UpdatedBy": {
    "AssociateId": 489,
    "Name": "Krajcik, Hickle and Vandervort",
    "PersonId": 296,
    "Rank": 274,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 523,
    "FullName": "Etha Larson",
    "FormalName": "Berge Inc and Sons",
    "Deleted": true,
    "EjUserId": 120,
    "UserName": "Kuphal LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 739
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 193,
    "Name": "Leuschke LLC",
    "PersonId": 283,
    "Rank": 997,
    "Tooltip": "eligendi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 416,
    "FullName": "Mike Jakubowski",
    "FormalName": "Johns, Feil and O'Keefe",
    "Deleted": false,
    "EjUserId": 848,
    "UserName": "Weimann, Hyatt and Schultz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 850
      }
    }
  },
  "Attention": "magni",
  "Header": "voluptas",
  "Name": "McClure Inc and Sons",
  "OurRef": "illo",
  "YourRef": "quod",
  "CreatedDate": "2016-08-27T18:25:50.4966298+02:00",
  "UpdatedDate": "2007-07-05T18:25:50.4966298+02:00",
  "Description": "Robust multimedia paradigm",
  "DocumentTemplate": {
    "DocumentTemplateId": 902,
    "Name": "Klein-Murray",
    "Tooltip": "pariatur",
    "SaveInDb": 266,
    "Filename": "quam",
    "DefaultOref": "aut",
    "RecordType": "Appointment",
    "Deleted": 795,
    "Direction": "Incoming",
    "AutoeventId": 302,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "aggregate efficient web services"
        },
        "FieldType": "System.String",
        "FieldLength": 577
      }
    }
  },
  "Person": {
    "Position": "ut",
    "PersonId": 666,
    "Mrmrs": "ut",
    "Firstname": "Tanya",
    "Lastname": "Lehner",
    "MiddleName": "Doyle Inc and Sons",
    "Title": "repudiandae",
    "Description": "Synergized 6th generation methodology",
    "Email": "sabina@stark.info",
    "FullName": "Elsie O'Conner",
    "DirectPhone": "713.506.2723 x648",
    "FormalName": "Torp Inc and Sons",
    "CountryId": 604,
    "ContactId": 501,
    "ContactName": "Kuhic LLC",
    "Retired": 887,
    "Rank": 428,
    "ActiveInterests": 650,
    "ContactDepartment": "",
    "ContactCountryId": 696,
    "ContactOrgNr": "264650",
    "FaxPhone": "373.661.3851 x85061",
    "MobilePhone": "386-431-7111 x86613",
    "ContactPhone": "178-426-1842 x8218",
    "AssociateName": "Considine-Eichmann",
    "AssociateId": 837,
    "UsePersonAddress": false,
    "ContactFax": "nisi",
    "Kanafname": "perspiciatis",
    "Kanalname": "voluptatibus",
    "Post1": "omnis",
    "Post2": "velit",
    "Post3": "numquam",
    "EmailName": "retta@jaskolski.info",
    "ContactFullName": "Jayme Mills",
    "ActiveErpLinks": 793,
    "TicketPriorityId": 809,
    "SupportLanguageId": 32,
    "SupportAssociateId": 175,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 262
      }
    }
  },
  "Associate": {
    "AssociateId": 825,
    "Name": "Langosh, Trantow and Farrell",
    "PersonId": 646,
    "Rank": 291,
    "Tooltip": "minima",
    "Type": "AnonymousAssociate",
    "GroupIdx": 563,
    "FullName": "Dakota Maggio DDS",
    "FormalName": "Barton, Leffler and Koch",
    "Deleted": false,
    "EjUserId": 495,
    "UserName": "Herzog LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 537
      }
    }
  },
  "Contact": {
    "ContactId": 584,
    "Name": "Wunsch-Howell",
    "OrgNr": "418550",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "eos",
    "DirectPhone": "1-110-780-0232",
    "AssociateId": 44,
    "CountryId": 178,
    "EmailAddress": "marilyne@cronin.biz",
    "Kananame": "ut",
    "EmailAddressName": "royal_romaguera@upton.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Penelope Hartmann",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quo",
    "FullName": "Earnestine Steuber",
    "IsOwnerContact": false,
    "ActiveErpLinks": 101,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 996
      }
    }
  },
  "Project": {
    "ProjectId": 728,
    "Name": "Jakubowski-Feeney",
    "Description": "Front-line demand-driven toolset",
    "URL": "http://www.example.com/",
    "Type": "accusantium",
    "AssociateId": 25,
    "AssociateFullName": "Orlando Heller IV",
    "TypeId": 262,
    "Updated": "1998-05-17T18:25:50.4996292+02:00",
    "StatusId": 73,
    "Status": "itaque",
    "TextId": 260,
    "PublishTo": "2009-06-21T18:25:50.4996292+02:00",
    "PublishFrom": "2010-01-26T18:25:50.4996292+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "885108",
    "ActiveErpLinks": 357,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 646
      }
    }
  },
  "Date": "2019-12-23T18:25:50.4996292+01:00",
  "ExternalRef": "dolores",
  "Completed": "Completed",
  "ActiveLinks": 967,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Padberg-Krajcik",
      "Id": 911,
      "Description": "Cloned foreground process improvement",
      "ExtraInfo": "unde",
      "LinkId": 938,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 793
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Kuphal Group",
    "SaleDate": "2007-02-11T18:25:50.4996292+01:00",
    "SaleId": 296,
    "Probability": 786,
    "Title": "consequatur",
    "Amount": 29666.444,
    "Currency": "nam",
    "ProjectName": "Homenick-Wilderman",
    "AssociateFullName": "Earnest Kuhn",
    "Description": "Open-source 24 hour emulation",
    "Status": "Lost",
    "WeightedAmount": 24009.574,
    "ProjectId": 28,
    "EarningPercent": 5565.9839999999995,
    "Earning": 1579.536,
    "ContactId": 666,
    "AssociateId": 400,
    "PersonId": 916,
    "SaleTypeId": 489,
    "SaleTypeName": "Bechtelar-Quitzon",
    "PersonFullName": "Lexi Wolf",
    "Completed": "Completed",
    "ActiveErpLinks": 711,
    "NextDueDate": "2013-03-08T18:25:50.500594+01:00",
    "Number": "1146473",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 497
      }
    }
  },
  "SuggestedDocumentId": 417,
  "Snum": 995,
  "UserDefinedFields": {
    "SuperOffice:1": "767134114",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "deserunt",
    "ExtraFields2": "harum"
  },
  "CustomFields": {
    "CustomFields1": "rem",
    "CustomFields2": "corrupti"
  },
  "PublishEventDate": "2004-08-28T18:25:50.500594+02:00",
  "PublishTo": "2011-04-25T18:25:50.500594+02:00",
  "PublishFrom": "2021-01-23T18:25:50.500594+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 566,
      "Visibility": "All",
      "DisplayValue": "dicta",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 574
        }
      }
    },
    {
      "VisibleId": 566,
      "Visibility": "All",
      "DisplayValue": "dicta",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 574
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
      "FieldLength": 237
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```