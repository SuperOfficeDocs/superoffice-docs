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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
  "ContactId": 91,
  "Name": "Bartoletti Inc and Sons",
  "Department": "",
  "OrgNr": "1178154",
  "Number1": "426740",
  "Number2": "622721",
  "UpdatedDate": "2003-03-20T11:06:41.707242+01:00",
  "CreatedDate": "2012-10-01T11:06:41.707242+02:00",
  "Emails": [
    {
      "Value": "deserunt",
      "StrippedValue": "fuga",
      "Description": "Operative asynchronous frame"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "fuga",
      "Description": "Operative asynchronous frame"
    }
  ],
  "Interests": [
    {
      "Id": 236,
      "Name": "O'Hara-Purdy",
      "ToolTip": "Ut officia odit corporis et nobis fugiat perspiciatis.",
      "Deleted": true,
      "Rank": 518,
      "Type": "officiis",
      "ColorBlock": 836,
      "IconHint": "sint",
      "Selected": true,
      "LastChanged": "2005-12-27T11:06:41.707242+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "harum",
      "Hidden": false,
      "FullName": "Savannah Howe"
    }
  ],
  "Urls": [
    {
      "Value": "debitis",
      "StrippedValue": "neque",
      "Description": "Seamless full-range internet solution"
    },
    {
      "Value": "debitis",
      "StrippedValue": "neque",
      "Description": "Seamless full-range internet solution"
    }
  ],
  "Phones": [
    {
      "Value": "minus",
      "StrippedValue": "quod",
      "Description": "Organized encompassing service-desk"
    },
    {
      "Value": "minus",
      "StrippedValue": "quod",
      "Description": "Organized encompassing service-desk"
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "occaecati",
      "Description": "Multi-layered systematic secured line"
    },
    {
      "Value": "sit",
      "StrippedValue": "occaecati",
      "Description": "Multi-layered systematic secured line"
    }
  ],
  "Description": "Diverse actuating complexity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sit",
      "PersonId": 924,
      "Mrmrs": "officia",
      "Firstname": "Geoffrey",
      "Lastname": "Maggio",
      "MiddleName": "Barrows Group",
      "Title": "ad",
      "Description": "Persistent solution-oriented benchmark",
      "Email": "brielle@gerlachtillman.biz",
      "FullName": "Mozell Johnson",
      "DirectPhone": "1-526-390-0986 x2148",
      "FormalName": "Feeney Inc and Sons",
      "CountryId": 639,
      "ContactId": 256,
      "ContactName": "Jewess, Harvey and Stehr",
      "Retired": 731,
      "Rank": 207,
      "ActiveInterests": 53,
      "ContactDepartment": "",
      "ContactCountryId": 445,
      "ContactOrgNr": "208380",
      "FaxPhone": "(957)942-3775",
      "MobilePhone": "252-151-4143 x845",
      "ContactPhone": "526-856-9104 x03896",
      "AssociateName": "Gibson, Rice and Glover",
      "AssociateId": 405,
      "UsePersonAddress": false,
      "ContactFax": "amet",
      "Kanafname": "reiciendis",
      "Kanalname": "enim",
      "Post1": "quo",
      "Post2": "ut",
      "Post3": "nobis",
      "EmailName": "delmer@kuhnlebsack.uk",
      "ContactFullName": "Prof. Lionel Hayes",
      "ActiveErpLinks": 863,
      "TicketPriorityId": 731,
      "SupportLanguageId": 32,
      "SupportAssociateId": 390,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "mollitia",
  "Xstop": false,
  "ActiveInterests": 292,
  "GroupId": 548,
  "ActiveStatusMonitorId": 489,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 827,
  "DbiAgentId": 58,
  "DbiLastSyncronized": "2016-10-01T11:06:41.707242+02:00",
  "DbiKey": "saepe",
  "DbiLastModified": "2000-10-01T11:06:41.707242+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 780,
  "ActiveErpLinks": 485,
  "BounceEmails": [
    "florida_monahan@lynch.info",
    "emery_haley@crooks.biz"
  ],
  "Domains": [
    "iste",
    "iure"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "doloremque",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "incidunt",
    "CustomFields2": "odit"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 797,
  "Name": "Willms Inc and Sons",
  "Department": "",
  "OrgNr": "893043",
  "Number1": "1412317",
  "Number2": "329907",
  "UpdatedDate": "2001-09-14T11:06:41.7228464+02:00",
  "CreatedDate": "2009-12-12T11:06:41.7228464+01:00",
  "Emails": [
    {
      "Value": "asperiores",
      "StrippedValue": "repudiandae",
      "Description": "User-friendly object-oriented benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 309
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "repudiandae",
      "Description": "User-friendly object-oriented benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 309
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 109,
      "Name": "Strosin Group",
      "ToolTip": "Id et enim odio deleniti impedit ratione.",
      "Deleted": false,
      "Rank": 545,
      "Type": "debitis",
      "ColorBlock": 130,
      "IconHint": "neque",
      "Selected": false,
      "LastChanged": "2017-08-30T11:06:41.7228464+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veritatis",
      "StyleHint": "dolores",
      "Hidden": true,
      "FullName": "Dayna Beatty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 87
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "earum",
      "StrippedValue": "nemo",
      "Description": "Ergonomic value-added hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 225
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "nemo",
      "Description": "Ergonomic value-added hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 225
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "aperiam",
      "StrippedValue": "quam",
      "Description": "Multi-channelled local parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 290
        }
      }
    },
    {
      "Value": "aperiam",
      "StrippedValue": "quam",
      "Description": "Multi-channelled local parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 290
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptas",
      "StrippedValue": "qui",
      "Description": "Grass-roots hybrid structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "qui",
      "Description": "Grass-roots hybrid structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    }
  ],
  "Description": "Up-sized heuristic encoding",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sint",
      "PersonId": 322,
      "Mrmrs": "qui",
      "Firstname": "Margarett",
      "Lastname": "Kuhic",
      "MiddleName": "Aufderhar, Deckow and Becker",
      "Title": "ad",
      "Description": "Multi-layered analyzing website",
      "Email": "michale.krajcik@botsfordschmitt.co.uk",
      "FullName": "Domenica Champlin",
      "DirectPhone": "544.875.8764",
      "FormalName": "Treutel Group",
      "CountryId": 162,
      "ContactId": 490,
      "ContactName": "Okuneva-Williamson",
      "Retired": 901,
      "Rank": 538,
      "ActiveInterests": 219,
      "ContactDepartment": "",
      "ContactCountryId": 700,
      "ContactOrgNr": "1224390",
      "FaxPhone": "555.060.3382 x64643",
      "MobilePhone": "650.184.7222",
      "ContactPhone": "392.861.0586 x28592",
      "AssociateName": "Dibbert LLC",
      "AssociateId": 15,
      "UsePersonAddress": true,
      "ContactFax": "autem",
      "Kanafname": "molestiae",
      "Kanalname": "error",
      "Post1": "dolorem",
      "Post2": "ipsa",
      "Post3": "et",
      "EmailName": "cassidy_ohara@hanerutherford.com",
      "ContactFullName": "Hollie Toy",
      "ActiveErpLinks": 791,
      "TicketPriorityId": 332,
      "SupportLanguageId": 939,
      "SupportAssociateId": 854,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 46
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "vel",
  "Xstop": false,
  "ActiveInterests": 3,
  "GroupId": 26,
  "ActiveStatusMonitorId": 600,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 144,
  "DbiAgentId": 641,
  "DbiLastSyncronized": "2014-01-04T11:06:41.7228464+01:00",
  "DbiKey": "ipsa",
  "DbiLastModified": "2004-10-04T11:06:41.7228464+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 176,
  "ActiveErpLinks": 22,
  "BounceEmails": [
    "alverta@hagenes.info",
    "isobel_gerhold@whiteblanda.com"
  ],
  "Domains": [
    "voluptatem",
    "enim"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Eliezer Bruen"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "eum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 708
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```