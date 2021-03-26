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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 130,
  "UpdatedBy": {
    "AssociateId": 192,
    "Name": "King-Trantow",
    "PersonId": 211,
    "Rank": 154,
    "Tooltip": "nobis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 158,
    "FullName": "Javonte Rodriguez",
    "FormalName": "Franecki Inc and Sons",
    "Deleted": true,
    "EjUserId": 424,
    "UserName": "Runte, Schiller and Stehr"
  },
  "CreatedBy": {
    "AssociateId": 406,
    "Name": "Towne-Moen",
    "PersonId": 785,
    "Rank": 822,
    "Tooltip": "labore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 844,
    "FullName": "Isaias Schultz",
    "FormalName": "Feil-Thompson",
    "Deleted": false,
    "EjUserId": 992,
    "UserName": "Johns Inc and Sons"
  },
  "Attention": "voluptas",
  "Header": "dolores",
  "Name": "Will, Pagac and O'Kon",
  "OurRef": "eos",
  "YourRef": "suscipit",
  "CreatedDate": "2012-01-11T09:40:59.0748844+01:00",
  "UpdatedDate": "1993-11-09T09:40:59.0748844+01:00",
  "Description": "Automated 24 hour matrix",
  "DocumentTemplate": {
    "DocumentTemplateId": 371,
    "Name": "Mante, Kulas and Oberbrunner",
    "Tooltip": "sed",
    "SaveInDb": 299,
    "Filename": "distinctio",
    "DefaultOref": "sit",
    "RecordType": "Appointment",
    "Deleted": 686,
    "Direction": "Incoming",
    "AutoeventId": 373,
    "QuoteDocType": "ConfirmationLines"
  },
  "Person": {
    "Position": "quidem",
    "PersonId": 904,
    "Mrmrs": "molestiae",
    "Firstname": "Salvatore",
    "Lastname": "Kerluke",
    "MiddleName": "Vandervort-Wunsch",
    "Title": "aut",
    "Description": "Multi-layered maximized collaboration",
    "Email": "una_haley@mcclure.info",
    "FullName": "Evie Grimes PhD",
    "DirectPhone": "(618)850-3043 x718",
    "FormalName": "Cummerata, Ondricka and Dibbert",
    "CountryId": 34,
    "ContactId": 76,
    "ContactName": "Haag-Walker",
    "Retired": 65,
    "Rank": 443,
    "ActiveInterests": 522,
    "ContactDepartment": "",
    "ContactCountryId": 39,
    "ContactOrgNr": "141306",
    "FaxPhone": "1-555-017-5184 x76414",
    "MobilePhone": "1-614-102-1117 x1443",
    "ContactPhone": "(385)724-7430",
    "AssociateName": "Bruen LLC",
    "AssociateId": 855,
    "UsePersonAddress": false,
    "ContactFax": "rerum",
    "Kanafname": "et",
    "Kanalname": "repudiandae",
    "Post1": "alias",
    "Post2": "enim",
    "Post3": "commodi",
    "EmailName": "genevieve_bahringer@lubowitz.info",
    "ContactFullName": "Emiliano Eichmann",
    "ActiveErpLinks": 171,
    "TicketPriorityId": 861,
    "SupportLanguageId": 574,
    "SupportAssociateId": 91,
    "CategoryName": "VIP Customer"
  },
  "Associate": {
    "AssociateId": 18,
    "Name": "Donnelly, Murphy and Hickle",
    "PersonId": 634,
    "Rank": 334,
    "Tooltip": "in",
    "Type": "AnonymousAssociate",
    "GroupIdx": 839,
    "FullName": "Reanna Wuckert MD",
    "FormalName": "Von-Dibbert",
    "Deleted": false,
    "EjUserId": 174,
    "UserName": "Block, Hauck and Luettgen"
  },
  "Contact": {
    "ContactId": 173,
    "Name": "Robel-Mohr",
    "OrgNr": "1314754",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "nisi",
    "DirectPhone": "(880)682-0440 x625",
    "AssociateId": 813,
    "CountryId": 169,
    "EmailAddress": "elfrieda_zemlak@johnsonweber.biz",
    "Kananame": "praesentium",
    "EmailAddressName": "sigrid_okon@anderson.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ophelia Langworth",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "consectetur",
    "FullName": "Brain Douglas",
    "IsOwnerContact": false,
    "ActiveErpLinks": 283
  },
  "Project": {
    "ProjectId": 843,
    "Name": "Torp, Ward and Kessler",
    "Description": "Switchable heuristic moderator",
    "URL": "http://www.example.com/",
    "Type": "earum",
    "AssociateId": 62,
    "AssociateFullName": "Mrs. Horacio Gerhold",
    "TypeId": 93,
    "Updated": "2009-10-18T09:40:59.0778842+02:00",
    "StatusId": 324,
    "Status": "laborum",
    "TextId": 48,
    "PublishTo": "2006-04-10T09:40:59.0778842+02:00",
    "PublishFrom": "2008-08-23T09:40:59.0778842+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1209187",
    "ActiveErpLinks": 214
  },
  "Date": "2018-07-30T09:40:59.0778842+02:00",
  "ExternalRef": "iusto",
  "Completed": "Completed",
  "ActiveLinks": 220,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Schinner-Luettgen",
      "Id": 21,
      "Description": "Versatile directional secured line",
      "ExtraInfo": "commodi",
      "LinkId": 497
    },
    {
      "EntityName": "Schinner-Luettgen",
      "Id": 21,
      "Description": "Versatile directional secured line",
      "ExtraInfo": "commodi",
      "LinkId": 497
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "West LLC",
    "SaleDate": "2018-12-29T09:40:59.0778842+01:00",
    "SaleId": 944,
    "Probability": 99,
    "Title": "et",
    "Amount": 12347.96,
    "Currency": "ut",
    "ProjectName": "Kessler LLC",
    "AssociateFullName": "Mr. Lizeth Heller",
    "Description": "Synchronised content-based moratorium",
    "Status": "Lost",
    "WeightedAmount": 23432.917999999998,
    "ProjectId": 933,
    "EarningPercent": 19947.91,
    "Earning": 21969.34,
    "ContactId": 74,
    "AssociateId": 458,
    "PersonId": 41,
    "SaleTypeId": 993,
    "SaleTypeName": "Paucek Inc and Sons",
    "PersonFullName": "Virgie Strosin",
    "Completed": "Completed",
    "ActiveErpLinks": 133,
    "NextDueDate": "2016-12-28T09:40:59.0798841+01:00",
    "Number": "989079"
  },
  "SuggestedDocumentId": 473,
  "Snum": 826,
  "UserDefinedFields": {
    "SuperOffice:1": "Bethel Hintz",
    "SuperOffice:2": "Alexandre Labadie I"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "natus"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "nobis"
  },
  "PublishEventDate": "2000-04-30T09:40:59.0798841+02:00",
  "PublishTo": "2010-03-13T09:40:59.0798841+01:00",
  "PublishFrom": "1999-08-08T09:40:59.0798841+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 246,
      "Visibility": "All",
      "DisplayValue": "et"
    },
    {
      "VisibleId": 246,
      "Visibility": "All",
      "DisplayValue": "et"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 306,
  "UpdatedBy": {
    "AssociateId": 642,
    "Name": "Runolfsdottir, Kautzer and Mueller",
    "PersonId": 755,
    "Rank": 20,
    "Tooltip": "eum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 187,
    "FullName": "Aaliyah Zboncak",
    "FormalName": "Moen LLC",
    "Deleted": true,
    "EjUserId": 598,
    "UserName": "Crooks Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 600
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 433,
    "Name": "Rutherford Group",
    "PersonId": 246,
    "Rank": 919,
    "Tooltip": "impedit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 769,
    "FullName": "Deshawn Cartwright DVM",
    "FormalName": "Ortiz, McClure and Dooley",
    "Deleted": true,
    "EjUserId": 810,
    "UserName": "Schamberger Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 2
      }
    }
  },
  "Attention": "qui",
  "Header": "necessitatibus",
  "Name": "Cassin Inc and Sons",
  "OurRef": "vel",
  "YourRef": "mollitia",
  "CreatedDate": "2008-03-02T09:40:59.0878841+01:00",
  "UpdatedDate": "2013-11-26T09:40:59.0878841+01:00",
  "Description": "Virtual discrete function",
  "DocumentTemplate": {
    "DocumentTemplateId": 331,
    "Name": "Harris-Bartell",
    "Tooltip": "iste",
    "SaveInDb": 494,
    "Filename": "assumenda",
    "DefaultOref": "dolores",
    "RecordType": "Appointment",
    "Deleted": 644,
    "Direction": "Incoming",
    "AutoeventId": 837,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 570
      }
    }
  },
  "Person": {
    "Position": "debitis",
    "PersonId": 89,
    "Mrmrs": "aspernatur",
    "Firstname": "Lynn",
    "Lastname": "Wiegand",
    "MiddleName": "Yost, Reichel and Ziemann",
    "Title": "vel",
    "Description": "Inverse hybrid infrastructure",
    "Email": "andre.braun@schowaltercartwright.biz",
    "FullName": "Julien Parisian",
    "DirectPhone": "072-356-1431 x885",
    "FormalName": "Nienow-Bayer",
    "CountryId": 444,
    "ContactId": 665,
    "ContactName": "Farrell, Tillman and Herman",
    "Retired": 73,
    "Rank": 99,
    "ActiveInterests": 545,
    "ContactDepartment": "",
    "ContactCountryId": 920,
    "ContactOrgNr": "1127712",
    "FaxPhone": "(458)471-3510 x101",
    "MobilePhone": "(134)810-1874 x456",
    "ContactPhone": "747-768-6300",
    "AssociateName": "Kshlerin, Oberbrunner and Schmeler",
    "AssociateId": 497,
    "UsePersonAddress": false,
    "ContactFax": "quo",
    "Kanafname": "culpa",
    "Kanalname": "ratione",
    "Post1": "non",
    "Post2": "soluta",
    "Post3": "sed",
    "EmailName": "joseph_denesik@danielsmith.biz",
    "ContactFullName": "Grant Heidenreich",
    "ActiveErpLinks": 209,
    "TicketPriorityId": 793,
    "SupportLanguageId": 766,
    "SupportAssociateId": 391,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "visualize killer portals"
        },
        "FieldType": "System.Int32",
        "FieldLength": 253
      }
    }
  },
  "Associate": {
    "AssociateId": 445,
    "Name": "Jast, Daugherty and Funk",
    "PersonId": 663,
    "Rank": 748,
    "Tooltip": "dolorum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 629,
    "FullName": "Lorine Kuhlman Sr.",
    "FormalName": "Borer-Koss",
    "Deleted": false,
    "EjUserId": 783,
    "UserName": "Monahan LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 757
      }
    }
  },
  "Contact": {
    "ContactId": 295,
    "Name": "Lang, Friesen and Tremblay",
    "OrgNr": "539964",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "est",
    "DirectPhone": "818-363-5518",
    "AssociateId": 290,
    "CountryId": 521,
    "EmailAddress": "vernie.pfeffer@skiles.uk",
    "Kananame": "et",
    "EmailAddressName": "berneice@runolfsdottir.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Hassan Thiel PhD",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "unde",
    "FullName": "Raphaelle Toy",
    "IsOwnerContact": false,
    "ActiveErpLinks": 154,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "optimize cutting-edge synergies"
        },
        "FieldType": "System.Int32",
        "FieldLength": 914
      }
    }
  },
  "Project": {
    "ProjectId": 294,
    "Name": "Hirthe-Ledner",
    "Description": "Ergonomic 24/7 Graphic Interface",
    "URL": "http://www.example.com/",
    "Type": "officiis",
    "AssociateId": 271,
    "AssociateFullName": "Elliot O'Reilly",
    "TypeId": 572,
    "Updated": "1998-01-19T09:40:59.0898857+01:00",
    "StatusId": 531,
    "Status": "atque",
    "TextId": 412,
    "PublishTo": "2003-06-10T09:40:59.0898857+02:00",
    "PublishFrom": "2001-05-08T09:40:59.0898857+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1514222",
    "ActiveErpLinks": 57,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 228
      }
    }
  },
  "Date": "1994-09-19T09:40:59.0898857+02:00",
  "ExternalRef": "ducimus",
  "Completed": "Completed",
  "ActiveLinks": 199,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Reichert LLC",
      "Id": 177,
      "Description": "Synchronised holistic alliance",
      "ExtraInfo": "sint",
      "LinkId": 301,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 606
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Hilpert LLC",
    "SaleDate": "2004-11-22T09:40:59.0898857+01:00",
    "SaleId": 188,
    "Probability": 886,
    "Title": "et",
    "Amount": 14779.944,
    "Currency": "earum",
    "ProjectName": "Miller-Ullrich",
    "AssociateFullName": "Aniya Kessler IV",
    "Description": "Compatible maximized protocol",
    "Status": "Lost",
    "WeightedAmount": 9684.06,
    "ProjectId": 553,
    "EarningPercent": 5550.3139999999994,
    "Earning": 21314.334,
    "ContactId": 734,
    "AssociateId": 125,
    "PersonId": 578,
    "SaleTypeId": 469,
    "SaleTypeName": "Kuhn, Hammes and Medhurst",
    "PersonFullName": "Marianne Steuber",
    "Completed": "Completed",
    "ActiveErpLinks": 13,
    "NextDueDate": "2005-03-03T09:40:59.0908862+01:00",
    "Number": "651303",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 4
      }
    }
  },
  "SuggestedDocumentId": 447,
  "Snum": 771,
  "UserDefinedFields": {
    "SuperOffice:1": "Maxine Kris Jr.",
    "SuperOffice:2": "Mr. Heaven Kuvalis"
  },
  "ExtraFields": {
    "ExtraFields1": "impedit",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "ducimus",
    "CustomFields2": "consequatur"
  },
  "PublishEventDate": "2019-11-27T09:40:59.0908862+01:00",
  "PublishTo": "2006-05-17T09:40:59.0908862+02:00",
  "PublishFrom": "2015-07-10T09:40:59.0908862+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 458,
      "Visibility": "All",
      "DisplayValue": "qui",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 176
        }
      }
    },
    {
      "VisibleId": 458,
      "Visibility": "All",
      "DisplayValue": "qui",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 176
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
      "FieldLength": 133
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```