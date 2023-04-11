---
title: POST Agents/Document/SaveDocumentEntity
uid: v1DocumentAgent_SaveDocumentEntity
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

### Response body: DocumentEntity

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

## Sample request

```http!
POST /api/v1/Agents/Document/SaveDocumentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 201,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Attention": "aliquam",
  "Header": "repellendus",
  "Name": "Kessler-Koepp",
  "OurRef": "error",
  "YourRef": "et",
  "CreatedDate": "2006-09-02T15:29:21.5147802+02:00",
  "UpdatedDate": "1999-04-14T15:29:21.5147802+02:00",
  "Description": "Face to face fault-tolerant encryption",
  "DocumentTemplate": null,
  "Person": null,
  "Associate": null,
  "Contact": null,
  "Project": null,
  "Date": "2017-05-29T15:29:21.5197788+02:00",
  "ExternalRef": "ab",
  "Completed": "Completed",
  "ActiveLinks": 845,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Wolf Inc and Sons",
      "Id": 92,
      "Description": "Intuitive web-enabled secured line",
      "ExtraInfo": "ex",
      "LinkId": 695
    },
    {
      "EntityName": "Wolf Inc and Sons",
      "Id": 92,
      "Description": "Intuitive web-enabled secured line",
      "ExtraInfo": "ex",
      "LinkId": 695
    }
  ],
  "LockSemantics": "Locking",
  "Sale": null,
  "SuggestedDocumentId": 671,
  "Snum": 839,
  "UserDefinedFields": {
    "SuperOffice:1": "1005536265",
    "SuperOffice:2": "212234537"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "illum"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "et"
  },
  "PublishEventDate": "1996-11-06T15:29:21.5202787+01:00",
  "PublishTo": "2021-10-11T15:29:21.5202787+02:00",
  "PublishFrom": "2017-12-10T15:29:21.5202787+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 303,
      "Visibility": "All",
      "DisplayValue": "illum"
    },
    {
      "VisibleId": 303,
      "Visibility": "All",
      "DisplayValue": "illum"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 184,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Attention": "qui",
  "Header": "et",
  "Name": "Collier LLC",
  "OurRef": "nostrum",
  "YourRef": "sunt",
  "CreatedDate": "2005-09-04T15:29:21.5267794+02:00",
  "UpdatedDate": "2014-09-30T15:29:21.5267794+02:00",
  "Description": "Right-sized multi-state forecast",
  "DocumentTemplate": null,
  "Person": null,
  "Associate": null,
  "Contact": null,
  "Project": null,
  "Date": "2006-01-24T15:29:21.5302796+01:00",
  "ExternalRef": "voluptatibus",
  "Completed": "Completed",
  "ActiveLinks": 456,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Mann-Schroeder",
      "Id": 503,
      "Description": "Object-based object-oriented info-mediaries",
      "ExtraInfo": "voluptatem",
      "LinkId": 678,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 377
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": null,
  "SuggestedDocumentId": 487,
  "Snum": 886,
  "UserDefinedFields": {
    "SuperOffice:1": "Nicholaus Frida Wilkinson Sr.",
    "SuperOffice:2": "Gregoria Nels Hyatt Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "voluptates",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "ex",
    "CustomFields2": "autem"
  },
  "PublishEventDate": "2001-09-08T15:29:21.5312789+02:00",
  "PublishTo": "2010-03-02T15:29:21.5312789+01:00",
  "PublishFrom": "2008-01-28T15:29:21.5312789+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 868,
      "Visibility": "All",
      "DisplayValue": "non",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    },
    {
      "VisibleId": 868,
      "Visibility": "All",
      "DisplayValue": "non",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 143
    }
  }
}
```