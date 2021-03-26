---
title: POST Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags
id: v1DocumentAgent_CreateNewPhysicalDocumentFromTemplateWithCustomTags
---

# POST Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags

```http
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags
```

Create a new physical document based on a document template and store it in the document archive.

Tags are substituted according to the provided id's.  Use GetDocumentStream to obtain the created document content. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags?$select=name,department,category/id
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

## Request Body: request  

ContactId, PersonId, AppointmentId, DocumentId, SaleId, SelectionId, ProjectId, CustomTags, CustomValues, UiCulture 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |
| PersonId | int32 |  |
| AppointmentId | int32 |  |
| DocumentId | int32 |  |
| SaleId | int32 |  |
| SelectionId | int32 |  |
| ProjectId | int32 |  |
| CustomTags | array |  |
| CustomValues | array |  |
| UiCulture | string |  |


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
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 478,
  "PersonId": 108,
  "AppointmentId": 640,
  "DocumentId": 19,
  "SaleId": 595,
  "SelectionId": 916,
  "ProjectId": 950,
  "CustomTags": [
    "similique",
    "esse"
  ],
  "CustomValues": [
    "pariatur",
    "ut"
  ],
  "UiCulture": "quas"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 114,
  "UpdatedBy": {
    "AssociateId": 502,
    "Name": "Bergstrom-McLaughlin",
    "PersonId": 124,
    "Rank": 609,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 478,
    "FullName": "Miss Cordell Stracke",
    "FormalName": "Barrows LLC",
    "Deleted": true,
    "EjUserId": 952,
    "UserName": "Schoen-Gutmann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 792
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 833,
    "Name": "Labadie-Christiansen",
    "PersonId": 584,
    "Rank": 816,
    "Tooltip": "aliquid",
    "Type": "AnonymousAssociate",
    "GroupIdx": 483,
    "FullName": "Orland Tremblay",
    "FormalName": "Schowalter LLC",
    "Deleted": true,
    "EjUserId": 815,
    "UserName": "Hammes, Kohler and Welch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 508
      }
    }
  },
  "Attention": "at",
  "Header": "adipisci",
  "Name": "Bradtke Group",
  "OurRef": "omnis",
  "YourRef": "repellat",
  "CreatedDate": "1999-05-26T16:48:29.4218977+02:00",
  "UpdatedDate": "1996-10-01T16:48:29.4218977+02:00",
  "Description": "Distributed national solution",
  "DocumentTemplate": {
    "DocumentTemplateId": 623,
    "Name": "Russel, Smitham and Emmerich",
    "Tooltip": "facilis",
    "SaveInDb": 280,
    "Filename": "consequatur",
    "DefaultOref": "excepturi",
    "RecordType": "Appointment",
    "Deleted": 888,
    "Direction": "Incoming",
    "AutoeventId": 264,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 48
      }
    }
  },
  "Person": {
    "Position": "sed",
    "PersonId": 161,
    "Mrmrs": "error",
    "Firstname": "Jewell",
    "Lastname": "O'Reilly",
    "MiddleName": "Kuvalis-VonRueden",
    "Title": "rerum",
    "Description": "Polarised eco-centric intranet",
    "Email": "ruby@heidenreich.co.uk",
    "FullName": "Talia Boyle I",
    "DirectPhone": "716-373-4755",
    "FormalName": "Schumm-O'Keefe",
    "CountryId": 173,
    "ContactId": 980,
    "ContactName": "Kunde, King and Feil",
    "Retired": 873,
    "Rank": 714,
    "ActiveInterests": 565,
    "ContactDepartment": "",
    "ContactCountryId": 789,
    "ContactOrgNr": "1371335",
    "FaxPhone": "807-206-4547 x103",
    "MobilePhone": "(768)705-1226",
    "ContactPhone": "(732)258-6085 x762",
    "AssociateName": "Bauch-Bradtke",
    "AssociateId": 560,
    "UsePersonAddress": true,
    "ContactFax": "aliquid",
    "Kanafname": "aut",
    "Kanalname": "voluptates",
    "Post1": "molestias",
    "Post2": "unde",
    "Post3": "voluptatem",
    "EmailName": "napoleon.sipes@jacobson.us",
    "ContactFullName": "Rosalind Hills",
    "ActiveErpLinks": 72,
    "TicketPriorityId": 395,
    "SupportLanguageId": 493,
    "SupportAssociateId": 14,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 997
      }
    }
  },
  "Associate": {
    "AssociateId": 536,
    "Name": "Schamberger-Hammes",
    "PersonId": 350,
    "Rank": 114,
    "Tooltip": "animi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 510,
    "FullName": "Alec Farrell PhD",
    "FormalName": "Turcotte, Beahan and Marks",
    "Deleted": true,
    "EjUserId": 347,
    "UserName": "Spinka-Glover",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "redefine B2B supply-chains"
        },
        "FieldType": "System.Int32",
        "FieldLength": 899
      }
    }
  },
  "Contact": {
    "ContactId": 795,
    "Name": "Moen, Lowe and Mosciski",
    "OrgNr": "1559505",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quisquam",
    "DirectPhone": "777-671-1658",
    "AssociateId": 453,
    "CountryId": 204,
    "EmailAddress": "florian_heidenreich@ebert.info",
    "Kananame": "voluptatem",
    "EmailAddressName": "michaela@johns.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Dr. Lisette Runolfsson",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quia",
    "FullName": "Walton Kuhlman",
    "IsOwnerContact": false,
    "ActiveErpLinks": 295,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "extend cross-platform experiences"
        },
        "FieldType": "System.Int32",
        "FieldLength": 641
      }
    }
  },
  "Project": {
    "ProjectId": 639,
    "Name": "Walter Inc and Sons",
    "Description": "Public-key composite help-desk",
    "URL": "http://www.example.com/",
    "Type": "qui",
    "AssociateId": 486,
    "AssociateFullName": "Aniyah Jerde",
    "TypeId": 401,
    "Updated": "2008-07-13T16:48:29.4659303+02:00",
    "StatusId": 937,
    "Status": "animi",
    "TextId": 340,
    "PublishTo": "2002-06-29T16:48:29.4659303+02:00",
    "PublishFrom": "2008-08-28T16:48:29.4659303+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1243629",
    "ActiveErpLinks": 860,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 751
      }
    }
  },
  "Date": "2002-02-04T16:48:29.4669256+01:00",
  "ExternalRef": "iste",
  "Completed": "Completed",
  "ActiveLinks": 672,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Harber-Rowe",
      "Id": 301,
      "Description": "Inverse empowering standardization",
      "ExtraInfo": "aliquid",
      "LinkId": 593,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 377
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Bosco LLC",
    "SaleDate": "2003-03-22T16:48:29.4669256+01:00",
    "SaleId": 182,
    "Probability": 792,
    "Title": "quia",
    "Amount": 13679.91,
    "Currency": "exercitationem",
    "ProjectName": "Collins, Bartell and Stiedemann",
    "AssociateFullName": "Mathilde Roberts",
    "Description": "Polarised zero administration methodology",
    "Status": "Lost",
    "WeightedAmount": 9461.546,
    "ProjectId": 924,
    "EarningPercent": 11100.627999999999,
    "Earning": 18832.206,
    "ContactId": 455,
    "AssociateId": 175,
    "PersonId": 131,
    "SaleTypeId": 435,
    "SaleTypeName": "Bahringer, Cremin and Miller",
    "PersonFullName": "Kailey Windler",
    "Completed": "Completed",
    "ActiveErpLinks": 491,
    "NextDueDate": "1994-02-01T16:48:29.4669256+01:00",
    "Number": "936735",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 424
      }
    }
  },
  "SuggestedDocumentId": 724,
  "Snum": 364,
  "UserDefinedFields": {
    "SuperOffice:1": "1649701655",
    "SuperOffice:2": "Golda Lindgren"
  },
  "ExtraFields": {
    "ExtraFields1": "temporibus",
    "ExtraFields2": "corporis"
  },
  "CustomFields": {
    "CustomFields1": "suscipit",
    "CustomFields2": "beatae"
  },
  "PublishEventDate": "2021-02-22T16:48:29.4669256+01:00",
  "PublishTo": "2011-12-28T16:48:29.4669256+01:00",
  "PublishFrom": "2013-10-21T16:48:29.4669256+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 536,
      "Visibility": "All",
      "DisplayValue": "vero",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 167
        }
      }
    },
    {
      "VisibleId": 536,
      "Visibility": "All",
      "DisplayValue": "vero",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 167
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
      "FieldLength": 880
    }
  }
}
```