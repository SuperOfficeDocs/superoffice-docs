---
title: CreateNewPhysicalMailMergeDocumentFromTemplate
id: v1DocumentAgent_CreateNewPhysicalMailMergeDocumentFromTemplate
---

# CreateNewPhysicalMailMergeDocumentFromTemplate

```http
POST /api/v1/Agents/Document/CreateNewPhysicalMailMergeDocumentFromTemplate
```

Create a new physical document based on the documents template.

Do not replace template tags, as the document is going to be used as a mail merge source. Use GetDocumentStream to obtain the created documents. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/CreateNewPhysicalMailMergeDocumentFromTemplate?$select=name,department,category/id
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

DocumentId, UiCulture 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | int32 |  |
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
POST /api/v1/Agents/Document/CreateNewPhysicalMailMergeDocumentFromTemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 652,
  "UiCulture": "ullam"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 809,
  "UpdatedBy": {
    "AssociateId": 270,
    "Name": "Breitenberg, Parker and Blanda",
    "PersonId": 710,
    "Rank": 542,
    "Tooltip": "harum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 590,
    "FullName": "Price Tillman",
    "FormalName": "Harris Group",
    "Deleted": true,
    "EjUserId": 991,
    "UserName": "Konopelski Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 369
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 408,
    "Name": "Hand-Legros",
    "PersonId": 966,
    "Rank": 195,
    "Tooltip": "facilis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 856,
    "FullName": "Mozell Hintz",
    "FormalName": "Haag, Hoeger and Durgan",
    "Deleted": true,
    "EjUserId": 642,
    "UserName": "Hamill, Kihn and Bosco",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 906
      }
    }
  },
  "Attention": "laboriosam",
  "Header": "tempora",
  "Name": "Hoeger, Quigley and Gutkowski",
  "OurRef": "impedit",
  "YourRef": "nisi",
  "CreatedDate": "2010-11-13T14:58:03.98546+01:00",
  "UpdatedDate": "2011-08-17T14:58:03.98546+02:00",
  "Description": "Decentralized analyzing encryption",
  "DocumentTemplate": {
    "DocumentTemplateId": 451,
    "Name": "Veum Inc and Sons",
    "Tooltip": "dicta",
    "SaveInDb": 61,
    "Filename": "et",
    "DefaultOref": "quae",
    "RecordType": "Appointment",
    "Deleted": 269,
    "Direction": "Incoming",
    "AutoeventId": 100,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 811
      }
    }
  },
  "Person": {
    "Position": "quae",
    "PersonId": 353,
    "Mrmrs": "cum",
    "Firstname": "Brain",
    "Lastname": "Osinski",
    "MiddleName": "Schmidt Inc and Sons",
    "Title": "neque",
    "Description": "Implemented regional data-warehouse",
    "Email": "ilene@schulist.name",
    "FullName": "Tracey Okuneva II",
    "DirectPhone": "1-006-007-2635 x22638",
    "FormalName": "Homenick-Willms",
    "CountryId": 885,
    "ContactId": 585,
    "ContactName": "Hayes-Parisian",
    "Retired": 169,
    "Rank": 395,
    "ActiveInterests": 541,
    "ContactDepartment": "",
    "ContactCountryId": 868,
    "ContactOrgNr": "1577855",
    "FaxPhone": "031-500-1421 x076",
    "MobilePhone": "507.837.8663",
    "ContactPhone": "256.473.8522 x8477",
    "AssociateName": "Flatley-Kuhic",
    "AssociateId": 568,
    "UsePersonAddress": true,
    "ContactFax": "voluptatum",
    "Kanafname": "ut",
    "Kanalname": "rem",
    "Post1": "aut",
    "Post2": "voluptatem",
    "Post3": "incidunt",
    "EmailName": "oren_russel@kautzerzulauf.ca",
    "ContactFullName": "Cassie Gutmann",
    "ActiveErpLinks": 514,
    "TicketPriorityId": 960,
    "SupportLanguageId": 564,
    "SupportAssociateId": 536,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "e-enable front-end supply-chains"
        },
        "FieldType": "System.Int32",
        "FieldLength": 292
      }
    }
  },
  "Associate": {
    "AssociateId": 67,
    "Name": "Jacobs LLC",
    "PersonId": 882,
    "Rank": 5,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 540,
    "FullName": "Adan Kassulke",
    "FormalName": "Baumbach, Bogisich and Willms",
    "Deleted": false,
    "EjUserId": 491,
    "UserName": "Rolfson Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 270
      }
    }
  },
  "Contact": {
    "ContactId": 938,
    "Name": "Rolfson LLC",
    "OrgNr": "1401568",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quo",
    "DirectPhone": "1-384-881-5668 x168",
    "AssociateId": 41,
    "CountryId": 926,
    "EmailAddress": "zena.leuschke@bruen.ca",
    "Kananame": "quia",
    "EmailAddressName": "anna.spinka@considine.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mrs. Jeremie Blick",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "mollitia",
    "FullName": "Maya Berge",
    "IsOwnerContact": true,
    "ActiveErpLinks": 160,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 682
      }
    }
  },
  "Project": {
    "ProjectId": 963,
    "Name": "Roberts, Stanton and Jaskolski",
    "Description": "Innovative empowering task-force",
    "URL": "http://www.example.com/",
    "Type": "rerum",
    "AssociateId": 441,
    "AssociateFullName": "Marcus Stroman",
    "TypeId": 965,
    "Updated": "1994-06-26T14:58:03.9884606+02:00",
    "StatusId": 733,
    "Status": "quia",
    "TextId": 878,
    "PublishTo": "2008-01-12T14:58:03.9884606+01:00",
    "PublishFrom": "2007-11-25T14:58:03.9884606+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1255371",
    "ActiveErpLinks": 708,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 910
      }
    }
  },
  "Date": "2021-02-21T14:58:03.9884606+01:00",
  "ExternalRef": "dolores",
  "Completed": "Completed",
  "ActiveLinks": 883,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Donnelly-Carroll",
      "Id": 337,
      "Description": "Realigned empowering knowledge base",
      "ExtraInfo": "aut",
      "LinkId": 59,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 141
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Hudson, Powlowski and Deckow",
    "SaleDate": "2009-02-11T14:58:03.9884606+01:00",
    "SaleId": 757,
    "Probability": 755,
    "Title": "cumque",
    "Amount": 2952.228,
    "Currency": "blanditiis",
    "ProjectName": "Mraz LLC",
    "AssociateFullName": "Mrs. Winston Senger",
    "Description": "Persistent intangible encryption",
    "Status": "Lost",
    "WeightedAmount": 5052.008,
    "ProjectId": 170,
    "EarningPercent": 29390.652,
    "Earning": 20665.595999999998,
    "ContactId": 882,
    "AssociateId": 209,
    "PersonId": 972,
    "SaleTypeId": 456,
    "SaleTypeName": "Hayes-Kreiger",
    "PersonFullName": "Magdalen Schmidt I",
    "Completed": "Completed",
    "ActiveErpLinks": 385,
    "NextDueDate": "2003-12-17T14:58:03.9884606+01:00",
    "Number": "1029532",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 546
      }
    }
  },
  "SuggestedDocumentId": 814,
  "Snum": 723,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "perferendis"
  },
  "CustomFields": {
    "CustomFields1": "explicabo",
    "CustomFields2": "autem"
  },
  "PublishEventDate": "2001-08-29T14:58:03.9884606+02:00",
  "PublishTo": "2004-02-21T14:58:03.9884606+01:00",
  "PublishFrom": "2010-10-23T14:58:03.9884606+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 541,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 947
        }
      }
    },
    {
      "VisibleId": 541,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 947
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
      "FieldType": "System.Int32",
      "FieldLength": 395
    }
  }
}
```