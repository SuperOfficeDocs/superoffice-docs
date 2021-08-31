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
POST /api/v1/Document/{documentId}/Content?contactId=369
POST /api/v1/Document/{documentId}/Content?personId=685
POST /api/v1/Document/{documentId}/Content?appointmentId=400
POST /api/v1/Document/{documentId}/Content?saleId=852
POST /api/v1/Document/{documentId}/Content?selectionId=998
POST /api/v1/Document/{documentId}/Content?projectId=444
POST /api/v1/Document/{documentId}/Content?uiCulture=occaecati
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
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 394,
  "UpdatedBy": {
    "AssociateId": 73,
    "Name": "Wilkinson-Koepp",
    "PersonId": 180,
    "Rank": 58,
    "Tooltip": "accusantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 260,
    "FullName": "Barbara Rolfson",
    "FormalName": "Gusikowski-Yost",
    "Deleted": false,
    "EjUserId": 342,
    "UserName": "Miller-West",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 91
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 602,
    "Name": "D'Amore Inc and Sons",
    "PersonId": 318,
    "Rank": 934,
    "Tooltip": "porro",
    "Type": "AnonymousAssociate",
    "GroupIdx": 440,
    "FullName": "Ebony Crona",
    "FormalName": "Welch Inc and Sons",
    "Deleted": true,
    "EjUserId": 483,
    "UserName": "Terry-Monahan",
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
  "Attention": "id",
  "Header": "porro",
  "Name": "Mills-Greenfelder",
  "OurRef": "autem",
  "YourRef": "aut",
  "CreatedDate": "1999-03-11T15:05:42.1576354+01:00",
  "UpdatedDate": "2000-05-07T15:05:42.1576354+02:00",
  "Description": "Proactive eco-centric attitude",
  "DocumentTemplate": {
    "DocumentTemplateId": 386,
    "Name": "Ward Inc and Sons",
    "Tooltip": "omnis",
    "SaveInDb": 314,
    "Filename": "esse",
    "DefaultOref": "maiores",
    "RecordType": "Appointment",
    "Deleted": 247,
    "Direction": "Incoming",
    "AutoeventId": 428,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 331
      }
    }
  },
  "Person": {
    "Position": "repellat",
    "PersonId": 74,
    "Mrmrs": "reiciendis",
    "Firstname": "Iva",
    "Lastname": "Sauer",
    "MiddleName": "Witting-Hessel",
    "Title": "nulla",
    "Description": "Enhanced radical contingency",
    "Email": "devyn_boehm@green.ca",
    "FullName": "Julia McGlynn",
    "DirectPhone": "(102)288-4310 x02875",
    "FormalName": "Pouros Inc and Sons",
    "CountryId": 545,
    "ContactId": 492,
    "ContactName": "Kub LLC",
    "Retired": 912,
    "Rank": 378,
    "ActiveInterests": 896,
    "ContactDepartment": "",
    "ContactCountryId": 325,
    "ContactOrgNr": "1256611",
    "FaxPhone": "477-280-8821",
    "MobilePhone": "715-773-5274 x80554",
    "ContactPhone": "808.165.7530",
    "AssociateName": "Rau-Yost",
    "AssociateId": 777,
    "UsePersonAddress": true,
    "ContactFax": "enim",
    "Kanafname": "nihil",
    "Kanalname": "nisi",
    "Post1": "ipsa",
    "Post2": "libero",
    "Post3": "minus",
    "EmailName": "janick_flatley@kertzmannparker.name",
    "ContactFullName": "Dolly Abernathy",
    "ActiveErpLinks": 157,
    "TicketPriorityId": 176,
    "SupportLanguageId": 299,
    "SupportAssociateId": 969,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 938
      }
    }
  },
  "Associate": {
    "AssociateId": 259,
    "Name": "Gleichner LLC",
    "PersonId": 825,
    "Rank": 231,
    "Tooltip": "doloribus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 398,
    "FullName": "Fabiola Littel",
    "FormalName": "Strosin Inc and Sons",
    "Deleted": true,
    "EjUserId": 621,
    "UserName": "Ward, Gorczany and Gutmann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 272
      }
    }
  },
  "Contact": {
    "ContactId": 259,
    "Name": "Cruickshank-Hirthe",
    "OrgNr": "377708",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "velit",
    "DirectPhone": "(478)064-5588 x4821",
    "AssociateId": 842,
    "CountryId": 827,
    "EmailAddress": "tre_wilderman@yundt.ca",
    "Kananame": "nihil",
    "EmailAddressName": "makenna.powlowski@schroederbarrows.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Emmet Pacocha",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "magnam",
    "FullName": "Makenzie Emmerich",
    "IsOwnerContact": true,
    "ActiveErpLinks": 132,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 992
      }
    }
  },
  "Project": {
    "ProjectId": 538,
    "Name": "Hettinger Group",
    "Description": "Centralized content-based help-desk",
    "URL": "http://www.example.com/",
    "Type": "adipisci",
    "AssociateId": 393,
    "AssociateFullName": "Mrs. Linwood Wuckert",
    "TypeId": 284,
    "Updated": "2014-09-14T15:05:42.1596347+02:00",
    "StatusId": 322,
    "Status": "eveniet",
    "TextId": 122,
    "PublishTo": "2007-03-11T15:05:42.1596347+01:00",
    "PublishFrom": "2007-05-30T15:05:42.1596347+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "764800",
    "ActiveErpLinks": 830,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 483
      }
    }
  },
  "Date": "2001-05-28T15:05:42.1596347+02:00",
  "ExternalRef": "velit",
  "Completed": "Completed",
  "ActiveLinks": 128,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Schaefer Group",
      "Id": 784,
      "Description": "Reduced bottom-line benchmark",
      "ExtraInfo": "autem",
      "LinkId": 1000,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 78
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Keeling Inc and Sons",
    "SaleDate": "2009-01-08T15:05:42.1606348+01:00",
    "SaleId": 17,
    "Probability": 125,
    "Title": "consequuntur",
    "Amount": 7750.382,
    "Currency": "velit",
    "ProjectName": "Rath, O'Conner and Jacobi",
    "AssociateFullName": "Miss Royce Gerhold",
    "Description": "Up-sized intangible support",
    "Status": "Lost",
    "WeightedAmount": 11827.716,
    "ProjectId": 374,
    "EarningPercent": 12382.434,
    "Earning": 27168.646,
    "ContactId": 287,
    "AssociateId": 688,
    "PersonId": 627,
    "SaleTypeId": 605,
    "SaleTypeName": "McClure Group",
    "PersonFullName": "Cordie Borer",
    "Completed": "Completed",
    "ActiveErpLinks": 112,
    "NextDueDate": "1997-01-09T15:05:42.1606348+01:00",
    "Number": "709129",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 327
      }
    }
  },
  "SuggestedDocumentId": 415,
  "Snum": 634,
  "UserDefinedFields": {
    "SuperOffice:1": "2028220900",
    "SuperOffice:2": "1785839967"
  },
  "ExtraFields": {
    "ExtraFields1": "sequi",
    "ExtraFields2": "aliquam"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "dolorum"
  },
  "PublishEventDate": "2014-08-24T15:05:42.1606348+02:00",
  "PublishTo": "1994-05-07T15:05:42.1606348+02:00",
  "PublishFrom": "2009-08-12T15:05:42.1606348+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 357,
      "Visibility": "All",
      "DisplayValue": "ipsa",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 421
        }
      }
    },
    {
      "VisibleId": 357,
      "Visibility": "All",
      "DisplayValue": "ipsa",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 421
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
      "FieldLength": 294
    }
  }
}
```