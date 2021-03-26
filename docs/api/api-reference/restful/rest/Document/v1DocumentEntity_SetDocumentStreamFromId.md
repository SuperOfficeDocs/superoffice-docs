---
title: PUT Document/{id}/Content
id: v1DocumentEntity_SetDocumentStreamFromId
---

# PUT Document/{id}/Content

```http
PUT /api/v1/Document/{documentId}/Content
```

Store document content from stream.

Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.




| Path Part | Type | Description |
|-----------|------|-------------|
| documentId | int32 | The document entity object that the binary data (document) should be stored to. Its file name may be amended by this call, see the return value. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `image/jpeg`, `image/jpg`, `image/png`, `image/gif`, `image/bmp`, `image/tiff`, `application/octet-stream`, `application/msword`, `application/rtf`, `application/vnd.openxmlformats-officedocument.wordprocessingml.document`, `application/vnd.ms-excel`, `application/vnd.openxmlformats-officedocument.spreadsheetml.sheet`, `application/vnd.ms-powerpoint`, `application/vnd.openxmlformats-officedocument.presentationml.presentation`, `multipart/form-data`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: stream  

The document content as a stream. 



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
PUT /api/v1/Document/{documentId}/Content
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 108,
  "UpdatedBy": {
    "AssociateId": 766,
    "Name": "McClure Inc and Sons",
    "PersonId": 973,
    "Rank": 234,
    "Tooltip": "pariatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 703,
    "FullName": "Theodore Shanahan",
    "FormalName": "Murphy, Romaguera and Bechtelar",
    "Deleted": true,
    "EjUserId": 305,
    "UserName": "Nitzsche-Wisoky",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 347
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 29,
    "Name": "Streich-Grant",
    "PersonId": 178,
    "Rank": 1000,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 601,
    "FullName": "Stuart Morissette IV",
    "FormalName": "Rosenbaum, Hayes and Dietrich",
    "Deleted": false,
    "EjUserId": 621,
    "UserName": "Yundt-Hartmann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 502
      }
    }
  },
  "Attention": "laudantium",
  "Header": "id",
  "Name": "O'Conner, Muller and Doyle",
  "OurRef": "voluptatibus",
  "YourRef": "cupiditate",
  "CreatedDate": "2005-08-26T09:40:59.1676628+02:00",
  "UpdatedDate": "2002-02-06T09:40:59.1676628+01:00",
  "Description": "Automated heuristic algorithm",
  "DocumentTemplate": {
    "DocumentTemplateId": 606,
    "Name": "Schumm Group",
    "Tooltip": "rerum",
    "SaveInDb": 628,
    "Filename": "dolorem",
    "DefaultOref": "vel",
    "RecordType": "Appointment",
    "Deleted": 109,
    "Direction": "Incoming",
    "AutoeventId": 438,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 522
      }
    }
  },
  "Person": {
    "Position": "ad",
    "PersonId": 255,
    "Mrmrs": "corporis",
    "Firstname": "Kendrick",
    "Lastname": "Ryan",
    "MiddleName": "Ortiz-Hahn",
    "Title": "corrupti",
    "Description": "Operative disintermediate solution",
    "Email": "crawford_heller@dachleuschke.co.uk",
    "FullName": "Raphaelle Cummerata",
    "DirectPhone": "(533)046-8128",
    "FormalName": "Kuhn, Brown and Brown",
    "CountryId": 153,
    "ContactId": 533,
    "ContactName": "Bauch-Hammes",
    "Retired": 504,
    "Rank": 806,
    "ActiveInterests": 552,
    "ContactDepartment": "",
    "ContactCountryId": 934,
    "ContactOrgNr": "1638751",
    "FaxPhone": "1-322-511-2102 x2365",
    "MobilePhone": "1-473-124-0045",
    "ContactPhone": "(540)642-5857 x025",
    "AssociateName": "Schroeder-Veum",
    "AssociateId": 108,
    "UsePersonAddress": true,
    "ContactFax": "dolorum",
    "Kanafname": "ut",
    "Kanalname": "accusantium",
    "Post1": "perspiciatis",
    "Post2": "id",
    "Post3": "sit",
    "EmailName": "mathias@pfannerstill.com",
    "ContactFullName": "Rollin Wintheiser",
    "ActiveErpLinks": 764,
    "TicketPriorityId": 778,
    "SupportLanguageId": 22,
    "SupportAssociateId": 289,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 858
      }
    }
  },
  "Associate": {
    "AssociateId": 431,
    "Name": "Veum-Runolfsdottir",
    "PersonId": 269,
    "Rank": 30,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 4,
    "FullName": "Stevie Predovic",
    "FormalName": "Rau Inc and Sons",
    "Deleted": false,
    "EjUserId": 410,
    "UserName": "Willms-Thompson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 403
      }
    }
  },
  "Contact": {
    "ContactId": 304,
    "Name": "Sauer, Thompson and Homenick",
    "OrgNr": "1042975",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quia",
    "DirectPhone": "1-343-766-0158 x2606",
    "AssociateId": 757,
    "CountryId": 18,
    "EmailAddress": "oren@klein.us",
    "Kananame": "ipsum",
    "EmailAddressName": "shaun@jacobsonharber.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Serena Abbott",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "voluptatibus",
    "FullName": "Justina Durgan",
    "IsOwnerContact": true,
    "ActiveErpLinks": 929,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 35
      }
    }
  },
  "Project": {
    "ProjectId": 149,
    "Name": "Brown, Murazik and McCullough",
    "Description": "Implemented 4th generation portal",
    "URL": "http://www.example.com/",
    "Type": "et",
    "AssociateId": 268,
    "AssociateFullName": "Jadyn Rau V",
    "TypeId": 828,
    "Updated": "2003-10-04T09:40:59.1696628+02:00",
    "StatusId": 764,
    "Status": "voluptas",
    "TextId": 299,
    "PublishTo": "1998-06-02T09:40:59.1696628+02:00",
    "PublishFrom": "2019-08-05T09:40:59.1696628+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "808277",
    "ActiveErpLinks": 534,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 234
      }
    }
  },
  "Date": "1994-08-09T09:40:59.1696628+02:00",
  "ExternalRef": "non",
  "Completed": "Completed",
  "ActiveLinks": 431,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Schuppe, Wiegand and Bergnaum",
      "Id": 224,
      "Description": "Decentralized asynchronous knowledge base",
      "ExtraInfo": "cupiditate",
      "LinkId": 817,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 817
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Rice-Haley",
    "SaleDate": "2003-02-13T09:40:59.1696628+01:00",
    "SaleId": 172,
    "Probability": 854,
    "Title": "nulla",
    "Amount": 14441.472,
    "Currency": "consectetur",
    "ProjectName": "Greenholt, Grant and Leffler",
    "AssociateFullName": "Chance Becker",
    "Description": "Synchronised value-added encoding",
    "Status": "Lost",
    "WeightedAmount": 2359.902,
    "ProjectId": 677,
    "EarningPercent": 30202.358,
    "Earning": 11780.706,
    "ContactId": 983,
    "AssociateId": 510,
    "PersonId": 719,
    "SaleTypeId": 967,
    "SaleTypeName": "Ferry-Jewess",
    "PersonFullName": "Mrs. Cleora Quigley",
    "Completed": "Completed",
    "ActiveErpLinks": 604,
    "NextDueDate": "1995-10-23T09:40:59.1706626+02:00",
    "Number": "374123",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 425
      }
    }
  },
  "SuggestedDocumentId": 272,
  "Snum": 506,
  "UserDefinedFields": {
    "SuperOffice:1": "Efren Keebler",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "autem"
  },
  "CustomFields": {
    "CustomFields1": "ipsa",
    "CustomFields2": "dolores"
  },
  "PublishEventDate": "2007-12-25T09:40:59.1716628+01:00",
  "PublishTo": "1995-03-01T09:40:59.1716628+01:00",
  "PublishFrom": "2014-03-30T09:40:59.1716628+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 14,
      "Visibility": "All",
      "DisplayValue": "voluptate",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 194
        }
      }
    },
    {
      "VisibleId": 14,
      "Visibility": "All",
      "DisplayValue": "voluptate",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 194
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
      "FieldLength": 479
    }
  }
}
```