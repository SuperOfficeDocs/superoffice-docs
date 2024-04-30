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
| DocumentTemplate | DocumentTemplate | The template type of the document.  Use MDO List name "doctmpl" to get list items. |
| Person | Person | A document may also be connected to a person; this must be a contact person registered on the current company. This does not mean however that a person is required.  Use MDO List name "person" to get list items. |
| Associate | Associate | The owner of the document - the associate whose checklist the document is in.  Use MDO List name "associate" to get list items. |
| Contact | Contact | The contact associated with the document. It may also be null if no contact is associated with the document.  Use MDO List name "contact" to get list items. |
| Project | Project | A document may also be connected to a project, so you see the document both on the company card, and on the project card. This does not mean however that a project is required.  Use MDO List name "project" to get list items. |
| Date | date-time | date + start time planned |
| ExternalRef | string | External reference for document plugin to resolve document identity (Notes ID, e-mail message ID, whatever) |
| Completed | string | Document Completed state. This is the part of the Status property. |
| ActiveLinks | int32 | Number of active links to sale, document, appointment. |
| Type | string | Is this a normal document or a mail-merge or report? |
| Links | array | List of all elements linked to the document. |
| LockSemantics | string |  |
| Sale | Sale | A document may also be connected to a sale, so you see the document on the company card, on the project card and on the sale card. This does not mean however that a sale is required. May be null.  Use MDO List name "sale" to get list items. |
| SuggestedDocumentId | int32 | Suggested guide item that this document is an instance of (Note: NOT valid for appointments, they have their own link) |
| Snum | int32 | The sequence number allocated from refcount on used template when creating the document |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.DocumentEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.DocumentEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.DocumentEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
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
  "DocumentId": 357,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Attention": "pariatur",
  "Header": "facere",
  "Name": "Gerhold Group",
  "OurRef": "totam",
  "YourRef": "odit",
  "CreatedDate": "2015-06-28T11:44:41.882801+02:00",
  "UpdatedDate": "2009-03-19T11:44:41.882801+01:00",
  "Description": "Balanced 24 hour solution",
  "DocumentTemplate": null,
  "Person": null,
  "Associate": null,
  "Contact": null,
  "Project": null,
  "Date": "2013-08-10T11:44:41.882801+02:00",
  "ExternalRef": "id",
  "Completed": "Completed",
  "ActiveLinks": 497,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Hegmann Inc and Sons",
      "Id": 947,
      "Description": "Decentralized eco-centric collaboration",
      "ExtraInfo": "eum",
      "LinkId": 115
    },
    {
      "EntityName": "Hegmann Inc and Sons",
      "Id": 947,
      "Description": "Decentralized eco-centric collaboration",
      "ExtraInfo": "eum",
      "LinkId": 115
    }
  ],
  "LockSemantics": "Locking",
  "Sale": null,
  "SuggestedDocumentId": 152,
  "Snum": 266,
  "UserDefinedFields": {
    "SuperOffice:1": "Tessie Carolyn Dicki V",
    "SuperOffice:2": "229724451"
  },
  "ExtraFields": {
    "ExtraFields1": "fuga",
    "ExtraFields2": "provident"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "ut"
  },
  "PublishEventDate": "2022-12-13T11:44:41.882801+01:00",
  "PublishTo": "2019-08-26T11:44:41.882801+02:00",
  "PublishFrom": "2020-06-25T11:44:41.882801+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 946,
      "Visibility": "All",
      "DisplayValue": "dolor"
    },
    {
      "VisibleId": 946,
      "Visibility": "All",
      "DisplayValue": "dolor"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 913,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Attention": "rerum",
  "Header": "necessitatibus",
  "Name": "Blanda Group",
  "OurRef": "in",
  "YourRef": "repellendus",
  "CreatedDate": "2019-02-09T11:44:41.8984219+01:00",
  "UpdatedDate": "2016-03-14T11:44:41.8984219+01:00",
  "Description": "Re-engineered dynamic software",
  "DocumentTemplate": null,
  "Person": null,
  "Associate": null,
  "Contact": null,
  "Project": null,
  "Date": "2012-09-01T11:44:41.8984219+02:00",
  "ExternalRef": "assumenda",
  "Completed": "Completed",
  "ActiveLinks": 745,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Quigley, O'Reilly and McKenzie",
      "Id": 161,
      "Description": "Advanced background solution",
      "ExtraInfo": "voluptatem",
      "LinkId": 799,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 696
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": null,
  "SuggestedDocumentId": 964,
  "Snum": 751,
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Nikki Franecki V",
    "SuperOffice:2": "Nelda McLaughlin"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "porro"
  },
  "CustomFields": {
    "CustomFields1": "occaecati",
    "CustomFields2": "cupiditate"
  },
  "PublishEventDate": "2016-09-19T11:44:41.8984219+02:00",
  "PublishTo": "2017-11-16T11:44:41.8984219+01:00",
  "PublishFrom": "2016-09-10T11:44:41.8984219+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 584,
      "Visibility": "All",
      "DisplayValue": "dolorum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 202
        }
      }
    },
    {
      "VisibleId": 584,
      "Visibility": "All",
      "DisplayValue": "dolorum",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 202
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 703
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```