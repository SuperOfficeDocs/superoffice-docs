---
title: GET Document/{id}
id: v1DocumentEntity_GetDocumentEntity
---

# GET Document/{id}

```http
GET /api/v1/Document/{id}
```

Gets a DocumentEntity object.

Calls the Document agent service GetDocumentEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the DocumentEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Document/{id}?$select=name,department,category/id
GET /api/v1/Document/{id}?fk=True
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




DocumentEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | DocumentEntity found. |
| 304 | DocumentEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

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
GET /api/v1/Document/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 DocumentEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 15 Jan 1996 09:40:59 G1T

{
  "DocumentId": 865,
  "UpdatedBy": {
    "AssociateId": 789,
    "Name": "Boehm Inc and Sons",
    "PersonId": 914,
    "Rank": 820,
    "Tooltip": "libero",
    "Type": "AnonymousAssociate",
    "GroupIdx": 917,
    "FullName": "Ava Windler",
    "FormalName": "Pollich Inc and Sons",
    "Deleted": true,
    "EjUserId": 451,
    "UserName": "Lakin, Leannon and Parker",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 445
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 657,
    "Name": "Ratke Inc and Sons",
    "PersonId": 548,
    "Rank": 957,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 494,
    "FullName": "Mrs. Eliza Kiehn",
    "FormalName": "Rath, Streich and Parisian",
    "Deleted": true,
    "EjUserId": 381,
    "UserName": "Smith, Ward and Ratke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 268
      }
    }
  },
  "Attention": "aut",
  "Header": "fugiat",
  "Name": "Konopelski Inc and Sons",
  "OurRef": "tenetur",
  "YourRef": "consequatur",
  "CreatedDate": "2012-10-14T09:40:59.0978862+02:00",
  "UpdatedDate": "1996-01-15T09:40:59.0978862+01:00",
  "Description": "Multi-channelled clear-thinking complexity",
  "DocumentTemplate": {
    "DocumentTemplateId": 96,
    "Name": "Corkery, Heller and Langosh",
    "Tooltip": "illum",
    "SaveInDb": 130,
    "Filename": "minus",
    "DefaultOref": "qui",
    "RecordType": "Appointment",
    "Deleted": 2,
    "Direction": "Incoming",
    "AutoeventId": 939,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "extend value-added solutions"
        },
        "FieldType": "System.Int32",
        "FieldLength": 834
      }
    }
  },
  "Person": {
    "Position": "velit",
    "PersonId": 761,
    "Mrmrs": "enim",
    "Firstname": "Warren",
    "Lastname": "Klocko",
    "MiddleName": "Orn Group",
    "Title": "qui",
    "Description": "Multi-lateral even-keeled pricing structure",
    "Email": "edward.stroman@powlowski.uk",
    "FullName": "Wanda Keebler",
    "DirectPhone": "(023)175-2000",
    "FormalName": "Schumm, Ziemann and Glover",
    "CountryId": 563,
    "ContactId": 153,
    "ContactName": "Hoeger-Schroeder",
    "Retired": 477,
    "Rank": 907,
    "ActiveInterests": 159,
    "ContactDepartment": "",
    "ContactCountryId": 501,
    "ContactOrgNr": "1091258",
    "FaxPhone": "188-787-8482",
    "MobilePhone": "1-741-254-3470 x110",
    "ContactPhone": "181.757.4351 x112",
    "AssociateName": "Wehner, Blanda and Schuster",
    "AssociateId": 649,
    "UsePersonAddress": false,
    "ContactFax": "in",
    "Kanafname": "voluptas",
    "Kanalname": "molestias",
    "Post1": "dicta",
    "Post2": "sed",
    "Post3": "alias",
    "EmailName": "shad.schowalter@runte.uk",
    "ContactFullName": "Mrs. Torrey Witting",
    "ActiveErpLinks": 148,
    "TicketPriorityId": 496,
    "SupportLanguageId": 242,
    "SupportAssociateId": 513,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 489
      }
    }
  },
  "Associate": {
    "AssociateId": 329,
    "Name": "Zemlak Group",
    "PersonId": 631,
    "Rank": 522,
    "Tooltip": "occaecati",
    "Type": "AnonymousAssociate",
    "GroupIdx": 345,
    "FullName": "Macie Daniel",
    "FormalName": "Gorczany-Abshire",
    "Deleted": true,
    "EjUserId": 15,
    "UserName": "Fahey LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 343
      }
    }
  },
  "Contact": {
    "ContactId": 358,
    "Name": "Anderson-Ullrich",
    "OrgNr": "1140918",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "sint",
    "DirectPhone": "528-222-6564 x276",
    "AssociateId": 220,
    "CountryId": 237,
    "EmailAddress": "kiera@abbottbogisich.info",
    "Kananame": "vel",
    "EmailAddressName": "dorcas.harris@ernserryan.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Maeve Willms",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "omnis",
    "FullName": "Millie Bednar DVM",
    "IsOwnerContact": false,
    "ActiveErpLinks": 843,
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
  "Project": {
    "ProjectId": 719,
    "Name": "Ortiz, Crist and Ziemann",
    "Description": "Ergonomic non-volatile hardware",
    "URL": "http://www.example.com/",
    "Type": "numquam",
    "AssociateId": 433,
    "AssociateFullName": "Al Ebert",
    "TypeId": 919,
    "Updated": "2018-01-27T09:40:59.1008547+01:00",
    "StatusId": 392,
    "Status": "voluptate",
    "TextId": 354,
    "PublishTo": "2017-06-13T09:40:59.1008547+02:00",
    "PublishFrom": "1999-03-26T09:40:59.1008547+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "723941",
    "ActiveErpLinks": 856,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 32
      }
    }
  },
  "Date": "2011-08-16T09:40:59.1008547+02:00",
  "ExternalRef": "atque",
  "Completed": "Completed",
  "ActiveLinks": 323,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Bernhard, Sauer and Thiel",
      "Id": 208,
      "Description": "Enterprise-wide fresh-thinking groupware",
      "ExtraInfo": "temporibus",
      "LinkId": 700,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 453
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Quigley LLC",
    "SaleDate": "1996-03-15T09:40:59.1008547+01:00",
    "SaleId": 204,
    "Probability": 197,
    "Title": "eos",
    "Amount": 25444.946,
    "Currency": "aut",
    "ProjectName": "Streich-Gleason",
    "AssociateFullName": "Elody Torphy",
    "Description": "Implemented client-driven firmware",
    "Status": "Lost",
    "WeightedAmount": 16519.314,
    "ProjectId": 148,
    "EarningPercent": 28415.978,
    "Earning": 12319.753999999999,
    "ContactId": 185,
    "AssociateId": 148,
    "PersonId": 460,
    "SaleTypeId": 157,
    "SaleTypeName": "Wisoky-Stracke",
    "PersonFullName": "Clyde Walsh",
    "Completed": "Completed",
    "ActiveErpLinks": 294,
    "NextDueDate": "2010-01-25T09:40:59.1008547+01:00",
    "Number": "1083350",
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
  },
  "SuggestedDocumentId": 224,
  "Snum": 893,
  "UserDefinedFields": {
    "SuperOffice:1": "134190784",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "natus",
    "CustomFields2": "occaecati"
  },
  "PublishEventDate": "2020-09-16T09:40:59.1018547+02:00",
  "PublishTo": "2019-11-20T09:40:59.1018547+01:00",
  "PublishFrom": "2008-12-20T09:40:59.1018547+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 225,
      "Visibility": "All",
      "DisplayValue": "earum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 16
        }
      }
    },
    {
      "VisibleId": 225,
      "Visibility": "All",
      "DisplayValue": "earum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 16
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
        "Reason": "syndicate bleeding-edge e-commerce"
      },
      "FieldType": "System.String",
      "FieldLength": 504
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```