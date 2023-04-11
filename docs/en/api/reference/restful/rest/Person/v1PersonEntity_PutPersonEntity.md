---
title: PUT Person/{id}
uid: v1PersonEntity_PutPersonEntity
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
  "PersonId": 814,
  "Firstname": "Anita",
  "MiddleName": "Luettgen-Dooley",
  "Lastname": "Funk",
  "Mrmrs": "et",
  "Title": "corrupti",
  "UpdatedDate": "2007-02-20T15:29:29.8481998+01:00",
  "CreatedDate": "1999-11-04T15:29:29.8481998+01:00",
  "BirthDate": "2019-03-31T15:29:29.8481998+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "et",
      "Description": "Quality-focused bi-directional data-warehouse"
    },
    {
      "Value": "omnis",
      "StrippedValue": "et",
      "Description": "Quality-focused bi-directional data-warehouse"
    }
  ],
  "Description": "Quality-focused web-enabled archive",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "quo",
      "StrippedValue": "iste",
      "Description": "Cross-group assymetric project"
    },
    {
      "Value": "quo",
      "StrippedValue": "iste",
      "Description": "Cross-group assymetric project"
    }
  ],
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "voluptates",
      "Description": "Organized responsive process improvement"
    },
    {
      "Value": "velit",
      "StrippedValue": "voluptates",
      "Description": "Organized responsive process improvement"
    }
  ],
  "MobilePhones": [
    {
      "Value": "quia",
      "StrippedValue": "quasi",
      "Description": "Customizable modular open system"
    },
    {
      "Value": "quia",
      "StrippedValue": "quasi",
      "Description": "Customizable modular open system"
    }
  ],
  "OfficePhones": [
    {
      "Value": "placeat",
      "StrippedValue": "sint",
      "Description": "User-centric empowering flexibility"
    },
    {
      "Value": "placeat",
      "StrippedValue": "sint",
      "Description": "User-centric empowering flexibility"
    }
  ],
  "OtherPhones": [
    {
      "Value": "non",
      "StrippedValue": "a",
      "Description": "Secured homogeneous circuit"
    },
    {
      "Value": "non",
      "StrippedValue": "a",
      "Description": "Secured homogeneous circuit"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 305,
      "Name": "Kirlin Inc and Sons",
      "ToolTip": "Quae voluptates aut doloremque quos magnam natus nemo.",
      "Deleted": false,
      "Rank": 480,
      "Type": "itaque",
      "ColorBlock": 690,
      "IconHint": "culpa",
      "Selected": false,
      "LastChanged": "2005-10-13T15:29:29.8521975+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "delectus",
      "StyleHint": "soluta",
      "Hidden": false,
      "FullName": "Marcelo Jenkins"
    }
  ],
  "PersonNumber": "1892949",
  "FullName": "Nick Torphy",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "dolore",
      "StrippedValue": "et",
      "Description": "Customer-focused intermediate benchmark"
    },
    {
      "Value": "dolore",
      "StrippedValue": "et",
      "Description": "Customer-focused intermediate benchmark"
    }
  ],
  "FormalName": "Rohan Group",
  "Address": null,
  "Post3": "est",
  "Post2": "ea",
  "Post1": "animi",
  "Kanalname": "optio",
  "Kanafname": "rerum",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "incidunt",
  "ActiveInterests": 993,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 724,
  "DbiKey": "aut",
  "DbiLastModified": "1998-06-14T15:29:29.8546972+02:00",
  "DbiLastSyncronized": "2013-05-31T15:29:29.8546972+02:00",
  "SentInfo": 912,
  "ShowContactTickets": 318,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "fuga",
      "StrippedValue": "deserunt",
      "Description": "Pre-emptive optimal instruction set"
    },
    {
      "Value": "fuga",
      "StrippedValue": "deserunt",
      "Description": "Pre-emptive optimal instruction set"
    }
  ],
  "InternetPhones": [
    {
      "Value": "dolor",
      "StrippedValue": "et",
      "Description": "Open-architected national project"
    },
    {
      "Value": "dolor",
      "StrippedValue": "et",
      "Description": "Open-architected national project"
    }
  ],
  "Source": 262,
  "ActiveErpLinks": 890,
  "ShipmentTypes": [
    {
      "Id": 280,
      "Name": "Bednar, Carter and Wilkinson",
      "ToolTip": "Debitis possimus molestiae.",
      "Deleted": true,
      "Rank": 924,
      "Type": "pariatur",
      "ColorBlock": 835,
      "IconHint": "quo",
      "Selected": false,
      "LastChanged": "1998-09-25T15:29:29.8551998+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eius",
      "StyleHint": "iure",
      "Hidden": false,
      "FullName": "Cassandre Toni Marks PhD"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 212,
      "Comment": "sunt",
      "Registered": "1999-03-25T15:29:29.8556982+01:00",
      "RegisteredAssociateId": 145,
      "Updated": "2007-06-04T15:29:29.8556982+02:00",
      "UpdatedAssociateId": 725,
      "LegalBaseId": 99,
      "LegalBaseKey": "at",
      "LegalBaseName": "Bernhard-Luettgen",
      "ConsentPurposeId": 822,
      "ConsentPurposeKey": "omnis",
      "ConsentPurposeName": "Koelpin Inc and Sons",
      "ConsentSourceId": 96,
      "ConsentSourceKey": "dolorum",
      "ConsentSourceName": "Gutkowski Group"
    }
  ],
  "BounceEmails": [
    "marielle@steuber.com",
    "wendy@mayer.com"
  ],
  "ActiveStatusMonitorId": 768,
  "UserDefinedFields": {
    "SuperOffice:1": "Jayson Harris II",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "veniam",
    "ExtraFields2": "provident"
  },
  "CustomFields": {
    "CustomFields1": "nisi",
    "CustomFields2": "autem"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 874,
  "Firstname": "Nola",
  "MiddleName": "Streich, O'Kon and Stoltenberg",
  "Lastname": "Padberg",
  "Mrmrs": "fuga",
  "Title": "aut",
  "UpdatedDate": "2002-05-16T15:29:29.864697+02:00",
  "CreatedDate": "2020-06-24T15:29:29.864697+02:00",
  "BirthDate": "2015-11-25T15:29:29.864697+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "vel",
      "Description": "Business-focused national utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 383
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "vel",
      "Description": "Business-focused national utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 383
        }
      }
    }
  ],
  "Description": "Sharable homogeneous database",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "nesciunt",
      "Description": "Mandatory motivating monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 25
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "nesciunt",
      "Description": "Mandatory motivating monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 25
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "minus",
      "StrippedValue": "repellendus",
      "Description": "Intuitive impactful website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 657
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "repellendus",
      "Description": "Intuitive impactful website",
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
  "MobilePhones": [
    {
      "Value": "incidunt",
      "StrippedValue": "natus",
      "Description": "Progressive web-enabled core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 260
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "natus",
      "Description": "Progressive web-enabled core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 260
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "excepturi",
      "StrippedValue": "doloribus",
      "Description": "Switchable content-based budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 39
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "doloribus",
      "Description": "Switchable content-based budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 39
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "molestias",
      "StrippedValue": "non",
      "Description": "Robust homogeneous Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 67
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "non",
      "Description": "Robust homogeneous Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 67
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
      "Id": 379,
      "Name": "West-Jakubowski",
      "ToolTip": "Sint voluptas.",
      "Deleted": false,
      "Rank": 596,
      "Type": "illo",
      "ColorBlock": 582,
      "IconHint": "doloremque",
      "Selected": false,
      "LastChanged": "2001-07-02T15:29:29.8666979+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cum",
      "StyleHint": "aut",
      "Hidden": true,
      "FullName": "Miss Sammie Volkman PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 408
        }
      }
    }
  ],
  "PersonNumber": "586835",
  "FullName": "Miss Glennie Conn",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "harum",
      "Description": "Expanded global projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 401
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "harum",
      "Description": "Expanded global projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 401
        }
      }
    }
  ],
  "FormalName": "Erdman, West and Hayes",
  "Address": null,
  "Post3": "ut",
  "Post2": "non",
  "Post1": "sint",
  "Kanalname": "in",
  "Kanafname": "occaecati",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ea",
  "ActiveInterests": 63,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 591,
  "DbiKey": "unde",
  "DbiLastModified": "2014-11-18T15:29:29.8701983+01:00",
  "DbiLastSyncronized": "2008-10-14T15:29:29.8701983+02:00",
  "SentInfo": 494,
  "ShowContactTickets": 299,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quia",
      "StrippedValue": "omnis",
      "Description": "Self-enabling client-server frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 532
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "omnis",
      "Description": "Self-enabling client-server frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 532
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "natus",
      "StrippedValue": "error",
      "Description": "Persistent scalable data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 375
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "error",
      "Description": "Persistent scalable data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 375
        }
      }
    }
  ],
  "Source": 363,
  "ActiveErpLinks": 757,
  "ShipmentTypes": [
    {
      "Id": 138,
      "Name": "Mayer, Reichert and Hansen",
      "ToolTip": "Velit hic sint aut rerum rerum.",
      "Deleted": true,
      "Rank": 388,
      "Type": "tenetur",
      "ColorBlock": 245,
      "IconHint": "aliquam",
      "Selected": true,
      "LastChanged": "1999-06-08T15:29:29.8707017+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "incidunt",
      "StyleHint": "minus",
      "Hidden": false,
      "FullName": "Dr. Tressa Gottlieb V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 25
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 379,
      "Comment": "quis",
      "Registered": "2006-10-08T15:29:29.8707017+02:00",
      "RegisteredAssociateId": 268,
      "Updated": "2011-08-05T15:29:29.8707017+02:00",
      "UpdatedAssociateId": 274,
      "LegalBaseId": 830,
      "LegalBaseKey": "blanditiis",
      "LegalBaseName": "Lebsack Inc and Sons",
      "ConsentPurposeId": 941,
      "ConsentPurposeKey": "illum",
      "ConsentPurposeName": "Macejkovic-Schamberger",
      "ConsentSourceId": 143,
      "ConsentSourceKey": "aut",
      "ConsentSourceName": "Stroman, Schulist and Walker",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 327
        }
      }
    }
  ],
  "BounceEmails": [
    "arturo@dach.uk",
    "ciara@boyer.uk"
  ],
  "ActiveStatusMonitorId": 398,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Jeramy Buckridge Sr.",
    "SuperOffice:2": "Miss Angelina Feeney"
  },
  "ExtraFields": {
    "ExtraFields1": "velit",
    "ExtraFields2": "aliquam"
  },
  "CustomFields": {
    "CustomFields1": "temporibus",
    "CustomFields2": "neque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 773
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```