---
title: POST Agents/Document/CreateNewPhysicalDocumentFromTemplate
id: v1DocumentAgent_CreateNewPhysicalDocumentFromTemplate
---

# POST Agents/Document/CreateNewPhysicalDocumentFromTemplate

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 333,
  "PersonId": 978,
  "AppointmentId": 637,
  "DocumentId": 613,
  "SaleId": 34,
  "SelectionId": 50,
  "ProjectId": 986,
  "UiCulture": "dolore"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 772,
  "UpdatedBy": {
    "AssociateId": 1001,
    "Name": "Farrell-Koepp",
    "PersonId": 982,
    "Rank": 976,
    "Tooltip": "illo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 32,
    "FullName": "Floyd Casper",
    "FormalName": "Rowe, Jacobson and Borer",
    "Deleted": true,
    "EjUserId": 472,
    "UserName": "Emmerich, Kassulke and Shields",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "brand open-source portals"
        },
        "FieldType": "System.String",
        "FieldLength": 914
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 940,
    "Name": "Moore Group",
    "PersonId": 551,
    "Rank": 461,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 306,
    "FullName": "Verla Towne",
    "FormalName": "Turner-Jacobson",
    "Deleted": false,
    "EjUserId": 464,
    "UserName": "Carter, Tillman and Murazik",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 573
      }
    }
  },
  "Attention": "repellat",
  "Header": "cupiditate",
  "Name": "Fahey Inc and Sons",
  "OurRef": "sunt",
  "YourRef": "maxime",
  "CreatedDate": "2016-04-04T16:48:29.4859245+02:00",
  "UpdatedDate": "2011-11-03T16:48:29.4859245+01:00",
  "Description": "Front-line static installation",
  "DocumentTemplate": {
    "DocumentTemplateId": 801,
    "Name": "Koepp Inc and Sons",
    "Tooltip": "dolor",
    "SaveInDb": 328,
    "Filename": "deserunt",
    "DefaultOref": "et",
    "RecordType": "Appointment",
    "Deleted": 31,
    "Direction": "Incoming",
    "AutoeventId": 202,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 565
      }
    }
  },
  "Person": {
    "Position": "repellendus",
    "PersonId": 6,
    "Mrmrs": "omnis",
    "Firstname": "Osborne",
    "Lastname": "Luettgen",
    "MiddleName": "O'Kon-Parker",
    "Title": "quidem",
    "Description": "Extended explicit service-desk",
    "Email": "branson.barton@osinskiprohaska.name",
    "FullName": "Miss Helmer Bode",
    "DirectPhone": "267.342.2013 x4657",
    "FormalName": "Vandervort Inc and Sons",
    "CountryId": 795,
    "ContactId": 482,
    "ContactName": "Kreiger-Haley",
    "Retired": 894,
    "Rank": 100,
    "ActiveInterests": 944,
    "ContactDepartment": "",
    "ContactCountryId": 894,
    "ContactOrgNr": "1353590",
    "FaxPhone": "1-236-618-8608 x07667",
    "MobilePhone": "(876)080-8328",
    "ContactPhone": "632-371-2110 x76003",
    "AssociateName": "Kshlerin, McDermott and Orn",
    "AssociateId": 592,
    "UsePersonAddress": true,
    "ContactFax": "nam",
    "Kanafname": "aspernatur",
    "Kanalname": "fugiat",
    "Post1": "aliquam",
    "Post2": "ad",
    "Post3": "magnam",
    "EmailName": "cleve@runolfsson.us",
    "ContactFullName": "Jasmin Luettgen",
    "ActiveErpLinks": 678,
    "TicketPriorityId": 222,
    "SupportLanguageId": 60,
    "SupportAssociateId": 109,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 299
      }
    }
  },
  "Associate": {
    "AssociateId": 458,
    "Name": "Nader, Heidenreich and O'Kon",
    "PersonId": 404,
    "Rank": 759,
    "Tooltip": "quis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 333,
    "FullName": "Steve Raynor",
    "FormalName": "Hintz, Keebler and Zemlak",
    "Deleted": false,
    "EjUserId": 8,
    "UserName": "Terry, Hammes and Armstrong",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 446
      }
    }
  },
  "Contact": {
    "ContactId": 262,
    "Name": "Feil, Sipes and Gerhold",
    "OrgNr": "1912310",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ut",
    "DirectPhone": "756-222-1583 x665",
    "AssociateId": 176,
    "CountryId": 654,
    "EmailAddress": "kris@morissettefeil.co.uk",
    "Kananame": "enim",
    "EmailAddressName": "electa_kunze@west.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Junior Lowe",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "et",
    "FullName": "Kaylah Batz MD",
    "IsOwnerContact": false,
    "ActiveErpLinks": 967,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 319
      }
    }
  },
  "Project": {
    "ProjectId": 646,
    "Name": "Mitchell-Mertz",
    "Description": "Implemented uniform contingency",
    "URL": "http://www.example.com/",
    "Type": "ea",
    "AssociateId": 8,
    "AssociateFullName": "Aimee Balistreri",
    "TypeId": 538,
    "Updated": "1998-10-04T16:48:29.487924+02:00",
    "StatusId": 78,
    "Status": "velit",
    "TextId": 88,
    "PublishTo": "2017-02-06T16:48:29.487924+01:00",
    "PublishFrom": "2017-03-28T16:48:29.487924+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "362263",
    "ActiveErpLinks": 186,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 273
      }
    }
  },
  "Date": "2019-04-18T16:48:29.487924+02:00",
  "ExternalRef": "corporis",
  "Completed": "Completed",
  "ActiveLinks": 980,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Kohler, Heidenreich and Howe",
      "Id": 441,
      "Description": "Fully-configurable systemic capability",
      "ExtraInfo": "ipsum",
      "LinkId": 157,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 891
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Waelchi-Jones",
    "SaleDate": "2016-07-17T16:48:29.4889246+02:00",
    "SaleId": 605,
    "Probability": 517,
    "Title": "velit",
    "Amount": 10943.928,
    "Currency": "corporis",
    "ProjectName": "Hartmann-Swift",
    "AssociateFullName": "Roy Beahan",
    "Description": "Mandatory zero defect methodology",
    "Status": "Lost",
    "WeightedAmount": 25401.07,
    "ProjectId": 649,
    "EarningPercent": 26272.322,
    "Earning": 8872.354,
    "ContactId": 894,
    "AssociateId": 120,
    "PersonId": 48,
    "SaleTypeId": 31,
    "SaleTypeName": "Wolff-Baumbach",
    "PersonFullName": "Raphael Osinski",
    "Completed": "Completed",
    "ActiveErpLinks": 744,
    "NextDueDate": "1999-02-18T16:48:29.4889246+01:00",
    "Number": "822172",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 10
      }
    }
  },
  "SuggestedDocumentId": 12,
  "Snum": 469,
  "UserDefinedFields": {
    "SuperOffice:1": "Elliot Kris Jr.",
    "SuperOffice:2": "Lydia Goldner"
  },
  "ExtraFields": {
    "ExtraFields1": "necessitatibus",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "blanditiis"
  },
  "PublishEventDate": "2014-02-28T16:48:29.4889246+01:00",
  "PublishTo": "2020-11-10T16:48:29.4889246+01:00",
  "PublishFrom": "2006-12-21T16:48:29.4889246+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 573,
      "Visibility": "All",
      "DisplayValue": "itaque",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 774
        }
      }
    },
    {
      "VisibleId": 573,
      "Visibility": "All",
      "DisplayValue": "itaque",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 774
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
      "FieldLength": 832
    }
  }
}
```