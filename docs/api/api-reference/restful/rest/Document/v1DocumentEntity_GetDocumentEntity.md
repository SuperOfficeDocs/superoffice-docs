---
title: GET Document/{id}
id: v1DocumentEntity_GetDocumentEntity
---

# GET Document/{id}

```http
GET /api/v1/Document/{id}
```

Gets a DocumentEntity object.

Calls the Document agent service GetDocumentEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the DocumentEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Document/{id}?$select=name,department,category/id
GET /api/v1/Document/{id}?fk=True
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




DocumentEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | DocumentEntity found. |
| 304 | DocumentEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

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
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/Document/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 DocumentEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 15 Mar 2018 15:05:42 G3T

{
  "DocumentId": 99,
  "UpdatedBy": {
    "AssociateId": 676,
    "Name": "Carter-Block",
    "PersonId": 993,
    "Rank": 375,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 720,
    "FullName": "Kitty Murazik",
    "FormalName": "Okuneva LLC",
    "Deleted": false,
    "EjUserId": 239,
    "UserName": "Johnston, Pfannerstill and Balistreri",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 390
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 638,
    "Name": "Pacocha Group",
    "PersonId": 359,
    "Rank": 260,
    "Tooltip": "mollitia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 335,
    "FullName": "Jalen Veum",
    "FormalName": "Schoen-Gorczany",
    "Deleted": true,
    "EjUserId": 809,
    "UserName": "Koelpin Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 523
      }
    }
  },
  "Attention": "reiciendis",
  "Header": "velit",
  "Name": "Little-Green",
  "OurRef": "id",
  "YourRef": "eum",
  "CreatedDate": "2014-03-14T15:05:42.1066557+01:00",
  "UpdatedDate": "2018-03-15T15:05:42.1066557+01:00",
  "Description": "Horizontal eco-centric Graphic Interface",
  "DocumentTemplate": {
    "DocumentTemplateId": 32,
    "Name": "Hane Group",
    "Tooltip": "quia",
    "SaveInDb": 330,
    "Filename": "velit",
    "DefaultOref": "voluptatibus",
    "RecordType": "Appointment",
    "Deleted": 632,
    "Direction": "Incoming",
    "AutoeventId": 233,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 283
      }
    }
  },
  "Person": {
    "Position": "amet",
    "PersonId": 194,
    "Mrmrs": "qui",
    "Firstname": "Jarrett",
    "Lastname": "Hagenes",
    "MiddleName": "Jones, Abshire and Weimann",
    "Title": "qui",
    "Description": "Balanced bottom-line conglomeration",
    "Email": "helen.swift@predovicabbott.biz",
    "FullName": "Johann Hermann",
    "DirectPhone": "438-810-4784 x670",
    "FormalName": "Dicki-Jakubowski",
    "CountryId": 22,
    "ContactId": 536,
    "ContactName": "Marquardt Inc and Sons",
    "Retired": 13,
    "Rank": 367,
    "ActiveInterests": 924,
    "ContactDepartment": "",
    "ContactCountryId": 288,
    "ContactOrgNr": "797461",
    "FaxPhone": "415.183.0002",
    "MobilePhone": "(422)153-7245 x6047",
    "ContactPhone": "480.883.3542",
    "AssociateName": "Price Inc and Sons",
    "AssociateId": 26,
    "UsePersonAddress": true,
    "ContactFax": "voluptatibus",
    "Kanafname": "ea",
    "Kanalname": "minus",
    "Post1": "dolore",
    "Post2": "officia",
    "Post3": "voluptate",
    "EmailName": "lambert_dickens@harvey.name",
    "ContactFullName": "Mr. Bridget Hansen",
    "ActiveErpLinks": 289,
    "TicketPriorityId": 138,
    "SupportLanguageId": 654,
    "SupportAssociateId": 742,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 756
      }
    }
  },
  "Associate": {
    "AssociateId": 201,
    "Name": "Gleason-Pfeffer",
    "PersonId": 744,
    "Rank": 97,
    "Tooltip": "fuga",
    "Type": "AnonymousAssociate",
    "GroupIdx": 747,
    "FullName": "Emanuel Kuhic",
    "FormalName": "Reichel, Bernhard and O'Hara",
    "Deleted": true,
    "EjUserId": 953,
    "UserName": "Lubowitz-Carroll",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 963
      }
    }
  },
  "Contact": {
    "ContactId": 75,
    "Name": "Block, Bauch and King",
    "OrgNr": "1619671",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ad",
    "DirectPhone": "1-140-581-2277",
    "AssociateId": 295,
    "CountryId": 417,
    "EmailAddress": "ashlee_marquardt@douglasbode.us",
    "Kananame": "voluptas",
    "EmailAddressName": "alana_littel@grimes.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Imogene Rodriguez",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nobis",
    "FullName": "Nicklaus Murazik",
    "IsOwnerContact": false,
    "ActiveErpLinks": 727,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 781
      }
    }
  },
  "Project": {
    "ProjectId": 507,
    "Name": "Wilkinson-Sauer",
    "Description": "De-engineered intangible implementation",
    "URL": "http://www.example.com/",
    "Type": "hic",
    "AssociateId": 319,
    "AssociateFullName": "Malcolm Berge",
    "TypeId": 804,
    "Updated": "2011-03-23T15:05:42.10967+01:00",
    "StatusId": 531,
    "Status": "suscipit",
    "TextId": 388,
    "PublishTo": "2021-01-16T15:05:42.10967+01:00",
    "PublishFrom": "2007-09-12T15:05:42.10967+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1417901",
    "ActiveErpLinks": 982,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 161
      }
    }
  },
  "Date": "2005-03-01T15:05:42.10967+01:00",
  "ExternalRef": "illum",
  "Completed": "Completed",
  "ActiveLinks": 244,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Rath LLC",
      "Id": 830,
      "Description": "Triple-buffered encompassing moderator",
      "ExtraInfo": "molestiae",
      "LinkId": 205,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 247
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Mertz, Nienow and Boyle",
    "SaleDate": "2014-04-17T15:05:42.1106682+02:00",
    "SaleId": 535,
    "Probability": 659,
    "Title": "et",
    "Amount": 14504.152,
    "Currency": "eveniet",
    "ProjectName": "Heathcote, Ferry and Kub",
    "AssociateFullName": "Dr. Jewel Harris",
    "Description": "Sharable incremental installation",
    "Status": "Lost",
    "WeightedAmount": 21192.108,
    "ProjectId": 858,
    "EarningPercent": 14920.974,
    "Earning": 12896.41,
    "ContactId": 377,
    "AssociateId": 960,
    "PersonId": 901,
    "SaleTypeId": 644,
    "SaleTypeName": "Runolfsson Group",
    "PersonFullName": "Chester Macejkovic",
    "Completed": "Completed",
    "ActiveErpLinks": 769,
    "NextDueDate": "2010-12-11T15:05:42.1106682+01:00",
    "Number": "1047791",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 685
      }
    }
  },
  "SuggestedDocumentId": 151,
  "Snum": 188,
  "UserDefinedFields": {
    "SuperOffice:1": "Israel Veum",
    "SuperOffice:2": "381399693"
  },
  "ExtraFields": {
    "ExtraFields1": "nesciunt",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "dolore",
    "CustomFields2": "voluptas"
  },
  "PublishEventDate": "2006-03-29T15:05:42.1106682+02:00",
  "PublishTo": "2013-08-29T15:05:42.1106682+02:00",
  "PublishFrom": "2006-02-06T15:05:42.1106682+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 439,
      "Visibility": "All",
      "DisplayValue": "dignissimos",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 482
        }
      }
    },
    {
      "VisibleId": 439,
      "Visibility": "All",
      "DisplayValue": "dignissimos",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 482
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "syndicate one-to-one initiatives"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 942
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```