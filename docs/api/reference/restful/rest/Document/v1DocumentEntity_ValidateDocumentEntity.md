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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 701,
  "UpdatedBy": {
    "AssociateId": 792,
    "Name": "Dickinson, Brown and Aufderhar",
    "PersonId": 893,
    "Rank": 597,
    "Tooltip": "unde",
    "Type": "AnonymousAssociate",
    "GroupIdx": 380,
    "FullName": "Ms. Nyah Haley",
    "FormalName": "Terry-Oberbrunner",
    "Deleted": false,
    "EjUserId": 797,
    "UserName": "Borer-Stokes"
  },
  "CreatedBy": {
    "AssociateId": 304,
    "Name": "Cartwright-Goyette",
    "PersonId": 641,
    "Rank": 18,
    "Tooltip": "accusamus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 594,
    "FullName": "Jacklyn Cole",
    "FormalName": "Jones-Fisher",
    "Deleted": true,
    "EjUserId": 798,
    "UserName": "Baumbach-Shanahan"
  },
  "Attention": "velit",
  "Header": "ratione",
  "Name": "Schmidt, Abshire and Stoltenberg",
  "OurRef": "molestias",
  "YourRef": "cumque",
  "CreatedDate": "2019-12-07T18:25:50.5296241+01:00",
  "UpdatedDate": "1997-07-14T18:25:50.5296241+02:00",
  "Description": "Profound tertiary methodology",
  "DocumentTemplate": {
    "DocumentTemplateId": 957,
    "Name": "Schuster Group",
    "Tooltip": "deleniti",
    "SaveInDb": 938,
    "Filename": "sit",
    "DefaultOref": "qui",
    "RecordType": "Appointment",
    "Deleted": 423,
    "Direction": "Incoming",
    "AutoeventId": 845,
    "QuoteDocType": "ConfirmationLines"
  },
  "Person": {
    "Position": "labore",
    "PersonId": 264,
    "Mrmrs": "dolores",
    "Firstname": "Nicola",
    "Lastname": "Emard",
    "MiddleName": "Altenwerth, Schinner and Bogan",
    "Title": "possimus",
    "Description": "Business-focused intermediate product",
    "Email": "kristopher@johnston.ca",
    "FullName": "Loy Skiles",
    "DirectPhone": "1-544-644-5053 x3417",
    "FormalName": "Spinka Group",
    "CountryId": 394,
    "ContactId": 817,
    "ContactName": "Casper-Paucek",
    "Retired": 681,
    "Rank": 64,
    "ActiveInterests": 840,
    "ContactDepartment": "strategize transparent paradigms",
    "ContactCountryId": 671,
    "ContactOrgNr": "1451122",
    "FaxPhone": "1-051-415-5008",
    "MobilePhone": "805.511.7272",
    "ContactPhone": "773.730.7887 x411",
    "AssociateName": "Waters Inc and Sons",
    "AssociateId": 570,
    "UsePersonAddress": false,
    "ContactFax": "qui",
    "Kanafname": "temporibus",
    "Kanalname": "architecto",
    "Post1": "sint",
    "Post2": "nihil",
    "Post3": "autem",
    "EmailName": "arturo@kozey.us",
    "ContactFullName": "Electa Fahey IV",
    "ActiveErpLinks": 276,
    "TicketPriorityId": 45,
    "SupportLanguageId": 916,
    "SupportAssociateId": 540,
    "CategoryName": "VIP Customer"
  },
  "Associate": {
    "AssociateId": 545,
    "Name": "Kuhn, Heathcote and Dickens",
    "PersonId": 841,
    "Rank": 309,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 478,
    "FullName": "Ms. Emmanuelle Brakus",
    "FormalName": "Fay, Casper and Beahan",
    "Deleted": true,
    "EjUserId": 629,
    "UserName": "Cremin-Ortiz"
  },
  "Contact": {
    "ContactId": 455,
    "Name": "Cole-Goldner",
    "OrgNr": "1279026",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "officiis",
    "DirectPhone": "470.440.4641 x8567",
    "AssociateId": 195,
    "CountryId": 397,
    "EmailAddress": "camron@reinger.info",
    "Kananame": "saepe",
    "EmailAddressName": "melissa.walker@oberbrunner.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Eloy Schoen",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "est",
    "FullName": "Maye Waelchi",
    "IsOwnerContact": false,
    "ActiveErpLinks": 959
  },
  "Project": {
    "ProjectId": 672,
    "Name": "Walker, Greenfelder and Block",
    "Description": "Distributed foreground adapter",
    "URL": "http://www.example.com/",
    "Type": "ratione",
    "AssociateId": 847,
    "AssociateFullName": "Adell Douglas",
    "TypeId": 623,
    "Updated": "1995-06-28T18:25:50.5345976+02:00",
    "StatusId": 385,
    "Status": "repellendus",
    "TextId": 547,
    "PublishTo": "2006-12-01T18:25:50.5345976+01:00",
    "PublishFrom": "2006-01-01T18:25:50.5345976+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "943829",
    "ActiveErpLinks": 887
  },
  "Date": "2005-10-21T18:25:50.5345976+02:00",
  "ExternalRef": "perspiciatis",
  "Completed": "Completed",
  "ActiveLinks": 27,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Shanahan Inc and Sons",
      "Id": 106,
      "Description": "Pre-emptive full-range time-frame",
      "ExtraInfo": "occaecati",
      "LinkId": 622
    },
    {
      "EntityName": "Shanahan Inc and Sons",
      "Id": 106,
      "Description": "Pre-emptive full-range time-frame",
      "ExtraInfo": "occaecati",
      "LinkId": 622
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Wolf LLC",
    "SaleDate": "2013-10-01T18:25:50.5345976+02:00",
    "SaleId": 608,
    "Probability": 97,
    "Title": "sunt",
    "Amount": 7866.34,
    "Currency": "ut",
    "ProjectName": "Borer-Heaney",
    "AssociateFullName": "Mrs. Clementine Mitchell",
    "Description": "Streamlined homogeneous adapter",
    "Status": "Lost",
    "WeightedAmount": 26780.03,
    "ProjectId": 58,
    "EarningPercent": 5804.168,
    "Earning": 1485.5159999999999,
    "ContactId": 519,
    "AssociateId": 338,
    "PersonId": 968,
    "SaleTypeId": 497,
    "SaleTypeName": "Balistreri Group",
    "PersonFullName": "Gail Von V",
    "Completed": "Completed",
    "ActiveErpLinks": 983,
    "NextDueDate": "2008-12-13T18:25:50.5345976+01:00",
    "Number": "1367188"
  },
  "SuggestedDocumentId": 775,
  "Snum": 857,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "eos"
  },
  "CustomFields": {
    "CustomFields1": "hic",
    "CustomFields2": "iure"
  },
  "PublishEventDate": "2018-10-28T18:25:50.5345976+01:00",
  "PublishTo": "2006-08-03T18:25:50.5345976+02:00",
  "PublishFrom": "2006-01-24T18:25:50.5345976+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 608,
      "Visibility": "All",
      "DisplayValue": "voluptatem"
    },
    {
      "VisibleId": 608,
      "Visibility": "All",
      "DisplayValue": "voluptatem"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "est",
  "2": "commodi"
}
```