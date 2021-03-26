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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 562,
  "UpdatedBy": {
    "AssociateId": 766,
    "Name": "Grant-Kris",
    "PersonId": 452,
    "Rank": 199,
    "Tooltip": "eius",
    "Type": "AnonymousAssociate",
    "GroupIdx": 888,
    "FullName": "Max Ratke",
    "FormalName": "Spinka-Sauer",
    "Deleted": true,
    "EjUserId": 953,
    "UserName": "Reichert, Sauer and Hirthe"
  },
  "CreatedBy": {
    "AssociateId": 481,
    "Name": "Will-Wisoky",
    "PersonId": 496,
    "Rank": 255,
    "Tooltip": "eum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 382,
    "FullName": "Sherman Emmerich",
    "FormalName": "Kertzmann-Ondricka",
    "Deleted": true,
    "EjUserId": 470,
    "UserName": "Treutel Inc and Sons"
  },
  "Attention": "est",
  "Header": "ducimus",
  "Name": "Morissette, Stehr and Moen",
  "OurRef": "omnis",
  "YourRef": "dolor",
  "CreatedDate": "2010-08-19T09:40:59.1028549+02:00",
  "UpdatedDate": "2017-02-15T09:40:59.1028549+01:00",
  "Description": "Profound intangible infrastructure",
  "DocumentTemplate": {
    "DocumentTemplateId": 705,
    "Name": "Greenfelder, White and Stroman",
    "Tooltip": "minus",
    "SaveInDb": 828,
    "Filename": "magnam",
    "DefaultOref": "esse",
    "RecordType": "Appointment",
    "Deleted": 410,
    "Direction": "Incoming",
    "AutoeventId": 884,
    "QuoteDocType": "ConfirmationLines"
  },
  "Person": {
    "Position": "repudiandae",
    "PersonId": 229,
    "Mrmrs": "facilis",
    "Firstname": "Lou",
    "Lastname": "Bernier",
    "MiddleName": "Kohler LLC",
    "Title": "odit",
    "Description": "Streamlined grid-enabled project",
    "Email": "abraham@dach.biz",
    "FullName": "Zella Mraz",
    "DirectPhone": "341-036-8226 x280",
    "FormalName": "Erdman Group",
    "CountryId": 401,
    "ContactId": 320,
    "ContactName": "Reichel LLC",
    "Retired": 807,
    "Rank": 552,
    "ActiveInterests": 278,
    "ContactDepartment": "",
    "ContactCountryId": 644,
    "ContactOrgNr": "698664",
    "FaxPhone": "(112)822-5032 x71510",
    "MobilePhone": "067-352-4787 x58856",
    "ContactPhone": "1-530-500-7056",
    "AssociateName": "Bechtelar Inc and Sons",
    "AssociateId": 511,
    "UsePersonAddress": true,
    "ContactFax": "dolores",
    "Kanafname": "velit",
    "Kanalname": "sunt",
    "Post1": "nostrum",
    "Post2": "expedita",
    "Post3": "repellat",
    "EmailName": "melisa@buckridgerodriguez.ca",
    "ContactFullName": "Laisha Dickinson",
    "ActiveErpLinks": 79,
    "TicketPriorityId": 444,
    "SupportLanguageId": 772,
    "SupportAssociateId": 979,
    "CategoryName": "VIP Customer"
  },
  "Associate": {
    "AssociateId": 891,
    "Name": "Reichert, Stroman and Gutmann",
    "PersonId": 417,
    "Rank": 570,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 467,
    "FullName": "Daisha Ryan",
    "FormalName": "Rempel, Brakus and Gleason",
    "Deleted": false,
    "EjUserId": 703,
    "UserName": "Hoeger LLC"
  },
  "Contact": {
    "ContactId": 69,
    "Name": "Goodwin-Kulas",
    "OrgNr": "1729805",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "illo",
    "DirectPhone": "(307)134-2755 x6154",
    "AssociateId": 783,
    "CountryId": 715,
    "EmailAddress": "athena_kuhlman@vandervort.uk",
    "Kananame": "nostrum",
    "EmailAddressName": "thalia@koss.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ottilie Renner",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "natus",
    "FullName": "Mustafa Quitzon",
    "IsOwnerContact": false,
    "ActiveErpLinks": 462
  },
  "Project": {
    "ProjectId": 721,
    "Name": "Wehner-Weissnat",
    "Description": "Reduced non-volatile artificial intelligence",
    "URL": "http://www.example.com/",
    "Type": "quod",
    "AssociateId": 738,
    "AssociateFullName": "Lavina Lebsack",
    "TypeId": 537,
    "Updated": "2012-04-07T09:40:59.1048549+02:00",
    "StatusId": 517,
    "Status": "et",
    "TextId": 323,
    "PublishTo": "2020-03-08T09:40:59.1058547+01:00",
    "PublishFrom": "2017-08-01T09:40:59.1058547+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1103052",
    "ActiveErpLinks": 830
  },
  "Date": "2000-11-26T09:40:59.1058547+01:00",
  "ExternalRef": "quisquam",
  "Completed": "Completed",
  "ActiveLinks": 410,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Cummerata, King and Schamberger",
      "Id": 879,
      "Description": "Realigned even-keeled emulation",
      "ExtraInfo": "distinctio",
      "LinkId": 414
    },
    {
      "EntityName": "Cummerata, King and Schamberger",
      "Id": 879,
      "Description": "Realigned even-keeled emulation",
      "ExtraInfo": "distinctio",
      "LinkId": 414
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Sporer-Ebert",
    "SaleDate": "2014-02-19T09:40:59.1058547+01:00",
    "SaleId": 197,
    "Probability": 668,
    "Title": "omnis",
    "Amount": 7327.2919999999995,
    "Currency": "et",
    "ProjectName": "Abshire Inc and Sons",
    "AssociateFullName": "Bertram Adams MD",
    "Description": "Implemented radical flexibility",
    "Status": "Lost",
    "WeightedAmount": 24614.435999999998,
    "ProjectId": 435,
    "EarningPercent": 2331.696,
    "Earning": 23354.568,
    "ContactId": 451,
    "AssociateId": 801,
    "PersonId": 784,
    "SaleTypeId": 222,
    "SaleTypeName": "Hirthe Group",
    "PersonFullName": "Moriah Swift",
    "Completed": "Completed",
    "ActiveErpLinks": 485,
    "NextDueDate": "1997-10-23T09:40:59.1058547+02:00",
    "Number": "306617"
  },
  "SuggestedDocumentId": 859,
  "Snum": 843,
  "UserDefinedFields": {
    "SuperOffice:1": "640902886",
    "SuperOffice:2": "Jessika Feest"
  },
  "ExtraFields": {
    "ExtraFields1": "perspiciatis",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "asperiores",
    "CustomFields2": "omnis"
  },
  "PublishEventDate": "2016-03-04T09:40:59.1058547+01:00",
  "PublishTo": "2008-11-26T09:40:59.1058547+01:00",
  "PublishFrom": "2015-04-18T09:40:59.1058547+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 769,
      "Visibility": "All",
      "DisplayValue": "quos"
    },
    {
      "VisibleId": 769,
      "Visibility": "All",
      "DisplayValue": "quos"
    }
  ]
}
```

```http_
HTTP/1.1 200 DocumentEntity updated.
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 822,
  "UpdatedBy": {
    "AssociateId": 885,
    "Name": "Block Inc and Sons",
    "PersonId": 455,
    "Rank": 772,
    "Tooltip": "ipsum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 513,
    "FullName": "Manuel Kemmer",
    "FormalName": "Smith Inc and Sons",
    "Deleted": false,
    "EjUserId": 559,
    "UserName": "Ledner, DuBuque and Lakin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 393
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 742,
    "Name": "Bradtke, Stoltenberg and Kessler",
    "PersonId": 221,
    "Rank": 801,
    "Tooltip": "odit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 136,
    "FullName": "Carole Hirthe",
    "FormalName": "Spencer, Balistreri and Harber",
    "Deleted": true,
    "EjUserId": 651,
    "UserName": "Simonis-Anderson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 98
      }
    }
  },
  "Attention": "laborum",
  "Header": "molestiae",
  "Name": "VonRueden-Berge",
  "OurRef": "autem",
  "YourRef": "enim",
  "CreatedDate": "2019-04-25T09:40:59.1128545+02:00",
  "UpdatedDate": "2001-05-09T09:40:59.1128545+02:00",
  "Description": "Synergistic demand-driven toolset",
  "DocumentTemplate": {
    "DocumentTemplateId": 297,
    "Name": "Yundt, Hyatt and Mosciski",
    "Tooltip": "consequatur",
    "SaveInDb": 484,
    "Filename": "eius",
    "DefaultOref": "omnis",
    "RecordType": "Appointment",
    "Deleted": 825,
    "Direction": "Incoming",
    "AutoeventId": 285,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 734
      }
    }
  },
  "Person": {
    "Position": "molestias",
    "PersonId": 978,
    "Mrmrs": "ut",
    "Firstname": "Tianna",
    "Lastname": "Russel",
    "MiddleName": "Gerhold, Labadie and Sawayn",
    "Title": "accusamus",
    "Description": "Realigned reciprocal matrices",
    "Email": "jasmin@franeckitoy.name",
    "FullName": "Eladio Gutkowski",
    "DirectPhone": "1-850-353-6263",
    "FormalName": "Gulgowski Inc and Sons",
    "CountryId": 881,
    "ContactId": 596,
    "ContactName": "Osinski, Rath and Spinka",
    "Retired": 395,
    "Rank": 44,
    "ActiveInterests": 110,
    "ContactDepartment": "",
    "ContactCountryId": 696,
    "ContactOrgNr": "885997",
    "FaxPhone": "275.067.2816 x78355",
    "MobilePhone": "350-155-1264",
    "ContactPhone": "1-078-318-3330 x22408",
    "AssociateName": "Bogan-Spencer",
    "AssociateId": 811,
    "UsePersonAddress": true,
    "ContactFax": "ea",
    "Kanafname": "magnam",
    "Kanalname": "eos",
    "Post1": "quia",
    "Post2": "porro",
    "Post3": "velit",
    "EmailName": "sid@borer.us",
    "ContactFullName": "Tyreek Wisoky",
    "ActiveErpLinks": 251,
    "TicketPriorityId": 252,
    "SupportLanguageId": 974,
    "SupportAssociateId": 120,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 713
      }
    }
  },
  "Associate": {
    "AssociateId": 192,
    "Name": "Kris Group",
    "PersonId": 1000,
    "Rank": 170,
    "Tooltip": "temporibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 219,
    "FullName": "Ms. Barry Rolfson",
    "FormalName": "Runolfsdottir, Stroman and Bosco",
    "Deleted": false,
    "EjUserId": 900,
    "UserName": "Hamill, Rice and Dietrich",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 154
      }
    }
  },
  "Contact": {
    "ContactId": 103,
    "Name": "Stroman LLC",
    "OrgNr": "899416",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "illum",
    "DirectPhone": "1-264-231-5374 x512",
    "AssociateId": 159,
    "CountryId": 992,
    "EmailAddress": "selina@gutkowski.ca",
    "Kananame": "occaecati",
    "EmailAddressName": "leif.lang@kuhic.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Eveline Stehr",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nihil",
    "FullName": "Tavares Mitchell",
    "IsOwnerContact": false,
    "ActiveErpLinks": 440,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 896
      }
    }
  },
  "Project": {
    "ProjectId": 885,
    "Name": "Littel, Barrows and Rippin",
    "Description": "Persistent explicit internet solution",
    "URL": "http://www.example.com/",
    "Type": "quisquam",
    "AssociateId": 42,
    "AssociateFullName": "Lesley Schmidt",
    "TypeId": 785,
    "Updated": "2018-11-29T09:40:59.1158544+01:00",
    "StatusId": 196,
    "Status": "non",
    "TextId": 588,
    "PublishTo": "2014-03-09T09:40:59.1158544+01:00",
    "PublishFrom": "1996-05-22T09:40:59.1158544+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "931207",
    "ActiveErpLinks": 344,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 581
      }
    }
  },
  "Date": "1996-07-30T09:40:59.1158544+02:00",
  "ExternalRef": "hic",
  "Completed": "Completed",
  "ActiveLinks": 722,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Doyle, Rohan and Predovic",
      "Id": 619,
      "Description": "Managed stable benchmark",
      "ExtraInfo": "rem",
      "LinkId": 922,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 246
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Yost, Nienow and Wolf",
    "SaleDate": "2010-01-25T09:40:59.1158544+01:00",
    "SaleId": 449,
    "Probability": 196,
    "Title": "quidem",
    "Amount": 21204.644,
    "Currency": "non",
    "ProjectName": "Herman, Abernathy and Schuppe",
    "AssociateFullName": "Mr. Billie Zboncak",
    "Description": "Pre-emptive impactful toolset",
    "Status": "Lost",
    "WeightedAmount": 2278.418,
    "ProjectId": 173,
    "EarningPercent": 7737.846,
    "Earning": 11329.41,
    "ContactId": 424,
    "AssociateId": 844,
    "PersonId": 879,
    "SaleTypeId": 177,
    "SaleTypeName": "Ondricka-Ullrich",
    "PersonFullName": "Carli Roberts",
    "Completed": "Completed",
    "ActiveErpLinks": 521,
    "NextDueDate": "2020-12-23T09:40:59.1168544+01:00",
    "Number": "417760",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 314
      }
    }
  },
  "SuggestedDocumentId": 499,
  "Snum": 470,
  "UserDefinedFields": {
    "SuperOffice:1": "Golda Funk",
    "SuperOffice:2": "582822691"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "fugiat",
    "CustomFields2": "autem"
  },
  "PublishEventDate": "1999-05-12T09:40:59.1168544+02:00",
  "PublishTo": "2003-01-03T09:40:59.1168544+01:00",
  "PublishFrom": "2005-01-04T09:40:59.1168544+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 450,
      "Visibility": "All",
      "DisplayValue": "suscipit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 274
        }
      }
    },
    {
      "VisibleId": 450,
      "Visibility": "All",
      "DisplayValue": "suscipit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 274
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
        "Reason": "exploit out-of-the-box e-business"
      },
      "FieldType": "System.Int32",
      "FieldLength": 812
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```