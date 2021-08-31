---
title: SaveDocumentEntity
id: v1DocumentAgent_SaveDocumentEntity
---

# SaveDocumentEntity

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 289,
  "UpdatedBy": {
    "AssociateId": 91,
    "Name": "Ruecker, Ankunding and Becker",
    "PersonId": 906,
    "Rank": 341,
    "Tooltip": "earum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 767,
    "FullName": "Marcos Turcotte",
    "FormalName": "Rohan-Rau",
    "Deleted": true,
    "EjUserId": 129,
    "UserName": "Barrows, Keebler and Wolf"
  },
  "CreatedBy": {
    "AssociateId": 271,
    "Name": "Kuhic, Boyer and Quitzon",
    "PersonId": 97,
    "Rank": 990,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 735,
    "FullName": "Selena Orn",
    "FormalName": "Bartell, Wilkinson and Yundt",
    "Deleted": false,
    "EjUserId": 345,
    "UserName": "Sawayn Group"
  },
  "Attention": "sint",
  "Header": "saepe",
  "Name": "Hansen, Ernser and Lakin",
  "OurRef": "expedita",
  "YourRef": "quos",
  "CreatedDate": "2019-05-17T14:58:03.9324608+02:00",
  "UpdatedDate": "2006-02-25T14:58:03.9324608+01:00",
  "Description": "Self-enabling modular structure",
  "DocumentTemplate": {
    "DocumentTemplateId": 953,
    "Name": "Metz Inc and Sons",
    "Tooltip": "non",
    "SaveInDb": 473,
    "Filename": "repellat",
    "DefaultOref": "ipsum",
    "RecordType": "Appointment",
    "Deleted": 479,
    "Direction": "Incoming",
    "AutoeventId": 724,
    "QuoteDocType": "ConfirmationLines"
  },
  "Person": {
    "Position": "totam",
    "PersonId": 579,
    "Mrmrs": "sed",
    "Firstname": "Aliyah",
    "Lastname": "Stamm",
    "MiddleName": "Anderson, Kozey and Haley",
    "Title": "quia",
    "Description": "Proactive high-level capability",
    "Email": "margarita@warddibbert.name",
    "FullName": "Ms. Cristobal Schowalter",
    "DirectPhone": "105.758.0102 x56845",
    "FormalName": "Koch LLC",
    "CountryId": 310,
    "ContactId": 910,
    "ContactName": "O'Keefe-Bailey",
    "Retired": 573,
    "Rank": 806,
    "ActiveInterests": 698,
    "ContactDepartment": "",
    "ContactCountryId": 301,
    "ContactOrgNr": "418599",
    "FaxPhone": "730.583.6611 x43868",
    "MobilePhone": "(448)588-8540 x087",
    "ContactPhone": "606.272.7765",
    "AssociateName": "Stroman, Conn and Robel",
    "AssociateId": 842,
    "UsePersonAddress": true,
    "ContactFax": "qui",
    "Kanafname": "numquam",
    "Kanalname": "voluptas",
    "Post1": "voluptas",
    "Post2": "et",
    "Post3": "dolores",
    "EmailName": "sarah@raynorswaniawski.name",
    "ContactFullName": "Hoyt O'Keefe",
    "ActiveErpLinks": 673,
    "TicketPriorityId": 956,
    "SupportLanguageId": 716,
    "SupportAssociateId": 660,
    "CategoryName": "VIP Customer"
  },
  "Associate": {
    "AssociateId": 614,
    "Name": "Harvey, Steuber and Brekke",
    "PersonId": 769,
    "Rank": 162,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 191,
    "FullName": "Mafalda Steuber DVM",
    "FormalName": "West, Feeney and Trantow",
    "Deleted": false,
    "EjUserId": 327,
    "UserName": "Torphy, Cummerata and Beahan"
  },
  "Contact": {
    "ContactId": 997,
    "Name": "Goyette LLC",
    "OrgNr": "1070834",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "iste",
    "DirectPhone": "1-868-812-6782 x4114",
    "AssociateId": 464,
    "CountryId": 711,
    "EmailAddress": "angelita@harris.com",
    "Kananame": "fugit",
    "EmailAddressName": "shad.nader@handblock.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Velda Dooley Jr.",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "possimus",
    "FullName": "Kole Weimann",
    "IsOwnerContact": false,
    "ActiveErpLinks": 937
  },
  "Project": {
    "ProjectId": 500,
    "Name": "Bayer, Runolfsson and Weissnat",
    "Description": "Up-sized zero tolerance projection",
    "URL": "http://www.example.com/",
    "Type": "modi",
    "AssociateId": 876,
    "AssociateFullName": "Miss Bell Schaefer",
    "TypeId": 533,
    "Updated": "2009-04-09T14:58:03.9354631+02:00",
    "StatusId": 401,
    "Status": "deleniti",
    "TextId": 907,
    "PublishTo": "2008-10-14T14:58:03.9354631+02:00",
    "PublishFrom": "2018-08-25T14:58:03.9354631+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "826543",
    "ActiveErpLinks": 677
  },
  "Date": "2018-09-21T14:58:03.9354631+02:00",
  "ExternalRef": "laudantium",
  "Completed": "Completed",
  "ActiveLinks": 916,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Haag Inc and Sons",
      "Id": 561,
      "Description": "Cross-group foreground paradigm",
      "ExtraInfo": "occaecati",
      "LinkId": 912
    },
    {
      "EntityName": "Haag Inc and Sons",
      "Id": 561,
      "Description": "Cross-group foreground paradigm",
      "ExtraInfo": "occaecati",
      "LinkId": 912
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Steuber LLC",
    "SaleDate": "1996-03-20T14:58:03.9354631+01:00",
    "SaleId": 546,
    "Probability": 226,
    "Title": "dolor",
    "Amount": 23799.595999999998,
    "Currency": "doloremque",
    "ProjectName": "Pacocha Inc and Sons",
    "AssociateFullName": "Mariela Franecki PhD",
    "Description": "Networked next generation implementation",
    "Status": "Lost",
    "WeightedAmount": 4390.7339999999995,
    "ProjectId": 368,
    "EarningPercent": 24959.176,
    "Earning": 14316.112,
    "ContactId": 974,
    "AssociateId": 342,
    "PersonId": 997,
    "SaleTypeId": 471,
    "SaleTypeName": "Hoppe LLC",
    "PersonFullName": "Natalia Quigley MD",
    "Completed": "Completed",
    "ActiveErpLinks": 565,
    "NextDueDate": "2019-06-15T14:58:03.9364605+02:00",
    "Number": "1029895"
  },
  "SuggestedDocumentId": 157,
  "Snum": 507,
  "UserDefinedFields": {
    "SuperOffice:1": "Johanna Vandervort",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "nostrum"
  },
  "CustomFields": {
    "CustomFields1": "incidunt",
    "CustomFields2": "dicta"
  },
  "PublishEventDate": "2014-09-30T14:58:03.9364605+02:00",
  "PublishTo": "2003-05-28T14:58:03.9364605+02:00",
  "PublishFrom": "2016-08-22T14:58:03.9364605+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 453,
      "Visibility": "All",
      "DisplayValue": "odio"
    },
    {
      "VisibleId": 453,
      "Visibility": "All",
      "DisplayValue": "odio"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 98,
  "UpdatedBy": {
    "AssociateId": 531,
    "Name": "Becker, Daniel and Cassin",
    "PersonId": 784,
    "Rank": 735,
    "Tooltip": "laudantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 470,
    "FullName": "Patrick Johnson",
    "FormalName": "Haley Group",
    "Deleted": false,
    "EjUserId": 512,
    "UserName": "Stokes Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 863
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 654,
    "Name": "Cormier, O'Keefe and McDermott",
    "PersonId": 729,
    "Rank": 652,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 294,
    "FullName": "Fay Johnson",
    "FormalName": "Torp-Grant",
    "Deleted": true,
    "EjUserId": 501,
    "UserName": "Grimes Inc and Sons",
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
  "Attention": "laboriosam",
  "Header": "et",
  "Name": "Rau, DuBuque and Gislason",
  "OurRef": "quibusdam",
  "YourRef": "consequatur",
  "CreatedDate": "2020-07-17T14:58:03.9414597+02:00",
  "UpdatedDate": "2001-05-19T14:58:03.9414597+02:00",
  "Description": "Upgradable composite firmware",
  "DocumentTemplate": {
    "DocumentTemplateId": 513,
    "Name": "Smitham LLC",
    "Tooltip": "qui",
    "SaveInDb": 976,
    "Filename": "et",
    "DefaultOref": "porro",
    "RecordType": "Appointment",
    "Deleted": 368,
    "Direction": "Incoming",
    "AutoeventId": 678,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 344
      }
    }
  },
  "Person": {
    "Position": "dolorum",
    "PersonId": 577,
    "Mrmrs": "dicta",
    "Firstname": "Eladio",
    "Lastname": "Predovic",
    "MiddleName": "Kreiger Inc and Sons",
    "Title": "voluptatem",
    "Description": "Cloned well-modulated functionalities",
    "Email": "albina@olson.info",
    "FullName": "Shanelle Kuhlman",
    "DirectPhone": "(660)056-5768 x4127",
    "FormalName": "Schaden Inc and Sons",
    "CountryId": 208,
    "ContactId": 80,
    "ContactName": "Kreiger-Hyatt",
    "Retired": 647,
    "Rank": 229,
    "ActiveInterests": 768,
    "ContactDepartment": "",
    "ContactCountryId": 316,
    "ContactOrgNr": "870491",
    "FaxPhone": "161-348-1468 x61240",
    "MobilePhone": "473-442-7013 x17284",
    "ContactPhone": "776-607-2157 x40621",
    "AssociateName": "Fahey Group",
    "AssociateId": 123,
    "UsePersonAddress": true,
    "ContactFax": "id",
    "Kanafname": "sapiente",
    "Kanalname": "ipsa",
    "Post1": "neque",
    "Post2": "autem",
    "Post3": "placeat",
    "EmailName": "rylan.hoppe@franecki.ca",
    "ContactFullName": "Ryan Prosacco MD",
    "ActiveErpLinks": 720,
    "TicketPriorityId": 392,
    "SupportLanguageId": 961,
    "SupportAssociateId": 224,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 826
      }
    }
  },
  "Associate": {
    "AssociateId": 1001,
    "Name": "Deckow-Lebsack",
    "PersonId": 742,
    "Rank": 862,
    "Tooltip": "porro",
    "Type": "AnonymousAssociate",
    "GroupIdx": 380,
    "FullName": "Korbin Rowe IV",
    "FormalName": "Simonis, Rosenbaum and Heller",
    "Deleted": false,
    "EjUserId": 218,
    "UserName": "Stehr-Dickens",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 176
      }
    }
  },
  "Contact": {
    "ContactId": 652,
    "Name": "Weissnat Group",
    "OrgNr": "1731775",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quam",
    "DirectPhone": "703-684-7518",
    "AssociateId": 181,
    "CountryId": 549,
    "EmailAddress": "jamaal@mcdermottblock.us",
    "Kananame": "magnam",
    "EmailAddressName": "shanny@pfannerstillhomenick.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Kaitlin Kassulke MD",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "asperiores",
    "FullName": "Kristina Tremblay",
    "IsOwnerContact": true,
    "ActiveErpLinks": 594,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 366
      }
    }
  },
  "Project": {
    "ProjectId": 130,
    "Name": "Greenfelder-Ziemann",
    "Description": "Configurable analyzing info-mediaries",
    "URL": "http://www.example.com/",
    "Type": "tempora",
    "AssociateId": 841,
    "AssociateFullName": "Grant Cummings",
    "TypeId": 814,
    "Updated": "1994-11-08T14:58:03.9444645+01:00",
    "StatusId": 563,
    "Status": "voluptatem",
    "TextId": 426,
    "PublishTo": "2012-09-13T14:58:03.9444645+02:00",
    "PublishFrom": "2013-10-06T14:58:03.9444645+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "584095",
    "ActiveErpLinks": 186,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 324
      }
    }
  },
  "Date": "1994-06-17T14:58:03.9444645+02:00",
  "ExternalRef": "qui",
  "Completed": "Completed",
  "ActiveLinks": 889,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Douglas-Pollich",
      "Id": 282,
      "Description": "Mandatory needs-based extranet",
      "ExtraInfo": "qui",
      "LinkId": 266,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 919
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Dietrich, Brekke and Barton",
    "SaleDate": "2019-08-09T14:58:03.9454316+02:00",
    "SaleId": 939,
    "Probability": 54,
    "Title": "consequatur",
    "Amount": 30763.343999999997,
    "Currency": "voluptates",
    "ProjectName": "Feeney, Goldner and Rohan",
    "AssociateFullName": "Dusty Kuvalis",
    "Description": "Polarised executive access",
    "Status": "Lost",
    "WeightedAmount": 30951.384,
    "ProjectId": 642,
    "EarningPercent": 30534.561999999998,
    "Earning": 31020.332,
    "ContactId": 646,
    "AssociateId": 856,
    "PersonId": 589,
    "SaleTypeId": 865,
    "SaleTypeName": "O'Conner, McDermott and Brakus",
    "PersonFullName": "Merlin Rohan",
    "Completed": "Completed",
    "ActiveErpLinks": 371,
    "NextDueDate": "2013-02-06T14:58:03.9454316+01:00",
    "Number": "907571",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 416
      }
    }
  },
  "SuggestedDocumentId": 970,
  "Snum": 549,
  "UserDefinedFields": {
    "SuperOffice:1": "2111238511",
    "SuperOffice:2": "Garry Thompson"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "voluptate",
    "CustomFields2": "modi"
  },
  "PublishEventDate": "2018-06-08T14:58:03.9454316+02:00",
  "PublishTo": "2001-02-17T14:58:03.9454316+01:00",
  "PublishFrom": "2014-08-01T14:58:03.9454316+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 131,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "envisioneer frictionless infrastructures"
          },
          "FieldType": "System.String",
          "FieldLength": 80
        }
      }
    },
    {
      "VisibleId": 131,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "envisioneer frictionless infrastructures"
          },
          "FieldType": "System.String",
          "FieldLength": 80
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
        "Reason": "harness seamless metrics"
      },
      "FieldType": "System.String",
      "FieldLength": 349
    }
  }
}
```