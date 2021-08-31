---
title: GET Document/default
id: v1DocumentEntity_DefaultDocumentEntity
---

# GET Document/default

```http
GET /api/v1/Document/default
```

Set default values into a new DocumentEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Document agent service CreateDefaultDocumentEntity.






## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/Document/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 06 Sep 2009 15:05:42 G9T

{
  "DocumentId": 637,
  "UpdatedBy": {
    "AssociateId": 605,
    "Name": "Steuber Inc and Sons",
    "PersonId": 687,
    "Rank": 239,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 71,
    "FullName": "Helena Blanda",
    "FormalName": "Klein, White and Beahan",
    "Deleted": false,
    "EjUserId": 744,
    "UserName": "Treutel, McLaughlin and Price",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 412
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 55,
    "Name": "Torphy, Aufderhar and Thompson",
    "PersonId": 985,
    "Rank": 469,
    "Tooltip": "deleniti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 236,
    "FullName": "Osborne Stracke",
    "FormalName": "Purdy, Little and Quitzon",
    "Deleted": true,
    "EjUserId": 355,
    "UserName": "Gislason Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 748
      }
    }
  },
  "Attention": "perferendis",
  "Header": "tenetur",
  "Name": "Cummerata-Shields",
  "OurRef": "dolorem",
  "YourRef": "ab",
  "CreatedDate": "2008-05-25T15:05:42.0420039+02:00",
  "UpdatedDate": "2009-09-06T15:05:42.0420039+02:00",
  "Description": "Phased solution-oriented utilisation",
  "DocumentTemplate": {
    "DocumentTemplateId": 503,
    "Name": "Johns, Willms and Stiedemann",
    "Tooltip": "rerum",
    "SaveInDb": 155,
    "Filename": "facilis",
    "DefaultOref": "explicabo",
    "RecordType": "Appointment",
    "Deleted": 927,
    "Direction": "Incoming",
    "AutoeventId": 779,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 912
      }
    }
  },
  "Person": {
    "Position": "eum",
    "PersonId": 215,
    "Mrmrs": "id",
    "Firstname": "Marcos",
    "Lastname": "Kirlin",
    "MiddleName": "Fadel-Nienow",
    "Title": "quos",
    "Description": "Face to face holistic task-force",
    "Email": "orie_padberg@jerde.info",
    "FullName": "Miss Estrella Fisher",
    "DirectPhone": "1-231-770-0810",
    "FormalName": "Howell LLC",
    "CountryId": 657,
    "ContactId": 968,
    "ContactName": "Johns LLC",
    "Retired": 503,
    "Rank": 457,
    "ActiveInterests": 209,
    "ContactDepartment": "",
    "ContactCountryId": 367,
    "ContactOrgNr": "401643",
    "FaxPhone": "(460)113-3327 x37624",
    "MobilePhone": "1-566-266-7651 x77828",
    "ContactPhone": "(785)288-7680 x30548",
    "AssociateName": "Zemlak Inc and Sons",
    "AssociateId": 332,
    "UsePersonAddress": false,
    "ContactFax": "voluptas",
    "Kanafname": "minus",
    "Kanalname": "voluptatem",
    "Post1": "sunt",
    "Post2": "rerum",
    "Post3": "et",
    "EmailName": "kristoffer.rogahn@dibbertbarton.biz",
    "ContactFullName": "Amiya Hane",
    "ActiveErpLinks": 602,
    "TicketPriorityId": 333,
    "SupportLanguageId": 711,
    "SupportAssociateId": 182,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 795
      }
    }
  },
  "Associate": {
    "AssociateId": 649,
    "Name": "Hoeger, Goodwin and Bednar",
    "PersonId": 744,
    "Rank": 838,
    "Tooltip": "mollitia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 699,
    "FullName": "Emilio Olson IV",
    "FormalName": "Yundt LLC",
    "Deleted": true,
    "EjUserId": 629,
    "UserName": "Fadel, Prosacco and Morar",
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
  "Contact": {
    "ContactId": 231,
    "Name": "Mertz Group",
    "OrgNr": "864332",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "cupiditate",
    "DirectPhone": "1-807-732-2808",
    "AssociateId": 812,
    "CountryId": 532,
    "EmailAddress": "kaden@walter.uk",
    "Kananame": "voluptas",
    "EmailAddressName": "letitia.keeling@koch.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jane Swift V",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "soluta",
    "FullName": "Celestine Schulist",
    "IsOwnerContact": false,
    "ActiveErpLinks": 787,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 433
      }
    }
  },
  "Project": {
    "ProjectId": 650,
    "Name": "Price-West",
    "Description": "Business-focused systematic archive",
    "URL": "http://www.example.com/",
    "Type": "commodi",
    "AssociateId": 633,
    "AssociateFullName": "Kaylee Hirthe",
    "TypeId": 851,
    "Updated": "2011-04-04T15:05:42.0440039+02:00",
    "StatusId": 745,
    "Status": "dolores",
    "TextId": 469,
    "PublishTo": "2000-05-07T15:05:42.0440039+02:00",
    "PublishFrom": "2006-11-24T15:05:42.0440039+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1083447",
    "ActiveErpLinks": 512,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 30
      }
    }
  },
  "Date": "2004-03-17T15:05:42.0440039+01:00",
  "ExternalRef": "et",
  "Completed": "Completed",
  "ActiveLinks": 185,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Jaskolski, Langosh and Quigley",
      "Id": 965,
      "Description": "Automated mission-critical instruction set",
      "ExtraInfo": "eveniet",
      "LinkId": 127,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 215
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Stracke, Smith and Toy",
    "SaleDate": "2005-09-09T15:05:42.0450043+02:00",
    "SaleId": 386,
    "Probability": 824,
    "Title": "aperiam",
    "Amount": 31101.816,
    "Currency": "fugiat",
    "ProjectName": "Sawayn, Hane and Johns",
    "AssociateFullName": "Eve Lesch II",
    "Description": "Multi-lateral regional installation",
    "Status": "Lost",
    "WeightedAmount": 29243.354,
    "ProjectId": 553,
    "EarningPercent": 7346.096,
    "Earning": 30738.271999999997,
    "ContactId": 386,
    "AssociateId": 899,
    "PersonId": 539,
    "SaleTypeId": 684,
    "SaleTypeName": "Simonis, Ullrich and Mante",
    "PersonFullName": "Eladio Walker",
    "Completed": "Completed",
    "ActiveErpLinks": 586,
    "NextDueDate": "2019-06-25T15:05:42.0450043+02:00",
    "Number": "1643991",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 191
      }
    }
  },
  "SuggestedDocumentId": 572,
  "Snum": 708,
  "UserDefinedFields": {
    "SuperOffice:1": "Serenity Heathcote",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "doloremque",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "nostrum"
  },
  "PublishEventDate": "2021-02-27T15:05:42.0450043+01:00",
  "PublishTo": "1997-02-28T15:05:42.0450043+01:00",
  "PublishFrom": "1997-08-22T15:05:42.0450043+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 121,
      "Visibility": "All",
      "DisplayValue": "beatae",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 535
        }
      }
    },
    {
      "VisibleId": 121,
      "Visibility": "All",
      "DisplayValue": "beatae",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 535
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "unleash vertical technologies"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 789
    }
  }
}
```