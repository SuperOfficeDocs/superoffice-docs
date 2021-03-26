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
  "DocumentId": 931,
  "UpdatedBy": {
    "AssociateId": 756,
    "Name": "Kiehn Group",
    "PersonId": 694,
    "Rank": 736,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 405,
    "FullName": "Justina Thompson",
    "FormalName": "Greenfelder-Blanda",
    "Deleted": true,
    "EjUserId": 975,
    "UserName": "Hackett-Okuneva",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 760
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 961,
    "Name": "Rau Group",
    "PersonId": 103,
    "Rank": 224,
    "Tooltip": "odit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 470,
    "FullName": "Drew Bins III",
    "FormalName": "Funk, Pollich and Skiles",
    "Deleted": true,
    "EjUserId": 737,
    "UserName": "Brown, West and Champlin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 275
      }
    }
  },
  "Attention": "enim",
  "Header": "eligendi",
  "Name": "Wehner, Reynolds and Moore",
  "OurRef": "esse",
  "YourRef": "sit",
  "CreatedDate": "1996-01-31T16:48:29.354894+01:00",
  "UpdatedDate": "2009-08-08T16:48:29.354894+02:00",
  "Description": "Organic web-enabled budgetary management",
  "DocumentTemplate": {
    "DocumentTemplateId": 799,
    "Name": "Lockman LLC",
    "Tooltip": "ut",
    "SaveInDb": 308,
    "Filename": "dolor",
    "DefaultOref": "pariatur",
    "RecordType": "Appointment",
    "Deleted": 591,
    "Direction": "Incoming",
    "AutoeventId": 143,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 857
      }
    }
  },
  "Person": {
    "Position": "aliquid",
    "PersonId": 136,
    "Mrmrs": "nesciunt",
    "Firstname": "Orpha",
    "Lastname": "Goodwin",
    "MiddleName": "DuBuque-Schumm",
    "Title": "unde",
    "Description": "Visionary zero defect strategy",
    "Email": "frances_ryan@haag.com",
    "FullName": "Dr. Hoyt Torp",
    "DirectPhone": "1-076-140-6487",
    "FormalName": "Goodwin-Pouros",
    "CountryId": 671,
    "ContactId": 871,
    "ContactName": "Keeling, Gusikowski and Dibbert",
    "Retired": 603,
    "Rank": 198,
    "ActiveInterests": 307,
    "ContactDepartment": "",
    "ContactCountryId": 468,
    "ContactOrgNr": "1246307",
    "FaxPhone": "1-710-768-8530 x207",
    "MobilePhone": "1-374-245-5615",
    "ContactPhone": "221.682.5647 x280",
    "AssociateName": "Hoeger, Runolfsson and Borer",
    "AssociateId": 535,
    "UsePersonAddress": false,
    "ContactFax": "enim",
    "Kanafname": "nostrum",
    "Kanalname": "blanditiis",
    "Post1": "non",
    "Post2": "dolores",
    "Post3": "aspernatur",
    "EmailName": "jade@kozey.info",
    "ContactFullName": "Heather Rogahn",
    "ActiveErpLinks": 659,
    "TicketPriorityId": 257,
    "SupportLanguageId": 337,
    "SupportAssociateId": 481,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 550
      }
    }
  },
  "Associate": {
    "AssociateId": 120,
    "Name": "Little, Eichmann and Gleason",
    "PersonId": 492,
    "Rank": 315,
    "Tooltip": "asperiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 295,
    "FullName": "Asia Nitzsche",
    "FormalName": "Nitzsche-Reynolds",
    "Deleted": true,
    "EjUserId": 453,
    "UserName": "Farrell, Runte and Zieme",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "leverage web-enabled synergies"
        },
        "FieldType": "System.String",
        "FieldLength": 812
      }
    }
  },
  "Contact": {
    "ContactId": 595,
    "Name": "Zboncak-Ondricka",
    "OrgNr": "1177246",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "possimus",
    "DirectPhone": "845.348.5056 x68452",
    "AssociateId": 350,
    "CountryId": 847,
    "EmailAddress": "barbara@armstrong.name",
    "Kananame": "repellendus",
    "EmailAddressName": "jayda.rosenbaum@gorczanystark.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Terrell Prosacco",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "id",
    "FullName": "Cassandra Lakin",
    "IsOwnerContact": true,
    "ActiveErpLinks": 402,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 35
      }
    }
  },
  "Project": {
    "ProjectId": 362,
    "Name": "Lemke-Kilback",
    "Description": "Centralized regional monitoring",
    "URL": "http://www.example.com/",
    "Type": "laborum",
    "AssociateId": 542,
    "AssociateFullName": "Lelah Ruecker",
    "TypeId": 469,
    "Updated": "2014-11-06T16:48:29.3578936+01:00",
    "StatusId": 257,
    "Status": "esse",
    "TextId": 896,
    "PublishTo": "2007-08-14T16:48:29.3578936+02:00",
    "PublishFrom": "2021-02-17T16:48:29.3578936+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "813359",
    "ActiveErpLinks": 242,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 558
      }
    }
  },
  "Date": "1996-09-04T16:48:29.3578936+02:00",
  "ExternalRef": "sed",
  "Completed": "Completed",
  "ActiveLinks": 742,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Ernser Group",
      "Id": 203,
      "Description": "Business-focused scalable internet solution",
      "ExtraInfo": "neque",
      "LinkId": 718,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 278
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Steuber Inc and Sons",
    "SaleDate": "2017-06-27T16:48:29.3588938+02:00",
    "SaleId": 31,
    "Probability": 651,
    "Title": "laboriosam",
    "Amount": 6477.978,
    "Currency": "pariatur",
    "ProjectName": "Huels Group",
    "AssociateFullName": "Emily Kirlin",
    "Description": "Ameliorated even-keeled capability",
    "Status": "Lost",
    "WeightedAmount": 11617.738,
    "ProjectId": 216,
    "EarningPercent": 25915.046,
    "Earning": 21709.218,
    "ContactId": 473,
    "AssociateId": 407,
    "PersonId": 456,
    "SaleTypeId": 482,
    "SaleTypeName": "Metz Inc and Sons",
    "PersonFullName": "Fermin Runolfsdottir",
    "Completed": "Completed",
    "ActiveErpLinks": 949,
    "NextDueDate": "2020-10-20T16:48:29.3588938+02:00",
    "Number": "1181216",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 687
      }
    }
  },
  "SuggestedDocumentId": 221,
  "Snum": 737,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "1173719792"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquid",
    "ExtraFields2": "ipsum"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "dignissimos"
  },
  "PublishEventDate": "2005-12-19T16:48:29.3588938+01:00",
  "PublishTo": "2014-07-17T16:48:29.3588938+02:00",
  "PublishFrom": "2013-10-07T16:48:29.3588938+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 967,
      "Visibility": "All",
      "DisplayValue": "possimus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 373
        }
      }
    },
    {
      "VisibleId": 967,
      "Visibility": "All",
      "DisplayValue": "possimus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 373
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
      "FieldLength": 680
    }
  }
}
```