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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 470,
  "Firstname": "Concepcion",
  "MiddleName": "Mitchell, Bashirian and Kreiger",
  "Lastname": "Block",
  "Mrmrs": "atque",
  "Title": "quam",
  "UpdatedDate": "2017-04-07T16:32:47.61831+02:00",
  "CreatedDate": "2007-08-23T16:32:47.61831+02:00",
  "BirthDate": "2020-08-23T16:32:47.61831+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "fugit",
      "StrippedValue": "possimus",
      "Description": "Monitored fault-tolerant concept"
    },
    {
      "Value": "fugit",
      "StrippedValue": "possimus",
      "Description": "Monitored fault-tolerant concept"
    }
  ],
  "Description": "Multi-tiered leading edge archive",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "sequi",
      "StrippedValue": "doloremque",
      "Description": "Open-architected composite projection"
    },
    {
      "Value": "sequi",
      "StrippedValue": "doloremque",
      "Description": "Open-architected composite projection"
    }
  ],
  "Faxes": [
    {
      "Value": "architecto",
      "StrippedValue": "excepturi",
      "Description": "Customizable tangible middleware"
    },
    {
      "Value": "architecto",
      "StrippedValue": "excepturi",
      "Description": "Customizable tangible middleware"
    }
  ],
  "MobilePhones": [
    {
      "Value": "distinctio",
      "StrippedValue": "necessitatibus",
      "Description": "Phased user-facing neural-net"
    },
    {
      "Value": "distinctio",
      "StrippedValue": "necessitatibus",
      "Description": "Phased user-facing neural-net"
    }
  ],
  "OfficePhones": [
    {
      "Value": "ut",
      "StrippedValue": "dolores",
      "Description": "Inverse transitional concept"
    },
    {
      "Value": "ut",
      "StrippedValue": "dolores",
      "Description": "Inverse transitional concept"
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "fugit",
      "Description": "Integrated bottom-line archive"
    },
    {
      "Value": "et",
      "StrippedValue": "fugit",
      "Description": "Integrated bottom-line archive"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 715,
      "Name": "Schiller-Blanda",
      "ToolTip": "Qui dicta occaecati aspernatur deserunt.",
      "Deleted": true,
      "Rank": 5,
      "Type": "numquam",
      "ColorBlock": 286,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2022-11-19T16:32:47.61831+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Miss Mariana Parker DVM"
    }
  ],
  "PersonNumber": "929297",
  "FullName": "Ike Danielle Hettinger III",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "deserunt",
      "StrippedValue": "et",
      "Description": "Front-line systemic superstructure"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "et",
      "Description": "Front-line systemic superstructure"
    }
  ],
  "FormalName": "Emmerich LLC",
  "Address": null,
  "Post3": "rem",
  "Post2": "corrupti",
  "Post1": "tempora",
  "Kanalname": "et",
  "Kanafname": "dolor",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "aut",
  "ActiveInterests": 826,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 361,
  "DbiKey": "qui",
  "DbiLastModified": "2000-12-19T16:32:47.61831+01:00",
  "DbiLastSyncronized": "2006-07-10T16:32:47.61831+02:00",
  "SentInfo": 33,
  "ShowContactTickets": 942,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ea",
      "StrippedValue": "officiis",
      "Description": "Enterprise-wide zero administration standardization"
    },
    {
      "Value": "ea",
      "StrippedValue": "officiis",
      "Description": "Enterprise-wide zero administration standardization"
    }
  ],
  "InternetPhones": [
    {
      "Value": "non",
      "StrippedValue": "impedit",
      "Description": "Realigned tangible challenge"
    },
    {
      "Value": "non",
      "StrippedValue": "impedit",
      "Description": "Realigned tangible challenge"
    }
  ],
  "Source": 384,
  "ActiveErpLinks": 452,
  "ShipmentTypes": [
    {
      "Id": 291,
      "Name": "Ledner Inc and Sons",
      "ToolTip": "Modi distinctio dolorum provident eos tempore sint.",
      "Deleted": true,
      "Rank": 916,
      "Type": "expedita",
      "ColorBlock": 435,
      "IconHint": "ullam",
      "Selected": true,
      "LastChanged": "2001-07-20T16:32:47.61831+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "pariatur",
      "Hidden": true,
      "FullName": "Laron Romaguera"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 310,
      "Comment": "aliquid",
      "Registered": "2010-02-13T16:32:47.61831+01:00",
      "RegisteredAssociateId": 636,
      "Updated": "2024-06-28T16:32:47.61831+02:00",
      "UpdatedAssociateId": 552,
      "LegalBaseId": 633,
      "LegalBaseKey": "unde",
      "LegalBaseName": "Becker, Adams and Metz",
      "ConsentPurposeId": 778,
      "ConsentPurposeKey": "laudantium",
      "ConsentPurposeName": "Stracke-Bruen",
      "ConsentSourceId": 528,
      "ConsentSourceKey": "nulla",
      "ConsentSourceName": "Hayes, Harber and Walter"
    }
  ],
  "BounceEmails": [
    "jody_casper@toy.com",
    "andreane.gislason@bruen.info"
  ],
  "ActiveStatusMonitorId": 764,
  "CreatedByFormId": 139,
  "UserDefinedFields": {
    "SuperOffice:1": "Adah Veum",
    "SuperOffice:2": "Allene O'Kon"
  },
  "ExtraFields": {
    "ExtraFields1": "quibusdam",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "ad",
    "CustomFields2": "sit"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 341,
  "Firstname": "Cleve",
  "MiddleName": "Schneider, Hamill and O'Kon",
  "Lastname": "Hackett",
  "Mrmrs": "voluptas",
  "Title": "rerum",
  "UpdatedDate": "2000-11-26T16:32:47.6339314+01:00",
  "CreatedDate": "2023-08-07T16:32:47.6339314+02:00",
  "BirthDate": "2019-11-14T16:32:47.6339314+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "veritatis",
      "StrippedValue": "non",
      "Description": "Public-key user-facing approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 25
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "non",
      "Description": "Public-key user-facing approach",
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
  "Description": "Open-source logistical knowledge base",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "nemo",
      "StrippedValue": "qui",
      "Description": "Upgradable solution-oriented challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 393
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "qui",
      "Description": "Upgradable solution-oriented challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 393
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eaque",
      "StrippedValue": "nobis",
      "Description": "Virtual encompassing algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 874
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "nobis",
      "Description": "Virtual encompassing algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 874
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "corrupti",
      "StrippedValue": "exercitationem",
      "Description": "Programmable intermediate contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 335
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "exercitationem",
      "Description": "Programmable intermediate contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 335
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "aut",
      "StrippedValue": "unde",
      "Description": "Ergonomic multi-state leverage",
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
      "Value": "aut",
      "StrippedValue": "unde",
      "Description": "Ergonomic multi-state leverage",
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
  "OtherPhones": [
    {
      "Value": "officia",
      "StrippedValue": "voluptatem",
      "Description": "Integrated upward-trending productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 795
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "voluptatem",
      "Description": "Integrated upward-trending productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 795
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
      "Id": 331,
      "Name": "Wiza Inc and Sons",
      "ToolTip": "Nesciunt vitae perferendis voluptas quis illum.",
      "Deleted": true,
      "Rank": 210,
      "Type": "recusandae",
      "ColorBlock": 136,
      "IconHint": "quaerat",
      "Selected": false,
      "LastChanged": "2021-09-17T16:32:47.6339314+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aliquid",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Webster Purdy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 312
        }
      }
    }
  ],
  "PersonNumber": "1219771",
  "FullName": "Ms. Haven Milton Borer Jr.",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "soluta",
      "StrippedValue": "eligendi",
      "Description": "Decentralized client-server solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    },
    {
      "Value": "soluta",
      "StrippedValue": "eligendi",
      "Description": "Decentralized client-server solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    }
  ],
  "FormalName": "Runolfsdottir-Haag",
  "Address": null,
  "Post3": "quod",
  "Post2": "velit",
  "Post1": "qui",
  "Kanalname": "accusantium",
  "Kanafname": "repellat",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "amet",
  "ActiveInterests": 751,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 145,
  "DbiKey": "tempore",
  "DbiLastModified": "2004-01-12T16:32:47.6339314+01:00",
  "DbiLastSyncronized": "2014-04-21T16:32:47.6339314+02:00",
  "SentInfo": 549,
  "ShowContactTickets": 713,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "laboriosam",
      "StrippedValue": "assumenda",
      "Description": "Universal composite function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 486
        }
      }
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "assumenda",
      "Description": "Universal composite function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 486
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptates",
      "StrippedValue": "libero",
      "Description": "Front-line human-resource moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 936
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "libero",
      "Description": "Front-line human-resource moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 936
        }
      }
    }
  ],
  "Source": 36,
  "ActiveErpLinks": 815,
  "ShipmentTypes": [
    {
      "Id": 818,
      "Name": "Walter, Sawayn and Lowe",
      "ToolTip": "Fuga amet alias maxime labore.",
      "Deleted": true,
      "Rank": 411,
      "Type": "et",
      "ColorBlock": 960,
      "IconHint": "sequi",
      "Selected": false,
      "LastChanged": "2007-02-03T16:32:47.6339314+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veniam",
      "StyleHint": "iure",
      "Hidden": true,
      "FullName": "Clemens Stiedemann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 623
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 6,
      "Comment": "reiciendis",
      "Registered": "2001-09-10T16:32:47.6339314+02:00",
      "RegisteredAssociateId": 990,
      "Updated": "2016-11-07T16:32:47.6339314+01:00",
      "UpdatedAssociateId": 103,
      "LegalBaseId": 862,
      "LegalBaseKey": "dignissimos",
      "LegalBaseName": "Schamberger, Padberg and Stamm",
      "ConsentPurposeId": 116,
      "ConsentPurposeKey": "ut",
      "ConsentPurposeName": "McDermott Group",
      "ConsentSourceId": 58,
      "ConsentSourceKey": "recusandae",
      "ConsentSourceName": "Barrows, Wisoky and Huel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 961
        }
      }
    }
  ],
  "BounceEmails": [
    "jayce@abshirehirthe.us",
    "natalia@spencer.uk"
  ],
  "ActiveStatusMonitorId": 476,
  "CreatedByFormId": 40,
  "UserDefinedFields": {
    "SuperOffice:1": "Emile Ryan",
    "SuperOffice:2": "1947858213"
  },
  "ExtraFields": {
    "ExtraFields1": "odit",
    "ExtraFields2": "provident"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "sequi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 92
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```