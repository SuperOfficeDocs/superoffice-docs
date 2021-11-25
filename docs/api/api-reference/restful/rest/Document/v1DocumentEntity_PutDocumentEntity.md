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
  "DocumentId": 152,
  "UpdatedBy": {
    "AssociateId": 882,
    "Name": "Will Inc and Sons",
    "PersonId": 770,
    "Rank": 108,
    "Tooltip": "beatae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 145,
    "FullName": "Alice Nader",
    "FormalName": "Runolfsdottir Inc and Sons",
    "Deleted": true,
    "EjUserId": 384,
    "UserName": "Lind-Hodkiewicz"
  },
  "CreatedBy": {
    "AssociateId": 117,
    "Name": "Smitham-Kohler",
    "PersonId": 628,
    "Rank": 627,
    "Tooltip": "ratione",
    "Type": "AnonymousAssociate",
    "GroupIdx": 541,
    "FullName": "Nelda Toy III",
    "FormalName": "Kuvalis Inc and Sons",
    "Deleted": true,
    "EjUserId": 239,
    "UserName": "Kiehn LLC"
  },
  "Attention": "repudiandae",
  "Header": "a",
  "Name": "Funk-Hackett",
  "OurRef": "maiores",
  "YourRef": "dolor",
  "CreatedDate": "2000-10-12T18:25:50.4486301+02:00",
  "UpdatedDate": "2000-12-15T18:25:50.4486301+01:00",
  "Description": "Open-source bandwidth-monitored open system",
  "DocumentTemplate": {
    "DocumentTemplateId": 143,
    "Name": "Schumm-Waters",
    "Tooltip": "id",
    "SaveInDb": 766,
    "Filename": "quod",
    "DefaultOref": "harum",
    "RecordType": "Appointment",
    "Deleted": 935,
    "Direction": "Incoming",
    "AutoeventId": 339,
    "QuoteDocType": "ConfirmationLines"
  },
  "Person": {
    "Position": "excepturi",
    "PersonId": 752,
    "Mrmrs": "quam",
    "Firstname": "Marco",
    "Lastname": "Wyman",
    "MiddleName": "Smitham LLC",
    "Title": "architecto",
    "Description": "Versatile bandwidth-monitored migration",
    "Email": "gerson.boehm@feest.com",
    "FullName": "Nina Eichmann DVM",
    "DirectPhone": "507-727-2612 x4450",
    "FormalName": "Beatty, Pollich and Hammes",
    "CountryId": 623,
    "ContactId": 92,
    "ContactName": "Gutkowski LLC",
    "Retired": 77,
    "Rank": 582,
    "ActiveInterests": 255,
    "ContactDepartment": "",
    "ContactCountryId": 155,
    "ContactOrgNr": "1385960",
    "FaxPhone": "(405)146-2623 x7115",
    "MobilePhone": "(535)043-5752",
    "ContactPhone": "1-610-301-3503 x072",
    "AssociateName": "Jerde LLC",
    "AssociateId": 340,
    "UsePersonAddress": false,
    "ContactFax": "aut",
    "Kanafname": "laudantium",
    "Kanalname": "est",
    "Post1": "omnis",
    "Post2": "voluptatem",
    "Post3": "et",
    "EmailName": "virginia@west.biz",
    "ContactFullName": "Duncan Pacocha",
    "ActiveErpLinks": 778,
    "TicketPriorityId": 543,
    "SupportLanguageId": 598,
    "SupportAssociateId": 828,
    "CategoryName": "VIP Customer"
  },
  "Associate": {
    "AssociateId": 541,
    "Name": "Hahn-Runte",
    "PersonId": 44,
    "Rank": 789,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 209,
    "FullName": "Effie Treutel III",
    "FormalName": "Little-Oberbrunner",
    "Deleted": true,
    "EjUserId": 400,
    "UserName": "Doyle Inc and Sons"
  },
  "Contact": {
    "ContactId": 977,
    "Name": "Heller-Hermiston",
    "OrgNr": "483832",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "sit",
    "DirectPhone": "740.426.2351 x4666",
    "AssociateId": 161,
    "CountryId": 246,
    "EmailAddress": "morton@parisian.uk",
    "Kananame": "odio",
    "EmailAddressName": "wanda.paucek@sawayn.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Heloise Jacobson",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "hic",
    "FullName": "Stephania Schuppe",
    "IsOwnerContact": false,
    "ActiveErpLinks": 541
  },
  "Project": {
    "ProjectId": 91,
    "Name": "Goyette-Medhurst",
    "Description": "Programmable cohesive product",
    "URL": "http://www.example.com/",
    "Type": "nihil",
    "AssociateId": 484,
    "AssociateFullName": "Lucile Johnson",
    "TypeId": 873,
    "Updated": "2003-07-25T18:25:50.4525957+02:00",
    "StatusId": 898,
    "Status": "voluptas",
    "TextId": 595,
    "PublishTo": "2003-10-07T18:25:50.4525957+02:00",
    "PublishFrom": "1999-04-16T18:25:50.4525957+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1469173",
    "ActiveErpLinks": 336
  },
  "Date": "2014-10-15T18:25:50.4525957+02:00",
  "ExternalRef": "sapiente",
  "Completed": "Completed",
  "ActiveLinks": 422,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Davis, Ullrich and Lehner",
      "Id": 894,
      "Description": "Face to face exuding portal",
      "ExtraInfo": "alias",
      "LinkId": 773
    },
    {
      "EntityName": "Davis, Ullrich and Lehner",
      "Id": 894,
      "Description": "Face to face exuding portal",
      "ExtraInfo": "alias",
      "LinkId": 773
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Erdman-Rutherford",
    "SaleDate": "2021-10-24T18:25:50.4525957+02:00",
    "SaleId": 534,
    "Probability": 613,
    "Title": "quae",
    "Amount": 17935.881999999998,
    "Currency": "ullam",
    "ProjectName": "O'Kon, Treutel and Koelpin",
    "AssociateFullName": "Hailey Kiehn",
    "Description": "Self-enabling impactful emulation",
    "Status": "Lost",
    "WeightedAmount": 24789.94,
    "ProjectId": 462,
    "EarningPercent": 16074.286,
    "Earning": 10580.384,
    "ContactId": 779,
    "AssociateId": 615,
    "PersonId": 888,
    "SaleTypeId": 580,
    "SaleTypeName": "Okuneva Inc and Sons",
    "PersonFullName": "Darby Metz",
    "Completed": "Completed",
    "ActiveErpLinks": 258,
    "NextDueDate": "2015-10-25T18:25:50.4525957+01:00",
    "Number": "805711"
  },
  "SuggestedDocumentId": 376,
  "Snum": 556,
  "UserDefinedFields": {
    "SuperOffice:1": "1889249501",
    "SuperOffice:2": "Reese Cartwright"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsa",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "veritatis",
    "CustomFields2": "enim"
  },
  "PublishEventDate": "2008-06-24T18:25:50.4525957+02:00",
  "PublishTo": "2016-07-21T18:25:50.4525957+02:00",
  "PublishFrom": "1999-01-25T18:25:50.4525957+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 161,
      "Visibility": "All",
      "DisplayValue": "rerum"
    },
    {
      "VisibleId": 161,
      "Visibility": "All",
      "DisplayValue": "rerum"
    }
  ]
}
```

```http_
HTTP/1.1 200 DocumentEntity updated.
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 121,
  "UpdatedBy": {
    "AssociateId": 43,
    "Name": "Moen-Donnelly",
    "PersonId": 631,
    "Rank": 534,
    "Tooltip": "doloremque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 67,
    "FullName": "Keith Paucek",
    "FormalName": "Haag, Hagenes and Bednar",
    "Deleted": true,
    "EjUserId": 96,
    "UserName": "Ferry Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 841
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 722,
    "Name": "Kozey, Marks and O'Hara",
    "PersonId": 481,
    "Rank": 767,
    "Tooltip": "nemo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 908,
    "FullName": "Mr. Neoma Lowe",
    "FormalName": "Cronin-Wisozk",
    "Deleted": true,
    "EjUserId": 432,
    "UserName": "Osinski Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 862
      }
    }
  },
  "Attention": "aut",
  "Header": "magnam",
  "Name": "Sawayn, Schamberger and Schroeder",
  "OurRef": "iste",
  "YourRef": "velit",
  "CreatedDate": "2016-09-04T18:25:50.4856263+02:00",
  "UpdatedDate": "2000-02-15T18:25:50.4856263+01:00",
  "Description": "Multi-layered grid-enabled product",
  "DocumentTemplate": {
    "DocumentTemplateId": 407,
    "Name": "Douglas LLC",
    "Tooltip": "autem",
    "SaveInDb": 983,
    "Filename": "placeat",
    "DefaultOref": "deserunt",
    "RecordType": "Appointment",
    "Deleted": 552,
    "Direction": "Incoming",
    "AutoeventId": 157,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 409
      }
    }
  },
  "Person": {
    "Position": "velit",
    "PersonId": 246,
    "Mrmrs": "itaque",
    "Firstname": "Cordia",
    "Lastname": "Trantow",
    "MiddleName": "Lueilwitz, Williamson and Nicolas",
    "Title": "ut",
    "Description": "Grass-roots cohesive functionalities",
    "Email": "josefa.bogisich@blanda.com",
    "FullName": "Pearlie Pfeffer",
    "DirectPhone": "455.104.1783",
    "FormalName": "Tromp Inc and Sons",
    "CountryId": 623,
    "ContactId": 791,
    "ContactName": "Schumm-Schulist",
    "Retired": 194,
    "Rank": 661,
    "ActiveInterests": 771,
    "ContactDepartment": "",
    "ContactCountryId": 104,
    "ContactOrgNr": "426403",
    "FaxPhone": "(123)013-1603 x051",
    "MobilePhone": "(855)171-7414 x38503",
    "ContactPhone": "438-428-3827",
    "AssociateName": "Keeling, Mitchell and Jacobs",
    "AssociateId": 272,
    "UsePersonAddress": true,
    "ContactFax": "voluptatem",
    "Kanafname": "dolorem",
    "Kanalname": "doloribus",
    "Post1": "inventore",
    "Post2": "possimus",
    "Post3": "maiores",
    "EmailName": "dan_damore@sanford.biz",
    "ContactFullName": "Magnolia Mertz",
    "ActiveErpLinks": 30,
    "TicketPriorityId": 265,
    "SupportLanguageId": 668,
    "SupportAssociateId": 883,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 851
      }
    }
  },
  "Associate": {
    "AssociateId": 770,
    "Name": "Douglas LLC",
    "PersonId": 283,
    "Rank": 371,
    "Tooltip": "perspiciatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 988,
    "FullName": "Roscoe Larkin",
    "FormalName": "Herman, Grady and Adams",
    "Deleted": true,
    "EjUserId": 526,
    "UserName": "Shanahan LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 725
      }
    }
  },
  "Contact": {
    "ContactId": 634,
    "Name": "Barrows, Brekke and Klein",
    "OrgNr": "908172",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "et",
    "DirectPhone": "(747)023-6870 x183",
    "AssociateId": 876,
    "CountryId": 903,
    "EmailAddress": "dawn.grady@russelhuel.ca",
    "Kananame": "ipsam",
    "EmailAddressName": "frieda_gleason@monahanmoen.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Brady Kutch",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "sit",
    "FullName": "Alvis Stracke",
    "IsOwnerContact": false,
    "ActiveErpLinks": 135,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 647
      }
    }
  },
  "Project": {
    "ProjectId": 236,
    "Name": "Miller-Brakus",
    "Description": "Team-oriented 24/7 collaboration",
    "URL": "http://www.example.com/",
    "Type": "corrupti",
    "AssociateId": 977,
    "AssociateFullName": "Miss Michael Bernhard",
    "TypeId": 179,
    "Updated": "2004-03-05T18:25:50.4886302+01:00",
    "StatusId": 311,
    "Status": "occaecati",
    "TextId": 360,
    "PublishTo": "2006-11-14T18:25:50.4886302+01:00",
    "PublishFrom": "2001-05-17T18:25:50.4886302+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "466803",
    "ActiveErpLinks": 432,
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
  "Date": "1996-12-06T18:25:50.4886302+01:00",
  "ExternalRef": "voluptatem",
  "Completed": "Completed",
  "ActiveLinks": 136,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Jacobson-Reinger",
      "Id": 593,
      "Description": "Horizontal bottom-line model",
      "ExtraInfo": "et",
      "LinkId": 233,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 871
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Zboncak LLC",
    "SaleDate": "2019-04-06T18:25:50.4886302+02:00",
    "SaleId": 487,
    "Probability": 157,
    "Title": "aut",
    "Amount": 14218.957999999999,
    "Currency": "dignissimos",
    "ProjectName": "Fahey-Bergnaum",
    "AssociateFullName": "Jamey Spinka",
    "Description": "Upgradable cohesive website",
    "Status": "Lost",
    "WeightedAmount": 23235.476,
    "ProjectId": 929,
    "EarningPercent": 31264.784,
    "Earning": 12394.97,
    "ContactId": 114,
    "AssociateId": 871,
    "PersonId": 593,
    "SaleTypeId": 992,
    "SaleTypeName": "Gerlach-Berge",
    "PersonFullName": "Hubert Reynolds",
    "Completed": "Completed",
    "ActiveErpLinks": 687,
    "NextDueDate": "2000-08-23T18:25:50.4886302+02:00",
    "Number": "1473904",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 815
      }
    }
  },
  "SuggestedDocumentId": 919,
  "Snum": 730,
  "UserDefinedFields": {
    "SuperOffice:1": "996480178",
    "SuperOffice:2": "Mr. Jed Torphy"
  },
  "ExtraFields": {
    "ExtraFields1": "iusto",
    "ExtraFields2": "quidem"
  },
  "CustomFields": {
    "CustomFields1": "quis",
    "CustomFields2": "voluptas"
  },
  "PublishEventDate": "1997-07-18T18:25:50.4896321+02:00",
  "PublishTo": "1997-03-16T18:25:50.4896321+01:00",
  "PublishFrom": "2007-09-21T18:25:50.4896321+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 40,
      "Visibility": "All",
      "DisplayValue": "id",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 375
        }
      }
    },
    {
      "VisibleId": 40,
      "Visibility": "All",
      "DisplayValue": "id",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 375
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
        "Reason": "optimize open-source infomediaries"
      },
      "FieldType": "System.Int32",
      "FieldLength": 779
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```