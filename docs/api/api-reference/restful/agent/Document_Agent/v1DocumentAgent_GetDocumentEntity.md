---
title: GetDocumentEntity
id: v1DocumentAgent_GetDocumentEntity
---

# GetDocumentEntity

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
POST /api/v1/Agents/Document/GetDocumentEntity?documentEntityId=934
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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 10,
  "UpdatedBy": {
    "AssociateId": 673,
    "Name": "Hintz, Gislason and Okuneva",
    "PersonId": 356,
    "Rank": 919,
    "Tooltip": "ratione",
    "Type": "AnonymousAssociate",
    "GroupIdx": 320,
    "FullName": "Sigrid Gerlach",
    "FormalName": "Hartmann-Barton",
    "Deleted": true,
    "EjUserId": 715,
    "UserName": "Zboncak Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 76
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 147,
    "Name": "Moore LLC",
    "PersonId": 24,
    "Rank": 987,
    "Tooltip": "beatae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 478,
    "FullName": "Kyleigh Sipes",
    "FormalName": "Halvorson, Eichmann and Goodwin",
    "Deleted": true,
    "EjUserId": 567,
    "UserName": "Williamson-Purdy",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 339
      }
    }
  },
  "Attention": "sed",
  "Header": "cumque",
  "Name": "Ledner-Zulauf",
  "OurRef": "non",
  "YourRef": "pariatur",
  "CreatedDate": "2006-06-18T14:58:03.9594598+02:00",
  "UpdatedDate": "2006-01-17T14:58:03.9594598+01:00",
  "Description": "Fundamental object-oriented protocol",
  "DocumentTemplate": {
    "DocumentTemplateId": 394,
    "Name": "Hegmann LLC",
    "Tooltip": "assumenda",
    "SaveInDb": 739,
    "Filename": "optio",
    "DefaultOref": "veniam",
    "RecordType": "Appointment",
    "Deleted": 118,
    "Direction": "Incoming",
    "AutoeventId": 142,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 32
      }
    }
  },
  "Person": {
    "Position": "dolorem",
    "PersonId": 100,
    "Mrmrs": "officia",
    "Firstname": "Della",
    "Lastname": "Rippin",
    "MiddleName": "Hickle-Raynor",
    "Title": "incidunt",
    "Description": "Re-engineered bifurcated extranet",
    "Email": "audreanne_walker@koepp.us",
    "FullName": "Cielo Konopelski DDS",
    "DirectPhone": "637-766-2077 x1013",
    "FormalName": "Conn, Beatty and Blick",
    "CountryId": 971,
    "ContactId": 129,
    "ContactName": "Bode Inc and Sons",
    "Retired": 763,
    "Rank": 835,
    "ActiveInterests": 566,
    "ContactDepartment": "",
    "ContactCountryId": 161,
    "ContactOrgNr": "985119",
    "FaxPhone": "787-630-3030 x710",
    "MobilePhone": "527.011.0453 x5018",
    "ContactPhone": "1-802-643-0265",
    "AssociateName": "Mueller Inc and Sons",
    "AssociateId": 574,
    "UsePersonAddress": true,
    "ContactFax": "debitis",
    "Kanafname": "alias",
    "Kanalname": "nemo",
    "Post1": "magni",
    "Post2": "sit",
    "Post3": "minima",
    "EmailName": "julie@gislason.uk",
    "ContactFullName": "Jakob Auer",
    "ActiveErpLinks": 523,
    "TicketPriorityId": 531,
    "SupportLanguageId": 629,
    "SupportAssociateId": 373,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 421
      }
    }
  },
  "Associate": {
    "AssociateId": 80,
    "Name": "Blanda-Walter",
    "PersonId": 601,
    "Rank": 851,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 802,
    "FullName": "Vance Wehner",
    "FormalName": "O'Kon, Cummings and Brekke",
    "Deleted": false,
    "EjUserId": 806,
    "UserName": "Heathcote-Doyle",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "transform value-added methodologies"
        },
        "FieldType": "System.Int32",
        "FieldLength": 544
      }
    }
  },
  "Contact": {
    "ContactId": 633,
    "Name": "Hoppe-Stoltenberg",
    "OrgNr": "1213371",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "aliquid",
    "DirectPhone": "1-633-750-4077 x4271",
    "AssociateId": 508,
    "CountryId": 75,
    "EmailAddress": "gudrun_schumm@stromanhettinger.uk",
    "Kananame": "modi",
    "EmailAddressName": "astrid@dickens.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Adelle Cassin",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "aut",
    "FullName": "Josefa Barrows",
    "IsOwnerContact": false,
    "ActiveErpLinks": 943,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 369
      }
    }
  },
  "Project": {
    "ProjectId": 718,
    "Name": "Hermann LLC",
    "Description": "Pre-emptive 5th generation data-warehouse",
    "URL": "http://www.example.com/",
    "Type": "voluptatem",
    "AssociateId": 811,
    "AssociateFullName": "Dr. Eli Kautzer",
    "TypeId": 660,
    "Updated": "2010-02-25T14:58:03.9624608+01:00",
    "StatusId": 854,
    "Status": "distinctio",
    "TextId": 508,
    "PublishTo": "2007-10-09T14:58:03.9624608+02:00",
    "PublishFrom": "1998-06-13T14:58:03.9624608+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "346401",
    "ActiveErpLinks": 458,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 636
      }
    }
  },
  "Date": "2001-12-31T14:58:03.9624608+01:00",
  "ExternalRef": "corporis",
  "Completed": "Completed",
  "ActiveLinks": 508,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "McLaughlin, Lynch and D'Amore",
      "Id": 694,
      "Description": "Enhanced systematic extranet",
      "ExtraInfo": "illo",
      "LinkId": 122,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 91
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Mayer, Stokes and Stroman",
    "SaleDate": "2014-04-08T14:58:03.9634638+02:00",
    "SaleId": 76,
    "Probability": 572,
    "Title": "sequi",
    "Amount": 10483.23,
    "Currency": "sint",
    "ProjectName": "Collins LLC",
    "AssociateFullName": "Theodora Kuhic MD",
    "Description": "Expanded assymetric infrastructure",
    "Status": "Lost",
    "WeightedAmount": 8944.436,
    "ProjectId": 988,
    "EarningPercent": 21226.582,
    "Earning": 2466.458,
    "ContactId": 11,
    "AssociateId": 338,
    "PersonId": 800,
    "SaleTypeId": 558,
    "SaleTypeName": "Littel Inc and Sons",
    "PersonFullName": "Miss Devonte Nienow",
    "Completed": "Completed",
    "ActiveErpLinks": 662,
    "NextDueDate": "2021-01-29T14:58:03.9634638+01:00",
    "Number": "407690",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 227
      }
    }
  },
  "SuggestedDocumentId": 68,
  "Snum": 407,
  "UserDefinedFields": {
    "SuperOffice:1": "Jerel Shields",
    "SuperOffice:2": "712678191"
  },
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "deserunt"
  },
  "CustomFields": {
    "CustomFields1": "natus",
    "CustomFields2": "ex"
  },
  "PublishEventDate": "2000-05-16T14:58:03.9634638+02:00",
  "PublishTo": "2014-01-07T14:58:03.9634638+01:00",
  "PublishFrom": "1995-02-12T14:58:03.9634638+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 68,
      "Visibility": "All",
      "DisplayValue": "veniam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 695
        }
      }
    },
    {
      "VisibleId": 68,
      "Visibility": "All",
      "DisplayValue": "veniam",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 695
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
      "FieldLength": 14
    }
  }
}
```