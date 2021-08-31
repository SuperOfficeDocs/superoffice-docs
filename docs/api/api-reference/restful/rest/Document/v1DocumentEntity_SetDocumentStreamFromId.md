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
  "DocumentId": 152,
  "UpdatedBy": {
    "AssociateId": 724,
    "Name": "Lockman-Dooley",
    "PersonId": 5,
    "Rank": 740,
    "Tooltip": "animi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 24,
    "FullName": "Hollie Carter",
    "FormalName": "Bosco Group",
    "Deleted": true,
    "EjUserId": 979,
    "UserName": "Boehm, Schulist and Altenwerth",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "enhance front-end supply-chains"
        },
        "FieldType": "System.Int32",
        "FieldLength": 605
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 105,
    "Name": "Crist Inc and Sons",
    "PersonId": 399,
    "Rank": 688,
    "Tooltip": "recusandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 448,
    "FullName": "Lorenza Dicki",
    "FormalName": "Baumbach Inc and Sons",
    "Deleted": false,
    "EjUserId": 371,
    "UserName": "Breitenberg, Graham and Toy",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "brand frictionless models"
        },
        "FieldType": "System.String",
        "FieldLength": 452
      }
    }
  },
  "Attention": "nihil",
  "Header": "est",
  "Name": "Hamill, Armstrong and Dibbert",
  "OurRef": "quisquam",
  "YourRef": "est",
  "CreatedDate": "2021-05-28T15:05:42.1456351+02:00",
  "UpdatedDate": "2011-02-22T15:05:42.1456351+01:00",
  "Description": "Operative mission-critical hierarchy",
  "DocumentTemplate": {
    "DocumentTemplateId": 623,
    "Name": "Will, Shields and Kub",
    "Tooltip": "quo",
    "SaveInDb": 110,
    "Filename": "non",
    "DefaultOref": "aperiam",
    "RecordType": "Appointment",
    "Deleted": 61,
    "Direction": "Incoming",
    "AutoeventId": 812,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 987
      }
    }
  },
  "Person": {
    "Position": "est",
    "PersonId": 30,
    "Mrmrs": "autem",
    "Firstname": "Lydia",
    "Lastname": "Eichmann",
    "MiddleName": "Goodwin-Labadie",
    "Title": "molestias",
    "Description": "Adaptive non-volatile project",
    "Email": "lincoln.ebert@lindpagac.co.uk",
    "FullName": "Camille Schaefer",
    "DirectPhone": "(574)244-4318 x6154",
    "FormalName": "Bauch-Purdy",
    "CountryId": 850,
    "ContactId": 530,
    "ContactName": "Heaney-Daugherty",
    "Retired": 135,
    "Rank": 859,
    "ActiveInterests": 607,
    "ContactDepartment": "",
    "ContactCountryId": 538,
    "ContactOrgNr": "959251",
    "FaxPhone": "(185)855-6178 x4256",
    "MobilePhone": "(350)853-0512 x36666",
    "ContactPhone": "084.674.5702 x40500",
    "AssociateName": "Hoppe-Wolff",
    "AssociateId": 252,
    "UsePersonAddress": true,
    "ContactFax": "omnis",
    "Kanafname": "voluptatem",
    "Kanalname": "enim",
    "Post1": "libero",
    "Post2": "sint",
    "Post3": "corrupti",
    "EmailName": "wanda@hodkiewiczcummings.name",
    "ContactFullName": "Dr. Anthony Daniel",
    "ActiveErpLinks": 867,
    "TicketPriorityId": 345,
    "SupportLanguageId": 892,
    "SupportAssociateId": 965,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "incentivize visionary e-services"
        },
        "FieldType": "System.String",
        "FieldLength": 457
      }
    }
  },
  "Associate": {
    "AssociateId": 527,
    "Name": "Kohler-Bartoletti",
    "PersonId": 220,
    "Rank": 583,
    "Tooltip": "eos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 649,
    "FullName": "Mrs. Alanna Walter",
    "FormalName": "Ledner-Padberg",
    "Deleted": true,
    "EjUserId": 388,
    "UserName": "Johnson, Boyle and Hammes",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 209
      }
    }
  },
  "Contact": {
    "ContactId": 250,
    "Name": "Jacobson LLC",
    "OrgNr": "984353",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "totam",
    "DirectPhone": "(383)561-4617",
    "AssociateId": 38,
    "CountryId": 480,
    "EmailAddress": "lafayette_watsica@barton.info",
    "Kananame": "nulla",
    "EmailAddressName": "della@kutch.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Eugene Carter",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "sit",
    "FullName": "Waldo Hansen",
    "IsOwnerContact": false,
    "ActiveErpLinks": 937,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 504
      }
    }
  },
  "Project": {
    "ProjectId": 172,
    "Name": "Mosciski, Schultz and Shanahan",
    "Description": "Programmable methodical workforce",
    "URL": "http://www.example.com/",
    "Type": "veniam",
    "AssociateId": 275,
    "AssociateFullName": "Barton Bauch",
    "TypeId": 330,
    "Updated": "1999-11-07T15:05:42.148635+01:00",
    "StatusId": 660,
    "Status": "magnam",
    "TextId": 297,
    "PublishTo": "1997-08-09T15:05:42.148635+02:00",
    "PublishFrom": "2002-07-16T15:05:42.148635+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "407534",
    "ActiveErpLinks": 108,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 495
      }
    }
  },
  "Date": "2011-01-18T15:05:42.148635+01:00",
  "ExternalRef": "explicabo",
  "Completed": "Completed",
  "ActiveLinks": 205,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Pfannerstill LLC",
      "Id": 842,
      "Description": "Enterprise-wide zero tolerance circuit",
      "ExtraInfo": "velit",
      "LinkId": 488,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 932
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Padberg-Brown",
    "SaleDate": "2004-07-31T15:05:42.1496354+02:00",
    "SaleId": 474,
    "Probability": 412,
    "Title": "iste",
    "Amount": 22571.068,
    "Currency": "dolores",
    "ProjectName": "Orn, Treutel and Johnson",
    "AssociateFullName": "Nikolas Smitham",
    "Description": "Synchronised incremental toolset",
    "Status": "Lost",
    "WeightedAmount": 12877.606,
    "ProjectId": 61,
    "EarningPercent": 27811.115999999998,
    "Earning": 16362.614,
    "ContactId": 527,
    "AssociateId": 954,
    "PersonId": 773,
    "SaleTypeId": 800,
    "SaleTypeName": "Koelpin LLC",
    "PersonFullName": "Raul Daugherty DVM",
    "Completed": "Completed",
    "ActiveErpLinks": 733,
    "NextDueDate": "2019-10-21T15:05:42.1496354+02:00",
    "Number": "938842",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "transform B2C convergence"
        },
        "FieldType": "System.String",
        "FieldLength": 779
      }
    }
  },
  "SuggestedDocumentId": 736,
  "Snum": 551,
  "UserDefinedFields": {
    "SuperOffice:1": "Elmer Shanahan",
    "SuperOffice:2": "Valentin Torp"
  },
  "ExtraFields": {
    "ExtraFields1": "repellendus",
    "ExtraFields2": "libero"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "vitae"
  },
  "PublishEventDate": "2015-01-10T15:05:42.1496354+01:00",
  "PublishTo": "2000-08-17T15:05:42.1496354+02:00",
  "PublishFrom": "2020-08-19T15:05:42.1496354+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 784,
      "Visibility": "All",
      "DisplayValue": "doloribus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 15
        }
      }
    },
    {
      "VisibleId": 784,
      "Visibility": "All",
      "DisplayValue": "doloribus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 15
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
      "FieldLength": 316
    }
  }
}
```