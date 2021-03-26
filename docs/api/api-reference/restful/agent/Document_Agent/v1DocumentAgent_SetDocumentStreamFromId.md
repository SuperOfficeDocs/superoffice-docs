---
title: POST Agents/Document/SetDocumentStreamFromId
id: v1DocumentAgent_SetDocumentStreamFromId
---

# POST Agents/Document/SetDocumentStreamFromId

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 61,
  "Stream": "GIF89....File contents as raw bytes..."
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 95,
  "UpdatedBy": {
    "AssociateId": 621,
    "Name": "Thiel-Ullrich",
    "PersonId": 271,
    "Rank": 50,
    "Tooltip": "incidunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 799,
    "FullName": "Merle Kuvalis",
    "FormalName": "Sipes Group",
    "Deleted": false,
    "EjUserId": 646,
    "UserName": "Legros, Gleason and Goldner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 28
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 485,
    "Name": "Johns Group",
    "PersonId": 968,
    "Rank": 324,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 556,
    "FullName": "Alva Hauck",
    "FormalName": "Borer, Davis and Will",
    "Deleted": true,
    "EjUserId": 545,
    "UserName": "Rau, Pagac and Larkin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 415
      }
    }
  },
  "Attention": "dolorem",
  "Header": "libero",
  "Name": "Kerluke Inc and Sons",
  "OurRef": "est",
  "YourRef": "rerum",
  "CreatedDate": "1998-06-16T16:48:29.2668943+02:00",
  "UpdatedDate": "2018-02-18T16:48:29.2668943+01:00",
  "Description": "Robust zero administration local area network",
  "DocumentTemplate": {
    "DocumentTemplateId": 279,
    "Name": "Predovic Inc and Sons",
    "Tooltip": "odio",
    "SaveInDb": 89,
    "Filename": "mollitia",
    "DefaultOref": "omnis",
    "RecordType": "Appointment",
    "Deleted": 807,
    "Direction": "Incoming",
    "AutoeventId": 522,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 709
      }
    }
  },
  "Person": {
    "Position": "rerum",
    "PersonId": 502,
    "Mrmrs": "explicabo",
    "Firstname": "Derick",
    "Lastname": "Hickle",
    "MiddleName": "Halvorson-Lynch",
    "Title": "non",
    "Description": "Reduced attitude-oriented core",
    "Email": "alford_mann@ritchie.co.uk",
    "FullName": "Miss Tomasa Rowe",
    "DirectPhone": "(247)142-2350",
    "FormalName": "McLaughlin Inc and Sons",
    "CountryId": 724,
    "ContactId": 2,
    "ContactName": "Predovic Group",
    "Retired": 568,
    "Rank": 702,
    "ActiveInterests": 387,
    "ContactDepartment": "",
    "ContactCountryId": 150,
    "ContactOrgNr": "669665",
    "FaxPhone": "827-381-4207",
    "MobilePhone": "1-234-771-8481 x0003",
    "ContactPhone": "306-524-7420 x51100",
    "AssociateName": "O'Conner, Conn and Haley",
    "AssociateId": 472,
    "UsePersonAddress": true,
    "ContactFax": "et",
    "Kanafname": "non",
    "Kanalname": "accusamus",
    "Post1": "vero",
    "Post2": "sed",
    "Post3": "eaque",
    "EmailName": "porter@lubowitzkutch.ca",
    "ContactFullName": "Frederik Upton I",
    "ActiveErpLinks": 721,
    "TicketPriorityId": 271,
    "SupportLanguageId": 15,
    "SupportAssociateId": 787,
    "CategoryName": "VIP Customer",
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
  },
  "Associate": {
    "AssociateId": 893,
    "Name": "Veum, Jerde and Gottlieb",
    "PersonId": 158,
    "Rank": 178,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 493,
    "FullName": "Everardo Swift",
    "FormalName": "Considine, Bernhard and Frami",
    "Deleted": false,
    "EjUserId": 256,
    "UserName": "McCullough Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 187
      }
    }
  },
  "Contact": {
    "ContactId": 269,
    "Name": "Johns-Koch",
    "OrgNr": "992465",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "inventore",
    "DirectPhone": "1-642-344-5727",
    "AssociateId": 847,
    "CountryId": 473,
    "EmailAddress": "mikel.eichmann@emmerich.ca",
    "Kananame": "eveniet",
    "EmailAddressName": "wallace@leannon.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Nikita Macejkovic DDS",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "reprehenderit",
    "FullName": "Gerard Thiel",
    "IsOwnerContact": false,
    "ActiveErpLinks": 133,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 59
      }
    }
  },
  "Project": {
    "ProjectId": 341,
    "Name": "O'Connell, Price and Grimes",
    "Description": "Extended foreground framework",
    "URL": "http://www.example.com/",
    "Type": "ducimus",
    "AssociateId": 316,
    "AssociateFullName": "Buck Haag",
    "TypeId": 469,
    "Updated": "1995-06-12T16:48:29.2698944+02:00",
    "StatusId": 769,
    "Status": "officiis",
    "TextId": 124,
    "PublishTo": "2018-11-14T16:48:29.2698944+01:00",
    "PublishFrom": "2013-06-21T16:48:29.2698944+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1170889",
    "ActiveErpLinks": 443,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 178
      }
    }
  },
  "Date": "2019-03-17T16:48:29.2698944+01:00",
  "ExternalRef": "facilis",
  "Completed": "Completed",
  "ActiveLinks": 633,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Wyman, Torp and Reilly",
      "Id": 743,
      "Description": "Innovative leading edge encoding",
      "ExtraInfo": "et",
      "LinkId": 582,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 365
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Cole-Witting",
    "SaleDate": "2019-09-11T16:48:29.2698944+02:00",
    "SaleId": 64,
    "Probability": 804,
    "Title": "at",
    "Amount": 13940.032,
    "Currency": "fugiat",
    "ProjectName": "Hilpert, Rice and Collier",
    "AssociateFullName": "Mariam Herman",
    "Description": "Business-focused regional initiative",
    "Status": "Lost",
    "WeightedAmount": 11949.942,
    "ProjectId": 699,
    "EarningPercent": 22730.902,
    "Earning": 13814.671999999999,
    "ContactId": 141,
    "AssociateId": 711,
    "PersonId": 863,
    "SaleTypeId": 755,
    "SaleTypeName": "Schiller, Schulist and VonRueden",
    "PersonFullName": "Jonas Heller V",
    "Completed": "Completed",
    "ActiveErpLinks": 72,
    "NextDueDate": "2004-07-18T16:48:29.2698944+02:00",
    "Number": "311965",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 921
      }
    }
  },
  "SuggestedDocumentId": 973,
  "Snum": 484,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "placeat",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "nam",
    "CustomFields2": "asperiores"
  },
  "PublishEventDate": "2002-04-23T16:48:29.2698944+02:00",
  "PublishTo": "2011-03-27T16:48:29.2698944+02:00",
  "PublishFrom": "2020-02-18T16:48:29.2698944+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 454,
      "Visibility": "All",
      "DisplayValue": "rem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 175
        }
      }
    },
    {
      "VisibleId": 454,
      "Visibility": "All",
      "DisplayValue": "rem",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 175
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
        "Reason": "recontextualize sexy initiatives"
      },
      "FieldType": "System.Int32",
      "FieldLength": 104
    }
  }
}
```