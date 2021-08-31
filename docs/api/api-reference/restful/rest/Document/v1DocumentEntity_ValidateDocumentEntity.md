---
title: POST Document/Validate
id: v1DocumentEntity_ValidateDocumentEntity
---

# POST Document/Validate

```http
POST /api/v1/Document/Validate
```

Check that entity is ready for saving, return error messages by field.








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

## Request Body: documentEntity  

Entity to be checked for errors. 

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



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
POST /api/v1/Document/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 23,
  "UpdatedBy": {
    "AssociateId": 300,
    "Name": "Romaguera-Spinka",
    "PersonId": 480,
    "Rank": 346,
    "Tooltip": "ipsam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 706,
    "FullName": "Kiarra West",
    "FormalName": "Kiehn Group",
    "Deleted": true,
    "EjUserId": 227,
    "UserName": "Erdman, Funk and Bins"
  },
  "CreatedBy": {
    "AssociateId": 51,
    "Name": "Gottlieb, Graham and Gislason",
    "PersonId": 395,
    "Rank": 341,
    "Tooltip": "ad",
    "Type": "AnonymousAssociate",
    "GroupIdx": 90,
    "FullName": "Millie Abernathy",
    "FormalName": "Hamill, Jacobi and Gerlach",
    "Deleted": true,
    "EjUserId": 853,
    "UserName": "McClure-Crist"
  },
  "Attention": "assumenda",
  "Header": "voluptas",
  "Name": "Daniel, Kuhn and Spinka",
  "OurRef": "voluptas",
  "YourRef": "mollitia",
  "CreatedDate": "1999-09-10T15:05:42.1656355+02:00",
  "UpdatedDate": "2006-04-08T15:05:42.1656355+02:00",
  "Description": "Distributed assymetric knowledge user",
  "DocumentTemplate": {
    "DocumentTemplateId": 978,
    "Name": "Keebler-Sporer",
    "Tooltip": "culpa",
    "SaveInDb": 572,
    "Filename": "rerum",
    "DefaultOref": "dolorem",
    "RecordType": "Appointment",
    "Deleted": 772,
    "Direction": "Incoming",
    "AutoeventId": 459,
    "QuoteDocType": "ConfirmationLines"
  },
  "Person": {
    "Position": "quia",
    "PersonId": 520,
    "Mrmrs": "et",
    "Firstname": "Jaren",
    "Lastname": "Hoppe",
    "MiddleName": "Berge, Towne and Mills",
    "Title": "voluptate",
    "Description": "Versatile radical concept",
    "Email": "stanton@farrell.uk",
    "FullName": "Dasia Hammes DVM",
    "DirectPhone": "1-633-361-0265",
    "FormalName": "Kutch, Abbott and O'Conner",
    "CountryId": 784,
    "ContactId": 598,
    "ContactName": "Blick, Bartoletti and Wyman",
    "Retired": 95,
    "Rank": 620,
    "ActiveInterests": 283,
    "ContactDepartment": "",
    "ContactCountryId": 531,
    "ContactOrgNr": "546030",
    "FaxPhone": "(721)240-1642 x628",
    "MobilePhone": "1-448-324-4711 x282",
    "ContactPhone": "057-474-3335",
    "AssociateName": "Wehner, Lesch and Brakus",
    "AssociateId": 139,
    "UsePersonAddress": false,
    "ContactFax": "facere",
    "Kanafname": "in",
    "Kanalname": "qui",
    "Post1": "nesciunt",
    "Post2": "illum",
    "Post3": "voluptatibus",
    "EmailName": "andreanne@mraz.co.uk",
    "ContactFullName": "Stephen Jaskolski",
    "ActiveErpLinks": 186,
    "TicketPriorityId": 468,
    "SupportLanguageId": 436,
    "SupportAssociateId": 137,
    "CategoryName": "VIP Customer"
  },
  "Associate": {
    "AssociateId": 193,
    "Name": "Hickle LLC",
    "PersonId": 289,
    "Rank": 964,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 809,
    "FullName": "Suzanne O'Keefe",
    "FormalName": "Hilpert, Ondricka and Pacocha",
    "Deleted": false,
    "EjUserId": 997,
    "UserName": "Jacobson-Ernser"
  },
  "Contact": {
    "ContactId": 348,
    "Name": "Hane-Braun",
    "OrgNr": "995895",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dolorem",
    "DirectPhone": "(538)546-6742",
    "AssociateId": 647,
    "CountryId": 253,
    "EmailAddress": "micah@bradtke.com",
    "Kananame": "est",
    "EmailAddressName": "sarai@wisoky.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jena Turcotte IV",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "rerum",
    "FullName": "Elwyn Emard Jr.",
    "IsOwnerContact": false,
    "ActiveErpLinks": 138
  },
  "Project": {
    "ProjectId": 940,
    "Name": "Connelly, Bartell and Cronin",
    "Description": "Organized asynchronous array",
    "URL": "http://www.example.com/",
    "Type": "molestiae",
    "AssociateId": 373,
    "AssociateFullName": "Zita Mertz",
    "TypeId": 521,
    "Updated": "1999-04-29T15:05:42.168635+02:00",
    "StatusId": 725,
    "Status": "molestiae",
    "TextId": 778,
    "PublishTo": "2001-01-06T15:05:42.168635+01:00",
    "PublishFrom": "2004-03-14T15:05:42.168635+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "996093",
    "ActiveErpLinks": 744
  },
  "Date": "2007-11-26T15:05:42.168635+01:00",
  "ExternalRef": "labore",
  "Completed": "Completed",
  "ActiveLinks": 965,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Bradtke-Schimmel",
      "Id": 828,
      "Description": "Fundamental stable local area network",
      "ExtraInfo": "impedit",
      "LinkId": 666
    },
    {
      "EntityName": "Bradtke-Schimmel",
      "Id": 828,
      "Description": "Fundamental stable local area network",
      "ExtraInfo": "impedit",
      "LinkId": 666
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Carter LLC",
    "SaleDate": "2007-11-18T15:05:42.168635+01:00",
    "SaleId": 548,
    "Probability": 122,
    "Title": "officia",
    "Amount": 15986.534,
    "Currency": "sit",
    "ProjectName": "Gusikowski-Grant",
    "AssociateFullName": "Grayce Jewess",
    "Description": "Centralized homogeneous strategy",
    "Status": "Lost",
    "WeightedAmount": 30164.75,
    "ProjectId": 342,
    "EarningPercent": 28309.422,
    "Earning": 28093.176,
    "ContactId": 803,
    "AssociateId": 694,
    "PersonId": 487,
    "SaleTypeId": 885,
    "SaleTypeName": "Lesch Inc and Sons",
    "PersonFullName": "Mr. Dortha Frami",
    "Completed": "Completed",
    "ActiveErpLinks": 241,
    "NextDueDate": "1995-06-29T15:05:42.168635+02:00",
    "Number": "1298797"
  },
  "SuggestedDocumentId": 814,
  "Snum": 454,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1154972041"
  },
  "ExtraFields": {
    "ExtraFields1": "odio",
    "ExtraFields2": "ipsam"
  },
  "CustomFields": {
    "CustomFields1": "quibusdam",
    "CustomFields2": "exercitationem"
  },
  "PublishEventDate": "2000-05-15T15:05:42.168635+02:00",
  "PublishTo": "2002-12-30T15:05:42.168635+01:00",
  "PublishFrom": "2005-01-16T15:05:42.168635+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 429,
      "Visibility": "All",
      "DisplayValue": "autem"
    },
    {
      "VisibleId": 429,
      "Visibility": "All",
      "DisplayValue": "autem"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "provident",
  "2": "dolor"
}
```