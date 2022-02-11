---
title: POST Agents/Document/SetDocumentStream
id: v1DocumentAgent_SetDocumentStream
---

# POST Agents/Document/SetDocumentStream

```http
POST /api/v1/Agents/Document/SetDocumentStream
```

Store a document's contents from its stream.

Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/SetDocumentStream?$select=name,department,category/id
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

DocumentEntity, Stream, OverwriteExistingData 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentEntity |  | Partial DocumentEntity class associating the generated DocumentEntity with an interface. |
| Stream | byte |  |
| OverwriteExistingData | bool |  |


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
POST /api/v1/Agents/Document/SetDocumentStream
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentEntity": {
    "DocumentId": 402,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "nemo",
    "Header": "autem",
    "Name": "Simonis Inc and Sons",
    "OurRef": "voluptas",
    "YourRef": "aspernatur",
    "CreatedDate": "1998-12-12T18:28:48.8649617+01:00",
    "UpdatedDate": "2016-04-01T18:28:48.8649617+02:00",
    "Description": "Enterprise-wide mission-critical budgetary management",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "2018-12-11T18:28:48.865942+01:00",
    "ExternalRef": "nemo",
    "Completed": "Completed",
    "ActiveLinks": 691,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 71,
    "Snum": 366,
    "UserDefinedFields": {
      "SuperOffice:1": "9576552",
      "SuperOffice:2": "1831588828"
    },
    "ExtraFields": {
      "ExtraFields1": "dolorum",
      "ExtraFields2": "dolorem"
    },
    "CustomFields": {
      "CustomFields1": "officiis",
      "CustomFields2": "sed"
    },
    "PublishEventDate": "2010-09-17T18:28:48.865942+02:00",
    "PublishTo": "2008-03-14T18:28:48.865942+01:00",
    "PublishFrom": "1996-03-04T18:28:48.865942+01:00",
    "IsPublished": false,
    "VisibleFor": [
      {},
      {}
    ]
  },
  "Stream": "GIF89....File contents as raw bytes...",
  "OverwriteExistingData": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 205,
  "UpdatedBy": {
    "AssociateId": 42,
    "Name": "Mosciski-Frami",
    "PersonId": 944,
    "Rank": 955,
    "Tooltip": "mollitia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 345,
    "FullName": "Leola Williamson",
    "FormalName": "Kiehn, Gottlieb and Bogisich",
    "Deleted": true,
    "EjUserId": 339,
    "UserName": "VonRueden-Boyer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 109
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 76,
    "Name": "Lebsack LLC",
    "PersonId": 889,
    "Rank": 458,
    "Tooltip": "corrupti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 660,
    "FullName": "Robin Senger IV",
    "FormalName": "Kreiger, Terry and Dietrich",
    "Deleted": false,
    "EjUserId": 634,
    "UserName": "Wunsch-Schuppe",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 152
      }
    }
  },
  "Attention": "veniam",
  "Header": "non",
  "Name": "Hackett Group",
  "OurRef": "facere",
  "YourRef": "repellendus",
  "CreatedDate": "2009-05-26T18:28:48.8729617+02:00",
  "UpdatedDate": "1995-02-05T18:28:48.8729617+01:00",
  "Description": "Persistent holistic core",
  "DocumentTemplate": {
    "DocumentTemplateId": 788,
    "Name": "Fritsch Inc and Sons",
    "Tooltip": "eligendi",
    "SaveInDb": 440,
    "Filename": "ad",
    "DefaultOref": "corporis",
    "RecordType": "Appointment",
    "Deleted": 94,
    "Direction": "Incoming",
    "AutoeventId": 456,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 205
      }
    }
  },
  "Person": {
    "Position": "qui",
    "PersonId": 95,
    "Mrmrs": "doloribus",
    "Firstname": "Lenora",
    "Lastname": "Bayer",
    "MiddleName": "Bosco-Rippin",
    "Title": "eaque",
    "Description": "De-engineered optimizing algorithm",
    "Email": "diego.gusikowski@sporerreinger.biz",
    "FullName": "Adalberto Hickle",
    "DirectPhone": "457.168.2400 x6225",
    "FormalName": "Cassin LLC",
    "CountryId": 947,
    "ContactId": 266,
    "ContactName": "Heathcote Inc and Sons",
    "Retired": 522,
    "Rank": 741,
    "ActiveInterests": 844,
    "ContactDepartment": "",
    "ContactCountryId": 79,
    "ContactOrgNr": "399324",
    "FaxPhone": "(745)747-2411",
    "MobilePhone": "(288)410-8751 x36033",
    "ContactPhone": "(036)783-8215",
    "AssociateName": "Conroy-Fisher",
    "AssociateId": 816,
    "UsePersonAddress": false,
    "ContactFax": "sed",
    "Kanafname": "et",
    "Kanalname": "et",
    "Post1": "est",
    "Post2": "odit",
    "Post3": "odio",
    "EmailName": "jaquelin_luettgen@corkerypouros.us",
    "ContactFullName": "Jaylin Harber DVM",
    "ActiveErpLinks": 854,
    "TicketPriorityId": 996,
    "SupportLanguageId": 662,
    "SupportAssociateId": 329,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 574
      }
    }
  },
  "Associate": {
    "AssociateId": 787,
    "Name": "Lind LLC",
    "PersonId": 663,
    "Rank": 376,
    "Tooltip": "totam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 708,
    "FullName": "Merl Hickle",
    "FormalName": "Bahringer, Rosenbaum and Keeling",
    "Deleted": true,
    "EjUserId": 46,
    "UserName": "Lockman, Lindgren and Schroeder",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 216
      }
    }
  },
  "Contact": {
    "ContactId": 211,
    "Name": "Terry, Becker and Hahn",
    "OrgNr": "1244242",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "non",
    "DirectPhone": "808.234.6557",
    "AssociateId": 975,
    "CountryId": 903,
    "EmailAddress": "kathryne_smitham@flatley.com",
    "Kananame": "magnam",
    "EmailAddressName": "tyson@willmsohara.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Glenda Harber",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "eum",
    "FullName": "Caitlyn Bauch",
    "IsOwnerContact": true,
    "ActiveErpLinks": 328,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 172
      }
    }
  },
  "Project": {
    "ProjectId": 790,
    "Name": "Feest-Bergstrom",
    "Description": "Visionary hybrid parallelism",
    "URL": "http://www.example.com/",
    "Type": "hic",
    "AssociateId": 413,
    "AssociateFullName": "Maybelle Halvorson",
    "TypeId": 648,
    "Updated": "1998-10-18T18:28:48.8759614+02:00",
    "StatusId": 47,
    "Status": "rem",
    "TextId": 828,
    "PublishTo": "2011-12-31T18:28:48.8759614+01:00",
    "PublishFrom": "2016-12-22T18:28:48.8759614+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1328392",
    "ActiveErpLinks": 75,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 837
      }
    }
  },
  "Date": "2002-10-27T18:28:48.8759614+01:00",
  "ExternalRef": "aut",
  "Completed": "Completed",
  "ActiveLinks": 665,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Rath, Keeling and Wolff",
      "Id": 151,
      "Description": "Progressive 24 hour hierarchy",
      "ExtraInfo": "est",
      "LinkId": 128,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Labadie-Dibbert",
    "SaleDate": "1994-10-07T18:28:48.8759614+02:00",
    "SaleId": 559,
    "Probability": 814,
    "Title": "asperiores",
    "Amount": 11570.728,
    "Currency": "quia",
    "ProjectName": "Fritsch-Gorczany",
    "AssociateFullName": "Akeem O'Keefe",
    "Description": "Digitized 4th generation flexibility",
    "Status": "Lost",
    "WeightedAmount": 15513.3,
    "ProjectId": 678,
    "EarningPercent": 21367.612,
    "Earning": 5509.572,
    "ContactId": 787,
    "AssociateId": 618,
    "PersonId": 145,
    "SaleTypeId": 949,
    "SaleTypeName": "Turner-Herman",
    "PersonFullName": "August Kunze",
    "Completed": "Completed",
    "ActiveErpLinks": 497,
    "NextDueDate": "2003-06-29T18:28:48.8769625+02:00",
    "Number": "1902264",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 53
      }
    }
  },
  "SuggestedDocumentId": 508,
  "Snum": 407,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Casey Mraz"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "quas"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "ullam"
  },
  "PublishEventDate": "2020-08-10T18:28:48.8769625+02:00",
  "PublishTo": "2002-03-23T18:28:48.8769625+01:00",
  "PublishFrom": "2016-07-25T18:28:48.8769625+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 721,
      "Visibility": "All",
      "DisplayValue": "dicta",
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
    {
      "VisibleId": 721,
      "Visibility": "All",
      "DisplayValue": "dicta",
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
      "FieldLength": 772
    }
  }
}
```