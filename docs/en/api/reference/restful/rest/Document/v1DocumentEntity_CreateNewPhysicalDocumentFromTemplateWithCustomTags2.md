---
title: POST Document/{id}/Content
uid: v1DocumentEntity_CreateNewPhysicalDocumentFromTemplateWithCustomTags2
generated: true
---

# POST Document/{id}/Content

```http
POST /api/v1/Document/{documentId}/Content
```

Create a new physical document based on a document template and store it in the document archive.


Tags are substituted according to the provided id's.  Use GetDocumentStream to obtain the created document content. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.





| Path Part | Type | Description |
|-----------|------|-------------|
| documentId | int32 | Identifier for the document **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactId | int32 |  Identifier for a contact. Defaults to document's contact if 0 |
| personId | int32 |  Identifier for a person. Defaults to document's person if 0 |
| appointmentId | int32 |  identifier for an appointment. Defaults to document if 0 |
| saleId | int32 |  Identifier for sale. Defaults to document's sale if 0. |
| selectionId | int32 |  identifier for selection. |
| projectId | int32 |  identifier for project. Defaults to document's project if 0 |
| uiCulture | string |  Language variation of template to use when creating document. (ISO code - "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang". |

```http
POST /api/v1/Document/{documentId}/Content?contactId=91
POST /api/v1/Document/{documentId}/Content?personId=661
POST /api/v1/Document/{documentId}/Content?appointmentId=21
POST /api/v1/Document/{documentId}/Content?saleId=122
POST /api/v1/Document/{documentId}/Content?selectionId=116
POST /api/v1/Document/{documentId}/Content?projectId=230
POST /api/v1/Document/{documentId}/Content?uiCulture=et
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

## Request Body: customTags 

Dictionary of custom tag names and values. Each name should have exactly four characters. There should be exactly one value for each tag. 


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
POST /api/v1/Document/{documentId}/Content
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 109,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Attention": "aut",
  "Header": "magni",
  "Name": "Walter-Considine",
  "OurRef": "modi",
  "YourRef": "aut",
  "CreatedDate": "2010-05-15T11:06:41.8634729+02:00",
  "UpdatedDate": "2012-11-26T11:06:41.8634729+01:00",
  "Description": "Diverse eco-centric portal",
  "DocumentTemplate": null,
  "Person": null,
  "Associate": null,
  "Contact": null,
  "Project": null,
  "Date": "2017-09-04T11:06:41.8634729+02:00",
  "ExternalRef": "nam",
  "Completed": "Completed",
  "ActiveLinks": 289,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Koss, Kunze and Vandervort",
      "Id": 798,
      "Description": "Team-oriented non-volatile emulation",
      "ExtraInfo": "tenetur",
      "LinkId": 218,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 151
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": null,
  "SuggestedDocumentId": 896,
  "Snum": 613,
  "UserDefinedFields": {
    "SuperOffice:1": "277342029",
    "SuperOffice:2": "Hazle Ullrich"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsum",
    "ExtraFields2": "totam"
  },
  "CustomFields": {
    "CustomFields1": "iste",
    "CustomFields2": "officia"
  },
  "PublishEventDate": "2018-09-15T11:06:41.8634729+02:00",
  "PublishTo": "2023-08-04T11:06:41.8634729+02:00",
  "PublishFrom": "2006-10-01T11:06:41.8634729+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 364,
      "Visibility": "All",
      "DisplayValue": "dolor",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 879
        }
      }
    },
    {
      "VisibleId": 364,
      "Visibility": "All",
      "DisplayValue": "dolor",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 879
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 300
    }
  }
}
```