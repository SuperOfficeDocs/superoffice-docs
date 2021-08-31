---
title: CreateNewPhysicalDocumentFromTemplateWithCustomTags2
id: v1DocumentAgent_CreateNewPhysicalDocumentFromTemplateWithCustomTags2
---

# CreateNewPhysicalDocumentFromTemplateWithCustomTags2

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
  "ContactId": 391,
  "PersonId": 364,
  "AppointmentId": 973,
  "DocumentId": 112,
  "SaleId": 90,
  "SelectionId": 907,
  "ProjectId": 3,
  "CustomTags": {
    "CustomTags1": "nostrum",
    "CustomTags2": "id"
  },
  "UiCulture": "corrupti"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 813,
  "UpdatedBy": {
    "AssociateId": 421,
    "Name": "Sauer, Bednar and Runolfsdottir",
    "PersonId": 82,
    "Rank": 525,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 763,
    "FullName": "Christelle Schaden",
    "FormalName": "Mayer, Raynor and Pacocha",
    "Deleted": false,
    "EjUserId": 397,
    "UserName": "Luettgen-D'Amore",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 970
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 303,
    "Name": "Cummerata, Klocko and Lueilwitz",
    "PersonId": 585,
    "Rank": 251,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 231,
    "FullName": "Virgie Beer DVM",
    "FormalName": "Jacobson Group",
    "Deleted": false,
    "EjUserId": 830,
    "UserName": "O'Keefe, Kohler and Ruecker",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 475
      }
    }
  },
  "Attention": "rerum",
  "Header": "deserunt",
  "Name": "Bruen-Ernser",
  "OurRef": "qui",
  "YourRef": "quia",
  "CreatedDate": "2013-02-28T14:58:04.0064627+01:00",
  "UpdatedDate": "1996-02-02T14:58:04.0064627+01:00",
  "Description": "Face to face motivating concept",
  "DocumentTemplate": {
    "DocumentTemplateId": 491,
    "Name": "Stokes-Harvey",
    "Tooltip": "atque",
    "SaveInDb": 769,
    "Filename": "a",
    "DefaultOref": "ullam",
    "RecordType": "Appointment",
    "Deleted": 379,
    "Direction": "Incoming",
    "AutoeventId": 715,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 631
      }
    }
  },
  "Person": {
    "Position": "quidem",
    "PersonId": 698,
    "Mrmrs": "quo",
    "Firstname": "Hillary",
    "Lastname": "Watsica",
    "MiddleName": "Runolfsson Inc and Sons",
    "Title": "eum",
    "Description": "Ameliorated dedicated definition",
    "Email": "aditya@berge.name",
    "FullName": "Alphonso Schulist",
    "DirectPhone": "163.401.5067 x704",
    "FormalName": "Lockman, Kessler and Daniel",
    "CountryId": 763,
    "ContactId": 555,
    "ContactName": "Mueller, Cartwright and Champlin",
    "Retired": 457,
    "Rank": 675,
    "ActiveInterests": 359,
    "ContactDepartment": "",
    "ContactCountryId": 264,
    "ContactOrgNr": "1326416",
    "FaxPhone": "502-218-2166",
    "MobilePhone": "434-040-7367",
    "ContactPhone": "(888)587-5332 x171",
    "AssociateName": "Fisher, Osinski and Hermiston",
    "AssociateId": 484,
    "UsePersonAddress": false,
    "ContactFax": "illum",
    "Kanafname": "est",
    "Kanalname": "nihil",
    "Post1": "libero",
    "Post2": "quidem",
    "Post3": "voluptas",
    "EmailName": "bria.conroy@hahn.co.uk",
    "ContactFullName": "Kaleb Greenfelder",
    "ActiveErpLinks": 364,
    "TicketPriorityId": 772,
    "SupportLanguageId": 398,
    "SupportAssociateId": 579,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 409
      }
    }
  },
  "Associate": {
    "AssociateId": 474,
    "Name": "Shanahan, Grimes and Osinski",
    "PersonId": 729,
    "Rank": 348,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 180,
    "FullName": "Raheem West",
    "FormalName": "Harris, Rath and Wiza",
    "Deleted": false,
    "EjUserId": 937,
    "UserName": "Sanford-Keebler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 810
      }
    }
  },
  "Contact": {
    "ContactId": 838,
    "Name": "Champlin LLC",
    "OrgNr": "1339926",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "eum",
    "DirectPhone": "743.886.1174 x37073",
    "AssociateId": 215,
    "CountryId": 270,
    "EmailAddress": "mattie@greenholtgerlach.com",
    "Kananame": "excepturi",
    "EmailAddressName": "orrin@little.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Kaden Heaney",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "deleniti",
    "FullName": "Westley Koelpin",
    "IsOwnerContact": true,
    "ActiveErpLinks": 303,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 394
      }
    }
  },
  "Project": {
    "ProjectId": 984,
    "Name": "Gibson Inc and Sons",
    "Description": "Inverse grid-enabled circuit",
    "URL": "http://www.example.com/",
    "Type": "et",
    "AssociateId": 695,
    "AssociateFullName": "Fabian Kulas",
    "TypeId": 450,
    "Updated": "2003-08-08T14:58:04.0524316+02:00",
    "StatusId": 894,
    "Status": "tempore",
    "TextId": 776,
    "PublishTo": "1996-12-11T14:58:04.0524316+01:00",
    "PublishFrom": "2009-11-20T14:58:04.0524316+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1711664",
    "ActiveErpLinks": 880,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 590
      }
    }
  },
  "Date": "2015-10-28T14:58:04.0524316+01:00",
  "ExternalRef": "accusantium",
  "Completed": "Completed",
  "ActiveLinks": 528,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Larkin Group",
      "Id": 133,
      "Description": "Persevering foreground paradigm",
      "ExtraInfo": "est",
      "LinkId": 300,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 805
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Nikolaus-Koch",
    "SaleDate": "2017-11-10T14:58:04.0534674+01:00",
    "SaleId": 964,
    "Probability": 664,
    "Title": "enim",
    "Amount": 13140.862,
    "Currency": "voluptatem",
    "ProjectName": "Pagac-O'Hara",
    "AssociateFullName": "Katherine Flatley",
    "Description": "Versatile uniform intranet",
    "Status": "Lost",
    "WeightedAmount": 28052.433999999997,
    "ProjectId": 541,
    "EarningPercent": 5901.322,
    "Earning": 15660.598,
    "ContactId": 713,
    "AssociateId": 654,
    "PersonId": 73,
    "SaleTypeId": 694,
    "SaleTypeName": "Torphy, Runolfsdottir and Sawayn",
    "PersonFullName": "Opal Heaney",
    "Completed": "Completed",
    "ActiveErpLinks": 966,
    "NextDueDate": "2006-03-28T14:58:04.0534674+02:00",
    "Number": "1583218",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 438
      }
    }
  },
  "SuggestedDocumentId": 813,
  "Snum": 41,
  "UserDefinedFields": {
    "SuperOffice:1": "Sigurd West",
    "SuperOffice:2": "557731938"
  },
  "ExtraFields": {
    "ExtraFields1": "perspiciatis",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "magnam",
    "CustomFields2": "voluptas"
  },
  "PublishEventDate": "2005-10-23T14:58:04.0534674+02:00",
  "PublishTo": "2003-03-09T14:58:04.0534674+01:00",
  "PublishFrom": "2001-10-03T14:58:04.0534674+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 810,
      "Visibility": "All",
      "DisplayValue": "consequatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 57
        }
      }
    },
    {
      "VisibleId": 810,
      "Visibility": "All",
      "DisplayValue": "consequatur",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 57
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "harness value-added deliverables"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 133
    }
  }
}
```