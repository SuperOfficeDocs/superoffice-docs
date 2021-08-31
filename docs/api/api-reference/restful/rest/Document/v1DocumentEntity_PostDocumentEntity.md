---
title: POST Document
id: v1DocumentEntity_PostDocumentEntity
---

# POST Document

```http
POST /api/v1/Document
```

Creates a new DocumentEntity Save the document entity.

If the entity already exists and the file name of the incoming entity is different from the existing one, a corresponding renaming of the physical document will be attempted. This may cause an amended file name to be substituted into the document entity, since a document plugin may have aribitrary rules on file names and collisions. Clients should always inspect the return value from this call and not assume that what they sent for saving is the final truth. Calls the Document agent service SaveDocumentEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Document?$select=name,department,category/id
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

## Request Body: newEntity  

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
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/Document
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 432,
  "UpdatedBy": {
    "AssociateId": 375,
    "Name": "Treutel LLC",
    "PersonId": 82,
    "Rank": 412,
    "Tooltip": "unde",
    "Type": "AnonymousAssociate",
    "GroupIdx": 570,
    "FullName": "Olin Adams",
    "FormalName": "Mayert-Auer",
    "Deleted": false,
    "EjUserId": 408,
    "UserName": "Reynolds, Metz and Borer"
  },
  "CreatedBy": {
    "AssociateId": 928,
    "Name": "Witting, Schroeder and Lebsack",
    "PersonId": 717,
    "Rank": 382,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 204,
    "FullName": "Madisen Hessel",
    "FormalName": "Goodwin-Pacocha",
    "Deleted": true,
    "EjUserId": 188,
    "UserName": "Orn LLC"
  },
  "Attention": "ipsa",
  "Header": "est",
  "Name": "Schowalter-Lindgren",
  "OurRef": "qui",
  "YourRef": "fugiat",
  "CreatedDate": "2013-11-29T15:05:42.0470042+01:00",
  "UpdatedDate": "2014-11-07T15:05:42.0470042+01:00",
  "Description": "Triple-buffered intangible data-warehouse",
  "DocumentTemplate": {
    "DocumentTemplateId": 888,
    "Name": "Cummings-Cremin",
    "Tooltip": "ut",
    "SaveInDb": 572,
    "Filename": "optio",
    "DefaultOref": "in",
    "RecordType": "Appointment",
    "Deleted": 735,
    "Direction": "Incoming",
    "AutoeventId": 549,
    "QuoteDocType": "ConfirmationLines"
  },
  "Person": {
    "Position": "praesentium",
    "PersonId": 961,
    "Mrmrs": "eligendi",
    "Firstname": "Ted",
    "Lastname": "Gerhold",
    "MiddleName": "Ernser-Conroy",
    "Title": "eum",
    "Description": "Multi-layered explicit array",
    "Email": "nathan.mertz@botsford.com",
    "FullName": "Helene Vandervort",
    "DirectPhone": "385-074-7785",
    "FormalName": "Witting-Corwin",
    "CountryId": 599,
    "ContactId": 930,
    "ContactName": "Padberg, Ritchie and Emard",
    "Retired": 326,
    "Rank": 109,
    "ActiveInterests": 688,
    "ContactDepartment": "",
    "ContactCountryId": 331,
    "ContactOrgNr": "1561697",
    "FaxPhone": "807-420-0124",
    "MobilePhone": "084-261-7554",
    "ContactPhone": "446.151.6021 x028",
    "AssociateName": "Carroll, Conroy and Gutkowski",
    "AssociateId": 966,
    "UsePersonAddress": true,
    "ContactFax": "quidem",
    "Kanafname": "praesentium",
    "Kanalname": "ut",
    "Post1": "repellendus",
    "Post2": "est",
    "Post3": "dolorem",
    "EmailName": "nasir@kub.biz",
    "ContactFullName": "Ms. Sienna Kerluke",
    "ActiveErpLinks": 234,
    "TicketPriorityId": 156,
    "SupportLanguageId": 1000,
    "SupportAssociateId": 953,
    "CategoryName": "VIP Customer"
  },
  "Associate": {
    "AssociateId": 724,
    "Name": "Macejkovic-O'Hara",
    "PersonId": 2,
    "Rank": 528,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 954,
    "FullName": "Zechariah Abbott DVM",
    "FormalName": "Hegmann, Schoen and Harvey",
    "Deleted": false,
    "EjUserId": 52,
    "UserName": "Langworth, Nienow and Goldner"
  },
  "Contact": {
    "ContactId": 746,
    "Name": "Feest-Lindgren",
    "OrgNr": "1237300",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "praesentium",
    "DirectPhone": "421.268.4563 x3360",
    "AssociateId": 651,
    "CountryId": 544,
    "EmailAddress": "sophia.white@durgan.us",
    "Kananame": "culpa",
    "EmailAddressName": "beulah@bergnaum.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Daisha Klein",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "consequuntur",
    "FullName": "Leopoldo Steuber",
    "IsOwnerContact": false,
    "ActiveErpLinks": 268
  },
  "Project": {
    "ProjectId": 835,
    "Name": "Waelchi LLC",
    "Description": "Quality-focused bi-directional success",
    "URL": "http://www.example.com/",
    "Type": "consequatur",
    "AssociateId": 508,
    "AssociateFullName": "Jonas Robel",
    "TypeId": 307,
    "Updated": "2012-04-05T15:05:42.0510044+02:00",
    "StatusId": 934,
    "Status": "qui",
    "TextId": 683,
    "PublishTo": "2010-12-21T15:05:42.0510044+01:00",
    "PublishFrom": "2011-01-14T15:05:42.0510044+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1285765",
    "ActiveErpLinks": 844
  },
  "Date": "2007-11-16T15:05:42.0510044+01:00",
  "ExternalRef": "eos",
  "Completed": "Completed",
  "ActiveLinks": 88,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Jakubowski-Rutherford",
      "Id": 375,
      "Description": "Profit-focused explicit intranet",
      "ExtraInfo": "nesciunt",
      "LinkId": 224
    },
    {
      "EntityName": "Jakubowski-Rutherford",
      "Id": 375,
      "Description": "Profit-focused explicit intranet",
      "ExtraInfo": "nesciunt",
      "LinkId": 224
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Baumbach, Wilkinson and Aufderhar",
    "SaleDate": "2008-07-31T15:05:42.0510044+02:00",
    "SaleId": 151,
    "Probability": 171,
    "Title": "consectetur",
    "Amount": 14714.13,
    "Currency": "sequi",
    "ProjectName": "Eichmann, Klocko and Kirlin",
    "AssociateFullName": "Claudine Kuhlman",
    "Description": "Reverse-engineered directional emulation",
    "Status": "Lost",
    "WeightedAmount": 14391.328,
    "ProjectId": 109,
    "EarningPercent": 30349.656,
    "Earning": 29202.611999999997,
    "ContactId": 703,
    "AssociateId": 567,
    "PersonId": 815,
    "SaleTypeId": 259,
    "SaleTypeName": "Cummings-Shields",
    "PersonFullName": "Olin Langworth",
    "Completed": "Completed",
    "ActiveErpLinks": 27,
    "NextDueDate": "2008-02-18T15:05:42.0510044+01:00",
    "Number": "1189787"
  },
  "SuggestedDocumentId": 897,
  "Snum": 816,
  "UserDefinedFields": {
    "SuperOffice:1": "Carmen Denesik",
    "SuperOffice:2": "Manuel Koepp"
  },
  "ExtraFields": {
    "ExtraFields1": "quam",
    "ExtraFields2": "dolores"
  },
  "CustomFields": {
    "CustomFields1": "molestias",
    "CustomFields2": "totam"
  },
  "PublishEventDate": "2004-06-11T15:05:42.0520039+02:00",
  "PublishTo": "2011-04-29T15:05:42.0520039+02:00",
  "PublishFrom": "2015-11-11T15:05:42.0520039+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 986,
      "Visibility": "All",
      "DisplayValue": "nobis"
    },
    {
      "VisibleId": 986,
      "Visibility": "All",
      "DisplayValue": "nobis"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 909,
  "UpdatedBy": {
    "AssociateId": 417,
    "Name": "O'Connell LLC",
    "PersonId": 165,
    "Rank": 126,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 858,
    "FullName": "Ms. Mariano Mayer",
    "FormalName": "Schmeler Group",
    "Deleted": true,
    "EjUserId": 647,
    "UserName": "Ward LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 424
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 719,
    "Name": "Flatley LLC",
    "PersonId": 53,
    "Rank": 359,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 629,
    "FullName": "Duncan Cummings",
    "FormalName": "Ruecker, Eichmann and Ullrich",
    "Deleted": false,
    "EjUserId": 535,
    "UserName": "Bins-Prohaska",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 732
      }
    }
  },
  "Attention": "voluptates",
  "Header": "debitis",
  "Name": "Ernser Inc and Sons",
  "OurRef": "voluptate",
  "YourRef": "sed",
  "CreatedDate": "2005-05-16T15:05:42.0570042+02:00",
  "UpdatedDate": "1999-08-10T15:05:42.0570042+02:00",
  "Description": "Re-engineered demand-driven knowledge user",
  "DocumentTemplate": {
    "DocumentTemplateId": 776,
    "Name": "Bernhard, Price and VonRueden",
    "Tooltip": "atque",
    "SaveInDb": 715,
    "Filename": "quae",
    "DefaultOref": "pariatur",
    "RecordType": "Appointment",
    "Deleted": 18,
    "Direction": "Incoming",
    "AutoeventId": 189,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 145
      }
    }
  },
  "Person": {
    "Position": "nemo",
    "PersonId": 510,
    "Mrmrs": "molestiae",
    "Firstname": "Keven",
    "Lastname": "Huel",
    "MiddleName": "Hagenes, Auer and Schmitt",
    "Title": "sint",
    "Description": "Up-sized systemic website",
    "Email": "ramona_jones@franecki.us",
    "FullName": "Giovani Howell PhD",
    "DirectPhone": "1-747-837-3534",
    "FormalName": "Borer Inc and Sons",
    "CountryId": 321,
    "ContactId": 29,
    "ContactName": "Ledner Group",
    "Retired": 92,
    "Rank": 609,
    "ActiveInterests": 200,
    "ContactDepartment": "",
    "ContactCountryId": 511,
    "ContactOrgNr": "963785",
    "FaxPhone": "(601)001-4234 x83004",
    "MobilePhone": "426-328-2255 x221",
    "ContactPhone": "860.412.3348",
    "AssociateName": "Purdy-Toy",
    "AssociateId": 495,
    "UsePersonAddress": true,
    "ContactFax": "qui",
    "Kanafname": "odit",
    "Kanalname": "nesciunt",
    "Post1": "quis",
    "Post2": "est",
    "Post3": "repellendus",
    "EmailName": "hosea.thompson@davis.ca",
    "ContactFullName": "Elmira Marks PhD",
    "ActiveErpLinks": 174,
    "TicketPriorityId": 49,
    "SupportLanguageId": 198,
    "SupportAssociateId": 863,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 38
      }
    }
  },
  "Associate": {
    "AssociateId": 755,
    "Name": "Kulas Group",
    "PersonId": 284,
    "Rank": 188,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 397,
    "FullName": "Shanon Keeling",
    "FormalName": "Kessler-Walsh",
    "Deleted": false,
    "EjUserId": 40,
    "UserName": "Ledner-Murray",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 161
      }
    }
  },
  "Contact": {
    "ContactId": 123,
    "Name": "Reichert, Windler and Harber",
    "OrgNr": "1402961",
    "Department": "repurpose vertical networks",
    "URL": "http://www.example.com/",
    "City": "et",
    "DirectPhone": "072.677.6455 x276",
    "AssociateId": 341,
    "CountryId": 997,
    "EmailAddress": "rebeca@nolan.com",
    "Kananame": "expedita",
    "EmailAddressName": "jabari@price.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Wilton Hand",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "eum",
    "FullName": "General Crooks",
    "IsOwnerContact": true,
    "ActiveErpLinks": 60,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 118
      }
    }
  },
  "Project": {
    "ProjectId": 693,
    "Name": "Spinka-Kozey",
    "Description": "Customer-focused disintermediate conglomeration",
    "URL": "http://www.example.com/",
    "Type": "exercitationem",
    "AssociateId": 989,
    "AssociateFullName": "Nolan Conroy",
    "TypeId": 210,
    "Updated": "2012-11-14T15:05:42.0600043+01:00",
    "StatusId": 986,
    "Status": "recusandae",
    "TextId": 740,
    "PublishTo": "2018-05-03T15:05:42.0600043+02:00",
    "PublishFrom": "1994-04-17T15:05:42.0600043+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "866280",
    "ActiveErpLinks": 956,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 1001
      }
    }
  },
  "Date": "2005-08-06T15:05:42.0600043+02:00",
  "ExternalRef": "quas",
  "Completed": "Completed",
  "ActiveLinks": 543,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Wintheiser Inc and Sons",
      "Id": 623,
      "Description": "Inverse discrete system engine",
      "ExtraInfo": "suscipit",
      "LinkId": 4,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 842
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Lesch, Waelchi and Deckow",
    "SaleDate": "2018-06-27T15:05:42.0600043+02:00",
    "SaleId": 405,
    "Probability": 888,
    "Title": "occaecati",
    "Amount": 27099.698,
    "Currency": "natus",
    "ProjectName": "Quigley, Schiller and Weber",
    "AssociateFullName": "Lawson Stiedemann",
    "Description": "Fully-configurable 24/7 strategy",
    "Status": "Lost",
    "WeightedAmount": 9969.253999999999,
    "ProjectId": 829,
    "EarningPercent": 2262.748,
    "Earning": 18760.124,
    "ContactId": 226,
    "AssociateId": 305,
    "PersonId": 334,
    "SaleTypeId": 683,
    "SaleTypeName": "Schumm, Shields and Mosciski",
    "PersonFullName": "Kristin Runolfsdottir",
    "Completed": "Completed",
    "ActiveErpLinks": 950,
    "NextDueDate": "2018-05-27T15:05:42.061004+02:00",
    "Number": "1132343",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "scale end-to-end methodologies"
        },
        "FieldType": "System.String",
        "FieldLength": 68
      }
    }
  },
  "SuggestedDocumentId": 809,
  "Snum": 987,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Finn Baumbach"
  },
  "ExtraFields": {
    "ExtraFields1": "distinctio",
    "ExtraFields2": "amet"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "at"
  },
  "PublishEventDate": "2019-03-26T15:05:42.061004+01:00",
  "PublishTo": "2018-01-25T15:05:42.061004+01:00",
  "PublishFrom": "2011-12-25T15:05:42.061004+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 176,
      "Visibility": "All",
      "DisplayValue": "deserunt",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    },
    {
      "VisibleId": 176,
      "Visibility": "All",
      "DisplayValue": "deserunt",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 94
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
      "FieldLength": 698
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```