---
title: POST Document
uid: v1DocumentEntity_PostDocumentEntity
generated: true
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
| DocumentId | Integer | Primary key |
| UpdatedBy | Associate | The person that last updated the appointment. |
| CreatedBy | Associate | The person that first created the document. The property is read-only. |
| Attention | String | Attention/salutation |
| Header | String | Visible document name |
| Name | String | File name |
| OurRef | String | Our reference, searchable field from freetext search |
| YourRef | String | Your reference |
| CreatedDate | String | Registered when  in UTC. |
| UpdatedDate | String | Last updated when  in UTC. |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| DocumentTemplate | DocumentTemplate | The template type of the document.  <para>Use MDO List name "doctmpl" to get list items.</para> |
| Person | Person | A document may also be connected to a person; this must be a contact person registered on the current company. This does not mean however that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Associate | Associate | The owner of the document - the associate whose checklist the document is in.  <para>Use MDO List name "associate" to get list items.</para> |
| Contact | Contact | The contact associated with the document. It may also be null if no contact is associated with the document.  <para>Use MDO List name "contact" to get list items.</para> |
| Project | Project | A document may also be connected to a project, so you see the document both on the company card, and on the project card. This does not mean however that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| Date | String | date + start time planned |
| ExternalRef | String | External reference for document plugin to resolve document identity (Notes ID, e-mail message ID, whatever) |
| Completed | String | Document Completed state. This is the part of the Status property. |
| ActiveLinks | Integer | Number of active links to sale, document, appointment. |
| Type | String | Is this a normal document or a mail-merge or report? |
| Links | Array | List of all elements linked to the document. |
| LockSemantics | String |  |
| Sale | Sale | A document may also be connected to a sale, so you see the document on the company card, on the project card and on the sale card. This does not mean however that a sale is required. May be null.  <para>Use MDO List name "sale" to get list items.</para> |
| SuggestedDocumentId | Integer | Suggested guide item that this document is an instance of (Note: NOT valid for appointments, they have their own link) |
| Snum | Integer | The sequence number allocated from refcount on used template when creating the document |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.DocumentEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.DocumentEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.DocumentEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.DocumentEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |
| VisibleFor | Array | The set of users or groups the record is visible for |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: DocumentEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | int32 | Primary key |
| UpdatedBy | Associate | The person that last updated the appointment. |
| CreatedBy | Associate | The person that first created the document. The property is read-only. |
| Attention | string | Attention/salutation |
| Header | string | Visible document name |
| Name | string | File name |
| OurRef | string | Our reference, searchable field from freetext search |
| YourRef | string | Your reference |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| DocumentTemplate | DocumentTemplate | The template type of the document.  <para>Use MDO List name "doctmpl" to get list items.</para> |
| Person | Person | A document may also be connected to a person; this must be a contact person registered on the current company. This does not mean however that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Associate | Associate | The owner of the document - the associate whose checklist the document is in.  <para>Use MDO List name "associate" to get list items.</para> |
| Contact | Contact | The contact associated with the document. It may also be null if no contact is associated with the document.  <para>Use MDO List name "contact" to get list items.</para> |
| Project | Project | A document may also be connected to a project, so you see the document both on the company card, and on the project card. This does not mean however that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| Date | date-time | date + start time planned |
| ExternalRef | string | External reference for document plugin to resolve document identity (Notes ID, e-mail message ID, whatever) |
| Completed | string | Document Completed state. This is the part of the Status property. |
| ActiveLinks | int32 | Number of active links to sale, document, appointment. |
| Type | string | Is this a normal document or a mail-merge or report? |
| Links | array | List of all elements linked to the document. |
| LockSemantics | string |  |
| Sale | Sale | A document may also be connected to a sale, so you see the document on the company card, on the project card and on the sale card. This does not mean however that a sale is required. May be null.  <para>Use MDO List name "sale" to get list items.</para> |
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Document
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 589,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Attention": "et",
  "Header": "voluptas",
  "Name": "Gibson Group",
  "OurRef": "minima",
  "YourRef": "consectetur",
  "CreatedDate": "2021-02-04T23:04:04.0900181+01:00",
  "UpdatedDate": "2020-09-30T23:04:04.0900181+02:00",
  "Description": "Advanced cohesive matrix",
  "DocumentTemplate": null,
  "Person": null,
  "Associate": null,
  "Contact": null,
  "Project": null,
  "Date": "2002-09-20T23:04:04.0945201+02:00",
  "ExternalRef": "voluptatum",
  "Completed": "Completed",
  "ActiveLinks": 553,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Boehm, Volkman and Mraz",
      "Id": 44,
      "Description": "Profit-focused multimedia array",
      "ExtraInfo": "sapiente",
      "LinkId": 186
    },
    {
      "EntityName": "Boehm, Volkman and Mraz",
      "Id": 44,
      "Description": "Profit-focused multimedia array",
      "ExtraInfo": "sapiente",
      "LinkId": 186
    }
  ],
  "LockSemantics": "Locking",
  "Sale": null,
  "SuggestedDocumentId": 110,
  "Snum": 570,
  "UserDefinedFields": {
    "SuperOffice:1": "Concepcion Morar",
    "SuperOffice:2": "Cathy Maggio"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptas",
    "ExtraFields2": "quasi"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "architecto"
  },
  "PublishEventDate": "2015-04-01T23:04:04.0955199+02:00",
  "PublishTo": "2012-09-20T23:04:04.0955199+02:00",
  "PublishFrom": "2002-06-23T23:04:04.0955199+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 287,
      "Visibility": "All",
      "DisplayValue": "possimus"
    },
    {
      "VisibleId": 287,
      "Visibility": "All",
      "DisplayValue": "possimus"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 846,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Attention": "nemo",
  "Header": "quia",
  "Name": "Botsford-Wuckert",
  "OurRef": "ipsam",
  "YourRef": "voluptas",
  "CreatedDate": "2009-03-18T23:04:04.1020183+01:00",
  "UpdatedDate": "2003-09-20T23:04:04.1020183+02:00",
  "Description": "Integrated demand-driven project",
  "DocumentTemplate": null,
  "Person": null,
  "Associate": null,
  "Contact": null,
  "Project": null,
  "Date": "2001-10-05T23:04:04.1060156+02:00",
  "ExternalRef": "dignissimos",
  "Completed": "Completed",
  "ActiveLinks": 97,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Kessler Group",
      "Id": 638,
      "Description": "Seamless radical orchestration",
      "ExtraInfo": "laboriosam",
      "LinkId": 784,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 796
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": null,
  "SuggestedDocumentId": 640,
  "Snum": 759,
  "UserDefinedFields": {
    "SuperOffice:1": "Rosendo Sabryna Adams I",
    "SuperOffice:2": "1043772796"
  },
  "ExtraFields": {
    "ExtraFields1": "reiciendis",
    "ExtraFields2": "ullam"
  },
  "CustomFields": {
    "CustomFields1": "nam",
    "CustomFields2": "laboriosam"
  },
  "PublishEventDate": "2014-12-30T23:04:04.1070181+01:00",
  "PublishTo": "2013-12-26T23:04:04.1070181+01:00",
  "PublishFrom": "2010-09-09T23:04:04.1070181+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 771,
      "Visibility": "All",
      "DisplayValue": "non",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 181
        }
      }
    },
    {
      "VisibleId": 771,
      "Visibility": "All",
      "DisplayValue": "non",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 181
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 335
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```