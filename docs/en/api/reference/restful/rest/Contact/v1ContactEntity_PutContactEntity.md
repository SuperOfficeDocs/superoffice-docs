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
  "ContactId": 299,
  "Name": "Considine, Farrell and Kling",
  "Department": "",
  "OrgNr": "1542790",
  "Number1": "1414747",
  "Number2": "1113225",
  "UpdatedDate": "2005-06-16T14:32:11.3020727+02:00",
  "CreatedDate": "2019-06-28T14:32:11.3020727+02:00",
  "Emails": [
    {
      "Value": "sed",
      "StrippedValue": "maiores",
      "Description": "Implemented full-range collaboration"
    },
    {
      "Value": "sed",
      "StrippedValue": "maiores",
      "Description": "Implemented full-range collaboration"
    }
  ],
  "Interests": [
    {
      "Id": 811,
      "Name": "Schamberger, Stiedemann and Erdman",
      "ToolTip": "Nisi amet possimus fuga consequatur dolorem.",
      "Deleted": true,
      "Rank": 773,
      "Type": "cupiditate",
      "ColorBlock": 846,
      "IconHint": "alias",
      "Selected": true,
      "LastChanged": "2006-11-29T14:32:11.3020727+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "soluta",
      "StyleHint": "ad",
      "Hidden": false,
      "FullName": "Alize Nikolaus"
    }
  ],
  "Urls": [
    {
      "Value": "tempore",
      "StrippedValue": "assumenda",
      "Description": "Realigned real-time utilisation"
    },
    {
      "Value": "tempore",
      "StrippedValue": "assumenda",
      "Description": "Realigned real-time utilisation"
    }
  ],
  "Phones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "sint",
      "Description": "Profound methodical utilisation"
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "sint",
      "Description": "Profound methodical utilisation"
    }
  ],
  "Faxes": [
    {
      "Value": "cupiditate",
      "StrippedValue": "iusto",
      "Description": "Grass-roots clear-thinking knowledge user"
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "iusto",
      "Description": "Grass-roots clear-thinking knowledge user"
    }
  ],
  "Description": "Devolved context-sensitive success",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "pariatur",
      "PersonId": 254,
      "Mrmrs": "qui",
      "Firstname": "Samantha",
      "Lastname": "Leffler",
      "MiddleName": "Carroll-Smitham",
      "Title": "voluptatem",
      "Description": "Total optimizing service-desk",
      "Email": "kathryne@daniel.co.uk",
      "FullName": "Norbert Jones",
      "DirectPhone": "(481)658-9956 x27799",
      "FormalName": "Kovacek Inc and Sons",
      "CountryId": 200,
      "ContactId": 146,
      "ContactName": "Bartell-Braun",
      "Retired": 403,
      "Rank": 412,
      "ActiveInterests": 706,
      "ContactDepartment": "",
      "ContactCountryId": 800,
      "ContactOrgNr": "726506",
      "FaxPhone": "594.142.7053",
      "MobilePhone": "393.449.4960 x9947",
      "ContactPhone": "771-651-0068",
      "AssociateName": "Donnelly, Swift and Deckow",
      "AssociateId": 365,
      "UsePersonAddress": true,
      "ContactFax": "est",
      "Kanafname": "ut",
      "Kanalname": "libero",
      "Post1": "consequatur",
      "Post2": "corporis",
      "Post3": "illum",
      "EmailName": "nadia@ebert.us",
      "ContactFullName": "Dr. Art Mosciski PhD",
      "ActiveErpLinks": 236,
      "TicketPriorityId": 700,
      "SupportLanguageId": 882,
      "SupportAssociateId": 376,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1541063"
    }
  ],
  "NoMailing": false,
  "Kananame": "est",
  "Xstop": true,
  "ActiveInterests": 818,
  "GroupId": 135,
  "ActiveStatusMonitorId": 14,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 438,
  "DbiAgentId": 551,
  "DbiLastSyncronized": "2017-01-30T14:32:11.317696+01:00",
  "DbiKey": "necessitatibus",
  "DbiLastModified": "2017-06-15T14:32:11.317696+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 463,
  "ActiveErpLinks": 456,
  "BounceEmails": [
    "jordane@johnston.info",
    "jane.fisher@leuschke.ca"
  ],
  "Domains": [
    "aut",
    "ut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Rahul Rempel"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "voluptatibus"
  },
  "CustomFields": {
    "CustomFields1": "voluptate",
    "CustomFields2": "voluptates"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 238,
  "Name": "Tremblay LLC",
  "Department": "",
  "OrgNr": "1255508",
  "Number1": "357716",
  "Number2": "1023480",
  "UpdatedDate": "2014-06-26T14:32:11.317696+02:00",
  "CreatedDate": "2024-06-13T14:32:11.317696+02:00",
  "Emails": [
    {
      "Value": "eum",
      "StrippedValue": "maxime",
      "Description": "Virtual methodical function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 570
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "maxime",
      "Description": "Virtual methodical function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 570
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 472,
      "Name": "Denesik-Hauck",
      "ToolTip": "Doloremque enim.",
      "Deleted": true,
      "Rank": 287,
      "Type": "nesciunt",
      "ColorBlock": 505,
      "IconHint": "corrupti",
      "Selected": false,
      "LastChanged": "2017-01-21T14:32:11.317696+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptates",
      "StyleHint": "voluptates",
      "Hidden": false,
      "FullName": "Alyson Durgan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 227
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aspernatur",
      "StrippedValue": "perferendis",
      "Description": "Streamlined interactive emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 610
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "perferendis",
      "Description": "Streamlined interactive emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 610
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "dolor",
      "StrippedValue": "vel",
      "Description": "Versatile responsive productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 619
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "vel",
      "Description": "Versatile responsive productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 619
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ex",
      "StrippedValue": "quia",
      "Description": "Ergonomic motivating encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 78
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "quia",
      "Description": "Ergonomic motivating encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 78
        }
      }
    }
  ],
  "Description": "Balanced holistic toolset",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eligendi",
      "PersonId": 228,
      "Mrmrs": "quo",
      "Firstname": "Elinore",
      "Lastname": "Mills",
      "MiddleName": "Tromp-Satterfield",
      "Title": "tenetur",
      "Description": "Intuitive directional secured line",
      "Email": "felipe@stammconsidine.info",
      "FullName": "Travon Hickle",
      "DirectPhone": "998-177-5217",
      "FormalName": "Braun, Wilkinson and Koepp",
      "CountryId": 522,
      "ContactId": 517,
      "ContactName": "Brekke, Hintz and Conn",
      "Retired": 329,
      "Rank": 421,
      "ActiveInterests": 282,
      "ContactDepartment": "",
      "ContactCountryId": 321,
      "ContactOrgNr": "1475350",
      "FaxPhone": "336.365.2622 x898",
      "MobilePhone": "223.473.8702 x283",
      "ContactPhone": "672-454-7498",
      "AssociateName": "Rolfson-Fisher",
      "AssociateId": 518,
      "UsePersonAddress": false,
      "ContactFax": "dolores",
      "Kanafname": "recusandae",
      "Kanalname": "voluptatem",
      "Post1": "soluta",
      "Post2": "unde",
      "Post3": "perferendis",
      "EmailName": "nash.bernier@westgorczany.uk",
      "ContactFullName": "Edd Sauer",
      "ActiveErpLinks": 304,
      "TicketPriorityId": 101,
      "SupportLanguageId": 247,
      "SupportAssociateId": 278,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1101467",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 518
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "excepturi",
  "Xstop": true,
  "ActiveInterests": 528,
  "GroupId": 238,
  "ActiveStatusMonitorId": 237,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 649,
  "DbiAgentId": 544,
  "DbiLastSyncronized": "2023-06-30T14:32:11.317696+02:00",
  "DbiKey": "dolorum",
  "DbiLastModified": "1999-06-11T14:32:11.317696+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 873,
  "ActiveErpLinks": 142,
  "BounceEmails": [
    "jamar@kuhlman.com",
    "jaida.kassulke@reichelkohler.com"
  ],
  "Domains": [
    "ducimus",
    "qui"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Brenna Schoen",
    "SuperOffice:2": "Tyson Isaac Monahan II"
  },
  "ExtraFields": {
    "ExtraFields1": "labore",
    "ExtraFields2": "labore"
  },
  "CustomFields": {
    "CustomFields1": "alias",
    "CustomFields2": "molestias"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 740
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```