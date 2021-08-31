---
title: PUT Document/{id}
id: v1DocumentEntity_PutDocumentEntity
---

# PUT Document/{id}

```http
PUT /api/v1/Document/{id}
```

Updates the existing DocumentEntity Save the document entity.

If the entity already exists and the file name of the incoming entity is different from the existing one, a corresponding renaming of the physical document will be attempted. This may cause an amended file name to be substituted into the document entity, since a document plugin may have aribitrary rules on file names and collisions. Clients should always inspect the return value from this call and not assume that what they sent for saving is the final truth.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The DocumentEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Document/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity  

The DocumentEntity to be saved. 

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


## Response: object




DocumentEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | DocumentEntity updated. |
| 412 | Update stopped because DocumentEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Document/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 416,
  "UpdatedBy": {
    "AssociateId": 193,
    "Name": "Hudson, Bahringer and Conn",
    "PersonId": 562,
    "Rank": 712,
    "Tooltip": "suscipit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 804,
    "FullName": "Shaniya Kreiger",
    "FormalName": "Kautzer, Jenkins and Marvin",
    "Deleted": true,
    "EjUserId": 718,
    "UserName": "Botsford, Hilpert and Wilderman"
  },
  "CreatedBy": {
    "AssociateId": 651,
    "Name": "Ferry Group",
    "PersonId": 23,
    "Rank": 344,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 155,
    "FullName": "Miss Frederik Goyette",
    "FormalName": "Graham Inc and Sons",
    "Deleted": false,
    "EjUserId": 146,
    "UserName": "Harvey, Simonis and Heathcote"
  },
  "Attention": "et",
  "Header": "dolore",
  "Name": "Rutherford-Kozey",
  "OurRef": "aspernatur",
  "YourRef": "odio",
  "CreatedDate": "2011-06-16T15:05:42.1116675+02:00",
  "UpdatedDate": "1995-11-05T15:05:42.1116675+01:00",
  "Description": "Function-based zero administration attitude",
  "DocumentTemplate": {
    "DocumentTemplateId": 995,
    "Name": "Cremin, Mayert and Reinger",
    "Tooltip": "alias",
    "SaveInDb": 63,
    "Filename": "enim",
    "DefaultOref": "eligendi",
    "RecordType": "Appointment",
    "Deleted": 951,
    "Direction": "Incoming",
    "AutoeventId": 617,
    "QuoteDocType": "ConfirmationLines"
  },
  "Person": {
    "Position": "unde",
    "PersonId": 118,
    "Mrmrs": "aspernatur",
    "Firstname": "Kaitlin",
    "Lastname": "Terry",
    "MiddleName": "Rath-Volkman",
    "Title": "molestiae",
    "Description": "Triple-buffered executive toolset",
    "Email": "marcia@witting.us",
    "FullName": "Damaris Monahan",
    "DirectPhone": "1-108-721-8740 x6788",
    "FormalName": "Goodwin-Will",
    "CountryId": 18,
    "ContactId": 558,
    "ContactName": "Collier-Erdman",
    "Retired": 912,
    "Rank": 887,
    "ActiveInterests": 650,
    "ContactDepartment": "",
    "ContactCountryId": 800,
    "ContactOrgNr": "895433",
    "FaxPhone": "224.483.8746 x303",
    "MobilePhone": "(116)248-2558",
    "ContactPhone": "810.163.4387 x433",
    "AssociateName": "Yost, Hamill and Carroll",
    "AssociateId": 571,
    "UsePersonAddress": false,
    "ContactFax": "doloremque",
    "Kanafname": "rerum",
    "Kanalname": "totam",
    "Post1": "perspiciatis",
    "Post2": "cupiditate",
    "Post3": "harum",
    "EmailName": "katharina_bogan@waelchi.biz",
    "ContactFullName": "Virgil Rath",
    "ActiveErpLinks": 374,
    "TicketPriorityId": 410,
    "SupportLanguageId": 751,
    "SupportAssociateId": 826,
    "CategoryName": "VIP Customer"
  },
  "Associate": {
    "AssociateId": 362,
    "Name": "Lubowitz-McKenzie",
    "PersonId": 180,
    "Rank": 33,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 33,
    "FullName": "Ewell Ortiz",
    "FormalName": "Schneider LLC",
    "Deleted": false,
    "EjUserId": 711,
    "UserName": "Schaden Group"
  },
  "Contact": {
    "ContactId": 521,
    "Name": "Rempel, Jacobi and Jenkins",
    "OrgNr": "1252746",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quos",
    "DirectPhone": "853-138-0577",
    "AssociateId": 324,
    "CountryId": 56,
    "EmailAddress": "kimberly.orn@kassulkespinka.biz",
    "Kananame": "delectus",
    "EmailAddressName": "ron@shanahandickens.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Joan Koepp I",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nemo",
    "FullName": "Alessandra Nolan",
    "IsOwnerContact": false,
    "ActiveErpLinks": 173
  },
  "Project": {
    "ProjectId": 935,
    "Name": "Murphy-Zulauf",
    "Description": "Visionary coherent product",
    "URL": "http://www.example.com/",
    "Type": "dolorem",
    "AssociateId": 380,
    "AssociateFullName": "Nils Skiles IV",
    "TypeId": 830,
    "Updated": "2020-02-25T15:05:42.1156698+01:00",
    "StatusId": 979,
    "Status": "sed",
    "TextId": 697,
    "PublishTo": "2006-11-15T15:05:42.1156698+01:00",
    "PublishFrom": "2001-04-06T15:05:42.1156698+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "729547",
    "ActiveErpLinks": 357
  },
  "Date": "2019-08-21T15:05:42.1156698+02:00",
  "ExternalRef": "velit",
  "Completed": "Completed",
  "ActiveLinks": 7,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Gaylord Group",
      "Id": 50,
      "Description": "Optimized well-modulated algorithm",
      "ExtraInfo": "minus",
      "LinkId": 818
    },
    {
      "EntityName": "Gaylord Group",
      "Id": 50,
      "Description": "Optimized well-modulated algorithm",
      "ExtraInfo": "minus",
      "LinkId": 818
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Weimann-Rodriguez",
    "SaleDate": "2004-06-03T15:05:42.1156698+02:00",
    "SaleId": 773,
    "Probability": 712,
    "Title": "molestiae",
    "Amount": 12658.225999999999,
    "Currency": "ut",
    "ProjectName": "Dickens-Graham",
    "AssociateFullName": "Mikel Murphy Sr.",
    "Description": "Exclusive methodical moderator",
    "Status": "Lost",
    "WeightedAmount": 5873.116,
    "ProjectId": 746,
    "EarningPercent": 18152.128,
    "Earning": 17801.12,
    "ContactId": 782,
    "AssociateId": 508,
    "PersonId": 14,
    "SaleTypeId": 596,
    "SaleTypeName": "Willms, Reilly and Hoeger",
    "PersonFullName": "Johan Lesch",
    "Completed": "Completed",
    "ActiveErpLinks": 304,
    "NextDueDate": "1999-08-19T15:05:42.1156698+02:00",
    "Number": "904759"
  },
  "SuggestedDocumentId": 603,
  "Snum": 918,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "cupiditate",
    "ExtraFields2": "numquam"
  },
  "CustomFields": {
    "CustomFields1": "perferendis",
    "CustomFields2": "alias"
  },
  "PublishEventDate": "2020-04-12T15:05:42.1156698+02:00",
  "PublishTo": "2016-02-08T15:05:42.1156698+01:00",
  "PublishFrom": "1996-03-18T15:05:42.1156698+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 415,
      "Visibility": "All",
      "DisplayValue": "earum"
    },
    {
      "VisibleId": 415,
      "Visibility": "All",
      "DisplayValue": "earum"
    }
  ]
}
```

```http_
HTTP/1.1 200 DocumentEntity updated.
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 745,
  "UpdatedBy": {
    "AssociateId": 547,
    "Name": "Parker Group",
    "PersonId": 278,
    "Rank": 558,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 6,
    "FullName": "Jamey Kihn",
    "FormalName": "Jaskolski LLC",
    "Deleted": false,
    "EjUserId": 971,
    "UserName": "Gorczany, Hickle and Kris",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 699
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 476,
    "Name": "Walsh Inc and Sons",
    "PersonId": 548,
    "Rank": 374,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 625,
    "FullName": "Gino Keebler Sr.",
    "FormalName": "Tromp LLC",
    "Deleted": false,
    "EjUserId": 567,
    "UserName": "Powlowski, Nolan and Daniel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 997
      }
    }
  },
  "Attention": "vel",
  "Header": "voluptatem",
  "Name": "Beatty LLC",
  "OurRef": "et",
  "YourRef": "vel",
  "CreatedDate": "2009-02-16T15:05:42.1216671+01:00",
  "UpdatedDate": "2014-04-16T15:05:42.1216671+02:00",
  "Description": "Multi-tiered directional artificial intelligence",
  "DocumentTemplate": {
    "DocumentTemplateId": 787,
    "Name": "Dooley LLC",
    "Tooltip": "labore",
    "SaveInDb": 466,
    "Filename": "voluptatibus",
    "DefaultOref": "sequi",
    "RecordType": "Appointment",
    "Deleted": 832,
    "Direction": "Incoming",
    "AutoeventId": 712,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 789
      }
    }
  },
  "Person": {
    "Position": "corporis",
    "PersonId": 893,
    "Mrmrs": "at",
    "Firstname": "Althea",
    "Lastname": "Wiza",
    "MiddleName": "Funk LLC",
    "Title": "consectetur",
    "Description": "Inverse interactive functionalities",
    "Email": "rosamond_haag@veum.us",
    "FullName": "Sister Mayer",
    "DirectPhone": "(813)888-4043",
    "FormalName": "Paucek, Nolan and Gislason",
    "CountryId": 405,
    "ContactId": 597,
    "ContactName": "Kub-Wintheiser",
    "Retired": 589,
    "Rank": 291,
    "ActiveInterests": 745,
    "ContactDepartment": "",
    "ContactCountryId": 196,
    "ContactOrgNr": "993830",
    "FaxPhone": "(778)342-7088",
    "MobilePhone": "318.484.8758",
    "ContactPhone": "1-560-888-1210 x765",
    "AssociateName": "Langworth Inc and Sons",
    "AssociateId": 411,
    "UsePersonAddress": true,
    "ContactFax": "incidunt",
    "Kanafname": "soluta",
    "Kanalname": "vitae",
    "Post1": "nam",
    "Post2": "quo",
    "Post3": "quia",
    "EmailName": "gust@hettinger.com",
    "ContactFullName": "Jovan Green",
    "ActiveErpLinks": 831,
    "TicketPriorityId": 843,
    "SupportLanguageId": 625,
    "SupportAssociateId": 772,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 303
      }
    }
  },
  "Associate": {
    "AssociateId": 396,
    "Name": "Hills-Mayer",
    "PersonId": 454,
    "Rank": 813,
    "Tooltip": "eaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 550,
    "FullName": "Catharine Hammes",
    "FormalName": "Hermann Group",
    "Deleted": false,
    "EjUserId": 3,
    "UserName": "Keeling-Gaylord",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 890
      }
    }
  },
  "Contact": {
    "ContactId": 118,
    "Name": "Howe Group",
    "OrgNr": "1776289",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "commodi",
    "DirectPhone": "485.554.2262",
    "AssociateId": 355,
    "CountryId": 969,
    "EmailAddress": "jeanie_sipes@cummerata.co.uk",
    "Kananame": "explicabo",
    "EmailAddressName": "marty.schaefer@dickensbarrows.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Sigurd Will",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "et",
    "FullName": "Elouise Howell",
    "IsOwnerContact": false,
    "ActiveErpLinks": 892,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 511
      }
    }
  },
  "Project": {
    "ProjectId": 536,
    "Name": "Huels Group",
    "Description": "Devolved analyzing intranet",
    "URL": "http://www.example.com/",
    "Type": "tempora",
    "AssociateId": 321,
    "AssociateFullName": "Filiberto Keebler",
    "TypeId": 942,
    "Updated": "2014-01-28T15:05:42.1246359+01:00",
    "StatusId": 809,
    "Status": "eos",
    "TextId": 297,
    "PublishTo": "1994-07-11T15:05:42.1246359+02:00",
    "PublishFrom": "1999-03-03T15:05:42.1246359+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "804847",
    "ActiveErpLinks": 581,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 345
      }
    }
  },
  "Date": "2017-04-11T15:05:42.1246359+02:00",
  "ExternalRef": "aut",
  "Completed": "Completed",
  "ActiveLinks": 52,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Huel LLC",
      "Id": 16,
      "Description": "User-friendly bifurcated budgetary management",
      "ExtraInfo": "quidem",
      "LinkId": 990,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 113
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Schamberger, Funk and Murray",
    "SaleDate": "2002-11-02T15:05:42.1256354+01:00",
    "SaleId": 74,
    "Probability": 140,
    "Title": "quia",
    "Amount": 14341.184,
    "Currency": "animi",
    "ProjectName": "Bergnaum, Douglas and Swaniawski",
    "AssociateFullName": "Geo Schaden",
    "Description": "Compatible fresh-thinking parallelism",
    "Status": "Lost",
    "WeightedAmount": 10730.815999999999,
    "ProjectId": 851,
    "EarningPercent": 21301.798,
    "Earning": 24962.309999999998,
    "ContactId": 375,
    "AssociateId": 807,
    "PersonId": 28,
    "SaleTypeId": 191,
    "SaleTypeName": "Shields Inc and Sons",
    "PersonFullName": "Erich Raynor",
    "Completed": "Completed",
    "ActiveErpLinks": 364,
    "NextDueDate": "2019-06-06T15:05:42.1256354+02:00",
    "Number": "839111",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 543
      }
    }
  },
  "SuggestedDocumentId": 150,
  "Snum": 603,
  "UserDefinedFields": {
    "SuperOffice:1": "247757775",
    "SuperOffice:2": "Akeem Miller"
  },
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "ad",
    "CustomFields2": "quibusdam"
  },
  "PublishEventDate": "2013-07-28T15:05:42.1256354+02:00",
  "PublishTo": "2014-05-03T15:05:42.1256354+02:00",
  "PublishFrom": "2010-11-21T15:05:42.1256354+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 667,
      "Visibility": "All",
      "DisplayValue": "sequi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 45
        }
      }
    },
    {
      "VisibleId": 667,
      "Visibility": "All",
      "DisplayValue": "sequi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 45
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
      "FieldLength": 533
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```