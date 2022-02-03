---
title: POST Agents/Document/CreateDefaultDocumentEntity
id: v1DocumentAgent_CreateDefaultDocumentEntity
---

# POST Agents/Document/CreateDefaultDocumentEntity

```http
POST /api/v1/Agents/Document/CreateDefaultDocumentEntity
```

Set default values into a new DocumentEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Document/CreateDefaultDocumentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 170,
  "UpdatedBy": {
    "AssociateId": 363,
    "Name": "Heathcote-Ward",
    "PersonId": 401,
    "Rank": 455,
    "Tooltip": "voluptates",
    "Type": "AnonymousAssociate",
    "GroupIdx": 421,
    "FullName": "Clovis Nicolas DDS",
    "FormalName": "Ondricka, Olson and Harvey",
    "Deleted": true,
    "EjUserId": 758,
    "UserName": "Wuckert-Spinka",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 392
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 333,
    "Name": "Schoen-Bashirian",
    "PersonId": 874,
    "Rank": 347,
    "Tooltip": "ab",
    "Type": "AnonymousAssociate",
    "GroupIdx": 83,
    "FullName": "Jarrett Kirlin",
    "FormalName": "Sanford, Pacocha and Tremblay",
    "Deleted": false,
    "EjUserId": 368,
    "UserName": "Waters, Stiedemann and Reinger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 769
      }
    }
  },
  "Attention": "vel",
  "Header": "sunt",
  "Name": "Stiedemann-Berge",
  "OurRef": "ut",
  "YourRef": "eum",
  "CreatedDate": "2014-06-28T18:28:48.8269309+02:00",
  "UpdatedDate": "1998-07-24T18:28:48.8269309+02:00",
  "Description": "Fully-configurable optimizing initiative",
  "DocumentTemplate": {
    "DocumentTemplateId": 584,
    "Name": "Stokes-Schuppe",
    "Tooltip": "assumenda",
    "SaveInDb": 309,
    "Filename": "itaque",
    "DefaultOref": "quo",
    "RecordType": "Appointment",
    "Deleted": 475,
    "Direction": "Incoming",
    "AutoeventId": 542,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 671
      }
    }
  },
  "Person": {
    "Position": "molestias",
    "PersonId": 880,
    "Mrmrs": "reprehenderit",
    "Firstname": "Carrie",
    "Lastname": "Feest",
    "MiddleName": "Langosh, Macejkovic and Langosh",
    "Title": "dolor",
    "Description": "Horizontal bifurcated support",
    "Email": "scot_stehr@ondricka.us",
    "FullName": "Miss Estefania Tromp",
    "DirectPhone": "002.508.0423",
    "FormalName": "Lehner-Marquardt",
    "CountryId": 435,
    "ContactId": 377,
    "ContactName": "Kihn-Goyette",
    "Retired": 113,
    "Rank": 500,
    "ActiveInterests": 636,
    "ContactDepartment": "",
    "ContactCountryId": 306,
    "ContactOrgNr": "1445906",
    "FaxPhone": "875.577.3344 x270",
    "MobilePhone": "035-332-4225 x521",
    "ContactPhone": "657-664-0175 x571",
    "AssociateName": "Yundt Group",
    "AssociateId": 388,
    "UsePersonAddress": false,
    "ContactFax": "cum",
    "Kanafname": "non",
    "Kanalname": "eos",
    "Post1": "cupiditate",
    "Post2": "tempore",
    "Post3": "rerum",
    "EmailName": "janae@watsicamarquardt.info",
    "ContactFullName": "Kenny Anderson",
    "ActiveErpLinks": 610,
    "TicketPriorityId": 414,
    "SupportLanguageId": 868,
    "SupportAssociateId": 542,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 124
      }
    }
  },
  "Associate": {
    "AssociateId": 266,
    "Name": "Herman Inc and Sons",
    "PersonId": 908,
    "Rank": 136,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 797,
    "FullName": "Hershel Fisher",
    "FormalName": "Heidenreich-McGlynn",
    "Deleted": false,
    "EjUserId": 621,
    "UserName": "Dickens Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "architect transparent systems"
        },
        "FieldType": "System.String",
        "FieldLength": 264
      }
    }
  },
  "Contact": {
    "ContactId": 565,
    "Name": "Sporer, Bednar and Pollich",
    "OrgNr": "1233294",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "cum",
    "DirectPhone": "1-308-006-1610",
    "AssociateId": 279,
    "CountryId": 604,
    "EmailAddress": "lonzo@steubermiller.co.uk",
    "Kananame": "ducimus",
    "EmailAddressName": "kaylie@jaskolski.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mya Smitham",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "sint",
    "FullName": "Devante Kutch",
    "IsOwnerContact": false,
    "ActiveErpLinks": 129,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 469
      }
    }
  },
  "Project": {
    "ProjectId": 681,
    "Name": "Hessel, Donnelly and Graham",
    "Description": "Business-focused human-resource hardware",
    "URL": "http://www.example.com/",
    "Type": "unde",
    "AssociateId": 231,
    "AssociateFullName": "Breana Fay",
    "TypeId": 867,
    "Updated": "2000-08-09T18:28:48.8299565+02:00",
    "StatusId": 780,
    "Status": "magni",
    "TextId": 81,
    "PublishTo": "1997-08-29T18:28:48.8299565+02:00",
    "PublishFrom": "2010-10-27T18:28:48.8299565+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "803223",
    "ActiveErpLinks": 951,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 242
      }
    }
  },
  "Date": "2006-10-22T18:28:48.8299565+02:00",
  "ExternalRef": "earum",
  "Completed": "Completed",
  "ActiveLinks": 769,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Bogan Inc and Sons",
      "Id": 820,
      "Description": "Multi-lateral heuristic groupware",
      "ExtraInfo": "sit",
      "LinkId": 563,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 61
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Langworth, Bednar and McClure",
    "SaleDate": "2014-05-19T18:28:48.8299565+02:00",
    "SaleId": 954,
    "Probability": 708,
    "Title": "suscipit",
    "Amount": 22721.5,
    "Currency": "et",
    "ProjectName": "Ziemann Inc and Sons",
    "AssociateFullName": "Jamie Koelpin",
    "Description": "Networked logistical open system",
    "Status": "Lost",
    "WeightedAmount": 9809.42,
    "ProjectId": 617,
    "EarningPercent": 13751.992,
    "Earning": 31098.682,
    "ContactId": 642,
    "AssociateId": 324,
    "PersonId": 589,
    "SaleTypeId": 753,
    "SaleTypeName": "Emmerich Group",
    "PersonFullName": "Pierce Kerluke",
    "Completed": "Completed",
    "ActiveErpLinks": 83,
    "NextDueDate": "2008-05-26T18:28:48.8309277+02:00",
    "Number": "902742",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 836
      }
    }
  },
  "SuggestedDocumentId": 819,
  "Snum": 331,
  "UserDefinedFields": {
    "SuperOffice:1": "Moses Maggio Sr.",
    "SuperOffice:2": "1408351121"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "praesentium"
  },
  "PublishEventDate": "2005-11-24T18:28:48.8309277+01:00",
  "PublishTo": "2010-08-14T18:28:48.8309277+02:00",
  "PublishFrom": "2010-09-07T18:28:48.8309277+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 193,
      "Visibility": "All",
      "DisplayValue": "cupiditate",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 95
        }
      }
    },
    {
      "VisibleId": 193,
      "Visibility": "All",
      "DisplayValue": "cupiditate",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 95
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
      "FieldLength": 665
    }
  }
}
```