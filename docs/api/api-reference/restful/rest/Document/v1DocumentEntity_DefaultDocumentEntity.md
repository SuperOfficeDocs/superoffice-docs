---
title: GET Document/default
id: v1DocumentEntity_DefaultDocumentEntity
---

# GET Document/default

```http
GET /api/v1/Document/default
```

Set default values into a new DocumentEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Document agent service CreateDefaultDocumentEntity.






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

Partial DocumentEntity class associating the generated DocumentEntity with an interface.

| Response | Description |
|----------------|-------------|
| 200 | OK |

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

## Sample Request

```http!
GET /api/v1/Document/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 02 Jun 2012 18:25:50 G6T

{
  "DocumentId": 892,
  "UpdatedBy": {
    "AssociateId": 804,
    "Name": "Kovacek-Ferry",
    "PersonId": 512,
    "Rank": 595,
    "Tooltip": "similique",
    "Type": "AnonymousAssociate",
    "GroupIdx": 465,
    "FullName": "Sabrina Schmitt",
    "FormalName": "Grant, Block and Barrows",
    "Deleted": true,
    "EjUserId": 317,
    "UserName": "Pfannerstill, Gleason and Dietrich",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 312
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 970,
    "Name": "Bernhard, Hilll and Boehm",
    "PersonId": 301,
    "Rank": 457,
    "Tooltip": "corporis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 473,
    "FullName": "Geovanny Reilly",
    "FormalName": "Harvey-Larson",
    "Deleted": true,
    "EjUserId": 24,
    "UserName": "Klocko, Haag and Murphy",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 838
      }
    }
  },
  "Attention": "sed",
  "Header": "rerum",
  "Name": "Heller, Grady and Sauer",
  "OurRef": "temporibus",
  "YourRef": "fuga",
  "CreatedDate": "2006-07-17T18:25:50.4166246+02:00",
  "UpdatedDate": "2012-06-02T18:25:50.4166246+02:00",
  "Description": "Upgradable zero defect help-desk",
  "DocumentTemplate": {
    "DocumentTemplateId": 558,
    "Name": "Waters-Beatty",
    "Tooltip": "non",
    "SaveInDb": 677,
    "Filename": "nemo",
    "DefaultOref": "pariatur",
    "RecordType": "Appointment",
    "Deleted": 342,
    "Direction": "Incoming",
    "AutoeventId": 171,
    "QuoteDocType": "ConfirmationLines",
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
  "Person": {
    "Position": "natus",
    "PersonId": 255,
    "Mrmrs": "rerum",
    "Firstname": "Rhoda",
    "Lastname": "Littel",
    "MiddleName": "Satterfield-Koch",
    "Title": "cupiditate",
    "Description": "Function-based coherent algorithm",
    "Email": "rossie_weissnat@naderprice.ca",
    "FullName": "Ms. Blake Gaylord",
    "DirectPhone": "1-820-058-6827",
    "FormalName": "Keeling LLC",
    "CountryId": 251,
    "ContactId": 408,
    "ContactName": "Roberts, Hansen and Hayes",
    "Retired": 153,
    "Rank": 445,
    "ActiveInterests": 535,
    "ContactDepartment": "",
    "ContactCountryId": 678,
    "ContactOrgNr": "1015723",
    "FaxPhone": "081.675.2443",
    "MobilePhone": "824-020-6423 x262",
    "ContactPhone": "1-707-373-7855",
    "AssociateName": "Christiansen Inc and Sons",
    "AssociateId": 282,
    "UsePersonAddress": false,
    "ContactFax": "placeat",
    "Kanafname": "deleniti",
    "Kanalname": "et",
    "Post1": "et",
    "Post2": "quia",
    "Post3": "asperiores",
    "EmailName": "jaydon_rowe@stanton.co.uk",
    "ContactFullName": "Frances Brekke",
    "ActiveErpLinks": 583,
    "TicketPriorityId": 945,
    "SupportLanguageId": 659,
    "SupportAssociateId": 980,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 201
      }
    }
  },
  "Associate": {
    "AssociateId": 855,
    "Name": "O'Connell-Bernier",
    "PersonId": 637,
    "Rank": 343,
    "Tooltip": "accusantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 767,
    "FullName": "Jameson Dibbert",
    "FormalName": "Kassulke-Wuckert",
    "Deleted": true,
    "EjUserId": 656,
    "UserName": "Sporer, Gottlieb and Miller",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 641
      }
    }
  },
  "Contact": {
    "ContactId": 371,
    "Name": "Oberbrunner-Kirlin",
    "OrgNr": "1098727",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "culpa",
    "DirectPhone": "133.387.8208 x814",
    "AssociateId": 679,
    "CountryId": 542,
    "EmailAddress": "zackery@waelchi.com",
    "Kananame": "minima",
    "EmailAddressName": "ward_hodkiewicz@king.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ryley Sipes PhD",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ipsam",
    "FullName": "Toy Kling",
    "IsOwnerContact": false,
    "ActiveErpLinks": 954,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 229
      }
    }
  },
  "Project": {
    "ProjectId": 20,
    "Name": "Veum, Glover and Schamberger",
    "Description": "Exclusive assymetric firmware",
    "URL": "http://www.example.com/",
    "Type": "eveniet",
    "AssociateId": 133,
    "AssociateFullName": "Isabelle Cummerata",
    "TypeId": 446,
    "Updated": "2003-07-16T18:25:50.4196247+02:00",
    "StatusId": 832,
    "Status": "quo",
    "TextId": 741,
    "PublishTo": "2014-03-10T18:25:50.4196247+01:00",
    "PublishFrom": "2003-03-06T18:25:50.4196247+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1243492",
    "ActiveErpLinks": 540,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 216
      }
    }
  },
  "Date": "1997-10-12T18:25:50.4196247+02:00",
  "ExternalRef": "minima",
  "Completed": "Completed",
  "ActiveLinks": 730,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Davis Group",
      "Id": 807,
      "Description": "Compatible intangible groupware",
      "ExtraInfo": "saepe",
      "LinkId": 970,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 39
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Beer Group",
    "SaleDate": "1996-01-01T18:25:50.4196247+01:00",
    "SaleId": 336,
    "Probability": 119,
    "Title": "ut",
    "Amount": 7897.6799999999994,
    "Currency": "dolorum",
    "ProjectName": "Effertz, Armstrong and Rogahn",
    "AssociateFullName": "Miss Hubert Barton",
    "Description": "Horizontal multimedia implementation",
    "Status": "Lost",
    "WeightedAmount": 20151.62,
    "ProjectId": 749,
    "EarningPercent": 8659.242,
    "Earning": 28948.757999999998,
    "ContactId": 620,
    "AssociateId": 763,
    "PersonId": 533,
    "SaleTypeId": 451,
    "SaleTypeName": "Labadie-Bosco",
    "PersonFullName": "Erich Gulgowski",
    "Completed": "Completed",
    "ActiveErpLinks": 396,
    "NextDueDate": "2013-11-15T18:25:50.420597+01:00",
    "Number": "1550229",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 754
      }
    }
  },
  "SuggestedDocumentId": 198,
  "Snum": 913,
  "UserDefinedFields": {
    "SuperOffice:1": "Estefania Wolff",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "suscipit",
    "ExtraFields2": "inventore"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "quisquam"
  },
  "PublishEventDate": "2005-11-18T18:25:50.420597+01:00",
  "PublishTo": "2017-04-14T18:25:50.420597+02:00",
  "PublishFrom": "2014-05-29T18:25:50.420597+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 167,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 11
        }
      }
    },
    {
      "VisibleId": 167,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 11
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
      "FieldLength": 14
    }
  }
}
```