---
title: POST Agents/Document/GetDocumentEntity
id: v1DocumentAgent_GetDocumentEntity
---

# POST Agents/Document/GetDocumentEntity

```http
POST /api/v1/Agents/Document/GetDocumentEntity
```

Gets a DocumentEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| documentEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/GetDocumentEntity?documentEntityId=112
POST /api/v1/Agents/Document/GetDocumentEntity?$select=name,department,category/id
```


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
POST /api/v1/Agents/Document/GetDocumentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 501,
  "UpdatedBy": {
    "AssociateId": 121,
    "Name": "Turcotte-Macejkovic",
    "PersonId": 238,
    "Rank": 701,
    "Tooltip": "corrupti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 310,
    "FullName": "Johnson Pollich Jr.",
    "FormalName": "Wolf Inc and Sons",
    "Deleted": true,
    "EjUserId": 543,
    "UserName": "Pouros Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 58
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 993,
    "Name": "Kris, Yost and Becker",
    "PersonId": 497,
    "Rank": 677,
    "Tooltip": "vero",
    "Type": "AnonymousAssociate",
    "GroupIdx": 468,
    "FullName": "Norbert Shanahan",
    "FormalName": "Lesch, Ryan and Smith",
    "Deleted": false,
    "EjUserId": 457,
    "UserName": "Harvey, Aufderhar and Schaden",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 658
      }
    }
  },
  "Attention": "sit",
  "Header": "omnis",
  "Name": "Davis-Quigley",
  "OurRef": "alias",
  "YourRef": "aliquam",
  "CreatedDate": "2002-12-07T16:48:29.3858948+01:00",
  "UpdatedDate": "1998-05-01T16:48:29.3858948+02:00",
  "Description": "Reactive context-sensitive pricing structure",
  "DocumentTemplate": {
    "DocumentTemplateId": 511,
    "Name": "Reichert, Rau and Graham",
    "Tooltip": "neque",
    "SaveInDb": 400,
    "Filename": "et",
    "DefaultOref": "expedita",
    "RecordType": "Appointment",
    "Deleted": 699,
    "Direction": "Incoming",
    "AutoeventId": 234,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 222
      }
    }
  },
  "Person": {
    "Position": "et",
    "PersonId": 584,
    "Mrmrs": "voluptatem",
    "Firstname": "Kaden",
    "Lastname": "Kessler",
    "MiddleName": "Crist-Mosciski",
    "Title": "aut",
    "Description": "Expanded didactic extranet",
    "Email": "manuela@oconneraufderhar.biz",
    "FullName": "Dr. Beau Becker",
    "DirectPhone": "(230)574-4457",
    "FormalName": "Miller Inc and Sons",
    "CountryId": 623,
    "ContactId": 722,
    "ContactName": "Hintz, Zieme and Schmidt",
    "Retired": 545,
    "Rank": 422,
    "ActiveInterests": 423,
    "ContactDepartment": "",
    "ContactCountryId": 137,
    "ContactOrgNr": "1095206",
    "FaxPhone": "1-548-840-8205 x576",
    "MobilePhone": "663.800.0285 x724",
    "ContactPhone": "777-018-8068 x5423",
    "AssociateName": "Gaylord, Ryan and Dietrich",
    "AssociateId": 50,
    "UsePersonAddress": false,
    "ContactFax": "quod",
    "Kanafname": "dolor",
    "Kanalname": "unde",
    "Post1": "aliquid",
    "Post2": "dolore",
    "Post3": "quia",
    "EmailName": "emelia.fisher@kuhic.biz",
    "ContactFullName": "Willie Lesch",
    "ActiveErpLinks": 297,
    "TicketPriorityId": 533,
    "SupportLanguageId": 795,
    "SupportAssociateId": 638,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 688
      }
    }
  },
  "Associate": {
    "AssociateId": 256,
    "Name": "Will-Considine",
    "PersonId": 615,
    "Rank": 709,
    "Tooltip": "dolorum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 545,
    "FullName": "Jacinto Schaefer",
    "FormalName": "Wunsch-Ziemann",
    "Deleted": true,
    "EjUserId": 445,
    "UserName": "Graham-Lynch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 759
      }
    }
  },
  "Contact": {
    "ContactId": 646,
    "Name": "Stamm, Romaguera and Stracke",
    "OrgNr": "1646861",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "et",
    "DirectPhone": "315-860-2114",
    "AssociateId": 750,
    "CountryId": 812,
    "EmailAddress": "phyllis_damore@mcglynn.name",
    "Kananame": "sapiente",
    "EmailAddressName": "vivien@torp.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Arno Hilll",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "a",
    "FullName": "Roy Schultz",
    "IsOwnerContact": false,
    "ActiveErpLinks": 529,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 779
      }
    }
  },
  "Project": {
    "ProjectId": 231,
    "Name": "Bins, Gulgowski and Will",
    "Description": "Extended local service-desk",
    "URL": "http://www.example.com/",
    "Type": "exercitationem",
    "AssociateId": 959,
    "AssociateFullName": "Golda Schroeder",
    "TypeId": 661,
    "Updated": "2017-05-10T16:48:29.3889243+02:00",
    "StatusId": 874,
    "Status": "et",
    "TextId": 315,
    "PublishTo": "2003-05-04T16:48:29.3889243+02:00",
    "PublishFrom": "2009-01-13T16:48:29.3889243+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "837735",
    "ActiveErpLinks": 161,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 62
      }
    }
  },
  "Date": "2005-06-02T16:48:29.3889243+02:00",
  "ExternalRef": "aut",
  "Completed": "Completed",
  "ActiveLinks": 159,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "McGlynn, Veum and Hermann",
      "Id": 243,
      "Description": "Re-engineered disintermediate approach",
      "ExtraInfo": "qui",
      "LinkId": 245,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "grow world-class niches"
          },
          "FieldType": "System.Int32",
          "FieldLength": 886
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Langworth, Shanahan and Quigley",
    "SaleDate": "1999-06-03T16:48:29.3899221+02:00",
    "SaleId": 544,
    "Probability": 210,
    "Title": "est",
    "Amount": 22483.316,
    "Currency": "aut",
    "ProjectName": "O'Hara LLC",
    "AssociateFullName": "Edgar Fay",
    "Description": "Extended analyzing synergy",
    "Status": "Lost",
    "WeightedAmount": 9665.256,
    "ProjectId": 643,
    "EarningPercent": 14043.454,
    "Earning": 28694.904,
    "ContactId": 694,
    "AssociateId": 202,
    "PersonId": 992,
    "SaleTypeId": 407,
    "SaleTypeName": "Lesch Inc and Sons",
    "PersonFullName": "Mrs. Kaylin Walter",
    "Completed": "Completed",
    "ActiveErpLinks": 117,
    "NextDueDate": "1998-12-24T16:48:29.3899221+01:00",
    "Number": "402135",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 339
      }
    }
  },
  "SuggestedDocumentId": 34,
  "Snum": 389,
  "UserDefinedFields": {
    "SuperOffice:1": "181045011",
    "SuperOffice:2": "370504344"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "quidem"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "aut"
  },
  "PublishEventDate": "1997-12-19T16:48:29.3899221+01:00",
  "PublishTo": "2021-01-05T16:48:29.3899221+01:00",
  "PublishFrom": "2010-12-25T16:48:29.3899221+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 546,
      "Visibility": "All",
      "DisplayValue": "voluptatem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 408
        }
      }
    },
    {
      "VisibleId": 546,
      "Visibility": "All",
      "DisplayValue": "voluptatem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 408
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
      "FieldLength": 955
    }
  }
}
```