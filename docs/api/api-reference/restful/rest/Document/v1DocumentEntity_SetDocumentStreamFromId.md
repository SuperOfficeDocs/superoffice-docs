---
title: PUT Document/{id}/Content
id: v1DocumentEntity_SetDocumentStreamFromId
---

# PUT Document/{id}/Content

```http
PUT /api/v1/Document/{documentId}/Content
```

Store document content from stream.

Since there is a potential for a name conflict (the file name stored by the document entity earlier may prove to be invalid), the (possibly amended) document entity is returned. The client should not assume that any earlier, cached entity information is valid.




| Path Part | Type | Description |
|-----------|------|-------------|
| documentId | int32 | The document entity object that the binary data (document) should be stored to. Its file name may be amended by this call, see the return value. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `image/jpeg`, `image/jpg`, `image/png`, `image/gif`, `image/bmp`, `image/tiff`, `application/octet-stream`, `application/msword`, `application/rtf`, `application/vnd.openxmlformats-officedocument.wordprocessingml.document`, `application/vnd.ms-excel`, `application/vnd.openxmlformats-officedocument.spreadsheetml.sheet`, `application/vnd.ms-powerpoint`, `application/vnd.openxmlformats-officedocument.presentationml.presentation`, `multipart/form-data`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: stream  

The document content as a stream. 



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
PUT /api/v1/Document/{documentId}/Content
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 77,
  "UpdatedBy": {
    "AssociateId": 346,
    "Name": "Spencer-Swaniawski",
    "PersonId": 484,
    "Rank": 145,
    "Tooltip": "nam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 622,
    "FullName": "Leopold Gutmann V",
    "FormalName": "Rodriguez, Ullrich and Stroman",
    "Deleted": true,
    "EjUserId": 706,
    "UserName": "Pacocha-Parisian",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 264
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 163,
    "Name": "Pfannerstill, Nolan and Veum",
    "PersonId": 418,
    "Rank": 358,
    "Tooltip": "quos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 159,
    "FullName": "Tatum Bernier",
    "FormalName": "Koelpin LLC",
    "Deleted": false,
    "EjUserId": 652,
    "UserName": "Johnson, Herman and Cronin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 186
      }
    }
  },
  "Attention": "libero",
  "Header": "modi",
  "Name": "Rohan-Thompson",
  "OurRef": "doloribus",
  "YourRef": "aut",
  "CreatedDate": "2014-08-10T18:25:50.509594+02:00",
  "UpdatedDate": "2016-07-18T18:25:50.509594+02:00",
  "Description": "User-centric bottom-line Graphical User Interface",
  "DocumentTemplate": {
    "DocumentTemplateId": 485,
    "Name": "Dare, Cormier and Nader",
    "Tooltip": "non",
    "SaveInDb": 37,
    "Filename": "in",
    "DefaultOref": "voluptas",
    "RecordType": "Appointment",
    "Deleted": 514,
    "Direction": "Incoming",
    "AutoeventId": 451,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 625
      }
    }
  },
  "Person": {
    "Position": "excepturi",
    "PersonId": 945,
    "Mrmrs": "quia",
    "Firstname": "Emile",
    "Lastname": "Ankunding",
    "MiddleName": "Hilll, Klein and Stokes",
    "Title": "non",
    "Description": "Progressive responsive adapter",
    "Email": "katheryn.klocko@fisher.co.uk",
    "FullName": "Jay Hagenes IV",
    "DirectPhone": "813.742.2147",
    "FormalName": "Hickle LLC",
    "CountryId": 123,
    "ContactId": 65,
    "ContactName": "Terry-Smith",
    "Retired": 342,
    "Rank": 431,
    "ActiveInterests": 988,
    "ContactDepartment": "",
    "ContactCountryId": 267,
    "ContactOrgNr": "1123111",
    "FaxPhone": "418.876.1845 x8125",
    "MobilePhone": "605.245.8642 x5803",
    "ContactPhone": "(800)571-1484",
    "AssociateName": "Nienow LLC",
    "AssociateId": 419,
    "UsePersonAddress": false,
    "ContactFax": "id",
    "Kanafname": "facilis",
    "Kanalname": "facilis",
    "Post1": "quasi",
    "Post2": "ipsum",
    "Post3": "ex",
    "EmailName": "mina.renner@marquardt.biz",
    "ContactFullName": "Brando McDermott",
    "ActiveErpLinks": 774,
    "TicketPriorityId": 673,
    "SupportLanguageId": 653,
    "SupportAssociateId": 509,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 988
      }
    }
  },
  "Associate": {
    "AssociateId": 318,
    "Name": "Schimmel-Larkin",
    "PersonId": 42,
    "Rank": 195,
    "Tooltip": "consectetur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 324,
    "FullName": "Marjory Kozey",
    "FormalName": "Rowe LLC",
    "Deleted": false,
    "EjUserId": 802,
    "UserName": "Daugherty, Bergstrom and Johnson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 21
      }
    }
  },
  "Contact": {
    "ContactId": 6,
    "Name": "Macejkovic, Collins and Wolff",
    "OrgNr": "382551",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "aut",
    "DirectPhone": "1-114-535-3830 x4806",
    "AssociateId": 848,
    "CountryId": 6,
    "EmailAddress": "thad@murazik.co.uk",
    "Kananame": "atque",
    "EmailAddressName": "jesus.okon@greenbrown.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Lenna O'Connell",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "officia",
    "FullName": "Rosella Hayes",
    "IsOwnerContact": false,
    "ActiveErpLinks": 177,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 507
      }
    }
  },
  "Project": {
    "ProjectId": 441,
    "Name": "Grimes Inc and Sons",
    "Description": "Expanded directional function",
    "URL": "http://www.example.com/",
    "Type": "corporis",
    "AssociateId": 134,
    "AssociateFullName": "Bernadette Rolfson",
    "TypeId": 75,
    "Updated": "2020-12-26T18:25:50.5126216+01:00",
    "StatusId": 259,
    "Status": "qui",
    "TextId": 371,
    "PublishTo": "2017-07-14T18:25:50.5126216+02:00",
    "PublishFrom": "2016-07-30T18:25:50.5126216+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "976857",
    "ActiveErpLinks": 481,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 121
      }
    }
  },
  "Date": "2002-01-25T18:25:50.5126216+01:00",
  "ExternalRef": "nam",
  "Completed": "Completed",
  "ActiveLinks": 125,
  "Type": "BookingForChecklist",
  "Links": [
    {
      "EntityName": "Herzog LLC",
      "Id": 26,
      "Description": "Stand-alone explicit benchmark",
      "ExtraInfo": "sint",
      "LinkId": 879,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 308
        }
      }
    }
  ],
  "LockSemantics": "Locking",
  "Sale": {
    "ContactName": "Bosco-Crist",
    "SaleDate": "1997-03-25T18:25:50.5126216+01:00",
    "SaleId": 313,
    "Probability": 349,
    "Title": "occaecati",
    "Amount": 16801.374,
    "Currency": "ut",
    "ProjectName": "Moore LLC",
    "AssociateFullName": "Miss Marlene Murazik",
    "Description": "Advanced secondary superstructure",
    "Status": "Lost",
    "WeightedAmount": 24912.165999999997,
    "ProjectId": 547,
    "EarningPercent": 24755.466,
    "Earning": 2059.038,
    "ContactId": 789,
    "AssociateId": 684,
    "PersonId": 903,
    "SaleTypeId": 2,
    "SaleTypeName": "Goodwin Group",
    "PersonFullName": "Gilberto Aufderhar",
    "Completed": "Completed",
    "ActiveErpLinks": 523,
    "NextDueDate": "1999-08-27T18:25:50.5136247+02:00",
    "Number": "992655",
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
  "SuggestedDocumentId": 277,
  "Snum": 517,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Jeanette Reilly"
  },
  "ExtraFields": {
    "ExtraFields1": "exercitationem",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "natus",
    "CustomFields2": "et"
  },
  "PublishEventDate": "2007-03-27T18:25:50.5136247+02:00",
  "PublishTo": "2001-12-02T18:25:50.5136247+01:00",
  "PublishFrom": "1995-08-17T18:25:50.5136247+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 118,
      "Visibility": "All",
      "DisplayValue": "quia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 543
        }
      }
    },
    {
      "VisibleId": 118,
      "Visibility": "All",
      "DisplayValue": "quia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 543
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
      "FieldLength": 552
    }
  }
}
```