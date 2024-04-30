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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 896,
  "Firstname": "Madyson",
  "MiddleName": "Breitenberg, Roberts and Cole",
  "Lastname": "Bruen",
  "Mrmrs": "est",
  "Title": "quia",
  "UpdatedDate": "2014-03-13T11:44:42.0702572+01:00",
  "CreatedDate": "2022-07-07T11:44:42.0702572+02:00",
  "BirthDate": "2014-05-01T11:44:42.0702572+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "facere",
      "StrippedValue": "nulla",
      "Description": "Vision-oriented zero administration portal"
    },
    {
      "Value": "facere",
      "StrippedValue": "nulla",
      "Description": "Vision-oriented zero administration portal"
    }
  ],
  "Description": "Synergistic directional portal",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "sed",
      "StrippedValue": "magnam",
      "Description": "Exclusive reciprocal artificial intelligence"
    },
    {
      "Value": "sed",
      "StrippedValue": "magnam",
      "Description": "Exclusive reciprocal artificial intelligence"
    }
  ],
  "Faxes": [
    {
      "Value": "fuga",
      "StrippedValue": "et",
      "Description": "Synchronised stable knowledge base"
    },
    {
      "Value": "fuga",
      "StrippedValue": "et",
      "Description": "Synchronised stable knowledge base"
    }
  ],
  "MobilePhones": [
    {
      "Value": "recusandae",
      "StrippedValue": "enim",
      "Description": "Compatible tangible portal"
    },
    {
      "Value": "recusandae",
      "StrippedValue": "enim",
      "Description": "Compatible tangible portal"
    }
  ],
  "OfficePhones": [
    {
      "Value": "officia",
      "StrippedValue": "facilis",
      "Description": "Organized leading edge algorithm"
    },
    {
      "Value": "officia",
      "StrippedValue": "facilis",
      "Description": "Organized leading edge algorithm"
    }
  ],
  "OtherPhones": [
    {
      "Value": "omnis",
      "StrippedValue": "velit",
      "Description": "Robust non-volatile collaboration"
    },
    {
      "Value": "omnis",
      "StrippedValue": "velit",
      "Description": "Robust non-volatile collaboration"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 156,
      "Name": "Harris LLC",
      "ToolTip": "Porro sit.",
      "Deleted": true,
      "Rank": 600,
      "Type": "voluptatem",
      "ColorBlock": 321,
      "IconHint": "eaque",
      "Selected": true,
      "LastChanged": "2017-10-24T11:44:42.0702572+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "soluta",
      "StyleHint": "sunt",
      "Hidden": true,
      "FullName": "Pauline Caleb Thompson DVM"
    }
  ],
  "PersonNumber": "999793",
  "FullName": "Makayla Gutmann DDS",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "similique",
      "StrippedValue": "quas",
      "Description": "Organized uniform leverage"
    },
    {
      "Value": "similique",
      "StrippedValue": "quas",
      "Description": "Organized uniform leverage"
    }
  ],
  "FormalName": "Tromp, Kihn and Koch",
  "Address": null,
  "Post3": "voluptas",
  "Post2": "eos",
  "Post1": "excepturi",
  "Kanalname": "perferendis",
  "Kanafname": "consequuntur",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ut",
  "ActiveInterests": 937,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 682,
  "DbiKey": "accusamus",
  "DbiLastModified": "2021-12-10T11:44:42.0702572+01:00",
  "DbiLastSyncronized": "2024-02-28T11:44:42.0702572+01:00",
  "SentInfo": 204,
  "ShowContactTickets": 92,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "est",
      "StrippedValue": "quis",
      "Description": "Enhanced encompassing standardization"
    },
    {
      "Value": "est",
      "StrippedValue": "quis",
      "Description": "Enhanced encompassing standardization"
    }
  ],
  "InternetPhones": [
    {
      "Value": "ut",
      "StrippedValue": "qui",
      "Description": "Total mission-critical groupware"
    },
    {
      "Value": "ut",
      "StrippedValue": "qui",
      "Description": "Total mission-critical groupware"
    }
  ],
  "Source": 867,
  "ActiveErpLinks": 444,
  "ShipmentTypes": [
    {
      "Id": 699,
      "Name": "Moen-Schuppe",
      "ToolTip": "Suscipit maxime autem maiores voluptas dolorem consequuntur.",
      "Deleted": false,
      "Rank": 737,
      "Type": "pariatur",
      "ColorBlock": 730,
      "IconHint": "commodi",
      "Selected": true,
      "LastChanged": "2010-06-02T11:44:42.0702572+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolor",
      "StyleHint": "iste",
      "Hidden": true,
      "FullName": "Louie Leffler"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 746,
      "Comment": "pariatur",
      "Registered": "2007-09-16T11:44:42.0702572+02:00",
      "RegisteredAssociateId": 35,
      "Updated": "2017-11-12T11:44:42.0702572+01:00",
      "UpdatedAssociateId": 841,
      "LegalBaseId": 823,
      "LegalBaseKey": "eum",
      "LegalBaseName": "Sporer, Watsica and Dare",
      "ConsentPurposeId": 630,
      "ConsentPurposeKey": "est",
      "ConsentPurposeName": "Swaniawski-Fisher",
      "ConsentSourceId": 693,
      "ConsentSourceKey": "architecto",
      "ConsentSourceName": "Gutmann-Friesen"
    }
  ],
  "BounceEmails": [
    "christophe@welch.co.uk",
    "hulda@zemlakortiz.biz"
  ],
  "ActiveStatusMonitorId": 501,
  "UserDefinedFields": {
    "SuperOffice:1": "Quinten Deckow",
    "SuperOffice:2": "Jazlyn Wunsch DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "debitis"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "aut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 245,
  "Firstname": "Forest",
  "MiddleName": "Boyer Inc and Sons",
  "Lastname": "O'Reilly",
  "Mrmrs": "et",
  "Title": "non",
  "UpdatedDate": "2019-04-22T11:44:42.0858811+02:00",
  "CreatedDate": "2011-10-31T11:44:42.0858811+01:00",
  "BirthDate": "2006-07-06T11:44:42.0858811+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "cum",
      "StrippedValue": "architecto",
      "Description": "Open-source actuating toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 305
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "architecto",
      "Description": "Open-source actuating toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 305
        }
      }
    }
  ],
  "Description": "Future-proofed empowering conglomeration",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "a",
      "StrippedValue": "eum",
      "Description": "Innovative multi-state policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 451
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "eum",
      "Description": "Innovative multi-state policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 451
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "suscipit",
      "StrippedValue": "necessitatibus",
      "Description": "Synergized 4th generation encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 143
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "necessitatibus",
      "Description": "Synergized 4th generation encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 143
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "autem",
      "StrippedValue": "temporibus",
      "Description": "Quality-focused directional budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "temporibus",
      "Description": "Quality-focused directional budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "odit",
      "StrippedValue": "est",
      "Description": "Open-architected upward-trending approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 767
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "est",
      "Description": "Open-architected upward-trending approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 767
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "velit",
      "StrippedValue": "est",
      "Description": "Realigned explicit extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 931
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "est",
      "Description": "Realigned explicit extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 931
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
      "Id": 59,
      "Name": "Cassin, Breitenberg and McLaughlin",
      "ToolTip": "Aut incidunt voluptas.",
      "Deleted": false,
      "Rank": 859,
      "Type": "excepturi",
      "ColorBlock": 44,
      "IconHint": "quas",
      "Selected": false,
      "LastChanged": "2004-04-19T11:44:42.0858811+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolore",
      "StyleHint": "molestiae",
      "Hidden": false,
      "FullName": "Dr. Cornell Winona Fahey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 796
        }
      }
    }
  ],
  "PersonNumber": "866867",
  "FullName": "Fernando Ullrich",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "quasi",
      "StrippedValue": "et",
      "Description": "Robust bandwidth-monitored extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 882
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "et",
      "Description": "Robust bandwidth-monitored extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 882
        }
      }
    }
  ],
  "FormalName": "Beier Inc and Sons",
  "Address": null,
  "Post3": "distinctio",
  "Post2": "veniam",
  "Post1": "laborum",
  "Kanalname": "distinctio",
  "Kanafname": "nam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 336,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 10,
  "DbiKey": "eum",
  "DbiLastModified": "2008-12-22T11:44:42.0858811+01:00",
  "DbiLastSyncronized": "2011-12-21T11:44:42.0858811+01:00",
  "SentInfo": 406,
  "ShowContactTickets": 853,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "eum",
      "StrippedValue": "est",
      "Description": "De-engineered clear-thinking analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 345
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "est",
      "Description": "De-engineered clear-thinking analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 345
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ut",
      "StrippedValue": "officiis",
      "Description": "Digitized neutral algorithm",
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
      "Value": "ut",
      "StrippedValue": "officiis",
      "Description": "Digitized neutral algorithm",
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
  "Source": 851,
  "ActiveErpLinks": 428,
  "ShipmentTypes": [
    {
      "Id": 245,
      "Name": "Sporer Group",
      "ToolTip": "Minus quia et aut ut atque deserunt est.",
      "Deleted": false,
      "Rank": 693,
      "Type": "et",
      "ColorBlock": 839,
      "IconHint": "dolor",
      "Selected": false,
      "LastChanged": "2023-08-05T11:44:42.0858811+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sunt",
      "StyleHint": "vel",
      "Hidden": false,
      "FullName": "Jamie Torp",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 930
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 536,
      "Comment": "eos",
      "Registered": "2008-05-28T11:44:42.0858811+02:00",
      "RegisteredAssociateId": 510,
      "Updated": "2016-10-13T11:44:42.0858811+02:00",
      "UpdatedAssociateId": 761,
      "LegalBaseId": 129,
      "LegalBaseKey": "asperiores",
      "LegalBaseName": "Braun LLC",
      "ConsentPurposeId": 558,
      "ConsentPurposeKey": "est",
      "ConsentPurposeName": "Hahn-Pollich",
      "ConsentSourceId": 391,
      "ConsentSourceKey": "neque",
      "ConsentSourceName": "Runolfsson-Altenwerth",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 54
        }
      }
    }
  ],
  "BounceEmails": [
    "lindsey_tillman@considine.info",
    "lurline.effertz@roberts.name"
  ],
  "ActiveStatusMonitorId": 401,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "odit"
  },
  "CustomFields": {
    "CustomFields1": "ab",
    "CustomFields2": "provident"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 165
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```