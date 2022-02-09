---
title: POST Document/{id}/Content
id: v1DocumentEntity_CreateNewPhysicalDocumentFromTemplateWithCustomTags2
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
POST /api/v1/Document/{documentId}/Content?contactId=232
POST /api/v1/Document/{documentId}/Content?personId=335
POST /api/v1/Document/{documentId}/Content?appointmentId=525
POST /api/v1/Document/{documentId}/Content?saleId=412
POST /api/v1/Document/{documentId}/Content?selectionId=746
POST /api/v1/Document/{documentId}/Content?projectId=341
POST /api/v1/Document/{documentId}/Content?uiCulture=veniam
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
POST /api/v1/Document/{documentId}/Content
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 158,
  "UpdatedBy": {
    "AssociateId": 670,
    "Name": "Kihn-Hansen",
    "PersonId": 396,
    "Rank": 634,
    "Tooltip": "placeat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 807,
    "FullName": "Patsy Leffler",
    "FormalName": "Pagac Inc and Sons",
    "Deleted": false,
    "EjUserId": 601,
    "UserName": "Gaylord Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "generate front-end e-business"
        },
        "FieldType": "System.Int32",
        "FieldLength": 731
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 671,
    "Name": "Harvey-Casper",
    "PersonId": 727,
    "Rank": 307,
    "Tooltip": "quibusdam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 565,
    "FullName": "Domenico Ruecker",
    "FormalName": "Herman Group",
    "Deleted": false,
    "EjUserId": 758,
    "UserName": "Grant Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "maximize front-end systems"
        },
        "FieldType": "System.String",
        "FieldLength": 427
      }
    }
  },
  "Attention": "laborum",
  "Header": "corrupti",
  "Name": "Lockman-Block",
  "OurRef": "totam",
  "YourRef": "et",
  "CreatedDate": "2015-10-19T18:25:50.5206282+02:00",
  "UpdatedDate": "1997-04-23T18:25:50.5206282+02:00",
  "Description": "Synergized bottom-line forecast",
  "DocumentTemplate": {
    "DocumentTemplateId": 338,
    "Name": "Kuhn, Collier and Towne",
    "Tooltip": "amet",
    "SaveInDb": 820,
    "Filename": "quibusdam",
    "DefaultOref": "recusandae",
    "RecordType": "Appointment",
    "Deleted": 725,
    "Direction": "Incoming",
    "AutoeventId": 86,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 812
      }
    }
  },
  "Person": {
    "Position": "quisquam",
    "PersonId": 216,
    "Mrmrs": "et",
    "Firstname": "Delores",
    "Lastname": "Carter",
    "MiddleName": "Zulauf, Howell and Jacobson",
    "Title": "temporibus",
    "Description": "Extended needs-based capability",
    "Email": "kaitlyn_kassulke@schneider.com",
    "FullName": "Nathaniel Wuckert",
    "DirectPhone": "704.645.1200 x10163",
    "FormalName": "Heidenreich LLC",
    "CountryId": 451,
    "ContactId": 860,
    "ContactName": "Prohaska, Hansen and Koss",
    "Retired": 1001,
    "Rank": 877,
    "ActiveInterests": 973,
    "ContactDepartment": "",
    "ContactCountryId": 112,
    "ContactOrgNr": "1472561",
    "FaxPhone": "1-161-387-2647 x646",
    "MobilePhone": "713.076.2100",
    "ContactPhone": "1-866-511-1468 x3400",
    "AssociateName": "Funk-Rippin",
    "AssociateId": 329,
    "UsePersonAddress": true,
    "ContactFax": "debitis",
    "Kanafname": "rerum",
    "Kanalname": "at",
    "Post1": "quae",
    "Post2": "dolor",
    "Post3": "sit",
    "EmailName": "braulio_willms@mayert.us",
    "ContactFullName": "Kassandra Ullrich",
    "ActiveErpLinks": 89,
    "TicketPriorityId": 435,
    "SupportLanguageId": 393,
    "SupportAssociateId": 647,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 507
      }
    }
  },
  "Associate": {
    "AssociateId": 562,
    "Name": "Wolff, Beer and Simonis",
    "PersonId": 282,
    "Rank": 87,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 123,
    "FullName": "Nolan Kovacek",
    "FormalName": "Rogahn, Heaney and Jacobi",
    "Deleted": true,
    "EjUserId": 356,
    "UserName": "Morar, Zboncak and Hettinger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 207
      }
    }
  },
  "Contact": {
    "ContactId": 678,
    "Name": "Hammes Inc and Sons",
    "OrgNr": "1107311",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "est",
    "DirectPhone": "(760)836-5415",
    "AssociateId": 525,
    "CountryId": 645,
    "EmailAddress": "stan@wiegand.info",
    "Kananame": "culpa",
    "EmailAddressName": "maiya_walker@funkbayer.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Rhett Pfannerstill",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "enim",
    "FullName": "Jacinto Gutmann",
    "IsOwnerContact": false,
    "ActiveErpLinks": 232,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 830
      }
    }
  },
  "Project": {
    "ProjectId": 7,
    "Name": "Bartoletti, Turner and Johnston",
    "Description": "Ergonomic system-worthy hierarchy",
    "URL": "http://www.example.com/",
    "Type": "quam",
    "AssociateId": 76,
    "AssociateFullName": "Vincenza Auer",
    "TypeId": 171,
    "Updated": "2020-05-10T18:25:50.5236247+02:00",
    "StatusId": 854,
    "Status": "sed",
    "TextId": 393,
    "PublishTo": "2003-11-09T18:25:50.5236247+01:00",
    "PublishFrom": "2000-05-19T18:25:50.5236247+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "613674",
    "ActiveErpLinks": 321,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 717
      }
    }
  },
  "Date": "2006-03-22T18:25:50.5236247+01:00",
  "ExternalRef": "et",
  "Completed": "Completed",
  "ActiveLinks": 658,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Murazik, Sipes and Schneider",
      "Id": 286,
      "Description": "Assimilated bandwidth-monitored data-warehouse",
      "ExtraInfo": "dolor",
      "LinkId": 617,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "expedite dynamic models"
          },
          "FieldType": "System.Int32",
          "FieldLength": 534
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Stamm LLC",
    "SaleDate": "1997-12-10T18:25:50.5236247+01:00",
    "SaleId": 105,
    "Probability": 860,
    "Title": "enim",
    "Amount": 30832.291999999998,
    "Currency": "et",
    "ProjectName": "Watsica, Herzog and Witting",
    "AssociateFullName": "D'angelo Pacocha DDS",
    "Description": "Configurable mobile monitoring",
    "Status": "Lost",
    "WeightedAmount": 18775.793999999998,
    "ProjectId": 251,
    "EarningPercent": 22041.422,
    "Earning": 29597.496,
    "ContactId": 510,
    "AssociateId": 500,
    "PersonId": 339,
    "SaleTypeId": 850,
    "SaleTypeName": "Cartwright-Stokes",
    "PersonFullName": "Felipa Kessler",
    "Completed": "Completed",
    "ActiveErpLinks": 730,
    "NextDueDate": "1996-01-03T18:25:50.524624+01:00",
    "Number": "777779",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 943
      }
    }
  },
  "SuggestedDocumentId": 684,
  "Snum": 78,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "natus",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "est"
  },
  "PublishEventDate": "1999-08-25T18:25:50.524624+02:00",
  "PublishTo": "2004-03-15T18:25:50.524624+01:00",
  "PublishFrom": "1994-07-20T18:25:50.524624+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 719,
      "Visibility": "All",
      "DisplayValue": "dolorum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 788
        }
      }
    },
    {
      "VisibleId": 719,
      "Visibility": "All",
      "DisplayValue": "dolorum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 788
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
        "Reason": "exploit granular synergies"
      },
      "FieldType": "System.String",
      "FieldLength": 345
    }
  }
}
```