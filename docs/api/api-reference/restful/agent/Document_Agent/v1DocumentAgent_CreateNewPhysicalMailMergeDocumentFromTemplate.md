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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 888,
  "UiCulture": "fuga"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 54,
  "UpdatedBy": {
    "AssociateId": 326,
    "Name": "Herzog Group",
    "PersonId": 13,
    "Rank": 908,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 558,
    "FullName": "Deontae Mann",
    "FormalName": "Fahey LLC",
    "Deleted": true,
    "EjUserId": 516,
    "UserName": "Ryan, Bernhard and Rippin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 173
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 306,
    "Name": "Goldner LLC",
    "PersonId": 803,
    "Rank": 95,
    "Tooltip": "voluptatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 817,
    "FullName": "Nona Quitzon",
    "FormalName": "Morissette Group",
    "Deleted": true,
    "EjUserId": 892,
    "UserName": "Little-Gerhold",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 69
      }
    }
  },
  "Attention": "rerum",
  "Header": "maiores",
  "Name": "Adams-Brekke",
  "OurRef": "voluptas",
  "YourRef": "officiis",
  "CreatedDate": "2005-09-23T16:48:29.4099243+02:00",
  "UpdatedDate": "2009-04-25T16:48:29.4099243+02:00",
  "Description": "Reverse-engineered contextually-based algorithm",
  "DocumentTemplate": {
    "DocumentTemplateId": 586,
    "Name": "Jenkins Inc and Sons",
    "Tooltip": "aut",
    "SaveInDb": 495,
    "Filename": "eius",
    "DefaultOref": "eum",
    "RecordType": "Appointment",
    "Deleted": 753,
    "Direction": "Incoming",
    "AutoeventId": 633,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 151
      }
    }
  },
  "Person": {
    "Position": "repellat",
    "PersonId": 584,
    "Mrmrs": "ex",
    "Firstname": "Brady",
    "Lastname": "Strosin",
    "MiddleName": "Roberts, Goyette and Nitzsche",
    "Title": "ut",
    "Description": "Open-architected multi-tasking matrix",
    "Email": "perry.metz@nikolausrunolfsdottir.name",
    "FullName": "Filomena Torp",
    "DirectPhone": "1-882-130-5545 x74873",
    "FormalName": "Armstrong, Franecki and Kshlerin",
    "CountryId": 241,
    "ContactId": 243,
    "ContactName": "Tremblay LLC",
    "Retired": 867,
    "Rank": 804,
    "ActiveInterests": 701,
    "ContactDepartment": "",
    "ContactCountryId": 233,
    "ContactOrgNr": "838350",
    "FaxPhone": "286.604.7180 x03085",
    "MobilePhone": "(278)375-6806 x2437",
    "ContactPhone": "737.280.5744",
    "AssociateName": "Hegmann Inc and Sons",
    "AssociateId": 933,
    "UsePersonAddress": false,
    "ContactFax": "sapiente",
    "Kanafname": "eaque",
    "Kanalname": "ea",
    "Post1": "consequatur",
    "Post2": "deserunt",
    "Post3": "quibusdam",
    "EmailName": "garland.farrell@bechtelar.name",
    "ContactFullName": "Lina Osinski V",
    "ActiveErpLinks": 562,
    "TicketPriorityId": 947,
    "SupportLanguageId": 395,
    "SupportAssociateId": 911,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 6
      }
    }
  },
  "Associate": {
    "AssociateId": 580,
    "Name": "Hamill LLC",
    "PersonId": 343,
    "Rank": 291,
    "Tooltip": "aspernatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 657,
    "FullName": "Monte Gerlach",
    "FormalName": "Labadie Inc and Sons",
    "Deleted": true,
    "EjUserId": 487,
    "UserName": "Kassulke Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 468
      }
    }
  },
  "Contact": {
    "ContactId": 437,
    "Name": "Klocko, Hegmann and Tromp",
    "OrgNr": "849276",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "beatae",
    "DirectPhone": "874-661-3588",
    "AssociateId": 344,
    "CountryId": 554,
    "EmailAddress": "ashley@bogisich.us",
    "Kananame": "voluptas",
    "EmailAddressName": "tyson_gulgowski@rolfsonquitzon.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Zetta Kohler",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "veniam",
    "FullName": "Helene Auer",
    "IsOwnerContact": false,
    "ActiveErpLinks": 651,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 404
      }
    }
  },
  "Project": {
    "ProjectId": 525,
    "Name": "Kertzmann Inc and Sons",
    "Description": "Exclusive contextually-based implementation",
    "URL": "http://www.example.com/",
    "Type": "harum",
    "AssociateId": 458,
    "AssociateFullName": "Mrs. Tate Strosin",
    "TypeId": 565,
    "Updated": "2008-07-01T16:48:29.411925+02:00",
    "StatusId": 286,
    "Status": "rerum",
    "TextId": 473,
    "PublishTo": "2006-05-19T16:48:29.411925+02:00",
    "PublishFrom": "1995-04-29T16:48:29.411925+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "777268",
    "ActiveErpLinks": 678,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 452
      }
    }
  },
  "Date": "1998-06-21T16:48:29.411925+02:00",
  "ExternalRef": "aut",
  "Completed": "Completed",
  "ActiveLinks": 424,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Koss, Kuhn and Kris",
      "Id": 633,
      "Description": "Configurable executive access",
      "ExtraInfo": "eveniet",
      "LinkId": 499,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 367
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Gislason-Stokes",
    "SaleDate": "2005-06-02T16:48:29.411925+02:00",
    "SaleId": 220,
    "Probability": 818,
    "Title": "qui",
    "Amount": 30656.788,
    "Currency": "vel",
    "ProjectName": "Muller Inc and Sons",
    "AssociateFullName": "Estrella Kihn",
    "Description": "Reverse-engineered mission-critical protocol",
    "Status": "Lost",
    "WeightedAmount": 4970.5239999999994,
    "ProjectId": 842,
    "EarningPercent": 13670.508,
    "Earning": 18227.344,
    "ContactId": 864,
    "AssociateId": 748,
    "PersonId": 258,
    "SaleTypeId": 181,
    "SaleTypeName": "Morissette, Jaskolski and Bogan",
    "PersonFullName": "Denis Smitham",
    "Completed": "Completed",
    "ActiveErpLinks": 847,
    "NextDueDate": "2004-12-28T16:48:29.4129245+01:00",
    "Number": "648389",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 295
      }
    }
  },
  "SuggestedDocumentId": 184,
  "Snum": 388,
  "UserDefinedFields": {
    "SuperOffice:1": "1327512686",
    "SuperOffice:2": "Jaeden Lubowitz"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptate",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "ex",
    "CustomFields2": "est"
  },
  "PublishEventDate": "2010-03-10T16:48:29.4139189+01:00",
  "PublishTo": "2013-07-27T16:48:29.4139189+02:00",
  "PublishFrom": "1999-11-12T16:48:29.4139189+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 98,
      "Visibility": "All",
      "DisplayValue": "odio",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 566
        }
      }
    },
    {
      "VisibleId": 98,
      "Visibility": "All",
      "DisplayValue": "odio",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 566
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
      "FieldLength": 400
    }
  }
}
```