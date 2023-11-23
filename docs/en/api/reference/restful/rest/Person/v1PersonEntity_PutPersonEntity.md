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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 777,
  "Firstname": "Reynold",
  "MiddleName": "Toy-Schowalter",
  "Lastname": "King",
  "Mrmrs": "labore",
  "Title": "debitis",
  "UpdatedDate": "2001-04-20T13:38:17.4836968+02:00",
  "CreatedDate": "2000-12-04T13:38:17.4836968+01:00",
  "BirthDate": "2004-10-13T13:38:17.4836968+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "temporibus",
      "Description": "Organized mission-critical knowledge base"
    },
    {
      "Value": "quia",
      "StrippedValue": "temporibus",
      "Description": "Organized mission-critical knowledge base"
    }
  ],
  "Description": "Multi-lateral directional model",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quia",
      "StrippedValue": "et",
      "Description": "Networked solution-oriented migration"
    },
    {
      "Value": "quia",
      "StrippedValue": "et",
      "Description": "Networked solution-oriented migration"
    }
  ],
  "Faxes": [
    {
      "Value": "tempora",
      "StrippedValue": "quia",
      "Description": "Automated mission-critical installation"
    },
    {
      "Value": "tempora",
      "StrippedValue": "quia",
      "Description": "Automated mission-critical installation"
    }
  ],
  "MobilePhones": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "nostrum",
      "Description": "Synergistic systematic application"
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "nostrum",
      "Description": "Synergistic systematic application"
    }
  ],
  "OfficePhones": [
    {
      "Value": "possimus",
      "StrippedValue": "ab",
      "Description": "Exclusive multi-tasking array"
    },
    {
      "Value": "possimus",
      "StrippedValue": "ab",
      "Description": "Exclusive multi-tasking array"
    }
  ],
  "OtherPhones": [
    {
      "Value": "eveniet",
      "StrippedValue": "iste",
      "Description": "User-friendly 24 hour interface"
    },
    {
      "Value": "eveniet",
      "StrippedValue": "iste",
      "Description": "User-friendly 24 hour interface"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 890,
      "Name": "Erdman Inc and Sons",
      "ToolTip": "Distinctio vel officia quis consequuntur non rem aut.",
      "Deleted": true,
      "Rank": 413,
      "Type": "doloribus",
      "ColorBlock": 190,
      "IconHint": "voluptas",
      "Selected": true,
      "LastChanged": "2022-06-24T13:38:17.4836968+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veritatis",
      "StyleHint": "iusto",
      "Hidden": false,
      "FullName": "Ms. Mable Moen DVM"
    }
  ],
  "PersonNumber": "608035",
  "FullName": "Terrell Muller",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "eligendi",
      "StrippedValue": "architecto",
      "Description": "Ergonomic client-server hardware"
    },
    {
      "Value": "eligendi",
      "StrippedValue": "architecto",
      "Description": "Ergonomic client-server hardware"
    }
  ],
  "FormalName": "Wyman, Sipes and Aufderhar",
  "Address": null,
  "Post3": "iusto",
  "Post2": "esse",
  "Post1": "quam",
  "Kanalname": "nihil",
  "Kanafname": "cupiditate",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ipsa",
  "ActiveInterests": 563,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 427,
  "DbiKey": "facilis",
  "DbiLastModified": "2000-02-13T13:38:17.4836968+01:00",
  "DbiLastSyncronized": "2013-03-19T13:38:17.4836968+01:00",
  "SentInfo": 854,
  "ShowContactTickets": 429,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "harum",
      "StrippedValue": "aliquid",
      "Description": "Digitized background flexibility"
    },
    {
      "Value": "harum",
      "StrippedValue": "aliquid",
      "Description": "Digitized background flexibility"
    }
  ],
  "InternetPhones": [
    {
      "Value": "consectetur",
      "StrippedValue": "dolorem",
      "Description": "Public-key didactic interface"
    },
    {
      "Value": "consectetur",
      "StrippedValue": "dolorem",
      "Description": "Public-key didactic interface"
    }
  ],
  "Source": 184,
  "ActiveErpLinks": 882,
  "ShipmentTypes": [
    {
      "Id": 925,
      "Name": "Bailey, Howell and Vandervort",
      "ToolTip": "Ut quas et neque eos id aut qui.",
      "Deleted": false,
      "Rank": 947,
      "Type": "veritatis",
      "ColorBlock": 659,
      "IconHint": "sint",
      "Selected": false,
      "LastChanged": "2012-06-13T13:38:17.4836968+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "commodi",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Jaden Jacobson"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 884,
      "Comment": "omnis",
      "Registered": "2006-12-31T13:38:17.4836968+01:00",
      "RegisteredAssociateId": 358,
      "Updated": "2010-02-12T13:38:17.4836968+01:00",
      "UpdatedAssociateId": 873,
      "LegalBaseId": 86,
      "LegalBaseKey": "voluptatum",
      "LegalBaseName": "Williamson Group",
      "ConsentPurposeId": 296,
      "ConsentPurposeKey": "necessitatibus",
      "ConsentPurposeName": "Dibbert, Adams and Greenfelder",
      "ConsentSourceId": 480,
      "ConsentSourceKey": "assumenda",
      "ConsentSourceName": "Harvey, Greenfelder and Carter"
    }
  ],
  "BounceEmails": [
    "daren_kling@russel.name",
    "sadye@lebsackfahey.co.uk"
  ],
  "ActiveStatusMonitorId": 241,
  "UserDefinedFields": {
    "SuperOffice:1": "241505047",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "tempore"
  },
  "CustomFields": {
    "CustomFields1": "quod",
    "CustomFields2": "omnis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 51,
  "Firstname": "Edgar",
  "MiddleName": "McDermott, Metz and Harris",
  "Lastname": "Jacobs",
  "Mrmrs": "est",
  "Title": "ducimus",
  "UpdatedDate": "2012-03-12T13:38:17.4993159+01:00",
  "CreatedDate": "2008-01-22T13:38:17.4993159+01:00",
  "BirthDate": "2004-09-06T13:38:17.4993159+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "ab",
      "Description": "Innovative global migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 244
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "ab",
      "Description": "Innovative global migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 244
        }
      }
    }
  ],
  "Description": "Balanced client-server pricing structure",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "excepturi",
      "StrippedValue": "fuga",
      "Description": "Mandatory intangible throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 140
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "fuga",
      "Description": "Mandatory intangible throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 140
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "omnis",
      "StrippedValue": "porro",
      "Description": "Proactive stable portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 396
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "porro",
      "Description": "Proactive stable portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 396
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "modi",
      "StrippedValue": "voluptate",
      "Description": "Stand-alone well-modulated strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 601
        }
      }
    },
    {
      "Value": "modi",
      "StrippedValue": "voluptate",
      "Description": "Stand-alone well-modulated strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 601
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "minima",
      "StrippedValue": "vel",
      "Description": "Sharable zero administration extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 23
        }
      }
    },
    {
      "Value": "minima",
      "StrippedValue": "vel",
      "Description": "Sharable zero administration extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 23
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "architecto",
      "StrippedValue": "est",
      "Description": "Re-contextualized directional throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 290
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "est",
      "Description": "Re-contextualized directional throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 290
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
      "Id": 511,
      "Name": "Bergnaum Inc and Sons",
      "ToolTip": "Quibusdam et sunt.",
      "Deleted": true,
      "Rank": 330,
      "Type": "voluptatem",
      "ColorBlock": 192,
      "IconHint": "aliquid",
      "Selected": false,
      "LastChanged": "2021-04-08T13:38:17.4993159+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "asperiores",
      "StyleHint": "velit",
      "Hidden": false,
      "FullName": "Mr. Clifton Corwin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 177
        }
      }
    }
  ],
  "PersonNumber": "1298859",
  "FullName": "Mr. Edmond Esteban Greenfelder IV",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "architecto",
      "Description": "Customer-focused background monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 617
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "architecto",
      "Description": "Customer-focused background monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 617
        }
      }
    }
  ],
  "FormalName": "Eichmann, Larson and Rolfson",
  "Address": null,
  "Post3": "necessitatibus",
  "Post2": "architecto",
  "Post1": "quae",
  "Kanalname": "molestias",
  "Kanafname": "molestiae",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sit",
  "ActiveInterests": 236,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 453,
  "DbiKey": "dolores",
  "DbiLastModified": "2011-12-10T13:38:17.4993159+01:00",
  "DbiLastSyncronized": "2023-05-11T13:38:17.4993159+02:00",
  "SentInfo": 701,
  "ShowContactTickets": 421,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "accusantium",
      "StrippedValue": "quo",
      "Description": "Innovative didactic support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 921
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "quo",
      "Description": "Innovative didactic support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 921
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "nihil",
      "StrippedValue": "et",
      "Description": "Object-based empowering contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "et",
      "Description": "Object-based empowering contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    }
  ],
  "Source": 541,
  "ActiveErpLinks": 441,
  "ShipmentTypes": [
    {
      "Id": 969,
      "Name": "Windler, Oberbrunner and Lowe",
      "ToolTip": "Temporibus ut nesciunt dicta.",
      "Deleted": false,
      "Rank": 526,
      "Type": "nihil",
      "ColorBlock": 37,
      "IconHint": "aliquid",
      "Selected": false,
      "LastChanged": "2005-02-27T13:38:17.4993159+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "neque",
      "StyleHint": "autem",
      "Hidden": false,
      "FullName": "Prof. Margarette Prohaska DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 289
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 257,
      "Comment": "veritatis",
      "Registered": "2009-11-21T13:38:17.4993159+01:00",
      "RegisteredAssociateId": 223,
      "Updated": "1998-02-28T13:38:17.4993159+01:00",
      "UpdatedAssociateId": 890,
      "LegalBaseId": 1000,
      "LegalBaseKey": "voluptas",
      "LegalBaseName": "Kiehn Group",
      "ConsentPurposeId": 604,
      "ConsentPurposeKey": "dolorem",
      "ConsentPurposeName": "Schamberger Group",
      "ConsentSourceId": 430,
      "ConsentSourceKey": "aut",
      "ConsentSourceName": "Walsh-Schneider",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 825
        }
      }
    }
  ],
  "BounceEmails": [
    "dahlia@langworthkemmer.us",
    "jason_rohan@veumleannon.biz"
  ],
  "ActiveStatusMonitorId": 514,
  "UserDefinedFields": {
    "SuperOffice:1": "1368415825",
    "SuperOffice:2": "Demario Hudson"
  },
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "voluptates",
    "CustomFields2": "suscipit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 791
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```