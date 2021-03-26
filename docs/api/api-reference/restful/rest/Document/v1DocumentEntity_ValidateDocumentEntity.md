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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 901,
  "UpdatedBy": {
    "AssociateId": 218,
    "Name": "Bauch-Dickens",
    "PersonId": 269,
    "Rank": 450,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 836,
    "FullName": "Ericka Lemke",
    "FormalName": "Thompson-Jast",
    "Deleted": false,
    "EjUserId": 422,
    "UserName": "King-Daugherty"
  },
  "CreatedBy": {
    "AssociateId": 316,
    "Name": "Bins-Zboncak",
    "PersonId": 389,
    "Rank": 710,
    "Tooltip": "provident",
    "Type": "AnonymousAssociate",
    "GroupIdx": 133,
    "FullName": "Yessenia Schultz",
    "FormalName": "Trantow, Mitchell and O'Hara",
    "Deleted": true,
    "EjUserId": 115,
    "UserName": "Gibson, Torp and Simonis"
  },
  "Attention": "pariatur",
  "Header": "officia",
  "Name": "Keeling Inc and Sons",
  "OurRef": "impedit",
  "YourRef": "quisquam",
  "CreatedDate": "1996-07-17T09:40:59.186663+02:00",
  "UpdatedDate": "1998-02-13T09:40:59.186663+01:00",
  "Description": "Versatile cohesive structure",
  "DocumentTemplate": {
    "DocumentTemplateId": 741,
    "Name": "Hilpert Inc and Sons",
    "Tooltip": "eligendi",
    "SaveInDb": 338,
    "Filename": "est",
    "DefaultOref": "aut",
    "RecordType": "Appointment",
    "Deleted": 181,
    "Direction": "Incoming",
    "AutoeventId": 636,
    "QuoteDocType": "ConfirmationLines"
  },
  "Person": {
    "Position": "maxime",
    "PersonId": 800,
    "Mrmrs": "quaerat",
    "Firstname": "Billy",
    "Lastname": "Kutch",
    "MiddleName": "Schuppe LLC",
    "Title": "deleniti",
    "Description": "Compatible systemic analyzer",
    "Email": "jack.hintz@townemedhurst.com",
    "FullName": "Jonathon Jaskolski",
    "DirectPhone": "051.427.7401 x05562",
    "FormalName": "Gutmann-Morissette",
    "CountryId": 858,
    "ContactId": 627,
    "ContactName": "Wehner, Cummings and Ratke",
    "Retired": 820,
    "Rank": 81,
    "ActiveInterests": 998,
    "ContactDepartment": "",
    "ContactCountryId": 838,
    "ContactOrgNr": "834501",
    "FaxPhone": "714-467-7523 x8436",
    "MobilePhone": "851.785.7204 x3617",
    "ContactPhone": "548.364.1764 x7233",
    "AssociateName": "Predovic, Hamill and Block",
    "AssociateId": 329,
    "UsePersonAddress": true,
    "ContactFax": "quo",
    "Kanafname": "magnam",
    "Kanalname": "et",
    "Post1": "vel",
    "Post2": "enim",
    "Post3": "facilis",
    "EmailName": "jordan_koss@williamsonwisoky.us",
    "ContactFullName": "Raoul Hessel",
    "ActiveErpLinks": 364,
    "TicketPriorityId": 170,
    "SupportLanguageId": 407,
    "SupportAssociateId": 450,
    "CategoryName": "VIP Customer"
  },
  "Associate": {
    "AssociateId": 893,
    "Name": "Ruecker Inc and Sons",
    "PersonId": 658,
    "Rank": 851,
    "Tooltip": "commodi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 686,
    "FullName": "Jamison Quigley",
    "FormalName": "Senger-Schiller",
    "Deleted": true,
    "EjUserId": 353,
    "UserName": "Lebsack Group"
  },
  "Contact": {
    "ContactId": 591,
    "Name": "Davis-Herzog",
    "OrgNr": "173962",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ut",
    "DirectPhone": "055-022-2477 x177",
    "AssociateId": 817,
    "CountryId": 493,
    "EmailAddress": "margot@aufderhar.co.uk",
    "Kananame": "et",
    "EmailAddressName": "laurianne@raynorlindgren.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Nova Marvin",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "dolorum",
    "FullName": "Aubrey McKenzie",
    "IsOwnerContact": false,
    "ActiveErpLinks": 545
  },
  "Project": {
    "ProjectId": 223,
    "Name": "Herzog, Nolan and Osinski",
    "Description": "Reverse-engineered object-oriented framework",
    "URL": "http://www.example.com/",
    "Type": "at",
    "AssociateId": 388,
    "AssociateFullName": "Koby Kerluke",
    "TypeId": 424,
    "Updated": "2019-05-20T09:40:59.1896631+02:00",
    "StatusId": 682,
    "Status": "cumque",
    "TextId": 675,
    "PublishTo": "2002-12-30T09:40:59.1896631+01:00",
    "PublishFrom": "2007-03-20T09:40:59.1896631+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "308765",
    "ActiveErpLinks": 386
  },
  "Date": "2014-01-22T09:40:59.1896631+01:00",
  "ExternalRef": "adipisci",
  "Completed": "Completed",
  "ActiveLinks": 169,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Krajcik-Pfeffer",
      "Id": 112,
      "Description": "Profound contextually-based time-frame",
      "ExtraInfo": "accusamus",
      "LinkId": 218
    },
    {
      "EntityName": "Krajcik-Pfeffer",
      "Id": 112,
      "Description": "Profound contextually-based time-frame",
      "ExtraInfo": "accusamus",
      "LinkId": 218
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Jacobs, Frami and Dibbert",
    "SaleDate": "2017-07-04T09:40:59.1896631+02:00",
    "SaleId": 830,
    "Probability": 553,
    "Title": "aut",
    "Amount": 27836.188,
    "Currency": "debitis",
    "ProjectName": "Zboncak, Hermann and Hayes",
    "AssociateFullName": "Jensen Dickens",
    "Description": "De-engineered directional open architecture",
    "Status": "Lost",
    "WeightedAmount": 29710.32,
    "ProjectId": 103,
    "EarningPercent": 23448.588,
    "Earning": 9790.616,
    "ContactId": 414,
    "AssociateId": 447,
    "PersonId": 32,
    "SaleTypeId": 153,
    "SaleTypeName": "King, Olson and Emmerich",
    "PersonFullName": "Andre Donnelly",
    "Completed": "Completed",
    "ActiveErpLinks": 710,
    "NextDueDate": "2003-07-31T09:40:59.1906628+02:00",
    "Number": "425810"
  },
  "SuggestedDocumentId": 199,
  "Snum": 502,
  "UserDefinedFields": {
    "SuperOffice:1": "2105880956",
    "SuperOffice:2": "Marcelo Beer"
  },
  "ExtraFields": {
    "ExtraFields1": "quae",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "ullam",
    "CustomFields2": "iure"
  },
  "PublishEventDate": "2007-02-11T09:40:59.1906628+01:00",
  "PublishTo": "2017-06-01T09:40:59.1906628+02:00",
  "PublishFrom": "1999-11-20T09:40:59.1906628+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 738,
      "Visibility": "All",
      "DisplayValue": "quae"
    },
    {
      "VisibleId": 738,
      "Visibility": "All",
      "DisplayValue": "quae"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "deleniti",
  "2": "et"
}
```