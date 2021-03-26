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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocumentEntity": {
    "DocumentId": 500,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "iste",
    "Header": "qui",
    "Name": "King, Abernathy and Donnelly",
    "OurRef": "veniam",
    "YourRef": "rerum",
    "CreatedDate": "2000-09-05T16:48:29.3909247+02:00",
    "UpdatedDate": "2006-07-04T16:48:29.3909247+02:00",
    "Description": "Diverse multi-tasking artificial intelligence",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "2004-04-12T16:48:29.3909247+02:00",
    "ExternalRef": "ut",
    "Completed": "Completed",
    "ActiveLinks": 650,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 269,
    "Snum": 24,
    "UserDefinedFields": {
      "SuperOffice:1": "True",
      "SuperOffice:2": "Chanelle Cruickshank DDS"
    },
    "ExtraFields": {
      "ExtraFields1": "facere",
      "ExtraFields2": "neque"
    },
    "CustomFields": {
      "CustomFields1": "asperiores",
      "CustomFields2": "quis"
    },
    "PublishEventDate": "2016-03-21T16:48:29.3909247+01:00",
    "PublishTo": "2015-07-12T16:48:29.3909247+02:00",
    "PublishFrom": "2004-10-29T16:48:29.3909247+02:00",
    "IsPublished": true,
    "VisibleFor": [
      {},
      {}
    ]
  },
  "Stream": "GIF89....File contents as raw bytes...",
  "OverwriteExistingData": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 366,
  "UpdatedBy": {
    "AssociateId": 832,
    "Name": "O'Hara Inc and Sons",
    "PersonId": 992,
    "Rank": 759,
    "Tooltip": "quisquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 637,
    "FullName": "Gia Huels",
    "FormalName": "Luettgen Inc and Sons",
    "Deleted": true,
    "EjUserId": 78,
    "UserName": "Bauch Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 202
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 507,
    "Name": "Corwin-Kilback",
    "PersonId": 199,
    "Rank": 914,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 297,
    "FullName": "Sigurd West",
    "FormalName": "Schultz-Runolfsson",
    "Deleted": false,
    "EjUserId": 566,
    "UserName": "Mayer Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 576
      }
    }
  },
  "Attention": "delectus",
  "Header": "aliquid",
  "Name": "Bins LLC",
  "OurRef": "non",
  "YourRef": "corporis",
  "CreatedDate": "2010-01-04T16:48:29.3969315+01:00",
  "UpdatedDate": "2013-10-18T16:48:29.3969315+02:00",
  "Description": "Assimilated object-oriented time-frame",
  "DocumentTemplate": {
    "DocumentTemplateId": 702,
    "Name": "Simonis Group",
    "Tooltip": "qui",
    "SaveInDb": 650,
    "Filename": "ad",
    "DefaultOref": "consectetur",
    "RecordType": "Appointment",
    "Deleted": 76,
    "Direction": "Incoming",
    "AutoeventId": 738,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 946
      }
    }
  },
  "Person": {
    "Position": "suscipit",
    "PersonId": 208,
    "Mrmrs": "veniam",
    "Firstname": "Sibyl",
    "Lastname": "Auer",
    "MiddleName": "Langosh, Hermiston and Prohaska",
    "Title": "atque",
    "Description": "Pre-emptive assymetric paradigm",
    "Email": "keyon.goldner@moore.info",
    "FullName": "Trystan Walter",
    "DirectPhone": "1-655-327-3375 x441",
    "FormalName": "Parisian, Von and Lynch",
    "CountryId": 660,
    "ContactId": 92,
    "ContactName": "Hartmann-Bailey",
    "Retired": 665,
    "Rank": 250,
    "ActiveInterests": 675,
    "ContactDepartment": "",
    "ContactCountryId": 628,
    "ContactOrgNr": "1186942",
    "FaxPhone": "1-338-417-6226",
    "MobilePhone": "673-061-5812",
    "ContactPhone": "741-683-6614",
    "AssociateName": "Langosh Inc and Sons",
    "AssociateId": 144,
    "UsePersonAddress": false,
    "ContactFax": "molestias",
    "Kanafname": "voluptatem",
    "Kanalname": "autem",
    "Post1": "et",
    "Post2": "nesciunt",
    "Post3": "nesciunt",
    "EmailName": "forrest.zulauf@bahringer.uk",
    "ContactFullName": "Ericka Koss",
    "ActiveErpLinks": 865,
    "TicketPriorityId": 425,
    "SupportLanguageId": 581,
    "SupportAssociateId": 545,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 352
      }
    }
  },
  "Associate": {
    "AssociateId": 111,
    "Name": "Dietrich, Ledner and Braun",
    "PersonId": 111,
    "Rank": 14,
    "Tooltip": "nulla",
    "Type": "AnonymousAssociate",
    "GroupIdx": 233,
    "FullName": "Kendall Prosacco",
    "FormalName": "Runte LLC",
    "Deleted": true,
    "EjUserId": 481,
    "UserName": "Kuhlman Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 40
      }
    }
  },
  "Contact": {
    "ContactId": 961,
    "Name": "Padberg, Sipes and Smith",
    "OrgNr": "523530",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "non",
    "DirectPhone": "788.082.0268 x1271",
    "AssociateId": 412,
    "CountryId": 252,
    "EmailAddress": "rylan_greenfelder@feeney.com",
    "Kananame": "vel",
    "EmailAddressName": "lois@lowe.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ms. Dario McKenzie",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "cupiditate",
    "FullName": "Loren Satterfield",
    "IsOwnerContact": false,
    "ActiveErpLinks": 133,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 670
      }
    }
  },
  "Project": {
    "ProjectId": 427,
    "Name": "Johnston Group",
    "Description": "Down-sized uniform matrix",
    "URL": "http://www.example.com/",
    "Type": "voluptas",
    "AssociateId": 743,
    "AssociateFullName": "Kylee Gerlach",
    "TypeId": 394,
    "Updated": "2006-07-07T16:48:29.3999308+02:00",
    "StatusId": 215,
    "Status": "quidem",
    "TextId": 270,
    "PublishTo": "1999-03-13T16:48:29.3999308+01:00",
    "PublishFrom": "2004-05-11T16:48:29.3999308+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1310176",
    "ActiveErpLinks": 336,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 706
      }
    }
  },
  "Date": "1995-08-28T16:48:29.3999308+02:00",
  "ExternalRef": "quibusdam",
  "Completed": "Completed",
  "ActiveLinks": 348,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Champlin-Schmitt",
      "Id": 312,
      "Description": "Balanced foreground throughput",
      "ExtraInfo": "pariatur",
      "LinkId": 145,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 244
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Cruickshank, Emmerich and Beier",
    "SaleDate": "2019-10-18T16:48:29.3999308+02:00",
    "SaleId": 249,
    "Probability": 602,
    "Title": "et",
    "Amount": 3629.172,
    "Currency": "modi",
    "ProjectName": "Upton, Hudson and Zieme",
    "AssociateFullName": "Dr. Clair Bode",
    "Description": "Cloned even-keeled firmware",
    "Status": "Lost",
    "WeightedAmount": 12529.732,
    "ProjectId": 671,
    "EarningPercent": 24758.6,
    "Earning": 25491.956,
    "ContactId": 507,
    "AssociateId": 397,
    "PersonId": 491,
    "SaleTypeId": 419,
    "SaleTypeName": "Howe Group",
    "PersonFullName": "Kory Kling II",
    "Completed": "Completed",
    "ActiveErpLinks": 856,
    "NextDueDate": "2011-07-24T16:48:29.4009246+02:00",
    "Number": "381977",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 481
      }
    }
  },
  "SuggestedDocumentId": 458,
  "Snum": 149,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Dariana Murphy",
    "SuperOffice:2": "Geovanni Kling"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "dicta",
    "CustomFields2": "tenetur"
  },
  "PublishEventDate": "2015-07-29T16:48:29.4009246+02:00",
  "PublishTo": "2009-11-02T16:48:29.4009246+01:00",
  "PublishFrom": "2004-06-01T16:48:29.4009246+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 234,
      "Visibility": "All",
      "DisplayValue": "neque",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    },
    {
      "VisibleId": 234,
      "Visibility": "All",
      "DisplayValue": "neque",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 621
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
      "FieldLength": 367
    }
  }
}
```