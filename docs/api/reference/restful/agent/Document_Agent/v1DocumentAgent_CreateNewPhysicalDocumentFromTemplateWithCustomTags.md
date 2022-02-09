---
title: POST Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags
id: v1DocumentAgent_CreateNewPhysicalDocumentFromTemplateWithCustomTags
---

# POST Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags

```http
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags
```

Create a new physical document based on a document template and store it in the document archive.

Tags are substituted according to the provided id's.  Use GetDocumentStream to obtain the created document content. Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags?$select=name,department,category/id
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

ContactId, PersonId, AppointmentId, DocumentId, SaleId, SelectionId, ProjectId, CustomTags, CustomValues, UiCulture 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |
| PersonId | int32 |  |
| AppointmentId | int32 |  |
| DocumentId | int32 |  |
| SaleId | int32 |  |
| SelectionId | int32 |  |
| ProjectId | int32 |  |
| CustomTags | array |  |
| CustomValues | array |  |
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
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 576,
  "PersonId": 365,
  "AppointmentId": 672,
  "DocumentId": 56,
  "SaleId": 119,
  "SelectionId": 587,
  "ProjectId": 405,
  "CustomTags": [
    "inventore",
    "consequuntur"
  ],
  "CustomValues": [
    "eos",
    "possimus"
  ],
  "UiCulture": "placeat"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 645,
  "UpdatedBy": {
    "AssociateId": 8,
    "Name": "Welch Group",
    "PersonId": 436,
    "Rank": 100,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 698,
    "FullName": "Chelsea Ondricka",
    "FormalName": "O'Conner LLC",
    "Deleted": false,
    "EjUserId": 256,
    "UserName": "Barrows-Strosin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 904
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 268,
    "Name": "Bauch Inc and Sons",
    "PersonId": 720,
    "Rank": 945,
    "Tooltip": "tempore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 546,
    "FullName": "Miss Kenton Bergstrom",
    "FormalName": "Hahn-Erdman",
    "Deleted": true,
    "EjUserId": 942,
    "UserName": "O'Hara-Kshlerin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 33
      }
    }
  },
  "Attention": "officiis",
  "Header": "est",
  "Name": "Hane, Collier and Schumm",
  "OurRef": "vero",
  "YourRef": "tenetur",
  "CreatedDate": "1996-07-20T18:28:48.8989619+02:00",
  "UpdatedDate": "2001-04-15T18:28:48.8989619+02:00",
  "Description": "Triple-buffered impactful matrix",
  "DocumentTemplate": {
    "DocumentTemplateId": 634,
    "Name": "Rutherford-Will",
    "Tooltip": "aut",
    "SaveInDb": 716,
    "Filename": "rerum",
    "DefaultOref": "modi",
    "RecordType": "Appointment",
    "Deleted": 783,
    "Direction": "Incoming",
    "AutoeventId": 840,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 861
      }
    }
  },
  "Person": {
    "Position": "error",
    "PersonId": 794,
    "Mrmrs": "placeat",
    "Firstname": "Stan",
    "Lastname": "Rodriguez",
    "MiddleName": "Gleason LLC",
    "Title": "soluta",
    "Description": "Customizable system-worthy matrices",
    "Email": "neil.waters@boyle.us",
    "FullName": "Tanner Mante",
    "DirectPhone": "733.283.5206",
    "FormalName": "Durgan Inc and Sons",
    "CountryId": 61,
    "ContactId": 596,
    "ContactName": "Denesik-Schultz",
    "Retired": 544,
    "Rank": 105,
    "ActiveInterests": 902,
    "ContactDepartment": "",
    "ContactCountryId": 169,
    "ContactOrgNr": "1479930",
    "FaxPhone": "(361)246-1486 x81224",
    "MobilePhone": "485.750.4614 x344",
    "ContactPhone": "145-087-1723 x071",
    "AssociateName": "Klein, Wintheiser and Luettgen",
    "AssociateId": 278,
    "UsePersonAddress": false,
    "ContactFax": "repudiandae",
    "Kanafname": "quaerat",
    "Kanalname": "magnam",
    "Post1": "quaerat",
    "Post2": "quasi",
    "Post3": "aliquid",
    "EmailName": "alek_mayer@mertzerdman.us",
    "ContactFullName": "Guy Padberg",
    "ActiveErpLinks": 661,
    "TicketPriorityId": 194,
    "SupportLanguageId": 843,
    "SupportAssociateId": 864,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 192
      }
    }
  },
  "Associate": {
    "AssociateId": 949,
    "Name": "Stiedemann Inc and Sons",
    "PersonId": 495,
    "Rank": 951,
    "Tooltip": "debitis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 568,
    "FullName": "Mose Russel",
    "FormalName": "Bergnaum Inc and Sons",
    "Deleted": false,
    "EjUserId": 652,
    "UserName": "Zulauf LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 933
      }
    }
  },
  "Contact": {
    "ContactId": 237,
    "Name": "Bergnaum-Ullrich",
    "OrgNr": "951451",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "aut",
    "DirectPhone": "277-052-6368",
    "AssociateId": 676,
    "CountryId": 907,
    "EmailAddress": "branson@bruendubuque.uk",
    "Kananame": "qui",
    "EmailAddressName": "austin_eichmann@hilpert.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Abe Beahan",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "necessitatibus",
    "FullName": "Quinten Kilback",
    "IsOwnerContact": false,
    "ActiveErpLinks": 644,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 903
      }
    }
  },
  "Project": {
    "ProjectId": 287,
    "Name": "Gaylord Inc and Sons",
    "Description": "Enhanced user-facing framework",
    "URL": "http://www.example.com/",
    "Type": "ex",
    "AssociateId": 162,
    "AssociateFullName": "Angel Jacobson",
    "TypeId": 165,
    "Updated": "2021-11-18T18:28:48.9019617+01:00",
    "StatusId": 669,
    "Status": "aliquam",
    "TextId": 91,
    "PublishTo": "2001-07-01T18:28:48.9019617+02:00",
    "PublishFrom": "2020-11-11T18:28:48.9019617+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1014082",
    "ActiveErpLinks": 18,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 244
      }
    }
  },
  "Date": "2006-06-14T18:28:48.9019617+02:00",
  "ExternalRef": "non",
  "Completed": "Completed",
  "ActiveLinks": 711,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Will, Walter and Corkery",
      "Id": 215,
      "Description": "Phased bandwidth-monitored moderator",
      "ExtraInfo": "quod",
      "LinkId": 831,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 203
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Orn-Ullrich",
    "SaleDate": "1998-04-02T18:28:48.9019617+02:00",
    "SaleId": 578,
    "Probability": 87,
    "Title": "ipsam",
    "Amount": 5108.42,
    "Currency": "quis",
    "ProjectName": "Schiller LLC",
    "AssociateFullName": "Sigurd Powlowski",
    "Description": "Grass-roots clear-thinking orchestration",
    "Status": "Lost",
    "WeightedAmount": 3444.266,
    "ProjectId": 878,
    "EarningPercent": 4525.496,
    "Earning": 28729.378,
    "ContactId": 64,
    "AssociateId": 48,
    "PersonId": 342,
    "SaleTypeId": 189,
    "SaleTypeName": "Parisian LLC",
    "PersonFullName": "Miss Hillary Stokes",
    "Completed": "Completed",
    "ActiveErpLinks": 847,
    "NextDueDate": "2015-06-28T18:28:48.9029617+02:00",
    "Number": "1536842",
    "TableRight": {},
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
  },
  "SuggestedDocumentId": 89,
  "Snum": 856,
  "UserDefinedFields": {
    "SuperOffice:1": "895485702",
    "SuperOffice:2": "Edna Kuhn"
  },
  "ExtraFields": {
    "ExtraFields1": "quaerat",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "excepturi",
    "CustomFields2": "fugiat"
  },
  "PublishEventDate": "2018-06-06T18:28:48.9029617+02:00",
  "PublishTo": "1994-11-27T18:28:48.9029617+01:00",
  "PublishFrom": "1996-05-16T18:28:48.9029617+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 995,
      "Visibility": "All",
      "DisplayValue": "laudantium",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 406
        }
      }
    },
    {
      "VisibleId": 995,
      "Visibility": "All",
      "DisplayValue": "laudantium",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 406
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
      "FieldLength": 831
    }
  }
}
```