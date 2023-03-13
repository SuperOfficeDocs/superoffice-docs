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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 30,
  "Firstname": "Edythe",
  "MiddleName": "Balistreri, Buckridge and Funk",
  "Lastname": "Marvin",
  "Mrmrs": "autem",
  "Title": "qui",
  "UpdatedDate": "1996-04-14T12:15:27.0456344+02:00",
  "CreatedDate": "2002-08-16T12:15:27.0456344+02:00",
  "BirthDate": "2004-09-17T12:15:27.0456344+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "recusandae",
      "StrippedValue": "dolorem",
      "Description": "Centralized exuding focus group"
    },
    {
      "Value": "recusandae",
      "StrippedValue": "dolorem",
      "Description": "Centralized exuding focus group"
    }
  ],
  "Description": "Synchronised local open system",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "dolor",
      "StrippedValue": "quas",
      "Description": "Optimized impactful access"
    },
    {
      "Value": "dolor",
      "StrippedValue": "quas",
      "Description": "Optimized impactful access"
    }
  ],
  "Faxes": [
    {
      "Value": "repudiandae",
      "StrippedValue": "consequatur",
      "Description": "Profound human-resource ability"
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "consequatur",
      "Description": "Profound human-resource ability"
    }
  ],
  "MobilePhones": [
    {
      "Value": "accusantium",
      "StrippedValue": "dignissimos",
      "Description": "Fully-configurable attitude-oriented support"
    },
    {
      "Value": "accusantium",
      "StrippedValue": "dignissimos",
      "Description": "Fully-configurable attitude-oriented support"
    }
  ],
  "OfficePhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "in",
      "Description": "Enhanced cohesive access"
    },
    {
      "Value": "dolorem",
      "StrippedValue": "in",
      "Description": "Enhanced cohesive access"
    }
  ],
  "OtherPhones": [
    {
      "Value": "eos",
      "StrippedValue": "in",
      "Description": "Integrated stable capability"
    },
    {
      "Value": "eos",
      "StrippedValue": "in",
      "Description": "Integrated stable capability"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 103,
      "Name": "Abshire LLC",
      "ToolTip": "Et laborum facere labore.",
      "Deleted": false,
      "Rank": 606,
      "Type": "error",
      "ColorBlock": 297,
      "IconHint": "perferendis",
      "Selected": false,
      "LastChanged": "2003-03-11T12:15:27.0486343+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "ea",
      "Hidden": false,
      "FullName": "Damon Kunde"
    }
  ],
  "PersonNumber": "919625",
  "FullName": "Lilian Hayes",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "incidunt",
      "StrippedValue": "dolores",
      "Description": "Extended systematic alliance"
    },
    {
      "Value": "incidunt",
      "StrippedValue": "dolores",
      "Description": "Extended systematic alliance"
    }
  ],
  "FormalName": "Sauer, Huel and Schinner",
  "Address": null,
  "Post3": "maxime",
  "Post2": "debitis",
  "Post1": "mollitia",
  "Kanalname": "aperiam",
  "Kanafname": "aliquid",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "eos",
  "ActiveInterests": 626,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 93,
  "DbiKey": "qui",
  "DbiLastModified": "1999-10-07T12:15:27.0516378+02:00",
  "DbiLastSyncronized": "2005-06-05T12:15:27.0516378+02:00",
  "SentInfo": 347,
  "ShowContactTickets": 469,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "vero",
      "StrippedValue": "laudantium",
      "Description": "Mandatory optimal protocol"
    },
    {
      "Value": "vero",
      "StrippedValue": "laudantium",
      "Description": "Mandatory optimal protocol"
    }
  ],
  "InternetPhones": [
    {
      "Value": "possimus",
      "StrippedValue": "fugiat",
      "Description": "Centralized hybrid info-mediaries"
    },
    {
      "Value": "possimus",
      "StrippedValue": "fugiat",
      "Description": "Centralized hybrid info-mediaries"
    }
  ],
  "Source": 960,
  "ActiveErpLinks": 415,
  "ShipmentTypes": [
    {
      "Id": 447,
      "Name": "Kuhic-Blanda",
      "ToolTip": "Commodi omnis ullam odit laboriosam ipsa sit.",
      "Deleted": false,
      "Rank": 804,
      "Type": "itaque",
      "ColorBlock": 744,
      "IconHint": "similique",
      "Selected": false,
      "LastChanged": "2007-07-13T12:15:27.0516378+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "modi",
      "StyleHint": "sunt",
      "Hidden": true,
      "FullName": "Kay Pacocha"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 263,
      "Comment": "ad",
      "Registered": "2018-12-23T12:15:27.0516378+01:00",
      "RegisteredAssociateId": 728,
      "Updated": "1998-08-27T12:15:27.0516378+02:00",
      "UpdatedAssociateId": 361,
      "LegalBaseId": 335,
      "LegalBaseKey": "sint",
      "LegalBaseName": "Kozey-Dibbert",
      "ConsentPurposeId": 985,
      "ConsentPurposeKey": "voluptas",
      "ConsentPurposeName": "Pacocha, Emard and Gleason",
      "ConsentSourceId": 621,
      "ConsentSourceKey": "et",
      "ConsentSourceName": "Doyle-Braun"
    }
  ],
  "BounceEmails": [
    "gabe@kemmer.name",
    "linwood@kassulke.uk"
  ],
  "ActiveStatusMonitorId": 445,
  "UserDefinedFields": {
    "SuperOffice:1": "1998677083",
    "SuperOffice:2": "Shemar Hirthe"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "repudiandae"
  },
  "CustomFields": {
    "CustomFields1": "nulla",
    "CustomFields2": "eius"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 650,
  "Firstname": "Jennyfer",
  "MiddleName": "Wehner-Breitenberg",
  "Lastname": "Borer",
  "Mrmrs": "quo",
  "Title": "sapiente",
  "UpdatedDate": "2008-01-06T12:15:27.0616341+01:00",
  "CreatedDate": "2016-03-10T12:15:27.0616341+01:00",
  "BirthDate": "1995-10-15T12:15:27.0616341+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "officia",
      "StrippedValue": "enim",
      "Description": "Robust object-oriented help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 179
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "enim",
      "Description": "Robust object-oriented help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 179
        }
      }
    }
  ],
  "Description": "Innovative bi-directional definition",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quidem",
      "StrippedValue": "id",
      "Description": "Balanced assymetric Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 913
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "id",
      "Description": "Balanced assymetric Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 913
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aperiam",
      "StrippedValue": "sapiente",
      "Description": "Implemented 24 hour Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 298
        }
      }
    },
    {
      "Value": "aperiam",
      "StrippedValue": "sapiente",
      "Description": "Implemented 24 hour Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 298
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "qui",
      "StrippedValue": "dolor",
      "Description": "Compatible fault-tolerant knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 505
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "dolor",
      "Description": "Compatible fault-tolerant knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 505
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "molestiae",
      "Description": "Up-sized foreground initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "molestiae",
      "Description": "Up-sized foreground initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "praesentium",
      "StrippedValue": "magni",
      "Description": "Object-based directional groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 343
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "magni",
      "Description": "Object-based directional groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 343
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
      "Id": 739,
      "Name": "Wisozk, Franecki and Mueller",
      "ToolTip": "Corrupti ut harum cupiditate labore adipisci corporis excepturi.",
      "Deleted": false,
      "Rank": 873,
      "Type": "qui",
      "ColorBlock": 122,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2002-12-01T12:15:27.0636339+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ab",
      "StyleHint": "iure",
      "Hidden": false,
      "FullName": "Else Towne IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 493
        }
      }
    }
  ],
  "PersonNumber": "663218",
  "FullName": "Elinor Weissnat",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "illo",
      "StrippedValue": "eos",
      "Description": "Team-oriented composite application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "eos",
      "Description": "Team-oriented composite application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    }
  ],
  "FormalName": "Boehm Inc and Sons",
  "Address": null,
  "Post3": "dolorem",
  "Post2": "beatae",
  "Post1": "debitis",
  "Kanalname": "eum",
  "Kanafname": "eveniet",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "assumenda",
  "ActiveInterests": 55,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 983,
  "DbiKey": "et",
  "DbiLastModified": "1997-05-04T12:15:27.0666342+02:00",
  "DbiLastSyncronized": "2011-09-08T12:15:27.0666342+02:00",
  "SentInfo": 3,
  "ShowContactTickets": 646,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "et",
      "StrippedValue": "error",
      "Description": "Upgradable regional framework",
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
      "Value": "et",
      "StrippedValue": "error",
      "Description": "Upgradable regional framework",
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
  "InternetPhones": [
    {
      "Value": "ut",
      "StrippedValue": "iure",
      "Description": "Enterprise-wide multi-tasking knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 934
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "iure",
      "Description": "Enterprise-wide multi-tasking knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 934
        }
      }
    }
  ],
  "Source": 457,
  "ActiveErpLinks": 480,
  "ShipmentTypes": [
    {
      "Id": 183,
      "Name": "Upton, Reichel and Kilback",
      "ToolTip": "Deserunt dolorem voluptas eligendi consequatur quo et.",
      "Deleted": false,
      "Rank": 348,
      "Type": "eos",
      "ColorBlock": 301,
      "IconHint": "vel",
      "Selected": false,
      "LastChanged": "2022-12-15T12:15:27.0666342+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "nihil",
      "Hidden": false,
      "FullName": "Destiney Hayes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 980
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 112,
      "Comment": "quia",
      "Registered": "2013-08-19T12:15:27.0676371+02:00",
      "RegisteredAssociateId": 148,
      "Updated": "2009-12-05T12:15:27.0676371+01:00",
      "UpdatedAssociateId": 413,
      "LegalBaseId": 810,
      "LegalBaseKey": "non",
      "LegalBaseName": "Gaylord Inc and Sons",
      "ConsentPurposeId": 144,
      "ConsentPurposeKey": "officia",
      "ConsentPurposeName": "Johns-Adams",
      "ConsentSourceId": 194,
      "ConsentSourceKey": "praesentium",
      "ConsentSourceName": "Hartmann-DuBuque",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    }
  ],
  "BounceEmails": [
    "fausto@halvorsonkiehn.info",
    "lydia.hartmann@casper.uk"
  ],
  "ActiveStatusMonitorId": 686,
  "UserDefinedFields": {
    "SuperOffice:1": "Werner Bernhard",
    "SuperOffice:2": "Jacques Little DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "cumque",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "molestiae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 532
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```