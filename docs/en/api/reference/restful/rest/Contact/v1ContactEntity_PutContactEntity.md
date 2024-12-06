---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
generated: true
---

# PUT Contact/{id}

```http
PUT /api/v1/Contact/{id}
```

Updates the existing ContactEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Contact/{id}?$select=name,department,category/id
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

## Request Body: entity 

The ContactEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

ContactEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity updated. |
| 412 | Update stopped because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 594,
  "Name": "Hagenes, Botsford and Walter",
  "Department": "",
  "OrgNr": "715570",
  "Number1": "1131332",
  "Number2": "537015",
  "UpdatedDate": "2007-04-11T10:18:00.3011917+02:00",
  "CreatedDate": "2012-01-31T10:18:00.3011917+01:00",
  "Emails": [
    {
      "Value": "vero",
      "StrippedValue": "et",
      "Description": "Managed bandwidth-monitored archive"
    },
    {
      "Value": "vero",
      "StrippedValue": "et",
      "Description": "Managed bandwidth-monitored archive"
    }
  ],
  "Interests": [
    {
      "Id": 542,
      "Name": "Schinner-Rutherford",
      "ToolTip": "Tempore fuga voluptas voluptas amet dolores.",
      "Deleted": false,
      "Rank": 667,
      "Type": "deleniti",
      "ColorBlock": 183,
      "IconHint": "assumenda",
      "Selected": false,
      "LastChanged": "2003-05-31T10:18:00.3011917+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "accusamus",
      "StyleHint": "dolores",
      "Hidden": false,
      "FullName": "Marian Howell"
    }
  ],
  "Urls": [
    {
      "Value": "ab",
      "StrippedValue": "excepturi",
      "Description": "Mandatory explicit firmware"
    },
    {
      "Value": "ab",
      "StrippedValue": "excepturi",
      "Description": "Mandatory explicit firmware"
    }
  ],
  "Phones": [
    {
      "Value": "sed",
      "StrippedValue": "molestiae",
      "Description": "Grass-roots radical structure"
    },
    {
      "Value": "sed",
      "StrippedValue": "molestiae",
      "Description": "Grass-roots radical structure"
    }
  ],
  "Faxes": [
    {
      "Value": "officia",
      "StrippedValue": "tempora",
      "Description": "Robust local analyzer"
    },
    {
      "Value": "officia",
      "StrippedValue": "tempora",
      "Description": "Robust local analyzer"
    }
  ],
  "Description": "Focused real-time intranet",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "incidunt",
      "PersonId": 971,
      "Mrmrs": "ut",
      "Firstname": "Charley",
      "Lastname": "Cartwright",
      "MiddleName": "Lakin-Kuphal",
      "Title": "et",
      "Description": "Right-sized exuding info-mediaries",
      "Email": "bianka_reinger@leuschke.us",
      "FullName": "Jewel Morar",
      "DirectPhone": "1-915-104-2230",
      "FormalName": "Cartwright LLC",
      "CountryId": 928,
      "ContactId": 824,
      "ContactName": "Bradtke, Cummings and Barton",
      "Retired": 208,
      "Rank": 103,
      "ActiveInterests": 353,
      "ContactDepartment": "transition out-of-the-box niches",
      "ContactCountryId": 203,
      "ContactOrgNr": "1247384",
      "FaxPhone": "1-848-064-5950 x1267",
      "MobilePhone": "1-451-683-2739 x5586",
      "ContactPhone": "779.021.2451 x13168",
      "AssociateName": "Lind-Pagac",
      "AssociateId": 107,
      "UsePersonAddress": false,
      "ContactFax": "sit",
      "Kanafname": "reiciendis",
      "Kanalname": "sunt",
      "Post1": "officia",
      "Post2": "exercitationem",
      "Post3": "officiis",
      "EmailName": "josue@bechtelar.co.uk",
      "ContactFullName": "Camden Kulas",
      "ActiveErpLinks": 475,
      "TicketPriorityId": 30,
      "SupportLanguageId": 114,
      "SupportAssociateId": 667,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "praesentium",
  "Xstop": false,
  "ActiveInterests": 176,
  "GroupId": 581,
  "ActiveStatusMonitorId": 967,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 752,
  "DbiAgentId": 749,
  "DbiLastSyncronized": "1998-07-27T10:18:00.3011917+02:00",
  "DbiKey": "laboriosam",
  "DbiLastModified": "2022-04-05T10:18:00.3011917+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 367,
  "ActiveErpLinks": 488,
  "BounceEmails": [
    "damian_kessler@hickle.com",
    "cydney@lebsack.com"
  ],
  "Domains": [
    "sit",
    "facere"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Autumn Gottlieb",
    "SuperOffice:2": "Prof. Amely Raphael Pagac"
  },
  "ExtraFields": {
    "ExtraFields1": "quisquam",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "quia"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 943,
  "Name": "Harber Inc and Sons",
  "Department": "",
  "OrgNr": "1091738",
  "Number1": "872784",
  "Number2": "948054",
  "UpdatedDate": "2009-04-02T10:18:00.3168238+02:00",
  "CreatedDate": "2024-07-19T10:18:00.3168238+02:00",
  "Emails": [
    {
      "Value": "consequatur",
      "StrippedValue": "reiciendis",
      "Description": "Versatile multi-tasking success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 986
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "reiciendis",
      "Description": "Versatile multi-tasking success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 986
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 877,
      "Name": "Reynolds, Dicki and Rath",
      "ToolTip": "Dolorum non.",
      "Deleted": false,
      "Rank": 593,
      "Type": "tenetur",
      "ColorBlock": 517,
      "IconHint": "nostrum",
      "Selected": true,
      "LastChanged": "2019-02-04T10:18:00.3168238+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fugit",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Casper Marvin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 804
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dignissimos",
      "StrippedValue": "aut",
      "Description": "Open-architected client-driven service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 499
        }
      }
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "aut",
      "Description": "Open-architected client-driven service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 499
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sint",
      "StrippedValue": "fuga",
      "Description": "Robust content-based analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 24
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "fuga",
      "Description": "Robust content-based analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 24
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "sed",
      "Description": "Public-key analyzing migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 755
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "sed",
      "Description": "Public-key analyzing migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 755
        }
      }
    }
  ],
  "Description": "Cross-platform needs-based product",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "a",
      "PersonId": 748,
      "Mrmrs": "qui",
      "Firstname": "Eldred",
      "Lastname": "Collier",
      "MiddleName": "Walter-Hammes",
      "Title": "necessitatibus",
      "Description": "Ergonomic optimizing application",
      "Email": "emilia@sporer.co.uk",
      "FullName": "Ubaldo Dooley",
      "DirectPhone": "029-001-0573 x03254",
      "FormalName": "Kub, Walter and Jast",
      "CountryId": 416,
      "ContactId": 882,
      "ContactName": "Wintheiser, Cole and Denesik",
      "Retired": 38,
      "Rank": 326,
      "ActiveInterests": 959,
      "ContactDepartment": "",
      "ContactCountryId": 59,
      "ContactOrgNr": "1316693",
      "FaxPhone": "974-124-4815",
      "MobilePhone": "366-376-4912 x2939",
      "ContactPhone": "948.815.7575 x298",
      "AssociateName": "Homenick, Stark and Willms",
      "AssociateId": 529,
      "UsePersonAddress": false,
      "ContactFax": "neque",
      "Kanafname": "enim",
      "Kanalname": "sed",
      "Post1": "eaque",
      "Post2": "ipsam",
      "Post3": "iure",
      "EmailName": "hobart@balistreritreutel.co.uk",
      "ContactFullName": "Beryl Grant",
      "ActiveErpLinks": 516,
      "TicketPriorityId": 780,
      "SupportLanguageId": 44,
      "SupportAssociateId": 379,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 217
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "molestias",
  "Xstop": false,
  "ActiveInterests": 551,
  "GroupId": 794,
  "ActiveStatusMonitorId": 825,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 747,
  "DbiAgentId": 561,
  "DbiLastSyncronized": "2010-10-29T10:18:00.3168238+02:00",
  "DbiKey": "perferendis",
  "DbiLastModified": "2006-09-09T10:18:00.3168238+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 161,
  "ActiveErpLinks": 898,
  "BounceEmails": [
    "wilford_funk@cronin.biz",
    "obie@wolff.biz"
  ],
  "Domains": [
    "dolorem",
    "incidunt"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Libby Welch",
    "SuperOffice:2": "Ezekiel Gutmann"
  },
  "ExtraFields": {
    "ExtraFields1": "facere",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "iste",
    "CustomFields2": "ipsum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 371
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```