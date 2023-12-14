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
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
  "PersonId": 822,
  "Firstname": "Kailee",
  "MiddleName": "Kertzmann, Gulgowski and Gislason",
  "Lastname": "Nolan",
  "Mrmrs": "est",
  "Title": "quis",
  "UpdatedDate": "2017-09-02T13:57:12.6380798+02:00",
  "CreatedDate": "2005-04-22T13:57:12.6380798+02:00",
  "BirthDate": "2002-07-22T13:57:12.6380798+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "rem",
      "StrippedValue": "hic",
      "Description": "Universal tertiary adapter"
    },
    {
      "Value": "rem",
      "StrippedValue": "hic",
      "Description": "Universal tertiary adapter"
    }
  ],
  "Description": "Cross-platform client-driven matrix",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "ad",
      "StrippedValue": "deserunt",
      "Description": "Front-line modular emulation"
    },
    {
      "Value": "ad",
      "StrippedValue": "deserunt",
      "Description": "Front-line modular emulation"
    }
  ],
  "Faxes": [
    {
      "Value": "molestias",
      "StrippedValue": "doloribus",
      "Description": "User-centric multimedia benchmark"
    },
    {
      "Value": "molestias",
      "StrippedValue": "doloribus",
      "Description": "User-centric multimedia benchmark"
    }
  ],
  "MobilePhones": [
    {
      "Value": "quidem",
      "StrippedValue": "eos",
      "Description": "Profit-focused assymetric alliance"
    },
    {
      "Value": "quidem",
      "StrippedValue": "eos",
      "Description": "Profit-focused assymetric alliance"
    }
  ],
  "OfficePhones": [
    {
      "Value": "similique",
      "StrippedValue": "quo",
      "Description": "Innovative static paradigm"
    },
    {
      "Value": "similique",
      "StrippedValue": "quo",
      "Description": "Innovative static paradigm"
    }
  ],
  "OtherPhones": [
    {
      "Value": "ab",
      "StrippedValue": "sit",
      "Description": "Cloned grid-enabled solution"
    },
    {
      "Value": "ab",
      "StrippedValue": "sit",
      "Description": "Cloned grid-enabled solution"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 369,
      "Name": "Roberts LLC",
      "ToolTip": "Autem dolorem eius culpa.",
      "Deleted": false,
      "Rank": 665,
      "Type": "corrupti",
      "ColorBlock": 20,
      "IconHint": "ab",
      "Selected": false,
      "LastChanged": "2010-07-26T13:57:12.6380798+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestias",
      "StyleHint": "esse",
      "Hidden": false,
      "FullName": "Joey Anderson"
    }
  ],
  "PersonNumber": "1133547",
  "FullName": "Nichole Parisian",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "sapiente",
      "StrippedValue": "atque",
      "Description": "Customizable multi-state contingency"
    },
    {
      "Value": "sapiente",
      "StrippedValue": "atque",
      "Description": "Customizable multi-state contingency"
    }
  ],
  "FormalName": "Kuhn-Ward",
  "Address": null,
  "Post3": "iste",
  "Post2": "maxime",
  "Post1": "aliquid",
  "Kanalname": "soluta",
  "Kanafname": "ad",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "doloremque",
  "ActiveInterests": 943,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 540,
  "DbiKey": "vero",
  "DbiLastModified": "2013-04-18T13:57:12.6380798+02:00",
  "DbiLastSyncronized": "1997-01-13T13:57:12.6380798+01:00",
  "SentInfo": 566,
  "ShowContactTickets": 8,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sunt",
      "StrippedValue": "sit",
      "Description": "Reactive motivating circuit"
    },
    {
      "Value": "sunt",
      "StrippedValue": "sit",
      "Description": "Reactive motivating circuit"
    }
  ],
  "InternetPhones": [
    {
      "Value": "veniam",
      "StrippedValue": "occaecati",
      "Description": "Ameliorated systemic help-desk"
    },
    {
      "Value": "veniam",
      "StrippedValue": "occaecati",
      "Description": "Ameliorated systemic help-desk"
    }
  ],
  "Source": 501,
  "ActiveErpLinks": 751,
  "ShipmentTypes": [
    {
      "Id": 337,
      "Name": "Anderson, Mraz and Schiller",
      "ToolTip": "Qui eius expedita ipsam fugit.",
      "Deleted": false,
      "Rank": 778,
      "Type": "debitis",
      "ColorBlock": 229,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2023-05-18T13:57:12.6380798+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "earum",
      "Hidden": false,
      "FullName": "Mrs. Vivien Hintz Sr."
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 256,
      "Comment": "sapiente",
      "Registered": "2001-03-03T13:57:12.6380798+01:00",
      "RegisteredAssociateId": 398,
      "Updated": "1999-08-24T13:57:12.6380798+02:00",
      "UpdatedAssociateId": 442,
      "LegalBaseId": 753,
      "LegalBaseKey": "nisi",
      "LegalBaseName": "Lind Inc and Sons",
      "ConsentPurposeId": 650,
      "ConsentPurposeKey": "voluptatem",
      "ConsentPurposeName": "Wisoky-Herzog",
      "ConsentSourceId": 582,
      "ConsentSourceKey": "qui",
      "ConsentSourceName": "Rippin Group"
    }
  ],
  "BounceEmails": [
    "candelario@mraz.biz",
    "shane_hudson@weimann.biz"
  ],
  "ActiveStatusMonitorId": 899,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Ceasar Alexanne Stehr",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "placeat"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "recusandae"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 563,
  "Firstname": "Hal",
  "MiddleName": "Hamill Inc and Sons",
  "Lastname": "Stark",
  "Mrmrs": "suscipit",
  "Title": "est",
  "UpdatedDate": "2004-04-17T13:57:12.6537025+02:00",
  "CreatedDate": "1999-06-19T13:57:12.6537025+02:00",
  "BirthDate": "2007-06-08T13:57:12.6537025+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "odio",
      "StrippedValue": "qui",
      "Description": "Mandatory optimal intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 915
        }
      }
    },
    {
      "Value": "odio",
      "StrippedValue": "qui",
      "Description": "Mandatory optimal intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 915
        }
      }
    }
  ],
  "Description": "User-centric client-driven forecast",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "sint",
      "StrippedValue": "cupiditate",
      "Description": "Object-based 24 hour utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 990
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "cupiditate",
      "Description": "Object-based 24 hour utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 990
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "corporis",
      "StrippedValue": "cupiditate",
      "Description": "Realigned zero administration superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 63
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "cupiditate",
      "Description": "Realigned zero administration superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 63
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "ut",
      "StrippedValue": "non",
      "Description": "Expanded web-enabled pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 202
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "non",
      "Description": "Expanded web-enabled pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 202
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "aut",
      "StrippedValue": "sunt",
      "Description": "Total user-facing moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 263
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "sunt",
      "Description": "Total user-facing moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 263
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "nobis",
      "StrippedValue": "a",
      "Description": "Triple-buffered next generation analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 296
        }
      }
    },
    {
      "Value": "nobis",
      "StrippedValue": "a",
      "Description": "Triple-buffered next generation analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 296
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
      "Id": 902,
      "Name": "Lynch, Glover and Pacocha",
      "ToolTip": "Et enim sit consectetur temporibus et.",
      "Deleted": true,
      "Rank": 788,
      "Type": "quas",
      "ColorBlock": 179,
      "IconHint": "amet",
      "Selected": false,
      "LastChanged": "2000-08-10T13:57:12.6537025+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "impedit",
      "Hidden": false,
      "FullName": "Ms. Stanton Blanda",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 995
        }
      }
    }
  ],
  "PersonNumber": "392879",
  "FullName": "Ms. Tom Alisa Boyer I",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "illo",
      "StrippedValue": "voluptas",
      "Description": "Up-sized leading edge definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "voluptas",
      "Description": "Up-sized leading edge definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    }
  ],
  "FormalName": "Jones LLC",
  "Address": null,
  "Post3": "commodi",
  "Post2": "quos",
  "Post1": "quia",
  "Kanalname": "explicabo",
  "Kanafname": "a",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptatum",
  "ActiveInterests": 496,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 963,
  "DbiKey": "qui",
  "DbiLastModified": "2008-06-18T13:57:12.6537025+02:00",
  "DbiLastSyncronized": "2007-09-09T13:57:12.6537025+02:00",
  "SentInfo": 423,
  "ShowContactTickets": 508,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "aut",
      "StrippedValue": "beatae",
      "Description": "Secured even-keeled data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "beatae",
      "Description": "Secured even-keeled data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "itaque",
      "StrippedValue": "saepe",
      "Description": "Profound directional encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 259
        }
      }
    },
    {
      "Value": "itaque",
      "StrippedValue": "saepe",
      "Description": "Profound directional encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 259
        }
      }
    }
  ],
  "Source": 585,
  "ActiveErpLinks": 575,
  "ShipmentTypes": [
    {
      "Id": 604,
      "Name": "Welch Group",
      "ToolTip": "Non ullam ad facilis aut.",
      "Deleted": false,
      "Rank": 116,
      "Type": "veritatis",
      "ColorBlock": 58,
      "IconHint": "a",
      "Selected": true,
      "LastChanged": "2007-07-07T13:57:12.6537025+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "voluptas",
      "Hidden": false,
      "FullName": "Prof. Cleora Lorna McGlynn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 239
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 184,
      "Comment": "placeat",
      "Registered": "2011-04-25T13:57:12.6537025+02:00",
      "RegisteredAssociateId": 85,
      "Updated": "1997-02-26T13:57:12.6537025+01:00",
      "UpdatedAssociateId": 177,
      "LegalBaseId": 492,
      "LegalBaseKey": "amet",
      "LegalBaseName": "Kuvalis, Breitenberg and Yundt",
      "ConsentPurposeId": 720,
      "ConsentPurposeKey": "vel",
      "ConsentPurposeName": "Adams-White",
      "ConsentSourceId": 978,
      "ConsentSourceKey": "nulla",
      "ConsentSourceName": "Emard-Witting",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 665
        }
      }
    }
  ],
  "BounceEmails": [
    "kiley.oberbrunner@haag.co.uk",
    "keegan_jast@schaefer.com"
  ],
  "ActiveStatusMonitorId": 726,
  "UserDefinedFields": {
    "SuperOffice:1": "Jasper Predovic",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quod",
    "ExtraFields2": "dolore"
  },
  "CustomFields": {
    "CustomFields1": "distinctio",
    "CustomFields2": "minima"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 137
    }
  }
}
```