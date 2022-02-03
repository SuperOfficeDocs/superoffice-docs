---
title: POST Agents/Document/CreateDefaultDocumentEntityFromSuggestion
id: v1DocumentAgent_CreateDefaultDocumentEntityFromSuggestion
---

# POST Agents/Document/CreateDefaultDocumentEntityFromSuggestion

```http
POST /api/v1/Agents/Document/CreateDefaultDocumentEntityFromSuggestion
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/CreateDefaultDocumentEntityFromSuggestion?$select=name,department,category/id
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

SuggestedDocumentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SuggestedDocumentId | int32 |  |


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
POST /api/v1/Agents/Document/CreateDefaultDocumentEntityFromSuggestion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SuggestedDocumentId": 862
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 86,
  "UpdatedBy": {
    "AssociateId": 95,
    "Name": "Wolf-Kris",
    "PersonId": 382,
    "Rank": 820,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 170,
    "FullName": "Mr. Krystina Quitzon",
    "FormalName": "Schowalter-Bogan",
    "Deleted": true,
    "EjUserId": 629,
    "UserName": "Stark-Kshlerin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 496
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 857,
    "Name": "Dicki-Boyer",
    "PersonId": 167,
    "Rank": 456,
    "Tooltip": "praesentium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 962,
    "FullName": "Cameron Homenick",
    "FormalName": "Mante, Jaskolski and Corwin",
    "Deleted": false,
    "EjUserId": 728,
    "UserName": "Terry-Rutherford",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 723
      }
    }
  },
  "Attention": "fugit",
  "Header": "est",
  "Name": "Rowe-Reichel",
  "OurRef": "sapiente",
  "YourRef": "illum",
  "CreatedDate": "2018-02-28T18:28:48.7439565+01:00",
  "UpdatedDate": "2021-11-01T18:28:48.7439565+01:00",
  "Description": "Organized national attitude",
  "DocumentTemplate": {
    "DocumentTemplateId": 652,
    "Name": "Watsica-Weber",
    "Tooltip": "nobis",
    "SaveInDb": 859,
    "Filename": "sit",
    "DefaultOref": "corrupti",
    "RecordType": "Appointment",
    "Deleted": 620,
    "Direction": "Incoming",
    "AutoeventId": 170,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 391
      }
    }
  },
  "Person": {
    "Position": "qui",
    "PersonId": 524,
    "Mrmrs": "et",
    "Firstname": "Jessica",
    "Lastname": "Wolff",
    "MiddleName": "McLaughlin Inc and Sons",
    "Title": "voluptatem",
    "Description": "Realigned radical attitude",
    "Email": "rex.monahan@funkschaefer.us",
    "FullName": "Donavon Herman I",
    "DirectPhone": "(232)522-8107 x45667",
    "FormalName": "Mayert LLC",
    "CountryId": 650,
    "ContactId": 867,
    "ContactName": "Hirthe, Moen and King",
    "Retired": 835,
    "Rank": 777,
    "ActiveInterests": 135,
    "ContactDepartment": "",
    "ContactCountryId": 174,
    "ContactOrgNr": "1196330",
    "FaxPhone": "(207)161-7378",
    "MobilePhone": "(078)748-8586 x3886",
    "ContactPhone": "(641)406-8335 x85544",
    "AssociateName": "Adams Inc and Sons",
    "AssociateId": 683,
    "UsePersonAddress": false,
    "ContactFax": "quo",
    "Kanafname": "rerum",
    "Kanalname": "numquam",
    "Post1": "repudiandae",
    "Post2": "eum",
    "Post3": "accusamus",
    "EmailName": "preston@halvorsongleason.uk",
    "ContactFullName": "Valentina Bashirian",
    "ActiveErpLinks": 423,
    "TicketPriorityId": 618,
    "SupportLanguageId": 173,
    "SupportAssociateId": 532,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 443
      }
    }
  },
  "Associate": {
    "AssociateId": 483,
    "Name": "Toy-Flatley",
    "PersonId": 181,
    "Rank": 285,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 950,
    "FullName": "Wyatt Beer",
    "FormalName": "Lowe LLC",
    "Deleted": true,
    "EjUserId": 215,
    "UserName": "Bauch, Daniel and Will",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "innovate efficient initiatives"
        },
        "FieldType": "System.Int32",
        "FieldLength": 818
      }
    }
  },
  "Contact": {
    "ContactId": 109,
    "Name": "Trantow LLC",
    "OrgNr": "1359650",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "et",
    "DirectPhone": "(446)640-8830",
    "AssociateId": 727,
    "CountryId": 438,
    "EmailAddress": "jeanne@gleichner.info",
    "Kananame": "excepturi",
    "EmailAddressName": "bennie_reilly@reynoldsvonrueden.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Cecile Carter",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "totam",
    "FullName": "Emiliano Ledner",
    "IsOwnerContact": true,
    "ActiveErpLinks": 212,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 583
      }
    }
  },
  "Project": {
    "ProjectId": 816,
    "Name": "Bosco Group",
    "Description": "Customer-focused fresh-thinking instruction set",
    "URL": "http://www.example.com/",
    "Type": "commodi",
    "AssociateId": 643,
    "AssociateFullName": "Betty Murphy",
    "TypeId": 413,
    "Updated": "1998-09-25T18:28:48.7459561+02:00",
    "StatusId": 55,
    "Status": "est",
    "TextId": 165,
    "PublishTo": "2005-09-15T18:28:48.7459561+02:00",
    "PublishFrom": "2011-03-19T18:28:48.7459561+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1501248",
    "ActiveErpLinks": 972,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 874
      }
    }
  },
  "Date": "2013-04-22T18:28:48.7459561+02:00",
  "ExternalRef": "cumque",
  "Completed": "Completed",
  "ActiveLinks": 40,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Murray-Ritchie",
      "Id": 595,
      "Description": "Open-architected systematic functionalities",
      "ExtraInfo": "voluptatum",
      "LinkId": 649,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 681
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Johnston, Toy and Dare",
    "SaleDate": "2016-08-31T18:28:48.7469561+02:00",
    "SaleId": 624,
    "Probability": 210,
    "Title": "cumque",
    "Amount": 805.438,
    "Currency": "recusandae",
    "ProjectName": "Bechtelar Group",
    "AssociateFullName": "Gaetano McLaughlin",
    "Description": "Cross-group empowering Graphical User Interface",
    "Status": "Lost",
    "WeightedAmount": 4064.798,
    "ProjectId": 652,
    "EarningPercent": 22906.406,
    "Earning": 153.566,
    "ContactId": 388,
    "AssociateId": 469,
    "PersonId": 910,
    "SaleTypeId": 622,
    "SaleTypeName": "Gibson, Treutel and Leffler",
    "PersonFullName": "Damaris Schowalter",
    "Completed": "Completed",
    "ActiveErpLinks": 849,
    "NextDueDate": "2003-07-19T18:28:48.7469561+02:00",
    "Number": "404703",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 927
      }
    }
  },
  "SuggestedDocumentId": 56,
  "Snum": 756,
  "UserDefinedFields": {
    "SuperOffice:1": "1773662061",
    "SuperOffice:2": "Fay Walker"
  },
  "ExtraFields": {
    "ExtraFields1": "exercitationem",
    "ExtraFields2": "dignissimos"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2019-09-13T18:28:48.7469561+02:00",
  "PublishTo": "2015-03-10T18:28:48.7469561+01:00",
  "PublishFrom": "1995-03-30T18:28:48.7469561+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 803,
      "Visibility": "All",
      "DisplayValue": "aut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 24
        }
      }
    },
    {
      "VisibleId": 803,
      "Visibility": "All",
      "DisplayValue": "aut",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 24
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
      "FieldLength": 952
    }
  }
}
```