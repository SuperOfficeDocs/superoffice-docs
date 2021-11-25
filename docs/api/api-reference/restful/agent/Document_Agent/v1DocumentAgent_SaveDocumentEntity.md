---
title: POST Agents/Document/SaveDocumentEntity
id: v1DocumentAgent_SaveDocumentEntity
---

# POST Agents/Document/SaveDocumentEntity

```http
POST /api/v1/Agents/Document/SaveDocumentEntity
```

Updates the existing DocumentEntity or creates a new DocumentEntity if the id parameter is empty








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
POST /api/v1/Agents/Document/SaveDocumentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 346,
  "UpdatedBy": {
    "AssociateId": 268,
    "Name": "Aufderhar-Rogahn",
    "PersonId": 82,
    "Rank": 259,
    "Tooltip": "voluptatum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 449,
    "FullName": "Cortez Brakus",
    "FormalName": "Marvin Inc and Sons",
    "Deleted": false,
    "EjUserId": 427,
    "UserName": "Conn, Bradtke and Emmerich"
  },
  "CreatedBy": {
    "AssociateId": 626,
    "Name": "Medhurst-Becker",
    "PersonId": 385,
    "Rank": 1001,
    "Tooltip": "voluptatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 523,
    "FullName": "Viviane Carroll",
    "FormalName": "Maggio LLC",
    "Deleted": true,
    "EjUserId": 637,
    "UserName": "Reichert, Miller and Blick"
  },
  "Attention": "omnis",
  "Header": "doloribus",
  "Name": "Kertzmann LLC",
  "OurRef": "optio",
  "YourRef": "et",
  "CreatedDate": "2020-08-04T18:28:48.8329619+02:00",
  "UpdatedDate": "1999-08-16T18:28:48.8329619+02:00",
  "Description": "Progressive bottom-line adapter",
  "DocumentTemplate": {
    "DocumentTemplateId": 876,
    "Name": "Schiller Inc and Sons",
    "Tooltip": "esse",
    "SaveInDb": 593,
    "Filename": "maiores",
    "DefaultOref": "quidem",
    "RecordType": "Appointment",
    "Deleted": 98,
    "Direction": "Incoming",
    "AutoeventId": 183,
    "QuoteDocType": "ConfirmationLines"
  },
  "Person": {
    "Position": "unde",
    "PersonId": 903,
    "Mrmrs": "quasi",
    "Firstname": "Gloria",
    "Lastname": "Von",
    "MiddleName": "Kihn Inc and Sons",
    "Title": "explicabo",
    "Description": "Re-contextualized analyzing concept",
    "Email": "john.ruecker@waters.co.uk",
    "FullName": "Rosina Abernathy IV",
    "DirectPhone": "423-373-2628 x42474",
    "FormalName": "Kunze-Jast",
    "CountryId": 917,
    "ContactId": 344,
    "ContactName": "Labadie, Schimmel and Ledner",
    "Retired": 464,
    "Rank": 446,
    "ActiveInterests": 274,
    "ContactDepartment": "",
    "ContactCountryId": 875,
    "ContactOrgNr": "887526",
    "FaxPhone": "338.036.7581",
    "MobilePhone": "323.347.3630",
    "ContactPhone": "004.773.1085",
    "AssociateName": "Bogisich, Watsica and Breitenberg",
    "AssociateId": 885,
    "UsePersonAddress": true,
    "ContactFax": "placeat",
    "Kanafname": "ad",
    "Kanalname": "dolorum",
    "Post1": "qui",
    "Post2": "veritatis",
    "Post3": "id",
    "EmailName": "ida@sawayn.uk",
    "ContactFullName": "Kristin Leffler",
    "ActiveErpLinks": 870,
    "TicketPriorityId": 431,
    "SupportLanguageId": 485,
    "SupportAssociateId": 939,
    "CategoryName": "VIP Customer"
  },
  "Associate": {
    "AssociateId": 229,
    "Name": "Mohr-Dietrich",
    "PersonId": 469,
    "Rank": 278,
    "Tooltip": "commodi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 922,
    "FullName": "Ransom Schamberger",
    "FormalName": "Powlowski-Anderson",
    "Deleted": false,
    "EjUserId": 820,
    "UserName": "Johnston-Lowe"
  },
  "Contact": {
    "ContactId": 458,
    "Name": "Wilderman-Sawayn",
    "OrgNr": "1456137",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "et",
    "DirectPhone": "(174)377-0570 x01084",
    "AssociateId": 410,
    "CountryId": 949,
    "EmailAddress": "keshawn@beatty.uk",
    "Kananame": "aut",
    "EmailAddressName": "haley_lubowitz@labadie.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mrs. Alta Volkman",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "deserunt",
    "FullName": "Koby Hayes IV",
    "IsOwnerContact": true,
    "ActiveErpLinks": 582
  },
  "Project": {
    "ProjectId": 53,
    "Name": "Hane Group",
    "Description": "Reverse-engineered discrete process improvement",
    "URL": "http://www.example.com/",
    "Type": "inventore",
    "AssociateId": 732,
    "AssociateFullName": "Miss Stella Dibbert",
    "TypeId": 641,
    "Updated": "1998-04-10T18:28:48.8359267+02:00",
    "StatusId": 232,
    "Status": "qui",
    "TextId": 586,
    "PublishTo": "2020-11-24T18:28:48.8359267+01:00",
    "PublishFrom": "2017-11-29T18:28:48.8359267+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "985183",
    "ActiveErpLinks": 306
  },
  "Date": "2010-12-28T18:28:48.8359267+01:00",
  "ExternalRef": "eum",
  "Completed": "Completed",
  "ActiveLinks": 722,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Gusikowski-Mitchell",
      "Id": 119,
      "Description": "Intuitive reciprocal task-force",
      "ExtraInfo": "quo",
      "LinkId": 210
    },
    {
      "EntityName": "Gusikowski-Mitchell",
      "Id": 119,
      "Description": "Intuitive reciprocal task-force",
      "ExtraInfo": "quo",
      "LinkId": 210
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Funk LLC",
    "SaleDate": "2021-07-05T18:28:48.8359267+02:00",
    "SaleId": 987,
    "Probability": 953,
    "Title": "ut",
    "Amount": 29569.289999999997,
    "Currency": "nobis",
    "ProjectName": "Ullrich-Senger",
    "AssociateFullName": "Santos Kihn PhD",
    "Description": "Multi-lateral 24 hour local area network",
    "Status": "Lost",
    "WeightedAmount": 4635.186,
    "ProjectId": 123,
    "EarningPercent": 18816.536,
    "Earning": 18217.942,
    "ContactId": 524,
    "AssociateId": 456,
    "PersonId": 452,
    "SaleTypeId": 465,
    "SaleTypeName": "Rodriguez-Shields",
    "PersonFullName": "Chasity Shields",
    "Completed": "Completed",
    "ActiveErpLinks": 292,
    "NextDueDate": "2010-08-01T18:28:48.8359267+02:00",
    "Number": "814134"
  },
  "SuggestedDocumentId": 143,
  "Snum": 778,
  "UserDefinedFields": {
    "SuperOffice:1": "Maxime Greenholt",
    "SuperOffice:2": "Ernestine Hilpert"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "odit"
  },
  "CustomFields": {
    "CustomFields1": "esse",
    "CustomFields2": "molestiae"
  },
  "PublishEventDate": "1997-02-19T18:28:48.8369561+01:00",
  "PublishTo": "1997-05-08T18:28:48.8369561+02:00",
  "PublishFrom": "2008-10-06T18:28:48.8369561+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 942,
      "Visibility": "All",
      "DisplayValue": "facilis"
    },
    {
      "VisibleId": 942,
      "Visibility": "All",
      "DisplayValue": "facilis"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 85,
  "UpdatedBy": {
    "AssociateId": 448,
    "Name": "Heidenreich, Skiles and Blanda",
    "PersonId": 410,
    "Rank": 235,
    "Tooltip": "odio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 980,
    "FullName": "Garrison Schmeler",
    "FormalName": "Jenkins, Schuster and Sipes",
    "Deleted": true,
    "EjUserId": 193,
    "UserName": "Lehner-White",
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
  "CreatedBy": {
    "AssociateId": 474,
    "Name": "Fisher-Klocko",
    "PersonId": 364,
    "Rank": 299,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 604,
    "FullName": "Camylle Watsica",
    "FormalName": "Ankunding, Zulauf and Gerlach",
    "Deleted": true,
    "EjUserId": 377,
    "UserName": "Wuckert-Kris",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 831
      }
    }
  },
  "Attention": "impedit",
  "Header": "maxime",
  "Name": "Jacobi-McKenzie",
  "OurRef": "omnis",
  "YourRef": "velit",
  "CreatedDate": "2015-06-26T18:28:48.8429608+02:00",
  "UpdatedDate": "2005-01-15T18:28:48.8429608+01:00",
  "Description": "Implemented zero administration productivity",
  "DocumentTemplate": {
    "DocumentTemplateId": 710,
    "Name": "Legros, Parisian and Leannon",
    "Tooltip": "ea",
    "SaveInDb": 534,
    "Filename": "voluptatum",
    "DefaultOref": "eos",
    "RecordType": "Appointment",
    "Deleted": 993,
    "Direction": "Incoming",
    "AutoeventId": 408,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 100
      }
    }
  },
  "Person": {
    "Position": "amet",
    "PersonId": 892,
    "Mrmrs": "incidunt",
    "Firstname": "Theresa",
    "Lastname": "Lebsack",
    "MiddleName": "Balistreri, Spencer and Abernathy",
    "Title": "adipisci",
    "Description": "Robust empowering encryption",
    "Email": "elouise.heller@beerwehner.us",
    "FullName": "Whitney Russel",
    "DirectPhone": "720-626-2551",
    "FormalName": "McDermott Group",
    "CountryId": 735,
    "ContactId": 663,
    "ContactName": "Beer-Ruecker",
    "Retired": 534,
    "Rank": 220,
    "ActiveInterests": 123,
    "ContactDepartment": "reinvent one-to-one e-commerce",
    "ContactCountryId": 346,
    "ContactOrgNr": "1065965",
    "FaxPhone": "402-140-6630",
    "MobilePhone": "1-465-604-4532 x264",
    "ContactPhone": "860.708.8830 x003",
    "AssociateName": "Rempel-Towne",
    "AssociateId": 881,
    "UsePersonAddress": false,
    "ContactFax": "accusantium",
    "Kanafname": "velit",
    "Kanalname": "quas",
    "Post1": "sed",
    "Post2": "quasi",
    "Post3": "hic",
    "EmailName": "heloise@miller.biz",
    "ContactFullName": "Eden Cummings",
    "ActiveErpLinks": 534,
    "TicketPriorityId": 521,
    "SupportLanguageId": 339,
    "SupportAssociateId": 577,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 168
      }
    }
  },
  "Associate": {
    "AssociateId": 920,
    "Name": "Johnson-Lynch",
    "PersonId": 25,
    "Rank": 418,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 567,
    "FullName": "Tomasa Brakus",
    "FormalName": "Abbott, Johnston and Senger",
    "Deleted": false,
    "EjUserId": 230,
    "UserName": "Ryan, Jewess and Denesik",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 497
      }
    }
  },
  "Contact": {
    "ContactId": 228,
    "Name": "Stokes Group",
    "OrgNr": "278109",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dignissimos",
    "DirectPhone": "1-633-700-1230 x548",
    "AssociateId": 753,
    "CountryId": 89,
    "EmailAddress": "dasia.kuphal@kertzmann.ca",
    "Kananame": "culpa",
    "EmailAddressName": "granville@johnson.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Sincere Carter",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quo",
    "FullName": "Miss Frankie Bayer",
    "IsOwnerContact": false,
    "ActiveErpLinks": 85,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 160
      }
    }
  },
  "Project": {
    "ProjectId": 109,
    "Name": "Krajcik, Schulist and Goldner",
    "Description": "Profound background archive",
    "URL": "http://www.example.com/",
    "Type": "officiis",
    "AssociateId": 473,
    "AssociateFullName": "Lucie O'Keefe III",
    "TypeId": 832,
    "Updated": "2008-12-14T18:28:48.8449612+01:00",
    "StatusId": 628,
    "Status": "a",
    "TextId": 24,
    "PublishTo": "2004-07-29T18:28:48.8449612+02:00",
    "PublishFrom": "1997-03-09T18:28:48.8449612+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "884059",
    "ActiveErpLinks": 138,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 95
      }
    }
  },
  "Date": "2020-04-27T18:28:48.8449612+02:00",
  "ExternalRef": "enim",
  "Completed": "Completed",
  "ActiveLinks": 990,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Cummerata Inc and Sons",
      "Id": 444,
      "Description": "Self-enabling interactive extranet",
      "ExtraInfo": "dolorem",
      "LinkId": 67,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 612
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Rohan, Collins and Kozey",
    "SaleDate": "1998-11-08T18:28:48.8449612+01:00",
    "SaleId": 563,
    "Probability": 615,
    "Title": "sint",
    "Amount": 26284.858,
    "Currency": "ut",
    "ProjectName": "Jenkins, Heaney and Hilll",
    "AssociateFullName": "Haylee Torphy",
    "Description": "Intuitive high-level productivity",
    "Status": "Lost",
    "WeightedAmount": 6854.058,
    "ProjectId": 96,
    "EarningPercent": 18518.806,
    "Earning": 17280.876,
    "ContactId": 377,
    "AssociateId": 620,
    "PersonId": 429,
    "SaleTypeId": 640,
    "SaleTypeName": "Kautzer, Grant and Blick",
    "PersonFullName": "Mr. Raymond Corkery",
    "Completed": "Completed",
    "ActiveErpLinks": 457,
    "NextDueDate": "2006-02-01T18:28:48.8459567+01:00",
    "Number": "1187341",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 953
      }
    }
  },
  "SuggestedDocumentId": 483,
  "Snum": 699,
  "UserDefinedFields": {
    "SuperOffice:1": "479169774",
    "SuperOffice:2": "Clint Feeney"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "velit"
  },
  "PublishEventDate": "2006-07-01T18:28:48.8459567+02:00",
  "PublishTo": "2018-10-29T18:28:48.8459567+01:00",
  "PublishFrom": "2008-05-29T18:28:48.8459567+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 221,
      "Visibility": "All",
      "DisplayValue": "enim",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 202
        }
      }
    },
    {
      "VisibleId": 221,
      "Visibility": "All",
      "DisplayValue": "enim",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 202
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
      "FieldLength": 895
    }
  }
}
```