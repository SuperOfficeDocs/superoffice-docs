---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
---

# POST Agents/Person/SavePersonEntity

```http
POST /api/v1/Agents/Person/SavePersonEntity
```

Updates the existing PersonEntity or creates a new PersonEntity if the id parameter is empty








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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 318,
  "Firstname": "Tavares",
  "MiddleName": "O'Connell-Connelly",
  "Lastname": "Muller",
  "Mrmrs": "eaque",
  "Title": "aliquid",
  "UpdatedDate": "1997-11-10T12:15:19.4227453+01:00",
  "CreatedDate": "1996-09-10T12:15:19.4227453+02:00",
  "BirthDate": "2004-06-22T12:15:19.4227453+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ab",
      "StrippedValue": "quam",
      "Description": "Enterprise-wide solution-oriented internet solution"
    },
    {
      "Value": "ab",
      "StrippedValue": "quam",
      "Description": "Enterprise-wide solution-oriented internet solution"
    }
  ],
  "Description": "Team-oriented demand-driven time-frame",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "aspernatur",
      "StrippedValue": "deserunt",
      "Description": "Virtual 5th generation focus group"
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "deserunt",
      "Description": "Virtual 5th generation focus group"
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "rem",
      "Description": "Assimilated directional Graphic Interface"
    },
    {
      "Value": "ut",
      "StrippedValue": "rem",
      "Description": "Assimilated directional Graphic Interface"
    }
  ],
  "MobilePhones": [
    {
      "Value": "atque",
      "StrippedValue": "expedita",
      "Description": "Sharable directional open system"
    },
    {
      "Value": "atque",
      "StrippedValue": "expedita",
      "Description": "Sharable directional open system"
    }
  ],
  "OfficePhones": [
    {
      "Value": "in",
      "StrippedValue": "non",
      "Description": "Multi-tiered tangible implementation"
    },
    {
      "Value": "in",
      "StrippedValue": "non",
      "Description": "Multi-tiered tangible implementation"
    }
  ],
  "OtherPhones": [
    {
      "Value": "iure",
      "StrippedValue": "est",
      "Description": "Adaptive motivating conglomeration"
    },
    {
      "Value": "iure",
      "StrippedValue": "est",
      "Description": "Adaptive motivating conglomeration"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 184,
      "Name": "Terry-Mohr",
      "ToolTip": "Repellendus vitae neque laboriosam ratione.",
      "Deleted": false,
      "Rank": 800,
      "Type": "dolore",
      "ColorBlock": 637,
      "IconHint": "quibusdam",
      "Selected": false,
      "LastChanged": "2019-06-14T12:15:19.426745+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "est",
      "Hidden": false,
      "FullName": "Erica Ondricka"
    }
  ],
  "PersonNumber": "381837",
  "FullName": "Keaton Witting",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "dicta",
      "Description": "Secured contextually-based matrices"
    },
    {
      "Value": "sed",
      "StrippedValue": "dicta",
      "Description": "Secured contextually-based matrices"
    }
  ],
  "FormalName": "Kautzer LLC",
  "Address": null,
  "Post3": "est",
  "Post2": "voluptates",
  "Post1": "ut",
  "Kanalname": "nemo",
  "Kanafname": "tempore",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "rerum",
  "ActiveInterests": 697,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 379,
  "DbiKey": "fugiat",
  "DbiLastModified": "2012-01-31T12:15:19.4287447+01:00",
  "DbiLastSyncronized": "2019-12-06T12:15:19.4287447+01:00",
  "SentInfo": 706,
  "ShowContactTickets": 870,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "esse",
      "Description": "Enterprise-wide full-range approach"
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "esse",
      "Description": "Enterprise-wide full-range approach"
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptate",
      "StrippedValue": "voluptas",
      "Description": "Down-sized systemic synergy"
    },
    {
      "Value": "voluptate",
      "StrippedValue": "voluptas",
      "Description": "Down-sized systemic synergy"
    }
  ],
  "Source": 955,
  "ActiveErpLinks": 512,
  "ShipmentTypes": [
    {
      "Id": 426,
      "Name": "Glover, Beatty and Padberg",
      "ToolTip": "Nobis est dolorem id.",
      "Deleted": true,
      "Rank": 216,
      "Type": "quos",
      "ColorBlock": 258,
      "IconHint": "non",
      "Selected": true,
      "LastChanged": "2000-07-25T12:15:19.4287447+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "voluptas",
      "Hidden": false,
      "FullName": "Reagan Von"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 323,
      "Comment": "et",
      "Registered": "2008-03-08T12:15:19.429745+01:00",
      "RegisteredAssociateId": 181,
      "Updated": "2009-05-06T12:15:19.429745+02:00",
      "UpdatedAssociateId": 119,
      "LegalBaseId": 426,
      "LegalBaseKey": "est",
      "LegalBaseName": "Friesen Inc and Sons",
      "ConsentPurposeId": 311,
      "ConsentPurposeKey": "voluptatum",
      "ConsentPurposeName": "Marvin Inc and Sons",
      "ConsentSourceId": 23,
      "ConsentSourceKey": "officiis",
      "ConsentSourceName": "Spinka, Hettinger and Mertz"
    }
  ],
  "BounceEmails": [
    "althea@stracke.co.uk",
    "jude@murray.com"
  ],
  "ActiveStatusMonitorId": 342,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Breana Bauch"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "soluta",
    "CustomFields2": "ut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 904,
  "Firstname": "Lionel",
  "MiddleName": "Jakubowski-Hayes",
  "Lastname": "Cassin",
  "Mrmrs": "ullam",
  "Title": "tenetur",
  "UpdatedDate": "2001-02-09T12:15:19.4387461+01:00",
  "CreatedDate": "1995-10-15T12:15:19.4387461+02:00",
  "BirthDate": "2008-04-12T12:15:19.4387461+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "dolores",
      "Description": "Configurable mobile concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 185
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "dolores",
      "Description": "Configurable mobile concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 185
        }
      }
    }
  ],
  "Description": "Multi-layered leading edge throughput",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "fugiat",
      "StrippedValue": "soluta",
      "Description": "Synergized reciprocal product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 328
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "soluta",
      "Description": "Synergized reciprocal product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 328
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "officia",
      "Description": "Mandatory encompassing ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 944
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "officia",
      "Description": "Mandatory encompassing ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 944
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "voluptate",
      "StrippedValue": "culpa",
      "Description": "Adaptive reciprocal intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 256
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "culpa",
      "Description": "Adaptive reciprocal intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 256
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "possimus",
      "StrippedValue": "reiciendis",
      "Description": "Enterprise-wide clear-thinking complexity",
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
      "Value": "possimus",
      "StrippedValue": "reiciendis",
      "Description": "Enterprise-wide clear-thinking complexity",
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
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "provident",
      "Description": "Universal composite adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 873
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "provident",
      "Description": "Universal composite adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 873
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
      "Id": 651,
      "Name": "Bernhard, Turcotte and Robel",
      "ToolTip": "Eos et ut optio et.",
      "Deleted": false,
      "Rank": 635,
      "Type": "aliquid",
      "ColorBlock": 229,
      "IconHint": "iure",
      "Selected": false,
      "LastChanged": "2001-12-11T12:15:19.4417461+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "possimus",
      "StyleHint": "nemo",
      "Hidden": false,
      "FullName": "Peggie Price",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 694
        }
      }
    }
  ],
  "PersonNumber": "300643",
  "FullName": "Cayla Miller PhD",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "et",
      "Description": "Intuitive cohesive interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 107
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "et",
      "Description": "Intuitive cohesive interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 107
        }
      }
    }
  ],
  "FormalName": "Stroman-Johnson",
  "Address": null,
  "Post3": "sed",
  "Post2": "eos",
  "Post1": "laboriosam",
  "Kanalname": "quidem",
  "Kanafname": "fugiat",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "sed",
  "ActiveInterests": 36,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 247,
  "DbiKey": "saepe",
  "DbiLastModified": "2001-06-19T12:15:19.4447446+02:00",
  "DbiLastSyncronized": "1996-04-15T12:15:19.4447446+02:00",
  "SentInfo": 503,
  "ShowContactTickets": 109,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "suscipit",
      "StrippedValue": "ut",
      "Description": "Versatile analyzing hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 848
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "ut",
      "Description": "Versatile analyzing hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 848
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "sequi",
      "StrippedValue": "et",
      "Description": "Customizable disintermediate capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 447
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "et",
      "Description": "Customizable disintermediate capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 447
        }
      }
    }
  ],
  "Source": 327,
  "ActiveErpLinks": 181,
  "ShipmentTypes": [
    {
      "Id": 690,
      "Name": "Fritsch Inc and Sons",
      "ToolTip": "Porro natus qui rem alias.",
      "Deleted": true,
      "Rank": 708,
      "Type": "ratione",
      "ColorBlock": 355,
      "IconHint": "aut",
      "Selected": true,
      "LastChanged": "2015-02-24T12:15:19.4447446+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laboriosam",
      "StyleHint": "illum",
      "Hidden": true,
      "FullName": "Ms. Alexandria Hannah Kutch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 202
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 341,
      "Comment": "maiores",
      "Registered": "1997-10-20T12:15:19.4457449+02:00",
      "RegisteredAssociateId": 637,
      "Updated": "2020-04-08T12:15:19.4457449+02:00",
      "UpdatedAssociateId": 464,
      "LegalBaseId": 458,
      "LegalBaseKey": "error",
      "LegalBaseName": "Pfannerstill Inc and Sons",
      "ConsentPurposeId": 706,
      "ConsentPurposeKey": "repellendus",
      "ConsentPurposeName": "Bergnaum, Schroeder and Littel",
      "ConsentSourceId": 805,
      "ConsentSourceKey": "voluptatum",
      "ConsentSourceName": "Witting, Ferry and Stark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 607
        }
      }
    }
  ],
  "BounceEmails": [
    "nikko@swift.ca",
    "francisco_cronin@wolfhowell.uk"
  ],
  "ActiveStatusMonitorId": 825,
  "UserDefinedFields": {
    "SuperOffice:1": "Laurianne Welch",
    "SuperOffice:2": "Samantha Wolff"
  },
  "ExtraFields": {
    "ExtraFields1": "impedit",
    "ExtraFields2": "a"
  },
  "CustomFields": {
    "CustomFields1": "repudiandae",
    "CustomFields2": "aspernatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 213
    }
  }
}
```