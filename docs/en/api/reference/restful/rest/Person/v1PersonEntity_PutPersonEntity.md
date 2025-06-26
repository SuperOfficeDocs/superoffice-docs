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
  "PersonId": 461,
  "Firstname": "Yvonne",
  "MiddleName": "Jerde LLC",
  "Lastname": "Barrows",
  "Mrmrs": "veritatis",
  "Title": "molestiae",
  "UpdatedDate": "2010-05-04T03:45:28.4518091+02:00",
  "CreatedDate": "2012-11-07T03:45:28.4518091+01:00",
  "BirthDate": "2001-08-07T03:45:28.4518091+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "occaecati",
      "StrippedValue": "impedit",
      "Description": "Integrated mobile initiative"
    },
    {
      "Value": "occaecati",
      "StrippedValue": "impedit",
      "Description": "Integrated mobile initiative"
    }
  ],
  "Description": "Profit-focused object-oriented data-warehouse",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "aliquam",
      "StrippedValue": "id",
      "Description": "Team-oriented assymetric encoding"
    },
    {
      "Value": "aliquam",
      "StrippedValue": "id",
      "Description": "Team-oriented assymetric encoding"
    }
  ],
  "Faxes": [
    {
      "Value": "error",
      "StrippedValue": "enim",
      "Description": "Robust user-facing encryption"
    },
    {
      "Value": "error",
      "StrippedValue": "enim",
      "Description": "Robust user-facing encryption"
    }
  ],
  "MobilePhones": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "adipisci",
      "Description": "De-engineered zero defect workforce"
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "adipisci",
      "Description": "De-engineered zero defect workforce"
    }
  ],
  "OfficePhones": [
    {
      "Value": "recusandae",
      "StrippedValue": "voluptatem",
      "Description": "Streamlined tertiary knowledge base"
    },
    {
      "Value": "recusandae",
      "StrippedValue": "voluptatem",
      "Description": "Streamlined tertiary knowledge base"
    }
  ],
  "OtherPhones": [
    {
      "Value": "sed",
      "StrippedValue": "amet",
      "Description": "Versatile fault-tolerant projection"
    },
    {
      "Value": "sed",
      "StrippedValue": "amet",
      "Description": "Versatile fault-tolerant projection"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 923,
      "Name": "Skiles, Raynor and Skiles",
      "ToolTip": "Quam sint perferendis.",
      "Deleted": false,
      "Rank": 711,
      "Type": "labore",
      "ColorBlock": 208,
      "IconHint": "enim",
      "Selected": true,
      "LastChanged": "2013-02-20T03:45:28.4671923+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "illo",
      "StyleHint": "nesciunt",
      "Hidden": false,
      "FullName": "Mr. Edd Hansen"
    }
  ],
  "PersonNumber": "1246266",
  "FullName": "Erin Stiedemann",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "id",
      "StrippedValue": "corporis",
      "Description": "User-centric bottom-line infrastructure"
    },
    {
      "Value": "id",
      "StrippedValue": "corporis",
      "Description": "User-centric bottom-line infrastructure"
    }
  ],
  "FormalName": "Weber-Cremin",
  "Address": null,
  "Post3": "quisquam",
  "Post2": "quidem",
  "Post1": "officiis",
  "Kanalname": "corporis",
  "Kanafname": "voluptas",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "nisi",
  "ActiveInterests": 189,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 131,
  "DbiKey": "voluptas",
  "DbiLastModified": "2013-08-29T03:45:28.4671923+02:00",
  "DbiLastSyncronized": "2010-02-10T03:45:28.4671923+01:00",
  "SentInfo": 613,
  "ShowContactTickets": 716,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "laudantium",
      "StrippedValue": "tempora",
      "Description": "Integrated needs-based encoding"
    },
    {
      "Value": "laudantium",
      "StrippedValue": "tempora",
      "Description": "Integrated needs-based encoding"
    }
  ],
  "InternetPhones": [
    {
      "Value": "omnis",
      "StrippedValue": "quibusdam",
      "Description": "Grass-roots exuding adapter"
    },
    {
      "Value": "omnis",
      "StrippedValue": "quibusdam",
      "Description": "Grass-roots exuding adapter"
    }
  ],
  "Source": 181,
  "ActiveErpLinks": 788,
  "ShipmentTypes": [
    {
      "Id": 21,
      "Name": "Morissette-Towne",
      "ToolTip": "Iusto quia eos quam voluptas.",
      "Deleted": true,
      "Rank": 571,
      "Type": "veniam",
      "ColorBlock": 500,
      "IconHint": "repellat",
      "Selected": false,
      "LastChanged": "2023-12-29T03:45:28.4671923+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "itaque",
      "Hidden": false,
      "FullName": "Mrs. Terence Dach"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 671,
      "Comment": "occaecati",
      "Registered": "2025-02-20T03:45:28.4671923+01:00",
      "RegisteredAssociateId": 283,
      "Updated": "2017-09-14T03:45:28.4671923+02:00",
      "UpdatedAssociateId": 345,
      "LegalBaseId": 978,
      "LegalBaseKey": "quis",
      "LegalBaseName": "Pouros, Goyette and Kris",
      "ConsentPurposeId": 883,
      "ConsentPurposeKey": "consequatur",
      "ConsentPurposeName": "Sawayn-Orn",
      "ConsentSourceId": 265,
      "ConsentSourceKey": "qui",
      "ConsentSourceName": "Marks, Ondricka and Kling"
    }
  ],
  "BounceEmails": [
    "alvis@hand.uk",
    "constantin@ritchiewolff.us"
  ],
  "ActiveStatusMonitorId": 686,
  "CreatedByFormId": 287,
  "UserDefinedFields": {
    "SuperOffice:1": "Garth Windler",
    "SuperOffice:2": "Jonas Witting"
  },
  "ExtraFields": {
    "ExtraFields1": "cupiditate",
    "ExtraFields2": "ab"
  },
  "CustomFields": {
    "CustomFields1": "aliquid",
    "CustomFields2": "quaerat"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 303,
  "Firstname": "Tre",
  "MiddleName": "Waters, Kemmer and Quitzon",
  "Lastname": "Leannon",
  "Mrmrs": "maxime",
  "Title": "vel",
  "UpdatedDate": "2023-08-17T03:45:28.4671923+02:00",
  "CreatedDate": "2007-07-28T03:45:28.4671923+02:00",
  "BirthDate": "2001-12-14T03:45:28.4671923+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptates",
      "StrippedValue": "dignissimos",
      "Description": "Polarised directional productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 447
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "dignissimos",
      "Description": "Polarised directional productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 447
        }
      }
    }
  ],
  "Description": "Cross-group motivating Graphical User Interface",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "neque",
      "StrippedValue": "iusto",
      "Description": "Configurable non-volatile synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 393
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "iusto",
      "Description": "Configurable non-volatile synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 393
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "provident",
      "Description": "Total tangible encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 787
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "provident",
      "Description": "Total tangible encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 787
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "tenetur",
      "StrippedValue": "qui",
      "Description": "Open-architected needs-based secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 370
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "qui",
      "Description": "Open-architected needs-based secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 370
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quos",
      "StrippedValue": "ea",
      "Description": "Synergized actuating conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 655
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "ea",
      "Description": "Synergized actuating conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 655
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "omnis",
      "StrippedValue": "quae",
      "Description": "Managed user-facing migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 702
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "quae",
      "Description": "Managed user-facing migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 702
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
      "Id": 474,
      "Name": "Mueller, Sporer and Kemmer",
      "ToolTip": "Ipsa voluptatem odit qui totam totam.",
      "Deleted": true,
      "Rank": 150,
      "Type": "eius",
      "ColorBlock": 118,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2021-05-02T03:45:28.4671923+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "necessitatibus",
      "Hidden": true,
      "FullName": "Vena Lavon Hyatt I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 275
        }
      }
    }
  ],
  "PersonNumber": "1518610",
  "FullName": "Letitia Trantow",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "eos",
      "StrippedValue": "ut",
      "Description": "Synchronised responsive leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 923
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "ut",
      "Description": "Synchronised responsive leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 923
        }
      }
    }
  ],
  "FormalName": "Kiehn LLC",
  "Address": null,
  "Post3": "esse",
  "Post2": "ea",
  "Post1": "nihil",
  "Kanalname": "explicabo",
  "Kanafname": "nobis",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "molestiae",
  "ActiveInterests": 590,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 151,
  "DbiKey": "sunt",
  "DbiLastModified": "2017-10-10T03:45:28.4671923+02:00",
  "DbiLastSyncronized": "1999-01-04T03:45:28.4671923+01:00",
  "SentInfo": 501,
  "ShowContactTickets": 865,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "vero",
      "StrippedValue": "cumque",
      "Description": "Automated empowering customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "cumque",
      "Description": "Automated empowering customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "eos",
      "StrippedValue": "esse",
      "Description": "Digitized demand-driven encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 494
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "esse",
      "Description": "Digitized demand-driven encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 494
        }
      }
    }
  ],
  "Source": 94,
  "ActiveErpLinks": 90,
  "ShipmentTypes": [
    {
      "Id": 726,
      "Name": "Barrows, Rogahn and Dach",
      "ToolTip": "Exercitationem qui vero illo est aperiam.",
      "Deleted": false,
      "Rank": 66,
      "Type": "quia",
      "ColorBlock": 166,
      "IconHint": "molestiae",
      "Selected": false,
      "LastChanged": "2000-03-12T03:45:28.4671923+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "dolore",
      "Hidden": false,
      "FullName": "Mr. Bernhard Ondricka",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 955
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 807,
      "Comment": "aut",
      "Registered": "2004-05-10T03:45:28.4671923+02:00",
      "RegisteredAssociateId": 251,
      "Updated": "2021-03-18T03:45:28.4671923+01:00",
      "UpdatedAssociateId": 557,
      "LegalBaseId": 608,
      "LegalBaseKey": "voluptas",
      "LegalBaseName": "Murazik-Treutel",
      "ConsentPurposeId": 298,
      "ConsentPurposeKey": "aut",
      "ConsentPurposeName": "Schumm, Kautzer and Rath",
      "ConsentSourceId": 163,
      "ConsentSourceKey": "quod",
      "ConsentSourceName": "Zemlak Group",
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
    "osborne@lesch.info",
    "carolina_vonrueden@mcdermott.co.uk"
  ],
  "ActiveStatusMonitorId": 490,
  "CreatedByFormId": 554,
  "UserDefinedFields": {
    "SuperOffice:1": "Ivy Kovacek Jr.",
    "SuperOffice:2": "Noemy Hermiston"
  },
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "minima",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 796
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```