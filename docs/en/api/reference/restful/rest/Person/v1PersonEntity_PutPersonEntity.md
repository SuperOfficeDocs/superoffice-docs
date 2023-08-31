---
title: PUT Person/{id}
uid: v1PersonEntity_PutPersonEntity
generated: true
---

# PUT Person/{id}

```http
PUT /api/v1/Person/{id}
```

Updates the existing PersonEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PersonEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Person/{id}?$select=name,department,category/id
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

PersonEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity updated. |
| 412 | Update stopped because PersonEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: PersonEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 982,
  "Firstname": "Rita",
  "MiddleName": "Terry, Simonis and Macejkovic",
  "Lastname": "Ullrich",
  "Mrmrs": "accusantium",
  "Title": "voluptatum",
  "UpdatedDate": "2016-05-26T03:31:32.6757627+02:00",
  "CreatedDate": "2022-09-05T03:31:32.6757627+02:00",
  "BirthDate": "2018-03-01T03:31:32.6757627+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quas",
      "StrippedValue": "ducimus",
      "Description": "Enterprise-wide grid-enabled matrices"
    },
    {
      "Value": "quas",
      "StrippedValue": "ducimus",
      "Description": "Enterprise-wide grid-enabled matrices"
    }
  ],
  "Description": "Proactive interactive focus group",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "fuga",
      "Description": "Mandatory global interface"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "fuga",
      "Description": "Mandatory global interface"
    }
  ],
  "Faxes": [
    {
      "Value": "iusto",
      "StrippedValue": "ullam",
      "Description": "Centralized uniform approach"
    },
    {
      "Value": "iusto",
      "StrippedValue": "ullam",
      "Description": "Centralized uniform approach"
    }
  ],
  "MobilePhones": [
    {
      "Value": "repellat",
      "StrippedValue": "facere",
      "Description": "Reduced background core"
    },
    {
      "Value": "repellat",
      "StrippedValue": "facere",
      "Description": "Reduced background core"
    }
  ],
  "OfficePhones": [
    {
      "Value": "nostrum",
      "StrippedValue": "libero",
      "Description": "Profound motivating extranet"
    },
    {
      "Value": "nostrum",
      "StrippedValue": "libero",
      "Description": "Profound motivating extranet"
    }
  ],
  "OtherPhones": [
    {
      "Value": "quae",
      "StrippedValue": "mollitia",
      "Description": "Optimized attitude-oriented flexibility"
    },
    {
      "Value": "quae",
      "StrippedValue": "mollitia",
      "Description": "Optimized attitude-oriented flexibility"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 549,
      "Name": "Schmeler-Schamberger",
      "ToolTip": "Cum facilis dolores sint omnis.",
      "Deleted": false,
      "Rank": 622,
      "Type": "pariatur",
      "ColorBlock": 760,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "1997-11-30T03:31:32.6913849+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rem",
      "StyleHint": "cum",
      "Hidden": false,
      "FullName": "Catalina Morar"
    }
  ],
  "PersonNumber": "921361",
  "FullName": "Grant Kovacek I",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "neque",
      "StrippedValue": "ut",
      "Description": "Vision-oriented disintermediate product"
    },
    {
      "Value": "neque",
      "StrippedValue": "ut",
      "Description": "Vision-oriented disintermediate product"
    }
  ],
  "FormalName": "Trantow LLC",
  "Address": null,
  "Post3": "eligendi",
  "Post2": "optio",
  "Post1": "provident",
  "Kanalname": "totam",
  "Kanafname": "amet",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "animi",
  "ActiveInterests": 288,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 768,
  "DbiKey": "quod",
  "DbiLastModified": "2023-02-07T03:31:32.6913849+01:00",
  "DbiLastSyncronized": "2022-05-29T03:31:32.6913849+02:00",
  "SentInfo": 611,
  "ShowContactTickets": 268,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "cupiditate",
      "StrippedValue": "et",
      "Description": "Stand-alone analyzing internet solution"
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "et",
      "Description": "Stand-alone analyzing internet solution"
    }
  ],
  "InternetPhones": [
    {
      "Value": "autem",
      "StrippedValue": "laudantium",
      "Description": "Cloned uniform artificial intelligence"
    },
    {
      "Value": "autem",
      "StrippedValue": "laudantium",
      "Description": "Cloned uniform artificial intelligence"
    }
  ],
  "Source": 860,
  "ActiveErpLinks": 766,
  "ShipmentTypes": [
    {
      "Id": 599,
      "Name": "Harber, Upton and Vandervort",
      "ToolTip": "Aut illo omnis adipisci adipisci sit.",
      "Deleted": false,
      "Rank": 390,
      "Type": "in",
      "ColorBlock": 262,
      "IconHint": "dolor",
      "Selected": false,
      "LastChanged": "2019-07-09T03:31:32.6913849+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "perspiciatis",
      "StyleHint": "minima",
      "Hidden": false,
      "FullName": "Arianna Thompson"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 367,
      "Comment": "non",
      "Registered": "1998-03-08T03:31:32.6913849+01:00",
      "RegisteredAssociateId": 107,
      "Updated": "1996-07-19T03:31:32.6913849+02:00",
      "UpdatedAssociateId": 541,
      "LegalBaseId": 693,
      "LegalBaseKey": "dignissimos",
      "LegalBaseName": "Batz, Jones and Purdy",
      "ConsentPurposeId": 981,
      "ConsentPurposeKey": "totam",
      "ConsentPurposeName": "Schaden, Von and Stracke",
      "ConsentSourceId": 996,
      "ConsentSourceKey": "voluptatum",
      "ConsentSourceName": "Jerde-Hills"
    }
  ],
  "BounceEmails": [
    "kris_dare@kihn.info",
    "mellie_ullrich@lindgren.biz"
  ],
  "ActiveStatusMonitorId": 190,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Mrs. Violette Stacy Grady"
  },
  "ExtraFields": {
    "ExtraFields1": "magnam",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "enim",
    "CustomFields2": "explicabo"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 743,
  "Firstname": "Lance",
  "MiddleName": "Walter, Kutch and Waelchi",
  "Lastname": "Schamberger",
  "Mrmrs": "voluptas",
  "Title": "aut",
  "UpdatedDate": "2015-05-11T03:31:32.6913849+02:00",
  "CreatedDate": "2021-11-26T03:31:32.6913849+01:00",
  "BirthDate": "2010-06-30T03:31:32.6913849+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quo",
      "StrippedValue": "impedit",
      "Description": "De-engineered grid-enabled workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 742
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "impedit",
      "Description": "De-engineered grid-enabled workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 742
        }
      }
    }
  ],
  "Description": "De-engineered tertiary extranet",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "sequi",
      "StrippedValue": "dolores",
      "Description": "Open-architected explicit process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 903
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "dolores",
      "Description": "Open-architected explicit process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 903
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "culpa",
      "StrippedValue": "dolorem",
      "Description": "Diverse 3rd generation product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    },
    {
      "Value": "culpa",
      "StrippedValue": "dolorem",
      "Description": "Diverse 3rd generation product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "non",
      "StrippedValue": "ut",
      "Description": "Optional didactic definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 845
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "ut",
      "Description": "Optional didactic definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 845
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "iusto",
      "StrippedValue": "iure",
      "Description": "Polarised bandwidth-monitored process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 123
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "iure",
      "Description": "Polarised bandwidth-monitored process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 123
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quas",
      "StrippedValue": "culpa",
      "Description": "Stand-alone client-server data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 368
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "culpa",
      "Description": "Stand-alone client-server data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 368
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
      "Id": 773,
      "Name": "Labadie-Schaden",
      "ToolTip": "Blanditiis alias.",
      "Deleted": true,
      "Rank": 510,
      "Type": "ullam",
      "ColorBlock": 514,
      "IconHint": "dolorem",
      "Selected": false,
      "LastChanged": "2018-02-11T03:31:32.6913849+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "mollitia",
      "StyleHint": "deleniti",
      "Hidden": true,
      "FullName": "Miss Patrick Giovani Lesch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 657
        }
      }
    }
  ],
  "PersonNumber": "932950",
  "FullName": "Mr. Maude Funk",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "sapiente",
      "StrippedValue": "aperiam",
      "Description": "Horizontal non-volatile complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 917
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "aperiam",
      "Description": "Horizontal non-volatile complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 917
        }
      }
    }
  ],
  "FormalName": "Zieme, Sawayn and Rice",
  "Address": null,
  "Post3": "itaque",
  "Post2": "nam",
  "Post1": "nemo",
  "Kanalname": "optio",
  "Kanafname": "delectus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ut",
  "ActiveInterests": 427,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 123,
  "DbiKey": "ut",
  "DbiLastModified": "2011-06-07T03:31:32.707005+02:00",
  "DbiLastSyncronized": "2023-01-10T03:31:32.707005+01:00",
  "SentInfo": 710,
  "ShowContactTickets": 761,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sunt",
      "StrippedValue": "sit",
      "Description": "Secured dynamic solution",
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
      "Value": "sunt",
      "StrippedValue": "sit",
      "Description": "Secured dynamic solution",
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
      "Value": "dolor",
      "StrippedValue": "in",
      "Description": "Devolved holistic utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 741
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "in",
      "Description": "Devolved holistic utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 741
        }
      }
    }
  ],
  "Source": 190,
  "ActiveErpLinks": 633,
  "ShipmentTypes": [
    {
      "Id": 659,
      "Name": "Mayer-Crooks",
      "ToolTip": "Ipsam voluptas.",
      "Deleted": false,
      "Rank": 688,
      "Type": "dolores",
      "ColorBlock": 670,
      "IconHint": "nihil",
      "Selected": false,
      "LastChanged": "2021-08-22T03:31:32.707005+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "exercitationem",
      "StyleHint": "sapiente",
      "Hidden": true,
      "FullName": "Autumn Schulist",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 233
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 98,
      "Comment": "optio",
      "Registered": "2014-11-13T03:31:32.707005+01:00",
      "RegisteredAssociateId": 946,
      "Updated": "2007-12-09T03:31:32.707005+01:00",
      "UpdatedAssociateId": 154,
      "LegalBaseId": 465,
      "LegalBaseKey": "dolor",
      "LegalBaseName": "Schoen, Hauck and Lynch",
      "ConsentPurposeId": 150,
      "ConsentPurposeKey": "recusandae",
      "ConsentPurposeName": "Wiza-O'Keefe",
      "ConsentSourceId": 820,
      "ConsentSourceKey": "tenetur",
      "ConsentSourceName": "Ledner-Berge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 354
        }
      }
    }
  ],
  "BounceEmails": [
    "easter.ernser@jenkins.uk",
    "nelle@ernser.ca"
  ],
  "ActiveStatusMonitorId": 345,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Leonora Boyer"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "quo"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "voluptas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 81
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```