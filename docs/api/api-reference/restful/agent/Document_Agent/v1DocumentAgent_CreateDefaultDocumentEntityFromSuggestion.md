---
title: POST Agents/Document/CreateDefaultDocumentEntityFromSuggestion
id: v1DocumentAgent_CreateDefaultDocumentEntityFromSuggestion
---

# POST Agents/Document/CreateDefaultDocumentEntityFromSuggestion

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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SuggestedDocumentId": 495
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 816,
  "UpdatedBy": {
    "AssociateId": 173,
    "Name": "Lockman, Ankunding and Torp",
    "PersonId": 170,
    "Rank": 426,
    "Tooltip": "deserunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 364,
    "FullName": "Miss Corrine Spinka",
    "FormalName": "Cremin Group",
    "Deleted": true,
    "EjUserId": 647,
    "UserName": "Stracke, Wolff and Mann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 30
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 404,
    "Name": "Bogan Inc and Sons",
    "PersonId": 441,
    "Rank": 80,
    "Tooltip": "pariatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 66,
    "FullName": "Toby Fay",
    "FormalName": "Cronin, Beer and Hartmann",
    "Deleted": false,
    "EjUserId": 853,
    "UserName": "Ernser-Wunsch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 944
      }
    }
  },
  "Attention": "nemo",
  "Header": "voluptatibus",
  "Name": "Marks Inc and Sons",
  "OurRef": "sint",
  "YourRef": "mollitia",
  "CreatedDate": "2012-06-07T16:48:29.2568945+02:00",
  "UpdatedDate": "2004-03-16T16:48:29.2568945+01:00",
  "Description": "Optimized holistic workforce",
  "DocumentTemplate": {
    "DocumentTemplateId": 725,
    "Name": "Nicolas LLC",
    "Tooltip": "et",
    "SaveInDb": 706,
    "Filename": "incidunt",
    "DefaultOref": "laudantium",
    "RecordType": "Appointment",
    "Deleted": 808,
    "Direction": "Incoming",
    "AutoeventId": 118,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 429
      }
    }
  },
  "Person": {
    "Position": "est",
    "PersonId": 1001,
    "Mrmrs": "rerum",
    "Firstname": "Robbie",
    "Lastname": "Jenkins",
    "MiddleName": "Koch, Anderson and Greenholt",
    "Title": "magni",
    "Description": "Enhanced demand-driven application",
    "Email": "frida@rolfsonmitchell.co.uk",
    "FullName": "Alexandre Brekke",
    "DirectPhone": "501-311-2001",
    "FormalName": "Weimann Group",
    "CountryId": 583,
    "ContactId": 657,
    "ContactName": "Klocko, Erdman and Ritchie",
    "Retired": 161,
    "Rank": 148,
    "ActiveInterests": 581,
    "ContactDepartment": "streamline customized deliverables",
    "ContactCountryId": 970,
    "ContactOrgNr": "1331099",
    "FaxPhone": "1-785-522-5071 x00118",
    "MobilePhone": "1-480-644-2870",
    "ContactPhone": "1-143-172-1213 x23323",
    "AssociateName": "Marks-Considine",
    "AssociateId": 65,
    "UsePersonAddress": true,
    "ContactFax": "vitae",
    "Kanafname": "exercitationem",
    "Kanalname": "velit",
    "Post1": "eum",
    "Post2": "cum",
    "Post3": "possimus",
    "EmailName": "gertrude@leannonjerde.co.uk",
    "ContactFullName": "Sabrina Bailey PhD",
    "ActiveErpLinks": 854,
    "TicketPriorityId": 980,
    "SupportLanguageId": 204,
    "SupportAssociateId": 610,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 141
      }
    }
  },
  "Associate": {
    "AssociateId": 724,
    "Name": "Schneider, Medhurst and Volkman",
    "PersonId": 71,
    "Rank": 952,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 136,
    "FullName": "Theresia Kiehn",
    "FormalName": "Langworth, Braun and Wiegand",
    "Deleted": false,
    "EjUserId": 898,
    "UserName": "Luettgen, Veum and Doyle",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "architect distributed partnerships"
        },
        "FieldType": "System.Int32",
        "FieldLength": 655
      }
    }
  },
  "Contact": {
    "ContactId": 596,
    "Name": "Dicki Group",
    "OrgNr": "1781427",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ea",
    "DirectPhone": "277.628.3264 x762",
    "AssociateId": 165,
    "CountryId": 167,
    "EmailAddress": "leann.schamberger@herzog.biz",
    "Kananame": "dolores",
    "EmailAddressName": "jeffry_mann@krajcikhessel.us",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mariano Beahan",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quia",
    "FullName": "Regan Harber III",
    "IsOwnerContact": false,
    "ActiveErpLinks": 846,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 790
      }
    }
  },
  "Project": {
    "ProjectId": 939,
    "Name": "Kertzmann-Parker",
    "Description": "Organic composite definition",
    "URL": "http://www.example.com/",
    "Type": "voluptatem",
    "AssociateId": 187,
    "AssociateFullName": "Darryl Waelchi",
    "TypeId": 374,
    "Updated": "2017-12-10T16:48:29.2598946+01:00",
    "StatusId": 43,
    "Status": "commodi",
    "TextId": 906,
    "PublishTo": "2007-12-15T16:48:29.2598946+01:00",
    "PublishFrom": "2007-11-21T16:48:29.2598946+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "202621",
    "ActiveErpLinks": 635,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 811
      }
    }
  },
  "Date": "1997-05-23T16:48:29.2598946+02:00",
  "ExternalRef": "laudantium",
  "Completed": "Completed",
  "ActiveLinks": 702,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Bailey Group",
      "Id": 798,
      "Description": "Cross-group fresh-thinking instruction set",
      "ExtraInfo": "nostrum",
      "LinkId": 347,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 289
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Kutch-Cassin",
    "SaleDate": "2006-05-17T16:48:29.2598946+02:00",
    "SaleId": 303,
    "Probability": 92,
    "Title": "commodi",
    "Amount": 1526.258,
    "Currency": "sit",
    "ProjectName": "Heidenreich-Gottlieb",
    "AssociateFullName": "Elwyn Legros",
    "Description": "Down-sized full-range superstructure",
    "Status": "Lost",
    "WeightedAmount": 16741.827999999998,
    "ProjectId": 569,
    "EarningPercent": 24783.672,
    "Earning": 2457.056,
    "ContactId": 971,
    "AssociateId": 951,
    "PersonId": 835,
    "SaleTypeId": 734,
    "SaleTypeName": "Carter, Bins and Harber",
    "PersonFullName": "Fletcher Cummings",
    "Completed": "Completed",
    "ActiveErpLinks": 164,
    "NextDueDate": "2010-04-24T16:48:29.2608944+02:00",
    "Number": "1853220",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 933
      }
    }
  },
  "SuggestedDocumentId": 753,
  "Snum": 169,
  "UserDefinedFields": {
    "SuperOffice:1": "1671629672",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "reiciendis"
  },
  "CustomFields": {
    "CustomFields1": "suscipit",
    "CustomFields2": "sit"
  },
  "PublishEventDate": "2017-05-21T16:48:29.2608944+02:00",
  "PublishTo": "2010-07-13T16:48:29.2608944+02:00",
  "PublishFrom": "2003-12-25T16:48:29.2608944+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 427,
      "Visibility": "All",
      "DisplayValue": "voluptate",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 370
        }
      }
    },
    {
      "VisibleId": 427,
      "Visibility": "All",
      "DisplayValue": "voluptate",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 370
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
      "FieldLength": 317
    }
  }
}
```