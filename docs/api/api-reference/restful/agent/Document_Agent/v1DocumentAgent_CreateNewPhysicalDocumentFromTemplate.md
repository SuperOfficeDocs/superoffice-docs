---
title: CreateNewPhysicalDocumentFromTemplate
id: v1DocumentAgent_CreateNewPhysicalDocumentFromTemplate
---

# CreateNewPhysicalDocumentFromTemplate

```http
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplate
```

Create a new document content based on a document template and store it in the document archive.

Tags are substituted according to the provided id's.  Use GetDocumentStream to obtain the created document. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplate?$select=name,department,category/id
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

ContactId, PersonId, AppointmentId, DocumentId, SaleId, SelectionId, ProjectId, UiCulture 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |
| PersonId | int32 |  |
| AppointmentId | int32 |  |
| DocumentId | int32 |  |
| SaleId | int32 |  |
| SelectionId | int32 |  |
| ProjectId | int32 |  |
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
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 5,
  "PersonId": 828,
  "AppointmentId": 720,
  "DocumentId": 968,
  "SaleId": 489,
  "SelectionId": 451,
  "ProjectId": 75,
  "UiCulture": "ducimus"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 265,
  "UpdatedBy": {
    "AssociateId": 644,
    "Name": "O'Reilly Inc and Sons",
    "PersonId": 29,
    "Rank": 757,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 606,
    "FullName": "Maritza Welch",
    "FormalName": "Stoltenberg, Gibson and Klein",
    "Deleted": true,
    "EjUserId": 257,
    "UserName": "Yundt-Schmeler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 128
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 758,
    "Name": "Reynolds-Hudson",
    "PersonId": 263,
    "Rank": 616,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 220,
    "FullName": "Brycen Raynor",
    "FormalName": "Hayes-Blanda",
    "Deleted": false,
    "EjUserId": 12,
    "UserName": "Cummerata, Brakus and Shanahan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 7
      }
    }
  },
  "Attention": "ipsa",
  "Header": "voluptas",
  "Name": "Wolff-Weimann",
  "OurRef": "repellat",
  "YourRef": "odio",
  "CreatedDate": "2017-03-18T14:58:04.0624732+01:00",
  "UpdatedDate": "2012-04-08T14:58:04.0624732+02:00",
  "Description": "Down-sized fault-tolerant workforce",
  "DocumentTemplate": {
    "DocumentTemplateId": 25,
    "Name": "Lebsack-Hagenes",
    "Tooltip": "aut",
    "SaveInDb": 107,
    "Filename": "sed",
    "DefaultOref": "optio",
    "RecordType": "Appointment",
    "Deleted": 26,
    "Direction": "Incoming",
    "AutoeventId": 462,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 246
      }
    }
  },
  "Person": {
    "Position": "repellat",
    "PersonId": 623,
    "Mrmrs": "sed",
    "Firstname": "Rebekah",
    "Lastname": "King",
    "MiddleName": "Nader LLC",
    "Title": "omnis",
    "Description": "Right-sized attitude-oriented projection",
    "Email": "coby@hintz.name",
    "FullName": "Lucas Vandervort",
    "DirectPhone": "(770)533-0612",
    "FormalName": "Aufderhar Group",
    "CountryId": 111,
    "ContactId": 814,
    "ContactName": "Swift-Gorczany",
    "Retired": 773,
    "Rank": 21,
    "ActiveInterests": 918,
    "ContactDepartment": "",
    "ContactCountryId": 923,
    "ContactOrgNr": "316776",
    "FaxPhone": "371-223-6438 x35105",
    "MobilePhone": "(566)231-5800",
    "ContactPhone": "(834)884-5814 x70622",
    "AssociateName": "Stroman, Witting and Grimes",
    "AssociateId": 76,
    "UsePersonAddress": false,
    "ContactFax": "vero",
    "Kanafname": "ratione",
    "Kanalname": "itaque",
    "Post1": "modi",
    "Post2": "tempora",
    "Post3": "modi",
    "EmailName": "reece@weimann.uk",
    "ContactFullName": "Ms. Amiya Hintz",
    "ActiveErpLinks": 526,
    "TicketPriorityId": 777,
    "SupportLanguageId": 756,
    "SupportAssociateId": 107,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "target cross-media methodologies"
        },
        "FieldType": "System.String",
        "FieldLength": 11
      }
    }
  },
  "Associate": {
    "AssociateId": 124,
    "Name": "Lakin-Quitzon",
    "PersonId": 810,
    "Rank": 589,
    "Tooltip": "dolore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 886,
    "FullName": "Lauriane Schmeler",
    "FormalName": "Kuhlman Inc and Sons",
    "Deleted": false,
    "EjUserId": 881,
    "UserName": "Davis-Kuhn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 967
      }
    }
  },
  "Contact": {
    "ContactId": 392,
    "Name": "Zieme Inc and Sons",
    "OrgNr": "1357444",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "numquam",
    "DirectPhone": "352.175.3241",
    "AssociateId": 182,
    "CountryId": 959,
    "EmailAddress": "isom_ratke@klocko.uk",
    "Kananame": "quia",
    "EmailAddressName": "hayley.ledner@aufderhar.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ms. Rashad Casper",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "omnis",
    "FullName": "Margie McDermott",
    "IsOwnerContact": true,
    "ActiveErpLinks": 388,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "extend magnetic e-services"
        },
        "FieldType": "System.String",
        "FieldLength": 229
      }
    }
  },
  "Project": {
    "ProjectId": 17,
    "Name": "Sanford, Treutel and Powlowski",
    "Description": "Upgradable zero administration hardware",
    "URL": "http://www.example.com/",
    "Type": "voluptas",
    "AssociateId": 515,
    "AssociateFullName": "Mrs. Ebony Feest",
    "TypeId": 143,
    "Updated": "2019-10-19T14:58:04.0654659+02:00",
    "StatusId": 374,
    "Status": "voluptas",
    "TextId": 431,
    "PublishTo": "2017-03-29T14:58:04.0654659+02:00",
    "PublishFrom": "2018-07-08T14:58:04.0654659+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1359780",
    "ActiveErpLinks": 46,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 985
      }
    }
  },
  "Date": "2021-03-12T14:58:04.0654659+01:00",
  "ExternalRef": "et",
  "Completed": "Completed",
  "ActiveLinks": 442,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Towne Group",
      "Id": 145,
      "Description": "Customer-focused actuating task-force",
      "ExtraInfo": "occaecati",
      "LinkId": 853,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 718
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Erdman Group",
    "SaleDate": "1998-04-15T14:58:04.0654659+02:00",
    "SaleId": 702,
    "Probability": 993,
    "Title": "suscipit",
    "Amount": 27902.002,
    "Currency": "quis",
    "ProjectName": "Satterfield-Kunde",
    "AssociateFullName": "Ms. Dulce Schimmel",
    "Description": "Switchable systematic infrastructure",
    "Status": "Lost",
    "WeightedAmount": 5707.014,
    "ProjectId": 301,
    "EarningPercent": 2908.352,
    "Earning": 5660.004,
    "ContactId": 628,
    "AssociateId": 480,
    "PersonId": 511,
    "SaleTypeId": 943,
    "SaleTypeName": "Bode-Flatley",
    "PersonFullName": "Queenie Rosenbaum",
    "Completed": "Completed",
    "ActiveErpLinks": 153,
    "NextDueDate": "2001-05-29T14:58:04.0664662+02:00",
    "Number": "620010",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 759
      }
    }
  },
  "SuggestedDocumentId": 548,
  "Snum": 156,
  "UserDefinedFields": {
    "SuperOffice:1": "930925307",
    "SuperOffice:2": "1771047748"
  },
  "ExtraFields": {
    "ExtraFields1": "magni",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "eaque",
    "CustomFields2": "omnis"
  },
  "PublishEventDate": "2007-06-10T14:58:04.0674662+02:00",
  "PublishTo": "2011-08-30T14:58:04.0674662+02:00",
  "PublishFrom": "2010-02-24T14:58:04.0674662+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 950,
      "Visibility": "All",
      "DisplayValue": "minima",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 499
        }
      }
    },
    {
      "VisibleId": 950,
      "Visibility": "All",
      "DisplayValue": "minima",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 499
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
      "FieldLength": 243
    }
  }
}
```