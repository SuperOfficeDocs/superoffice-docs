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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 197,
  "Name": "Baumbach LLC",
  "Department": "",
  "OrgNr": "1395450",
  "Number1": "763440",
  "Number2": "352013",
  "UpdatedDate": "2021-03-25T13:28:31.460542+01:00",
  "CreatedDate": "2015-04-30T13:28:31.460542+02:00",
  "Emails": [
    {
      "Value": "laborum",
      "StrippedValue": "commodi",
      "Description": "Team-oriented impactful workforce"
    },
    {
      "Value": "laborum",
      "StrippedValue": "commodi",
      "Description": "Team-oriented impactful workforce"
    }
  ],
  "Interests": [
    {
      "Id": 637,
      "Name": "Bashirian Group",
      "ToolTip": "Atque quasi sed sequi odit dolor exercitationem.",
      "Deleted": true,
      "Rank": 183,
      "Type": "voluptatem",
      "ColorBlock": 86,
      "IconHint": "molestias",
      "Selected": true,
      "LastChanged": "2018-06-24T13:28:31.460542+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "quo",
      "Hidden": false,
      "FullName": "Reagan Schiller"
    }
  ],
  "Urls": [
    {
      "Value": "temporibus",
      "StrippedValue": "qui",
      "Description": "Focused systemic middleware"
    },
    {
      "Value": "temporibus",
      "StrippedValue": "qui",
      "Description": "Focused systemic middleware"
    }
  ],
  "Phones": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "ut",
      "Description": "Synchronised hybrid archive"
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "ut",
      "Description": "Synchronised hybrid archive"
    }
  ],
  "Faxes": [
    {
      "Value": "impedit",
      "StrippedValue": "sit",
      "Description": "User-friendly content-based adapter"
    },
    {
      "Value": "impedit",
      "StrippedValue": "sit",
      "Description": "User-friendly content-based adapter"
    }
  ],
  "Description": "Optional impactful leverage",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sed",
      "PersonId": 448,
      "Mrmrs": "magnam",
      "Firstname": "Chester",
      "Lastname": "Schmeler",
      "MiddleName": "Jacobi Inc and Sons",
      "Title": "est",
      "Description": "Configurable radical collaboration",
      "Email": "niko@littlegrady.info",
      "FullName": "Arnold Koepp",
      "DirectPhone": "(461)809-7901",
      "FormalName": "O'Kon LLC",
      "CountryId": 462,
      "ContactId": 594,
      "ContactName": "Dare Inc and Sons",
      "Retired": 197,
      "Rank": 969,
      "ActiveInterests": 907,
      "ContactDepartment": "",
      "ContactCountryId": 405,
      "ContactOrgNr": "763151",
      "FaxPhone": "1-744-238-5168",
      "MobilePhone": "188.827.0597",
      "ContactPhone": "1-773-165-1384",
      "AssociateName": "Stokes-Harris",
      "AssociateId": 503,
      "UsePersonAddress": false,
      "ContactFax": "repellendus",
      "Kanafname": "quis",
      "Kanalname": "eligendi",
      "Post1": "aspernatur",
      "Post2": "nam",
      "Post3": "voluptates",
      "EmailName": "luciano_rice@leannonrussel.co.uk",
      "ContactFullName": "Carolina Kuhic",
      "ActiveErpLinks": 568,
      "TicketPriorityId": 143,
      "SupportLanguageId": 486,
      "SupportAssociateId": 960,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "laborum",
  "Xstop": false,
  "ActiveInterests": 227,
  "GroupId": 530,
  "ActiveStatusMonitorId": 707,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 416,
  "DbiAgentId": 477,
  "DbiLastSyncronized": "2000-06-23T13:28:31.460542+02:00",
  "DbiKey": "veniam",
  "DbiLastModified": "1998-10-27T13:28:31.460542+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 956,
  "ActiveErpLinks": 383,
  "BounceEmails": [
    "kenyatta_bradtke@gibsonbogisich.biz",
    "julia@stanton.co.uk"
  ],
  "Domains": [
    "excepturi",
    "sed"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Shannon Metz",
    "SuperOffice:2": "Mrs. Leta Amari Farrell DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "nemo",
    "ExtraFields2": "culpa"
  },
  "CustomFields": {
    "CustomFields1": "vitae",
    "CustomFields2": "officiis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 113,
  "Name": "Jaskolski, Pfannerstill and Hauck",
  "Department": "",
  "OrgNr": "1225022",
  "Number1": "1028385",
  "Number2": "910981",
  "UpdatedDate": "2006-06-23T13:28:31.4761635+02:00",
  "CreatedDate": "2004-03-23T13:28:31.4761635+01:00",
  "Emails": [
    {
      "Value": "in",
      "StrippedValue": "et",
      "Description": "Quality-focused homogeneous installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 220
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "et",
      "Description": "Quality-focused homogeneous installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 220
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 117,
      "Name": "Tremblay LLC",
      "ToolTip": "Dolores tempore expedita corrupti aspernatur.",
      "Deleted": true,
      "Rank": 257,
      "Type": "qui",
      "ColorBlock": 918,
      "IconHint": "placeat",
      "Selected": true,
      "LastChanged": "2010-01-14T13:28:31.4761635+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ab",
      "StyleHint": "eaque",
      "Hidden": true,
      "FullName": "Miss Jaiden Skyla Kemmer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 38
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dolor",
      "StrippedValue": "cum",
      "Description": "Sharable transitional internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 72
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "cum",
      "Description": "Sharable transitional internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 72
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "excepturi",
      "StrippedValue": "et",
      "Description": "Right-sized reciprocal toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 77
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "et",
      "Description": "Right-sized reciprocal toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 77
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tempore",
      "StrippedValue": "dolores",
      "Description": "Polarised multi-state function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 860
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "dolores",
      "Description": "Polarised multi-state function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 860
        }
      }
    }
  ],
  "Description": "Seamless dedicated benchmark",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "illum",
      "PersonId": 116,
      "Mrmrs": "aliquid",
      "Firstname": "Dell",
      "Lastname": "Barrows",
      "MiddleName": "Yundt-Bechtelar",
      "Title": "et",
      "Description": "Virtual value-added structure",
      "Email": "madyson.boyer@hermandicki.com",
      "FullName": "Theodora Kassulke",
      "DirectPhone": "473.634.5026 x144",
      "FormalName": "Dickens, McClure and Mann",
      "CountryId": 494,
      "ContactId": 239,
      "ContactName": "Lang-Parisian",
      "Retired": 500,
      "Rank": 921,
      "ActiveInterests": 579,
      "ContactDepartment": "",
      "ContactCountryId": 985,
      "ContactOrgNr": "1190259",
      "FaxPhone": "1-030-615-7524 x1536",
      "MobilePhone": "150-429-1568",
      "ContactPhone": "1-572-382-6723",
      "AssociateName": "Johns, Ward and Casper",
      "AssociateId": 269,
      "UsePersonAddress": true,
      "ContactFax": "laboriosam",
      "Kanafname": "reiciendis",
      "Kanalname": "optio",
      "Post1": "et",
      "Post2": "dolor",
      "Post3": "quo",
      "EmailName": "shanna_klein@connelly.ca",
      "ContactFullName": "Mr. Toney Schimmel",
      "ActiveErpLinks": 343,
      "TicketPriorityId": 484,
      "SupportLanguageId": 383,
      "SupportAssociateId": 735,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 961
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "laboriosam",
  "Xstop": true,
  "ActiveInterests": 552,
  "GroupId": 422,
  "ActiveStatusMonitorId": 714,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 704,
  "DbiAgentId": 597,
  "DbiLastSyncronized": "2022-03-23T13:28:31.4761635+01:00",
  "DbiKey": "veniam",
  "DbiLastModified": "2013-02-25T13:28:31.4761635+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 470,
  "ActiveErpLinks": 300,
  "BounceEmails": [
    "estel@harvey.com",
    "magnus@stroman.info"
  ],
  "Domains": [
    "laudantium",
    "eos"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Otto Schneider",
    "SuperOffice:2": "Cyril Bernier PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "nobis",
    "ExtraFields2": "quaerat"
  },
  "CustomFields": {
    "CustomFields1": "ad",
    "CustomFields2": "ipsa"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 683
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```