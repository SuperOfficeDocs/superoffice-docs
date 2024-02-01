---
title: POST Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags
uid: v1DocumentAgent_CreateNewPhysicalDocumentFromTemplateWithCustomTags
generated: true
---

# POST Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags

```http
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags
```

Create a new physical document based on a document template and store it in the document archive.


Tags are substituted according to the provided id's.  Use GetDocumentStream to obtain the created document content. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags?$select=name,department,category/id
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

## Request Body: request 

ContactId, PersonId, AppointmentId, DocumentId, SaleId, SelectionId, ProjectId, CustomTags, CustomValues, UiCulture 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| PersonId | Integer |  |
| AppointmentId | Integer |  |
| DocumentId | Integer |  |
| SaleId | Integer |  |
| SelectionId | Integer |  |
| ProjectId | Integer |  |
| CustomTags | Array |  |
| CustomValues | Array |  |
| UiCulture | String |  |

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
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 219,
  "PersonId": 912,
  "AppointmentId": 329,
  "DocumentId": 565,
  "SaleId": 662,
  "SelectionId": 949,
  "ProjectId": 40,
  "CustomTags": [
    "dolores",
    "nemo"
  ],
  "CustomValues": [
    "illum",
    "debitis"
  ],
  "UiCulture": "autem"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 72,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Attention": "iusto",
  "Header": "repellat",
  "Name": "Koch LLC",
  "OurRef": "esse",
  "YourRef": "possimus",
  "CreatedDate": "2014-03-29T23:03:55.7821321+01:00",
  "UpdatedDate": "2022-11-15T23:03:55.7821321+01:00",
  "Description": "Enterprise-wide disintermediate middleware",
  "DocumentTemplate": null,
  "Person": null,
  "Associate": null,
  "Contact": null,
  "Project": null,
  "Date": "1998-11-10T23:03:55.784635+01:00",
  "ExternalRef": "atque",
  "Completed": "Completed",
  "ActiveLinks": 94,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Lowe LLC",
      "Id": 931,
      "Description": "Assimilated dedicated synergy",
      "ExtraInfo": "vero",
      "LinkId": 598,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 882
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": null,
  "SuggestedDocumentId": 548,
  "Snum": 360,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Hosea Osinski"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "quisquam"
  },
  "CustomFields": {
    "CustomFields1": "adipisci",
    "CustomFields2": "corporis"
  },
  "PublishEventDate": "2020-11-24T23:03:55.7866294+01:00",
  "PublishTo": "2008-11-23T23:03:55.7866294+01:00",
  "PublishFrom": "1999-09-27T23:03:55.7866294+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 102,
      "Visibility": "All",
      "DisplayValue": "fuga",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 160
        }
      }
    },
    {
      "VisibleId": 102,
      "Visibility": "All",
      "DisplayValue": "fuga",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 160
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 911
    }
  }
}
```