---
title: SetDocumentStreamFromId
id: v1DocumentAgent_SetDocumentStreamFromId
---

# SetDocumentStreamFromId

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 954,
  "Stream": "GIF89....File contents as raw bytes..."
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 920,
  "UpdatedBy": {
    "AssociateId": 414,
    "Name": "McGlynn LLC",
    "PersonId": 458,
    "Rank": 318,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 912,
    "FullName": "Theo Auer",
    "FormalName": "Kunze Group",
    "Deleted": false,
    "EjUserId": 917,
    "UserName": "Conn LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 174
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 586,
    "Name": "Mitchell-Stroman",
    "PersonId": 753,
    "Rank": 621,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 32,
    "FullName": "Abe Abbott",
    "FormalName": "Conroy, Koepp and Douglas",
    "Deleted": false,
    "EjUserId": 692,
    "UserName": "West Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 257
      }
    }
  },
  "Attention": "rerum",
  "Header": "dolores",
  "Name": "Berge Inc and Sons",
  "OurRef": "officiis",
  "YourRef": "beatae",
  "CreatedDate": "1997-12-10T14:58:03.8614597+01:00",
  "UpdatedDate": "2009-11-25T14:58:03.8614597+01:00",
  "Description": "Focused 3rd generation product",
  "DocumentTemplate": {
    "DocumentTemplateId": 719,
    "Name": "Russel Group",
    "Tooltip": "quia",
    "SaveInDb": 132,
    "Filename": "modi",
    "DefaultOref": "quos",
    "RecordType": "Appointment",
    "Deleted": 227,
    "Direction": "Incoming",
    "AutoeventId": 229,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 357
      }
    }
  },
  "Person": {
    "Position": "aut",
    "PersonId": 817,
    "Mrmrs": "minus",
    "Firstname": "Rebekah",
    "Lastname": "Strosin",
    "MiddleName": "Howe-Harvey",
    "Title": "in",
    "Description": "Configurable client-driven capability",
    "Email": "reggie@nikolaus.com",
    "FullName": "Shemar Marks",
    "DirectPhone": "(813)078-3648",
    "FormalName": "Breitenberg-Buckridge",
    "CountryId": 799,
    "ContactId": 304,
    "ContactName": "Grant-Torp",
    "Retired": 891,
    "Rank": 94,
    "ActiveInterests": 74,
    "ContactDepartment": "",
    "ContactCountryId": 561,
    "ContactOrgNr": "1164714",
    "FaxPhone": "1-735-048-0576",
    "MobilePhone": "(244)035-2767",
    "ContactPhone": "218-384-0854 x76080",
    "AssociateName": "Hodkiewicz-Kerluke",
    "AssociateId": 13,
    "UsePersonAddress": true,
    "ContactFax": "deserunt",
    "Kanafname": "delectus",
    "Kanalname": "eum",
    "Post1": "rerum",
    "Post2": "ipsam",
    "Post3": "deleniti",
    "EmailName": "adolphus@kshlerin.com",
    "ContactFullName": "Lexie Muller",
    "ActiveErpLinks": 961,
    "TicketPriorityId": 114,
    "SupportLanguageId": 617,
    "SupportAssociateId": 451,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 362
      }
    }
  },
  "Associate": {
    "AssociateId": 232,
    "Name": "Kilback, Prohaska and Hettinger",
    "PersonId": 908,
    "Rank": 636,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 613,
    "FullName": "Gaylord Labadie",
    "FormalName": "Hickle LLC",
    "Deleted": true,
    "EjUserId": 67,
    "UserName": "McGlynn, Gleason and Feeney",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 978
      }
    }
  },
  "Contact": {
    "ContactId": 480,
    "Name": "Langworth, Kutch and Williamson",
    "OrgNr": "296988",
    "Department": "brand turn-key users",
    "URL": "http://www.example.com/",
    "City": "odit",
    "DirectPhone": "1-810-212-4720 x332",
    "AssociateId": 774,
    "CountryId": 965,
    "EmailAddress": "trudie.langworth@crona.ca",
    "Kananame": "qui",
    "EmailAddressName": "everett@rempel.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Lyda Bayer",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "amet",
    "FullName": "Leatha Lebsack MD",
    "IsOwnerContact": false,
    "ActiveErpLinks": 462,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 508
      }
    }
  },
  "Project": {
    "ProjectId": 202,
    "Name": "Powlowski, Konopelski and Huel",
    "Description": "Devolved explicit forecast",
    "URL": "http://www.example.com/",
    "Type": "in",
    "AssociateId": 669,
    "AssociateFullName": "Caesar Brekke",
    "TypeId": 3,
    "Updated": "2007-06-13T14:58:03.9074313+02:00",
    "StatusId": 438,
    "Status": "in",
    "TextId": 945,
    "PublishTo": "2018-04-03T14:58:03.9074313+02:00",
    "PublishFrom": "1996-07-21T14:58:03.9074313+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "872790",
    "ActiveErpLinks": 914,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 969
      }
    }
  },
  "Date": "2009-01-19T14:58:03.9074313+01:00",
  "ExternalRef": "id",
  "Completed": "Completed",
  "ActiveLinks": 144,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Corwin Inc and Sons",
      "Id": 785,
      "Description": "Universal discrete database",
      "ExtraInfo": "occaecati",
      "LinkId": 382,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 189
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Dietrich Group",
    "SaleDate": "2011-03-22T14:58:03.9084608+01:00",
    "SaleId": 285,
    "Probability": 317,
    "Title": "aliquid",
    "Amount": 15083.942,
    "Currency": "et",
    "ProjectName": "Shanahan-Carroll",
    "AssociateFullName": "Conner Lubowitz",
    "Description": "Versatile zero tolerance infrastructure",
    "Status": "Lost",
    "WeightedAmount": 25604.78,
    "ProjectId": 620,
    "EarningPercent": 962.13799999999992,
    "Earning": 25958.922,
    "ContactId": 666,
    "AssociateId": 961,
    "PersonId": 238,
    "SaleTypeId": 738,
    "SaleTypeName": "Yundt-Stoltenberg",
    "PersonFullName": "Tyler Halvorson",
    "Completed": "Completed",
    "ActiveErpLinks": 763,
    "NextDueDate": "2015-11-12T14:58:03.9084608+01:00",
    "Number": "1549505",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 14
      }
    }
  },
  "SuggestedDocumentId": 48,
  "Snum": 828,
  "UserDefinedFields": {
    "SuperOffice:1": "926097628",
    "SuperOffice:2": "Issac O'Conner"
  },
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "ex"
  },
  "PublishEventDate": "2002-06-01T14:58:03.9084608+02:00",
  "PublishTo": "2004-11-02T14:58:03.9084608+01:00",
  "PublishFrom": "2020-12-30T14:58:03.9084608+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 6,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 108
        }
      }
    },
    {
      "VisibleId": 6,
      "Visibility": "All",
      "DisplayValue": "et",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 108
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
      "FieldLength": 985
    }
  }
}
```