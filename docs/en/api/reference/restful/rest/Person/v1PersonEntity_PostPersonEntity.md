---
title: POST Person
uid: v1PersonEntity_PostPersonEntity
generated: true
---

# POST Person

```http
POST /api/v1/Person
```

Creates a new PersonEntity


Calls the Person agent service SavePersonEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Person?$select=name,department,category/id
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

## Request Body: newEntity 

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
POST /api/v1/Person
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 164,
  "Firstname": "Jennyfer",
  "MiddleName": "Price, Fritsch and Leuschke",
  "Lastname": "Luettgen",
  "Mrmrs": "quia",
  "Title": "eos",
  "UpdatedDate": "2019-05-25T13:38:17.4680694+02:00",
  "CreatedDate": "2006-04-10T13:38:17.4680694+02:00",
  "BirthDate": "2018-12-02T13:38:17.4680694+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "labore",
      "StrippedValue": "quia",
      "Description": "Pre-emptive local focus group"
    },
    {
      "Value": "labore",
      "StrippedValue": "quia",
      "Description": "Pre-emptive local focus group"
    }
  ],
  "Description": "Vision-oriented systematic groupware",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "et",
      "StrippedValue": "dolor",
      "Description": "Seamless heuristic artificial intelligence"
    },
    {
      "Value": "et",
      "StrippedValue": "dolor",
      "Description": "Seamless heuristic artificial intelligence"
    }
  ],
  "Faxes": [
    {
      "Value": "laudantium",
      "StrippedValue": "molestiae",
      "Description": "Upgradable encompassing encryption"
    },
    {
      "Value": "laudantium",
      "StrippedValue": "molestiae",
      "Description": "Upgradable encompassing encryption"
    }
  ],
  "MobilePhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "sed",
      "Description": "Enterprise-wide fault-tolerant success"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "sed",
      "Description": "Enterprise-wide fault-tolerant success"
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptates",
      "StrippedValue": "necessitatibus",
      "Description": "Proactive radical framework"
    },
    {
      "Value": "voluptates",
      "StrippedValue": "necessitatibus",
      "Description": "Proactive radical framework"
    }
  ],
  "OtherPhones": [
    {
      "Value": "vero",
      "StrippedValue": "omnis",
      "Description": "Vision-oriented intermediate installation"
    },
    {
      "Value": "vero",
      "StrippedValue": "omnis",
      "Description": "Vision-oriented intermediate installation"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 161,
      "Name": "Schulist-Shields",
      "ToolTip": "Nihil vel aut aut.",
      "Deleted": true,
      "Rank": 648,
      "Type": "ratione",
      "ColorBlock": 205,
      "IconHint": "porro",
      "Selected": true,
      "LastChanged": "1999-06-27T13:38:17.4680694+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "autem",
      "StyleHint": "dolorem",
      "Hidden": true,
      "FullName": "Easton Cremin"
    }
  ],
  "PersonNumber": "1058511",
  "FullName": "Mr. Amelie Champlin",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "neque",
      "StrippedValue": "adipisci",
      "Description": "Universal optimal interface"
    },
    {
      "Value": "neque",
      "StrippedValue": "adipisci",
      "Description": "Universal optimal interface"
    }
  ],
  "FormalName": "Braun, Mueller and Hilpert",
  "Address": null,
  "Post3": "reprehenderit",
  "Post2": "occaecati",
  "Post1": "voluptatem",
  "Kanalname": "illum",
  "Kanafname": "in",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "enim",
  "ActiveInterests": 568,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 119,
  "DbiKey": "et",
  "DbiLastModified": "1997-09-02T13:38:17.4680694+02:00",
  "DbiLastSyncronized": "2013-05-24T13:38:17.4680694+02:00",
  "SentInfo": 245,
  "ShowContactTickets": 923,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "doloribus",
      "StrippedValue": "quia",
      "Description": "Automated uniform standardization"
    },
    {
      "Value": "doloribus",
      "StrippedValue": "quia",
      "Description": "Automated uniform standardization"
    }
  ],
  "InternetPhones": [
    {
      "Value": "in",
      "StrippedValue": "provident",
      "Description": "Expanded intermediate pricing structure"
    },
    {
      "Value": "in",
      "StrippedValue": "provident",
      "Description": "Expanded intermediate pricing structure"
    }
  ],
  "Source": 113,
  "ActiveErpLinks": 857,
  "ShipmentTypes": [
    {
      "Id": 109,
      "Name": "Stiedemann-Macejkovic",
      "ToolTip": "Veritatis aperiam sed vitae.",
      "Deleted": false,
      "Rank": 318,
      "Type": "sunt",
      "ColorBlock": 476,
      "IconHint": "ex",
      "Selected": false,
      "LastChanged": "2021-05-04T13:38:17.4680694+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nulla",
      "StyleHint": "quibusdam",
      "Hidden": false,
      "FullName": "Charlie Champlin"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 306,
      "Comment": "ab",
      "Registered": "2010-05-31T13:38:17.4680694+02:00",
      "RegisteredAssociateId": 196,
      "Updated": "2002-06-08T13:38:17.4680694+02:00",
      "UpdatedAssociateId": 459,
      "LegalBaseId": 842,
      "LegalBaseKey": "ut",
      "LegalBaseName": "Lowe, Hoeger and Monahan",
      "ConsentPurposeId": 86,
      "ConsentPurposeKey": "enim",
      "ConsentPurposeName": "Walter LLC",
      "ConsentSourceId": 565,
      "ConsentSourceKey": "sapiente",
      "ConsentSourceName": "Stokes-Stark"
    }
  ],
  "BounceEmails": [
    "dolly@hoegertrantow.co.uk",
    "noble_hamill@dicki.name"
  ],
  "ActiveStatusMonitorId": 11,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Scarlett Tillman V",
    "SuperOffice:2": "Prof. Destiny Zieme"
  },
  "ExtraFields": {
    "ExtraFields1": "incidunt",
    "ExtraFields2": "maxime"
  },
  "CustomFields": {
    "CustomFields1": "praesentium",
    "CustomFields2": "nam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 415,
  "Firstname": "Meaghan",
  "MiddleName": "Collins, Mraz and Abbott",
  "Lastname": "Cormier",
  "Mrmrs": "aperiam",
  "Title": "ut",
  "UpdatedDate": "2013-04-03T13:38:17.4680694+02:00",
  "CreatedDate": "2018-07-26T13:38:17.4680694+02:00",
  "BirthDate": "1996-11-04T13:38:17.4680694+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ullam",
      "StrippedValue": "rem",
      "Description": "Enterprise-wide cohesive flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 188
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "rem",
      "Description": "Enterprise-wide cohesive flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 188
        }
      }
    }
  ],
  "Description": "Universal optimal focus group",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "iure",
      "Description": "Exclusive directional budgetary management",
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
      "Value": "omnis",
      "StrippedValue": "iure",
      "Description": "Exclusive directional budgetary management",
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
  "Faxes": [
    {
      "Value": "quae",
      "StrippedValue": "rem",
      "Description": "Persistent even-keeled alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 199
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "rem",
      "Description": "Persistent even-keeled alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 199
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "a",
      "StrippedValue": "quidem",
      "Description": "Optimized neutral capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 563
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "quidem",
      "Description": "Optimized neutral capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 563
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "fuga",
      "StrippedValue": "dicta",
      "Description": "Adaptive heuristic portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "dicta",
      "Description": "Adaptive heuristic portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "delectus",
      "StrippedValue": "neque",
      "Description": "Quality-focused multimedia neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 600
        }
      }
    },
    {
      "Value": "delectus",
      "StrippedValue": "neque",
      "Description": "Quality-focused multimedia neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 600
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
      "Id": 937,
      "Name": "Renner, Johns and Brown",
      "ToolTip": "Voluptatem facilis harum doloribus officiis.",
      "Deleted": false,
      "Rank": 150,
      "Type": "pariatur",
      "ColorBlock": 1002,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2019-11-30T13:38:17.4680694+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolore",
      "StyleHint": "laudantium",
      "Hidden": false,
      "FullName": "Golden Crist",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    }
  ],
  "PersonNumber": "1484535",
  "FullName": "Gisselle Wyman",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "architecto",
      "StrippedValue": "ipsam",
      "Description": "Re-engineered solution-oriented encoding",
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
      "Value": "architecto",
      "StrippedValue": "ipsam",
      "Description": "Re-engineered solution-oriented encoding",
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
  "FormalName": "Schimmel-Welch",
  "Address": null,
  "Post3": "molestias",
  "Post2": "et",
  "Post1": "libero",
  "Kanalname": "aut",
  "Kanafname": "vitae",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "deserunt",
  "ActiveInterests": 627,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 793,
  "DbiKey": "excepturi",
  "DbiLastModified": "2011-02-09T13:38:17.4680694+01:00",
  "DbiLastSyncronized": "2015-05-24T13:38:17.4680694+02:00",
  "SentInfo": 394,
  "ShowContactTickets": 565,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sapiente",
      "StrippedValue": "aliquam",
      "Description": "Robust discrete concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 903
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "aliquam",
      "Description": "Robust discrete concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 903
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "rerum",
      "Description": "Focused grid-enabled adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 471
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "rerum",
      "Description": "Focused grid-enabled adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 471
        }
      }
    }
  ],
  "Source": 341,
  "ActiveErpLinks": 118,
  "ShipmentTypes": [
    {
      "Id": 296,
      "Name": "Larson Inc and Sons",
      "ToolTip": "Aut quod saepe ab neque.",
      "Deleted": false,
      "Rank": 64,
      "Type": "fugiat",
      "ColorBlock": 91,
      "IconHint": "dolorem",
      "Selected": false,
      "LastChanged": "2023-06-02T13:38:17.4680694+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "magni",
      "StyleHint": "maiores",
      "Hidden": false,
      "FullName": "Miss Bessie Perry Shields",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 503
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 211,
      "Comment": "repudiandae",
      "Registered": "2016-07-26T13:38:17.4680694+02:00",
      "RegisteredAssociateId": 144,
      "Updated": "2022-12-12T13:38:17.4680694+01:00",
      "UpdatedAssociateId": 889,
      "LegalBaseId": 208,
      "LegalBaseKey": "qui",
      "LegalBaseName": "Beatty Group",
      "ConsentPurposeId": 40,
      "ConsentPurposeKey": "occaecati",
      "ConsentPurposeName": "Gibson, Klein and Schamberger",
      "ConsentSourceId": 64,
      "ConsentSourceKey": "autem",
      "ConsentSourceName": "Gorczany-Leffler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 894
        }
      }
    }
  ],
  "BounceEmails": [
    "garnet@romagueracormier.name",
    "marjolaine.koch@reingerstehr.uk"
  ],
  "ActiveStatusMonitorId": 74,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Marguerite Fleta Hintz",
    "SuperOffice:2": "Teagan DuBuque"
  },
  "ExtraFields": {
    "ExtraFields1": "accusamus",
    "ExtraFields2": "adipisci"
  },
  "CustomFields": {
    "CustomFields1": "assumenda",
    "CustomFields2": "ipsum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 427
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```