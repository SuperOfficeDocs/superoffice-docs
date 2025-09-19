---
title: POST Agents/Document/CreateDefaultDocumentEntity
uid: v1DocumentAgent_CreateDefaultDocumentEntity
generated: true
content_type: reference
---

# POST Agents/Document/CreateDefaultDocumentEntity

```http
POST /api/v1/Agents/Document/CreateDefaultDocumentEntity
```

Loading default values into a new DocumentEntity.








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Document/CreateDefaultDocumentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 887,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Attention": "odio",
  "Header": "omnis",
  "Name": "Flatley, Hoeger and Donnelly",
  "OurRef": "doloremque",
  "YourRef": "distinctio",
  "CreatedDate": "2016-05-03T03:41:53.3869896+02:00",
  "UpdatedDate": "2005-08-29T03:41:53.3869896+02:00",
  "Description": "Multi-lateral bi-directional benchmark",
  "DocumentTemplate": null,
  "Person": null,
  "Associate": null,
  "Contact": null,
  "Project": null,
  "Date": "1998-09-10T03:41:53.402614+02:00",
  "ExternalRef": "nostrum",
  "Completed": "Completed",
  "ActiveLinks": 114,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "O'Keefe, Turcotte and Lockman",
      "Id": 621,
      "Description": "Future-proofed multimedia success",
      "ExtraInfo": "enim",
      "LinkId": 946,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 441
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": null,
  "SuggestedDocumentId": 286,
  "Snum": 814,
  "UserDefinedFields": {
    "SuperOffice:1": "2103755476",
    "SuperOffice:2": "1055835923"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "porro"
  },
  "CustomFields": {
    "CustomFields1": "veniam",
    "CustomFields2": "aspernatur"
  },
  "PublishEventDate": "2013-06-23T03:41:53.402614+02:00",
  "PublishTo": "2014-04-24T03:41:53.402614+02:00",
  "PublishFrom": "2016-12-09T03:41:53.402614+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 287,
      "Visibility": "All",
      "DisplayValue": "maiores",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 260
        }
      }
    },
    {
      "VisibleId": 287,
      "Visibility": "All",
      "DisplayValue": "maiores",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 260
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 490
    }
  }
}
```