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
| CreatedByFormId | Integer | The form id of the form that created the person |
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
| CreatedByFormId | int32 | The form id of the form that created the person |
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 861,
  "Firstname": "Ida",
  "MiddleName": "Kihn-Quitzon",
  "Lastname": "Howell",
  "Mrmrs": "nisi",
  "Title": "quia",
  "UpdatedDate": "2016-05-23T13:28:31.7573489+02:00",
  "CreatedDate": "2023-06-07T13:28:31.7573489+02:00",
  "BirthDate": "2016-11-29T13:28:31.7573489+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dolorum",
      "StrippedValue": "iste",
      "Description": "Enterprise-wide 5th generation superstructure"
    },
    {
      "Value": "dolorum",
      "StrippedValue": "iste",
      "Description": "Enterprise-wide 5th generation superstructure"
    }
  ],
  "Description": "Inverse needs-based middleware",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "deserunt",
      "StrippedValue": "harum",
      "Description": "Fully-configurable mission-critical interface"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "harum",
      "Description": "Fully-configurable mission-critical interface"
    }
  ],
  "Faxes": [
    {
      "Value": "dolorum",
      "StrippedValue": "eius",
      "Description": "Implemented homogeneous benchmark"
    },
    {
      "Value": "dolorum",
      "StrippedValue": "eius",
      "Description": "Implemented homogeneous benchmark"
    }
  ],
  "MobilePhones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "ipsum",
      "Description": "Optional cohesive application"
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "ipsum",
      "Description": "Optional cohesive application"
    }
  ],
  "OfficePhones": [
    {
      "Value": "reiciendis",
      "StrippedValue": "voluptatem",
      "Description": "Triple-buffered secondary strategy"
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "voluptatem",
      "Description": "Triple-buffered secondary strategy"
    }
  ],
  "OtherPhones": [
    {
      "Value": "quia",
      "StrippedValue": "aut",
      "Description": "Re-contextualized leading edge circuit"
    },
    {
      "Value": "quia",
      "StrippedValue": "aut",
      "Description": "Re-contextualized leading edge circuit"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 597,
      "Name": "Nolan, Goyette and Lynch",
      "ToolTip": "Qui ab omnis voluptatem voluptatem sit.",
      "Deleted": false,
      "Rank": 8,
      "Type": "amet",
      "ColorBlock": 545,
      "IconHint": "at",
      "Selected": false,
      "LastChanged": "2014-11-07T13:28:31.7729711+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eligendi",
      "StyleHint": "id",
      "Hidden": false,
      "FullName": "Carmella Sterling Johnston DVM"
    }
  ],
  "PersonNumber": "1318822",
  "FullName": "Mrs. Major Colten Kohler",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "unde",
      "Description": "Optimized next generation database"
    },
    {
      "Value": "aut",
      "StrippedValue": "unde",
      "Description": "Optimized next generation database"
    }
  ],
  "FormalName": "Bartell-Witting",
  "Address": null,
  "Post3": "molestiae",
  "Post2": "dolorem",
  "Post1": "sunt",
  "Kanalname": "sequi",
  "Kanafname": "vel",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ex",
  "ActiveInterests": 606,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 382,
  "DbiKey": "dignissimos",
  "DbiLastModified": "2019-11-29T13:28:31.7729711+01:00",
  "DbiLastSyncronized": "2007-07-04T13:28:31.7729711+02:00",
  "SentInfo": 261,
  "ShowContactTickets": 533,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ipsa",
      "StrippedValue": "atque",
      "Description": "Adaptive secondary forecast"
    },
    {
      "Value": "ipsa",
      "StrippedValue": "atque",
      "Description": "Adaptive secondary forecast"
    }
  ],
  "InternetPhones": [
    {
      "Value": "accusantium",
      "StrippedValue": "ea",
      "Description": "Virtual 5th generation utilisation"
    },
    {
      "Value": "accusantium",
      "StrippedValue": "ea",
      "Description": "Virtual 5th generation utilisation"
    }
  ],
  "Source": 957,
  "ActiveErpLinks": 635,
  "ShipmentTypes": [
    {
      "Id": 854,
      "Name": "Adams-Harvey",
      "ToolTip": "Voluptatum quo eligendi qui quo.",
      "Deleted": false,
      "Rank": 310,
      "Type": "quo",
      "ColorBlock": 6,
      "IconHint": "autem",
      "Selected": true,
      "LastChanged": "2004-04-06T13:28:31.7729711+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veniam",
      "StyleHint": "est",
      "Hidden": true,
      "FullName": "Cristina Stracke PhD"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 403,
      "Comment": "dolor",
      "Registered": "2021-10-27T13:28:31.7729711+02:00",
      "RegisteredAssociateId": 317,
      "Updated": "2010-04-21T13:28:31.7729711+02:00",
      "UpdatedAssociateId": 74,
      "LegalBaseId": 801,
      "LegalBaseKey": "nobis",
      "LegalBaseName": "Kirlin Group",
      "ConsentPurposeId": 977,
      "ConsentPurposeKey": "delectus",
      "ConsentPurposeName": "Schaden Inc and Sons",
      "ConsentSourceId": 983,
      "ConsentSourceKey": "labore",
      "ConsentSourceName": "Pagac, Quigley and Schiller"
    }
  ],
  "BounceEmails": [
    "america@lindgren.info",
    "brook_legros@krajcikwatsica.co.uk"
  ],
  "ActiveStatusMonitorId": 29,
  "CreatedByFormId": 41,
  "UserDefinedFields": {
    "SuperOffice:1": "Jed Rutherford",
    "SuperOffice:2": "Katelyn Erdman"
  },
  "ExtraFields": {
    "ExtraFields1": "minus",
    "ExtraFields2": "quis"
  },
  "CustomFields": {
    "CustomFields1": "in",
    "CustomFields2": "sint"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 696,
  "Firstname": "Diana",
  "MiddleName": "Krajcik-Spinka",
  "Lastname": "Rohan",
  "Mrmrs": "tempore",
  "Title": "inventore",
  "UpdatedDate": "1998-06-20T13:28:31.7729711+02:00",
  "CreatedDate": "2008-03-10T13:28:31.7729711+01:00",
  "BirthDate": "2017-08-18T13:28:31.7729711+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "itaque",
      "StrippedValue": "fugiat",
      "Description": "Implemented responsive leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 853
        }
      }
    },
    {
      "Value": "itaque",
      "StrippedValue": "fugiat",
      "Description": "Implemented responsive leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 853
        }
      }
    }
  ],
  "Description": "Organic reciprocal framework",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "est",
      "StrippedValue": "sapiente",
      "Description": "Focused multi-state product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 901
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "sapiente",
      "Description": "Focused multi-state product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 901
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "et",
      "Description": "Synergized client-server data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 730
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "et",
      "Description": "Synergized client-server data-warehouse",
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
  "MobilePhones": [
    {
      "Value": "aut",
      "StrippedValue": "repellendus",
      "Description": "Team-oriented empowering initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 229
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "repellendus",
      "Description": "Team-oriented empowering initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 229
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "incidunt",
      "StrippedValue": "delectus",
      "Description": "Integrated directional methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 545
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "delectus",
      "Description": "Integrated directional methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 545
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "in",
      "StrippedValue": "necessitatibus",
      "Description": "Vision-oriented encompassing interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 101
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "necessitatibus",
      "Description": "Vision-oriented encompassing interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 101
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
      "Id": 708,
      "Name": "Aufderhar-Bradtke",
      "ToolTip": "Sit qui optio molestiae temporibus ut.",
      "Deleted": false,
      "Rank": 95,
      "Type": "aspernatur",
      "ColorBlock": 280,
      "IconHint": "sint",
      "Selected": false,
      "LastChanged": "2018-12-02T13:28:31.7885906+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "quasi",
      "Hidden": false,
      "FullName": "Mrs. Tate Verla Cummings II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 318
        }
      }
    }
  ],
  "PersonNumber": "739852",
  "FullName": "Kenna Virgil Prohaska I",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "error",
      "StrippedValue": "aliquid",
      "Description": "User-centric encompassing database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 440
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "aliquid",
      "Description": "User-centric encompassing database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 440
        }
      }
    }
  ],
  "FormalName": "Conroy Group",
  "Address": null,
  "Post3": "autem",
  "Post2": "est",
  "Post1": "sit",
  "Kanalname": "autem",
  "Kanafname": "fugit",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "incidunt",
  "ActiveInterests": 744,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 769,
  "DbiKey": "consequatur",
  "DbiLastModified": "2006-01-01T13:28:31.7885906+01:00",
  "DbiLastSyncronized": "2007-08-10T13:28:31.7885906+02:00",
  "SentInfo": 619,
  "ShowContactTickets": 568,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "in",
      "StrippedValue": "officiis",
      "Description": "Diverse value-added hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 687
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "officiis",
      "Description": "Diverse value-added hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 687
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "quia",
      "StrippedValue": "eum",
      "Description": "Mandatory static support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 615
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "eum",
      "Description": "Mandatory static support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 615
        }
      }
    }
  ],
  "Source": 774,
  "ActiveErpLinks": 462,
  "ShipmentTypes": [
    {
      "Id": 155,
      "Name": "Ernser-Ritchie",
      "ToolTip": "Expedita necessitatibus ut ut nostrum.",
      "Deleted": false,
      "Rank": 566,
      "Type": "pariatur",
      "ColorBlock": 992,
      "IconHint": "accusantium",
      "Selected": false,
      "LastChanged": "2006-02-13T13:28:31.7885906+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "alias",
      "StyleHint": "id",
      "Hidden": false,
      "FullName": "Michel Hodkiewicz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 567,
      "Comment": "velit",
      "Registered": "2013-01-11T13:28:31.7885906+01:00",
      "RegisteredAssociateId": 787,
      "Updated": "2008-11-05T13:28:31.7885906+01:00",
      "UpdatedAssociateId": 25,
      "LegalBaseId": 15,
      "LegalBaseKey": "sunt",
      "LegalBaseName": "Murray-Schaefer",
      "ConsentPurposeId": 292,
      "ConsentPurposeKey": "dolor",
      "ConsentPurposeName": "Powlowski, Kessler and Keebler",
      "ConsentSourceId": 226,
      "ConsentSourceKey": "suscipit",
      "ConsentSourceName": "Ziemann Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 511
        }
      }
    }
  ],
  "BounceEmails": [
    "beau_heathcote@rippin.com",
    "aditya_mckenzie@kerlukehirthe.us"
  ],
  "ActiveStatusMonitorId": 616,
  "CreatedByFormId": 139,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Carol Devan Dooley PhD",
    "SuperOffice:2": "Quinton Haag"
  },
  "ExtraFields": {
    "ExtraFields1": "consectetur",
    "ExtraFields2": "quo"
  },
  "CustomFields": {
    "CustomFields1": "nesciunt",
    "CustomFields2": "ea"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 633
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```