---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
generated: true
---

# POST Agents/Contact/SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is empty








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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

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

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 634,
  "Name": "Stehr-McClure",
  "Department": "",
  "OrgNr": "1511813",
  "Number1": "1684942",
  "Number2": "1196928",
  "UpdatedDate": "2014-04-06T12:01:27.4627597+02:00",
  "CreatedDate": "2013-11-21T12:01:27.4627597+01:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "dolorem",
      "Description": "Synchronised upward-trending budgetary management"
    },
    {
      "Value": "quia",
      "StrippedValue": "dolorem",
      "Description": "Synchronised upward-trending budgetary management"
    }
  ],
  "Interests": [
    {
      "Id": 292,
      "Name": "Klein, Kuhn and Fisher",
      "ToolTip": "Qui sed.",
      "Deleted": false,
      "Rank": 538,
      "Type": "sed",
      "ColorBlock": 626,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2024-01-10T12:01:27.4627597+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "consequatur",
      "Hidden": true,
      "FullName": "Peyton Pfeffer"
    }
  ],
  "Urls": [
    {
      "Value": "ratione",
      "StrippedValue": "mollitia",
      "Description": "Down-sized composite groupware"
    },
    {
      "Value": "ratione",
      "StrippedValue": "mollitia",
      "Description": "Down-sized composite groupware"
    }
  ],
  "Phones": [
    {
      "Value": "nulla",
      "StrippedValue": "magnam",
      "Description": "Organized directional throughput"
    },
    {
      "Value": "nulla",
      "StrippedValue": "magnam",
      "Description": "Organized directional throughput"
    }
  ],
  "Faxes": [
    {
      "Value": "ipsa",
      "StrippedValue": "deserunt",
      "Description": "Networked static task-force"
    },
    {
      "Value": "ipsa",
      "StrippedValue": "deserunt",
      "Description": "Networked static task-force"
    }
  ],
  "Description": "Future-proofed heuristic flexibility",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 613,
      "Mrmrs": "eligendi",
      "Firstname": "Ona",
      "Lastname": "Brekke",
      "MiddleName": "Wolff-Koepp",
      "Title": "fugit",
      "Description": "Reactive next generation core",
      "Email": "lorenzo_muller@ziemann.info",
      "FullName": "Prof. Hubert Zane Kunde",
      "DirectPhone": "192-966-3234",
      "FormalName": "Veum Inc and Sons",
      "CountryId": 421,
      "ContactId": 841,
      "ContactName": "Keebler, Mertz and Greenholt",
      "Retired": 249,
      "Rank": 212,
      "ActiveInterests": 150,
      "ContactDepartment": "",
      "ContactCountryId": 709,
      "ContactOrgNr": "1024289",
      "FaxPhone": "273-624-4376 x07606",
      "MobilePhone": "(363)175-6293",
      "ContactPhone": "(377)184-1621",
      "AssociateName": "Okuneva Inc and Sons",
      "AssociateId": 952,
      "UsePersonAddress": false,
      "ContactFax": "sapiente",
      "Kanafname": "illum",
      "Kanalname": "sed",
      "Post1": "provident",
      "Post2": "harum",
      "Post3": "quo",
      "EmailName": "clair@graham.uk",
      "ContactFullName": "Grady Von",
      "ActiveErpLinks": 733,
      "TicketPriorityId": 725,
      "SupportLanguageId": 547,
      "SupportAssociateId": 672,
      "CategoryName": "VIP Customer",
      "PersonNumber": "861849"
    }
  ],
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": false,
  "ActiveInterests": 409,
  "GroupId": 289,
  "ActiveStatusMonitorId": 752,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 588,
  "DbiAgentId": 448,
  "DbiLastSyncronized": "1999-12-23T12:01:27.4627597+01:00",
  "DbiKey": "reprehenderit",
  "DbiLastModified": "2022-08-27T12:01:27.4627597+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 426,
  "ActiveErpLinks": 476,
  "BounceEmails": [
    "mason.parisian@loweschultz.ca",
    "jarrett@feestschuster.co.uk"
  ],
  "Domains": [
    "et",
    "tempore"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "833122064",
    "SuperOffice:2": "1212575254"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "molestias"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "minus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 299,
  "Name": "Pfannerstill, Huel and Mosciski",
  "Department": "",
  "OrgNr": "1526507",
  "Number1": "921183",
  "Number2": "755106",
  "UpdatedDate": "2021-03-10T12:01:27.4627597+01:00",
  "CreatedDate": "2006-03-16T12:01:27.4627597+01:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "laudantium",
      "Description": "Total well-modulated instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 426
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "laudantium",
      "Description": "Total well-modulated instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 426
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 566,
      "Name": "McLaughlin-Hermiston",
      "ToolTip": "Amet tempore impedit qui magnam culpa sunt.",
      "Deleted": false,
      "Rank": 640,
      "Type": "et",
      "ColorBlock": 892,
      "IconHint": "ab",
      "Selected": false,
      "LastChanged": "2016-12-23T12:01:27.4627597+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quae",
      "StyleHint": "commodi",
      "Hidden": true,
      "FullName": "Ms. Eloisa Rosemary Gutmann III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 509
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "pariatur",
      "StrippedValue": "quo",
      "Description": "Horizontal exuding approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 380
        }
      }
    },
    {
      "Value": "pariatur",
      "StrippedValue": "quo",
      "Description": "Horizontal exuding approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 380
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "rerum",
      "StrippedValue": "recusandae",
      "Description": "Reduced 6th generation paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "recusandae",
      "Description": "Reduced 6th generation paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolor",
      "StrippedValue": "libero",
      "Description": "Profit-focused interactive functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 933
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "libero",
      "Description": "Profit-focused interactive functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 933
        }
      }
    }
  ],
  "Description": "Versatile interactive hub",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quia",
      "PersonId": 579,
      "Mrmrs": "quam",
      "Firstname": "Alexandria",
      "Lastname": "Miller",
      "MiddleName": "Torphy-Harvey",
      "Title": "repudiandae",
      "Description": "Stand-alone high-level monitoring",
      "Email": "elvis@lynchgusikowski.info",
      "FullName": "Mrs. Travis Weissnat",
      "DirectPhone": "1-584-272-0146 x5345",
      "FormalName": "Sauer, Littel and Greenfelder",
      "CountryId": 987,
      "ContactId": 383,
      "ContactName": "Lesch, Heidenreich and Kassulke",
      "Retired": 56,
      "Rank": 905,
      "ActiveInterests": 842,
      "ContactDepartment": "",
      "ContactCountryId": 382,
      "ContactOrgNr": "925984",
      "FaxPhone": "(599)963-3171",
      "MobilePhone": "925-768-4113 x1460",
      "ContactPhone": "1-618-525-4152",
      "AssociateName": "Herman, Goodwin and Gorczany",
      "AssociateId": 863,
      "UsePersonAddress": false,
      "ContactFax": "quis",
      "Kanafname": "minima",
      "Kanalname": "perferendis",
      "Post1": "eaque",
      "Post2": "quae",
      "Post3": "facere",
      "EmailName": "kali.stoltenberg@kuphal.info",
      "ContactFullName": "Jaiden Olson",
      "ActiveErpLinks": 256,
      "TicketPriorityId": 383,
      "SupportLanguageId": 496,
      "SupportAssociateId": 218,
      "CategoryName": "VIP Customer",
      "PersonNumber": "596466",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 858
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "sapiente",
  "Xstop": false,
  "ActiveInterests": 173,
  "GroupId": 29,
  "ActiveStatusMonitorId": 987,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 858,
  "DbiAgentId": 760,
  "DbiLastSyncronized": "2021-07-26T12:01:27.4783858+02:00",
  "DbiKey": "totam",
  "DbiLastModified": "2024-10-27T12:01:27.4783858+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 599,
  "ActiveErpLinks": 120,
  "BounceEmails": [
    "kareem@bogisichswaniawski.biz",
    "moses@pouros.us"
  ],
  "Domains": [
    "sint",
    "consectetur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Genesis Kuhn"
  },
  "ExtraFields": {
    "ExtraFields1": "iure",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "vitae",
    "CustomFields2": "consequatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 281
    }
  }
}
```