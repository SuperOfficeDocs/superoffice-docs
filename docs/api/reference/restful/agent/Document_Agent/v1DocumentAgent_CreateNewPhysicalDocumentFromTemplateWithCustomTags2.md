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
  "ContactId": 210,
  "PersonId": 523,
  "AppointmentId": 925,
  "DocumentId": 251,
  "SaleId": 989,
  "SelectionId": 394,
  "ProjectId": 354,
  "CustomTags": {
    "CustomTags1": "animi",
    "CustomTags2": "et"
  },
  "UiCulture": "eveniet"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 567,
  "UpdatedBy": {
    "AssociateId": 959,
    "Name": "Wiza LLC",
    "PersonId": 69,
    "Rank": 68,
    "Tooltip": "corrupti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 190,
    "FullName": "Julius Friesen",
    "FormalName": "Kautzer Inc and Sons",
    "Deleted": true,
    "EjUserId": 375,
    "UserName": "Robel Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 124
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 627,
    "Name": "Boyle-Beer",
    "PersonId": 157,
    "Rank": 648,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 541,
    "FullName": "Jayne Maggio",
    "FormalName": "Hayes Group",
    "Deleted": false,
    "EjUserId": 119,
    "UserName": "Ebert, Quigley and Walsh",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 450
      }
    }
  },
  "Attention": "tempore",
  "Header": "voluptatem",
  "Name": "Kshlerin-Dickens",
  "OurRef": "odio",
  "YourRef": "veniam",
  "CreatedDate": "2010-02-01T18:28:48.953956+01:00",
  "UpdatedDate": "2004-12-20T18:28:48.953956+01:00",
  "Description": "Optimized bifurcated projection",
  "DocumentTemplate": {
    "DocumentTemplateId": 727,
    "Name": "Witting, Lebsack and Spinka",
    "Tooltip": "tenetur",
    "SaveInDb": 758,
    "Filename": "sit",
    "DefaultOref": "in",
    "RecordType": "Appointment",
    "Deleted": 702,
    "Direction": "Incoming",
    "AutoeventId": 606,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 772
      }
    }
  },
  "Person": {
    "Position": "aut",
    "PersonId": 974,
    "Mrmrs": "quae",
    "Firstname": "Monserrat",
    "Lastname": "Morissette",
    "MiddleName": "Bode, Kunze and Corwin",
    "Title": "voluptates",
    "Description": "Diverse eco-centric interface",
    "Email": "lempi@raynor.uk",
    "FullName": "Lester Braun",
    "DirectPhone": "1-360-805-0470 x2743",
    "FormalName": "Quitzon Group",
    "CountryId": 790,
    "ContactId": 510,
    "ContactName": "Kuphal-Zemlak",
    "Retired": 86,
    "Rank": 197,
    "ActiveInterests": 102,
    "ContactDepartment": "",
    "ContactCountryId": 823,
    "ContactOrgNr": "1354177",
    "FaxPhone": "368-810-0504 x764",
    "MobilePhone": "1-874-316-7605 x235",
    "ContactPhone": "(757)463-5474 x10606",
    "AssociateName": "Murazik Group",
    "AssociateId": 495,
    "UsePersonAddress": false,
    "ContactFax": "nostrum",
    "Kanafname": "odio",
    "Kanalname": "voluptatem",
    "Post1": "tempore",
    "Post2": "laboriosam",
    "Post3": "temporibus",
    "EmailName": "brycen@king.co.uk",
    "ContactFullName": "Dr. Gino White",
    "ActiveErpLinks": 25,
    "TicketPriorityId": 253,
    "SupportLanguageId": 115,
    "SupportAssociateId": 70,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 972
      }
    }
  },
  "Associate": {
    "AssociateId": 478,
    "Name": "Bartell, Morar and Larkin",
    "PersonId": 660,
    "Rank": 343,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 902,
    "FullName": "Josh Robel",
    "FormalName": "Monahan-Lubowitz",
    "Deleted": true,
    "EjUserId": 275,
    "UserName": "Ebert-Prosacco",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 345
      }
    }
  },
  "Contact": {
    "ContactId": 936,
    "Name": "Gutmann Group",
    "OrgNr": "1543468",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "enim",
    "DirectPhone": "(342)733-3203 x32844",
    "AssociateId": 385,
    "CountryId": 761,
    "EmailAddress": "noe_labadie@rohandaniel.biz",
    "Kananame": "id",
    "EmailAddressName": "tanya.klocko@koss.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mr. Jaydon Barrows",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ullam",
    "FullName": "Kevon King DVM",
    "IsOwnerContact": false,
    "ActiveErpLinks": 281,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 881
      }
    }
  },
  "Project": {
    "ProjectId": 826,
    "Name": "Kunde-Hermiston",
    "Description": "Visionary reciprocal architecture",
    "URL": "http://www.example.com/",
    "Type": "sit",
    "AssociateId": 636,
    "AssociateFullName": "Fae Schaden",
    "TypeId": 959,
    "Updated": "2014-02-26T18:28:48.9569555+01:00",
    "StatusId": 810,
    "Status": "quis",
    "TextId": 491,
    "PublishTo": "2013-01-01T18:28:48.9569555+01:00",
    "PublishFrom": "2014-04-15T18:28:48.9569555+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1395565",
    "ActiveErpLinks": 350,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 72
      }
    }
  },
  "Date": "1997-12-20T18:28:48.9569555+01:00",
  "ExternalRef": "quaerat",
  "Completed": "Completed",
  "ActiveLinks": 383,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Wolf-Carter",
      "Id": 236,
      "Description": "Ergonomic zero administration Graphical User Interface",
      "ExtraInfo": "sed",
      "LinkId": 593,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 631
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Langosh, Wiegand and Dietrich",
    "SaleDate": "2005-06-09T18:28:48.9569555+02:00",
    "SaleId": 164,
    "Probability": 690,
    "Title": "aut",
    "Amount": 4321.786,
    "Currency": "qui",
    "ProjectName": "Hagenes, Predovic and Kihn",
    "AssociateFullName": "Guido Hand",
    "Description": "Reduced stable extranet",
    "Status": "Lost",
    "WeightedAmount": 7571.744,
    "ProjectId": 352,
    "EarningPercent": 27080.894,
    "Earning": 25617.316,
    "ContactId": 720,
    "AssociateId": 884,
    "PersonId": 539,
    "SaleTypeId": 60,
    "SaleTypeName": "Murray, Fahey and Balistreri",
    "PersonFullName": "Elton Dietrich",
    "Completed": "Completed",
    "ActiveErpLinks": 473,
    "NextDueDate": "1998-08-17T18:28:48.9579555+02:00",
    "Number": "1063028",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 418
      }
    }
  },
  "SuggestedDocumentId": 536,
  "Snum": 508,
  "UserDefinedFields": {
    "SuperOffice:1": "Catharine Torp",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "nulla",
    "ExtraFields2": "nisi"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "beatae"
  },
  "PublishEventDate": "2003-07-04T18:28:48.9579555+02:00",
  "PublishTo": "2016-09-10T18:28:48.9579555+02:00",
  "PublishFrom": "2000-10-16T18:28:48.9579555+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 277,
      "Visibility": "All",
      "DisplayValue": "fuga",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 202
        }
      }
    },
    {
      "VisibleId": 277,
      "Visibility": "All",
      "DisplayValue": "fuga",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 202
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
      "FieldLength": 214
    }
  }
}
```