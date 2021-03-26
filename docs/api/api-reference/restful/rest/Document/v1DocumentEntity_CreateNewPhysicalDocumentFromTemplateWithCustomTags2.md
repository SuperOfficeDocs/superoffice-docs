---
title: POST Document/{id}/Content
id: v1DocumentEntity_CreateNewPhysicalDocumentFromTemplateWithCustomTags2
---

# POST Document/{id}/Content

```http
POST /api/v1/Document/{documentId}/Content
```

Create a new physical document based on a document template and store it in the document archive.

Tags are substituted according to the provided id's.  Use GetDocumentStream to obtain the created document content. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.




| Path Part | Type | Description |
|-----------|------|-------------|
| documentId | int32 | Identifier for the document **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactId | int32 |  Identifier for a contact. Defaults to document's contact if 0 |
| personId | int32 |  Identifier for a person. Defaults to document's person if 0 |
| appointmentId | int32 |  identifier for an appointment. Defaults to document if 0 |
| saleId | int32 |  Identifier for sale. Defaults to document's sale if 0. |
| selectionId | int32 |  identifier for selection. |
| projectId | int32 |  identifier for project. Defaults to document's project if 0 |
| uiCulture | string |  Language variation of template to use when creating document. (ISO code - "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang". |

```http
POST /api/v1/Document/{documentId}/Content?contactId=443
POST /api/v1/Document/{documentId}/Content?personId=19
POST /api/v1/Document/{documentId}/Content?appointmentId=170
POST /api/v1/Document/{documentId}/Content?saleId=767
POST /api/v1/Document/{documentId}/Content?selectionId=746
POST /api/v1/Document/{documentId}/Content?projectId=482
POST /api/v1/Document/{documentId}/Content?uiCulture=dignissimos
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

## Request Body: customTags  

Dictionary of custom tag names and values. Each name should have exactly four characters. There should be exactly one value for each tag. 



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
POST /api/v1/Document/{documentId}/Content
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 290,
  "UpdatedBy": {
    "AssociateId": 370,
    "Name": "Pouros-Heaney",
    "PersonId": 121,
    "Rank": 326,
    "Tooltip": "eum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 640,
    "FullName": "Mireya Kuhn",
    "FormalName": "Okuneva-Jones",
    "Deleted": true,
    "EjUserId": 268,
    "UserName": "Russel, Weissnat and Altenwerth",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 678
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 86,
    "Name": "Wolff, Kuhic and Hermiston",
    "PersonId": 633,
    "Rank": 515,
    "Tooltip": "rem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 127,
    "FullName": "Dr. Percival Reinger",
    "FormalName": "Osinski-Kozey",
    "Deleted": true,
    "EjUserId": 827,
    "UserName": "Ortiz LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 344
      }
    }
  },
  "Attention": "ut",
  "Header": "nostrum",
  "Name": "Nolan LLC",
  "OurRef": "fugiat",
  "YourRef": "numquam",
  "CreatedDate": "2013-07-11T09:40:59.1776628+02:00",
  "UpdatedDate": "2016-06-30T09:40:59.1776628+02:00",
  "Description": "Diverse real-time time-frame",
  "DocumentTemplate": {
    "DocumentTemplateId": 719,
    "Name": "Hickle LLC",
    "Tooltip": "ipsa",
    "SaveInDb": 365,
    "Filename": "porro",
    "DefaultOref": "officiis",
    "RecordType": "Appointment",
    "Deleted": 415,
    "Direction": "Incoming",
    "AutoeventId": 624,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 379
      }
    }
  },
  "Person": {
    "Position": "et",
    "PersonId": 947,
    "Mrmrs": "voluptate",
    "Firstname": "Kayden",
    "Lastname": "Trantow",
    "MiddleName": "Klein, Dietrich and Feil",
    "Title": "suscipit",
    "Description": "Realigned multi-tasking analyzer",
    "Email": "freida@wuckert.co.uk",
    "FullName": "Archibald Rutherford",
    "DirectPhone": "(732)467-6370 x38041",
    "FormalName": "Tillman-Lebsack",
    "CountryId": 869,
    "ContactId": 258,
    "ContactName": "Powlowski Group",
    "Retired": 567,
    "Rank": 315,
    "ActiveInterests": 205,
    "ContactDepartment": "",
    "ContactCountryId": 511,
    "ContactOrgNr": "485861",
    "FaxPhone": "(754)644-8438",
    "MobilePhone": "1-756-337-7310 x14515",
    "ContactPhone": "(148)186-8434 x6518",
    "AssociateName": "Langosh LLC",
    "AssociateId": 295,
    "UsePersonAddress": false,
    "ContactFax": "et",
    "Kanafname": "nulla",
    "Kanalname": "cum",
    "Post1": "hic",
    "Post2": "distinctio",
    "Post3": "eveniet",
    "EmailName": "robert_russel@kertzmann.com",
    "ContactFullName": "Curtis Bailey",
    "ActiveErpLinks": 882,
    "TicketPriorityId": 113,
    "SupportLanguageId": 169,
    "SupportAssociateId": 213,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 159
      }
    }
  },
  "Associate": {
    "AssociateId": 345,
    "Name": "Kuhn Group",
    "PersonId": 287,
    "Rank": 663,
    "Tooltip": "provident",
    "Type": "AnonymousAssociate",
    "GroupIdx": 798,
    "FullName": "Remington Gutkowski",
    "FormalName": "Conroy-Simonis",
    "Deleted": true,
    "EjUserId": 156,
    "UserName": "Blanda Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 649
      }
    }
  },
  "Contact": {
    "ContactId": 876,
    "Name": "Adams, Lakin and Smith",
    "OrgNr": "757155",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "omnis",
    "DirectPhone": "(304)251-8353",
    "AssociateId": 725,
    "CountryId": 301,
    "EmailAddress": "eugene_beier@mosciski.biz",
    "Kananame": "voluptatem",
    "EmailAddressName": "max@bahringer.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Gage Barrows",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "corrupti",
    "FullName": "Marcelina Roberts",
    "IsOwnerContact": true,
    "ActiveErpLinks": 515,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 254
      }
    }
  },
  "Project": {
    "ProjectId": 152,
    "Name": "Bashirian-D'Amore",
    "Description": "Up-sized national approach",
    "URL": "http://www.example.com/",
    "Type": "dignissimos",
    "AssociateId": 561,
    "AssociateFullName": "Gloria Torphy",
    "TypeId": 76,
    "Updated": "2004-04-11T09:40:59.1806625+02:00",
    "StatusId": 859,
    "Status": "debitis",
    "TextId": 278,
    "PublishTo": "2001-07-24T09:40:59.1806625+02:00",
    "PublishFrom": "2006-06-01T09:40:59.1806625+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "378846",
    "ActiveErpLinks": 851,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 190
      }
    }
  },
  "Date": "1994-08-03T09:40:59.1806625+02:00",
  "ExternalRef": "veniam",
  "Completed": "Completed",
  "ActiveLinks": 900,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Rohan Group",
      "Id": 194,
      "Description": "Innovative systemic installation",
      "ExtraInfo": "rem",
      "LinkId": 211,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 126
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Kreiger-Bernier",
    "SaleDate": "2016-07-17T09:40:59.1806625+02:00",
    "SaleId": 713,
    "Probability": 801,
    "Title": "non",
    "Amount": 10100.882,
    "Currency": "veniam",
    "ProjectName": "Crooks, Konopelski and Walsh",
    "AssociateFullName": "Ettie Yost",
    "Description": "Sharable maximized array",
    "Status": "Lost",
    "WeightedAmount": 21461.631999999998,
    "ProjectId": 896,
    "EarningPercent": 26704.814,
    "Earning": 1215.992,
    "ContactId": 423,
    "AssociateId": 801,
    "PersonId": 901,
    "SaleTypeId": 758,
    "SaleTypeName": "Schmeler Inc and Sons",
    "PersonFullName": "Larue Crist",
    "Completed": "Completed",
    "ActiveErpLinks": 888,
    "NextDueDate": "2016-02-08T09:40:59.1816627+01:00",
    "Number": "1100010",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 99
      }
    }
  },
  "SuggestedDocumentId": 2,
  "Snum": 342,
  "UserDefinedFields": {
    "SuperOffice:1": "1173000774",
    "SuperOffice:2": "Osborne Leuschke"
  },
  "ExtraFields": {
    "ExtraFields1": "aspernatur",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "tempore",
    "CustomFields2": "mollitia"
  },
  "PublishEventDate": "2020-06-03T09:40:59.1816627+02:00",
  "PublishTo": "2005-09-23T09:40:59.1816627+02:00",
  "PublishFrom": "1994-02-06T09:40:59.1816627+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 786,
      "Visibility": "All",
      "DisplayValue": "assumenda",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 353
        }
      }
    },
    {
      "VisibleId": 786,
      "Visibility": "All",
      "DisplayValue": "assumenda",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 353
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
      "FieldLength": 853
    }
  }
}
```