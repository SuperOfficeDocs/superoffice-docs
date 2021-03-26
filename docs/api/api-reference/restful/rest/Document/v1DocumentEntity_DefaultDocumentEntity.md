---
title: GET Document/default
id: v1DocumentEntity_DefaultDocumentEntity
---

# GET Document/default

```http
GET /api/v1/Document/default
```

Set default values into a new DocumentEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Document agent service CreateDefaultDocumentEntity.






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
GET /api/v1/Document/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 25 Oct 2010 09:40:59 G10T

{
  "DocumentId": 166,
  "UpdatedBy": {
    "AssociateId": 747,
    "Name": "Mraz-Greenholt",
    "PersonId": 104,
    "Rank": 257,
    "Tooltip": "modi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 181,
    "FullName": "Dr. Stephon Weber",
    "FormalName": "Considine-Schulist",
    "Deleted": false,
    "EjUserId": 33,
    "UserName": "Doyle-Leffler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 446
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 18,
    "Name": "Okuneva, Runolfsdottir and Abshire",
    "PersonId": 668,
    "Rank": 807,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 987,
    "FullName": "Jewell Stracke",
    "FormalName": "Runolfsdottir LLC",
    "Deleted": false,
    "EjUserId": 326,
    "UserName": "Smith, Kreiger and Schoen",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 617
      }
    }
  },
  "Attention": "sapiente",
  "Header": "quia",
  "Name": "Gleason LLC",
  "OurRef": "est",
  "YourRef": "aut",
  "CreatedDate": "2016-06-24T09:40:59.0688855+02:00",
  "UpdatedDate": "2010-10-25T09:40:59.0688855+02:00",
  "Description": "Adaptive demand-driven analyzer",
  "DocumentTemplate": {
    "DocumentTemplateId": 320,
    "Name": "Hyatt LLC",
    "Tooltip": "rem",
    "SaveInDb": 441,
    "Filename": "nostrum",
    "DefaultOref": "incidunt",
    "RecordType": "Appointment",
    "Deleted": 538,
    "Direction": "Incoming",
    "AutoeventId": 305,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 678
      }
    }
  },
  "Person": {
    "Position": "quia",
    "PersonId": 803,
    "Mrmrs": "nulla",
    "Firstname": "Lionel",
    "Lastname": "Jacobs",
    "MiddleName": "Miller Group",
    "Title": "autem",
    "Description": "Organized global infrastructure",
    "Email": "reilly@kilbacklehner.ca",
    "FullName": "Teagan Bernier",
    "DirectPhone": "067-230-2153",
    "FormalName": "Hermiston Inc and Sons",
    "CountryId": 524,
    "ContactId": 544,
    "ContactName": "Feil LLC",
    "Retired": 574,
    "Rank": 169,
    "ActiveInterests": 437,
    "ContactDepartment": "",
    "ContactCountryId": 110,
    "ContactOrgNr": "527142",
    "FaxPhone": "1-552-131-6078 x5816",
    "MobilePhone": "580-275-8842 x8385",
    "ContactPhone": "531-636-8388",
    "AssociateName": "Conroy-Rempel",
    "AssociateId": 620,
    "UsePersonAddress": true,
    "ContactFax": "amet",
    "Kanafname": "omnis",
    "Kanalname": "illo",
    "Post1": "consequuntur",
    "Post2": "sequi",
    "Post3": "cumque",
    "EmailName": "sarina_stoltenberg@labadie.us",
    "ContactFullName": "Jan Friesen",
    "ActiveErpLinks": 892,
    "TicketPriorityId": 665,
    "SupportLanguageId": 552,
    "SupportAssociateId": 75,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 259
      }
    }
  },
  "Associate": {
    "AssociateId": 288,
    "Name": "Zemlak Group",
    "PersonId": 446,
    "Rank": 353,
    "Tooltip": "sapiente",
    "Type": "AnonymousAssociate",
    "GroupIdx": 238,
    "FullName": "Katlynn Schamberger",
    "FormalName": "Cartwright LLC",
    "Deleted": true,
    "EjUserId": 129,
    "UserName": "Nicolas, White and Grant",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 650
      }
    }
  },
  "Contact": {
    "ContactId": 663,
    "Name": "Kutch Group",
    "OrgNr": "883515",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "velit",
    "DirectPhone": "773.467.7088 x4748",
    "AssociateId": 613,
    "CountryId": 177,
    "EmailAddress": "pauline@zulauf.uk",
    "Kananame": "quibusdam",
    "EmailAddressName": "kristina.leuschke@schuppeshanahan.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Erika Paucek",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "impedit",
    "FullName": "Sigmund Champlin",
    "IsOwnerContact": true,
    "ActiveErpLinks": 175,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 798
      }
    }
  },
  "Project": {
    "ProjectId": 638,
    "Name": "Hodkiewicz-O'Connell",
    "Description": "Profound user-facing application",
    "URL": "http://www.example.com/",
    "Type": "aut",
    "AssociateId": 387,
    "AssociateFullName": "Lillian Schaden",
    "TypeId": 165,
    "Updated": "2011-04-28T09:40:59.0708855+02:00",
    "StatusId": 262,
    "Status": "explicabo",
    "TextId": 91,
    "PublishTo": "2019-12-18T09:40:59.0708855+01:00",
    "PublishFrom": "2014-04-29T09:40:59.0708855+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1250556",
    "ActiveErpLinks": 468,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 515
      }
    }
  },
  "Date": "2003-07-16T09:40:59.0708855+02:00",
  "ExternalRef": "adipisci",
  "Completed": "Completed",
  "ActiveLinks": 895,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Crooks, Runolfsdottir and Dach",
      "Id": 895,
      "Description": "Future-proofed cohesive forecast",
      "ExtraInfo": "et",
      "LinkId": 90,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 227
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Rath-Conroy",
    "SaleDate": "2006-05-05T09:40:59.0708855+02:00",
    "SaleId": 424,
    "Probability": 212,
    "Title": "sit",
    "Amount": 17794.852,
    "Currency": "rerum",
    "ProjectName": "Hansen, Kozey and Mitchell",
    "AssociateFullName": "Dr. Cyrus Johns",
    "Description": "Compatible static system engine",
    "Status": "Lost",
    "WeightedAmount": 21912.928,
    "ProjectId": 53,
    "EarningPercent": 27011.946,
    "Earning": 181.772,
    "ContactId": 81,
    "AssociateId": 379,
    "PersonId": 545,
    "SaleTypeId": 176,
    "SaleTypeName": "Grant-Block",
    "PersonFullName": "Jayne Kohler",
    "Completed": "Completed",
    "ActiveErpLinks": 524,
    "NextDueDate": "2001-02-25T09:40:59.0718856+01:00",
    "Number": "1313197",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 302
      }
    }
  },
  "SuggestedDocumentId": 25,
  "Snum": 823,
  "UserDefinedFields": {
    "SuperOffice:1": "Joey Hegmann",
    "SuperOffice:2": "Jose Kessler"
  },
  "ExtraFields": {
    "ExtraFields1": "natus",
    "ExtraFields2": "aliquid"
  },
  "CustomFields": {
    "CustomFields1": "accusantium",
    "CustomFields2": "rem"
  },
  "PublishEventDate": "2004-06-20T09:40:59.0718856+02:00",
  "PublishTo": "2014-05-31T09:40:59.0718856+02:00",
  "PublishFrom": "2019-08-06T09:40:59.0718856+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 546,
      "Visibility": "All",
      "DisplayValue": "nobis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 334
        }
      }
    },
    {
      "VisibleId": 546,
      "Visibility": "All",
      "DisplayValue": "nobis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 334
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
      "FieldLength": 302
    }
  }
}
```