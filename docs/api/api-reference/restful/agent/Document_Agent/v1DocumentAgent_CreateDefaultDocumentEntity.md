---
title: CreateDefaultDocumentEntity
id: v1DocumentAgent_CreateDefaultDocumentEntity
---

# CreateDefaultDocumentEntity

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
  "DocumentId": 207,
  "UpdatedBy": {
    "AssociateId": 775,
    "Name": "Koss, Hilll and Littel",
    "PersonId": 702,
    "Rank": 95,
    "Tooltip": "magnam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 935,
    "FullName": "Blaze Deckow",
    "FormalName": "Tromp-Altenwerth",
    "Deleted": true,
    "EjUserId": 136,
    "UserName": "Berge-Walter",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "reintermediate integrated experiences"
        },
        "FieldType": "System.String",
        "FieldLength": 531
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 362,
    "Name": "Hilpert, Reichert and Beer",
    "PersonId": 265,
    "Rank": 761,
    "Tooltip": "modi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 496,
    "FullName": "Ellsworth Stamm",
    "FormalName": "Feil, Ziemann and Toy",
    "Deleted": true,
    "EjUserId": 189,
    "UserName": "Wolff, Marquardt and Leffler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "generate wireless action-items"
        },
        "FieldType": "System.String",
        "FieldLength": 775
      }
    }
  },
  "Attention": "ipsum",
  "Header": "necessitatibus",
  "Name": "Macejkovic-Fahey",
  "OurRef": "et",
  "YourRef": "nostrum",
  "CreatedDate": "2000-02-10T14:58:03.9274598+01:00",
  "UpdatedDate": "2010-03-07T14:58:03.9274598+01:00",
  "Description": "Profit-focused assymetric pricing structure",
  "DocumentTemplate": {
    "DocumentTemplateId": 80,
    "Name": "Torphy LLC",
    "Tooltip": "blanditiis",
    "SaveInDb": 738,
    "Filename": "eum",
    "DefaultOref": "voluptas",
    "RecordType": "Appointment",
    "Deleted": 916,
    "Direction": "Incoming",
    "AutoeventId": 953,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 142
      }
    }
  },
  "Person": {
    "Position": "a",
    "PersonId": 282,
    "Mrmrs": "assumenda",
    "Firstname": "Rhianna",
    "Lastname": "Lynch",
    "MiddleName": "Kuhlman-Dicki",
    "Title": "necessitatibus",
    "Description": "Cloned exuding process improvement",
    "Email": "jaleel.trantow@keeling.ca",
    "FullName": "Miller Osinski",
    "DirectPhone": "1-470-218-8818",
    "FormalName": "Toy Inc and Sons",
    "CountryId": 898,
    "ContactId": 378,
    "ContactName": "Dicki Inc and Sons",
    "Retired": 956,
    "Rank": 474,
    "ActiveInterests": 530,
    "ContactDepartment": "",
    "ContactCountryId": 353,
    "ContactOrgNr": "1253721",
    "FaxPhone": "361-488-0604 x480",
    "MobilePhone": "145.621.7303 x22615",
    "ContactPhone": "(427)642-6682 x73787",
    "AssociateName": "Bechtelar Group",
    "AssociateId": 335,
    "UsePersonAddress": true,
    "ContactFax": "cum",
    "Kanafname": "exercitationem",
    "Kanalname": "consequatur",
    "Post1": "qui",
    "Post2": "quisquam",
    "Post3": "eveniet",
    "EmailName": "cody@fahey.uk",
    "ContactFullName": "Nikko Wuckert",
    "ActiveErpLinks": 707,
    "TicketPriorityId": 995,
    "SupportLanguageId": 368,
    "SupportAssociateId": 470,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "expedite vertical channels"
        },
        "FieldType": "System.String",
        "FieldLength": 867
      }
    }
  },
  "Associate": {
    "AssociateId": 582,
    "Name": "Stamm, Pfannerstill and Ledner",
    "PersonId": 150,
    "Rank": 490,
    "Tooltip": "alias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 248,
    "FullName": "Dr. Elyse Nikolaus",
    "FormalName": "Marks, Dibbert and Renner",
    "Deleted": true,
    "EjUserId": 433,
    "UserName": "Auer Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 434
      }
    }
  },
  "Contact": {
    "ContactId": 490,
    "Name": "Boyer LLC",
    "OrgNr": "435203",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "aut",
    "DirectPhone": "1-518-264-4841 x820",
    "AssociateId": 854,
    "CountryId": 457,
    "EmailAddress": "hosea@smitham.com",
    "Kananame": "illo",
    "EmailAddressName": "ayana@kemmer.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Eli Shields",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "dolorum",
    "FullName": "Jessyca Carroll",
    "IsOwnerContact": false,
    "ActiveErpLinks": 572,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 941
      }
    }
  },
  "Project": {
    "ProjectId": 501,
    "Name": "Aufderhar Inc and Sons",
    "Description": "Centralized background matrix",
    "URL": "http://www.example.com/",
    "Type": "quas",
    "AssociateId": 238,
    "AssociateFullName": "Vladimir Carroll",
    "TypeId": 941,
    "Updated": "2015-09-19T14:58:03.9304598+02:00",
    "StatusId": 841,
    "Status": "placeat",
    "TextId": 265,
    "PublishTo": "2005-02-10T14:58:03.9304598+01:00",
    "PublishFrom": "2012-11-01T14:58:03.9304598+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "435350",
    "ActiveErpLinks": 234,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 772
      }
    }
  },
  "Date": "2014-04-28T14:58:03.9304598+02:00",
  "ExternalRef": "molestias",
  "Completed": "Completed",
  "ActiveLinks": 114,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Trantow, Dicki and Nader",
      "Id": 554,
      "Description": "Expanded multimedia project",
      "ExtraInfo": "fuga",
      "LinkId": 652,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 690
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Hessel, Steuber and Morissette",
    "SaleDate": "1998-01-02T14:58:03.9304598+01:00",
    "SaleId": 870,
    "Probability": 983,
    "Title": "sit",
    "Amount": 9959.851999999999,
    "Currency": "velit",
    "ProjectName": "Terry Group",
    "AssociateFullName": "Abigale Homenick",
    "Description": "Innovative value-added secured line",
    "Status": "Lost",
    "WeightedAmount": 22292.142,
    "ProjectId": 339,
    "EarningPercent": 20978.996,
    "Earning": 26416.486,
    "ContactId": 806,
    "AssociateId": 417,
    "PersonId": 583,
    "SaleTypeId": 453,
    "SaleTypeName": "Johns Inc and Sons",
    "PersonFullName": "Larue Corkery",
    "Completed": "Completed",
    "ActiveErpLinks": 497,
    "NextDueDate": "2002-09-17T14:58:03.9304598+02:00",
    "Number": "1877689",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 989
      }
    }
  },
  "SuggestedDocumentId": 245,
  "Snum": 557,
  "UserDefinedFields": {
    "SuperOffice:1": "Ian Daugherty",
    "SuperOffice:2": "1594603348"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "error"
  },
  "PublishEventDate": "2009-11-21T14:58:03.9314603+01:00",
  "PublishTo": "2001-08-09T14:58:03.9314603+02:00",
  "PublishFrom": "2019-04-30T14:58:03.9314603+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 329,
      "Visibility": "All",
      "DisplayValue": "placeat",
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
      "VisibleId": 329,
      "Visibility": "All",
      "DisplayValue": "placeat",
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
      "FieldLength": 428
    }
  }
}
```