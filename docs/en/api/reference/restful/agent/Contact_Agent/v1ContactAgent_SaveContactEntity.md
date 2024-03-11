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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 391,
  "Name": "Strosin LLC",
  "Department": "",
  "OrgNr": "579753",
  "Number1": "1433506",
  "Number2": "1249194",
  "UpdatedDate": "2001-11-11T14:23:46.0793329+01:00",
  "CreatedDate": "2014-10-25T14:23:46.0793329+02:00",
  "Emails": [
    {
      "Value": "aliquam",
      "StrippedValue": "quo",
      "Description": "Horizontal contextually-based secured line"
    },
    {
      "Value": "aliquam",
      "StrippedValue": "quo",
      "Description": "Horizontal contextually-based secured line"
    }
  ],
  "Interests": [
    {
      "Id": 33,
      "Name": "Welch-Wintheiser",
      "ToolTip": "Dignissimos aut.",
      "Deleted": true,
      "Rank": 525,
      "Type": "porro",
      "ColorBlock": 799,
      "IconHint": "expedita",
      "Selected": false,
      "LastChanged": "2001-11-17T14:23:46.0793329+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "iusto",
      "StyleHint": "consequuntur",
      "Hidden": false,
      "FullName": "Gerry Ritchie"
    }
  ],
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "molestias",
      "Description": "Implemented full-range secured line"
    },
    {
      "Value": "aut",
      "StrippedValue": "molestias",
      "Description": "Implemented full-range secured line"
    }
  ],
  "Phones": [
    {
      "Value": "tempora",
      "StrippedValue": "et",
      "Description": "Extended cohesive collaboration"
    },
    {
      "Value": "tempora",
      "StrippedValue": "et",
      "Description": "Extended cohesive collaboration"
    }
  ],
  "Faxes": [
    {
      "Value": "perferendis",
      "StrippedValue": "aut",
      "Description": "Upgradable asynchronous secured line"
    },
    {
      "Value": "perferendis",
      "StrippedValue": "aut",
      "Description": "Upgradable asynchronous secured line"
    }
  ],
  "Description": "Networked actuating project",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quidem",
      "PersonId": 721,
      "Mrmrs": "officia",
      "Firstname": "Baby",
      "Lastname": "Dietrich",
      "MiddleName": "Dickens Group",
      "Title": "et",
      "Description": "Enterprise-wide transitional definition",
      "Email": "angelica_jewess@runte.uk",
      "FullName": "Domenica Shanny Larkin III",
      "DirectPhone": "(369)024-7100 x97663",
      "FormalName": "Langworth, Funk and Bradtke",
      "CountryId": 845,
      "ContactId": 310,
      "ContactName": "Powlowski LLC",
      "Retired": 452,
      "Rank": 638,
      "ActiveInterests": 168,
      "ContactDepartment": "",
      "ContactCountryId": 224,
      "ContactOrgNr": "334278",
      "FaxPhone": "680.383.8540 x6880",
      "MobilePhone": "(997)918-8101",
      "ContactPhone": "454-022-1425",
      "AssociateName": "Haag, Kuhic and Roob",
      "AssociateId": 550,
      "UsePersonAddress": true,
      "ContactFax": "ut",
      "Kanafname": "dolor",
      "Kanalname": "ducimus",
      "Post1": "culpa",
      "Post2": "ea",
      "Post3": "sunt",
      "EmailName": "marley@nolan.us",
      "ContactFullName": "Dr. Adelia Johnston",
      "ActiveErpLinks": 107,
      "TicketPriorityId": 129,
      "SupportLanguageId": 127,
      "SupportAssociateId": 266,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "repudiandae",
  "Xstop": true,
  "ActiveInterests": 934,
  "GroupId": 719,
  "ActiveStatusMonitorId": 403,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 91,
  "DbiAgentId": 748,
  "DbiLastSyncronized": "2011-07-29T14:23:46.0949571+02:00",
  "DbiKey": "magnam",
  "DbiLastModified": "2022-09-07T14:23:46.0949571+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 661,
  "ActiveErpLinks": 696,
  "BounceEmails": [
    "brock@morar.biz",
    "jerad_klein@parisian.biz"
  ],
  "Domains": [
    "dolore",
    "eos"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "131080123"
  },
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "reprehenderit"
  },
  "CustomFields": {
    "CustomFields1": "illo",
    "CustomFields2": "magni"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 136,
  "Name": "Funk, Zboncak and Hackett",
  "Department": "benchmark wireless deliverables",
  "OrgNr": "1570860",
  "Number1": "1113986",
  "Number2": "1778037",
  "UpdatedDate": "2000-12-08T14:23:46.0949571+01:00",
  "CreatedDate": "2006-11-02T14:23:46.0949571+01:00",
  "Emails": [
    {
      "Value": "tempore",
      "StrippedValue": "autem",
      "Description": "Virtual neutral portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 952
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "autem",
      "Description": "Virtual neutral portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 952
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 288,
      "Name": "Pacocha-Grant",
      "ToolTip": "Maiores quo ut ab.",
      "Deleted": false,
      "Rank": 798,
      "Type": "repellendus",
      "ColorBlock": 639,
      "IconHint": "commodi",
      "Selected": false,
      "LastChanged": "2004-10-30T14:23:46.0949571+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repudiandae",
      "StyleHint": "similique",
      "Hidden": false,
      "FullName": "Mr. Ryan Walsh DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 141
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "earum",
      "StrippedValue": "alias",
      "Description": "Realigned responsive paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 535
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "alias",
      "Description": "Realigned responsive paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 535
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "voluptas",
      "Description": "Polarised dedicated monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 879
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "voluptas",
      "Description": "Polarised dedicated monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 879
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "similique",
      "StrippedValue": "nobis",
      "Description": "Secured hybrid structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 8
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "nobis",
      "Description": "Secured hybrid structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 8
        }
      }
    }
  ],
  "Description": "Advanced modular access",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ipsa",
      "PersonId": 771,
      "Mrmrs": "autem",
      "Firstname": "Vivianne",
      "Lastname": "Quigley",
      "MiddleName": "Konopelski, Stehr and Hoppe",
      "Title": "voluptates",
      "Description": "Multi-tiered actuating conglomeration",
      "Email": "pierce@witting.com",
      "FullName": "Axel Josephine Gerlach DVM",
      "DirectPhone": "(168)657-3167 x186",
      "FormalName": "Greenfelder LLC",
      "CountryId": 892,
      "ContactId": 380,
      "ContactName": "Klein LLC",
      "Retired": 243,
      "Rank": 281,
      "ActiveInterests": 618,
      "ContactDepartment": "",
      "ContactCountryId": 96,
      "ContactOrgNr": "799393",
      "FaxPhone": "469-910-5289 x74897",
      "MobilePhone": "646.128.0875 x980",
      "ContactPhone": "805-107-7504 x92573",
      "AssociateName": "Jerde-Boyer",
      "AssociateId": 406,
      "UsePersonAddress": false,
      "ContactFax": "aliquam",
      "Kanafname": "blanditiis",
      "Kanalname": "quaerat",
      "Post1": "tempora",
      "Post2": "sequi",
      "Post3": "necessitatibus",
      "EmailName": "tracy@feestgleason.name",
      "ContactFullName": "Prof. Anna Liliana Hilll",
      "ActiveErpLinks": 687,
      "TicketPriorityId": 389,
      "SupportLanguageId": 712,
      "SupportAssociateId": 503,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 189
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "unde",
  "Xstop": true,
  "ActiveInterests": 692,
  "GroupId": 480,
  "ActiveStatusMonitorId": 402,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 201,
  "DbiAgentId": 949,
  "DbiLastSyncronized": "2021-03-24T14:23:46.0949571+01:00",
  "DbiKey": "ducimus",
  "DbiLastModified": "2001-12-07T14:23:46.0949571+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 889,
  "ActiveErpLinks": 453,
  "BounceEmails": [
    "rodger_buckridge@hartmann.biz",
    "pauline@ullrich.ca"
  ],
  "Domains": [
    "quas",
    "quia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "132777503",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "quo"
  },
  "CustomFields": {
    "CustomFields1": "reiciendis",
    "CustomFields2": "omnis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 35
    }
  }
}
```