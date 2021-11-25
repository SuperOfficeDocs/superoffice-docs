---
title: POST Agents/Document/SetDocumentStreamFromId
id: v1DocumentAgent_SetDocumentStreamFromId
---

# POST Agents/Document/SetDocumentStreamFromId

```http
POST /api/v1/Agents/Document/SetDocumentStreamFromId
```

Store document content from stream.

Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/SetDocumentStreamFromId?$select=name,department,category/id
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

DocumentId, Stream 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | int32 |  |
| Stream | byte |  |


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
POST /api/v1/Agents/Document/SetDocumentStreamFromId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 340,
  "Stream": "GIF89....File contents as raw bytes..."
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 522,
  "UpdatedBy": {
    "AssociateId": 172,
    "Name": "Kuhlman Inc and Sons",
    "PersonId": 728,
    "Rank": 484,
    "Tooltip": "impedit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 214,
    "FullName": "Ulises O'Reilly",
    "FormalName": "Hammes-Beer",
    "Deleted": true,
    "EjUserId": 166,
    "UserName": "Herzog LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 78
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 226,
    "Name": "Pouros, Moore and Altenwerth",
    "PersonId": 953,
    "Rank": 320,
    "Tooltip": "fugiat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 303,
    "FullName": "Alexander Hane",
    "FormalName": "Lowe, Auer and Homenick",
    "Deleted": true,
    "EjUserId": 888,
    "UserName": "Cruickshank Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 487
      }
    }
  },
  "Attention": "doloribus",
  "Header": "sed",
  "Name": "Harber, Zieme and Kuphal",
  "OurRef": "eveniet",
  "YourRef": "est",
  "CreatedDate": "2014-10-03T18:28:48.7979565+02:00",
  "UpdatedDate": "2013-09-06T18:28:48.7979565+02:00",
  "Description": "Programmable solution-oriented projection",
  "DocumentTemplate": {
    "DocumentTemplateId": 21,
    "Name": "Considine Group",
    "Tooltip": "aut",
    "SaveInDb": 501,
    "Filename": "perferendis",
    "DefaultOref": "aut",
    "RecordType": "Appointment",
    "Deleted": 728,
    "Direction": "Incoming",
    "AutoeventId": 88,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 834
      }
    }
  },
  "Person": {
    "Position": "non",
    "PersonId": 443,
    "Mrmrs": "dolorem",
    "Firstname": "Amira",
    "Lastname": "O'Keefe",
    "MiddleName": "Monahan, Corkery and McDermott",
    "Title": "suscipit",
    "Description": "Focused stable core",
    "Email": "lura.denesik@kingrosenbaum.co.uk",
    "FullName": "Ignatius Watsica",
    "DirectPhone": "(057)738-1471",
    "FormalName": "Koelpin Inc and Sons",
    "CountryId": 579,
    "ContactId": 60,
    "ContactName": "Pfeffer, Moore and Reinger",
    "Retired": 433,
    "Rank": 991,
    "ActiveInterests": 850,
    "ContactDepartment": "",
    "ContactCountryId": 820,
    "ContactOrgNr": "290419",
    "FaxPhone": "1-263-031-5803",
    "MobilePhone": "031.335.5708 x3833",
    "ContactPhone": "1-401-185-2676 x4053",
    "AssociateName": "O'Reilly-Bayer",
    "AssociateId": 514,
    "UsePersonAddress": false,
    "ContactFax": "reprehenderit",
    "Kanafname": "quidem",
    "Kanalname": "et",
    "Post1": "laboriosam",
    "Post2": "ea",
    "Post3": "debitis",
    "EmailName": "margie@morissette.name",
    "ContactFullName": "Carmen Rogahn",
    "ActiveErpLinks": 667,
    "TicketPriorityId": 307,
    "SupportLanguageId": 634,
    "SupportAssociateId": 932,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 468
      }
    }
  },
  "Associate": {
    "AssociateId": 262,
    "Name": "Homenick-Kling",
    "PersonId": 781,
    "Rank": 323,
    "Tooltip": "odio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 211,
    "FullName": "Earnest Dooley",
    "FormalName": "Bartoletti Group",
    "Deleted": true,
    "EjUserId": 392,
    "UserName": "Reinger, Bednar and Volkman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "scale next-generation models"
        },
        "FieldType": "System.String",
        "FieldLength": 6
      }
    }
  },
  "Contact": {
    "ContactId": 529,
    "Name": "Dicki-Smith",
    "OrgNr": "749502",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "error",
    "DirectPhone": "(330)065-7432 x74106",
    "AssociateId": 413,
    "CountryId": 347,
    "EmailAddress": "dejah@watsica.uk",
    "Kananame": "qui",
    "EmailAddressName": "isabell_casper@heidenreichterry.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Francisca Yost",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "qui",
    "FullName": "Savannah Grimes",
    "IsOwnerContact": true,
    "ActiveErpLinks": 674,
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
  "Project": {
    "ProjectId": 61,
    "Name": "Schinner Inc and Sons",
    "Description": "Ergonomic systematic time-frame",
    "URL": "http://www.example.com/",
    "Type": "illo",
    "AssociateId": 636,
    "AssociateFullName": "Sarai Zboncak",
    "TypeId": 433,
    "Updated": "1995-09-14T18:28:48.8019515+02:00",
    "StatusId": 277,
    "Status": "dignissimos",
    "TextId": 616,
    "PublishTo": "2004-09-19T18:28:48.8019515+02:00",
    "PublishFrom": "2010-07-02T18:28:48.8019515+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "905270",
    "ActiveErpLinks": 752,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 270
      }
    }
  },
  "Date": "2004-06-23T18:28:48.8019515+02:00",
  "ExternalRef": "eos",
  "Completed": "Completed",
  "ActiveLinks": 441,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Hane-Flatley",
      "Id": 101,
      "Description": "Ameliorated interactive standardization",
      "ExtraInfo": "aliquid",
      "LinkId": 996,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 341
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Russel, Johnson and Nienow",
    "SaleDate": "2001-08-05T18:28:48.8019515+02:00",
    "SaleId": 646,
    "Probability": 770,
    "Title": "ut",
    "Amount": 17356.092,
    "Currency": "quia",
    "ProjectName": "Johns-Jenkins",
    "AssociateFullName": "Emerald Lockman",
    "Description": "Automated leading edge throughput",
    "Status": "Lost",
    "WeightedAmount": 10749.619999999999,
    "ProjectId": 594,
    "EarningPercent": 2864.476,
    "Earning": 17302.814,
    "ContactId": 108,
    "AssociateId": 77,
    "PersonId": 486,
    "SaleTypeId": 170,
    "SaleTypeName": "Huels Inc and Sons",
    "PersonFullName": "Maxine Kilback MD",
    "Completed": "Completed",
    "ActiveErpLinks": 699,
    "NextDueDate": "2001-07-31T18:28:48.8029296+02:00",
    "Number": "636575",
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
  "SuggestedDocumentId": 382,
  "Snum": 890,
  "UserDefinedFields": {
    "SuperOffice:1": "Adelia Hyatt",
    "SuperOffice:2": "Hildegard Simonis"
  },
  "ExtraFields": {
    "ExtraFields1": "consectetur",
    "ExtraFields2": "eligendi"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "fuga"
  },
  "PublishEventDate": "2021-04-13T18:28:48.8049283+02:00",
  "PublishTo": "2014-08-12T18:28:48.8049283+02:00",
  "PublishFrom": "2002-03-25T18:28:48.8049283+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 15,
      "Visibility": "All",
      "DisplayValue": "corporis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 799
        }
      }
    },
    {
      "VisibleId": 15,
      "Visibility": "All",
      "DisplayValue": "corporis",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 799
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
      "FieldLength": 224
    }
  }
}
```