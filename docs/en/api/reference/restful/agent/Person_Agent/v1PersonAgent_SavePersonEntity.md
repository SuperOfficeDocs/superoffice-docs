---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
generated: true
---

# POST Agents/Person/SavePersonEntity

```http
POST /api/v1/Agents/Person/SavePersonEntity
```

Updates the existing PersonEntity or creates a new PersonEntity if the id parameter is empty








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

The PersonEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer | Primary key |
| Firstname | String | First name |
| MiddleName | String | Middle name or 'van' etc. |
| Lastname | String | Last name |
| Mrmrs | String | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | String | Title |
| UpdatedDate | String | Last updated date  in UTC. |
| CreatedDate | String | Registered date  in UTC. |
| BirthDate | String | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | Array | A collection of the person's emails |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | Boolean | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | Array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | Array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | Array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | Array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | Array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | Array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | String | Alphanumeric user field |
| FullName | String | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | Boolean | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | Boolean | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | Boolean | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | Array | The urls related to this person. |
| FormalName | String | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | String | Postal address, used in Japanese versions only |
| Post2 | String | Postal address, used in Japanese versions only |
| Post1 | String | Postal address, used in Japanese versions only |
| Kanalname | String | Kana last name, used in Japanese versions only |
| Kanafname | String | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | String | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | Integer | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| DbiLastSyncronized | String | Last external syncronization. |
| SentInfo | Integer | Has information on username/password been sent (ejournal) |
| ShowContactTickets | Integer | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | Array |  |
| InternetPhones | Array |  |
| Source | Integer | How did we get this person? For future integration needs |
| ActiveErpLinks | Integer | How many active ERP links are there for this person? |
| ShipmentTypes | Array | The person's available and selected shipment types. |
| Consents | Array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for person |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 110,
  "Firstname": "Madge",
  "MiddleName": "Altenwerth, Kessler and Hills",
  "Lastname": "Hilll",
  "Mrmrs": "excepturi",
  "Title": "et",
  "UpdatedDate": "2007-05-11T12:57:34.4147625+02:00",
  "CreatedDate": "2011-03-03T12:57:34.4147625+01:00",
  "BirthDate": "2008-11-20T12:57:34.4147625+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "magnam",
      "Description": "Face to face modular forecast"
    },
    {
      "Value": "et",
      "StrippedValue": "magnam",
      "Description": "Face to face modular forecast"
    }
  ],
  "Description": "Switchable real-time architecture",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "laborum",
      "Description": "Multi-tiered dynamic local area network"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "laborum",
      "Description": "Multi-tiered dynamic local area network"
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "provident",
      "Description": "Multi-channelled fresh-thinking product"
    },
    {
      "Value": "non",
      "StrippedValue": "provident",
      "Description": "Multi-channelled fresh-thinking product"
    }
  ],
  "MobilePhones": [
    {
      "Value": "nostrum",
      "StrippedValue": "unde",
      "Description": "Total analyzing database"
    },
    {
      "Value": "nostrum",
      "StrippedValue": "unde",
      "Description": "Total analyzing database"
    }
  ],
  "OfficePhones": [
    {
      "Value": "in",
      "StrippedValue": "consectetur",
      "Description": "Multi-lateral scalable infrastructure"
    },
    {
      "Value": "in",
      "StrippedValue": "consectetur",
      "Description": "Multi-lateral scalable infrastructure"
    }
  ],
  "OtherPhones": [
    {
      "Value": "non",
      "StrippedValue": "ut",
      "Description": "Upgradable non-volatile data-warehouse"
    },
    {
      "Value": "non",
      "StrippedValue": "ut",
      "Description": "Upgradable non-volatile data-warehouse"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 44,
      "Name": "Nader-Trantow",
      "ToolTip": "Accusantium voluptatem vero atque vel.",
      "Deleted": false,
      "Rank": 919,
      "Type": "culpa",
      "ColorBlock": 375,
      "IconHint": "hic",
      "Selected": false,
      "LastChanged": "2023-02-13T12:57:34.4147625+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "perspiciatis",
      "Hidden": false,
      "FullName": "Brady Lebsack"
    }
  ],
  "PersonNumber": "1345251",
  "FullName": "Prof. Alberta Albertha Stamm",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "quasi",
      "StrippedValue": "voluptas",
      "Description": "Vision-oriented content-based adapter"
    },
    {
      "Value": "quasi",
      "StrippedValue": "voluptas",
      "Description": "Vision-oriented content-based adapter"
    }
  ],
  "FormalName": "Hessel, Stoltenberg and Miller",
  "Address": null,
  "Post3": "facilis",
  "Post2": "debitis",
  "Post1": "vitae",
  "Kanalname": "veniam",
  "Kanafname": "similique",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptatem",
  "ActiveInterests": 909,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 506,
  "DbiKey": "exercitationem",
  "DbiLastModified": "2020-03-28T12:57:34.4147625+01:00",
  "DbiLastSyncronized": "2008-02-10T12:57:34.4147625+01:00",
  "SentInfo": 424,
  "ShowContactTickets": 183,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nemo",
      "StrippedValue": "atque",
      "Description": "Organized web-enabled capability"
    },
    {
      "Value": "nemo",
      "StrippedValue": "atque",
      "Description": "Organized web-enabled capability"
    }
  ],
  "InternetPhones": [
    {
      "Value": "odio",
      "StrippedValue": "sed",
      "Description": "Compatible 4th generation time-frame"
    },
    {
      "Value": "odio",
      "StrippedValue": "sed",
      "Description": "Compatible 4th generation time-frame"
    }
  ],
  "Source": 149,
  "ActiveErpLinks": 188,
  "ShipmentTypes": [
    {
      "Id": 372,
      "Name": "Dickens Inc and Sons",
      "ToolTip": "Assumenda perspiciatis sed animi.",
      "Deleted": false,
      "Rank": 479,
      "Type": "sed",
      "ColorBlock": 83,
      "IconHint": "culpa",
      "Selected": false,
      "LastChanged": "2015-07-12T12:57:34.4147625+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "cum",
      "Hidden": false,
      "FullName": "Kirsten Boyer"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 123,
      "Comment": "et",
      "Registered": "2007-01-23T12:57:34.4147625+01:00",
      "RegisteredAssociateId": 734,
      "Updated": "2004-11-11T12:57:34.4147625+01:00",
      "UpdatedAssociateId": 44,
      "LegalBaseId": 115,
      "LegalBaseKey": "ut",
      "LegalBaseName": "Reichert-Dickinson",
      "ConsentPurposeId": 450,
      "ConsentPurposeKey": "dolor",
      "ConsentPurposeName": "Gislason, Ruecker and Cummerata",
      "ConsentSourceId": 832,
      "ConsentSourceKey": "corrupti",
      "ConsentSourceName": "Howell Inc and Sons"
    }
  ],
  "BounceEmails": [
    "bria_dubuque@kuphal.ca",
    "maxwell@abernathythiel.com"
  ],
  "ActiveStatusMonitorId": 803,
  "UserDefinedFields": {
    "SuperOffice:1": "273995859",
    "SuperOffice:2": "1470258472"
  },
  "ExtraFields": {
    "ExtraFields1": "impedit",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "ea"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 270,
  "Firstname": "Jeff",
  "MiddleName": "O'Keefe Inc and Sons",
  "Lastname": "Boyle",
  "Mrmrs": "magni",
  "Title": "ut",
  "UpdatedDate": "2017-11-01T12:57:34.4303839+01:00",
  "CreatedDate": "2014-01-29T12:57:34.4303839+01:00",
  "BirthDate": "1998-05-03T12:57:34.4303839+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "aspernatur",
      "StrippedValue": "dolores",
      "Description": "Programmable local knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 99
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "dolores",
      "Description": "Programmable local knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 99
        }
      }
    }
  ],
  "Description": "Phased value-added hub",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "odit",
      "Description": "Reverse-engineered intermediate conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 48
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "odit",
      "Description": "Reverse-engineered intermediate conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 48
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quo",
      "StrippedValue": "odio",
      "Description": "Public-key exuding moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 466
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "odio",
      "Description": "Public-key exuding moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 466
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "soluta",
      "StrippedValue": "aut",
      "Description": "Multi-layered hybrid database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 854
        }
      }
    },
    {
      "Value": "soluta",
      "StrippedValue": "aut",
      "Description": "Multi-layered hybrid database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 854
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "maxime",
      "StrippedValue": "dignissimos",
      "Description": "Profit-focused system-worthy success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 637
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "dignissimos",
      "Description": "Profit-focused system-worthy success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 637
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "sed",
      "Description": "Organized impactful algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 332
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "sed",
      "Description": "Organized impactful algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 332
        }
      }
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 284,
      "Name": "Dibbert, Anderson and Altenwerth",
      "ToolTip": "Laboriosam nihil qui enim sit illo non explicabo.",
      "Deleted": false,
      "Rank": 594,
      "Type": "ut",
      "ColorBlock": 710,
      "IconHint": "nihil",
      "Selected": false,
      "LastChanged": "2007-01-31T12:57:34.4303839+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eligendi",
      "StyleHint": "temporibus",
      "Hidden": false,
      "FullName": "Noah Tillman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 867
        }
      }
    }
  ],
  "PersonNumber": "1224075",
  "FullName": "Cale Aliyah Konopelski Sr.",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "voluptatibus",
      "Description": "Total zero tolerance hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "voluptatibus",
      "Description": "Total zero tolerance hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    }
  ],
  "FormalName": "Mante LLC",
  "Address": null,
  "Post3": "nobis",
  "Post2": "possimus",
  "Post1": "nisi",
  "Kanalname": "ea",
  "Kanafname": "quam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "corporis",
  "ActiveInterests": 994,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 888,
  "DbiKey": "reprehenderit",
  "DbiLastModified": "2011-07-31T12:57:34.4303839+02:00",
  "DbiLastSyncronized": "2007-09-13T12:57:34.4303839+02:00",
  "SentInfo": 643,
  "ShowContactTickets": 4,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "molestiae",
      "StrippedValue": "enim",
      "Description": "Ergonomic upward-trending leverage",
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
      "Value": "molestiae",
      "StrippedValue": "enim",
      "Description": "Ergonomic upward-trending leverage",
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
  "InternetPhones": [
    {
      "Value": "sed",
      "StrippedValue": "harum",
      "Description": "Profit-focused dedicated archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 586
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "harum",
      "Description": "Profit-focused dedicated archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 586
        }
      }
    }
  ],
  "Source": 269,
  "ActiveErpLinks": 184,
  "ShipmentTypes": [
    {
      "Id": 824,
      "Name": "Jacobs-Schamberger",
      "ToolTip": "Aliquid aperiam aliquam quas et iure.",
      "Deleted": false,
      "Rank": 500,
      "Type": "cum",
      "ColorBlock": 554,
      "IconHint": "non",
      "Selected": false,
      "LastChanged": "2017-08-25T12:57:34.4303839+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rerum",
      "StyleHint": "explicabo",
      "Hidden": true,
      "FullName": "Shanon Powlowski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 803
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 497,
      "Comment": "consequuntur",
      "Registered": "2022-05-05T12:57:34.4303839+02:00",
      "RegisteredAssociateId": 425,
      "Updated": "2019-09-19T12:57:34.4303839+02:00",
      "UpdatedAssociateId": 272,
      "LegalBaseId": 728,
      "LegalBaseKey": "sit",
      "LegalBaseName": "Schaefer, Boehm and Abernathy",
      "ConsentPurposeId": 730,
      "ConsentPurposeKey": "quia",
      "ConsentPurposeName": "Ratke Group",
      "ConsentSourceId": 337,
      "ConsentSourceKey": "amet",
      "ConsentSourceName": "Murazik Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 488
        }
      }
    }
  ],
  "BounceEmails": [
    "hoyt_willms@goodwin.com",
    "samir_bashirian@waters.com"
  ],
  "ActiveStatusMonitorId": 467,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Einar Jerde",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "quasi",
    "CustomFields2": "aliquam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 37
    }
  }
}
```