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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 619,
  "PersonId": 66,
  "AppointmentId": 520,
  "DocumentId": 92,
  "SaleId": 462,
  "SelectionId": 920,
  "ProjectId": 477,
  "UiCulture": "dolor"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 101,
  "UpdatedBy": {
    "AssociateId": 451,
    "Name": "Toy, Goyette and Murazik",
    "PersonId": 32,
    "Rank": 407,
    "Tooltip": "modi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 646,
    "FullName": "Marisa Adams",
    "FormalName": "Corkery Inc and Sons",
    "Deleted": true,
    "EjUserId": 519,
    "UserName": "Lowe, Huels and Miller",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 942
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 241,
    "Name": "Schroeder-Goyette",
    "PersonId": 732,
    "Rank": 392,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 984,
    "FullName": "Ewell Olson",
    "FormalName": "Klein, Stanton and Gleason",
    "Deleted": true,
    "EjUserId": 421,
    "UserName": "Bergnaum, Sipes and Herman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 803
      }
    }
  },
  "Attention": "illo",
  "Header": "nam",
  "Name": "Hackett-Borer",
  "OurRef": "et",
  "YourRef": "mollitia",
  "CreatedDate": "1996-11-16T18:28:48.9659557+01:00",
  "UpdatedDate": "2008-05-12T18:28:48.9659557+02:00",
  "Description": "Enterprise-wide optimizing paradigm",
  "DocumentTemplate": {
    "DocumentTemplateId": 166,
    "Name": "Von, Steuber and Schimmel",
    "Tooltip": "perspiciatis",
    "SaveInDb": 334,
    "Filename": "consequatur",
    "DefaultOref": "debitis",
    "RecordType": "Appointment",
    "Deleted": 114,
    "Direction": "Incoming",
    "AutoeventId": 903,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 136
      }
    }
  },
  "Person": {
    "Position": "ut",
    "PersonId": 37,
    "Mrmrs": "quo",
    "Firstname": "Cornelius",
    "Lastname": "Kerluke",
    "MiddleName": "Kemmer, Walsh and Nader",
    "Title": "aut",
    "Description": "Digitized 6th generation implementation",
    "Email": "adam.lakin@sawayn.com",
    "FullName": "Brendon Larson",
    "DirectPhone": "(583)457-8720 x7053",
    "FormalName": "Schroeder-Luettgen",
    "CountryId": 297,
    "ContactId": 925,
    "ContactName": "Kerluke, Roberts and McClure",
    "Retired": 447,
    "Rank": 700,
    "ActiveInterests": 196,
    "ContactDepartment": "",
    "ContactCountryId": 774,
    "ContactOrgNr": "530771",
    "FaxPhone": "088.702.7430 x52853",
    "MobilePhone": "(360)541-6272",
    "ContactPhone": "(732)168-1716 x53466",
    "AssociateName": "Rice-Steuber",
    "AssociateId": 464,
    "UsePersonAddress": false,
    "ContactFax": "exercitationem",
    "Kanafname": "adipisci",
    "Kanalname": "sed",
    "Post1": "quos",
    "Post2": "ut",
    "Post3": "ut",
    "EmailName": "glenda_collins@volkman.us",
    "ContactFullName": "Neoma Effertz",
    "ActiveErpLinks": 591,
    "TicketPriorityId": 731,
    "SupportLanguageId": 268,
    "SupportAssociateId": 534,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 949
      }
    }
  },
  "Associate": {
    "AssociateId": 403,
    "Name": "Orn-Ankunding",
    "PersonId": 545,
    "Rank": 476,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 222,
    "FullName": "Trudie Wilkinson",
    "FormalName": "Nikolaus, Reinger and Champlin",
    "Deleted": false,
    "EjUserId": 635,
    "UserName": "Schuster-Wunsch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 87
      }
    }
  },
  "Contact": {
    "ContactId": 329,
    "Name": "Schumm-McGlynn",
    "OrgNr": "1624094",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ipsam",
    "DirectPhone": "033.587.2117 x250",
    "AssociateId": 541,
    "CountryId": 407,
    "EmailAddress": "andy@champlin.us",
    "Kananame": "debitis",
    "EmailAddressName": "cale@gradyabernathy.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Maya Ortiz",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "et",
    "FullName": "Nathen Kessler",
    "IsOwnerContact": false,
    "ActiveErpLinks": 628,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 691
      }
    }
  },
  "Project": {
    "ProjectId": 327,
    "Name": "Quigley, Hintz and Gorczany",
    "Description": "Digitized regional policy",
    "URL": "http://www.example.com/",
    "Type": "nesciunt",
    "AssociateId": 897,
    "AssociateFullName": "Cristal Kuphal",
    "TypeId": 940,
    "Updated": "2007-11-07T18:28:48.9689575+01:00",
    "StatusId": 270,
    "Status": "veniam",
    "TextId": 744,
    "PublishTo": "2012-10-21T18:28:48.9689575+02:00",
    "PublishFrom": "2018-12-14T18:28:48.9689575+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "990498",
    "ActiveErpLinks": 841,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 459
      }
    }
  },
  "Date": "2018-08-15T18:28:48.9689575+02:00",
  "ExternalRef": "voluptas",
  "Completed": "Completed",
  "ActiveLinks": 555,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Goodwin-Abshire",
      "Id": 822,
      "Description": "Polarised asynchronous intranet",
      "ExtraInfo": "possimus",
      "LinkId": 785,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Jerde-Fadel",
    "SaleDate": "2012-02-14T18:28:48.969955+01:00",
    "SaleId": 219,
    "Probability": 243,
    "Title": "aliquid",
    "Amount": 13755.126,
    "Currency": "amet",
    "ProjectName": "Price-Batz",
    "AssociateFullName": "Vena Borer DVM",
    "Description": "Front-line analyzing workforce",
    "Status": "Lost",
    "WeightedAmount": 14454.008,
    "ProjectId": 132,
    "EarningPercent": 7427.58,
    "Earning": 17675.76,
    "ContactId": 79,
    "AssociateId": 209,
    "PersonId": 243,
    "SaleTypeId": 354,
    "SaleTypeName": "Boyer-Murazik",
    "PersonFullName": "Miss Else Brakus",
    "Completed": "Completed",
    "ActiveErpLinks": 337,
    "NextDueDate": "2011-04-19T18:28:48.969955+02:00",
    "Number": "1624861",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 445
      }
    }
  },
  "SuggestedDocumentId": 845,
  "Snum": 471,
  "UserDefinedFields": {
    "SuperOffice:1": "1779968285",
    "SuperOffice:2": "634062081"
  },
  "ExtraFields": {
    "ExtraFields1": "iure",
    "ExtraFields2": "hic"
  },
  "CustomFields": {
    "CustomFields1": "explicabo",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2017-05-31T18:28:48.969955+02:00",
  "PublishTo": "2007-04-03T18:28:48.969955+02:00",
  "PublishFrom": "2018-12-10T18:28:48.969955+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 109,
      "Visibility": "All",
      "DisplayValue": "animi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 325
        }
      }
    },
    {
      "VisibleId": 109,
      "Visibility": "All",
      "DisplayValue": "animi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 325
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
      "FieldLength": 165
    }
  }
}
```