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
GET /api/v1/Document/{id}?fk=False
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
Accept-Language: en
```

```http_
HTTP/1.1 200 DocumentEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 18 Mar 1997 18:25:50 G3T

{
  "DocumentId": 432,
  "UpdatedBy": {
    "AssociateId": 333,
    "Name": "Klein-Wiza",
    "PersonId": 413,
    "Rank": 767,
    "Tooltip": "quisquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 44,
    "FullName": "Kara Lueilwitz",
    "FormalName": "Ward-Hilll",
    "Deleted": true,
    "EjUserId": 225,
    "UserName": "Hand, Ryan and Baumbach",
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
  "CreatedBy": {
    "AssociateId": 409,
    "Name": "Feeney-Langosh",
    "PersonId": 142,
    "Rank": 219,
    "Tooltip": "autem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 928,
    "FullName": "Abe Kuvalis Sr.",
    "FormalName": "Oberbrunner-Labadie",
    "Deleted": false,
    "EjUserId": 54,
    "UserName": "Greenfelder Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 372
      }
    }
  },
  "Attention": "earum",
  "Header": "quis",
  "Name": "Yost Group",
  "OurRef": "ea",
  "YourRef": "corrupti",
  "CreatedDate": "2019-11-26T18:25:50.4446297+01:00",
  "UpdatedDate": "1997-03-18T18:25:50.4446297+01:00",
  "Description": "Re-contextualized grid-enabled process improvement",
  "DocumentTemplate": {
    "DocumentTemplateId": 895,
    "Name": "Dare LLC",
    "Tooltip": "fugiat",
    "SaveInDb": 777,
    "Filename": "sed",
    "DefaultOref": "esse",
    "RecordType": "Appointment",
    "Deleted": 209,
    "Direction": "Incoming",
    "AutoeventId": 391,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 159
      }
    }
  },
  "Person": {
    "Position": "ipsam",
    "PersonId": 616,
    "Mrmrs": "quasi",
    "Firstname": "Laurie",
    "Lastname": "Schamberger",
    "MiddleName": "Crooks-Keeling",
    "Title": "sit",
    "Description": "Reactive intangible protocol",
    "Email": "lurline@ohara.com",
    "FullName": "Newton Nader",
    "DirectPhone": "065.501.1525 x538",
    "FormalName": "Cartwright Inc and Sons",
    "CountryId": 234,
    "ContactId": 970,
    "ContactName": "Yundt Inc and Sons",
    "Retired": 188,
    "Rank": 679,
    "ActiveInterests": 888,
    "ContactDepartment": "",
    "ContactCountryId": 765,
    "ContactOrgNr": "814502",
    "FaxPhone": "855-850-8180 x25638",
    "MobilePhone": "568-428-5554",
    "ContactPhone": "(062)230-7200 x32228",
    "AssociateName": "Tillman Group",
    "AssociateId": 434,
    "UsePersonAddress": true,
    "ContactFax": "est",
    "Kanafname": "impedit",
    "Kanalname": "quisquam",
    "Post1": "mollitia",
    "Post2": "inventore",
    "Post3": "suscipit",
    "EmailName": "charley@hessel.info",
    "ContactFullName": "Toni Cassin",
    "ActiveErpLinks": 898,
    "TicketPriorityId": 219,
    "SupportLanguageId": 240,
    "SupportAssociateId": 348,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 628
      }
    }
  },
  "Associate": {
    "AssociateId": 675,
    "Name": "Eichmann, Bruen and Bogisich",
    "PersonId": 255,
    "Rank": 120,
    "Tooltip": "tempora",
    "Type": "AnonymousAssociate",
    "GroupIdx": 431,
    "FullName": "Darius Wilderman Sr.",
    "FormalName": "Daugherty Inc and Sons",
    "Deleted": true,
    "EjUserId": 551,
    "UserName": "Brown-Wehner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 876
      }
    }
  },
  "Contact": {
    "ContactId": 436,
    "Name": "Ritchie-Witting",
    "OrgNr": "555027",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "veritatis",
    "DirectPhone": "1-005-214-1168",
    "AssociateId": 947,
    "CountryId": 114,
    "EmailAddress": "ceasar@weissnat.ca",
    "Kananame": "quia",
    "EmailAddressName": "isai.paucek@kuhic.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Pierre Mante",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "tenetur",
    "FullName": "Virgil Rodriguez II",
    "IsOwnerContact": false,
    "ActiveErpLinks": 569,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 748
      }
    }
  },
  "Project": {
    "ProjectId": 931,
    "Name": "Haag LLC",
    "Description": "Extended encompassing initiative",
    "URL": "http://www.example.com/",
    "Type": "qui",
    "AssociateId": 153,
    "AssociateFullName": "Frederique Nikolaus",
    "TypeId": 236,
    "Updated": "2006-08-11T18:25:50.4476295+02:00",
    "StatusId": 40,
    "Status": "in",
    "TextId": 968,
    "PublishTo": "1999-03-01T18:25:50.4476295+01:00",
    "PublishFrom": "2019-04-13T18:25:50.4476295+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "280608",
    "ActiveErpLinks": 34,
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
  "Date": "1994-08-30T18:25:50.4476295+02:00",
  "ExternalRef": "perspiciatis",
  "Completed": "Completed",
  "ActiveLinks": 703,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Rutherford-Waelchi",
      "Id": 468,
      "Description": "Self-enabling full-range forecast",
      "ExtraInfo": "necessitatibus",
      "LinkId": 158,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 750
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Huels-Schulist",
    "SaleDate": "1998-04-10T18:25:50.4476295+02:00",
    "SaleId": 652,
    "Probability": 554,
    "Title": "explicabo",
    "Amount": 16801.374,
    "Currency": "ratione",
    "ProjectName": "Wolff Group",
    "AssociateFullName": "Mrs. Gerry Weimann",
    "Description": "Seamless coherent data-warehouse",
    "Status": "Lost",
    "WeightedAmount": 29237.086,
    "ProjectId": 163,
    "EarningPercent": 12921.482,
    "Earning": 23276.218,
    "ContactId": 632,
    "AssociateId": 181,
    "PersonId": 55,
    "SaleTypeId": 265,
    "SaleTypeName": "Paucek-Raynor",
    "PersonFullName": "Jaylon Reichert",
    "Completed": "Completed",
    "ActiveErpLinks": 119,
    "NextDueDate": "2020-07-03T18:25:50.4476295+02:00",
    "Number": "1007495",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 659
      }
    }
  },
  "SuggestedDocumentId": 390,
  "Snum": 376,
  "UserDefinedFields": {
    "SuperOffice:1": "Geovany Hoppe",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "praesentium",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "ipsa"
  },
  "PublishEventDate": "2014-06-07T18:25:50.4476295+02:00",
  "PublishTo": "2017-10-21T18:25:50.4476295+02:00",
  "PublishFrom": "2009-03-24T18:25:50.4476295+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 994,
      "Visibility": "All",
      "DisplayValue": "cupiditate",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 88
        }
      }
    },
    {
      "VisibleId": 994,
      "Visibility": "All",
      "DisplayValue": "cupiditate",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 88
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
      "FieldLength": 369
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```