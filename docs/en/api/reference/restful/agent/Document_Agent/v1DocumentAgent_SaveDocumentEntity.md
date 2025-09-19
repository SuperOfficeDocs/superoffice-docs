---
title: POST Agents/Document/SaveDocumentEntity
uid: v1DocumentAgent_SaveDocumentEntity
generated: true
content_type: reference
---

# POST Agents/Document/SaveDocumentEntity

```http
POST /api/v1/Agents/Document/SaveDocumentEntity
```

Updates the existing DocumentEntity or creates a new DocumentEntity if the id parameter is 0.


Save the document entity. If the entity already exists and the file name of the incoming entity is different from the existing one, a corresponding renaming of the physical document will be attempted. This may cause an amended file name to be substituted into the document entity, since a document plugin may have aribitrary rules on file names and collisions. Clients should always inspect the return value from this call and not assume that what they sent for saving is the final truth.







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

The DocumentEntity that is saved 

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

## Sample request

```http!
POST /api/v1/Agents/Document/SaveDocumentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 735,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Attention": "qui",
  "Header": "vel",
  "Name": "Prosacco, Heaney and Grant",
  "OurRef": "minima",
  "YourRef": "sequi",
  "CreatedDate": "1999-03-11T03:41:53.402614+01:00",
  "UpdatedDate": "2001-06-22T03:41:53.402614+02:00",
  "Description": "Cloned explicit firmware",
  "DocumentTemplate": null,
  "Person": null,
  "Associate": null,
  "Contact": null,
  "Project": null,
  "Date": "2013-12-05T03:41:53.402614+01:00",
  "ExternalRef": "perspiciatis",
  "Completed": "Completed",
  "ActiveLinks": 66,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Cummings-Mayert",
      "Id": 231,
      "Description": "Profit-focused incremental paradigm",
      "ExtraInfo": "voluptatem",
      "LinkId": 172
    },
    {
      "EntityName": "Cummings-Mayert",
      "Id": 231,
      "Description": "Profit-focused incremental paradigm",
      "ExtraInfo": "voluptatem",
      "LinkId": 172
    }
  ],
  "LockSemantics": "Locking",
  "Sale": null,
  "SuggestedDocumentId": 989,
  "Snum": 208,
  "UserDefinedFields": {
    "SuperOffice:1": "624676987",
    "SuperOffice:2": "1922080801"
  },
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "aspernatur"
  },
  "CustomFields": {
    "CustomFields1": "nostrum",
    "CustomFields2": "explicabo"
  },
  "PublishEventDate": "2018-05-25T03:41:53.402614+02:00",
  "PublishTo": "2005-08-21T03:41:53.402614+02:00",
  "PublishFrom": "2024-02-07T03:41:53.402614+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 321,
      "Visibility": "All",
      "DisplayValue": "eligendi"
    },
    {
      "VisibleId": 321,
      "Visibility": "All",
      "DisplayValue": "eligendi"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 245,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Attention": "quos",
  "Header": "natus",
  "Name": "Bernhard Inc and Sons",
  "OurRef": "voluptas",
  "YourRef": "saepe",
  "CreatedDate": "2000-04-24T03:41:53.402614+02:00",
  "UpdatedDate": "2007-05-11T03:41:53.402614+02:00",
  "Description": "Organized clear-thinking function",
  "DocumentTemplate": null,
  "Person": null,
  "Associate": null,
  "Contact": null,
  "Project": null,
  "Date": "2009-04-02T03:41:53.402614+02:00",
  "ExternalRef": "suscipit",
  "Completed": "Completed",
  "ActiveLinks": 408,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Wiza-Bode",
      "Id": 646,
      "Description": "Synchronised tangible process improvement",
      "ExtraInfo": "quam",
      "LinkId": 155,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 844
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": null,
  "SuggestedDocumentId": 887,
  "Snum": 470,
  "UserDefinedFields": {
    "SuperOffice:1": "Adah Torp",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "vel"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "eum"
  },
  "PublishEventDate": "2011-05-10T03:41:53.402614+02:00",
  "PublishTo": "2005-09-17T03:41:53.402614+02:00",
  "PublishFrom": "2015-05-19T03:41:53.402614+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 22,
      "Visibility": "All",
      "DisplayValue": "suscipit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 40
        }
      }
    },
    {
      "VisibleId": 22,
      "Visibility": "All",
      "DisplayValue": "suscipit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 40
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 838
    }
  }
}
```