---
title: POST Agents/Document/CreateNewPhysicalMailMergeDocumentFromTemplate
id: v1DocumentAgent_CreateNewPhysicalMailMergeDocumentFromTemplate
---

# POST Agents/Document/CreateNewPhysicalMailMergeDocumentFromTemplate

```http
POST /api/v1/Agents/Document/CreateNewPhysicalMailMergeDocumentFromTemplate
```

Create a new physical document based on the documents template.

Do not replace template tags, as the document is going to be used as a mail merge source. Use GetDocumentStream to obtain the created documents. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/CreateNewPhysicalMailMergeDocumentFromTemplate?$select=name,department,category/id
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

DocumentId, UiCulture 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | int32 |  |
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
POST /api/v1/Agents/Document/CreateNewPhysicalMailMergeDocumentFromTemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 475,
  "UiCulture": "et"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 284,
  "UpdatedBy": {
    "AssociateId": 254,
    "Name": "Beer, Macejkovic and Krajcik",
    "PersonId": 134,
    "Rank": 796,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 232,
    "FullName": "Ted Blanda II",
    "FormalName": "Senger, Koepp and Graham",
    "Deleted": true,
    "EjUserId": 906,
    "UserName": "Olson Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 804
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 469,
    "Name": "Lakin LLC",
    "PersonId": 339,
    "Rank": 899,
    "Tooltip": "aliquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 254,
    "FullName": "Jadyn Hyatt DVM",
    "FormalName": "Robel Group",
    "Deleted": true,
    "EjUserId": 440,
    "UserName": "O'Reilly, Tremblay and Stroman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "synergize dynamic methodologies"
        },
        "FieldType": "System.Int32",
        "FieldLength": 365
      }
    }
  },
  "Attention": "incidunt",
  "Header": "asperiores",
  "Name": "Goodwin-Schuppe",
  "OurRef": "at",
  "YourRef": "debitis",
  "CreatedDate": "2020-10-21T18:28:48.8869686+02:00",
  "UpdatedDate": "2005-05-31T18:28:48.8869686+02:00",
  "Description": "Organized dedicated secured line",
  "DocumentTemplate": {
    "DocumentTemplateId": 90,
    "Name": "Daugherty, VonRueden and Rice",
    "Tooltip": "consequatur",
    "SaveInDb": 306,
    "Filename": "sunt",
    "DefaultOref": "nobis",
    "RecordType": "Appointment",
    "Deleted": 925,
    "Direction": "Incoming",
    "AutoeventId": 215,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "redefine web-enabled niches"
        },
        "FieldType": "System.Int32",
        "FieldLength": 818
      }
    }
  },
  "Person": {
    "Position": "ut",
    "PersonId": 215,
    "Mrmrs": "delectus",
    "Firstname": "Lisandro",
    "Lastname": "Greenfelder",
    "MiddleName": "Mante Inc and Sons",
    "Title": "velit",
    "Description": "Self-enabling bi-directional migration",
    "Email": "heaven_stiedemann@aufderhar.us",
    "FullName": "Jessica Ondricka",
    "DirectPhone": "732-365-3841 x33428",
    "FormalName": "Bruen LLC",
    "CountryId": 111,
    "ContactId": 410,
    "ContactName": "Connelly LLC",
    "Retired": 562,
    "Rank": 797,
    "ActiveInterests": 549,
    "ContactDepartment": "",
    "ContactCountryId": 799,
    "ContactOrgNr": "1689893",
    "FaxPhone": "(827)472-8563",
    "MobilePhone": "1-150-336-0012",
    "ContactPhone": "266.064.1351",
    "AssociateName": "Thompson-Kohler",
    "AssociateId": 35,
    "UsePersonAddress": false,
    "ContactFax": "aspernatur",
    "Kanafname": "dolor",
    "Kanalname": "aliquid",
    "Post1": "earum",
    "Post2": "dolorem",
    "Post3": "qui",
    "EmailName": "jesus@runolfsson.ca",
    "ContactFullName": "Mr. Nyasia Schuster",
    "ActiveErpLinks": 580,
    "TicketPriorityId": 378,
    "SupportLanguageId": 506,
    "SupportAssociateId": 375,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 694
      }
    }
  },
  "Associate": {
    "AssociateId": 563,
    "Name": "Murphy Group",
    "PersonId": 965,
    "Rank": 200,
    "Tooltip": "autem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 292,
    "FullName": "Mariana Eichmann",
    "FormalName": "Brakus Group",
    "Deleted": false,
    "EjUserId": 829,
    "UserName": "Veum-Walter",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 55
      }
    }
  },
  "Contact": {
    "ContactId": 278,
    "Name": "Schmitt LLC",
    "OrgNr": "1062461",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "magni",
    "DirectPhone": "154.655.5461 x05325",
    "AssociateId": 490,
    "CountryId": 54,
    "EmailAddress": "leslie@muller.name",
    "Kananame": "tenetur",
    "EmailAddressName": "thea@durgan.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mrs. Vesta Hickle",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "illo",
    "FullName": "Diego Heathcote",
    "IsOwnerContact": true,
    "ActiveErpLinks": 229,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 852
      }
    }
  },
  "Project": {
    "ProjectId": 532,
    "Name": "Kuhlman, Bartell and Little",
    "Description": "Synergized executive focus group",
    "URL": "http://www.example.com/",
    "Type": "fuga",
    "AssociateId": 660,
    "AssociateFullName": "Miss Haskell Okuneva",
    "TypeId": 439,
    "Updated": "2006-10-30T18:28:48.8899617+01:00",
    "StatusId": 427,
    "Status": "cupiditate",
    "TextId": 178,
    "PublishTo": "2013-04-15T18:28:48.8899617+02:00",
    "PublishFrom": "2016-05-23T18:28:48.8899617+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1595719",
    "ActiveErpLinks": 351,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 484
      }
    }
  },
  "Date": "1996-06-07T18:28:48.8899617+02:00",
  "ExternalRef": "odit",
  "Completed": "Completed",
  "ActiveLinks": 38,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Frami Inc and Sons",
      "Id": 720,
      "Description": "Synergized bifurcated portal",
      "ExtraInfo": "ut",
      "LinkId": 267,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 679
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Considine Group",
    "SaleDate": "2016-01-01T18:28:48.8899617+01:00",
    "SaleId": 685,
    "Probability": 334,
    "Title": "hic",
    "Amount": 16513.046,
    "Currency": "sequi",
    "ProjectName": "Conroy, Rempel and Bernhard",
    "AssociateFullName": "Merle Mueller",
    "Description": "Synergistic explicit circuit",
    "Status": "Lost",
    "WeightedAmount": 25222.432,
    "ProjectId": 304,
    "EarningPercent": 5468.83,
    "Earning": 14359.988,
    "ContactId": 485,
    "AssociateId": 31,
    "PersonId": 334,
    "SaleTypeId": 502,
    "SaleTypeName": "Dibbert, Johns and Kiehn",
    "PersonFullName": "Scarlett Keebler",
    "Completed": "Completed",
    "ActiveErpLinks": 354,
    "NextDueDate": "2015-06-12T18:28:48.8909632+02:00",
    "Number": "438642",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 419
      }
    }
  },
  "SuggestedDocumentId": 603,
  "Snum": 947,
  "UserDefinedFields": {
    "SuperOffice:1": "Anika Cole II",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsa",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "non"
  },
  "PublishEventDate": "1995-05-19T18:28:48.8909632+02:00",
  "PublishTo": "2013-08-10T18:28:48.8909632+02:00",
  "PublishFrom": "2002-10-16T18:28:48.8909632+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 196,
      "Visibility": "All",
      "DisplayValue": "enim",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 811
        }
      }
    },
    {
      "VisibleId": 196,
      "Visibility": "All",
      "DisplayValue": "enim",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 811
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
      "FieldLength": 131
    }
  }
}
```