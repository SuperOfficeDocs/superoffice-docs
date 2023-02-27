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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 403,
  "Firstname": "Kaleigh",
  "MiddleName": "Balistreri, Hilpert and Lindgren",
  "Lastname": "Adams",
  "Mrmrs": "quo",
  "Title": "soluta",
  "UpdatedDate": "2009-07-23T14:19:10.4123484+02:00",
  "CreatedDate": "2013-10-10T14:19:10.4123484+02:00",
  "BirthDate": "2019-12-02T14:19:10.4123484+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "neque",
      "Description": "Horizontal non-volatile matrices"
    },
    {
      "Value": "qui",
      "StrippedValue": "neque",
      "Description": "Horizontal non-volatile matrices"
    }
  ],
  "Description": "Synergistic uniform capability",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "aliquid",
      "StrippedValue": "qui",
      "Description": "Self-enabling context-sensitive policy"
    },
    {
      "Value": "aliquid",
      "StrippedValue": "qui",
      "Description": "Self-enabling context-sensitive policy"
    }
  ],
  "Faxes": [
    {
      "Value": "tempora",
      "StrippedValue": "reiciendis",
      "Description": "Reduced demand-driven encoding"
    },
    {
      "Value": "tempora",
      "StrippedValue": "reiciendis",
      "Description": "Reduced demand-driven encoding"
    }
  ],
  "MobilePhones": [
    {
      "Value": "perferendis",
      "StrippedValue": "illo",
      "Description": "Object-based client-driven project"
    },
    {
      "Value": "perferendis",
      "StrippedValue": "illo",
      "Description": "Object-based client-driven project"
    }
  ],
  "OfficePhones": [
    {
      "Value": "nulla",
      "StrippedValue": "veritatis",
      "Description": "Managed well-modulated application"
    },
    {
      "Value": "nulla",
      "StrippedValue": "veritatis",
      "Description": "Managed well-modulated application"
    }
  ],
  "OtherPhones": [
    {
      "Value": "sed",
      "StrippedValue": "repudiandae",
      "Description": "Synergized background forecast"
    },
    {
      "Value": "sed",
      "StrippedValue": "repudiandae",
      "Description": "Synergized background forecast"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 645,
      "Name": "Marvin-Fahey",
      "ToolTip": "Enim sed ullam beatae ipsa.",
      "Deleted": false,
      "Rank": 594,
      "Type": "quo",
      "ColorBlock": 537,
      "IconHint": "rerum",
      "Selected": false,
      "LastChanged": "2022-03-01T14:19:10.4123484+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "quasi",
      "Hidden": false,
      "FullName": "Cullen Austen Schaefer II"
    }
  ],
  "PersonNumber": "380840",
  "FullName": "Lora Thiel",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "rerum",
      "StrippedValue": "ea",
      "Description": "Sharable disintermediate hardware"
    },
    {
      "Value": "rerum",
      "StrippedValue": "ea",
      "Description": "Sharable disintermediate hardware"
    }
  ],
  "FormalName": "Simonis-Kohler",
  "Address": null,
  "Post3": "omnis",
  "Post2": "dolores",
  "Post1": "pariatur",
  "Kanalname": "laudantium",
  "Kanafname": "ut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "iure",
  "ActiveInterests": 61,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 618,
  "DbiKey": "suscipit",
  "DbiLastModified": "2002-07-21T14:19:10.4123484+02:00",
  "DbiLastSyncronized": "2017-09-13T14:19:10.4123484+02:00",
  "SentInfo": 875,
  "ShowContactTickets": 801,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "optio",
      "StrippedValue": "voluptas",
      "Description": "Monitored local leverage"
    },
    {
      "Value": "optio",
      "StrippedValue": "voluptas",
      "Description": "Monitored local leverage"
    }
  ],
  "InternetPhones": [
    {
      "Value": "deleniti",
      "StrippedValue": "esse",
      "Description": "Face to face 5th generation model"
    },
    {
      "Value": "deleniti",
      "StrippedValue": "esse",
      "Description": "Face to face 5th generation model"
    }
  ],
  "Source": 31,
  "ActiveErpLinks": 779,
  "ShipmentTypes": [
    {
      "Id": 194,
      "Name": "Herman Inc and Sons",
      "ToolTip": "Nihil omnis facere iusto accusamus dolores nostrum consequatur.",
      "Deleted": false,
      "Rank": 201,
      "Type": "reprehenderit",
      "ColorBlock": 762,
      "IconHint": "veritatis",
      "Selected": false,
      "LastChanged": "2022-07-31T14:19:10.4123484+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aliquid",
      "StyleHint": "sed",
      "Hidden": false,
      "FullName": "Jaylan Quitzon"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 292,
      "Comment": "debitis",
      "Registered": "2002-09-27T14:19:10.4123484+02:00",
      "RegisteredAssociateId": 225,
      "Updated": "2017-11-18T14:19:10.4123484+01:00",
      "UpdatedAssociateId": 70,
      "LegalBaseId": 599,
      "LegalBaseKey": "iure",
      "LegalBaseName": "Monahan-Hegmann",
      "ConsentPurposeId": 165,
      "ConsentPurposeKey": "possimus",
      "ConsentPurposeName": "Mohr-Barrows",
      "ConsentSourceId": 297,
      "ConsentSourceKey": "fugit",
      "ConsentSourceName": "Davis Group"
    }
  ],
  "BounceEmails": [
    "gabriella_oreilly@rueckercollier.us",
    "victor@gerlach.co.uk"
  ],
  "ActiveStatusMonitorId": 612,
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Wanda Una Hand II",
    "SuperOffice:2": "1492644264"
  },
  "ExtraFields": {
    "ExtraFields1": "hic",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "libero",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 458,
  "Firstname": "Wava",
  "MiddleName": "Gusikowski-Rath",
  "Lastname": "Dooley",
  "Mrmrs": "quae",
  "Title": "non",
  "UpdatedDate": "1999-10-01T14:19:10.427974+02:00",
  "CreatedDate": "2015-01-22T14:19:10.427974+01:00",
  "BirthDate": "2013-02-13T14:19:10.427974+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "laudantium",
      "Description": "Innovative upward-trending knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 552
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "laudantium",
      "Description": "Innovative upward-trending knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 552
        }
      }
    }
  ],
  "Description": "Enhanced background policy",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "velit",
      "StrippedValue": "dolor",
      "Description": "Business-focused assymetric utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 681
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "dolor",
      "Description": "Business-focused assymetric utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 681
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "totam",
      "StrippedValue": "soluta",
      "Description": "Versatile disintermediate info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 809
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "soluta",
      "Description": "Versatile disintermediate info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 809
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "nisi",
      "StrippedValue": "asperiores",
      "Description": "Reverse-engineered coherent capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 979
        }
      }
    },
    {
      "Value": "nisi",
      "StrippedValue": "asperiores",
      "Description": "Reverse-engineered coherent capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 979
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "aliquid",
      "StrippedValue": "enim",
      "Description": "Fundamental intermediate knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 507
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "enim",
      "Description": "Fundamental intermediate knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 507
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ut",
      "StrippedValue": "occaecati",
      "Description": "Synchronised radical customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "occaecati",
      "Description": "Synchronised radical customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
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
      "Id": 321,
      "Name": "Hodkiewicz Group",
      "ToolTip": "Natus porro non debitis impedit.",
      "Deleted": false,
      "Rank": 988,
      "Type": "sunt",
      "ColorBlock": 217,
      "IconHint": "id",
      "Selected": true,
      "LastChanged": "2012-11-18T14:19:10.427974+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "id",
      "StyleHint": "sed",
      "Hidden": false,
      "FullName": "Sarai Friesen",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 923
        }
      }
    }
  ],
  "PersonNumber": "1200375",
  "FullName": "Roel Lynch",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "eos",
      "Description": "Focused 24 hour parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 997
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "eos",
      "Description": "Focused 24 hour parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 997
        }
      }
    }
  ],
  "FormalName": "Schoen Inc and Sons",
  "Address": null,
  "Post3": "voluptatibus",
  "Post2": "et",
  "Post1": "et",
  "Kanalname": "mollitia",
  "Kanafname": "iste",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "magni",
  "ActiveInterests": 726,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 521,
  "DbiKey": "animi",
  "DbiLastModified": "2000-06-20T14:19:10.427974+02:00",
  "DbiLastSyncronized": "2020-10-17T14:19:10.427974+02:00",
  "SentInfo": 363,
  "ShowContactTickets": 826,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "eos",
      "StrippedValue": "quo",
      "Description": "Fundamental grid-enabled flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 186
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "quo",
      "Description": "Fundamental grid-enabled flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 186
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "omnis",
      "StrippedValue": "iusto",
      "Description": "Realigned bandwidth-monitored open system",
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
      "Value": "omnis",
      "StrippedValue": "iusto",
      "Description": "Realigned bandwidth-monitored open system",
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
  "Source": 840,
  "ActiveErpLinks": 274,
  "ShipmentTypes": [
    {
      "Id": 792,
      "Name": "Kerluke-Homenick",
      "ToolTip": "Aliquam fuga beatae aut fugiat maxime pariatur.",
      "Deleted": true,
      "Rank": 199,
      "Type": "et",
      "ColorBlock": 577,
      "IconHint": "veritatis",
      "Selected": false,
      "LastChanged": "2000-05-04T14:19:10.427974+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consectetur",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Alejandra Gerlach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 649
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 51,
      "Comment": "nulla",
      "Registered": "2015-08-03T14:19:10.427974+02:00",
      "RegisteredAssociateId": 35,
      "Updated": "2009-08-09T14:19:10.427974+02:00",
      "UpdatedAssociateId": 667,
      "LegalBaseId": 822,
      "LegalBaseKey": "est",
      "LegalBaseName": "Leannon, Witting and McCullough",
      "ConsentPurposeId": 661,
      "ConsentPurposeKey": "sed",
      "ConsentPurposeName": "Carroll-Hammes",
      "ConsentSourceId": 466,
      "ConsentSourceKey": "laudantium",
      "ConsentSourceName": "Rohan-Casper",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    }
  ],
  "BounceEmails": [
    "kade.marvin@towne.uk",
    "alfredo@dicki.info"
  ],
  "ActiveStatusMonitorId": 657,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Elissa Hintz"
  },
  "ExtraFields": {
    "ExtraFields1": "beatae",
    "ExtraFields2": "doloribus"
  },
  "CustomFields": {
    "CustomFields1": "magnam",
    "CustomFields2": "repudiandae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 55
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```