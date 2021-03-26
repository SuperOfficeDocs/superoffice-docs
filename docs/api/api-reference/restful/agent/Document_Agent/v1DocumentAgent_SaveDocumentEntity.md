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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 531,
  "UpdatedBy": {
    "AssociateId": 609,
    "Name": "Hartmann, Schulist and Carter",
    "PersonId": 84,
    "Rank": 696,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 183,
    "FullName": "Mrs. Leila Marks",
    "FormalName": "Fahey Inc and Sons",
    "Deleted": true,
    "EjUserId": 728,
    "UserName": "Mohr, Wuckert and Boyer"
  },
  "CreatedBy": {
    "AssociateId": 644,
    "Name": "Balistreri-Brekke",
    "PersonId": 634,
    "Rank": 473,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 112,
    "FullName": "Jeanne Ernser",
    "FormalName": "Crist-Ryan",
    "Deleted": true,
    "EjUserId": 265,
    "UserName": "Mann, Stokes and Welch"
  },
  "Attention": "assumenda",
  "Header": "sequi",
  "Name": "Raynor-Casper",
  "OurRef": "omnis",
  "YourRef": "reiciendis",
  "CreatedDate": "2014-09-05T16:48:29.3598942+02:00",
  "UpdatedDate": "2016-07-24T16:48:29.3598942+02:00",
  "Description": "Reduced 6th generation leverage",
  "DocumentTemplate": {
    "DocumentTemplateId": 24,
    "Name": "Stracke-Crona",
    "Tooltip": "aut",
    "SaveInDb": 870,
    "Filename": "non",
    "DefaultOref": "molestiae",
    "RecordType": "Appointment",
    "Deleted": 457,
    "Direction": "Incoming",
    "AutoeventId": 885,
    "QuoteDocType": "ConfirmationLines"
  },
  "Person": {
    "Position": "cumque",
    "PersonId": 632,
    "Mrmrs": "et",
    "Firstname": "Jarrett",
    "Lastname": "Schuppe",
    "MiddleName": "Tromp-Christiansen",
    "Title": "id",
    "Description": "Object-based zero defect data-warehouse",
    "Email": "milo@fisher.biz",
    "FullName": "Miss Stanley Satterfield",
    "DirectPhone": "777-421-5041",
    "FormalName": "Heaney, Little and Mertz",
    "CountryId": 260,
    "ContactId": 259,
    "ContactName": "Ruecker, Cole and Marvin",
    "Retired": 949,
    "Rank": 536,
    "ActiveInterests": 519,
    "ContactDepartment": "",
    "ContactCountryId": 772,
    "ContactOrgNr": "837652",
    "FaxPhone": "1-468-342-8705 x0588",
    "MobilePhone": "283.663.4276 x1222",
    "ContactPhone": "1-684-747-1372",
    "AssociateName": "Kiehn-Farrell",
    "AssociateId": 164,
    "UsePersonAddress": false,
    "ContactFax": "et",
    "Kanafname": "maxime",
    "Kanalname": "est",
    "Post1": "similique",
    "Post2": "enim",
    "Post3": "blanditiis",
    "EmailName": "laurence@witting.ca",
    "ContactFullName": "Suzanne Borer",
    "ActiveErpLinks": 82,
    "TicketPriorityId": 98,
    "SupportLanguageId": 508,
    "SupportAssociateId": 999,
    "CategoryName": "VIP Customer"
  },
  "Associate": {
    "AssociateId": 178,
    "Name": "Koepp-Hyatt",
    "PersonId": 77,
    "Rank": 1000,
    "Tooltip": "veritatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 256,
    "FullName": "Elton Mayer",
    "FormalName": "Rice Inc and Sons",
    "Deleted": true,
    "EjUserId": 677,
    "UserName": "Howe-Harvey"
  },
  "Contact": {
    "ContactId": 987,
    "Name": "Mraz, Hane and Zieme",
    "OrgNr": "1450570",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "et",
    "DirectPhone": "1-460-181-7273 x836",
    "AssociateId": 663,
    "CountryId": 62,
    "EmailAddress": "urban@okunevajacobson.ca",
    "Kananame": "distinctio",
    "EmailAddressName": "lulu@bins.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Lenna Schuster",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "pariatur",
    "FullName": "Abe Morissette",
    "IsOwnerContact": true,
    "ActiveErpLinks": 263
  },
  "Project": {
    "ProjectId": 888,
    "Name": "Langworth Group",
    "Description": "Automated hybrid task-force",
    "URL": "http://www.example.com/",
    "Type": "itaque",
    "AssociateId": 418,
    "AssociateFullName": "Luz Walter",
    "TypeId": 29,
    "Updated": "2020-10-21T16:48:29.3628937+02:00",
    "StatusId": 343,
    "Status": "vero",
    "TextId": 476,
    "PublishTo": "2017-12-20T16:48:29.3628937+01:00",
    "PublishFrom": "2018-08-06T16:48:29.3628937+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "380064",
    "ActiveErpLinks": 588
  },
  "Date": "2012-02-29T16:48:29.3628937+01:00",
  "ExternalRef": "rerum",
  "Completed": "Completed",
  "ActiveLinks": 232,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Goldner LLC",
      "Id": 520,
      "Description": "Diverse mission-critical paradigm",
      "ExtraInfo": "qui",
      "LinkId": 908
    },
    {
      "EntityName": "Goldner LLC",
      "Id": 520,
      "Description": "Diverse mission-critical paradigm",
      "ExtraInfo": "qui",
      "LinkId": 908
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Padberg Inc and Sons",
    "SaleDate": "2016-11-24T16:48:29.3628937+01:00",
    "SaleId": 682,
    "Probability": 797,
    "Title": "molestias",
    "Amount": 23229.208,
    "Currency": "qui",
    "ProjectName": "Cummerata Inc and Sons",
    "AssociateFullName": "Emelia Hermiston MD",
    "Description": "Visionary disintermediate solution",
    "Status": "Lost",
    "WeightedAmount": 29183.807999999997,
    "ProjectId": 266,
    "EarningPercent": 11730.562,
    "Earning": 16553.788,
    "ContactId": 510,
    "AssociateId": 807,
    "PersonId": 738,
    "SaleTypeId": 374,
    "SaleTypeName": "Harber, Effertz and Pfannerstill",
    "PersonFullName": "Jillian Champlin",
    "Completed": "Completed",
    "ActiveErpLinks": 652,
    "NextDueDate": "2001-06-14T16:48:29.3638941+02:00",
    "Number": "918191"
  },
  "SuggestedDocumentId": 491,
  "Snum": 339,
  "UserDefinedFields": {
    "SuperOffice:1": "Evelyn Bode II",
    "SuperOffice:2": "915712611"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "iusto"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "voluptatem"
  },
  "PublishEventDate": "2013-05-21T16:48:29.3638941+02:00",
  "PublishTo": "2015-02-27T16:48:29.3638941+01:00",
  "PublishFrom": "2000-02-29T16:48:29.3638941+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 436,
      "Visibility": "All",
      "DisplayValue": "voluptatum"
    },
    {
      "VisibleId": 436,
      "Visibility": "All",
      "DisplayValue": "voluptatum"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 641,
  "UpdatedBy": {
    "AssociateId": 479,
    "Name": "Mitchell, Hessel and Champlin",
    "PersonId": 179,
    "Rank": 750,
    "Tooltip": "eius",
    "Type": "AnonymousAssociate",
    "GroupIdx": 20,
    "FullName": "Ewald Lynch",
    "FormalName": "Rempel-Kuhlman",
    "Deleted": true,
    "EjUserId": 91,
    "UserName": "Ruecker-Satterfield",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 909
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 95,
    "Name": "Boyle, Harris and Fritsch",
    "PersonId": 334,
    "Rank": 655,
    "Tooltip": "vel",
    "Type": "AnonymousAssociate",
    "GroupIdx": 647,
    "FullName": "Donald Stoltenberg",
    "FormalName": "Oberbrunner-Osinski",
    "Deleted": true,
    "EjUserId": 353,
    "UserName": "Herman-Parker",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 877
      }
    }
  },
  "Attention": "ut",
  "Header": "optio",
  "Name": "Williamson-Howe",
  "OurRef": "vitae",
  "YourRef": "et",
  "CreatedDate": "1996-12-02T16:48:29.3688938+01:00",
  "UpdatedDate": "1996-08-12T16:48:29.3688938+02:00",
  "Description": "Public-key 5th generation paradigm",
  "DocumentTemplate": {
    "DocumentTemplateId": 183,
    "Name": "Boehm-Block",
    "Tooltip": "tempora",
    "SaveInDb": 878,
    "Filename": "odit",
    "DefaultOref": "exercitationem",
    "RecordType": "Appointment",
    "Deleted": 556,
    "Direction": "Incoming",
    "AutoeventId": 433,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 310
      }
    }
  },
  "Person": {
    "Position": "soluta",
    "PersonId": 558,
    "Mrmrs": "accusantium",
    "Firstname": "Amari",
    "Lastname": "Satterfield",
    "MiddleName": "Reichert, Sawayn and Lynch",
    "Title": "odio",
    "Description": "Proactive hybrid portal",
    "Email": "kamron@emard.info",
    "FullName": "Katlynn Ondricka",
    "DirectPhone": "(564)014-7684 x03064",
    "FormalName": "Huel Inc and Sons",
    "CountryId": 307,
    "ContactId": 630,
    "ContactName": "Von Group",
    "Retired": 685,
    "Rank": 689,
    "ActiveInterests": 174,
    "ContactDepartment": "",
    "ContactCountryId": 673,
    "ContactOrgNr": "1831843",
    "FaxPhone": "(001)302-5507",
    "MobilePhone": "1-605-643-6232 x2076",
    "ContactPhone": "730.218.8303 x8238",
    "AssociateName": "Ratke, Gleason and Rowe",
    "AssociateId": 344,
    "UsePersonAddress": true,
    "ContactFax": "quae",
    "Kanafname": "nobis",
    "Kanalname": "ut",
    "Post1": "et",
    "Post2": "possimus",
    "Post3": "minima",
    "EmailName": "evert.gleason@rueckerroberts.info",
    "ContactFullName": "Lacey Lehner",
    "ActiveErpLinks": 397,
    "TicketPriorityId": 561,
    "SupportLanguageId": 129,
    "SupportAssociateId": 430,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 980
      }
    }
  },
  "Associate": {
    "AssociateId": 277,
    "Name": "Lang-Stehr",
    "PersonId": 743,
    "Rank": 467,
    "Tooltip": "totam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 380,
    "FullName": "Laney Hegmann",
    "FormalName": "O'Connell-Pagac",
    "Deleted": false,
    "EjUserId": 424,
    "UserName": "Breitenberg-Kuvalis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 323
      }
    }
  },
  "Contact": {
    "ContactId": 515,
    "Name": "Champlin-Parisian",
    "OrgNr": "564381",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dolor",
    "DirectPhone": "1-614-672-2433 x8108",
    "AssociateId": 452,
    "CountryId": 433,
    "EmailAddress": "caitlyn@kossgerhold.name",
    "Kananame": "provident",
    "EmailAddressName": "triston@schamberger.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Erich Mante",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "officiis",
    "FullName": "Jodie Pouros",
    "IsOwnerContact": false,
    "ActiveErpLinks": 816,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 159
      }
    }
  },
  "Project": {
    "ProjectId": 327,
    "Name": "Langosh Inc and Sons",
    "Description": "Enhanced 5th generation architecture",
    "URL": "http://www.example.com/",
    "Type": "illum",
    "AssociateId": 309,
    "AssociateFullName": "Princess Collins",
    "TypeId": 959,
    "Updated": "2007-07-01T16:48:29.3718941+02:00",
    "StatusId": 861,
    "Status": "quas",
    "TextId": 771,
    "PublishTo": "2017-04-13T16:48:29.3718941+02:00",
    "PublishFrom": "2020-05-10T16:48:29.3718941+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "954728",
    "ActiveErpLinks": 39,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 472
      }
    }
  },
  "Date": "2003-11-18T16:48:29.3718941+01:00",
  "ExternalRef": "omnis",
  "Completed": "Completed",
  "ActiveLinks": 829,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Kassulke, Witting and Lynch",
      "Id": 710,
      "Description": "Diverse homogeneous installation",
      "ExtraInfo": "eius",
      "LinkId": 73,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 818
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Rempel, Will and Cassin",
    "SaleDate": "2003-04-14T16:48:29.3718941+02:00",
    "SaleId": 714,
    "Probability": 177,
    "Title": "suscipit",
    "Amount": 3641.708,
    "Currency": "eum",
    "ProjectName": "Beatty Group",
    "AssociateFullName": "Elsa Rohan",
    "Description": "Phased global benchmark",
    "Status": "Lost",
    "WeightedAmount": 1902.338,
    "ProjectId": 944,
    "EarningPercent": 17233.865999999998,
    "Earning": 5061.41,
    "ContactId": 358,
    "AssociateId": 120,
    "PersonId": 968,
    "SaleTypeId": 475,
    "SaleTypeName": "Carter-O'Keefe",
    "PersonFullName": "Kasey Bartoletti",
    "Completed": "Completed",
    "ActiveErpLinks": 703,
    "NextDueDate": "2006-02-17T16:48:29.3728937+01:00",
    "Number": "437111",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 429
      }
    }
  },
  "SuggestedDocumentId": 99,
  "Snum": 326,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Geraldine Mayert"
  },
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "ex",
    "CustomFields2": "non"
  },
  "PublishEventDate": "1997-08-18T16:48:29.3728937+02:00",
  "PublishTo": "2000-12-23T16:48:29.3728937+01:00",
  "PublishFrom": "2003-04-30T16:48:29.3728937+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 263,
      "Visibility": "All",
      "DisplayValue": "sit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 182
        }
      }
    },
    {
      "VisibleId": 263,
      "Visibility": "All",
      "DisplayValue": "sit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 182
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
      "FieldLength": 839
    }
  }
}
```