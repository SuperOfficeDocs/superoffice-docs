---
title: CreateNewPhysicalDocumentFromTemplateWithCustomTags
id: v1DocumentAgent_CreateNewPhysicalDocumentFromTemplateWithCustomTags
---

# CreateNewPhysicalDocumentFromTemplateWithCustomTags

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
| ContactId | int32 |  |
| PersonId | int32 |  |
| AppointmentId | int32 |  |
| DocumentId | int32 |  |
| SaleId | int32 |  |
| SelectionId | int32 |  |
| ProjectId | int32 |  |
| CustomTags | array |  |
| CustomValues | array |  |
| UiCulture | string |  |


## Response: object

Partial DocumentEntity class associating the generated DocumentEntity with an interface.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 848,
  "PersonId": 160,
  "AppointmentId": 196,
  "DocumentId": 494,
  "SaleId": 608,
  "SelectionId": 147,
  "ProjectId": 796,
  "CustomTags": [
    "unde",
    "ut"
  ],
  "CustomValues": [
    "ut",
    "est"
  ],
  "UiCulture": "nobis"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 990,
  "UpdatedBy": {
    "AssociateId": 504,
    "Name": "Bogisich Group",
    "PersonId": 51,
    "Rank": 976,
    "Tooltip": "dicta",
    "Type": "AnonymousAssociate",
    "GroupIdx": 634,
    "FullName": "Justice Wuckert",
    "FormalName": "Becker-Denesik",
    "Deleted": true,
    "EjUserId": 332,
    "UserName": "Luettgen, Fritsch and D'Amore",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 728
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 2,
    "Name": "Renner, Vandervort and Wiza",
    "PersonId": 376,
    "Rank": 206,
    "Tooltip": "eaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 489,
    "FullName": "Alejandra Schiller",
    "FormalName": "O'Reilly, Powlowski and Frami",
    "Deleted": false,
    "EjUserId": 463,
    "UserName": "West-Rohan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 336
      }
    }
  },
  "Attention": "id",
  "Header": "laudantium",
  "Name": "Jerde Inc and Sons",
  "OurRef": "occaecati",
  "YourRef": "saepe",
  "CreatedDate": "2003-08-16T14:58:03.9954602+02:00",
  "UpdatedDate": "2010-06-08T14:58:03.9954602+02:00",
  "Description": "Function-based tangible hardware",
  "DocumentTemplate": {
    "DocumentTemplateId": 524,
    "Name": "Flatley, Gutkowski and Champlin",
    "Tooltip": "officia",
    "SaveInDb": 479,
    "Filename": "ut",
    "DefaultOref": "quia",
    "RecordType": "Appointment",
    "Deleted": 59,
    "Direction": "Incoming",
    "AutoeventId": 530,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 711
      }
    }
  },
  "Person": {
    "Position": "et",
    "PersonId": 393,
    "Mrmrs": "illum",
    "Firstname": "Jannie",
    "Lastname": "Hackett",
    "MiddleName": "McGlynn, Koelpin and Collins",
    "Title": "sint",
    "Description": "Enhanced regional budgetary management",
    "Email": "cordelia@corwin.us",
    "FullName": "Zora VonRueden",
    "DirectPhone": "(032)364-6447 x520",
    "FormalName": "Pacocha Group",
    "CountryId": 510,
    "ContactId": 849,
    "ContactName": "Leuschke, Shields and Konopelski",
    "Retired": 393,
    "Rank": 108,
    "ActiveInterests": 833,
    "ContactDepartment": "",
    "ContactCountryId": 209,
    "ContactOrgNr": "1855740",
    "FaxPhone": "868.013.2048 x76226",
    "MobilePhone": "(871)265-1355 x81402",
    "ContactPhone": "(448)830-0243 x37601",
    "AssociateName": "Jones Group",
    "AssociateId": 759,
    "UsePersonAddress": true,
    "ContactFax": "id",
    "Kanafname": "vel",
    "Kanalname": "sint",
    "Post1": "in",
    "Post2": "sequi",
    "Post3": "odio",
    "EmailName": "tod.stamm@schaeferkub.info",
    "ContactFullName": "Tyreek Rutherford",
    "ActiveErpLinks": 351,
    "TicketPriorityId": 195,
    "SupportLanguageId": 383,
    "SupportAssociateId": 637,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 740
      }
    }
  },
  "Associate": {
    "AssociateId": 606,
    "Name": "Yost Inc and Sons",
    "PersonId": 719,
    "Rank": 279,
    "Tooltip": "eum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 714,
    "FullName": "Oceane Harvey",
    "FormalName": "White, Connelly and Schultz",
    "Deleted": false,
    "EjUserId": 295,
    "UserName": "Nienow, Kihn and Welch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 857
      }
    }
  },
  "Contact": {
    "ContactId": 188,
    "Name": "Tillman Group",
    "OrgNr": "684863",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quia",
    "DirectPhone": "(655)735-0213 x4227",
    "AssociateId": 847,
    "CountryId": 200,
    "EmailAddress": "barney@halvorson.uk",
    "Kananame": "nihil",
    "EmailAddressName": "deshawn@waelchi.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Tavares Rutherford",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quasi",
    "FullName": "Modesto Simonis I",
    "IsOwnerContact": false,
    "ActiveErpLinks": 844,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 371
      }
    }
  },
  "Project": {
    "ProjectId": 943,
    "Name": "Beier, West and Tillman",
    "Description": "Multi-channelled dynamic project",
    "URL": "http://www.example.com/",
    "Type": "incidunt",
    "AssociateId": 290,
    "AssociateFullName": "Caden Luettgen",
    "TypeId": 147,
    "Updated": "2005-10-02T14:58:03.9984627+02:00",
    "StatusId": 183,
    "Status": "perferendis",
    "TextId": 514,
    "PublishTo": "2006-01-06T14:58:03.9984627+01:00",
    "PublishFrom": "2008-09-28T14:58:03.9984627+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1461919",
    "ActiveErpLinks": 475,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 477
      }
    }
  },
  "Date": "2015-01-29T14:58:03.9984627+01:00",
  "ExternalRef": "modi",
  "Completed": "Completed",
  "ActiveLinks": 384,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Wiza, Leffler and Rath",
      "Id": 611,
      "Description": "Cross-platform uniform contingency",
      "ExtraInfo": "veniam",
      "LinkId": 580,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "morph world-class e-services"
          },
          "FieldType": "System.String",
          "FieldLength": 19
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Boyer-Hagenes",
    "SaleDate": "2015-04-03T14:58:03.9984627+02:00",
    "SaleId": 411,
    "Probability": 134,
    "Title": "corrupti",
    "Amount": 11987.55,
    "Currency": "reprehenderit",
    "ProjectName": "Botsford-Dare",
    "AssociateFullName": "Lon Durgan",
    "Description": "Horizontal disintermediate superstructure",
    "Status": "Lost",
    "WeightedAmount": 17481.452,
    "ProjectId": 570,
    "EarningPercent": 30249.368,
    "Earning": 13520.076,
    "ContactId": 897,
    "AssociateId": 48,
    "PersonId": 776,
    "SaleTypeId": 33,
    "SaleTypeName": "Waelchi, Hermann and Doyle",
    "PersonFullName": "Taryn Goodwin",
    "Completed": "Completed",
    "ActiveErpLinks": 740,
    "NextDueDate": "2018-05-21T14:58:03.9984627+02:00",
    "Number": "740051",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 395
      }
    }
  },
  "SuggestedDocumentId": 654,
  "Snum": 487,
  "UserDefinedFields": {
    "SuperOffice:1": "Izabella Wiegand",
    "SuperOffice:2": "Tania Ledner"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "dicta"
  },
  "CustomFields": {
    "CustomFields1": "blanditiis",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2020-09-11T14:58:03.999466+02:00",
  "PublishTo": "2010-01-13T14:58:03.999466+01:00",
  "PublishFrom": "1998-09-23T14:58:03.999466+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 501,
      "Visibility": "All",
      "DisplayValue": "magnam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 28
        }
      }
    },
    {
      "VisibleId": 501,
      "Visibility": "All",
      "DisplayValue": "magnam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 28
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 460
    }
  }
}
```