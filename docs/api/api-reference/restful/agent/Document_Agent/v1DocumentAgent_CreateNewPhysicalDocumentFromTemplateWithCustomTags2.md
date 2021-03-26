---
title: POST Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags2
id: v1DocumentAgent_CreateNewPhysicalDocumentFromTemplateWithCustomTags2
---

# POST Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags2

```http
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags2
```

Create a new physical document based on a document template and store it in the document archive.

Tags are substituted according to the provided id's.  Use GetDocumentStream to obtain the created document content. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags2?$select=name,department,category/id
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

ContactId, PersonId, AppointmentId, DocumentId, SaleId, SelectionId, ProjectId, CustomTags, UiCulture 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |
| PersonId | int32 |  |
| AppointmentId | int32 |  |
| DocumentId | int32 |  |
| SaleId | int32 |  |
| SelectionId | int32 |  |
| ProjectId | int32 |  |
| CustomTags | object |  |
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
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 93,
  "PersonId": 681,
  "AppointmentId": 362,
  "DocumentId": 702,
  "SaleId": 285,
  "SelectionId": 748,
  "ProjectId": 760,
  "CustomTags": {
    "CustomTags1": "quaerat",
    "CustomTags2": "nostrum"
  },
  "UiCulture": "voluptates"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 327,
  "UpdatedBy": {
    "AssociateId": 883,
    "Name": "Little, King and Gleason",
    "PersonId": 907,
    "Rank": 131,
    "Tooltip": "iste",
    "Type": "AnonymousAssociate",
    "GroupIdx": 725,
    "FullName": "Brooke White",
    "FormalName": "Moore-Kuhn",
    "Deleted": true,
    "EjUserId": 462,
    "UserName": "Satterfield Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 958
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 530,
    "Name": "O'Keefe Group",
    "PersonId": 756,
    "Rank": 268,
    "Tooltip": "quae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 366,
    "FullName": "Hosea Flatley",
    "FormalName": "Brekke, Lindgren and Spinka",
    "Deleted": true,
    "EjUserId": 210,
    "UserName": "Kuhic-Collier",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 988
      }
    }
  },
  "Attention": "sapiente",
  "Header": "numquam",
  "Name": "Thiel LLC",
  "OurRef": "vel",
  "YourRef": "ut",
  "CreatedDate": "2005-02-28T16:48:29.4739321+01:00",
  "UpdatedDate": "2011-08-01T16:48:29.4739321+02:00",
  "Description": "Multi-channelled context-sensitive archive",
  "DocumentTemplate": {
    "DocumentTemplateId": 200,
    "Name": "Stracke Inc and Sons",
    "Tooltip": "nihil",
    "SaveInDb": 4,
    "Filename": "dolorem",
    "DefaultOref": "praesentium",
    "RecordType": "Appointment",
    "Deleted": 469,
    "Direction": "Incoming",
    "AutoeventId": 703,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 702
      }
    }
  },
  "Person": {
    "Position": "sed",
    "PersonId": 109,
    "Mrmrs": "sit",
    "Firstname": "Torey",
    "Lastname": "Hirthe",
    "MiddleName": "Goodwin Inc and Sons",
    "Title": "facere",
    "Description": "Front-line fault-tolerant task-force",
    "Email": "spencer@roobkeeling.name",
    "FullName": "Gilberto Armstrong",
    "DirectPhone": "878-232-5245 x588",
    "FormalName": "Gulgowski Inc and Sons",
    "CountryId": 873,
    "ContactId": 963,
    "ContactName": "Braun-Quitzon",
    "Retired": 191,
    "Rank": 76,
    "ActiveInterests": 461,
    "ContactDepartment": "",
    "ContactCountryId": 999,
    "ContactOrgNr": "712970",
    "FaxPhone": "(611)040-0378 x8437",
    "MobilePhone": "238.540.0378 x6664",
    "ContactPhone": "355.573.4748 x18005",
    "AssociateName": "Green-Jakubowski",
    "AssociateId": 279,
    "UsePersonAddress": true,
    "ContactFax": "explicabo",
    "Kanafname": "iste",
    "Kanalname": "et",
    "Post1": "voluptas",
    "Post2": "maxime",
    "Post3": "voluptatem",
    "EmailName": "sim_huels@satterfield.info",
    "ContactFullName": "Francisco Murazik",
    "ActiveErpLinks": 250,
    "TicketPriorityId": 170,
    "SupportLanguageId": 72,
    "SupportAssociateId": 288,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 325
      }
    }
  },
  "Associate": {
    "AssociateId": 494,
    "Name": "Bogan-Grady",
    "PersonId": 446,
    "Rank": 20,
    "Tooltip": "magni",
    "Type": "AnonymousAssociate",
    "GroupIdx": 188,
    "FullName": "Pierce Mante",
    "FormalName": "Bergstrom, Cassin and Leuschke",
    "Deleted": true,
    "EjUserId": 571,
    "UserName": "Jakubowski-Torp",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 510
      }
    }
  },
  "Contact": {
    "ContactId": 308,
    "Name": "McCullough-Lueilwitz",
    "OrgNr": "922565",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dolorem",
    "DirectPhone": "1-728-867-7575 x030",
    "AssociateId": 947,
    "CountryId": 748,
    "EmailAddress": "pauline@von.info",
    "Kananame": "itaque",
    "EmailAddressName": "lorna_adams@streich.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ms. Emma Gutkowski",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "est",
    "FullName": "Kailey Beer",
    "IsOwnerContact": false,
    "ActiveErpLinks": 420,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 316
      }
    }
  },
  "Project": {
    "ProjectId": 639,
    "Name": "Block, Balistreri and Jenkins",
    "Description": "Customer-focused context-sensitive migration",
    "URL": "http://www.example.com/",
    "Type": "nobis",
    "AssociateId": 17,
    "AssociateFullName": "Aubrey Hand PhD",
    "TypeId": 491,
    "Updated": "2020-08-16T16:48:29.4769244+02:00",
    "StatusId": 92,
    "Status": "exercitationem",
    "TextId": 574,
    "PublishTo": "2004-01-26T16:48:29.4769244+01:00",
    "PublishFrom": "2009-01-25T16:48:29.4769244+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "311124",
    "ActiveErpLinks": 383,
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
  "Date": "2007-11-30T16:48:29.4769244+01:00",
  "ExternalRef": "voluptatem",
  "Completed": "Completed",
  "ActiveLinks": 199,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Berge, Howell and Spinka",
      "Id": 903,
      "Description": "Focused mobile core",
      "ExtraInfo": "eligendi",
      "LinkId": 214,
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
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Robel-Anderson",
    "SaleDate": "2011-03-24T16:48:29.4769244+01:00",
    "SaleId": 304,
    "Probability": 845,
    "Title": "placeat",
    "Amount": 21069.881999999998,
    "Currency": "nam",
    "ProjectName": "Leffler LLC",
    "AssociateFullName": "Harvey Mueller",
    "Description": "Multi-tiered client-server algorithm",
    "Status": "Lost",
    "WeightedAmount": 14181.35,
    "ProjectId": 672,
    "EarningPercent": 10495.766,
    "Earning": 25849.232,
    "ContactId": 547,
    "AssociateId": 826,
    "PersonId": 438,
    "SaleTypeId": 170,
    "SaleTypeName": "Parker Group",
    "PersonFullName": "Kira Brown",
    "Completed": "Completed",
    "ActiveErpLinks": 899,
    "NextDueDate": "1998-06-19T16:48:29.4769244+02:00",
    "Number": "1695911",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 324
      }
    }
  },
  "SuggestedDocumentId": 628,
  "Snum": 327,
  "UserDefinedFields": {
    "SuperOffice:1": "Pierce Monahan",
    "SuperOffice:2": "Miss Colleen Bernier"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "culpa",
    "CustomFields2": "eveniet"
  },
  "PublishEventDate": "2002-01-17T16:48:29.47793+01:00",
  "PublishTo": "1994-06-03T16:48:29.47793+02:00",
  "PublishFrom": "1995-02-18T16:48:29.47793+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 192,
      "Visibility": "All",
      "DisplayValue": "temporibus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 284
        }
      }
    },
    {
      "VisibleId": 192,
      "Visibility": "All",
      "DisplayValue": "temporibus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 284
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
      "FieldLength": 516
    }
  }
}
```