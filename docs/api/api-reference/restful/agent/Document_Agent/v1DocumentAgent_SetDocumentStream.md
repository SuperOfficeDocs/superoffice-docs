---
title: SetDocumentStream
id: v1DocumentAgent_SetDocumentStream
---

# SetDocumentStream

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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DocumentEntity": {
    "DocumentId": 803,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "possimus",
    "Header": "odit",
    "Name": "Casper LLC",
    "OurRef": "vel",
    "YourRef": "consequuntur",
    "CreatedDate": "2020-06-07T14:58:03.9644605+02:00",
    "UpdatedDate": "1997-10-14T14:58:03.9644605+02:00",
    "Description": "Profound human-resource instruction set",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "2017-02-10T14:58:03.9644605+01:00",
    "ExternalRef": "quas",
    "Completed": "Completed",
    "ActiveLinks": 945,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 125,
    "Snum": 243,
    "UserDefinedFields": {
      "SuperOffice:1": "False",
      "SuperOffice:2": "31191820"
    },
    "ExtraFields": {
      "ExtraFields1": "consequatur",
      "ExtraFields2": "veritatis"
    },
    "CustomFields": {
      "CustomFields1": "odio",
      "CustomFields2": "aperiam"
    },
    "PublishEventDate": "1995-02-15T14:58:03.9644605+01:00",
    "PublishTo": "1998-10-27T14:58:03.9644605+01:00",
    "PublishFrom": "2019-07-03T14:58:03.9644605+02:00",
    "IsPublished": false,
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
  "DocumentId": 607,
  "UpdatedBy": {
    "AssociateId": 74,
    "Name": "Zemlak, Cormier and Steuber",
    "PersonId": 883,
    "Rank": 121,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 343,
    "FullName": "Weldon Orn",
    "FormalName": "Bayer-Hintz",
    "Deleted": true,
    "EjUserId": 977,
    "UserName": "Thompson-Green",
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
  "CreatedBy": {
    "AssociateId": 128,
    "Name": "Schowalter-Pagac",
    "PersonId": 914,
    "Rank": 359,
    "Tooltip": "minus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 443,
    "FullName": "Katheryn Bartell PhD",
    "FormalName": "Gibson-Luettgen",
    "Deleted": false,
    "EjUserId": 486,
    "UserName": "Blanda Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 920
      }
    }
  },
  "Attention": "a",
  "Header": "repellendus",
  "Name": "McClure LLC",
  "OurRef": "facere",
  "YourRef": "unde",
  "CreatedDate": "2004-01-29T14:58:03.9714606+01:00",
  "UpdatedDate": "2018-06-12T14:58:03.9714606+02:00",
  "Description": "Visionary hybrid customer loyalty",
  "DocumentTemplate": {
    "DocumentTemplateId": 176,
    "Name": "Simonis Group",
    "Tooltip": "sunt",
    "SaveInDb": 119,
    "Filename": "minus",
    "DefaultOref": "molestiae",
    "RecordType": "Appointment",
    "Deleted": 195,
    "Direction": "Incoming",
    "AutoeventId": 479,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 260
      }
    }
  },
  "Person": {
    "Position": "impedit",
    "PersonId": 362,
    "Mrmrs": "rerum",
    "Firstname": "Ila",
    "Lastname": "Cole",
    "MiddleName": "Rau, Von and O'Keefe",
    "Title": "optio",
    "Description": "Streamlined logistical protocol",
    "Email": "rod_pfeffer@breitenberg.biz",
    "FullName": "Gloria Hodkiewicz",
    "DirectPhone": "1-451-322-4717",
    "FormalName": "Williamson-Gibson",
    "CountryId": 904,
    "ContactId": 816,
    "ContactName": "Jones-O'Conner",
    "Retired": 364,
    "Rank": 803,
    "ActiveInterests": 662,
    "ContactDepartment": "",
    "ContactCountryId": 183,
    "ContactOrgNr": "953274",
    "FaxPhone": "852-860-6612 x404",
    "MobilePhone": "087.836.5125 x250",
    "ContactPhone": "443.047.3741 x141",
    "AssociateName": "Renner-Lebsack",
    "AssociateId": 852,
    "UsePersonAddress": true,
    "ContactFax": "voluptas",
    "Kanafname": "eligendi",
    "Kanalname": "modi",
    "Post1": "neque",
    "Post2": "eligendi",
    "Post3": "et",
    "EmailName": "art.dare@oconner.uk",
    "ContactFullName": "Lorna Gerlach",
    "ActiveErpLinks": 302,
    "TicketPriorityId": 439,
    "SupportLanguageId": 561,
    "SupportAssociateId": 771,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 475
      }
    }
  },
  "Associate": {
    "AssociateId": 715,
    "Name": "Turner, Jerde and Gleason",
    "PersonId": 887,
    "Rank": 788,
    "Tooltip": "modi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 352,
    "FullName": "Lucio Howell",
    "FormalName": "Kozey, Braun and Kris",
    "Deleted": true,
    "EjUserId": 310,
    "UserName": "Padberg LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 393
      }
    }
  },
  "Contact": {
    "ContactId": 256,
    "Name": "Kirlin, Satterfield and Nienow",
    "OrgNr": "1027015",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "voluptas",
    "DirectPhone": "(624)350-2558 x5053",
    "AssociateId": 497,
    "CountryId": 726,
    "EmailAddress": "alia@crooksstiedemann.info",
    "Kananame": "provident",
    "EmailAddressName": "ocie_ratke@johnson.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Howard Rice",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "vero",
    "FullName": "Amaya Gulgowski",
    "IsOwnerContact": false,
    "ActiveErpLinks": 906,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 602
      }
    }
  },
  "Project": {
    "ProjectId": 790,
    "Name": "Conroy-Bode",
    "Description": "Streamlined multi-tasking groupware",
    "URL": "http://www.example.com/",
    "Type": "consequatur",
    "AssociateId": 989,
    "AssociateFullName": "Terrence Sawayn",
    "TypeId": 860,
    "Updated": "2008-09-29T14:58:03.9754641+02:00",
    "StatusId": 521,
    "Status": "velit",
    "TextId": 227,
    "PublishTo": "2007-04-18T14:58:03.9754641+02:00",
    "PublishFrom": "2009-05-26T14:58:03.9754641+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1431973",
    "ActiveErpLinks": 868,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 651
      }
    }
  },
  "Date": "1995-07-18T14:58:03.9754641+02:00",
  "ExternalRef": "perferendis",
  "Completed": "Completed",
  "ActiveLinks": 992,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Marks Inc and Sons",
      "Id": 591,
      "Description": "Advanced mobile time-frame",
      "ExtraInfo": "placeat",
      "LinkId": 944,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 828
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Pfeffer-Gaylord",
    "SaleDate": "2017-01-05T14:58:03.9754641+01:00",
    "SaleId": 154,
    "Probability": 560,
    "Title": "iure",
    "Amount": 6725.5639999999994,
    "Currency": "soluta",
    "ProjectName": "Bartell Group",
    "AssociateFullName": "Miss Armand Schiller",
    "Description": "Synergized contextually-based throughput",
    "Status": "Lost",
    "WeightedAmount": 19092.327999999998,
    "ProjectId": 209,
    "EarningPercent": 28246.742,
    "Earning": 15400.475999999999,
    "ContactId": 608,
    "AssociateId": 930,
    "PersonId": 815,
    "SaleTypeId": 928,
    "SaleTypeName": "Schinner, Haag and O'Kon",
    "PersonFullName": "Christelle Roob",
    "Completed": "Completed",
    "ActiveErpLinks": 839,
    "NextDueDate": "2010-02-17T14:58:03.9754641+01:00",
    "Number": "732494",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 348
      }
    }
  },
  "SuggestedDocumentId": 928,
  "Snum": 769,
  "UserDefinedFields": {
    "SuperOffice:1": "341049895",
    "SuperOffice:2": "Lauretta Baumbach"
  },
  "ExtraFields": {
    "ExtraFields1": "beatae",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "tenetur",
    "CustomFields2": "sunt"
  },
  "PublishEventDate": "2013-10-10T14:58:03.9754641+02:00",
  "PublishTo": "2011-01-09T14:58:03.9754641+01:00",
  "PublishFrom": "1997-06-11T14:58:03.9754641+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 375,
      "Visibility": "All",
      "DisplayValue": "accusantium",
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
    {
      "VisibleId": 375,
      "Visibility": "All",
      "DisplayValue": "accusantium",
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
      "FieldLength": 567
    }
  }
}
```