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
POST /api/v1/Agents/Document/GetDocumentEntity?documentEntityId=442
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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 161,
  "UpdatedBy": {
    "AssociateId": 663,
    "Name": "Stehr LLC",
    "PersonId": 856,
    "Rank": 214,
    "Tooltip": "facere",
    "Type": "AnonymousAssociate",
    "GroupIdx": 738,
    "FullName": "Clemmie Strosin Sr.",
    "FormalName": "Hansen LLC",
    "Deleted": true,
    "EjUserId": 489,
    "UserName": "Kilback Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 983
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 561,
    "Name": "Gaylord, Turner and Kuphal",
    "PersonId": 314,
    "Rank": 270,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 968,
    "FullName": "Nella Kling",
    "FormalName": "Renner, Wiegand and Ferry",
    "Deleted": true,
    "EjUserId": 10,
    "UserName": "Shields Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 614
      }
    }
  },
  "Attention": "quo",
  "Header": "adipisci",
  "Name": "Gutmann, Swaniawski and O'Hara",
  "OurRef": "et",
  "YourRef": "ut",
  "CreatedDate": "1998-12-05T18:28:48.8599614+01:00",
  "UpdatedDate": "1996-07-24T18:28:48.8599614+02:00",
  "Description": "Switchable static model",
  "DocumentTemplate": {
    "DocumentTemplateId": 363,
    "Name": "Goyette Inc and Sons",
    "Tooltip": "porro",
    "SaveInDb": 808,
    "Filename": "quod",
    "DefaultOref": "et",
    "RecordType": "Appointment",
    "Deleted": 696,
    "Direction": "Incoming",
    "AutoeventId": 67,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 362
      }
    }
  },
  "Person": {
    "Position": "sit",
    "PersonId": 987,
    "Mrmrs": "aut",
    "Firstname": "Rosario",
    "Lastname": "Fay",
    "MiddleName": "Abernathy-Kuhlman",
    "Title": "non",
    "Description": "Visionary maximized throughput",
    "Email": "anais_king@boyle.co.uk",
    "FullName": "Theodora Grimes",
    "DirectPhone": "1-301-444-1103 x244",
    "FormalName": "Nader Inc and Sons",
    "CountryId": 116,
    "ContactId": 714,
    "ContactName": "Brakus, Adams and Hamill",
    "Retired": 106,
    "Rank": 118,
    "ActiveInterests": 991,
    "ContactDepartment": "",
    "ContactCountryId": 264,
    "ContactOrgNr": "1057437",
    "FaxPhone": "(874)618-3564 x36553",
    "MobilePhone": "1-478-782-1140 x80411",
    "ContactPhone": "024-387-1684",
    "AssociateName": "Fisher Group",
    "AssociateId": 245,
    "UsePersonAddress": false,
    "ContactFax": "omnis",
    "Kanafname": "vel",
    "Kanalname": "repellat",
    "Post1": "aut",
    "Post2": "nihil",
    "Post3": "ratione",
    "EmailName": "veronica@braun.us",
    "ContactFullName": "Mittie Jast Sr.",
    "ActiveErpLinks": 16,
    "TicketPriorityId": 943,
    "SupportLanguageId": 705,
    "SupportAssociateId": 650,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 202
      }
    }
  },
  "Associate": {
    "AssociateId": 936,
    "Name": "Grimes-Hintz",
    "PersonId": 518,
    "Rank": 265,
    "Tooltip": "in",
    "Type": "AnonymousAssociate",
    "GroupIdx": 247,
    "FullName": "Ezra Schamberger",
    "FormalName": "Mueller-O'Kon",
    "Deleted": true,
    "EjUserId": 748,
    "UserName": "Jast-Marvin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 269
      }
    }
  },
  "Contact": {
    "ContactId": 284,
    "Name": "Champlin, Brown and Schroeder",
    "OrgNr": "1229410",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "est",
    "DirectPhone": "763-060-4800 x33205",
    "AssociateId": 471,
    "CountryId": 330,
    "EmailAddress": "linwood@balistreri.com",
    "Kananame": "ullam",
    "EmailAddressName": "valentin@friesenweissnat.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Otilia Schowalter",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "corporis",
    "FullName": "Mortimer Langosh",
    "IsOwnerContact": true,
    "ActiveErpLinks": 556,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 367
      }
    }
  },
  "Project": {
    "ProjectId": 810,
    "Name": "Feeney Inc and Sons",
    "Description": "Cross-group empowering standardization",
    "URL": "http://www.example.com/",
    "Type": "vel",
    "AssociateId": 75,
    "AssociateFullName": "Corbin Little",
    "TypeId": 382,
    "Updated": "2000-11-04T18:28:48.862962+01:00",
    "StatusId": 576,
    "Status": "omnis",
    "TextId": 125,
    "PublishTo": "2019-08-27T18:28:48.862962+02:00",
    "PublishFrom": "2007-11-04T18:28:48.862962+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "453520",
    "ActiveErpLinks": 167,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 545
      }
    }
  },
  "Date": "2008-12-26T18:28:48.862962+01:00",
  "ExternalRef": "et",
  "Completed": "Completed",
  "ActiveLinks": 154,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Rau Inc and Sons",
      "Id": 133,
      "Description": "Phased global approach",
      "ExtraInfo": "id",
      "LinkId": 761,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 747
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Ratke Inc and Sons",
    "SaleDate": "1999-06-30T18:28:48.862962+02:00",
    "SaleId": 854,
    "Probability": 275,
    "Title": "sit",
    "Amount": 4635.186,
    "Currency": "repellat",
    "ProjectName": "Fritsch, Heaney and Schamberger",
    "AssociateFullName": "Scarlett Huel",
    "Description": "Total interactive standardization",
    "Status": "Lost",
    "WeightedAmount": 20229.969999999998,
    "ProjectId": 518,
    "EarningPercent": 20264.444,
    "Earning": 13899.289999999999,
    "ContactId": 568,
    "AssociateId": 503,
    "PersonId": 458,
    "SaleTypeId": 71,
    "SaleTypeName": "Yundt, Hickle and Paucek",
    "PersonFullName": "Keshaun Senger",
    "Completed": "Completed",
    "ActiveErpLinks": 302,
    "NextDueDate": "2015-12-25T18:28:48.8639618+01:00",
    "Number": "1100511",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 684
      }
    }
  },
  "SuggestedDocumentId": 820,
  "Snum": 627,
  "UserDefinedFields": {
    "SuperOffice:1": "Kellen Klocko I",
    "SuperOffice:2": "Ms. Celestino Jaskolski"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "beatae"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "similique"
  },
  "PublishEventDate": "1995-11-16T18:28:48.8639618+01:00",
  "PublishTo": "2015-11-11T18:28:48.8639618+01:00",
  "PublishFrom": "1997-12-31T18:28:48.8639618+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 96,
      "Visibility": "All",
      "DisplayValue": "nesciunt",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 966
        }
      }
    },
    {
      "VisibleId": 96,
      "Visibility": "All",
      "DisplayValue": "nesciunt",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 966
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
      "FieldLength": 311
    }
  }
}
```