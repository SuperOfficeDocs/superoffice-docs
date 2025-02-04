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
  "ContactId": 137,
  "Name": "Cormier, Lubowitz and Mann",
  "Department": "",
  "OrgNr": "964915",
  "Number1": "1471923",
  "Number2": "1431689",
  "UpdatedDate": "2020-07-03T13:13:22.3676527+02:00",
  "CreatedDate": "2022-01-20T13:13:22.3676527+01:00",
  "Emails": [
    {
      "Value": "occaecati",
      "StrippedValue": "porro",
      "Description": "Seamless fault-tolerant hub"
    },
    {
      "Value": "occaecati",
      "StrippedValue": "porro",
      "Description": "Seamless fault-tolerant hub"
    }
  ],
  "Interests": [
    {
      "Id": 144,
      "Name": "Dickinson, Ankunding and O'Hara",
      "ToolTip": "Facilis excepturi consequuntur aliquid id atque cum.",
      "Deleted": false,
      "Rank": 390,
      "Type": "natus",
      "ColorBlock": 257,
      "IconHint": "dolorem",
      "Selected": true,
      "LastChanged": "2019-01-05T13:13:22.3676527+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "inventore",
      "Hidden": true,
      "FullName": "Will Adams"
    }
  ],
  "Urls": [
    {
      "Value": "provident",
      "StrippedValue": "exercitationem",
      "Description": "Extended asynchronous collaboration"
    },
    {
      "Value": "provident",
      "StrippedValue": "exercitationem",
      "Description": "Extended asynchronous collaboration"
    }
  ],
  "Phones": [
    {
      "Value": "quaerat",
      "StrippedValue": "animi",
      "Description": "Monitored dedicated solution"
    },
    {
      "Value": "quaerat",
      "StrippedValue": "animi",
      "Description": "Monitored dedicated solution"
    }
  ],
  "Faxes": [
    {
      "Value": "quae",
      "StrippedValue": "delectus",
      "Description": "Optimized object-oriented encryption"
    },
    {
      "Value": "quae",
      "StrippedValue": "delectus",
      "Description": "Optimized object-oriented encryption"
    }
  ],
  "Description": "Decentralized tangible approach",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "temporibus",
      "PersonId": 983,
      "Mrmrs": "consequatur",
      "Firstname": "Colleen",
      "Lastname": "Hermiston",
      "MiddleName": "Langworth LLC",
      "Title": "qui",
      "Description": "Enhanced fault-tolerant capability",
      "Email": "jace@keeblerspencer.ca",
      "FullName": "Dr. Zack Jordan Wilderman",
      "DirectPhone": "1-990-352-0208 x500",
      "FormalName": "Maggio-Marquardt",
      "CountryId": 510,
      "ContactId": 815,
      "ContactName": "Collier, Abbott and Crooks",
      "Retired": 873,
      "Rank": 10,
      "ActiveInterests": 684,
      "ContactDepartment": "",
      "ContactCountryId": 584,
      "ContactOrgNr": "1728981",
      "FaxPhone": "325-287-5517 x665",
      "MobilePhone": "(625)605-9966 x53817",
      "ContactPhone": "533-861-7476",
      "AssociateName": "Rodriguez-Rippin",
      "AssociateId": 554,
      "UsePersonAddress": false,
      "ContactFax": "debitis",
      "Kanafname": "quo",
      "Kanalname": "consequatur",
      "Post1": "sit",
      "Post2": "voluptas",
      "Post3": "voluptas",
      "EmailName": "gage@leuschkechamplin.uk",
      "ContactFullName": "Hollis Chandler Rath DVM",
      "ActiveErpLinks": 422,
      "TicketPriorityId": 566,
      "SupportLanguageId": 495,
      "SupportAssociateId": 948,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptatum",
  "Xstop": false,
  "ActiveInterests": 604,
  "GroupId": 707,
  "ActiveStatusMonitorId": 5,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 33,
  "DbiAgentId": 366,
  "DbiLastSyncronized": "1997-12-22T13:13:22.3676527+01:00",
  "DbiKey": "magnam",
  "DbiLastModified": "2021-01-01T13:13:22.3676527+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 946,
  "ActiveErpLinks": 788,
  "BounceEmails": [
    "samara_stroman@schustertillman.info",
    "valentine@conn.us"
  ],
  "Domains": [
    "porro",
    "cum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Brenna Arnaldo Predovic IV",
    "SuperOffice:2": "Dr. Walker Oral Howell"
  },
  "ExtraFields": {
    "ExtraFields1": "ducimus",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "amet",
    "CustomFields2": "non"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 477,
  "Name": "Russel-Gottlieb",
  "Department": "",
  "OrgNr": "1786590",
  "Number1": "1373019",
  "Number2": "1036165",
  "UpdatedDate": "2015-12-13T13:13:22.3832725+01:00",
  "CreatedDate": "2001-09-12T13:13:22.3832725+02:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "corrupti",
      "Description": "Realigned client-server infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 824
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "corrupti",
      "Description": "Realigned client-server infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 824
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 754,
      "Name": "Dickinson, Torp and Oberbrunner",
      "ToolTip": "Aliquam tempore.",
      "Deleted": false,
      "Rank": 858,
      "Type": "aut",
      "ColorBlock": 674,
      "IconHint": "expedita",
      "Selected": false,
      "LastChanged": "2007-08-17T13:13:22.3832725+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "corporis",
      "StyleHint": "modi",
      "Hidden": false,
      "FullName": "Miss Alba Lowell Hagenes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 793
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "provident",
      "Description": "Inverse client-server initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 448
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "provident",
      "Description": "Inverse client-server initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 448
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "possimus",
      "StrippedValue": "placeat",
      "Description": "Persevering global capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 304
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "placeat",
      "Description": "Persevering global capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 304
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ullam",
      "StrippedValue": "expedita",
      "Description": "Ergonomic client-driven definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 887
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "expedita",
      "Description": "Ergonomic client-driven definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 887
        }
      }
    }
  ],
  "Description": "Open-architected user-facing software",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "laudantium",
      "PersonId": 313,
      "Mrmrs": "totam",
      "Firstname": "Vicente",
      "Lastname": "Little",
      "MiddleName": "Heidenreich-Feeney",
      "Title": "hic",
      "Description": "Configurable assymetric challenge",
      "Email": "phoebe.greenholt@lang.co.uk",
      "FullName": "Marcelle Rowe",
      "DirectPhone": "504-690-0831 x2677",
      "FormalName": "Ebert, Dibbert and Dickinson",
      "CountryId": 300,
      "ContactId": 955,
      "ContactName": "Mayert Group",
      "Retired": 931,
      "Rank": 160,
      "ActiveInterests": 419,
      "ContactDepartment": "",
      "ContactCountryId": 710,
      "ContactOrgNr": "1288650",
      "FaxPhone": "1-988-547-1355",
      "MobilePhone": "(832)936-7777 x059",
      "ContactPhone": "532.621.5543 x89899",
      "AssociateName": "Luettgen, Turcotte and Witting",
      "AssociateId": 731,
      "UsePersonAddress": false,
      "ContactFax": "beatae",
      "Kanafname": "facilis",
      "Kanalname": "dolor",
      "Post1": "reprehenderit",
      "Post2": "possimus",
      "Post3": "recusandae",
      "EmailName": "dejon.crooks@crist.info",
      "ContactFullName": "Bertrand Goldner",
      "ActiveErpLinks": 94,
      "TicketPriorityId": 1001,
      "SupportLanguageId": 272,
      "SupportAssociateId": 226,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 416
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "ipsam",
  "Xstop": true,
  "ActiveInterests": 861,
  "GroupId": 432,
  "ActiveStatusMonitorId": 67,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 87,
  "DbiAgentId": 571,
  "DbiLastSyncronized": "2014-01-19T13:13:22.3832725+01:00",
  "DbiKey": "non",
  "DbiLastModified": "2018-12-18T13:13:22.3832725+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 655,
  "ActiveErpLinks": 129,
  "BounceEmails": [
    "cale_beahan@buckridgekuhlman.co.uk",
    "wyatt_bruen@kshlerincorwin.ca"
  ],
  "Domains": [
    "dicta",
    "veritatis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "2037407240"
  },
  "ExtraFields": {
    "ExtraFields1": "reiciendis",
    "ExtraFields2": "vitae"
  },
  "CustomFields": {
    "CustomFields1": "doloremque",
    "CustomFields2": "excepturi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 785
    }
  }
}
```