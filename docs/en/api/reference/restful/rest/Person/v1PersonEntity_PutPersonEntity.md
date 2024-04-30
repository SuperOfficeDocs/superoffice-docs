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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 303,
  "Firstname": "Chandler",
  "MiddleName": "Welch, Schuster and Homenick",
  "Lastname": "Graham",
  "Mrmrs": "quis",
  "Title": "nesciunt",
  "UpdatedDate": "2020-02-20T11:16:13.9644573+01:00",
  "CreatedDate": "2003-07-02T11:16:13.9644573+02:00",
  "BirthDate": "2006-03-24T11:16:13.9644573+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dignissimos",
      "StrippedValue": "reiciendis",
      "Description": "Progressive contextually-based policy"
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "reiciendis",
      "Description": "Progressive contextually-based policy"
    }
  ],
  "Description": "Polarised context-sensitive protocol",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "est",
      "StrippedValue": "voluptatibus",
      "Description": "Function-based web-enabled architecture"
    },
    {
      "Value": "est",
      "StrippedValue": "voluptatibus",
      "Description": "Function-based web-enabled architecture"
    }
  ],
  "Faxes": [
    {
      "Value": "consequatur",
      "StrippedValue": "nobis",
      "Description": "Automated impactful data-warehouse"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "nobis",
      "Description": "Automated impactful data-warehouse"
    }
  ],
  "MobilePhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "asperiores",
      "Description": "Exclusive grid-enabled process improvement"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "asperiores",
      "Description": "Exclusive grid-enabled process improvement"
    }
  ],
  "OfficePhones": [
    {
      "Value": "minus",
      "StrippedValue": "magnam",
      "Description": "Seamless 24 hour database"
    },
    {
      "Value": "minus",
      "StrippedValue": "magnam",
      "Description": "Seamless 24 hour database"
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "quidem",
      "Description": "Phased empowering functionalities"
    },
    {
      "Value": "et",
      "StrippedValue": "quidem",
      "Description": "Phased empowering functionalities"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 469,
      "Name": "Koss, Schmitt and Leffler",
      "ToolTip": "Ratione voluptatem quidem doloribus sint veritatis qui.",
      "Deleted": false,
      "Rank": 246,
      "Type": "quas",
      "ColorBlock": 615,
      "IconHint": "id",
      "Selected": false,
      "LastChanged": "2000-10-18T11:16:13.9644573+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "debitis",
      "StyleHint": "eos",
      "Hidden": false,
      "FullName": "Dr. Ubaldo Sage Leuschke V"
    }
  ],
  "PersonNumber": "1302404",
  "FullName": "Margret Paucek",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "sunt",
      "StrippedValue": "quaerat",
      "Description": "User-centric human-resource conglomeration"
    },
    {
      "Value": "sunt",
      "StrippedValue": "quaerat",
      "Description": "User-centric human-resource conglomeration"
    }
  ],
  "FormalName": "Schroeder Inc and Sons",
  "Address": null,
  "Post3": "eum",
  "Post2": "eius",
  "Post1": "ea",
  "Kanalname": "quis",
  "Kanafname": "voluptate",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "laboriosam",
  "ActiveInterests": 972,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 536,
  "DbiKey": "non",
  "DbiLastModified": "1999-09-27T11:16:13.9644573+02:00",
  "DbiLastSyncronized": "2018-04-12T11:16:13.9644573+02:00",
  "SentInfo": 622,
  "ShowContactTickets": 659,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "eveniet",
      "StrippedValue": "et",
      "Description": "Compatible motivating orchestration"
    },
    {
      "Value": "eveniet",
      "StrippedValue": "et",
      "Description": "Compatible motivating orchestration"
    }
  ],
  "InternetPhones": [
    {
      "Value": "optio",
      "StrippedValue": "maiores",
      "Description": "Automated responsive matrices"
    },
    {
      "Value": "optio",
      "StrippedValue": "maiores",
      "Description": "Automated responsive matrices"
    }
  ],
  "Source": 467,
  "ActiveErpLinks": 361,
  "ShipmentTypes": [
    {
      "Id": 707,
      "Name": "Gutmann-Ruecker",
      "ToolTip": "Omnis maxime illo ullam repellat officiis enim maxime.",
      "Deleted": false,
      "Rank": 352,
      "Type": "fugit",
      "ColorBlock": 774,
      "IconHint": "inventore",
      "Selected": false,
      "LastChanged": "2012-01-31T11:16:13.9644573+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Mekhi Huels"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 852,
      "Comment": "omnis",
      "Registered": "1999-12-14T11:16:13.9644573+01:00",
      "RegisteredAssociateId": 83,
      "Updated": "2013-08-30T11:16:13.9644573+02:00",
      "UpdatedAssociateId": 619,
      "LegalBaseId": 579,
      "LegalBaseKey": "sed",
      "LegalBaseName": "Gislason LLC",
      "ConsentPurposeId": 879,
      "ConsentPurposeKey": "provident",
      "ConsentPurposeName": "Keeling Inc and Sons",
      "ConsentSourceId": 19,
      "ConsentSourceKey": "maiores",
      "ConsentSourceName": "Romaguera-Moen"
    }
  ],
  "BounceEmails": [
    "rodrigo@schimmel.uk",
    "berneice_hettinger@rogahn.com"
  ],
  "ActiveStatusMonitorId": 562,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Fausto Leilani Gibson III",
    "SuperOffice:2": "575270555"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "reprehenderit",
    "CustomFields2": "maiores"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 57,
  "Firstname": "Lisette",
  "MiddleName": "Morar-Langosh",
  "Lastname": "Donnelly",
  "Mrmrs": "debitis",
  "Title": "quisquam",
  "UpdatedDate": "2021-01-26T11:16:13.9800858+01:00",
  "CreatedDate": "2005-06-29T11:16:13.9800858+02:00",
  "BirthDate": "2016-04-05T11:16:13.9800858+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "eum",
      "StrippedValue": "ex",
      "Description": "Proactive logistical database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 708
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "ex",
      "Description": "Proactive logistical database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 708
        }
      }
    }
  ],
  "Description": "Sharable client-driven access",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "porro",
      "StrippedValue": "nisi",
      "Description": "Assimilated human-resource projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 595
        }
      }
    },
    {
      "Value": "porro",
      "StrippedValue": "nisi",
      "Description": "Assimilated human-resource projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 595
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "corporis",
      "Description": "Managed solution-oriented intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 384
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "corporis",
      "Description": "Managed solution-oriented intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 384
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "corrupti",
      "StrippedValue": "voluptates",
      "Description": "Stand-alone reciprocal workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 433
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "voluptates",
      "Description": "Stand-alone reciprocal workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 433
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "iste",
      "StrippedValue": "commodi",
      "Description": "Team-oriented impactful toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 37
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "commodi",
      "Description": "Team-oriented impactful toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 37
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quos",
      "StrippedValue": "facilis",
      "Description": "Right-sized zero administration groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 175
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "facilis",
      "Description": "Right-sized zero administration groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 175
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
      "Id": 928,
      "Name": "Cole, Brekke and Fay",
      "ToolTip": "Quia quae delectus dolorum qui illum omnis voluptatem.",
      "Deleted": false,
      "Rank": 739,
      "Type": "temporibus",
      "ColorBlock": 915,
      "IconHint": "minima",
      "Selected": false,
      "LastChanged": "2013-12-20T11:16:13.9800858+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "iste",
      "StyleHint": "sint",
      "Hidden": false,
      "FullName": "Uriel Schroeder",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 104
        }
      }
    }
  ],
  "PersonNumber": "1282585",
  "FullName": "Florine Bernhard",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "commodi",
      "StrippedValue": "amet",
      "Description": "Public-key fresh-thinking synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 812
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "amet",
      "Description": "Public-key fresh-thinking synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 812
        }
      }
    }
  ],
  "FormalName": "Douglas LLC",
  "Address": null,
  "Post3": "aperiam",
  "Post2": "labore",
  "Post1": "facilis",
  "Kanalname": "ipsum",
  "Kanafname": "est",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "officiis",
  "ActiveInterests": 541,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 810,
  "DbiKey": "adipisci",
  "DbiLastModified": "2016-11-23T11:16:13.9800858+01:00",
  "DbiLastSyncronized": "2005-05-12T11:16:13.9800858+02:00",
  "SentInfo": 517,
  "ShowContactTickets": 929,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "vero",
      "StrippedValue": "assumenda",
      "Description": "Organic impactful help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "assumenda",
      "Description": "Organic impactful help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 228
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "facilis",
      "StrippedValue": "maxime",
      "Description": "Open-source contextually-based methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 779
        }
      }
    },
    {
      "Value": "facilis",
      "StrippedValue": "maxime",
      "Description": "Open-source contextually-based methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 779
        }
      }
    }
  ],
  "Source": 723,
  "ActiveErpLinks": 594,
  "ShipmentTypes": [
    {
      "Id": 766,
      "Name": "Purdy, VonRueden and O'Conner",
      "ToolTip": "Facere ratione est quaerat.",
      "Deleted": false,
      "Rank": 256,
      "Type": "iure",
      "ColorBlock": 158,
      "IconHint": "ducimus",
      "Selected": false,
      "LastChanged": "2016-12-23T11:16:13.9800858+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "culpa",
      "StyleHint": "eaque",
      "Hidden": false,
      "FullName": "Edyth Spencer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 730
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 99,
      "Comment": "officia",
      "Registered": "2013-02-07T11:16:13.9800858+01:00",
      "RegisteredAssociateId": 431,
      "Updated": "2022-12-23T11:16:13.9800858+01:00",
      "UpdatedAssociateId": 419,
      "LegalBaseId": 781,
      "LegalBaseKey": "autem",
      "LegalBaseName": "Rowe, Goodwin and Lindgren",
      "ConsentPurposeId": 372,
      "ConsentPurposeKey": "facere",
      "ConsentPurposeName": "Grady, Cormier and Wehner",
      "ConsentSourceId": 14,
      "ConsentSourceKey": "pariatur",
      "ConsentSourceName": "Stanton Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 859
        }
      }
    }
  ],
  "BounceEmails": [
    "regan.reilly@keebler.info",
    "jamal@gislason.biz"
  ],
  "ActiveStatusMonitorId": 468,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Art Jabari Purdy Jr.",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "adipisci"
  },
  "CustomFields": {
    "CustomFields1": "necessitatibus",
    "CustomFields2": "quam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 359
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```