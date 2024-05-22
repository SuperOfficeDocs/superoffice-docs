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
  "PersonId": 319,
  "Firstname": "Meredith",
  "MiddleName": "Welch, King and Abernathy",
  "Lastname": "Langworth",
  "Mrmrs": "dolor",
  "Title": "asperiores",
  "UpdatedDate": "2000-05-13T12:57:42.5263634+02:00",
  "CreatedDate": "2012-02-02T12:57:42.5263634+01:00",
  "BirthDate": "2013-11-13T12:57:42.5263634+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quasi",
      "StrippedValue": "aliquid",
      "Description": "Secured transitional flexibility"
    },
    {
      "Value": "quasi",
      "StrippedValue": "aliquid",
      "Description": "Secured transitional flexibility"
    }
  ],
  "Description": "Optimized reciprocal encoding",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "error",
      "StrippedValue": "possimus",
      "Description": "Decentralized context-sensitive internet solution"
    },
    {
      "Value": "error",
      "StrippedValue": "possimus",
      "Description": "Decentralized context-sensitive internet solution"
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "qui",
      "Description": "Fundamental well-modulated middleware"
    },
    {
      "Value": "sit",
      "StrippedValue": "qui",
      "Description": "Fundamental well-modulated middleware"
    }
  ],
  "MobilePhones": [
    {
      "Value": "soluta",
      "StrippedValue": "reiciendis",
      "Description": "Balanced optimal definition"
    },
    {
      "Value": "soluta",
      "StrippedValue": "reiciendis",
      "Description": "Balanced optimal definition"
    }
  ],
  "OfficePhones": [
    {
      "Value": "placeat",
      "StrippedValue": "voluptatibus",
      "Description": "User-centric context-sensitive intranet"
    },
    {
      "Value": "placeat",
      "StrippedValue": "voluptatibus",
      "Description": "User-centric context-sensitive intranet"
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "ratione",
      "Description": "Inverse bi-directional implementation"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "ratione",
      "Description": "Inverse bi-directional implementation"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 707,
      "Name": "Paucek Group",
      "ToolTip": "Maxime aut voluptatem quia provident quae blanditiis.",
      "Deleted": true,
      "Rank": 14,
      "Type": "accusantium",
      "ColorBlock": 368,
      "IconHint": "reprehenderit",
      "Selected": false,
      "LastChanged": "2008-06-18T12:57:42.5263634+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rerum",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Ms. Meta Hyatt V"
    }
  ],
  "PersonNumber": "1171488",
  "FullName": "Liza Mertz",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "sunt",
      "StrippedValue": "qui",
      "Description": "Persevering systematic benchmark"
    },
    {
      "Value": "sunt",
      "StrippedValue": "qui",
      "Description": "Persevering systematic benchmark"
    }
  ],
  "FormalName": "Gibson LLC",
  "Address": null,
  "Post3": "est",
  "Post2": "voluptates",
  "Post1": "ullam",
  "Kanalname": "facilis",
  "Kanafname": "exercitationem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "molestiae",
  "ActiveInterests": 224,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 306,
  "DbiKey": "sunt",
  "DbiLastModified": "2017-11-29T12:57:42.5263634+01:00",
  "DbiLastSyncronized": "2024-01-16T12:57:42.5263634+01:00",
  "SentInfo": 343,
  "ShowContactTickets": 797,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "molestiae",
      "StrippedValue": "esse",
      "Description": "Multi-channelled tertiary service-desk"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "esse",
      "Description": "Multi-channelled tertiary service-desk"
    }
  ],
  "InternetPhones": [
    {
      "Value": "fugit",
      "StrippedValue": "quod",
      "Description": "Horizontal maximized customer loyalty"
    },
    {
      "Value": "fugit",
      "StrippedValue": "quod",
      "Description": "Horizontal maximized customer loyalty"
    }
  ],
  "Source": 265,
  "ActiveErpLinks": 414,
  "ShipmentTypes": [
    {
      "Id": 466,
      "Name": "Larkin LLC",
      "ToolTip": "Laboriosam et vel quis.",
      "Deleted": false,
      "Rank": 141,
      "Type": "laudantium",
      "ColorBlock": 911,
      "IconHint": "velit",
      "Selected": false,
      "LastChanged": "2022-06-27T12:57:42.5263634+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nesciunt",
      "StyleHint": "consequatur",
      "Hidden": true,
      "FullName": "Ms. Birdie Eusebio Auer V"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 895,
      "Comment": "minima",
      "Registered": "2020-02-02T12:57:42.5263634+01:00",
      "RegisteredAssociateId": 906,
      "Updated": "2015-01-06T12:57:42.5263634+01:00",
      "UpdatedAssociateId": 246,
      "LegalBaseId": 607,
      "LegalBaseKey": "dolores",
      "LegalBaseName": "Robel, Towne and Littel",
      "ConsentPurposeId": 412,
      "ConsentPurposeKey": "impedit",
      "ConsentPurposeName": "Heller-Mann",
      "ConsentSourceId": 527,
      "ConsentSourceKey": "suscipit",
      "ConsentSourceName": "Heathcote Inc and Sons"
    }
  ],
  "BounceEmails": [
    "rosemary@hyatt.name",
    "enid.weissnat@dicki.uk"
  ],
  "ActiveStatusMonitorId": 956,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Eugene Tate Bauch Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "quae"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "placeat"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 776,
  "Firstname": "Anibal",
  "MiddleName": "Greenfelder-Ullrich",
  "Lastname": "Ondricka",
  "Mrmrs": "minus",
  "Title": "quidem",
  "UpdatedDate": "2022-04-12T12:57:42.5419844+02:00",
  "CreatedDate": "2001-07-17T12:57:42.5419844+02:00",
  "BirthDate": "2008-03-17T12:57:42.5419844+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dolores",
      "StrippedValue": "molestiae",
      "Description": "Inverse 5th generation flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 457
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "molestiae",
      "Description": "Inverse 5th generation flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 457
        }
      }
    }
  ],
  "Description": "Open-source disintermediate secured line",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "aliquid",
      "StrippedValue": "atque",
      "Description": "Ameliorated 24/7 database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 852
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "atque",
      "Description": "Ameliorated 24/7 database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 852
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "distinctio",
      "StrippedValue": "nesciunt",
      "Description": "Sharable optimal open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    },
    {
      "Value": "distinctio",
      "StrippedValue": "nesciunt",
      "Description": "Sharable optimal open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "id",
      "StrippedValue": "ex",
      "Description": "Enhanced upward-trending toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 799
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "ex",
      "Description": "Enhanced upward-trending toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 799
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "adipisci",
      "StrippedValue": "facilis",
      "Description": "Total coherent projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 881
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "facilis",
      "Description": "Total coherent projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 881
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quisquam",
      "StrippedValue": "praesentium",
      "Description": "Distributed content-based local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 930
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "praesentium",
      "Description": "Distributed content-based local area network",
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
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 182,
      "Name": "Zieme, Upton and Hermiston",
      "ToolTip": "Molestiae facere quas fugiat dolor voluptatem.",
      "Deleted": true,
      "Rank": 730,
      "Type": "ex",
      "ColorBlock": 719,
      "IconHint": "suscipit",
      "Selected": false,
      "LastChanged": "2024-01-17T12:57:42.5419844+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "hic",
      "StyleHint": "aperiam",
      "Hidden": false,
      "FullName": "Miss Sarah Green",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 785
        }
      }
    }
  ],
  "PersonNumber": "515585",
  "FullName": "Mr. Guido Tomasa Stracke",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "ea",
      "Description": "Mandatory holistic productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 385
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "ea",
      "Description": "Mandatory holistic productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 385
        }
      }
    }
  ],
  "FormalName": "Mertz Inc and Sons",
  "Address": null,
  "Post3": "itaque",
  "Post2": "hic",
  "Post1": "sint",
  "Kanalname": "est",
  "Kanafname": "quia",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "porro",
  "ActiveInterests": 904,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 100,
  "DbiKey": "ex",
  "DbiLastModified": "2022-05-22T12:57:42.5419844+02:00",
  "DbiLastSyncronized": "1997-10-11T12:57:42.5419844+02:00",
  "SentInfo": 496,
  "ShowContactTickets": 474,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "iste",
      "StrippedValue": "sit",
      "Description": "Secured empowering portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "sit",
      "Description": "Secured empowering portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "quo",
      "Description": "Assimilated maximized orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 746
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quo",
      "Description": "Assimilated maximized orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 746
        }
      }
    }
  ],
  "Source": 724,
  "ActiveErpLinks": 368,
  "ShipmentTypes": [
    {
      "Id": 744,
      "Name": "Baumbach, Farrell and Harber",
      "ToolTip": "Est ad maiores fugiat.",
      "Deleted": false,
      "Rank": 190,
      "Type": "reprehenderit",
      "ColorBlock": 337,
      "IconHint": "non",
      "Selected": true,
      "LastChanged": "2004-08-05T12:57:42.5419844+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsum",
      "StyleHint": "aliquid",
      "Hidden": true,
      "FullName": "Rhea Makenna Dickens PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 430
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 841,
      "Comment": "dolorem",
      "Registered": "2000-11-08T12:57:42.5419844+01:00",
      "RegisteredAssociateId": 13,
      "Updated": "2000-12-02T12:57:42.5419844+01:00",
      "UpdatedAssociateId": 994,
      "LegalBaseId": 689,
      "LegalBaseKey": "occaecati",
      "LegalBaseName": "Rolfson Inc and Sons",
      "ConsentPurposeId": 66,
      "ConsentPurposeKey": "soluta",
      "ConsentPurposeName": "Ondricka, Hand and Douglas",
      "ConsentSourceId": 298,
      "ConsentSourceKey": "repudiandae",
      "ConsentSourceName": "Beer, Zboncak and Hudson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 427
        }
      }
    }
  ],
  "BounceEmails": [
    "verona.larkin@hagenes.com",
    "cydney.anderson@lebsack.com"
  ],
  "ActiveStatusMonitorId": 947,
  "UserDefinedFields": {
    "SuperOffice:1": "Kianna Swaniawski",
    "SuperOffice:2": "Miss Agustin Ruthe Lang"
  },
  "ExtraFields": {
    "ExtraFields1": "fuga",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "distinctio",
    "CustomFields2": "est"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 836
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```