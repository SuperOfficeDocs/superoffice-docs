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
  "DocumentId": 183,
  "UpdatedBy": {
    "AssociateId": 311,
    "Name": "Kulas, Kohler and Pouros",
    "PersonId": 444,
    "Rank": 502,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 305,
    "FullName": "Lucinda Hammes",
    "FormalName": "Wehner Inc and Sons",
    "Deleted": false,
    "EjUserId": 518,
    "UserName": "Gislason Group"
  },
  "CreatedBy": {
    "AssociateId": 730,
    "Name": "Shanahan, Feil and Moen",
    "PersonId": 157,
    "Rank": 572,
    "Tooltip": "autem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 359,
    "FullName": "Regan Weissnat",
    "FormalName": "Rau-Moore",
    "Deleted": true,
    "EjUserId": 579,
    "UserName": "Mitchell, Hand and Boyle"
  },
  "Attention": "mollitia",
  "Header": "ipsam",
  "Name": "Pfeffer, Haag and Pfannerstill",
  "OurRef": "repudiandae",
  "YourRef": "consectetur",
  "CreatedDate": "2003-07-22T18:25:50.4236243+02:00",
  "UpdatedDate": "2004-04-29T18:25:50.4236243+02:00",
  "Description": "Multi-channelled stable focus group",
  "DocumentTemplate": {
    "DocumentTemplateId": 306,
    "Name": "Ankunding-Ullrich",
    "Tooltip": "quisquam",
    "SaveInDb": 502,
    "Filename": "non",
    "DefaultOref": "dolore",
    "RecordType": "Appointment",
    "Deleted": 427,
    "Direction": "Incoming",
    "AutoeventId": 142,
    "QuoteDocType": "ConfirmationLines"
  },
  "Person": {
    "Position": "labore",
    "PersonId": 643,
    "Mrmrs": "voluptas",
    "Firstname": "Pasquale",
    "Lastname": "Sporer",
    "MiddleName": "Quitzon-Homenick",
    "Title": "aliquam",
    "Description": "Reverse-engineered optimal approach",
    "Email": "colt@mann.us",
    "FullName": "Davin Swift III",
    "DirectPhone": "1-220-144-3783",
    "FormalName": "Cole, Kutch and Langworth",
    "CountryId": 745,
    "ContactId": 529,
    "ContactName": "Wintheiser Group",
    "Retired": 247,
    "Rank": 458,
    "ActiveInterests": 787,
    "ContactDepartment": "",
    "ContactCountryId": 93,
    "ContactOrgNr": "469246",
    "FaxPhone": "104-062-6443 x47478",
    "MobilePhone": "630.602.7821 x1540",
    "ContactPhone": "836.263.3076 x82061",
    "AssociateName": "Jerde LLC",
    "AssociateId": 990,
    "UsePersonAddress": false,
    "ContactFax": "quia",
    "Kanafname": "est",
    "Kanalname": "enim",
    "Post1": "qui",
    "Post2": "ratione",
    "Post3": "veritatis",
    "EmailName": "jaden@kovacekschaden.ca",
    "ContactFullName": "Giles Goodwin",
    "ActiveErpLinks": 295,
    "TicketPriorityId": 243,
    "SupportLanguageId": 965,
    "SupportAssociateId": 70,
    "CategoryName": "VIP Customer"
  },
  "Associate": {
    "AssociateId": 46,
    "Name": "Gusikowski, Conn and Von",
    "PersonId": 744,
    "Rank": 159,
    "Tooltip": "iusto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 727,
    "FullName": "Tevin Kihn",
    "FormalName": "Stroman-Orn",
    "Deleted": true,
    "EjUserId": 687,
    "UserName": "Waelchi, Roob and Nitzsche"
  },
  "Contact": {
    "ContactId": 125,
    "Name": "King-Tillman",
    "OrgNr": "820947",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "delectus",
    "DirectPhone": "(675)256-3850 x275",
    "AssociateId": 869,
    "CountryId": 88,
    "EmailAddress": "jovanny_stiedemann@goyettecormier.us",
    "Kananame": "dolor",
    "EmailAddressName": "jamel@weber.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Grady Eichmann",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "possimus",
    "FullName": "Arely Ritchie",
    "IsOwnerContact": true,
    "ActiveErpLinks": 756
  },
  "Project": {
    "ProjectId": 343,
    "Name": "Jacobs, Gorczany and Bode",
    "Description": "Persevering responsive flexibility",
    "URL": "http://www.example.com/",
    "Type": "qui",
    "AssociateId": 599,
    "AssociateFullName": "Cydney Luettgen",
    "TypeId": 522,
    "Updated": "2005-11-11T18:25:50.4266223+01:00",
    "StatusId": 63,
    "Status": "incidunt",
    "TextId": 545,
    "PublishTo": "1994-09-30T18:25:50.4266223+02:00",
    "PublishFrom": "2002-11-01T18:25:50.4266223+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "562866",
    "ActiveErpLinks": 182
  },
  "Date": "2004-01-01T18:25:50.4266223+01:00",
  "ExternalRef": "magni",
  "Completed": "Completed",
  "ActiveLinks": 532,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Ledner Group",
      "Id": 570,
      "Description": "Profit-focused tertiary Graphic Interface",
      "ExtraInfo": "veritatis",
      "LinkId": 602
    },
    {
      "EntityName": "Ledner Group",
      "Id": 570,
      "Description": "Profit-focused tertiary Graphic Interface",
      "ExtraInfo": "veritatis",
      "LinkId": 602
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Cummerata-Heller",
    "SaleDate": "2016-12-16T18:25:50.4266223+01:00",
    "SaleId": 657,
    "Probability": 118,
    "Title": "similique",
    "Amount": 30265.038,
    "Currency": "quod",
    "ProjectName": "Nolan, Sauer and Walker",
    "AssociateFullName": "Stephen Ward II",
    "Description": "Diverse client-server complexity",
    "Status": "Lost",
    "WeightedAmount": 4237.168,
    "ProjectId": 692,
    "EarningPercent": 23564.546,
    "Earning": 29826.278,
    "ContactId": 947,
    "AssociateId": 163,
    "PersonId": 715,
    "SaleTypeId": 351,
    "SaleTypeName": "Hudson-Toy",
    "PersonFullName": "Elyse Reynolds",
    "Completed": "Completed",
    "ActiveErpLinks": 1000,
    "NextDueDate": "2012-10-03T18:25:50.4276303+02:00",
    "Number": "1285797"
  },
  "SuggestedDocumentId": 566,
  "Snum": 612,
  "UserDefinedFields": {
    "SuperOffice:1": "1639795728",
    "SuperOffice:2": "Melany Kunde"
  },
  "ExtraFields": {
    "ExtraFields1": "porro",
    "ExtraFields2": "dolorum"
  },
  "CustomFields": {
    "CustomFields1": "nobis",
    "CustomFields2": "corrupti"
  },
  "PublishEventDate": "1997-03-05T18:25:50.4276303+01:00",
  "PublishTo": "2017-05-26T18:25:50.4276303+02:00",
  "PublishFrom": "2015-09-26T18:25:50.4276303+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 254,
      "Visibility": "All",
      "DisplayValue": "quis"
    },
    {
      "VisibleId": 254,
      "Visibility": "All",
      "DisplayValue": "quis"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 215,
  "UpdatedBy": {
    "AssociateId": 727,
    "Name": "Jenkins LLC",
    "PersonId": 94,
    "Rank": 382,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 880,
    "FullName": "Ambrose Kuphal",
    "FormalName": "Lakin Group",
    "Deleted": true,
    "EjUserId": 795,
    "UserName": "Nolan Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 135
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 218,
    "Name": "Schmeler-Satterfield",
    "PersonId": 729,
    "Rank": 49,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 800,
    "FullName": "Ms. Gladyce Runte",
    "FormalName": "Dare, Hahn and Haley",
    "Deleted": true,
    "EjUserId": 519,
    "UserName": "Carter-Haley",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 683
      }
    }
  },
  "Attention": "iste",
  "Header": "enim",
  "Name": "Luettgen Inc and Sons",
  "OurRef": "molestiae",
  "YourRef": "nihil",
  "CreatedDate": "2005-05-14T18:25:50.4346326+02:00",
  "UpdatedDate": "1999-02-26T18:25:50.4346326+01:00",
  "Description": "Fundamental encompassing migration",
  "DocumentTemplate": {
    "DocumentTemplateId": 484,
    "Name": "Grimes-Wiegand",
    "Tooltip": "incidunt",
    "SaveInDb": 470,
    "Filename": "eos",
    "DefaultOref": "suscipit",
    "RecordType": "Appointment",
    "Deleted": 99,
    "Direction": "Incoming",
    "AutoeventId": 23,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 158
      }
    }
  },
  "Person": {
    "Position": "non",
    "PersonId": 832,
    "Mrmrs": "et",
    "Firstname": "Sincere",
    "Lastname": "Bernier",
    "MiddleName": "Toy, Rath and Lemke",
    "Title": "ipsam",
    "Description": "Multi-tiered stable flexibility",
    "Email": "nina@walshbogan.co.uk",
    "FullName": "Marta Ernser PhD",
    "DirectPhone": "743.548.1285 x2711",
    "FormalName": "Leffler, Jones and Adams",
    "CountryId": 155,
    "ContactId": 165,
    "ContactName": "Gutmann-Pouros",
    "Retired": 514,
    "Rank": 261,
    "ActiveInterests": 711,
    "ContactDepartment": "",
    "ContactCountryId": 71,
    "ContactOrgNr": "725174",
    "FaxPhone": "1-611-214-1021",
    "MobilePhone": "(761)746-2466",
    "ContactPhone": "(614)782-6318",
    "AssociateName": "Kozey-Lind",
    "AssociateId": 669,
    "UsePersonAddress": true,
    "ContactFax": "id",
    "Kanafname": "ullam",
    "Kanalname": "et",
    "Post1": "ea",
    "Post2": "voluptatibus",
    "Post3": "eum",
    "EmailName": "neha@schneider.biz",
    "ContactFullName": "Tyrell Schmidt",
    "ActiveErpLinks": 405,
    "TicketPriorityId": 558,
    "SupportLanguageId": 801,
    "SupportAssociateId": 316,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 313
      }
    }
  },
  "Associate": {
    "AssociateId": 236,
    "Name": "DuBuque-Labadie",
    "PersonId": 894,
    "Rank": 689,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 207,
    "FullName": "Randall Becker",
    "FormalName": "Mayer, Weissnat and Marks",
    "Deleted": false,
    "EjUserId": 336,
    "UserName": "Torp Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "optimize robust channels"
        },
        "FieldType": "System.String",
        "FieldLength": 502
      }
    }
  },
  "Contact": {
    "ContactId": 624,
    "Name": "Ankunding, Altenwerth and Carroll",
    "OrgNr": "1448914",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "at",
    "DirectPhone": "(326)471-6587",
    "AssociateId": 745,
    "CountryId": 280,
    "EmailAddress": "delpha.erdman@bernier.uk",
    "Kananame": "voluptates",
    "EmailAddressName": "demarcus@schmittwehner.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Nola Trantow",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "et",
    "FullName": "Leslie Grimes",
    "IsOwnerContact": true,
    "ActiveErpLinks": 255,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 527
      }
    }
  },
  "Project": {
    "ProjectId": 644,
    "Name": "Padberg, Harris and Rowe",
    "Description": "Public-key intangible support",
    "URL": "http://www.example.com/",
    "Type": "et",
    "AssociateId": 38,
    "AssociateFullName": "Gage Herzog",
    "TypeId": 598,
    "Updated": "2015-04-27T18:25:50.4375956+02:00",
    "StatusId": 245,
    "Status": "consequatur",
    "TextId": 545,
    "PublishTo": "2019-01-26T18:25:50.4375956+01:00",
    "PublishFrom": "2019-04-12T18:25:50.4375956+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "943213",
    "ActiveErpLinks": 487,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 819
      }
    }
  },
  "Date": "2008-05-04T18:25:50.4375956+02:00",
  "ExternalRef": "rerum",
  "Completed": "Completed",
  "ActiveLinks": 269,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Haag-Bauch",
      "Id": 251,
      "Description": "Open-source well-modulated moderator",
      "ExtraInfo": "quod",
      "LinkId": 640,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 116
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Larkin-Beer",
    "SaleDate": "2010-05-09T18:25:50.4375956+02:00",
    "SaleId": 548,
    "Probability": 32,
    "Title": "saepe",
    "Amount": 8631.036,
    "Currency": "id",
    "ProjectName": "Green-Rodriguez",
    "AssociateFullName": "Mikel Watsica",
    "Description": "Compatible even-keeled moratorium",
    "Status": "Lost",
    "WeightedAmount": 9107.404,
    "ProjectId": 560,
    "EarningPercent": 510.842,
    "Earning": 4296.714,
    "ContactId": 444,
    "AssociateId": 198,
    "PersonId": 765,
    "SaleTypeId": 803,
    "SaleTypeName": "Lynch Inc and Sons",
    "PersonFullName": "Raegan Torphy",
    "Completed": "Completed",
    "ActiveErpLinks": 831,
    "NextDueDate": "2021-06-10T18:25:50.4375956+02:00",
    "Number": "931802",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 376
      }
    }
  },
  "SuggestedDocumentId": 925,
  "Snum": 493,
  "UserDefinedFields": {
    "SuperOffice:1": "1944616754",
    "SuperOffice:2": "Carmine Heathcote"
  },
  "ExtraFields": {
    "ExtraFields1": "architecto",
    "ExtraFields2": "sapiente"
  },
  "CustomFields": {
    "CustomFields1": "veniam",
    "CustomFields2": "fugiat"
  },
  "PublishEventDate": "2010-09-19T18:25:50.43863+02:00",
  "PublishTo": "2019-06-03T18:25:50.43863+02:00",
  "PublishFrom": "2016-12-12T18:25:50.43863+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 380,
      "Visibility": "All",
      "DisplayValue": "eos",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 374
        }
      }
    },
    {
      "VisibleId": 380,
      "Visibility": "All",
      "DisplayValue": "eos",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 374
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
      "FieldLength": 95
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```