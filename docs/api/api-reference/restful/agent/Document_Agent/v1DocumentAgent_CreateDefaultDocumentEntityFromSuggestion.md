---
title: CreateDefaultDocumentEntityFromSuggestion
id: v1DocumentAgent_CreateDefaultDocumentEntityFromSuggestion
---

# CreateDefaultDocumentEntityFromSuggestion

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
  "SuggestedDocumentId": 274
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 6,
  "UpdatedBy": {
    "AssociateId": 783,
    "Name": "Muller-Keeling",
    "PersonId": 786,
    "Rank": 841,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 921,
    "FullName": "Nelda Bednar",
    "FormalName": "Rodriguez LLC",
    "Deleted": true,
    "EjUserId": 587,
    "UserName": "Stiedemann-Hartmann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 455
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 929,
    "Name": "Turner LLC",
    "PersonId": 743,
    "Rank": 470,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 496,
    "FullName": "Dale Oberbrunner",
    "FormalName": "Hoeger-Predovic",
    "Deleted": true,
    "EjUserId": 773,
    "UserName": "Russel Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 860
      }
    }
  },
  "Attention": "ut",
  "Header": "quos",
  "Name": "Moen, Kunde and Lubowitz",
  "OurRef": "vero",
  "YourRef": "ut",
  "CreatedDate": "2009-11-20T14:58:03.8504706+01:00",
  "UpdatedDate": "2016-03-25T14:58:03.8504706+01:00",
  "Description": "Multi-channelled even-keeled toolset",
  "DocumentTemplate": {
    "DocumentTemplateId": 245,
    "Name": "Satterfield-Dickens",
    "Tooltip": "molestiae",
    "SaveInDb": 272,
    "Filename": "voluptatem",
    "DefaultOref": "maxime",
    "RecordType": "Appointment",
    "Deleted": 125,
    "Direction": "Incoming",
    "AutoeventId": 270,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 223
      }
    }
  },
  "Person": {
    "Position": "qui",
    "PersonId": 889,
    "Mrmrs": "nam",
    "Firstname": "Mara",
    "Lastname": "Schmidt",
    "MiddleName": "Cronin, Nikolaus and Marquardt",
    "Title": "esse",
    "Description": "Horizontal non-volatile internet solution",
    "Email": "marcelino.haag@hartmann.info",
    "FullName": "Rupert Tremblay",
    "DirectPhone": "063-116-0524",
    "FormalName": "Cassin LLC",
    "CountryId": 2,
    "ContactId": 625,
    "ContactName": "Wolf, Tillman and Rowe",
    "Retired": 243,
    "Rank": 733,
    "ActiveInterests": 923,
    "ContactDepartment": "",
    "ContactCountryId": 690,
    "ContactOrgNr": "1432628",
    "FaxPhone": "666.378.5181 x42658",
    "MobilePhone": "(101)227-3630",
    "ContactPhone": "(405)625-6385 x0217",
    "AssociateName": "Predovic, Mosciski and Jones",
    "AssociateId": 600,
    "UsePersonAddress": true,
    "ContactFax": "dolorem",
    "Kanafname": "ut",
    "Kanalname": "maxime",
    "Post1": "dolorum",
    "Post2": "nemo",
    "Post3": "ipsa",
    "EmailName": "dennis.bayer@lesch.biz",
    "ContactFullName": "Deonte Willms",
    "ActiveErpLinks": 696,
    "TicketPriorityId": 36,
    "SupportLanguageId": 782,
    "SupportAssociateId": 963,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 756
      }
    }
  },
  "Associate": {
    "AssociateId": 354,
    "Name": "Armstrong, Bartell and Pouros",
    "PersonId": 465,
    "Rank": 764,
    "Tooltip": "perspiciatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 103,
    "FullName": "Lourdes O'Kon",
    "FormalName": "Lynch Group",
    "Deleted": false,
    "EjUserId": 815,
    "UserName": "Boehm-Cruickshank",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "seize user-centric experiences"
        },
        "FieldType": "System.String",
        "FieldLength": 851
      }
    }
  },
  "Contact": {
    "ContactId": 785,
    "Name": "Cormier, Swaniawski and Lubowitz",
    "OrgNr": "854912",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ea",
    "DirectPhone": "446.277.2081 x875",
    "AssociateId": 651,
    "CountryId": 674,
    "EmailAddress": "robb@olson.name",
    "Kananame": "omnis",
    "EmailAddressName": "vanessa_boehm@schmeler.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Dario Weber",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ducimus",
    "FullName": "Destinee Leannon",
    "IsOwnerContact": false,
    "ActiveErpLinks": 902,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 864
      }
    }
  },
  "Project": {
    "ProjectId": 491,
    "Name": "Thompson LLC",
    "Description": "Mandatory responsive knowledge base",
    "URL": "http://www.example.com/",
    "Type": "inventore",
    "AssociateId": 607,
    "AssociateFullName": "Verna Kris",
    "TypeId": 908,
    "Updated": "2013-03-19T14:58:03.8544598+01:00",
    "StatusId": 242,
    "Status": "dolorem",
    "TextId": 361,
    "PublishTo": "2014-10-20T14:58:03.8544598+02:00",
    "PublishFrom": "2007-04-24T14:58:03.8544598+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "796860",
    "ActiveErpLinks": 745,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 296
      }
    }
  },
  "Date": "2004-07-20T14:58:03.8544598+02:00",
  "ExternalRef": "error",
  "Completed": "Completed",
  "ActiveLinks": 888,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Douglas Group",
      "Id": 365,
      "Description": "Balanced client-server parallelism",
      "ExtraInfo": "sit",
      "LinkId": 293,
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
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Rippin, Glover and Leuschke",
    "SaleDate": "2012-06-02T14:58:03.8544598+02:00",
    "SaleId": 64,
    "Probability": 509,
    "Title": "et",
    "Amount": 9774.946,
    "Currency": "quam",
    "ProjectName": "Keebler LLC",
    "AssociateFullName": "Winnifred Mertz",
    "Description": "Monitored zero tolerance algorithm",
    "Status": "Lost",
    "WeightedAmount": 25156.618,
    "ProjectId": 303,
    "EarningPercent": 2071.574,
    "Earning": 25050.061999999998,
    "ContactId": 254,
    "AssociateId": 386,
    "PersonId": 792,
    "SaleTypeId": 256,
    "SaleTypeName": "Green, Walsh and Zulauf",
    "PersonFullName": "Deontae Greenholt",
    "Completed": "Completed",
    "ActiveErpLinks": 550,
    "NextDueDate": "2010-09-17T14:58:03.8544598+02:00",
    "Number": "1210731",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 766
      }
    }
  },
  "SuggestedDocumentId": 452,
  "Snum": 745,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "1947991849"
  },
  "ExtraFields": {
    "ExtraFields1": "quaerat",
    "ExtraFields2": "recusandae"
  },
  "CustomFields": {
    "CustomFields1": "rem",
    "CustomFields2": "consequatur"
  },
  "PublishEventDate": "2018-04-26T14:58:03.855462+02:00",
  "PublishTo": "2021-06-06T14:58:03.855462+02:00",
  "PublishFrom": "2010-10-06T14:58:03.855462+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 873,
      "Visibility": "All",
      "DisplayValue": "quod",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 49
        }
      }
    },
    {
      "VisibleId": 873,
      "Visibility": "All",
      "DisplayValue": "quod",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 49
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
      "FieldLength": 406
    }
  }
}
```